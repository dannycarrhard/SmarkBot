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
    /// InlineResponse20017
    /// </summary>
    [DataContract]
        public partial class InlineResponse20017 :  IEquatable<InlineResponse20017>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20017" /> class.
        /// </summary>
        /// <param name="activity">activity (required).</param>
        /// <param name="contractGroups">contractGroups (required).</param>
        /// <param name="contracts">contracts (required).</param>
        /// <param name="events">events (required).</param>
        public InlineResponse20017(List<InlineResponse20017Activity> activity = default(List<InlineResponse20017Activity>), Dictionary<string, InlineResponse20017ContractGroups> contractGroups = default(Dictionary<string, InlineResponse20017ContractGroups>), Dictionary<string, InlineResponse20017Contracts> contracts = default(Dictionary<string, InlineResponse20017Contracts>), Dictionary<string, InlineResponse20017Events> events = default(Dictionary<string, InlineResponse20017Events>))
        {
            // to ensure "activity" is required (not null)
            if (activity == null)
            {
                throw new InvalidDataException("activity is a required property for InlineResponse20017 and cannot be null");
            }
            else
            {
                this.Activity = activity;
            }
            // to ensure "contractGroups" is required (not null)
            if (contractGroups == null)
            {
                throw new InvalidDataException("contractGroups is a required property for InlineResponse20017 and cannot be null");
            }
            else
            {
                this.ContractGroups = contractGroups;
            }
            // to ensure "contracts" is required (not null)
            if (contracts == null)
            {
                throw new InvalidDataException("contracts is a required property for InlineResponse20017 and cannot be null");
            }
            else
            {
                this.Contracts = contracts;
            }
            // to ensure "events" is required (not null)
            if (events == null)
            {
                throw new InvalidDataException("events is a required property for InlineResponse20017 and cannot be null");
            }
            else
            {
                this.Events = events;
            }
        }
        
        /// <summary>
        /// Gets or Sets Activity
        /// </summary>
        [DataMember(Name="activity", EmitDefaultValue=false)]
        public List<InlineResponse20017Activity> Activity { get; set; }

        /// <summary>
        /// Gets or Sets ContractGroups
        /// </summary>
        [DataMember(Name="contract_groups", EmitDefaultValue=false)]
        public Dictionary<string, InlineResponse20017ContractGroups> ContractGroups { get; set; }

        /// <summary>
        /// Gets or Sets Contracts
        /// </summary>
        [DataMember(Name="contracts", EmitDefaultValue=false)]
        public Dictionary<string, InlineResponse20017Contracts> Contracts { get; set; }

        /// <summary>
        /// Gets or Sets Events
        /// </summary>
        [DataMember(Name="events", EmitDefaultValue=false)]
        public Dictionary<string, InlineResponse20017Events> Events { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20017 {\n");
            sb.Append("  Activity: ").Append(Activity).Append("\n");
            sb.Append("  ContractGroups: ").Append(ContractGroups).Append("\n");
            sb.Append("  Contracts: ").Append(Contracts).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
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
            return this.Equals(input as InlineResponse20017);
        }

        /// <summary>
        /// Returns true if InlineResponse20017 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20017 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20017 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Activity == input.Activity ||
                    this.Activity != null &&
                    input.Activity != null &&
                    this.Activity.SequenceEqual(input.Activity)
                ) && 
                (
                    this.ContractGroups == input.ContractGroups ||
                    this.ContractGroups != null &&
                    input.ContractGroups != null &&
                    this.ContractGroups.SequenceEqual(input.ContractGroups)
                ) && 
                (
                    this.Contracts == input.Contracts ||
                    this.Contracts != null &&
                    input.Contracts != null &&
                    this.Contracts.SequenceEqual(input.Contracts)
                ) && 
                (
                    this.Events == input.Events ||
                    this.Events != null &&
                    input.Events != null &&
                    this.Events.SequenceEqual(input.Events)
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
                if (this.Activity != null)
                    hashCode = hashCode * 59 + this.Activity.GetHashCode();
                if (this.ContractGroups != null)
                    hashCode = hashCode * 59 + this.ContractGroups.GetHashCode();
                if (this.Contracts != null)
                    hashCode = hashCode * 59 + this.Contracts.GetHashCode();
                if (this.Events != null)
                    hashCode = hashCode * 59 + this.Events.GetHashCode();
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