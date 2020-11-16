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
    /// GamblingSelfTestResponse
    /// </summary>
    [DataContract]
        public partial class GamblingSelfTestResponse :  IEquatable<GamblingSelfTestResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GamblingSelfTestResponse" /> class.
        /// </summary>
        /// <param name="gamblingRisk">gamblingRisk (required).</param>
        public GamblingSelfTestResponse(string gamblingRisk = default(string))
        {
            // to ensure "gamblingRisk" is required (not null)
            if (gamblingRisk == null)
            {
                throw new InvalidDataException("gamblingRisk is a required property for GamblingSelfTestResponse and cannot be null");
            }
            else
            {
                this.GamblingRisk = gamblingRisk;
            }
        }
        
        /// <summary>
        /// Gets or Sets GamblingRisk
        /// </summary>
        [DataMember(Name="gambling_risk", EmitDefaultValue=false)]
        public string GamblingRisk { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GamblingSelfTestResponse {\n");
            sb.Append("  GamblingRisk: ").Append(GamblingRisk).Append("\n");
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
            return this.Equals(input as GamblingSelfTestResponse);
        }

        /// <summary>
        /// Returns true if GamblingSelfTestResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GamblingSelfTestResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GamblingSelfTestResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GamblingRisk == input.GamblingRisk ||
                    (this.GamblingRisk != null &&
                    this.GamblingRisk.Equals(input.GamblingRisk))
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
                if (this.GamblingRisk != null)
                    hashCode = hashCode * 59 + this.GamblingRisk.GetHashCode();
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
