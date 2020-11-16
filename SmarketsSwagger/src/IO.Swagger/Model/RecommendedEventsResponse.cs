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
    /// RecommendedEventsResponse
    /// </summary>
    [DataContract]
        public partial class RecommendedEventsResponse :  IEquatable<RecommendedEventsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecommendedEventsResponse" /> class.
        /// </summary>
        /// <param name="count">count (required).</param>
        /// <param name="pagination">pagination.</param>
        /// <param name="searchResultEventIds">searchResultEventIds (required).</param>
        public RecommendedEventsResponse(int? count = default(int?), EventsPagination pagination = default(EventsPagination), List<string> searchResultEventIds = default(List<string>))
        {
            // to ensure "count" is required (not null)
            if (count == null)
            {
                throw new InvalidDataException("count is a required property for RecommendedEventsResponse and cannot be null");
            }
            else
            {
                this.Count = count;
            }
            // to ensure "searchResultEventIds" is required (not null)
            if (searchResultEventIds == null)
            {
                throw new InvalidDataException("searchResultEventIds is a required property for RecommendedEventsResponse and cannot be null");
            }
            else
            {
                this.SearchResultEventIds = searchResultEventIds;
            }
            this.Pagination = pagination;
        }
        
        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }

        /// <summary>
        /// Gets or Sets Pagination
        /// </summary>
        [DataMember(Name="pagination", EmitDefaultValue=false)]
        public EventsPagination Pagination { get; set; }

        /// <summary>
        /// Gets or Sets SearchResultEventIds
        /// </summary>
        [DataMember(Name="search_result_event_ids", EmitDefaultValue=false)]
        public List<string> SearchResultEventIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecommendedEventsResponse {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Pagination: ").Append(Pagination).Append("\n");
            sb.Append("  SearchResultEventIds: ").Append(SearchResultEventIds).Append("\n");
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
            return this.Equals(input as RecommendedEventsResponse);
        }

        /// <summary>
        /// Returns true if RecommendedEventsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RecommendedEventsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecommendedEventsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.Pagination == input.Pagination ||
                    (this.Pagination != null &&
                    this.Pagination.Equals(input.Pagination))
                ) && 
                (
                    this.SearchResultEventIds == input.SearchResultEventIds ||
                    this.SearchResultEventIds != null &&
                    input.SearchResultEventIds != null &&
                    this.SearchResultEventIds.SequenceEqual(input.SearchResultEventIds)
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
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Pagination != null)
                    hashCode = hashCode * 59 + this.Pagination.GetHashCode();
                if (this.SearchResultEventIds != null)
                    hashCode = hashCode * 59 + this.SearchResultEventIds.GetHashCode();
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
