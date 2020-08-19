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
    public interface IOpportunitiesApi
    {
        /// <summary>
        /// Get a character&#39;s completed tasks Return a list of tasks finished by a character  - -- Alternate route: &#x60;/dev/characters/{character_id}/opportunities/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/opportunities/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/opportunities/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCharactersCharacterIdOpportunities200Ok&gt;</returns>
        List<GetCharactersCharacterIdOpportunities200Ok> GetCharactersCharacterIdOpportunities (int? characterId, string datasource, string ifNoneMatch, string token);
        /// <summary>
        /// Get opportunities groups Return a list of opportunities groups  - -- Alternate route: &#x60;/dev/opportunities/groups/&#x60;  Alternate route: &#x60;/legacy/opportunities/groups/&#x60;  Alternate route: &#x60;/v1/opportunities/groups/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>List&lt;int?&gt;</returns>
        List<int?> GetOpportunitiesGroups (string datasource, string ifNoneMatch);
        /// <summary>
        /// Get opportunities group Return information of an opportunities group  - -- Alternate route: &#x60;/dev/opportunities/groups/{group_id}/&#x60;  Alternate route: &#x60;/legacy/opportunities/groups/{group_id}/&#x60;  Alternate route: &#x60;/v1/opportunities/groups/{group_id}/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="groupId">ID of an opportunities group</param>
        /// <param name="acceptLanguage">Language to use in the response</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="language">Language to use in the response, takes precedence over Accept-Language</param>
        /// <returns>GetOpportunitiesGroupsGroupIdOk</returns>
        GetOpportunitiesGroupsGroupIdOk GetOpportunitiesGroupsGroupId (int? groupId, string acceptLanguage, string datasource, string ifNoneMatch, string language);
        /// <summary>
        /// Get opportunities tasks Return a list of opportunities tasks  - -- Alternate route: &#x60;/dev/opportunities/tasks/&#x60;  Alternate route: &#x60;/legacy/opportunities/tasks/&#x60;  Alternate route: &#x60;/v1/opportunities/tasks/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>List&lt;int?&gt;</returns>
        List<int?> GetOpportunitiesTasks (string datasource, string ifNoneMatch);
        /// <summary>
        /// Get opportunities task Return information of an opportunities task  - -- Alternate route: &#x60;/dev/opportunities/tasks/{task_id}/&#x60;  Alternate route: &#x60;/legacy/opportunities/tasks/{task_id}/&#x60;  Alternate route: &#x60;/v1/opportunities/tasks/{task_id}/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="taskId">ID of an opportunities task</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>GetOpportunitiesTasksTaskIdOk</returns>
        GetOpportunitiesTasksTaskIdOk GetOpportunitiesTasksTaskId (int? taskId, string datasource, string ifNoneMatch);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OpportunitiesApi : IOpportunitiesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpportunitiesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public OpportunitiesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OpportunitiesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OpportunitiesApi(String basePath)
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
        /// Get a character&#39;s completed tasks Return a list of tasks finished by a character  - -- Alternate route: &#x60;/dev/characters/{character_id}/opportunities/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/opportunities/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/opportunities/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCharactersCharacterIdOpportunities200Ok&gt;</returns>            
        public List<GetCharactersCharacterIdOpportunities200Ok> GetCharactersCharacterIdOpportunities (int? characterId, string datasource, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterIdOpportunities");
            
    
            var path = "/characters/{character_id}/opportunities/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdOpportunities: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdOpportunities: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCharactersCharacterIdOpportunities200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCharactersCharacterIdOpportunities200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get opportunities groups Return a list of opportunities groups  - -- Alternate route: &#x60;/dev/opportunities/groups/&#x60;  Alternate route: &#x60;/legacy/opportunities/groups/&#x60;  Alternate route: &#x60;/v1/opportunities/groups/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>List&lt;int?&gt;</returns>            
        public List<int?> GetOpportunitiesGroups (string datasource, string ifNoneMatch)
        {
            
    
            var path = "/opportunities/groups/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetOpportunitiesGroups: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOpportunitiesGroups: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<int?>) ApiClient.Deserialize(response.Content, typeof(List<int?>), response.Headers);
        }
    
        /// <summary>
        /// Get opportunities group Return information of an opportunities group  - -- Alternate route: &#x60;/dev/opportunities/groups/{group_id}/&#x60;  Alternate route: &#x60;/legacy/opportunities/groups/{group_id}/&#x60;  Alternate route: &#x60;/v1/opportunities/groups/{group_id}/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="groupId">ID of an opportunities group</param> 
        /// <param name="acceptLanguage">Language to use in the response</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="language">Language to use in the response, takes precedence over Accept-Language</param> 
        /// <returns>GetOpportunitiesGroupsGroupIdOk</returns>            
        public GetOpportunitiesGroupsGroupIdOk GetOpportunitiesGroupsGroupId (int? groupId, string acceptLanguage, string datasource, string ifNoneMatch, string language)
        {
            
            // verify the required parameter 'groupId' is set
            if (groupId == null) throw new ApiException(400, "Missing required parameter 'groupId' when calling GetOpportunitiesGroupsGroupId");
            
    
            var path = "/opportunities/groups/{group_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "group_id" + "}", ApiClient.ParameterToString(groupId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
             if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
 if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOpportunitiesGroupsGroupId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOpportunitiesGroupsGroupId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetOpportunitiesGroupsGroupIdOk) ApiClient.Deserialize(response.Content, typeof(GetOpportunitiesGroupsGroupIdOk), response.Headers);
        }
    
        /// <summary>
        /// Get opportunities tasks Return a list of opportunities tasks  - -- Alternate route: &#x60;/dev/opportunities/tasks/&#x60;  Alternate route: &#x60;/legacy/opportunities/tasks/&#x60;  Alternate route: &#x60;/v1/opportunities/tasks/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>List&lt;int?&gt;</returns>            
        public List<int?> GetOpportunitiesTasks (string datasource, string ifNoneMatch)
        {
            
    
            var path = "/opportunities/tasks/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetOpportunitiesTasks: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOpportunitiesTasks: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<int?>) ApiClient.Deserialize(response.Content, typeof(List<int?>), response.Headers);
        }
    
        /// <summary>
        /// Get opportunities task Return information of an opportunities task  - -- Alternate route: &#x60;/dev/opportunities/tasks/{task_id}/&#x60;  Alternate route: &#x60;/legacy/opportunities/tasks/{task_id}/&#x60;  Alternate route: &#x60;/v1/opportunities/tasks/{task_id}/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="taskId">ID of an opportunities task</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>GetOpportunitiesTasksTaskIdOk</returns>            
        public GetOpportunitiesTasksTaskIdOk GetOpportunitiesTasksTaskId (int? taskId, string datasource, string ifNoneMatch)
        {
            
            // verify the required parameter 'taskId' is set
            if (taskId == null) throw new ApiException(400, "Missing required parameter 'taskId' when calling GetOpportunitiesTasksTaskId");
            
    
            var path = "/opportunities/tasks/{task_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "task_id" + "}", ApiClient.ParameterToString(taskId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetOpportunitiesTasksTaskId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOpportunitiesTasksTaskId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetOpportunitiesTasksTaskIdOk) ApiClient.Deserialize(response.Content, typeof(GetOpportunitiesTasksTaskIdOk), response.Headers);
        }
    
    }
}
