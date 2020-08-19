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
    public interface ILoyaltyApi
    {
        /// <summary>
        /// Get loyalty points Return a list of loyalty points for all corporations the character has worked for  - -- Alternate route: &#x60;/dev/characters/{character_id}/loyalty/points/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/loyalty/points/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/loyalty/points/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCharactersCharacterIdLoyaltyPoints200Ok&gt;</returns>
        List<GetCharactersCharacterIdLoyaltyPoints200Ok> GetCharactersCharacterIdLoyaltyPoints (int? characterId, string datasource, string ifNoneMatch, string token);
        /// <summary>
        /// List loyalty store offers Return a list of offers from a specific corporation&#39;s loyalty store  - -- Alternate route: &#x60;/dev/loyalty/stores/{corporation_id}/offers/&#x60;  Alternate route: &#x60;/legacy/loyalty/stores/{corporation_id}/offers/&#x60;  Alternate route: &#x60;/v1/loyalty/stores/{corporation_id}/offers/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>List&lt;GetLoyaltyStoresCorporationIdOffers200Ok&gt;</returns>
        List<GetLoyaltyStoresCorporationIdOffers200Ok> GetLoyaltyStoresCorporationIdOffers (int? corporationId, string datasource, string ifNoneMatch);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class LoyaltyApi : ILoyaltyApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoyaltyApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public LoyaltyApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LoyaltyApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LoyaltyApi(String basePath)
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
        /// Get loyalty points Return a list of loyalty points for all corporations the character has worked for  - -- Alternate route: &#x60;/dev/characters/{character_id}/loyalty/points/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/loyalty/points/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/loyalty/points/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCharactersCharacterIdLoyaltyPoints200Ok&gt;</returns>            
        public List<GetCharactersCharacterIdLoyaltyPoints200Ok> GetCharactersCharacterIdLoyaltyPoints (int? characterId, string datasource, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterIdLoyaltyPoints");
            
    
            var path = "/characters/{character_id}/loyalty/points/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdLoyaltyPoints: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdLoyaltyPoints: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCharactersCharacterIdLoyaltyPoints200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCharactersCharacterIdLoyaltyPoints200Ok>), response.Headers);
        }
    
        /// <summary>
        /// List loyalty store offers Return a list of offers from a specific corporation&#39;s loyalty store  - -- Alternate route: &#x60;/dev/loyalty/stores/{corporation_id}/offers/&#x60;  Alternate route: &#x60;/legacy/loyalty/stores/{corporation_id}/offers/&#x60;  Alternate route: &#x60;/v1/loyalty/stores/{corporation_id}/offers/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>List&lt;GetLoyaltyStoresCorporationIdOffers200Ok&gt;</returns>            
        public List<GetLoyaltyStoresCorporationIdOffers200Ok> GetLoyaltyStoresCorporationIdOffers (int? corporationId, string datasource, string ifNoneMatch)
        {
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling GetLoyaltyStoresCorporationIdOffers");
            
    
            var path = "/loyalty/stores/{corporation_id}/offers/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "corporation_id" + "}", ApiClient.ParameterToString(corporationId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetLoyaltyStoresCorporationIdOffers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetLoyaltyStoresCorporationIdOffers: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetLoyaltyStoresCorporationIdOffers200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetLoyaltyStoresCorporationIdOffers200Ok>), response.Headers);
        }
    
    }
}
