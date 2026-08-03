# -*- coding: utf-8 -*-
import joblib
import pandas as pd

from pathlib import Path

from sklearn.metrics import accuracy_score
from sklearn.metrics import classification_report
from sklearn.metrics import confusion_matrix

from sklearn.model_selection import train_test_split
from sklearn.preprocessing import LabelEncoder

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

model = joblib.load(Path(__file__).parent / "models" / "fraud_model.pkl")

predictions = model.predict(X_test)

print()

print("Accuracy")

print(accuracy_score(y_test, predictions))

print()

print(classification_report(y_test, predictions))

print()

print(confusion_matrix(y_test, predictions))
