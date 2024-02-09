/* tslint:disable */
/* eslint-disable */
/*
SnapTrade

Connect brokerage accounts to your app for live positions and trading

The version of the OpenAPI document: 1.0.0
Contact: api@snaptrade.com

NOTE: This file is auto generated by Konfig (https://konfigthis.com).
*/

import globalAxios, { AxiosPromise, AxiosInstance, AxiosRequestConfig } from 'axios';
import { Configuration } from '../configuration';
// Some imports not used depending on template conditions
// @ts-ignore
import { DUMMY_BASE_URL, assertParamExists, setApiKeyToObject, setBasicAuthToObject, setBearerAuthToObject, setSearchParams, serializeDataIfNeeded, toPathString, createRequestFunction, isBrowser } from '../common';
// @ts-ignore
import { BASE_PATH, COLLECTION_FORMATS, RequestArgs, BaseAPI, RequiredError } from '../base';
// @ts-ignore
import { AccountOrderRecord } from '../models';
// @ts-ignore
import { Action } from '../models';
// @ts-ignore
import { ManualTradeAndImpact } from '../models';
// @ts-ignore
import { ManualTradeForm } from '../models';
// @ts-ignore
import { Model400FailedRequestResponse } from '../models';
// @ts-ignore
import { Model403FailedRequestResponse } from '../models';
// @ts-ignore
import { Model500UnexpectedExceptionResponse } from '../models';
// @ts-ignore
import { OrderType } from '../models';
// @ts-ignore
import { SymbolsQuotesInner } from '../models';
// @ts-ignore
import { TimeInForceStrict } from '../models';
// @ts-ignore
import { TradingCancelUserAccountOrderRequest } from '../models';
// @ts-ignore
import { TradingPlaceOCOOrderRequest } from '../models';
import { paginate } from "../pagination/paginate";
import type * as buffer from "buffer"
import { requestBeforeHook } from '../requestBeforeHook';
/**
 * TradingApi - axios parameter creator
 * @export
 */
