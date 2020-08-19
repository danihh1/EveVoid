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
    public interface IFleetsApi
    {
        /// <summary>
        /// Kick fleet member Kick a fleet member  - -- Alternate route: &#x60;/dev/fleets/{fleet_id}/members/{member_id}/&#x60;  Alternate route: &#x60;/legacy/fleets/{fleet_id}/members/{member_id}/&#x60;  Alternate route: &#x60;/v1/fleets/{fleet_id}/members/{member_id}/&#x60; 
        /// </summary>
        /// <param name="fleetId">ID for a fleet</param>
        /// <param name="memberId">The character ID of a member in this fleet</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns></returns>
        void DeleteFleetsFleetIdMembersMemberId (long? fleetId, int? memberId, string datasource, string token);
        /// <summary>
        /// Delete fleet squad Delete a fleet squad, only empty squads can be deleted  - -- Alternate route: &#x60;/dev/fleets/{fleet_id}/squads/{squad_id}/&#x60;  Alternate route: &#x60;/legacy/fleets/{fleet_id}/squads/{squad_id}/&#x60;  Alternate route: &#x60;/v1/fleets/{fleet_id}/squads/{squad_id}/&#x60; 
        /// </summary>
        /// <param name="fleetId">ID for a fleet</param>
        /// <param name="squadId">The squad to delete</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns></returns>
        void DeleteFleetsFleetIdSquadsSquadId (long? fleetId, long? squadId, string datasource, string token);
        /// <summary>
        /// Delete fleet wing Delete a fleet wing, only empty wings can be deleted. The wing may contain squads, but the squads must be empty  - -- Alternate route: &#x60;/dev/fleets/{fleet_id}/wings/{wing_id}/&#x60;  Alternate route: &#x60;/legacy/fleets/{fleet_id}/wings/{wing_id}/&#x60;  Alternate route: &#x60;/v1/fleets/{fleet_id}/wings/{wing_id}/&#x60; 
        /// </summary>
        /// <param name="fleetId">ID for a fleet</param>
        /// <param name="wingId">The wing to delete</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns></returns>
        void DeleteFleetsFleetIdWingsWingId (long? fleetId, long? wingId, string datasource, string token);
        /// <summary>
        /// Get character fleet info Return the fleet ID the character is in, if any.  - -- Alternate route: &#x60;/legacy/characters/{character_id}/fleet/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/fleet/&#x60;  - -- This route is cached for up to 60 seconds  - -- Warning: This route has an upgrade available  - -- [Diff of the upcoming changes](https://esi.evetech.net/diff/latest/dev/#GET-/characters/{character_id}/fleet/)
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>GetCharactersCharacterIdFleetOk</returns>
        GetCharactersCharacterIdFleetOk GetCharactersCharacterIdFleet (int? characterId, string datasource, string ifNoneMatch, string token);
        /// <summary>
        /// Get fleet information Return details about a fleet  - -- Alternate route: &#x60;/dev/fleets/{fleet_id}/&#x60;  Alternate route: &#x60;/legacy/fleets/{fleet_id}/&#x60;  Alternate route: &#x60;/v1/fleets/{fleet_id}/&#x60;  - -- This route is cached for up to 5 seconds
        /// </summary>
        /// <param name="fleetId">ID for a fleet</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>GetFleetsFleetIdOk</returns>
        GetFleetsFleetIdOk GetFleetsFleetId (long? fleetId, string datasource, string ifNoneMatch, string token);
        /// <summary>
        /// Get fleet members Return information about fleet members  - -- Alternate route: &#x60;/dev/fleets/{fleet_id}/members/&#x60;  Alternate route: &#x60;/legacy/fleets/{fleet_id}/members/&#x60;  Alternate route: &#x60;/v1/fleets/{fleet_id}/members/&#x60;  - -- This route is cached for up to 5 seconds
        /// </summary>
        /// <param name="fleetId">ID for a fleet</param>
        /// <param name="acceptLanguage">Language to use in the response</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="language">Language to use in the response, takes precedence over Accept-Language</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetFleetsFleetIdMembers200Ok&gt;</returns>
        List<GetFleetsFleetIdMembers200Ok> GetFleetsFleetIdMembers (long? fleetId, string acceptLanguage, string datasource, string ifNoneMatch, string language, string token);
        /// <summary>
        /// Get fleet wings Return information about wings in a fleet  - -- Alternate route: &#x60;/dev/fleets/{fleet_id}/wings/&#x60;  Alternate route: &#x60;/legacy/fleets/{fleet_id}/wings/&#x60;  Alternate route: &#x60;/v1/fleets/{fleet_id}/wings/&#x60;  - -- This route is cached for up to 5 seconds
        /// </summary>
        /// <param name="fleetId">ID for a fleet</param>
        /// <param name="acceptLanguage">Language to use in the response</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="language">Language to use in the response, takes precedence over Accept-Language</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetFleetsFleetIdWings200Ok&gt;</returns>
        List<GetFleetsFleetIdWings200Ok> GetFleetsFleetIdWings (long? fleetId, string acceptLanguage, string datasource, string ifNoneMatch, string language, string token);
        /// <summary>
        /// Create fleet invitation Invite a character into the fleet. If a character has a CSPA charge set it is not possible to invite them to the fleet using ESI  - -- Alternate route: &#x60;/dev/fleets/{fleet_id}/members/&#x60;  Alternate route: &#x60;/legacy/fleets/{fleet_id}/members/&#x60;  Alternate route: &#x60;/v1/fleets/{fleet_id}/members/&#x60; 
        /// </summary>
        /// <param name="fleetId">ID for a fleet</param>
        /// <param name="invitation">Details of the invitation</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns></returns>
        void PostFleetsFleetIdMembers (long? fleetId, PostFleetsFleetIdMembersInvitation invitation, string datasource, string token);
        /// <summary>
        /// Create fleet wing Create a new wing in a fleet  - -- Alternate route: &#x60;/dev/fleets/{fleet_id}/wings/&#x60;  Alternate route: &#x60;/legacy/fleets/{fleet_id}/wings/&#x60;  Alternate route: &#x60;/v1/fleets/{fleet_id}/wings/&#x60; 
        /// </summary>
        /// <param name="fleetId">ID for a fleet</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>PostFleetsFleetIdWingsCreated</returns>
        PostFleetsFleetIdWingsCreated PostFleetsFleetIdWings (long? fleetId, string datasource, string token);
        /// <summary>
        /// Create fleet squad Create a new squad in a fleet  - -- Alternate route: &#x60;/dev/fleets/{fleet_id}/wings/{wing_id}/squads/&#x60;  Alternate route: &#x60;/legacy/fleets/{fleet_id}/wings/{wing_id}/squads/&#x60;  Alternate route: &#x60;/v1/fleets/{fleet_id}/wings/{wing_id}/squads/&#x60; 
        /// </summary>
        /// <param name="fleetId">ID for a fleet</param>
        /// <param name="wingId">The wing_id to create squad in</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>PostFleetsFleetIdWingsWingIdSquadsCreated</returns>
        PostFleetsFleetIdWingsWingIdSquadsCreated PostFleetsFleetIdWingsWingIdSquads (long? fleetId, long? wingId, string datasource, string token);
        /// <summary>
        /// Update fleet Update settings about a fleet  - -- Alternate route: &#x60;/dev/fleets/{fleet_id}/&#x60;  Alternate route: &#x60;/legacy/fleets/{fleet_id}/&#x60;  Alternate route: &#x60;/v1/fleets/{fleet_id}/&#x60; 
        /// </summary>
        /// <param name="fleetId">ID for a fleet</param>
        /// <param name="newSettings">What to update for this fleet</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns></returns>
        void PutFleetsFleetId (long? fleetId, PutFleetsFleetIdNewSettings newSettings, string datasource, string token);
        /// <summary>
        /// Move fleet member Move a fleet member around  - -- Alternate route: &#x60;/dev/fleets/{fleet_id}/members/{member_id}/&#x60;  Alternate route: &#x60;/legacy/fleets/{fleet_id}/members/{member_id}/&#x60;  Alternate route: &#x60;/v1/fleets/{fleet_id}/members/{member_id}/&#x60; 
        /// </summary>
        /// <param name="fleetId">ID for a fleet</param>
        /// <param name="memberId">The character ID of a member in this fleet</param>
        /// <param name="movement">Details of the invitation</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns></returns>
        void PutFleetsFleetIdMembersMemberId (long? fleetId, int? memberId, PutFleetsFleetIdMembersMemberIdMovement movement, string datasource, string token);
        /// <summary>
        /// Rename fleet squad Rename a fleet squad  - -- Alternate route: &#x60;/dev/fleets/{fleet_id}/squads/{squad_id}/&#x60;  Alternate route: &#x60;/legacy/fleets/{fleet_id}/squads/{squad_id}/&#x60;  Alternate route: &#x60;/v1/fleets/{fleet_id}/squads/{squad_id}/&#x60; 
        /// </summary>
        /// <param name="fleetId">ID for a fleet</param>
        /// <param name="naming">New name of the squad</param>
        /// <param name="squadId">The squad to rename</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns></returns>
        void PutFleetsFleetIdSquadsSquadId (long? fleetId, PutFleetsFleetIdSquadsSquadIdNaming naming, long? squadId, string datasource, string token);
        /// <summary>
        /// Rename fleet wing Rename a fleet wing  - -- Alternate route: &#x60;/dev/fleets/{fleet_id}/wings/{wing_id}/&#x60;  Alternate route: &#x60;/legacy/fleets/{fleet_id}/wings/{wing_id}/&#x60;  Alternate route: &#x60;/v1/fleets/{fleet_id}/wings/{wing_id}/&#x60; 
        /// </summary>
        /// <param name="fleetId">ID for a fleet</param>
        /// <param name="naming">New name of the wing</param>
        /// <param name="wingId">The wing to rename</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns></returns>
        void PutFleetsFleetIdWingsWingId (long? fleetId, PutFleetsFleetIdWingsWingIdNaming naming, long? wingId, string datasource, string token);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class FleetsApi : IFleetsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FleetsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public FleetsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FleetsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FleetsApi(String basePath)
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
        /// Kick fleet member Kick a fleet member  - -- Alternate route: &#x60;/dev/fleets/{fleet_id}/members/{member_id}/&#x60;  Alternate route: &#x60;/legacy/fleets/{fleet_id}/members/{member_id}/&#x60;  Alternate route: &#x60;/v1/fleets/{fleet_id}/members/{member_id}/&#x60; 
        /// </summary>
        /// <param name="fleetId">ID for a fleet</param> 
        /// <param name="memberId">The character ID of a member in this fleet</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns></returns>            
        public void DeleteFleetsFleetIdMembersMemberId (long? fleetId, int? memberId, string datasource, string token)
        {
            
            // verify the required parameter 'fleetId' is set
            if (fleetId == null) throw new ApiException(400, "Missing required parameter 'fleetId' when calling DeleteFleetsFleetIdMembersMemberId");
            
            // verify the required parameter 'memberId' is set
            if (memberId == null) throw new ApiException(400, "Missing required parameter 'memberId' when calling DeleteFleetsFleetIdMembersMemberId");
            
    
            var path = "/fleets/{fleet_id}/members/{member_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "fleet_id" + "}", ApiClient.ParameterToString(fleetId));
path = path.Replace("{" + "member_id" + "}", ApiClient.ParameterToString(memberId));
    
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteFleetsFleetIdMembersMemberId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteFleetsFleetIdMembersMemberId: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete fleet squad Delete a fleet squad, only empty squads can be deleted  - -- Alternate route: &#x60;/dev/fleets/{fleet_id}/squads/{squad_id}/&#x60;  Alternate route: &#x60;/legacy/fleets/{fleet_id}/squads/{squad_id}/&#x60;  Alternate route: &#x60;/v1/fleets/{fleet_id}/squads/{squad_id}/&#x60; 
        /// </summary>
        /// <param name="fleetId">ID for a fleet</param> 
        /// <param name="squadId">The squad to delete</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns></returns>            
        public void DeleteFleetsFleetIdSquadsSquadId (long? fleetId, long? squadId, string datasource, string token)
        {
            
            // verify the required parameter 'fleetId' is set
            if (fleetId == null) throw new ApiException(400, "Missing required parameter 'fleetId' when calling DeleteFleetsFleetIdSquadsSquadId");
            
            // verify the required parameter 'squadId' is set
            if (squadId == null) throw new ApiException(400, "Missing required parameter 'squadId' when calling DeleteFleetsFleetIdSquadsSquadId");
            
    
            var path = "/fleets/{fleet_id}/squads/{squad_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "fleet_id" + "}", ApiClient.ParameterToString(fleetId));
path = path.Replace("{" + "squad_id" + "}", ApiClient.ParameterToString(squadId));
    
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteFleetsFleetIdSquadsSquadId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteFleetsFleetIdSquadsSquadId: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete fleet wing Delete a fleet wing, only empty wings can be deleted. The wing may contain squads, but the squads must be empty  - -- Alternate route: &#x60;/dev/fleets/{fleet_id}/wings/{wing_id}/&#x60;  Alternate route: &#x60;/legacy/fleets/{fleet_id}/wings/{wing_id}/&#x60;  Alternate route: &#x60;/v1/fleets/{fleet_id}/wings/{wing_id}/&#x60; 
        /// </summary>
        /// <param name="fleetId">ID for a fleet</param> 
        /// <param name="wingId">The wing to delete</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns></returns>            
        public void DeleteFleetsFleetIdWingsWingId (long? fleetId, long? wingId, string datasource, string token)
        {
            
            // verify the required parameter 'fleetId' is set
            if (fleetId == null) throw new ApiException(400, "Missing required parameter 'fleetId' when calling DeleteFleetsFleetIdWingsWingId");
            
            // verify the required parameter 'wingId' is set
            if (wingId == null) throw new ApiException(400, "Missing required parameter 'wingId' when calling DeleteFleetsFleetIdWingsWingId");
            
    
            var path = "/fleets/{fleet_id}/wings/{wing_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "fleet_id" + "}", ApiClient.ParameterToString(fleetId));
path = path.Replace("{" + "wing_id" + "}", ApiClient.ParameterToString(wingId));
    
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteFleetsFleetIdWingsWingId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteFleetsFleetIdWingsWingId: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get character fleet info Return the fleet ID the character is in, if any.  - -- Alternate route: &#x60;/legacy/characters/{character_id}/fleet/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/fleet/&#x60;  - -- This route is cached for up to 60 seconds  - -- Warning: This route has an upgrade available  - -- [Diff of the upcoming changes](https://esi.evetech.net/diff/latest/dev/#GET-/characters/{character_id}/fleet/)
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>GetCharactersCharacterIdFleetOk</returns>            
        public GetCharactersCharacterIdFleetOk GetCharactersCharacterIdFleet (int? characterId, string datasource, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterIdFleet");
            
    
            var path = "/characters/{character_id}/fleet/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdFleet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdFleet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetCharactersCharacterIdFleetOk) ApiClient.Deserialize(response.Content, typeof(GetCharactersCharacterIdFleetOk), response.Headers);
        }
    
        /// <summary>
        /// Get fleet information Return details about a fleet  - -- Alternate route: &#x60;/dev/fleets/{fleet_id}/&#x60;  Alternate route: &#x60;/legacy/fleets/{fleet_id}/&#x60;  Alternate route: &#x60;/v1/fleets/{fleet_id}/&#x60;  - -- This route is cached for up to 5 seconds
        /// </summary>
        /// <param name="fleetId">ID for a fleet</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>GetFleetsFleetIdOk</returns>            
        public GetFleetsFleetIdOk GetFleetsFleetId (long? fleetId, string datasource, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'fleetId' is set
            if (fleetId == null) throw new ApiException(400, "Missing required parameter 'fleetId' when calling GetFleetsFleetId");
            
    
            var path = "/fleets/{fleet_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "fleet_id" + "}", ApiClient.ParameterToString(fleetId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetFleetsFleetId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFleetsFleetId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetFleetsFleetIdOk) ApiClient.Deserialize(response.Content, typeof(GetFleetsFleetIdOk), response.Headers);
        }
    
        /// <summary>
        /// Get fleet members Return information about fleet members  - -- Alternate route: &#x60;/dev/fleets/{fleet_id}/members/&#x60;  Alternate route: &#x60;/legacy/fleets/{fleet_id}/members/&#x60;  Alternate route: &#x60;/v1/fleets/{fleet_id}/members/&#x60;  - -- This route is cached for up to 5 seconds
        /// </summary>
        /// <param name="fleetId">ID for a fleet</param> 
        /// <param name="acceptLanguage">Language to use in the response</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="language">Language to use in the response, takes precedence over Accept-Language</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetFleetsFleetIdMembers200Ok&gt;</returns>            
        public List<GetFleetsFleetIdMembers200Ok> GetFleetsFleetIdMembers (long? fleetId, string acceptLanguage, string datasource, string ifNoneMatch, string language, string token)
        {
            
            // verify the required parameter 'fleetId' is set
            if (fleetId == null) throw new ApiException(400, "Missing required parameter 'fleetId' when calling GetFleetsFleetIdMembers");
            
    
            var path = "/fleets/{fleet_id}/members/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "fleet_id" + "}", ApiClient.ParameterToString(fleetId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
             if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
 if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "evesso" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFleetsFleetIdMembers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFleetsFleetIdMembers: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetFleetsFleetIdMembers200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetFleetsFleetIdMembers200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get fleet wings Return information about wings in a fleet  - -- Alternate route: &#x60;/dev/fleets/{fleet_id}/wings/&#x60;  Alternate route: &#x60;/legacy/fleets/{fleet_id}/wings/&#x60;  Alternate route: &#x60;/v1/fleets/{fleet_id}/wings/&#x60;  - -- This route is cached for up to 5 seconds
        /// </summary>
        /// <param name="fleetId">ID for a fleet</param> 
        /// <param name="acceptLanguage">Language to use in the response</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="language">Language to use in the response, takes precedence over Accept-Language</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetFleetsFleetIdWings200Ok&gt;</returns>            
        public List<GetFleetsFleetIdWings200Ok> GetFleetsFleetIdWings (long? fleetId, string acceptLanguage, string datasource, string ifNoneMatch, string language, string token)
        {
            
            // verify the required parameter 'fleetId' is set
            if (fleetId == null) throw new ApiException(400, "Missing required parameter 'fleetId' when calling GetFleetsFleetIdWings");
            
    
            var path = "/fleets/{fleet_id}/wings/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "fleet_id" + "}", ApiClient.ParameterToString(fleetId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
             if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
 if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "evesso" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFleetsFleetIdWings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFleetsFleetIdWings: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetFleetsFleetIdWings200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetFleetsFleetIdWings200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Create fleet invitation Invite a character into the fleet. If a character has a CSPA charge set it is not possible to invite them to the fleet using ESI  - -- Alternate route: &#x60;/dev/fleets/{fleet_id}/members/&#x60;  Alternate route: &#x60;/legacy/fleets/{fleet_id}/members/&#x60;  Alternate route: &#x60;/v1/fleets/{fleet_id}/members/&#x60; 
        /// </summary>
        /// <param name="fleetId">ID for a fleet</param> 
        /// <param name="invitation">Details of the invitation</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns></returns>            
        public void PostFleetsFleetIdMembers (long? fleetId, PostFleetsFleetIdMembersInvitation invitation, string datasource, string token)
        {
            
            // verify the required parameter 'fleetId' is set
            if (fleetId == null) throw new ApiException(400, "Missing required parameter 'fleetId' when calling PostFleetsFleetIdMembers");
            
            // verify the required parameter 'invitation' is set
            if (invitation == null) throw new ApiException(400, "Missing required parameter 'invitation' when calling PostFleetsFleetIdMembers");
            
    
            var path = "/fleets/{fleet_id}/members/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "fleet_id" + "}", ApiClient.ParameterToString(fleetId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                    postBody = ApiClient.Serialize(invitation); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "evesso" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostFleetsFleetIdMembers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostFleetsFleetIdMembers: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create fleet wing Create a new wing in a fleet  - -- Alternate route: &#x60;/dev/fleets/{fleet_id}/wings/&#x60;  Alternate route: &#x60;/legacy/fleets/{fleet_id}/wings/&#x60;  Alternate route: &#x60;/v1/fleets/{fleet_id}/wings/&#x60; 
        /// </summary>
        /// <param name="fleetId">ID for a fleet</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>PostFleetsFleetIdWingsCreated</returns>            
        public PostFleetsFleetIdWingsCreated PostFleetsFleetIdWings (long? fleetId, string datasource, string token)
        {
            
            // verify the required parameter 'fleetId' is set
            if (fleetId == null) throw new ApiException(400, "Missing required parameter 'fleetId' when calling PostFleetsFleetIdWings");
            
    
            var path = "/fleets/{fleet_id}/wings/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "fleet_id" + "}", ApiClient.ParameterToString(fleetId));
    
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostFleetsFleetIdWings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostFleetsFleetIdWings: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PostFleetsFleetIdWingsCreated) ApiClient.Deserialize(response.Content, typeof(PostFleetsFleetIdWingsCreated), response.Headers);
        }
    
        /// <summary>
        /// Create fleet squad Create a new squad in a fleet  - -- Alternate route: &#x60;/dev/fleets/{fleet_id}/wings/{wing_id}/squads/&#x60;  Alternate route: &#x60;/legacy/fleets/{fleet_id}/wings/{wing_id}/squads/&#x60;  Alternate route: &#x60;/v1/fleets/{fleet_id}/wings/{wing_id}/squads/&#x60; 
        /// </summary>
        /// <param name="fleetId">ID for a fleet</param> 
        /// <param name="wingId">The wing_id to create squad in</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>PostFleetsFleetIdWingsWingIdSquadsCreated</returns>            
        public PostFleetsFleetIdWingsWingIdSquadsCreated PostFleetsFleetIdWingsWingIdSquads (long? fleetId, long? wingId, string datasource, string token)
        {
            
            // verify the required parameter 'fleetId' is set
            if (fleetId == null) throw new ApiException(400, "Missing required parameter 'fleetId' when calling PostFleetsFleetIdWingsWingIdSquads");
            
            // verify the required parameter 'wingId' is set
            if (wingId == null) throw new ApiException(400, "Missing required parameter 'wingId' when calling PostFleetsFleetIdWingsWingIdSquads");
            
    
            var path = "/fleets/{fleet_id}/wings/{wing_id}/squads/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "fleet_id" + "}", ApiClient.ParameterToString(fleetId));
