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


class ManualTradeForm(
    schemas.DictSchema
):
    """
    This class is auto generated by Konfig (https://konfigthis.com)

    Manual Trade Form
    """


    class MetaOapg:
        
        class properties:
            account_id = schemas.UUIDSchema
        
            @staticmethod
            def action() -> typing.Type['Action']:
                return Action
        
            @staticmethod
            def order_type() -> typing.Type['OrderType']:
                return OrderType
        
            @staticmethod
            def price() -> typing.Type['Price']:
                return Price
        
            @staticmethod
            def stop() -> typing.Type['StopPrice']:
                return StopPrice
        
            @staticmethod
            def time_in_force() -> typing.Type['TimeInForceStrict']:
                return TimeInForceStrict
        
            @staticmethod
            def units() -> typing.Type['UnitsNullable']:
                return UnitsNullable
            universal_symbol_id = schemas.UUIDSchema
        
            @staticmethod
            def notional_value() -> typing.Type['NotionalValueNullable']:
                return NotionalValueNullable
            __annotations__ = {
                "account_id": account_id,
                "action": action,
                "order_type": order_type,
                "price": price,
                "stop": stop,
                "time_in_force": time_in_force,
                "units": units,
                "universal_symbol_id": universal_symbol_id,
                "notional_value": notional_value,
            }
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["account_id"]) -> MetaOapg.properties.account_id: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["action"]) -> 'Action': ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["order_type"]) -> 'OrderType': ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["price"]) -> 'Price': ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["stop"]) -> 'StopPrice': ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["time_in_force"]) -> 'TimeInForceStrict': ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["units"]) -> 'UnitsNullable': ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["universal_symbol_id"]) -> MetaOapg.properties.universal_symbol_id: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["notional_value"]) -> 'NotionalValueNullable': ...
    
    @typing.overload
    def __getitem__(self, name: str) -> schemas.UnsetAnyTypeSchema: ...
    
    def __getitem__(self, name: typing.Union[typing_extensions.Literal["account_id", "action", "order_type", "price", "stop", "time_in_force", "units", "universal_symbol_id", "notional_value", ], str]):
        # dict_instance[name] accessor
        return super().__getitem__(name)
    
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["account_id"]) -> typing.Union[MetaOapg.properties.account_id, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["action"]) -> typing.Union['Action', schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["order_type"]) -> typing.Union['OrderType', schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["price"]) -> typing.Union['Price', schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["stop"]) -> typing.Union['StopPrice', schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["time_in_force"]) -> typing.Union['TimeInForceStrict', schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["units"]) -> typing.Union['UnitsNullable', schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["universal_symbol_id"]) -> typing.Union[MetaOapg.properties.universal_symbol_id, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["notional_value"]) -> typing.Union['NotionalValueNullable', schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: str) -> typing.Union[schemas.UnsetAnyTypeSchema, schemas.Unset]: ...
    
    def get_item_oapg(self, name: typing.Union[typing_extensions.Literal["account_id", "action", "order_type", "price", "stop", "time_in_force", "units", "universal_symbol_id", "notional_value", ], str]):
        return super().get_item_oapg(name)
    

    def __new__(
        cls,
        *args: typing.Union[dict, frozendict.frozendict, ],
        account_id: typing.Union[MetaOapg.properties.account_id, str, uuid.UUID, schemas.Unset] = schemas.unset,
        action: typing.Union['Action', schemas.Unset] = schemas.unset,
        order_type: typing.Union['OrderType', schemas.Unset] = schemas.unset,
        price: typing.Union['Price', schemas.Unset] = schemas.unset,
        stop: typing.Union['StopPrice', schemas.Unset] = schemas.unset,
        time_in_force: typing.Union['TimeInForceStrict', schemas.Unset] = schemas.unset,
        units: typing.Union['UnitsNullable', schemas.Unset] = schemas.unset,
        universal_symbol_id: typing.Union[MetaOapg.properties.universal_symbol_id, str, uuid.UUID, schemas.Unset] = schemas.unset,
        notional_value: typing.Union['NotionalValueNullable', schemas.Unset] = schemas.unset,
        _configuration: typing.Optional[schemas.Configuration] = None,
        **kwargs: typing.Union[schemas.AnyTypeSchema, dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, None, list, tuple, bytes],
    ) -> 'ManualTradeForm':
        return super().__new__(
            cls,
            *args,
            account_id=account_id,
            action=action,
            order_type=order_type,
            price=price,
            stop=stop,
            time_in_force=time_in_force,
            units=units,
            universal_symbol_id=universal_symbol_id,
            notional_value=notional_value,
            _configuration=_configuration,
            **kwargs,
        )

from snaptrade_client.model.action import Action
from snaptrade_client.model.notional_value_nullable import NotionalValueNullable
from snaptrade_client.model.order_type import OrderType
from snaptrade_client.model.price import Price
from snaptrade_client.model.stop_price import StopPrice
from snaptrade_client.model.time_in_force_strict import TimeInForceStrict
from snaptrade_client.model.units_nullable import UnitsNullable
