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
    /// DepositBonusConditionsResponse
    /// </summary>
    [DataContract]
        public partial class DepositBonusConditionsResponse :  IEquatable<DepositBonusConditionsResponse>, IValidatableObject
    {
        /// <summary>
        /// Defines Providers
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ProvidersEnum
        {
            /// <summary>
            /// Enum Banktransfer for value: bank_transfer
            /// </summary>
            [EnumMember(Value = "bank_transfer")]
            Banktransfer = 1,
            /// <summary>
            /// Enum Card for value: card
            /// </summary>
            [EnumMember(Value = "card")]
            Card = 2,
            /// <summary>
            /// Enum Neteller for value: neteller
            /// </summary>
            [EnumMember(Value = "neteller")]
            Neteller = 3,
            /// <summary>
            /// Enum Skrill for value: skrill
            /// </summary>
            [EnumMember(Value = "skrill")]
            Skrill = 4,
            /// <summary>
            /// Enum Trustly for value: trustly
            /// </summary>
            [EnumMember(Value = "trustly")]
            Trustly = 5,
            /// <summary>
            /// Enum Paypal for value: paypal
            /// </summary>
            [EnumMember(Value = "paypal")]
            Paypal = 6,
            /// <summary>
            /// Enum Openbanktransfer for value: open_bank_transfer
            /// </summary>
            [EnumMember(Value = "open_bank_transfer")]
            Openbanktransfer = 7,
            /// <summary>
            /// Enum Worldpay for value: worldpay
            /// </summary>
            [EnumMember(Value = "worldpay")]
            Worldpay = 8        }
        /// <summary>
        /// Gets or Sets Providers
        /// </summary>
        [DataMember(Name="providers", EmitDefaultValue=false)]
        public List<ProvidersEnum> Providers { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DepositBonusConditionsResponse" /> class.
        /// </summary>
        /// <param name="minDeposit">minDeposit (required).</param>
        /// <param name="providers">providers (required).</param>
        public DepositBonusConditionsResponse(List<DepositBonusConditionsResponseMinDeposit> minDeposit = default(List<DepositBonusConditionsResponseMinDeposit>), List<ProvidersEnum> providers = default(List<ProvidersEnum>))
        {
            // to ensure "minDeposit" is required (not null)
            if (minDeposit == null)
            {
                throw new InvalidDataException("minDeposit is a required property for DepositBonusConditionsResponse and cannot be null");
            }
            else
            {
                this.MinDeposit = minDeposit;
            }
            // to ensure "providers" is required (not null)
            if (providers == null)
            {
                throw new InvalidDataException("providers is a required property for DepositBonusConditionsResponse and cannot be null");
            }
            else
            {
                this.Providers = providers;
            }
        }
        
        /// <summary>
        /// Gets or Sets MinDeposit
        /// </summary>
        [DataMember(Name="min_deposit", EmitDefaultValue=false)]
        public List<DepositBonusConditionsResponseMinDeposit> MinDeposit { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DepositBonusConditionsResponse {\n");
            sb.Append("  MinDeposit: ").Append(MinDeposit).Append("\n");
            sb.Append("  Providers: ").Append(Providers).Append("\n");
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
            return this.Equals(input as DepositBonusConditionsResponse);
        }

        /// <summary>
        /// Returns true if DepositBonusConditionsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DepositBonusConditionsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DepositBonusConditionsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MinDeposit == input.MinDeposit ||
                    this.MinDeposit != null &&
                    input.MinDeposit != null &&
                    this.MinDeposit.SequenceEqual(input.MinDeposit)
                ) && 
                (
                    this.Providers == input.Providers ||
                    this.Providers != null &&
                    input.Providers != null &&
                    this.Providers.SequenceEqual(input.Providers)
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
                if (this.MinDeposit != null)
                    hashCode = hashCode * 59 + this.MinDeposit.GetHashCode();
                if (this.Providers != null)
                    hashCode = hashCode * 59 + this.Providers.GetHashCode();
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
