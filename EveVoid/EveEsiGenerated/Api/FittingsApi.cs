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
    public interface IFittingsApi
    {
        /// <summary>
        /// Delete fitting Delete a fitting from a character  - -- Alternate route: &#x60;/dev/characters/{character_id}/fittings/{fitting_id}/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/fittings/{fitting_id}/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/fittings/{fitting_id}/&#x60; 
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="fittingId">ID for a fitting of this character</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns></returns>
        void DeleteCharactersCharacterIdFittingsFittingId (int? characterId, int? fittingId, string datasource, string token);
        /// <summary>
        /// Get fittings Return fittings of a character  - -- Alternate route: &#x60;/dev/characters/{character_id}/fittings/&#x60;  Alternate route: &#x60;/v2/characters/{character_id}/fittings/&#x60;  - -- This route is cached for up to 300 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCharactersCharacterIdFittings200Ok&gt;</returns>
        List<GetCharactersCharacterIdFittings200Ok> GetCharactersCharacterIdFittings (int? characterId, string datasource, string ifNoneMatch, string token);
        /// <summary>
        /// Create fitting Save a new fitting for a character  - -- Alternate route: &#x60;/dev/characters/{character_id}/fittings/&#x60;  Alternate route: &#x60;/v2/characters/{character_id}/fittings/&#x60; 
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="fitting">Details about the new fitting</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>PostCharactersCharacterIdFittingsCreated</returns>
        PostCharactersCharacterIdFittingsCreated PostCharactersCharacterIdFittings (int? characterId, PostCharactersCharacterIdFittingsFitting fitting, string datasource, string token);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class FittingsApi : IFittingsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FittingsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public FittingsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FittingsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FittingsApi(String basePath)
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
        /// Delete fitting Delete a fitting from a character  - -- Alternate route: &#x60;/dev/characters/{character_id}/fittings/{fitting_id}/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/fittings/{fitting_id}/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/fittings/{fitting_id}/&#x60; 
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="fittingId">ID for a fitting of this character</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns></returns>            
        public void DeleteCharactersCharacterIdFittingsFittingId (int? characterId, int? fittingId, string datasource, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling DeleteCharactersCharacterIdFittingsFittingId");
            
            // verify the required parameter 'fittingId' is set
            if (fittingId == null) throw new ApiException(400, "Missing required parameter 'fittingId' when calling DeleteCharactersCharacterIdFittingsFittingId");
            
    
            var path = "/characters/{character_id}/fittings/{fitting_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "character_id" + "}", ApiClient.ParameterToString(characterId));
path = path.Replace("{" + "fitting_id" + "}", ApiClient.ParameterToString(fittingId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "evesso" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCharactersCharacterIdFittingsFittingId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCharactersCharacterIdFittingsFittingId: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get fittings Return fittings of a character  - -- Alternate route: &#x60;/dev/characters/{character_id}/fittings/&#x60;  Alternate route: &#x60;/v2/characters/{character_id}/fittings/&#x60;  - -- This route is cached for up to 300 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCharactersCharacterIdFittings200Ok&gt;</returns>            
        public List<GetCharactersCharacterIdFittings200Ok> GetCharactersCharacterIdFittings (int? characterId, string datasource, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterIdFittings");
            
    
            var path = "/characters/{character_id}/fittings/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdFittings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdFittings: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCharactersCharacterIdFittings200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCharactersCharacterIdFittings200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Create fitting Save a new fitting for a character  - -- Alternate route: &#x60;/dev/characters/{character_id}/fittings/&#x60;  Alternate route: &#x60;/v2/characters/{character_id}/fittings/&#x60; 
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="fitting">Details about the new fitting</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>PostCharactersCharacterIdFittingsCreated</returns>            
        public PostCharactersCharacterIdFittingsCreated PostCharactersCharacterIdFittings (int? characterId, PostCharactersCharacterIdFittingsFitting fitting, string datasource, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling PostCharactersCharacterIdFittings");
            
            // verify the required parameter 'fitting' is set
            if (fitting == null) throw new ApiException(400, "Missing required parameter 'fitting' when calling PostCharactersCharacterIdFittings");
            
    
            var path = "/characters/{character_id}/fittings/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "character_id" + "}", ApiClient.ParameterToString(characterId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                    postBody = ApiClient.Serialize(fitting); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "evesso" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostCharactersCharacterIdFittings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostCharactersCharacterIdFittings: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PostCharactersCharacterIdFittingsCreated) ApiClient.Deserialize(response.Content, typeof(PostCharactersCharacterIdFittingsCreated), response.Headers);
        }
    
    }
}
