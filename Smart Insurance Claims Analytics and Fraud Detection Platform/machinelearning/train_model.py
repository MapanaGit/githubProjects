# -*- coding: utf-8 -*-
import pandas as pd
import joblib

from pathlib import Path

from sklearn.model_selection import train_test_split
from sklearn.preprocessing import LabelEncoder
from sklearn.ensemble import RandomForestClassifier

dataset = Path(__file__).parent / "datasets" / "fraud_dataset.csv"

df = pd.read_csv(dataset)

encoder = LabelEncoder()

df["PolicyType"] = encoder.fit_transform(df["PolicyType"])

df["ClaimStatus"] = encoder.fit_transform(df["ClaimStatus"])

df["Fraud"] = encoder.fit_transform(df["Fraud"])

X = df.drop(columns=["Fraud"])

y = df["Fraud"]

X_train, X_test, y_train, y_test = train_test_split(
    X,
    y,
    test_size=0.20,
    random_state=42
)

model = RandomForestClassifier(
    n_estimators=200,
    random_state=42
)

model.fit(X_train, y_train)

models = Path(__file__).parent / "models"
models.mkdir(exist_ok=True)

joblib.dump(model, models / "fraud_model.pkl")

print("Model Trained Successfully")
