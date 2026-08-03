# -*- coding: utf-8 -*-
import pandas as pd
from database import get_connection

def load_table(table_name):
    """
    load SQL server table into a pandas dataframe
    """
    conn = get_connection()
    query = f"select * from {table_name}"
    
    df = pd.read_sql(query, conn)
    conn.close()
    
    return df

# Load tables
customers = load_table("customers")
policies = load_table("policies")
claims = load_table("claims")
claimitems = load_table("claimitems")
payments = load_table("payments")
claimstatus = load_table("claimstatus")
fraudscores = load_table("fraudscores")
users = load_table("users")
auditlog = load_table("auditlog")


# Display information
tables = {
    "Customers": customers,
    "Policies": policies,
    "Claims": claims,
    "Claim Items": claimitems,
    "Payments": payments,
    "Claim Status": claimstatus,
    "Fraud Scores": fraudscores,
    "Users": users,
    "Audit Log": auditlog
}

for name, df in tables.items():
    print(f"\n===== {name} =====")
    print(df.head())
    print(f"Rows: {df.shape[0]}")
    print(f"Columns: {df.shape[1]}")