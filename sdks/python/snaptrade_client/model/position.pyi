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


class Position(
    schemas.DictSchema
):
    """
    This class is auto generated by Konfig (https://konfigthis.com)

    Account Position
    """


    class MetaOapg:
        
        class properties:
        
            @staticmethod
            def symbol() -> typing.Type['PositionSymbol']:
                return PositionSymbol
            
            
            class units(
                schemas.NumberBase,
                schemas.NoneBase,
                schemas.Schema,
                schemas.NoneDecimalMixin
            ):
            
            
                def __new__(
                    cls,
                    *args: typing.Union[None, decimal.Decimal, int, float, ],
                    _configuration: typing.Optional[schemas.Configuration] = None,
                ) -> 'units':
                    return super().__new__(
                        cls,
                        *args,
                        _configuration=_configuration,
                    )
            
            
            class price(
                schemas.NumberBase,
                schemas.NoneBase,
                schemas.Schema,
                schemas.NoneDecimalMixin
            ):
            
            
                def __new__(
                    cls,
                    *args: typing.Union[None, decimal.Decimal, int, float, ],
                    _configuration: typing.Optional[schemas.Configuration] = None,
                ) -> 'price':
                    return super().__new__(
                        cls,
                        *args,
                        _configuration=_configuration,
                    )
            
            
            class open_pnl(
                schemas.NumberBase,
                schemas.NoneBase,
                schemas.Schema,
                schemas.NoneDecimalMixin
            ):
            
            
                def __new__(
                    cls,
                    *args: typing.Union[None, decimal.Decimal, int, float, ],
                    _configuration: typing.Optional[schemas.Configuration] = None,
                ) -> 'open_pnl':
                    return super().__new__(
                        cls,
                        *args,
                        _configuration=_configuration,
                    )
            
            
            class fractional_units(
                schemas.NumberBase,
                schemas.NoneBase,
                schemas.Schema,
                schemas.NoneDecimalMixin
            ):
            
            
                def __new__(
                    cls,
                    *args: typing.Union[None, decimal.Decimal, int, float, ],
                    _configuration: typing.Optional[schemas.Configuration] = None,
                ) -> 'fractional_units':
                    return super().__new__(
                        cls,
                        *args,
                        _configuration=_configuration,
                    )
            
            
            class average_purchase_price(
                schemas.NumberBase,
                schemas.NoneBase,
                schemas.Schema,
                schemas.NoneDecimalMixin
            ):
            
            
                def __new__(
                    cls,
                    *args: typing.Union[None, decimal.Decimal, int, float, ],
                    _configuration: typing.Optional[schemas.Configuration] = None,
                ) -> 'average_purchase_price':
                    return super().__new__(
                        cls,
                        *args,
                        _configuration=_configuration,
                    )
            __annotations__ = {
                "symbol": symbol,
                "units": units,
                "price": price,
                "open_pnl": open_pnl,
                "fractional_units": fractional_units,
                "average_purchase_price": average_purchase_price,
            }
        additional_properties = schemas.AnyTypeSchema
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["symbol"]) -> 'PositionSymbol': ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["units"]) -> MetaOapg.properties.units: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["price"]) -> MetaOapg.properties.price: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["open_pnl"]) -> MetaOapg.properties.open_pnl: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["fractional_units"]) -> MetaOapg.properties.fractional_units: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["average_purchase_price"]) -> MetaOapg.properties.average_purchase_price: ...
    
    @typing.overload
    def __getitem__(self, name: str) -> MetaOapg.additional_properties: ...
    
    def __getitem__(self, name: typing.Union[typing_extensions.Literal["symbol"], typing_extensions.Literal["units"], typing_extensions.Literal["price"], typing_extensions.Literal["open_pnl"], typing_extensions.Literal["fractional_units"], typing_extensions.Literal["average_purchase_price"], str, ]):
        # dict_instance[name] accessor
        return super().__getitem__(name)
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["symbol"]) -> typing.Union['PositionSymbol', schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["units"]) -> typing.Union[MetaOapg.properties.units, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["price"]) -> typing.Union[MetaOapg.properties.price, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["open_pnl"]) -> typing.Union[MetaOapg.properties.open_pnl, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["fractional_units"]) -> typing.Union[MetaOapg.properties.fractional_units, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["average_purchase_price"]) -> typing.Union[MetaOapg.properties.average_purchase_price, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: str) -> typing.Union[MetaOapg.additional_properties, schemas.Unset]: ...
    
    def get_item_oapg(self, name: typing.Union[typing_extensions.Literal["symbol"], typing_extensions.Literal["units"], typing_extensions.Literal["price"], typing_extensions.Literal["open_pnl"], typing_extensions.Literal["fractional_units"], typing_extensions.Literal["average_purchase_price"], str, ]):
        return super().get_item_oapg(name)

    def __new__(
        cls,
        *args: typing.Union[dict, frozendict.frozendict, ],
        symbol: typing.Union['PositionSymbol', schemas.Unset] = schemas.unset,
        units: typing.Union[MetaOapg.properties.units, None, decimal.Decimal, int, float, schemas.Unset] = schemas.unset,
        price: typing.Union[MetaOapg.properties.price, None, decimal.Decimal, int, float, schemas.Unset] = schemas.unset,
        open_pnl: typing.Union[MetaOapg.properties.open_pnl, None, decimal.Decimal, int, float, schemas.Unset] = schemas.unset,
        fractional_units: typing.Union[MetaOapg.properties.fractional_units, None, decimal.Decimal, int, float, schemas.Unset] = schemas.unset,
        average_purchase_price: typing.Union[MetaOapg.properties.average_purchase_price, None, decimal.Decimal, int, float, schemas.Unset] = schemas.unset,
        _configuration: typing.Optional[schemas.Configuration] = None,
        **kwargs: typing.Union[MetaOapg.additional_properties, dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, bool, None, list, tuple, bytes, io.FileIO, io.BufferedReader, ],
    ) -> 'Position':
        return super().__new__(
            cls,
            *args,
            symbol=symbol,
            units=units,
            price=price,
            open_pnl=open_pnl,
            fractional_units=fractional_units,
            average_purchase_price=average_purchase_price,
            _configuration=_configuration,
            **kwargs,
        )

from snaptrade_client.model.currency import Currency
from snaptrade_client.model.exchange import Exchange
from snaptrade_client.model.position_symbol import PositionSymbol
from snaptrade_client.model.security_type import SecurityType
from snaptrade_client.model.universal_symbol import UniversalSymbol
