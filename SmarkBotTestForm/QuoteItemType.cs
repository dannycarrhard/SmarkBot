using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CArbTestForm
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum QuoteItemType
    {
        Price = 1,

        Quantity = 2

    }
}
