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
    /// InlineResponse20032
    /// </summary>
    [DataContract]
        public partial class InlineResponse20032 :  IEquatable<InlineResponse20032>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20032" /> class.
        /// </summary>
        /// <param name="appliedImageGroups">appliedImageGroups (required).</param>
        /// <param name="imageRoot">imageRoot (required).</param>
        public InlineResponse20032(List<InlineResponse20032AppliedImageGroups> appliedImageGroups = default(List<InlineResponse20032AppliedImageGroups>), string imageRoot = default(string))
        {
            // to ensure "appliedImageGroups" is required (not null)
            if (appliedImageGroups == null)
            {
                throw new InvalidDataException("appliedImageGroups is a required property for InlineResponse20032 and cannot be null");
            }
            else
            {
                this.AppliedImageGroups = appliedImageGroups;
            }
            // to ensure "imageRoot" is required (not null)
            if (imageRoot == null)
            {
                throw new InvalidDataException("imageRoot is a required property for InlineResponse20032 and cannot be null");
            }
            else
            {
                this.ImageRoot = imageRoot;
            }
        }
        
        /// <summary>
        /// Gets or Sets AppliedImageGroups
        /// </summary>
        [DataMember(Name="applied_image_groups", EmitDefaultValue=false)]
        public List<InlineResponse20032AppliedImageGroups> AppliedImageGroups { get; set; }

        /// <summary>
        /// Gets or Sets ImageRoot
        /// </summary>
        [DataMember(Name="image_root", EmitDefaultValue=false)]
        public string ImageRoot { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20032 {\n");
            sb.Append("  AppliedImageGroups: ").Append(AppliedImageGroups).Append("\n");
            sb.Append("  ImageRoot: ").Append(ImageRoot).Append("\n");
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
            return this.Equals(input as InlineResponse20032);
        }

        /// <summary>
        /// Returns true if InlineResponse20032 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20032 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20032 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppliedImageGroups == input.AppliedImageGroups ||
                    this.AppliedImageGroups != null &&
                    input.AppliedImageGroups != null &&
                    this.AppliedImageGroups.SequenceEqual(input.AppliedImageGroups)
                ) && 
                (
                    this.ImageRoot == input.ImageRoot ||
                    (this.ImageRoot != null &&
                    this.ImageRoot.Equals(input.ImageRoot))
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
                if (this.AppliedImageGroups != null)
                    hashCode = hashCode * 59 + this.AppliedImageGroups.GetHashCode();
                if (this.ImageRoot != null)
                    hashCode = hashCode * 59 + this.ImageRoot.GetHashCode();
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
