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
    /// MinimumAllowedVersionResponse
    /// </summary>
    [DataContract]
        public partial class MinimumAllowedVersionResponse :  IEquatable<MinimumAllowedVersionResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MinimumAllowedVersionResponse" /> class.
        /// </summary>
        /// <param name="expiredUpgradePrompt">expiredUpgradePrompt (required).</param>
        /// <param name="minimumAllowedVersion">minimumAllowedVersion (required).</param>
        /// <param name="minimumRecommendedVersion">minimumRecommendedVersion.</param>
        /// <param name="recommendedUpgradePrompt">recommendedUpgradePrompt.</param>
        public MinimumAllowedVersionResponse(string expiredUpgradePrompt = default(string), string minimumAllowedVersion = default(string), string minimumRecommendedVersion = default(string), string recommendedUpgradePrompt = default(string))
        {
            // to ensure "expiredUpgradePrompt" is required (not null)
            if (expiredUpgradePrompt == null)
            {
                throw new InvalidDataException("expiredUpgradePrompt is a required property for MinimumAllowedVersionResponse and cannot be null");
            }
            else
            {
                this.ExpiredUpgradePrompt = expiredUpgradePrompt;
            }
            // to ensure "minimumAllowedVersion" is required (not null)
            if (minimumAllowedVersion == null)
            {
                throw new InvalidDataException("minimumAllowedVersion is a required property for MinimumAllowedVersionResponse and cannot be null");
            }
            else
            {
                this.MinimumAllowedVersion = minimumAllowedVersion;
            }
            this.MinimumRecommendedVersion = minimumRecommendedVersion;
            this.RecommendedUpgradePrompt = recommendedUpgradePrompt;
        }
        
        /// <summary>
        /// Gets or Sets ExpiredUpgradePrompt
        /// </summary>
        [DataMember(Name="expired_upgrade_prompt", EmitDefaultValue=false)]
        public string ExpiredUpgradePrompt { get; set; }

        /// <summary>
        /// Gets or Sets MinimumAllowedVersion
        /// </summary>
        [DataMember(Name="minimum_allowed_version", EmitDefaultValue=false)]
        public string MinimumAllowedVersion { get; set; }

        /// <summary>
        /// Gets or Sets MinimumRecommendedVersion
        /// </summary>
        [DataMember(Name="minimum_recommended_version", EmitDefaultValue=false)]
        public string MinimumRecommendedVersion { get; set; }

        /// <summary>
        /// Gets or Sets RecommendedUpgradePrompt
        /// </summary>
        [DataMember(Name="recommended_upgrade_prompt", EmitDefaultValue=false)]
        public string RecommendedUpgradePrompt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MinimumAllowedVersionResponse {\n");
            sb.Append("  ExpiredUpgradePrompt: ").Append(ExpiredUpgradePrompt).Append("\n");
            sb.Append("  MinimumAllowedVersion: ").Append(MinimumAllowedVersion).Append("\n");
            sb.Append("  MinimumRecommendedVersion: ").Append(MinimumRecommendedVersion).Append("\n");
            sb.Append("  RecommendedUpgradePrompt: ").Append(RecommendedUpgradePrompt).Append("\n");
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
            return this.Equals(input as MinimumAllowedVersionResponse);
        }

        /// <summary>
        /// Returns true if MinimumAllowedVersionResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MinimumAllowedVersionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MinimumAllowedVersionResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExpiredUpgradePrompt == input.ExpiredUpgradePrompt ||
                    (this.ExpiredUpgradePrompt != null &&
                    this.ExpiredUpgradePrompt.Equals(input.ExpiredUpgradePrompt))
                ) && 
                (
                    this.MinimumAllowedVersion == input.MinimumAllowedVersion ||
                    (this.MinimumAllowedVersion != null &&
                    this.MinimumAllowedVersion.Equals(input.MinimumAllowedVersion))
                ) && 
                (
                    this.MinimumRecommendedVersion == input.MinimumRecommendedVersion ||
                    (this.MinimumRecommendedVersion != null &&
                    this.MinimumRecommendedVersion.Equals(input.MinimumRecommendedVersion))
                ) && 
                (
                    this.RecommendedUpgradePrompt == input.RecommendedUpgradePrompt ||
                    (this.RecommendedUpgradePrompt != null &&
                    this.RecommendedUpgradePrompt.Equals(input.RecommendedUpgradePrompt))
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
                if (this.ExpiredUpgradePrompt != null)
                    hashCode = hashCode * 59 + this.ExpiredUpgradePrompt.GetHashCode();
                if (this.MinimumAllowedVersion != null)
                    hashCode = hashCode * 59 + this.MinimumAllowedVersion.GetHashCode();
                if (this.MinimumRecommendedVersion != null)
                    hashCode = hashCode * 59 + this.MinimumRecommendedVersion.GetHashCode();
                if (this.RecommendedUpgradePrompt != null)
                    hashCode = hashCode * 59 + this.RecommendedUpgradePrompt.GetHashCode();
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
