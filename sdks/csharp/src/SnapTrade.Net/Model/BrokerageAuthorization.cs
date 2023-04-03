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
    /// BrokerageAuthorization
    /// </summary>
    [DataContract(Name = "BrokerageAuthorization")]
    public partial class BrokerageAuthorization : Dictionary<String, Object>, IEquatable<BrokerageAuthorization>, IValidatableObject
    {
        /// <summary>
            /// Default constructor for <see cref="BrokerageAuthorization" /> class.
            /// </summary>
        public BrokerageAuthorization()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="BrokerageAuthorization" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="createdDate">Time.</param>
        /// <param name="updatedDate">Time.</param>
        /// <param name="brokerage">brokerage.</param>
        /// <param name="name">Connection Name.</param>
        /// <param name="type">type.</param>
        /// <param name="disabled">disabled.</param>
        /// <param name="disabledDate">Disabled date.</param>
        /// <param name="meta">Additional data about brokerage authorization.</param>
        public BrokerageAuthorization(Guid id = default(Guid), string createdDate = default(string), string updatedDate = default(string), Brokerage brokerage = default(Brokerage), string name = default(string), string type = default(string), bool disabled = default(bool), string disabledDate = default(string), Dictionary<string, Object> meta = default(Dictionary<string, Object>)) : base()
        {
            this.Id = id;
            this.CreatedDate = createdDate;
            this.UpdatedDate = updatedDate;
            this.Brokerage = brokerage;
            this.Name = name;
            this.Type = type;
            this.Disabled = disabled;
            this.DisabledDate = disabledDate;
            this.Meta = meta;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Time
        /// </summary>
        /// <value>Time</value>
        [DataMember(Name = "created_date", EmitDefaultValue = false)]
        public string CreatedDate { get; set; }

        /// <summary>
        /// Time
        /// </summary>
        /// <value>Time</value>
        [DataMember(Name = "updated_date", EmitDefaultValue = false)]
        public string UpdatedDate { get; set; }

        /// <summary>
        /// Gets or Sets Brokerage
        /// </summary>
        [DataMember(Name = "brokerage", EmitDefaultValue = false)]
        public Brokerage Brokerage { get; set; }

        /// <summary>
        /// Connection Name
        /// </summary>
        /// <value>Connection Name</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Disabled
        /// </summary>
        [DataMember(Name = "disabled", EmitDefaultValue = true)]
        public bool Disabled { get; set; }

        /// <summary>
        /// Disabled date
        /// </summary>
        /// <value>Disabled date</value>
        [DataMember(Name = "disabled_date", EmitDefaultValue = true)]
        public string DisabledDate { get; set; }

        /// <summary>
        /// Additional data about brokerage authorization
        /// </summary>
        /// <value>Additional data about brokerage authorization</value>
        [DataMember(Name = "meta", EmitDefaultValue = false)]
        public Dictionary<string, Object> Meta { get; set; }

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
            sb.Append("class BrokerageAuthorization {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
            sb.Append("  Brokerage: ").Append(Brokerage).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Disabled: ").Append(Disabled).Append("\n");
            sb.Append("  DisabledDate: ").Append(DisabledDate).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
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
            return this.Equals(input as BrokerageAuthorization);
        }

        /// <summary>
        /// Returns true if BrokerageAuthorization instances are equal
        /// </summary>
        /// <param name="input">Instance of BrokerageAuthorization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrokerageAuthorization input)
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
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && base.Equals(input) && 
                (
                    this.UpdatedDate == input.UpdatedDate ||
                    (this.UpdatedDate != null &&
                    this.UpdatedDate.Equals(input.UpdatedDate))
                ) && base.Equals(input) && 
                (
                    this.Brokerage == input.Brokerage ||
                    (this.Brokerage != null &&
                    this.Brokerage.Equals(input.Brokerage))
                ) && base.Equals(input) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.Disabled == input.Disabled ||
                    this.Disabled.Equals(input.Disabled)
                ) && base.Equals(input) && 
                (
                    this.DisabledDate == input.DisabledDate ||
                    (this.DisabledDate != null &&
                    this.DisabledDate.Equals(input.DisabledDate))
                ) && base.Equals(input) && 
                (
                    this.Meta == input.Meta ||
                    this.Meta != null &&
                    input.Meta != null &&
                    this.Meta.SequenceEqual(input.Meta)
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
                if (this.CreatedDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedDate.GetHashCode();
                }
                if (this.UpdatedDate != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedDate.GetHashCode();
                }
                if (this.Brokerage != null)
                {
                    hashCode = (hashCode * 59) + this.Brokerage.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Disabled.GetHashCode();
                if (this.DisabledDate != null)
                {
                    hashCode = (hashCode * 59) + this.DisabledDate.GetHashCode();
                }
                if (this.Meta != null)
                {
                    hashCode = (hashCode * 59) + this.Meta.GetHashCode();
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
