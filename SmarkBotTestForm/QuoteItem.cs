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

namespace CArbTestForm 
{
    [JsonConverter(typeof(StringEnumConverter))]
    [DataContract]
    public class Bid : IEquatable<Bid>, IValidatableObject
    {
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public int Price { get; set; }

        [DataMember(Name = "type", EmitDefaultValue = false)]
        public int Quantity { get; set; }
    }
}
