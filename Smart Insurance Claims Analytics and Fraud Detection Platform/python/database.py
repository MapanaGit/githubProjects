# -*- coding: utf-8 -*-
# -*- coding: utf-8 -*-
import pyodbc

def get_connection():
    """
    creates and return sql server database connection
    """
    conn = pyodbc.connect(
    'DRIVER={ODBC Driver 17 for SQL Server};'
    'SERVER=DEV\SQLEXPRESS;'
    'DATABASE=insurancedb;'
    'Trusted_Connection=yes;'
    )

    return conn

#test connection

if __name__ == "__main__":
    try:
        connection = get_connection()
        print("Connected to SQL server successfully")
        connection.close()
    except Exception as e:
        print("Connection failed")
        print(e)
