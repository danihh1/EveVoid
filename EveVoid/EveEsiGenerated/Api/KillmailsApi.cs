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
    public interface IKillmailsApi
    {
        /// <summary>
        /// Get a character&#39;s recent kills and losses Return a list of a character&#39;s kills and losses going back 90 days  - -- Alternate route: &#x60;/dev/characters/{character_id}/killmails/recent/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/killmails/recent/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/killmails/recent/&#x60;  - -- This route is cached for up to 300 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="page">Which page of results to return</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCharactersCharacterIdKillmailsRecent200Ok&gt;</returns>
        List<GetCharactersCharacterIdKillmailsRecent200Ok> GetCharactersCharacterIdKillmailsRecent (int? characterId, string datasource, string ifNoneMatch, int? page, string token);
        /// <summary>
        /// Get a corporation&#39;s recent kills and losses Get a list of a corporation&#39;s kills and losses going back 90 days  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/killmails/recent/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/killmails/recent/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/killmails/recent/&#x60;  - -- This route is cached for up to 300 seconds  - -- Requires one of the following EVE corporation role(s): Director 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="page">Which page of results to return</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCorporationsCorporationIdKillmailsRecent200Ok&gt;</returns>
        List<GetCorporationsCorporationIdKillmailsRecent200Ok> GetCorporationsCorporationIdKillmailsRecent (int? corporationId, string datasource, string ifNoneMatch, int? page, string token);
        /// <summary>
        /// Get a single killmail Return a single killmail from its ID and hash  - -- Alternate route: &#x60;/dev/killmails/{killmail_id}/{killmail_hash}/&#x60;  Alternate route: &#x60;/legacy/killmails/{killmail_id}/{killmail_hash}/&#x60;  Alternate route: &#x60;/v1/killmails/{killmail_id}/{killmail_hash}/&#x60;  - -- This route is cached for up to 30758400 seconds
        /// </summary>
        /// <param name="killmailHash">The killmail hash for verification</param>
        /// <param name="killmailId">The killmail ID to be queried</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>GetKillmailsKillmailIdKillmailHashOk</returns>
        GetKillmailsKillmailIdKillmailHashOk GetKillmailsKillmailIdKillmailHash (string killmailHash, int? killmailId, string datasource, string ifNoneMatch);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class KillmailsApi : IKillmailsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KillmailsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public KillmailsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="KillmailsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public KillmailsApi(String basePath)
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
        /// Get a character&#39;s recent kills and losses Return a list of a character&#39;s kills and losses going back 90 days  - -- Alternate route: &#x60;/dev/characters/{character_id}/killmails/recent/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/killmails/recent/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/killmails/recent/&#x60;  - -- This route is cached for up to 300 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCharactersCharacterIdKillmailsRecent200Ok&gt;</returns>            
        public List<GetCharactersCharacterIdKillmailsRecent200Ok> GetCharactersCharacterIdKillmailsRecent (int? characterId, string datasource, string ifNoneMatch, int? page, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterIdKillmailsRecent");
            
    
            var path = "/characters/{character_id}/killmails/recent/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdKillmailsRecent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdKillmailsRecent: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCharactersCharacterIdKillmailsRecent200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCharactersCharacterIdKillmailsRecent200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get a corporation&#39;s recent kills and losses Get a list of a corporation&#39;s kills and losses going back 90 days  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/killmails/recent/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/killmails/recent/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/killmails/recent/&#x60;  - -- This route is cached for up to 300 seconds  - -- Requires one of the following EVE corporation role(s): Director 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCorporationsCorporationIdKillmailsRecent200Ok&gt;</returns>            
        public List<GetCorporationsCorporationIdKillmailsRecent200Ok> GetCorporationsCorporationIdKillmailsRecent (int? corporationId, string datasource, string ifNoneMatch, int? page, string token)
        {
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling GetCorporationsCorporationIdKillmailsRecent");
            
    
            var path = "/corporations/{corporation_id}/killmails/recent/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdKillmailsRecent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdKillmailsRecent: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCorporationsCorporationIdKillmailsRecent200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCorporationsCorporationIdKillmailsRecent200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get a single killmail Return a single killmail from its ID and hash  - -- Alternate route: &#x60;/dev/killmails/{killmail_id}/{killmail_hash}/&#x60;  Alternate route: &#x60;/legacy/killmails/{killmail_id}/{killmail_hash}/&#x60;  Alternate route: &#x60;/v1/killmails/{killmail_id}/{killmail_hash}/&#x60;  - -- This route is cached for up to 30758400 seconds
        /// </summary>
        /// <param name="killmailHash">The killmail hash for verification</param> 
        /// <param name="killmailId">The killmail ID to be queried</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>GetKillmailsKillmailIdKillmailHashOk</returns>            
        public GetKillmailsKillmailIdKillmailHashOk GetKillmailsKillmailIdKillmailHash (string killmailHash, int? killmailId, string datasource, string ifNoneMatch)
        {
            
            // verify the required parameter 'killmailHash' is set
            if (killmailHash == null) throw new ApiException(400, "Missing required parameter 'killmailHash' when calling GetKillmailsKillmailIdKillmailHash");
            
            // verify the required parameter 'killmailId' is set
            if (killmailId == null) throw new ApiException(400, "Missing required parameter 'killmailId' when calling GetKillmailsKillmailIdKillmailHash");
            
    
            var path = "/killmails/{killmail_id}/{killmail_hash}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "killmail_hash" + "}", ApiClient.ParameterToString(killmailHash));
path = path.Replace("{" + "killmail_id" + "}", ApiClient.ParameterToString(killmailId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetKillmailsKillmailIdKillmailHash: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetKillmailsKillmailIdKillmailHash: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetKillmailsKillmailIdKillmailHashOk) ApiClient.Deserialize(response.Content, typeof(GetKillmailsKillmailIdKillmailHashOk), response.Headers);
        }
    
    }
}
