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
    public interface ICharacterApi
    {
        /// <summary>
        /// Get character&#39;s public information Public information about a character  - -- Alternate route: &#x60;/dev/characters/{character_id}/&#x60;  Alternate route: &#x60;/v4/characters/{character_id}/&#x60;  - -- This route is cached for up to 86400 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>GetCharactersCharacterIdOk</returns>
        GetCharactersCharacterIdOk GetCharactersCharacterId (int? characterId, string datasource, string ifNoneMatch);
        /// <summary>
        /// Get agents research Return a list of agents research information for a character. The formula for finding the current research points with an agent is: currentPoints &#x3D; remainderPoints + pointsPerDay * days(currentTime - researchStartDate)  - -- Alternate route: &#x60;/legacy/characters/{character_id}/agents_research/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/agents_research/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCharactersCharacterIdAgentsResearch200Ok&gt;</returns>
        List<GetCharactersCharacterIdAgentsResearch200Ok> GetCharactersCharacterIdAgentsResearch (int? characterId, string datasource, string ifNoneMatch, string token);
        /// <summary>
        /// Get blueprints Return a list of blueprints the character owns  - -- Alternate route: &#x60;/v2/characters/{character_id}/blueprints/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="page">Which page of results to return</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCharactersCharacterIdBlueprints200Ok&gt;</returns>
        List<GetCharactersCharacterIdBlueprints200Ok> GetCharactersCharacterIdBlueprints (int? characterId, string datasource, string ifNoneMatch, int? page, string token);
        /// <summary>
        /// Get corporation history Get a list of all the corporations a character has been a member of  - -- Alternate route: &#x60;/legacy/characters/{character_id}/corporationhistory/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/corporationhistory/&#x60;  - -- This route is cached for up to 86400 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>List&lt;GetCharactersCharacterIdCorporationhistory200Ok&gt;</returns>
        List<GetCharactersCharacterIdCorporationhistory200Ok> GetCharactersCharacterIdCorporationhistory (int? characterId, string datasource, string ifNoneMatch);
        /// <summary>
        /// Get jump fatigue Return a character&#39;s jump activation and fatigue information  - -- Alternate route: &#x60;/legacy/characters/{character_id}/fatigue/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/fatigue/&#x60;  - -- This route is cached for up to 300 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>GetCharactersCharacterIdFatigueOk</returns>
        GetCharactersCharacterIdFatigueOk GetCharactersCharacterIdFatigue (int? characterId, string datasource, string ifNoneMatch, string token);
        /// <summary>
        /// Get medals Return a list of medals the character has  - -- Alternate route: &#x60;/legacy/characters/{character_id}/medals/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/medals/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCharactersCharacterIdMedals200Ok&gt;</returns>
        List<GetCharactersCharacterIdMedals200Ok> GetCharactersCharacterIdMedals (int? characterId, string datasource, string ifNoneMatch, string token);
        /// <summary>
        /// Get character notifications Return character notifications  - -- Alternate route: &#x60;/dev/characters/{character_id}/notifications/&#x60;  Alternate route: &#x60;/v5/characters/{character_id}/notifications/&#x60;  Alternate route: &#x60;/v6/characters/{character_id}/notifications/&#x60;  - -- This route is cached for up to 600 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCharactersCharacterIdNotifications200Ok&gt;</returns>
        List<GetCharactersCharacterIdNotifications200Ok> GetCharactersCharacterIdNotifications (int? characterId, string datasource, string ifNoneMatch, string token);
        /// <summary>
        /// Get new contact notifications Return notifications about having been added to someone&#39;s contact list  - -- Alternate route: &#x60;/legacy/characters/{character_id}/notifications/contacts/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/notifications/contacts/&#x60;  - -- This route is cached for up to 600 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCharactersCharacterIdNotificationsContacts200Ok&gt;</returns>
        List<GetCharactersCharacterIdNotificationsContacts200Ok> GetCharactersCharacterIdNotificationsContacts (int? characterId, string datasource, string ifNoneMatch, string token);
        /// <summary>
        /// Get character portraits Get portrait urls for a character  - -- Alternate route: &#x60;/dev/characters/{character_id}/portrait/&#x60;  Alternate route: &#x60;/v2/characters/{character_id}/portrait/&#x60;  Alternate route: &#x60;/v3/characters/{character_id}/portrait/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>GetCharactersCharacterIdPortraitOk</returns>
        GetCharactersCharacterIdPortraitOk GetCharactersCharacterIdPortrait (int? characterId, string datasource, string ifNoneMatch);
        /// <summary>
        /// Get character corporation roles Returns a character&#39;s corporation roles  - -- Alternate route: &#x60;/v2/characters/{character_id}/roles/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>GetCharactersCharacterIdRolesOk</returns>
        GetCharactersCharacterIdRolesOk GetCharactersCharacterIdRoles (int? characterId, string datasource, string ifNoneMatch, string token);
        /// <summary>
        /// Get standings Return character standings from agents, NPC corporations, and factions  - -- Alternate route: &#x60;/legacy/characters/{character_id}/standings/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/standings/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCharactersCharacterIdStandings200Ok&gt;</returns>
        List<GetCharactersCharacterIdStandings200Ok> GetCharactersCharacterIdStandings (int? characterId, string datasource, string ifNoneMatch, string token);
        /// <summary>
        /// Yearly aggregate stats Returns aggregate yearly stats for a character  - -- Alternate route: &#x60;/dev/characters/{character_id}/stats/&#x60;  Alternate route: &#x60;/v2/characters/{character_id}/stats/&#x60;  - -- This route is cached for up to 86400 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCharactersCharacterIdStats200Ok&gt;</returns>
        List<GetCharactersCharacterIdStats200Ok> GetCharactersCharacterIdStats (int? characterId, string datasource, string ifNoneMatch, string token);
        /// <summary>
        /// Get character corporation titles Returns a character&#39;s titles  - -- Alternate route: &#x60;/legacy/characters/{character_id}/titles/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/titles/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCharactersCharacterIdTitles200Ok&gt;</returns>
        List<GetCharactersCharacterIdTitles200Ok> GetCharactersCharacterIdTitles (int? characterId, string datasource, string ifNoneMatch, string token);
        /// <summary>
        /// Character affiliation Bulk lookup of character IDs to corporation, alliance and faction  - -- Alternate route: &#x60;/legacy/characters/affiliation/&#x60;  Alternate route: &#x60;/v1/characters/affiliation/&#x60;  - -- This route is cached for up to 3600 seconds  - -- [Diff of the upcoming changes](https://esi.evetech.net/diff/latest/dev/#POST-/characters/affiliation/)
        /// </summary>
        /// <param name="characters">The character IDs to fetch affiliations for. All characters must exist, or none will be returned</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <returns>List&lt;PostCharactersAffiliation200Ok&gt;</returns>
        List<PostCharactersAffiliation200Ok> PostCharactersAffiliation (List<int?> characters, string datasource);
        /// <summary>
        /// Calculate a CSPA charge cost Takes a source character ID in the url and a set of target character ID&#39;s in the body, returns a CSPA charge cost  - -- Alternate route: &#x60;/v4/characters/{character_id}/cspa/&#x60; 
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="characters">The target characters to calculate the charge for</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>float?</returns>
        float? PostCharactersCharacterIdCspa (int? characterId, List<int?> characters, string datasource, string token);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CharacterApi : ICharacterApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CharacterApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CharacterApi(String basePath)
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
        /// Get character&#39;s public information Public information about a character  - -- Alternate route: &#x60;/dev/characters/{character_id}/&#x60;  Alternate route: &#x60;/v4/characters/{character_id}/&#x60;  - -- This route is cached for up to 86400 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>GetCharactersCharacterIdOk</returns>            
        public GetCharactersCharacterIdOk GetCharactersCharacterId (int? characterId, string datasource, string ifNoneMatch)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterId");
            
    
            var path = "/characters/{character_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "character_id" + "}", ApiClient.ParameterToString(characterId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetCharactersCharacterIdOk) ApiClient.Deserialize(response.Content, typeof(GetCharactersCharacterIdOk), response.Headers);
        }
    
        /// <summary>
        /// Get agents research Return a list of agents research information for a character. The formula for finding the current research points with an agent is: currentPoints &#x3D; remainderPoints + pointsPerDay * days(currentTime - researchStartDate)  - -- Alternate route: &#x60;/legacy/characters/{character_id}/agents_research/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/agents_research/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCharactersCharacterIdAgentsResearch200Ok&gt;</returns>            
        public List<GetCharactersCharacterIdAgentsResearch200Ok> GetCharactersCharacterIdAgentsResearch (int? characterId, string datasource, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterIdAgentsResearch");
            
    
            var path = "/characters/{character_id}/agents_research/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdAgentsResearch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdAgentsResearch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCharactersCharacterIdAgentsResearch200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCharactersCharacterIdAgentsResearch200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get blueprints Return a list of blueprints the character owns  - -- Alternate route: &#x60;/v2/characters/{character_id}/blueprints/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCharactersCharacterIdBlueprints200Ok&gt;</returns>            
        public List<GetCharactersCharacterIdBlueprints200Ok> GetCharactersCharacterIdBlueprints (int? characterId, string datasource, string ifNoneMatch, int? page, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterIdBlueprints");
            
    
            var path = "/characters/{character_id}/blueprints/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdBlueprints: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdBlueprints: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCharactersCharacterIdBlueprints200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCharactersCharacterIdBlueprints200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get corporation history Get a list of all the corporations a character has been a member of  - -- Alternate route: &#x60;/legacy/characters/{character_id}/corporationhistory/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/corporationhistory/&#x60;  - -- This route is cached for up to 86400 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>List&lt;GetCharactersCharacterIdCorporationhistory200Ok&gt;</returns>            
        public List<GetCharactersCharacterIdCorporationhistory200Ok> GetCharactersCharacterIdCorporationhistory (int? characterId, string datasource, string ifNoneMatch)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterIdCorporationhistory");
            
    
            var path = "/characters/{character_id}/corporationhistory/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "character_id" + "}", ApiClient.ParameterToString(characterId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdCorporationhistory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdCorporationhistory: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCharactersCharacterIdCorporationhistory200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCharactersCharacterIdCorporationhistory200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get jump fatigue Return a character&#39;s jump activation and fatigue information  - -- Alternate route: &#x60;/legacy/characters/{character_id}/fatigue/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/fatigue/&#x60;  - -- This route is cached for up to 300 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>GetCharactersCharacterIdFatigueOk</returns>            
        public GetCharactersCharacterIdFatigueOk GetCharactersCharacterIdFatigue (int? characterId, string datasource, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterIdFatigue");
            
    
            var path = "/characters/{character_id}/fatigue/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdFatigue: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdFatigue: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetCharactersCharacterIdFatigueOk) ApiClient.Deserialize(response.Content, typeof(GetCharactersCharacterIdFatigueOk), response.Headers);
        }
    
        /// <summary>
        /// Get medals Return a list of medals the character has  - -- Alternate route: &#x60;/legacy/characters/{character_id}/medals/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/medals/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCharactersCharacterIdMedals200Ok&gt;</returns>            
        public List<GetCharactersCharacterIdMedals200Ok> GetCharactersCharacterIdMedals (int? characterId, string datasource, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterIdMedals");
            
    
            var path = "/characters/{character_id}/medals/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdMedals: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdMedals: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCharactersCharacterIdMedals200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCharactersCharacterIdMedals200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get character notifications Return character notifications  - -- Alternate route: &#x60;/dev/characters/{character_id}/notifications/&#x60;  Alternate route: &#x60;/v5/characters/{character_id}/notifications/&#x60;  Alternate route: &#x60;/v6/characters/{character_id}/notifications/&#x60;  - -- This route is cached for up to 600 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCharactersCharacterIdNotifications200Ok&gt;</returns>            
        public List<GetCharactersCharacterIdNotifications200Ok> GetCharactersCharacterIdNotifications (int? characterId, string datasource, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterIdNotifications");
            
    
            var path = "/characters/{character_id}/notifications/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdNotifications: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdNotifications: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCharactersCharacterIdNotifications200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCharactersCharacterIdNotifications200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get new contact notifications Return notifications about having been added to someone&#39;s contact list  - -- Alternate route: &#x60;/legacy/characters/{character_id}/notifications/contacts/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/notifications/contacts/&#x60;  - -- This route is cached for up to 600 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCharactersCharacterIdNotificationsContacts200Ok&gt;</returns>            
        public List<GetCharactersCharacterIdNotificationsContacts200Ok> GetCharactersCharacterIdNotificationsContacts (int? characterId, string datasource, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterIdNotificationsContacts");
            
    
            var path = "/characters/{character_id}/notifications/contacts/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdNotificationsContacts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdNotificationsContacts: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCharactersCharacterIdNotificationsContacts200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCharactersCharacterIdNotificationsContacts200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get character portraits Get portrait urls for a character  - -- Alternate route: &#x60;/dev/characters/{character_id}/portrait/&#x60;  Alternate route: &#x60;/v2/characters/{character_id}/portrait/&#x60;  Alternate route: &#x60;/v3/characters/{character_id}/portrait/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>GetCharactersCharacterIdPortraitOk</returns>            
        public GetCharactersCharacterIdPortraitOk GetCharactersCharacterIdPortrait (int? characterId, string datasource, string ifNoneMatch)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterIdPortrait");
            
    
            var path = "/characters/{character_id}/portrait/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "character_id" + "}", ApiClient.ParameterToString(characterId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdPortrait: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdPortrait: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetCharactersCharacterIdPortraitOk) ApiClient.Deserialize(response.Content, typeof(GetCharactersCharacterIdPortraitOk), response.Headers);
        }
    
        /// <summary>
        /// Get character corporation roles Returns a character&#39;s corporation roles  - -- Alternate route: &#x60;/v2/characters/{character_id}/roles/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>GetCharactersCharacterIdRolesOk</returns>            
        public GetCharactersCharacterIdRolesOk GetCharactersCharacterIdRoles (int? characterId, string datasource, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterIdRoles");
            
    
            var path = "/characters/{character_id}/roles/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdRoles: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdRoles: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetCharactersCharacterIdRolesOk) ApiClient.Deserialize(response.Content, typeof(GetCharactersCharacterIdRolesOk), response.Headers);
        }
    
        /// <summary>
        /// Get standings Return character standings from agents, NPC corporations, and factions  - -- Alternate route: &#x60;/legacy/characters/{character_id}/standings/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/standings/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCharactersCharacterIdStandings200Ok&gt;</returns>            
        public List<GetCharactersCharacterIdStandings200Ok> GetCharactersCharacterIdStandings (int? characterId, string datasource, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterIdStandings");
            
    
            var path = "/characters/{character_id}/standings/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdStandings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdStandings: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCharactersCharacterIdStandings200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCharactersCharacterIdStandings200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Yearly aggregate stats Returns aggregate yearly stats for a character  - -- Alternate route: &#x60;/dev/characters/{character_id}/stats/&#x60;  Alternate route: &#x60;/v2/characters/{character_id}/stats/&#x60;  - -- This route is cached for up to 86400 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCharactersCharacterIdStats200Ok&gt;</returns>            
        public List<GetCharactersCharacterIdStats200Ok> GetCharactersCharacterIdStats (int? characterId, string datasource, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterIdStats");
            
    
            var path = "/characters/{character_id}/stats/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdStats: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdStats: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCharactersCharacterIdStats200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCharactersCharacterIdStats200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get character corporation titles Returns a character&#39;s titles  - -- Alternate route: &#x60;/legacy/characters/{character_id}/titles/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/titles/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCharactersCharacterIdTitles200Ok&gt;</returns>            
        public List<GetCharactersCharacterIdTitles200Ok> GetCharactersCharacterIdTitles (int? characterId, string datasource, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterIdTitles");
            
    
            var path = "/characters/{character_id}/titles/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdTitles: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdTitles: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCharactersCharacterIdTitles200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCharactersCharacterIdTitles200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Character affiliation Bulk lookup of character IDs to corporation, alliance and faction  - -- Alternate route: &#x60;/legacy/characters/affiliation/&#x60;  Alternate route: &#x60;/v1/characters/affiliation/&#x60;  - -- This route is cached for up to 3600 seconds  - -- [Diff of the upcoming changes](https://esi.evetech.net/diff/latest/dev/#POST-/characters/affiliation/)
        /// </summary>
        /// <param name="characters">The character IDs to fetch affiliations for. All characters must exist, or none will be returned</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <returns>List&lt;PostCharactersAffiliation200Ok&gt;</returns>            
        public List<PostCharactersAffiliation200Ok> PostCharactersAffiliation (List<int?> characters, string datasource)
        {
            
            // verify the required parameter 'characters' is set
            if (characters == null) throw new ApiException(400, "Missing required parameter 'characters' when calling PostCharactersAffiliation");
            
    
            var path = "/characters/affiliation/";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
                                    postBody = ApiClient.Serialize(characters); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostCharactersAffiliation: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostCharactersAffiliation: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<PostCharactersAffiliation200Ok>) ApiClient.Deserialize(response.Content, typeof(List<PostCharactersAffiliation200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Calculate a CSPA charge cost Takes a source character ID in the url and a set of target character ID&#39;s in the body, returns a CSPA charge cost  - -- Alternate route: &#x60;/v4/characters/{character_id}/cspa/&#x60; 
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="characters">The target characters to calculate the charge for</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>float?</returns>            
        public float? PostCharactersCharacterIdCspa (int? characterId, List<int?> characters, string datasource, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling PostCharactersCharacterIdCspa");
            
            // verify the required parameter 'characters' is set
            if (characters == null) throw new ApiException(400, "Missing required parameter 'characters' when calling PostCharactersCharacterIdCspa");
            
    
            var path = "/characters/{character_id}/cspa/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "character_id" + "}", ApiClient.ParameterToString(characterId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                    postBody = ApiClient.Serialize(characters); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "evesso" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostCharactersCharacterIdCspa: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostCharactersCharacterIdCspa: " + response.ErrorMessage, response.ErrorMessage);
    
            return (float?) ApiClient.Deserialize(response.Content, typeof(float?), response.Headers);
        }
    
    }
}
