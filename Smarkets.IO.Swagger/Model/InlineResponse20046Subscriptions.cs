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
    /// InlineResponse20046Subscriptions
    /// </summary>
    [DataContract]
        public partial class InlineResponse20046Subscriptions :  IEquatable<InlineResponse20046Subscriptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20046Subscriptions" /> class.
        /// </summary>
        /// <param name="betMatch">betMatch (required).</param>
        /// <param name="eventId">This ID uniquely identifies an event (required).</param>
        /// <param name="marketSettlePerUser">marketSettlePerUser (required).</param>
        /// <param name="marketingPushNotification">marketingPushNotification.</param>
        /// <param name="materialEventGameStart">materialEventGameStart (required).</param>
        /// <param name="materialEventGoal">materialEventGoal (required).</param>
        /// <param name="materialEventHalftimeStart">materialEventHalftimeStart (required).</param>
        /// <param name="materialEventOvertimeStart">materialEventOvertimeStart (required).</param>
        /// <param name="materialEventPenaltyStart">materialEventPenaltyStart (required).</param>
        /// <param name="materialEventRedCard">materialEventRedCard (required).</param>
        /// <param name="materialPushNotification">materialPushNotification (required).</param>
        /// <param name="sbkLiveBetStatus">sbkLiveBetStatus.</param>
        /// <param name="socialComment">socialComment.</param>
        /// <param name="socialFollow">socialFollow.</param>
        /// <param name="socialMention">socialMention.</param>
        /// <param name="socialReaction">socialReaction.</param>
        public InlineResponse20046Subscriptions(bool? betMatch = default(bool?), string eventId = default(string), bool? marketSettlePerUser = default(bool?), bool? marketingPushNotification = default(bool?), bool? materialEventGameStart = default(bool?), bool? materialEventGoal = default(bool?), bool? materialEventHalftimeStart = default(bool?), bool? materialEventOvertimeStart = default(bool?), bool? materialEventPenaltyStart = default(bool?), bool? materialEventRedCard = default(bool?), bool? materialPushNotification = default(bool?), bool? sbkLiveBetStatus = default(bool?), bool? socialComment = default(bool?), bool? socialFollow = default(bool?), bool? socialMention = default(bool?), bool? socialReaction = default(bool?))
        {
            // to ensure "betMatch" is required (not null)
            if (betMatch == null)
            {
                throw new InvalidDataException("betMatch is a required property for InlineResponse20046Subscriptions and cannot be null");
            }
            else
            {
                this.BetMatch = betMatch;
            }
            // to ensure "eventId" is required (not null)
            if (eventId == null)
            {
                throw new InvalidDataException("eventId is a required property for InlineResponse20046Subscriptions and cannot be null");
            }
            else
            {
                this.EventId = eventId;
            }
            // to ensure "marketSettlePerUser" is required (not null)
            if (marketSettlePerUser == null)
            {
                throw new InvalidDataException("marketSettlePerUser is a required property for InlineResponse20046Subscriptions and cannot be null");
            }
            else
            {
                this.MarketSettlePerUser = marketSettlePerUser;
            }
            // to ensure "materialEventGameStart" is required (not null)
            if (materialEventGameStart == null)
            {
                throw new InvalidDataException("materialEventGameStart is a required property for InlineResponse20046Subscriptions and cannot be null");
            }
            else
            {
                this.MaterialEventGameStart = materialEventGameStart;
            }
            // to ensure "materialEventGoal" is required (not null)
            if (materialEventGoal == null)
            {
                throw new InvalidDataException("materialEventGoal is a required property for InlineResponse20046Subscriptions and cannot be null");
            }
            else
            {
                this.MaterialEventGoal = materialEventGoal;
            }
            // to ensure "materialEventHalftimeStart" is required (not null)
            if (materialEventHalftimeStart == null)
            {
                throw new InvalidDataException("materialEventHalftimeStart is a required property for InlineResponse20046Subscriptions and cannot be null");
            }
            else
            {
                this.MaterialEventHalftimeStart = materialEventHalftimeStart;
            }
            // to ensure "materialEventOvertimeStart" is required (not null)
            if (materialEventOvertimeStart == null)
            {
                throw new InvalidDataException("materialEventOvertimeStart is a required property for InlineResponse20046Subscriptions and cannot be null");
            }
            else
            {
                this.MaterialEventOvertimeStart = materialEventOvertimeStart;
            }
            // to ensure "materialEventPenaltyStart" is required (not null)
            if (materialEventPenaltyStart == null)
            {
                throw new InvalidDataException("materialEventPenaltyStart is a required property for InlineResponse20046Subscriptions and cannot be null");
            }
            else
            {
                this.MaterialEventPenaltyStart = materialEventPenaltyStart;
            }
            // to ensure "materialEventRedCard" is required (not null)
            if (materialEventRedCard == null)
            {
                throw new InvalidDataException("materialEventRedCard is a required property for InlineResponse20046Subscriptions and cannot be null");
            }
            else
            {
                this.MaterialEventRedCard = materialEventRedCard;
            }
            // to ensure "materialPushNotification" is required (not null)
            if (materialPushNotification == null)
            {
                throw new InvalidDataException("materialPushNotification is a required property for InlineResponse20046Subscriptions and cannot be null");
            }
            else
            {
                this.MaterialPushNotification = materialPushNotification;
            }
            this.MarketingPushNotification = marketingPushNotification;
            this.SbkLiveBetStatus = sbkLiveBetStatus;
            this.SocialComment = socialComment;
            this.SocialFollow = socialFollow;
            this.SocialMention = socialMention;
            this.SocialReaction = socialReaction;
        }
        
        /// <summary>
        /// Gets or Sets BetMatch
        /// </summary>
        [DataMember(Name="bet_match", EmitDefaultValue=false)]
        public bool? BetMatch { get; set; }

        /// <summary>
        /// This ID uniquely identifies an event
        /// </summary>
        /// <value>This ID uniquely identifies an event</value>
        [DataMember(Name="event_id", EmitDefaultValue=false)]
        public string EventId { get; set; }

        /// <summary>
        /// Gets or Sets MarketSettlePerUser
        /// </summary>
        [DataMember(Name="market_settle_per_user", EmitDefaultValue=false)]
        public bool? MarketSettlePerUser { get; set; }

        /// <summary>
        /// Gets or Sets MarketingPushNotification
        /// </summary>
        [DataMember(Name="marketing_push_notification", EmitDefaultValue=false)]
        public bool? MarketingPushNotification { get; set; }

        /// <summary>
        /// Gets or Sets MaterialEventGameStart
        /// </summary>
        [DataMember(Name="material_event_game_start", EmitDefaultValue=false)]
        public bool? MaterialEventGameStart { get; set; }

        /// <summary>
        /// Gets or Sets MaterialEventGoal
        /// </summary>
        [DataMember(Name="material_event_goal", EmitDefaultValue=false)]
        public bool? MaterialEventGoal { get; set; }

        /// <summary>
        /// Gets or Sets MaterialEventHalftimeStart
        /// </summary>
        [DataMember(Name="material_event_halftime_start", EmitDefaultValue=false)]
        public bool? MaterialEventHalftimeStart { get; set; }

        /// <summary>
        /// Gets or Sets MaterialEventOvertimeStart
        /// </summary>
        [DataMember(Name="material_event_overtime_start", EmitDefaultValue=false)]
        public bool? MaterialEventOvertimeStart { get; set; }

        /// <summary>
        /// Gets or Sets MaterialEventPenaltyStart
        /// </summary>
        [DataMember(Name="material_event_penalty_start", EmitDefaultValue=false)]
        public bool? MaterialEventPenaltyStart { get; set; }

        /// <summary>
        /// Gets or Sets MaterialEventRedCard
        /// </summary>
        [DataMember(Name="material_event_red_card", EmitDefaultValue=false)]
        public bool? MaterialEventRedCard { get; set; }

        /// <summary>
        /// Gets or Sets MaterialPushNotification
        /// </summary>
        [DataMember(Name="material_push_notification", EmitDefaultValue=false)]
        public bool? MaterialPushNotification { get; set; }

        /// <summary>
        /// Gets or Sets SbkLiveBetStatus
        /// </summary>
        [DataMember(Name="sbk_live_bet_status", EmitDefaultValue=false)]
        public bool? SbkLiveBetStatus { get; set; }

        /// <summary>
        /// Gets or Sets SocialComment
        /// </summary>
        [DataMember(Name="social_comment", EmitDefaultValue=false)]
        public bool? SocialComment { get; set; }

        /// <summary>
        /// Gets or Sets SocialFollow
        /// </summary>
        [DataMember(Name="social_follow", EmitDefaultValue=false)]
        public bool? SocialFollow { get; set; }

        /// <summary>
        /// Gets or Sets SocialMention
        /// </summary>
        [DataMember(Name="social_mention", EmitDefaultValue=false)]
        public bool? SocialMention { get; set; }

        /// <summary>
        /// Gets or Sets SocialReaction
        /// </summary>
        [DataMember(Name="social_reaction", EmitDefaultValue=false)]
        public bool? SocialReaction { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20046Subscriptions {\n");
            sb.Append("  BetMatch: ").Append(BetMatch).Append("\n");
            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  MarketSettlePerUser: ").Append(MarketSettlePerUser).Append("\n");
            sb.Append("  MarketingPushNotification: ").Append(MarketingPushNotification).Append("\n");
            sb.Append("  MaterialEventGameStart: ").Append(MaterialEventGameStart).Append("\n");
            sb.Append("  MaterialEventGoal: ").Append(MaterialEventGoal).Append("\n");
            sb.Append("  MaterialEventHalftimeStart: ").Append(MaterialEventHalftimeStart).Append("\n");
            sb.Append("  MaterialEventOvertimeStart: ").Append(MaterialEventOvertimeStart).Append("\n");
            sb.Append("  MaterialEventPenaltyStart: ").Append(MaterialEventPenaltyStart).Append("\n");
            sb.Append("  MaterialEventRedCard: ").Append(MaterialEventRedCard).Append("\n");
            sb.Append("  MaterialPushNotification: ").Append(MaterialPushNotification).Append("\n");
            sb.Append("  SbkLiveBetStatus: ").Append(SbkLiveBetStatus).Append("\n");
            sb.Append("  SocialComment: ").Append(SocialComment).Append("\n");
            sb.Append("  SocialFollow: ").Append(SocialFollow).Append("\n");
            sb.Append("  SocialMention: ").Append(SocialMention).Append("\n");
            sb.Append("  SocialReaction: ").Append(SocialReaction).Append("\n");
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
            return this.Equals(input as InlineResponse20046Subscriptions);
        }

        /// <summary>
        /// Returns true if InlineResponse20046Subscriptions instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20046Subscriptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20046Subscriptions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BetMatch == input.BetMatch ||
                    (this.BetMatch != null &&
                    this.BetMatch.Equals(input.BetMatch))
                ) && 
                (
                    this.EventId == input.EventId ||
                    (this.EventId != null &&
                    this.EventId.Equals(input.EventId))
                ) && 
                (
                    this.MarketSettlePerUser == input.MarketSettlePerUser ||
                    (this.MarketSettlePerUser != null &&
                    this.MarketSettlePerUser.Equals(input.MarketSettlePerUser))
                ) && 
                (
                    this.MarketingPushNotification == input.MarketingPushNotification ||
                    (this.MarketingPushNotification != null &&
                    this.MarketingPushNotification.Equals(input.MarketingPushNotification))
                ) && 
                (
                    this.MaterialEventGameStart == input.MaterialEventGameStart ||
                    (this.MaterialEventGameStart != null &&
                    this.MaterialEventGameStart.Equals(input.MaterialEventGameStart))
                ) && 
                (
                    this.MaterialEventGoal == input.MaterialEventGoal ||
                    (this.MaterialEventGoal != null &&
                    this.MaterialEventGoal.Equals(input.MaterialEventGoal))
                ) && 
                (
                    this.MaterialEventHalftimeStart == input.MaterialEventHalftimeStart ||
                    (this.MaterialEventHalftimeStart != null &&
                    this.MaterialEventHalftimeStart.Equals(input.MaterialEventHalftimeStart))
                ) && 
                (
                    this.MaterialEventOvertimeStart == input.MaterialEventOvertimeStart ||
                    (this.MaterialEventOvertimeStart != null &&
                    this.MaterialEventOvertimeStart.Equals(input.MaterialEventOvertimeStart))
                ) && 
                (
                    this.MaterialEventPenaltyStart == input.MaterialEventPenaltyStart ||
                    (this.MaterialEventPenaltyStart != null &&
                    this.MaterialEventPenaltyStart.Equals(input.MaterialEventPenaltyStart))
                ) && 
                (
                    this.MaterialEventRedCard == input.MaterialEventRedCard ||
                    (this.MaterialEventRedCard != null &&
                    this.MaterialEventRedCard.Equals(input.MaterialEventRedCard))
                ) && 
                (
                    this.MaterialPushNotification == input.MaterialPushNotification ||
                    (this.MaterialPushNotification != null &&
                    this.MaterialPushNotification.Equals(input.MaterialPushNotification))
                ) && 
                (
                    this.SbkLiveBetStatus == input.SbkLiveBetStatus ||
                    (this.SbkLiveBetStatus != null &&
                    this.SbkLiveBetStatus.Equals(input.SbkLiveBetStatus))
                ) && 
                (
                    this.SocialComment == input.SocialComment ||
                    (this.SocialComment != null &&
                    this.SocialComment.Equals(input.SocialComment))
                ) && 
                (
                    this.SocialFollow == input.SocialFollow ||
                    (this.SocialFollow != null &&
                    this.SocialFollow.Equals(input.SocialFollow))
                ) && 
                (
                    this.SocialMention == input.SocialMention ||
                    (this.SocialMention != null &&
                    this.SocialMention.Equals(input.SocialMention))
                ) && 
                (
                    this.SocialReaction == input.SocialReaction ||
                    (this.SocialReaction != null &&
                    this.SocialReaction.Equals(input.SocialReaction))
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
                if (this.BetMatch != null)
                    hashCode = hashCode * 59 + this.BetMatch.GetHashCode();
                if (this.EventId != null)
                    hashCode = hashCode * 59 + this.EventId.GetHashCode();
                if (this.MarketSettlePerUser != null)
                    hashCode = hashCode * 59 + this.MarketSettlePerUser.GetHashCode();
                if (this.MarketingPushNotification != null)
                    hashCode = hashCode * 59 + this.MarketingPushNotification.GetHashCode();
                if (this.MaterialEventGameStart != null)
                    hashCode = hashCode * 59 + this.MaterialEventGameStart.GetHashCode();
                if (this.MaterialEventGoal != null)
                    hashCode = hashCode * 59 + this.MaterialEventGoal.GetHashCode();
                if (this.MaterialEventHalftimeStart != null)
                    hashCode = hashCode * 59 + this.MaterialEventHalftimeStart.GetHashCode();
                if (this.MaterialEventOvertimeStart != null)
                    hashCode = hashCode * 59 + this.MaterialEventOvertimeStart.GetHashCode();
                if (this.MaterialEventPenaltyStart != null)
                    hashCode = hashCode * 59 + this.MaterialEventPenaltyStart.GetHashCode();
                if (this.MaterialEventRedCard != null)
                    hashCode = hashCode * 59 + this.MaterialEventRedCard.GetHashCode();
                if (this.MaterialPushNotification != null)
                    hashCode = hashCode * 59 + this.MaterialPushNotification.GetHashCode();
                if (this.SbkLiveBetStatus != null)
                    hashCode = hashCode * 59 + this.SbkLiveBetStatus.GetHashCode();
                if (this.SocialComment != null)
                    hashCode = hashCode * 59 + this.SocialComment.GetHashCode();
                if (this.SocialFollow != null)
                    hashCode = hashCode * 59 + this.SocialFollow.GetHashCode();
                if (this.SocialMention != null)
                    hashCode = hashCode * 59 + this.SocialMention.GetHashCode();
                if (this.SocialReaction != null)
                    hashCode = hashCode * 59 + this.SocialReaction.GetHashCode();
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