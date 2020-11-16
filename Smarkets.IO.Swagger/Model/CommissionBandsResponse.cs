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
    /// CommissionBandsResponse
    /// </summary>
    [DataContract]
        public partial class CommissionBandsResponse :  IEquatable<CommissionBandsResponse>, IValidatableObject
    {
        /// <summary>
        /// Defines CurrentBand
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum CurrentBandEnum
        {
            /// <summary>
            /// Enum Mm for value: mm
            /// </summary>
            [EnumMember(Value = "mm")]
            Mm = 1,
            /// <summary>
            /// Enum Std for value: std
            /// </summary>
            [EnumMember(Value = "std")]
            Std = 2,
            /// <summary>
            /// Enum Pro for value: pro
            /// </summary>
            [EnumMember(Value = "pro")]
            Pro = 3,
            /// <summary>
            /// Enum Select for value: select
            /// </summary>
            [EnumMember(Value = "select")]
            Select = 4        }
        /// <summary>
        /// Gets or Sets CurrentBand
        /// </summary>
        [DataMember(Name="current_band", EmitDefaultValue=false)]
        public CurrentBandEnum CurrentBand { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommissionBandsResponse" /> class.
        /// </summary>
        /// <param name="bands">bands (required).</param>
        /// <param name="currentBand">currentBand (required).</param>
        /// <param name="currentBandExpiryDate">currentBandExpiryDate.</param>
        /// <param name="currentCommissionType">currentCommissionType (required).</param>
        public CommissionBandsResponse(Bands bands = default(Bands), CurrentBandEnum currentBand = default(CurrentBandEnum), DateTime? currentBandExpiryDate = default(DateTime?), string currentCommissionType = default(string))
        {
            // to ensure "bands" is required (not null)
            if (bands == null)
            {
                throw new InvalidDataException("bands is a required property for CommissionBandsResponse and cannot be null");
            }
            else
            {
                this.Bands = bands;
            }
            // to ensure "currentBand" is required (not null)
            if (currentBand == null)
            {
                throw new InvalidDataException("currentBand is a required property for CommissionBandsResponse and cannot be null");
            }
            else
            {
                this.CurrentBand = currentBand;
            }
            // to ensure "currentCommissionType" is required (not null)
            if (currentCommissionType == null)
            {
                throw new InvalidDataException("currentCommissionType is a required property for CommissionBandsResponse and cannot be null");
            }
            else
            {
                this.CurrentCommissionType = currentCommissionType;
            }
            this.CurrentBandExpiryDate = currentBandExpiryDate;
        }
        
        /// <summary>
        /// Gets or Sets Bands
        /// </summary>
        [DataMember(Name="bands", EmitDefaultValue=false)]
        public Bands Bands { get; set; }


        /// <summary>
        /// Gets or Sets CurrentBandExpiryDate
        /// </summary>
        [DataMember(Name="current_band_expiry_date", EmitDefaultValue=false)]
        public DateTime? CurrentBandExpiryDate { get; set; }

        /// <summary>
        /// Gets or Sets CurrentCommissionType
        /// </summary>
        [DataMember(Name="current_commission_type", EmitDefaultValue=false)]
        public string CurrentCommissionType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommissionBandsResponse {\n");
            sb.Append("  Bands: ").Append(Bands).Append("\n");
            sb.Append("  CurrentBand: ").Append(CurrentBand).Append("\n");
            sb.Append("  CurrentBandExpiryDate: ").Append(CurrentBandExpiryDate).Append("\n");
            sb.Append("  CurrentCommissionType: ").Append(CurrentCommissionType).Append("\n");
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
            return this.Equals(input as CommissionBandsResponse);
        }

        /// <summary>
        /// Returns true if CommissionBandsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CommissionBandsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommissionBandsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Bands == input.Bands ||
                    (this.Bands != null &&
                    this.Bands.Equals(input.Bands))
                ) && 
                (
                    this.CurrentBand == input.CurrentBand ||
                    (this.CurrentBand != null &&
                    this.CurrentBand.Equals(input.CurrentBand))
                ) && 
                (
                    this.CurrentBandExpiryDate == input.CurrentBandExpiryDate ||
                    (this.CurrentBandExpiryDate != null &&
                    this.CurrentBandExpiryDate.Equals(input.CurrentBandExpiryDate))
                ) && 
                (
                    this.CurrentCommissionType == input.CurrentCommissionType ||
                    (this.CurrentCommissionType != null &&
                    this.CurrentCommissionType.Equals(input.CurrentCommissionType))
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
                if (this.Bands != null)
                    hashCode = hashCode * 59 + this.Bands.GetHashCode();
                if (this.CurrentBand != null)
                    hashCode = hashCode * 59 + this.CurrentBand.GetHashCode();
                if (this.CurrentBandExpiryDate != null)
                    hashCode = hashCode * 59 + this.CurrentBandExpiryDate.GetHashCode();
                if (this.CurrentCommissionType != null)
                    hashCode = hashCode * 59 + this.CurrentCommissionType.GetHashCode();
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