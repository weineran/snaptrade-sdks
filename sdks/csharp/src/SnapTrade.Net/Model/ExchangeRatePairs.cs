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
    /// The exchange rate of a pair of currencies
    /// </summary>
    [DataContract(Name = "ExchangeRatePairs")]
    public partial class ExchangeRatePairs : Dictionary<String, Object>, IEquatable<ExchangeRatePairs>, IValidatableObject
    {
        /// <summary>
            /// Default constructor for <see cref="ExchangeRatePairs" /> class.
            /// </summary>
        public ExchangeRatePairs()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeRatePairs" /> class.
        /// </summary>
        /// <param name="src">src.</param>
        /// <param name="dst">dst.</param>
        /// <param name="exchangeRate">exchangeRate.</param>
        public ExchangeRatePairs(Currency src = default(Currency), Currency dst = default(Currency), decimal exchangeRate = default(decimal)) : base()
        {
            this.Src = src;
            this.Dst = dst;
            this.ExchangeRate = exchangeRate;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Src
        /// </summary>
        [DataMember(Name = "src", EmitDefaultValue = false)]
        public Currency Src { get; set; }

        /// <summary>
        /// Gets or Sets Dst
        /// </summary>
        [DataMember(Name = "dst", EmitDefaultValue = false)]
        public Currency Dst { get; set; }

        /// <summary>
        /// Gets or Sets ExchangeRate
        /// </summary>
        [DataMember(Name = "exchange_rate", EmitDefaultValue = false)]
        public decimal ExchangeRate { get; set; }

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
            sb.Append("class ExchangeRatePairs {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Src: ").Append(Src).Append("\n");
            sb.Append("  Dst: ").Append(Dst).Append("\n");
            sb.Append("  ExchangeRate: ").Append(ExchangeRate).Append("\n");
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
            return this.Equals(input as ExchangeRatePairs);
        }

        /// <summary>
        /// Returns true if ExchangeRatePairs instances are equal
        /// </summary>
        /// <param name="input">Instance of ExchangeRatePairs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExchangeRatePairs input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.Src == input.Src ||
                    (this.Src != null &&
                    this.Src.Equals(input.Src))
                ) && base.Equals(input) && 
                (
                    this.Dst == input.Dst ||
                    (this.Dst != null &&
                    this.Dst.Equals(input.Dst))
                ) && base.Equals(input) && 
                (
                    this.ExchangeRate == input.ExchangeRate ||
                    this.ExchangeRate.Equals(input.ExchangeRate)
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
                if (this.Src != null)
                {
                    hashCode = (hashCode * 59) + this.Src.GetHashCode();
                }
                if (this.Dst != null)
                {
                    hashCode = (hashCode * 59) + this.Dst.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ExchangeRate.GetHashCode();
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
