# -*- coding: utf-8 -*-
import joblib
import pandas as pd

from pathlib import Path

model = joblib.load(Path(__file__).parent / "models" / "fraud_model.pkl")

claim = pd.DataFrame({

    "ClaimID":[9999],
    "PolicyID":[101],
    "CustomerID":[25],
    "PolicyType":[1],
    "CoverAmount":[500000],
    "ClaimAmount":[90000],
    "PaymentAmount":[90000],
    "FraudScore":[95],
    "NumberOfItems":[6],
    "ClaimStatus":[0]

})

prediction = model.predict(claim)

print()

print("Prediction")

print("YES" if prediction[0] == 1 else "NO")
