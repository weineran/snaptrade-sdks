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
    /// OptionStrategy
    /// </summary>
    [DataContract(Name = "OptionStrategy")]
    public partial class OptionStrategy : Dictionary<String, Object>, IEquatable<OptionStrategy>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OptionStrategy" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="underlyingSymbolId">underlyingSymbolId.</param>
        /// <param name="strategyType">strategyType.</param>
        /// <param name="numberOfLegs">numberOfLegs.</param>
        /// <param name="legs">legs.</param>
        public OptionStrategy(Guid id = default(Guid), UniversalSymbol underlyingSymbolId = default(UniversalSymbol), string strategyType = default(string), decimal numberOfLegs = default(decimal), List<OptionStrategyLegsInner> legs = default(List<OptionStrategyLegsInner>)) : base()
        {
            this.Id = id;
            this.UnderlyingSymbolId = underlyingSymbolId;
            this.StrategyType = strategyType;
            this.NumberOfLegs = numberOfLegs;
            this.Legs = legs;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets UnderlyingSymbolId
        /// </summary>
        [DataMember(Name = "underlying_symbol_id", EmitDefaultValue = false)]
        public UniversalSymbol UnderlyingSymbolId { get; set; }

        /// <summary>
        /// Gets or Sets StrategyType
        /// </summary>
        [DataMember(Name = "strategy_type", EmitDefaultValue = false)]
        public string StrategyType { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfLegs
        /// </summary>
        [DataMember(Name = "number_of_legs", EmitDefaultValue = false)]
        public decimal NumberOfLegs { get; set; }

        /// <summary>
        /// Gets or Sets Legs
        /// </summary>
        [DataMember(Name = "legs", EmitDefaultValue = false)]
        public List<OptionStrategyLegsInner> Legs { get; set; }

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
            sb.Append("class OptionStrategy {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UnderlyingSymbolId: ").Append(UnderlyingSymbolId).Append("\n");
            sb.Append("  StrategyType: ").Append(StrategyType).Append("\n");
            sb.Append("  NumberOfLegs: ").Append(NumberOfLegs).Append("\n");
            sb.Append("  Legs: ").Append(Legs).Append("\n");
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
            return this.Equals(input as OptionStrategy);
        }

        /// <summary>
        /// Returns true if OptionStrategy instances are equal
        /// </summary>
        /// <param name="input">Instance of OptionStrategy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OptionStrategy input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && base.Equals(input) && 
                (
                    this.UnderlyingSymbolId == input.UnderlyingSymbolId ||
                    (this.UnderlyingSymbolId != null &&
                    this.UnderlyingSymbolId.Equals(input.UnderlyingSymbolId))
                ) && base.Equals(input) && 
                (
                    this.StrategyType == input.StrategyType ||
                    (this.StrategyType != null &&
                    this.StrategyType.Equals(input.StrategyType))
                ) && base.Equals(input) && 
                (
                    this.NumberOfLegs == input.NumberOfLegs ||
                    this.NumberOfLegs.Equals(input.NumberOfLegs)
                ) && base.Equals(input) && 
                (
                    this.Legs == input.Legs ||
                    this.Legs != null &&
                    input.Legs != null &&
                    this.Legs.SequenceEqual(input.Legs)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.UnderlyingSymbolId != null)
                {
                    hashCode = (hashCode * 59) + this.UnderlyingSymbolId.GetHashCode();
                }
                if (this.StrategyType != null)
                {
                    hashCode = (hashCode * 59) + this.StrategyType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.NumberOfLegs.GetHashCode();
                if (this.Legs != null)
                {
                    hashCode = (hashCode * 59) + this.Legs.GetHashCode();
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
