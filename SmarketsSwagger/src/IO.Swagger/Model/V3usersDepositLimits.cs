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
    /// V3usersDepositLimits
    /// </summary>
    [DataContract]
        public partial class V3usersDepositLimits :  IEquatable<V3usersDepositLimits>, IValidatableObject
    {
        /// <summary>
        /// Defines Interval
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum IntervalEnum
        {
            /// <summary>
            /// Enum Daily for value: daily
            /// </summary>
            [EnumMember(Value = "daily")]
            Daily = 1,
            /// <summary>
            /// Enum Weekly for value: weekly
            /// </summary>
            [EnumMember(Value = "weekly")]
            Weekly = 2,
            /// <summary>
            /// Enum Monthly for value: monthly
            /// </summary>
            [EnumMember(Value = "monthly")]
            Monthly = 3,
            /// <summary>
            /// Enum Yearly for value: yearly
            /// </summary>
            [EnumMember(Value = "yearly")]
            Yearly = 4        }
        /// <summary>
        /// Gets or Sets Interval
        /// </summary>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        public IntervalEnum Interval { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="V3usersDepositLimits" /> class.
        /// </summary>
        /// <param name="interval">interval (required).</param>
        /// <param name="totalAllowance">totalAllowance (required).</param>
        public V3usersDepositLimits(IntervalEnum interval = default(IntervalEnum), string totalAllowance = default(string))
        {
            // to ensure "interval" is required (not null)
            if (interval == null)
            {
                throw new InvalidDataException("interval is a required property for V3usersDepositLimits and cannot be null");
            }
            else
            {
                this.Interval = interval;
            }
            // to ensure "totalAllowance" is required (not null)
            if (totalAllowance == null)
            {
                throw new InvalidDataException("totalAllowance is a required property for V3usersDepositLimits and cannot be null");
            }
            else
            {
                this.TotalAllowance = totalAllowance;
            }
        }
        

        /// <summary>
        /// Gets or Sets TotalAllowance
        /// </summary>
        [DataMember(Name="total_allowance", EmitDefaultValue=false)]
        public string TotalAllowance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V3usersDepositLimits {\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  TotalAllowance: ").Append(TotalAllowance).Append("\n");
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
            return this.Equals(input as V3usersDepositLimits);
        }

        /// <summary>
        /// Returns true if V3usersDepositLimits instances are equal
        /// </summary>
        /// <param name="input">Instance of V3usersDepositLimits to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V3usersDepositLimits input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Interval == input.Interval ||
                    (this.Interval != null &&
                    this.Interval.Equals(input.Interval))
                ) && 
                (
                    this.TotalAllowance == input.TotalAllowance ||
                    (this.TotalAllowance != null &&
                    this.TotalAllowance.Equals(input.TotalAllowance))
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
                if (this.Interval != null)
                    hashCode = hashCode * 59 + this.Interval.GetHashCode();
                if (this.TotalAllowance != null)
                    hashCode = hashCode * 59 + this.TotalAllowance.GetHashCode();
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
