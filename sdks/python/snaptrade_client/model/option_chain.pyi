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


class OptionChain(
    schemas.ListSchema
):
    """NOTE:
    This class is auto generated by Konfig (https://konfigthis.com)

    chain of options
    """


    class MetaOapg:
        
        @staticmethod
        def items() -> typing.Type['OptionChainItem']:
            return OptionChainItem

    def __new__(
        cls,
        arg: typing.Union[typing.Tuple['OptionChainItem'], typing.List['OptionChainItem']],
        _configuration: typing.Optional[schemas.Configuration] = None,
    ) -> 'OptionChain':
        return super().__new__(
            cls,
            arg,
            _configuration=_configuration,
        )

    def __getitem__(self, i: int) -> 'OptionChainItem':
        return super().__getitem__(i)

from snaptrade_client.model.option_chain_item import OptionChainItem
from snaptrade_client.model.option_chain_item_chain_per_root import OptionChainItemChainPerRoot
