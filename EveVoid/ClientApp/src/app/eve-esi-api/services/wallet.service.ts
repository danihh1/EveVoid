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
class WalletService extends __BaseService {
  static readonly getCharactersCharacterIdWalletPath = '/characters/{character_id}/wallet/';
  static readonly getCharactersCharacterIdWalletJournalPath = '/characters/{character_id}/wallet/journal/';
  static readonly getCharactersCharacterIdWalletTransactionsPath = '/characters/{character_id}/wallet/transactions/';
  static readonly getCorporationsCorporationIdWalletsPath = '/corporations/{corporation_id}/wallets/';
  static readonly getCorporationsCorporationIdWalletsDivisionJournalPath = '/corporations/{corporation_id}/wallets/{division}/journal/';
  static readonly getCorporationsCorporationIdWalletsDivisionTransactionsPath = '/corporations/{corporation_id}/wallets/{division}/transactions/';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * Get a character's wallet balance
   *
   * Returns a character's wallet balance
   *
   * ---
   * Alternate route: `/legacy/characters/{character_id}/wallet/`
   *
   * Alternate route: `/v1/characters/{character_id}/wallet/`
   *
   * ---
   * This route is cached for up to 120 seconds
   *
   * ---
   * [Diff of the upcoming changes](https://esi.evetech.net/diff/latest/dev/#GET-/characters/{character_id}/wallet/)
   * @param params The `WalletService.GetCharactersCharacterIdWalletParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Wallet balance
   */
  getCharactersCharacterIdWalletResponse(params: WalletService.GetCharactersCharacterIdWalletParams): __Observable<__StrictHttpResponse<number>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/wallet/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'text'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return (_r as HttpResponse<any>).clone({ body: parseFloat((_r as HttpResponse<any>).body as string) }) as __StrictHttpResponse<number>
      })
    );
  }
  /**
   * Get a character's wallet balance
   *
   * Returns a character's wallet balance
   *
   * ---
   * Alternate route: `/legacy/characters/{character_id}/wallet/`
   *
   * Alternate route: `/v1/characters/{character_id}/wallet/`
   *
   * ---
   * This route is cached for up to 120 seconds
   *
   * ---
   * [Diff of the upcoming changes](https://esi.evetech.net/diff/latest/dev/#GET-/characters/{character_id}/wallet/)
   * @param params The `WalletService.GetCharactersCharacterIdWalletParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Wallet balance
   */
  getCharactersCharacterIdWallet(params: WalletService.GetCharactersCharacterIdWalletParams): __Observable<number> {
    return this.getCharactersCharacterIdWalletResponse(params).pipe(
      __map(_r => _r.body as number)
    );
  }

  /**
   * Get character wallet journal
   *
   * Retrieve the given character's wallet journal going 30 days back
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/wallet/journal/`
   *
   * Alternate route: `/v6/characters/{character_id}/wallet/journal/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `WalletService.GetCharactersCharacterIdWalletJournalParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Journal entries
   */
  getCharactersCharacterIdWalletJournalResponse(params: WalletService.GetCharactersCharacterIdWalletJournalParams): __Observable<__StrictHttpResponse<Array<{amount?: number, balance?: number, context_id?: number, context_id_type?: 'structure_id' | 'station_id' | 'market_transaction_id' | 'character_id' | 'corporation_id' | 'alliance_id' | 'eve_system' | 'industry_job_id' | 'contract_id' | 'planet_id' | 'system_id' | 'type_id', date: string, description: string, first_party_id?: number, id: number, reason?: string, ref_type: 'acceleration_gate_fee' | 'advertisement_listing_fee' | 'agent_donation' | 'agent_location_services' | 'agent_miscellaneous' | 'agent_mission_collateral_paid' | 'agent_mission_collateral_refunded' | 'agent_mission_reward' | 'agent_mission_reward_corporation_tax' | 'agent_mission_time_bonus_reward' | 'agent_mission_time_bonus_reward_corporation_tax' | 'agent_security_services' | 'agent_services_rendered' | 'agents_preward' | 'alliance_maintainance_fee' | 'alliance_registration_fee' | 'asset_safety_recovery_tax' | 'bounty' | 'bounty_prize' | 'bounty_prize_corporation_tax' | 'bounty_prizes' | 'bounty_reimbursement' | 'bounty_surcharge' | 'brokers_fee' | 'clone_activation' | 'clone_transfer' | 'contraband_fine' | 'contract_auction_bid' | 'contract_auction_bid_corp' | 'contract_auction_bid_refund' | 'contract_auction_sold' | 'contract_brokers_fee' | 'contract_brokers_fee_corp' | 'contract_collateral' | 'contract_collateral_deposited_corp' | 'contract_collateral_payout' | 'contract_collateral_refund' | 'contract_deposit' | 'contract_deposit_corp' | 'contract_deposit_refund' | 'contract_deposit_sales_tax' | 'contract_price' | 'contract_price_payment_corp' | 'contract_reversal' | 'contract_reward' | 'contract_reward_deposited' | 'contract_reward_deposited_corp' | 'contract_reward_refund' | 'contract_sales_tax' | 'copying' | 'corporate_reward_payout' | 'corporate_reward_tax' | 'corporation_account_withdrawal' | 'corporation_bulk_payment' | 'corporation_dividend_payment' | 'corporation_liquidation' | 'corporation_logo_change_cost' | 'corporation_payment' | 'corporation_registration_fee' | 'courier_mission_escrow' | 'cspa' | 'cspaofflinerefund' | 'datacore_fee' | 'dna_modification_fee' | 'docking_fee' | 'duel_wager_escrow' | 'duel_wager_payment' | 'duel_wager_refund' | 'factory_slot_rental_fee' | 'gm_cash_transfer' | 'industry_job_tax' | 'infrastructure_hub_maintenance' | 'inheritance' | 'insurance' | 'item_trader_payment' | 'jump_clone_activation_fee' | 'jump_clone_installation_fee' | 'kill_right_fee' | 'lp_store' | 'manufacturing' | 'market_escrow' | 'market_fine_paid' | 'market_transaction' | 'medal_creation' | 'medal_issued' | 'mission_completion' | 'mission_cost' | 'mission_expiration' | 'mission_reward' | 'office_rental_fee' | 'operation_bonus' | 'opportunity_reward' | 'planetary_construction' | 'planetary_export_tax' | 'planetary_import_tax' | 'player_donation' | 'player_trading' | 'project_discovery_reward' | 'project_discovery_tax' | 'reaction' | 'release_of_impounded_property' | 'repair_bill' | 'reprocessing_tax' | 'researching_material_productivity' | 'researching_technology' | 'researching_time_productivity' | 'resource_wars_reward' | 'reverse_engineering' | 'security_processing_fee' | 'shares' | 'skill_purchase' | 'sovereignity_bill' | 'store_purchase' | 'store_purchase_refund' | 'structure_gate_jump' | 'transaction_tax' | 'upkeep_adjustment_fee' | 'war_ally_contract' | 'war_fee' | 'war_fee_surrender', second_party_id?: number, tax?: number, tax_receiver_id?: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/wallet/journal/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{amount?: number, balance?: number, context_id?: number, context_id_type?: 'structure_id' | 'station_id' | 'market_transaction_id' | 'character_id' | 'corporation_id' | 'alliance_id' | 'eve_system' | 'industry_job_id' | 'contract_id' | 'planet_id' | 'system_id' | 'type_id', date: string, description: string, first_party_id?: number, id: number, reason?: string, ref_type: 'acceleration_gate_fee' | 'advertisement_listing_fee' | 'agent_donation' | 'agent_location_services' | 'agent_miscellaneous' | 'agent_mission_collateral_paid' | 'agent_mission_collateral_refunded' | 'agent_mission_reward' | 'agent_mission_reward_corporation_tax' | 'agent_mission_time_bonus_reward' | 'agent_mission_time_bonus_reward_corporation_tax' | 'agent_security_services' | 'agent_services_rendered' | 'agents_preward' | 'alliance_maintainance_fee' | 'alliance_registration_fee' | 'asset_safety_recovery_tax' | 'bounty' | 'bounty_prize' | 'bounty_prize_corporation_tax' | 'bounty_prizes' | 'bounty_reimbursement' | 'bounty_surcharge' | 'brokers_fee' | 'clone_activation' | 'clone_transfer' | 'contraband_fine' | 'contract_auction_bid' | 'contract_auction_bid_corp' | 'contract_auction_bid_refund' | 'contract_auction_sold' | 'contract_brokers_fee' | 'contract_brokers_fee_corp' | 'contract_collateral' | 'contract_collateral_deposited_corp' | 'contract_collateral_payout' | 'contract_collateral_refund' | 'contract_deposit' | 'contract_deposit_corp' | 'contract_deposit_refund' | 'contract_deposit_sales_tax' | 'contract_price' | 'contract_price_payment_corp' | 'contract_reversal' | 'contract_reward' | 'contract_reward_deposited' | 'contract_reward_deposited_corp' | 'contract_reward_refund' | 'contract_sales_tax' | 'copying' | 'corporate_reward_payout' | 'corporate_reward_tax' | 'corporation_account_withdrawal' | 'corporation_bulk_payment' | 'corporation_dividend_payment' | 'corporation_liquidation' | 'corporation_logo_change_cost' | 'corporation_payment' | 'corporation_registration_fee' | 'courier_mission_escrow' | 'cspa' | 'cspaofflinerefund' | 'datacore_fee' | 'dna_modification_fee' | 'docking_fee' | 'duel_wager_escrow' | 'duel_wager_payment' | 'duel_wager_refund' | 'factory_slot_rental_fee' | 'gm_cash_transfer' | 'industry_job_tax' | 'infrastructure_hub_maintenance' | 'inheritance' | 'insurance' | 'item_trader_payment' | 'jump_clone_activation_fee' | 'jump_clone_installation_fee' | 'kill_right_fee' | 'lp_store' | 'manufacturing' | 'market_escrow' | 'market_fine_paid' | 'market_transaction' | 'medal_creation' | 'medal_issued' | 'mission_completion' | 'mission_cost' | 'mission_expiration' | 'mission_reward' | 'office_rental_fee' | 'operation_bonus' | 'opportunity_reward' | 'planetary_construction' | 'planetary_export_tax' | 'planetary_import_tax' | 'player_donation' | 'player_trading' | 'project_discovery_reward' | 'project_discovery_tax' | 'reaction' | 'release_of_impounded_property' | 'repair_bill' | 'reprocessing_tax' | 'researching_material_productivity' | 'researching_technology' | 'researching_time_productivity' | 'resource_wars_reward' | 'reverse_engineering' | 'security_processing_fee' | 'shares' | 'skill_purchase' | 'sovereignity_bill' | 'store_purchase' | 'store_purchase_refund' | 'structure_gate_jump' | 'transaction_tax' | 'upkeep_adjustment_fee' | 'war_ally_contract' | 'war_fee' | 'war_fee_surrender', second_party_id?: number, tax?: number, tax_receiver_id?: number}>>;
      })
    );
  }
  /**
   * Get character wallet journal
   *
   * Retrieve the given character's wallet journal going 30 days back
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/wallet/journal/`
   *
   * Alternate route: `/v6/characters/{character_id}/wallet/journal/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `WalletService.GetCharactersCharacterIdWalletJournalParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Journal entries
   */
  getCharactersCharacterIdWalletJournal(params: WalletService.GetCharactersCharacterIdWalletJournalParams): __Observable<Array<{amount?: number, balance?: number, context_id?: number, context_id_type?: 'structure_id' | 'station_id' | 'market_transaction_id' | 'character_id' | 'corporation_id' | 'alliance_id' | 'eve_system' | 'industry_job_id' | 'contract_id' | 'planet_id' | 'system_id' | 'type_id', date: string, description: string, first_party_id?: number, id: number, reason?: string, ref_type: 'acceleration_gate_fee' | 'advertisement_listing_fee' | 'agent_donation' | 'agent_location_services' | 'agent_miscellaneous' | 'agent_mission_collateral_paid' | 'agent_mission_collateral_refunded' | 'agent_mission_reward' | 'agent_mission_reward_corporation_tax' | 'agent_mission_time_bonus_reward' | 'agent_mission_time_bonus_reward_corporation_tax' | 'agent_security_services' | 'agent_services_rendered' | 'agents_preward' | 'alliance_maintainance_fee' | 'alliance_registration_fee' | 'asset_safety_recovery_tax' | 'bounty' | 'bounty_prize' | 'bounty_prize_corporation_tax' | 'bounty_prizes' | 'bounty_reimbursement' | 'bounty_surcharge' | 'brokers_fee' | 'clone_activation' | 'clone_transfer' | 'contraband_fine' | 'contract_auction_bid' | 'contract_auction_bid_corp' | 'contract_auction_bid_refund' | 'contract_auction_sold' | 'contract_brokers_fee' | 'contract_brokers_fee_corp' | 'contract_collateral' | 'contract_collateral_deposited_corp' | 'contract_collateral_payout' | 'contract_collateral_refund' | 'contract_deposit' | 'contract_deposit_corp' | 'contract_deposit_refund' | 'contract_deposit_sales_tax' | 'contract_price' | 'contract_price_payment_corp' | 'contract_reversal' | 'contract_reward' | 'contract_reward_deposited' | 'contract_reward_deposited_corp' | 'contract_reward_refund' | 'contract_sales_tax' | 'copying' | 'corporate_reward_payout' | 'corporate_reward_tax' | 'corporation_account_withdrawal' | 'corporation_bulk_payment' | 'corporation_dividend_payment' | 'corporation_liquidation' | 'corporation_logo_change_cost' | 'corporation_payment' | 'corporation_registration_fee' | 'courier_mission_escrow' | 'cspa' | 'cspaofflinerefund' | 'datacore_fee' | 'dna_modification_fee' | 'docking_fee' | 'duel_wager_escrow' | 'duel_wager_payment' | 'duel_wager_refund' | 'factory_slot_rental_fee' | 'gm_cash_transfer' | 'industry_job_tax' | 'infrastructure_hub_maintenance' | 'inheritance' | 'insurance' | 'item_trader_payment' | 'jump_clone_activation_fee' | 'jump_clone_installation_fee' | 'kill_right_fee' | 'lp_store' | 'manufacturing' | 'market_escrow' | 'market_fine_paid' | 'market_transaction' | 'medal_creation' | 'medal_issued' | 'mission_completion' | 'mission_cost' | 'mission_expiration' | 'mission_reward' | 'office_rental_fee' | 'operation_bonus' | 'opportunity_reward' | 'planetary_construction' | 'planetary_export_tax' | 'planetary_import_tax' | 'player_donation' | 'player_trading' | 'project_discovery_reward' | 'project_discovery_tax' | 'reaction' | 'release_of_impounded_property' | 'repair_bill' | 'reprocessing_tax' | 'researching_material_productivity' | 'researching_technology' | 'researching_time_productivity' | 'resource_wars_reward' | 'reverse_engineering' | 'security_processing_fee' | 'shares' | 'skill_purchase' | 'sovereignity_bill' | 'store_purchase' | 'store_purchase_refund' | 'structure_gate_jump' | 'transaction_tax' | 'upkeep_adjustment_fee' | 'war_ally_contract' | 'war_fee' | 'war_fee_surrender', second_party_id?: number, tax?: number, tax_receiver_id?: number}>> {
    return this.getCharactersCharacterIdWalletJournalResponse(params).pipe(
      __map(_r => _r.body as Array<{amount?: number, balance?: number, context_id?: number, context_id_type?: 'structure_id' | 'station_id' | 'market_transaction_id' | 'character_id' | 'corporation_id' | 'alliance_id' | 'eve_system' | 'industry_job_id' | 'contract_id' | 'planet_id' | 'system_id' | 'type_id', date: string, description: string, first_party_id?: number, id: number, reason?: string, ref_type: 'acceleration_gate_fee' | 'advertisement_listing_fee' | 'agent_donation' | 'agent_location_services' | 'agent_miscellaneous' | 'agent_mission_collateral_paid' | 'agent_mission_collateral_refunded' | 'agent_mission_reward' | 'agent_mission_reward_corporation_tax' | 'agent_mission_time_bonus_reward' | 'agent_mission_time_bonus_reward_corporation_tax' | 'agent_security_services' | 'agent_services_rendered' | 'agents_preward' | 'alliance_maintainance_fee' | 'alliance_registration_fee' | 'asset_safety_recovery_tax' | 'bounty' | 'bounty_prize' | 'bounty_prize_corporation_tax' | 'bounty_prizes' | 'bounty_reimbursement' | 'bounty_surcharge' | 'brokers_fee' | 'clone_activation' | 'clone_transfer' | 'contraband_fine' | 'contract_auction_bid' | 'contract_auction_bid_corp' | 'contract_auction_bid_refund' | 'contract_auction_sold' | 'contract_brokers_fee' | 'contract_brokers_fee_corp' | 'contract_collateral' | 'contract_collateral_deposited_corp' | 'contract_collateral_payout' | 'contract_collateral_refund' | 'contract_deposit' | 'contract_deposit_corp' | 'contract_deposit_refund' | 'contract_deposit_sales_tax' | 'contract_price' | 'contract_price_payment_corp' | 'contract_reversal' | 'contract_reward' | 'contract_reward_deposited' | 'contract_reward_deposited_corp' | 'contract_reward_refund' | 'contract_sales_tax' | 'copying' | 'corporate_reward_payout' | 'corporate_reward_tax' | 'corporation_account_withdrawal' | 'corporation_bulk_payment' | 'corporation_dividend_payment' | 'corporation_liquidation' | 'corporation_logo_change_cost' | 'corporation_payment' | 'corporation_registration_fee' | 'courier_mission_escrow' | 'cspa' | 'cspaofflinerefund' | 'datacore_fee' | 'dna_modification_fee' | 'docking_fee' | 'duel_wager_escrow' | 'duel_wager_payment' | 'duel_wager_refund' | 'factory_slot_rental_fee' | 'gm_cash_transfer' | 'industry_job_tax' | 'infrastructure_hub_maintenance' | 'inheritance' | 'insurance' | 'item_trader_payment' | 'jump_clone_activation_fee' | 'jump_clone_installation_fee' | 'kill_right_fee' | 'lp_store' | 'manufacturing' | 'market_escrow' | 'market_fine_paid' | 'market_transaction' | 'medal_creation' | 'medal_issued' | 'mission_completion' | 'mission_cost' | 'mission_expiration' | 'mission_reward' | 'office_rental_fee' | 'operation_bonus' | 'opportunity_reward' | 'planetary_construction' | 'planetary_export_tax' | 'planetary_import_tax' | 'player_donation' | 'player_trading' | 'project_discovery_reward' | 'project_discovery_tax' | 'reaction' | 'release_of_impounded_property' | 'repair_bill' | 'reprocessing_tax' | 'researching_material_productivity' | 'researching_technology' | 'researching_time_productivity' | 'resource_wars_reward' | 'reverse_engineering' | 'security_processing_fee' | 'shares' | 'skill_purchase' | 'sovereignity_bill' | 'store_purchase' | 'store_purchase_refund' | 'structure_gate_jump' | 'transaction_tax' | 'upkeep_adjustment_fee' | 'war_ally_contract' | 'war_fee' | 'war_fee_surrender', second_party_id?: number, tax?: number, tax_receiver_id?: number}>)
    );
  }

  /**
   * Get wallet transactions
   *
   * Get wallet transactions of a character
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/wallet/transactions/`
   *
   * Alternate route: `/legacy/characters/{character_id}/wallet/transactions/`
   *
   * Alternate route: `/v1/characters/{character_id}/wallet/transactions/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `WalletService.GetCharactersCharacterIdWalletTransactionsParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `from_id`: Only show transactions happened before the one referenced by this id
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Wallet transactions
   */
  getCharactersCharacterIdWalletTransactionsResponse(params: WalletService.GetCharactersCharacterIdWalletTransactionsParams): __Observable<__StrictHttpResponse<Array<{client_id: number, date: string, is_buy: boolean, is_personal: boolean, journal_ref_id: number, location_id: number, quantity: number, transaction_id: number, type_id: number, unit_price: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.fromId != null) __params = __params.set('from_id', params.fromId.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/wallet/transactions/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{client_id: number, date: string, is_buy: boolean, is_personal: boolean, journal_ref_id: number, location_id: number, quantity: number, transaction_id: number, type_id: number, unit_price: number}>>;
      })
    );
  }
  /**
   * Get wallet transactions
   *
   * Get wallet transactions of a character
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/wallet/transactions/`
   *
   * Alternate route: `/legacy/characters/{character_id}/wallet/transactions/`
   *
   * Alternate route: `/v1/characters/{character_id}/wallet/transactions/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `WalletService.GetCharactersCharacterIdWalletTransactionsParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `from_id`: Only show transactions happened before the one referenced by this id
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Wallet transactions
   */
  getCharactersCharacterIdWalletTransactions(params: WalletService.GetCharactersCharacterIdWalletTransactionsParams): __Observable<Array<{client_id: number, date: string, is_buy: boolean, is_personal: boolean, journal_ref_id: number, location_id: number, quantity: number, transaction_id: number, type_id: number, unit_price: number}>> {
    return this.getCharactersCharacterIdWalletTransactionsResponse(params).pipe(
      __map(_r => _r.body as Array<{client_id: number, date: string, is_buy: boolean, is_personal: boolean, journal_ref_id: number, location_id: number, quantity: number, transaction_id: number, type_id: number, unit_price: number}>)
    );
  }

  /**
   * Returns a corporation's wallet balance
   *
   * Get a corporation's wallets
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/wallets/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/wallets/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/wallets/`
   *
   * ---
   * This route is cached for up to 300 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Accountant, Junior_Accountant
   * @param params The `WalletService.GetCorporationsCorporationIdWalletsParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return List of corporation wallets
   */
  getCorporationsCorporationIdWalletsResponse(params: WalletService.GetCorporationsCorporationIdWalletsParams): __Observable<__StrictHttpResponse<Array<{balance: number, division: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/corporations/${encodeURIComponent(params.corporationId)}/wallets/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{balance: number, division: number}>>;
      })
    );
  }
  /**
   * Returns a corporation's wallet balance
   *
   * Get a corporation's wallets
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/wallets/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/wallets/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/wallets/`
   *
   * ---
   * This route is cached for up to 300 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Accountant, Junior_Accountant
   * @param params The `WalletService.GetCorporationsCorporationIdWalletsParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return List of corporation wallets
   */
  getCorporationsCorporationIdWallets(params: WalletService.GetCorporationsCorporationIdWalletsParams): __Observable<Array<{balance: number, division: number}>> {
    return this.getCorporationsCorporationIdWalletsResponse(params).pipe(
      __map(_r => _r.body as Array<{balance: number, division: number}>)
    );
  }

  /**
   * Get corporation wallet journal
   *
   * Retrieve the given corporation's wallet journal for the given division going 30 days back
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/wallets/{division}/journal/`
   *
   * Alternate route: `/v4/corporations/{corporation_id}/wallets/{division}/journal/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Accountant, Junior_Accountant
   * @param params The `WalletService.GetCorporationsCorporationIdWalletsDivisionJournalParams` containing the following parameters:
   *
   * - `division`: Wallet key of the division to fetch journals from
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Journal entries
   */
  getCorporationsCorporationIdWalletsDivisionJournalResponse(params: WalletService.GetCorporationsCorporationIdWalletsDivisionJournalParams): __Observable<__StrictHttpResponse<Array<{amount?: number, balance?: number, context_id?: number, context_id_type?: 'structure_id' | 'station_id' | 'market_transaction_id' | 'character_id' | 'corporation_id' | 'alliance_id' | 'eve_system' | 'industry_job_id' | 'contract_id' | 'planet_id' | 'system_id' | 'type_id', date: string, description: string, first_party_id?: number, id: number, reason?: string, ref_type: 'acceleration_gate_fee' | 'advertisement_listing_fee' | 'agent_donation' | 'agent_location_services' | 'agent_miscellaneous' | 'agent_mission_collateral_paid' | 'agent_mission_collateral_refunded' | 'agent_mission_reward' | 'agent_mission_reward_corporation_tax' | 'agent_mission_time_bonus_reward' | 'agent_mission_time_bonus_reward_corporation_tax' | 'agent_security_services' | 'agent_services_rendered' | 'agents_preward' | 'alliance_maintainance_fee' | 'alliance_registration_fee' | 'asset_safety_recovery_tax' | 'bounty' | 'bounty_prize' | 'bounty_prize_corporation_tax' | 'bounty_prizes' | 'bounty_reimbursement' | 'bounty_surcharge' | 'brokers_fee' | 'clone_activation' | 'clone_transfer' | 'contraband_fine' | 'contract_auction_bid' | 'contract_auction_bid_corp' | 'contract_auction_bid_refund' | 'contract_auction_sold' | 'contract_brokers_fee' | 'contract_brokers_fee_corp' | 'contract_collateral' | 'contract_collateral_deposited_corp' | 'contract_collateral_payout' | 'contract_collateral_refund' | 'contract_deposit' | 'contract_deposit_corp' | 'contract_deposit_refund' | 'contract_deposit_sales_tax' | 'contract_price' | 'contract_price_payment_corp' | 'contract_reversal' | 'contract_reward' | 'contract_reward_deposited' | 'contract_reward_deposited_corp' | 'contract_reward_refund' | 'contract_sales_tax' | 'copying' | 'corporate_reward_payout' | 'corporate_reward_tax' | 'corporation_account_withdrawal' | 'corporation_bulk_payment' | 'corporation_dividend_payment' | 'corporation_liquidation' | 'corporation_logo_change_cost' | 'corporation_payment' | 'corporation_registration_fee' | 'courier_mission_escrow' | 'cspa' | 'cspaofflinerefund' | 'datacore_fee' | 'dna_modification_fee' | 'docking_fee' | 'duel_wager_escrow' | 'duel_wager_payment' | 'duel_wager_refund' | 'factory_slot_rental_fee' | 'gm_cash_transfer' | 'industry_job_tax' | 'infrastructure_hub_maintenance' | 'inheritance' | 'insurance' | 'jump_clone_activation_fee' | 'jump_clone_installation_fee' | 'kill_right_fee' | 'lp_store' | 'manufacturing' | 'market_escrow' | 'market_fine_paid' | 'market_transaction' | 'medal_creation' | 'medal_issued' | 'mission_completion' | 'mission_cost' | 'mission_expiration' | 'mission_reward' | 'office_rental_fee' | 'operation_bonus' | 'opportunity_reward' | 'planetary_construction' | 'planetary_export_tax' | 'planetary_import_tax' | 'player_donation' | 'player_trading' | 'project_discovery_reward' | 'project_discovery_tax' | 'reaction' | 'release_of_impounded_property' | 'repair_bill' | 'reprocessing_tax' | 'researching_material_productivity' | 'researching_technology' | 'researching_time_productivity' | 'resource_wars_reward' | 'reverse_engineering' | 'security_processing_fee' | 'shares' | 'sovereignity_bill' | 'store_purchase' | 'store_purchase_refund' | 'structure_gate_jump' | 'transaction_tax' | 'upkeep_adjustment_fee' | 'war_ally_contract' | 'war_fee' | 'war_fee_surrender', second_party_id?: number, tax?: number, tax_receiver_id?: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;


    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/corporations/${encodeURIComponent(params.corporationId)}/wallets/${encodeURIComponent(params.division)}/journal/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{amount?: number, balance?: number, context_id?: number, context_id_type?: 'structure_id' | 'station_id' | 'market_transaction_id' | 'character_id' | 'corporation_id' | 'alliance_id' | 'eve_system' | 'industry_job_id' | 'contract_id' | 'planet_id' | 'system_id' | 'type_id', date: string, description: string, first_party_id?: number, id: number, reason?: string, ref_type: 'acceleration_gate_fee' | 'advertisement_listing_fee' | 'agent_donation' | 'agent_location_services' | 'agent_miscellaneous' | 'agent_mission_collateral_paid' | 'agent_mission_collateral_refunded' | 'agent_mission_reward' | 'agent_mission_reward_corporation_tax' | 'agent_mission_time_bonus_reward' | 'agent_mission_time_bonus_reward_corporation_tax' | 'agent_security_services' | 'agent_services_rendered' | 'agents_preward' | 'alliance_maintainance_fee' | 'alliance_registration_fee' | 'asset_safety_recovery_tax' | 'bounty' | 'bounty_prize' | 'bounty_prize_corporation_tax' | 'bounty_prizes' | 'bounty_reimbursement' | 'bounty_surcharge' | 'brokers_fee' | 'clone_activation' | 'clone_transfer' | 'contraband_fine' | 'contract_auction_bid' | 'contract_auction_bid_corp' | 'contract_auction_bid_refund' | 'contract_auction_sold' | 'contract_brokers_fee' | 'contract_brokers_fee_corp' | 'contract_collateral' | 'contract_collateral_deposited_corp' | 'contract_collateral_payout' | 'contract_collateral_refund' | 'contract_deposit' | 'contract_deposit_corp' | 'contract_deposit_refund' | 'contract_deposit_sales_tax' | 'contract_price' | 'contract_price_payment_corp' | 'contract_reversal' | 'contract_reward' | 'contract_reward_deposited' | 'contract_reward_deposited_corp' | 'contract_reward_refund' | 'contract_sales_tax' | 'copying' | 'corporate_reward_payout' | 'corporate_reward_tax' | 'corporation_account_withdrawal' | 'corporation_bulk_payment' | 'corporation_dividend_payment' | 'corporation_liquidation' | 'corporation_logo_change_cost' | 'corporation_payment' | 'corporation_registration_fee' | 'courier_mission_escrow' | 'cspa' | 'cspaofflinerefund' | 'datacore_fee' | 'dna_modification_fee' | 'docking_fee' | 'duel_wager_escrow' | 'duel_wager_payment' | 'duel_wager_refund' | 'factory_slot_rental_fee' | 'gm_cash_transfer' | 'industry_job_tax' | 'infrastructure_hub_maintenance' | 'inheritance' | 'insurance' | 'jump_clone_activation_fee' | 'jump_clone_installation_fee' | 'kill_right_fee' | 'lp_store' | 'manufacturing' | 'market_escrow' | 'market_fine_paid' | 'market_transaction' | 'medal_creation' | 'medal_issued' | 'mission_completion' | 'mission_cost' | 'mission_expiration' | 'mission_reward' | 'office_rental_fee' | 'operation_bonus' | 'opportunity_reward' | 'planetary_construction' | 'planetary_export_tax' | 'planetary_import_tax' | 'player_donation' | 'player_trading' | 'project_discovery_reward' | 'project_discovery_tax' | 'reaction' | 'release_of_impounded_property' | 'repair_bill' | 'reprocessing_tax' | 'researching_material_productivity' | 'researching_technology' | 'researching_time_productivity' | 'resource_wars_reward' | 'reverse_engineering' | 'security_processing_fee' | 'shares' | 'sovereignity_bill' | 'store_purchase' | 'store_purchase_refund' | 'structure_gate_jump' | 'transaction_tax' | 'upkeep_adjustment_fee' | 'war_ally_contract' | 'war_fee' | 'war_fee_surrender', second_party_id?: number, tax?: number, tax_receiver_id?: number}>>;
      })
    );
  }
  /**
   * Get corporation wallet journal
   *
   * Retrieve the given corporation's wallet journal for the given division going 30 days back
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/wallets/{division}/journal/`
   *
   * Alternate route: `/v4/corporations/{corporation_id}/wallets/{division}/journal/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Accountant, Junior_Accountant
   * @param params The `WalletService.GetCorporationsCorporationIdWalletsDivisionJournalParams` containing the following parameters:
   *
   * - `division`: Wallet key of the division to fetch journals from
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Journal entries
   */
  getCorporationsCorporationIdWalletsDivisionJournal(params: WalletService.GetCorporationsCorporationIdWalletsDivisionJournalParams): __Observable<Array<{amount?: number, balance?: number, context_id?: number, context_id_type?: 'structure_id' | 'station_id' | 'market_transaction_id' | 'character_id' | 'corporation_id' | 'alliance_id' | 'eve_system' | 'industry_job_id' | 'contract_id' | 'planet_id' | 'system_id' | 'type_id', date: string, description: string, first_party_id?: number, id: number, reason?: string, ref_type: 'acceleration_gate_fee' | 'advertisement_listing_fee' | 'agent_donation' | 'agent_location_services' | 'agent_miscellaneous' | 'agent_mission_collateral_paid' | 'agent_mission_collateral_refunded' | 'agent_mission_reward' | 'agent_mission_reward_corporation_tax' | 'agent_mission_time_bonus_reward' | 'agent_mission_time_bonus_reward_corporation_tax' | 'agent_security_services' | 'agent_services_rendered' | 'agents_preward' | 'alliance_maintainance_fee' | 'alliance_registration_fee' | 'asset_safety_recovery_tax' | 'bounty' | 'bounty_prize' | 'bounty_prize_corporation_tax' | 'bounty_prizes' | 'bounty_reimbursement' | 'bounty_surcharge' | 'brokers_fee' | 'clone_activation' | 'clone_transfer' | 'contraband_fine' | 'contract_auction_bid' | 'contract_auction_bid_corp' | 'contract_auction_bid_refund' | 'contract_auction_sold' | 'contract_brokers_fee' | 'contract_brokers_fee_corp' | 'contract_collateral' | 'contract_collateral_deposited_corp' | 'contract_collateral_payout' | 'contract_collateral_refund' | 'contract_deposit' | 'contract_deposit_corp' | 'contract_deposit_refund' | 'contract_deposit_sales_tax' | 'contract_price' | 'contract_price_payment_corp' | 'contract_reversal' | 'contract_reward' | 'contract_reward_deposited' | 'contract_reward_deposited_corp' | 'contract_reward_refund' | 'contract_sales_tax' | 'copying' | 'corporate_reward_payout' | 'corporate_reward_tax' | 'corporation_account_withdrawal' | 'corporation_bulk_payment' | 'corporation_dividend_payment' | 'corporation_liquidation' | 'corporation_logo_change_cost' | 'corporation_payment' | 'corporation_registration_fee' | 'courier_mission_escrow' | 'cspa' | 'cspaofflinerefund' | 'datacore_fee' | 'dna_modification_fee' | 'docking_fee' | 'duel_wager_escrow' | 'duel_wager_payment' | 'duel_wager_refund' | 'factory_slot_rental_fee' | 'gm_cash_transfer' | 'industry_job_tax' | 'infrastructure_hub_maintenance' | 'inheritance' | 'insurance' | 'jump_clone_activation_fee' | 'jump_clone_installation_fee' | 'kill_right_fee' | 'lp_store' | 'manufacturing' | 'market_escrow' | 'market_fine_paid' | 'market_transaction' | 'medal_creation' | 'medal_issued' | 'mission_completion' | 'mission_cost' | 'mission_expiration' | 'mission_reward' | 'office_rental_fee' | 'operation_bonus' | 'opportunity_reward' | 'planetary_construction' | 'planetary_export_tax' | 'planetary_import_tax' | 'player_donation' | 'player_trading' | 'project_discovery_reward' | 'project_discovery_tax' | 'reaction' | 'release_of_impounded_property' | 'repair_bill' | 'reprocessing_tax' | 'researching_material_productivity' | 'researching_technology' | 'researching_time_productivity' | 'resource_wars_reward' | 'reverse_engineering' | 'security_processing_fee' | 'shares' | 'sovereignity_bill' | 'store_purchase' | 'store_purchase_refund' | 'structure_gate_jump' | 'transaction_tax' | 'upkeep_adjustment_fee' | 'war_ally_contract' | 'war_fee' | 'war_fee_surrender', second_party_id?: number, tax?: number, tax_receiver_id?: number}>> {
    return this.getCorporationsCorporationIdWalletsDivisionJournalResponse(params).pipe(
      __map(_r => _r.body as Array<{amount?: number, balance?: number, context_id?: number, context_id_type?: 'structure_id' | 'station_id' | 'market_transaction_id' | 'character_id' | 'corporation_id' | 'alliance_id' | 'eve_system' | 'industry_job_id' | 'contract_id' | 'planet_id' | 'system_id' | 'type_id', date: string, description: string, first_party_id?: number, id: number, reason?: string, ref_type: 'acceleration_gate_fee' | 'advertisement_listing_fee' | 'agent_donation' | 'agent_location_services' | 'agent_miscellaneous' | 'agent_mission_collateral_paid' | 'agent_mission_collateral_refunded' | 'agent_mission_reward' | 'agent_mission_reward_corporation_tax' | 'agent_mission_time_bonus_reward' | 'agent_mission_time_bonus_reward_corporation_tax' | 'agent_security_services' | 'agent_services_rendered' | 'agents_preward' | 'alliance_maintainance_fee' | 'alliance_registration_fee' | 'asset_safety_recovery_tax' | 'bounty' | 'bounty_prize' | 'bounty_prize_corporation_tax' | 'bounty_prizes' | 'bounty_reimbursement' | 'bounty_surcharge' | 'brokers_fee' | 'clone_activation' | 'clone_transfer' | 'contraband_fine' | 'contract_auction_bid' | 'contract_auction_bid_corp' | 'contract_auction_bid_refund' | 'contract_auction_sold' | 'contract_brokers_fee' | 'contract_brokers_fee_corp' | 'contract_collateral' | 'contract_collateral_deposited_corp' | 'contract_collateral_payout' | 'contract_collateral_refund' | 'contract_deposit' | 'contract_deposit_corp' | 'contract_deposit_refund' | 'contract_deposit_sales_tax' | 'contract_price' | 'contract_price_payment_corp' | 'contract_reversal' | 'contract_reward' | 'contract_reward_deposited' | 'contract_reward_deposited_corp' | 'contract_reward_refund' | 'contract_sales_tax' | 'copying' | 'corporate_reward_payout' | 'corporate_reward_tax' | 'corporation_account_withdrawal' | 'corporation_bulk_payment' | 'corporation_dividend_payment' | 'corporation_liquidation' | 'corporation_logo_change_cost' | 'corporation_payment' | 'corporation_registration_fee' | 'courier_mission_escrow' | 'cspa' | 'cspaofflinerefund' | 'datacore_fee' | 'dna_modification_fee' | 'docking_fee' | 'duel_wager_escrow' | 'duel_wager_payment' | 'duel_wager_refund' | 'factory_slot_rental_fee' | 'gm_cash_transfer' | 'industry_job_tax' | 'infrastructure_hub_maintenance' | 'inheritance' | 'insurance' | 'jump_clone_activation_fee' | 'jump_clone_installation_fee' | 'kill_right_fee' | 'lp_store' | 'manufacturing' | 'market_escrow' | 'market_fine_paid' | 'market_transaction' | 'medal_creation' | 'medal_issued' | 'mission_completion' | 'mission_cost' | 'mission_expiration' | 'mission_reward' | 'office_rental_fee' | 'operation_bonus' | 'opportunity_reward' | 'planetary_construction' | 'planetary_export_tax' | 'planetary_import_tax' | 'player_donation' | 'player_trading' | 'project_discovery_reward' | 'project_discovery_tax' | 'reaction' | 'release_of_impounded_property' | 'repair_bill' | 'reprocessing_tax' | 'researching_material_productivity' | 'researching_technology' | 'researching_time_productivity' | 'resource_wars_reward' | 'reverse_engineering' | 'security_processing_fee' | 'shares' | 'sovereignity_bill' | 'store_purchase' | 'store_purchase_refund' | 'structure_gate_jump' | 'transaction_tax' | 'upkeep_adjustment_fee' | 'war_ally_contract' | 'war_fee' | 'war_fee_surrender', second_party_id?: number, tax?: number, tax_receiver_id?: number}>)
    );
  }

  /**
   * Get corporation wallet transactions
   *
   * Get wallet transactions of a corporation
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/wallets/{division}/transactions/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/wallets/{division}/transactions/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/wallets/{division}/transactions/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Accountant, Junior_Accountant
   * @param params The `WalletService.GetCorporationsCorporationIdWalletsDivisionTransactionsParams` containing the following parameters:
   *
   * - `division`: Wallet key of the division to fetch journals from
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `from_id`: Only show journal entries happened before the transaction referenced by this id
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Wallet transactions
   */
  getCorporationsCorporationIdWalletsDivisionTransactionsResponse(params: WalletService.GetCorporationsCorporationIdWalletsDivisionTransactionsParams): __Observable<__StrictHttpResponse<Array<{client_id: number, date: string, is_buy: boolean, journal_ref_id: number, location_id: number, quantity: number, transaction_id: number, type_id: number, unit_price: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;


    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.fromId != null) __params = __params.set('from_id', params.fromId.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/corporations/${encodeURIComponent(params.corporationId)}/wallets/${encodeURIComponent(params.division)}/transactions/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{client_id: number, date: string, is_buy: boolean, journal_ref_id: number, location_id: number, quantity: number, transaction_id: number, type_id: number, unit_price: number}>>;
      })
    );
  }
  /**
   * Get corporation wallet transactions
   *
   * Get wallet transactions of a corporation
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/wallets/{division}/transactions/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/wallets/{division}/transactions/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/wallets/{division}/transactions/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Accountant, Junior_Accountant
   * @param params The `WalletService.GetCorporationsCorporationIdWalletsDivisionTransactionsParams` containing the following parameters:
   *
   * - `division`: Wallet key of the division to fetch journals from
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `from_id`: Only show journal entries happened before the transaction referenced by this id
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Wallet transactions
   */
  getCorporationsCorporationIdWalletsDivisionTransactions(params: WalletService.GetCorporationsCorporationIdWalletsDivisionTransactionsParams): __Observable<Array<{client_id: number, date: string, is_buy: boolean, journal_ref_id: number, location_id: number, quantity: number, transaction_id: number, type_id: number, unit_price: number}>> {
    return this.getCorporationsCorporationIdWalletsDivisionTransactionsResponse(params).pipe(
      __map(_r => _r.body as Array<{client_id: number, date: string, is_buy: boolean, journal_ref_id: number, location_id: number, quantity: number, transaction_id: number, type_id: number, unit_price: number}>)
    );
  }
}

