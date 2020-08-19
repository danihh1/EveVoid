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
    public interface IDogmaApi
    {
        /// <summary>
        /// Get attributes Get a list of dogma attribute ids  - -- Alternate route: &#x60;/dev/dogma/attributes/&#x60;  Alternate route: &#x60;/legacy/dogma/attributes/&#x60;  Alternate route: &#x60;/v1/dogma/attributes/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>List&lt;int?&gt;</returns>
        List<int?> GetDogmaAttributes (string datasource, string ifNoneMatch);
        /// <summary>
        /// Get attribute information Get information on a dogma attribute  - -- Alternate route: &#x60;/dev/dogma/attributes/{attribute_id}/&#x60;  Alternate route: &#x60;/legacy/dogma/attributes/{attribute_id}/&#x60;  Alternate route: &#x60;/v1/dogma/attributes/{attribute_id}/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="attributeId">A dogma attribute ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>GetDogmaAttributesAttributeIdOk</returns>
        GetDogmaAttributesAttributeIdOk GetDogmaAttributesAttributeId (int? attributeId, string datasource, string ifNoneMatch);
        /// <summary>
        /// Get dynamic item information Returns info about a dynamic item resulting from mutation with a mutaplasmid.  - -- Alternate route: &#x60;/dev/dogma/dynamic/items/{type_id}/{item_id}/&#x60;  Alternate route: &#x60;/legacy/dogma/dynamic/items/{type_id}/{item_id}/&#x60;  Alternate route: &#x60;/v1/dogma/dynamic/items/{type_id}/{item_id}/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="itemId">item_id integer</param>
        /// <param name="typeId">type_id integer</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>GetDogmaDynamicItemsTypeIdItemIdOk</returns>
        GetDogmaDynamicItemsTypeIdItemIdOk GetDogmaDynamicItemsTypeIdItemId (long? itemId, int? typeId, string datasource, string ifNoneMatch);
        /// <summary>
        /// Get effects Get a list of dogma effect ids  - -- Alternate route: &#x60;/dev/dogma/effects/&#x60;  Alternate route: &#x60;/legacy/dogma/effects/&#x60;  Alternate route: &#x60;/v1/dogma/effects/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>List&lt;int?&gt;</returns>
        List<int?> GetDogmaEffects (string datasource, string ifNoneMatch);
        /// <summary>
        /// Get effect information Get information on a dogma effect  - -- Alternate route: &#x60;/dev/dogma/effects/{effect_id}/&#x60;  Alternate route: &#x60;/v2/dogma/effects/{effect_id}/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="effectId">A dogma effect ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>GetDogmaEffectsEffectIdOk</returns>
        GetDogmaEffectsEffectIdOk GetDogmaEffectsEffectId (int? effectId, string datasource, string ifNoneMatch);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DogmaApi : IDogmaApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DogmaApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public DogmaApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DogmaApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DogmaApi(String basePath)
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
        /// Get attributes Get a list of dogma attribute ids  - -- Alternate route: &#x60;/dev/dogma/attributes/&#x60;  Alternate route: &#x60;/legacy/dogma/attributes/&#x60;  Alternate route: &#x60;/v1/dogma/attributes/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>List&lt;int?&gt;</returns>            
        public List<int?> GetDogmaAttributes (string datasource, string ifNoneMatch)
        {
            
    
            var path = "/dogma/attributes/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetDogmaAttributes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDogmaAttributes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<int?>) ApiClient.Deserialize(response.Content, typeof(List<int?>), response.Headers);
        }
    
        /// <summary>
        /// Get attribute information Get information on a dogma attribute  - -- Alternate route: &#x60;/dev/dogma/attributes/{attribute_id}/&#x60;  Alternate route: &#x60;/legacy/dogma/attributes/{attribute_id}/&#x60;  Alternate route: &#x60;/v1/dogma/attributes/{attribute_id}/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="attributeId">A dogma attribute ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>GetDogmaAttributesAttributeIdOk</returns>            
        public GetDogmaAttributesAttributeIdOk GetDogmaAttributesAttributeId (int? attributeId, string datasource, string ifNoneMatch)
        {
            
            // verify the required parameter 'attributeId' is set
            if (attributeId == null) throw new ApiException(400, "Missing required parameter 'attributeId' when calling GetDogmaAttributesAttributeId");
            
    
            var path = "/dogma/attributes/{attribute_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "attribute_id" + "}", ApiClient.ParameterToString(attributeId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetDogmaAttributesAttributeId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDogmaAttributesAttributeId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetDogmaAttributesAttributeIdOk) ApiClient.Deserialize(response.Content, typeof(GetDogmaAttributesAttributeIdOk), response.Headers);
        }
    
        /// <summary>
        /// Get dynamic item information Returns info about a dynamic item resulting from mutation with a mutaplasmid.  - -- Alternate route: &#x60;/dev/dogma/dynamic/items/{type_id}/{item_id}/&#x60;  Alternate route: &#x60;/legacy/dogma/dynamic/items/{type_id}/{item_id}/&#x60;  Alternate route: &#x60;/v1/dogma/dynamic/items/{type_id}/{item_id}/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="itemId">item_id integer</param> 
        /// <param name="typeId">type_id integer</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>GetDogmaDynamicItemsTypeIdItemIdOk</returns>            
        public GetDogmaDynamicItemsTypeIdItemIdOk GetDogmaDynamicItemsTypeIdItemId (long? itemId, int? typeId, string datasource, string ifNoneMatch)
        {
            
            // verify the required parameter 'itemId' is set
            if (itemId == null) throw new ApiException(400, "Missing required parameter 'itemId' when calling GetDogmaDynamicItemsTypeIdItemId");
            
            // verify the required parameter 'typeId' is set
            if (typeId == null) throw new ApiException(400, "Missing required parameter 'typeId' when calling GetDogmaDynamicItemsTypeIdItemId");
            
    
            var path = "/dogma/dynamic/items/{type_id}/{item_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "item_id" + "}", ApiClient.ParameterToString(itemId));
