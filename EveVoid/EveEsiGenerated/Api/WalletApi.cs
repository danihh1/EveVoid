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
    public interface IWalletApi
    {
        /// <summary>
        /// Get a character&#39;s wallet balance Returns a character&#39;s wallet balance  - -- Alternate route: &#x60;/legacy/characters/{character_id}/wallet/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/wallet/&#x60;  - -- This route is cached for up to 120 seconds  - -- [Diff of the upcoming changes](https://esi.evetech.net/diff/latest/dev/#GET-/characters/{character_id}/wallet/)
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>double?</returns>
        double? GetCharactersCharacterIdWallet (int? characterId, string datasource, string ifNoneMatch, string token);
        /// <summary>
        /// Get character wallet journal Retrieve the given character&#39;s wallet journal going 30 days back  - -- Alternate route: &#x60;/dev/characters/{character_id}/wallet/journal/&#x60;  Alternate route: &#x60;/v6/characters/{character_id}/wallet/journal/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="page">Which page of results to return</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCharactersCharacterIdWalletJournal200Ok&gt;</returns>
        List<GetCharactersCharacterIdWalletJournal200Ok> GetCharactersCharacterIdWalletJournal (int? characterId, string datasource, string ifNoneMatch, int? page, string token);
        /// <summary>
        /// Get wallet transactions Get wallet transactions of a character  - -- Alternate route: &#x60;/dev/characters/{character_id}/wallet/transactions/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/wallet/transactions/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/wallet/transactions/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="fromId">Only show transactions happened before the one referenced by this id</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCharactersCharacterIdWalletTransactions200Ok&gt;</returns>
        List<GetCharactersCharacterIdWalletTransactions200Ok> GetCharactersCharacterIdWalletTransactions (int? characterId, string datasource, long? fromId, string ifNoneMatch, string token);
        /// <summary>
        /// Returns a corporation&#39;s wallet balance Get a corporation&#39;s wallets  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/wallets/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/wallets/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/wallets/&#x60;  - -- This route is cached for up to 300 seconds  - -- Requires one of the following EVE corporation role(s): Accountant, Junior_Accountant 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCorporationsCorporationIdWallets200Ok&gt;</returns>
        List<GetCorporationsCorporationIdWallets200Ok> GetCorporationsCorporationIdWallets (int? corporationId, string datasource, string ifNoneMatch, string token);
        /// <summary>
        /// Get corporation wallet journal Retrieve the given corporation&#39;s wallet journal for the given division going 30 days back  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/wallets/{division}/journal/&#x60;  Alternate route: &#x60;/v4/corporations/{corporation_id}/wallets/{division}/journal/&#x60;  - -- This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Accountant, Junior_Accountant 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="division">Wallet key of the division to fetch journals from</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="page">Which page of results to return</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCorporationsCorporationIdWalletsDivisionJournal200Ok&gt;</returns>
        List<GetCorporationsCorporationIdWalletsDivisionJournal200Ok> GetCorporationsCorporationIdWalletsDivisionJournal (int? corporationId, int? division, string datasource, string ifNoneMatch, int? page, string token);
        /// <summary>
        /// Get corporation wallet transactions Get wallet transactions of a corporation  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/wallets/{division}/transactions/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/wallets/{division}/transactions/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/wallets/{division}/transactions/&#x60;  - -- This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Accountant, Junior_Accountant 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="division">Wallet key of the division to fetch journals from</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="fromId">Only show journal entries happened before the transaction referenced by this id</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCorporationsCorporationIdWalletsDivisionTransactions200Ok&gt;</returns>
        List<GetCorporationsCorporationIdWalletsDivisionTransactions200Ok> GetCorporationsCorporationIdWalletsDivisionTransactions (int? corporationId, int? division, string datasource, long? fromId, string ifNoneMatch, string token);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class WalletApi : IWalletApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public WalletApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WalletApi(String basePath)
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
        /// Get a character&#39;s wallet balance Returns a character&#39;s wallet balance  - -- Alternate route: &#x60;/legacy/characters/{character_id}/wallet/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/wallet/&#x60;  - -- This route is cached for up to 120 seconds  - -- [Diff of the upcoming changes](https://esi.evetech.net/diff/latest/dev/#GET-/characters/{character_id}/wallet/)
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>double?</returns>            
        public double? GetCharactersCharacterIdWallet (int? characterId, string datasource, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterIdWallet");
            
    
            var path = "/characters/{character_id}/wallet/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdWallet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdWallet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (double?) ApiClient.Deserialize(response.Content, typeof(double?), response.Headers);
        }
    
        /// <summary>
        /// Get character wallet journal Retrieve the given character&#39;s wallet journal going 30 days back  - -- Alternate route: &#x60;/dev/characters/{character_id}/wallet/journal/&#x60;  Alternate route: &#x60;/v6/characters/{character_id}/wallet/journal/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCharactersCharacterIdWalletJournal200Ok&gt;</returns>            
        public List<GetCharactersCharacterIdWalletJournal200Ok> GetCharactersCharacterIdWalletJournal (int? characterId, string datasource, string ifNoneMatch, int? page, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterIdWalletJournal");
            
    
            var path = "/characters/{character_id}/wallet/journal/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdWalletJournal: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdWalletJournal: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCharactersCharacterIdWalletJournal200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCharactersCharacterIdWalletJournal200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get wallet transactions Get wallet transactions of a character  - -- Alternate route: &#x60;/dev/characters/{character_id}/wallet/transactions/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/wallet/transactions/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/wallet/transactions/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="fromId">Only show transactions happened before the one referenced by this id</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCharactersCharacterIdWalletTransactions200Ok&gt;</returns>            
        public List<GetCharactersCharacterIdWalletTransactions200Ok> GetCharactersCharacterIdWalletTransactions (int? characterId, string datasource, long? fromId, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterIdWalletTransactions");
            
    
            var path = "/characters/{character_id}/wallet/transactions/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "character_id" + "}", ApiClient.ParameterToString(characterId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (fromId != null) queryParams.Add("from_id", ApiClient.ParameterToString(fromId)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
             if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "evesso" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdWalletTransactions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdWalletTransactions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCharactersCharacterIdWalletTransactions200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCharactersCharacterIdWalletTransactions200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Returns a corporation&#39;s wallet balance Get a corporation&#39;s wallets  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/wallets/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/wallets/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/wallets/&#x60;  - -- This route is cached for up to 300 seconds  - -- Requires one of the following EVE corporation role(s): Accountant, Junior_Accountant 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCorporationsCorporationIdWallets200Ok&gt;</returns>            
        public List<GetCorporationsCorporationIdWallets200Ok> GetCorporationsCorporationIdWallets (int? corporationId, string datasource, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling GetCorporationsCorporationIdWallets");
            
    
            var path = "/corporations/{corporation_id}/wallets/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdWallets: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdWallets: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCorporationsCorporationIdWallets200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCorporationsCorporationIdWallets200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get corporation wallet journal Retrieve the given corporation&#39;s wallet journal for the given division going 30 days back  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/wallets/{division}/journal/&#x60;  Alternate route: &#x60;/v4/corporations/{corporation_id}/wallets/{division}/journal/&#x60;  - -- This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Accountant, Junior_Accountant 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="division">Wallet key of the division to fetch journals from</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCorporationsCorporationIdWalletsDivisionJournal200Ok&gt;</returns>            
        public List<GetCorporationsCorporationIdWalletsDivisionJournal200Ok> GetCorporationsCorporationIdWalletsDivisionJournal (int? corporationId, int? division, string datasource, string ifNoneMatch, int? page, string token)
        {
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling GetCorporationsCorporationIdWalletsDivisionJournal");
            
            // verify the required parameter 'division' is set
            if (division == null) throw new ApiException(400, "Missing required parameter 'division' when calling GetCorporationsCorporationIdWalletsDivisionJournal");
            
    
            var path = "/corporations/{corporation_id}/wallets/{division}/journal/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "corporation_id" + "}", ApiClient.ParameterToString(corporationId));
path = path.Replace("{" + "division" + "}", ApiClient.ParameterToString(division));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdWalletsDivisionJournal: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdWalletsDivisionJournal: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCorporationsCorporationIdWalletsDivisionJournal200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCorporationsCorporationIdWalletsDivisionJournal200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get corporation wallet transactions Get wallet transactions of a corporation  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/wallets/{division}/transactions/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/wallets/{division}/transactions/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/wallets/{division}/transactions/&#x60;  - -- This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Accountant, Junior_Accountant 
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="division">Wallet key of the division to fetch journals from</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="fromId">Only show journal entries happened before the transaction referenced by this id</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCorporationsCorporationIdWalletsDivisionTransactions200Ok&gt;</returns>            
        public List<GetCorporationsCorporationIdWalletsDivisionTransactions200Ok> GetCorporationsCorporationIdWalletsDivisionTransactions (int? corporationId, int? division, string datasource, long? fromId, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling GetCorporationsCorporationIdWalletsDivisionTransactions");
            
            // verify the required parameter 'division' is set
            if (division == null) throw new ApiException(400, "Missing required parameter 'division' when calling GetCorporationsCorporationIdWalletsDivisionTransactions");
            
    
            var path = "/corporations/{corporation_id}/wallets/{division}/transactions/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "corporation_id" + "}", ApiClient.ParameterToString(corporationId));
path = path.Replace("{" + "division" + "}", ApiClient.ParameterToString(division));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (fromId != null) queryParams.Add("from_id", ApiClient.ParameterToString(fromId)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
             if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "evesso" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdWalletsDivisionTransactions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdWalletsDivisionTransactions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCorporationsCorporationIdWalletsDivisionTransactions200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCorporationsCorporationIdWalletsDivisionTransactions200Ok>), response.Headers);
        }
    
    }
}
