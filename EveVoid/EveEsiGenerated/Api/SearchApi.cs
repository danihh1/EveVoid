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
    public interface ISearchApi
    {
        /// <summary>
        /// Search on a string Search for entities that match a given sub-string.  - -- Alternate route: &#x60;/dev/characters/{character_id}/search/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/search/&#x60;  Alternate route: &#x60;/v3/characters/{character_id}/search/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="categories">Type of entities to search for</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="search">The string to search on</param>
        /// <param name="acceptLanguage">Language to use in the response</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="language">Language to use in the response, takes precedence over Accept-Language</param>
        /// <param name="strict">Whether the search should be a strict match</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>GetCharactersCharacterIdSearchOk</returns>
        GetCharactersCharacterIdSearchOk GetCharactersCharacterIdSearch (List<string> categories, int? characterId, string search, string acceptLanguage, string datasource, string ifNoneMatch, string language, bool? strict, string token);
        /// <summary>
        /// Search on a string Search for entities that match a given sub-string.  - -- Alternate route: &#x60;/dev/search/&#x60;  Alternate route: &#x60;/legacy/search/&#x60;  Alternate route: &#x60;/v2/search/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="categories">Type of entities to search for</param>
        /// <param name="search">The string to search on</param>
        /// <param name="acceptLanguage">Language to use in the response</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="language">Language to use in the response, takes precedence over Accept-Language</param>
        /// <param name="strict">Whether the search should be a strict match</param>
        /// <returns>GetSearchOk</returns>
        GetSearchOk GetSearch (List<string> categories, string search, string acceptLanguage, string datasource, string ifNoneMatch, string language, bool? strict);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SearchApi : ISearchApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SearchApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SearchApi(String basePath)
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
        /// Search on a string Search for entities that match a given sub-string.  - -- Alternate route: &#x60;/dev/characters/{character_id}/search/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/search/&#x60;  Alternate route: &#x60;/v3/characters/{character_id}/search/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="categories">Type of entities to search for</param> 
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="search">The string to search on</param> 
        /// <param name="acceptLanguage">Language to use in the response</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="language">Language to use in the response, takes precedence over Accept-Language</param> 
        /// <param name="strict">Whether the search should be a strict match</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>GetCharactersCharacterIdSearchOk</returns>            
        public GetCharactersCharacterIdSearchOk GetCharactersCharacterIdSearch (List<string> categories, int? characterId, string search, string acceptLanguage, string datasource, string ifNoneMatch, string language, bool? strict, string token)
        {
            
            // verify the required parameter 'categories' is set
            if (categories == null) throw new ApiException(400, "Missing required parameter 'categories' when calling GetCharactersCharacterIdSearch");
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterIdSearch");
            
            // verify the required parameter 'search' is set
            if (search == null) throw new ApiException(400, "Missing required parameter 'search' when calling GetCharactersCharacterIdSearch");
            
    
            var path = "/characters/{character_id}/search/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "character_id" + "}", ApiClient.ParameterToString(characterId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (categories != null) queryParams.Add("categories", ApiClient.ParameterToString(categories)); // query parameter
 if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
 if (search != null) queryParams.Add("search", ApiClient.ParameterToString(search)); // query parameter
 if (strict != null) queryParams.Add("strict", ApiClient.ParameterToString(strict)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
             if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
 if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "evesso" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdSearch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdSearch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetCharactersCharacterIdSearchOk) ApiClient.Deserialize(response.Content, typeof(GetCharactersCharacterIdSearchOk), response.Headers);
        }
    
        /// <summary>
        /// Search on a string Search for entities that match a given sub-string.  - -- Alternate route: &#x60;/dev/search/&#x60;  Alternate route: &#x60;/legacy/search/&#x60;  Alternate route: &#x60;/v2/search/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="categories">Type of entities to search for</param> 
        /// <param name="search">The string to search on</param> 
        /// <param name="acceptLanguage">Language to use in the response</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="language">Language to use in the response, takes precedence over Accept-Language</param> 
        /// <param name="strict">Whether the search should be a strict match</param> 
        /// <returns>GetSearchOk</returns>            
        public GetSearchOk GetSearch (List<string> categories, string search, string acceptLanguage, string datasource, string ifNoneMatch, string language, bool? strict)
        {
            
            // verify the required parameter 'categories' is set
            if (categories == null) throw new ApiException(400, "Missing required parameter 'categories' when calling GetSearch");
            
            // verify the required parameter 'search' is set
            if (search == null) throw new ApiException(400, "Missing required parameter 'search' when calling GetSearch");
            
    
            var path = "/search/";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (categories != null) queryParams.Add("categories", ApiClient.ParameterToString(categories)); // query parameter
 if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
 if (search != null) queryParams.Add("search", ApiClient.ParameterToString(search)); // query parameter
 if (strict != null) queryParams.Add("strict", ApiClient.ParameterToString(strict)); // query parameter
             if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
 if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSearch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSearch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetSearchOk) ApiClient.Deserialize(response.Content, typeof(GetSearchOk), response.Headers);
        }
    
    }
}
