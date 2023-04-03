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
    /// Impact of a group of trade
    /// </summary>
    [DataContract(Name = "TradeImpact")]
    public partial class TradeImpact : Dictionary<String, Object>, IEquatable<TradeImpact>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradeImpact" /> class.
        /// </summary>
        /// <param name="account">account.</param>
        /// <param name="currency">currency.</param>
        /// <param name="remainingCash">Remaining balance after executing all trades.</param>
        /// <param name="estimatedCommissions">Total estimated commissions across all trades to make.</param>
        /// <param name="forexFees">Estimated forex fees to pay to excute trades.</param>
        public TradeImpact(Account account = default(Account), Currency currency = default(Currency), decimal remainingCash = default(decimal), decimal estimatedCommissions = default(decimal), decimal forexFees = default(decimal)) : base()
        {
            this.Account = account;
            this.Currency = currency;
            this.RemainingCash = remainingCash;
            this.EstimatedCommissions = estimatedCommissions;
            this.ForexFees = forexFees;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name = "account", EmitDefaultValue = false)]
        public Account Account { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public Currency Currency { get; set; }

        /// <summary>
        /// Remaining balance after executing all trades
        /// </summary>
        /// <value>Remaining balance after executing all trades</value>
        [DataMember(Name = "remaining_cash", EmitDefaultValue = false)]
        public decimal RemainingCash { get; set; }

        /// <summary>
        /// Total estimated commissions across all trades to make
        /// </summary>
        /// <value>Total estimated commissions across all trades to make</value>
        [DataMember(Name = "estimated_commissions", EmitDefaultValue = false)]
        public decimal EstimatedCommissions { get; set; }

        /// <summary>
        /// Estimated forex fees to pay to excute trades
        /// </summary>
        /// <value>Estimated forex fees to pay to excute trades</value>
        [DataMember(Name = "forex_fees", EmitDefaultValue = false)]
        public decimal ForexFees { get; set; }

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
            sb.Append("class TradeImpact {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  RemainingCash: ").Append(RemainingCash).Append("\n");
            sb.Append("  EstimatedCommissions: ").Append(EstimatedCommissions).Append("\n");
            sb.Append("  ForexFees: ").Append(ForexFees).Append("\n");
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
            return this.Equals(input as TradeImpact);
        }

        /// <summary>
        /// Returns true if TradeImpact instances are equal
        /// </summary>
        /// <param name="input">Instance of TradeImpact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TradeImpact input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && base.Equals(input) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && base.Equals(input) && 
                (
                    this.RemainingCash == input.RemainingCash ||
                    this.RemainingCash.Equals(input.RemainingCash)
                ) && base.Equals(input) && 
                (
                    this.EstimatedCommissions == input.EstimatedCommissions ||
                    this.EstimatedCommissions.Equals(input.EstimatedCommissions)
                ) && base.Equals(input) && 
                (
                    this.ForexFees == input.ForexFees ||
                    this.ForexFees.Equals(input.ForexFees)
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
                if (this.Account != null)
                {
                    hashCode = (hashCode * 59) + this.Account.GetHashCode();
                }
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RemainingCash.GetHashCode();
                hashCode = (hashCode * 59) + this.EstimatedCommissions.GetHashCode();
                hashCode = (hashCode * 59) + this.ForexFees.GetHashCode();
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
