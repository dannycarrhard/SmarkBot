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
    /// PopularEventsResponse
    /// </summary>
    [DataContract]
        public partial class PopularEventsResponse :  IEquatable<PopularEventsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PopularEventsResponse" /> class.
        /// </summary>
        /// <param name="popularEventIds">popularEventIds (required).</param>
        public PopularEventsResponse(List<string> popularEventIds = default(List<string>))
        {
            // to ensure "popularEventIds" is required (not null)
            if (popularEventIds == null)
            {
                throw new InvalidDataException("popularEventIds is a required property for PopularEventsResponse and cannot be null");
            }
            else
            {
                this.PopularEventIds = popularEventIds;
            }
        }
        
        /// <summary>
        /// Gets or Sets PopularEventIds
        /// </summary>
        [DataMember(Name="popular_event_ids", EmitDefaultValue=false)]
        public List<string> PopularEventIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PopularEventsResponse {\n");
            sb.Append("  PopularEventIds: ").Append(PopularEventIds).Append("\n");
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
            return this.Equals(input as PopularEventsResponse);
        }

        /// <summary>
        /// Returns true if PopularEventsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PopularEventsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PopularEventsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PopularEventIds == input.PopularEventIds ||
                    this.PopularEventIds != null &&
                    input.PopularEventIds != null &&
                    this.PopularEventIds.SequenceEqual(input.PopularEventIds)
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
                if (this.PopularEventIds != null)
                    hashCode = hashCode * 59 + this.PopularEventIds.GetHashCode();
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
