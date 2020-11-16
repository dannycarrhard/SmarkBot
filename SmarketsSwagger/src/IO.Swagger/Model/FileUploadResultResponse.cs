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
    /// FileUploadResultResponse
    /// </summary>
    [DataContract]
        public partial class FileUploadResultResponse :  IEquatable<FileUploadResultResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileUploadResultResponse" /> class.
        /// </summary>
        /// <param name="fileUploadResult">fileUploadResult (required).</param>
        public FileUploadResultResponse(FileUploadResult fileUploadResult = default(FileUploadResult))
        {
            // to ensure "fileUploadResult" is required (not null)
            if (fileUploadResult == null)
            {
                throw new InvalidDataException("fileUploadResult is a required property for FileUploadResultResponse and cannot be null");
            }
            else
            {
                this.FileUploadResult = fileUploadResult;
            }
        }
        
        /// <summary>
        /// Gets or Sets FileUploadResult
        /// </summary>
        [DataMember(Name="file_upload_result", EmitDefaultValue=false)]
        public FileUploadResult FileUploadResult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileUploadResultResponse {\n");
            sb.Append("  FileUploadResult: ").Append(FileUploadResult).Append("\n");
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
            return this.Equals(input as FileUploadResultResponse);
        }

        /// <summary>
        /// Returns true if FileUploadResultResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of FileUploadResultResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileUploadResultResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FileUploadResult == input.FileUploadResult ||
                    (this.FileUploadResult != null &&
                    this.FileUploadResult.Equals(input.FileUploadResult))
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
                if (this.FileUploadResult != null)
                    hashCode = hashCode * 59 + this.FileUploadResult.GetHashCode();
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
