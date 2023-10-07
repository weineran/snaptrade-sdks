/*
SnapTrade

Connect brokerage accounts to your app for live positions and trading

The version of the OpenAPI document: 1.0.0
Contact: api@snaptrade.com

NOTE: This file is auto generated by Konfig (https://konfigthis.com).
*/

import { StrategyImpactLegsInner } from './strategy-impact-legs-inner';

/**
 * The strategy impact
 * @export
 * @interface StrategyImpact
 */
export interface StrategyImpact {
    [key: string]: any;

    /**
     * 
     * @type {number}
     * @memberof StrategyImpact
     */
    'estimatedCommissions'?: number;
    /**
     * 
     * @type {number}
     * @memberof StrategyImpact
     */
    'buyingPowerEffect'?: number;
    /**
     * 
     * @type {number}
     * @memberof StrategyImpact
     */
    'buyingPowerResult'?: number;
    /**
     * 
     * @type {number}
     * @memberof StrategyImpact
     */
    'maintExcessEffect'?: number;
    /**
     * 
     * @type {number}
     * @memberof StrategyImpact
     */
    'maintExcessResult'?: number;
    /**
     * 
     * @type {string}
     * @memberof StrategyImpact
     */
    'tradeValueCalculation'?: string;
    /**
     * 
     * @type {Array<StrategyImpactLegsInner>}
     * @memberof StrategyImpact
     */
    'legs'?: Array<StrategyImpactLegsInner>;
    /**
     * 
     * @type {string}
     * @memberof StrategyImpact
     */
    'side'?: string;
    /**
     * 
     * @type {string}
     * @memberof StrategyImpact
     */
    'effect'?: string;
    /**
     * 
     * @type {number}
     * @memberof StrategyImpact
     */
    'price'?: number;
    /**
     * 
     * @type {string}
     * @memberof StrategyImpact
     */
    'strategy'?: string;
}

