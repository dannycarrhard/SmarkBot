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
    /// InlineResponse20068BankTransfer
    /// </summary>
    [DataContract]
        public partial class InlineResponse20068BankTransfer :  IEquatable<InlineResponse20068BankTransfer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20068BankTransfer" /> class.
        /// </summary>
        /// <param name="bicswift">bicswift.</param>
        /// <param name="iban">iban.</param>
        /// <param name="lastUsed">lastUsed (required).</param>
        /// <param name="maxWithdrawal">maxWithdrawal (required).</param>
        /// <param name="methodId">methodId (required).</param>
        /// <param name="minWithdrawal">minWithdrawal (required).</param>
        /// <param name="withdrawalBalance">withdrawalBalance (required).</param>
        public InlineResponse20068BankTransfer(string bicswift = default(string), string iban = default(string), bool? lastUsed = default(bool?), OneOfinlineResponse20068BankTransferMaxWithdrawal maxWithdrawal = default(OneOfinlineResponse20068BankTransferMaxWithdrawal), string methodId = default(string), OneOfinlineResponse20068BankTransferMinWithdrawal minWithdrawal = default(OneOfinlineResponse20068BankTransferMinWithdrawal), string withdrawalBalance = default(string))
        {
            // to ensure "lastUsed" is required (not null)
            if (lastUsed == null)
            {
                throw new InvalidDataException("lastUsed is a required property for InlineResponse20068BankTransfer and cannot be null");
            }
            else
            {
                this.LastUsed = lastUsed;
            }
            // to ensure "maxWithdrawal" is required (not null)
            if (maxWithdrawal == null)
            {
                throw new InvalidDataException("maxWithdrawal is a required property for InlineResponse20068BankTransfer and cannot be null");
            }
            else
            {
                this.MaxWithdrawal = maxWithdrawal;
            }
            // to ensure "methodId" is required (not null)
            if (methodId == null)
            {
                throw new InvalidDataException("methodId is a required property for InlineResponse20068BankTransfer and cannot be null");
            }
            else
            {
                this.MethodId = methodId;
            }
            // to ensure "minWithdrawal" is required (not null)
            if (minWithdrawal == null)
            {
                throw new InvalidDataException("minWithdrawal is a required property for InlineResponse20068BankTransfer and cannot be null");
            }
            else
            {
                this.MinWithdrawal = minWithdrawal;
            }
            // to ensure "withdrawalBalance" is required (not null)
            if (withdrawalBalance == null)
            {
                throw new InvalidDataException("withdrawalBalance is a required property for InlineResponse20068BankTransfer and cannot be null");
            }
            else
            {
                this.WithdrawalBalance = withdrawalBalance;
            }
            this.Bicswift = bicswift;
            this.Iban = iban;
        }
        
        /// <summary>
        /// Gets or Sets Bicswift
        /// </summary>
        [DataMember(Name="bicswift", EmitDefaultValue=false)]
        public string Bicswift { get; set; }

        /// <summary>
        /// Gets or Sets Iban
        /// </summary>
        [DataMember(Name="iban", EmitDefaultValue=false)]
        public string Iban { get; set; }

        /// <summary>
        /// Gets or Sets LastUsed
        /// </summary>
        [DataMember(Name="last_used", EmitDefaultValue=false)]
        public bool? LastUsed { get; set; }

        /// <summary>
        /// Gets or Sets MaxWithdrawal
        /// </summary>
        [DataMember(Name="max_withdrawal", EmitDefaultValue=false)]
        public OneOfinlineResponse20068BankTransferMaxWithdrawal MaxWithdrawal { get; set; }

        /// <summary>
        /// Gets or Sets MethodId
        /// </summary>
        [DataMember(Name="method_id", EmitDefaultValue=false)]
        public string MethodId { get; set; }

        /// <summary>
        /// Gets or Sets MinWithdrawal
        /// </summary>
        [DataMember(Name="min_withdrawal", EmitDefaultValue=false)]
        public OneOfinlineResponse20068BankTransferMinWithdrawal MinWithdrawal { get; set; }

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
            sb.Append("class InlineResponse20068BankTransfer {\n");
            sb.Append("  Bicswift: ").Append(Bicswift).Append("\n");
            sb.Append("  Iban: ").Append(Iban).Append("\n");
            sb.Append("  LastUsed: ").Append(LastUsed).Append("\n");
            sb.Append("  MaxWithdrawal: ").Append(MaxWithdrawal).Append("\n");
            sb.Append("  MethodId: ").Append(MethodId).Append("\n");
            sb.Append("  MinWithdrawal: ").Append(MinWithdrawal).Append("\n");
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
            return this.Equals(input as InlineResponse20068BankTransfer);
        }

        /// <summary>
        /// Returns true if InlineResponse20068BankTransfer instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20068BankTransfer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20068BankTransfer input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Bicswift == input.Bicswift ||
                    (this.Bicswift != null &&
                    this.Bicswift.Equals(input.Bicswift))
                ) && 
                (
                    this.Iban == input.Iban ||
                    (this.Iban != null &&
                    this.Iban.Equals(input.Iban))
                ) && 
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
                if (this.Bicswift != null)
                    hashCode = hashCode * 59 + this.Bicswift.GetHashCode();
                if (this.Iban != null)
                    hashCode = hashCode * 59 + this.Iban.GetHashCode();
                if (this.LastUsed != null)
                    hashCode = hashCode * 59 + this.LastUsed.GetHashCode();
                if (this.MaxWithdrawal != null)
                    hashCode = hashCode * 59 + this.MaxWithdrawal.GetHashCode();
                if (this.MethodId != null)
                    hashCode = hashCode * 59 + this.MethodId.GetHashCode();
                if (this.MinWithdrawal != null)
                    hashCode = hashCode * 59 + this.MinWithdrawal.GetHashCode();
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