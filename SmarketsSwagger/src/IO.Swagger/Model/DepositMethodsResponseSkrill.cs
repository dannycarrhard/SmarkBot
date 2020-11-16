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
    /// DepositMethodsResponseSkrill
    /// </summary>
    [DataContract]
        public partial class DepositMethodsResponseSkrill :  IEquatable<DepositMethodsResponseSkrill>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DepositMethodsResponseSkrill" /> class.
        /// </summary>
        /// <param name="lastUsed">lastUsed (required).</param>
        /// <param name="maxDeposit">maxDeposit (required).</param>
        /// <param name="methodId">methodId (required).</param>
        /// <param name="minDeposit">minDeposit (required).</param>
        /// <param name="skrillId">skrillId (required).</param>
        public DepositMethodsResponseSkrill(bool? lastUsed = default(bool?), OneOfdepositMethodsResponseSkrillMaxDeposit maxDeposit = default(OneOfdepositMethodsResponseSkrillMaxDeposit), string methodId = default(string), OneOfdepositMethodsResponseSkrillMinDeposit minDeposit = default(OneOfdepositMethodsResponseSkrillMinDeposit), string skrillId = default(string))
        {
            // to ensure "lastUsed" is required (not null)
            if (lastUsed == null)
            {
                throw new InvalidDataException("lastUsed is a required property for DepositMethodsResponseSkrill and cannot be null");
            }
            else
            {
                this.LastUsed = lastUsed;
            }
            // to ensure "maxDeposit" is required (not null)
            if (maxDeposit == null)
            {
                throw new InvalidDataException("maxDeposit is a required property for DepositMethodsResponseSkrill and cannot be null");
            }
            else
            {
                this.MaxDeposit = maxDeposit;
            }
            // to ensure "methodId" is required (not null)
            if (methodId == null)
            {
                throw new InvalidDataException("methodId is a required property for DepositMethodsResponseSkrill and cannot be null");
            }
            else
            {
                this.MethodId = methodId;
            }
            // to ensure "minDeposit" is required (not null)
            if (minDeposit == null)
            {
                throw new InvalidDataException("minDeposit is a required property for DepositMethodsResponseSkrill and cannot be null");
            }
            else
            {
                this.MinDeposit = minDeposit;
            }
            // to ensure "skrillId" is required (not null)
            if (skrillId == null)
            {
                throw new InvalidDataException("skrillId is a required property for DepositMethodsResponseSkrill and cannot be null");
            }
            else
            {
                this.SkrillId = skrillId;
            }
        }
        
        /// <summary>
        /// Gets or Sets LastUsed
        /// </summary>
        [DataMember(Name="last_used", EmitDefaultValue=false)]
        public bool? LastUsed { get; set; }

        /// <summary>
        /// Gets or Sets MaxDeposit
        /// </summary>
        [DataMember(Name="max_deposit", EmitDefaultValue=false)]
        public OneOfdepositMethodsResponseSkrillMaxDeposit MaxDeposit { get; set; }

        /// <summary>
        /// Gets or Sets MethodId
        /// </summary>
        [DataMember(Name="method_id", EmitDefaultValue=false)]
        public string MethodId { get; set; }

        /// <summary>
        /// Gets or Sets MinDeposit
        /// </summary>
        [DataMember(Name="min_deposit", EmitDefaultValue=false)]
        public OneOfdepositMethodsResponseSkrillMinDeposit MinDeposit { get; set; }

        /// <summary>
        /// Gets or Sets SkrillId
        /// </summary>
        [DataMember(Name="skrill_id", EmitDefaultValue=false)]
        public string SkrillId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DepositMethodsResponseSkrill {\n");
            sb.Append("  LastUsed: ").Append(LastUsed).Append("\n");
            sb.Append("  MaxDeposit: ").Append(MaxDeposit).Append("\n");
            sb.Append("  MethodId: ").Append(MethodId).Append("\n");
            sb.Append("  MinDeposit: ").Append(MinDeposit).Append("\n");
            sb.Append("  SkrillId: ").Append(SkrillId).Append("\n");
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
            return this.Equals(input as DepositMethodsResponseSkrill);
        }

        /// <summary>
        /// Returns true if DepositMethodsResponseSkrill instances are equal
        /// </summary>
        /// <param name="input">Instance of DepositMethodsResponseSkrill to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DepositMethodsResponseSkrill input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LastUsed == input.LastUsed ||
                    (this.LastUsed != null &&
                    this.LastUsed.Equals(input.LastUsed))
                ) && 
                (
                    this.MaxDeposit == input.MaxDeposit ||
                    (this.MaxDeposit != null &&
                    this.MaxDeposit.Equals(input.MaxDeposit))
                ) && 
                (
                    this.MethodId == input.MethodId ||
                    (this.MethodId != null &&
                    this.MethodId.Equals(input.MethodId))
                ) && 
                (
                    this.MinDeposit == input.MinDeposit ||
                    (this.MinDeposit != null &&
                    this.MinDeposit.Equals(input.MinDeposit))
                ) && 
                (
                    this.SkrillId == input.SkrillId ||
                    (this.SkrillId != null &&
                    this.SkrillId.Equals(input.SkrillId))
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
                if (this.LastUsed != null)
                    hashCode = hashCode * 59 + this.LastUsed.GetHashCode();
                if (this.MaxDeposit != null)
                    hashCode = hashCode * 59 + this.MaxDeposit.GetHashCode();
                if (this.MethodId != null)
                    hashCode = hashCode * 59 + this.MethodId.GetHashCode();
                if (this.MinDeposit != null)
                    hashCode = hashCode * 59 + this.MinDeposit.GetHashCode();
                if (this.SkrillId != null)
                    hashCode = hashCode * 59 + this.SkrillId.GetHashCode();
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
