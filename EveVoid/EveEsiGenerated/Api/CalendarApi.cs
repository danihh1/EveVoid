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
    public interface ICalendarApi
    {
        /// <summary>
        /// List calendar event summaries Get 50 event summaries from the calendar. If no from_event ID is given, the resource will return the next 50 chronological event summaries from now. If a from_event ID is specified, it will return the next 50 chronological event summaries from after that event  - -- Alternate route: &#x60;/dev/characters/{character_id}/calendar/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/calendar/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/calendar/&#x60;  Alternate route: &#x60;/v2/characters/{character_id}/calendar/&#x60;  - -- This route is cached for up to 5 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="fromEvent">The event ID to retrieve events from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCharactersCharacterIdCalendar200Ok&gt;</returns>
        List<GetCharactersCharacterIdCalendar200Ok> GetCharactersCharacterIdCalendar (int? characterId, string datasource, int? fromEvent, string ifNoneMatch, string token);
        /// <summary>
        /// Get an event Get all the information for a specific event  - -- Alternate route: &#x60;/dev/characters/{character_id}/calendar/{event_id}/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/calendar/{event_id}/&#x60;  Alternate route: &#x60;/v3/characters/{character_id}/calendar/{event_id}/&#x60;  Alternate route: &#x60;/v4/characters/{character_id}/calendar/{event_id}/&#x60;  - -- This route is cached for up to 5 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="eventId">The id of the event requested</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>GetCharactersCharacterIdCalendarEventIdOk</returns>
        GetCharactersCharacterIdCalendarEventIdOk GetCharactersCharacterIdCalendarEventId (int? characterId, int? eventId, string datasource, string ifNoneMatch, string token);
        /// <summary>
        /// Get attendees Get all invited attendees for a given event  - -- Alternate route: &#x60;/dev/characters/{character_id}/calendar/{event_id}/attendees/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/calendar/{event_id}/attendees/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/calendar/{event_id}/attendees/&#x60;  Alternate route: &#x60;/v2/characters/{character_id}/calendar/{event_id}/attendees/&#x60;  - -- This route is cached for up to 600 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="eventId">The id of the event requested</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>List&lt;GetCharactersCharacterIdCalendarEventIdAttendees200Ok&gt;</returns>
        List<GetCharactersCharacterIdCalendarEventIdAttendees200Ok> GetCharactersCharacterIdCalendarEventIdAttendees (int? characterId, int? eventId, string datasource, string ifNoneMatch, string token);
        /// <summary>
        /// Respond to an event Set your response status to an event  - -- Alternate route: &#x60;/dev/characters/{character_id}/calendar/{event_id}/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/calendar/{event_id}/&#x60;  Alternate route: &#x60;/v3/characters/{character_id}/calendar/{event_id}/&#x60;  Alternate route: &#x60;/v4/characters/{character_id}/calendar/{event_id}/&#x60;  - -- This route is cached for up to 5 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="eventId">The ID of the event requested</param>
        /// <param name="response">The response value to set, overriding current value</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns></returns>
        void PutCharactersCharacterIdCalendarEventId (int? characterId, int? eventId, PutCharactersCharacterIdCalendarEventIdResponse response, string datasource, string token);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CalendarApi : ICalendarApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalendarApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CalendarApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CalendarApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CalendarApi(String basePath)
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
        /// List calendar event summaries Get 50 event summaries from the calendar. If no from_event ID is given, the resource will return the next 50 chronological event summaries from now. If a from_event ID is specified, it will return the next 50 chronological event summaries from after that event  - -- Alternate route: &#x60;/dev/characters/{character_id}/calendar/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/calendar/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/calendar/&#x60;  Alternate route: &#x60;/v2/characters/{character_id}/calendar/&#x60;  - -- This route is cached for up to 5 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="fromEvent">The event ID to retrieve events from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCharactersCharacterIdCalendar200Ok&gt;</returns>            
        public List<GetCharactersCharacterIdCalendar200Ok> GetCharactersCharacterIdCalendar (int? characterId, string datasource, int? fromEvent, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterIdCalendar");
            
    
            var path = "/characters/{character_id}/calendar/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "character_id" + "}", ApiClient.ParameterToString(characterId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (fromEvent != null) queryParams.Add("from_event", ApiClient.ParameterToString(fromEvent)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
             if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "evesso" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdCalendar: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdCalendar: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCharactersCharacterIdCalendar200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCharactersCharacterIdCalendar200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get an event Get all the information for a specific event  - -- Alternate route: &#x60;/dev/characters/{character_id}/calendar/{event_id}/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/calendar/{event_id}/&#x60;  Alternate route: &#x60;/v3/characters/{character_id}/calendar/{event_id}/&#x60;  Alternate route: &#x60;/v4/characters/{character_id}/calendar/{event_id}/&#x60;  - -- This route is cached for up to 5 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="eventId">The id of the event requested</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>GetCharactersCharacterIdCalendarEventIdOk</returns>            
        public GetCharactersCharacterIdCalendarEventIdOk GetCharactersCharacterIdCalendarEventId (int? characterId, int? eventId, string datasource, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterIdCalendarEventId");
            
            // verify the required parameter 'eventId' is set
            if (eventId == null) throw new ApiException(400, "Missing required parameter 'eventId' when calling GetCharactersCharacterIdCalendarEventId");
            
    
            var path = "/characters/{character_id}/calendar/{event_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "character_id" + "}", ApiClient.ParameterToString(characterId));
path = path.Replace("{" + "event_id" + "}", ApiClient.ParameterToString(eventId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdCalendarEventId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdCalendarEventId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetCharactersCharacterIdCalendarEventIdOk) ApiClient.Deserialize(response.Content, typeof(GetCharactersCharacterIdCalendarEventIdOk), response.Headers);
        }
    
        /// <summary>
        /// Get attendees Get all invited attendees for a given event  - -- Alternate route: &#x60;/dev/characters/{character_id}/calendar/{event_id}/attendees/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/calendar/{event_id}/attendees/&#x60;  Alternate route: &#x60;/v1/characters/{character_id}/calendar/{event_id}/attendees/&#x60;  Alternate route: &#x60;/v2/characters/{character_id}/calendar/{event_id}/attendees/&#x60;  - -- This route is cached for up to 600 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="eventId">The id of the event requested</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>List&lt;GetCharactersCharacterIdCalendarEventIdAttendees200Ok&gt;</returns>            
        public List<GetCharactersCharacterIdCalendarEventIdAttendees200Ok> GetCharactersCharacterIdCalendarEventIdAttendees (int? characterId, int? eventId, string datasource, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling GetCharactersCharacterIdCalendarEventIdAttendees");
            
            // verify the required parameter 'eventId' is set
            if (eventId == null) throw new ApiException(400, "Missing required parameter 'eventId' when calling GetCharactersCharacterIdCalendarEventIdAttendees");
            
    
            var path = "/characters/{character_id}/calendar/{event_id}/attendees/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "character_id" + "}", ApiClient.ParameterToString(characterId));
path = path.Replace("{" + "event_id" + "}", ApiClient.ParameterToString(eventId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdCalendarEventIdAttendees: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCharactersCharacterIdCalendarEventIdAttendees: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetCharactersCharacterIdCalendarEventIdAttendees200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetCharactersCharacterIdCalendarEventIdAttendees200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Respond to an event Set your response status to an event  - -- Alternate route: &#x60;/dev/characters/{character_id}/calendar/{event_id}/&#x60;  Alternate route: &#x60;/legacy/characters/{character_id}/calendar/{event_id}/&#x60;  Alternate route: &#x60;/v3/characters/{character_id}/calendar/{event_id}/&#x60;  Alternate route: &#x60;/v4/characters/{character_id}/calendar/{event_id}/&#x60;  - -- This route is cached for up to 5 seconds
        /// </summary>
        /// <param name="characterId">An EVE character ID</param> 
        /// <param name="eventId">The ID of the event requested</param> 
        /// <param name="response">The response value to set, overriding current value</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns></returns>            
        public void PutCharactersCharacterIdCalendarEventId (int? characterId, int? eventId, PutCharactersCharacterIdCalendarEventIdResponse response, string datasource, string token)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling PutCharactersCharacterIdCalendarEventId");
            
            // verify the required parameter 'eventId' is set
            if (eventId == null) throw new ApiException(400, "Missing required parameter 'eventId' when calling PutCharactersCharacterIdCalendarEventId");
            
            // verify the required parameter 'response' is set
            if (response == null) throw new ApiException(400, "Missing required parameter 'response' when calling PutCharactersCharacterIdCalendarEventId");
            
    
            var path = "/characters/{character_id}/calendar/{event_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "character_id" + "}", ApiClient.ParameterToString(characterId));
path = path.Replace("{" + "event_id" + "}", ApiClient.ParameterToString(eventId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                    postBody = ApiClient.Serialize(response); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "evesso" };

            // make the HTTP request
            IRestResponse restResponse = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)restResponse.StatusCode) >= 400)
                throw new ApiException ((int)restResponse.StatusCode, "Error calling PutCharactersCharacterIdCalendarEventId: " + restResponse.Content, restResponse.Content);
            else if (((int)restResponse.StatusCode) == 0)
                throw new ApiException ((int)restResponse.StatusCode, "Error calling PutCharactersCharacterIdCalendarEventId: " + restResponse.ErrorMessage, restResponse.ErrorMessage);
    
            return;
        }
    
    }
}
