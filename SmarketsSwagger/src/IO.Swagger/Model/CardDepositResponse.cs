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
    /// CardDepositResponse
    /// </summary>
    [DataContract]
        public partial class CardDepositResponse :  IEquatable<CardDepositResponse>, IValidatableObject
    {
        /// <summary>
        /// Defines PaymentType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum PaymentTypeEnum
        {
            /// <summary>
            /// Enum Card for value: card
            /// </summary>
            [EnumMember(Value = "card")]
            Card = 1,
            /// <summary>
            /// Enum Googlepay for value: googlepay
            /// </summary>
            [EnumMember(Value = "googlepay")]
            Googlepay = 2,
            /// <summary>
            /// Enum Applepay for value: applepay
            /// </summary>
            [EnumMember(Value = "applepay")]
            Applepay = 3        }
        /// <summary>
        /// Gets or Sets PaymentType
        /// </summary>
        [DataMember(Name="payment_type", EmitDefaultValue=false)]
        public PaymentTypeEnum? PaymentType { get; set; }
        /// <summary>
        /// Defines State
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StateEnum
        {
            /// <summary>
            /// Enum New for value: new
            /// </summary>
            [EnumMember(Value = "new")]
            New = 1,
            /// <summary>
            /// Enum Authorised for value: authorised
            /// </summary>
            [EnumMember(Value = "authorised")]
            Authorised = 2,
            /// <summary>
            /// Enum Failed for value: failed
            /// </summary>
            [EnumMember(Value = "failed")]
            Failed = 3,
            /// <summary>
            /// Enum Expired for value: expired
            /// </summary>
            [EnumMember(Value = "expired")]
            Expired = 4,
            /// <summary>
            /// Enum Credited for value: credited
            /// </summary>
            [EnumMember(Value = "credited")]
            Credited = 5        }
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CardDepositResponse" /> class.
        /// </summary>
        /// <param name="amount">amount (required).</param>
        /// <param name="authCode">authCode (required).</param>
        /// <param name="captured">captured (required).</param>
        /// <param name="fee">fee (required).</param>
        /// <param name="fraudPass">fraudPass (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="methodId">methodId (required).</param>
        /// <param name="paymentType">paymentType.</param>
        /// <param name="providerId">providerId (required).</param>
        /// <param name="redirectUrl">redirectUrl (required).</param>
        /// <param name="state">state (required).</param>
        /// <param name="threeDSecure">threeDSecure (required).</param>
        /// <param name="timestamp">timestamp (required).</param>
        public CardDepositResponse(string amount = default(string), string authCode = default(string), DateTime? captured = default(DateTime?), string fee = default(string), bool? fraudPass = default(bool?), string id = default(string), string methodId = default(string), PaymentTypeEnum? paymentType = default(PaymentTypeEnum?), string providerId = default(string), string redirectUrl = default(string), StateEnum state = default(StateEnum), bool? threeDSecure = default(bool?), string timestamp = default(string))
        {
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for CardDepositResponse and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }
            // to ensure "authCode" is required (not null)
            if (authCode == null)
            {
                throw new InvalidDataException("authCode is a required property for CardDepositResponse and cannot be null");
            }
            else
            {
                this.AuthCode = authCode;
            }
            // to ensure "captured" is required (not null)
            if (captured == null)
            {
                throw new InvalidDataException("captured is a required property for CardDepositResponse and cannot be null");
            }
            else
            {
                this.Captured = captured;
            }
            // to ensure "fee" is required (not null)
            if (fee == null)
            {
                throw new InvalidDataException("fee is a required property for CardDepositResponse and cannot be null");
            }
            else
            {
                this.Fee = fee;
            }
            // to ensure "fraudPass" is required (not null)
            if (fraudPass == null)
            {
                throw new InvalidDataException("fraudPass is a required property for CardDepositResponse and cannot be null");
            }
            else
            {
                this.FraudPass = fraudPass;
            }
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for CardDepositResponse and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "methodId" is required (not null)
            if (methodId == null)
            {
                throw new InvalidDataException("methodId is a required property for CardDepositResponse and cannot be null");
            }
            else
            {
                this.MethodId = methodId;
            }
            // to ensure "providerId" is required (not null)
            if (providerId == null)
            {
                throw new InvalidDataException("providerId is a required property for CardDepositResponse and cannot be null");
            }
            else
            {
                this.ProviderId = providerId;
            }
            // to ensure "redirectUrl" is required (not null)
            if (redirectUrl == null)
            {
                throw new InvalidDataException("redirectUrl is a required property for CardDepositResponse and cannot be null");
            }
            else
            {
                this.RedirectUrl = redirectUrl;
            }
            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new InvalidDataException("state is a required property for CardDepositResponse and cannot be null");
            }
            else
            {
                this.State = state;
            }
            // to ensure "threeDSecure" is required (not null)
            if (threeDSecure == null)
            {
                throw new InvalidDataException("threeDSecure is a required property for CardDepositResponse and cannot be null");
            }
            else
            {
                this.ThreeDSecure = threeDSecure;
            }
            // to ensure "timestamp" is required (not null)
            if (timestamp == null)
            {
                throw new InvalidDataException("timestamp is a required property for CardDepositResponse and cannot be null");
            }
            else
            {
                this.Timestamp = timestamp;
            }
            this.PaymentType = paymentType;
        }
        
        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public string Amount { get; set; }

        /// <summary>
        /// Gets or Sets AuthCode
        /// </summary>
        [DataMember(Name="auth_code", EmitDefaultValue=false)]
        public string AuthCode { get; set; }

        /// <summary>
        /// Gets or Sets Captured
        /// </summary>
        [DataMember(Name="captured", EmitDefaultValue=false)]
        public DateTime? Captured { get; set; }

        /// <summary>
        /// Gets or Sets Fee
        /// </summary>
        [DataMember(Name="fee", EmitDefaultValue=false)]
        public string Fee { get; set; }

        /// <summary>
        /// Gets or Sets FraudPass
        /// </summary>
        [DataMember(Name="fraud_pass", EmitDefaultValue=false)]
        public bool? FraudPass { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets MethodId
        /// </summary>
        [DataMember(Name="method_id", EmitDefaultValue=false)]
        public string MethodId { get; set; }


        /// <summary>
        /// Gets or Sets ProviderId
        /// </summary>
        [DataMember(Name="provider_id", EmitDefaultValue=false)]
        public string ProviderId { get; set; }

        /// <summary>
        /// Gets or Sets RedirectUrl
        /// </summary>
        [DataMember(Name="redirect_url", EmitDefaultValue=false)]
        public string RedirectUrl { get; set; }


        /// <summary>
        /// Gets or Sets ThreeDSecure
        /// </summary>
        [DataMember(Name="three_d_secure", EmitDefaultValue=false)]
        public bool? ThreeDSecure { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public string Timestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CardDepositResponse {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  AuthCode: ").Append(AuthCode).Append("\n");
            sb.Append("  Captured: ").Append(Captured).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  FraudPass: ").Append(FraudPass).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MethodId: ").Append(MethodId).Append("\n");
            sb.Append("  PaymentType: ").Append(PaymentType).Append("\n");
            sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
            sb.Append("  RedirectUrl: ").Append(RedirectUrl).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ThreeDSecure: ").Append(ThreeDSecure).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
            return this.Equals(input as CardDepositResponse);
        }

        /// <summary>
        /// Returns true if CardDepositResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CardDepositResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CardDepositResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.AuthCode == input.AuthCode ||
                    (this.AuthCode != null &&
                    this.AuthCode.Equals(input.AuthCode))
                ) && 
                (
                    this.Captured == input.Captured ||
                    (this.Captured != null &&
                    this.Captured.Equals(input.Captured))
                ) && 
                (
                    this.Fee == input.Fee ||
                    (this.Fee != null &&
                    this.Fee.Equals(input.Fee))
                ) && 
                (
                    this.FraudPass == input.FraudPass ||
                    (this.FraudPass != null &&
                    this.FraudPass.Equals(input.FraudPass))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.MethodId == input.MethodId ||
                    (this.MethodId != null &&
                    this.MethodId.Equals(input.MethodId))
                ) && 
                (
                    this.PaymentType == input.PaymentType ||
                    (this.PaymentType != null &&
                    this.PaymentType.Equals(input.PaymentType))
                ) && 
                (
                    this.ProviderId == input.ProviderId ||
                    (this.ProviderId != null &&
                    this.ProviderId.Equals(input.ProviderId))
                ) && 
                (
                    this.RedirectUrl == input.RedirectUrl ||
                    (this.RedirectUrl != null &&
                    this.RedirectUrl.Equals(input.RedirectUrl))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.ThreeDSecure == input.ThreeDSecure ||
                    (this.ThreeDSecure != null &&
                    this.ThreeDSecure.Equals(input.ThreeDSecure))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.AuthCode != null)
                    hashCode = hashCode * 59 + this.AuthCode.GetHashCode();
                if (this.Captured != null)
                    hashCode = hashCode * 59 + this.Captured.GetHashCode();
                if (this.Fee != null)
                    hashCode = hashCode * 59 + this.Fee.GetHashCode();
                if (this.FraudPass != null)
                    hashCode = hashCode * 59 + this.FraudPass.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.MethodId != null)
                    hashCode = hashCode * 59 + this.MethodId.GetHashCode();
                if (this.PaymentType != null)
                    hashCode = hashCode * 59 + this.PaymentType.GetHashCode();
                if (this.ProviderId != null)
                    hashCode = hashCode * 59 + this.ProviderId.GetHashCode();
                if (this.RedirectUrl != null)
                    hashCode = hashCode * 59 + this.RedirectUrl.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.ThreeDSecure != null)
                    hashCode = hashCode * 59 + this.ThreeDSecure.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
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
