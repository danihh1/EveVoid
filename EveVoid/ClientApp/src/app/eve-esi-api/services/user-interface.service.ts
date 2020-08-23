/* tslint:disable */
import { Injectable } from '@angular/core';
import { HttpClient, HttpRequest, HttpResponse, HttpHeaders } from '@angular/common/http';
import { BaseService as __BaseService } from '../base-service';
import { ApiConfiguration as __Configuration } from '../api-configuration';
import { StrictHttpResponse as __StrictHttpResponse } from '../strict-http-response';
import { Observable as __Observable } from 'rxjs';
import { map as __map, filter as __filter } from 'rxjs/operators';

@Injectable({
  providedIn: 'root',
})
class UserInterfaceService extends __BaseService {
  static readonly postUiAutopilotWaypointPath = '/ui/autopilot/waypoint/';
  static readonly postUiOpenwindowContractPath = '/ui/openwindow/contract/';
  static readonly postUiOpenwindowInformationPath = '/ui/openwindow/information/';
  static readonly postUiOpenwindowMarketdetailsPath = '/ui/openwindow/marketdetails/';
  static readonly postUiOpenwindowNewmailPath = '/ui/openwindow/newmail/';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * Set Autopilot Waypoint
   *
   * Set a solar system as autopilot waypoint
   *
   * ---
   * Alternate route: `/dev/ui/autopilot/waypoint/`
   *
   * Alternate route: `/legacy/ui/autopilot/waypoint/`
   *
   * Alternate route: `/v2/ui/autopilot/waypoint/`
   * @param params The `UserInterfaceService.PostUiAutopilotWaypointParams` containing the following parameters:
   *
   * - `destination_id`: The destination to travel to, can be solar system, station or structure's id
   *
   * - `clear_other_waypoints`: Whether clean other waypoints beforing adding this one
   *
   * - `add_to_beginning`: Whether this solar system should be added to the beginning of all waypoints
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   */
  postUiAutopilotWaypointResponse(params: UserInterfaceService.PostUiAutopilotWaypointParams): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.destinationId != null) __params = __params.set('destination_id', params.destinationId.toString());
    if (params.clearOtherWaypoints != null) __params = __params.set('clear_other_waypoints', params.clearOtherWaypoints.toString());
    if (params.addToBeginning != null) __params = __params.set('add_to_beginning', params.addToBeginning.toString());
    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/ui/autopilot/waypoint/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<null>;
      })
    );
  }
  /**
   * Set Autopilot Waypoint
   *
   * Set a solar system as autopilot waypoint
   *
   * ---
   * Alternate route: `/dev/ui/autopilot/waypoint/`
   *
   * Alternate route: `/legacy/ui/autopilot/waypoint/`
   *
   * Alternate route: `/v2/ui/autopilot/waypoint/`
   * @param params The `UserInterfaceService.PostUiAutopilotWaypointParams` containing the following parameters:
   *
   * - `destination_id`: The destination to travel to, can be solar system, station or structure's id
   *
   * - `clear_other_waypoints`: Whether clean other waypoints beforing adding this one
   *
   * - `add_to_beginning`: Whether this solar system should be added to the beginning of all waypoints
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   */
  postUiAutopilotWaypoint(params: UserInterfaceService.PostUiAutopilotWaypointParams): __Observable<null> {
    return this.postUiAutopilotWaypointResponse(params).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * Open Contract Window
   *
   * Open the contract window inside the client
   *
   * ---
   * Alternate route: `/dev/ui/openwindow/contract/`
   *
   * Alternate route: `/legacy/ui/openwindow/contract/`
   *
   * Alternate route: `/v1/ui/openwindow/contract/`
   * @param params The `UserInterfaceService.PostUiOpenwindowContractParams` containing the following parameters:
   *
   * - `contract_id`: The contract to open
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   */
  postUiOpenwindowContractResponse(params: UserInterfaceService.PostUiOpenwindowContractParams): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.contractId != null) __params = __params.set('contract_id', params.contractId.toString());
    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/ui/openwindow/contract/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<null>;
      })
    );
  }
  /**
   * Open Contract Window
   *
   * Open the contract window inside the client
   *
   * ---
   * Alternate route: `/dev/ui/openwindow/contract/`
   *
   * Alternate route: `/legacy/ui/openwindow/contract/`
   *
   * Alternate route: `/v1/ui/openwindow/contract/`
   * @param params The `UserInterfaceService.PostUiOpenwindowContractParams` containing the following parameters:
   *
   * - `contract_id`: The contract to open
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   */
  postUiOpenwindowContract(params: UserInterfaceService.PostUiOpenwindowContractParams): __Observable<null> {
    return this.postUiOpenwindowContractResponse(params).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * Open Information Window
   *
   * Open the information window for a character, corporation or alliance inside the client
   *
   * ---
   * Alternate route: `/dev/ui/openwindow/information/`
   *
   * Alternate route: `/legacy/ui/openwindow/information/`
   *
   * Alternate route: `/v1/ui/openwindow/information/`
   * @param params The `UserInterfaceService.PostUiOpenwindowInformationParams` containing the following parameters:
   *
   * - `target_id`: The target to open
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   */
  postUiOpenwindowInformationResponse(params: UserInterfaceService.PostUiOpenwindowInformationParams): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.targetId != null) __params = __params.set('target_id', params.targetId.toString());
    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/ui/openwindow/information/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<null>;
      })
    );
  }
  /**
   * Open Information Window
   *
   * Open the information window for a character, corporation or alliance inside the client
   *
   * ---
   * Alternate route: `/dev/ui/openwindow/information/`
   *
   * Alternate route: `/legacy/ui/openwindow/information/`
   *
   * Alternate route: `/v1/ui/openwindow/information/`
   * @param params The `UserInterfaceService.PostUiOpenwindowInformationParams` containing the following parameters:
   *
   * - `target_id`: The target to open
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   */
  postUiOpenwindowInformation(params: UserInterfaceService.PostUiOpenwindowInformationParams): __Observable<null> {
    return this.postUiOpenwindowInformationResponse(params).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * Open Market Details
   *
   * Open the market details window for a specific typeID inside the client
   *
   * ---
   * Alternate route: `/dev/ui/openwindow/marketdetails/`
   *
   * Alternate route: `/legacy/ui/openwindow/marketdetails/`
   *
   * Alternate route: `/v1/ui/openwindow/marketdetails/`
   * @param params The `UserInterfaceService.PostUiOpenwindowMarketdetailsParams` containing the following parameters:
   *
   * - `type_id`: The item type to open in market window
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   */
  postUiOpenwindowMarketdetailsResponse(params: UserInterfaceService.PostUiOpenwindowMarketdetailsParams): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.typeId != null) __params = __params.set('type_id', params.typeId.toString());
    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/ui/openwindow/marketdetails/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<null>;
      })
    );
  }
  /**
   * Open Market Details
   *
   * Open the market details window for a specific typeID inside the client
   *
   * ---
   * Alternate route: `/dev/ui/openwindow/marketdetails/`
   *
   * Alternate route: `/legacy/ui/openwindow/marketdetails/`
   *
   * Alternate route: `/v1/ui/openwindow/marketdetails/`
   * @param params The `UserInterfaceService.PostUiOpenwindowMarketdetailsParams` containing the following parameters:
   *
   * - `type_id`: The item type to open in market window
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   */
  postUiOpenwindowMarketdetails(params: UserInterfaceService.PostUiOpenwindowMarketdetailsParams): __Observable<null> {
    return this.postUiOpenwindowMarketdetailsResponse(params).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * Open New Mail Window
   *
   * Open the New Mail window, according to settings from the request if applicable
   *
   * ---
   * Alternate route: `/dev/ui/openwindow/newmail/`
   *
   * Alternate route: `/legacy/ui/openwindow/newmail/`
   *
   * Alternate route: `/v1/ui/openwindow/newmail/`
   * @param params The `UserInterfaceService.PostUiOpenwindowNewmailParams` containing the following parameters:
   *
   * - `new_mail`: The details of mail to create
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   */
  postUiOpenwindowNewmailResponse(params: UserInterfaceService.PostUiOpenwindowNewmailParams): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    __body = params.newMail;
    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/ui/openwindow/newmail/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<null>;
      })
    );
  }
  /**
   * Open New Mail Window
   *
   * Open the New Mail window, according to settings from the request if applicable
   *
   * ---
   * Alternate route: `/dev/ui/openwindow/newmail/`
   *
   * Alternate route: `/legacy/ui/openwindow/newmail/`
   *
   * Alternate route: `/v1/ui/openwindow/newmail/`
   * @param params The `UserInterfaceService.PostUiOpenwindowNewmailParams` containing the following parameters:
   *
   * - `new_mail`: The details of mail to create
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   */
  postUiOpenwindowNewmail(params: UserInterfaceService.PostUiOpenwindowNewmailParams): __Observable<null> {
    return this.postUiOpenwindowNewmailResponse(params).pipe(
      __map(_r => _r.body as null)
    );
  }
}

