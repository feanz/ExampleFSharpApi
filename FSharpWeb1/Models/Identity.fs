module Data

open FSharp.Data

[<CLIMutable>]
type Car =
    {   Make : string
        Model : string }

[<Literal>]
let connectionString = @"Data Source=(LocalDb)\v11.0;Initial Catalog=Authentication;Integrated Security=SSPI"

[<Literal>]
let identitySql = "SELECT BedeplayerId, username, sitecode from playeridentity";

[<Literal>]
let identityByIdSql = "SELECT BedeplayerId, username, sitecode from playeridentity where bedeplayerid = @Id"
       
type QueryIdentities = SqlCommandProvider<identitySql, connectionString>

type QueryIdentityById = SqlCommandProvider<identityByIdSql, connectionString>