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
    /// Record of order in brokerageaccount
    /// </summary>
    [DataContract(Name = "AccountOrderRecord")]
    public partial class AccountOrderRecord : Dictionary<String, Object>, IEquatable<AccountOrderRecord>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public AccountOrderRecordStatus? Status { get; set; }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public Action? Action { get; set; }

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
            /// Default constructor for <see cref="AccountOrderRecord" /> class.
            /// </summary>
        public AccountOrderRecord()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="AccountOrderRecord" /> class.
        /// </summary>
        /// <param name="brokerageOrderId">Order id returned by brokerage.</param>
        /// <param name="status">status.</param>
        /// <param name="symbol">symbol.</param>
        /// <param name="universalSymbol">universalSymbol.</param>
        /// <param name="optionSymbol">optionSymbol.</param>
        /// <param name="action">action.</param>
        /// <param name="totalQuantity">Trade Units.</param>
        /// <param name="openQuantity">Trade Units.</param>
        /// <param name="canceledQuantity">Trade Units.</param>
        /// <param name="filledQuantity">Trade Units.</param>
        /// <param name="executionPrice">Trade Price if limit or stop limit order.</param>
        /// <param name="limitPrice">Trade Price if limit or stop limit order.</param>
        /// <param name="stopPrice">Trade Price if limit or stop limit order.</param>
        /// <param name="orderType">orderType.</param>
        /// <param name="timeInForce">timeInForce.</param>
        /// <param name="timePlaced">Time.</param>
        /// <param name="timeUpdated">Time.</param>
        /// <param name="expiryDate">Time.</param>
        public AccountOrderRecord(string brokerageOrderId = default(string), AccountOrderRecordStatus? status = default(AccountOrderRecordStatus?), Guid symbol = default(Guid), UniversalSymbol universalSymbol = default(UniversalSymbol), OptionsSymbol optionSymbol = default(OptionsSymbol), Action? action = default(Action?), decimal totalQuantity = default(decimal), decimal openQuantity = default(decimal), decimal canceledQuantity = default(decimal), decimal filledQuantity = default(decimal), decimal executionPrice = default(decimal), decimal limitPrice = default(decimal), decimal stopPrice = default(decimal), OrderType? orderType = default(OrderType?), TimeInForce? timeInForce = default(TimeInForce?), string timePlaced = default(string), string timeUpdated = default(string), string expiryDate = default(string)) : base()
        {
            this.BrokerageOrderId = brokerageOrderId;
            this.Status = status;
            this.Symbol = symbol;
            this.UniversalSymbol = universalSymbol;
            this.OptionSymbol = optionSymbol;
            this.Action = action;
            this.TotalQuantity = totalQuantity;
            this.OpenQuantity = openQuantity;
            this.CanceledQuantity = canceledQuantity;
            this.FilledQuantity = filledQuantity;
            this.ExecutionPrice = executionPrice;
            this.LimitPrice = limitPrice;
            this.StopPrice = stopPrice;
            this.OrderType = orderType;
            this.TimeInForce = timeInForce;
            this.TimePlaced = timePlaced;
            this.TimeUpdated = timeUpdated;
            this.ExpiryDate = expiryDate;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Order id returned by brokerage
        /// </summary>
        /// <value>Order id returned by brokerage</value>
        [DataMember(Name = "brokerage_order_id", EmitDefaultValue = false)]
        public string BrokerageOrderId { get; set; }

        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        [DataMember(Name = "symbol", EmitDefaultValue = false)]
        public Guid Symbol { get; set; }

        /// <summary>
        /// Gets or Sets UniversalSymbol
        /// </summary>
        [DataMember(Name = "universal_symbol", EmitDefaultValue = false)]
        public UniversalSymbol UniversalSymbol { get; set; }

        /// <summary>
        /// Gets or Sets OptionSymbol
        /// </summary>
        [DataMember(Name = "option_symbol", EmitDefaultValue = false)]
        public OptionsSymbol OptionSymbol { get; set; }

        /// <summary>
        /// Trade Units
        /// </summary>
        /// <value>Trade Units</value>
        [DataMember(Name = "total_quantity", EmitDefaultValue = false)]
        public decimal TotalQuantity { get; set; }

        /// <summary>
        /// Trade Units
        /// </summary>
        /// <value>Trade Units</value>
        [DataMember(Name = "open_quantity", EmitDefaultValue = false)]
        public decimal OpenQuantity { get; set; }

        /// <summary>
        /// Trade Units
        /// </summary>
        /// <value>Trade Units</value>
        [DataMember(Name = "canceled_quantity", EmitDefaultValue = false)]
        public decimal CanceledQuantity { get; set; }

        /// <summary>
        /// Trade Units
        /// </summary>
        /// <value>Trade Units</value>
        [DataMember(Name = "filled_quantity", EmitDefaultValue = false)]
        public decimal FilledQuantity { get; set; }

        /// <summary>
        /// Trade Price if limit or stop limit order
        /// </summary>
        /// <value>Trade Price if limit or stop limit order</value>
        [DataMember(Name = "execution_price", EmitDefaultValue = false)]
        public decimal ExecutionPrice { get; set; }

        /// <summary>
        /// Trade Price if limit or stop limit order
        /// </summary>
        /// <value>Trade Price if limit or stop limit order</value>
        [DataMember(Name = "limit_price", EmitDefaultValue = false)]
        public decimal LimitPrice { get; set; }

        /// <summary>
        /// Trade Price if limit or stop limit order
        /// </summary>
        /// <value>Trade Price if limit or stop limit order</value>
        [DataMember(Name = "stop_price", EmitDefaultValue = false)]
        public decimal StopPrice { get; set; }

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
        /// Time
        /// </summary>
        /// <value>Time</value>
        [DataMember(Name = "expiry_date", EmitDefaultValue = false)]
        public string ExpiryDate { get; set; }

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
            sb.Append("class AccountOrderRecord {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  BrokerageOrderId: ").Append(BrokerageOrderId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  UniversalSymbol: ").Append(UniversalSymbol).Append("\n");
            sb.Append("  OptionSymbol: ").Append(OptionSymbol).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  TotalQuantity: ").Append(TotalQuantity).Append("\n");
            sb.Append("  OpenQuantity: ").Append(OpenQuantity).Append("\n");
            sb.Append("  CanceledQuantity: ").Append(CanceledQuantity).Append("\n");
            sb.Append("  FilledQuantity: ").Append(FilledQuantity).Append("\n");
            sb.Append("  ExecutionPrice: ").Append(ExecutionPrice).Append("\n");
            sb.Append("  LimitPrice: ").Append(LimitPrice).Append("\n");
            sb.Append("  StopPrice: ").Append(StopPrice).Append("\n");
            sb.Append("  OrderType: ").Append(OrderType).Append("\n");
            sb.Append("  TimeInForce: ").Append(TimeInForce).Append("\n");
            sb.Append("  TimePlaced: ").Append(TimePlaced).Append("\n");
            sb.Append("  TimeUpdated: ").Append(TimeUpdated).Append("\n");
            sb.Append("  ExpiryDate: ").Append(ExpiryDate).Append("\n");
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
            return this.Equals(input as AccountOrderRecord);
        }

        /// <summary>
        /// Returns true if AccountOrderRecord instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountOrderRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountOrderRecord input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.BrokerageOrderId == input.BrokerageOrderId ||
                    (this.BrokerageOrderId != null &&
                    this.BrokerageOrderId.Equals(input.BrokerageOrderId))
                ) && base.Equals(input) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && base.Equals(input) && 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && base.Equals(input) && 
                (
                    this.UniversalSymbol == input.UniversalSymbol ||
                    (this.UniversalSymbol != null &&
                    this.UniversalSymbol.Equals(input.UniversalSymbol))
                ) && base.Equals(input) && 
                (
                    this.OptionSymbol == input.OptionSymbol ||
                    (this.OptionSymbol != null &&
                    this.OptionSymbol.Equals(input.OptionSymbol))
                ) && base.Equals(input) && 
                (
                    this.Action == input.Action ||
                    this.Action.Equals(input.Action)
                ) && base.Equals(input) && 
                (
                    this.TotalQuantity == input.TotalQuantity ||
                    this.TotalQuantity.Equals(input.TotalQuantity)
                ) && base.Equals(input) && 
                (
                    this.OpenQuantity == input.OpenQuantity ||
                    this.OpenQuantity.Equals(input.OpenQuantity)
                ) && base.Equals(input) && 
                (
                    this.CanceledQuantity == input.CanceledQuantity ||
                    this.CanceledQuantity.Equals(input.CanceledQuantity)
                ) && base.Equals(input) && 
                (
                    this.FilledQuantity == input.FilledQuantity ||
                    this.FilledQuantity.Equals(input.FilledQuantity)
                ) && base.Equals(input) && 
                (
                    this.ExecutionPrice == input.ExecutionPrice ||
                    this.ExecutionPrice.Equals(input.ExecutionPrice)
                ) && base.Equals(input) && 
                (
                    this.LimitPrice == input.LimitPrice ||
                    this.LimitPrice.Equals(input.LimitPrice)
                ) && base.Equals(input) && 
                (
                    this.StopPrice == input.StopPrice ||
                    this.StopPrice.Equals(input.StopPrice)
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
                    this.TimePlaced == input.TimePlaced ||
                    (this.TimePlaced != null &&
                    this.TimePlaced.Equals(input.TimePlaced))
                ) && base.Equals(input) && 
                (
                    this.TimeUpdated == input.TimeUpdated ||
                    (this.TimeUpdated != null &&
                    this.TimeUpdated.Equals(input.TimeUpdated))
                ) && base.Equals(input) && 
                (
                    this.ExpiryDate == input.ExpiryDate ||
                    (this.ExpiryDate != null &&
                    this.ExpiryDate.Equals(input.ExpiryDate))
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
                if (this.BrokerageOrderId != null)
                {
                    hashCode = (hashCode * 59) + this.BrokerageOrderId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.Symbol != null)
                {
                    hashCode = (hashCode * 59) + this.Symbol.GetHashCode();
                }
                if (this.UniversalSymbol != null)
                {
                    hashCode = (hashCode * 59) + this.UniversalSymbol.GetHashCode();
                }
                if (this.OptionSymbol != null)
                {
                    hashCode = (hashCode * 59) + this.OptionSymbol.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Action.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalQuantity.GetHashCode();
                hashCode = (hashCode * 59) + this.OpenQuantity.GetHashCode();
                hashCode = (hashCode * 59) + this.CanceledQuantity.GetHashCode();
                hashCode = (hashCode * 59) + this.FilledQuantity.GetHashCode();
                hashCode = (hashCode * 59) + this.ExecutionPrice.GetHashCode();
                hashCode = (hashCode * 59) + this.LimitPrice.GetHashCode();
                hashCode = (hashCode * 59) + this.StopPrice.GetHashCode();
                hashCode = (hashCode * 59) + this.OrderType.GetHashCode();
                hashCode = (hashCode * 59) + this.TimeInForce.GetHashCode();
                if (this.TimePlaced != null)
                {
                    hashCode = (hashCode * 59) + this.TimePlaced.GetHashCode();
                }
                if (this.TimeUpdated != null)
                {
                    hashCode = (hashCode * 59) + this.TimeUpdated.GetHashCode();
                }
                if (this.ExpiryDate != null)
                {
                    hashCode = (hashCode * 59) + this.ExpiryDate.GetHashCode();
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
