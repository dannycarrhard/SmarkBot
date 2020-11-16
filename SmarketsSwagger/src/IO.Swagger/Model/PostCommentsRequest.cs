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
    /// PostCommentsRequest
    /// </summary>
    [DataContract]
        public partial class PostCommentsRequest :  IEquatable<PostCommentsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostCommentsRequest" /> class.
        /// </summary>
        /// <param name="commentText">commentText.</param>
        /// <param name="contractId">This ID uniquely identifies the contract.</param>
        /// <param name="eventId">This ID uniquely identifies an event.</param>
        /// <param name="hideStake">hideStake.</param>
        /// <param name="legacyCommentId">legacyCommentId.</param>
        /// <param name="link">link.</param>
        /// <param name="marketId">This ID uniquely identifies the market.</param>
        /// <param name="mentions">mentions.</param>
        /// <param name="odds">odds.</param>
        /// <param name="parentCommentId">parentCommentId.</param>
        /// <param name="stake">stake.</param>
        public PostCommentsRequest(string commentText = default(string), string contractId = default(string), string eventId = default(string), bool? hideStake = default(bool?), int? legacyCommentId = default(int?), string link = default(string), string marketId = default(string), List<int?> mentions = default(List<int?>), int? odds = default(int?), int? parentCommentId = default(int?), string stake = default(string), string contractId = default(string), string eventId = default(string), string marketId = default(string))
        {
            this.CommentText = commentText;
            this.ContractId = contractId;
            this.EventId = eventId;
            this.HideStake = hideStake;
            this.LegacyCommentId = legacyCommentId;
            this.Link = link;
            this.MarketId = marketId;
            this.Mentions = mentions;
            this.Odds = odds;
            this.ParentCommentId = parentCommentId;
            this.Stake = stake;
        }
        
        /// <summary>
        /// Gets or Sets CommentText
        /// </summary>
        [DataMember(Name="comment_text", EmitDefaultValue=false)]
        public string CommentText { get; set; }

        /// <summary>
        /// This ID uniquely identifies the contract
        /// </summary>
        /// <value>This ID uniquely identifies the contract</value>
        [DataMember(Name="contract_id", EmitDefaultValue=false)]
        public string ContractId { get; set; }

        /// <summary>
        /// This ID uniquely identifies an event
        /// </summary>
        /// <value>This ID uniquely identifies an event</value>
        [DataMember(Name="event_id", EmitDefaultValue=false)]
        public string EventId { get; set; }

        /// <summary>
        /// Gets or Sets HideStake
        /// </summary>
        [DataMember(Name="hide_stake", EmitDefaultValue=false)]
        public bool? HideStake { get; set; }

        /// <summary>
        /// Gets or Sets LegacyCommentId
        /// </summary>
        [DataMember(Name="legacy_comment_id", EmitDefaultValue=false)]
        public int? LegacyCommentId { get; set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public string Link { get; set; }

        /// <summary>
        /// This ID uniquely identifies the market
        /// </summary>
        /// <value>This ID uniquely identifies the market</value>
        [DataMember(Name="market_id", EmitDefaultValue=false)]
        public string MarketId { get; set; }

        /// <summary>
        /// Gets or Sets Mentions
        /// </summary>
        [DataMember(Name="mentions", EmitDefaultValue=false)]
        public List<int?> Mentions { get; set; }

        /// <summary>
        /// Gets or Sets Odds
        /// </summary>
        [DataMember(Name="odds", EmitDefaultValue=false)]
        public int? Odds { get; set; }

        /// <summary>
        /// Gets or Sets ParentCommentId
        /// </summary>
        [DataMember(Name="parent_comment_id", EmitDefaultValue=false)]
        public int? ParentCommentId { get; set; }

        /// <summary>
        /// Gets or Sets Stake
        /// </summary>
        [DataMember(Name="stake", EmitDefaultValue=false)]
        public string Stake { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostCommentsRequest {\n");
            sb.Append("  CommentText: ").Append(CommentText).Append("\n");
            sb.Append("  ContractId: ").Append(ContractId).Append("\n");
            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  HideStake: ").Append(HideStake).Append("\n");
            sb.Append("  LegacyCommentId: ").Append(LegacyCommentId).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  MarketId: ").Append(MarketId).Append("\n");
            sb.Append("  Mentions: ").Append(Mentions).Append("\n");
            sb.Append("  Odds: ").Append(Odds).Append("\n");
            sb.Append("  ParentCommentId: ").Append(ParentCommentId).Append("\n");
            sb.Append("  Stake: ").Append(Stake).Append("\n");
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
            return this.Equals(input as PostCommentsRequest);
        }

        /// <summary>
        /// Returns true if PostCommentsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PostCommentsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostCommentsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CommentText == input.CommentText ||
                    (this.CommentText != null &&
                    this.CommentText.Equals(input.CommentText))
                ) && 
                (
                    this.ContractId == input.ContractId ||
                    (this.ContractId != null &&
                    this.ContractId.Equals(input.ContractId))
                ) && 
                (
                    this.EventId == input.EventId ||
                    (this.EventId != null &&
                    this.EventId.Equals(input.EventId))
                ) && 
                (
                    this.HideStake == input.HideStake ||
                    (this.HideStake != null &&
                    this.HideStake.Equals(input.HideStake))
                ) && 
                (
                    this.LegacyCommentId == input.LegacyCommentId ||
                    (this.LegacyCommentId != null &&
                    this.LegacyCommentId.Equals(input.LegacyCommentId))
                ) && 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
                ) && 
                (
                    this.MarketId == input.MarketId ||
                    (this.MarketId != null &&
                    this.MarketId.Equals(input.MarketId))
                ) && 
                (
                    this.Mentions == input.Mentions ||
                    this.Mentions != null &&
                    input.Mentions != null &&
                    this.Mentions.SequenceEqual(input.Mentions)
                ) && 
                (
                    this.Odds == input.Odds ||
                    (this.Odds != null &&
                    this.Odds.Equals(input.Odds))
                ) && 
                (
                    this.ParentCommentId == input.ParentCommentId ||
                    (this.ParentCommentId != null &&
                    this.ParentCommentId.Equals(input.ParentCommentId))
                ) && 
                (
                    this.Stake == input.Stake ||
                    (this.Stake != null &&
                    this.Stake.Equals(input.Stake))
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
                if (this.CommentText != null)
                    hashCode = hashCode * 59 + this.CommentText.GetHashCode();
                if (this.ContractId != null)
                    hashCode = hashCode * 59 + this.ContractId.GetHashCode();
                if (this.EventId != null)
                    hashCode = hashCode * 59 + this.EventId.GetHashCode();
                if (this.HideStake != null)
                    hashCode = hashCode * 59 + this.HideStake.GetHashCode();
                if (this.LegacyCommentId != null)
                    hashCode = hashCode * 59 + this.LegacyCommentId.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                if (this.MarketId != null)
                    hashCode = hashCode * 59 + this.MarketId.GetHashCode();
                if (this.Mentions != null)
                    hashCode = hashCode * 59 + this.Mentions.GetHashCode();
                if (this.Odds != null)
                    hashCode = hashCode * 59 + this.Odds.GetHashCode();
                if (this.ParentCommentId != null)
                    hashCode = hashCode * 59 + this.ParentCommentId.GetHashCode();
                if (this.Stake != null)
                    hashCode = hashCode * 59 + this.Stake.GetHashCode();
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