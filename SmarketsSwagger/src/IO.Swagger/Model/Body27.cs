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
    /// Body27
    /// </summary>
    [DataContract]
        public partial class Body27 :  IEquatable<Body27>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Body27" /> class.
        /// </summary>
        /// <param name="sig">Signature (required).</param>
        /// <param name="sso">Nonce (required).</param>
        public Body27(string sig = default(string), string sso = default(string))
        {
            // to ensure "sig" is required (not null)
            if (sig == null)
            {
                throw new InvalidDataException("sig is a required property for Body27 and cannot be null");
            }
            else
            {
                this.Sig = sig;
            }
            // to ensure "sso" is required (not null)
            if (sso == null)
            {
                throw new InvalidDataException("sso is a required property for Body27 and cannot be null");
            }
            else
            {
                this.Sso = sso;
            }
        }
        
        /// <summary>
        /// Signature
        /// </summary>
        /// <value>Signature</value>
        [DataMember(Name="sig", EmitDefaultValue=false)]
        public string Sig { get; set; }

        /// <summary>
        /// Nonce
        /// </summary>
        /// <value>Nonce</value>
        [DataMember(Name="sso", EmitDefaultValue=false)]
        public string Sso { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Body27 {\n");
            sb.Append("  Sig: ").Append(Sig).Append("\n");
            sb.Append("  Sso: ").Append(Sso).Append("\n");
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
            return this.Equals(input as Body27);
        }

        /// <summary>
        /// Returns true if Body27 instances are equal
        /// </summary>
        /// <param name="input">Instance of Body27 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Body27 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Sig == input.Sig ||
                    (this.Sig != null &&
                    this.Sig.Equals(input.Sig))
                ) && 
                (
                    this.Sso == input.Sso ||
                    (this.Sso != null &&
                    this.Sso.Equals(input.Sso))
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
                if (this.Sig != null)
                    hashCode = hashCode * 59 + this.Sig.GetHashCode();
                if (this.Sso != null)
                    hashCode = hashCode * 59 + this.Sso.GetHashCode();
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