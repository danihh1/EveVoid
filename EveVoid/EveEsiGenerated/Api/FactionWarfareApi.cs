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
    public interface IFactionWarfareApi
    {
        /// <summary>
        /// Overview of a character involved in faction warfare Statistical overview of a character involved in faction warfare  - -- Alternate route: &#x60;/dev/characters/{character_id}/fw/stats/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/fw/stats/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/fw/stats/&#x60;  Alternate route: &#x60;/v2/characters/{character_id}/fw/stats/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>GetCharactersCharacterIdFwStatsOk</returns>
        GetCharactersCharacterIdFwStatsOk GetCharactersCharacterIdFwStats (int? characterId, string datasource, string ifNoneMatch, string token);
        /// <summary>
        /// Overview of a corporation involved in faction warfare Statistics about a corporation involved in faction warfare  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/fw/stats/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/fw/stats/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/fw/stats/&#x60;  Alternate route: &#x60;/v2/corporations/{corporation_id}/fw/stats/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>GetCorporationsCorporationIdFwStatsOk</returns>
        GetCorporationsCorporationIdFwStatsOk GetCorporationsCorporationIdFwStats (int? corporationId, string datasource, string ifNoneMatch, string token);
        /// <summary>
        /// List of the top factions in faction warfare Top 4 leaderboard of factions for kills and victory points separated by total, last week and yesterday  - -- Alternate route: &#x60;/dev/fw/leaderboards/&#x60;  Alternate route: &#x60;/legacy/fw/leaderboards/&#x60;  Alternate route: &#x60;/v1/fw/leaderboards/&#x60;  Alternate route: &#x60;/v2/fw/leaderboards/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>GetFwLeaderboardsOk</returns>
        GetFwLeaderboardsOk GetFwLeaderboards (string datasource, string ifNoneMatch);
        /// <summary>
        /// List of the top pilots in faction warfare Top 100 leaderboard of pilots for kills and victory points separated by total, last week and yesterday  - -- Alternate route: &#x60;/dev/fw/leaderboards/characters/&#x60;  Alternate route: &#x60;/legacy/fw/leaderboards/characters/&#x60;  Alternate route: &#x60;/v1/fw/leaderboards/characters/&#x60;  Alternate route: &#x60;/v2/fw/leaderboards/characters/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>GetFwLeaderboardsCharactersOk</returns>
        GetFwLeaderboardsCharactersOk GetFwLeaderboardsCharacters (string datasource, string ifNoneMatch);
        /// <summary>
        /// List of the top corporations in faction warfare Top 10 leaderboard of corporations for kills and victory points separated by total, last week and yesterday  - -- Alternate route: &#x60;/dev/fw/leaderboards/corporations/&#x60;  Alternate route: &#x60;/legacy/fw/leaderboards/corporations/&#x60;  Alternate route: &#x60;/v1/fw/leaderboards/corporations/&#x60;  Alternate route: &#x60;/v2/fw/leaderboards/corporations/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>GetFwLeaderboardsCorporationsOk</returns>
        GetFwLeaderboardsCorporationsOk GetFwLeaderboardsCorporations (string datasource, string ifNoneMatch);
        /// <summary>
        /// An overview of statistics about factions involved in faction warfare Statistical overviews of factions involved in faction warfare  - -- Alternate route: &#x60;/dev/fw/stats/&#x60;  Alternate route: &#x60;/legacy/fw/stats/&#x60;  Alternate route: &#x60;/v1/fw/stats/&#x60;  Alternate route: &#x60;/v2/fw/stats/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>List&lt;GetFwStats200Ok&gt;</returns>
        List<GetFwStats200Ok> GetFwStats (string datasource, string ifNoneMatch);
        /// <summary>
        /// Ownership of faction warfare systems An overview of the current ownership of faction warfare solar systems  - -- Alternate route: &#x60;/dev/fw/systems/&#x60;  Alternate route: &#x60;/legacy/fw/systems/&#x60;  Alternate route: &#x60;/v2/fw/systems/&#x60;  Alternate route: &#x60;/v3/fw/systems/&#x60;  - -- This route is cached for up to 1800 seconds
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>List&lt;GetFwSystems200Ok&gt;</returns>
        List<GetFwSystems200Ok> GetFwSystems (string datasource, string ifNoneMatch);
        /// <summary>
        /// Data about which NPC factions are at war Data about which NPC factions are at war  - -- Alternate route: &#x60;/dev/fw/wars/&#x60;  Alternate route: &#x60;/legacy/fw/wars/&#x60;  Alternate route: &#x60;/v1/fw/wars/&#x60;  Alternate route: &#x60;/v2/fw/wars/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>List&lt;GetFwWars200Ok&gt;</returns>
        List<GetFwWars200Ok> GetFwWars (string datasource, string ifNoneMatch);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class FactionWarfareApi : IFactionWarfareApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FactionWarfareApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public FactionWarfareApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FactionWarfareApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FactionWarfareApi(String basePath)
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
        /// Overview of a character involved in faction warfare Statistical overview of a character involved in faction warfare  - -- Alternate route: &#x60;/dev/characters/{character_id}/fw/stats/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/fw/stats/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/fw/stats/&#x60;  Alternate route: &#x60;/v2/characters/{character_id}/fw/stats/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>GetCharactersCharacterIdFwStatsOk</returns>            
        public GetCharactersCharacterIdFwStatsOk GetCharactersCharacterIdFwStats (int? characterId, string datasource, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterIdFwStats");
            
    
            var path = "/characters/{character_id}/fw/stats/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdFwStats: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdFwStats: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetCharactersCharacterIdFwStatsOk) ApiClient.Deserialize(response.Content, typeof(GetCharactersCharacterIdFwStatsOk), response.Headers);
        }
    
        /// <summary>
        /// Overview of a corporation involved in faction warfare Statistics about a corporation involved in faction warfare  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/fw/stats/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/fw/stats/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/fw/stats/&#x60;  Alternate route: &#x60;/v2/corporations/{corporation_id}/fw/stats/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>GetCorporationsCorporationIdFwStatsOk</returns>            
        public GetCorporationsCorporationIdFwStatsOk GetCorporationsCorporationIdFwStats (int? corporationId, string datasource, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling GetCorporationsCorporationIdFwStats");
            
    
            var path = "/corporations/{corporation_id}/fw/stats/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "corporation_id" + "}", ApiClient.ParameterToString(corporationId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdFwStats: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdFwStats: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetCorporationsCorporationIdFwStatsOk) ApiClient.Deserialize(response.Content, typeof(GetCorporationsCorporationIdFwStatsOk), response.Headers);
        }
    
        /// <summary>
        /// List of the top factions in faction warfare Top 4 leaderboard of factions for kills and victory points separated by total, last week and yesterday  - -- Alternate route: &#x60;/dev/fw/leaderboards/&#x60;  Alternate route: &#x60;/legacy/fw/leaderboards/&#x60;  Alternate route: &#x60;/v1/fw/leaderboards/&#x60;  Alternate route: &#x60;/v2/fw/leaderboards/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>GetFwLeaderboardsOk</returns>            
        public GetFwLeaderboardsOk GetFwLeaderboards (string datasource, string ifNoneMatch)
        {
            
    
            var path = "/fw/leaderboards/";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetFwLeaderboards: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFwLeaderboards: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetFwLeaderboardsOk) ApiClient.Deserialize(response.Content, typeof(GetFwLeaderboardsOk), response.Headers);
        }
    
        /// <summary>
        /// List of the top pilots in faction warfare Top 100 leaderboard of pilots for kills and victory points separated by total, last week and yesterday  - -- Alternate route: &#x60;/dev/fw/leaderboards/characters/&#x60;  Alternate route: &#x60;/legacy/fw/leaderboards/characters/&#x60;  Alternate route: &#x60;/v1/fw/leaderboards/characters/&#x60;  Alternate route: &#x60;/v2/fw/leaderboards/characters/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>GetFwLeaderboardsCharactersOk</returns>            
        public GetFwLeaderboardsCharactersOk GetFwLeaderboardsCharacters (string datasource, string ifNoneMatch)
        {
            
    
            var path = "/fw/leaderboards/characters/";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetFwLeaderboardsCharacters: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFwLeaderboardsCharacters: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetFwLeaderboardsCharactersOk) ApiClient.Deserialize(response.Content, typeof(GetFwLeaderboardsCharactersOk), response.Headers);
        }
    
        /// <summary>
        /// List of the top corporations in faction warfare Top 10 leaderboard of corporations for kills and victory points separated by total, last week and yesterday  - -- Alternate route: &#x60;/dev/fw/leaderboards/corporations/&#x60;  Alternate route: &#x60;/legacy/fw/leaderboards/corporations/&#x60;  Alternate route: &#x60;/v1/fw/leaderboards/corporations/&#x60;  Alternate route: &#x60;/v2/fw/leaderboards/corporations/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>GetFwLeaderboardsCorporationsOk</returns>            
        public GetFwLeaderboardsCorporationsOk GetFwLeaderboardsCorporations (string datasource, string ifNoneMatch)
        {
            
    
            var path = "/fw/leaderboards/corporations/";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetFwLeaderboardsCorporations: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFwLeaderboardsCorporations: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetFwLeaderboardsCorporationsOk) ApiClient.Deserialize(response.Content, typeof(GetFwLeaderboardsCorporationsOk), response.Headers);
        }
    
        /// <summary>
        /// An overview of statistics about factions involved in faction warfare Statistical overviews of factions involved in faction warfare  - -- Alternate route: &#x60;/dev/fw/stats/&#x60;  Alternate route: &#x60;/legacy/fw/stats/&#x60;  Alternate route: &#x60;/v1/fw/stats/&#x60;  Alternate route: &#x60;/v2/fw/stats/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>List&lt;GetFwStats200Ok&gt;</returns>            
        public List<GetFwStats200Ok> GetFwStats (string datasource, string ifNoneMatch)
        {
            
    
            var path = "/fw/stats/";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetFwStats: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFwStats: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetFwStats200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetFwStats200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Ownership of faction warfare systems An overview of the current ownership of faction warfare solar systems  - -- Alternate route: &#x60;/dev/fw/systems/&#x60;  Alternate route: &#x60;/legacy/fw/systems/&#x60;  Alternate route: &#x60;/v2/fw/systems/&#x60;  Alternate route: &#x60;/v3/fw/systems/&#x60;  - -- This route is cached for up to 1800 seconds
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>List&lt;GetFwSystems200Ok&gt;</returns>            
        public List<GetFwSystems200Ok> GetFwSystems (string datasource, string ifNoneMatch)
        {
            
    
            var path = "/fw/systems/";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetFwSystems: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFwSystems: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetFwSystems200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetFwSystems200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Data about which NPC factions are at war Data about which NPC factions are at war  - -- Alternate route: &#x60;/dev/fw/wars/&#x60;  Alternate route: &#x60;/legacy/fw/wars/&#x60;  Alternate route: &#x60;/v1/fw/wars/&#x60;  Alternate route: &#x60;/v2/fw/wars/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>List&lt;GetFwWars200Ok&gt;</returns>            
        public List<GetFwWars200Ok> GetFwWars (string datasource, string ifNoneMatch)
        {
            
    
            var path = "/fw/wars/";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetFwWars: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFwWars: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetFwWars200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetFwWars200Ok>), response.Headers);
        }
    
    }
}
