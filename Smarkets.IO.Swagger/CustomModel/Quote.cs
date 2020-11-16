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
    public class Quote
    {
        public string ContractId { get; set; }
        
        public List<BidOffer> Bids { get; set; }

        public List<BidOffer> Offers { get; set; }

        public Quote(string contractId = null, List<BidOffer> bids = null, List<BidOffer> offers = null)
        {
            this.ContractId = contractId;
            this.Bids = bids;
            this.Offers = offers;
        }
    }
}
