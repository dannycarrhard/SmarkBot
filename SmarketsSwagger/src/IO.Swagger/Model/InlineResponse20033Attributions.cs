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
    /// InlineResponse20033Attributions
    /// </summary>
    [DataContract]
        public partial class InlineResponse20033Attributions :  IEquatable<InlineResponse20033Attributions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20033Attributions" /> class.
        /// </summary>
        /// <param name="authorName">authorName.</param>
        /// <param name="authorUrl">authorUrl.</param>
        /// <param name="imageId">imageId (required).</param>
        /// <param name="imageUrl">imageUrl.</param>
        /// <param name="licenseName">licenseName.</param>
        /// <param name="licenseUrl">licenseUrl.</param>
        /// <param name="originalImageTitle">originalImageTitle (required).</param>
        /// <param name="originalImageUrl">originalImageUrl (required).</param>
        public InlineResponse20033Attributions(string authorName = default(string), string authorUrl = default(string), int? imageId = default(int?), string imageUrl = default(string), string licenseName = default(string), string licenseUrl = default(string), string originalImageTitle = default(string), string originalImageUrl = default(string))
        {
            // to ensure "imageId" is required (not null)
            if (imageId == null)
            {
                throw new InvalidDataException("imageId is a required property for InlineResponse20033Attributions and cannot be null");
            }
            else
            {
                this.ImageId = imageId;
            }
            // to ensure "originalImageTitle" is required (not null)
            if (originalImageTitle == null)
            {
                throw new InvalidDataException("originalImageTitle is a required property for InlineResponse20033Attributions and cannot be null");
            }
            else
            {
                this.OriginalImageTitle = originalImageTitle;
            }
            // to ensure "originalImageUrl" is required (not null)
            if (originalImageUrl == null)
            {
                throw new InvalidDataException("originalImageUrl is a required property for InlineResponse20033Attributions and cannot be null");
            }
            else
            {
                this.OriginalImageUrl = originalImageUrl;
            }
            this.AuthorName = authorName;
            this.AuthorUrl = authorUrl;
            this.ImageUrl = imageUrl;
            this.LicenseName = licenseName;
            this.LicenseUrl = licenseUrl;
        }
        
        /// <summary>
        /// Gets or Sets AuthorName
        /// </summary>
        [DataMember(Name="author_name", EmitDefaultValue=false)]
        public string AuthorName { get; set; }

        /// <summary>
        /// Gets or Sets AuthorUrl
        /// </summary>
        [DataMember(Name="author_url", EmitDefaultValue=false)]
        public string AuthorUrl { get; set; }

        /// <summary>
        /// Gets or Sets ImageId
        /// </summary>
        [DataMember(Name="image_id", EmitDefaultValue=false)]
        public int? ImageId { get; set; }

        /// <summary>
        /// Gets or Sets ImageUrl
        /// </summary>
        [DataMember(Name="image_url", EmitDefaultValue=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets LicenseName
        /// </summary>
        [DataMember(Name="license_name", EmitDefaultValue=false)]
        public string LicenseName { get; set; }

        /// <summary>
        /// Gets or Sets LicenseUrl
        /// </summary>
        [DataMember(Name="license_url", EmitDefaultValue=false)]
        public string LicenseUrl { get; set; }

        /// <summary>
        /// Gets or Sets OriginalImageTitle
        /// </summary>
        [DataMember(Name="original_image_title", EmitDefaultValue=false)]
        public string OriginalImageTitle { get; set; }

        /// <summary>
        /// Gets or Sets OriginalImageUrl
        /// </summary>
        [DataMember(Name="original_image_url", EmitDefaultValue=false)]
        public string OriginalImageUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20033Attributions {\n");
            sb.Append("  AuthorName: ").Append(AuthorName).Append("\n");
            sb.Append("  AuthorUrl: ").Append(AuthorUrl).Append("\n");
            sb.Append("  ImageId: ").Append(ImageId).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  LicenseName: ").Append(LicenseName).Append("\n");
            sb.Append("  LicenseUrl: ").Append(LicenseUrl).Append("\n");
            sb.Append("  OriginalImageTitle: ").Append(OriginalImageTitle).Append("\n");
            sb.Append("  OriginalImageUrl: ").Append(OriginalImageUrl).Append("\n");
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
            return this.Equals(input as InlineResponse20033Attributions);
        }

        /// <summary>
        /// Returns true if InlineResponse20033Attributions instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20033Attributions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20033Attributions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuthorName == input.AuthorName ||
                    (this.AuthorName != null &&
                    this.AuthorName.Equals(input.AuthorName))
                ) && 
                (
                    this.AuthorUrl == input.AuthorUrl ||
                    (this.AuthorUrl != null &&
                    this.AuthorUrl.Equals(input.AuthorUrl))
                ) && 
                (
                    this.ImageId == input.ImageId ||
                    (this.ImageId != null &&
                    this.ImageId.Equals(input.ImageId))
                ) && 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                ) && 
                (
                    this.LicenseName == input.LicenseName ||
                    (this.LicenseName != null &&
                    this.LicenseName.Equals(input.LicenseName))
                ) && 
                (
                    this.LicenseUrl == input.LicenseUrl ||
                    (this.LicenseUrl != null &&
                    this.LicenseUrl.Equals(input.LicenseUrl))
                ) && 
                (
                    this.OriginalImageTitle == input.OriginalImageTitle ||
                    (this.OriginalImageTitle != null &&
                    this.OriginalImageTitle.Equals(input.OriginalImageTitle))
                ) && 
                (
                    this.OriginalImageUrl == input.OriginalImageUrl ||
                    (this.OriginalImageUrl != null &&
                    this.OriginalImageUrl.Equals(input.OriginalImageUrl))
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
                if (this.AuthorName != null)
                    hashCode = hashCode * 59 + this.AuthorName.GetHashCode();
                if (this.AuthorUrl != null)
                    hashCode = hashCode * 59 + this.AuthorUrl.GetHashCode();
                if (this.ImageId != null)
                    hashCode = hashCode * 59 + this.ImageId.GetHashCode();
                if (this.ImageUrl != null)
                    hashCode = hashCode * 59 + this.ImageUrl.GetHashCode();
                if (this.LicenseName != null)
                    hashCode = hashCode * 59 + this.LicenseName.GetHashCode();
                if (this.LicenseUrl != null)
                    hashCode = hashCode * 59 + this.LicenseUrl.GetHashCode();
                if (this.OriginalImageTitle != null)
                    hashCode = hashCode * 59 + this.OriginalImageTitle.GetHashCode();
                if (this.OriginalImageUrl != null)
                    hashCode = hashCode * 59 + this.OriginalImageUrl.GetHashCode();
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
