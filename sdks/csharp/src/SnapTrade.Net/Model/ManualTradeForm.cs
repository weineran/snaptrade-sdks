/*
 * SnapTrade
 *
 * Connect brokerage accounts to your app for live positions and trading
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: api@snaptrade.com
 * Generated by: https://konfigthis.com
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = SnapTrade.Net.Client.OpenAPIDateConverter;

namespace SnapTrade.Net.Model
{
    /// <summary>
    /// Manual Trade Form
    /// </summary>
    [DataContract(Name = "ManualTradeForm")]
    public partial class ManualTradeForm : IEquatable<ManualTradeForm>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets _Action
        /// </summary>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public ModelAction? _Action { get; set; }

        /// <summary>
        /// Gets or Sets OrderType
        /// </summary>
        [DataMember(Name = "order_type", EmitDefaultValue = false)]
        public OrderType? OrderType { get; set; }

        /// <summary>
        /// Gets or Sets TimeInForce
        /// </summary>
        [DataMember(Name = "time_in_force", EmitDefaultValue = false)]
        public TimeInForce? TimeInForce { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ManualTradeForm" /> class.
        /// </summary>
        /// <param name="accountId">accountId.</param>
        /// <param name="action">action.</param>
        /// <param name="orderType">orderType.</param>
        /// <param name="price">Trade Price if limit or stop limit order.</param>
        /// <param name="stop">Stop Price. If stop loss or stop limit order, the price to trigger the stop.</param>
        /// <param name="timeInForce">timeInForce.</param>
        /// <param name="units">Trade Units. Cannot work with notional value..</param>
        /// <param name="universalSymbolId">universalSymbolId.</param>
        /// <param name="notionalValue">Dollar amount to trade. Cannot work with units. Can only work for market order types and day for time in force. **Only available for Alpaca and Alpaca Paper. Please contact support to get access to place notional trades**.</param>
        public ManualTradeForm(string accountId = default(string), ModelAction? action = default(ModelAction?), OrderType? orderType = default(OrderType?), double? price = default(double?), double? stop = default(double?), TimeInForce? timeInForce = default(TimeInForce?), double units = default(double), string universalSymbolId = default(string), double? notionalValue = default(double?))
        {
            this.AccountId = accountId;
            this._Action = action;
            this.OrderType = orderType;
            this.Price = price;
            this.Stop = stop;
            this.TimeInForce = timeInForce;
            this.Units = units;
            this.UniversalSymbolId = universalSymbolId;
            this.NotionalValue = notionalValue;
        }

        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// Trade Price if limit or stop limit order
        /// </summary>
        /// <value>Trade Price if limit or stop limit order</value>
        [DataMember(Name = "price", EmitDefaultValue = true)]
        public double? Price { get; set; }

        /// <summary>
        /// Stop Price. If stop loss or stop limit order, the price to trigger the stop
        /// </summary>
        /// <value>Stop Price. If stop loss or stop limit order, the price to trigger the stop</value>
        [DataMember(Name = "stop", EmitDefaultValue = true)]
        public double? Stop { get; set; }

        /// <summary>
        /// Trade Units. Cannot work with notional value.
        /// </summary>
        /// <value>Trade Units. Cannot work with notional value.</value>
        [DataMember(Name = "units", EmitDefaultValue = false)]
        public double Units { get; set; }

        /// <summary>
        /// Gets or Sets UniversalSymbolId
        /// </summary>
        [DataMember(Name = "universal_symbol_id", EmitDefaultValue = false)]
        public string UniversalSymbolId { get; set; }

        /// <summary>
        /// Dollar amount to trade. Cannot work with units. Can only work for market order types and day for time in force. **Only available for Alpaca and Alpaca Paper. Please contact support to get access to place notional trades**
        /// </summary>
        /// <value>Dollar amount to trade. Cannot work with units. Can only work for market order types and day for time in force. **Only available for Alpaca and Alpaca Paper. Please contact support to get access to place notional trades**</value>
        [DataMember(Name = "notional_value", EmitDefaultValue = true)]
        public double? NotionalValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ManualTradeForm {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  _Action: ").Append(_Action).Append("\n");
            sb.Append("  OrderType: ").Append(OrderType).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Stop: ").Append(Stop).Append("\n");
            sb.Append("  TimeInForce: ").Append(TimeInForce).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
            sb.Append("  UniversalSymbolId: ").Append(UniversalSymbolId).Append("\n");
            sb.Append("  NotionalValue: ").Append(NotionalValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ManualTradeForm);
        }

        /// <summary>
        /// Returns true if ManualTradeForm instances are equal
        /// </summary>
        /// <param name="input">Instance of ManualTradeForm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManualTradeForm input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this._Action == input._Action ||
                    this._Action.Equals(input._Action)
                ) && 
                (
                    this.OrderType == input.OrderType ||
                    this.OrderType.Equals(input.OrderType)
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.Stop == input.Stop ||
                    (this.Stop != null &&
                    this.Stop.Equals(input.Stop))
                ) && 
                (
                    this.TimeInForce == input.TimeInForce ||
                    this.TimeInForce.Equals(input.TimeInForce)
                ) && 
                (
                    this.Units == input.Units ||
                    this.Units.Equals(input.Units)
                ) && 
                (
                    this.UniversalSymbolId == input.UniversalSymbolId ||
                    (this.UniversalSymbolId != null &&
                    this.UniversalSymbolId.Equals(input.UniversalSymbolId))
                ) && 
                (
                    this.NotionalValue == input.NotionalValue ||
                    (this.NotionalValue != null &&
                    this.NotionalValue.Equals(input.NotionalValue))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this._Action.GetHashCode();
                hashCode = (hashCode * 59) + this.OrderType.GetHashCode();
                if (this.Price != null)
                {
                    hashCode = (hashCode * 59) + this.Price.GetHashCode();
                }
                if (this.Stop != null)
                {
                    hashCode = (hashCode * 59) + this.Stop.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TimeInForce.GetHashCode();
                hashCode = (hashCode * 59) + this.Units.GetHashCode();
                if (this.UniversalSymbolId != null)
                {
                    hashCode = (hashCode * 59) + this.UniversalSymbolId.GetHashCode();
                }
                if (this.NotionalValue != null)
                {
                    hashCode = (hashCode * 59) + this.NotionalValue.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
