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
    public interface IUniverseApi
    {
        /// <summary>
        /// Get ancestries Get all character ancestries  - -- Alternate route: &#x60;/dev/universe/ancestries/&#x60;  Alternate route: &#x60;/legacy/universe/ancestries/&#x60;  Alternate route: &#x60;/v1/universe/ancestries/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="acceptLanguage">Language to use in the response</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="language">Language to use in the response, takes precedence over Accept-Language</param>
        /// <returns>List&lt;GetUniverseAncestries200Ok&gt;</returns>
        List<GetUniverseAncestries200Ok> GetUniverseAncestries (string acceptLanguage, string datasource, string ifNoneMatch, string language);
        /// <summary>
        /// Get asteroid belt information Get information on an asteroid belt  - -- Alternate route: &#x60;/dev/universe/asteroid_belts/{asteroid_belt_id}/&#x60;  Alternate route: &#x60;/legacy/universe/asteroid_belts/{asteroid_belt_id}/&#x60;  Alternate route: &#x60;/v1/universe/asteroid_belts/{asteroid_belt_id}/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="asteroidBeltId">asteroid_belt_id integer</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>GetUniverseAsteroidBeltsAsteroidBeltIdOk</returns>
        GetUniverseAsteroidBeltsAsteroidBeltIdOk GetUniverseAsteroidBeltsAsteroidBeltId (int? asteroidBeltId, string datasource, string ifNoneMatch);
        /// <summary>
        /// Get bloodlines Get a list of bloodlines  - -- Alternate route: &#x60;/dev/universe/bloodlines/&#x60;  Alternate route: &#x60;/legacy/universe/bloodlines/&#x60;  Alternate route: &#x60;/v1/universe/bloodlines/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="acceptLanguage">Language to use in the response</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="language">Language to use in the response, takes precedence over Accept-Language</param>
        /// <returns>List&lt;GetUniverseBloodlines200Ok&gt;</returns>
        List<GetUniverseBloodlines200Ok> GetUniverseBloodlines (string acceptLanguage, string datasource, string ifNoneMatch, string language);
        /// <summary>
        /// Get item categories Get a list of item categories  - -- Alternate route: &#x60;/dev/universe/categories/&#x60;  Alternate route: &#x60;/legacy/universe/categories/&#x60;  Alternate route: &#x60;/v1/universe/categories/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>List&lt;int?&gt;</returns>
        List<int?> GetUniverseCategories (string datasource, string ifNoneMatch);
        /// <summary>
        /// Get item category information Get information of an item category  - -- Alternate route: &#x60;/dev/universe/categories/{category_id}/&#x60;  Alternate route: &#x60;/legacy/universe/categories/{category_id}/&#x60;  Alternate route: &#x60;/v1/universe/categories/{category_id}/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="categoryId">An Eve item category ID</param>
        /// <param name="acceptLanguage">Language to use in the response</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="language">Language to use in the response, takes precedence over Accept-Language</param>
        /// <returns>GetUniverseCategoriesCategoryIdOk</returns>
        GetUniverseCategoriesCategoryIdOk GetUniverseCategoriesCategoryId (int? categoryId, string acceptLanguage, string datasource, string ifNoneMatch, string language);
        /// <summary>
        /// Get constellations Get a list of constellations  - -- Alternate route: &#x60;/dev/universe/constellations/&#x60;  Alternate route: &#x60;/legacy/universe/constellations/&#x60;  Alternate route: &#x60;/v1/universe/constellations/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>List&lt;int?&gt;</returns>
        List<int?> GetUniverseConstellations (string datasource, string ifNoneMatch);
        /// <summary>
        /// Get constellation information Get information on a constellation  - -- Alternate route: &#x60;/dev/universe/constellations/{constellation_id}/&#x60;  Alternate route: &#x60;/legacy/universe/constellations/{constellation_id}/&#x60;  Alternate route: &#x60;/v1/universe/constellations/{constellation_id}/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="constellationId">constellation_id integer</param>
        /// <param name="acceptLanguage">Language to use in the response</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="language">Language to use in the response, takes precedence over Accept-Language</param>
        /// <returns>GetUniverseConstellationsConstellationIdOk</returns>
        GetUniverseConstellationsConstellationIdOk GetUniverseConstellationsConstellationId (int? constellationId, string acceptLanguage, string datasource, string ifNoneMatch, string language);
        /// <summary>
        /// Get factions Get a list of factions  - -- Alternate route: &#x60;/dev/universe/factions/&#x60;  Alternate route: &#x60;/v2/universe/factions/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="acceptLanguage">Language to use in the response</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="language">Language to use in the response, takes precedence over Accept-Language</param>
        /// <returns>List&lt;GetUniverseFactions200Ok&gt;</returns>
        List<GetUniverseFactions200Ok> GetUniverseFactions (string acceptLanguage, string datasource, string ifNoneMatch, string language);
        /// <summary>
        /// Get graphics Get a list of graphics  - -- Alternate route: &#x60;/dev/universe/graphics/&#x60;  Alternate route: &#x60;/legacy/universe/graphics/&#x60;  Alternate route: &#x60;/v1/universe/graphics/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>List&lt;int?&gt;</returns>
        List<int?> GetUniverseGraphics (string datasource, string ifNoneMatch);
        /// <summary>
        /// Get graphic information Get information on a graphic  - -- Alternate route: &#x60;/dev/universe/graphics/{graphic_id}/&#x60;  Alternate route: &#x60;/legacy/universe/graphics/{graphic_id}/&#x60;  Alternate route: &#x60;/v1/universe/graphics/{graphic_id}/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="graphicId">graphic_id integer</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>GetUniverseGraphicsGraphicIdOk</returns>
        GetUniverseGraphicsGraphicIdOk GetUniverseGraphicsGraphicId (int? graphicId, string datasource, string ifNoneMatch);
        /// <summary>
        /// Get item groups Get a list of item groups  - -- Alternate route: &#x60;/dev/universe/groups/&#x60;  Alternate route: &#x60;/legacy/universe/groups/&#x60;  Alternate route: &#x60;/v1/universe/groups/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="page">Which page of results to return</param>
        /// <returns>List&lt;int?&gt;</returns>
        List<int?> GetUniverseGroups (string datasource, string ifNoneMatch, int? page);
        /// <summary>
        /// Get item group information Get information on an item group  - -- Alternate route: &#x60;/dev/universe/groups/{group_id}/&#x60;  Alternate route: &#x60;/legacy/universe/groups/{group_id}/&#x60;  Alternate route: &#x60;/v1/universe/groups/{group_id}/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="groupId">An Eve item group ID</param>
        /// <param name="acceptLanguage">Language to use in the response</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="language">Language to use in the response, takes precedence over Accept-Language</param>
        /// <returns>GetUniverseGroupsGroupIdOk</returns>
        GetUniverseGroupsGroupIdOk GetUniverseGroupsGroupId (int? groupId, string acceptLanguage, string datasource, string ifNoneMatch, string language);
        /// <summary>
        /// Get moon information Get information on a moon  - -- Alternate route: &#x60;/dev/universe/moons/{moon_id}/&#x60;  Alternate route: &#x60;/legacy/universe/moons/{moon_id}/&#x60;  Alternate route: &#x60;/v1/universe/moons/{moon_id}/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="moonId">moon_id integer</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>GetUniverseMoonsMoonIdOk</returns>
        GetUniverseMoonsMoonIdOk GetUniverseMoonsMoonId (int? moonId, string datasource, string ifNoneMatch);
        /// <summary>
        /// Get planet information Get information on a planet  - -- Alternate route: &#x60;/dev/universe/planets/{planet_id}/&#x60;  Alternate route: &#x60;/legacy/universe/planets/{planet_id}/&#x60;  Alternate route: &#x60;/v1/universe/planets/{planet_id}/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="planetId">planet_id integer</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>GetUniversePlanetsPlanetIdOk</returns>
        GetUniversePlanetsPlanetIdOk GetUniversePlanetsPlanetId (int? planetId, string datasource, string ifNoneMatch);
        /// <summary>
        /// Get character races Get a list of character races  - -- Alternate route: &#x60;/dev/universe/races/&#x60;  Alternate route: &#x60;/legacy/universe/races/&#x60;  Alternate route: &#x60;/v1/universe/races/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="acceptLanguage">Language to use in the response</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="language">Language to use in the response, takes precedence over Accept-Language</param>
        /// <returns>List&lt;GetUniverseRaces200Ok&gt;</returns>
        List<GetUniverseRaces200Ok> GetUniverseRaces (string acceptLanguage, string datasource, string ifNoneMatch, string language);
        /// <summary>
        /// Get regions Get a list of regions  - -- Alternate route: &#x60;/dev/universe/regions/&#x60;  Alternate route: &#x60;/legacy/universe/regions/&#x60;  Alternate route: &#x60;/v1/universe/regions/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>List&lt;int?&gt;</returns>
        List<int?> GetUniverseRegions (string datasource, string ifNoneMatch);
        /// <summary>
        /// Get region information Get information on a region  - -- Alternate route: &#x60;/dev/universe/regions/{region_id}/&#x60;  Alternate route: &#x60;/legacy/universe/regions/{region_id}/&#x60;  Alternate route: &#x60;/v1/universe/regions/{region_id}/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="regionId">region_id integer</param>
        /// <param name="acceptLanguage">Language to use in the response</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="language">Language to use in the response, takes precedence over Accept-Language</param>
        /// <returns>GetUniverseRegionsRegionIdOk</returns>
        GetUniverseRegionsRegionIdOk GetUniverseRegionsRegionId (int? regionId, string acceptLanguage, string datasource, string ifNoneMatch, string language);
        /// <summary>
        /// Get stargate information Get information on a stargate  - -- Alternate route: &#x60;/dev/universe/stargates/{stargate_id}/&#x60;  Alternate route: &#x60;/legacy/universe/stargates/{stargate_id}/&#x60;  Alternate route: &#x60;/v1/universe/stargates/{stargate_id}/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="stargateId">stargate_id integer</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>GetUniverseStargatesStargateIdOk</returns>
        GetUniverseStargatesStargateIdOk GetUniverseStargatesStargateId (int? stargateId, string datasource, string ifNoneMatch);
        /// <summary>
        /// Get star information Get information on a star  - -- Alternate route: &#x60;/dev/universe/stars/{star_id}/&#x60;  Alternate route: &#x60;/legacy/universe/stars/{star_id}/&#x60;  Alternate route: &#x60;/v1/universe/stars/{star_id}/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="starId">star_id integer</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>GetUniverseStarsStarIdOk</returns>
        GetUniverseStarsStarIdOk GetUniverseStarsStarId (int? starId, string datasource, string ifNoneMatch);
        /// <summary>
        /// Get station information Get information on a station  - -- Alternate route: &#x60;/dev/universe/stations/{station_id}/&#x60;  Alternate route: &#x60;/v2/universe/stations/{station_id}/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="stationId">station_id integer</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>GetUniverseStationsStationIdOk</returns>
        GetUniverseStationsStationIdOk GetUniverseStationsStationId (int? stationId, string datasource, string ifNoneMatch);
        /// <summary>
        /// List all public structures List all public structures  - -- Alternate route: &#x60;/dev/universe/structures/&#x60;  Alternate route: &#x60;/legacy/universe/structures/&#x60;  Alternate route: &#x60;/v1/universe/structures/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="filter">Only list public structures that have this service online</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>List&lt;long?&gt;</returns>
        List<long?> GetUniverseStructures (string datasource, string filter, string ifNoneMatch);
        /// <summary>
        /// Get structure information Returns information on requested structure if you are on the ACL. Otherwise, returns \&quot;Forbidden\&quot; for all inputs.  - -- Alternate route: &#x60;/dev/universe/structures/{structure_id}/&#x60;  Alternate route: &#x60;/v2/universe/structures/{structure_id}/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="structureId">An Eve structure ID</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="token">Access token to use if unable to set a header</param>
        /// <returns>GetUniverseStructuresStructureIdOk</returns>
        GetUniverseStructuresStructureIdOk GetUniverseStructuresStructureId (long? structureId, string datasource, string ifNoneMatch, string token);
        /// <summary>
        /// Get system jumps Get the number of jumps in solar systems within the last hour ending at the timestamp of the Last-Modified header, excluding wormhole space. Only systems with jumps will be listed  - -- Alternate route: &#x60;/dev/universe/system_jumps/&#x60;  Alternate route: &#x60;/legacy/universe/system_jumps/&#x60;  Alternate route: &#x60;/v1/universe/system_jumps/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>List&lt;GetUniverseSystemJumps200Ok&gt;</returns>
        List<GetUniverseSystemJumps200Ok> GetUniverseSystemJumps (string datasource, string ifNoneMatch);
        /// <summary>
        /// Get system kills Get the number of ship, pod and NPC kills per solar system within the last hour ending at the timestamp of the Last-Modified header, excluding wormhole space. Only systems with kills will be listed  - -- Alternate route: &#x60;/dev/universe/system_kills/&#x60;  Alternate route: &#x60;/v2/universe/system_kills/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>List&lt;GetUniverseSystemKills200Ok&gt;</returns>
        List<GetUniverseSystemKills200Ok> GetUniverseSystemKills (string datasource, string ifNoneMatch);
        /// <summary>
        /// Get solar systems Get a list of solar systems  - -- Alternate route: &#x60;/dev/universe/systems/&#x60;  Alternate route: &#x60;/legacy/universe/systems/&#x60;  Alternate route: &#x60;/v1/universe/systems/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <returns>List&lt;int?&gt;</returns>
        List<int?> GetUniverseSystems (string datasource, string ifNoneMatch);
        /// <summary>
        /// Get solar system information Get information on a solar system.  - -- Alternate route: &#x60;/dev/universe/systems/{system_id}/&#x60;  Alternate route: &#x60;/v4/universe/systems/{system_id}/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="systemId">system_id integer</param>
        /// <param name="acceptLanguage">Language to use in the response</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="language">Language to use in the response, takes precedence over Accept-Language</param>
        /// <returns>GetUniverseSystemsSystemIdOk</returns>
        GetUniverseSystemsSystemIdOk GetUniverseSystemsSystemId (int? systemId, string acceptLanguage, string datasource, string ifNoneMatch, string language);
        /// <summary>
        /// Get types Get a list of type ids  - -- Alternate route: &#x60;/dev/universe/types/&#x60;  Alternate route: &#x60;/legacy/universe/types/&#x60;  Alternate route: &#x60;/v1/universe/types/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="page">Which page of results to return</param>
        /// <returns>List&lt;int?&gt;</returns>
        List<int?> GetUniverseTypes (string datasource, string ifNoneMatch, int? page);
        /// <summary>
        /// Get type information Get information on a type  - -- Alternate route: &#x60;/dev/universe/types/{type_id}/&#x60;  Alternate route: &#x60;/v3/universe/types/{type_id}/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="typeId">An Eve item type ID</param>
        /// <param name="acceptLanguage">Language to use in the response</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param>
        /// <param name="language">Language to use in the response, takes precedence over Accept-Language</param>
        /// <returns>GetUniverseTypesTypeIdOk</returns>
        GetUniverseTypesTypeIdOk GetUniverseTypesTypeId (int? typeId, string acceptLanguage, string datasource, string ifNoneMatch, string language);
        /// <summary>
        /// Bulk names to IDs Resolve a set of names to IDs in the following categories: agents, alliances, characters, constellations, corporations factions, inventory_types, regions, stations, and systems. Only exact matches will be returned. All names searched for are cached for 12 hours  - -- Alternate route: &#x60;/dev/universe/ids/&#x60;  Alternate route: &#x60;/legacy/universe/ids/&#x60;  Alternate route: &#x60;/v1/universe/ids/&#x60; 
        /// </summary>
        /// <param name="names">The names to resolve</param>
        /// <param name="acceptLanguage">Language to use in the response</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <param name="language">Language to use in the response, takes precedence over Accept-Language</param>
        /// <returns>PostUniverseIdsOk</returns>
        PostUniverseIdsOk PostUniverseIds (List<string> names, string acceptLanguage, string datasource, string language);
        /// <summary>
        /// Get names and categories for a set of IDs Resolve a set of IDs to names and categories. Supported ID&#39;s for resolving are: Characters, Corporations, Alliances, Stations, Solar Systems, Constellations, Regions, Types, Factions  - -- Alternate route: &#x60;/dev/universe/names/&#x60;  Alternate route: &#x60;/v3/universe/names/&#x60; 
        /// </summary>
        /// <param name="ids">The ids to resolve</param>
        /// <param name="datasource">The server name you would like data from</param>
        /// <returns>List&lt;PostUniverseNames200Ok&gt;</returns>
        List<PostUniverseNames200Ok> PostUniverseNames (List<int?> ids, string datasource);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UniverseApi : IUniverseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UniverseApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UniverseApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UniverseApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UniverseApi(String basePath)
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
        /// Get ancestries Get all character ancestries  - -- Alternate route: &#x60;/dev/universe/ancestries/&#x60;  Alternate route: &#x60;/legacy/universe/ancestries/&#x60;  Alternate route: &#x60;/v1/universe/ancestries/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="acceptLanguage">Language to use in the response</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="language">Language to use in the response, takes precedence over Accept-Language</param> 
        /// <returns>List&lt;GetUniverseAncestries200Ok&gt;</returns>            
        public List<GetUniverseAncestries200Ok> GetUniverseAncestries (string acceptLanguage, string datasource, string ifNoneMatch, string language)
        {
            
    
            var path = "/universe/ancestries/";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseAncestries: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseAncestries: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetUniverseAncestries200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetUniverseAncestries200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get asteroid belt information Get information on an asteroid belt  - -- Alternate route: &#x60;/dev/universe/asteroid_belts/{asteroid_belt_id}/&#x60;  Alternate route: &#x60;/legacy/universe/asteroid_belts/{asteroid_belt_id}/&#x60;  Alternate route: &#x60;/v1/universe/asteroid_belts/{asteroid_belt_id}/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="asteroidBeltId">asteroid_belt_id integer</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>GetUniverseAsteroidBeltsAsteroidBeltIdOk</returns>            
        public GetUniverseAsteroidBeltsAsteroidBeltIdOk GetUniverseAsteroidBeltsAsteroidBeltId (int? asteroidBeltId, string datasource, string ifNoneMatch)
        {
            
            // verify the required parameter 'asteroidBeltId' is set
            if (asteroidBeltId == null) throw new ApiException(400, "Missing required parameter 'asteroidBeltId' when calling GetUniverseAsteroidBeltsAsteroidBeltId");
            
    
            var path = "/universe/asteroid_belts/{asteroid_belt_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "asteroid_belt_id" + "}", ApiClient.ParameterToString(asteroidBeltId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseAsteroidBeltsAsteroidBeltId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseAsteroidBeltsAsteroidBeltId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetUniverseAsteroidBeltsAsteroidBeltIdOk) ApiClient.Deserialize(response.Content, typeof(GetUniverseAsteroidBeltsAsteroidBeltIdOk), response.Headers);
        }
    
        /// <summary>
        /// Get bloodlines Get a list of bloodlines  - -- Alternate route: &#x60;/dev/universe/bloodlines/&#x60;  Alternate route: &#x60;/legacy/universe/bloodlines/&#x60;  Alternate route: &#x60;/v1/universe/bloodlines/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="acceptLanguage">Language to use in the response</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="language">Language to use in the response, takes precedence over Accept-Language</param> 
        /// <returns>List&lt;GetUniverseBloodlines200Ok&gt;</returns>            
        public List<GetUniverseBloodlines200Ok> GetUniverseBloodlines (string acceptLanguage, string datasource, string ifNoneMatch, string language)
        {
            
    
            var path = "/universe/bloodlines/";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseBloodlines: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseBloodlines: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetUniverseBloodlines200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetUniverseBloodlines200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get item categories Get a list of item categories  - -- Alternate route: &#x60;/dev/universe/categories/&#x60;  Alternate route: &#x60;/legacy/universe/categories/&#x60;  Alternate route: &#x60;/v1/universe/categories/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>List&lt;int?&gt;</returns>            
        public List<int?> GetUniverseCategories (string datasource, string ifNoneMatch)
        {
            
    
            var path = "/universe/categories/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseCategories: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseCategories: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<int?>) ApiClient.Deserialize(response.Content, typeof(List<int?>), response.Headers);
        }
    
        /// <summary>
        /// Get item category information Get information of an item category  - -- Alternate route: &#x60;/dev/universe/categories/{category_id}/&#x60;  Alternate route: &#x60;/legacy/universe/categories/{category_id}/&#x60;  Alternate route: &#x60;/v1/universe/categories/{category_id}/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="categoryId">An Eve item category ID</param> 
        /// <param name="acceptLanguage">Language to use in the response</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="language">Language to use in the response, takes precedence over Accept-Language</param> 
        /// <returns>GetUniverseCategoriesCategoryIdOk</returns>            
        public GetUniverseCategoriesCategoryIdOk GetUniverseCategoriesCategoryId (int? categoryId, string acceptLanguage, string datasource, string ifNoneMatch, string language)
        {
            
            // verify the required parameter 'categoryId' is set
            if (categoryId == null) throw new ApiException(400, "Missing required parameter 'categoryId' when calling GetUniverseCategoriesCategoryId");
            
    
            var path = "/universe/categories/{category_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "category_id" + "}", ApiClient.ParameterToString(categoryId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseCategoriesCategoryId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseCategoriesCategoryId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetUniverseCategoriesCategoryIdOk) ApiClient.Deserialize(response.Content, typeof(GetUniverseCategoriesCategoryIdOk), response.Headers);
        }
    
        /// <summary>
        /// Get constellations Get a list of constellations  - -- Alternate route: &#x60;/dev/universe/constellations/&#x60;  Alternate route: &#x60;/legacy/universe/constellations/&#x60;  Alternate route: &#x60;/v1/universe/constellations/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>List&lt;int?&gt;</returns>            
        public List<int?> GetUniverseConstellations (string datasource, string ifNoneMatch)
        {
            
    
            var path = "/universe/constellations/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseConstellations: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseConstellations: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<int?>) ApiClient.Deserialize(response.Content, typeof(List<int?>), response.Headers);
        }
    
        /// <summary>
        /// Get constellation information Get information on a constellation  - -- Alternate route: &#x60;/dev/universe/constellations/{constellation_id}/&#x60;  Alternate route: &#x60;/legacy/universe/constellations/{constellation_id}/&#x60;  Alternate route: &#x60;/v1/universe/constellations/{constellation_id}/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="constellationId">constellation_id integer</param> 
        /// <param name="acceptLanguage">Language to use in the response</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="language">Language to use in the response, takes precedence over Accept-Language</param> 
        /// <returns>GetUniverseConstellationsConstellationIdOk</returns>            
        public GetUniverseConstellationsConstellationIdOk GetUniverseConstellationsConstellationId (int? constellationId, string acceptLanguage, string datasource, string ifNoneMatch, string language)
        {
            
            // verify the required parameter 'constellationId' is set
            if (constellationId == null) throw new ApiException(400, "Missing required parameter 'constellationId' when calling GetUniverseConstellationsConstellationId");
            
    
            var path = "/universe/constellations/{constellation_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "constellation_id" + "}", ApiClient.ParameterToString(constellationId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseConstellationsConstellationId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseConstellationsConstellationId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetUniverseConstellationsConstellationIdOk) ApiClient.Deserialize(response.Content, typeof(GetUniverseConstellationsConstellationIdOk), response.Headers);
        }
    
        /// <summary>
        /// Get factions Get a list of factions  - -- Alternate route: &#x60;/dev/universe/factions/&#x60;  Alternate route: &#x60;/v2/universe/factions/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="acceptLanguage">Language to use in the response</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="language">Language to use in the response, takes precedence over Accept-Language</param> 
        /// <returns>List&lt;GetUniverseFactions200Ok&gt;</returns>            
        public List<GetUniverseFactions200Ok> GetUniverseFactions (string acceptLanguage, string datasource, string ifNoneMatch, string language)
        {
            
    
            var path = "/universe/factions/";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseFactions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseFactions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetUniverseFactions200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetUniverseFactions200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get graphics Get a list of graphics  - -- Alternate route: &#x60;/dev/universe/graphics/&#x60;  Alternate route: &#x60;/legacy/universe/graphics/&#x60;  Alternate route: &#x60;/v1/universe/graphics/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>List&lt;int?&gt;</returns>            
        public List<int?> GetUniverseGraphics (string datasource, string ifNoneMatch)
        {
            
    
            var path = "/universe/graphics/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseGraphics: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseGraphics: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<int?>) ApiClient.Deserialize(response.Content, typeof(List<int?>), response.Headers);
        }
    
        /// <summary>
        /// Get graphic information Get information on a graphic  - -- Alternate route: &#x60;/dev/universe/graphics/{graphic_id}/&#x60;  Alternate route: &#x60;/legacy/universe/graphics/{graphic_id}/&#x60;  Alternate route: &#x60;/v1/universe/graphics/{graphic_id}/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="graphicId">graphic_id integer</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>GetUniverseGraphicsGraphicIdOk</returns>            
        public GetUniverseGraphicsGraphicIdOk GetUniverseGraphicsGraphicId (int? graphicId, string datasource, string ifNoneMatch)
        {
            
            // verify the required parameter 'graphicId' is set
            if (graphicId == null) throw new ApiException(400, "Missing required parameter 'graphicId' when calling GetUniverseGraphicsGraphicId");
            
    
            var path = "/universe/graphics/{graphic_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "graphic_id" + "}", ApiClient.ParameterToString(graphicId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseGraphicsGraphicId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseGraphicsGraphicId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetUniverseGraphicsGraphicIdOk) ApiClient.Deserialize(response.Content, typeof(GetUniverseGraphicsGraphicIdOk), response.Headers);
        }
    
        /// <summary>
        /// Get item groups Get a list of item groups  - -- Alternate route: &#x60;/dev/universe/groups/&#x60;  Alternate route: &#x60;/legacy/universe/groups/&#x60;  Alternate route: &#x60;/v1/universe/groups/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <returns>List&lt;int?&gt;</returns>            
        public List<int?> GetUniverseGroups (string datasource, string ifNoneMatch, int? page)
        {
            
    
            var path = "/universe/groups/";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseGroups: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseGroups: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<int?>) ApiClient.Deserialize(response.Content, typeof(List<int?>), response.Headers);
        }
    
        /// <summary>
        /// Get item group information Get information on an item group  - -- Alternate route: &#x60;/dev/universe/groups/{group_id}/&#x60;  Alternate route: &#x60;/legacy/universe/groups/{group_id}/&#x60;  Alternate route: &#x60;/v1/universe/groups/{group_id}/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="groupId">An Eve item group ID</param> 
        /// <param name="acceptLanguage">Language to use in the response</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="language">Language to use in the response, takes precedence over Accept-Language</param> 
        /// <returns>GetUniverseGroupsGroupIdOk</returns>            
        public GetUniverseGroupsGroupIdOk GetUniverseGroupsGroupId (int? groupId, string acceptLanguage, string datasource, string ifNoneMatch, string language)
        {
            
            // verify the required parameter 'groupId' is set
            if (groupId == null) throw new ApiException(400, "Missing required parameter 'groupId' when calling GetUniverseGroupsGroupId");
            
    
            var path = "/universe/groups/{group_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "group_id" + "}", ApiClient.ParameterToString(groupId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseGroupsGroupId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseGroupsGroupId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetUniverseGroupsGroupIdOk) ApiClient.Deserialize(response.Content, typeof(GetUniverseGroupsGroupIdOk), response.Headers);
        }
    
        /// <summary>
        /// Get moon information Get information on a moon  - -- Alternate route: &#x60;/dev/universe/moons/{moon_id}/&#x60;  Alternate route: &#x60;/legacy/universe/moons/{moon_id}/&#x60;  Alternate route: &#x60;/v1/universe/moons/{moon_id}/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="moonId">moon_id integer</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>GetUniverseMoonsMoonIdOk</returns>            
        public GetUniverseMoonsMoonIdOk GetUniverseMoonsMoonId (int? moonId, string datasource, string ifNoneMatch)
        {
            
            // verify the required parameter 'moonId' is set
            if (moonId == null) throw new ApiException(400, "Missing required parameter 'moonId' when calling GetUniverseMoonsMoonId");
            
    
            var path = "/universe/moons/{moon_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "moon_id" + "}", ApiClient.ParameterToString(moonId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseMoonsMoonId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseMoonsMoonId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetUniverseMoonsMoonIdOk) ApiClient.Deserialize(response.Content, typeof(GetUniverseMoonsMoonIdOk), response.Headers);
        }
    
        /// <summary>
        /// Get planet information Get information on a planet  - -- Alternate route: &#x60;/dev/universe/planets/{planet_id}/&#x60;  Alternate route: &#x60;/legacy/universe/planets/{planet_id}/&#x60;  Alternate route: &#x60;/v1/universe/planets/{planet_id}/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="planetId">planet_id integer</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>GetUniversePlanetsPlanetIdOk</returns>            
        public GetUniversePlanetsPlanetIdOk GetUniversePlanetsPlanetId (int? planetId, string datasource, string ifNoneMatch)
        {
            
            // verify the required parameter 'planetId' is set
            if (planetId == null) throw new ApiException(400, "Missing required parameter 'planetId' when calling GetUniversePlanetsPlanetId");
            
    
            var path = "/universe/planets/{planet_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "planet_id" + "}", ApiClient.ParameterToString(planetId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniversePlanetsPlanetId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniversePlanetsPlanetId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetUniversePlanetsPlanetIdOk) ApiClient.Deserialize(response.Content, typeof(GetUniversePlanetsPlanetIdOk), response.Headers);
        }
    
        /// <summary>
        /// Get character races Get a list of character races  - -- Alternate route: &#x60;/dev/universe/races/&#x60;  Alternate route: &#x60;/legacy/universe/races/&#x60;  Alternate route: &#x60;/v1/universe/races/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="acceptLanguage">Language to use in the response</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="language">Language to use in the response, takes precedence over Accept-Language</param> 
        /// <returns>List&lt;GetUniverseRaces200Ok&gt;</returns>            
        public List<GetUniverseRaces200Ok> GetUniverseRaces (string acceptLanguage, string datasource, string ifNoneMatch, string language)
        {
            
    
            var path = "/universe/races/";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseRaces: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseRaces: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetUniverseRaces200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetUniverseRaces200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get regions Get a list of regions  - -- Alternate route: &#x60;/dev/universe/regions/&#x60;  Alternate route: &#x60;/legacy/universe/regions/&#x60;  Alternate route: &#x60;/v1/universe/regions/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>List&lt;int?&gt;</returns>            
        public List<int?> GetUniverseRegions (string datasource, string ifNoneMatch)
        {
            
    
            var path = "/universe/regions/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseRegions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseRegions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<int?>) ApiClient.Deserialize(response.Content, typeof(List<int?>), response.Headers);
        }
    
        /// <summary>
        /// Get region information Get information on a region  - -- Alternate route: &#x60;/dev/universe/regions/{region_id}/&#x60;  Alternate route: &#x60;/legacy/universe/regions/{region_id}/&#x60;  Alternate route: &#x60;/v1/universe/regions/{region_id}/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="regionId">region_id integer</param> 
        /// <param name="acceptLanguage">Language to use in the response</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="language">Language to use in the response, takes precedence over Accept-Language</param> 
        /// <returns>GetUniverseRegionsRegionIdOk</returns>            
        public GetUniverseRegionsRegionIdOk GetUniverseRegionsRegionId (int? regionId, string acceptLanguage, string datasource, string ifNoneMatch, string language)
        {
            
            // verify the required parameter 'regionId' is set
            if (regionId == null) throw new ApiException(400, "Missing required parameter 'regionId' when calling GetUniverseRegionsRegionId");
            
    
            var path = "/universe/regions/{region_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "region_id" + "}", ApiClient.ParameterToString(regionId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseRegionsRegionId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseRegionsRegionId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetUniverseRegionsRegionIdOk) ApiClient.Deserialize(response.Content, typeof(GetUniverseRegionsRegionIdOk), response.Headers);
        }
    
        /// <summary>
        /// Get stargate information Get information on a stargate  - -- Alternate route: &#x60;/dev/universe/stargates/{stargate_id}/&#x60;  Alternate route: &#x60;/legacy/universe/stargates/{stargate_id}/&#x60;  Alternate route: &#x60;/v1/universe/stargates/{stargate_id}/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="stargateId">stargate_id integer</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>GetUniverseStargatesStargateIdOk</returns>            
        public GetUniverseStargatesStargateIdOk GetUniverseStargatesStargateId (int? stargateId, string datasource, string ifNoneMatch)
        {
            
            // verify the required parameter 'stargateId' is set
            if (stargateId == null) throw new ApiException(400, "Missing required parameter 'stargateId' when calling GetUniverseStargatesStargateId");
            
    
            var path = "/universe/stargates/{stargate_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "stargate_id" + "}", ApiClient.ParameterToString(stargateId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseStargatesStargateId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseStargatesStargateId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetUniverseStargatesStargateIdOk) ApiClient.Deserialize(response.Content, typeof(GetUniverseStargatesStargateIdOk), response.Headers);
        }
    
        /// <summary>
        /// Get star information Get information on a star  - -- Alternate route: &#x60;/dev/universe/stars/{star_id}/&#x60;  Alternate route: &#x60;/legacy/universe/stars/{star_id}/&#x60;  Alternate route: &#x60;/v1/universe/stars/{star_id}/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="starId">star_id integer</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>GetUniverseStarsStarIdOk</returns>            
        public GetUniverseStarsStarIdOk GetUniverseStarsStarId (int? starId, string datasource, string ifNoneMatch)
        {
            
            // verify the required parameter 'starId' is set
            if (starId == null) throw new ApiException(400, "Missing required parameter 'starId' when calling GetUniverseStarsStarId");
            
    
            var path = "/universe/stars/{star_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "star_id" + "}", ApiClient.ParameterToString(starId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseStarsStarId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseStarsStarId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetUniverseStarsStarIdOk) ApiClient.Deserialize(response.Content, typeof(GetUniverseStarsStarIdOk), response.Headers);
        }
    
        /// <summary>
        /// Get station information Get information on a station  - -- Alternate route: &#x60;/dev/universe/stations/{station_id}/&#x60;  Alternate route: &#x60;/v2/universe/stations/{station_id}/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="stationId">station_id integer</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>GetUniverseStationsStationIdOk</returns>            
        public GetUniverseStationsStationIdOk GetUniverseStationsStationId (int? stationId, string datasource, string ifNoneMatch)
        {
            
            // verify the required parameter 'stationId' is set
            if (stationId == null) throw new ApiException(400, "Missing required parameter 'stationId' when calling GetUniverseStationsStationId");
            
    
            var path = "/universe/stations/{station_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "station_id" + "}", ApiClient.ParameterToString(stationId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseStationsStationId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseStationsStationId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetUniverseStationsStationIdOk) ApiClient.Deserialize(response.Content, typeof(GetUniverseStationsStationIdOk), response.Headers);
        }
    
        /// <summary>
        /// List all public structures List all public structures  - -- Alternate route: &#x60;/dev/universe/structures/&#x60;  Alternate route: &#x60;/legacy/universe/structures/&#x60;  Alternate route: &#x60;/v1/universe/structures/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="filter">Only list public structures that have this service online</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>List&lt;long?&gt;</returns>            
        public List<long?> GetUniverseStructures (string datasource, string filter, string ifNoneMatch)
        {
            
    
            var path = "/universe/structures/";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
             if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseStructures: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseStructures: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<long?>) ApiClient.Deserialize(response.Content, typeof(List<long?>), response.Headers);
        }
    
        /// <summary>
        /// Get structure information Returns information on requested structure if you are on the ACL. Otherwise, returns \&quot;Forbidden\&quot; for all inputs.  - -- Alternate route: &#x60;/dev/universe/structures/{structure_id}/&#x60;  Alternate route: &#x60;/v2/universe/structures/{structure_id}/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="structureId">An Eve structure ID</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="token">Access token to use if unable to set a header</param> 
        /// <returns>GetUniverseStructuresStructureIdOk</returns>            
        public GetUniverseStructuresStructureIdOk GetUniverseStructuresStructureId (long? structureId, string datasource, string ifNoneMatch, string token)
        {
            
            // verify the required parameter 'structureId' is set
            if (structureId == null) throw new ApiException(400, "Missing required parameter 'structureId' when calling GetUniverseStructuresStructureId");
            
    
            var path = "/universe/structures/{structure_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "structure_id" + "}", ApiClient.ParameterToString(structureId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseStructuresStructureId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseStructuresStructureId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetUniverseStructuresStructureIdOk) ApiClient.Deserialize(response.Content, typeof(GetUniverseStructuresStructureIdOk), response.Headers);
        }
    
        /// <summary>
        /// Get system jumps Get the number of jumps in solar systems within the last hour ending at the timestamp of the Last-Modified header, excluding wormhole space. Only systems with jumps will be listed  - -- Alternate route: &#x60;/dev/universe/system_jumps/&#x60;  Alternate route: &#x60;/legacy/universe/system_jumps/&#x60;  Alternate route: &#x60;/v1/universe/system_jumps/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>List&lt;GetUniverseSystemJumps200Ok&gt;</returns>            
        public List<GetUniverseSystemJumps200Ok> GetUniverseSystemJumps (string datasource, string ifNoneMatch)
        {
            
    
            var path = "/universe/system_jumps/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseSystemJumps: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseSystemJumps: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetUniverseSystemJumps200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetUniverseSystemJumps200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get system kills Get the number of ship, pod and NPC kills per solar system within the last hour ending at the timestamp of the Last-Modified header, excluding wormhole space. Only systems with kills will be listed  - -- Alternate route: &#x60;/dev/universe/system_kills/&#x60;  Alternate route: &#x60;/v2/universe/system_kills/&#x60;  - -- This route is cached for up to 3600 seconds
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>List&lt;GetUniverseSystemKills200Ok&gt;</returns>            
        public List<GetUniverseSystemKills200Ok> GetUniverseSystemKills (string datasource, string ifNoneMatch)
        {
            
    
            var path = "/universe/system_kills/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseSystemKills: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseSystemKills: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GetUniverseSystemKills200Ok>) ApiClient.Deserialize(response.Content, typeof(List<GetUniverseSystemKills200Ok>), response.Headers);
        }
    
        /// <summary>
        /// Get solar systems Get a list of solar systems  - -- Alternate route: &#x60;/dev/universe/systems/&#x60;  Alternate route: &#x60;/legacy/universe/systems/&#x60;  Alternate route: &#x60;/v1/universe/systems/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <returns>List&lt;int?&gt;</returns>            
        public List<int?> GetUniverseSystems (string datasource, string ifNoneMatch)
        {
            
    
            var path = "/universe/systems/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseSystems: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseSystems: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<int?>) ApiClient.Deserialize(response.Content, typeof(List<int?>), response.Headers);
        }
    
        /// <summary>
        /// Get solar system information Get information on a solar system.  - -- Alternate route: &#x60;/dev/universe/systems/{system_id}/&#x60;  Alternate route: &#x60;/v4/universe/systems/{system_id}/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="systemId">system_id integer</param> 
        /// <param name="acceptLanguage">Language to use in the response</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="language">Language to use in the response, takes precedence over Accept-Language</param> 
        /// <returns>GetUniverseSystemsSystemIdOk</returns>            
        public GetUniverseSystemsSystemIdOk GetUniverseSystemsSystemId (int? systemId, string acceptLanguage, string datasource, string ifNoneMatch, string language)
        {
            
            // verify the required parameter 'systemId' is set
            if (systemId == null) throw new ApiException(400, "Missing required parameter 'systemId' when calling GetUniverseSystemsSystemId");
            
    
            var path = "/universe/systems/{system_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "system_id" + "}", ApiClient.ParameterToString(systemId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseSystemsSystemId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseSystemsSystemId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetUniverseSystemsSystemIdOk) ApiClient.Deserialize(response.Content, typeof(GetUniverseSystemsSystemIdOk), response.Headers);
        }
    
        /// <summary>
        /// Get types Get a list of type ids  - -- Alternate route: &#x60;/dev/universe/types/&#x60;  Alternate route: &#x60;/legacy/universe/types/&#x60;  Alternate route: &#x60;/v1/universe/types/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="page">Which page of results to return</param> 
        /// <returns>List&lt;int?&gt;</returns>            
        public List<int?> GetUniverseTypes (string datasource, string ifNoneMatch, int? page)
        {
            
    
            var path = "/universe/types/";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseTypes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<int?>) ApiClient.Deserialize(response.Content, typeof(List<int?>), response.Headers);
        }
    
        /// <summary>
        /// Get type information Get information on a type  - -- Alternate route: &#x60;/dev/universe/types/{type_id}/&#x60;  Alternate route: &#x60;/v3/universe/types/{type_id}/&#x60;  - -- This route expires daily at 11:05
        /// </summary>
        /// <param name="typeId">An Eve item type ID</param> 
        /// <param name="acceptLanguage">Language to use in the response</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="ifNoneMatch">ETag from a previous request. A 304 will be returned if this matches the current ETag</param> 
        /// <param name="language">Language to use in the response, takes precedence over Accept-Language</param> 
        /// <returns>GetUniverseTypesTypeIdOk</returns>            
        public GetUniverseTypesTypeIdOk GetUniverseTypesTypeId (int? typeId, string acceptLanguage, string datasource, string ifNoneMatch, string language)
        {
            
            // verify the required parameter 'typeId' is set
            if (typeId == null) throw new ApiException(400, "Missing required parameter 'typeId' when calling GetUniverseTypesTypeId");
            
    
            var path = "/universe/types/{type_id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "type_id" + "}", ApiClient.ParameterToString(typeId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseTypesTypeId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUniverseTypesTypeId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetUniverseTypesTypeIdOk) ApiClient.Deserialize(response.Content, typeof(GetUniverseTypesTypeIdOk), response.Headers);
        }
    
        /// <summary>
        /// Bulk names to IDs Resolve a set of names to IDs in the following categories: agents, alliances, characters, constellations, corporations factions, inventory_types, regions, stations, and systems. Only exact matches will be returned. All names searched for are cached for 12 hours  - -- Alternate route: &#x60;/dev/universe/ids/&#x60;  Alternate route: &#x60;/legacy/universe/ids/&#x60;  Alternate route: &#x60;/v1/universe/ids/&#x60; 
        /// </summary>
        /// <param name="names">The names to resolve</param> 
        /// <param name="acceptLanguage">Language to use in the response</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <param name="language">Language to use in the response, takes precedence over Accept-Language</param> 
        /// <returns>PostUniverseIdsOk</returns>            
        public PostUniverseIdsOk PostUniverseIds (List<string> names, string acceptLanguage, string datasource, string language)
        {
            
            // verify the required parameter 'names' is set
            if (names == null) throw new ApiException(400, "Missing required parameter 'names' when calling PostUniverseIds");
            
    
            var path = "/universe/ids/";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
 if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
             if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                        postBody = ApiClient.Serialize(names); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostUniverseIds: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostUniverseIds: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PostUniverseIdsOk) ApiClient.Deserialize(response.Content, typeof(PostUniverseIdsOk), response.Headers);
        }
    
        /// <summary>
        /// Get names and categories for a set of IDs Resolve a set of IDs to names and categories. Supported ID&#39;s for resolving are: Characters, Corporations, Alliances, Stations, Solar Systems, Constellations, Regions, Types, Factions  - -- Alternate route: &#x60;/dev/universe/names/&#x60;  Alternate route: &#x60;/v3/universe/names/&#x60; 
        /// </summary>
        /// <param name="ids">The ids to resolve</param> 
        /// <param name="datasource">The server name you would like data from</param> 
        /// <returns>List&lt;PostUniverseNames200Ok&gt;</returns>            
        public List<PostUniverseNames200Ok> PostUniverseNames (List<int?> ids, string datasource)
        {
            
            // verify the required parameter 'ids' is set
            if (ids == null) throw new ApiException(400, "Missing required parameter 'ids' when calling PostUniverseNames");
            
    
            var path = "/universe/names/";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (datasource != null) queryParams.Add("datasource", ApiClient.ParameterToString(datasource)); // query parameter
                                    postBody = ApiClient.Serialize(ids); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostUniverseNames: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostUniverseNames: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<PostUniverseNames200Ok>) ApiClient.Deserialize(response.Content, typeof(List<PostUniverseNames200Ok>), response.Headers);
        }
    
    }
}
