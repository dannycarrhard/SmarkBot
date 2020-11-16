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
    /// RecentTrade
    /// </summary>
    [DataContract]
        public partial class RecentTrade :  IEquatable<RecentTrade>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="RecentTrade" /> class.
        /// </summary>
        /// <param name="contractId">This ID uniquely identifies the contract (required).</param>
        /// <param name="marketId">This ID uniquely identifies the market (required).</param>
        /// <param name="price"> This price is in percentage basis points.&lt;br&gt; Example: 5000 &#x3D; 50% &lt;br&gt; To convert it to decimal odds, just divide 10000 by it&lt;br&gt; Example: 10000 / 5000 &#x3D; 2.0 (decimal odds).&lt;br&gt; This price has to conform to a valid tick on the exchange; an invalid price error will be returned if it does not. (required).</param>
        /// <param name="quantity">     Quantity is the sum of the total pot (back+lay) in case the order is matched&lt;br&gt;     The units are 1/100 of a UK penny.&lt;br&gt;     Example: Quantity 1 &#x3D; 0.0001 GBP&lt;br&gt;     To convert it to back stake, just multiply by the price and divide by 100000000&lt;br&gt;     Example: 100000 (quantity) * 5000 (price) / 100000000 &#x3D; 5 GBP back stake (required).</param>
        /// <param name="side"> side can either be:&lt;ul&gt; &lt;li&gt;buy: backing a contract &lt;li&gt;sell: laying a contract &lt;/ul&gt; (required).</param>
        /// <param name="timestamp">timestamp (required).</param>
        public RecentTrade(string contractId = default(string), string marketId = default(string), int? price = default(int?), int? quantity = default(int?), SideEnum side = default(SideEnum), DateTime? timestamp = default(DateTime?))
        {
            // to ensure "contractId" is required (not null)
            if (contractId == null)
            {
                throw new InvalidDataException("contractId is a required property for RecentTrade and cannot be null");
            }
            else
            {
                this.ContractId = contractId;
            }
            // to ensure "marketId" is required (not null)
            if (marketId == null)
            {
                throw new InvalidDataException("marketId is a required property for RecentTrade and cannot be null");
            }
            else
            {
                this.MarketId = marketId;
            }
            // to ensure "price" is required (not null)
            if (price == null)
            {
                throw new InvalidDataException("price is a required property for RecentTrade and cannot be null");
            }
            else
            {
                this.Price = price;
            }
            // to ensure "quantity" is required (not null)
            if (quantity == null)
            {
                throw new InvalidDataException("quantity is a required property for RecentTrade and cannot be null");
            }
            else
            {
                this.Quantity = quantity;
            }
            // to ensure "side" is required (not null)
            if (side == null)
            {
                throw new InvalidDataException("side is a required property for RecentTrade and cannot be null");
            }
            else
            {
                this.Side = side;
            }
            // to ensure "timestamp" is required (not null)
            if (timestamp == null)
            {
                throw new InvalidDataException("timestamp is a required property for RecentTrade and cannot be null");
            }
            else
            {
                this.Timestamp = timestamp;
            }
        }
        
        /// <summary>
        /// This ID uniquely identifies the contract
        /// </summary>
        /// <value>This ID uniquely identifies the contract</value>
        [DataMember(Name="contract_id", EmitDefaultValue=false)]
        public string ContractId { get; set; }

        /// <summary>
        /// This ID uniquely identifies the market
        /// </summary>
        /// <value>This ID uniquely identifies the market</value>
        [DataMember(Name="market_id", EmitDefaultValue=false)]
        public string MarketId { get; set; }

        /// <summary>
        ///  This price is in percentage basis points.&lt;br&gt; Example: 5000 &#x3D; 50% &lt;br&gt; To convert it to decimal odds, just divide 10000 by it&lt;br&gt; Example: 10000 / 5000 &#x3D; 2.0 (decimal odds).&lt;br&gt; This price has to conform to a valid tick on the exchange; an invalid price error will be returned if it does not.
        /// </summary>
        /// <value> This price is in percentage basis points.&lt;br&gt; Example: 5000 &#x3D; 50% &lt;br&gt; To convert it to decimal odds, just divide 10000 by it&lt;br&gt; Example: 10000 / 5000 &#x3D; 2.0 (decimal odds).&lt;br&gt; This price has to conform to a valid tick on the exchange; an invalid price error will be returned if it does not.</value>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public int? Price { get; set; }

        /// <summary>
        ///      Quantity is the sum of the total pot (back+lay) in case the order is matched&lt;br&gt;     The units are 1/100 of a UK penny.&lt;br&gt;     Example: Quantity 1 &#x3D; 0.0001 GBP&lt;br&gt;     To convert it to back stake, just multiply by the price and divide by 100000000&lt;br&gt;     Example: 100000 (quantity) * 5000 (price) / 100000000 &#x3D; 5 GBP back stake
        /// </summary>
        /// <value>     Quantity is the sum of the total pot (back+lay) in case the order is matched&lt;br&gt;     The units are 1/100 of a UK penny.&lt;br&gt;     Example: Quantity 1 &#x3D; 0.0001 GBP&lt;br&gt;     To convert it to back stake, just multiply by the price and divide by 100000000&lt;br&gt;     Example: 100000 (quantity) * 5000 (price) / 100000000 &#x3D; 5 GBP back stake</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }


        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecentTrade {\n");
            sb.Append("  ContractId: ").Append(ContractId).Append("\n");
            sb.Append("  MarketId: ").Append(MarketId).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Side: ").Append(Side).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
            return this.Equals(input as RecentTrade);
        }

        /// <summary>
        /// Returns true if RecentTrade instances are equal
        /// </summary>
        /// <param name="input">Instance of RecentTrade to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecentTrade input)
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
                    this.MarketId == input.MarketId ||
                    (this.MarketId != null &&
                    this.MarketId.Equals(input.MarketId))
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
                    this.Side == input.Side ||
                    (this.Side != null &&
                    this.Side.Equals(input.Side))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
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
                if (this.MarketId != null)
                    hashCode = hashCode * 59 + this.MarketId.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.Side != null)
                    hashCode = hashCode * 59 + this.Side.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
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