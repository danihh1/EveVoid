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
    public interface ICorporationApi
    {
        /// <summary>
        /// Get corporation information Public information about a corporation  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/&#x60;  Alternate route: &#x60;/v4/corporations/{corporation_id}/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>GetCorporationsCorporationIdOk</returns>
        GetCorporationsCorporationIdOk GetCorporationsCorporationId (int? corporationId, string datasource, string ifNoneMatch);
        /// <summary>
        /// Get alliance history Get a list of all the alliances a corporation has been a member of  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/alliancehistory/&#x60;  Alternate route: &#x60;/v2/corporations/{corporation_id}/alliancehistory/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>List&lt;GetCorporationsCorporationIdAlliancehistory200Ok&gt;</returns>
        List<GetCorporationsCorporationIdAlliancehistory200Ok> GetCorporationsCorporationIdAlliancehistory (int? corporationId, string datasource, string ifNoneMatch);
        /// <summary>
        /// Get corporation blueprints Returns a list of blueprints the corporation owns  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/blueprints/&#x60;  Alternate route: &#x60;/v2/corporations/{corporation_id}/blueprints/&#x60;  - -- This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Director 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="page">Which page of results to return</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCorporationsCorporationIdBlueprints200Ok&gt;</returns>
        List<GetCorporationsCorporationIdBlueprints200Ok> GetCorporationsCorporationIdBlueprints (int? corporationId, string datasource, string ifNoneMatch, int? page, string token);
        /// <summary>
        /// Get all corporation ALSC logs Returns logs recorded in the past seven days from all audit log secure containers (ALSC) owned by a given corporation  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/containers/logs/&#x60;  Alternate route: &#x60;/v2/corporations/{corporation_id}/containers/logs/&#x60;  - -- This route is cached for up to 600 seconds  - -- Requires one of the following EVE corporation role(s): Director 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="page">Which page of results to return</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCorporationsCorporationIdContainersLogs200Ok&gt;</returns>
        List<GetCorporationsCorporationIdContainersLogs200Ok> GetCorporationsCorporationIdContainersLogs (int? corporationId, string datasource, string ifNoneMatch, int? page, string token);
        /// <summary>
        /// Get corporation divisions Return corporation hangar and wallet division names, only show if a division is not using the default name  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/divisions/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/divisions/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/divisions/&#x60;  - -- This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Director 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>GetCorporationsCorporationIdDivisionsOk</returns>
        GetCorporationsCorporationIdDivisionsOk GetCorporationsCorporationIdDivisions (int? corporationId, string datasource, string ifNoneMatch, string token);
        /// <summary>
        /// Get corporation facilities Return a corporation&#39;s facilities  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/facilities/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/facilities/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/facilities/&#x60;  - -- This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Factory_Manager 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCorporationsCorporationIdFacilities200Ok&gt;</returns>
        List<GetCorporationsCorporationIdFacilities200Ok> GetCorporationsCorporationIdFacilities (int? corporationId, string datasource, string ifNoneMatch, string token);
        /// <summary>
        /// Get corporation icon Get the icon urls for a corporation  - -- Alternate route: &#x60;/legacy/corporations/{corporation_id}/icons/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/icons/&#x60;  - -- This route is cached for up to 3600 seconds  - -- [Diff of the upcoming changes](https://esi.evetech.net/diff/latest/dev/#GET-/corporations/{corporation_id}/icons/)
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>GetCorporationsCorporationIdIconsOk</returns>
        GetCorporationsCorporationIdIconsOk GetCorporationsCorporationIdIcons (int? corporationId, string datasource, string ifNoneMatch);
        /// <summary>
        /// Get corporation medals Returns a corporation&#39;s medals  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/medals/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/medals/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/medals/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="page">Which page of results to return</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCorporationsCorporationIdMedals200Ok&gt;</returns>
        List<GetCorporationsCorporationIdMedals200Ok> GetCorporationsCorporationIdMedals (int? corporationId, string datasource, string ifNoneMatch, int? page, string token);
        /// <summary>
        /// Get corporation issued medals Returns medals issued by a corporation  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/medals/issued/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/medals/issued/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/medals/issued/&#x60;  - -- This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Director 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="page">Which page of results to return</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCorporationsCorporationIdMedalsIssued200Ok&gt;</returns>
        List<GetCorporationsCorporationIdMedalsIssued200Ok> GetCorporationsCorporationIdMedalsIssued (int? corporationId, string datasource, string ifNoneMatch, int? page, string token);
        /// <summary>
        /// Get corporation members Return the current member list of a corporation, the token&#39;s character need to be a member of the corporation.  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/members/&#x60;  Alternate route: &#x60;/v3/corporations/{corporation_id}/members/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;int?&gt;</returns>
        List<int?> GetCorporationsCorporationIdMembers (int? corporationId, string datasource, string ifNoneMatch, string token);
        /// <summary>
        /// Get corporation member limit Return a corporation&#39;s member limit, not including CEO himself  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/members/limit/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/members/limit/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/members/limit/&#x60;  - -- This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Director 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>int?</returns>
        int? GetCorporationsCorporationIdMembersLimit (int? corporationId, string datasource, string ifNoneMatch, string token);
        /// <summary>
        /// Get corporation&#39;s members&#39; titles Returns a corporation&#39;s members&#39; titles  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/members/titles/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/members/titles/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/members/titles/&#x60;  - -- This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Director 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCorporationsCorporationIdMembersTitles200Ok&gt;</returns>
        List<GetCorporationsCorporationIdMembersTitles200Ok> GetCorporationsCorporationIdMembersTitles (int? corporationId, string datasource, string ifNoneMatch, string token);
        /// <summary>
        /// Track corporation members Returns additional information about a corporation&#39;s members which helps tracking their activities  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/membertracking/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/membertracking/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/membertracking/&#x60;  - -- This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Director 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCorporationsCorporationIdMembertracking200Ok&gt;</returns>
        List<GetCorporationsCorporationIdMembertracking200Ok> GetCorporationsCorporationIdMembertracking (int? corporationId, string datasource, string ifNoneMatch, string token);
        /// <summary>
        /// Get corporation member roles Return the roles of all members if the character has the personnel manager role or any grantable role.  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/roles/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/roles/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/roles/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCorporationsCorporationIdRoles200Ok&gt;</returns>
        List<GetCorporationsCorporationIdRoles200Ok> GetCorporationsCorporationIdRoles (int? corporationId, string datasource, string ifNoneMatch, string token);
        /// <summary>
        /// Get corporation member roles history Return how roles have changed for a coporation&#39;s members, up to a month  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/roles/history/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/roles/history/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/roles/history/&#x60;  - -- This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Director 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="page">Which page of results to return</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCorporationsCorporationIdRolesHistory200Ok&gt;</returns>
        List<GetCorporationsCorporationIdRolesHistory200Ok> GetCorporationsCorporationIdRolesHistory (int? corporationId, string datasource, string ifNoneMatch, int? page, string token);
        /// <summary>
        /// Get corporation shareholders Return the current shareholders of a corporation.  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/shareholders/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/shareholders/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/shareholders/&#x60;  - -- This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Director 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="page">Which page of results to return</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCorporationsCorporationIdShareholders200Ok&gt;</returns>
        List<GetCorporationsCorporationIdShareholders200Ok> GetCorporationsCorporationIdShareholders (int? corporationId, string datasource, string ifNoneMatch, int? page, string token);
        /// <summary>
        /// Get corporation standings Return corporation standings from agents, NPC corporations, and factions  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/standings/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/standings/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/standings/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="page">Which page of results to return</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCorporationsCorporationIdStandings200Ok&gt;</returns>
        List<GetCorporationsCorporationIdStandings200Ok> GetCorporationsCorporationIdStandings (int? corporationId, string datasource, string ifNoneMatch, int? page, string token);
        /// <summary>
        /// Get corporation starbases (POSes) Returns list of corporation starbases (POSes)  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/starbases/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/starbases/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/starbases/&#x60;  - -- This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Director 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="page">Which page of results to return</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCorporationsCorporationIdStarbases200Ok&gt;</returns>
        List<GetCorporationsCorporationIdStarbases200Ok> GetCorporationsCorporationIdStarbases (int? corporationId, string datasource, string ifNoneMatch, int? page, string token);
        /// <summary>
        /// Get starbase (POS) detail Returns various settings and fuels of a starbase (POS)  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/starbases/{starbase_id}/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/starbases/{starbase_id}/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/starbases/{starbase_id}/&#x60;  - -- This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Director 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="starbaseId">An EVE starbase (POS) ID</param>
        /// <param name="systemId">The solar system this starbase (POS) is located in,</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>GetCorporationsCorporationIdStarbasesStarbaseIdOk</returns>
        GetCorporationsCorporationIdStarbasesStarbaseIdOk GetCorporationsCorporationIdStarbasesStarbaseId (int? corporationId, long? starbaseId, int? systemId, string datasource, string ifNoneMatch, string token);
        /// <summary>
        /// Get corporation structures Get a list of corporation structures. This route&#39;s version includes the changes to structures detailed in this blog: https://www.eveonline.com/article/upwell-2.0-structures-changes-coming-on-february-13th  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/structures/&#x60;  Alternate route: &#x60;/v3/corporations/{corporation_id}/structures/&#x60;  - -- This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Station_Manager 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="acceptLanguage">Language to use in the response</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="language">Language to use in the response, takes precedence over Accept-Language</param>
        /// <param name="page">Which page of results to return</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCorporationsCorporationIdStructures200Ok&gt;</returns>
        List<GetCorporationsCorporationIdStructures200Ok> GetCorporationsCorporationIdStructures (int? corporationId, string acceptLanguage, string datasource, string ifNoneMatch, string language, int? page, string token);
        /// <summary>
        /// Get corporation titles Returns a corporation&#39;s titles  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/titles/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/titles/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/titles/&#x60;  - -- This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Director 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCorporationsCorporationIdTitles200Ok&gt;</returns>
        List<GetCorporationsCorporationIdTitles200Ok> GetCorporationsCorporationIdTitles (int? corporationId, string datasource, string ifNoneMatch, string token);
        /// <summary>
        /// Get npc corporations Get a list of npc corporations  - -- Alternate route: &#x60;/dev/corporations/npccorps/&#x60;  Alternate route: &#x60;/legacy/corporations/npccorps/&#x60;  Alternate route: &#x60;/v1/corporations/npccorps/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>List&lt;int?&gt;</returns>
        List<int?> GetCorporationsNpccorps (string datasource, string ifNoneMatch);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CorporationApi : ICorporationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CorporationApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CorporationApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CorporationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CorporationApi(String basePath)
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
        /// Get corporation information Public information about a corporation  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/&#x60;  Alternate route: &#x60;/v4/corporations/{corporation_id}/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>GetCorporationsCorporationIdOk</returns>            
        public GetCorporationsCorporationIdOk GetCorporationsCorporationId (int? corporationId, string datasource, string ifNoneMatch)
        {
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling GetCorporationsCorporationId");
            
    
            var path = "/corporations/{corporation_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "corporation_id" + "}", ApiClient.ParameterToString(corporationId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetCorporationsCorporationIdOk) ApiClient.Deserialize(response.Content, typeof(GetCorporationsCorporationIdOk), response.Headers);
        }
    
        /// <summary>
        /// Get alliance history Get a list of all the alliances a corporation has been a member of  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/alliancehistory/&#x60;  Alternate route: &#x60;/v2/corporations/{corporation_id}/alliancehistory/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>List&lt;GetCorporationsCorporationIdAlliancehistory200Ok&gt;</returns>            
        public List<GetCorporationsCorporationIdAlliancehistory200Ok> GetCorporationsCorporationIdAlliancehistory (int? corporationId, string datasource, string ifNoneMatch)
        {
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling GetCorporationsCorporationIdAlliancehistory");
            
    
            var path = "/corporations/{corporation_id}/alliancehistory/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "corporation_id" + "}", ApiClient.ParameterToString(corporationId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdAlliancehistory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdAlliancehistory: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCorporationsCorporationIdAlliancehistory200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCorporationsCorporationIdAlliancehistory200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get corporation blueprints Returns a list of blueprints the corporation owns  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/blueprints/&#x60;  Alternate route: &#x60;/v2/corporations/{corporation_id}/blueprints/&#x60;  - -- This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Director 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCorporationsCorporationIdBlueprints200Ok&gt;</returns>            
        public List<GetCorporationsCorporationIdBlueprints200Ok> GetCorporationsCorporationIdBlueprints (int? corporationId, string datasource, string ifNoneMatch, int? page, string token)
        {
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling GetCorporationsCorporationIdBlueprints");
            
    
            var path = "/corporations/{corporation_id}/blueprints/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdBlueprints: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdBlueprints: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCorporationsCorporationIdBlueprints200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCorporationsCorporationIdBlueprints200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get all corporation ALSC logs Returns logs recorded in the past seven days from all audit log secure containers (ALSC) owned by a given corporation  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/containers/logs/&#x60;  Alternate route: &#x60;/v2/corporations/{corporation_id}/containers/logs/&#x60;  - -- This route is cached for up to 600 seconds  - -- Requires one of the following EVE corporation role(s): Director 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCorporationsCorporationIdContainersLogs200Ok&gt;</returns>            
        public List<GetCorporationsCorporationIdContainersLogs200Ok> GetCorporationsCorporationIdContainersLogs (int? corporationId, string datasource, string ifNoneMatch, int? page, string token)
        {
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling GetCorporationsCorporationIdContainersLogs");
            
    
            var path = "/corporations/{corporation_id}/containers/logs/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdContainersLogs: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdContainersLogs: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCorporationsCorporationIdContainersLogs200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCorporationsCorporationIdContainersLogs200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get corporation divisions Return corporation hangar and wallet division names, only show if a division is not using the default name  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/divisions/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/divisions/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/divisions/&#x60;  - -- This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Director 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>GetCorporationsCorporationIdDivisionsOk</returns>            
        public GetCorporationsCorporationIdDivisionsOk GetCorporationsCorporationIdDivisions (int? corporationId, string datasource, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling GetCorporationsCorporationIdDivisions");
            
    
            var path = "/corporations/{corporation_id}/divisions/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdDivisions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdDivisions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetCorporationsCorporationIdDivisionsOk) ApiClient.Deserialize(response.Content, typeof(GetCorporationsCorporationIdDivisionsOk), response.Headers);
        }
    
        /// <summary>
        /// Get corporation facilities Return a corporation&#39;s facilities  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/facilities/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/facilities/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/facilities/&#x60;  - -- This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Factory_Manager 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCorporationsCorporationIdFacilities200Ok&gt;</returns>            
        public List<GetCorporationsCorporationIdFacilities200Ok> GetCorporationsCorporationIdFacilities (int? corporationId, string datasource, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling GetCorporationsCorporationIdFacilities");
            
    
            var path = "/corporations/{corporation_id}/facilities/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdFacilities: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdFacilities: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCorporationsCorporationIdFacilities200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCorporationsCorporationIdFacilities200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get corporation icon Get the icon urls for a corporation  - -- Alternate route: &#x60;/legacy/corporations/{corporation_id}/icons/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/icons/&#x60;  - -- This route is cached for up to 3600 seconds  - -- [Diff of the upcoming changes](https://esi.evetech.net/diff/latest/dev/#GET-/corporations/{corporation_id}/icons/)
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>GetCorporationsCorporationIdIconsOk</returns>            
        public GetCorporationsCorporationIdIconsOk GetCorporationsCorporationIdIcons (int? corporationId, string datasource, string ifNoneMatch)
        {
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling GetCorporationsCorporationIdIcons");
            
    
            var path = "/corporations/{corporation_id}/icons/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "corporation_id" + "}", ApiClient.ParameterToString(corporationId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdIcons: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdIcons: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetCorporationsCorporationIdIconsOk) ApiClient.Deserialize(response.Content, typeof(GetCorporationsCorporationIdIconsOk), response.Headers);
        }
    
        /// <summary>
        /// Get corporation medals Returns a corporation&#39;s medals  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/medals/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/medals/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/medals/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCorporationsCorporationIdMedals200Ok&gt;</returns>            
        public List<GetCorporationsCorporationIdMedals200Ok> GetCorporationsCorporationIdMedals (int? corporationId, string datasource, string ifNoneMatch, int? page, string token)
        {
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling GetCorporationsCorporationIdMedals");
            
    
            var path = "/corporations/{corporation_id}/medals/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdMedals: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdMedals: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCorporationsCorporationIdMedals200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCorporationsCorporationIdMedals200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get corporation issued medals Returns medals issued by a corporation  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/medals/issued/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/medals/issued/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/medals/issued/&#x60;  - -- This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Director 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCorporationsCorporationIdMedalsIssued200Ok&gt;</returns>            
        public List<GetCorporationsCorporationIdMedalsIssued200Ok> GetCorporationsCorporationIdMedalsIssued (int? corporationId, string datasource, string ifNoneMatch, int? page, string token)
        {
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling GetCorporationsCorporationIdMedalsIssued");
            
    
            var path = "/corporations/{corporation_id}/medals/issued/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdMedalsIssued: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdMedalsIssued: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCorporationsCorporationIdMedalsIssued200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCorporationsCorporationIdMedalsIssued200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get corporation members Return the current member list of a corporation, the token&#39;s character need to be a member of the corporation.  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/members/&#x60;  Alternate route: &#x60;/v3/corporations/{corporation_id}/members/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;int?&gt;</returns>            
        public List<int?> GetCorporationsCorporationIdMembers (int? corporationId, string datasource, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling GetCorporationsCorporationIdMembers");
            
    
            var path = "/corporations/{corporation_id}/members/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdMembers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdMembers: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<int?>) ApiClient.Deserialize(response.Content, typeof(List<int?>), response.Headers);
        }
    
        /// <summary>
        /// Get corporation member limit Return a corporation&#39;s member limit, not including CEO himself  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/members/limit/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/members/limit/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/members/limit/&#x60;  - -- This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Director 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>int?</returns>            
        public int? GetCorporationsCorporationIdMembersLimit (int? corporationId, string datasource, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling GetCorporationsCorporationIdMembersLimit");
            
    
            var path = "/corporations/{corporation_id}/members/limit/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdMembersLimit: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdMembersLimit: " + response.ErrorMessage, response.ErrorMessage);
    
            return (int?) ApiClient.Deserialize(response.Content, typeof(int?), response.Headers);
        }
    
        /// <summary>
        /// Get corporation&#39;s members&#39; titles Returns a corporation&#39;s members&#39; titles  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/members/titles/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/members/titles/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/members/titles/&#x60;  - -- This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Director 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCorporationsCorporationIdMembersTitles200Ok&gt;</returns>            
        public List<GetCorporationsCorporationIdMembersTitles200Ok> GetCorporationsCorporationIdMembersTitles (int? corporationId, string datasource, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling GetCorporationsCorporationIdMembersTitles");
            
    
            var path = "/corporations/{corporation_id}/members/titles/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdMembersTitles: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdMembersTitles: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCorporationsCorporationIdMembersTitles200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCorporationsCorporationIdMembersTitles200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Track corporation members Returns additional information about a corporation&#39;s members which helps tracking their activities  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/membertracking/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/membertracking/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/membertracking/&#x60;  - -- This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Director 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCorporationsCorporationIdMembertracking200Ok&gt;</returns>            
        public List<GetCorporationsCorporationIdMembertracking200Ok> GetCorporationsCorporationIdMembertracking (int? corporationId, string datasource, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling GetCorporationsCorporationIdMembertracking");
            
    
            var path = "/corporations/{corporation_id}/membertracking/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdMembertracking: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdMembertracking: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCorporationsCorporationIdMembertracking200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCorporationsCorporationIdMembertracking200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get corporation member roles Return the roles of all members if the character has the personnel manager role or any grantable role.  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/roles/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/roles/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/roles/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCorporationsCorporationIdRoles200Ok&gt;</returns>            
        public List<GetCorporationsCorporationIdRoles200Ok> GetCorporationsCorporationIdRoles (int? corporationId, string datasource, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling GetCorporationsCorporationIdRoles");
            
    
            var path = "/corporations/{corporation_id}/roles/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdRoles: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdRoles: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCorporationsCorporationIdRoles200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCorporationsCorporationIdRoles200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get corporation member roles history Return how roles have changed for a coporation&#39;s members, up to a month  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/roles/history/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/roles/history/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/roles/history/&#x60;  - -- This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Director 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCorporationsCorporationIdRolesHistory200Ok&gt;</returns>            
        public List<GetCorporationsCorporationIdRolesHistory200Ok> GetCorporationsCorporationIdRolesHistory (int? corporationId, string datasource, string ifNoneMatch, int? page, string token)
        {
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling GetCorporationsCorporationIdRolesHistory");
            
    
            var path = "/corporations/{corporation_id}/roles/history/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdRolesHistory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdRolesHistory: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCorporationsCorporationIdRolesHistory200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCorporationsCorporationIdRolesHistory200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get corporation shareholders Return the current shareholders of a corporation.  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/shareholders/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/shareholders/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/shareholders/&#x60;  - -- This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Director 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCorporationsCorporationIdShareholders200Ok&gt;</returns>            
        public List<GetCorporationsCorporationIdShareholders200Ok> GetCorporationsCorporationIdShareholders (int? corporationId, string datasource, string ifNoneMatch, int? page, string token)
        {
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling GetCorporationsCorporationIdShareholders");
            
    
            var path = "/corporations/{corporation_id}/shareholders/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdShareholders: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdShareholders: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCorporationsCorporationIdShareholders200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCorporationsCorporationIdShareholders200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get corporation standings Return corporation standings from agents, NPC corporations, and factions  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/standings/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/standings/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/standings/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCorporationsCorporationIdStandings200Ok&gt;</returns>            
        public List<GetCorporationsCorporationIdStandings200Ok> GetCorporationsCorporationIdStandings (int? corporationId, string datasource, string ifNoneMatch, int? page, string token)
        {
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling GetCorporationsCorporationIdStandings");
            
    
            var path = "/corporations/{corporation_id}/standings/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdStandings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdStandings: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCorporationsCorporationIdStandings200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCorporationsCorporationIdStandings200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get corporation starbases (POSes) Returns list of corporation starbases (POSes)  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/starbases/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/starbases/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/starbases/&#x60;  - -- This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Director 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCorporationsCorporationIdStarbases200Ok&gt;</returns>            
        public List<GetCorporationsCorporationIdStarbases200Ok> GetCorporationsCorporationIdStarbases (int? corporationId, string datasource, string ifNoneMatch, int? page, string token)
        {
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling GetCorporationsCorporationIdStarbases");
            
    
            var path = "/corporations/{corporation_id}/starbases/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdStarbases: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdStarbases: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCorporationsCorporationIdStarbases200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCorporationsCorporationIdStarbases200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get starbase (POS) detail Returns various settings and fuels of a starbase (POS)  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/starbases/{starbase_id}/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/starbases/{starbase_id}/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/starbases/{starbase_id}/&#x60;  - -- This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Director 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="starbaseId">An EVE starbase (POS) ID</param> 
        /// <param name="systemId">The solar system this starbase (POS) is located in,</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>GetCorporationsCorporationIdStarbasesStarbaseIdOk</returns>            
        public GetCorporationsCorporationIdStarbasesStarbaseIdOk GetCorporationsCorporationIdStarbasesStarbaseId (int? corporationId, long? starbaseId, int? systemId, string datasource, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling GetCorporationsCorporationIdStarbasesStarbaseId");
            
            // verify the required parameter 'starbaseId' is set
            if (starbaseId == null) throw new ApiException(400, "Missing required parameter 'starbaseId' when calling GetCorporationsCorporationIdStarbasesStarbaseId");
            
            // verify the required parameter 'systemId' is set
            if (systemId == null) throw new ApiException(400, "Missing required parameter 'systemId' when calling GetCorporationsCorporationIdStarbasesStarbaseId");
            
    
            var path = "/corporations/{corporation_id}/starbases/{starbase_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "corporation_id" + "}", ApiClient.ParameterToString(corporationId));
path = path.Replace("{" + "starbase_id" + "}", ApiClient.ParameterToString(starbaseId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (systemId != null) queryParams.Add("system_id", ApiClient.ParameterToString(systemId)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
             if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "evesso" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdStarbasesStarbaseId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdStarbasesStarbaseId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetCorporationsCorporationIdStarbasesStarbaseIdOk) ApiClient.Deserialize(response.Content, typeof(GetCorporationsCorporationIdStarbasesStarbaseIdOk), response.Headers);
        }
    
        /// <summary>
        /// Get corporation structures Get a list of corporation structures. This route&#39;s version includes the changes to structures detailed in this blog: https://www.eveonline.com/article/upwell-2.0-structures-changes-coming-on-february-13th  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/structures/&#x60;  Alternate route: &#x60;/v3/corporations/{corporation_id}/structures/&#x60;  - -- This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Station_Manager 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="acceptLanguage">Language to use in the response</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="language">Language to use in the response, takes precedence over Accept-Language</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCorporationsCorporationIdStructures200Ok&gt;</returns>            
        public List<GetCorporationsCorporationIdStructures200Ok> GetCorporationsCorporationIdStructures (int? corporationId, string acceptLanguage, string datasource, string ifNoneMatch, string language, int? page, string token)
        {
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling GetCorporationsCorporationIdStructures");
            
    
            var path = "/corporations/{corporation_id}/structures/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "corporation_id" + "}", ApiClient.ParameterToString(corporationId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
             if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
 if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "evesso" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdStructures: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdStructures: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCorporationsCorporationIdStructures200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCorporationsCorporationIdStructures200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get corporation titles Returns a corporation&#39;s titles  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/titles/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/titles/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/titles/&#x60;  - -- This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Director 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCorporationsCorporationIdTitles200Ok&gt;</returns>            
        public List<GetCorporationsCorporationIdTitles200Ok> GetCorporationsCorporationIdTitles (int? corporationId, string datasource, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling GetCorporationsCorporationIdTitles");
            
    
            var path = "/corporations/{corporation_id}/titles/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdTitles: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdTitles: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCorporationsCorporationIdTitles200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCorporationsCorporationIdTitles200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get npc corporations Get a list of npc corporations  - -- Alternate route: &#x60;/dev/corporations/npccorps/&#x60;  Alternate route: &#x60;/legacy/corporations/npccorps/&#x60;  Alternate route: &#x60;/v1/corporations/npccorps/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>List&lt;int?&gt;</returns>            
        public List<int?> GetCorporationsNpccorps (string datasource, string ifNoneMatch)
        {
            
    
            var path = "/corporations/npccorps/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsNpccorps: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsNpccorps: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<int?>) ApiClient.Deserialize(response.Content, typeof(List<int?>), response.Headers);
        }
    
    }
}
