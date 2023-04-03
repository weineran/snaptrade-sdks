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
    /// Example for failed request response
    /// </summary>
    [DataContract(Name = "404FailedRequestResponse")]
    public partial class Model404FailedRequestResponse : Dictionary<String, Object>, IEquatable<Model404FailedRequestResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Model404FailedRequestResponse" /> class.
        /// </summary>
        /// <param name="defaultDetail">defaultDetail.</param>
        /// <param name="defaultCode">defaultCode.</param>
        public Model404FailedRequestResponse(Object defaultDetail = default(Object), Object defaultCode = default(Object)) : base()
        {
            this.DefaultDetail = defaultDetail;
            this.DefaultCode = defaultCode;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets DefaultDetail
        /// </summary>
        [DataMember(Name = "default_detail", EmitDefaultValue = true)]
        public Object DefaultDetail { get; set; }

        /// <summary>
        /// Gets or Sets DefaultCode
        /// </summary>
        [DataMember(Name = "default_code", EmitDefaultValue = true)]
        public Object DefaultCode { get; set; }

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
            sb.Append("class Model404FailedRequestResponse {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  DefaultDetail: ").Append(DefaultDetail).Append("\n");
            sb.Append("  DefaultCode: ").Append(DefaultCode).Append("\n");
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
            return this.Equals(input as Model404FailedRequestResponse);
        }

        /// <summary>
        /// Returns true if Model404FailedRequestResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of Model404FailedRequestResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Model404FailedRequestResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.DefaultDetail == input.DefaultDetail ||
                    (this.DefaultDetail != null &&
                    this.DefaultDetail.Equals(input.DefaultDetail))
                ) && base.Equals(input) && 
                (
                    this.DefaultCode == input.DefaultCode ||
                    (this.DefaultCode != null &&
                    this.DefaultCode.Equals(input.DefaultCode))
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
                if (this.DefaultDetail != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultDetail.GetHashCode();
                }
                if (this.DefaultCode != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultCode.GetHashCode();
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
