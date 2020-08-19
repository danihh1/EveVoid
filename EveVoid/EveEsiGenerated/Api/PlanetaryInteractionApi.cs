using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPlanetaryInteractionApi
    {
        /// <summary>
        /// Get colonies Returns a list of all planetary colonies owned by a character.  - -- Alternate route: &#x60;/dev/characters/{character_id}/planets/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/planets/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/planets/&#x60;  - -- This route is cached for up to 600 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCharactersCharacterIdPlanets200Ok&gt;</returns>
        List<GetCharactersCharacterIdPlanets200Ok> GetCharactersCharacterIdPlanets (int? characterId, string datasource, string ifNoneMatch, string token);
        /// <summary>
        /// Get colony layout Returns full details on the layout of a single planetary colony, including links, pins and routes. Note: Planetary information is only recalculated when the colony is viewed through the client. Information will not update until this criteria is met.  - -- Alternate route: &#x60;/dev/characters/{character_id}/planets/{planet_id}/&#x60;  Alternate route: &#x60;/v3/characters/{character_id}/planets/{planet_id}/&#x60; 
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="planetId">Planet id of the target planet</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>GetCharactersCharacterIdPlanetsPlanetIdOk</returns>
        GetCharactersCharacterIdPlanetsPlanetIdOk GetCharactersCharacterIdPlanetsPlanetId (int? characterId, int? planetId, string datasource, string token);
        /// <summary>
        /// List corporation customs offices List customs offices owned by a corporation  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/customs_offices/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/customs_offices/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/customs_offices/&#x60;  - -- This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Director 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="page">Which page of results to return</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCorporationsCorporationIdCustomsOffices200Ok&gt;</returns>
        List<GetCorporationsCorporationIdCustomsOffices200Ok> GetCorporationsCorporationIdCustomsOffices (int? corporationId, string datasource, string ifNoneMatch, int? page, string token);
        /// <summary>
        /// Get schematic information Get information on a planetary factory schematic  - -- Alternate route: &#x60;/dev/universe/schematics/{schematic_id}/&#x60;  Alternate route: &#x60;/legacy/universe/schematics/{schematic_id}/&#x60;  Alternate route: &#x60;/v1/universe/schematics/{schematic_id}/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="schematicId">A PI schematic ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>GetUniverseSchematicsSchematicIdOk</returns>
        GetUniverseSchematicsSchematicIdOk GetUniverseSchematicsSchematicId (int? schematicId, string datasource, string ifNoneMatch);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PlanetaryInteractionApi : IPlanetaryInteractionApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlanetaryInteractionApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PlanetaryInteractionApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PlanetaryInteractionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PlanetaryInteractionApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Get colonies Returns a list of all planetary colonies owned by a character.  - -- Alternate route: &#x60;/dev/characters/{character_id}/planets/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/planets/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/planets/&#x60;  - -- This route is cached for up to 600 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCharactersCharacterIdPlanets200Ok&gt;</returns>            
        public List<GetCharactersCharacterIdPlanets200Ok> GetCharactersCharacterIdPlanets (int? characterId, string datasource, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterIdPlanets");
            
    
            var path = "/characters/{character_id}/planets/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "character_id" + "}", ApiClient.ParameterToString(characterId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
             if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "evesso" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdPlanets: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdPlanets: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCharactersCharacterIdPlanets200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCharactersCharacterIdPlanets200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get colony layout Returns full details on the layout of a single planetary colony, including links, pins and routes. Note: Planetary information is only recalculated when the colony is viewed through the client. Information will not update until this criteria is met.  - -- Alternate route: &#x60;/dev/characters/{character_id}/planets/{planet_id}/&#x60;  Alternate route: &#x60;/v3/characters/{character_id}/planets/{planet_id}/&#x60; 
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="planetId">Planet id of the target planet</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>GetCharactersCharacterIdPlanetsPlanetIdOk</returns>            
        public GetCharactersCharacterIdPlanetsPlanetIdOk GetCharactersCharacterIdPlanetsPlanetId (int? characterId, int? planetId, string datasource, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterIdPlanetsPlanetId");
            
            // verify the required parameter 'planetId' is set
            if (planetId == null) throw new ApiException(400, "Missing required parameter 'planetId' when calling GetCharactersCharacterIdPlanetsPlanetId");
            
    
            var path = "/characters/{character_id}/planets/{planet_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "character_id" + "}", ApiClient.ParameterToString(characterId));
path = path.Replace("{" + "planet_id" + "}", ApiClient.ParameterToString(planetId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "evesso" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdPlanetsPlanetId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdPlanetsPlanetId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetCharactersCharacterIdPlanetsPlanetIdOk) ApiClient.Deserialize(response.Content, typeof(GetCharactersCharacterIdPlanetsPlanetIdOk), response.Headers);
        }
    
        /// <summary>
        /// List corporation customs offices List customs offices owned by a corporation  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/customs_offices/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/customs_offices/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/customs_offices/&#x60;  - -- This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Director 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCorporationsCorporationIdCustomsOffices200Ok&gt;</returns>            
        public List<GetCorporationsCorporationIdCustomsOffices200Ok> GetCorporationsCorporationIdCustomsOffices (int? corporationId, string datasource, string ifNoneMatch, int? page, string token)
        {
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling GetCorporationsCorporationIdCustomsOffices");
            
    
            var path = "/corporations/{corporation_id}/customs_offices/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "corporation_id" + "}", ApiClient.ParameterToString(corporationId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
             if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "evesso" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdCustomsOffices: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdCustomsOffices: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCorporationsCorporationIdCustomsOffices200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCorporationsCorporationIdCustomsOffices200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get schematic information Get information on a planetary factory schematic  - -- Alternate route: &#x60;/dev/universe/schematics/{schematic_id}/&#x60;  Alternate route: &#x60;/legacy/universe/schematics/{schematic_id}/&#x60;  Alternate route: &#x60;/v1/universe/schematics/{schematic_id}/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="schematicId">A PI schematic ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>GetUniverseSchematicsSchematicIdOk</returns>            
        public GetUniverseSchematicsSchematicIdOk GetUniverseSchematicsSchematicId (int? schematicId, string datasource, string ifNoneMatch)
        {
            
            // verify the required parameter 'schematicId' is set
            if (schematicId == null) throw new ApiException(400, "Missing required parameter 'schematicId' when calling GetUniverseSchematicsSchematicId");
            
    
            var path = "/universe/schematics/{schematic_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "schematic_id" + "}", ApiClient.ParameterToString(schematicId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
             if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseSchematicsSchematicId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseSchematicsSchematicId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetUniverseSchematicsSchematicIdOk) ApiClient.Deserialize(response.Content, typeof(GetUniverseSchematicsSchematicIdOk), response.Headers);
        }
    
    }
}
