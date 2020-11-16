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
    /// InlineResponse20032AppliedImageGroups
    /// </summary>
    [DataContract]
        public partial class InlineResponse20032AppliedImageGroups :  IEquatable<InlineResponse20032AppliedImageGroups>, IValidatableObject
    {
        /// <summary>
        /// Defines ResourceType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ResourceTypeEnum
        {
            /// <summary>
            /// Enum Competitor for value: competitor
            /// </summary>
            [EnumMember(Value = "competitor")]
            Competitor = 1,
            /// <summary>
            /// Enum Event for value: event
            /// </summary>
            [EnumMember(Value = "event")]
            Event = 2        }
        /// <summary>
        /// Gets or Sets ResourceType
        /// </summary>
        [DataMember(Name="resource_type", EmitDefaultValue=false)]
        public ResourceTypeEnum ResourceType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20032AppliedImageGroups" /> class.
        /// </summary>
        /// <param name="imagePaths">imagePaths (required).</param>
        /// <param name="resourceId">resourceId (required).</param>
        /// <param name="resourceType">resourceType (required).</param>
        public InlineResponse20032AppliedImageGroups(List<string> imagePaths = default(List<string>), int? resourceId = default(int?), ResourceTypeEnum resourceType = default(ResourceTypeEnum))
        {
            // to ensure "imagePaths" is required (not null)
            if (imagePaths == null)
            {
                throw new InvalidDataException("imagePaths is a required property for InlineResponse20032AppliedImageGroups and cannot be null");
            }
            else
            {
                this.ImagePaths = imagePaths;
            }
            // to ensure "resourceId" is required (not null)
            if (resourceId == null)
            {
                throw new InvalidDataException("resourceId is a required property for InlineResponse20032AppliedImageGroups and cannot be null");
            }
            else
            {
                this.ResourceId = resourceId;
            }
            // to ensure "resourceType" is required (not null)
            if (resourceType == null)
            {
                throw new InvalidDataException("resourceType is a required property for InlineResponse20032AppliedImageGroups and cannot be null");
            }
            else
            {
                this.ResourceType = resourceType;
            }
        }
        
        /// <summary>
        /// Gets or Sets ImagePaths
        /// </summary>
        [DataMember(Name="image_paths", EmitDefaultValue=false)]
        public List<string> ImagePaths { get; set; }

        /// <summary>
        /// Gets or Sets ResourceId
        /// </summary>
        [DataMember(Name="resource_id", EmitDefaultValue=false)]
        public int? ResourceId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20032AppliedImageGroups {\n");
            sb.Append("  ImagePaths: ").Append(ImagePaths).Append("\n");
            sb.Append("  ResourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
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
            return this.Equals(input as InlineResponse20032AppliedImageGroups);
        }

        /// <summary>
        /// Returns true if InlineResponse20032AppliedImageGroups instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20032AppliedImageGroups to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20032AppliedImageGroups input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ImagePaths == input.ImagePaths ||
                    this.ImagePaths != null &&
                    input.ImagePaths != null &&
                    this.ImagePaths.SequenceEqual(input.ImagePaths)
                ) && 
                (
                    this.ResourceId == input.ResourceId ||
                    (this.ResourceId != null &&
                    this.ResourceId.Equals(input.ResourceId))
                ) && 
                (
                    this.ResourceType == input.ResourceType ||
                    (this.ResourceType != null &&
                    this.ResourceType.Equals(input.ResourceType))
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
                if (this.ImagePaths != null)
                    hashCode = hashCode * 59 + this.ImagePaths.GetHashCode();
                if (this.ResourceId != null)
                    hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.ResourceType != null)
                    hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
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