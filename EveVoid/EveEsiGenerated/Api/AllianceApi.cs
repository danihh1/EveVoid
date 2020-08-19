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
    public interface IAllianceApi
    {
        /// <summary>
        /// List all alliances List all active player alliances  - -- Alternate route: &#x60;/dev/alliances/&#x60;  Alternate route: &#x60;/legacy/alliances/&#x60;  Alternate route: &#x60;/v1/alliances/&#x60;  Alternate route: &#x60;/v2/alliances/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>List&lt;int?&gt;</returns>
        List<int?> GetAlliances (string datasource, string ifNoneMatch);
        /// <summary>
        /// Get alliance information Public information about an alliance  - -- Alternate route: &#x60;/dev/alliances/{alliance_id}/&#x60;  Alternate route: &#x60;/legacy/alliances/{alliance_id}/&#x60;  Alternate route: &#x60;/v3/alliances/{alliance_id}/&#x60;  Alternate route: &#x60;/v4/alliances/{alliance_id}/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="allianceId">An EVE alliance ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>GetAlliancesAllianceIdOk</returns>
        GetAlliancesAllianceIdOk GetAlliancesAllianceId (int? allianceId, string datasource, string ifNoneMatch);
        /// <summary>
        /// List alliance&#39;s corporations List all current member corporations of an alliance  - -- Alternate route: &#x60;/dev/alliances/{alliance_id}/corporations/&#x60;  Alternate route: &#x60;/legacy/alliances/{alliance_id}/corporations/&#x60;  Alternate route: &#x60;/v1/alliances/{alliance_id}/corporations/&#x60;  Alternate route: &#x60;/v2/alliances/{alliance_id}/corporations/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="allianceId">An EVE alliance ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>List&lt;int?&gt;</returns>
        List<int?> GetAlliancesAllianceIdCorporations (int? allianceId, string datasource, string ifNoneMatch);
        /// <summary>
        /// Get alliance icon Get the icon urls for a alliance  - -- Alternate route: &#x60;/legacy/alliances/{alliance_id}/icons/&#x60;  Alternate route: &#x60;/v1/alliances/{alliance_id}/icons/&#x60;  - -- This route expires daily at 11:05  - -- [Diff of the upcoming changes](https://esi.evetech.net/diff/latest/dev/#GET-/alliances/{alliance_id}/icons/)
        /// </summary>
        /// <param name="allianceId">An EVE alliance ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>GetAlliancesAllianceIdIconsOk</returns>
        GetAlliancesAllianceIdIconsOk GetAlliancesAllianceIdIcons (int? allianceId, string datasource, string ifNoneMatch);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AllianceApi : IAllianceApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AllianceApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AllianceApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AllianceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AllianceApi(String basePath)
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
        /// List all alliances List all active player alliances  - -- Alternate route: &#x60;/dev/alliances/&#x60;  Alternate route: &#x60;/legacy/alliances/&#x60;  Alternate route: &#x60;/v1/alliances/&#x60;  Alternate route: &#x60;/v2/alliances/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>List&lt;int?&gt;</returns>            
        public List<int?> GetAlliances (string datasource, string ifNoneMatch)
        {
            
    
            var path = "/alliances/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetAlliances: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAlliances: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<int?>) ApiClient.Deserialize(response.Content, typeof(List<int?>), response.Headers);
        }
    
        /// <summary>
        /// Get alliance information Public information about an alliance  - -- Alternate route: &#x60;/dev/alliances/{alliance_id}/&#x60;  Alternate route: &#x60;/legacy/alliances/{alliance_id}/&#x60;  Alternate route: &#x60;/v3/alliances/{alliance_id}/&#x60;  Alternate route: &#x60;/v4/alliances/{alliance_id}/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="allianceId">An EVE alliance ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>GetAlliancesAllianceIdOk</returns>            
        public GetAlliancesAllianceIdOk GetAlliancesAllianceId (int? allianceId, string datasource, string ifNoneMatch)
        {
            
            // verify the required parameter 'allianceId' is set
            if (allianceId == null) throw new ApiException(400, "Missing required parameter 'allianceId' when calling GetAlliancesAllianceId");
            
    
            var path = "/alliances/{alliance_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "alliance_id" + "}", ApiClient.ParameterToString(allianceId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetAlliancesAllianceId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAlliancesAllianceId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetAlliancesAllianceIdOk) ApiClient.Deserialize(response.Content, typeof(GetAlliancesAllianceIdOk), response.Headers);
        }
    
        /// <summary>
        /// List alliance&#39;s corporations List all current member corporations of an alliance  - -- Alternate route: &#x60;/dev/alliances/{alliance_id}/corporations/&#x60;  Alternate route: &#x60;/legacy/alliances/{alliance_id}/corporations/&#x60;  Alternate route: &#x60;/v1/alliances/{alliance_id}/corporations/&#x60;  Alternate route: &#x60;/v2/alliances/{alliance_id}/corporations/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="allianceId">An EVE alliance ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>List&lt;int?&gt;</returns>            
        public List<int?> GetAlliancesAllianceIdCorporations (int? allianceId, string datasource, string ifNoneMatch)
        {
            
            // verify the required parameter 'allianceId' is set
            if (allianceId == null) throw new ApiException(400, "Missing required parameter 'allianceId' when calling GetAlliancesAllianceIdCorporations");
            
    
            var path = "/alliances/{alliance_id}/corporations/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "alliance_id" + "}", ApiClient.ParameterToString(allianceId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetAlliancesAllianceIdCorporations: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAlliancesAllianceIdCorporations: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<int?>) ApiClient.Deserialize(response.Content, typeof(List<int?>), response.Headers);
        }
    
        /// <summary>
        /// Get alliance icon Get the icon urls for a alliance  - -- Alternate route: &#x60;/legacy/alliances/{alliance_id}/icons/&#x60;  Alternate route: &#x60;/v1/alliances/{alliance_id}/icons/&#x60;  - -- This route expires daily at 11:05  - -- [Diff of the upcoming changes](https://esi.evetech.net/diff/latest/dev/#GET-/alliances/{alliance_id}/icons/)
        /// </summary>
        /// <param name="allianceId">An EVE alliance ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>GetAlliancesAllianceIdIconsOk</returns>            
        public GetAlliancesAllianceIdIconsOk GetAlliancesAllianceIdIcons (int? allianceId, string datasource, string ifNoneMatch)
        {
            
            // verify the required parameter 'allianceId' is set
            if (allianceId == null) throw new ApiException(400, "Missing required parameter 'allianceId' when calling GetAlliancesAllianceIdIcons");
            
    
            var path = "/alliances/{alliance_id}/icons/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "alliance_id" + "}", ApiClient.ParameterToString(allianceId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetAlliancesAllianceIdIcons: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAlliancesAllianceIdIcons: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetAlliancesAllianceIdIconsOk) ApiClient.Deserialize(response.Content, typeof(GetAlliancesAllianceIdIconsOk), response.Headers);
        }
    
    }
}
