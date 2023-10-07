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
    /// Strategy order record
    /// </summary>
    [DataContract(Name = "StrategyOrderRecord")]
    public partial class StrategyOrderRecord : IEquatable<StrategyOrderRecord>, IValidatableObject
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum PENDING for value: PENDING
            /// </summary>
            [EnumMember(Value = "PENDING")]
            PENDING = 1,

            /// <summary>
            /// Enum ACCEPTED for value: ACCEPTED
            /// </summary>
            [EnumMember(Value = "ACCEPTED")]
            ACCEPTED = 2,

            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            [EnumMember(Value = "FAILED")]
            FAILED = 3,

            /// <summary>
            /// Enum REJECTED for value: REJECTED
            /// </summary>
            [EnumMember(Value = "REJECTED")]
            REJECTED = 4,

            /// <summary>
            /// Enum CANCELED for value: CANCELED
            /// </summary>
            [EnumMember(Value = "CANCELED")]
            CANCELED = 5,

            /// <summary>
            /// Enum PARTIALCANCELED for value: PARTIAL_CANCELED
            /// </summary>
            [EnumMember(Value = "PARTIAL_CANCELED")]
            PARTIALCANCELED = 6,

            /// <summary>
            /// Enum CANCELPENDING for value: CANCEL_PENDING
            /// </summary>
            [EnumMember(Value = "CANCEL_PENDING")]
            CANCELPENDING = 7,

            /// <summary>
            /// Enum EXECUTED for value: EXECUTED
            /// </summary>
            [EnumMember(Value = "EXECUTED")]
            EXECUTED = 8,

            /// <summary>
            /// Enum PARTIAL for value: PARTIAL
            /// </summary>
            [EnumMember(Value = "PARTIAL")]
            PARTIAL = 9,

            /// <summary>
            /// Enum REPLACEPENDING for value: REPLACE_PENDING
            /// </summary>
            [EnumMember(Value = "REPLACE_PENDING")]
            REPLACEPENDING = 10,

            /// <summary>
            /// Enum REPLACED for value: REPLACED
            /// </summary>
            [EnumMember(Value = "REPLACED")]
            REPLACED = 11,

            /// <summary>
            /// Enum STOPPED for value: STOPPED
            /// </summary>
            [EnumMember(Value = "STOPPED")]
            STOPPED = 12,

            /// <summary>
            /// Enum SUSPENDED for value: SUSPENDED
            /// </summary>
            [EnumMember(Value = "SUSPENDED")]
            SUSPENDED = 13,

            /// <summary>
            /// Enum EXPIRED for value: EXPIRED
            /// </summary>
            [EnumMember(Value = "EXPIRED")]
            EXPIRED = 14,

            /// <summary>
            /// Enum QUEUED for value: QUEUED
            /// </summary>
            [EnumMember(Value = "QUEUED")]
            QUEUED = 15,

            /// <summary>
            /// Enum TRIGGERED for value: TRIGGERED
            /// </summary>
            [EnumMember(Value = "TRIGGERED")]
            TRIGGERED = 16,

            /// <summary>
            /// Enum ACTIVATED for value: ACTIVATED
            /// </summary>
            [EnumMember(Value = "ACTIVATED")]
            ACTIVATED = 17,

            /// <summary>
            /// Enum PENDINGRISKREVIEW for value: PENDING_RISK_REVIEW
            /// </summary>
            [EnumMember(Value = "PENDING_RISK_REVIEW")]
            PENDINGRISKREVIEW = 18,

            /// <summary>
            /// Enum CONTINGENTORDER for value: CONTINGENT_ORDER
            /// </summary>
            [EnumMember(Value = "CONTINGENT_ORDER")]
            CONTINGENTORDER = 19

        }


        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Defines OrderType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrderTypeEnum
        {
            /// <summary>
            /// Enum Limit for value: Limit
            /// </summary>
            [EnumMember(Value = "Limit")]
            Limit = 1,

            /// <summary>
            /// Enum Market for value: Market
            /// </summary>
            [EnumMember(Value = "Market")]
            Market = 2,

            /// <summary>
            /// Enum NetDebit for value: NetDebit
            /// </summary>
            [EnumMember(Value = "NetDebit")]
            NetDebit = 3,

            /// <summary>
            /// Enum NetCredit for value: NetCredit
            /// </summary>
            [EnumMember(Value = "NetCredit")]
            NetCredit = 4

        }


        /// <summary>
        /// Gets or Sets OrderType
        /// </summary>
        [DataMember(Name = "order_type", EmitDefaultValue = false)]
        public OrderTypeEnum? OrderType { get; set; }
        /// <summary>
        /// Defines TimeInForce
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TimeInForceEnum
        {
            /// <summary>
            /// Enum DAY for value: DAY
            /// </summary>
            [EnumMember(Value = "DAY")]
            DAY = 1,

            /// <summary>
            /// Enum GTC for value: GTC
            /// </summary>
            [EnumMember(Value = "GTC")]
            GTC = 2

        }


        /// <summary>
        /// Gets or Sets TimeInForce
        /// </summary>
        [DataMember(Name = "time_in_force", EmitDefaultValue = false)]
        public TimeInForceEnum? TimeInForce { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StrategyOrderRecord" /> class.
        /// </summary>
        /// <param name="strategy">strategy.</param>
        /// <param name="status">status.</param>
        /// <param name="filledQuantity">filledQuantity.</param>
        /// <param name="openQuantity">openQuantity.</param>
        /// <param name="closedQuantity">closedQuantity.</param>
        /// <param name="orderType">orderType.</param>
        /// <param name="timeInForce">timeInForce.</param>
        /// <param name="limitPrice">Trade Price if limit or stop limit order.</param>
        /// <param name="executionPrice">Trade Price if limit or stop limit order.</param>
        /// <param name="timePlaced">Time.</param>
        /// <param name="timeUpdated">Time.</param>
        public StrategyOrderRecord(OptionStrategy strategy = default(OptionStrategy), StatusEnum? status = default(StatusEnum?), double filledQuantity = default(double), double openQuantity = default(double), double closedQuantity = default(double), OrderTypeEnum? orderType = default(OrderTypeEnum?), TimeInForceEnum? timeInForce = default(TimeInForceEnum?), double? limitPrice = default(double?), double? executionPrice = default(double?), string timePlaced = default(string), string timeUpdated = default(string)) : base()
        {
            this.Strategy = strategy;
            this.Status = status;
            this.FilledQuantity = filledQuantity;
            this.OpenQuantity = openQuantity;
            this.ClosedQuantity = closedQuantity;
            this.OrderType = orderType;
            this.TimeInForce = timeInForce;
            this.LimitPrice = limitPrice;
            this.ExecutionPrice = executionPrice;
            this.TimePlaced = timePlaced;
            this.TimeUpdated = timeUpdated;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Strategy
        /// </summary>
        [DataMember(Name = "strategy", EmitDefaultValue = false)]
        public OptionStrategy Strategy { get; set; }

        /// <summary>
        /// Gets or Sets FilledQuantity
        /// </summary>
        [DataMember(Name = "filled_quantity", EmitDefaultValue = false)]
        public double FilledQuantity { get; set; }

        /// <summary>
        /// Gets or Sets OpenQuantity
        /// </summary>
        [DataMember(Name = "open_quantity", EmitDefaultValue = false)]
        public double OpenQuantity { get; set; }

        /// <summary>
        /// Gets or Sets ClosedQuantity
        /// </summary>
        [DataMember(Name = "closed_quantity", EmitDefaultValue = false)]
        public double ClosedQuantity { get; set; }

        /// <summary>
        /// Trade Price if limit or stop limit order
        /// </summary>
        /// <value>Trade Price if limit or stop limit order</value>
        [DataMember(Name = "limit_price", EmitDefaultValue = true)]
        public double? LimitPrice { get; set; }

        /// <summary>
        /// Trade Price if limit or stop limit order
        /// </summary>
        /// <value>Trade Price if limit or stop limit order</value>
        [DataMember(Name = "execution_price", EmitDefaultValue = true)]
        public double? ExecutionPrice { get; set; }

        /// <summary>
        /// Time
        /// </summary>
        /// <value>Time</value>
        [DataMember(Name = "time_placed", EmitDefaultValue = false)]
        public string TimePlaced { get; set; }

        /// <summary>
        /// Time
        /// </summary>
        /// <value>Time</value>
        [DataMember(Name = "time_updated", EmitDefaultValue = false)]
        public string TimeUpdated { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StrategyOrderRecord {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Strategy: ").Append(Strategy).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  FilledQuantity: ").Append(FilledQuantity).Append("\n");
            sb.Append("  OpenQuantity: ").Append(OpenQuantity).Append("\n");
            sb.Append("  ClosedQuantity: ").Append(ClosedQuantity).Append("\n");
            sb.Append("  OrderType: ").Append(OrderType).Append("\n");
            sb.Append("  TimeInForce: ").Append(TimeInForce).Append("\n");
            sb.Append("  LimitPrice: ").Append(LimitPrice).Append("\n");
            sb.Append("  ExecutionPrice: ").Append(ExecutionPrice).Append("\n");
            sb.Append("  TimePlaced: ").Append(TimePlaced).Append("\n");
            sb.Append("  TimeUpdated: ").Append(TimeUpdated).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as StrategyOrderRecord);
        }

        /// <summary>
        /// Returns true if StrategyOrderRecord instances are equal
        /// </summary>
        /// <param name="input">Instance of StrategyOrderRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StrategyOrderRecord input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.Strategy == input.Strategy ||
                    (this.Strategy != null &&
                    this.Strategy.Equals(input.Strategy))
                ) && base.Equals(input) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && base.Equals(input) && 
                (
                    this.FilledQuantity == input.FilledQuantity ||
                    this.FilledQuantity.Equals(input.FilledQuantity)
                ) && base.Equals(input) && 
                (
                    this.OpenQuantity == input.OpenQuantity ||
                    this.OpenQuantity.Equals(input.OpenQuantity)
                ) && base.Equals(input) && 
                (
                    this.ClosedQuantity == input.ClosedQuantity ||
                    this.ClosedQuantity.Equals(input.ClosedQuantity)
                ) && base.Equals(input) && 
                (
                    this.OrderType == input.OrderType ||
                    this.OrderType.Equals(input.OrderType)
                ) && base.Equals(input) && 
                (
                    this.TimeInForce == input.TimeInForce ||
                    this.TimeInForce.Equals(input.TimeInForce)
                ) && base.Equals(input) && 
                (
                    this.LimitPrice == input.LimitPrice ||
                    (this.LimitPrice != null &&
                    this.LimitPrice.Equals(input.LimitPrice))
                ) && base.Equals(input) && 
                (
                    this.ExecutionPrice == input.ExecutionPrice ||
                    (this.ExecutionPrice != null &&
                    this.ExecutionPrice.Equals(input.ExecutionPrice))
                ) && base.Equals(input) && 
                (
                    this.TimePlaced == input.TimePlaced ||
                    (this.TimePlaced != null &&
                    this.TimePlaced.Equals(input.TimePlaced))
                ) && base.Equals(input) && 
                (
                    this.TimeUpdated == input.TimeUpdated ||
                    (this.TimeUpdated != null &&
                    this.TimeUpdated.Equals(input.TimeUpdated))
                )
                && (this.AdditionalProperties.Count == input.AdditionalProperties.Count && !this.AdditionalProperties.Except(input.AdditionalProperties).Any());
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (this.Strategy != null)
                {
                    hashCode = (hashCode * 59) + this.Strategy.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                hashCode = (hashCode * 59) + this.FilledQuantity.GetHashCode();
                hashCode = (hashCode * 59) + this.OpenQuantity.GetHashCode();
                hashCode = (hashCode * 59) + this.ClosedQuantity.GetHashCode();
                hashCode = (hashCode * 59) + this.OrderType.GetHashCode();
                hashCode = (hashCode * 59) + this.TimeInForce.GetHashCode();
                if (this.LimitPrice != null)
                {
                    hashCode = (hashCode * 59) + this.LimitPrice.GetHashCode();
                }
                if (this.ExecutionPrice != null)
                {
                    hashCode = (hashCode * 59) + this.ExecutionPrice.GetHashCode();
                }
                if (this.TimePlaced != null)
                {
                    hashCode = (hashCode * 59) + this.TimePlaced.GetHashCode();
                }
                if (this.TimeUpdated != null)
                {
                    hashCode = (hashCode * 59) + this.TimeUpdated.GetHashCode();
                }
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
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
