# coding: utf-8

"""
    SnapTrade

    Connect brokerage accounts to your app for live positions and trading

    The version of the OpenAPI document: 1.0.0
    Contact: api@snaptrade.com
    Generated by: https://konfigthis.com
"""

from datetime import datetime, date
import typing
from enum import Enum
from typing_extensions import TypedDict, Literal

from snaptrade_client.type.manual_trade import ManualTrade
from snaptrade_client.type.manual_trade_balance import ManualTradeBalance

RequiredManualTradeAndImpact = TypedDict("RequiredManualTradeAndImpact", {
    })

OptionalManualTradeAndImpact = TypedDict("OptionalManualTradeAndImpact", {
    "trade": ManualTrade,

    "trade_impacts": typing.List[ManualTrade],

    "combined_remaining_balance": ManualTradeBalance,
    }, total=False)

class ManualTradeAndImpact(RequiredManualTradeAndImpact, OptionalManualTradeAndImpact):
    pass
