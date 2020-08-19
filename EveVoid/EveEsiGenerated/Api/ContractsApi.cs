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
    public interface IContractsApi
    {
        /// <summary>
        /// Get contracts Returns contracts available to a character, only if the character is issuer, acceptor or assignee. Only returns contracts no older than 30 days, or if the status is \&quot;in_progress\&quot;.  - -- Alternate route: &#x60;/dev/characters/{character_id}/contracts/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/contracts/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/contracts/&#x60;  - -- This route is cached for up to 300 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="page">Which page of results to return</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCharactersCharacterIdContracts200Ok&gt;</returns>
        List<GetCharactersCharacterIdContracts200Ok> GetCharactersCharacterIdContracts (int? characterId, string datasource, string ifNoneMatch, int? page, string token);
        /// <summary>
        /// Get contract bids Lists bids on a particular auction contract  - -- Alternate route: &#x60;/dev/characters/{character_id}/contracts/{contract_id}/bids/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/contracts/{contract_id}/bids/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/contracts/{contract_id}/bids/&#x60;  - -- This route is cached for up to 300 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="contractId">ID of a contract</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCharactersCharacterIdContractsContractIdBids200Ok&gt;</returns>
        List<GetCharactersCharacterIdContractsContractIdBids200Ok> GetCharactersCharacterIdContractsContractIdBids (int? characterId, int? contractId, string datasource, string ifNoneMatch, string token);
        /// <summary>
        /// Get contract items Lists items of a particular contract  - -- Alternate route: &#x60;/dev/characters/{character_id}/contracts/{contract_id}/items/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/contracts/{contract_id}/items/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/contracts/{contract_id}/items/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="contractId">ID of a contract</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCharactersCharacterIdContractsContractIdItems200Ok&gt;</returns>
        List<GetCharactersCharacterIdContractsContractIdItems200Ok> GetCharactersCharacterIdContractsContractIdItems (int? characterId, int? contractId, string datasource, string ifNoneMatch, string token);
        /// <summary>
        /// Get public contract bids Lists bids on a public auction contract  - -- Alternate route: &#x60;/dev/contracts/public/bids/{contract_id}/&#x60;  Alternate route: &#x60;/legacy/contracts/public/bids/{contract_id}/&#x60;  Alternate route: &#x60;/v1/contracts/public/bids/{contract_id}/&#x60;  - -- This route is cached for up to 300 seconds
        /// </summary>
        /// <param name="contractId">ID of a contract</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="page">Which page of results to return</param>
        /// <returns>List&lt;GetContractsPublicBidsContractId200Ok&gt;</returns>
        List<GetContractsPublicBidsContractId200Ok> GetContractsPublicBidsContractId (int? contractId, string datasource, string ifNoneMatch, int? page);
        /// <summary>
        /// Get public contract items Lists items of a public contract  - -- Alternate route: &#x60;/dev/contracts/public/items/{contract_id}/&#x60;  Alternate route: &#x60;/legacy/contracts/public/items/{contract_id}/&#x60;  Alternate route: &#x60;/v1/contracts/public/items/{contract_id}/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="contractId">ID of a contract</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="page">Which page of results to return</param>
        /// <returns>List&lt;GetContractsPublicItemsContractId200Ok&gt;</returns>
        List<GetContractsPublicItemsContractId200Ok> GetContractsPublicItemsContractId (int? contractId, string datasource, string ifNoneMatch, int? page);
        /// <summary>
        /// Get public contracts Returns a paginated list of all public contracts in the given region  - -- Alternate route: &#x60;/dev/contracts/public/{region_id}/&#x60;  Alternate route: &#x60;/legacy/contracts/public/{region_id}/&#x60;  Alternate route: &#x60;/v1/contracts/public/{region_id}/&#x60;  - -- This route is cached for up to 1800 seconds
        /// </summary>
        /// <param name="regionId">An EVE region id</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="page">Which page of results to return</param>
        /// <returns>List&lt;GetContractsPublicRegionId200Ok&gt;</returns>
        List<GetContractsPublicRegionId200Ok> GetContractsPublicRegionId (int? regionId, string datasource, string ifNoneMatch, int? page);
        /// <summary>
        /// Get corporation contracts Returns contracts available to a corporation, only if the corporation is issuer, acceptor or assignee. Only returns contracts no older than 30 days, or if the status is \&quot;in_progress\&quot;.  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/contracts/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/contracts/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/contracts/&#x60;  - -- This route is cached for up to 300 seconds
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="page">Which page of results to return</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCorporationsCorporationIdContracts200Ok&gt;</returns>
        List<GetCorporationsCorporationIdContracts200Ok> GetCorporationsCorporationIdContracts (int? corporationId, string datasource, string ifNoneMatch, int? page, string token);
        /// <summary>
        /// Get corporation contract bids Lists bids on a particular auction contract  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/contracts/{contract_id}/bids/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/contracts/{contract_id}/bids/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/contracts/{contract_id}/bids/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="contractId">ID of a contract</param>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="page">Which page of results to return</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCorporationsCorporationIdContractsContractIdBids200Ok&gt;</returns>
        List<GetCorporationsCorporationIdContractsContractIdBids200Ok> GetCorporationsCorporationIdContractsContractIdBids (int? contractId, int? corporationId, string datasource, string ifNoneMatch, int? page, string token);
        /// <summary>
        /// Get corporation contract items Lists items of a particular contract  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/contracts/{contract_id}/items/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/contracts/{contract_id}/items/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/contracts/{contract_id}/items/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="contractId">ID of a contract</param>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCorporationsCorporationIdContractsContractIdItems200Ok&gt;</returns>
        List<GetCorporationsCorporationIdContractsContractIdItems200Ok> GetCorporationsCorporationIdContractsContractIdItems (int? contractId, int? corporationId, string datasource, string ifNoneMatch, string token);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ContractsApi : IContractsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ContractsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ContractsApi(String basePath)
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
        /// Get contracts Returns contracts available to a character, only if the character is issuer, acceptor or assignee. Only returns contracts no older than 30 days, or if the status is \&quot;in_progress\&quot;.  - -- Alternate route: &#x60;/dev/characters/{character_id}/contracts/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/contracts/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/contracts/&#x60;  - -- This route is cached for up to 300 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCharactersCharacterIdContracts200Ok&gt;</returns>            
        public List<GetCharactersCharacterIdContracts200Ok> GetCharactersCharacterIdContracts (int? characterId, string datasource, string ifNoneMatch, int? page, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterIdContracts");
            
    
            var path = "/characters/{character_id}/contracts/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdContracts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdContracts: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCharactersCharacterIdContracts200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCharactersCharacterIdContracts200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get contract bids Lists bids on a particular auction contract  - -- Alternate route: &#x60;/dev/characters/{character_id}/contracts/{contract_id}/bids/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/contracts/{contract_id}/bids/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/contracts/{contract_id}/bids/&#x60;  - -- This route is cached for up to 300 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="contractId">ID of a contract</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCharactersCharacterIdContractsContractIdBids200Ok&gt;</returns>            
        public List<GetCharactersCharacterIdContractsContractIdBids200Ok> GetCharactersCharacterIdContractsContractIdBids (int? characterId, int? contractId, string datasource, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterIdContractsContractIdBids");
            
            // verify the required parameter 'contractId' is set
            if (contractId == null) throw new ApiException(400, "Missing required parameter 'contractId' when calling GetCharactersCharacterIdContractsContractIdBids");
            
    
            var path = "/characters/{character_id}/contracts/{contract_id}/bids/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "character_id" + "}", ApiClient.ParameterToString(characterId));
path = path.Replace("{" + "contract_id" + "}", ApiClient.ParameterToString(contractId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdContractsContractIdBids: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdContractsContractIdBids: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCharactersCharacterIdContractsContractIdBids200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCharactersCharacterIdContractsContractIdBids200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get contract items Lists items of a particular contract  - -- Alternate route: &#x60;/dev/characters/{character_id}/contracts/{contract_id}/items/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/contracts/{contract_id}/items/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/contracts/{contract_id}/items/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="contractId">ID of a contract</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCharactersCharacterIdContractsContractIdItems200Ok&gt;</returns>            
        public List<GetCharactersCharacterIdContractsContractIdItems200Ok> GetCharactersCharacterIdContractsContractIdItems (int? characterId, int? contractId, string datasource, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterIdContractsContractIdItems");
            
            // verify the required parameter 'contractId' is set
            if (contractId == null) throw new ApiException(400, "Missing required parameter 'contractId' when calling GetCharactersCharacterIdContractsContractIdItems");
            
    
            var path = "/characters/{character_id}/contracts/{contract_id}/items/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "character_id" + "}", ApiClient.ParameterToString(characterId));
path = path.Replace("{" + "contract_id" + "}", ApiClient.ParameterToString(contractId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdContractsContractIdItems: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdContractsContractIdItems: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCharactersCharacterIdContractsContractIdItems200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCharactersCharacterIdContractsContractIdItems200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get public contract bids Lists bids on a public auction contract  - -- Alternate route: &#x60;/dev/contracts/public/bids/{contract_id}/&#x60;  Alternate route: &#x60;/legacy/contracts/public/bids/{contract_id}/&#x60;  Alternate route: &#x60;/v1/contracts/public/bids/{contract_id}/&#x60;  - -- This route is cached for up to 300 seconds
        /// </summary>
        /// <param name="contractId">ID of a contract</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <returns>List&lt;GetContractsPublicBidsContractId200Ok&gt;</returns>            
        public List<GetContractsPublicBidsContractId200Ok> GetContractsPublicBidsContractId (int? contractId, string datasource, string ifNoneMatch, int? page)
        {
            
            // verify the required parameter 'contractId' is set
            if (contractId == null) throw new ApiException(400, "Missing required parameter 'contractId' when calling GetContractsPublicBidsContractId");
            
    
            var path = "/contracts/public/bids/{contract_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "contract_id" + "}", ApiClient.ParameterToString(contractId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetContractsPublicBidsContractId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetContractsPublicBidsContractId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetContractsPublicBidsContractId200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetContractsPublicBidsContractId200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get public contract items Lists items of a public contract  - -- Alternate route: &#x60;/dev/contracts/public/items/{contract_id}/&#x60;  Alternate route: &#x60;/legacy/contracts/public/items/{contract_id}/&#x60;  Alternate route: &#x60;/v1/contracts/public/items/{contract_id}/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="contractId">ID of a contract</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <returns>List&lt;GetContractsPublicItemsContractId200Ok&gt;</returns>            
        public List<GetContractsPublicItemsContractId200Ok> GetContractsPublicItemsContractId (int? contractId, string datasource, string ifNoneMatch, int? page)
        {
            
            // verify the required parameter 'contractId' is set
            if (contractId == null) throw new ApiException(400, "Missing required parameter 'contractId' when calling GetContractsPublicItemsContractId");
            
    
            var path = "/contracts/public/items/{contract_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "contract_id" + "}", ApiClient.ParameterToString(contractId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetContractsPublicItemsContractId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetContractsPublicItemsContractId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetContractsPublicItemsContractId200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetContractsPublicItemsContractId200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get public contracts Returns a paginated list of all public contracts in the given region  - -- Alternate route: &#x60;/dev/contracts/public/{region_id}/&#x60;  Alternate route: &#x60;/legacy/contracts/public/{region_id}/&#x60;  Alternate route: &#x60;/v1/contracts/public/{region_id}/&#x60;  - -- This route is cached for up to 1800 seconds
        /// </summary>
        /// <param name="regionId">An EVE region id</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <returns>List&lt;GetContractsPublicRegionId200Ok&gt;</returns>            
        public List<GetContractsPublicRegionId200Ok> GetContractsPublicRegionId (int? regionId, string datasource, string ifNoneMatch, int? page)
        {
            
            // verify the required parameter 'regionId' is set
            if (regionId == null) throw new ApiException(400, "Missing required parameter 'regionId' when calling GetContractsPublicRegionId");
            
    
            var path = "/contracts/public/{region_id}/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetContractsPublicRegionId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetContractsPublicRegionId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetContractsPublicRegionId200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetContractsPublicRegionId200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get corporation contracts Returns contracts available to a corporation, only if the corporation is issuer, acceptor or assignee. Only returns contracts no older than 30 days, or if the status is \&quot;in_progress\&quot;.  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/contracts/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/contracts/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/contracts/&#x60;  - -- This route is cached for up to 300 seconds
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCorporationsCorporationIdContracts200Ok&gt;</returns>            
        public List<GetCorporationsCorporationIdContracts200Ok> GetCorporationsCorporationIdContracts (int? corporationId, string datasource, string ifNoneMatch, int? page, string token)
        {
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling GetCorporationsCorporationIdContracts");
            
    
            var path = "/corporations/{corporation_id}/contracts/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdContracts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdContracts: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCorporationsCorporationIdContracts200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCorporationsCorporationIdContracts200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get corporation contract bids Lists bids on a particular auction contract  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/contracts/{contract_id}/bids/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/contracts/{contract_id}/bids/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/contracts/{contract_id}/bids/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="contractId">ID of a contract</param> 
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCorporationsCorporationIdContractsContractIdBids200Ok&gt;</returns>            
        public List<GetCorporationsCorporationIdContractsContractIdBids200Ok> GetCorporationsCorporationIdContractsContractIdBids (int? contractId, int? corporationId, string datasource, string ifNoneMatch, int? page, string token)
        {
            
            // verify the required parameter 'contractId' is set
            if (contractId == null) throw new ApiException(400, "Missing required parameter 'contractId' when calling GetCorporationsCorporationIdContractsContractIdBids");
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling GetCorporationsCorporationIdContractsContractIdBids");
            
    
            var path = "/corporations/{corporation_id}/contracts/{contract_id}/bids/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "contract_id" + "}", ApiClient.ParameterToString(contractId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdContractsContractIdBids: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdContractsContractIdBids: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCorporationsCorporationIdContractsContractIdBids200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCorporationsCorporationIdContractsContractIdBids200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get corporation contract items Lists items of a particular contract  - -- Alternate route: &#x60;/dev/corporations/{corporation_id}/contracts/{contract_id}/items/&#x60;  Alternate route: &#x60;/legacy/corporations/{corporation_id}/contracts/{contract_id}/items/&#x60;  Alternate route: &#x60;/v1/corporations/{corporation_id}/contracts/{contract_id}/items/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="contractId">ID of a contract</param> 
        /// <param name="corporationId">An EVE corporation ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCorporationsCorporationIdContractsContractIdItems200Ok&gt;</returns>            
        public List<GetCorporationsCorporationIdContractsContractIdItems200Ok> GetCorporationsCorporationIdContractsContractIdItems (int? contractId, int? corporationId, string datasource, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'contractId' is set
            if (contractId == null) throw new ApiException(400, "Missing required parameter 'contractId' when calling GetCorporationsCorporationIdContractsContractIdItems");
            
            // verify the required parameter 'corporationId' is set
            if (corporationId == null) throw new ApiException(400, "Missing required parameter 'corporationId' when calling GetCorporationsCorporationIdContractsContractIdItems");
            
    
            var path = "/corporations/{corporation_id}/contracts/{contract_id}/items/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "contract_id" + "}", ApiClient.ParameterToString(contractId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdContractsContractIdItems: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCorporationsCorporationIdContractsContractIdItems: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCorporationsCorporationIdContractsContractIdItems200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCorporationsCorporationIdContractsContractIdItems200Ok>), response.Headers);
        }
    
    }
}
