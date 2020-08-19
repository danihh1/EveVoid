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
    public interface IMarketApi
    {
        /// <summary>
        /// List open orders from a character List open market orders placed by a character  - -- Alternate route: &#x60;/dev/characters/{character_id}/orders/&#x60;  Alternate route: &#x60;/v2/characters/{character_id}/orders/&#x60;  - -- This route is cached for up to 1200 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCharactersCharacterIdOrders200Ok&gt;</returns>
        List<GetCharactersCharacterIdOrders200Ok> GetCharactersCharacterIdOrders (int? characterId, string datasource, string ifNoneMatch, string token);
        /// <summary>
        /// List historical orders by a character List cancelled and expired market orders placed by a character up to 90 days in the past.  - -- Alternate route: &#x60;/dev/characters/{character_id}/orders/history/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/orders/history/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/orders/history/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="page">Which page of results to return</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCharactersCharacterIdOrdersHistory200Ok&gt;</returns>
        List<GetCharactersCharacterIdOrdersHistory200Ok> GetCharactersCharacterIdOrdersHistory (int? characterId, string datasource, string ifNoneMatch, int? page, string token);
        /// <summary>
        /// List open orders from a corporation List open market orders placed on behalf of a corporation  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/orders/&#x60;  Alternate route: &#x60;/v3/corporations/{corporation_id}/orders/&#x60;  - -- This route is cached for up to 1200 seconds  - -- Requires one of the following EVE corporation role(s): Accountant, Trader 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="page">Which page of results to return</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCorporationsCorporationIdOrders200Ok&gt;</returns>
        List<GetCorporationsCorporationIdOrders200Ok> GetCorporationsCorporationIdOrders (int? corporationId, string datasource, string ifNoneMatch, int? page, string token);
        /// <summary>
        /// List historical orders from a corporation List cancelled and expired market orders placed on behalf of a corporation up to 90 days in the past.  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/orders/history/&#x60;  Alternate route: &#x60;/v2/corporations/{corporation_id}/orders/history/&#x60;  - -- This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Accountant, Trader 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="page">Which page of results to return</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCorporationsCorporationIdOrdersHistory200Ok&gt;</returns>
        List<GetCorporationsCorporationIdOrdersHistory200Ok> GetCorporationsCorporationIdOrdersHistory (int? corporationId, string datasource, string ifNoneMatch, int? page, string token);
        /// <summary>
        /// Get item groups Get a list of item groups  - -- Alternate route: &#x60;/dev/markets/groups/&#x60;  Alternate route: &#x60;/legacy/markets/groups/&#x60;  Alternate route: &#x60;/v1/markets/groups/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>List&lt;int?&gt;</returns>
        List<int?> GetMarketsGroups (string datasource, string ifNoneMatch);
        /// <summary>
        /// Get item group information Get information on an item group  - -- Alternate route: &#x60;/dev/markets/groups/{market_group_id}/&#x60;  Alternate route: &#x60;/legacy/markets/groups/{market_group_id}/&#x60;  Alternate route: &#x60;/v1/markets/groups/{market_group_id}/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="marketGroupId">An Eve item group ID</param>
        /// <param name="acceptLanguage">Language to use in the response</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="language">Language to use in the response, takes precedence over Accept-Language</param>
        /// <returns>GetMarketsGroupsMarketGroupIdOk</returns>
        GetMarketsGroupsMarketGroupIdOk GetMarketsGroupsMarketGroupId (int? marketGroupId, string acceptLanguage, string datasource, string ifNoneMatch, string language);
        /// <summary>
        /// List market prices Return a list of prices  - -- Alternate route: &#x60;/dev/markets/prices/&#x60;  Alternate route: &#x60;/legacy/markets/prices/&#x60;  Alternate route: &#x60;/v1/markets/prices/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>List&lt;GetMarketsPrices200Ok&gt;</returns>
        List<GetMarketsPrices200Ok> GetMarketsPrices (string datasource, string ifNoneMatch);
        /// <summary>
        /// List historical market statistics in a region Return a list of historical market statistics for the specified type in a region  - -- Alternate route: &#x60;/dev/markets/{region_id}/history/&#x60;  Alternate route: &#x60;/legacy/markets/{region_id}/history/&#x60;  Alternate route: &#x60;/v1/markets/{region_id}/history/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="regionId">Return statistics in this region</param>
        /// <param name="typeId">Return statistics for this type</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>List&lt;GetMarketsRegionIdHistory200Ok&gt;</returns>
        List<GetMarketsRegionIdHistory200Ok> GetMarketsRegionIdHistory (int? regionId, int? typeId, string datasource, string ifNoneMatch);
        /// <summary>
        /// List orders in a region Return a list of orders in a region  - -- Alternate route: &#x60;/dev/markets/{region_id}/orders/&#x60;  Alternate route: &#x60;/legacy/markets/{region_id}/orders/&#x60;  Alternate route: &#x60;/v1/markets/{region_id}/orders/&#x60;  - -- This route is cached for up to 300 seconds
        /// </summary>
        /// <param name="orderType">Filter buy/sell orders, return all orders by default. If you query without type_id, we always return both buy and sell orders</param>
        /// <param name="regionId">Return orders in this region</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="page">Which page of results to return</param>
        /// <param name="typeId">Return orders only for this type</param>
        /// <returns>List&lt;GetMarketsRegionIdOrders200Ok&gt;</returns>
        List<GetMarketsRegionIdOrders200Ok> GetMarketsRegionIdOrders (string orderType, int? regionId, string datasource, string ifNoneMatch, int? page, int? typeId);
        /// <summary>
        /// List type IDs relevant to a market Return a list of type IDs that have active orders in the region, for efficient market indexing.  - -- Alternate route: &#x60;/dev/markets/{region_id}/types/&#x60;  Alternate route: &#x60;/legacy/markets/{region_id}/types/&#x60;  Alternate route: &#x60;/v1/markets/{region_id}/types/&#x60;  - -- This route is cached for up to 600 seconds
        /// </summary>
        /// <param name="regionId">Return statistics in this region</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="page">Which page of results to return</param>
        /// <returns>List&lt;int?&gt;</returns>
        List<int?> GetMarketsRegionIdTypes (int? regionId, string datasource, string ifNoneMatch, int? page);
        /// <summary>
        /// List orders in a structure Return all orders in a structure  - -- Alternate route: &#x60;/dev/markets/structures/{structure_id}/&#x60;  Alternate route: &#x60;/legacy/markets/structures/{structure_id}/&#x60;  Alternate route: &#x60;/v1/markets/structures/{structure_id}/&#x60;  - -- This route is cached for up to 300 seconds
        /// </summary>
        /// <param name="structureId">Return orders in this structure</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="page">Which page of results to return</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetMarketsStructuresStructureId200Ok&gt;</returns>
        List<GetMarketsStructuresStructureId200Ok> GetMarketsStructuresStructureId (long? structureId, string datasource, string ifNoneMatch, int? page, string token);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MarketApi : IMarketApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public MarketApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MarketApi(String basePath)
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
        /// List open orders from a character List open market orders placed by a character  - -- Alternate route: &#x60;/dev/characters/{character_id}/orders/&#x60;  Alternate route: &#x60;/v2/characters/{character_id}/orders/&#x60;  - -- This route is cached for up to 1200 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCharactersCharacterIdOrders200Ok&gt;</returns>            
        public List<GetCharactersCharacterIdOrders200Ok> GetCharactersCharacterIdOrders (int? characterId, string datasource, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterIdOrders");
            
    
            var path = "/characters/{character_id}/orders/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdOrders: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdOrders: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCharactersCharacterIdOrders200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCharactersCharacterIdOrders200Ok>), response.Headers);
        }
    
        /// <summary>
        /// List historical orders by a character List cancelled and expired market orders placed by a character up to 90 days in the past.  - -- Alternate route: &#x60;/dev/characters/{character_id}/orders/history/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/orders/history/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/orders/history/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCharactersCharacterIdOrdersHistory200Ok&gt;</returns>            
        public List<GetCharactersCharacterIdOrdersHistory200Ok> GetCharactersCharacterIdOrdersHistory (int? characterId, string datasource, string ifNoneMatch, int? page, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterIdOrdersHistory");
            
    
            var path = "/characters/{character_id}/orders/history/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdOrdersHistory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdOrdersHistory: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCharactersCharacterIdOrdersHistory200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCharactersCharacterIdOrdersHistory200Ok>), response.Headers);
        }
    
        /// <summary>
        /// List open orders from a corporation List open market orders placed on behalf of a corporation  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/orders/&#x60;  Alternate route: &#x60;/v3/corporations/{corporation_id}/orders/&#x60;  - -- This route is cached for up to 1200 seconds  - -- Requires one of the following EVE corporation role(s): Accountant, Trader 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCorporationsCorporationIdOrders200Ok&gt;</returns>            
        public List<GetCorporationsCorporationIdOrders200Ok> GetCorporationsCorporationIdOrders (int? corporationId, string datasource, string ifNoneMatch, int? page, string token)
        {
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling GetCorporationsCorporationIdOrders");
            
    
            var path = "/corporations/{corporation_id}/orders/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdOrders: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdOrders: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCorporationsCorporationIdOrders200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCorporationsCorporationIdOrders200Ok>), response.Headers);
        }
    
        /// <summary>
        /// List historical orders from a corporation List cancelled and expired market orders placed on behalf of a corporation up to 90 days in the past.  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/orders/history/&#x60;  Alternate route: &#x60;/v2/corporations/{corporation_id}/orders/history/&#x60;  - -- This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Accountant, Trader 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCorporationsCorporationIdOrdersHistory200Ok&gt;</returns>            
        public List<GetCorporationsCorporationIdOrdersHistory200Ok> GetCorporationsCorporationIdOrdersHistory (int? corporationId, string datasource, string ifNoneMatch, int? page, string token)
        {
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling GetCorporationsCorporationIdOrdersHistory");
            
    
            var path = "/corporations/{corporation_id}/orders/history/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdOrdersHistory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdOrdersHistory: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCorporationsCorporationIdOrdersHistory200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCorporationsCorporationIdOrdersHistory200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get item groups Get a list of item groups  - -- Alternate route: &#x60;/dev/markets/groups/&#x60;  Alternate route: &#x60;/legacy/markets/groups/&#x60;  Alternate route: &#x60;/v1/markets/groups/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>List&lt;int?&gt;</returns>            
        public List<int?> GetMarketsGroups (string datasource, string ifNoneMatch)
        {
            
    
            var path = "/markets/groups/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetMarketsGroups: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMarketsGroups: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<int?>) ApiClient.Deserialize(response.Content, typeof(List<int?>), response.Headers);
        }
    
        /// <summary>
        /// Get item group information Get information on an item group  - -- Alternate route: &#x60;/dev/markets/groups/{market_group_id}/&#x60;  Alternate route: &#x60;/legacy/markets/groups/{market_group_id}/&#x60;  Alternate route: &#x60;/v1/markets/groups/{market_group_id}/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="marketGroupId">An Eve item group ID</param> 
        /// <param name="acceptLanguage">Language to use in the response</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="language">Language to use in the response, takes precedence over Accept-Language</param> 
        /// <returns>GetMarketsGroupsMarketGroupIdOk</returns>            
        public GetMarketsGroupsMarketGroupIdOk GetMarketsGroupsMarketGroupId (int? marketGroupId, string acceptLanguage, string datasource, string ifNoneMatch, string language)
        {
            
            // verify the required parameter 'marketGroupId' is set
            if (marketGroupId == null) throw new ApiException(400, "Missing required parameter 'marketGroupId' when calling GetMarketsGroupsMarketGroupId");
            
    
            var path = "/markets/groups/{market_group_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "market_group_id" + "}", ApiClient.ParameterToString(marketGroupId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetMarketsGroupsMarketGroupId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMarketsGroupsMarketGroupId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetMarketsGroupsMarketGroupIdOk) ApiClient.Deserialize(response.Content, typeof(GetMarketsGroupsMarketGroupIdOk), response.Headers);
        }
    
        /// <summary>
        /// List market prices Return a list of prices  - -- Alternate route: &#x60;/dev/markets/prices/&#x60;  Alternate route: &#x60;/legacy/markets/prices/&#x60;  Alternate route: &#x60;/v1/markets/prices/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>List&lt;GetMarketsPrices200Ok&gt;</returns>            
        public List<GetMarketsPrices200Ok> GetMarketsPrices (string datasource, string ifNoneMatch)
        {
            
    
            var path = "/markets/prices/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetMarketsPrices: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMarketsPrices: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetMarketsPrices200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetMarketsPrices200Ok>), response.Headers);
        }
    
        /// <summary>
        /// List historical market statistics in a region Return a list of historical market statistics for the specified type in a region  - -- Alternate route: &#x60;/dev/markets/{region_id}/history/&#x60;  Alternate route: &#x60;/legacy/markets/{region_id}/history/&#x60;  Alternate route: &#x60;/v1/markets/{region_id}/history/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="regionId">Return statistics in this region</param> 
        /// <param name="typeId">Return statistics for this type</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>List&lt;GetMarketsRegionIdHistory200Ok&gt;</returns>            
        public List<GetMarketsRegionIdHistory200Ok> GetMarketsRegionIdHistory (int? regionId, int? typeId, string datasource, string ifNoneMatch)
        {
            
            // verify the required parameter 'regionId' is set
            if (regionId == null) throw new ApiException(400, "Missing required parameter 'regionId' when calling GetMarketsRegionIdHistory");
            
            // verify the required parameter 'typeId' is set
            if (typeId == null) throw new ApiException(400, "Missing required parameter 'typeId' when calling GetMarketsRegionIdHistory");
            
    
            var path = "/markets/{region_id}/history/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "region_id" + "}", ApiClient.ParameterToString(regionId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (typeId != null) queryParams.Add("type_id", ApiClient.ParameterToString(typeId)); // query parameter
             if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMarketsRegionIdHistory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMarketsRegionIdHistory: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetMarketsRegionIdHistory200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetMarketsRegionIdHistory200Ok>), response.Headers);
        }
    
        /// <summary>
        /// List orders in a region Return a list of orders in a region  - -- Alternate route: &#x60;/dev/markets/{region_id}/orders/&#x60;  Alternate route: &#x60;/legacy/markets/{region_id}/orders/&#x60;  Alternate route: &#x60;/v1/markets/{region_id}/orders/&#x60;  - -- This route is cached for up to 300 seconds
        /// </summary>
        /// <param name="orderType">Filter buy/sell orders, return all orders by default. If you query without type_id, we always return both buy and sell orders</param> 
        /// <param name="regionId">Return orders in this region</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <param name="typeId">Return orders only for this type</param> 
        /// <returns>List&lt;GetMarketsRegionIdOrders200Ok&gt;</returns>            
        public List<GetMarketsRegionIdOrders200Ok> GetMarketsRegionIdOrders (string orderType, int? regionId, string datasource, string ifNoneMatch, int? page, int? typeId)
        {
            
            // verify the required parameter 'orderType' is set
            if (orderType == null) throw new ApiException(400, "Missing required parameter 'orderType' when calling GetMarketsRegionIdOrders");
            
            // verify the required parameter 'regionId' is set
            if (regionId == null) throw new ApiException(400, "Missing required parameter 'regionId' when calling GetMarketsRegionIdOrders");
            
    
            var path = "/markets/{region_id}/orders/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "region_id" + "}", ApiClient.ParameterToString(regionId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (orderType != null) queryParams.Add("order_type", ApiClient.ParameterToString(orderType)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (typeId != null) queryParams.Add("type_id", ApiClient.ParameterToString(typeId)); // query parameter
             if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMarketsRegionIdOrders: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMarketsRegionIdOrders: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetMarketsRegionIdOrders200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetMarketsRegionIdOrders200Ok>), response.Headers);
        }
    
        /// <summary>
        /// List type IDs relevant to a market Return a list of type IDs that have active orders in the region, for efficient market indexing.  - -- Alternate route: &#x60;/dev/markets/{region_id}/types/&#x60;  Alternate route: &#x60;/legacy/markets/{region_id}/types/&#x60;  Alternate route: &#x60;/v1/markets/{region_id}/types/&#x60;  - -- This route is cached for up to 600 seconds
        /// </summary>
        /// <param name="regionId">Return statistics in this region</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <returns>List&lt;int?&gt;</returns>            
        public List<int?> GetMarketsRegionIdTypes (int? regionId, string datasource, string ifNoneMatch, int? page)
        {
            
            // verify the required parameter 'regionId' is set
            if (regionId == null) throw new ApiException(400, "Missing required parameter 'regionId' when calling GetMarketsRegionIdTypes");
            
    
            var path = "/markets/{region_id}/types/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "region_id" + "}", ApiClient.ParameterToString(regionId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
             if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMarketsRegionIdTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMarketsRegionIdTypes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<int?>) ApiClient.Deserialize(response.Content, typeof(List<int?>), response.Headers);
        }
    
        /// <summary>
        /// List orders in a structure Return all orders in a structure  - -- Alternate route: &#x60;/dev/markets/structures/{structure_id}/&#x60;  Alternate route: &#x60;/legacy/markets/structures/{structure_id}/&#x60;  Alternate route: &#x60;/v1/markets/structures/{structure_id}/&#x60;  - -- This route is cached for up to 300 seconds
        /// </summary>
        /// <param name="structureId">Return orders in this structure</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetMarketsStructuresStructureId200Ok&gt;</returns>            
        public List<GetMarketsStructuresStructureId200Ok> GetMarketsStructuresStructureId (long? structureId, string datasource, string ifNoneMatch, int? page, string token)
        {
            
            // verify the required parameter 'structureId' is set
            if (structureId == null) throw new ApiException(400, "Missing required parameter 'structureId' when calling GetMarketsStructuresStructureId");
            
    
            var path = "/markets/structures/{structure_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "structure_id" + "}", ApiClient.ParameterToString(structureId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetMarketsStructuresStructureId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMarketsStructuresStructureId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetMarketsStructuresStructureId200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetMarketsStructuresStructureId200Ok>), response.Headers);
        }
    
    }
}
