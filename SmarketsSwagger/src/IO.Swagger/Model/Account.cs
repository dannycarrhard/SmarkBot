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
    /// Account
    /// </summary>
    [DataContract]
        public partial class Account :  IEquatable<Account>, IValidatableObject
    {
        /// <summary>
        /// Currency of the account
        /// </summary>
        /// <value>Currency of the account</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum CurrencyEnum
        {
            /// <summary>
            /// Enum AUD for value: AUD
            /// </summary>
            [EnumMember(Value = "AUD")]
            AUD = 1,
            /// <summary>
            /// Enum CAD for value: CAD
            /// </summary>
            [EnumMember(Value = "CAD")]
            CAD = 2,
            /// <summary>
            /// Enum CHF for value: CHF
            /// </summary>
            [EnumMember(Value = "CHF")]
            CHF = 3,
            /// <summary>
            /// Enum CZK for value: CZK
            /// </summary>
            [EnumMember(Value = "CZK")]
            CZK = 4,
            /// <summary>
            /// Enum DKK for value: DKK
            /// </summary>
            [EnumMember(Value = "DKK")]
            DKK = 5,
            /// <summary>
            /// Enum EUR for value: EUR
            /// </summary>
            [EnumMember(Value = "EUR")]
            EUR = 6,
            /// <summary>
            /// Enum GBP for value: GBP
            /// </summary>
            [EnumMember(Value = "GBP")]
            GBP = 7,
            /// <summary>
            /// Enum HKD for value: HKD
            /// </summary>
            [EnumMember(Value = "HKD")]
            HKD = 8,
            /// <summary>
            /// Enum HUF for value: HUF
            /// </summary>
            [EnumMember(Value = "HUF")]
            HUF = 9,
            /// <summary>
            /// Enum JPY for value: JPY
            /// </summary>
            [EnumMember(Value = "JPY")]
            JPY = 10,
            /// <summary>
            /// Enum NOK for value: NOK
            /// </summary>
            [EnumMember(Value = "NOK")]
            NOK = 11,
            /// <summary>
            /// Enum PLN for value: PLN
            /// </summary>
            [EnumMember(Value = "PLN")]
            PLN = 12,
            /// <summary>
            /// Enum SEK for value: SEK
            /// </summary>
            [EnumMember(Value = "SEK")]
            SEK = 13,
            /// <summary>
            /// Enum USD for value: USD
            /// </summary>
            [EnumMember(Value = "USD")]
            USD = 14        }
        /// <summary>
        /// Currency of the account
        /// </summary>
        /// <value>Currency of the account</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public CurrencyEnum Currency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Account" /> class.
        /// </summary>
        /// <param name="accountId">Unique identifier of the account (required).</param>
        /// <param name="availableBalance">Current available balance on the account, it is equal to the balance deducted by the exposure (required).</param>
        /// <param name="balance">Current balance on the account (required).</param>
        /// <param name="bonusBalance">Current bonus balance on the account;                     losses will be refunded up to this amount.</param>
        /// <param name="commissionType">Commission charged by Smarkets on the account.</param>
        /// <param name="currency">Currency of the account (required).</param>
        /// <param name="exposure">Current exposure on the account (required).</param>
        public Account(string accountId = default(string), string availableBalance = default(string), string balance = default(string), string bonusBalance = default(string), string commissionType = default(string), CurrencyEnum currency = default(CurrencyEnum), string exposure = default(string))
        {
            // to ensure "accountId" is required (not null)
            if (accountId == null)
            {
                throw new InvalidDataException("accountId is a required property for Account and cannot be null");
            }
            else
            {
                this.AccountId = accountId;
            }
            // to ensure "availableBalance" is required (not null)
            if (availableBalance == null)
            {
                throw new InvalidDataException("availableBalance is a required property for Account and cannot be null");
            }
            else
            {
                this.AvailableBalance = availableBalance;
            }
            // to ensure "balance" is required (not null)
            if (balance == null)
            {
                throw new InvalidDataException("balance is a required property for Account and cannot be null");
            }
            else
            {
                this.Balance = balance;
            }
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new InvalidDataException("currency is a required property for Account and cannot be null");
            }
            else
            {
                this.Currency = currency;
            }
            // to ensure "exposure" is required (not null)
            if (exposure == null)
            {
                throw new InvalidDataException("exposure is a required property for Account and cannot be null");
            }
            else
            {
                this.Exposure = exposure;
            }
            this.BonusBalance = bonusBalance;
            this.CommissionType = commissionType;
        }
        
        /// <summary>
        /// Unique identifier of the account
        /// </summary>
        /// <value>Unique identifier of the account</value>
        [DataMember(Name="account_id", EmitDefaultValue=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// Current available balance on the account, it is equal to the balance deducted by the exposure
        /// </summary>
        /// <value>Current available balance on the account, it is equal to the balance deducted by the exposure</value>
        [DataMember(Name="available_balance", EmitDefaultValue=false)]
        public string AvailableBalance { get; set; }

        /// <summary>
        /// Current balance on the account
        /// </summary>
        /// <value>Current balance on the account</value>
        [DataMember(Name="balance", EmitDefaultValue=false)]
        public string Balance { get; set; }

        /// <summary>
        /// Current bonus balance on the account;                     losses will be refunded up to this amount
        /// </summary>
        /// <value>Current bonus balance on the account;                     losses will be refunded up to this amount</value>
        [DataMember(Name="bonus_balance", EmitDefaultValue=false)]
        public string BonusBalance { get; set; }

        /// <summary>
        /// Commission charged by Smarkets on the account
        /// </summary>
        /// <value>Commission charged by Smarkets on the account</value>
        [DataMember(Name="commission_type", EmitDefaultValue=false)]
        public string CommissionType { get; set; }


        /// <summary>
        /// Current exposure on the account
        /// </summary>
        /// <value>Current exposure on the account</value>
        [DataMember(Name="exposure", EmitDefaultValue=false)]
        public string Exposure { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Account {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AvailableBalance: ").Append(AvailableBalance).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  BonusBalance: ").Append(BonusBalance).Append("\n");
            sb.Append("  CommissionType: ").Append(CommissionType).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Exposure: ").Append(Exposure).Append("\n");
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
            return this.Equals(input as Account);
        }

        /// <summary>
        /// Returns true if Account instances are equal
        /// </summary>
        /// <param name="input">Instance of Account to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Account input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.AvailableBalance == input.AvailableBalance ||
                    (this.AvailableBalance != null &&
                    this.AvailableBalance.Equals(input.AvailableBalance))
                ) && 
                (
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
                ) && 
                (
                    this.BonusBalance == input.BonusBalance ||
                    (this.BonusBalance != null &&
                    this.BonusBalance.Equals(input.BonusBalance))
                ) && 
                (
                    this.CommissionType == input.CommissionType ||
                    (this.CommissionType != null &&
                    this.CommissionType.Equals(input.CommissionType))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Exposure == input.Exposure ||
                    (this.Exposure != null &&
                    this.Exposure.Equals(input.Exposure))
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
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.AvailableBalance != null)
                    hashCode = hashCode * 59 + this.AvailableBalance.GetHashCode();
                if (this.Balance != null)
                    hashCode = hashCode * 59 + this.Balance.GetHashCode();
                if (this.BonusBalance != null)
                    hashCode = hashCode * 59 + this.BonusBalance.GetHashCode();
                if (this.CommissionType != null)
                    hashCode = hashCode * 59 + this.CommissionType.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Exposure != null)
                    hashCode = hashCode * 59 + this.Exposure.GetHashCode();
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