export const TradingApiAxiosParamCreator = function (configuration?: Configuration) {
    return {
        /**
         * 
         * @summary Cancel open order in account
         * @param {string} userId 
         * @param {string} userSecret 
         * @param {string} accountId The ID of the account to cancel the order in.
         * @param {TradingCancelUserAccountOrderRequest} tradingCancelUserAccountOrderRequest The Order ID to be canceled
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        cancelUserAccountOrder: async (userId: string, userSecret: string, accountId: string, tradingCancelUserAccountOrderRequest: TradingCancelUserAccountOrderRequest, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            // verify required parameter 'userId' is not null or undefined
            assertParamExists('cancelUserAccountOrder', 'userId', userId)
            // verify required parameter 'userSecret' is not null or undefined
            assertParamExists('cancelUserAccountOrder', 'userSecret', userSecret)
            // verify required parameter 'accountId' is not null or undefined
            assertParamExists('cancelUserAccountOrder', 'accountId', accountId)
            // verify required parameter 'tradingCancelUserAccountOrderRequest' is not null or undefined
            assertParamExists('cancelUserAccountOrder', 'tradingCancelUserAccountOrderRequest', tradingCancelUserAccountOrderRequest)
            const localVarPath = `/accounts/{accountId}/orders/cancel`
                .replace(`{${"accountId"}}`, encodeURIComponent(String(accountId !== undefined ? accountId : `-accountId-`)));
            // use dummy base URL string because the URL constructor only accepts absolute URLs.
            const localVarUrlObj = new URL(localVarPath, DUMMY_BASE_URL);
            let baseOptions;
            if (configuration) {
                baseOptions = configuration.baseOptions;
            }

            const localVarRequestOptions: AxiosRequestConfig = { method: 'POST', ...baseOptions, ...options};
            const localVarHeaderParameter = configuration && !isBrowser() ? { "User-Agent": configuration.userAgent } : {} as any;
            const localVarQueryParameter = {} as any;

            // authentication PartnerClientId required
            await setApiKeyToObject({object: localVarQueryParameter, key: "clientId", keyParamName: "clientId", configuration})
            // authentication PartnerSignature required
            await setApiKeyToObject({ object: localVarHeaderParameter, key: "Signature", keyParamName: "signature", configuration })
            // authentication PartnerTimestamp required
            await setApiKeyToObject({object: localVarQueryParameter, key: "timestamp", keyParamName: "timestamp", configuration})
            if (userId !== undefined) {
                localVarQueryParameter['userId'] = userId;
            }

            if (userSecret !== undefined) {
                localVarQueryParameter['userSecret'] = userSecret;
            }


    
            localVarHeaderParameter['Content-Type'] = 'application/json';


            let headersFromBaseOptions = baseOptions && baseOptions.headers ? baseOptions.headers : {};
            localVarRequestOptions.headers = {...localVarHeaderParameter, ...headersFromBaseOptions, ...options.headers};
            requestBeforeHook({
                requestBody: tradingCancelUserAccountOrderRequest,
                queryParameters: localVarQueryParameter,
                requestConfig: localVarRequestOptions,
                path: localVarPath,
                configuration
            });
            localVarRequestOptions.data = serializeDataIfNeeded(tradingCancelUserAccountOrderRequest, localVarRequestOptions, configuration)

            setSearchParams(localVarUrlObj, localVarQueryParameter);
            return {
                url: toPathString(localVarUrlObj),
                options: localVarRequestOptions,
            };
        },
        /**
         * 
         * @summary Check impact of trades on account.
         * @param {string} userId 
         * @param {string} userSecret 
         * @param {ManualTradeForm} manualTradeForm 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        getOrderImpact: async (userId: string, userSecret: string, manualTradeForm: ManualTradeForm, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            // verify required parameter 'userId' is not null or undefined
            assertParamExists('getOrderImpact', 'userId', userId)
            // verify required parameter 'userSecret' is not null or undefined
            assertParamExists('getOrderImpact', 'userSecret', userSecret)
            // verify required parameter 'manualTradeForm' is not null or undefined
            assertParamExists('getOrderImpact', 'manualTradeForm', manualTradeForm)
            const localVarPath = `/trade/impact`;
            // use dummy base URL string because the URL constructor only accepts absolute URLs.
            const localVarUrlObj = new URL(localVarPath, DUMMY_BASE_URL);
            let baseOptions;
            if (configuration) {
                baseOptions = configuration.baseOptions;
            }

            const localVarRequestOptions: AxiosRequestConfig = { method: 'POST', ...baseOptions, ...options};
            const localVarHeaderParameter = configuration && !isBrowser() ? { "User-Agent": configuration.userAgent } : {} as any;
            const localVarQueryParameter = {} as any;

            // authentication PartnerClientId required
            await setApiKeyToObject({object: localVarQueryParameter, key: "clientId", keyParamName: "clientId", configuration})
            // authentication PartnerSignature required
            await setApiKeyToObject({ object: localVarHeaderParameter, key: "Signature", keyParamName: "signature", configuration })
            // authentication PartnerTimestamp required
            await setApiKeyToObject({object: localVarQueryParameter, key: "timestamp", keyParamName: "timestamp", configuration})
            if (userId !== undefined) {
                localVarQueryParameter['userId'] = userId;
            }

            if (userSecret !== undefined) {
                localVarQueryParameter['userSecret'] = userSecret;
            }


    
            localVarHeaderParameter['Content-Type'] = 'application/json';


            let headersFromBaseOptions = baseOptions && baseOptions.headers ? baseOptions.headers : {};
            localVarRequestOptions.headers = {...localVarHeaderParameter, ...headersFromBaseOptions, ...options.headers};
            requestBeforeHook({
                requestBody: manualTradeForm,
                queryParameters: localVarQueryParameter,
                requestConfig: localVarRequestOptions,
                path: localVarPath,
                configuration
            });
            localVarRequestOptions.data = serializeDataIfNeeded(manualTradeForm, localVarRequestOptions, configuration)

            setSearchParams(localVarUrlObj, localVarQueryParameter);
            return {
                url: toPathString(localVarUrlObj),
                options: localVarRequestOptions,
            };
        },
        /**
         * 
         * @summary Get symbol quotes
         * @param {string} userId 
         * @param {string} userSecret 
         * @param {string} symbols List of universal_symbol_id or tickers to get quotes for.
         * @param {string} accountId The ID of the account to get quotes.
         * @param {boolean} [useTicker] Should be set to True if providing tickers.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        getUserAccountQuotes: async (userId: string, userSecret: string, symbols: string, accountId: string, useTicker?: boolean, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            // verify required parameter 'userId' is not null or undefined
            assertParamExists('getUserAccountQuotes', 'userId', userId)
            // verify required parameter 'userSecret' is not null or undefined
            assertParamExists('getUserAccountQuotes', 'userSecret', userSecret)
            // verify required parameter 'symbols' is not null or undefined
            assertParamExists('getUserAccountQuotes', 'symbols', symbols)
            // verify required parameter 'accountId' is not null or undefined
            assertParamExists('getUserAccountQuotes', 'accountId', accountId)
            const localVarPath = `/accounts/{accountId}/quotes`
                .replace(`{${"accountId"}}`, encodeURIComponent(String(accountId !== undefined ? accountId : `-accountId-`)));
            // use dummy base URL string because the URL constructor only accepts absolute URLs.
            const localVarUrlObj = new URL(localVarPath, DUMMY_BASE_URL);
            let baseOptions;
            if (configuration) {
                baseOptions = configuration.baseOptions;
            }

            const localVarRequestOptions: AxiosRequestConfig = { method: 'GET', ...baseOptions, ...options};
            const localVarHeaderParameter = configuration && !isBrowser() ? { "User-Agent": configuration.userAgent } : {} as any;
            const localVarQueryParameter = {} as any;

            // authentication PartnerClientId required
            await setApiKeyToObject({object: localVarQueryParameter, key: "clientId", keyParamName: "clientId", configuration})
            // authentication PartnerSignature required
            await setApiKeyToObject({ object: localVarHeaderParameter, key: "Signature", keyParamName: "signature", configuration })
            // authentication PartnerTimestamp required
            await setApiKeyToObject({object: localVarQueryParameter, key: "timestamp", keyParamName: "timestamp", configuration})
            if (userId !== undefined) {
                localVarQueryParameter['userId'] = userId;
            }

            if (userSecret !== undefined) {
                localVarQueryParameter['userSecret'] = userSecret;
            }

            if (symbols !== undefined) {
                localVarQueryParameter['symbols'] = symbols;
            }

            if (useTicker !== undefined) {
                localVarQueryParameter['use_ticker'] = useTicker;
            }


    
            let headersFromBaseOptions = baseOptions && baseOptions.headers ? baseOptions.headers : {};
            localVarRequestOptions.headers = {...localVarHeaderParameter, ...headersFromBaseOptions, ...options.headers};
            requestBeforeHook({
                queryParameters: localVarQueryParameter,
                requestConfig: localVarRequestOptions,
                path: localVarPath,
                configuration
            });

            setSearchParams(localVarUrlObj, localVarQueryParameter);
            return {
                url: toPathString(localVarUrlObj),
                options: localVarRequestOptions,
            };
        },
        /**
         * 
         * @summary Place a trade with NO validation.
         * @param {string} userId 
         * @param {string} userSecret 
         * @param {ManualTradeForm} manualTradeForm 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        placeForceOrder: async (userId: string, userSecret: string, manualTradeForm: ManualTradeForm, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            // verify required parameter 'userId' is not null or undefined
            assertParamExists('placeForceOrder', 'userId', userId)
            // verify required parameter 'userSecret' is not null or undefined
            assertParamExists('placeForceOrder', 'userSecret', userSecret)
            // verify required parameter 'manualTradeForm' is not null or undefined
            assertParamExists('placeForceOrder', 'manualTradeForm', manualTradeForm)
            const localVarPath = `/trade/place`;
            // use dummy base URL string because the URL constructor only accepts absolute URLs.
            const localVarUrlObj = new URL(localVarPath, DUMMY_BASE_URL);
            let baseOptions;
            if (configuration) {
                baseOptions = configuration.baseOptions;
            }

            const localVarRequestOptions: AxiosRequestConfig = { method: 'POST', ...baseOptions, ...options};
            const localVarHeaderParameter = configuration && !isBrowser() ? { "User-Agent": configuration.userAgent } : {} as any;
            const localVarQueryParameter = {} as any;

            // authentication PartnerClientId required
            await setApiKeyToObject({object: localVarQueryParameter, key: "clientId", keyParamName: "clientId", configuration})
            // authentication PartnerSignature required
            await setApiKeyToObject({ object: localVarHeaderParameter, key: "Signature", keyParamName: "signature", configuration })
            // authentication PartnerTimestamp required
            await setApiKeyToObject({object: localVarQueryParameter, key: "timestamp", keyParamName: "timestamp", configuration})
            if (userId !== undefined) {
                localVarQueryParameter['userId'] = userId;
            }

            if (userSecret !== undefined) {
                localVarQueryParameter['userSecret'] = userSecret;
            }


    
            localVarHeaderParameter['Content-Type'] = 'application/json';


            let headersFromBaseOptions = baseOptions && baseOptions.headers ? baseOptions.headers : {};
            localVarRequestOptions.headers = {...localVarHeaderParameter, ...headersFromBaseOptions, ...options.headers};
            requestBeforeHook({
                requestBody: manualTradeForm,
                queryParameters: localVarQueryParameter,
                requestConfig: localVarRequestOptions,
                path: localVarPath,
                configuration
            });
            localVarRequestOptions.data = serializeDataIfNeeded(manualTradeForm, localVarRequestOptions, configuration)

            setSearchParams(localVarUrlObj, localVarQueryParameter);
            return {
                url: toPathString(localVarUrlObj),
                options: localVarRequestOptions,
            };
        },
        /**
         * 
         * @summary Place a OCO (One Cancels Other) order
         * @param {string} userId 
         * @param {string} userSecret 
         * @param {TradingPlaceOCOOrderRequest} tradingPlaceOCOOrderRequest 
         * @param {*} [options] Override http request option.
         * @deprecated
         * @throws {RequiredError}
         */
        placeOCOOrder: async (userId: string, userSecret: string, tradingPlaceOCOOrderRequest: TradingPlaceOCOOrderRequest, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            // verify required parameter 'userId' is not null or undefined
            assertParamExists('placeOCOOrder', 'userId', userId)
            // verify required parameter 'userSecret' is not null or undefined
            assertParamExists('placeOCOOrder', 'userSecret', userSecret)
            // verify required parameter 'tradingPlaceOCOOrderRequest' is not null or undefined
            assertParamExists('placeOCOOrder', 'tradingPlaceOCOOrderRequest', tradingPlaceOCOOrderRequest)
            const localVarPath = `/trade/oco`;
            // use dummy base URL string because the URL constructor only accepts absolute URLs.
            const localVarUrlObj = new URL(localVarPath, DUMMY_BASE_URL);
            let baseOptions;
            if (configuration) {
                baseOptions = configuration.baseOptions;
            }

            const localVarRequestOptions: AxiosRequestConfig = { method: 'POST', ...baseOptions, ...options};
            const localVarHeaderParameter = configuration && !isBrowser() ? { "User-Agent": configuration.userAgent } : {} as any;
            const localVarQueryParameter = {} as any;

            // authentication PartnerClientId required
            await setApiKeyToObject({object: localVarQueryParameter, key: "clientId", keyParamName: "clientId", configuration})
            // authentication PartnerSignature required
            await setApiKeyToObject({ object: localVarHeaderParameter, key: "Signature", keyParamName: "signature", configuration })
            // authentication PartnerTimestamp required
            await setApiKeyToObject({object: localVarQueryParameter, key: "timestamp", keyParamName: "timestamp", configuration})
            if (userId !== undefined) {
                localVarQueryParameter['userId'] = userId;
            }

            if (userSecret !== undefined) {
                localVarQueryParameter['userSecret'] = userSecret;
            }


    
            localVarHeaderParameter['Content-Type'] = 'application/json';


            let headersFromBaseOptions = baseOptions && baseOptions.headers ? baseOptions.headers : {};
            localVarRequestOptions.headers = {...localVarHeaderParameter, ...headersFromBaseOptions, ...options.headers};
            requestBeforeHook({
                requestBody: tradingPlaceOCOOrderRequest,
                queryParameters: localVarQueryParameter,
                requestConfig: localVarRequestOptions,
                path: localVarPath,
                configuration
            });
            localVarRequestOptions.data = serializeDataIfNeeded(tradingPlaceOCOOrderRequest, localVarRequestOptions, configuration)

            setSearchParams(localVarUrlObj, localVarQueryParameter);
            return {
                url: toPathString(localVarUrlObj),
                options: localVarRequestOptions,
            };
        },
        /**
         * 
         * @summary Place order
         * @param {string} tradeId The ID of trade object obtained from trade/impact endpoint
         * @param {string} userId 
         * @param {string} userSecret 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        placeOrder: async (tradeId: string, userId: string, userSecret: string, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            // verify required parameter 'tradeId' is not null or undefined
            assertParamExists('placeOrder', 'tradeId', tradeId)
            // verify required parameter 'userId' is not null or undefined
            assertParamExists('placeOrder', 'userId', userId)
            // verify required parameter 'userSecret' is not null or undefined
            assertParamExists('placeOrder', 'userSecret', userSecret)
            const localVarPath = `/trade/{tradeId}`
                .replace(`{${"tradeId"}}`, encodeURIComponent(String(tradeId !== undefined ? tradeId : `-tradeId-`)));
            // use dummy base URL string because the URL constructor only accepts absolute URLs.
            const localVarUrlObj = new URL(localVarPath, DUMMY_BASE_URL);
            let baseOptions;
            if (configuration) {
                baseOptions = configuration.baseOptions;
            }

            const localVarRequestOptions: AxiosRequestConfig = { method: 'POST', ...baseOptions, ...options};
            const localVarHeaderParameter = configuration && !isBrowser() ? { "User-Agent": configuration.userAgent } : {} as any;
            const localVarQueryParameter = {} as any;

            // authentication PartnerClientId required
            await setApiKeyToObject({object: localVarQueryParameter, key: "clientId", keyParamName: "clientId", configuration})
            // authentication PartnerSignature required
            await setApiKeyToObject({ object: localVarHeaderParameter, key: "Signature", keyParamName: "signature", configuration })
            // authentication PartnerTimestamp required
            await setApiKeyToObject({object: localVarQueryParameter, key: "timestamp", keyParamName: "timestamp", configuration})
            if (userId !== undefined) {
                localVarQueryParameter['userId'] = userId;
            }

            if (userSecret !== undefined) {
                localVarQueryParameter['userSecret'] = userSecret;
            }


    
            let headersFromBaseOptions = baseOptions && baseOptions.headers ? baseOptions.headers : {};
            localVarRequestOptions.headers = {...localVarHeaderParameter, ...headersFromBaseOptions, ...options.headers};
            requestBeforeHook({
                queryParameters: localVarQueryParameter,
                requestConfig: localVarRequestOptions,
                path: localVarPath,
                configuration
            });

            setSearchParams(localVarUrlObj, localVarQueryParameter);
            return {
                url: toPathString(localVarUrlObj),
                options: localVarRequestOptions,
            };
        },
    }
};

/**
 * TradingApi - functional programming interface
 * @export
 */
export const TradingApiFp = function(configuration?: Configuration) {
    const localVarAxiosParamCreator = TradingApiAxiosParamCreator(configuration)
    return {
        /**
         * 
         * @summary Cancel open order in account
         * @param {TradingApiCancelUserAccountOrderRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async cancelUserAccountOrder(requestParameters: TradingApiCancelUserAccountOrderRequest, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => AxiosPromise<AccountOrderRecord>> {
            const localVarAxiosArgs = await localVarAxiosParamCreator.cancelUserAccountOrder(requestParameters.userId, requestParameters.userSecret, requestParameters.accountId, requestParameters, options);
            return createRequestFunction(localVarAxiosArgs, globalAxios, BASE_PATH, configuration);
        },
        /**
         * 
         * @summary Check impact of trades on account.
         * @param {TradingApiGetOrderImpactRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async getOrderImpact(requestParameters: TradingApiGetOrderImpactRequest, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => AxiosPromise<ManualTradeAndImpact>> {
            const localVarAxiosArgs = await localVarAxiosParamCreator.getOrderImpact(requestParameters.userId, requestParameters.userSecret, requestParameters, options);
            return createRequestFunction(localVarAxiosArgs, globalAxios, BASE_PATH, configuration);
        },
        /**
         * 
         * @summary Get symbol quotes
         * @param {TradingApiGetUserAccountQuotesRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async getUserAccountQuotes(requestParameters: TradingApiGetUserAccountQuotesRequest, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => AxiosPromise<Array<SymbolsQuotesInner>>> {
            const localVarAxiosArgs = await localVarAxiosParamCreator.getUserAccountQuotes(requestParameters.userId, requestParameters.userSecret, requestParameters.symbols, requestParameters.accountId, requestParameters.useTicker, options);
            return createRequestFunction(localVarAxiosArgs, globalAxios, BASE_PATH, configuration);
        },
        /**
         * 
         * @summary Place a trade with NO validation.
         * @param {TradingApiPlaceForceOrderRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async placeForceOrder(requestParameters: TradingApiPlaceForceOrderRequest, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => AxiosPromise<AccountOrderRecord>> {
            const localVarAxiosArgs = await localVarAxiosParamCreator.placeForceOrder(requestParameters.userId, requestParameters.userSecret, requestParameters, options);
            return createRequestFunction(localVarAxiosArgs, globalAxios, BASE_PATH, configuration);
        },
        /**
         * 
         * @summary Place a OCO (One Cancels Other) order
         * @param {TradingApiPlaceOCOOrderRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @deprecated
         * @throws {RequiredError}
         */
        async placeOCOOrder(requestParameters: TradingApiPlaceOCOOrderRequest, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => AxiosPromise<AccountOrderRecord>> {
            const localVarAxiosArgs = await localVarAxiosParamCreator.placeOCOOrder(requestParameters.userId, requestParameters.userSecret, requestParameters, options);
            return createRequestFunction(localVarAxiosArgs, globalAxios, BASE_PATH, configuration);
        },
        /**
         * 
         * @summary Place order
         * @param {TradingApiPlaceOrderRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async placeOrder(requestParameters: TradingApiPlaceOrderRequest, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => AxiosPromise<AccountOrderRecord>> {
            const localVarAxiosArgs = await localVarAxiosParamCreator.placeOrder(requestParameters.tradeId, requestParameters.userId, requestParameters.userSecret, options);
            return createRequestFunction(localVarAxiosArgs, globalAxios, BASE_PATH, configuration);
        },
    }
};

/**
 * TradingApi - factory interface
 * @export
 */
export const TradingApiFactory = function (configuration?: Configuration, basePath?: string, axios?: AxiosInstance) {
    const localVarFp = TradingApiFp(configuration)
    return {
        /**
         * 
         * @summary Cancel open order in account
         * @param {TradingApiCancelUserAccountOrderRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        cancelUserAccountOrder(requestParameters: TradingApiCancelUserAccountOrderRequest, options?: AxiosRequestConfig): AxiosPromise<AccountOrderRecord> {
            return localVarFp.cancelUserAccountOrder(requestParameters, options).then((request) => request(axios, basePath));
        },
        /**
         * 
         * @summary Check impact of trades on account.
         * @param {TradingApiGetOrderImpactRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        getOrderImpact(requestParameters: TradingApiGetOrderImpactRequest, options?: AxiosRequestConfig): AxiosPromise<ManualTradeAndImpact> {
            return localVarFp.getOrderImpact(requestParameters, options).then((request) => request(axios, basePath));
        },
        /**
         * 
         * @summary Get symbol quotes
         * @param {TradingApiGetUserAccountQuotesRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        getUserAccountQuotes(requestParameters: TradingApiGetUserAccountQuotesRequest, options?: AxiosRequestConfig): AxiosPromise<Array<SymbolsQuotesInner>> {
            return localVarFp.getUserAccountQuotes(requestParameters, options).then((request) => request(axios, basePath));
        },
        /**
         * 
         * @summary Place a trade with NO validation.
         * @param {TradingApiPlaceForceOrderRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        placeForceOrder(requestParameters: TradingApiPlaceForceOrderRequest, options?: AxiosRequestConfig): AxiosPromise<AccountOrderRecord> {
            return localVarFp.placeForceOrder(requestParameters, options).then((request) => request(axios, basePath));
        },
        /**
         * 
         * @summary Place a OCO (One Cancels Other) order
         * @param {TradingApiPlaceOCOOrderRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @deprecated
         * @throws {RequiredError}
         */
        placeOCOOrder(requestParameters: TradingApiPlaceOCOOrderRequest, options?: AxiosRequestConfig): AxiosPromise<AccountOrderRecord> {
            return localVarFp.placeOCOOrder(requestParameters, options).then((request) => request(axios, basePath));
        },
        /**
         * 
         * @summary Place order
         * @param {TradingApiPlaceOrderRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        placeOrder(requestParameters: TradingApiPlaceOrderRequest, options?: AxiosRequestConfig): AxiosPromise<AccountOrderRecord> {
            return localVarFp.placeOrder(requestParameters, options).then((request) => request(axios, basePath));
        },
    };
};

/**
 * Request parameters for cancelUserAccountOrder operation in TradingApi.
 * @export
 * @interface TradingApiCancelUserAccountOrderRequest
 */
export type TradingApiCancelUserAccountOrderRequest = {
    
    /**
    * 
    * @type {string}
    * @memberof TradingApiCancelUserAccountOrder
    */
    readonly userId: string
    
    /**
    * 
    * @type {string}
    * @memberof TradingApiCancelUserAccountOrder
    */
    readonly userSecret: string
    
    /**
    * The ID of the account to cancel the order in.
    * @type {string}
    * @memberof TradingApiCancelUserAccountOrder
    */
    readonly accountId: string
    
} & TradingCancelUserAccountOrderRequest

/**
 * Request parameters for getOrderImpact operation in TradingApi.
 * @export
 * @interface TradingApiGetOrderImpactRequest
 */
export type TradingApiGetOrderImpactRequest = {
    
    /**
    * 
    * @type {string}
    * @memberof TradingApiGetOrderImpact
    */
    readonly userId: string
    
    /**
    * 
    * @type {string}
    * @memberof TradingApiGetOrderImpact
    */
    readonly userSecret: string
    
} & ManualTradeForm

/**
 * Request parameters for getUserAccountQuotes operation in TradingApi.
 * @export
 * @interface TradingApiGetUserAccountQuotesRequest
 */
export type TradingApiGetUserAccountQuotesRequest = {
    
    /**
    * 
    * @type {string}
    * @memberof TradingApiGetUserAccountQuotes
    */
    readonly userId: string
    
    /**
    * 
    * @type {string}
    * @memberof TradingApiGetUserAccountQuotes
    */
    readonly userSecret: string
    
    /**
    * List of universal_symbol_id or tickers to get quotes for.
    * @type {string}
    * @memberof TradingApiGetUserAccountQuotes
    */
    readonly symbols: string
    
    /**
    * The ID of the account to get quotes.
    * @type {string}
    * @memberof TradingApiGetUserAccountQuotes
    */
    readonly accountId: string
    
    /**
    * Should be set to True if providing tickers.
    * @type {boolean}
    * @memberof TradingApiGetUserAccountQuotes
    */
    readonly useTicker?: boolean
    
}

/**
 * Request parameters for placeForceOrder operation in TradingApi.
 * @export
 * @interface TradingApiPlaceForceOrderRequest
 */
export type TradingApiPlaceForceOrderRequest = {
    
    /**
    * 
    * @type {string}
    * @memberof TradingApiPlaceForceOrder
    */
    readonly userId: string
    
    /**
    * 
    * @type {string}
    * @memberof TradingApiPlaceForceOrder
    */
    readonly userSecret: string
    
} & ManualTradeForm

/**
 * Request parameters for placeOCOOrder operation in TradingApi.
 * @export
 * @interface TradingApiPlaceOCOOrderRequest
 */
export type TradingApiPlaceOCOOrderRequest = {
    
    /**
    * 
    * @type {string}
    * @memberof TradingApiPlaceOCOOrder
    */
    readonly userId: string
    
    /**
    * 
    * @type {string}
    * @memberof TradingApiPlaceOCOOrder
    */
    readonly userSecret: string
    
} & TradingPlaceOCOOrderRequest

/**
 * Request parameters for placeOrder operation in TradingApi.
 * @export
 * @interface TradingApiPlaceOrderRequest
 */
export type TradingApiPlaceOrderRequest = {
    
    /**
    * The ID of trade object obtained from trade/impact endpoint
    * @type {string}
    * @memberof TradingApiPlaceOrder
    */
    readonly tradeId: string
    
    /**
    * 
    * @type {string}
    * @memberof TradingApiPlaceOrder
    */
    readonly userId: string
    
    /**
    * 
    * @type {string}
    * @memberof TradingApiPlaceOrder
    */
    readonly userSecret: string
    
}

/**
 * TradingApiGenerated - object-oriented interface
 * @export
 * @class TradingApiGenerated
 * @extends {BaseAPI}
 */
export class TradingApiGenerated extends BaseAPI {
    /**
     * 
     * @summary Cancel open order in account
     * @param {TradingApiCancelUserAccountOrderRequest} requestParameters Request parameters.
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof TradingApiGenerated
     */
    public cancelUserAccountOrder(requestParameters: TradingApiCancelUserAccountOrderRequest, options?: AxiosRequestConfig) {
        return TradingApiFp(this.configuration).cancelUserAccountOrder(requestParameters, options).then((request) => request(this.axios, this.basePath));
    }

    /**
     * 
     * @summary Check impact of trades on account.
     * @param {TradingApiGetOrderImpactRequest} requestParameters Request parameters.
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof TradingApiGenerated
     */
    public getOrderImpact(requestParameters: TradingApiGetOrderImpactRequest, options?: AxiosRequestConfig) {
        return TradingApiFp(this.configuration).getOrderImpact(requestParameters, options).then((request) => request(this.axios, this.basePath));
    }

    /**
     * 
     * @summary Get symbol quotes
     * @param {TradingApiGetUserAccountQuotesRequest} requestParameters Request parameters.
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof TradingApiGenerated
     */
    public getUserAccountQuotes(requestParameters: TradingApiGetUserAccountQuotesRequest, options?: AxiosRequestConfig) {
        return TradingApiFp(this.configuration).getUserAccountQuotes(requestParameters, options).then((request) => request(this.axios, this.basePath));
    }

    /**
     * 
     * @summary Place a trade with NO validation.
     * @param {TradingApiPlaceForceOrderRequest} requestParameters Request parameters.
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof TradingApiGenerated
     */
    public placeForceOrder(requestParameters: TradingApiPlaceForceOrderRequest, options?: AxiosRequestConfig) {
        return TradingApiFp(this.configuration).placeForceOrder(requestParameters, options).then((request) => request(this.axios, this.basePath));
    }

    /**
     * 
     * @summary Place a OCO (One Cancels Other) order
     * @param {TradingApiPlaceOCOOrderRequest} requestParameters Request parameters.
     * @param {*} [options] Override http request option.
     * @deprecated
     * @throws {RequiredError}
     * @memberof TradingApiGenerated
     */
    public placeOCOOrder(requestParameters: TradingApiPlaceOCOOrderRequest, options?: AxiosRequestConfig) {
        return TradingApiFp(this.configuration).placeOCOOrder(requestParameters, options).then((request) => request(this.axios, this.basePath));
    }

    /**
     * 
     * @summary Place order
     * @param {TradingApiPlaceOrderRequest} requestParameters Request parameters.
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof TradingApiGenerated
     */
    public placeOrder(requestParameters: TradingApiPlaceOrderRequest, options?: AxiosRequestConfig) {
        return TradingApiFp(this.configuration).placeOrder(requestParameters, options).then((request) => request(this.axios, this.basePath));
    }
}
