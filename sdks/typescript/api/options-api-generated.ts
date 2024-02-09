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
import { Model500UnexpectedExceptionResponse } from '../models';
// @ts-ignore
import { OptionChainInner } from '../models';
// @ts-ignore
import { OptionLeg } from '../models';
// @ts-ignore
import { OptionsGetOptionStrategyRequest } from '../models';
// @ts-ignore
import { OptionsPlaceOptionStrategyRequest } from '../models';
// @ts-ignore
import { OptionsPosition } from '../models';
// @ts-ignore
import { OrderType } from '../models';
// @ts-ignore
import { StrategyOrderRecord } from '../models';
// @ts-ignore
import { StrategyQuotes } from '../models';
// @ts-ignore
import { TimeInForceStrict } from '../models';
import { paginate } from "../pagination/paginate";
import type * as buffer from "buffer"
import { requestBeforeHook } from '../requestBeforeHook';
/**
 * OptionsApi - axios parameter creator
 * @export
 */
export const OptionsApiAxiosParamCreator = function (configuration?: Configuration) {
    return {
        /**
         * 
         * @summary Creates an option strategy object that will be used to place an option strategy order
         * @param {string} userId 
         * @param {string} userSecret 
         * @param {string} accountId The ID of the account to create the option strategy object in.
         * @param {OptionsGetOptionStrategyRequest} optionsGetOptionStrategyRequest 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        getOptionStrategy: async (userId: string, userSecret: string, accountId: string, optionsGetOptionStrategyRequest: OptionsGetOptionStrategyRequest, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            // verify required parameter 'userId' is not null or undefined
            assertParamExists('getOptionStrategy', 'userId', userId)
            // verify required parameter 'userSecret' is not null or undefined
            assertParamExists('getOptionStrategy', 'userSecret', userSecret)
            // verify required parameter 'accountId' is not null or undefined
            assertParamExists('getOptionStrategy', 'accountId', accountId)
            // verify required parameter 'optionsGetOptionStrategyRequest' is not null or undefined
            assertParamExists('getOptionStrategy', 'optionsGetOptionStrategyRequest', optionsGetOptionStrategyRequest)
            const localVarPath = `/accounts/{accountId}/optionStrategy`
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
                requestBody: optionsGetOptionStrategyRequest,
                queryParameters: localVarQueryParameter,
                requestConfig: localVarRequestOptions,
                path: localVarPath,
                configuration
            });
            localVarRequestOptions.data = serializeDataIfNeeded(optionsGetOptionStrategyRequest, localVarRequestOptions, configuration)

            setSearchParams(localVarUrlObj, localVarQueryParameter);
            return {
                url: toPathString(localVarUrlObj),
                options: localVarRequestOptions,
            };
        },
        /**
         * 
         * @summary Get the options chain
         * @param {string} userId 
         * @param {string} userSecret 
         * @param {string} accountId The ID of the account to get the options chain from.
         * @param {string} symbol Universal symbol ID if symbol
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        getOptionsChain: async (userId: string, userSecret: string, accountId: string, symbol: string, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            // verify required parameter 'userId' is not null or undefined
            assertParamExists('getOptionsChain', 'userId', userId)
            // verify required parameter 'userSecret' is not null or undefined
            assertParamExists('getOptionsChain', 'userSecret', userSecret)
            // verify required parameter 'accountId' is not null or undefined
            assertParamExists('getOptionsChain', 'accountId', accountId)
            // verify required parameter 'symbol' is not null or undefined
            assertParamExists('getOptionsChain', 'symbol', symbol)
            const localVarPath = `/accounts/{accountId}/optionsChain`
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

            if (symbol !== undefined) {
                localVarQueryParameter['symbol'] = symbol;
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
         * @summary Get latest market data of option strategy
         * @param {string} userId 
         * @param {string} userSecret 
         * @param {string} accountId The ID of the account the strategy will be placed in.
         * @param {string} optionStrategyId Option strategy id obtained from response when creating option strategy object
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        getOptionsStrategyQuote: async (userId: string, userSecret: string, accountId: string, optionStrategyId: string, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            // verify required parameter 'userId' is not null or undefined
            assertParamExists('getOptionsStrategyQuote', 'userId', userId)
            // verify required parameter 'userSecret' is not null or undefined
            assertParamExists('getOptionsStrategyQuote', 'userSecret', userSecret)
            // verify required parameter 'accountId' is not null or undefined
            assertParamExists('getOptionsStrategyQuote', 'accountId', accountId)
            // verify required parameter 'optionStrategyId' is not null or undefined
            assertParamExists('getOptionsStrategyQuote', 'optionStrategyId', optionStrategyId)
            const localVarPath = `/accounts/{accountId}/optionStrategy/{optionStrategyId}`
                .replace(`{${"accountId"}}`, encodeURIComponent(String(accountId !== undefined ? accountId : `-accountId-`)))
                .replace(`{${"optionStrategyId"}}`, encodeURIComponent(String(optionStrategyId !== undefined ? optionStrategyId : `-optionStrategyId-`)));
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
         * @summary Get the options holdings in the account
         * @param {string} userId 
         * @param {string} userSecret 
         * @param {string} accountId The ID of the account to fetch options holdings for.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        listOptionHoldings: async (userId: string, userSecret: string, accountId: string, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            // verify required parameter 'userId' is not null or undefined
            assertParamExists('listOptionHoldings', 'userId', userId)
            // verify required parameter 'userSecret' is not null or undefined
            assertParamExists('listOptionHoldings', 'userSecret', userSecret)
            // verify required parameter 'accountId' is not null or undefined
            assertParamExists('listOptionHoldings', 'accountId', accountId)
            const localVarPath = `/accounts/{accountId}/options`
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
         * @summary Place an option strategy order on the brokerage
         * @param {string} userId 
         * @param {string} userSecret 
         * @param {string} accountId The ID of the account to execute the strategy in.
         * @param {string} optionStrategyId Option strategy id obtained from response when creating option strategy object
         * @param {OptionsPlaceOptionStrategyRequest} optionsPlaceOptionStrategyRequest 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        placeOptionStrategy: async (userId: string, userSecret: string, accountId: string, optionStrategyId: string, optionsPlaceOptionStrategyRequest: OptionsPlaceOptionStrategyRequest, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            // verify required parameter 'userId' is not null or undefined
            assertParamExists('placeOptionStrategy', 'userId', userId)
            // verify required parameter 'userSecret' is not null or undefined
            assertParamExists('placeOptionStrategy', 'userSecret', userSecret)
            // verify required parameter 'accountId' is not null or undefined
            assertParamExists('placeOptionStrategy', 'accountId', accountId)
            // verify required parameter 'optionStrategyId' is not null or undefined
            assertParamExists('placeOptionStrategy', 'optionStrategyId', optionStrategyId)
            // verify required parameter 'optionsPlaceOptionStrategyRequest' is not null or undefined
            assertParamExists('placeOptionStrategy', 'optionsPlaceOptionStrategyRequest', optionsPlaceOptionStrategyRequest)
            const localVarPath = `/accounts/{accountId}/optionStrategy/{optionStrategyId}/execute`
                .replace(`{${"accountId"}}`, encodeURIComponent(String(accountId !== undefined ? accountId : `-accountId-`)))
                .replace(`{${"optionStrategyId"}}`, encodeURIComponent(String(optionStrategyId !== undefined ? optionStrategyId : `-optionStrategyId-`)));
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
                requestBody: optionsPlaceOptionStrategyRequest,
                queryParameters: localVarQueryParameter,
                requestConfig: localVarRequestOptions,
                path: localVarPath,
                configuration
            });
            localVarRequestOptions.data = serializeDataIfNeeded(optionsPlaceOptionStrategyRequest, localVarRequestOptions, configuration)

            setSearchParams(localVarUrlObj, localVarQueryParameter);
            return {
                url: toPathString(localVarUrlObj),
                options: localVarRequestOptions,
            };
        },
    }
};

/**
 * OptionsApi - functional programming interface
 * @export
 */
export const OptionsApiFp = function(configuration?: Configuration) {
    const localVarAxiosParamCreator = OptionsApiAxiosParamCreator(configuration)
    return {
        /**
         * 
         * @summary Creates an option strategy object that will be used to place an option strategy order
         * @param {OptionsApiGetOptionStrategyRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async getOptionStrategy(requestParameters: OptionsApiGetOptionStrategyRequest, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => AxiosPromise<StrategyQuotes>> {
            const localVarAxiosArgs = await localVarAxiosParamCreator.getOptionStrategy(requestParameters.userId, requestParameters.userSecret, requestParameters.accountId, requestParameters, options);
            return createRequestFunction(localVarAxiosArgs, globalAxios, BASE_PATH, configuration);
        },
        /**
         * 
         * @summary Get the options chain
         * @param {OptionsApiGetOptionsChainRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async getOptionsChain(requestParameters: OptionsApiGetOptionsChainRequest, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => AxiosPromise<Array<OptionChainInner>>> {
            const localVarAxiosArgs = await localVarAxiosParamCreator.getOptionsChain(requestParameters.userId, requestParameters.userSecret, requestParameters.accountId, requestParameters.symbol, options);
            return createRequestFunction(localVarAxiosArgs, globalAxios, BASE_PATH, configuration);
        },
        /**
         * 
         * @summary Get latest market data of option strategy
         * @param {OptionsApiGetOptionsStrategyQuoteRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async getOptionsStrategyQuote(requestParameters: OptionsApiGetOptionsStrategyQuoteRequest, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => AxiosPromise<StrategyQuotes>> {
            const localVarAxiosArgs = await localVarAxiosParamCreator.getOptionsStrategyQuote(requestParameters.userId, requestParameters.userSecret, requestParameters.accountId, requestParameters.optionStrategyId, options);
            return createRequestFunction(localVarAxiosArgs, globalAxios, BASE_PATH, configuration);
        },
        /**
         * 
         * @summary Get the options holdings in the account
         * @param {OptionsApiListOptionHoldingsRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async listOptionHoldings(requestParameters: OptionsApiListOptionHoldingsRequest, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => AxiosPromise<Array<OptionsPosition>>> {
            const localVarAxiosArgs = await localVarAxiosParamCreator.listOptionHoldings(requestParameters.userId, requestParameters.userSecret, requestParameters.accountId, options);
            return createRequestFunction(localVarAxiosArgs, globalAxios, BASE_PATH, configuration);
        },
        /**
         * 
         * @summary Place an option strategy order on the brokerage
         * @param {OptionsApiPlaceOptionStrategyRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async placeOptionStrategy(requestParameters: OptionsApiPlaceOptionStrategyRequest, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => AxiosPromise<StrategyOrderRecord>> {
            const localVarAxiosArgs = await localVarAxiosParamCreator.placeOptionStrategy(requestParameters.userId, requestParameters.userSecret, requestParameters.accountId, requestParameters.optionStrategyId, requestParameters, options);
            return createRequestFunction(localVarAxiosArgs, globalAxios, BASE_PATH, configuration);
        },
    }
};

/**
 * OptionsApi - factory interface
 * @export
 */
export const OptionsApiFactory = function (configuration?: Configuration, basePath?: string, axios?: AxiosInstance) {
    const localVarFp = OptionsApiFp(configuration)
    return {
        /**
         * 
         * @summary Creates an option strategy object that will be used to place an option strategy order
         * @param {OptionsApiGetOptionStrategyRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        getOptionStrategy(requestParameters: OptionsApiGetOptionStrategyRequest, options?: AxiosRequestConfig): AxiosPromise<StrategyQuotes> {
            return localVarFp.getOptionStrategy(requestParameters, options).then((request) => request(axios, basePath));
        },
        /**
         * 
         * @summary Get the options chain
         * @param {OptionsApiGetOptionsChainRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        getOptionsChain(requestParameters: OptionsApiGetOptionsChainRequest, options?: AxiosRequestConfig): AxiosPromise<Array<OptionChainInner>> {
            return localVarFp.getOptionsChain(requestParameters, options).then((request) => request(axios, basePath));
        },
        /**
         * 
         * @summary Get latest market data of option strategy
         * @param {OptionsApiGetOptionsStrategyQuoteRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        getOptionsStrategyQuote(requestParameters: OptionsApiGetOptionsStrategyQuoteRequest, options?: AxiosRequestConfig): AxiosPromise<StrategyQuotes> {
            return localVarFp.getOptionsStrategyQuote(requestParameters, options).then((request) => request(axios, basePath));
        },
        /**
         * 
         * @summary Get the options holdings in the account
         * @param {OptionsApiListOptionHoldingsRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        listOptionHoldings(requestParameters: OptionsApiListOptionHoldingsRequest, options?: AxiosRequestConfig): AxiosPromise<Array<OptionsPosition>> {
            return localVarFp.listOptionHoldings(requestParameters, options).then((request) => request(axios, basePath));
        },
        /**
         * 
         * @summary Place an option strategy order on the brokerage
         * @param {OptionsApiPlaceOptionStrategyRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        placeOptionStrategy(requestParameters: OptionsApiPlaceOptionStrategyRequest, options?: AxiosRequestConfig): AxiosPromise<StrategyOrderRecord> {
            return localVarFp.placeOptionStrategy(requestParameters, options).then((request) => request(axios, basePath));
        },
    };
};

/**
 * Request parameters for getOptionStrategy operation in OptionsApi.
 * @export
 * @interface OptionsApiGetOptionStrategyRequest
 */
export type OptionsApiGetOptionStrategyRequest = {
    
    /**
    * 
    * @type {string}
    * @memberof OptionsApiGetOptionStrategy
    */
    readonly userId: string
    
    /**
    * 
    * @type {string}
    * @memberof OptionsApiGetOptionStrategy
    */
    readonly userSecret: string
    
    /**
    * The ID of the account to create the option strategy object in.
    * @type {string}
    * @memberof OptionsApiGetOptionStrategy
    */
    readonly accountId: string
    
} & OptionsGetOptionStrategyRequest

/**
 * Request parameters for getOptionsChain operation in OptionsApi.
 * @export
 * @interface OptionsApiGetOptionsChainRequest
 */
export type OptionsApiGetOptionsChainRequest = {
    
    /**
    * 
    * @type {string}
    * @memberof OptionsApiGetOptionsChain
    */
    readonly userId: string
    
    /**
    * 
    * @type {string}
    * @memberof OptionsApiGetOptionsChain
    */
    readonly userSecret: string
    
    /**
    * The ID of the account to get the options chain from.
    * @type {string}
    * @memberof OptionsApiGetOptionsChain
    */
    readonly accountId: string
    
    /**
    * Universal symbol ID if symbol
    * @type {string}
    * @memberof OptionsApiGetOptionsChain
    */
    readonly symbol: string
    
}

/**
 * Request parameters for getOptionsStrategyQuote operation in OptionsApi.
 * @export
 * @interface OptionsApiGetOptionsStrategyQuoteRequest
 */
export type OptionsApiGetOptionsStrategyQuoteRequest = {
    
    /**
    * 
    * @type {string}
    * @memberof OptionsApiGetOptionsStrategyQuote
    */
    readonly userId: string
    
    /**
    * 
    * @type {string}
    * @memberof OptionsApiGetOptionsStrategyQuote
    */
    readonly userSecret: string
    
    /**
    * The ID of the account the strategy will be placed in.
    * @type {string}
    * @memberof OptionsApiGetOptionsStrategyQuote
    */
    readonly accountId: string
    
    /**
    * Option strategy id obtained from response when creating option strategy object
    * @type {string}
    * @memberof OptionsApiGetOptionsStrategyQuote
    */
    readonly optionStrategyId: string
    
}

/**
 * Request parameters for listOptionHoldings operation in OptionsApi.
 * @export
 * @interface OptionsApiListOptionHoldingsRequest
 */
export type OptionsApiListOptionHoldingsRequest = {
    
    /**
    * 
    * @type {string}
    * @memberof OptionsApiListOptionHoldings
    */
    readonly userId: string
    
    /**
    * 
    * @type {string}
    * @memberof OptionsApiListOptionHoldings
    */
    readonly userSecret: string
    
    /**
    * The ID of the account to fetch options holdings for.
    * @type {string}
    * @memberof OptionsApiListOptionHoldings
    */
    readonly accountId: string
    
}

/**
 * Request parameters for placeOptionStrategy operation in OptionsApi.
 * @export
 * @interface OptionsApiPlaceOptionStrategyRequest
 */
export type OptionsApiPlaceOptionStrategyRequest = {
    
    /**
    * 
    * @type {string}
    * @memberof OptionsApiPlaceOptionStrategy
    */
    readonly userId: string
    
    /**
    * 
    * @type {string}
    * @memberof OptionsApiPlaceOptionStrategy
    */
    readonly userSecret: string
    
    /**
    * The ID of the account to execute the strategy in.
    * @type {string}
    * @memberof OptionsApiPlaceOptionStrategy
    */
    readonly accountId: string
    
    /**
    * Option strategy id obtained from response when creating option strategy object
    * @type {string}
    * @memberof OptionsApiPlaceOptionStrategy
    */
    readonly optionStrategyId: string
    
} & OptionsPlaceOptionStrategyRequest

/**
 * OptionsApiGenerated - object-oriented interface
 * @export
 * @class OptionsApiGenerated
 * @extends {BaseAPI}
 */
export class OptionsApiGenerated extends BaseAPI {
    /**
     * 
     * @summary Creates an option strategy object that will be used to place an option strategy order
     * @param {OptionsApiGetOptionStrategyRequest} requestParameters Request parameters.
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof OptionsApiGenerated
     */
    public getOptionStrategy(requestParameters: OptionsApiGetOptionStrategyRequest, options?: AxiosRequestConfig) {
        return OptionsApiFp(this.configuration).getOptionStrategy(requestParameters, options).then((request) => request(this.axios, this.basePath));
    }

    /**
     * 
     * @summary Get the options chain
     * @param {OptionsApiGetOptionsChainRequest} requestParameters Request parameters.
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof OptionsApiGenerated
     */
    public getOptionsChain(requestParameters: OptionsApiGetOptionsChainRequest, options?: AxiosRequestConfig) {
        return OptionsApiFp(this.configuration).getOptionsChain(requestParameters, options).then((request) => request(this.axios, this.basePath));
    }

    /**
     * 
     * @summary Get latest market data of option strategy
     * @param {OptionsApiGetOptionsStrategyQuoteRequest} requestParameters Request parameters.
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof OptionsApiGenerated
     */
    public getOptionsStrategyQuote(requestParameters: OptionsApiGetOptionsStrategyQuoteRequest, options?: AxiosRequestConfig) {
        return OptionsApiFp(this.configuration).getOptionsStrategyQuote(requestParameters, options).then((request) => request(this.axios, this.basePath));
    }

    /**
     * 
     * @summary Get the options holdings in the account
     * @param {OptionsApiListOptionHoldingsRequest} requestParameters Request parameters.
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof OptionsApiGenerated
     */
    public listOptionHoldings(requestParameters: OptionsApiListOptionHoldingsRequest, options?: AxiosRequestConfig) {
        return OptionsApiFp(this.configuration).listOptionHoldings(requestParameters, options).then((request) => request(this.axios, this.basePath));
    }

    /**
     * 
     * @summary Place an option strategy order on the brokerage
     * @param {OptionsApiPlaceOptionStrategyRequest} requestParameters Request parameters.
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof OptionsApiGenerated
     */
    public placeOptionStrategy(requestParameters: OptionsApiPlaceOptionStrategyRequest, options?: AxiosRequestConfig) {
        return OptionsApiFp(this.configuration).placeOptionStrategy(requestParameters, options).then((request) => request(this.axios, this.basePath));
    }
}
