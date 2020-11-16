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
    /// UpdateMemberRequest
    /// </summary>
    [DataContract]
        public partial class UpdateMemberRequest :  IEquatable<UpdateMemberRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMemberRequest" /> class.
        /// </summary>
        /// <param name="bio">bio.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="favouriteSportsDescription">favouriteSportsDescription.</param>
        /// <param name="favouriteTeamsDescription">favouriteTeamsDescription.</param>
        /// <param name="isPrivate">isPrivate.</param>
        /// <param name="username">username.</param>
        public UpdateMemberRequest(string bio = default(string), string displayName = default(string), string favouriteSportsDescription = default(string), string favouriteTeamsDescription = default(string), bool? isPrivate = default(bool?), string username = default(string))
        {
            this.Bio = bio;
            this.DisplayName = displayName;
            this.FavouriteSportsDescription = favouriteSportsDescription;
            this.FavouriteTeamsDescription = favouriteTeamsDescription;
            this.IsPrivate = isPrivate;
            this.Username = username;
        }
        
        /// <summary>
        /// Gets or Sets Bio
        /// </summary>
        [DataMember(Name="bio", EmitDefaultValue=false)]
        public string Bio { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets FavouriteSportsDescription
        /// </summary>
        [DataMember(Name="favourite_sports_description", EmitDefaultValue=false)]
        public string FavouriteSportsDescription { get; set; }

        /// <summary>
        /// Gets or Sets FavouriteTeamsDescription
        /// </summary>
        [DataMember(Name="favourite_teams_description", EmitDefaultValue=false)]
        public string FavouriteTeamsDescription { get; set; }

        /// <summary>
        /// Gets or Sets IsPrivate
        /// </summary>
        [DataMember(Name="is_private", EmitDefaultValue=false)]
        public bool? IsPrivate { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateMemberRequest {\n");
            sb.Append("  Bio: ").Append(Bio).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  FavouriteSportsDescription: ").Append(FavouriteSportsDescription).Append("\n");
            sb.Append("  FavouriteTeamsDescription: ").Append(FavouriteTeamsDescription).Append("\n");
            sb.Append("  IsPrivate: ").Append(IsPrivate).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
            return this.Equals(input as UpdateMemberRequest);
        }

        /// <summary>
        /// Returns true if UpdateMemberRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateMemberRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateMemberRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Bio == input.Bio ||
                    (this.Bio != null &&
                    this.Bio.Equals(input.Bio))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.FavouriteSportsDescription == input.FavouriteSportsDescription ||
                    (this.FavouriteSportsDescription != null &&
                    this.FavouriteSportsDescription.Equals(input.FavouriteSportsDescription))
                ) && 
                (
                    this.FavouriteTeamsDescription == input.FavouriteTeamsDescription ||
                    (this.FavouriteTeamsDescription != null &&
                    this.FavouriteTeamsDescription.Equals(input.FavouriteTeamsDescription))
                ) && 
                (
                    this.IsPrivate == input.IsPrivate ||
                    (this.IsPrivate != null &&
                    this.IsPrivate.Equals(input.IsPrivate))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
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
                if (this.Bio != null)
                    hashCode = hashCode * 59 + this.Bio.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.FavouriteSportsDescription != null)
                    hashCode = hashCode * 59 + this.FavouriteSportsDescription.GetHashCode();
                if (this.FavouriteTeamsDescription != null)
                    hashCode = hashCode * 59 + this.FavouriteTeamsDescription.GetHashCode();
                if (this.IsPrivate != null)
                    hashCode = hashCode * 59 + this.IsPrivate.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
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