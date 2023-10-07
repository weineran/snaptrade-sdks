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
    /// Options Symbol
    /// </summary>
    [DataContract(Name = "OptionsSymbol")]
    public partial class OptionsSymbol : IEquatable<OptionsSymbol>, IValidatableObject
    {
        /// <summary>
        /// Defines OptionType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OptionTypeEnum
        {
            /// <summary>
            /// Enum CALL for value: CALL
            /// </summary>
            [EnumMember(Value = "CALL")]
            CALL = 1,

            /// <summary>
            /// Enum PUT for value: PUT
            /// </summary>
            [EnumMember(Value = "PUT")]
            PUT = 2

        }


        /// <summary>
        /// Gets or Sets OptionType
        /// </summary>
        [DataMember(Name = "option_type", IsRequired = true, EmitDefaultValue = true)]
        public OptionTypeEnum OptionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OptionsSymbol" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OptionsSymbol()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="OptionsSymbol" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="ticker">ticker (required).</param>
        /// <param name="optionType">optionType (required).</param>
        /// <param name="strikePrice">strikePrice (required).</param>
        /// <param name="expirationDate">expirationDate (required).</param>
        /// <param name="isMiniOption">isMiniOption.</param>
        /// <param name="underlyingSymbol">underlyingSymbol (required).</param>
        /// <param name="localId">localId.</param>
        /// <param name="exchangeId">exchangeId.</param>
        public OptionsSymbol(string id = default(string), string ticker = default(string), OptionTypeEnum optionType = default(OptionTypeEnum), double strikePrice = default(double), string expirationDate = default(string), bool isMiniOption = default(bool), UnderlyingSymbol underlyingSymbol = default(UnderlyingSymbol), string localId = default(string), string exchangeId = default(string)) : base()
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for OptionsSymbol and cannot be null");
            }
            this.Id = id;
            // to ensure "ticker" is required (not null)
            if (ticker == null)
            {
                throw new ArgumentNullException("ticker is a required property for OptionsSymbol and cannot be null");
            }
            this.Ticker = ticker;
            this.OptionType = optionType;
            this.StrikePrice = strikePrice;
            // to ensure "expirationDate" is required (not null)
            if (expirationDate == null)
            {
                throw new ArgumentNullException("expirationDate is a required property for OptionsSymbol and cannot be null");
            }
            this.ExpirationDate = expirationDate;
            // to ensure "underlyingSymbol" is required (not null)
            if (underlyingSymbol == null)
            {
                throw new ArgumentNullException("underlyingSymbol is a required property for OptionsSymbol and cannot be null");
            }
            this.UnderlyingSymbol = underlyingSymbol;
            this.IsMiniOption = isMiniOption;
            this.LocalId = localId;
            this.ExchangeId = exchangeId;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Ticker
        /// </summary>
        [DataMember(Name = "ticker", IsRequired = true, EmitDefaultValue = true)]
        public string Ticker { get; set; }

        /// <summary>
        /// Gets or Sets StrikePrice
        /// </summary>
        [DataMember(Name = "strike_price", IsRequired = true, EmitDefaultValue = true)]
        public double StrikePrice { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        [DataMember(Name = "expiration_date", IsRequired = true, EmitDefaultValue = true)]
        public string ExpirationDate { get; set; }

        /// <summary>
        /// Gets or Sets IsMiniOption
        /// </summary>
        [DataMember(Name = "is_mini_option", EmitDefaultValue = true)]
        public bool IsMiniOption { get; set; }

        /// <summary>
        /// Gets or Sets UnderlyingSymbol
        /// </summary>
        [DataMember(Name = "underlying_symbol", IsRequired = true, EmitDefaultValue = true)]
        public UnderlyingSymbol UnderlyingSymbol { get; set; }

        /// <summary>
        /// Gets or Sets LocalId
        /// </summary>
        [DataMember(Name = "local_id", EmitDefaultValue = false)]
        public string LocalId { get; set; }

        /// <summary>
        /// Gets or Sets ExchangeId
        /// </summary>
        [DataMember(Name = "exchange_id", EmitDefaultValue = false)]
        public string ExchangeId { get; set; }

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
            sb.Append("class OptionsSymbol {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Ticker: ").Append(Ticker).Append("\n");
            sb.Append("  OptionType: ").Append(OptionType).Append("\n");
            sb.Append("  StrikePrice: ").Append(StrikePrice).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  IsMiniOption: ").Append(IsMiniOption).Append("\n");
            sb.Append("  UnderlyingSymbol: ").Append(UnderlyingSymbol).Append("\n");
            sb.Append("  LocalId: ").Append(LocalId).Append("\n");
            sb.Append("  ExchangeId: ").Append(ExchangeId).Append("\n");
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
            return this.Equals(input as OptionsSymbol);
        }

        /// <summary>
        /// Returns true if OptionsSymbol instances are equal
        /// </summary>
        /// <param name="input">Instance of OptionsSymbol to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OptionsSymbol input)
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
                    this.Ticker == input.Ticker ||
                    (this.Ticker != null &&
                    this.Ticker.Equals(input.Ticker))
                ) && base.Equals(input) && 
                (
                    this.OptionType == input.OptionType ||
                    this.OptionType.Equals(input.OptionType)
                ) && base.Equals(input) && 
                (
                    this.StrikePrice == input.StrikePrice ||
                    this.StrikePrice.Equals(input.StrikePrice)
                ) && base.Equals(input) && 
                (
                    this.ExpirationDate == input.ExpirationDate ||
                    (this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(input.ExpirationDate))
                ) && base.Equals(input) && 
                (
                    this.IsMiniOption == input.IsMiniOption ||
                    this.IsMiniOption.Equals(input.IsMiniOption)
                ) && base.Equals(input) && 
                (
                    this.UnderlyingSymbol == input.UnderlyingSymbol ||
                    (this.UnderlyingSymbol != null &&
                    this.UnderlyingSymbol.Equals(input.UnderlyingSymbol))
                ) && base.Equals(input) && 
                (
                    this.LocalId == input.LocalId ||
                    (this.LocalId != null &&
                    this.LocalId.Equals(input.LocalId))
                ) && base.Equals(input) && 
                (
                    this.ExchangeId == input.ExchangeId ||
                    (this.ExchangeId != null &&
                    this.ExchangeId.Equals(input.ExchangeId))
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
                if (this.Ticker != null)
                {
                    hashCode = (hashCode * 59) + this.Ticker.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.OptionType.GetHashCode();
                hashCode = (hashCode * 59) + this.StrikePrice.GetHashCode();
                if (this.ExpirationDate != null)
                {
                    hashCode = (hashCode * 59) + this.ExpirationDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsMiniOption.GetHashCode();
                if (this.UnderlyingSymbol != null)
                {
                    hashCode = (hashCode * 59) + this.UnderlyingSymbol.GetHashCode();
                }
                if (this.LocalId != null)
                {
                    hashCode = (hashCode * 59) + this.LocalId.GetHashCode();
                }
                if (this.ExchangeId != null)
                {
                    hashCode = (hashCode * 59) + this.ExchangeId.GetHashCode();
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
