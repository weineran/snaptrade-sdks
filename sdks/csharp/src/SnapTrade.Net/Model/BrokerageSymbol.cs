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
    /// Brokerage symbol
    /// </summary>
    [DataContract(Name = "BrokerageSymbol")]
    public partial class BrokerageSymbol : Dictionary<String, Object>, IEquatable<BrokerageSymbol>, IValidatableObject
    {
        /// <summary>
            /// Default constructor for <see cref="BrokerageSymbol" /> class.
            /// </summary>
        public BrokerageSymbol()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="BrokerageSymbol" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="symbol">symbol.</param>
        /// <param name="brokerageAuthorization">brokerageAuthorization.</param>
        /// <param name="description">description.</param>
        /// <param name="allowsFractionalUnits">allowsFractionalUnits.</param>
        public BrokerageSymbol(Guid id = default(Guid), UniversalSymbol symbol = default(UniversalSymbol), BrokerageAuthorization brokerageAuthorization = default(BrokerageAuthorization), string description = default(string), bool? allowsFractionalUnits = default(bool?)) : base()
        {
            this.Id = id;
            this.Symbol = symbol;
            this.BrokerageAuthorization = brokerageAuthorization;
            this.Description = description;
            this.AllowsFractionalUnits = allowsFractionalUnits;
            this.AdditionalProperties = new Dictionary<string, object>();
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
        /// Gets or Sets BrokerageAuthorization
        /// </summary>
        [DataMember(Name = "brokerage_authorization", EmitDefaultValue = false)]
        public BrokerageAuthorization BrokerageAuthorization { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets AllowsFractionalUnits
        /// </summary>
        [DataMember(Name = "allows_fractional_units", EmitDefaultValue = true)]
        public bool? AllowsFractionalUnits { get; set; }

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
            sb.Append("class BrokerageSymbol {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  BrokerageAuthorization: ").Append(BrokerageAuthorization).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  AllowsFractionalUnits: ").Append(AllowsFractionalUnits).Append("\n");
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
            return this.Equals(input as BrokerageSymbol);
        }

        /// <summary>
        /// Returns true if BrokerageSymbol instances are equal
        /// </summary>
        /// <param name="input">Instance of BrokerageSymbol to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrokerageSymbol input)
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
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && base.Equals(input) && 
                (
                    this.BrokerageAuthorization == input.BrokerageAuthorization ||
                    (this.BrokerageAuthorization != null &&
                    this.BrokerageAuthorization.Equals(input.BrokerageAuthorization))
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.AllowsFractionalUnits == input.AllowsFractionalUnits ||
                    (this.AllowsFractionalUnits != null &&
                    this.AllowsFractionalUnits.Equals(input.AllowsFractionalUnits))
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
                if (this.Symbol != null)
                {
                    hashCode = (hashCode * 59) + this.Symbol.GetHashCode();
                }
                if (this.BrokerageAuthorization != null)
                {
                    hashCode = (hashCode * 59) + this.BrokerageAuthorization.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.AllowsFractionalUnits != null)
                {
                    hashCode = (hashCode * 59) + this.AllowsFractionalUnits.GetHashCode();
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
