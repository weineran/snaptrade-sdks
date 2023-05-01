# coding: utf-8

"""
    SnapTrade

    Connect brokerage accounts to your app for live positions and trading

    The version of the OpenAPI document: 1.0.0
    Contact: api@snaptrade.com
    Generated by: https://konfigthis.com
"""

from dataclasses import dataclass
import typing_extensions
import urllib3
import json
from urllib3._collections import HTTPHeaderDict

from snaptrade_client import api_client, exceptions
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

from snaptrade_client.model.target_asset import TargetAsset

# Path params
PortfolioGroupIdSchema = schemas.UUIDSchema
TargetAssetIdSchema = schemas.UUIDSchema
RequestRequiredPathParams = typing_extensions.TypedDict(
    'RequestRequiredPathParams',
    {
        'portfolioGroupId': typing.Union[PortfolioGroupIdSchema, str, uuid.UUID, ],
        'targetAssetId': typing.Union[TargetAssetIdSchema, str, uuid.UUID, ],
    }
)
RequestOptionalPathParams = typing_extensions.TypedDict(
    'RequestOptionalPathParams',
    {
    },
    total=False
)


class RequestPathParams(RequestRequiredPathParams, RequestOptionalPathParams):
    pass


request_path_portfolio_group_id = api_client.PathParameter(
    name="portfolioGroupId",
    style=api_client.ParameterStyle.SIMPLE,
    schema=PortfolioGroupIdSchema,
    required=True,
)
request_path_target_asset_id = api_client.PathParameter(
    name="targetAssetId",
    style=api_client.ParameterStyle.SIMPLE,
    schema=TargetAssetIdSchema,
    required=True,
)
# body param
SchemaForRequestBodyApplicationJson = TargetAsset


request_body_target_asset = api_client.RequestBody(
    content={
        'application/json': api_client.MediaType(
            schema=SchemaForRequestBodyApplicationJson),
    },
    required=True,
)
SchemaFor200ResponseBodyApplicationJson = TargetAsset


@dataclass
class ApiResponseFor200(api_client.ApiResponse):
    body: typing.Union[
        SchemaFor200ResponseBodyApplicationJson,
    ]


_response_for_200 = api_client.OpenApiResponse(
    response_cls=ApiResponseFor200,
    content={
        'application/json': api_client.MediaType(
            schema=SchemaFor200ResponseBodyApplicationJson),
    },
)


@dataclass
class ApiResponseFor400(api_client.ApiResponse):
    body: schemas.Unset = schemas.unset


_response_for_400 = api_client.OpenApiResponse(
    response_cls=ApiResponseFor400,
)


@dataclass
class ApiResponseFor404(api_client.ApiResponse):
    body: schemas.Unset = schemas.unset


_response_for_404 = api_client.OpenApiResponse(
    response_cls=ApiResponseFor404,
)


@dataclass
class ApiResponseForDefault(api_client.ApiResponse):
    body: schemas.Unset = schemas.unset


_response_for_default = api_client.OpenApiResponse(
    response_cls=ApiResponseForDefault,
)
_all_accept_content_types = (
    'application/json',
)


