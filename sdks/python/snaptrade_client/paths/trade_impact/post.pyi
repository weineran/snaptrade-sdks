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

from snaptrade_client.model.model400_failed_request_response import Model400FailedRequestResponse
from snaptrade_client.model.manual_trade_and_impact import ManualTradeAndImpact
from snaptrade_client.model.model403_failed_request_response import Model403FailedRequestResponse
from snaptrade_client.model.manual_trade_form import ManualTradeForm

# Query params
UserIdSchema = schemas.StrSchema
UserSecretSchema = schemas.StrSchema
RequestRequiredQueryParams = typing_extensions.TypedDict(
    'RequestRequiredQueryParams',
    {
        'userId': typing.Union[UserIdSchema, str, ],
        'userSecret': typing.Union[UserSecretSchema, str, ],
    }
)
RequestOptionalQueryParams = typing_extensions.TypedDict(
    'RequestOptionalQueryParams',
    {
    },
    total=False
)


class RequestQueryParams(RequestRequiredQueryParams, RequestOptionalQueryParams):
    pass


request_query_user_id = api_client.QueryParameter(
    name="userId",
    style=api_client.ParameterStyle.FORM,
    schema=UserIdSchema,
    required=True,
    explode=True,
)
request_query_user_secret = api_client.QueryParameter(
    name="userSecret",
    style=api_client.ParameterStyle.FORM,
    schema=UserSecretSchema,
    required=True,
    explode=True,
)
# body param
SchemaForRequestBodyApplicationJson = ManualTradeForm


request_body_manual_trade_form = api_client.RequestBody(
    content={
        'application/json': api_client.MediaType(
            schema=SchemaForRequestBodyApplicationJson),
    },
    required=True,
)
SchemaFor200ResponseBodyApplicationJson = ManualTradeAndImpact


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
SchemaFor400ResponseBodyApplicationJson = Model400FailedRequestResponse


@dataclass
class ApiResponseFor400(api_client.ApiResponse):
    body: typing.Union[
        SchemaFor400ResponseBodyApplicationJson,
    ]


_response_for_400 = api_client.OpenApiResponse(
    response_cls=ApiResponseFor400,
    content={
        'application/json': api_client.MediaType(
            schema=SchemaFor400ResponseBodyApplicationJson),
    },
)
SchemaFor403ResponseBodyApplicationJson = Model403FailedRequestResponse


@dataclass
class ApiResponseFor403(api_client.ApiResponse):
    body: typing.Union[
        SchemaFor403ResponseBodyApplicationJson,
    ]


_response_for_403 = api_client.OpenApiResponse(
    response_cls=ApiResponseFor403,
    content={
        'application/json': api_client.MediaType(
            schema=SchemaFor403ResponseBodyApplicationJson),
    },
)


@dataclass
class ApiResponseFor500(api_client.ApiResponse):
    body: schemas.Unset = schemas.unset


_response_for_500 = api_client.OpenApiResponse(
    response_cls=ApiResponseFor500,
)
_all_accept_content_types = (
    'application/json',
)


