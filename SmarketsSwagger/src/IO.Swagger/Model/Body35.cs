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
    /// Body35
    /// </summary>
    [DataContract]
        public partial class Body35 :  IEquatable<Body35>, IValidatableObject
    {
        /// <summary>
        /// Defines DeviceType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum DeviceTypeEnum
        {
            /// <summary>
            /// Enum Android for value: android
            /// </summary>
            [EnumMember(Value = "android")]
            Android = 1,
            /// <summary>
            /// Enum Ios for value: ios
            /// </summary>
            [EnumMember(Value = "ios")]
            Ios = 2,
            /// <summary>
            /// Enum Web for value: web
            /// </summary>
            [EnumMember(Value = "web")]
            Web = 3        }
        /// <summary>
        /// Gets or Sets DeviceType
        /// </summary>
        [DataMember(Name="device_type", EmitDefaultValue=false)]
        public DeviceTypeEnum? DeviceType { get; set; }
        /// <summary>
        /// Defines Kind
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum KindEnum
        {
            /// <summary>
            /// Enum Android for value: android
            /// </summary>
            [EnumMember(Value = "android")]
            Android = 1,
            /// <summary>
            /// Enum Ios for value: ios
            /// </summary>
            [EnumMember(Value = "ios")]
            Ios = 2,
            /// <summary>
            /// Enum Web for value: web
            /// </summary>
            [EnumMember(Value = "web")]
            Web = 3        }
        /// <summary>
        /// Gets or Sets Kind
        /// </summary>
        [DataMember(Name="kind", EmitDefaultValue=false)]
        public KindEnum? Kind { get; set; }
        /// <summary>
        /// Defines Sub
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum SubEnum
        {
            /// <summary>
            /// Enum Marketsettleperuser for value: market_settle_per_user
            /// </summary>
            [EnumMember(Value = "market_settle_per_user")]
            Marketsettleperuser = 1,
            /// <summary>
            /// Enum Materialpushnotification for value: material_push_notification
            /// </summary>
            [EnumMember(Value = "material_push_notification")]
            Materialpushnotification = 2,
            /// <summary>
            /// Enum Betmatch for value: bet_match
            /// </summary>
            [EnumMember(Value = "bet_match")]
            Betmatch = 3,
            /// <summary>
            /// Enum Marketingpushnotification for value: marketing_push_notification
            /// </summary>
            [EnumMember(Value = "marketing_push_notification")]
            Marketingpushnotification = 4,
            /// <summary>
            /// Enum Sbklivebetstatus for value: sbk_live_bet_status
            /// </summary>
            [EnumMember(Value = "sbk_live_bet_status")]
            Sbklivebetstatus = 5,
            /// <summary>
            /// Enum Socialfollow for value: social_follow
            /// </summary>
            [EnumMember(Value = "social_follow")]
            Socialfollow = 6,
            /// <summary>
            /// Enum Socialcomment for value: social_comment
            /// </summary>
            [EnumMember(Value = "social_comment")]
            Socialcomment = 7,
            /// <summary>
            /// Enum Socialmention for value: social_mention
            /// </summary>
            [EnumMember(Value = "social_mention")]
            Socialmention = 8,
            /// <summary>
            /// Enum Socialreaction for value: social_reaction
            /// </summary>
            [EnumMember(Value = "social_reaction")]
            Socialreaction = 9,
            /// <summary>
            /// Enum Materialeventgoal for value: material_event_goal
            /// </summary>
            [EnumMember(Value = "material_event_goal")]
            Materialeventgoal = 10,
            /// <summary>
            /// Enum Materialeventredcard for value: material_event_red_card
            /// </summary>
            [EnumMember(Value = "material_event_red_card")]
            Materialeventredcard = 11,
            /// <summary>
            /// Enum Materialeventgamestart for value: material_event_game_start
            /// </summary>
            [EnumMember(Value = "material_event_game_start")]
            Materialeventgamestart = 12,
            /// <summary>
            /// Enum Materialeventhalftimestart for value: material_event_halftime_start
            /// </summary>
            [EnumMember(Value = "material_event_halftime_start")]
            Materialeventhalftimestart = 13,
            /// <summary>
            /// Enum Materialeventovertimestart for value: material_event_overtime_start
            /// </summary>
            [EnumMember(Value = "material_event_overtime_start")]
            Materialeventovertimestart = 14,
            /// <summary>
            /// Enum Materialeventpenaltystart for value: material_event_penalty_start
            /// </summary>
            [EnumMember(Value = "material_event_penalty_start")]
            Materialeventpenaltystart = 15        }
        /// <summary>
        /// Gets or Sets Sub
        /// </summary>
        [DataMember(Name="sub", EmitDefaultValue=false)]
        public List<SubEnum> Sub { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Body35" /> class.
        /// </summary>
        /// <param name="deviceType">deviceType.</param>
        /// <param name="kind">kind.</param>
        /// <param name="registrationId">registrationId (required).</param>
        /// <param name="sub">sub.</param>
        public Body35(DeviceTypeEnum? deviceType = default(DeviceTypeEnum?), KindEnum? kind = default(KindEnum?), string registrationId = default(string), List<SubEnum> sub = default(List<SubEnum>))
        {
            // to ensure "registrationId" is required (not null)
            if (registrationId == null)
            {
                throw new InvalidDataException("registrationId is a required property for Body35 and cannot be null");
            }
            else
            {
                this.RegistrationId = registrationId;
            }
            this.DeviceType = deviceType;
            this.Kind = kind;
            this.Sub = sub;
        }
        


        /// <summary>
        /// Gets or Sets RegistrationId
        /// </summary>
        [DataMember(Name="registration_id", EmitDefaultValue=false)]
        public string RegistrationId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Body35 {\n");
            sb.Append("  DeviceType: ").Append(DeviceType).Append("\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  RegistrationId: ").Append(RegistrationId).Append("\n");
            sb.Append("  Sub: ").Append(Sub).Append("\n");
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
            return this.Equals(input as Body35);
        }

        /// <summary>
        /// Returns true if Body35 instances are equal
        /// </summary>
        /// <param name="input">Instance of Body35 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Body35 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeviceType == input.DeviceType ||
                    (this.DeviceType != null &&
                    this.DeviceType.Equals(input.DeviceType))
                ) && 
                (
                    this.Kind == input.Kind ||
                    (this.Kind != null &&
                    this.Kind.Equals(input.Kind))
                ) && 
                (
                    this.RegistrationId == input.RegistrationId ||
                    (this.RegistrationId != null &&
                    this.RegistrationId.Equals(input.RegistrationId))
                ) && 
                (
                    this.Sub == input.Sub ||
                    this.Sub != null &&
                    input.Sub != null &&
                    this.Sub.SequenceEqual(input.Sub)
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
                if (this.DeviceType != null)
                    hashCode = hashCode * 59 + this.DeviceType.GetHashCode();
                if (this.Kind != null)
                    hashCode = hashCode * 59 + this.Kind.GetHashCode();
                if (this.RegistrationId != null)
                    hashCode = hashCode * 59 + this.RegistrationId.GetHashCode();
                if (this.Sub != null)
                    hashCode = hashCode * 59 + this.Sub.GetHashCode();
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