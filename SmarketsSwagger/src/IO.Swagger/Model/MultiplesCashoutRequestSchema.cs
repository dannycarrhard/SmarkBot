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
    /// MultiplesCashoutRequestSchema
    /// </summary>
    [DataContract]
        public partial class MultiplesCashoutRequestSchema :  IEquatable<MultiplesCashoutRequestSchema>, IValidatableObject
    {
        /// <summary>
        ///  side can either be:&lt;ul&gt; &lt;li&gt;buy: backing a contract &lt;li&gt;sell: laying a contract &lt;/ul&gt;
        /// </summary>
        /// <value> side can either be:&lt;ul&gt; &lt;li&gt;buy: backing a contract &lt;li&gt;sell: laying a contract &lt;/ul&gt;</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum SideEnum
        {
            /// <summary>
            /// Enum Buy for value: buy
            /// </summary>
            [EnumMember(Value = "buy")]
            Buy = 1,
            /// <summary>
            /// Enum Sell for value: sell
            /// </summary>
            [EnumMember(Value = "sell")]
            Sell = 2        }
        /// <summary>
        ///  side can either be:&lt;ul&gt; &lt;li&gt;buy: backing a contract &lt;li&gt;sell: laying a contract &lt;/ul&gt;
        /// </summary>
        /// <value> side can either be:&lt;ul&gt; &lt;li&gt;buy: backing a contract &lt;li&gt;sell: laying a contract &lt;/ul&gt;</value>
        [DataMember(Name="side", EmitDefaultValue=false)]
        public SideEnum Side { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MultiplesCashoutRequestSchema" /> class.
        /// </summary>
        /// <param name="contractIds">contractIds (required).</param>
        /// <param name="price">price (required).</param>
        /// <param name="quantity">quantity (required).</param>
        /// <param name="referenceId">referenceId.</param>
        /// <param name="side"> side can either be:&lt;ul&gt; &lt;li&gt;buy: backing a contract &lt;li&gt;sell: laying a contract &lt;/ul&gt; (required).</param>
        public MultiplesCashoutRequestSchema(List<string> contractIds = default(List<string>), int? price = default(int?), int? quantity = default(int?), int? referenceId = default(int?), SideEnum side = default(SideEnum))
        {
            // to ensure "contractIds" is required (not null)
            if (contractIds == null)
            {
                throw new InvalidDataException("contractIds is a required property for MultiplesCashoutRequestSchema and cannot be null");
            }
            else
            {
                this.ContractIds = contractIds;
            }
            // to ensure "price" is required (not null)
            if (price == null)
            {
                throw new InvalidDataException("price is a required property for MultiplesCashoutRequestSchema and cannot be null");
            }
            else
            {
                this.Price = price;
            }
            // to ensure "quantity" is required (not null)
            if (quantity == null)
            {
                throw new InvalidDataException("quantity is a required property for MultiplesCashoutRequestSchema and cannot be null");
            }
            else
            {
                this.Quantity = quantity;
            }
            // to ensure "side" is required (not null)
            if (side == null)
            {
                throw new InvalidDataException("side is a required property for MultiplesCashoutRequestSchema and cannot be null");
            }
            else
            {
                this.Side = side;
            }
            this.ReferenceId = referenceId;
        }
        
        /// <summary>
        /// Gets or Sets ContractIds
        /// </summary>
        [DataMember(Name="contract_ids", EmitDefaultValue=false)]
        public List<string> ContractIds { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public int? Price { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceId
        /// </summary>
        [DataMember(Name="reference_id", EmitDefaultValue=false)]
        public int? ReferenceId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MultiplesCashoutRequestSchema {\n");
            sb.Append("  ContractIds: ").Append(ContractIds).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  Side: ").Append(Side).Append("\n");
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
            return this.Equals(input as MultiplesCashoutRequestSchema);
        }

        /// <summary>
        /// Returns true if MultiplesCashoutRequestSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of MultiplesCashoutRequestSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MultiplesCashoutRequestSchema input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContractIds == input.ContractIds ||
                    this.ContractIds != null &&
                    input.ContractIds != null &&
                    this.ContractIds.SequenceEqual(input.ContractIds)
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.ReferenceId == input.ReferenceId ||
                    (this.ReferenceId != null &&
                    this.ReferenceId.Equals(input.ReferenceId))
                ) && 
                (
                    this.Side == input.Side ||
                    (this.Side != null &&
                    this.Side.Equals(input.Side))
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
                if (this.ContractIds != null)
                    hashCode = hashCode * 59 + this.ContractIds.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.ReferenceId != null)
                    hashCode = hashCode * 59 + this.ReferenceId.GetHashCode();
                if (this.Side != null)
                    hashCode = hashCode * 59 + this.Side.GetHashCode();
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