path = path.Replace("{" + "type_id" + "}", ApiClient.ParameterToString(typeId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetDogmaDynamicItemsTypeIdItemId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDogmaDynamicItemsTypeIdItemId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetDogmaDynamicItemsTypeIdItemIdOk) ApiClient.Deserialize(response.Content, typeof(GetDogmaDynamicItemsTypeIdItemIdOk), response.Headers);
        }
    
        /// <summary>
        /// Get effects Get a list of dogma effect ids  - -- Alternate route: &#x60;/dev/dogma/effects/&#x60;  Alternate route: &#x60;/legacy/dogma/effects/&#x60;  Alternate route: &#x60;/v1/dogma/effects/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>List&lt;int?&gt;</returns>            
        public List<int?> GetDogmaEffects (string datasource, string ifNoneMatch)
        {
            
    
            var path = "/dogma/effects/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetDogmaEffects: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDogmaEffects: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<int?>) ApiClient.Deserialize(response.Content, typeof(List<int?>), response.Headers);
        }
    
        /// <summary>
        /// Get effect information Get information on a dogma effect  - -- Alternate route: &#x60;/dev/dogma/effects/{effect_id}/&#x60;  Alternate route: &#x60;/v2/dogma/effects/{effect_id}/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="effectId">A dogma effect ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>GetDogmaEffectsEffectIdOk</returns>            
        public GetDogmaEffectsEffectIdOk GetDogmaEffectsEffectId (int? effectId, string datasource, string ifNoneMatch)
        {
            
            // verify the required parameter 'effectId' is set
            if (effectId == null) throw new ApiException(400, "Missing required parameter 'effectId' when calling GetDogmaEffectsEffectId");
            
    
            var path = "/dogma/effects/{effect_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "effect_id" + "}", ApiClient.ParameterToString(effectId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetDogmaEffectsEffectId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDogmaEffectsEffectId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetDogmaEffectsEffectIdOk) ApiClient.Deserialize(response.Content, typeof(GetDogmaEffectsEffectIdOk), response.Headers);
        }
    
    }
}
