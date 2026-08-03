# -*- coding: utf-8 -*-
import pandas as pd
from pathlib import Path
import sys

#allow importing from the pattern folder
PROJECT_ROOT = Path(__file__).resolve().parent.parent
sys.path.append(str(PROJECT_ROOT / "python"))

from database import get_connection

def create_dataset():
    conn = get_connection()
    
    query="""
    select 
        c.claimid, 
        c.policyid, 
        c.customerid,
        
        p.policytype,
        p.coveramount,
        
        c.claimamount,
        c.claimdate,
        
        cs.statusname AS claimstatus,
        
        ISNULL(fs.fraudscore,0) AS fraudscore,
        ISNULL(pay.amount,0) AS paymentamount,
        COUNT(ci.claimitemid) as numberofitems,
        
        CASE
            WHEN fs.fraudscore >=70 THEN 'Yes'
            ELSE 'No'
        END AS Fraud
    
    FROM claims c
    
    INNER JOIN claims policies p
        ON c.policyid = p.policyid
        
    INNER JOIN claimstatus cs
        ON c.statusid = cs.statusid
        
    LEFT JOIN fraudscores fs
        ON c.claimid = fs.claimid
        
    LEFT JOIN payments pay
        ON c.claimid = pay.claimid
    
    LEFT JOIN claimitems ci
        ON c.claimid = ci.claimid
    
    GROUP BY
    
        c.claimid,
        c.policyid,
        c.customerid,
        
        p.policytype,
        p.coveramount,
        
        c.claimamount,
        c.claimdate,
        
        cs.statusname,
        
        fs.fraudscore,
        
        pay.amount
        
    """
    
    df = pd.read_sql(query, conn)

    conn.close()

    output_folder = Path(__file__).parent / "datasets"
    output_folder.mkdir(exist_ok=True)

    output_file = output_folder / "fraud_dataset.csv"

    df.to_csv(output_file, index=False)

    print(df.head())

    print("\nDataset Shape")

    print(df.shape)

    print("\nSaved to")

    print(output_file)


if __name__ == "__main__":
    create_dataset()
