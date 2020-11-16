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
    /// MultiTickRequestSchema1
    /// </summary>
    [DataContract]
        public partial class MultiTickRequestSchema1 :  IEquatable<MultiTickRequestSchema1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultiTickRequestSchema1" /> class.
        /// </summary>
        /// <param name="contractId">This ID uniquely identifies the contract (required).</param>
        /// <param name="price">price (required).</param>
        /// <param name="quantity">quantity (required).</param>
        /// <param name="referenceId">referenceId.</param>
        public MultiTickRequestSchema1(string contractId = default(string), int? price = default(int?), decimal? quantity = default(decimal?), int? referenceId = default(int?))
        {
            // to ensure "contractId" is required (not null)
            if (contractId == null)
            {
                throw new InvalidDataException("contractId is a required property for MultiTickRequestSchema1 and cannot be null");
            }
            else
            {
                this.ContractId = contractId;
            }
            // to ensure "price" is required (not null)
            if (price == null)
            {
                throw new InvalidDataException("price is a required property for MultiTickRequestSchema1 and cannot be null");
            }
            else
            {
                this.Price = price;
            }
            // to ensure "quantity" is required (not null)
            if (quantity == null)
            {
                throw new InvalidDataException("quantity is a required property for MultiTickRequestSchema1 and cannot be null");
            }
            else
            {
                this.Quantity = quantity;
            }
            this.ReferenceId = referenceId;
        }
        
        /// <summary>
        /// This ID uniquely identifies the contract
        /// </summary>
        /// <value>This ID uniquely identifies the contract</value>
        [DataMember(Name="contract_id", EmitDefaultValue=false)]
        public string ContractId { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public int? Price { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public decimal? Quantity { get; set; }

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
            sb.Append("class MultiTickRequestSchema1 {\n");
            sb.Append("  ContractId: ").Append(ContractId).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
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
            return this.Equals(input as MultiTickRequestSchema1);
        }

        /// <summary>
        /// Returns true if MultiTickRequestSchema1 instances are equal
        /// </summary>
        /// <param name="input">Instance of MultiTickRequestSchema1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MultiTickRequestSchema1 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContractId == input.ContractId ||
                    (this.ContractId != null &&
                    this.ContractId.Equals(input.ContractId))
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
                if (this.ContractId != null)
                    hashCode = hashCode * 59 + this.ContractId.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.ReferenceId != null)
                    hashCode = hashCode * 59 + this.ReferenceId.GetHashCode();
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
