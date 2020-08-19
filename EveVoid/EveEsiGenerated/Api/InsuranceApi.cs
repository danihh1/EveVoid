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
    public interface IInsuranceApi
    {
        /// <summary>
        /// List insurance levels Return available insurance levels for all ship types  - -- Alternate route: &#x60;/dev/insurance/prices/&#x60;  Alternate route: &#x60;/legacy/insurance/prices/&#x60;  Alternate route: &#x60;/v1/insurance/prices/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="acceptLanguage">Language to use in the response</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="language">Language to use in the response, takes precedence over Accept-Language</param>
        /// <returns>List&lt;GetInsurancePrices200Ok&gt;</returns>
        List<GetInsurancePrices200Ok> GetInsurancePrices (string acceptLanguage, string datasource, string ifNoneMatch, string language);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class InsuranceApi : IInsuranceApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsuranceApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public InsuranceApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InsuranceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InsuranceApi(String basePath)
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
        /// List insurance levels Return available insurance levels for all ship types  - -- Alternate route: &#x60;/dev/insurance/prices/&#x60;  Alternate route: &#x60;/legacy/insurance/prices/&#x60;  Alternate route: &#x60;/v1/insurance/prices/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="acceptLanguage">Language to use in the response</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="language">Language to use in the response, takes precedence over Accept-Language</param> 
        /// <returns>List&lt;GetInsurancePrices200Ok&gt;</returns>            
        public List<GetInsurancePrices200Ok> GetInsurancePrices (string acceptLanguage, string datasource, string ifNoneMatch, string language)
        {
            
    
            var path = "/insurance/prices/";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetInsurancePrices: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetInsurancePrices: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetInsurancePrices200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetInsurancePrices200Ok>), response.Headers);
        }
    
    }
}
