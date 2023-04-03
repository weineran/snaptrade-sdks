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
    /// MonthlyDividends
    /// </summary>
    [DataContract(Name = "MonthlyDividends")]
    public partial class MonthlyDividends : Dictionary<String, Object>, IEquatable<MonthlyDividends>, IValidatableObject
    {
        /// <summary>
            /// Default constructor for <see cref="MonthlyDividends" /> class.
            /// </summary>
        public MonthlyDividends()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="MonthlyDividends" /> class.
        /// </summary>
        /// <param name="date">Date used to specify timeframe for a reporting call (in YYYY-MM-DD format).</param>
        /// <param name="dividends">dividends.</param>
        public MonthlyDividends(string date = default(string), List<DividendAtDate> dividends = default(List<DividendAtDate>)) : base()
        {
            this.Date = date;
            this.Dividends = dividends;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Date used to specify timeframe for a reporting call (in YYYY-MM-DD format)
        /// </summary>
        /// <value>Date used to specify timeframe for a reporting call (in YYYY-MM-DD format)</value>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public string Date { get; set; }

        /// <summary>
        /// Gets or Sets Dividends
        /// </summary>
        [DataMember(Name = "dividends", EmitDefaultValue = false)]
        public List<DividendAtDate> Dividends { get; set; }

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
            sb.Append("class MonthlyDividends {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Dividends: ").Append(Dividends).Append("\n");
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
            return this.Equals(input as MonthlyDividends);
        }

        /// <summary>
        /// Returns true if MonthlyDividends instances are equal
        /// </summary>
        /// <param name="input">Instance of MonthlyDividends to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MonthlyDividends input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && base.Equals(input) && 
                (
                    this.Dividends == input.Dividends ||
                    this.Dividends != null &&
                    input.Dividends != null &&
                    this.Dividends.SequenceEqual(input.Dividends)
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
                if (this.Date != null)
                {
                    hashCode = (hashCode * 59) + this.Date.GetHashCode();
                }
                if (this.Dividends != null)
                {
                    hashCode = (hashCode * 59) + this.Dividends.GetHashCode();
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
