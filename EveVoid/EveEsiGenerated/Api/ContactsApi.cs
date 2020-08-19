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
    public interface IContactsApi
    {
        /// <summary>
        /// Delete contacts Bulk delete contacts  - -- Alternate route: &#x60;/dev/characters/{character_id}/contacts/&#x60;  Alternate route: &#x60;/v2/characters/{character_id}/contacts/&#x60; 
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="contactIds">A list of contacts to delete</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns></returns>
        void DeleteCharactersCharacterIdContacts (int? characterId, List<int?> contactIds, string datasource, string token);
        /// <summary>
        /// Get alliance contacts Return contacts of an alliance  - -- Alternate route: &#x60;/dev/alliances/{alliance_id}/contacts/&#x60;  Alternate route: &#x60;/v2/alliances/{alliance_id}/contacts/&#x60;  - -- This route is cached for up to 300 seconds
        /// </summary>
        /// <param name="allianceId">An EVE alliance ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="page">Which page of results to return</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetAlliancesAllianceIdContacts200Ok&gt;</returns>
        List<GetAlliancesAllianceIdContacts200Ok> GetAlliancesAllianceIdContacts (int? allianceId, string datasource, string ifNoneMatch, int? page, string token);
        /// <summary>
        /// Get alliance contact labels Return custom labels for an alliance&#39;s contacts  - -- Alternate route: &#x60;/dev/alliances/{alliance_id}/contacts/labels/&#x60;  Alternate route: &#x60;/legacy/alliances/{alliance_id}/contacts/labels/&#x60;  Alternate route: &#x60;/v1/alliances/{alliance_id}/contacts/labels/&#x60;  - -- This route is cached for up to 300 seconds
        /// </summary>
        /// <param name="allianceId">An EVE alliance ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetAlliancesAllianceIdContactsLabels200Ok&gt;</returns>
        List<GetAlliancesAllianceIdContactsLabels200Ok> GetAlliancesAllianceIdContactsLabels (int? allianceId, string datasource, string ifNoneMatch, string token);
        /// <summary>
        /// Get contacts Return contacts of a character  - -- Alternate route: &#x60;/dev/characters/{character_id}/contacts/&#x60;  Alternate route: &#x60;/v2/characters/{character_id}/contacts/&#x60;  - -- This route is cached for up to 300 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="page">Which page of results to return</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCharactersCharacterIdContacts200Ok&gt;</returns>
        List<GetCharactersCharacterIdContacts200Ok> GetCharactersCharacterIdContacts (int? characterId, string datasource, string ifNoneMatch, int? page, string token);
        /// <summary>
        /// Get contact labels Return custom labels for a character&#39;s contacts  - -- Alternate route: &#x60;/dev/characters/{character_id}/contacts/labels/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/contacts/labels/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/contacts/labels/&#x60;  - -- This route is cached for up to 300 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCharactersCharacterIdContactsLabels200Ok&gt;</returns>
        List<GetCharactersCharacterIdContactsLabels200Ok> GetCharactersCharacterIdContactsLabels (int? characterId, string datasource, string ifNoneMatch, string token);
        /// <summary>
        /// Get corporation contacts Return contacts of a corporation  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/contacts/&#x60;  Alternate route: &#x60;/v2/corporations/{corporation_id}/contacts/&#x60;  - -- This route is cached for up to 300 seconds
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="page">Which page of results to return</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCorporationsCorporationIdContacts200Ok&gt;</returns>
        List<GetCorporationsCorporationIdContacts200Ok> GetCorporationsCorporationIdContacts (int? corporationId, string datasource, string ifNoneMatch, int? page, string token);
        /// <summary>
        /// Get corporation contact labels Return custom labels for a corporation&#39;s contacts  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/contacts/labels/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/contacts/labels/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/contacts/labels/&#x60;  - -- This route is cached for up to 300 seconds
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCorporationsCorporationIdContactsLabels200Ok&gt;</returns>
        List<GetCorporationsCorporationIdContactsLabels200Ok> GetCorporationsCorporationIdContactsLabels (int? corporationId, string datasource, string ifNoneMatch, string token);
        /// <summary>
        /// Add contacts Bulk add contacts with same settings  - -- Alternate route: &#x60;/dev/characters/{character_id}/contacts/&#x60;  Alternate route: &#x60;/v2/characters/{character_id}/contacts/&#x60; 
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="contactIds">A list of contacts</param>
        /// <param name="standing">Standing for the contact</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="labelIds">Add custom labels to the new contact</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <param name="watched">Whether the contact should be watched, note this is only effective on characters</param>
        /// <returns>List&lt;int?&gt;</returns>
        List<int?> PostCharactersCharacterIdContacts (int? characterId, List<int?> contactIds, float? standing, string datasource, List<long?> labelIds, string token, bool? watched);
        /// <summary>
        /// Edit contacts Bulk edit contacts with same settings  - -- Alternate route: &#x60;/dev/characters/{character_id}/contacts/&#x60;  Alternate route: &#x60;/v2/characters/{character_id}/contacts/&#x60; 
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="contactIds">A list of contacts</param>
        /// <param name="standing">Standing for the contact</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="labelIds">Add custom labels to the contact</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <param name="watched">Whether the contact should be watched, note this is only effective on characters</param>
        /// <returns></returns>
        void PutCharactersCharacterIdContacts (int? characterId, List<int?> contactIds, float? standing, string datasource, List<long?> labelIds, string token, bool? watched);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ContactsApi : IContactsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ContactsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ContactsApi(String basePath)
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
        /// Delete contacts Bulk delete contacts  - -- Alternate route: &#x60;/dev/characters/{character_id}/contacts/&#x60;  Alternate route: &#x60;/v2/characters/{character_id}/contacts/&#x60; 
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="contactIds">A list of contacts to delete</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns></returns>            
        public void DeleteCharactersCharacterIdContacts (int? characterId, List<int?> contactIds, string datasource, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling DeleteCharactersCharacterIdContacts");
            
            // verify the required parameter 'contactIds' is set
            if (contactIds == null) throw new ApiException(400, "Missing required parameter 'contactIds' when calling DeleteCharactersCharacterIdContacts");
            
    
            var path = "/characters/{character_id}/contacts/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "character_id" + "}", ApiClient.ParameterToString(characterId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (contactIds != null) queryParams.Add("contact_ids", ApiClient.ParameterToString(contactIds)); // query parameter
 if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "evesso" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCharactersCharacterIdContacts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCharactersCharacterIdContacts: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get alliance contacts Return contacts of an alliance  - -- Alternate route: &#x60;/dev/alliances/{alliance_id}/contacts/&#x60;  Alternate route: &#x60;/v2/alliances/{alliance_id}/contacts/&#x60;  - -- This route is cached for up to 300 seconds
        /// </summary>
        /// <param name="allianceId">An EVE alliance ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetAlliancesAllianceIdContacts200Ok&gt;</returns>            
        public List<GetAlliancesAllianceIdContacts200Ok> GetAlliancesAllianceIdContacts (int? allianceId, string datasource, string ifNoneMatch, int? page, string token)
        {
            
            // verify the required parameter 'allianceId' is set
            if (allianceId == null) throw new ApiException(400, "Missing required parameter 'allianceId' when calling GetAlliancesAllianceIdContacts");
            
    
            var path = "/alliances/{alliance_id}/contacts/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "alliance_id" + "}", ApiClient.ParameterToString(allianceId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetAlliancesAllianceIdContacts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAlliancesAllianceIdContacts: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetAlliancesAllianceIdContacts200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetAlliancesAllianceIdContacts200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get alliance contact labels Return custom labels for an alliance&#39;s contacts  - -- Alternate route: &#x60;/dev/alliances/{alliance_id}/contacts/labels/&#x60;  Alternate route: &#x60;/legacy/alliances/{alliance_id}/contacts/labels/&#x60;  Alternate route: &#x60;/v1/alliances/{alliance_id}/contacts/labels/&#x60;  - -- This route is cached for up to 300 seconds
        /// </summary>
        /// <param name="allianceId">An EVE alliance ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetAlliancesAllianceIdContactsLabels200Ok&gt;</returns>            
        public List<GetAlliancesAllianceIdContactsLabels200Ok> GetAlliancesAllianceIdContactsLabels (int? allianceId, string datasource, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'allianceId' is set
            if (allianceId == null) throw new ApiException(400, "Missing required parameter 'allianceId' when calling GetAlliancesAllianceIdContactsLabels");
            
    
            var path = "/alliances/{alliance_id}/contacts/labels/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "alliance_id" + "}", ApiClient.ParameterToString(allianceId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetAlliancesAllianceIdContactsLabels: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAlliancesAllianceIdContactsLabels: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetAlliancesAllianceIdContactsLabels200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetAlliancesAllianceIdContactsLabels200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get contacts Return contacts of a character  - -- Alternate route: &#x60;/dev/characters/{character_id}/contacts/&#x60;  Alternate route: &#x60;/v2/characters/{character_id}/contacts/&#x60;  - -- This route is cached for up to 300 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCharactersCharacterIdContacts200Ok&gt;</returns>            
        public List<GetCharactersCharacterIdContacts200Ok> GetCharactersCharacterIdContacts (int? characterId, string datasource, string ifNoneMatch, int? page, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterIdContacts");
            
    
            var path = "/characters/{character_id}/contacts/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdContacts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdContacts: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCharactersCharacterIdContacts200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCharactersCharacterIdContacts200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get contact labels Return custom labels for a character&#39;s contacts  - -- Alternate route: &#x60;/dev/characters/{character_id}/contacts/labels/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/contacts/labels/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/contacts/labels/&#x60;  - -- This route is cached for up to 300 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCharactersCharacterIdContactsLabels200Ok&gt;</returns>            
        public List<GetCharactersCharacterIdContactsLabels200Ok> GetCharactersCharacterIdContactsLabels (int? characterId, string datasource, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterIdContactsLabels");
            
    
            var path = "/characters/{character_id}/contacts/labels/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdContactsLabels: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdContactsLabels: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCharactersCharacterIdContactsLabels200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCharactersCharacterIdContactsLabels200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get corporation contacts Return contacts of a corporation  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/contacts/&#x60;  Alternate route: &#x60;/v2/corporations/{corporation_id}/contacts/&#x60;  - -- This route is cached for up to 300 seconds
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCorporationsCorporationIdContacts200Ok&gt;</returns>            
        public List<GetCorporationsCorporationIdContacts200Ok> GetCorporationsCorporationIdContacts (int? corporationId, string datasource, string ifNoneMatch, int? page, string token)
        {
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling GetCorporationsCorporationIdContacts");
            
    
            var path = "/corporations/{corporation_id}/contacts/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdContacts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdContacts: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCorporationsCorporationIdContacts200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCorporationsCorporationIdContacts200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get corporation contact labels Return custom labels for a corporation&#39;s contacts  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/contacts/labels/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/contacts/labels/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/contacts/labels/&#x60;  - -- This route is cached for up to 300 seconds
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCorporationsCorporationIdContactsLabels200Ok&gt;</returns>            
        public List<GetCorporationsCorporationIdContactsLabels200Ok> GetCorporationsCorporationIdContactsLabels (int? corporationId, string datasource, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling GetCorporationsCorporationIdContactsLabels");
            
    
            var path = "/corporations/{corporation_id}/contacts/labels/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdContactsLabels: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdContactsLabels: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCorporationsCorporationIdContactsLabels200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCorporationsCorporationIdContactsLabels200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Add contacts Bulk add contacts with same settings  - -- Alternate route: &#x60;/dev/characters/{character_id}/contacts/&#x60;  Alternate route: &#x60;/v2/characters/{character_id}/contacts/&#x60; 
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="contactIds">A list of contacts</param> 
        /// <param name="standing">Standing for the contact</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="labelIds">Add custom labels to the new contact</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <param name="watched">Whether the contact should be watched, note this is only effective on characters</param> 
        /// <returns>List&lt;int?&gt;</returns>            
        public List<int?> PostCharactersCharacterIdContacts (int? characterId, List<int?> contactIds, float? standing, string datasource, List<long?> labelIds, string token, bool? watched)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling PostCharactersCharacterIdContacts");
            
            // verify the required parameter 'contactIds' is set
            if (contactIds == null) throw new ApiException(400, "Missing required parameter 'contactIds' when calling PostCharactersCharacterIdContacts");
            
            // verify the required parameter 'standing' is set
            if (standing == null) throw new ApiException(400, "Missing required parameter 'standing' when calling PostCharactersCharacterIdContacts");
            
    
            var path = "/characters/{character_id}/contacts/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "character_id" + "}", ApiClient.ParameterToString(characterId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (labelIds != null) queryParams.Add("label_ids", ApiClient.ParameterToString(labelIds)); // query parameter
 if (standing != null) queryParams.Add("standing", ApiClient.ParameterToString(standing)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (watched != null) queryParams.Add("watched", ApiClient.ParameterToString(watched)); // query parameter
                                    postBody = ApiClient.Serialize(contactIds); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "evesso" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostCharactersCharacterIdContacts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostCharactersCharacterIdContacts: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<int?>) ApiClient.Deserialize(response.Content, typeof(List<int?>), response.Headers);
        }
    
        /// <summary>
        /// Edit contacts Bulk edit contacts with same settings  - -- Alternate route: &#x60;/dev/characters/{character_id}/contacts/&#x60;  Alternate route: &#x60;/v2/characters/{character_id}/contacts/&#x60; 
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="contactIds">A list of contacts</param> 
        /// <param name="standing">Standing for the contact</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="labelIds">Add custom labels to the contact</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <param name="watched">Whether the contact should be watched, note this is only effective on characters</param> 
        /// <returns></returns>            
        public void PutCharactersCharacterIdContacts (int? characterId, List<int?> contactIds, float? standing, string datasource, List<long?> labelIds, string token, bool? watched)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling PutCharactersCharacterIdContacts");
            
            // verify the required parameter 'contactIds' is set
            if (contactIds == null) throw new ApiException(400, "Missing required parameter 'contactIds' when calling PutCharactersCharacterIdContacts");
            
            // verify the required parameter 'standing' is set
            if (standing == null) throw new ApiException(400, "Missing required parameter 'standing' when calling PutCharactersCharacterIdContacts");
            
    
            var path = "/characters/{character_id}/contacts/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "character_id" + "}", ApiClient.ParameterToString(characterId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (labelIds != null) queryParams.Add("label_ids", ApiClient.ParameterToString(labelIds)); // query parameter
 if (standing != null) queryParams.Add("standing", ApiClient.ParameterToString(standing)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
 if (watched != null) queryParams.Add("watched", ApiClient.ParameterToString(watched)); // query parameter
                                    postBody = ApiClient.Serialize(contactIds); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "evesso" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PutCharactersCharacterIdContacts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutCharactersCharacterIdContacts: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
