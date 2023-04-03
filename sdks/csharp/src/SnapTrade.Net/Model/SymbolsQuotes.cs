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
    /// Symbols and Tickers Quotes object
    /// </summary>
    [DataContract(Name = "SymbolsQuotes")]
    public partial class SymbolsQuotes : Dictionary<String, Object>, IEquatable<SymbolsQuotes>, IValidatableObject
    {
        /// <summary>
            /// Default constructor for <see cref="SymbolsQuotes" /> class.
            /// </summary>
        public SymbolsQuotes()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="SymbolsQuotes" /> class.
        /// </summary>
        /// <param name="symbol">symbol.</param>
        /// <param name="bidPrice">bidPrice.</param>
        /// <param name="askPrice">askPrice.</param>
        /// <param name="lastTradePrice">lastTradePrice.</param>
        /// <param name="bidSize">bidSize.</param>
        /// <param name="askSize">askSize.</param>
        public SymbolsQuotes(UniversalSymbol symbol = default(UniversalSymbol), decimal bidPrice = default(decimal), decimal askPrice = default(decimal), decimal lastTradePrice = default(decimal), decimal bidSize = default(decimal), decimal askSize = default(decimal)) : base()
        {
            this.Symbol = symbol;
            this.BidPrice = bidPrice;
            this.AskPrice = askPrice;
            this.LastTradePrice = lastTradePrice;
            this.BidSize = bidSize;
            this.AskSize = askSize;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        [DataMember(Name = "symbol", EmitDefaultValue = false)]
        public UniversalSymbol Symbol { get; set; }

        /// <summary>
        /// Gets or Sets BidPrice
        /// </summary>
        [DataMember(Name = "bid_price", EmitDefaultValue = false)]
        public decimal BidPrice { get; set; }

        /// <summary>
        /// Gets or Sets AskPrice
        /// </summary>
        [DataMember(Name = "ask_price", EmitDefaultValue = false)]
        public decimal AskPrice { get; set; }

        /// <summary>
        /// Gets or Sets LastTradePrice
        /// </summary>
        [DataMember(Name = "last_trade_price", EmitDefaultValue = false)]
        public decimal LastTradePrice { get; set; }

        /// <summary>
        /// Gets or Sets BidSize
        /// </summary>
        [DataMember(Name = "bid_size", EmitDefaultValue = false)]
        public decimal BidSize { get; set; }

        /// <summary>
        /// Gets or Sets AskSize
        /// </summary>
        [DataMember(Name = "ask_size", EmitDefaultValue = false)]
        public decimal AskSize { get; set; }

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
            sb.Append("class SymbolsQuotes {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  BidPrice: ").Append(BidPrice).Append("\n");
            sb.Append("  AskPrice: ").Append(AskPrice).Append("\n");
            sb.Append("  LastTradePrice: ").Append(LastTradePrice).Append("\n");
            sb.Append("  BidSize: ").Append(BidSize).Append("\n");
            sb.Append("  AskSize: ").Append(AskSize).Append("\n");
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
            return this.Equals(input as SymbolsQuotes);
        }

        /// <summary>
        /// Returns true if SymbolsQuotes instances are equal
        /// </summary>
        /// <param name="input">Instance of SymbolsQuotes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SymbolsQuotes input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && base.Equals(input) && 
                (
                    this.BidPrice == input.BidPrice ||
                    this.BidPrice.Equals(input.BidPrice)
                ) && base.Equals(input) && 
                (
                    this.AskPrice == input.AskPrice ||
                    this.AskPrice.Equals(input.AskPrice)
                ) && base.Equals(input) && 
                (
                    this.LastTradePrice == input.LastTradePrice ||
                    this.LastTradePrice.Equals(input.LastTradePrice)
                ) && base.Equals(input) && 
                (
                    this.BidSize == input.BidSize ||
                    this.BidSize.Equals(input.BidSize)
                ) && base.Equals(input) && 
                (
                    this.AskSize == input.AskSize ||
                    this.AskSize.Equals(input.AskSize)
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
                if (this.Symbol != null)
                {
                    hashCode = (hashCode * 59) + this.Symbol.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.BidPrice.GetHashCode();
                hashCode = (hashCode * 59) + this.AskPrice.GetHashCode();
                hashCode = (hashCode * 59) + this.LastTradePrice.GetHashCode();
                hashCode = (hashCode * 59) + this.BidSize.GetHashCode();
                hashCode = (hashCode * 59) + this.AskSize.GetHashCode();
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