class BaseApi(api_client.Api):

    def _update_portfolio_target_by_id_oapg(
        self,
        skip_deserialization: bool = True,
        timeout: typing.Optional[typing.Union[int, typing.Tuple]] = None,
        accept_content_types: typing.Tuple[str] = _all_accept_content_types,
        content_type: str = 'application/json',
        body: typing.Union[SchemaForRequestBodyApplicationJson, None, dict, list, schemas.Primitive] = None,
        path_params: typing.Union[RequestPathParams, dict] = {},
    ) -> typing.Union[
        ApiResponseFor200,
        ApiResponseForDefault,
        api_client.ApiResponseWithoutDeserialization,
    ]:
        """
        Update a TargetAsset under the specified PortfolioGroup.
        :param skip_deserialization: If true then api_response.response will be set but
            api_response.body and api_response.headers will not be deserialized into schema
            class instances
        """
        self._verify_typed_dict_inputs_oapg(RequestPathParams, path_params)
        used_path = path.value

        _path_params = {}
        for parameter in (
            request_path_portfolio_group_id,
            request_path_target_asset_id,
        ):
            parameter_data = path_params.get(parameter.name, schemas.unset)
            if parameter_data is schemas.unset:
                continue
            serialized_data = parameter.serialize(parameter_data)
            _path_params.update(serialized_data)

        for k, v in _path_params.items():
            used_path = used_path.replace('{%s}' % k, v)

        _headers = HTTPHeaderDict()
        # TODO add cookie handling
        if accept_content_types:
            for accept_content_type in accept_content_types:
                _headers.add('Accept', accept_content_type)

        if body is schemas.unset:
            raise exceptions.ApiValueError(
                'The required body parameter has an invalid value of: unset. Set a valid value instead')
        _fields = None
        _body = None
        serialized_data = request_body_target_asset.serialize(body, content_type)
        _headers.add('Content-Type', content_type)
        if 'fields' in serialized_data:
            _fields = serialized_data['fields']
        elif 'body' in serialized_data:
            _body = serialized_data['body']
        response = self.api_client.call_api(
            resource_path=used_path,
            method='patch'.upper(),
            headers=_headers,
            fields=_fields,
            serialized_body=_body,
            body=body,
            auth_settings=_auth,
            timeout=timeout,
        )

        response_for_status = _status_code_to_response.get(str(response.http_response.status))
        if response_for_status:
            api_response = response_for_status.deserialize(
                                                   response,
                                                   self.api_client.configuration,
                                                   skip_deserialization=skip_deserialization
                                               )
        else:
            default_response = _status_code_to_response.get('default')
            if default_response:
                api_response = default_response.deserialize(
                                                    response,
                                                    self.api_client.configuration,
                                                    skip_deserialization=skip_deserialization
                                                )
            else:
                api_response = api_client.ApiResponseWithoutDeserialization(
                    response=response.http_response,
                    round_trip_time=response.round_trip_time,
                    status=response.http_response.status,
                    headers=response.http_response.headers,
                )

        if not 200 <= api_response.status <= 299:
            raise exceptions.ApiException(api_response=api_response)

        return api_response


class UpdatePortfolioTargetById(BaseApi):
    # this class is used by api classes that refer to endpoints with operationId fn names

    def update_portfolio_target_by_id(
        self,
        body: typing.Union[SchemaForRequestBodyApplicationJson, None, dict, list, schemas.Primitive] = None,
        portfolio_group_id: typing.Any = None,
        target_asset_id: typing.Any = None,
        id: typing.Any = None,
        symbol: typing.Any = None,
        percent: typing.Any = None,
        is_supported: typing.Any = None,
        is_excluded: typing.Any = None,
        path_params: typing.Union[RequestPathParams, dict] = {},
    ) -> typing.Union[
        ApiResponseFor200,
        ApiResponseForDefault,
        api_client.ApiResponseWithoutDeserialization,
    ]:
        if body is None:
            body = {}
        if isinstance(body, dict) and id is not None:
            body["id"] = id
        if isinstance(body, dict) and symbol is not None:
            body["symbol"] = symbol
        if isinstance(body, dict) and percent is not None:
            body["percent"] = percent
        if isinstance(body, dict) and is_supported is not None:
            body["is_supported"] = is_supported
        if isinstance(body, dict) and is_excluded is not None:
            body["is_excluded"] = is_excluded
        if portfolio_group_id is not None:
            path_params["portfolioGroupId"] = portfolio_group_id
        if target_asset_id is not None:
            path_params["targetAssetId"] = target_asset_id
        return self._update_portfolio_target_by_id_oapg(
            body=body,
            path_params=path_params,
        )


class ApiForpatch(BaseApi):
    # this class is used by api classes that refer to endpoints by path and http method names

    def patch(
        self,
        body: typing.Union[SchemaForRequestBodyApplicationJson, None, dict, list, schemas.Primitive] = None,
        portfolio_group_id: typing.Any = None,
        target_asset_id: typing.Any = None,
        id: typing.Any = None,
        symbol: typing.Any = None,
        percent: typing.Any = None,
        is_supported: typing.Any = None,
        is_excluded: typing.Any = None,
        path_params: typing.Union[RequestPathParams, dict] = {},
    ) -> typing.Union[
        ApiResponseFor200,
        ApiResponseForDefault,
        api_client.ApiResponseWithoutDeserialization,
    ]:
        if body is None:
            body = {}
        if isinstance(body, dict) and id is not None:
            body["id"] = id
        if isinstance(body, dict) and symbol is not None:
            body["symbol"] = symbol
        if isinstance(body, dict) and percent is not None:
            body["percent"] = percent
        if isinstance(body, dict) and is_supported is not None:
            body["is_supported"] = is_supported
        if isinstance(body, dict) and is_excluded is not None:
            body["is_excluded"] = is_excluded
        if portfolio_group_id is not None:
            path_params["portfolioGroupId"] = portfolio_group_id
        if target_asset_id is not None:
            path_params["targetAssetId"] = target_asset_id
        return self._update_portfolio_target_by_id_oapg(
            body=body,
            path_params=path_params,
        )


