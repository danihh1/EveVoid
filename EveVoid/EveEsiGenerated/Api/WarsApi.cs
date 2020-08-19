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
    public interface IWarsApi
    {
        /// <summary>
        /// List wars Return a list of wars  - -- Alternate route: &#x60;/dev/wars/&#x60;  Alternate route: &#x60;/legacy/wars/&#x60;  Alternate route: &#x60;/v1/wars/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="maxWarId">Only return wars with ID smaller than this</param>
        /// <returns>List&lt;int?&gt;</returns>
        List<int?> GetWars (string datasource, string ifNoneMatch, int? maxWarId);
        /// <summary>
        /// Get war information Return details about a war  - -- Alternate route: &#x60;/dev/wars/{war_id}/&#x60;  Alternate route: &#x60;/legacy/wars/{war_id}/&#x60;  Alternate route: &#x60;/v1/wars/{war_id}/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="warId">ID for a war</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>GetWarsWarIdOk</returns>
        GetWarsWarIdOk GetWarsWarId (int? warId, string datasource, string ifNoneMatch);
        /// <summary>
        /// List kills for a war Return a list of kills related to a war  - -- Alternate route: &#x60;/dev/wars/{war_id}/killmails/&#x60;  Alternate route: &#x60;/legacy/wars/{war_id}/killmails/&#x60;  Alternate route: &#x60;/v1/wars/{war_id}/killmails/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="warId">A valid war ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="page">Which page of results to return</param>
        /// <returns>List&lt;GetWarsWarIdKillmails200Ok&gt;</returns>
        List<GetWarsWarIdKillmails200Ok> GetWarsWarIdKillmails (int? warId, string datasource, string ifNoneMatch, int? page);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class WarsApi : IWarsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WarsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public WarsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WarsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WarsApi(String basePath)
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
        /// List wars Return a list of wars  - -- Alternate route: &#x60;/dev/wars/&#x60;  Alternate route: &#x60;/legacy/wars/&#x60;  Alternate route: &#x60;/v1/wars/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="maxWarId">Only return wars with ID smaller than this</param> 
        /// <returns>List&lt;int?&gt;</returns>            
        public List<int?> GetWars (string datasource, string ifNoneMatch, int? maxWarId)
        {
            
    
            var path = "/wars/";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (maxWarId != null) queryParams.Add("max_war_id", ApiClient.ParameterToString(maxWarId)); // query parameter
             if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWars: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWars: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<int?>) ApiClient.Deserialize(response.Content, typeof(List<int?>), response.Headers);
        }
    
        /// <summary>
        /// Get war information Return details about a war  - -- Alternate route: &#x60;/dev/wars/{war_id}/&#x60;  Alternate route: &#x60;/legacy/wars/{war_id}/&#x60;  Alternate route: &#x60;/v1/wars/{war_id}/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="warId">ID for a war</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>GetWarsWarIdOk</returns>            
        public GetWarsWarIdOk GetWarsWarId (int? warId, string datasource, string ifNoneMatch)
        {
            
            // verify the required parameter 'warId' is set
            if (warId == null) throw new ApiException(400, "Missing required parameter 'warId' when calling GetWarsWarId");
            
    
            var path = "/wars/{war_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "war_id" + "}", ApiClient.ParameterToString(warId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetWarsWarId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWarsWarId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetWarsWarIdOk) ApiClient.Deserialize(response.Content, typeof(GetWarsWarIdOk), response.Headers);
        }
    
        /// <summary>
        /// List kills for a war Return a list of kills related to a war  - -- Alternate route: &#x60;/dev/wars/{war_id}/killmails/&#x60;  Alternate route: &#x60;/legacy/wars/{war_id}/killmails/&#x60;  Alternate route: &#x60;/v1/wars/{war_id}/killmails/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="warId">A valid war ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <returns>List&lt;GetWarsWarIdKillmails200Ok&gt;</returns>            
        public List<GetWarsWarIdKillmails200Ok> GetWarsWarIdKillmails (int? warId, string datasource, string ifNoneMatch, int? page)
        {
            
            // verify the required parameter 'warId' is set
            if (warId == null) throw new ApiException(400, "Missing required parameter 'warId' when calling GetWarsWarIdKillmails");
            
    
            var path = "/wars/{war_id}/killmails/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "war_id" + "}", ApiClient.ParameterToString(warId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
             if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWarsWarIdKillmails: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWarsWarIdKillmails: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetWarsWarIdKillmails200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetWarsWarIdKillmails200Ok>), response.Headers);
        }
    
    }
}
