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
using IO.Swagger.Model;

namespace IO.Swagger.CustomModel
{
    /// <summary>
    /// Contract
    /// </summary>
    [DataContract]
    public partial class Contract : IEquatable<Contract>, IValidatableObject
    {
        /// <summary>
        ///  state_or_outcome can have the following values: &lt;ul&gt; &lt;li&gt;new: The contract was just created and is still not available for betting &lt;li&gt;open: open for betting &lt;li&gt;live: open and trading live in-play &lt;li&gt;halted: Trading on this contract has halted &lt;li&gt;winner: settled as winner. &lt;li&gt;loser:  settled as loser. &lt;li&gt;deadheat: settled as a deadheat - a tie with other contract. &lt;li&gt;reduced: withdrawn and a reduction factor was applied. &lt;li&gt;voided: no longer available for betting &lt;li&gt;unavailable: not currently available for betting &lt;/ul&gt;     
        /// </summary>
        /// <value> state_or_outcome can have the following values: &lt;ul&gt; &lt;li&gt;new: The contract was just created and is still not available for betting &lt;li&gt;open: open for betting &lt;li&gt;live: open and trading live in-play &lt;li&gt;halted: Trading on this contract has halted &lt;li&gt;winner: settled as winner. &lt;li&gt;loser:  settled as loser. &lt;li&gt;deadheat: settled as a deadheat - a tie with other contract. &lt;li&gt;reduced: withdrawn and a reduction factor was applied. &lt;li&gt;voided: no longer available for betting &lt;li&gt;unavailable: not currently available for betting &lt;/ul&gt;     </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateOrOutcomeEnum
        {
            /// <summary>
            /// Enum Live for value: live
            /// </summary>
            [EnumMember(Value = "live")]
            Live = 1,
            /// <summary>
            /// Enum Open for value: open
            /// </summary>
            [EnumMember(Value = "open")]
            Open = 2,
            /// <summary>
            /// Enum New for value: new
            /// </summary>
            [EnumMember(Value = "new")]
            New = 3,
            /// <summary>
            /// Enum Halted for value: halted
            /// </summary>
            [EnumMember(Value = "halted")]
            Halted = 4,
            /// <summary>
            /// Enum Winner for value: winner
            /// </summary>
            [EnumMember(Value = "winner")]
            Winner = 5,
            /// <summary>
            /// Enum Loser for value: loser
            /// </summary>
            [EnumMember(Value = "loser")]
            Loser = 6,
            /// <summary>
            /// Enum Deadheat for value: deadheat
            /// </summary>
            [EnumMember(Value = "deadheat")]
            Deadheat = 7,
            /// <summary>
            /// Enum Reduced for value: reduced
            /// </summary>
            [EnumMember(Value = "reduced")]
            Reduced = 8,
            /// <summary>
            /// Enum Voided for value: voided
            /// </summary>
            [EnumMember(Value = "voided")]
            Voided = 9,
            /// <summary>
            /// Enum Unavailable for value: unavailable
            /// </summary>
            [EnumMember(Value = "unavailable")]
            Unavailable = 10
        }
        /// <summary>
        ///  state_or_outcome can have the following values: &lt;ul&gt; &lt;li&gt;new: The contract was just created and is still not available for betting &lt;li&gt;open: open for betting &lt;li&gt;live: open and trading live in-play &lt;li&gt;halted: Trading on this contract has halted &lt;li&gt;winner: settled as winner. &lt;li&gt;loser:  settled as loser. &lt;li&gt;deadheat: settled as a deadheat - a tie with other contract. &lt;li&gt;reduced: withdrawn and a reduction factor was applied. &lt;li&gt;voided: no longer available for betting &lt;li&gt;unavailable: not currently available for betting &lt;/ul&gt;     
        /// </summary>
        /// <value> state_or_outcome can have the following values: &lt;ul&gt; &lt;li&gt;new: The contract was just created and is still not available for betting &lt;li&gt;open: open for betting &lt;li&gt;live: open and trading live in-play &lt;li&gt;halted: Trading on this contract has halted &lt;li&gt;winner: settled as winner. &lt;li&gt;loser:  settled as loser. &lt;li&gt;deadheat: settled as a deadheat - a tie with other contract. &lt;li&gt;reduced: withdrawn and a reduction factor was applied. &lt;li&gt;voided: no longer available for betting &lt;li&gt;unavailable: not currently available for betting &lt;/ul&gt;     </value>
        [DataMember(Name = "state_or_outcome", EmitDefaultValue = false)]
        public StateOrOutcomeEnum StateOrOutcome { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Contract" /> class.
        /// </summary>
        /// <param name="competitorId">The Smarkets competitor model id.</param>
        /// <param name="contractType">contractType.</param>
        /// <param name="created">When was the contract created in the Smarkets exchange (required).</param>
        /// <param name="displayOrder">Smarkets will display the contracts sorted by these values, in descending order.</param>
        /// <param name="hidden">Hidden contracts aren&#x27;t displayed in our website.</param>
        /// <param name="id">This ID uniquely identifies the contract (required).</param>
        /// <param name="info">info.</param>
        /// <param name="marketId">This ID uniquely identifies the market (required).</param>
        /// <param name="modified">The datetime of the last modification made by Smarkets to the&lt;br&gt; contract properties (required).</param>
        /// <param name="name">Name for the contract, as displayed in our website.&lt;br&gt; Examples can be team names, horse names or other winning outcomes for each market.&lt;br&gt; It should not be used to identify the contract.&lt;br&gt; The contract_type field should be used instead. (required).</param>
        /// <param name="outcomeTimestamp">If the contract has settled, this will have the settlement datetime, null otherwise (required).</param>
        /// <param name="reductionFactor">reductionFactor.</param>
        /// <param name="slug">Slug concisely represents the contract.&lt;br&gt; It should not be used to identify the contract.&lt;br&gt; The contract_type field should be used instead. (required).</param>
        /// <param name="stateOrOutcome"> state_or_outcome can have the following values: &lt;ul&gt; &lt;li&gt;new: The contract was just created and is still not available for betting &lt;li&gt;open: open for betting &lt;li&gt;live: open and trading live in-play &lt;li&gt;halted: Trading on this contract has halted &lt;li&gt;winner: settled as winner. &lt;li&gt;loser:  settled as loser. &lt;li&gt;deadheat: settled as a deadheat - a tie with other contract. &lt;li&gt;reduced: withdrawn and a reduction factor was applied. &lt;li&gt;voided: no longer available for betting &lt;li&gt;unavailable: not currently available for betting &lt;/ul&gt;      (required).</param>
        public Contract(int? competitorId = default(int?), ContractsResponseContractType contractType = default(ContractsResponseContractType), DateTime? created = default(DateTime?), int? displayOrder = default(int?), bool? hidden = default(bool?), string id = default(string), ContractsResponseInfo info = default(ContractsResponseInfo), string marketId = default(string), DateTime? modified = default(DateTime?), string name = default(string), DateTime? outcomeTimestamp = default(DateTime?), string reductionFactor = default(string), string slug = default(string), StateOrOutcomeEnum stateOrOutcome = default(StateOrOutcomeEnum))
        {
            // to ensure "created" is required (not null)
            if (created == null)
            {
                throw new InvalidDataException("created is a required property for Contract and cannot be null");
            }
            else
            {
                this.Created = created;
            }
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for Contract and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "marketId" is required (not null)
            if (marketId == null)
            {
                throw new InvalidDataException("marketId is a required property for Contract and cannot be null");
            }
            else
            {
                this.MarketId = marketId;
            }
            // to ensure "modified" is required (not null)
            if (modified == null)
            {
                throw new InvalidDataException("modified is a required property for Contract and cannot be null");
            }
            else
            {
                this.Modified = modified;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Contract and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "outcomeTimestamp" is required (not null)
            if (outcomeTimestamp == null)
            {
                this.OutcomeTimestamp = outcomeTimestamp;
                //throw new InvalidDataException("outcomeTimestamp is a required property for Contract and cannot be null");
            }
            else
            {
                this.OutcomeTimestamp = outcomeTimestamp;
            }
            // to ensure "slug" is required (not null)
            if (slug == null)
            {
                throw new InvalidDataException("slug is a required property for Contract and cannot be null");
            }
            else
            {
                this.Slug = slug;
            }
            // to ensure "stateOrOutcome" is required (not null)
            if (stateOrOutcome == null)
            {
                throw new InvalidDataException("stateOrOutcome is a required property for Contract and cannot be null");
            }
            else
            {
                this.StateOrOutcome = stateOrOutcome;
            }
            this.CompetitorId = competitorId;
            this.ContractType = contractType;
            this.DisplayOrder = displayOrder;
            this.Hidden = hidden;
            this.Info = info;
            this.ReductionFactor = reductionFactor;
        }

        /// <summary>
        /// The Smarkets competitor model id
        /// </summary>
        /// <value>The Smarkets competitor model id</value>
        [DataMember(Name = "competitor_id", EmitDefaultValue = false)]
        public int? CompetitorId { get; set; }

        /// <summary>
        /// Gets or Sets ContractType
        /// </summary>
        [DataMember(Name = "contract_type", EmitDefaultValue = false)]
        public ContractsResponseContractType ContractType { get; set; }

        /// <summary>
        /// When was the contract created in the Smarkets exchange
        /// </summary>
        /// <value>When was the contract created in the Smarkets exchange</value>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Smarkets will display the contracts sorted by these values, in descending order
        /// </summary>
        /// <value>Smarkets will display the contracts sorted by these values, in descending order</value>
        [DataMember(Name = "display_order", EmitDefaultValue = false)]
        public int? DisplayOrder { get; set; }

        /// <summary>
        /// Hidden contracts aren&#x27;t displayed in our website
        /// </summary>
        /// <value>Hidden contracts aren&#x27;t displayed in our website</value>
        [DataMember(Name = "hidden", EmitDefaultValue = false)]
        public bool? Hidden { get; set; }

        /// <summary>
        /// This ID uniquely identifies the contract
        /// </summary>
        /// <value>This ID uniquely identifies the contract</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Info
        /// </summary>
        [DataMember(Name = "info", EmitDefaultValue = false)]
        public ContractsResponseInfo Info { get; set; }

        /// <summary>
        /// This ID uniquely identifies the market
        /// </summary>
        /// <value>This ID uniquely identifies the market</value>
        [DataMember(Name = "market_id", EmitDefaultValue = false)]
        public string MarketId { get; set; }

        /// <summary>
        /// The datetime of the last modification made by Smarkets to the&lt;br&gt; contract properties
        /// </summary>
        /// <value>The datetime of the last modification made by Smarkets to the&lt;br&gt; contract properties</value>
        [DataMember(Name = "modified", EmitDefaultValue = false)]
        public DateTime? Modified { get; set; }

        /// <summary>
        /// Name for the contract, as displayed in our website.&lt;br&gt; Examples can be team names, horse names or other winning outcomes for each market.&lt;br&gt; It should not be used to identify the contract.&lt;br&gt; The contract_type field should be used instead.
        /// </summary>
        /// <value>Name for the contract, as displayed in our website.&lt;br&gt; Examples can be team names, horse names or other winning outcomes for each market.&lt;br&gt; It should not be used to identify the contract.&lt;br&gt; The contract_type field should be used instead.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// If the contract has settled, this will have the settlement datetime, null otherwise
        /// </summary>
        /// <value>If the contract has settled, this will have the settlement datetime, null otherwise</value>
        [DataMember(Name = "outcome_timestamp", EmitDefaultValue = false)]
        public DateTime? OutcomeTimestamp { get; set; }

        /// <summary>
        /// Gets or Sets ReductionFactor
        /// </summary>
        [DataMember(Name = "reduction_factor", EmitDefaultValue = false)]
        public string ReductionFactor { get; set; }

        /// <summary>
        /// Slug concisely represents the contract.&lt;br&gt; It should not be used to identify the contract.&lt;br&gt; The contract_type field should be used instead.
        /// </summary>
        /// <value>Slug concisely represents the contract.&lt;br&gt; It should not be used to identify the contract.&lt;br&gt; The contract_type field should be used instead.</value>
        [DataMember(Name = "slug", EmitDefaultValue = false)]
        public string Slug { get; set; }

        public Quote Quote { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Contract {\n");
            sb.Append("  CompetitorId: ").Append(CompetitorId).Append("\n");
            sb.Append("  ContractType: ").Append(ContractType).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  DisplayOrder: ").Append(DisplayOrder).Append("\n");
            sb.Append("  Hidden: ").Append(Hidden).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Info: ").Append(Info).Append("\n");
            sb.Append("  MarketId: ").Append(MarketId).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OutcomeTimestamp: ").Append(OutcomeTimestamp).Append("\n");
            sb.Append("  ReductionFactor: ").Append(ReductionFactor).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  StateOrOutcome: ").Append(StateOrOutcome).Append("\n");
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
            return this.Equals(input as Contract);
        }

        /// <summary>
        /// Returns true if Contract instances are equal
        /// </summary>
        /// <param name="input">Instance of Contract to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Contract input)
        {
            if (input == null)
                return false;

            return
                (
                    this.CompetitorId == input.CompetitorId ||
                    (this.CompetitorId != null &&
                    this.CompetitorId.Equals(input.CompetitorId))
                ) &&
                (
                    this.ContractType == input.ContractType ||
                    (this.ContractType != null &&
                    this.ContractType.Equals(input.ContractType))
                ) &&
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) &&
                (
                    this.DisplayOrder == input.DisplayOrder ||
                    (this.DisplayOrder != null &&
                    this.DisplayOrder.Equals(input.DisplayOrder))
                ) &&
                (
                    this.Hidden == input.Hidden ||
                    (this.Hidden != null &&
                    this.Hidden.Equals(input.Hidden))
                ) &&
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) &&
                (
                    this.Info == input.Info ||
                    (this.Info != null &&
                    this.Info.Equals(input.Info))
                ) &&
                (
                    this.MarketId == input.MarketId ||
                    (this.MarketId != null &&
                    this.MarketId.Equals(input.MarketId))
                ) &&
                (
                    this.Modified == input.Modified ||
                    (this.Modified != null &&
                    this.Modified.Equals(input.Modified))
                ) &&
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) &&
                (
                    this.OutcomeTimestamp == input.OutcomeTimestamp ||
                    (this.OutcomeTimestamp != null &&
                    this.OutcomeTimestamp.Equals(input.OutcomeTimestamp))
                ) &&
                (
                    this.ReductionFactor == input.ReductionFactor ||
                    (this.ReductionFactor != null &&
                    this.ReductionFactor.Equals(input.ReductionFactor))
                ) &&
                (
                    this.Slug == input.Slug ||
                    (this.Slug != null &&
                    this.Slug.Equals(input.Slug))
                ) &&
                (
                    this.StateOrOutcome == input.StateOrOutcome ||
                    (this.StateOrOutcome != null &&
                    this.StateOrOutcome.Equals(input.StateOrOutcome))
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
                if (this.CompetitorId != null)
                    hashCode = hashCode * 59 + this.CompetitorId.GetHashCode();
                if (this.ContractType != null)
                    hashCode = hashCode * 59 + this.ContractType.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.DisplayOrder != null)
                    hashCode = hashCode * 59 + this.DisplayOrder.GetHashCode();
                if (this.Hidden != null)
                    hashCode = hashCode * 59 + this.Hidden.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Info != null)
                    hashCode = hashCode * 59 + this.Info.GetHashCode();
                if (this.MarketId != null)
                    hashCode = hashCode * 59 + this.MarketId.GetHashCode();
                if (this.Modified != null)
                    hashCode = hashCode * 59 + this.Modified.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OutcomeTimestamp != null)
                    hashCode = hashCode * 59 + this.OutcomeTimestamp.GetHashCode();
                if (this.ReductionFactor != null)
                    hashCode = hashCode * 59 + this.ReductionFactor.GetHashCode();
                if (this.Slug != null)
                    hashCode = hashCode * 59 + this.Slug.GetHashCode();
                if (this.StateOrOutcome != null)
                    hashCode = hashCode * 59 + this.StateOrOutcome.GetHashCode();
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