class BaseApi(api_client.Api):

    def _get_order_impact_oapg(
        self,
        skip_deserialization: bool = True,
        timeout: typing.Optional[typing.Union[int, typing.Tuple]] = None,
        accept_content_types: typing.Tuple[str] = _all_accept_content_types,
        content_type: str = 'application/json',
        body: typing.Union[SchemaForRequestBodyApplicationJson, None, dict, list, schemas.Primitive] = None,
        query_params: typing.Union[RequestQueryParams, dict] = {},
    ) -> typing.Union[
        ApiResponseFor200,
        api_client.ApiResponseWithoutDeserialization,
    ]:
        """
        Check impact of trades on account.
        :param skip_deserialization: If true then api_response.response will be set but
            api_response.body and api_response.headers will not be deserialized into schema
            class instances
        """
        self._verify_typed_dict_inputs_oapg(RequestQueryParams, query_params)
        used_path = path.value

        prefix_separator_iterator = None
        for parameter in (
            request_query_user_id,
            request_query_user_secret,
        ):
            parameter_data = query_params.get(parameter.name, schemas.unset)
            if parameter_data is schemas.unset:
                continue
            if prefix_separator_iterator is None:
                prefix_separator_iterator = parameter.get_prefix_separator_iterator()
            serialized_data = parameter.serialize(parameter_data, prefix_separator_iterator)
            for serialized_value in serialized_data.values():
                used_path += serialized_value

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
        serialized_data = request_body_manual_trade_form.serialize(body, content_type)
        _headers.add('Content-Type', content_type)
        if 'fields' in serialized_data:
            _fields = serialized_data['fields']
        elif 'body' in serialized_data:
            _body = serialized_data['body']
        response = self.api_client.call_api(
            resource_path=used_path,
            method='post'.upper(),
            headers=_headers,
            fields=_fields,
            serialized_body=_body,
            body=body,
            auth_settings=_auth,
            prefix_separator_iterator=prefix_separator_iterator,
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
            # If response data is JSON then deserialize for SDK consumer convenience
            is_json = api_client.JSONDetector._content_type_is_json(response.http_response.headers.get('Content-Type', ''))
            api_response = api_client.ApiResponseWithoutDeserialization(
                body=json.loads(response.http_response.data) if is_json else response.http_response.data,
                response=response.http_response,
                round_trip_time=response.round_trip_time,
                status=response.http_response.status,
                headers=response.http_response.headers,
            )

        if not 200 <= api_response.status <= 299:
            raise exceptions.ApiException(api_response=api_response)

        return api_response


class GetOrderImpact(BaseApi):
    # this class is used by api classes that refer to endpoints with operationId fn names

    def get_order_impact(
        self,
        body: typing.Union[SchemaForRequestBodyApplicationJson, None, dict, list, schemas.Primitive] = None,
        user_id: typing.Any = None,
        user_secret: typing.Any = None,
        account_id: typing.Any = None,
        action: typing.Any = None,
        order_type: typing.Any = None,
        price: typing.Any = None,
        stop: typing.Any = None,
        time_in_force: typing.Any = None,
        units: typing.Any = None,
        universal_symbol_id: typing.Any = None,
        query_params: typing.Union[RequestQueryParams, dict] = {},
    ) -> typing.Union[
        ApiResponseFor200,
        api_client.ApiResponseWithoutDeserialization,
    ]:
        if body is None:
            body = {}
        if isinstance(body, dict) and account_id is not None:
            body["account_id"] = account_id
        if isinstance(body, dict) and action is not None:
            body["action"] = action
        if isinstance(body, dict) and order_type is not None:
            body["order_type"] = order_type
        if isinstance(body, dict) and price is not None:
            body["price"] = price
        if isinstance(body, dict) and stop is not None:
            body["stop"] = stop
        if isinstance(body, dict) and time_in_force is not None:
            body["time_in_force"] = time_in_force
        if isinstance(body, dict) and units is not None:
            body["units"] = units
        if isinstance(body, dict) and universal_symbol_id is not None:
            body["universal_symbol_id"] = universal_symbol_id
        if user_id is not None:
            query_params["userId"] = user_id
        if user_secret is not None:
            query_params["userSecret"] = user_secret
        return self._get_order_impact_oapg(
            body=body,
            query_params=query_params,
        )


class ApiForpost(BaseApi):
    # this class is used by api classes that refer to endpoints by path and http method names

    def post(
        self,
        body: typing.Union[SchemaForRequestBodyApplicationJson, None, dict, list, schemas.Primitive] = None,
        user_id: typing.Any = None,
        user_secret: typing.Any = None,
        account_id: typing.Any = None,
        action: typing.Any = None,
        order_type: typing.Any = None,
        price: typing.Any = None,
        stop: typing.Any = None,
        time_in_force: typing.Any = None,
        units: typing.Any = None,
        universal_symbol_id: typing.Any = None,
        query_params: typing.Union[RequestQueryParams, dict] = {},
    ) -> typing.Union[
        ApiResponseFor200,
        api_client.ApiResponseWithoutDeserialization,
    ]:
        if body is None:
            body = {}
        if isinstance(body, dict) and account_id is not None:
            body["account_id"] = account_id
        if isinstance(body, dict) and action is not None:
            body["action"] = action
        if isinstance(body, dict) and order_type is not None:
            body["order_type"] = order_type
        if isinstance(body, dict) and price is not None:
            body["price"] = price
        if isinstance(body, dict) and stop is not None:
            body["stop"] = stop
        if isinstance(body, dict) and time_in_force is not None:
            body["time_in_force"] = time_in_force
        if isinstance(body, dict) and units is not None:
            body["units"] = units
        if isinstance(body, dict) and universal_symbol_id is not None:
            body["universal_symbol_id"] = universal_symbol_id
        if user_id is not None:
            query_params["userId"] = user_id
        if user_secret is not None:
            query_params["userSecret"] = user_secret
        return self._get_order_impact_oapg(
            body=body,
            query_params=query_params,
        )


