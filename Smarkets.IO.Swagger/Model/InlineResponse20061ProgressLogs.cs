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
    /// InlineResponse20061ProgressLogs
    /// </summary>
    [DataContract]
        public partial class InlineResponse20061ProgressLogs :  IEquatable<InlineResponse20061ProgressLogs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20061ProgressLogs" /> class.
        /// </summary>
        /// <param name="eventId">eventId.</param>
        /// <param name="progressIncr">progressIncr.</param>
        /// <param name="promotionCode">promotionCode.</param>
        /// <param name="reason">reason.</param>
        /// <param name="refundAmount">refundAmount.</param>
        /// <param name="ts">ts.</param>
        public InlineResponse20061ProgressLogs(int? eventId = default(int?), int? progressIncr = default(int?), string promotionCode = default(string), string reason = default(string), decimal? refundAmount = default(decimal?), string ts = default(string))
        {
            this.EventId = eventId;
            this.ProgressIncr = progressIncr;
            this.PromotionCode = promotionCode;
            this.Reason = reason;
            this.RefundAmount = refundAmount;
            this.Ts = ts;
        }
        
        /// <summary>
        /// Gets or Sets EventId
        /// </summary>
        [DataMember(Name="event_id", EmitDefaultValue=false)]
        public int? EventId { get; set; }

        /// <summary>
        /// Gets or Sets ProgressIncr
        /// </summary>
        [DataMember(Name="progress_incr", EmitDefaultValue=false)]
        public int? ProgressIncr { get; set; }

        /// <summary>
        /// Gets or Sets PromotionCode
        /// </summary>
        [DataMember(Name="promotion_code", EmitDefaultValue=false)]
        public string PromotionCode { get; set; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or Sets RefundAmount
        /// </summary>
        [DataMember(Name="refund_amount", EmitDefaultValue=false)]
        public decimal? RefundAmount { get; set; }

        /// <summary>
        /// Gets or Sets Ts
        /// </summary>
        [DataMember(Name="ts", EmitDefaultValue=false)]
        public string Ts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20061ProgressLogs {\n");
            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  ProgressIncr: ").Append(ProgressIncr).Append("\n");
            sb.Append("  PromotionCode: ").Append(PromotionCode).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  RefundAmount: ").Append(RefundAmount).Append("\n");
            sb.Append("  Ts: ").Append(Ts).Append("\n");
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
            return this.Equals(input as InlineResponse20061ProgressLogs);
        }

        /// <summary>
        /// Returns true if InlineResponse20061ProgressLogs instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20061ProgressLogs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20061ProgressLogs input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EventId == input.EventId ||
                    (this.EventId != null &&
                    this.EventId.Equals(input.EventId))
                ) && 
                (
                    this.ProgressIncr == input.ProgressIncr ||
                    (this.ProgressIncr != null &&
                    this.ProgressIncr.Equals(input.ProgressIncr))
                ) && 
                (
                    this.PromotionCode == input.PromotionCode ||
                    (this.PromotionCode != null &&
                    this.PromotionCode.Equals(input.PromotionCode))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.RefundAmount == input.RefundAmount ||
                    (this.RefundAmount != null &&
                    this.RefundAmount.Equals(input.RefundAmount))
                ) && 
                (
                    this.Ts == input.Ts ||
                    (this.Ts != null &&
                    this.Ts.Equals(input.Ts))
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
                if (this.EventId != null)
                    hashCode = hashCode * 59 + this.EventId.GetHashCode();
                if (this.ProgressIncr != null)
                    hashCode = hashCode * 59 + this.ProgressIncr.GetHashCode();
                if (this.PromotionCode != null)
                    hashCode = hashCode * 59 + this.PromotionCode.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.RefundAmount != null)
                    hashCode = hashCode * 59 + this.RefundAmount.GetHashCode();
                if (this.Ts != null)
                    hashCode = hashCode * 59 + this.Ts.GetHashCode();
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
