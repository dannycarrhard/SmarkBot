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
    /// HomeEventsResponseEvents
    /// </summary>
    [DataContract]
        public partial class HomeEventsResponseEvents :  IEquatable<HomeEventsResponseEvents>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HomeEventsResponseEvents" /> class.
        /// </summary>
        /// <param name="eventId">This ID uniquely identifies an event (required).</param>
        /// <param name="layout">layout (required).</param>
        /// <param name="navKey">navKey (required).</param>
        public HomeEventsResponseEvents(string eventId = default(string), string layout = default(string), string navKey = default(string))
        {
            // to ensure "eventId" is required (not null)
            if (eventId == null)
            {
                throw new InvalidDataException("eventId is a required property for HomeEventsResponseEvents and cannot be null");
            }
            else
            {
                this.EventId = eventId;
            }
            // to ensure "layout" is required (not null)
            if (layout == null)
            {
                throw new InvalidDataException("layout is a required property for HomeEventsResponseEvents and cannot be null");
            }
            else
            {
                this.Layout = layout;
            }
            // to ensure "navKey" is required (not null)
            if (navKey == null)
            {
                throw new InvalidDataException("navKey is a required property for HomeEventsResponseEvents and cannot be null");
            }
            else
            {
                this.NavKey = navKey;
            }
        }
        
        /// <summary>
        /// This ID uniquely identifies an event
        /// </summary>
        /// <value>This ID uniquely identifies an event</value>
        [DataMember(Name="event_id", EmitDefaultValue=false)]
        public string EventId { get; set; }

        /// <summary>
        /// Gets or Sets Layout
        /// </summary>
        [DataMember(Name="layout", EmitDefaultValue=false)]
        public string Layout { get; set; }

        /// <summary>
        /// Gets or Sets NavKey
        /// </summary>
        [DataMember(Name="nav_key", EmitDefaultValue=false)]
        public string NavKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HomeEventsResponseEvents {\n");
            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  Layout: ").Append(Layout).Append("\n");
            sb.Append("  NavKey: ").Append(NavKey).Append("\n");
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
            return this.Equals(input as HomeEventsResponseEvents);
        }

        /// <summary>
        /// Returns true if HomeEventsResponseEvents instances are equal
        /// </summary>
        /// <param name="input">Instance of HomeEventsResponseEvents to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HomeEventsResponseEvents input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EventId == input.EventId ||
                    (this.EventId != null &&
                    this.EventId.Equals(input.EventId))
                ) && 
                (
                    this.Layout == input.Layout ||
                    (this.Layout != null &&
                    this.Layout.Equals(input.Layout))
                ) && 
                (
                    this.NavKey == input.NavKey ||
                    (this.NavKey != null &&
                    this.NavKey.Equals(input.NavKey))
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
                if (this.EventId != null)
                    hashCode = hashCode * 59 + this.EventId.GetHashCode();
                if (this.Layout != null)
                    hashCode = hashCode * 59 + this.Layout.GetHashCode();
                if (this.NavKey != null)
                    hashCode = hashCode * 59 + this.NavKey.GetHashCode();
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
