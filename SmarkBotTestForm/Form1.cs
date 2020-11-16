using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IO.Swagger;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
using CustomModel = IO.Swagger.CustomModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using AutoMapper;
using System.Net.Mail;

namespace SmarkBotTestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                throw new Exception();
            }
            catch (Exception ex)
            {
                MailMessage mail = new MailMessage();
                mail.To.Add("smarkbot@outlook.com");
                mail.From = new MailAddress("danny_carr@hotmail.co.uk");
                mail.Subject = "Error";
                string Body = "Error";
                mail.Body = Body;
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient("smtp-mail.outlook.com", 587);
                // smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
                smtp.UseDefaultCredentials = false;
                smtp.EnableSsl = true;
                smtp.Credentials = new System.Net.NetworkCredential("danny_carr@hotmail.co.uk", "#3vert0n5");
                // smtp.Port = 587;
                //Or your Smtp Email ID and Password
                //smtp.Send(mail);

                //ex.LogToElmah();
            }

            var sessionsApi = new SessionsApi();
            var sessionCreate = new SessionCreate("#3Vert0n", true, "theuberdeeg@gmail.com");
            var token = sessionsApi.CreateSession(sessionCreate);

            //var header

            var configuration = new Configuration();
            //configuration.Username = "theuberdeeg@gmail.com";
            //configuration.Password = "#3Vert0n";
            configuration.AccessToken = token.Token;
            //configuration.AccessToken = "WzMwMzM2NDEwLDExMzE4NjM5OF0.xKV2DHnWMDxNTsicJfNaqiLthbo";

            var eventsApi= new EventsApi(configuration);

            var minDateTime = new DateTime(2020, 11, 11, 12, 0, 0);
            var maxDateTime = new DateTime(2020, 11, 11, 21, 0, 0);

            var eventTypes = new List<string>();
            eventTypes.Add("horse_racing_race");

            var eventTypeDomains = new List<string>();
            eventTypeDomains.Add("horse_racing");

            var eventTypeScopes = new List<string>();
            eventTypeScopes.Add("single_event");

            var events = eventsApi.GetEvents(null, null, null, eventTypes, eventTypeDomains, eventTypeScopes, true, null, minDateTime, maxDateTime,null, null, null, null,null,null, "start_datetime,name", 100, false, null);

            ModelEvent event1 = events._Events.FirstOrDefault();

            var eventConfig = new MapperConfiguration(cfg => cfg.CreateMap<ModelEvent, CustomModel.Event>().ForMember(Event => Event.Markets, opt => opt.Ignore()));
            var eventMapper = eventConfig.CreateMapper();
            var eventList = eventMapper.Map<List<ModelEvent>, List<CustomModel.Event>>(events._Events);

            //var eventIds = new List<int?>();
            var eventIds = (from item in eventList select item.Id).ToList()
                .Select(s => Int32.TryParse(s, out int n) ? n : (int?)null).ToList();

            var marketsApi = new MarketsApi(configuration);
            var apiMarketsList = marketsApi.GetMarketsByEventIds(eventIds, "display_order", 100, false, false);

            var marketMapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<Market, CustomModel.Market>().ForMember(Market => Market.Contracts, opt => opt.Ignore()));
            var marketMapper = marketMapperConfig.CreateMapper();
            var marketList = marketMapper.Map<List<Market>, List<CustomModel.Market>>(apiMarketsList.Markets);

            //var marketIds = new List<int?>();
            //marketIds.Add(11369867);

            var marketIds = (from item in marketList select item.Id).ToList()
                .Select(s => Int32.TryParse(s, out int n) ? n : (int?)null).ToList();

            var contractsApi = new ContractsApi(configuration);
            var apiContracts = contractsApi.GetContractsByMarketIds(marketIds);

            var contractMapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<Contract, CustomModel.Contract>().ForMember(Contract => Contract.Quote, opt => opt.Ignore()));
            var contractMapper = contractMapperConfig.CreateMapper();
            var contractList = contractMapper.Map<List<Contract>, List< CustomModel.Contract>> (apiContracts.Contracts);

            var pricesApi = new PricesApi(configuration);
            var apiPricesList = pricesApi.GetQuotes(marketIds);

            foreach(var apiPrice in apiPricesList)
            {
                var s = apiPrice.Value.ToString();
                var q = JObject.Parse(apiPrice.Value.ToString());

                var bidList = q["bids"].ToList();
                var bids = new List<CustomModel.BidOffer>();

                foreach(var item in bidList)
                {
                    var bid = new CustomModel.BidOffer();
                    bid.BidOfferTypeDescription = "Bid";
                    bid.Price = (int?)item["price"];
                    bid.Quantity = (int?)item["quantity"];

                    bids.Add(bid);
                }

                var offerList = q["offers"].ToList();
                var offers = new List<CustomModel.BidOffer>();

                foreach (var item in offerList)
                {
                    var offer = new CustomModel.BidOffer();
                    offer.BidOfferTypeDescription = "Offer";
                    offer.Price = (int?)item["price"];
                    offer.Quantity = (int?)item["quantity"];

                    bids.Add(offer);
                }

                var contractId = apiPrice.Key;
                CustomModel.Quote quote = new CustomModel.Quote(contractId, bids, offers);

                var contract = contractList.Where(c => c.Id == contractId).First();
                contract.Quote = quote;

            }

            foreach(var itemMarket in marketList)
            {
                var contracts = contractList.Where(c => c.MarketId == itemMarket.Id).ToList();
                itemMarket.Contracts = contracts;
            }

            foreach (var itemEvent in eventList)
            {
                var markets = marketList.Where(c => c.EventId == itemEvent.Id).ToList();
                itemEvent.Markets = markets;
            }

        }
    }
}
