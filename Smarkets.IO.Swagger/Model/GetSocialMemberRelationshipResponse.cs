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
    /// GetSocialMemberRelationshipResponse
    /// </summary>
    [DataContract]
        public partial class GetSocialMemberRelationshipResponse :  IEquatable<GetSocialMemberRelationshipResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSocialMemberRelationshipResponse" /> class.
        /// </summary>
        /// <param name="blocked">blocked.</param>
        /// <param name="blocking">blocking.</param>
        /// <param name="followers">followers.</param>
        /// <param name="following">following.</param>
        /// <param name="incomingFollowRequests">incomingFollowRequests.</param>
        /// <param name="outgoingFollowRequests">outgoingFollowRequests.</param>
        /// <param name="recommendations">recommendations.</param>
        public GetSocialMemberRelationshipResponse(List<int?> blocked = default(List<int?>), List<int?> blocking = default(List<int?>), List<int?> followers = default(List<int?>), List<int?> following = default(List<int?>), List<int?> incomingFollowRequests = default(List<int?>), List<int?> outgoingFollowRequests = default(List<int?>), List<int?> recommendations = default(List<int?>))
        {
            this.Blocked = blocked;
            this.Blocking = blocking;
            this.Followers = followers;
            this.Following = following;
            this.IncomingFollowRequests = incomingFollowRequests;
            this.OutgoingFollowRequests = outgoingFollowRequests;
            this.Recommendations = recommendations;
        }
        
        /// <summary>
        /// Gets or Sets Blocked
        /// </summary>
        [DataMember(Name="blocked", EmitDefaultValue=false)]
        public List<int?> Blocked { get; set; }

        /// <summary>
        /// Gets or Sets Blocking
        /// </summary>
        [DataMember(Name="blocking", EmitDefaultValue=false)]
        public List<int?> Blocking { get; set; }

        /// <summary>
        /// Gets or Sets Followers
        /// </summary>
        [DataMember(Name="followers", EmitDefaultValue=false)]
        public List<int?> Followers { get; set; }

        /// <summary>
        /// Gets or Sets Following
        /// </summary>
        [DataMember(Name="following", EmitDefaultValue=false)]
        public List<int?> Following { get; set; }

        /// <summary>
        /// Gets or Sets IncomingFollowRequests
        /// </summary>
        [DataMember(Name="incoming_follow_requests", EmitDefaultValue=false)]
        public List<int?> IncomingFollowRequests { get; set; }

        /// <summary>
        /// Gets or Sets OutgoingFollowRequests
        /// </summary>
        [DataMember(Name="outgoing_follow_requests", EmitDefaultValue=false)]
        public List<int?> OutgoingFollowRequests { get; set; }

        /// <summary>
        /// Gets or Sets Recommendations
        /// </summary>
        [DataMember(Name="recommendations", EmitDefaultValue=false)]
        public List<int?> Recommendations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetSocialMemberRelationshipResponse {\n");
            sb.Append("  Blocked: ").Append(Blocked).Append("\n");
            sb.Append("  Blocking: ").Append(Blocking).Append("\n");
            sb.Append("  Followers: ").Append(Followers).Append("\n");
            sb.Append("  Following: ").Append(Following).Append("\n");
            sb.Append("  IncomingFollowRequests: ").Append(IncomingFollowRequests).Append("\n");
            sb.Append("  OutgoingFollowRequests: ").Append(OutgoingFollowRequests).Append("\n");
            sb.Append("  Recommendations: ").Append(Recommendations).Append("\n");
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
            return this.Equals(input as GetSocialMemberRelationshipResponse);
        }

        /// <summary>
        /// Returns true if GetSocialMemberRelationshipResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetSocialMemberRelationshipResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetSocialMemberRelationshipResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Blocked == input.Blocked ||
                    this.Blocked != null &&
                    input.Blocked != null &&
                    this.Blocked.SequenceEqual(input.Blocked)
                ) && 
                (
                    this.Blocking == input.Blocking ||
                    this.Blocking != null &&
                    input.Blocking != null &&
                    this.Blocking.SequenceEqual(input.Blocking)
                ) && 
                (
                    this.Followers == input.Followers ||
                    this.Followers != null &&
                    input.Followers != null &&
                    this.Followers.SequenceEqual(input.Followers)
                ) && 
                (
                    this.Following == input.Following ||
                    this.Following != null &&
                    input.Following != null &&
                    this.Following.SequenceEqual(input.Following)
                ) && 
                (
                    this.IncomingFollowRequests == input.IncomingFollowRequests ||
                    this.IncomingFollowRequests != null &&
                    input.IncomingFollowRequests != null &&
                    this.IncomingFollowRequests.SequenceEqual(input.IncomingFollowRequests)
                ) && 
                (
                    this.OutgoingFollowRequests == input.OutgoingFollowRequests ||
                    this.OutgoingFollowRequests != null &&
                    input.OutgoingFollowRequests != null &&
                    this.OutgoingFollowRequests.SequenceEqual(input.OutgoingFollowRequests)
                ) && 
                (
                    this.Recommendations == input.Recommendations ||
                    this.Recommendations != null &&
                    input.Recommendations != null &&
                    this.Recommendations.SequenceEqual(input.Recommendations)
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
                if (this.Blocked != null)
                    hashCode = hashCode * 59 + this.Blocked.GetHashCode();
                if (this.Blocking != null)
                    hashCode = hashCode * 59 + this.Blocking.GetHashCode();
                if (this.Followers != null)
                    hashCode = hashCode * 59 + this.Followers.GetHashCode();
                if (this.Following != null)
                    hashCode = hashCode * 59 + this.Following.GetHashCode();
                if (this.IncomingFollowRequests != null)
                    hashCode = hashCode * 59 + this.IncomingFollowRequests.GetHashCode();
                if (this.OutgoingFollowRequests != null)
                    hashCode = hashCode * 59 + this.OutgoingFollowRequests.GetHashCode();
                if (this.Recommendations != null)
                    hashCode = hashCode * 59 + this.Recommendations.GetHashCode();
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
