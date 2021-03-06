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
    /// ResponsibleGamblingAcknowledgeResponse
    /// </summary>
    [DataContract]
        public partial class ResponsibleGamblingAcknowledgeResponse :  IEquatable<ResponsibleGamblingAcknowledgeResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsibleGamblingAcknowledgeResponse" /> class.
        /// </summary>
        /// <param name="ackRequiredIn">Period of time in seconds when responsible gambling message needs to be acknowledged (required).</param>
        /// <param name="isLoginAcked">Indicates whether the responsible gambling message was acknowledged upon login (required).</param>
        /// <param name="sessionDuration">Period of time in seconds since the last login (required).</param>
        public ResponsibleGamblingAcknowledgeResponse(int? ackRequiredIn = default(int?), bool? isLoginAcked = default(bool?), int? sessionDuration = default(int?))
        {
            // to ensure "ackRequiredIn" is required (not null)
            if (ackRequiredIn == null)
            {
                throw new InvalidDataException("ackRequiredIn is a required property for ResponsibleGamblingAcknowledgeResponse and cannot be null");
            }
            else
            {
                this.AckRequiredIn = ackRequiredIn;
            }
            // to ensure "isLoginAcked" is required (not null)
            if (isLoginAcked == null)
            {
                throw new InvalidDataException("isLoginAcked is a required property for ResponsibleGamblingAcknowledgeResponse and cannot be null");
            }
            else
            {
                this.IsLoginAcked = isLoginAcked;
            }
            // to ensure "sessionDuration" is required (not null)
            if (sessionDuration == null)
            {
                throw new InvalidDataException("sessionDuration is a required property for ResponsibleGamblingAcknowledgeResponse and cannot be null");
            }
            else
            {
                this.SessionDuration = sessionDuration;
            }
        }
        
        /// <summary>
        /// Period of time in seconds when responsible gambling message needs to be acknowledged
        /// </summary>
        /// <value>Period of time in seconds when responsible gambling message needs to be acknowledged</value>
        [DataMember(Name="ack_required_in", EmitDefaultValue=false)]
        public int? AckRequiredIn { get; set; }

        /// <summary>
        /// Indicates whether the responsible gambling message was acknowledged upon login
        /// </summary>
        /// <value>Indicates whether the responsible gambling message was acknowledged upon login</value>
        [DataMember(Name="is_login_acked", EmitDefaultValue=false)]
        public bool? IsLoginAcked { get; set; }

        /// <summary>
        /// Period of time in seconds since the last login
        /// </summary>
        /// <value>Period of time in seconds since the last login</value>
        [DataMember(Name="session_duration", EmitDefaultValue=false)]
        public int? SessionDuration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponsibleGamblingAcknowledgeResponse {\n");
            sb.Append("  AckRequiredIn: ").Append(AckRequiredIn).Append("\n");
            sb.Append("  IsLoginAcked: ").Append(IsLoginAcked).Append("\n");
            sb.Append("  SessionDuration: ").Append(SessionDuration).Append("\n");
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
            return this.Equals(input as ResponsibleGamblingAcknowledgeResponse);
        }

        /// <summary>
        /// Returns true if ResponsibleGamblingAcknowledgeResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ResponsibleGamblingAcknowledgeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponsibleGamblingAcknowledgeResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AckRequiredIn == input.AckRequiredIn ||
                    (this.AckRequiredIn != null &&
                    this.AckRequiredIn.Equals(input.AckRequiredIn))
                ) && 
                (
                    this.IsLoginAcked == input.IsLoginAcked ||
                    (this.IsLoginAcked != null &&
                    this.IsLoginAcked.Equals(input.IsLoginAcked))
                ) && 
                (
                    this.SessionDuration == input.SessionDuration ||
                    (this.SessionDuration != null &&
                    this.SessionDuration.Equals(input.SessionDuration))
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
                if (this.AckRequiredIn != null)
                    hashCode = hashCode * 59 + this.AckRequiredIn.GetHashCode();
                if (this.IsLoginAcked != null)
                    hashCode = hashCode * 59 + this.IsLoginAcked.GetHashCode();
                if (this.SessionDuration != null)
                    hashCode = hashCode * 59 + this.SessionDuration.GetHashCode();
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
