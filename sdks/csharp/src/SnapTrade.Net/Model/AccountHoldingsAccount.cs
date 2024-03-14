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
    /// Account Holdings with Account ID
    /// </summary>
    [DataContract(Name = "AccountHoldingsAccount")]
    public partial class AccountHoldingsAccount : IEquatable<AccountHoldingsAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountHoldingsAccount" /> class.
        /// </summary>
        /// <param name="account">account.</param>
        /// <param name="balances">balances.</param>
        /// <param name="positions">positions.</param>
        /// <param name="optionPostions">optionPostions.</param>
        /// <param name="orders">orders.</param>
        /// <param name="totalValue">totalValue.</param>
        public AccountHoldingsAccount(SnapTradeHoldingsAccountAccountId account = default(SnapTradeHoldingsAccountAccountId), List<Balance> balances = default(List<Balance>), List<Position> positions = default(List<Position>), List<OptionsPosition> optionPostions = default(List<OptionsPosition>), List<AccountOrderRecord> orders = default(List<AccountOrderRecord>), SnapTradeHoldingsTotalValue totalValue = default(SnapTradeHoldingsTotalValue)) : base()
        {
            this.Account = account;
            this.Balances = balances;
            this.Positions = positions;
            this.OptionPostions = optionPostions;
            this.Orders = orders;
            this.TotalValue = totalValue;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name = "account", EmitDefaultValue = false)]
        public SnapTradeHoldingsAccountAccountId Account { get; set; }

        /// <summary>
        /// Gets or Sets Balances
        /// </summary>
        [DataMember(Name = "balances", EmitDefaultValue = true)]
        public List<Balance> Balances { get; set; }

        /// <summary>
        /// Gets or Sets Positions
        /// </summary>
        [DataMember(Name = "positions", EmitDefaultValue = true)]
        public List<Position> Positions { get; set; }

        /// <summary>
        /// Gets or Sets OptionPostions
        /// </summary>
        [DataMember(Name = "option_postions", EmitDefaultValue = true)]
        public List<OptionsPosition> OptionPostions { get; set; }

        /// <summary>
        /// Gets or Sets Orders
        /// </summary>
        [DataMember(Name = "orders", EmitDefaultValue = true)]
        public List<AccountOrderRecord> Orders { get; set; }

        /// <summary>
        /// Gets or Sets TotalValue
        /// </summary>
        [DataMember(Name = "total_value", EmitDefaultValue = false)]
        public SnapTradeHoldingsTotalValue TotalValue { get; set; }

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
            sb.Append("class AccountHoldingsAccount {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Balances: ").Append(Balances).Append("\n");
            sb.Append("  Positions: ").Append(Positions).Append("\n");
            sb.Append("  OptionPostions: ").Append(OptionPostions).Append("\n");
            sb.Append("  Orders: ").Append(Orders).Append("\n");
            sb.Append("  TotalValue: ").Append(TotalValue).Append("\n");
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
            return this.Equals(input as AccountHoldingsAccount);
        }

        /// <summary>
        /// Returns true if AccountHoldingsAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountHoldingsAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountHoldingsAccount input)
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
                    this.Balances == input.Balances ||
                    this.Balances != null &&
                    input.Balances != null &&
                    this.Balances.SequenceEqual(input.Balances)
                ) && base.Equals(input) && 
                (
                    this.Positions == input.Positions ||
                    this.Positions != null &&
                    input.Positions != null &&
                    this.Positions.SequenceEqual(input.Positions)
                ) && base.Equals(input) && 
                (
                    this.OptionPostions == input.OptionPostions ||
                    this.OptionPostions != null &&
                    input.OptionPostions != null &&
                    this.OptionPostions.SequenceEqual(input.OptionPostions)
                ) && base.Equals(input) && 
                (
                    this.Orders == input.Orders ||
                    this.Orders != null &&
                    input.Orders != null &&
                    this.Orders.SequenceEqual(input.Orders)
                ) && base.Equals(input) && 
                (
                    this.TotalValue == input.TotalValue ||
                    (this.TotalValue != null &&
                    this.TotalValue.Equals(input.TotalValue))
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
                if (this.Balances != null)
                {
                    hashCode = (hashCode * 59) + this.Balances.GetHashCode();
                }
                if (this.Positions != null)
                {
                    hashCode = (hashCode * 59) + this.Positions.GetHashCode();
                }
                if (this.OptionPostions != null)
                {
                    hashCode = (hashCode * 59) + this.OptionPostions.GetHashCode();
                }
                if (this.Orders != null)
                {
                    hashCode = (hashCode * 59) + this.Orders.GetHashCode();
                }
                if (this.TotalValue != null)
                {
                    hashCode = (hashCode * 59) + this.TotalValue.GetHashCode();
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
