/*
SnapTrade

Connect brokerage accounts to your app for live positions and trading

The version of the OpenAPI document: 1.0.0
Contact: api@snaptrade.com

NOTE: This file is auto generated by Konfig (https://konfigthis.com).
*/


/**
 * 
 * @export
 * @interface StrategyQuotesGreek
 */
export interface StrategyQuotesGreek {
    [key: string]: any;

    /**
     * 
     * @type {number}
     * @memberof StrategyQuotesGreek
     */
    'delta'?: number;
    /**
     * 
     * @type {number}
     * @memberof StrategyQuotesGreek
     */
    'gamma'?: number;
    /**
     * 
     * @type {number}
     * @memberof StrategyQuotesGreek
     */
    'theta'?: number;
    /**
     * 
     * @type {number}
     * @memberof StrategyQuotesGreek
     */
    'vega'?: number;
    /**
     * 
     * @type {number}
     * @memberof StrategyQuotesGreek
     */
    'rho'?: number;
}

