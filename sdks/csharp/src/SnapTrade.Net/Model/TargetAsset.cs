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
    /// Target percentage of a certain asset
    /// </summary>
    [DataContract(Name = "TargetAsset")]
    public partial class TargetAsset : IEquatable<TargetAsset>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TargetAsset" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="symbol">symbol.</param>
        /// <param name="percent">percent.</param>
        /// <param name="isSupported">isSupported.</param>
        /// <param name="isExcluded">isExcluded.</param>
        /// <param name="meta">meta.</param>
        public TargetAsset(Guid id = default(Guid), UniversalSymbol symbol = default(UniversalSymbol), decimal percent = default(decimal), bool isSupported = default(bool), bool isExcluded = default(bool), Dictionary<string, Object> meta = default(Dictionary<string, Object>))
        {
            this.Id = id;
            this.Symbol = symbol;
            this.Percent = percent;
            this.IsSupported = isSupported;
            this.IsExcluded = isExcluded;
            this.Meta = meta;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        [DataMember(Name = "symbol", EmitDefaultValue = false)]
        public UniversalSymbol Symbol { get; set; }

        /// <summary>
        /// Gets or Sets Percent
        /// </summary>
        [DataMember(Name = "percent", EmitDefaultValue = false)]
        public decimal Percent { get; set; }

        /// <summary>
        /// Gets or Sets IsSupported
        /// </summary>
        [DataMember(Name = "is_supported", EmitDefaultValue = true)]
        public bool IsSupported { get; set; }

        /// <summary>
        /// Gets or Sets IsExcluded
        /// </summary>
        [DataMember(Name = "is_excluded", EmitDefaultValue = true)]
        public bool IsExcluded { get; set; }

        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [DataMember(Name = "meta", EmitDefaultValue = true)]
        public Dictionary<string, Object> Meta { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TargetAsset {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Percent: ").Append(Percent).Append("\n");
            sb.Append("  IsSupported: ").Append(IsSupported).Append("\n");
            sb.Append("  IsExcluded: ").Append(IsExcluded).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
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
            return this.Equals(input as TargetAsset);
        }

        /// <summary>
        /// Returns true if TargetAsset instances are equal
        /// </summary>
        /// <param name="input">Instance of TargetAsset to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TargetAsset input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.Percent == input.Percent ||
                    this.Percent.Equals(input.Percent)
                ) && 
                (
                    this.IsSupported == input.IsSupported ||
                    this.IsSupported.Equals(input.IsSupported)
                ) && 
                (
                    this.IsExcluded == input.IsExcluded ||
                    this.IsExcluded.Equals(input.IsExcluded)
                ) && 
                (
                    this.Meta == input.Meta ||
                    this.Meta != null &&
                    input.Meta != null &&
                    this.Meta.SequenceEqual(input.Meta)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Symbol != null)
                {
                    hashCode = (hashCode * 59) + this.Symbol.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Percent.GetHashCode();
                hashCode = (hashCode * 59) + this.IsSupported.GetHashCode();
                hashCode = (hashCode * 59) + this.IsExcluded.GetHashCode();
                if (this.Meta != null)
                {
                    hashCode = (hashCode * 59) + this.Meta.GetHashCode();
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
            // Percent (decimal) maximum
            if (this.Percent > (decimal)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Percent, must be a value less than or equal to 100.", new [] { "Percent" });
            }

            // Percent (decimal) minimum
            if (this.Percent < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Percent, must be a value greater than or equal to 0.", new [] { "Percent" });
            }

            yield break;
        }
    }

}
