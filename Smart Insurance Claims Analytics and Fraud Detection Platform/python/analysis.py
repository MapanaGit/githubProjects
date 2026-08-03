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

# main program

customers = load_table("customers")
policies = load_table("policies")
claims = load_table("claims")
claim_items = load_table("claimitems")
payments = load_table("payments")

print("\n==== Customers ====")
print(customers.head())

print("\n==== Policies ====")
print(policies.head())

print("\n==== Claims ====")
print(claims.head())

print("\n==== Table Sizes ====")

print("Customers:", customers.shape)
print("Policies:", policies.shape)
print("Claims:", claims.shape)
print("Claim Items:", claim_items.shape)
print("Payments:", payments.shape)