path = path.Replace("{" + "wing_id" + "}", ApiClient.ParameterToString(wingId));
    
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostFleetsFleetIdWingsWingIdSquads: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostFleetsFleetIdWingsWingIdSquads: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PostFleetsFleetIdWingsWingIdSquadsCreated) ApiClient.Deserialize(response.Content, typeof(PostFleetsFleetIdWingsWingIdSquadsCreated), response.Headers);
        }
    
        /// <summary>
        /// Update fleet Update settings about a fleet  - -- Alternate route: &#x60;/dev/fleets/{fleet_id}/&#x60;  Alternate route: &#x60;/legacy/fleets/{fleet_id}/&#x60;  Alternate route: &#x60;/v1/fleets/{fleet_id}/&#x60; 
        /// </summary>
        /// <param name="fleetId">ID for a fleet</param> 
        /// <param name="newSettings">What to update for this fleet</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns></returns>            
        public void PutFleetsFleetId (long? fleetId, PutFleetsFleetIdNewSettings newSettings, string datasource, string token)
        {
            
            // verify the required parameter 'fleetId' is set
            if (fleetId == null) throw new ApiException(400, "Missing required parameter 'fleetId' when calling PutFleetsFleetId");
            
            // verify the required parameter 'newSettings' is set
            if (newSettings == null) throw new ApiException(400, "Missing required parameter 'newSettings' when calling PutFleetsFleetId");
            
    
            var path = "/fleets/{fleet_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "fleet_id" + "}", ApiClient.ParameterToString(fleetId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                    postBody = ApiClient.Serialize(newSettings); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "evesso" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PutFleetsFleetId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutFleetsFleetId: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Move fleet member Move a fleet member around  - -- Alternate route: &#x60;/dev/fleets/{fleet_id}/members/{member_id}/&#x60;  Alternate route: &#x60;/legacy/fleets/{fleet_id}/members/{member_id}/&#x60;  Alternate route: &#x60;/v1/fleets/{fleet_id}/members/{member_id}/&#x60; 
        /// </summary>
        /// <param name="fleetId">ID for a fleet</param> 
        /// <param name="memberId">The character ID of a member in this fleet</param> 
        /// <param name="movement">Details of the invitation</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns></returns>            
        public void PutFleetsFleetIdMembersMemberId (long? fleetId, int? memberId, PutFleetsFleetIdMembersMemberIdMovement movement, string datasource, string token)
        {
            
            // verify the required parameter 'fleetId' is set
            if (fleetId == null) throw new ApiException(400, "Missing required parameter 'fleetId' when calling PutFleetsFleetIdMembersMemberId");
            
            // verify the required parameter 'memberId' is set
            if (memberId == null) throw new ApiException(400, "Missing required parameter 'memberId' when calling PutFleetsFleetIdMembersMemberId");
            
            // verify the required parameter 'movement' is set
            if (movement == null) throw new ApiException(400, "Missing required parameter 'movement' when calling PutFleetsFleetIdMembersMemberId");
            
    
            var path = "/fleets/{fleet_id}/members/{member_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "fleet_id" + "}", ApiClient.ParameterToString(fleetId));
