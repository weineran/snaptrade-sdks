/*
SnapTrade

Connect brokerage accounts to your app for live positions and trading

The version of the OpenAPI document: 1.0.0
Contact: api@snaptrade.com

NOTE: This file is auto generated by Konfig (https://konfigthis.com).
*/

import { AccountSimple } from './account-simple';
import { Currency } from './currency';
import { OptionsSymbol } from './options-symbol';
import { Symbol } from './symbol';

/**
 * A transaction or activity from an institution
 * @export
 * @interface UniversalActivity
 */
export interface UniversalActivity {
    [key: string]: any;

    /**
     * 
     * @type {string}
     * @memberof UniversalActivity
     */
    'id'?: string;
    /**
     * 
     * @type {AccountSimple}
     * @memberof UniversalActivity
     */
    'account'?: AccountSimple;
    /**
     * 
     * @type {number}
     * @memberof UniversalActivity
     */
    'amount'?: number | null;
    /**
     * 
     * @type {Currency}
     * @memberof UniversalActivity
     */
    'currency'?: Currency;
    /**
     * 
     * @type {string}
     * @memberof UniversalActivity
     */
    'description'?: string;
    /**
     * 
     * @type {number}
     * @memberof UniversalActivity
     */
    'fee'?: number;
    /**
     * The forex conversion rate involved in the transaction if provided by the brokerage. Used in cases where securities of one currency are purchased in a different currency, and the forex conversion is automatic. In those cases, price, amount and fee will be in the top level currency (activity -> currency)
     * @type {number}
     * @memberof UniversalActivity
     */
    'fx_rate'?: number | null;
    /**
     * 
     * @type {string}
     * @memberof UniversalActivity
     */
    'institution'?: string;
    /**
     * If an option transaction, then it\'s type (BUY_TO_OPEN, SELL_TO_CLOSE, etc), otherwise empty string
     * @type {string}
     * @memberof UniversalActivity
     */
    'option_type'?: string;
    /**
     * 
     * @type {number}
     * @memberof UniversalActivity
     */
    'price'?: number;
    /**
     * 
     * @type {string}
     * @memberof UniversalActivity
     */
    'settlement_date'?: string;
    /**
     * Reference ID from brokerage used to identify related transactions. For example if an order comprises of several transactions (buy, fee, fx), they can be grouped if they share the same external_reference_id
     * @type {string}
     * @memberof UniversalActivity
     */
    'external_reference_id'?: string | null;
    /**
     * 
     * @type {Symbol}
     * @memberof UniversalActivity
     */
    'symbol'?: Symbol;
    /**
     * 
     * @type {OptionsSymbol}
     * @memberof UniversalActivity
     */
    'option_symbol'?: OptionsSymbol;
    /**
     * 
     * @type {string}
     * @memberof UniversalActivity
     */
    'trade_date'?: string | null;
    /**
     * Potential values include (but are not limited to) - DIVIDEND - BUY - SELL - CONTRIBUTION - WITHDRAWAL - EXTERNAL_ASSET_TRANSFER_IN - EXTERNAL_ASSET_TRANSFER_OUT - INTERNAL_CASH_TRANSFER_IN - INTERNAL_CASH_TRANSFER_OUT - INTERNAL_ASSET_TRANSFER_IN - INTERNAL_ASSET_TRANSFER_OUT - INTEREST - REBATE - GOV_GRANT - TAX - FEE - REI - FXT
     * @type {string}
     * @memberof UniversalActivity
     */
    'type'?: string;
    /**
     * Usually but not necessarily an integer
     * @type {number}
     * @memberof UniversalActivity
     */
    'units'?: number;
}

