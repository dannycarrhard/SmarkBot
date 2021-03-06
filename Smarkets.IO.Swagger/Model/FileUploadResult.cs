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
    /// FileUploadResult
    /// </summary>
    [DataContract]
        public partial class FileUploadResult :  IEquatable<FileUploadResult>, IValidatableObject
    {
        /// <summary>
        /// Defines Error
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ErrorEnum
        {
            /// <summary>
            /// Enum EXTENSIONNOTALLOWED for value: EXTENSION_NOT_ALLOWED
            /// </summary>
            [EnumMember(Value = "EXTENSION_NOT_ALLOWED")]
            EXTENSIONNOTALLOWED = 1,
            /// <summary>
            /// Enum FILETOOLARGE for value: FILE_TOO_LARGE
            /// </summary>
            [EnumMember(Value = "FILE_TOO_LARGE")]
            FILETOOLARGE = 2        }
        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public ErrorEnum? Error { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileUploadResult" /> class.
        /// </summary>
        /// <param name="error">error.</param>
        /// <param name="fileName">fileName (required).</param>
        /// <param name="success">success (required).</param>
        public FileUploadResult(ErrorEnum? error = default(ErrorEnum?), string fileName = default(string), bool? success = default(bool?))
        {
            // to ensure "fileName" is required (not null)
            if (fileName == null)
            {
                throw new InvalidDataException("fileName is a required property for FileUploadResult and cannot be null");
            }
            else
            {
                this.FileName = fileName;
            }
            // to ensure "success" is required (not null)
            if (success == null)
            {
                throw new InvalidDataException("success is a required property for FileUploadResult and cannot be null");
            }
            else
            {
                this.Success = success;
            }
            this.Error = error;
        }
        

        /// <summary>
        /// Gets or Sets FileName
        /// </summary>
        [DataMember(Name="file_name", EmitDefaultValue=false)]
        public string FileName { get; set; }

        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name="success", EmitDefaultValue=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileUploadResult {\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
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
            return this.Equals(input as FileUploadResult);
        }

        /// <summary>
        /// Returns true if FileUploadResult instances are equal
        /// </summary>
        /// <param name="input">Instance of FileUploadResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileUploadResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
                ) && 
                (
                    this.Success == input.Success ||
                    (this.Success != null &&
                    this.Success.Equals(input.Success))
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
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.FileName != null)
                    hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.Success != null)
                    hashCode = hashCode * 59 + this.Success.GetHashCode();
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
