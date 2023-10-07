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


class OptionStrategy(
    schemas.DictSchema
):
    """
    This class is auto generated by Konfig (https://konfigthis.com)
    """


    class MetaOapg:
        
        class properties:
            id = schemas.UUIDSchema
        
            @staticmethod
            def underlying_symbol_id() -> typing.Type['UniversalSymbol']:
                return UniversalSymbol
            strategy_type = schemas.StrSchema
            number_of_legs = schemas.NumberSchema
        
            @staticmethod
            def legs() -> typing.Type['OptionStrategyLegs']:
                return OptionStrategyLegs
            __annotations__ = {
                "id": id,
                "underlying_symbol_id": underlying_symbol_id,
                "strategy_type": strategy_type,
                "number_of_legs": number_of_legs,
                "legs": legs,
            }
        additional_properties = schemas.AnyTypeSchema
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["id"]) -> MetaOapg.properties.id: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["underlying_symbol_id"]) -> 'UniversalSymbol': ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["strategy_type"]) -> MetaOapg.properties.strategy_type: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["number_of_legs"]) -> MetaOapg.properties.number_of_legs: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["legs"]) -> 'OptionStrategyLegs': ...
    
    @typing.overload
    def __getitem__(self, name: str) -> MetaOapg.additional_properties: ...
    
    def __getitem__(self, name: typing.Union[typing_extensions.Literal["id"], typing_extensions.Literal["underlying_symbol_id"], typing_extensions.Literal["strategy_type"], typing_extensions.Literal["number_of_legs"], typing_extensions.Literal["legs"], str, ]):
        # dict_instance[name] accessor
        return super().__getitem__(name)
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["id"]) -> typing.Union[MetaOapg.properties.id, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["underlying_symbol_id"]) -> typing.Union['UniversalSymbol', schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["strategy_type"]) -> typing.Union[MetaOapg.properties.strategy_type, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["number_of_legs"]) -> typing.Union[MetaOapg.properties.number_of_legs, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["legs"]) -> typing.Union['OptionStrategyLegs', schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: str) -> typing.Union[MetaOapg.additional_properties, schemas.Unset]: ...
    
    def get_item_oapg(self, name: typing.Union[typing_extensions.Literal["id"], typing_extensions.Literal["underlying_symbol_id"], typing_extensions.Literal["strategy_type"], typing_extensions.Literal["number_of_legs"], typing_extensions.Literal["legs"], str, ]):
        return super().get_item_oapg(name)

    def __new__(
        cls,
        *args: typing.Union[dict, frozendict.frozendict, ],
        id: typing.Union[MetaOapg.properties.id, str, uuid.UUID, schemas.Unset] = schemas.unset,
        underlying_symbol_id: typing.Union['UniversalSymbol', schemas.Unset] = schemas.unset,
        strategy_type: typing.Union[MetaOapg.properties.strategy_type, str, schemas.Unset] = schemas.unset,
        number_of_legs: typing.Union[MetaOapg.properties.number_of_legs, decimal.Decimal, int, float, schemas.Unset] = schemas.unset,
        legs: typing.Union['OptionStrategyLegs', schemas.Unset] = schemas.unset,
        _configuration: typing.Optional[schemas.Configuration] = None,
        **kwargs: typing.Union[MetaOapg.additional_properties, dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, bool, None, list, tuple, bytes, io.FileIO, io.BufferedReader, ],
    ) -> 'OptionStrategy':
        return super().__new__(
            cls,
            *args,
            id=id,
            underlying_symbol_id=underlying_symbol_id,
            strategy_type=strategy_type,
            number_of_legs=number_of_legs,
            legs=legs,
            _configuration=_configuration,
            **kwargs,
        )

from snaptrade_client.model.currency import Currency
from snaptrade_client.model.exchange import Exchange
from snaptrade_client.model.option_strategy_legs import OptionStrategyLegs
from snaptrade_client.model.security_type import SecurityType
from snaptrade_client.model.universal_symbol import UniversalSymbol
