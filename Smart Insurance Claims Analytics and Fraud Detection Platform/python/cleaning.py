# -*- coding: utf-8 -*-
claims = claims.drop_duplicates()

claims["claimdate"] = pd.to_datetime(claims["claimdate"])
