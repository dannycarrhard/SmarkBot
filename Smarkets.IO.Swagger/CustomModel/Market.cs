﻿using System;
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
    /// Market
    /// </summary>
    [DataContract]
    public partial class Market : IEquatable<Market>, IValidatableObject
    {
        /// <summary>
        /// Category of this market
        /// </summary>
        /// <value>Category of this market</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CategoryEnum
        {
            /// <summary>
            /// Enum Goals for value: goals
            /// </summary>
            [EnumMember(Value = "goals")]
            Goals = 1,
            /// <summary>
            /// Enum HalfTime for value: half-time
            /// </summary>
            [EnumMember(Value = "half-time")]
            HalfTime = 2,
            /// <summary>
            /// Enum Handicap for value: handicap
            /// </summary>
            [EnumMember(Value = "handicap")]
            Handicap = 3,
            /// <summary>
            /// Enum Totals for value: totals
            /// </summary>
            [EnumMember(Value = "totals")]
            Totals = 4,
            /// <summary>
            /// Enum Corners for value: corners
            /// </summary>
            [EnumMember(Value = "corners")]
            Corners = 5,
            /// <summary>
            /// Enum Cards for value: cards
            /// </summary>
            [EnumMember(Value = "cards")]
            Cards = 6,
            /// <summary>
            /// Enum Players for value: players
            /// </summary>
            [EnumMember(Value = "players")]
            Players = 7,
            /// <summary>
            /// Enum Winner for value: winner
            /// </summary>
            [EnumMember(Value = "winner")]
            Winner = 8,
            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 9,
            /// <summary>
            /// Enum Teams for value: teams
            /// </summary>
            [EnumMember(Value = "teams")]
            Teams = 10,
            /// <summary>
            /// Enum Place for value: place
            /// </summary>
            [EnumMember(Value = "place")]
            Place = 11,
            /// <summary>
            /// Enum Relegation for value: relegation
            /// </summary>
            [EnumMember(Value = "relegation")]
            Relegation = 12,
            /// <summary>
            /// Enum Nationality for value: nationality
            /// </summary>
            [EnumMember(Value = "nationality")]
            Nationality = 13,
            /// <summary>
            /// Enum Makethecut for value: make the cut
            /// </summary>
            [EnumMember(Value = "make the cut")]
            Makethecut = 14,
            /// <summary>
            /// Enum Firstroundleader for value: first round leader
            /// </summary>
            [EnumMember(Value = "first round leader")]
            Firstroundleader = 15
        }
        /// <summary>
        /// Category of this market
        /// </summary>
        /// <value>Category of this market</value>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        public CategoryEnum? Category { get; set; }
        /// <summary>
        ///  The display type can be used by frontend to define how the odds of the contracts of&lt;br&gt; the market will appear on the website.
        /// </summary>
        /// <value> The display type can be used by frontend to define how the odds of the contracts of&lt;br&gt; the market will appear on the website.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DisplayTypeEnum
        {
            /// <summary>
            /// Enum Population for value: population
            /// </summary>
            [EnumMember(Value = "population")]
            Population = 1,
            /// <summary>
            /// Enum Cross for value: cross
            /// </summary>
            [EnumMember(Value = "cross")]
            Cross = 2,
            /// <summary>
            /// Enum Donut for value: donut
            /// </summary>
            [EnumMember(Value = "donut")]
            Donut = 3,
            /// <summary>
            /// Enum Bars for value: bars
            /// </summary>
            [EnumMember(Value = "bars")]
            Bars = 4,
            /// <summary>
            /// Enum Bars2 for value: bars2
            /// </summary>
            [EnumMember(Value = "bars2")]
            Bars2 = 5,
            /// <summary>
            /// Enum Default for value: default
            /// </summary>
            [EnumMember(Value = "default")]
            Default = 6
        }
        /// <summary>
        ///  The display type can be used by frontend to define how the odds of the contracts of&lt;br&gt; the market will appear on the website.
        /// </summary>
        /// <value> The display type can be used by frontend to define how the odds of the contracts of&lt;br&gt; the market will appear on the website.</value>
        [DataMember(Name = "display_type", EmitDefaultValue = false)]
        public DisplayTypeEnum DisplayType { get; set; }
        /// <summary>
        ///  Market state can have the following values:&lt;br&gt; -new: just created, still not open for trading&lt;br&gt; -open: open for trading not live in-play&lt;br&gt; -live: open for trading, live in-play&lt;br&gt; -halted: trading is halted temporarily, usually due to material events&lt;br&gt; -settled: traded has ceased and the market has settled&lt;br&gt; -voided: the market was voided and no winner was chosen&lt;br&gt; -unavailable: the maret is not available for betting
        /// </summary>
        /// <value> Market state can have the following values:&lt;br&gt; -new: just created, still not open for trading&lt;br&gt; -open: open for trading not live in-play&lt;br&gt; -live: open for trading, live in-play&lt;br&gt; -halted: trading is halted temporarily, usually due to material events&lt;br&gt; -settled: traded has ceased and the market has settled&lt;br&gt; -voided: the market was voided and no winner was chosen&lt;br&gt; -unavailable: the maret is not available for betting</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum New for value: new
            /// </summary>
            [EnumMember(Value = "new")]
            New = 1,
            /// <summary>
            /// Enum Open for value: open
            /// </summary>
            [EnumMember(Value = "open")]
            Open = 2,
            /// <summary>
            /// Enum Live for value: live
            /// </summary>
            [EnumMember(Value = "live")]
            Live = 3,
            /// <summary>
            /// Enum Halted for value: halted
            /// </summary>
            [EnumMember(Value = "halted")]
            Halted = 4,
            /// <summary>
            /// Enum Settled for value: settled
            /// </summary>
            [EnumMember(Value = "settled")]
            Settled = 5,
            /// <summary>
            /// Enum Voided for value: voided
            /// </summary>
            [EnumMember(Value = "voided")]
            Voided = 6,
            /// <summary>
            /// Enum Unavailable for value: unavailable
            /// </summary>
            [EnumMember(Value = "unavailable")]
            Unavailable = 7
        }
        /// <summary>
        ///  Market state can have the following values:&lt;br&gt; -new: just created, still not open for trading&lt;br&gt; -open: open for trading not live in-play&lt;br&gt; -live: open for trading, live in-play&lt;br&gt; -halted: trading is halted temporarily, usually due to material events&lt;br&gt; -settled: traded has ceased and the market has settled&lt;br&gt; -voided: the market was voided and no winner was chosen&lt;br&gt; -unavailable: the maret is not available for betting
        /// </summary>
        /// <value> Market state can have the following values:&lt;br&gt; -new: just created, still not open for trading&lt;br&gt; -open: open for trading not live in-play&lt;br&gt; -live: open for trading, live in-play&lt;br&gt; -halted: trading is halted temporarily, usually due to material events&lt;br&gt; -settled: traded has ceased and the market has settled&lt;br&gt; -voided: the market was voided and no winner was chosen&lt;br&gt; -unavailable: the maret is not available for betting</value>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public StateEnum State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Market" /> class.
        /// </summary>
        /// <param name="betDelay">How much is the bet delay for this market,\&quot; the interval between order placement and acceptance (required).</param>
        /// <param name="cashoutEnabled"> Cashout enabled determines whether instant cashout is enabled for this market. If true, trading out of this market will cause the settlement result to be immediatelly reflected in the customer&#x27;s balance (before the final settlement of the market). (required).</param>
        /// <param name="category">Category of this market.</param>
        /// <param name="complete">Complete markets cannot have additional contracts added after market creation (required).</param>
        /// <param name="contractSelections"> These particular contracts are not related to markets in the same way that most contracts are related to markets.&lt;br&gt; The contract_selections field is only set for accumulator markets and it refers to the contract IDs that the acca is made up of, an example:&lt;br&gt; &lt;br&gt; M1 (Winner market in Man Utd - Liverpool) &lt;ul&gt; &lt;li&gt;M1-C1 (Man Utd) &lt;li&gt;M1-C2 (Draw) &lt;li&gt;M1-C3 (Liverpool) &lt;/ul&gt; &lt;/ul&gt; M2 (Winner market in Arsenal - Chelsea) &lt;ul&gt; &lt;li&gt;M2-C1 (Arsenal) &lt;li&gt;M2-C2 (Draw) &lt;li&gt;M2-C3 (Chelsea) &lt;/ul&gt; &lt;br&gt; Now an accumulator market is created:&lt;br&gt; M3 (Man Utd and Arsenal both to win on 23rd of February) &lt;ul&gt; &lt;li&gt;M3-C1 (Yes) &lt;li&gt;M3-C2 (No) &lt;/ul&gt; &lt;br&gt; In this case, M3 will have two contracts (M3-C1 and M3-C2) but contract_selections will be M1-C1 (Man Utd) and M2-C1 (Arsenal).&lt;br&gt;.</param>
        /// <param name="created">When was the market created in the Smarkets exchange (required).</param>
        /// <param name="description">A summary about this market.</param>
        /// <param name="displayOrder">Markets are sorted in the website according to these numbers in descending order.</param>
        /// <param name="displayType"> The display type can be used by frontend to define how the odds of the contracts of&lt;br&gt; the market will appear on the website. (required) (default to DisplayTypeEnum.Default).</param>
        /// <param name="eventId">This ID uniquely identifies an event (required).</param>
        /// <param name="hidden">Hidden markets aren&#x27;t displayed in our website (required).</param>
        /// <param name="id">This ID uniquely identifies the market (required).</param>
        /// <param name="inplayEnabled">True if trading will be open when the markets go live in-play.</param>
        /// <param name="marketType">marketType (required).</param>
        /// <param name="modified">The datetime of the last modification made by Smarkets to the market properties (required).</param>
        /// <param name="name"> Name of the market. This field is for display purposes and should not be used to identify the market.&lt;br&gt; The market_type field should be used instead. (required).</param>
        /// <param name="slug"> Slug concisely represents the market.&lt;br&gt; It should not be used to identify the market.&lt;br&gt; The market_type field should be used instead. (required).</param>
        /// <param name="state"> Market state can have the following values:&lt;br&gt; -new: just created, still not open for trading&lt;br&gt; -open: open for trading not live in-play&lt;br&gt; -live: open for trading, live in-play&lt;br&gt; -halted: trading is halted temporarily, usually due to material events&lt;br&gt; -settled: traded has ceased and the market has settled&lt;br&gt; -voided: the market was voided and no winner was chosen&lt;br&gt; -unavailable: the maret is not available for betting (required).</param>
        /// <param name="winnerCount"> How many winners will the market have.&lt;br&gt; Usually this number is 1, except for \&quot;To Place\&quot;, \&quot;Top x Finish\&quot; type markets      (required).</param>
        public Market(int? betDelay = default(int?), bool? cashoutEnabled = default(bool?), CategoryEnum? category = default(CategoryEnum?), bool? complete = default(bool?), List<int?> contractSelections = default(List<int?>), DateTime? created = default(DateTime?), string description = default(string), int? displayOrder = default(int?), DisplayTypeEnum displayType = DisplayTypeEnum.Default, string eventId = default(string), bool? hidden = default(bool?), string id = default(string), bool? inplayEnabled = default(bool?), AccountActivityResponseMarketType marketType = default(AccountActivityResponseMarketType), DateTime? modified = default(DateTime?), string name = default(string), string slug = default(string), StateEnum state = default(StateEnum), int? winnerCount = default(int?))
        {
            // to ensure "betDelay" is required (not null)
            if (betDelay == null)
            {
                throw new InvalidDataException("betDelay is a required property for Market and cannot be null");
            }
            else
            {
                this.BetDelay = betDelay;
            }
            // to ensure "cashoutEnabled" is required (not null)
            if (cashoutEnabled == null)
            {
                throw new InvalidDataException("cashoutEnabled is a required property for Market and cannot be null");
            }
            else
            {
                this.CashoutEnabled = cashoutEnabled;
            }
            // to ensure "complete" is required (not null)
            if (complete == null)
            {
                throw new InvalidDataException("complete is a required property for Market and cannot be null");
            }
            else
            {
                this.Complete = complete;
            }
            // to ensure "created" is required (not null)
            if (created == null)
            {
                throw new InvalidDataException("created is a required property for Market and cannot be null");
            }
            else
            {
                this.Created = created;
            }
            // to ensure "displayType" is required (not null)
            if (displayType == null)
            {
                throw new InvalidDataException("displayType is a required property for Market and cannot be null");
            }
            else
            {
                this.DisplayType = displayType;
            }
            // to ensure "eventId" is required (not null)
            if (eventId == null)
            {
                throw new InvalidDataException("eventId is a required property for Market and cannot be null");
            }
            else
            {
                this.EventId = eventId;
            }
            // to ensure "hidden" is required (not null)
            if (hidden == null)
            {
                throw new InvalidDataException("hidden is a required property for Market and cannot be null");
            }
            else
            {
                this.Hidden = hidden;
            }
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for Market and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "marketType" is required (not null)
            if (marketType == null)
            {
                throw new InvalidDataException("marketType is a required property for Market and cannot be null");
            }
            else
            {
                this.MarketType = marketType;
            }
            // to ensure "modified" is required (not null)
            if (modified == null)
            {
                throw new InvalidDataException("modified is a required property for Market and cannot be null");
            }
            else
            {
                this.Modified = modified;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Market and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "slug" is required (not null)
            if (slug == null)
            {
                throw new InvalidDataException("slug is a required property for Market and cannot be null");
            }
            else
            {
                this.Slug = slug;
            }
            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new InvalidDataException("state is a required property for Market and cannot be null");
            }
            else
            {
                this.State = state;
            }
            // to ensure "winnerCount" is required (not null)
            if (winnerCount == null)
            {
                throw new InvalidDataException("winnerCount is a required property for Market and cannot be null");
            }
            else
            {
                this.WinnerCount = winnerCount;
            }
            this.Category = category;
            this.ContractSelections = contractSelections;
            this.Description = description;
            this.DisplayOrder = displayOrder;
            this.InplayEnabled = inplayEnabled;
        }

        /// <summary>
        /// How much is the bet delay for this market,\&quot; the interval between order placement and acceptance
        /// </summary>
        /// <value>How much is the bet delay for this market,\&quot; the interval between order placement and acceptance</value>
        [DataMember(Name = "bet_delay", EmitDefaultValue = false)]
        public int? BetDelay { get; set; }

        /// <summary>
        ///  Cashout enabled determines whether instant cashout is enabled for this market. If true, trading out of this market will cause the settlement result to be immediatelly reflected in the customer&#x27;s balance (before the final settlement of the market).
        /// </summary>
        /// <value> Cashout enabled determines whether instant cashout is enabled for this market. If true, trading out of this market will cause the settlement result to be immediatelly reflected in the customer&#x27;s balance (before the final settlement of the market).</value>
        [DataMember(Name = "cashout_enabled", EmitDefaultValue = false)]
        public bool? CashoutEnabled { get; set; }


        /// <summary>
        /// Complete markets cannot have additional contracts added after market creation
        /// </summary>
        /// <value>Complete markets cannot have additional contracts added after market creation</value>
        [DataMember(Name = "complete", EmitDefaultValue = false)]
        public bool? Complete { get; set; }

        /// <summary>
        ///  These particular contracts are not related to markets in the same way that most contracts are related to markets.&lt;br&gt; The contract_selections field is only set for accumulator markets and it refers to the contract IDs that the acca is made up of, an example:&lt;br&gt; &lt;br&gt; M1 (Winner market in Man Utd - Liverpool) &lt;ul&gt; &lt;li&gt;M1-C1 (Man Utd) &lt;li&gt;M1-C2 (Draw) &lt;li&gt;M1-C3 (Liverpool) &lt;/ul&gt; &lt;/ul&gt; M2 (Winner market in Arsenal - Chelsea) &lt;ul&gt; &lt;li&gt;M2-C1 (Arsenal) &lt;li&gt;M2-C2 (Draw) &lt;li&gt;M2-C3 (Chelsea) &lt;/ul&gt; &lt;br&gt; Now an accumulator market is created:&lt;br&gt; M3 (Man Utd and Arsenal both to win on 23rd of February) &lt;ul&gt; &lt;li&gt;M3-C1 (Yes) &lt;li&gt;M3-C2 (No) &lt;/ul&gt; &lt;br&gt; In this case, M3 will have two contracts (M3-C1 and M3-C2) but contract_selections will be M1-C1 (Man Utd) and M2-C1 (Arsenal).&lt;br&gt;
        /// </summary>
        /// <value> These particular contracts are not related to markets in the same way that most contracts are related to markets.&lt;br&gt; The contract_selections field is only set for accumulator markets and it refers to the contract IDs that the acca is made up of, an example:&lt;br&gt; &lt;br&gt; M1 (Winner market in Man Utd - Liverpool) &lt;ul&gt; &lt;li&gt;M1-C1 (Man Utd) &lt;li&gt;M1-C2 (Draw) &lt;li&gt;M1-C3 (Liverpool) &lt;/ul&gt; &lt;/ul&gt; M2 (Winner market in Arsenal - Chelsea) &lt;ul&gt; &lt;li&gt;M2-C1 (Arsenal) &lt;li&gt;M2-C2 (Draw) &lt;li&gt;M2-C3 (Chelsea) &lt;/ul&gt; &lt;br&gt; Now an accumulator market is created:&lt;br&gt; M3 (Man Utd and Arsenal both to win on 23rd of February) &lt;ul&gt; &lt;li&gt;M3-C1 (Yes) &lt;li&gt;M3-C2 (No) &lt;/ul&gt; &lt;br&gt; In this case, M3 will have two contracts (M3-C1 and M3-C2) but contract_selections will be M1-C1 (Man Utd) and M2-C1 (Arsenal).&lt;br&gt;</value>
        [DataMember(Name = "contract_selections", EmitDefaultValue = false)]
        public List<int?> ContractSelections { get; set; }

        /// <summary>
        /// When was the market created in the Smarkets exchange
        /// </summary>
        /// <value>When was the market created in the Smarkets exchange</value>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// A summary about this market
        /// </summary>
        /// <value>A summary about this market</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Markets are sorted in the website according to these numbers in descending order
        /// </summary>
        /// <value>Markets are sorted in the website according to these numbers in descending order</value>
        [DataMember(Name = "display_order", EmitDefaultValue = false)]
        public int? DisplayOrder { get; set; }


        /// <summary>
        /// This ID uniquely identifies an event
        /// </summary>
        /// <value>This ID uniquely identifies an event</value>
        [DataMember(Name = "event_id", EmitDefaultValue = false)]
        public string EventId { get; set; }

        /// <summary>
        /// Hidden markets aren&#x27;t displayed in our website
        /// </summary>
        /// <value>Hidden markets aren&#x27;t displayed in our website</value>
        [DataMember(Name = "hidden", EmitDefaultValue = false)]
        public bool? Hidden { get; set; }

        /// <summary>
        /// This ID uniquely identifies the market
        /// </summary>
        /// <value>This ID uniquely identifies the market</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// True if trading will be open when the markets go live in-play
        /// </summary>
        /// <value>True if trading will be open when the markets go live in-play</value>
        [DataMember(Name = "inplay_enabled", EmitDefaultValue = false)]
        public bool? InplayEnabled { get; set; }

        /// <summary>
        /// Gets or Sets MarketType
        /// </summary>
        [DataMember(Name = "market_type", EmitDefaultValue = false)]
        public AccountActivityResponseMarketType MarketType { get; set; }

        /// <summary>
        /// The datetime of the last modification made by Smarkets to the market properties
        /// </summary>
        /// <value>The datetime of the last modification made by Smarkets to the market properties</value>
        [DataMember(Name = "modified", EmitDefaultValue = false)]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///  Name of the market. This field is for display purposes and should not be used to identify the market.&lt;br&gt; The market_type field should be used instead.
        /// </summary>
        /// <value> Name of the market. This field is for display purposes and should not be used to identify the market.&lt;br&gt; The market_type field should be used instead.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        ///  Slug concisely represents the market.&lt;br&gt; It should not be used to identify the market.&lt;br&gt; The market_type field should be used instead.
        /// </summary>
        /// <value> Slug concisely represents the market.&lt;br&gt; It should not be used to identify the market.&lt;br&gt; The market_type field should be used instead.</value>
        [DataMember(Name = "slug", EmitDefaultValue = false)]
        public string Slug { get; set; }


        /// <summary>
        ///  How many winners will the market have.&lt;br&gt; Usually this number is 1, except for \&quot;To Place\&quot;, \&quot;Top x Finish\&quot; type markets     
        /// </summary>
        /// <value> How many winners will the market have.&lt;br&gt; Usually this number is 1, except for \&quot;To Place\&quot;, \&quot;Top x Finish\&quot; type markets     </value>
        [DataMember(Name = "winner_count", EmitDefaultValue = false)]
        public int? WinnerCount { get; set; }

        public List<Contract> Contracts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Market {\n");
            sb.Append("  BetDelay: ").Append(BetDelay).Append("\n");
            sb.Append("  CashoutEnabled: ").Append(CashoutEnabled).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Complete: ").Append(Complete).Append("\n");
            sb.Append("  ContractSelections: ").Append(ContractSelections).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisplayOrder: ").Append(DisplayOrder).Append("\n");
            sb.Append("  DisplayType: ").Append(DisplayType).Append("\n");
            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  Hidden: ").Append(Hidden).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InplayEnabled: ").Append(InplayEnabled).Append("\n");
            sb.Append("  MarketType: ").Append(MarketType).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  WinnerCount: ").Append(WinnerCount).Append("\n");
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
            return this.Equals(input as Market);
        }

        /// <summary>
        /// Returns true if Market instances are equal
        /// </summary>
        /// <param name="input">Instance of Market to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Market input)
        {
            if (input == null)
                return false;

            return
                (
                    this.BetDelay == input.BetDelay ||
                    (this.BetDelay != null &&
                    this.BetDelay.Equals(input.BetDelay))
                ) &&
                (
                    this.CashoutEnabled == input.CashoutEnabled ||
                    (this.CashoutEnabled != null &&
                    this.CashoutEnabled.Equals(input.CashoutEnabled))
                ) &&
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) &&
                (
                    this.Complete == input.Complete ||
                    (this.Complete != null &&
                    this.Complete.Equals(input.Complete))
                ) &&
                (
                    this.ContractSelections == input.ContractSelections ||
                    this.ContractSelections != null &&
                    input.ContractSelections != null &&
                    this.ContractSelections.SequenceEqual(input.ContractSelections)
                ) &&
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) &&
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) &&
                (
                    this.DisplayOrder == input.DisplayOrder ||
                    (this.DisplayOrder != null &&
                    this.DisplayOrder.Equals(input.DisplayOrder))
                ) &&
                (
                    this.DisplayType == input.DisplayType ||
                    (this.DisplayType != null &&
                    this.DisplayType.Equals(input.DisplayType))
                ) &&
                (
                    this.EventId == input.EventId ||
                    (this.EventId != null &&
                    this.EventId.Equals(input.EventId))
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
                    this.InplayEnabled == input.InplayEnabled ||
                    (this.InplayEnabled != null &&
                    this.InplayEnabled.Equals(input.InplayEnabled))
                ) &&
                (
                    this.MarketType == input.MarketType ||
                    (this.MarketType != null &&
                    this.MarketType.Equals(input.MarketType))
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
                    this.Slug == input.Slug ||
                    (this.Slug != null &&
                    this.Slug.Equals(input.Slug))
                ) &&
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) &&
                (
                    this.WinnerCount == input.WinnerCount ||
                    (this.WinnerCount != null &&
                    this.WinnerCount.Equals(input.WinnerCount))
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
                if (this.BetDelay != null)
                    hashCode = hashCode * 59 + this.BetDelay.GetHashCode();
                if (this.CashoutEnabled != null)
                    hashCode = hashCode * 59 + this.CashoutEnabled.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Complete != null)
                    hashCode = hashCode * 59 + this.Complete.GetHashCode();
                if (this.ContractSelections != null)
                    hashCode = hashCode * 59 + this.ContractSelections.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DisplayOrder != null)
                    hashCode = hashCode * 59 + this.DisplayOrder.GetHashCode();
                if (this.DisplayType != null)
                    hashCode = hashCode * 59 + this.DisplayType.GetHashCode();
                if (this.EventId != null)
                    hashCode = hashCode * 59 + this.EventId.GetHashCode();
                if (this.Hidden != null)
                    hashCode = hashCode * 59 + this.Hidden.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InplayEnabled != null)
                    hashCode = hashCode * 59 + this.InplayEnabled.GetHashCode();
                if (this.MarketType != null)
                    hashCode = hashCode * 59 + this.MarketType.GetHashCode();
                if (this.Modified != null)
                    hashCode = hashCode * 59 + this.Modified.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Slug != null)
                    hashCode = hashCode * 59 + this.Slug.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.WinnerCount != null)
                    hashCode = hashCode * 59 + this.WinnerCount.GetHashCode();
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
