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
    public interface IMailApi
    {
        /// <summary>
        /// Delete a mail label Delete a mail label  - -- Alternate route: &#x60;/dev/characters/{character_id}/mail/labels/{label_id}/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/mail/labels/{label_id}/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/mail/labels/{label_id}/&#x60; 
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="labelId">An EVE label id</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns></returns>
        void DeleteCharactersCharacterIdMailLabelsLabelId (int? characterId, int? labelId, string datasource, string token);
        /// <summary>
        /// Delete a mail Delete a mail  - -- Alternate route: &#x60;/dev/characters/{character_id}/mail/{mail_id}/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/mail/{mail_id}/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/mail/{mail_id}/&#x60; 
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="mailId">An EVE mail ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns></returns>
        void DeleteCharactersCharacterIdMailMailId (int? characterId, int? mailId, string datasource, string token);
        /// <summary>
        /// Return mail headers Return the 50 most recent mail headers belonging to the character that match the query criteria. Queries can be filtered by label, and last_mail_id can be used to paginate backwards  - -- Alternate route: &#x60;/dev/characters/{character_id}/mail/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/mail/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/mail/&#x60;  - -- This route is cached for up to 30 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="labels">Fetch only mails that match one or more of the given labels</param>
        /// <param name="lastMailId">List only mail with an ID lower than the given ID, if present</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCharactersCharacterIdMail200Ok&gt;</returns>
        List<GetCharactersCharacterIdMail200Ok> GetCharactersCharacterIdMail (int? characterId, string datasource, string ifNoneMatch, List<int?> labels, int? lastMailId, string token);
        /// <summary>
        /// Get mail labels and unread counts Return a list of the users mail labels, unread counts for each label and a total unread count.  - -- Alternate route: &#x60;/dev/characters/{character_id}/mail/labels/&#x60;  Alternate route: &#x60;/v3/characters/{character_id}/mail/labels/&#x60;  - -- This route is cached for up to 30 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>GetCharactersCharacterIdMailLabelsOk</returns>
        GetCharactersCharacterIdMailLabelsOk GetCharactersCharacterIdMailLabels (int? characterId, string datasource, string ifNoneMatch, string token);
        /// <summary>
        /// Return mailing list subscriptions Return all mailing lists that the character is subscribed to  - -- Alternate route: &#x60;/dev/characters/{character_id}/mail/lists/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/mail/lists/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/mail/lists/&#x60;  - -- This route is cached for up to 120 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCharactersCharacterIdMailLists200Ok&gt;</returns>
        List<GetCharactersCharacterIdMailLists200Ok> GetCharactersCharacterIdMailLists (int? characterId, string datasource, string ifNoneMatch, string token);
        /// <summary>
        /// Return a mail Return the contents of an EVE mail  - -- Alternate route: &#x60;/dev/characters/{character_id}/mail/{mail_id}/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/mail/{mail_id}/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/mail/{mail_id}/&#x60;  - -- This route is cached for up to 30 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="mailId">An EVE mail ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>GetCharactersCharacterIdMailMailIdOk</returns>
        GetCharactersCharacterIdMailMailIdOk GetCharactersCharacterIdMailMailId (int? characterId, int? mailId, string datasource, string ifNoneMatch, string token);
        /// <summary>
        /// Send a new mail Create and send a new mail  - -- Alternate route: &#x60;/dev/characters/{character_id}/mail/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/mail/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/mail/&#x60; 
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="mail">The mail to send</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>int?</returns>
        int? PostCharactersCharacterIdMail (int? characterId, PostCharactersCharacterIdMailMail mail, string datasource, string token);
        /// <summary>
        /// Create a mail label Create a mail label  - -- Alternate route: &#x60;/dev/characters/{character_id}/mail/labels/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/mail/labels/&#x60;  Alternate route: &#x60;/v2/characters/{character_id}/mail/labels/&#x60; 
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="label">Label to create</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>int?</returns>
        int? PostCharactersCharacterIdMailLabels (int? characterId, PostCharactersCharacterIdMailLabelsLabel label, string datasource, string token);
        /// <summary>
        /// Update metadata about a mail Update metadata about a mail  - -- Alternate route: &#x60;/dev/characters/{character_id}/mail/{mail_id}/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/mail/{mail_id}/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/mail/{mail_id}/&#x60; 
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="contents">Data used to update the mail</param>
        /// <param name="mailId">An EVE mail ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns></returns>
        void PutCharactersCharacterIdMailMailId (int? characterId, PutCharactersCharacterIdMailMailIdContents contents, int? mailId, string datasource, string token);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MailApi : IMailApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MailApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public MailApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MailApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MailApi(String basePath)
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
        /// Delete a mail label Delete a mail label  - -- Alternate route: &#x60;/dev/characters/{character_id}/mail/labels/{label_id}/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/mail/labels/{label_id}/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/mail/labels/{label_id}/&#x60; 
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="labelId">An EVE label id</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns></returns>            
        public void DeleteCharactersCharacterIdMailLabelsLabelId (int? characterId, int? labelId, string datasource, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling DeleteCharactersCharacterIdMailLabelsLabelId");
            
            // verify the required parameter 'labelId' is set
            if (labelId == null) throw new ApiException(400, "Missing required parameter 'labelId' when calling DeleteCharactersCharacterIdMailLabelsLabelId");
            
    
            var path = "/characters/{character_id}/mail/labels/{label_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "character_id" + "}", ApiClient.ParameterToString(characterId));
path = path.Replace("{" + "label_id" + "}", ApiClient.ParameterToString(labelId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCharactersCharacterIdMailLabelsLabelId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCharactersCharacterIdMailLabelsLabelId: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a mail Delete a mail  - -- Alternate route: &#x60;/dev/characters/{character_id}/mail/{mail_id}/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/mail/{mail_id}/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/mail/{mail_id}/&#x60; 
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="mailId">An EVE mail ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns></returns>            
        public void DeleteCharactersCharacterIdMailMailId (int? characterId, int? mailId, string datasource, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling DeleteCharactersCharacterIdMailMailId");
            
            // verify the required parameter 'mailId' is set
            if (mailId == null) throw new ApiException(400, "Missing required parameter 'mailId' when calling DeleteCharactersCharacterIdMailMailId");
            
    
            var path = "/characters/{character_id}/mail/{mail_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "character_id" + "}", ApiClient.ParameterToString(characterId));
path = path.Replace("{" + "mail_id" + "}", ApiClient.ParameterToString(mailId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCharactersCharacterIdMailMailId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCharactersCharacterIdMailMailId: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Return mail headers Return the 50 most recent mail headers belonging to the character that match the query criteria. Queries can be filtered by label, and last_mail_id can be used to paginate backwards  - -- Alternate route: &#x60;/dev/characters/{character_id}/mail/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/mail/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/mail/&#x60;  - -- This route is cached for up to 30 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="labels">Fetch only mails that match one or more of the given labels</param> 
        /// <param name="lastMailId">List only mail with an ID lower than the given ID, if present</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCharactersCharacterIdMail200Ok&gt;</returns>            
        public List<GetCharactersCharacterIdMail200Ok> GetCharactersCharacterIdMail (int? characterId, string datasource, string ifNoneMatch, List<int?> labels, int? lastMailId, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterIdMail");
            
    
            var path = "/characters/{character_id}/mail/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "character_id" + "}", ApiClient.ParameterToString(characterId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (labels != null) queryParams.Add("labels", ApiClient.ParameterToString(labels)); // query parameter
 if (lastMailId != null) queryParams.Add("last_mail_id", ApiClient.ParameterToString(lastMailId)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
             if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "evesso" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdMail: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdMail: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCharactersCharacterIdMail200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCharactersCharacterIdMail200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get mail labels and unread counts Return a list of the users mail labels, unread counts for each label and a total unread count.  - -- Alternate route: &#x60;/dev/characters/{character_id}/mail/labels/&#x60;  Alternate route: &#x60;/v3/characters/{character_id}/mail/labels/&#x60;  - -- This route is cached for up to 30 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>GetCharactersCharacterIdMailLabelsOk</returns>            
        public GetCharactersCharacterIdMailLabelsOk GetCharactersCharacterIdMailLabels (int? characterId, string datasource, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterIdMailLabels");
            
    
            var path = "/characters/{character_id}/mail/labels/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdMailLabels: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdMailLabels: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetCharactersCharacterIdMailLabelsOk) ApiClient.Deserialize(response.Content, typeof(GetCharactersCharacterIdMailLabelsOk), response.Headers);
        }
    
        /// <summary>
        /// Return mailing list subscriptions Return all mailing lists that the character is subscribed to  - -- Alternate route: &#x60;/dev/characters/{character_id}/mail/lists/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/mail/lists/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/mail/lists/&#x60;  - -- This route is cached for up to 120 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCharactersCharacterIdMailLists200Ok&gt;</returns>            
        public List<GetCharactersCharacterIdMailLists200Ok> GetCharactersCharacterIdMailLists (int? characterId, string datasource, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterIdMailLists");
            
    
            var path = "/characters/{character_id}/mail/lists/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdMailLists: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdMailLists: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCharactersCharacterIdMailLists200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCharactersCharacterIdMailLists200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Return a mail Return the contents of an EVE mail  - -- Alternate route: &#x60;/dev/characters/{character_id}/mail/{mail_id}/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/mail/{mail_id}/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/mail/{mail_id}/&#x60;  - -- This route is cached for up to 30 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="mailId">An EVE mail ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>GetCharactersCharacterIdMailMailIdOk</returns>            
        public GetCharactersCharacterIdMailMailIdOk GetCharactersCharacterIdMailMailId (int? characterId, int? mailId, string datasource, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterIdMailMailId");
            
            // verify the required parameter 'mailId' is set
            if (mailId == null) throw new ApiException(400, "Missing required parameter 'mailId' when calling GetCharactersCharacterIdMailMailId");
            
    
            var path = "/characters/{character_id}/mail/{mail_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "character_id" + "}", ApiClient.ParameterToString(characterId));
path = path.Replace("{" + "mail_id" + "}", ApiClient.ParameterToString(mailId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdMailMailId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdMailMailId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetCharactersCharacterIdMailMailIdOk) ApiClient.Deserialize(response.Content, typeof(GetCharactersCharacterIdMailMailIdOk), response.Headers);
        }
    
        /// <summary>
        /// Send a new mail Create and send a new mail  - -- Alternate route: &#x60;/dev/characters/{character_id}/mail/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/mail/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/mail/&#x60; 
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="mail">The mail to send</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>int?</returns>            
        public int? PostCharactersCharacterIdMail (int? characterId, PostCharactersCharacterIdMailMail mail, string datasource, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling PostCharactersCharacterIdMail");
            
            // verify the required parameter 'mail' is set
            if (mail == null) throw new ApiException(400, "Missing required parameter 'mail' when calling PostCharactersCharacterIdMail");
            
    
            var path = "/characters/{character_id}/mail/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "character_id" + "}", ApiClient.ParameterToString(characterId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                    postBody = ApiClient.Serialize(mail); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "evesso" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostCharactersCharacterIdMail: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostCharactersCharacterIdMail: " + response.ErrorMessage, response.ErrorMessage);
    
            return (int?) ApiClient.Deserialize(response.Content, typeof(int?), response.Headers);
        }
    
        /// <summary>
        /// Create a mail label Create a mail label  - -- Alternate route: &#x60;/dev/characters/{character_id}/mail/labels/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/mail/labels/&#x60;  Alternate route: &#x60;/v2/characters/{character_id}/mail/labels/&#x60; 
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="label">Label to create</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>int?</returns>            
        public int? PostCharactersCharacterIdMailLabels (int? characterId, PostCharactersCharacterIdMailLabelsLabel label, string datasource, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling PostCharactersCharacterIdMailLabels");
            
            // verify the required parameter 'label' is set
            if (label == null) throw new ApiException(400, "Missing required parameter 'label' when calling PostCharactersCharacterIdMailLabels");
            
    
            var path = "/characters/{character_id}/mail/labels/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "character_id" + "}", ApiClient.ParameterToString(characterId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                    postBody = ApiClient.Serialize(label); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "evesso" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostCharactersCharacterIdMailLabels: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostCharactersCharacterIdMailLabels: " + response.ErrorMessage, response.ErrorMessage);
    
            return (int?) ApiClient.Deserialize(response.Content, typeof(int?), response.Headers);
        }
    
        /// <summary>
        /// Update metadata about a mail Update metadata about a mail  - -- Alternate route: &#x60;/dev/characters/{character_id}/mail/{mail_id}/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/mail/{mail_id}/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/mail/{mail_id}/&#x60; 
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="contents">Data used to update the mail</param> 
        /// <param name="mailId">An EVE mail ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns></returns>            
        public void PutCharactersCharacterIdMailMailId (int? characterId, PutCharactersCharacterIdMailMailIdContents contents, int? mailId, string datasource, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling PutCharactersCharacterIdMailMailId");
            
            // verify the required parameter 'contents' is set
            if (contents == null) throw new ApiException(400, "Missing required parameter 'contents' when calling PutCharactersCharacterIdMailMailId");
            
            // verify the required parameter 'mailId' is set
            if (mailId == null) throw new ApiException(400, "Missing required parameter 'mailId' when calling PutCharactersCharacterIdMailMailId");
            
    
            var path = "/characters/{character_id}/mail/{mail_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "character_id" + "}", ApiClient.ParameterToString(characterId));
path = path.Replace("{" + "mail_id" + "}", ApiClient.ParameterToString(mailId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                    postBody = ApiClient.Serialize(contents); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "evesso" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PutCharactersCharacterIdMailMailId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutCharactersCharacterIdMailMailId: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
