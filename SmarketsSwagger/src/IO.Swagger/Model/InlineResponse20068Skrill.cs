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
    /// InlineResponse20068Skrill
    /// </summary>
    [DataContract]
        public partial class InlineResponse20068Skrill :  IEquatable<InlineResponse20068Skrill>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20068Skrill" /> class.
        /// </summary>
        /// <param name="lastUsed">lastUsed (required).</param>
        /// <param name="maxWithdrawal">maxWithdrawal (required).</param>
        /// <param name="methodId">methodId (required).</param>
        /// <param name="minWithdrawal">minWithdrawal (required).</param>
        /// <param name="skrillId">skrillId (required).</param>
        /// <param name="withdrawalBalance">withdrawalBalance (required).</param>
        public InlineResponse20068Skrill(bool? lastUsed = default(bool?), OneOfinlineResponse20068SkrillMaxWithdrawal maxWithdrawal = default(OneOfinlineResponse20068SkrillMaxWithdrawal), string methodId = default(string), OneOfinlineResponse20068SkrillMinWithdrawal minWithdrawal = default(OneOfinlineResponse20068SkrillMinWithdrawal), string skrillId = default(string), string withdrawalBalance = default(string))
        {
            // to ensure "lastUsed" is required (not null)
            if (lastUsed == null)
            {
                throw new InvalidDataException("lastUsed is a required property for InlineResponse20068Skrill and cannot be null");
            }
            else
            {
                this.LastUsed = lastUsed;
            }
            // to ensure "maxWithdrawal" is required (not null)
            if (maxWithdrawal == null)
            {
                throw new InvalidDataException("maxWithdrawal is a required property for InlineResponse20068Skrill and cannot be null");
            }
            else
            {
                this.MaxWithdrawal = maxWithdrawal;
            }
            // to ensure "methodId" is required (not null)
            if (methodId == null)
            {
                throw new InvalidDataException("methodId is a required property for InlineResponse20068Skrill and cannot be null");
            }
            else
            {
                this.MethodId = methodId;
            }
            // to ensure "minWithdrawal" is required (not null)
            if (minWithdrawal == null)
            {
                throw new InvalidDataException("minWithdrawal is a required property for InlineResponse20068Skrill and cannot be null");
            }
            else
            {
                this.MinWithdrawal = minWithdrawal;
            }
            // to ensure "skrillId" is required (not null)
            if (skrillId == null)
            {
                throw new InvalidDataException("skrillId is a required property for InlineResponse20068Skrill and cannot be null");
            }
            else
            {
                this.SkrillId = skrillId;
            }
            // to ensure "withdrawalBalance" is required (not null)
            if (withdrawalBalance == null)
            {
                throw new InvalidDataException("withdrawalBalance is a required property for InlineResponse20068Skrill and cannot be null");
            }
            else
            {
                this.WithdrawalBalance = withdrawalBalance;
            }
        }
        
        /// <summary>
        /// Gets or Sets LastUsed
        /// </summary>
        [DataMember(Name="last_used", EmitDefaultValue=false)]
        public bool? LastUsed { get; set; }

        /// <summary>
        /// Gets or Sets MaxWithdrawal
        /// </summary>
        [DataMember(Name="max_withdrawal", EmitDefaultValue=false)]
        public OneOfinlineResponse20068SkrillMaxWithdrawal MaxWithdrawal { get; set; }

        /// <summary>
        /// Gets or Sets MethodId
        /// </summary>
        [DataMember(Name="method_id", EmitDefaultValue=false)]
        public string MethodId { get; set; }

        /// <summary>
        /// Gets or Sets MinWithdrawal
        /// </summary>
        [DataMember(Name="min_withdrawal", EmitDefaultValue=false)]
        public OneOfinlineResponse20068SkrillMinWithdrawal MinWithdrawal { get; set; }

        /// <summary>
        /// Gets or Sets SkrillId
        /// </summary>
        [DataMember(Name="skrill_id", EmitDefaultValue=false)]
        public string SkrillId { get; set; }

        /// <summary>
        /// Gets or Sets WithdrawalBalance
        /// </summary>
        [DataMember(Name="withdrawal_balance", EmitDefaultValue=false)]
        public string WithdrawalBalance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20068Skrill {\n");
            sb.Append("  LastUsed: ").Append(LastUsed).Append("\n");
            sb.Append("  MaxWithdrawal: ").Append(MaxWithdrawal).Append("\n");
            sb.Append("  MethodId: ").Append(MethodId).Append("\n");
            sb.Append("  MinWithdrawal: ").Append(MinWithdrawal).Append("\n");
            sb.Append("  SkrillId: ").Append(SkrillId).Append("\n");
            sb.Append("  WithdrawalBalance: ").Append(WithdrawalBalance).Append("\n");
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
            return this.Equals(input as InlineResponse20068Skrill);
        }

        /// <summary>
        /// Returns true if InlineResponse20068Skrill instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20068Skrill to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20068Skrill input)
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
                    this.MaxWithdrawal == input.MaxWithdrawal ||
                    (this.MaxWithdrawal != null &&
                    this.MaxWithdrawal.Equals(input.MaxWithdrawal))
                ) && 
                (
                    this.MethodId == input.MethodId ||
                    (this.MethodId != null &&
                    this.MethodId.Equals(input.MethodId))
                ) && 
                (
                    this.MinWithdrawal == input.MinWithdrawal ||
                    (this.MinWithdrawal != null &&
                    this.MinWithdrawal.Equals(input.MinWithdrawal))
                ) && 
                (
                    this.SkrillId == input.SkrillId ||
                    (this.SkrillId != null &&
                    this.SkrillId.Equals(input.SkrillId))
                ) && 
                (
                    this.WithdrawalBalance == input.WithdrawalBalance ||
                    (this.WithdrawalBalance != null &&
                    this.WithdrawalBalance.Equals(input.WithdrawalBalance))
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
                if (this.MaxWithdrawal != null)
                    hashCode = hashCode * 59 + this.MaxWithdrawal.GetHashCode();
                if (this.MethodId != null)
                    hashCode = hashCode * 59 + this.MethodId.GetHashCode();
                if (this.MinWithdrawal != null)
                    hashCode = hashCode * 59 + this.MinWithdrawal.GetHashCode();
                if (this.SkrillId != null)
                    hashCode = hashCode * 59 + this.SkrillId.GetHashCode();
                if (this.WithdrawalBalance != null)
                    hashCode = hashCode * 59 + this.WithdrawalBalance.GetHashCode();
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
