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
    /// Clock information for the event
    /// </summary>
    [DataContract]
        public partial class EventStatesClock :  IEquatable<EventStatesClock>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventStatesClock" /> class.
        /// </summary>
        /// <param name="matchTime">The current match time.</param>
        /// <param name="remainingTime">Remaining time.</param>
        /// <param name="remainingTimeInPeriod">Remaining time in the current period.</param>
        /// <param name="stoppageTime">Stoppage time of the current period.</param>
        /// <param name="stoppageTimeAnnounced">stoppageTimeAnnounced.</param>
        /// <param name="stopped">Indicates whether the clock is stopped.</param>
        public EventStatesClock(string matchTime = default(string), string remainingTime = default(string), string remainingTimeInPeriod = default(string), string stoppageTime = default(string), string stoppageTimeAnnounced = default(string), bool? stopped = default(bool?))
        {
            this.MatchTime = matchTime;
            this.RemainingTime = remainingTime;
            this.RemainingTimeInPeriod = remainingTimeInPeriod;
            this.StoppageTime = stoppageTime;
            this.StoppageTimeAnnounced = stoppageTimeAnnounced;
            this.Stopped = stopped;
        }
        
        /// <summary>
        /// The current match time
        /// </summary>
        /// <value>The current match time</value>
        [DataMember(Name="match_time", EmitDefaultValue=false)]
        public string MatchTime { get; set; }

        /// <summary>
        /// Remaining time
        /// </summary>
        /// <value>Remaining time</value>
        [DataMember(Name="remaining_time", EmitDefaultValue=false)]
        public string RemainingTime { get; set; }

        /// <summary>
        /// Remaining time in the current period
        /// </summary>
        /// <value>Remaining time in the current period</value>
        [DataMember(Name="remaining_time_in_period", EmitDefaultValue=false)]
        public string RemainingTimeInPeriod { get; set; }

        /// <summary>
        /// Stoppage time of the current period
        /// </summary>
        /// <value>Stoppage time of the current period</value>
        [DataMember(Name="stoppage_time", EmitDefaultValue=false)]
        public string StoppageTime { get; set; }

        /// <summary>
        /// Gets or Sets StoppageTimeAnnounced
        /// </summary>
        [DataMember(Name="stoppage_time_announced", EmitDefaultValue=false)]
        public string StoppageTimeAnnounced { get; set; }

        /// <summary>
        /// Indicates whether the clock is stopped
        /// </summary>
        /// <value>Indicates whether the clock is stopped</value>
        [DataMember(Name="stopped", EmitDefaultValue=false)]
        public bool? Stopped { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventStatesClock {\n");
            sb.Append("  MatchTime: ").Append(MatchTime).Append("\n");
            sb.Append("  RemainingTime: ").Append(RemainingTime).Append("\n");
            sb.Append("  RemainingTimeInPeriod: ").Append(RemainingTimeInPeriod).Append("\n");
            sb.Append("  StoppageTime: ").Append(StoppageTime).Append("\n");
            sb.Append("  StoppageTimeAnnounced: ").Append(StoppageTimeAnnounced).Append("\n");
            sb.Append("  Stopped: ").Append(Stopped).Append("\n");
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
            return this.Equals(input as EventStatesClock);
        }

        /// <summary>
        /// Returns true if EventStatesClock instances are equal
        /// </summary>
        /// <param name="input">Instance of EventStatesClock to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventStatesClock input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MatchTime == input.MatchTime ||
                    (this.MatchTime != null &&
                    this.MatchTime.Equals(input.MatchTime))
                ) && 
                (
                    this.RemainingTime == input.RemainingTime ||
                    (this.RemainingTime != null &&
                    this.RemainingTime.Equals(input.RemainingTime))
                ) && 
                (
                    this.RemainingTimeInPeriod == input.RemainingTimeInPeriod ||
                    (this.RemainingTimeInPeriod != null &&
                    this.RemainingTimeInPeriod.Equals(input.RemainingTimeInPeriod))
                ) && 
                (
                    this.StoppageTime == input.StoppageTime ||
                    (this.StoppageTime != null &&
                    this.StoppageTime.Equals(input.StoppageTime))
                ) && 
                (
                    this.StoppageTimeAnnounced == input.StoppageTimeAnnounced ||
                    (this.StoppageTimeAnnounced != null &&
                    this.StoppageTimeAnnounced.Equals(input.StoppageTimeAnnounced))
                ) && 
                (
                    this.Stopped == input.Stopped ||
                    (this.Stopped != null &&
                    this.Stopped.Equals(input.Stopped))
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
                if (this.MatchTime != null)
                    hashCode = hashCode * 59 + this.MatchTime.GetHashCode();
                if (this.RemainingTime != null)
                    hashCode = hashCode * 59 + this.RemainingTime.GetHashCode();
                if (this.RemainingTimeInPeriod != null)
                    hashCode = hashCode * 59 + this.RemainingTimeInPeriod.GetHashCode();
                if (this.StoppageTime != null)
                    hashCode = hashCode * 59 + this.StoppageTime.GetHashCode();
                if (this.StoppageTimeAnnounced != null)
                    hashCode = hashCode * 59 + this.StoppageTimeAnnounced.GetHashCode();
                if (this.Stopped != null)
                    hashCode = hashCode * 59 + this.Stopped.GetHashCode();
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
