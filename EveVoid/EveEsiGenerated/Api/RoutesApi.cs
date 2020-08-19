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
    public interface IRoutesApi
    {
        /// <summary>
        /// Get route Get the systems between origin and destination  - -- Alternate route: &#x60;/dev/route/{origin}/{destination}/&#x60;  Alternate route: &#x60;/legacy/route/{origin}/{destination}/&#x60;  Alternate route: &#x60;/v1/route/{origin}/{destination}/&#x60;  - -- This route is cached for up to 86400 seconds
        /// </summary>
        /// <param name="destination">destination solar system ID</param>
        /// <param name="origin">origin solar system ID</param>
        /// <param name="avoid">avoid solar system ID(s)</param>
        /// <param name="connections">connected solar system pairs</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="flag">route security preference</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>List&lt;int?&gt;</returns>
        List<int?> GetRouteOriginDestination (int? destination, int? origin, List<int?> avoid, List<List<int?>> connections, string datasource, string flag, string ifNoneMatch);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RoutesApi : IRoutesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoutesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public RoutesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RoutesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RoutesApi(String basePath)
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
        /// Get route Get the systems between origin and destination  - -- Alternate route: &#x60;/dev/route/{origin}/{destination}/&#x60;  Alternate route: &#x60;/legacy/route/{origin}/{destination}/&#x60;  Alternate route: &#x60;/v1/route/{origin}/{destination}/&#x60;  - -- This route is cached for up to 86400 seconds
        /// </summary>
        /// <param name="destination">destination solar system ID</param> 
        /// <param name="origin">origin solar system ID</param> 
        /// <param name="avoid">avoid solar system ID(s)</param> 
        /// <param name="connections">connected solar system pairs</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="flag">route security preference</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>List&lt;int?&gt;</returns>            
        public List<int?> GetRouteOriginDestination (int? destination, int? origin, List<int?> avoid, List<List<int?>> connections, string datasource, string flag, string ifNoneMatch)
        {
            
            // verify the required parameter 'destination' is set
            if (destination == null) throw new ApiException(400, "Missing required parameter 'destination' when calling GetRouteOriginDestination");
            
            // verify the required parameter 'origin' is set
            if (origin == null) throw new ApiException(400, "Missing required parameter 'origin' when calling GetRouteOriginDestination");
            
    
            var path = "/route/{origin}/{destination}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "destination" + "}", ApiClient.ParameterToString(destination));
path = path.Replace("{" + "origin" + "}", ApiClient.ParameterToString(origin));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (avoid != null) queryParams.Add("avoid", ApiClient.ParameterToString(avoid)); // query parameter
 if (connections != null) queryParams.Add("connections", ApiClient.ParameterToString(connections)); // query parameter
 if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (flag != null) queryParams.Add("flag", ApiClient.ParameterToString(flag)); // query parameter
             if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRouteOriginDestination: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRouteOriginDestination: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<int?>) ApiClient.Deserialize(response.Content, typeof(List<int?>), response.Headers);
        }
    
    }
}
