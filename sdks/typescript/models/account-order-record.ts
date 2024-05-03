/*
SnapTrade

Connect brokerage accounts to your app for live positions and trading

The version of the OpenAPI document: 1.0.0
Contact: api@snaptrade.com

NOTE: This file is auto generated by Konfig (https://konfigthis.com).
*/
import type * as buffer from "buffer"

import { AccountOrderRecordStatus } from './account-order-record-status';
import { Action } from './action';
import { OptionsSymbol } from './options-symbol';
import { OrderType } from './order-type';
import { UniversalSymbol } from './universal-symbol';

/**
 * Record of order in brokerageaccount
 * @export
 * @interface AccountOrderRecord
 */
export interface AccountOrderRecord {
    [key: string]: any;

    /**
     * Order id returned by brokerage
     * @type {string}
     * @memberof AccountOrderRecord
     */
    'brokerage_order_id'?: string;
    /**
     * 
     * @type {AccountOrderRecordStatus}
     * @memberof AccountOrderRecord
     */
    'status'?: AccountOrderRecordStatus;
    /**
     * 
     * @type {string}
     * @memberof AccountOrderRecord
     */
    'symbol'?: string;
    /**
     * 
     * @type {UniversalSymbol}
     * @memberof AccountOrderRecord
     */
    'universal_symbol'?: UniversalSymbol;
    /**
     * 
     * @type {OptionsSymbol}
     * @memberof AccountOrderRecord
     */
    'option_symbol'?: OptionsSymbol;
    /**
     * Trade Action
     * @type {Action}
     * @memberof AccountOrderRecord
     */
    'action'?: Action;
    /**
     * 
     * @type {number}
     * @memberof AccountOrderRecord
     */
    'total_quantity'?: number | null;
    /**
     * Trade Units
     * @type {number}
     * @memberof AccountOrderRecord
     */
    'open_quantity'?: number | null;
    /**
     * Trade Units
     * @type {number}
     * @memberof AccountOrderRecord
     */
    'canceled_quantity'?: number | null;
    /**
     * Trade Units
     * @type {number}
     * @memberof AccountOrderRecord
     */
    'filled_quantity'?: number | null;
    /**
     * Trade Price if limit or stop limit order
     * @type {number}
     * @memberof AccountOrderRecord
     */
    'execution_price'?: number | null;
    /**
     * Trade Price if limit or stop limit order
     * @type {number}
     * @memberof AccountOrderRecord
     */
    'limit_price'?: number | null;
    /**
     * Stop Price. If stop loss or stop limit order, the price to trigger the stop
     * @type {number}
     * @memberof AccountOrderRecord
     */
    'stop_price'?: number | null;
    /**
     * Order Type
     * @type {OrderType}
     * @memberof AccountOrderRecord
     */
    'order_type'?: OrderType;
    /**
     * Trade time in force examples:   * FOK - Fill Or Kill   * Day - Day   * GTC - Good Til Canceled   * GTD - Good Til Date 
     * @type {string}
     * @memberof AccountOrderRecord
     */
    'time_in_force'?: string;
    /**
     * Time
     * @type {string}
     * @memberof AccountOrderRecord
     */
    'time_placed'?: string;
    /**
     * 
     * @type {string}
     * @memberof AccountOrderRecord
     */
    'time_updated'?: string | null;
    /**
     * 
     * @type {string}
     * @memberof AccountOrderRecord
     */
    'time_executed'?: string | null;
    /**
     * Time
     * @type {string}
     * @memberof AccountOrderRecord
     */
    'expiry_date'?: string;
}

