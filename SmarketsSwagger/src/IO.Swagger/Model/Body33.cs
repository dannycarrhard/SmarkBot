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
    /// Body33
    /// </summary>
    [DataContract]
        public partial class Body33 :  IEquatable<Body33>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Body33" /> class.
        /// </summary>
        /// <param name="amount">amount (required).</param>
        /// <param name="failUrl">failUrl.</param>
        /// <param name="methodId">methodId (required).</param>
        /// <param name="secureId">secureId.</param>
        /// <param name="successUrl">successUrl.</param>
        public Body33(string amount = default(string), string failUrl = default(string), string methodId = default(string), string secureId = default(string), string successUrl = default(string))
        {
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for Body33 and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }
            // to ensure "methodId" is required (not null)
            if (methodId == null)
            {
                throw new InvalidDataException("methodId is a required property for Body33 and cannot be null");
            }
            else
            {
                this.MethodId = methodId;
            }
            this.FailUrl = failUrl;
            this.SecureId = secureId;
            this.SuccessUrl = successUrl;
        }
        
        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public string Amount { get; set; }

        /// <summary>
        /// Gets or Sets FailUrl
        /// </summary>
        [DataMember(Name="fail_url", EmitDefaultValue=false)]
        public string FailUrl { get; set; }

        /// <summary>
        /// Gets or Sets MethodId
        /// </summary>
        [DataMember(Name="method_id", EmitDefaultValue=false)]
        public string MethodId { get; set; }

        /// <summary>
        /// Gets or Sets SecureId
        /// </summary>
        [DataMember(Name="secure_id", EmitDefaultValue=false)]
        public string SecureId { get; set; }

        /// <summary>
        /// Gets or Sets SuccessUrl
        /// </summary>
        [DataMember(Name="success_url", EmitDefaultValue=false)]
        public string SuccessUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Body33 {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  FailUrl: ").Append(FailUrl).Append("\n");
            sb.Append("  MethodId: ").Append(MethodId).Append("\n");
            sb.Append("  SecureId: ").Append(SecureId).Append("\n");
            sb.Append("  SuccessUrl: ").Append(SuccessUrl).Append("\n");
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
            return this.Equals(input as Body33);
        }

        /// <summary>
        /// Returns true if Body33 instances are equal
        /// </summary>
        /// <param name="input">Instance of Body33 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Body33 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.FailUrl == input.FailUrl ||
                    (this.FailUrl != null &&
                    this.FailUrl.Equals(input.FailUrl))
                ) && 
                (
                    this.MethodId == input.MethodId ||
                    (this.MethodId != null &&
                    this.MethodId.Equals(input.MethodId))
                ) && 
                (
                    this.SecureId == input.SecureId ||
                    (this.SecureId != null &&
                    this.SecureId.Equals(input.SecureId))
                ) && 
                (
                    this.SuccessUrl == input.SuccessUrl ||
                    (this.SuccessUrl != null &&
                    this.SuccessUrl.Equals(input.SuccessUrl))
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.FailUrl != null)
                    hashCode = hashCode * 59 + this.FailUrl.GetHashCode();
                if (this.MethodId != null)
                    hashCode = hashCode * 59 + this.MethodId.GetHashCode();
                if (this.SecureId != null)
                    hashCode = hashCode * 59 + this.SecureId.GetHashCode();
                if (this.SuccessUrl != null)
                    hashCode = hashCode * 59 + this.SuccessUrl.GetHashCode();
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
