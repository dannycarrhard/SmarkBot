/* 
 * Smarkets HTTP API
 *
 * This is the HTTP trading API for Smarkets. It can be used to trade on our exchange.     <br><br>For authenticated requests:<br>     <ul>     <li>Get a session token using the login route:     <a class=\"nostyle\" href=\"#/sessions/create_session\"><span>GET /v3/sessions/</span></a></li>     <li>Click on 'Authorize 🔓', enter your token after 'Session-Token ' and click on the 'Authorize' button</li>     </ul>     <p>In order to place bets and get the latest prices without restrictions     using this API, you need to be a Smarkets API user.<br></p>     <p>To become one, please fill <a href=\"https://docs.google.com/forms/d/1qI8RqypNimakPx- bmoUE_lA0YSP3YogKfL8N14STNSM/viewform?edit_requested=true\">this form</a>.</p>     <p>For questions and feedback about the API, use <a href=\"https://community.smarkets.com/c/developers\">our forum</a>.</p>     <p>The API is not public, but we are granting users access on an ongoing basis.</p>     <p>You can find some sample code to help you bootstrap your integration <a href=\"https://github.com/ smarkets/smk_trading_bot\">here</a>.</p>     
 *
 * OpenAPI spec version: 3
 * Contact: api@smarkets.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Provider
    /// </summary>
    [DataContract]
        public partial class Provider :  IEquatable<Provider>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Provider" /> class.
        /// </summary>
        /// <param name="disabledReason">disabledReason.</param>
        /// <param name="eligibleForBonus">eligibleForBonus.</param>
        /// <param name="enabled">enabled (required).</param>
        /// <param name="lastUsed">lastUsed (required).</param>
        /// <param name="maxAmount">maxAmount (required).</param>
        /// <param name="minAmount">minAmount (required).</param>
        public Provider(string disabledReason = default(string), bool? eligibleForBonus = default(bool?), bool? enabled = default(bool?), bool? lastUsed = default(bool?), OneOfproviderMaxAmount maxAmount = default(OneOfproviderMaxAmount), OneOfproviderMinAmount minAmount = default(OneOfproviderMinAmount))
        {
            // to ensure "enabled" is required (not null)
            if (enabled == null)
            {
                throw new InvalidDataException("enabled is a required property for Provider and cannot be null");
            }
            else
            {
                this.Enabled = enabled;
            }
            // to ensure "lastUsed" is required (not null)
            if (lastUsed == null)
            {
                throw new InvalidDataException("lastUsed is a required property for Provider and cannot be null");
            }
            else
            {
                this.LastUsed = lastUsed;
            }
            // to ensure "maxAmount" is required (not null)
            if (maxAmount == null)
            {
                throw new InvalidDataException("maxAmount is a required property for Provider and cannot be null");
            }
            else
            {
                this.MaxAmount = maxAmount;
            }
            // to ensure "minAmount" is required (not null)
            if (minAmount == null)
            {
                throw new InvalidDataException("minAmount is a required property for Provider and cannot be null");
            }
            else
            {
                this.MinAmount = minAmount;
            }
            this.DisabledReason = disabledReason;
            this.EligibleForBonus = eligibleForBonus;
        }
        
        /// <summary>
        /// Gets or Sets DisabledReason
        /// </summary>
        [DataMember(Name="disabled_reason", EmitDefaultValue=false)]
        public string DisabledReason { get; set; }

        /// <summary>
        /// Gets or Sets EligibleForBonus
        /// </summary>
        [DataMember(Name="eligible_for_bonus", EmitDefaultValue=false)]
        public bool? EligibleForBonus { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or Sets LastUsed
        /// </summary>
        [DataMember(Name="last_used", EmitDefaultValue=false)]
        public bool? LastUsed { get; set; }

        /// <summary>
        /// Gets or Sets MaxAmount
        /// </summary>
        [DataMember(Name="max_amount", EmitDefaultValue=false)]
        public OneOfproviderMaxAmount MaxAmount { get; set; }

        /// <summary>
        /// Gets or Sets MinAmount
        /// </summary>
        [DataMember(Name="min_amount", EmitDefaultValue=false)]
        public OneOfproviderMinAmount MinAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Provider {\n");
            sb.Append("  DisabledReason: ").Append(DisabledReason).Append("\n");
            sb.Append("  EligibleForBonus: ").Append(EligibleForBonus).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  LastUsed: ").Append(LastUsed).Append("\n");
            sb.Append("  MaxAmount: ").Append(MaxAmount).Append("\n");
            sb.Append("  MinAmount: ").Append(MinAmount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Provider);
        }

        /// <summary>
        /// Returns true if Provider instances are equal
        /// </summary>
        /// <param name="input">Instance of Provider to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Provider input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisabledReason == input.DisabledReason ||
                    (this.DisabledReason != null &&
                    this.DisabledReason.Equals(input.DisabledReason))
                ) && 
                (
                    this.EligibleForBonus == input.EligibleForBonus ||
                    (this.EligibleForBonus != null &&
                    this.EligibleForBonus.Equals(input.EligibleForBonus))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.LastUsed == input.LastUsed ||
                    (this.LastUsed != null &&
                    this.LastUsed.Equals(input.LastUsed))
                ) && 
                (
                    this.MaxAmount == input.MaxAmount ||
                    (this.MaxAmount != null &&
                    this.MaxAmount.Equals(input.MaxAmount))
                ) && 
                (
                    this.MinAmount == input.MinAmount ||
                    (this.MinAmount != null &&
                    this.MinAmount.Equals(input.MinAmount))
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
                if (this.DisabledReason != null)
                    hashCode = hashCode * 59 + this.DisabledReason.GetHashCode();
                if (this.EligibleForBonus != null)
                    hashCode = hashCode * 59 + this.EligibleForBonus.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.LastUsed != null)
                    hashCode = hashCode * 59 + this.LastUsed.GetHashCode();
                if (this.MaxAmount != null)
                    hashCode = hashCode * 59 + this.MaxAmount.GetHashCode();
                if (this.MinAmount != null)
                    hashCode = hashCode * 59 + this.MinAmount.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
