namespace Bede.AuthenticationFSharp.Web.Controllers

open System.Net
open System.Numerics
open System.Net.Http
open System.Web.Http
open IdentityData

/// Retrieves values.
[<RoutePrefix("api")>]
type IdentityController() =
    inherit ApiController()    

    /// Gets all values.
    [<Route("identity")>]
    member x.Get(request: HttpRequestMessage) =         
        let queryIdentity = new QueryIdentities()
        request.CreateResponse(queryIdentity.Execute())

    /// Gets a single value at the specified index.
    [<Route("identity/{id:long}")>]
    member x.Get(request: HttpRequestMessage, id: int64) =
        if id >= 0L then
             let queryIdentity = new QueryIdentityById()
             request.CreateResponse(queryIdentity.Execute(id))
        else 
            request.CreateResponse(HttpStatusCode.NotFound)  