path = path.Replace("{" + "member_id" + "}", ApiClient.ParameterToString(memberId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                    postBody = ApiClient.Serialize(movement); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "evesso" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PutFleetsFleetIdMembersMemberId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutFleetsFleetIdMembersMemberId: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Rename fleet squad Rename a fleet squad  - -- Alternate route: &#x60;/dev/fleets/{fleet_id}/squads/{squad_id}/&#x60;  Alternate route: &#x60;/legacy/fleets/{fleet_id}/squads/{squad_id}/&#x60;  Alternate route: &#x60;/v1/fleets/{fleet_id}/squads/{squad_id}/&#x60; 
        /// </summary>
        /// <param name="fleetId">ID for a fleet</param> 
        /// <param name="naming">New name of the squad</param> 
        /// <param name="squadId">The squad to rename</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns></returns>            
        public void PutFleetsFleetIdSquadsSquadId (long? fleetId, PutFleetsFleetIdSquadsSquadIdNaming naming, long? squadId, string datasource, string token)
        {
            
            // verify the required parameter 'fleetId' is set
            if (fleetId == null) throw new ApiException(400, "Missing required parameter 'fleetId' when calling PutFleetsFleetIdSquadsSquadId");
            
            // verify the required parameter 'naming' is set
            if (naming == null) throw new ApiException(400, "Missing required parameter 'naming' when calling PutFleetsFleetIdSquadsSquadId");
            
            // verify the required parameter 'squadId' is set
            if (squadId == null) throw new ApiException(400, "Missing required parameter 'squadId' when calling PutFleetsFleetIdSquadsSquadId");
            
    
            var path = "/fleets/{fleet_id}/squads/{squad_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "fleet_id" + "}", ApiClient.ParameterToString(fleetId));
path = path.Replace("{" + "squad_id" + "}", ApiClient.ParameterToString(squadId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                    postBody = ApiClient.Serialize(naming); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "evesso" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PutFleetsFleetIdSquadsSquadId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutFleetsFleetIdSquadsSquadId: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Rename fleet wing Rename a fleet wing  - -- Alternate route: &#x60;/dev/fleets/{fleet_id}/wings/{wing_id}/&#x60;  Alternate route: &#x60;/legacy/fleets/{fleet_id}/wings/{wing_id}/&#x60;  Alternate route: &#x60;/v1/fleets/{fleet_id}/wings/{wing_id}/&#x60; 
        /// </summary>
        /// <param name="fleetId">ID for a fleet</param> 
        /// <param name="naming">New name of the wing</param> 
        /// <param name="wingId">The wing to rename</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns></returns>            
        public void PutFleetsFleetIdWingsWingId (long? fleetId, PutFleetsFleetIdWingsWingIdNaming naming, long? wingId, string datasource, string token)
        {
            
            // verify the required parameter 'fleetId' is set
            if (fleetId == null) throw new ApiException(400, "Missing required parameter 'fleetId' when calling PutFleetsFleetIdWingsWingId");
            
            // verify the required parameter 'naming' is set
            if (naming == null) throw new ApiException(400, "Missing required parameter 'naming' when calling PutFleetsFleetIdWingsWingId");
            
            // verify the required parameter 'wingId' is set
            if (wingId == null) throw new ApiException(400, "Missing required parameter 'wingId' when calling PutFleetsFleetIdWingsWingId");
            
    
            var path = "/fleets/{fleet_id}/wings/{wing_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "fleet_id" + "}", ApiClient.ParameterToString(fleetId));
path = path.Replace("{" + "wing_id" + "}", ApiClient.ParameterToString(wingId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                    postBody = ApiClient.Serialize(naming); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "evesso" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PutFleetsFleetIdWingsWingId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutFleetsFleetIdWingsWingId: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
