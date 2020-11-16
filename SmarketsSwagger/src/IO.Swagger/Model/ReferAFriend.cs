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
    /// ReferAFriend
    /// </summary>
    [DataContract]
        public partial class ReferAFriend :  IEquatable<ReferAFriend>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferAFriend" /> class.
        /// </summary>
        /// <param name="currency">currency (required).</param>
        /// <param name="earned">earned (required).</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="rafCode">rafCode (required).</param>
        /// <param name="totalReferred">totalReferred (required).</param>
        public ReferAFriend(string currency = default(string), string earned = default(string), bool? enabled = default(bool?), string rafCode = default(string), int? totalReferred = default(int?))
        {
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new InvalidDataException("currency is a required property for ReferAFriend and cannot be null");
            }
            else
            {
                this.Currency = currency;
            }
            // to ensure "earned" is required (not null)
            if (earned == null)
            {
                throw new InvalidDataException("earned is a required property for ReferAFriend and cannot be null");
            }
            else
            {
                this.Earned = earned;
            }
            // to ensure "rafCode" is required (not null)
            if (rafCode == null)
            {
                throw new InvalidDataException("rafCode is a required property for ReferAFriend and cannot be null");
            }
            else
            {
                this.RafCode = rafCode;
            }
            // to ensure "totalReferred" is required (not null)
            if (totalReferred == null)
            {
                throw new InvalidDataException("totalReferred is a required property for ReferAFriend and cannot be null");
            }
            else
            {
                this.TotalReferred = totalReferred;
            }
            this.Enabled = enabled;
        }
        
        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets Earned
        /// </summary>
        [DataMember(Name="earned", EmitDefaultValue=false)]
        public string Earned { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or Sets RafCode
        /// </summary>
        [DataMember(Name="raf_code", EmitDefaultValue=false)]
        public string RafCode { get; set; }

        /// <summary>
        /// Gets or Sets TotalReferred
        /// </summary>
        [DataMember(Name="total_referred", EmitDefaultValue=false)]
        public int? TotalReferred { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReferAFriend {\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Earned: ").Append(Earned).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  RafCode: ").Append(RafCode).Append("\n");
            sb.Append("  TotalReferred: ").Append(TotalReferred).Append("\n");
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
            return this.Equals(input as ReferAFriend);
        }

        /// <summary>
        /// Returns true if ReferAFriend instances are equal
        /// </summary>
        /// <param name="input">Instance of ReferAFriend to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReferAFriend input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Earned == input.Earned ||
                    (this.Earned != null &&
                    this.Earned.Equals(input.Earned))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.RafCode == input.RafCode ||
                    (this.RafCode != null &&
                    this.RafCode.Equals(input.RafCode))
                ) && 
                (
                    this.TotalReferred == input.TotalReferred ||
                    (this.TotalReferred != null &&
                    this.TotalReferred.Equals(input.TotalReferred))
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
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Earned != null)
                    hashCode = hashCode * 59 + this.Earned.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.RafCode != null)
                    hashCode = hashCode * 59 + this.RafCode.GetHashCode();
                if (this.TotalReferred != null)
                    hashCode = hashCode * 59 + this.TotalReferred.GetHashCode();
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