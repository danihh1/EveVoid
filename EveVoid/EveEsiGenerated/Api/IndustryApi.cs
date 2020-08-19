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
    public interface IIndustryApi
    {
        /// <summary>
        /// List character industry jobs List industry jobs placed by a character  - -- Alternate route: &#x60;/dev/characters/{character_id}/industry/jobs/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/industry/jobs/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/industry/jobs/&#x60;  - -- This route is cached for up to 300 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="includeCompleted">Whether to retrieve completed character industry jobs. Only includes jobs from the past 90 days</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCharactersCharacterIdIndustryJobs200Ok&gt;</returns>
        List<GetCharactersCharacterIdIndustryJobs200Ok> GetCharactersCharacterIdIndustryJobs (int? characterId, string datasource, string ifNoneMatch, bool? includeCompleted, string token);
        /// <summary>
        /// Character mining ledger Paginated record of all mining done by a character for the past 30 days   - -- Alternate route: &#x60;/dev/characters/{character_id}/mining/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/mining/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/mining/&#x60;  - -- This route is cached for up to 600 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="page">Which page of results to return</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCharactersCharacterIdMining200Ok&gt;</returns>
        List<GetCharactersCharacterIdMining200Ok> GetCharactersCharacterIdMining (int? characterId, string datasource, string ifNoneMatch, int? page, string token);
        /// <summary>
        /// Moon extraction timers Extraction timers for all moon chunks being extracted by refineries belonging to a corporation.   - -- Alternate route: &#x60;/dev/corporation/{corporation_id}/mining/extractions/&#x60;  Alternate route: &#x60;/legacy/corporation/{corporation_id}/mining/extractions/&#x60;  Alternate route: &#x60;/v1/corporation/{corporation_id}/mining/extractions/&#x60;  - -- This route is cached for up to 1800 seconds  - -- Requires one of the following EVE corporation role(s): Station_Manager 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="page">Which page of results to return</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCorporationCorporationIdMiningExtractions200Ok&gt;</returns>
        List<GetCorporationCorporationIdMiningExtractions200Ok> GetCorporationCorporationIdMiningExtractions (int? corporationId, string datasource, string ifNoneMatch, int? page, string token);
        /// <summary>
        /// Corporation mining observers Paginated list of all entities capable of observing and recording mining for a corporation   - -- Alternate route: &#x60;/dev/corporation/{corporation_id}/mining/observers/&#x60;  Alternate route: &#x60;/legacy/corporation/{corporation_id}/mining/observers/&#x60;  Alternate route: &#x60;/v1/corporation/{corporation_id}/mining/observers/&#x60;  - -- This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Accountant 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="page">Which page of results to return</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCorporationCorporationIdMiningObservers200Ok&gt;</returns>
        List<GetCorporationCorporationIdMiningObservers200Ok> GetCorporationCorporationIdMiningObservers (int? corporationId, string datasource, string ifNoneMatch, int? page, string token);
        /// <summary>
        /// Observed corporation mining Paginated record of all mining seen by an observer   - -- Alternate route: &#x60;/dev/corporation/{corporation_id}/mining/observers/{observer_id}/&#x60;  Alternate route: &#x60;/legacy/corporation/{corporation_id}/mining/observers/{observer_id}/&#x60;  Alternate route: &#x60;/v1/corporation/{corporation_id}/mining/observers/{observer_id}/&#x60;  - -- This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Accountant 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="observerId">A mining observer id</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="page">Which page of results to return</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCorporationCorporationIdMiningObserversObserverId200Ok&gt;</returns>
        List<GetCorporationCorporationIdMiningObserversObserverId200Ok> GetCorporationCorporationIdMiningObserversObserverId (int? corporationId, long? observerId, string datasource, string ifNoneMatch, int? page, string token);
        /// <summary>
        /// List corporation industry jobs List industry jobs run by a corporation  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/industry/jobs/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/industry/jobs/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/industry/jobs/&#x60;  - -- This route is cached for up to 300 seconds  - -- Requires one of the following EVE corporation role(s): Factory_Manager 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="includeCompleted">Whether to retrieve completed corporation industry jobs. Only includes jobs from the past 90 days</param>
        /// <param name="page">Which page of results to return</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCorporationsCorporationIdIndustryJobs200Ok&gt;</returns>
        List<GetCorporationsCorporationIdIndustryJobs200Ok> GetCorporationsCorporationIdIndustryJobs (int? corporationId, string datasource, string ifNoneMatch, bool? includeCompleted, int? page, string token);
        /// <summary>
        /// List industry facilities Return a list of industry facilities  - -- Alternate route: &#x60;/dev/industry/facilities/&#x60;  Alternate route: &#x60;/legacy/industry/facilities/&#x60;  Alternate route: &#x60;/v1/industry/facilities/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>List&lt;GetIndustryFacilities200Ok&gt;</returns>
        List<GetIndustryFacilities200Ok> GetIndustryFacilities (string datasource, string ifNoneMatch);
        /// <summary>
        /// List solar system cost indices Return cost indices for solar systems  - -- Alternate route: &#x60;/dev/industry/systems/&#x60;  Alternate route: &#x60;/legacy/industry/systems/&#x60;  Alternate route: &#x60;/v1/industry/systems/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>List&lt;GetIndustrySystems200Ok&gt;</returns>
        List<GetIndustrySystems200Ok> GetIndustrySystems (string datasource, string ifNoneMatch);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class IndustryApi : IIndustryApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IndustryApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public IndustryApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IndustryApi"/> class.
        /// </summary>
        /// <returns></returns>
        public IndustryApi(String basePath)
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
        /// List character industry jobs List industry jobs placed by a character  - -- Alternate route: &#x60;/dev/characters/{character_id}/industry/jobs/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/industry/jobs/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/industry/jobs/&#x60;  - -- This route is cached for up to 300 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="includeCompleted">Whether to retrieve completed character industry jobs. Only includes jobs from the past 90 days</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCharactersCharacterIdIndustryJobs200Ok&gt;</returns>            
        public List<GetCharactersCharacterIdIndustryJobs200Ok> GetCharactersCharacterIdIndustryJobs (int? characterId, string datasource, string ifNoneMatch, bool? includeCompleted, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterIdIndustryJobs");
            
    
            var path = "/characters/{character_id}/industry/jobs/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "character_id" + "}", ApiClient.ParameterToString(characterId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (includeCompleted != null) queryParams.Add("include_completed", ApiClient.ParameterToString(includeCompleted)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
             if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "evesso" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdIndustryJobs: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdIndustryJobs: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCharactersCharacterIdIndustryJobs200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCharactersCharacterIdIndustryJobs200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Character mining ledger Paginated record of all mining done by a character for the past 30 days   - -- Alternate route: &#x60;/dev/characters/{character_id}/mining/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/mining/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/mining/&#x60;  - -- This route is cached for up to 600 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCharactersCharacterIdMining200Ok&gt;</returns>            
        public List<GetCharactersCharacterIdMining200Ok> GetCharactersCharacterIdMining (int? characterId, string datasource, string ifNoneMatch, int? page, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterIdMining");
            
    
            var path = "/characters/{character_id}/mining/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdMining: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdMining: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCharactersCharacterIdMining200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCharactersCharacterIdMining200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Moon extraction timers Extraction timers for all moon chunks being extracted by refineries belonging to a corporation.   - -- Alternate route: &#x60;/dev/corporation/{corporation_id}/mining/extractions/&#x60;  Alternate route: &#x60;/legacy/corporation/{corporation_id}/mining/extractions/&#x60;  Alternate route: &#x60;/v1/corporation/{corporation_id}/mining/extractions/&#x60;  - -- This route is cached for up to 1800 seconds  - -- Requires one of the following EVE corporation role(s): Station_Manager 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCorporationCorporationIdMiningExtractions200Ok&gt;</returns>            
        public List<GetCorporationCorporationIdMiningExtractions200Ok> GetCorporationCorporationIdMiningExtractions (int? corporationId, string datasource, string ifNoneMatch, int? page, string token)
        {
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling GetCorporationCorporationIdMiningExtractions");
            
    
            var path = "/corporation/{corporation_id}/mining/extractions/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationCorporationIdMiningExtractions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationCorporationIdMiningExtractions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCorporationCorporationIdMiningExtractions200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCorporationCorporationIdMiningExtractions200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Corporation mining observers Paginated list of all entities capable of observing and recording mining for a corporation   - -- Alternate route: &#x60;/dev/corporation/{corporation_id}/mining/observers/&#x60;  Alternate route: &#x60;/legacy/corporation/{corporation_id}/mining/observers/&#x60;  Alternate route: &#x60;/v1/corporation/{corporation_id}/mining/observers/&#x60;  - -- This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Accountant 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCorporationCorporationIdMiningObservers200Ok&gt;</returns>            
        public List<GetCorporationCorporationIdMiningObservers200Ok> GetCorporationCorporationIdMiningObservers (int? corporationId, string datasource, string ifNoneMatch, int? page, string token)
        {
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling GetCorporationCorporationIdMiningObservers");
            
    
            var path = "/corporation/{corporation_id}/mining/observers/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationCorporationIdMiningObservers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationCorporationIdMiningObservers: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCorporationCorporationIdMiningObservers200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCorporationCorporationIdMiningObservers200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Observed corporation mining Paginated record of all mining seen by an observer   - -- Alternate route: &#x60;/dev/corporation/{corporation_id}/mining/observers/{observer_id}/&#x60;  Alternate route: &#x60;/legacy/corporation/{corporation_id}/mining/observers/{observer_id}/&#x60;  Alternate route: &#x60;/v1/corporation/{corporation_id}/mining/observers/{observer_id}/&#x60;  - -- This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Accountant 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="observerId">A mining observer id</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCorporationCorporationIdMiningObserversObserverId200Ok&gt;</returns>            
        public List<GetCorporationCorporationIdMiningObserversObserverId200Ok> GetCorporationCorporationIdMiningObserversObserverId (int? corporationId, long? observerId, string datasource, string ifNoneMatch, int? page, string token)
        {
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling GetCorporationCorporationIdMiningObserversObserverId");
            
            // verify the required parameter 'observerId' is set
            if (observerId == null) throw new ApiException(400, "Missing required parameter 'observerId' when calling GetCorporationCorporationIdMiningObserversObserverId");
            
    
            var path = "/corporation/{corporation_id}/mining/observers/{observer_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "corporation_id" + "}", ApiClient.ParameterToString(corporationId));
path = path.Replace("{" + "observer_id" + "}", ApiClient.ParameterToString(observerId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationCorporationIdMiningObserversObserverId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationCorporationIdMiningObserversObserverId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCorporationCorporationIdMiningObserversObserverId200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCorporationCorporationIdMiningObserversObserverId200Ok>), response.Headers);
        }
    
        /// <summary>
        /// List corporation industry jobs List industry jobs run by a corporation  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/industry/jobs/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/industry/jobs/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/industry/jobs/&#x60;  - -- This route is cached for up to 300 seconds  - -- Requires one of the following EVE corporation role(s): Factory_Manager 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="includeCompleted">Whether to retrieve completed corporation industry jobs. Only includes jobs from the past 90 days</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCorporationsCorporationIdIndustryJobs200Ok&gt;</returns>            
        public List<GetCorporationsCorporationIdIndustryJobs200Ok> GetCorporationsCorporationIdIndustryJobs (int? corporationId, string datasource, string ifNoneMatch, bool? includeCompleted, int? page, string token)
        {
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling GetCorporationsCorporationIdIndustryJobs");
            
    
            var path = "/corporations/{corporation_id}/industry/jobs/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "corporation_id" + "}", ApiClient.ParameterToString(corporationId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (includeCompleted != null) queryParams.Add("include_completed", ApiClient.ParameterToString(includeCompleted)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
             if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "evesso" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdIndustryJobs: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdIndustryJobs: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCorporationsCorporationIdIndustryJobs200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCorporationsCorporationIdIndustryJobs200Ok>), response.Headers);
        }
    
        /// <summary>
        /// List industry facilities Return a list of industry facilities  - -- Alternate route: &#x60;/dev/industry/facilities/&#x60;  Alternate route: &#x60;/legacy/industry/facilities/&#x60;  Alternate route: &#x60;/v1/industry/facilities/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>List&lt;GetIndustryFacilities200Ok&gt;</returns>            
        public List<GetIndustryFacilities200Ok> GetIndustryFacilities (string datasource, string ifNoneMatch)
        {
            
    
            var path = "/industry/facilities/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetIndustryFacilities: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetIndustryFacilities: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetIndustryFacilities200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetIndustryFacilities200Ok>), response.Headers);
        }
    
        /// <summary>
        /// List solar system cost indices Return cost indices for solar systems  - -- Alternate route: &#x60;/dev/industry/systems/&#x60;  Alternate route: &#x60;/legacy/industry/systems/&#x60;  Alternate route: &#x60;/v1/industry/systems/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>List&lt;GetIndustrySystems200Ok&gt;</returns>            
        public List<GetIndustrySystems200Ok> GetIndustrySystems (string datasource, string ifNoneMatch)
        {
            
    
            var path = "/industry/systems/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetIndustrySystems: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetIndustrySystems: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetIndustrySystems200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetIndustrySystems200Ok>), response.Headers);
        }
    
    }
}
