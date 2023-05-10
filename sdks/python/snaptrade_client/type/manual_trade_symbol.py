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

from snaptrade_client.type.currency import Currency

RequiredManualTradeSymbol = TypedDict("RequiredManualTradeSymbol", {
    })

OptionalManualTradeSymbol = TypedDict("OptionalManualTradeSymbol", {
    "brokerage_symbol_id": str,

    "universal_symbol_id": str,

    "currency": Currency,

    "local_id": str,

    "description": typing.Optional[str],

    "symbol": str,
    }, total=False)

class ManualTradeSymbol(RequiredManualTradeSymbol, OptionalManualTradeSymbol):
    pass
