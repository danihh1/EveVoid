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
    public interface IAssetsApi
    {
        /// <summary>
        /// Get character assets Return a list of the characters assets  - -- Alternate route: &#x60;/dev/characters/{character_id}/assets/&#x60;  Alternate route: &#x60;/v5/characters/{character_id}/assets/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="page">Which page of results to return</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCharactersCharacterIdAssets200Ok&gt;</returns>
        List<GetCharactersCharacterIdAssets200Ok> GetCharactersCharacterIdAssets (int? characterId, string datasource, string ifNoneMatch, int? page, string token);
        /// <summary>
        /// Get corporation assets Return a list of the corporation assets  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/assets/&#x60;  Alternate route: &#x60;/v5/corporations/{corporation_id}/assets/&#x60;  - -- This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Director 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="page">Which page of results to return</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCorporationsCorporationIdAssets200Ok&gt;</returns>
        List<GetCorporationsCorporationIdAssets200Ok> GetCorporationsCorporationIdAssets (int? corporationId, string datasource, string ifNoneMatch, int? page, string token);
        /// <summary>
        /// Get character asset locations Return locations for a set of item ids, which you can get from character assets endpoint. Coordinates for items in hangars or stations are set to (0,0,0)  - -- Alternate route: &#x60;/dev/characters/{character_id}/assets/locations/&#x60;  Alternate route: &#x60;/v2/characters/{character_id}/assets/locations/&#x60; 
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="itemIds">A list of item ids</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;PostCharactersCharacterIdAssetsLocations200Ok&gt;</returns>
        List<PostCharactersCharacterIdAssetsLocations200Ok> PostCharactersCharacterIdAssetsLocations (int? characterId, List<long?> itemIds, string datasource, string token);
        /// <summary>
        /// Get character asset names Return names for a set of item ids, which you can get from character assets endpoint. Typically used for items that can customize names, like containers or ships.  - -- Alternate route: &#x60;/dev/characters/{character_id}/assets/names/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/assets/names/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/assets/names/&#x60; 
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="itemIds">A list of item ids</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;PostCharactersCharacterIdAssetsNames200Ok&gt;</returns>
        List<PostCharactersCharacterIdAssetsNames200Ok> PostCharactersCharacterIdAssetsNames (int? characterId, List<long?> itemIds, string datasource, string token);
        /// <summary>
        /// Get corporation asset locations Return locations for a set of item ids, which you can get from corporation assets endpoint. Coordinates for items in hangars or stations are set to (0,0,0)  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/assets/locations/&#x60;  Alternate route: &#x60;/v2/corporations/{corporation_id}/assets/locations/&#x60;   - -- Requires one of the following EVE corporation role(s): Director 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="itemIds">A list of item ids</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;PostCorporationsCorporationIdAssetsLocations200Ok&gt;</returns>
        List<PostCorporationsCorporationIdAssetsLocations200Ok> PostCorporationsCorporationIdAssetsLocations (int? corporationId, List<long?> itemIds, string datasource, string token);
        /// <summary>
        /// Get corporation asset names Return names for a set of item ids, which you can get from corporation assets endpoint. Only valid for items that can customize names, like containers or ships  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/assets/names/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/assets/names/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/assets/names/&#x60;   - -- Requires one of the following EVE corporation role(s): Director 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="itemIds">A list of item ids</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;PostCorporationsCorporationIdAssetsNames200Ok&gt;</returns>
        List<PostCorporationsCorporationIdAssetsNames200Ok> PostCorporationsCorporationIdAssetsNames (int? corporationId, List<long?> itemIds, string datasource, string token);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AssetsApi : IAssetsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AssetsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AssetsApi(String basePath)
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
        /// Get character assets Return a list of the characters assets  - -- Alternate route: &#x60;/dev/characters/{character_id}/assets/&#x60;  Alternate route: &#x60;/v5/characters/{character_id}/assets/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCharactersCharacterIdAssets200Ok&gt;</returns>            
        public List<GetCharactersCharacterIdAssets200Ok> GetCharactersCharacterIdAssets (int? characterId, string datasource, string ifNoneMatch, int? page, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterIdAssets");
            
    
            var path = "/characters/{character_id}/assets/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "character_id" + "}", ApiClient.ParameterToString(characterId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdAssets: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdAssets: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCharactersCharacterIdAssets200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCharactersCharacterIdAssets200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get corporation assets Return a list of the corporation assets  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/assets/&#x60;  Alternate route: &#x60;/v5/corporations/{corporation_id}/assets/&#x60;  - -- This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Director 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCorporationsCorporationIdAssets200Ok&gt;</returns>            
        public List<GetCorporationsCorporationIdAssets200Ok> GetCorporationsCorporationIdAssets (int? corporationId, string datasource, string ifNoneMatch, int? page, string token)
        {
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling GetCorporationsCorporationIdAssets");
            
    
            var path = "/corporations/{corporation_id}/assets/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdAssets: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdAssets: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCorporationsCorporationIdAssets200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCorporationsCorporationIdAssets200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get character asset locations Return locations for a set of item ids, which you can get from character assets endpoint. Coordinates for items in hangars or stations are set to (0,0,0)  - -- Alternate route: &#x60;/dev/characters/{character_id}/assets/locations/&#x60;  Alternate route: &#x60;/v2/characters/{character_id}/assets/locations/&#x60; 
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="itemIds">A list of item ids</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;PostCharactersCharacterIdAssetsLocations200Ok&gt;</returns>            
        public List<PostCharactersCharacterIdAssetsLocations200Ok> PostCharactersCharacterIdAssetsLocations (int? characterId, List<long?> itemIds, string datasource, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling PostCharactersCharacterIdAssetsLocations");
            
            // verify the required parameter 'itemIds' is set
            if (itemIds == null) throw new ApiException(400, "Missing required parameter 'itemIds' when calling PostCharactersCharacterIdAssetsLocations");
            
    
            var path = "/characters/{character_id}/assets/locations/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "character_id" + "}", ApiClient.ParameterToString(characterId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                    postBody = ApiClient.Serialize(itemIds); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "evesso" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostCharactersCharacterIdAssetsLocations: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostCharactersCharacterIdAssetsLocations: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<PostCharactersCharacterIdAssetsLocations200Ok>) ApiClient.Deserialize(response.Content, typeof(List<PostCharactersCharacterIdAssetsLocations200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get character asset names Return names for a set of item ids, which you can get from character assets endpoint. Typically used for items that can customize names, like containers or ships.  - -- Alternate route: &#x60;/dev/characters/{character_id}/assets/names/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/assets/names/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/assets/names/&#x60; 
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="itemIds">A list of item ids</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;PostCharactersCharacterIdAssetsNames200Ok&gt;</returns>            
        public List<PostCharactersCharacterIdAssetsNames200Ok> PostCharactersCharacterIdAssetsNames (int? characterId, List<long?> itemIds, string datasource, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling PostCharactersCharacterIdAssetsNames");
            
            // verify the required parameter 'itemIds' is set
            if (itemIds == null) throw new ApiException(400, "Missing required parameter 'itemIds' when calling PostCharactersCharacterIdAssetsNames");
            
    
            var path = "/characters/{character_id}/assets/names/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "character_id" + "}", ApiClient.ParameterToString(characterId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                    postBody = ApiClient.Serialize(itemIds); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "evesso" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostCharactersCharacterIdAssetsNames: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostCharactersCharacterIdAssetsNames: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<PostCharactersCharacterIdAssetsNames200Ok>) ApiClient.Deserialize(response.Content, typeof(List<PostCharactersCharacterIdAssetsNames200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get corporation asset locations Return locations for a set of item ids, which you can get from corporation assets endpoint. Coordinates for items in hangars or stations are set to (0,0,0)  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/assets/locations/&#x60;  Alternate route: &#x60;/v2/corporations/{corporation_id}/assets/locations/&#x60;   - -- Requires one of the following EVE corporation role(s): Director 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="itemIds">A list of item ids</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;PostCorporationsCorporationIdAssetsLocations200Ok&gt;</returns>            
        public List<PostCorporationsCorporationIdAssetsLocations200Ok> PostCorporationsCorporationIdAssetsLocations (int? corporationId, List<long?> itemIds, string datasource, string token)
        {
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling PostCorporationsCorporationIdAssetsLocations");
            
            // verify the required parameter 'itemIds' is set
            if (itemIds == null) throw new ApiException(400, "Missing required parameter 'itemIds' when calling PostCorporationsCorporationIdAssetsLocations");
            
    
            var path = "/corporations/{corporation_id}/assets/locations/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "corporation_id" + "}", ApiClient.ParameterToString(corporationId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                    postBody = ApiClient.Serialize(itemIds); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "evesso" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostCorporationsCorporationIdAssetsLocations: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostCorporationsCorporationIdAssetsLocations: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<PostCorporationsCorporationIdAssetsLocations200Ok>) ApiClient.Deserialize(response.Content, typeof(List<PostCorporationsCorporationIdAssetsLocations200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get corporation asset names Return names for a set of item ids, which you can get from corporation assets endpoint. Only valid for items that can customize names, like containers or ships  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/assets/names/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/assets/names/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/assets/names/&#x60;   - -- Requires one of the following EVE corporation role(s): Director 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="itemIds">A list of item ids</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;PostCorporationsCorporationIdAssetsNames200Ok&gt;</returns>            
        public List<PostCorporationsCorporationIdAssetsNames200Ok> PostCorporationsCorporationIdAssetsNames (int? corporationId, List<long?> itemIds, string datasource, string token)
        {
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling PostCorporationsCorporationIdAssetsNames");
            
            // verify the required parameter 'itemIds' is set
            if (itemIds == null) throw new ApiException(400, "Missing required parameter 'itemIds' when calling PostCorporationsCorporationIdAssetsNames");
            
    
            var path = "/corporations/{corporation_id}/assets/names/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "corporation_id" + "}", ApiClient.ParameterToString(corporationId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                    postBody = ApiClient.Serialize(itemIds); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "evesso" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostCorporationsCorporationIdAssetsNames: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostCorporationsCorporationIdAssetsNames: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<PostCorporationsCorporationIdAssetsNames200Ok>) ApiClient.Deserialize(response.Content, typeof(List<PostCorporationsCorporationIdAssetsNames200Ok>), response.Headers);
        }
    
    }
}
