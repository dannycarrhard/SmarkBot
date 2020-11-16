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
    /// Contract information required to display statement
    /// </summary>
    [DataContract]
        public partial class StatementEvent :  IEquatable<StatementEvent>, IValidatableObject
    {
        /// <summary>
        ///  state_or_outcome can have the following values: &lt;ul&gt; &lt;li&gt;new: The contract was just created and is still not available for betting &lt;li&gt;open: open for betting &lt;li&gt;live: open and trading live in-play &lt;li&gt;halted: Trading on this contract has halted &lt;li&gt;winner: settled as winner. &lt;li&gt;loser:  settled as loser. &lt;li&gt;deadheat: settled as a deadheat - a tie with other contract. &lt;li&gt;reduced: withdrawn and a reduction factor was applied. &lt;li&gt;voided: no longer available for betting &lt;li&gt;unavailable: not currently available for betting &lt;/ul&gt;     
        /// </summary>
        /// <value> state_or_outcome can have the following values: &lt;ul&gt; &lt;li&gt;new: The contract was just created and is still not available for betting &lt;li&gt;open: open for betting &lt;li&gt;live: open and trading live in-play &lt;li&gt;halted: Trading on this contract has halted &lt;li&gt;winner: settled as winner. &lt;li&gt;loser:  settled as loser. &lt;li&gt;deadheat: settled as a deadheat - a tie with other contract. &lt;li&gt;reduced: withdrawn and a reduction factor was applied. &lt;li&gt;voided: no longer available for betting &lt;li&gt;unavailable: not currently available for betting &lt;/ul&gt;     </value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StateOrOutcomeEnum
        {
            /// <summary>
            /// Enum Live for value: live
            /// </summary>
            [EnumMember(Value = "live")]
            Live = 1,
            /// <summary>
            /// Enum Open for value: open
            /// </summary>
            [EnumMember(Value = "open")]
            Open = 2,
            /// <summary>
            /// Enum New for value: new
            /// </summary>
            [EnumMember(Value = "new")]
            New = 3,
            /// <summary>
            /// Enum Halted for value: halted
            /// </summary>
            [EnumMember(Value = "halted")]
            Halted = 4,
            /// <summary>
            /// Enum Winner for value: winner
            /// </summary>
            [EnumMember(Value = "winner")]
            Winner = 5,
            /// <summary>
            /// Enum Loser for value: loser
            /// </summary>
            [EnumMember(Value = "loser")]
            Loser = 6,
            /// <summary>
            /// Enum Deadheat for value: deadheat
            /// </summary>
            [EnumMember(Value = "deadheat")]
            Deadheat = 7,
            /// <summary>
            /// Enum Reduced for value: reduced
            /// </summary>
            [EnumMember(Value = "reduced")]
            Reduced = 8,
            /// <summary>
            /// Enum Voided for value: voided
            /// </summary>
            [EnumMember(Value = "voided")]
            Voided = 9,
            /// <summary>
            /// Enum Unavailable for value: unavailable
            /// </summary>
            [EnumMember(Value = "unavailable")]
            Unavailable = 10        }
        /// <summary>
        ///  state_or_outcome can have the following values: &lt;ul&gt; &lt;li&gt;new: The contract was just created and is still not available for betting &lt;li&gt;open: open for betting &lt;li&gt;live: open and trading live in-play &lt;li&gt;halted: Trading on this contract has halted &lt;li&gt;winner: settled as winner. &lt;li&gt;loser:  settled as loser. &lt;li&gt;deadheat: settled as a deadheat - a tie with other contract. &lt;li&gt;reduced: withdrawn and a reduction factor was applied. &lt;li&gt;voided: no longer available for betting &lt;li&gt;unavailable: not currently available for betting &lt;/ul&gt;     
        /// </summary>
        /// <value> state_or_outcome can have the following values: &lt;ul&gt; &lt;li&gt;new: The contract was just created and is still not available for betting &lt;li&gt;open: open for betting &lt;li&gt;live: open and trading live in-play &lt;li&gt;halted: Trading on this contract has halted &lt;li&gt;winner: settled as winner. &lt;li&gt;loser:  settled as loser. &lt;li&gt;deadheat: settled as a deadheat - a tie with other contract. &lt;li&gt;reduced: withdrawn and a reduction factor was applied. &lt;li&gt;voided: no longer available for betting &lt;li&gt;unavailable: not currently available for betting &lt;/ul&gt;     </value>
        [DataMember(Name="state_or_outcome", EmitDefaultValue=false)]
        public StateOrOutcomeEnum StateOrOutcome { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StatementEvent" /> class.
        /// </summary>
        /// <param name="name">Name for the contract, as displayed in our website.&lt;br&gt; Examples can be team names, horse names or other winning outcomes for each market.&lt;br&gt; It should not be used to identify the contract.&lt;br&gt; The contract_type field should be used instead. (required).</param>
        /// <param name="stateOrOutcome"> state_or_outcome can have the following values: &lt;ul&gt; &lt;li&gt;new: The contract was just created and is still not available for betting &lt;li&gt;open: open for betting &lt;li&gt;live: open and trading live in-play &lt;li&gt;halted: Trading on this contract has halted &lt;li&gt;winner: settled as winner. &lt;li&gt;loser:  settled as loser. &lt;li&gt;deadheat: settled as a deadheat - a tie with other contract. &lt;li&gt;reduced: withdrawn and a reduction factor was applied. &lt;li&gt;voided: no longer available for betting &lt;li&gt;unavailable: not currently available for betting &lt;/ul&gt;      (required).</param>
        public StatementEvent(string name = default(string), StateOrOutcomeEnum stateOrOutcome = default(StateOrOutcomeEnum))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for StatementEvent and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "stateOrOutcome" is required (not null)
            if (stateOrOutcome == null)
            {
                throw new InvalidDataException("stateOrOutcome is a required property for StatementEvent and cannot be null");
            }
            else
            {
                this.StateOrOutcome = stateOrOutcome;
            }
        }
        
        /// <summary>
        /// Name for the contract, as displayed in our website.&lt;br&gt; Examples can be team names, horse names or other winning outcomes for each market.&lt;br&gt; It should not be used to identify the contract.&lt;br&gt; The contract_type field should be used instead.
        /// </summary>
        /// <value>Name for the contract, as displayed in our website.&lt;br&gt; Examples can be team names, horse names or other winning outcomes for each market.&lt;br&gt; It should not be used to identify the contract.&lt;br&gt; The contract_type field should be used instead.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatementEvent {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  StateOrOutcome: ").Append(StateOrOutcome).Append("\n");
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
            return this.Equals(input as StatementEvent);
        }

        /// <summary>
        /// Returns true if StatementEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of StatementEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatementEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.StateOrOutcome == input.StateOrOutcome ||
                    (this.StateOrOutcome != null &&
                    this.StateOrOutcome.Equals(input.StateOrOutcome))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.StateOrOutcome != null)
                    hashCode = hashCode * 59 + this.StateOrOutcome.GetHashCode();
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