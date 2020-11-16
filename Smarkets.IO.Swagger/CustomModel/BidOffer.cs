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

namespace IO.Swagger.CustomModel
{
    [DataContract]
    public class BidOffer : IEquatable<BidOffer>, IValidatableObject
    {
        public BidOfferType? BidOfferType { get; set; }

        public string BidOfferTypeDescription { get; set; }

        [DataMember(Name = "price", EmitDefaultValue = false)]
        public int? Price { get; set; }

        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public int? Quantity { get; set; }

        public BidOffer(string bidOfferTypeDescription = default(string), int? price = default(int), int? quantity = default(int))
        {

            if(bidOfferTypeDescription == null)
            {

            }
            else
            {
                if(bidOfferTypeDescription.ToLower() == "bid" || bidOfferTypeDescription.ToLower() == "offer")
                {
                    if(bidOfferTypeDescription.ToLower() == "bid")
                    {
                        this.BidOfferType = CustomModel.BidOfferType.Bid;
                    }
                    else
                    {
                        this.BidOfferType = CustomModel.BidOfferType.Offer;
                    }

                }
                else
                {

                }
            }
            //this.BidOfferType = bidOfferType;


            // to ensure "price" is required (not null)
            if (price == null)
            {
                throw new InvalidDataException("price is a required property for BidOffer and cannot be null");
            }
            else
            {
                this.Price = price;
            }
            // to ensure "quantity" is required (not null)
            if (quantity == null)
            {
                throw new InvalidDataException("quantity is a required property for BidOffer and cannot be null");
            }
            else
            {
                this.Quantity = quantity;
            }
        }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("BidOffer {\n");
            sb.Append("  BidOfferType: ").Append(BidOfferType).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
            return this.Equals(input as BidOffer);
        }

        /// <summary>
        /// Returns true if BidOffer instances are equal
        /// </summary>
        /// <param name="input">Instance of BidOffer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BidOffer input)
        {
            if (input == null)
                return false;

            return
                (
                    this.BidOfferType == input.BidOfferType ||
                    (this.BidOfferType != null &&
                    this.BidOfferType.Equals(input.BidOfferType))
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
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
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
