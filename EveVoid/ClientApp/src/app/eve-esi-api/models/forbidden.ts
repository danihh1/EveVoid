/* tslint:disable */

/**
 * Forbidden model
 */
export interface Forbidden {

  /**
   * Forbidden message
   */
  error: string;

  /**
   * status code received from SSO
   */
  sso_status?: number;
}
