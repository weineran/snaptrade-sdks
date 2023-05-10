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

from snaptrade_client.type.brokerage_authorization import BrokerageAuthorization
from snaptrade_client.type.universal_symbol import UniversalSymbol

RequiredBrokerageSymbol = TypedDict("RequiredBrokerageSymbol", {
    })

OptionalBrokerageSymbol = TypedDict("OptionalBrokerageSymbol", {
    "id": str,

    "symbol": UniversalSymbol,

    "brokerage_authorization": BrokerageAuthorization,

    "description": str,

    "allows_fractional_units": typing.Optional[bool],
    }, total=False)

class BrokerageSymbol(RequiredBrokerageSymbol, OptionalBrokerageSymbol):
    pass
