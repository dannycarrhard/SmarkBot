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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;
using IO.Swagger.Model;

namespace IO.Swagger.CustomModel
{
    /// <summary>
    /// ModelEvent
    /// </summary>
    [DataContract]
    public partial class Event
    {
        /// <summary>
        ///  Event state can have the following values: &lt;ul&gt; &lt;li&gt;upcoming: the event is now open for betting &lt;li&gt;live: the event is now live in-play &lt;li&gt;ended: the event has ended and its markets should be settled &lt;li&gt;settled: the event has ended and its markets should be settled &lt;li&gt;cancelled: the event was cancelled and didn&#x27;t take place &lt;li&gt;suspended: the event was suspended and during play time &lt;/ul&gt;     
        /// </summary>
        /// <value> Event state can have the following values: &lt;ul&gt; &lt;li&gt;upcoming: the event is now open for betting &lt;li&gt;live: the event is now live in-play &lt;li&gt;ended: the event has ended and its markets should be settled &lt;li&gt;settled: the event has ended and its markets should be settled &lt;li&gt;cancelled: the event was cancelled and didn&#x27;t take place &lt;li&gt;suspended: the event was suspended and during play time &lt;/ul&gt;     </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum New for value: new
            /// </summary>
            [EnumMember(Value = "new")]
            New = 1,
            /// <summary>
            /// Enum Upcoming for value: upcoming
            /// </summary>
            [EnumMember(Value = "upcoming")]
            Upcoming = 2,
            /// <summary>
            /// Enum Live for value: live
            /// </summary>
            [EnumMember(Value = "live")]
            Live = 3,
            /// <summary>
            /// Enum Ended for value: ended
            /// </summary>
            [EnumMember(Value = "ended")]
            Ended = 4,
            /// <summary>
            /// Enum Settled for value: settled
            /// </summary>
            [EnumMember(Value = "settled")]
            Settled = 5,
            /// <summary>
            /// Enum Cancelled for value: cancelled
            /// </summary>
            [EnumMember(Value = "cancelled")]
            Cancelled = 6,
            /// <summary>
            /// Enum Suspended for value: suspended
            /// </summary>
            [EnumMember(Value = "suspended")]
            Suspended = 7
        }
        /// <summary>
        ///  Event state can have the following values: &lt;ul&gt; &lt;li&gt;upcoming: the event is now open for betting &lt;li&gt;live: the event is now live in-play &lt;li&gt;ended: the event has ended and its markets should be settled &lt;li&gt;settled: the event has ended and its markets should be settled &lt;li&gt;cancelled: the event was cancelled and didn&#x27;t take place &lt;li&gt;suspended: the event was suspended and during play time &lt;/ul&gt;     
        /// </summary>
        /// <value> Event state can have the following values: &lt;ul&gt; &lt;li&gt;upcoming: the event is now open for betting &lt;li&gt;live: the event is now live in-play &lt;li&gt;ended: the event has ended and its markets should be settled &lt;li&gt;settled: the event has ended and its markets should be settled &lt;li&gt;cancelled: the event was cancelled and didn&#x27;t take place &lt;li&gt;suspended: the event was suspended and during play time &lt;/ul&gt;     </value>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public StateEnum State { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelEvent" /> class.
        /// </summary>
        /// <param name="betAllowed">Determines whether bets are allowed in the given jurisdiction.</param>
        /// <param name="bettable">This needs to be True for events to be open for trading.</param>
        /// <param name="chartTimePeriod">A string to be used by frontend to show/default selectable chart time periods.</param>
        /// <param name="created">When was the event created in the Smarkets exchange (required).</param>
        /// <param name="description">Additional description for this event (required).</param>
        /// <param name="displayOrder">On Smarkets listings pages, events will be sorted according to these numbers, in descending order.</param>
        /// <param name="endDate">When the event is scheduled to end (required).</param>
        /// <param name="fullSlug">The URL slug for the event page (required).</param>
        /// <param name="hidden">True if the event is hidden from the Smarkets website (required).</param>
        /// <param name="id">This ID uniquely identifies an event (required).</param>
        /// <param name="inplayEnabled">True if trading will be open when the markets go live in-play.</param>
        /// <param name="modified">The datetime of the last modification made by Smarkets to the event properties (required).</param>
        /// <param name="name">The name of the event (required).</param>
        /// <param name="parentId">This ID uniquely identifies the parent of the event (required).</param>
        /// <param name="seoDescription">Additional description for this event used for SEO.</param>
        /// <param name="shortName">A shorter version of the name of the event (required).</param>
        /// <param name="slug">An easier way to identify the event (required).</param>
        /// <param name="specialRules">Special rules to be defined for this market.</param>
        /// <param name="startDate">In what day the event will go live, This can be useful for events that still have an unknown start_datetime (required).</param>
        /// <param name="startDatetime">When the event is scheduled to go live (required).</param>
        /// <param name="state"> Event state can have the following values: &lt;ul&gt; &lt;li&gt;upcoming: the event is now open for betting &lt;li&gt;live: the event is now live in-play &lt;li&gt;ended: the event has ended and its markets should be settled &lt;li&gt;settled: the event has ended and its markets should be settled &lt;li&gt;cancelled: the event was cancelled and didn&#x27;t take place &lt;li&gt;suspended: the event was suspended and during play time &lt;/ul&gt;      (required).</param>
        /// <param name="type">The type of the event, for instance, the name of the sport&lt;br&gt; (required).</param>
        public Event(bool? betAllowed = default(bool?), bool? bettable = default(bool?), string chartTimePeriod = default(string), DateTime? created = default(DateTime?), string description = default(string), int? displayOrder = default(int?), DateTime? endDate = default(DateTime?), string fullSlug = default(string), bool? hidden = default(bool?), string id = default(string), bool? inplayEnabled = default(bool?), DateTime? modified = default(DateTime?), string name = default(string), string parentId = default(string), string seoDescription = default(string), string shortName = default(string), string slug = default(string), string specialRules = default(string), DateTime? startDate = default(DateTime?), DateTime? startDatetime = default(DateTime?), StateEnum state = default(StateEnum), OneOfEventType type = default(OneOfEventType))
        {
            // to ensure "created" is required (not null)
            if (created == null)
            {
                throw new InvalidDataException("created is a required property for ModelEvent and cannot be null");
            }
            else
            {
                this.Created = created;
            }
            // to ensure "description" is required (not null)
            if (description == null)
            {
                //throw new InvalidDataException("description is a required property for ModelEvent and cannot be null");
                this.Description = description;
            }
            else
            {
                this.Description = description;
            }
            // to ensure "endDate" is required (not null)
            if (endDate == null)
            {
                //throw new InvalidDataException("endDate is a required property for ModelEvent and cannot be null");
                this.EndDate = endDate;
            }
            else
            {
                this.EndDate = endDate;
            }
            // to ensure "fullSlug" is required (not null)
            if (fullSlug == null)
            {
                throw new InvalidDataException("fullSlug is a required property for ModelEvent and cannot be null");
            }
            else
            {
                this.FullSlug = fullSlug;
            }
            // to ensure "hidden" is required (not null)
            if (hidden == null)
            {
                throw new InvalidDataException("hidden is a required property for ModelEvent and cannot be null");
            }
            else
            {
                this.Hidden = hidden;
            }
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for ModelEvent and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "modified" is required (not null)
            if (modified == null)
            {
                throw new InvalidDataException("modified is a required property for ModelEvent and cannot be null");
            }
            else
            {
                this.Modified = modified;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for ModelEvent and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "parentId" is required (not null)
            if (parentId == null)
            {
                throw new InvalidDataException("parentId is a required property for ModelEvent and cannot be null");
            }
            else
            {
                this.ParentId = parentId;
            }
            // to ensure "shortName" is required (not null)
            if (shortName == null)
            {
                //throw new InvalidDataException("shortName is a required property for ModelEvent and cannot be null");
                this.ShortName = shortName;
            }
            else
            {
                this.ShortName = shortName;
            }
            // to ensure "slug" is required (not null)
            if (slug == null)
            {
                throw new InvalidDataException("slug is a required property for ModelEvent and cannot be null");
            }
            else
            {
                this.Slug = slug;
            }
            // to ensure "startDate" is required (not null)
            if (startDate == null)
            {
                throw new InvalidDataException("startDate is a required property for ModelEvent and cannot be null");
            }
            else
            {
                this.StartDate = startDate;
            }
            // to ensure "startDatetime" is required (not null)
            if (startDatetime == null)
            {
                throw new InvalidDataException("startDatetime is a required property for ModelEvent and cannot be null");
            }
            else
            {
                this.StartDatetime = startDatetime;
            }
            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new InvalidDataException("state is a required property for ModelEvent and cannot be null");
            }
            else
            {
                this.State = state;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for ModelEvent and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            this.BetAllowed = betAllowed;
            this.Bettable = bettable;
            this.ChartTimePeriod = chartTimePeriod;
            this.DisplayOrder = displayOrder;
            this.InplayEnabled = inplayEnabled;
            this.SeoDescription = seoDescription;
            this.SpecialRules = specialRules;
        }

        /// <summary>
        /// Determines whether bets are allowed in the given jurisdiction
        /// </summary>
        /// <value>Determines whether bets are allowed in the given jurisdiction</value>
        [DataMember(Name = "bet_allowed", EmitDefaultValue = false)]
        public bool? BetAllowed { get; set; }

        /// <summary>
        /// This needs to be True for events to be open for trading
        /// </summary>
        /// <value>This needs to be True for events to be open for trading</value>
        [DataMember(Name = "bettable", EmitDefaultValue = false)]
        public bool? Bettable { get; set; }

        /// <summary>
        /// A string to be used by frontend to show/default selectable chart time periods
        /// </summary>
        /// <value>A string to be used by frontend to show/default selectable chart time periods</value>
        [DataMember(Name = "chart_time_period", EmitDefaultValue = false)]
        public string ChartTimePeriod { get; set; }

        /// <summary>
        /// When was the event created in the Smarkets exchange
        /// </summary>
        /// <value>When was the event created in the Smarkets exchange</value>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Additional description for this event
        /// </summary>
        /// <value>Additional description for this event</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// On Smarkets listings pages, events will be sorted according to these numbers, in descending order
        /// </summary>
        /// <value>On Smarkets listings pages, events will be sorted according to these numbers, in descending order</value>
        [DataMember(Name = "display_order", EmitDefaultValue = false)]
        public int? DisplayOrder { get; set; }

        /// <summary>
        /// When the event is scheduled to end
        /// </summary>
        /// <value>When the event is scheduled to end</value>
        [DataMember(Name = "end_date", EmitDefaultValue = false)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// The URL slug for the event page
        /// </summary>
        /// <value>The URL slug for the event page</value>
        [DataMember(Name = "full_slug", EmitDefaultValue = false)]
        public string FullSlug { get; set; }

        /// <summary>
        /// True if the event is hidden from the Smarkets website
        /// </summary>
        /// <value>True if the event is hidden from the Smarkets website</value>
        [DataMember(Name = "hidden", EmitDefaultValue = false)]
        public bool? Hidden { get; set; }

        /// <summary>
        /// This ID uniquely identifies an event
        /// </summary>
        /// <value>This ID uniquely identifies an event</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// True if trading will be open when the markets go live in-play
        /// </summary>
        /// <value>True if trading will be open when the markets go live in-play</value>
        [DataMember(Name = "inplay_enabled", EmitDefaultValue = false)]
        public bool? InplayEnabled { get; set; }

        /// <summary>
        /// The datetime of the last modification made by Smarkets to the event properties
        /// </summary>
        /// <value>The datetime of the last modification made by Smarkets to the event properties</value>
        [DataMember(Name = "modified", EmitDefaultValue = false)]
        public DateTime? Modified { get; set; }

        /// <summary>
        /// The name of the event
        /// </summary>
        /// <value>The name of the event</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// This ID uniquely identifies the parent of the event
        /// </summary>
        /// <value>This ID uniquely identifies the parent of the event</value>
        [DataMember(Name = "parent_id", EmitDefaultValue = false)]
        public string ParentId { get; set; }

        /// <summary>
        /// Additional description for this event used for SEO
        /// </summary>
        /// <value>Additional description for this event used for SEO</value>
        [DataMember(Name = "seo_description", EmitDefaultValue = false)]
        public string SeoDescription { get; set; }

        /// <summary>
        /// A shorter version of the name of the event
        /// </summary>
        /// <value>A shorter version of the name of the event</value>
        [DataMember(Name = "short_name", EmitDefaultValue = false)]
        public string ShortName { get; set; }

        /// <summary>
        /// An easier way to identify the event
        /// </summary>
        /// <value>An easier way to identify the event</value>
        [DataMember(Name = "slug", EmitDefaultValue = false)]
        public string Slug { get; set; }

        /// <summary>
        /// Special rules to be defined for this market
        /// </summary>
        /// <value>Special rules to be defined for this market</value>
        [DataMember(Name = "special_rules", EmitDefaultValue = false)]
        public string SpecialRules { get; set; }

        /// <summary>
        /// In what day the event will go live, This can be useful for events that still have an unknown start_datetime
        /// </summary>
        /// <value>In what day the event will go live, This can be useful for events that still have an unknown start_datetime</value>
        [DataMember(Name = "start_date", EmitDefaultValue = false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// When the event is scheduled to go live
        /// </summary>
        /// <value>When the event is scheduled to go live</value>
        [DataMember(Name = "start_datetime", EmitDefaultValue = false)]
        public DateTime? StartDatetime { get; set; }


        /// <summary>
        /// The type of the event, for instance, the name of the sport&lt;br&gt;
        /// </summary>
        /// <value>The type of the event, for instance, the name of the sport&lt;br&gt;</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public OneOfEventType Type { get; set; }

        public List<Market> Markets { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelEvent {\n");
            sb.Append("  BetAllowed: ").Append(BetAllowed).Append("\n");
            sb.Append("  Bettable: ").Append(Bettable).Append("\n");
            sb.Append("  ChartTimePeriod: ").Append(ChartTimePeriod).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisplayOrder: ").Append(DisplayOrder).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  FullSlug: ").Append(FullSlug).Append("\n");
            sb.Append("  Hidden: ").Append(Hidden).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InplayEnabled: ").Append(InplayEnabled).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  SeoDescription: ").Append(SeoDescription).Append("\n");
            sb.Append("  ShortName: ").Append(ShortName).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  SpecialRules: ").Append(SpecialRules).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  StartDatetime: ").Append(StartDatetime).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
    }
}
