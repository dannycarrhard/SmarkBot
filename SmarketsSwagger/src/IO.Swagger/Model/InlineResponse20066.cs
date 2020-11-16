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
    /// InlineResponse20066
    /// </summary>
    [DataContract]
        public partial class InlineResponse20066 :  IEquatable<InlineResponse20066>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20066" /> class.
        /// </summary>
        /// <param name="placedOrderLimit">placedOrderLimit (required).</param>
        /// <param name="placedOrderUsage">placedOrderUsage (required).</param>
        /// <param name="placedStakeLimit">placedStakeLimit (required).</param>
        /// <param name="placedStakeUsage">placedStakeUsage (required).</param>
        /// <param name="showAlert">showAlert (required).</param>
        public InlineResponse20066(int? placedOrderLimit = default(int?), int? placedOrderUsage = default(int?), int? placedStakeLimit = default(int?), int? placedStakeUsage = default(int?), bool? showAlert = default(bool?))
        {
            // to ensure "placedOrderLimit" is required (not null)
            if (placedOrderLimit == null)
            {
                throw new InvalidDataException("placedOrderLimit is a required property for InlineResponse20066 and cannot be null");
            }
            else
            {
                this.PlacedOrderLimit = placedOrderLimit;
            }
            // to ensure "placedOrderUsage" is required (not null)
            if (placedOrderUsage == null)
            {
                throw new InvalidDataException("placedOrderUsage is a required property for InlineResponse20066 and cannot be null");
            }
            else
            {
                this.PlacedOrderUsage = placedOrderUsage;
            }
            // to ensure "placedStakeLimit" is required (not null)
            if (placedStakeLimit == null)
            {
                throw new InvalidDataException("placedStakeLimit is a required property for InlineResponse20066 and cannot be null");
            }
            else
            {
                this.PlacedStakeLimit = placedStakeLimit;
            }
            // to ensure "placedStakeUsage" is required (not null)
            if (placedStakeUsage == null)
            {
                throw new InvalidDataException("placedStakeUsage is a required property for InlineResponse20066 and cannot be null");
            }
            else
            {
                this.PlacedStakeUsage = placedStakeUsage;
            }
            // to ensure "showAlert" is required (not null)
            if (showAlert == null)
            {
                throw new InvalidDataException("showAlert is a required property for InlineResponse20066 and cannot be null");
            }
            else
            {
                this.ShowAlert = showAlert;
            }
        }
        
        /// <summary>
        /// Gets or Sets PlacedOrderLimit
        /// </summary>
        [DataMember(Name="placed_order_limit", EmitDefaultValue=false)]
        public int? PlacedOrderLimit { get; set; }

        /// <summary>
        /// Gets or Sets PlacedOrderUsage
        /// </summary>
        [DataMember(Name="placed_order_usage", EmitDefaultValue=false)]
        public int? PlacedOrderUsage { get; set; }

        /// <summary>
        /// Gets or Sets PlacedStakeLimit
        /// </summary>
        [DataMember(Name="placed_stake_limit", EmitDefaultValue=false)]
        public int? PlacedStakeLimit { get; set; }

        /// <summary>
        /// Gets or Sets PlacedStakeUsage
        /// </summary>
        [DataMember(Name="placed_stake_usage", EmitDefaultValue=false)]
        public int? PlacedStakeUsage { get; set; }

        /// <summary>
        /// Gets or Sets ShowAlert
        /// </summary>
        [DataMember(Name="show_alert", EmitDefaultValue=false)]
        public bool? ShowAlert { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20066 {\n");
            sb.Append("  PlacedOrderLimit: ").Append(PlacedOrderLimit).Append("\n");
            sb.Append("  PlacedOrderUsage: ").Append(PlacedOrderUsage).Append("\n");
            sb.Append("  PlacedStakeLimit: ").Append(PlacedStakeLimit).Append("\n");
            sb.Append("  PlacedStakeUsage: ").Append(PlacedStakeUsage).Append("\n");
            sb.Append("  ShowAlert: ").Append(ShowAlert).Append("\n");
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
            return this.Equals(input as InlineResponse20066);
        }

        /// <summary>
        /// Returns true if InlineResponse20066 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20066 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20066 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PlacedOrderLimit == input.PlacedOrderLimit ||
                    (this.PlacedOrderLimit != null &&
                    this.PlacedOrderLimit.Equals(input.PlacedOrderLimit))
                ) && 
                (
                    this.PlacedOrderUsage == input.PlacedOrderUsage ||
                    (this.PlacedOrderUsage != null &&
                    this.PlacedOrderUsage.Equals(input.PlacedOrderUsage))
                ) && 
                (
                    this.PlacedStakeLimit == input.PlacedStakeLimit ||
                    (this.PlacedStakeLimit != null &&
                    this.PlacedStakeLimit.Equals(input.PlacedStakeLimit))
                ) && 
                (
                    this.PlacedStakeUsage == input.PlacedStakeUsage ||
                    (this.PlacedStakeUsage != null &&
                    this.PlacedStakeUsage.Equals(input.PlacedStakeUsage))
                ) && 
                (
                    this.ShowAlert == input.ShowAlert ||
                    (this.ShowAlert != null &&
                    this.ShowAlert.Equals(input.ShowAlert))
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
                if (this.PlacedOrderLimit != null)
                    hashCode = hashCode * 59 + this.PlacedOrderLimit.GetHashCode();
                if (this.PlacedOrderUsage != null)
                    hashCode = hashCode * 59 + this.PlacedOrderUsage.GetHashCode();
                if (this.PlacedStakeLimit != null)
                    hashCode = hashCode * 59 + this.PlacedStakeLimit.GetHashCode();
                if (this.PlacedStakeUsage != null)
                    hashCode = hashCode * 59 + this.PlacedStakeUsage.GetHashCode();
                if (this.ShowAlert != null)
                    hashCode = hashCode * 59 + this.ShowAlert.GetHashCode();
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