module WalletService {

  /**
   * Parameters for getCharactersCharacterIdWallet
   */
  export interface GetCharactersCharacterIdWalletParams {

    /**
     * An EVE character ID
     */
    characterId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';

    /**
     * ETag from a previous request. A 304 will be returned if this matches the current ETag
     */
    IfNoneMatch?: string;
  }

  /**
   * Parameters for getCharactersCharacterIdWalletJournal
   */
  export interface GetCharactersCharacterIdWalletJournalParams {

    /**
     * An EVE character ID
     */
    characterId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * Which page of results to return
     */
    page?: number;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';

    /**
     * ETag from a previous request. A 304 will be returned if this matches the current ETag
     */
    IfNoneMatch?: string;
  }

  /**
   * Parameters for getCharactersCharacterIdWalletTransactions
   */
  export interface GetCharactersCharacterIdWalletTransactionsParams {

    /**
     * An EVE character ID
     */
    characterId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * Only show transactions happened before the one referenced by this id
     */
    fromId?: number;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';

    /**
     * ETag from a previous request. A 304 will be returned if this matches the current ETag
     */
    IfNoneMatch?: string;
  }

  /**
   * Parameters for getCorporationsCorporationIdWallets
   */
  export interface GetCorporationsCorporationIdWalletsParams {

    /**
     * An EVE corporation ID
     */
    corporationId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';

    /**
     * ETag from a previous request. A 304 will be returned if this matches the current ETag
     */
    IfNoneMatch?: string;
  }

  /**
   * Parameters for getCorporationsCorporationIdWalletsDivisionJournal
   */
  export interface GetCorporationsCorporationIdWalletsDivisionJournalParams {

    /**
     * Wallet key of the division to fetch journals from
     */
    division: number;

    /**
     * An EVE corporation ID
     */
    corporationId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * Which page of results to return
     */
    page?: number;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';

    /**
     * ETag from a previous request. A 304 will be returned if this matches the current ETag
     */
    IfNoneMatch?: string;
  }

  /**
   * Parameters for getCorporationsCorporationIdWalletsDivisionTransactions
   */
  export interface GetCorporationsCorporationIdWalletsDivisionTransactionsParams {

    /**
     * Wallet key of the division to fetch journals from
     */
    division: number;

    /**
     * An EVE corporation ID
     */
    corporationId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * Only show journal entries happened before the transaction referenced by this id
     */
    fromId?: number;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';

    /**
     * ETag from a previous request. A 304 will be returned if this matches the current ETag
     */
    IfNoneMatch?: string;
  }
}

export { WalletService }