module UserInterfaceService {

  /**
   * Parameters for postUiAutopilotWaypoint
   */
  export interface PostUiAutopilotWaypointParams {

    /**
     * The destination to travel to, can be solar system, station or structure's id
     */
    destinationId: number;

    /**
     * Whether clean other waypoints beforing adding this one
     */
    clearOtherWaypoints: boolean;

    /**
     * Whether this solar system should be added to the beginning of all waypoints
     */
    addToBeginning: boolean;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';
  }

  /**
   * Parameters for postUiOpenwindowContract
   */
  export interface PostUiOpenwindowContractParams {

    /**
     * The contract to open
     */
    contractId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';
  }

  /**
   * Parameters for postUiOpenwindowInformation
   */
  export interface PostUiOpenwindowInformationParams {

    /**
     * The target to open
     */
    targetId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';
  }

  /**
   * Parameters for postUiOpenwindowMarketdetails
   */
  export interface PostUiOpenwindowMarketdetailsParams {

    /**
     * The item type to open in market window
     */
    typeId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';
  }

  /**
   * Parameters for postUiOpenwindowNewmail
   */
  export interface PostUiOpenwindowNewmailParams {

    /**
     * The details of mail to create
     */
    newMail: {body: string, recipients: Array<number>, subject: string, to_corp_or_alliance_id?: number, to_mailing_list_id?: number};

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';
  }
}

export { UserInterfaceService }
