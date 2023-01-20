/*
 * SnapTrade
 * Connect brokerage accounts to your app for live positions and trading
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: api@snaptrade.com
 *
 * NOTE: This class is auto generated by Konfig (https://konfigthis.com).
 * Do not edit the class manually.
 */


package com.konfigthis.client.api;

import com.konfigthis.client.ApiException;
import com.konfigthis.client.model.OptionChainInner;
import com.konfigthis.client.model.OptionsGetOptionStrategyRequest;
import com.konfigthis.client.model.OptionsHoldings;
import com.konfigthis.client.model.OptionsPlaceOptionStrategyRequest;
import com.konfigthis.client.model.StrategyOrderRecord;
import com.konfigthis.client.model.StrategyQuotes;
import java.util.UUID;
import org.junit.jupiter.api.Disabled;
import org.junit.jupiter.api.Test;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * API tests for OptionsApi
 */
@Disabled
public class OptionsApiTest {

    private final OptionsApi api = new OptionsApi();

    /**
     * Creates an option strategy object that will be used to place an option strategy order
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void getOptionStrategyTest() throws ApiException {
        String userId = null;
        String userSecret = null;
        UUID accountId = null;
        OptionsGetOptionStrategyRequest optionsGetOptionStrategyRequest = null;
        StrategyQuotes response = api.getOptionStrategy(userId, userSecret, accountId, optionsGetOptionStrategyRequest);
        // TODO: test validations
    }

    /**
     * Get the options chain
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void getOptionsChainTest() throws ApiException {
        String userId = null;
        String userSecret = null;
        UUID accountId = null;
        UUID symbol = null;
        List<OptionChainInner> response = api.getOptionsChain(userId, userSecret, accountId, symbol);
        // TODO: test validations
    }

    /**
     * Get latest market data of option strategy
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void getOptionsStrategyQuoteTest() throws ApiException {
        String userId = null;
        String userSecret = null;
        UUID accountId = null;
        UUID optionStrategyId = null;
        StrategyQuotes response = api.getOptionsStrategyQuote(userId, userSecret, accountId, optionStrategyId);
        // TODO: test validations
    }

    /**
     * Get the options holdings in the account
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void listOptionHoldingsTest() throws ApiException {
        String userId = null;
        String userSecret = null;
        UUID accountId = null;
        OptionsHoldings response = api.listOptionHoldings(userId, userSecret, accountId);
        // TODO: test validations
    }

    /**
     * Place an option strategy order on the brokerage
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void placeOptionStrategyTest() throws ApiException {
        String userId = null;
        String userSecret = null;
        UUID accountId = null;
        UUID optionStrategyId = null;
        OptionsPlaceOptionStrategyRequest optionsPlaceOptionStrategyRequest = null;
        StrategyOrderRecord response = api.placeOptionStrategy(userId, userSecret, accountId, optionStrategyId, optionsPlaceOptionStrategyRequest);
        // TODO: test validations
    }

}
