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
    public interface IBookmarksApi
    {
        /// <summary>
        /// List bookmarks A list of your character&#39;s personal bookmarks  - -- Alternate route: &#x60;/dev/characters/{character_id}/bookmarks/&#x60;  Alternate route: &#x60;/v2/characters/{character_id}/bookmarks/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="page">Which page of results to return</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCharactersCharacterIdBookmarks200Ok&gt;</returns>
        List<GetCharactersCharacterIdBookmarks200Ok> GetCharactersCharacterIdBookmarks (int? characterId, string datasource, string ifNoneMatch, int? page, string token);
        /// <summary>
        /// List bookmark folders A list of your character&#39;s personal bookmark folders  - -- Alternate route: &#x60;/dev/characters/{character_id}/bookmarks/folders/&#x60;  Alternate route: &#x60;/v2/characters/{character_id}/bookmarks/folders/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="page">Which page of results to return</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCharactersCharacterIdBookmarksFolders200Ok&gt;</returns>
        List<GetCharactersCharacterIdBookmarksFolders200Ok> GetCharactersCharacterIdBookmarksFolders (int? characterId, string datasource, string ifNoneMatch, int? page, string token);
        /// <summary>
        /// List corporation bookmarks A list of your corporation&#39;s bookmarks  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/bookmarks/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/bookmarks/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/bookmarks/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="page">Which page of results to return</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCorporationsCorporationIdBookmarks200Ok&gt;</returns>
        List<GetCorporationsCorporationIdBookmarks200Ok> GetCorporationsCorporationIdBookmarks (int? corporationId, string datasource, string ifNoneMatch, int? page, string token);
        /// <summary>
        /// List corporation bookmark folders A list of your corporation&#39;s bookmark folders  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/bookmarks/folders/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/bookmarks/folders/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/bookmarks/folders/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="page">Which page of results to return</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCorporationsCorporationIdBookmarksFolders200Ok&gt;</returns>
        List<GetCorporationsCorporationIdBookmarksFolders200Ok> GetCorporationsCorporationIdBookmarksFolders (int? corporationId, string datasource, string ifNoneMatch, int? page, string token);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BookmarksApi : IBookmarksApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BookmarksApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public BookmarksApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BookmarksApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BookmarksApi(String basePath)
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
        /// List bookmarks A list of your character&#39;s personal bookmarks  - -- Alternate route: &#x60;/dev/characters/{character_id}/bookmarks/&#x60;  Alternate route: &#x60;/v2/characters/{character_id}/bookmarks/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCharactersCharacterIdBookmarks200Ok&gt;</returns>            
        public List<GetCharactersCharacterIdBookmarks200Ok> GetCharactersCharacterIdBookmarks (int? characterId, string datasource, string ifNoneMatch, int? page, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterIdBookmarks");
            
    
            var path = "/characters/{character_id}/bookmarks/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdBookmarks: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdBookmarks: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCharactersCharacterIdBookmarks200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCharactersCharacterIdBookmarks200Ok>), response.Headers);
        }
    
        /// <summary>
        /// List bookmark folders A list of your character&#39;s personal bookmark folders  - -- Alternate route: &#x60;/dev/characters/{character_id}/bookmarks/folders/&#x60;  Alternate route: &#x60;/v2/characters/{character_id}/bookmarks/folders/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCharactersCharacterIdBookmarksFolders200Ok&gt;</returns>            
        public List<GetCharactersCharacterIdBookmarksFolders200Ok> GetCharactersCharacterIdBookmarksFolders (int? characterId, string datasource, string ifNoneMatch, int? page, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterIdBookmarksFolders");
            
    
            var path = "/characters/{character_id}/bookmarks/folders/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdBookmarksFolders: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdBookmarksFolders: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCharactersCharacterIdBookmarksFolders200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCharactersCharacterIdBookmarksFolders200Ok>), response.Headers);
        }
    
        /// <summary>
        /// List corporation bookmarks A list of your corporation&#39;s bookmarks  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/bookmarks/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/bookmarks/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/bookmarks/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCorporationsCorporationIdBookmarks200Ok&gt;</returns>            
        public List<GetCorporationsCorporationIdBookmarks200Ok> GetCorporationsCorporationIdBookmarks (int? corporationId, string datasource, string ifNoneMatch, int? page, string token)
        {
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling GetCorporationsCorporationIdBookmarks");
            
    
            var path = "/corporations/{corporation_id}/bookmarks/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdBookmarks: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdBookmarks: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCorporationsCorporationIdBookmarks200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCorporationsCorporationIdBookmarks200Ok>), response.Headers);
        }
    
        /// <summary>
        /// List corporation bookmark folders A list of your corporation&#39;s bookmark folders  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/bookmarks/folders/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/bookmarks/folders/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/bookmarks/folders/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCorporationsCorporationIdBookmarksFolders200Ok&gt;</returns>            
        public List<GetCorporationsCorporationIdBookmarksFolders200Ok> GetCorporationsCorporationIdBookmarksFolders (int? corporationId, string datasource, string ifNoneMatch, int? page, string token)
        {
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling GetCorporationsCorporationIdBookmarksFolders");
            
    
            var path = "/corporations/{corporation_id}/bookmarks/folders/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdBookmarksFolders: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdBookmarksFolders: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCorporationsCorporationIdBookmarksFolders200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCorporationsCorporationIdBookmarksFolders200Ok>), response.Headers);
        }
    
    }
}
