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
    /// InlineResponse20016
    /// </summary>
    [DataContract]
        public partial class InlineResponse20016 :  IEquatable<InlineResponse20016>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20016" /> class.
        /// </summary>
        /// <param name="authenticated">authenticated (required).</param>
        /// <param name="country">country (required).</param>
        /// <param name="currency">currency.</param>
        /// <param name="email">email.</param>
        /// <param name="familyName">familyName.</param>
        /// <param name="givenName">givenName.</param>
        /// <param name="idSlug">idSlug.</param>
        /// <param name="lastChangedTerms">lastChangedTerms.</param>
        /// <param name="lastSeenTerms">lastSeenTerms.</param>
        /// <param name="memberId">memberId.</param>
        /// <param name="permittedCountry">permittedCountry (required).</param>
        /// <param name="rate">rate.</param>
        public InlineResponse20016(bool? authenticated = default(bool?), string country = default(string), string currency = default(string), string email = default(string), string familyName = default(string), string givenName = default(string), string idSlug = default(string), DateTime? lastChangedTerms = default(DateTime?), DateTime? lastSeenTerms = default(DateTime?), int? memberId = default(int?), bool? permittedCountry = default(bool?), string rate = default(string))
        {
            // to ensure "authenticated" is required (not null)
            if (authenticated == null)
            {
                throw new InvalidDataException("authenticated is a required property for InlineResponse20016 and cannot be null");
            }
            else
            {
                this.Authenticated = authenticated;
            }
            // to ensure "country" is required (not null)
            if (country == null)
            {
                throw new InvalidDataException("country is a required property for InlineResponse20016 and cannot be null");
            }
            else
            {
                this.Country = country;
            }
            // to ensure "permittedCountry" is required (not null)
            if (permittedCountry == null)
            {
                throw new InvalidDataException("permittedCountry is a required property for InlineResponse20016 and cannot be null");
            }
            else
            {
                this.PermittedCountry = permittedCountry;
            }
            this.Currency = currency;
            this.Email = email;
            this.FamilyName = familyName;
            this.GivenName = givenName;
            this.IdSlug = idSlug;
            this.LastChangedTerms = lastChangedTerms;
            this.LastSeenTerms = lastSeenTerms;
            this.MemberId = memberId;
            this.Rate = rate;
        }
        
        /// <summary>
        /// Gets or Sets Authenticated
        /// </summary>
        [DataMember(Name="authenticated", EmitDefaultValue=false)]
        public bool? Authenticated { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets FamilyName
        /// </summary>
        [DataMember(Name="family_name", EmitDefaultValue=false)]
        public string FamilyName { get; set; }

        /// <summary>
        /// Gets or Sets GivenName
        /// </summary>
        [DataMember(Name="given_name", EmitDefaultValue=false)]
        public string GivenName { get; set; }

        /// <summary>
        /// Gets or Sets IdSlug
        /// </summary>
        [DataMember(Name="id_slug", EmitDefaultValue=false)]
        public string IdSlug { get; set; }

        /// <summary>
        /// Gets or Sets LastChangedTerms
        /// </summary>
        [DataMember(Name="last_changed_terms", EmitDefaultValue=false)]
        public DateTime? LastChangedTerms { get; set; }

        /// <summary>
        /// Gets or Sets LastSeenTerms
        /// </summary>
        [DataMember(Name="last_seen_terms", EmitDefaultValue=false)]
        public DateTime? LastSeenTerms { get; set; }

        /// <summary>
        /// Gets or Sets MemberId
        /// </summary>
        [DataMember(Name="member_id", EmitDefaultValue=false)]
        public int? MemberId { get; set; }

        /// <summary>
        /// Gets or Sets PermittedCountry
        /// </summary>
        [DataMember(Name="permitted_country", EmitDefaultValue=false)]
        public bool? PermittedCountry { get; set; }

        /// <summary>
        /// Gets or Sets Rate
        /// </summary>
        [DataMember(Name="rate", EmitDefaultValue=false)]
        public string Rate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20016 {\n");
            sb.Append("  Authenticated: ").Append(Authenticated).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FamilyName: ").Append(FamilyName).Append("\n");
            sb.Append("  GivenName: ").Append(GivenName).Append("\n");
            sb.Append("  IdSlug: ").Append(IdSlug).Append("\n");
            sb.Append("  LastChangedTerms: ").Append(LastChangedTerms).Append("\n");
            sb.Append("  LastSeenTerms: ").Append(LastSeenTerms).Append("\n");
            sb.Append("  MemberId: ").Append(MemberId).Append("\n");
            sb.Append("  PermittedCountry: ").Append(PermittedCountry).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
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
            return this.Equals(input as InlineResponse20016);
        }

        /// <summary>
        /// Returns true if InlineResponse20016 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20016 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20016 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Authenticated == input.Authenticated ||
                    (this.Authenticated != null &&
                    this.Authenticated.Equals(input.Authenticated))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.FamilyName == input.FamilyName ||
                    (this.FamilyName != null &&
                    this.FamilyName.Equals(input.FamilyName))
                ) && 
                (
                    this.GivenName == input.GivenName ||
                    (this.GivenName != null &&
                    this.GivenName.Equals(input.GivenName))
                ) && 
                (
                    this.IdSlug == input.IdSlug ||
                    (this.IdSlug != null &&
                    this.IdSlug.Equals(input.IdSlug))
                ) && 
                (
                    this.LastChangedTerms == input.LastChangedTerms ||
                    (this.LastChangedTerms != null &&
                    this.LastChangedTerms.Equals(input.LastChangedTerms))
                ) && 
                (
                    this.LastSeenTerms == input.LastSeenTerms ||
                    (this.LastSeenTerms != null &&
                    this.LastSeenTerms.Equals(input.LastSeenTerms))
                ) && 
                (
                    this.MemberId == input.MemberId ||
                    (this.MemberId != null &&
                    this.MemberId.Equals(input.MemberId))
                ) && 
                (
                    this.PermittedCountry == input.PermittedCountry ||
                    (this.PermittedCountry != null &&
                    this.PermittedCountry.Equals(input.PermittedCountry))
                ) && 
                (
                    this.Rate == input.Rate ||
                    (this.Rate != null &&
                    this.Rate.Equals(input.Rate))
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
                if (this.Authenticated != null)
                    hashCode = hashCode * 59 + this.Authenticated.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.FamilyName != null)
                    hashCode = hashCode * 59 + this.FamilyName.GetHashCode();
                if (this.GivenName != null)
                    hashCode = hashCode * 59 + this.GivenName.GetHashCode();
                if (this.IdSlug != null)
                    hashCode = hashCode * 59 + this.IdSlug.GetHashCode();
                if (this.LastChangedTerms != null)
                    hashCode = hashCode * 59 + this.LastChangedTerms.GetHashCode();
                if (this.LastSeenTerms != null)
                    hashCode = hashCode * 59 + this.LastSeenTerms.GetHashCode();
                if (this.MemberId != null)
                    hashCode = hashCode * 59 + this.MemberId.GetHashCode();
                if (this.PermittedCountry != null)
                    hashCode = hashCode * 59 + this.PermittedCountry.GetHashCode();
                if (this.Rate != null)
                    hashCode = hashCode * 59 + this.Rate.GetHashCode();
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
