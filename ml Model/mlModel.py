from flask import Flask, request, jsonify
import pandas as pd
import requests
from sklearn.linear_model import LinearRegression
import numpy as np

app = Flask(__name__)

def get_historical_data(symbol, interval="1h", limit=100):
    url = f"https://api.binance.com/api/v3/klines"
    params = {"symbol": symbol, "interval": interval, "limit": limit}
    response = requests.get(url, params=params)

    if response.status_code == 200:
        data = response.json()
        df = pd.DataFrame(data, columns=[
            'Open Time', 'Open', 'High', 'Low', 'Close', 'Volume',
            'Close Time', 'Quote Asset Volume', 'Number of Trades',
            'Taker Buy Base Volume', 'Taker Buy Quote Volume', 'Ignore'
        ])
        df = df[['Open Time', 'Close']]
        df['Open Time'] = pd.to_datetime(df['Open Time'], unit='ms')
        df['Close'] = df['Close'].astype(float)
        return df
    else:
        return None

def train_model(df):
    X = np.arange(len(df)).reshape(-1, 1)
    Y = df['Close'].values
    model = LinearRegression()
    model.fit(X, Y)
    return model

def predict_next_hour(model, df):
    next_hour = len(df)
    prediction = model.predict(np.array([[next_hour]]))
    return prediction[0]

@app.route('/')
def home():
    return "SmartTrade AI Flask API is Running!"

@app.route('/get_data', methods=['GET'])
def get_data():
    symbol = request.args.get('symbol')
    if not symbol:
        return jsonify({"error": "Symbol is required"}), 400

    df = get_historical_data(symbol)
    if df is not None:
        result = df.to_dict(orient='records')
        return jsonify(result)
    else:
        return jsonify({"error": "Failed to fetch data"}), 500

@app.route('/get_prediction', methods=['GET'])
def get_prediction():
    symbol = request.args.get('symbol')
    if not symbol:
        return jsonify({"error": "Symbol is required"}), 400

    df = get_historical_data(symbol)
    if df is not None:
        model = train_model(df)
        prediction = predict_next_hour(model, df)
        return jsonify({"symbol": symbol, "prediction": round(prediction, 2)})
    else:
        return jsonify({"error": "Failed to fetch data"}), 500

if __name__ == '__main__':
    app.run(debug=True)