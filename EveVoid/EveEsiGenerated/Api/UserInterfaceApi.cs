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
    public interface IUserInterfaceApi
    {
        /// <summary>
        /// Set Autopilot Waypoint Set a solar system as autopilot waypoint  - -- Alternate route: &#x60;/dev/ui/autopilot/waypoint/&#x60;  Alternate route: &#x60;/legacy/ui/autopilot/waypoint/&#x60;  Alternate route: &#x60;/v2/ui/autopilot/waypoint/&#x60; 
        /// </summary>
        /// <param name="addToBeginning">Whether this solar system should be added to the beginning of all waypoints</param>
        /// <param name="clearOtherWaypoints">Whether clean other waypoints beforing adding this one</param>
        /// <param name="destinationId">The destination to travel to, can be solar system, station or structure&#39;s id</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns></returns>
        void PostUiAutopilotWaypoint (bool? addToBeginning, bool? clearOtherWaypoints, long? destinationId, string datasource, string token);
        /// <summary>
        /// Open Contract Window Open the contract window inside the client  - -- Alternate route: &#x60;/dev/ui/openwindow/contract/&#x60;  Alternate route: &#x60;/legacy/ui/openwindow/contract/&#x60;  Alternate route: &#x60;/v1/ui/openwindow/contract/&#x60; 
        /// </summary>
        /// <param name="contractId">The contract to open</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns></returns>
        void PostUiOpenwindowContract (int? contractId, string datasource, string token);
        /// <summary>
        /// Open Information Window Open the information window for a character, corporation or alliance inside the client  - -- Alternate route: &#x60;/dev/ui/openwindow/information/&#x60;  Alternate route: &#x60;/legacy/ui/openwindow/information/&#x60;  Alternate route: &#x60;/v1/ui/openwindow/information/&#x60; 
        /// </summary>
        /// <param name="targetId">The target to open</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns></returns>
        void PostUiOpenwindowInformation (int? targetId, string datasource, string token);
        /// <summary>
        /// Open Market Details Open the market details window for a specific typeID inside the client  - -- Alternate route: &#x60;/dev/ui/openwindow/marketdetails/&#x60;  Alternate route: &#x60;/legacy/ui/openwindow/marketdetails/&#x60;  Alternate route: &#x60;/v1/ui/openwindow/marketdetails/&#x60; 
        /// </summary>
        /// <param name="typeId">The item type to open in market window</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns></returns>
        void PostUiOpenwindowMarketdetails (int? typeId, string datasource, string token);
        /// <summary>
        /// Open New Mail Window Open the New Mail window, according to settings from the request if applicable  - -- Alternate route: &#x60;/dev/ui/openwindow/newmail/&#x60;  Alternate route: &#x60;/legacy/ui/openwindow/newmail/&#x60;  Alternate route: &#x60;/v1/ui/openwindow/newmail/&#x60; 
        /// </summary>
        /// <param name="newMail">The details of mail to create</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns></returns>
        void PostUiOpenwindowNewmail (PostUiOpenwindowNewmailNewMail newMail, string datasource, string token);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UserInterfaceApi : IUserInterfaceApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserInterfaceApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UserInterfaceApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserInterfaceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserInterfaceApi(String basePath)
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
        /// Set Autopilot Waypoint Set a solar system as autopilot waypoint  - -- Alternate route: &#x60;/dev/ui/autopilot/waypoint/&#x60;  Alternate route: &#x60;/legacy/ui/autopilot/waypoint/&#x60;  Alternate route: &#x60;/v2/ui/autopilot/waypoint/&#x60; 
        /// </summary>
        /// <param name="addToBeginning">Whether this solar system should be added to the beginning of all waypoints</param> 
        /// <param name="clearOtherWaypoints">Whether clean other waypoints beforing adding this one</param> 
        /// <param name="destinationId">The destination to travel to, can be solar system, station or structure&#39;s id</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns></returns>            
        public void PostUiAutopilotWaypoint (bool? addToBeginning, bool? clearOtherWaypoints, long? destinationId, string datasource, string token)
        {
            
            // verify the required parameter 'addToBeginning' is set
            if (addToBeginning == null) throw new ApiException(400, "Missing required parameter 'addToBeginning' when calling PostUiAutopilotWaypoint");
            
            // verify the required parameter 'clearOtherWaypoints' is set
            if (clearOtherWaypoints == null) throw new ApiException(400, "Missing required parameter 'clearOtherWaypoints' when calling PostUiAutopilotWaypoint");
            
            // verify the required parameter 'destinationId' is set
            if (destinationId == null) throw new ApiException(400, "Missing required parameter 'destinationId' when calling PostUiAutopilotWaypoint");
            
    
            var path = "/ui/autopilot/waypoint/";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (addToBeginning != null) queryParams.Add("add_to_beginning", ApiClient.ParameterToString(addToBeginning)); // query parameter
 if (clearOtherWaypoints != null) queryParams.Add("clear_other_waypoints", ApiClient.ParameterToString(clearOtherWaypoints)); // query parameter
 if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (destinationId != null) queryParams.Add("destination_id", ApiClient.ParameterToString(destinationId)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "evesso" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostUiAutopilotWaypoint: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostUiAutopilotWaypoint: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Open Contract Window Open the contract window inside the client  - -- Alternate route: &#x60;/dev/ui/openwindow/contract/&#x60;  Alternate route: &#x60;/legacy/ui/openwindow/contract/&#x60;  Alternate route: &#x60;/v1/ui/openwindow/contract/&#x60; 
        /// </summary>
        /// <param name="contractId">The contract to open</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns></returns>            
        public void PostUiOpenwindowContract (int? contractId, string datasource, string token)
        {
            
            // verify the required parameter 'contractId' is set
            if (contractId == null) throw new ApiException(400, "Missing required parameter 'contractId' when calling PostUiOpenwindowContract");
            
    
            var path = "/ui/openwindow/contract/";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (contractId != null) queryParams.Add("contract_id", ApiClient.ParameterToString(contractId)); // query parameter
 if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "evesso" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostUiOpenwindowContract: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostUiOpenwindowContract: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Open Information Window Open the information window for a character, corporation or alliance inside the client  - -- Alternate route: &#x60;/dev/ui/openwindow/information/&#x60;  Alternate route: &#x60;/legacy/ui/openwindow/information/&#x60;  Alternate route: &#x60;/v1/ui/openwindow/information/&#x60; 
        /// </summary>
        /// <param name="targetId">The target to open</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns></returns>            
        public void PostUiOpenwindowInformation (int? targetId, string datasource, string token)
        {
            
            // verify the required parameter 'targetId' is set
            if (targetId == null) throw new ApiException(400, "Missing required parameter 'targetId' when calling PostUiOpenwindowInformation");
            
    
            var path = "/ui/openwindow/information/";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (targetId != null) queryParams.Add("target_id", ApiClient.ParameterToString(targetId)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "evesso" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostUiOpenwindowInformation: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostUiOpenwindowInformation: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Open Market Details Open the market details window for a specific typeID inside the client  - -- Alternate route: &#x60;/dev/ui/openwindow/marketdetails/&#x60;  Alternate route: &#x60;/legacy/ui/openwindow/marketdetails/&#x60;  Alternate route: &#x60;/v1/ui/openwindow/marketdetails/&#x60; 
        /// </summary>
        /// <param name="typeId">The item type to open in market window</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns></returns>            
        public void PostUiOpenwindowMarketdetails (int? typeId, string datasource, string token)
        {
            
            // verify the required parameter 'typeId' is set
            if (typeId == null) throw new ApiException(400, "Missing required parameter 'typeId' when calling PostUiOpenwindowMarketdetails");
            
    
            var path = "/ui/openwindow/marketdetails/";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (typeId != null) queryParams.Add("type_id", ApiClient.ParameterToString(typeId)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "evesso" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostUiOpenwindowMarketdetails: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostUiOpenwindowMarketdetails: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Open New Mail Window Open the New Mail window, according to settings from the request if applicable  - -- Alternate route: &#x60;/dev/ui/openwindow/newmail/&#x60;  Alternate route: &#x60;/legacy/ui/openwindow/newmail/&#x60;  Alternate route: &#x60;/v1/ui/openwindow/newmail/&#x60; 
        /// </summary>
        /// <param name="newMail">The details of mail to create</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns></returns>            
        public void PostUiOpenwindowNewmail (PostUiOpenwindowNewmailNewMail newMail, string datasource, string token)
        {
            
            // verify the required parameter 'newMail' is set
            if (newMail == null) throw new ApiException(400, "Missing required parameter 'newMail' when calling PostUiOpenwindowNewmail");
            
    
            var path = "/ui/openwindow/newmail/";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                    postBody = ApiClient.Serialize(newMail); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "evesso" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostUiOpenwindowNewmail: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostUiOpenwindowNewmail: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
