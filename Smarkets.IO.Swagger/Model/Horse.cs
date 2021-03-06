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
    /// Horse
    /// </summary>
    [DataContract]
        public partial class Horse :  IEquatable<Horse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Horse" /> class.
        /// </summary>
        /// <param name="age">age (required).</param>
        /// <param name="beatenDistance">beatenDistance.</param>
        /// <param name="closeUp">closeUp.</param>
        /// <param name="clothNumber">clothNumber (required).</param>
        /// <param name="contractId">This ID uniquely identifies the contract (required).</param>
        /// <param name="daysSinceLastRun">daysSinceLastRun (required).</param>
        /// <param name="drawNumber">drawNumber (required).</param>
        /// <param name="form">form (required).</param>
        /// <param name="headgear">headgear (required).</param>
        /// <param name="jockeyName">jockeyName (required).</param>
        /// <param name="officialRating">officialRating (required).</param>
        /// <param name="position">position.</param>
        /// <param name="reductionFactor">reductionFactor (required).</param>
        /// <param name="silkFile">silkFile (required).</param>
        /// <param name="trainerName">trainerName (required).</param>
        /// <param name="weight">weight (required).</param>
        public Horse(int? age = default(int?), string beatenDistance = default(string), string closeUp = default(string), int? clothNumber = default(int?), string contractId = default(string), int? daysSinceLastRun = default(int?), int? drawNumber = default(int?), string form = default(string), OneOfhorseHeadgear headgear = default(OneOfhorseHeadgear), string jockeyName = default(string), string officialRating = default(string), int? position = default(int?), string reductionFactor = default(string), string silkFile = default(string), string trainerName = default(string), string weight = default(string))
        {
            // to ensure "age" is required (not null)
            if (age == null)
            {
                throw new InvalidDataException("age is a required property for Horse and cannot be null");
            }
            else
            {
                this.Age = age;
            }
            // to ensure "clothNumber" is required (not null)
            if (clothNumber == null)
            {
                throw new InvalidDataException("clothNumber is a required property for Horse and cannot be null");
            }
            else
            {
                this.ClothNumber = clothNumber;
            }
            // to ensure "contractId" is required (not null)
            if (contractId == null)
            {
                throw new InvalidDataException("contractId is a required property for Horse and cannot be null");
            }
            else
            {
                this.ContractId = contractId;
            }
            // to ensure "daysSinceLastRun" is required (not null)
            if (daysSinceLastRun == null)
            {
                throw new InvalidDataException("daysSinceLastRun is a required property for Horse and cannot be null");
            }
            else
            {
                this.DaysSinceLastRun = daysSinceLastRun;
            }
            // to ensure "drawNumber" is required (not null)
            if (drawNumber == null)
            {
                throw new InvalidDataException("drawNumber is a required property for Horse and cannot be null");
            }
            else
            {
                this.DrawNumber = drawNumber;
            }
            // to ensure "form" is required (not null)
            if (form == null)
            {
                throw new InvalidDataException("form is a required property for Horse and cannot be null");
            }
            else
            {
                this.Form = form;
            }
            // to ensure "headgear" is required (not null)
            if (headgear == null)
            {
                throw new InvalidDataException("headgear is a required property for Horse and cannot be null");
            }
            else
            {
                this.Headgear = headgear;
            }
            // to ensure "jockeyName" is required (not null)
            if (jockeyName == null)
            {
                throw new InvalidDataException("jockeyName is a required property for Horse and cannot be null");
            }
            else
            {
                this.JockeyName = jockeyName;
            }
            // to ensure "officialRating" is required (not null)
            if (officialRating == null)
            {
                throw new InvalidDataException("officialRating is a required property for Horse and cannot be null");
            }
            else
            {
                this.OfficialRating = officialRating;
            }
            // to ensure "reductionFactor" is required (not null)
            if (reductionFactor == null)
            {
                throw new InvalidDataException("reductionFactor is a required property for Horse and cannot be null");
            }
            else
            {
                this.ReductionFactor = reductionFactor;
            }
            // to ensure "silkFile" is required (not null)
            if (silkFile == null)
            {
                throw new InvalidDataException("silkFile is a required property for Horse and cannot be null");
            }
            else
            {
                this.SilkFile = silkFile;
            }
            // to ensure "trainerName" is required (not null)
            if (trainerName == null)
            {
                throw new InvalidDataException("trainerName is a required property for Horse and cannot be null");
            }
            else
            {
                this.TrainerName = trainerName;
            }
            // to ensure "weight" is required (not null)
            if (weight == null)
            {
                throw new InvalidDataException("weight is a required property for Horse and cannot be null");
            }
            else
            {
                this.Weight = weight;
            }
            this.BeatenDistance = beatenDistance;
            this.CloseUp = closeUp;
            this.Position = position;
        }
        
        /// <summary>
        /// Gets or Sets Age
        /// </summary>
        [DataMember(Name="age", EmitDefaultValue=false)]
        public int? Age { get; set; }

        /// <summary>
        /// Gets or Sets BeatenDistance
        /// </summary>
        [DataMember(Name="beaten_distance", EmitDefaultValue=false)]
        public string BeatenDistance { get; set; }

        /// <summary>
        /// Gets or Sets CloseUp
        /// </summary>
        [DataMember(Name="close_up", EmitDefaultValue=false)]
        public string CloseUp { get; set; }

        /// <summary>
        /// Gets or Sets ClothNumber
        /// </summary>
        [DataMember(Name="cloth_number", EmitDefaultValue=false)]
        public int? ClothNumber { get; set; }

        /// <summary>
        /// This ID uniquely identifies the contract
        /// </summary>
        /// <value>This ID uniquely identifies the contract</value>
        [DataMember(Name="contract_id", EmitDefaultValue=false)]
        public string ContractId { get; set; }

        /// <summary>
        /// Gets or Sets DaysSinceLastRun
        /// </summary>
        [DataMember(Name="days_since_last_run", EmitDefaultValue=false)]
        public int? DaysSinceLastRun { get; set; }

        /// <summary>
        /// Gets or Sets DrawNumber
        /// </summary>
        [DataMember(Name="draw_number", EmitDefaultValue=false)]
        public int? DrawNumber { get; set; }

        /// <summary>
        /// Gets or Sets Form
        /// </summary>
        [DataMember(Name="form", EmitDefaultValue=false)]
        public string Form { get; set; }

        /// <summary>
        /// Gets or Sets Headgear
        /// </summary>
        [DataMember(Name="headgear", EmitDefaultValue=false)]
        public OneOfhorseHeadgear Headgear { get; set; }

        /// <summary>
        /// Gets or Sets JockeyName
        /// </summary>
        [DataMember(Name="jockey_name", EmitDefaultValue=false)]
        public string JockeyName { get; set; }

        /// <summary>
        /// Gets or Sets OfficialRating
        /// </summary>
        [DataMember(Name="official_rating", EmitDefaultValue=false)]
        public string OfficialRating { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public int? Position { get; set; }

        /// <summary>
        /// Gets or Sets ReductionFactor
        /// </summary>
        [DataMember(Name="reduction_factor", EmitDefaultValue=false)]
        public string ReductionFactor { get; set; }

        /// <summary>
        /// Gets or Sets SilkFile
        /// </summary>
        [DataMember(Name="silk_file", EmitDefaultValue=false)]
        public string SilkFile { get; set; }

        /// <summary>
        /// Gets or Sets TrainerName
        /// </summary>
        [DataMember(Name="trainer_name", EmitDefaultValue=false)]
        public string TrainerName { get; set; }

        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name="weight", EmitDefaultValue=false)]
        public string Weight { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Horse {\n");
            sb.Append("  Age: ").Append(Age).Append("\n");
            sb.Append("  BeatenDistance: ").Append(BeatenDistance).Append("\n");
            sb.Append("  CloseUp: ").Append(CloseUp).Append("\n");
            sb.Append("  ClothNumber: ").Append(ClothNumber).Append("\n");
            sb.Append("  ContractId: ").Append(ContractId).Append("\n");
            sb.Append("  DaysSinceLastRun: ").Append(DaysSinceLastRun).Append("\n");
            sb.Append("  DrawNumber: ").Append(DrawNumber).Append("\n");
            sb.Append("  Form: ").Append(Form).Append("\n");
            sb.Append("  Headgear: ").Append(Headgear).Append("\n");
            sb.Append("  JockeyName: ").Append(JockeyName).Append("\n");
            sb.Append("  OfficialRating: ").Append(OfficialRating).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  ReductionFactor: ").Append(ReductionFactor).Append("\n");
            sb.Append("  SilkFile: ").Append(SilkFile).Append("\n");
            sb.Append("  TrainerName: ").Append(TrainerName).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
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
            return this.Equals(input as Horse);
        }

        /// <summary>
        /// Returns true if Horse instances are equal
        /// </summary>
        /// <param name="input">Instance of Horse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Horse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Age == input.Age ||
                    (this.Age != null &&
                    this.Age.Equals(input.Age))
                ) && 
                (
                    this.BeatenDistance == input.BeatenDistance ||
                    (this.BeatenDistance != null &&
                    this.BeatenDistance.Equals(input.BeatenDistance))
                ) && 
                (
                    this.CloseUp == input.CloseUp ||
                    (this.CloseUp != null &&
                    this.CloseUp.Equals(input.CloseUp))
                ) && 
                (
                    this.ClothNumber == input.ClothNumber ||
                    (this.ClothNumber != null &&
                    this.ClothNumber.Equals(input.ClothNumber))
                ) && 
                (
                    this.ContractId == input.ContractId ||
                    (this.ContractId != null &&
                    this.ContractId.Equals(input.ContractId))
                ) && 
                (
                    this.DaysSinceLastRun == input.DaysSinceLastRun ||
                    (this.DaysSinceLastRun != null &&
                    this.DaysSinceLastRun.Equals(input.DaysSinceLastRun))
                ) && 
                (
                    this.DrawNumber == input.DrawNumber ||
                    (this.DrawNumber != null &&
                    this.DrawNumber.Equals(input.DrawNumber))
                ) && 
                (
                    this.Form == input.Form ||
                    (this.Form != null &&
                    this.Form.Equals(input.Form))
                ) && 
                (
                    this.Headgear == input.Headgear ||
                    (this.Headgear != null &&
                    this.Headgear.Equals(input.Headgear))
                ) && 
                (
                    this.JockeyName == input.JockeyName ||
                    (this.JockeyName != null &&
                    this.JockeyName.Equals(input.JockeyName))
                ) && 
                (
                    this.OfficialRating == input.OfficialRating ||
                    (this.OfficialRating != null &&
                    this.OfficialRating.Equals(input.OfficialRating))
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
                ) && 
                (
                    this.ReductionFactor == input.ReductionFactor ||
                    (this.ReductionFactor != null &&
                    this.ReductionFactor.Equals(input.ReductionFactor))
                ) && 
                (
                    this.SilkFile == input.SilkFile ||
                    (this.SilkFile != null &&
                    this.SilkFile.Equals(input.SilkFile))
                ) && 
                (
                    this.TrainerName == input.TrainerName ||
                    (this.TrainerName != null &&
                    this.TrainerName.Equals(input.TrainerName))
                ) && 
                (
                    this.Weight == input.Weight ||
                    (this.Weight != null &&
                    this.Weight.Equals(input.Weight))
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
                if (this.Age != null)
                    hashCode = hashCode * 59 + this.Age.GetHashCode();
                if (this.BeatenDistance != null)
                    hashCode = hashCode * 59 + this.BeatenDistance.GetHashCode();
                if (this.CloseUp != null)
                    hashCode = hashCode * 59 + this.CloseUp.GetHashCode();
                if (this.ClothNumber != null)
                    hashCode = hashCode * 59 + this.ClothNumber.GetHashCode();
                if (this.ContractId != null)
                    hashCode = hashCode * 59 + this.ContractId.GetHashCode();
                if (this.DaysSinceLastRun != null)
                    hashCode = hashCode * 59 + this.DaysSinceLastRun.GetHashCode();
                if (this.DrawNumber != null)
                    hashCode = hashCode * 59 + this.DrawNumber.GetHashCode();
                if (this.Form != null)
                    hashCode = hashCode * 59 + this.Form.GetHashCode();
                if (this.Headgear != null)
                    hashCode = hashCode * 59 + this.Headgear.GetHashCode();
                if (this.JockeyName != null)
                    hashCode = hashCode * 59 + this.JockeyName.GetHashCode();
                if (this.OfficialRating != null)
                    hashCode = hashCode * 59 + this.OfficialRating.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.ReductionFactor != null)
                    hashCode = hashCode * 59 + this.ReductionFactor.GetHashCode();
                if (this.SilkFile != null)
                    hashCode = hashCode * 59 + this.SilkFile.GetHashCode();
                if (this.TrainerName != null)
                    hashCode = hashCode * 59 + this.TrainerName.GetHashCode();
                if (this.Weight != null)
                    hashCode = hashCode * 59 + this.Weight.GetHashCode();
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
