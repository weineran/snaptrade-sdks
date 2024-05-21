# coding: utf-8

"""
    SnapTrade

    Connect brokerage accounts to your app for live positions and trading

    The version of the OpenAPI document: 1.0.0
    Contact: api@snaptrade.com
    Created by: https://snaptrade.com/
"""

from datetime import date, datetime  # noqa: F401
import decimal  # noqa: F401
import functools  # noqa: F401
import io  # noqa: F401
import re  # noqa: F401
import typing  # noqa: F401
import typing_extensions  # noqa: F401
import uuid  # noqa: F401

import frozendict  # noqa: F401

from snaptrade_client import schemas  # noqa: F401


class OrderTypeStrict(
    schemas.EnumBase,
    schemas.StrSchema
):
    """
    This class is auto generated by Konfig (https://konfigthis.com)

    Order Type
    """


    class MetaOapg:
        enum_value_to_name = {
            "Limit": "LIMIT",
            "Market": "MARKET",
            "StopLimit": "STOP_LIMIT",
            "StopLoss": "STOP_LOSS",
        }
    
    @schemas.classproperty
    def LIMIT(cls):
        return cls("Limit")
    
    @schemas.classproperty
    def MARKET(cls):
        return cls("Market")
    
    @schemas.classproperty
    def STOP_LIMIT(cls):
        return cls("StopLimit")
    
    @schemas.classproperty
    def STOP_LOSS(cls):
        return cls("StopLoss")
