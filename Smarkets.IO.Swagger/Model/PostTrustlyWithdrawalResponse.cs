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
    /// PostTrustlyWithdrawalResponse
    /// </summary>
    [DataContract]
        public partial class PostTrustlyWithdrawalResponse :  IEquatable<PostTrustlyWithdrawalResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostTrustlyWithdrawalResponse" /> class.
        /// </summary>
        /// <param name="withdrawalUrl">withdrawalUrl (required).</param>
        public PostTrustlyWithdrawalResponse(string withdrawalUrl = default(string))
        {
            // to ensure "withdrawalUrl" is required (not null)
            if (withdrawalUrl == null)
            {
                throw new InvalidDataException("withdrawalUrl is a required property for PostTrustlyWithdrawalResponse and cannot be null");
            }
            else
            {
                this.WithdrawalUrl = withdrawalUrl;
            }
        }
        
        /// <summary>
        /// Gets or Sets WithdrawalUrl
        /// </summary>
        [DataMember(Name="withdrawal_url", EmitDefaultValue=false)]
        public string WithdrawalUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostTrustlyWithdrawalResponse {\n");
            sb.Append("  WithdrawalUrl: ").Append(WithdrawalUrl).Append("\n");
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
            return this.Equals(input as PostTrustlyWithdrawalResponse);
        }

        /// <summary>
        /// Returns true if PostTrustlyWithdrawalResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PostTrustlyWithdrawalResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostTrustlyWithdrawalResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WithdrawalUrl == input.WithdrawalUrl ||
                    (this.WithdrawalUrl != null &&
                    this.WithdrawalUrl.Equals(input.WithdrawalUrl))
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
                if (this.WithdrawalUrl != null)
                    hashCode = hashCode * 59 + this.WithdrawalUrl.GetHashCode();
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
