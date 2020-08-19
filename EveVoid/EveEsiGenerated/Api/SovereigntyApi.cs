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
    public interface ISovereigntyApi
    {
        /// <summary>
        /// List sovereignty campaigns Shows sovereignty data for campaigns.  - -- Alternate route: &#x60;/dev/sovereignty/campaigns/&#x60;  Alternate route: &#x60;/legacy/sovereignty/campaigns/&#x60;  Alternate route: &#x60;/v1/sovereignty/campaigns/&#x60;  - -- This route is cached for up to 5 seconds
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>List&lt;GetSovereigntyCampaigns200Ok&gt;</returns>
        List<GetSovereigntyCampaigns200Ok> GetSovereigntyCampaigns (string datasource, string ifNoneMatch);
        /// <summary>
        /// List sovereignty of systems Shows sovereignty information for solar systems  - -- Alternate route: &#x60;/dev/sovereignty/map/&#x60;  Alternate route: &#x60;/legacy/sovereignty/map/&#x60;  Alternate route: &#x60;/v1/sovereignty/map/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>List&lt;GetSovereigntyMap200Ok&gt;</returns>
        List<GetSovereigntyMap200Ok> GetSovereigntyMap (string datasource, string ifNoneMatch);
        /// <summary>
        /// List sovereignty structures Shows sovereignty data for structures.  - -- Alternate route: &#x60;/dev/sovereignty/structures/&#x60;  Alternate route: &#x60;/legacy/sovereignty/structures/&#x60;  Alternate route: &#x60;/v1/sovereignty/structures/&#x60;  - -- This route is cached for up to 120 seconds
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>List&lt;GetSovereigntyStructures200Ok&gt;</returns>
        List<GetSovereigntyStructures200Ok> GetSovereigntyStructures (string datasource, string ifNoneMatch);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SovereigntyApi : ISovereigntyApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SovereigntyApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SovereigntyApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SovereigntyApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SovereigntyApi(String basePath)
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
        /// List sovereignty campaigns Shows sovereignty data for campaigns.  - -- Alternate route: &#x60;/dev/sovereignty/campaigns/&#x60;  Alternate route: &#x60;/legacy/sovereignty/campaigns/&#x60;  Alternate route: &#x60;/v1/sovereignty/campaigns/&#x60;  - -- This route is cached for up to 5 seconds
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>List&lt;GetSovereigntyCampaigns200Ok&gt;</returns>            
        public List<GetSovereigntyCampaigns200Ok> GetSovereigntyCampaigns (string datasource, string ifNoneMatch)
        {
            
    
            var path = "/sovereignty/campaigns/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetSovereigntyCampaigns: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSovereigntyCampaigns: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetSovereigntyCampaigns200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetSovereigntyCampaigns200Ok>), response.Headers);
        }
    
        /// <summary>
        /// List sovereignty of systems Shows sovereignty information for solar systems  - -- Alternate route: &#x60;/dev/sovereignty/map/&#x60;  Alternate route: &#x60;/legacy/sovereignty/map/&#x60;  Alternate route: &#x60;/v1/sovereignty/map/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>List&lt;GetSovereigntyMap200Ok&gt;</returns>            
        public List<GetSovereigntyMap200Ok> GetSovereigntyMap (string datasource, string ifNoneMatch)
        {
            
    
            var path = "/sovereignty/map/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetSovereigntyMap: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSovereigntyMap: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetSovereigntyMap200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetSovereigntyMap200Ok>), response.Headers);
        }
    
        /// <summary>
        /// List sovereignty structures Shows sovereignty data for structures.  - -- Alternate route: &#x60;/dev/sovereignty/structures/&#x60;  Alternate route: &#x60;/legacy/sovereignty/structures/&#x60;  Alternate route: &#x60;/v1/sovereignty/structures/&#x60;  - -- This route is cached for up to 120 seconds
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>List&lt;GetSovereigntyStructures200Ok&gt;</returns>            
        public List<GetSovereigntyStructures200Ok> GetSovereigntyStructures (string datasource, string ifNoneMatch)
        {
            
    
            var path = "/sovereignty/structures/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetSovereigntyStructures: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSovereigntyStructures: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetSovereigntyStructures200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetSovereigntyStructures200Ok>), response.Headers);
        }
    
    }
}
