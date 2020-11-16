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
    /// Account activity fetch success
    /// </summary>
    [DataContract]
        public partial class AccountActivityResponse :  IEquatable<AccountActivityResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountActivityResponse" /> class.
        /// </summary>
        /// <param name="accountActivity">accountActivity (required).</param>
        /// <param name="contracts">Array of contracts.</param>
        /// <param name="events">Array of events.</param>
        /// <param name="markets">Array of markets.</param>
        /// <param name="pagination">pagination.</param>
        public AccountActivityResponse(List<AccountActivityTransaction> accountActivity = default(List<AccountActivityTransaction>), List<StatementEvent> contracts = default(List<StatementEvent>), List<StatementEvent1> events = default(List<StatementEvent1>), List<StatementEvent2> markets = default(List<StatementEvent2>), AccountActivityResponsePagination pagination = default(AccountActivityResponsePagination))
        {
            // to ensure "accountActivity" is required (not null)
            if (accountActivity == null)
            {
                throw new InvalidDataException("accountActivity is a required property for AccountActivityResponse and cannot be null");
            }
            else
            {
                this.AccountActivity = accountActivity;
            }
            this.Contracts = contracts;
            this.Events = events;
            this.Markets = markets;
            this.Pagination = pagination;
        }
        
        /// <summary>
        /// Gets or Sets AccountActivity
        /// </summary>
        [DataMember(Name="account_activity", EmitDefaultValue=false)]
        public List<AccountActivityTransaction> AccountActivity { get; set; }

        /// <summary>
        /// Array of contracts
        /// </summary>
        /// <value>Array of contracts</value>
        [DataMember(Name="contracts", EmitDefaultValue=false)]
        public List<StatementEvent> Contracts { get; set; }

        /// <summary>
        /// Array of events
        /// </summary>
        /// <value>Array of events</value>
        [DataMember(Name="events", EmitDefaultValue=false)]
        public List<StatementEvent1> Events { get; set; }

        /// <summary>
        /// Array of markets
        /// </summary>
        /// <value>Array of markets</value>
        [DataMember(Name="markets", EmitDefaultValue=false)]
        public List<StatementEvent2> Markets { get; set; }

        /// <summary>
        /// Gets or Sets Pagination
        /// </summary>
        [DataMember(Name="pagination", EmitDefaultValue=false)]
        public AccountActivityResponsePagination Pagination { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountActivityResponse {\n");
            sb.Append("  AccountActivity: ").Append(AccountActivity).Append("\n");
            sb.Append("  Contracts: ").Append(Contracts).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  Markets: ").Append(Markets).Append("\n");
            sb.Append("  Pagination: ").Append(Pagination).Append("\n");
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
            return this.Equals(input as AccountActivityResponse);
        }

        /// <summary>
        /// Returns true if AccountActivityResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountActivityResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountActivityResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountActivity == input.AccountActivity ||
                    this.AccountActivity != null &&
                    input.AccountActivity != null &&
                    this.AccountActivity.SequenceEqual(input.AccountActivity)
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
                ) && 
                (
                    this.Markets == input.Markets ||
                    this.Markets != null &&
                    input.Markets != null &&
                    this.Markets.SequenceEqual(input.Markets)
                ) && 
                (
                    this.Pagination == input.Pagination ||
                    (this.Pagination != null &&
                    this.Pagination.Equals(input.Pagination))
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
                if (this.AccountActivity != null)
                    hashCode = hashCode * 59 + this.AccountActivity.GetHashCode();
                if (this.Contracts != null)
                    hashCode = hashCode * 59 + this.Contracts.GetHashCode();
                if (this.Events != null)
                    hashCode = hashCode * 59 + this.Events.GetHashCode();
                if (this.Markets != null)
                    hashCode = hashCode * 59 + this.Markets.GetHashCode();
                if (this.Pagination != null)
                    hashCode = hashCode * 59 + this.Pagination.GetHashCode();
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