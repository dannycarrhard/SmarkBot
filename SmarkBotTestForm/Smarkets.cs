using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CArbTestForm
{
    public static class client
    {

        public static object log;

        public class OrderPlaceError
            : Exception
        {
        }

        public class SmarketsClient
        {

            public object auth_token;

            public SmarketsClient()
            {
                this.auth_token = null;
            }

            public virtual Dictionary<string, string> _auth_headers()
            {
                return new Dictionary<string, string> {
                {
                    "Authorization",
                    "Session-Token " + this.auth_token}};
            }

            public virtual object init_session()
            {
                //log.info("initiating session");
                this.auth_token = configuration["auth"].get("auth_token");
                if (!this.auth_token)
                {
                    var response = requests.post($"{configuration[\"api\"][\"base_url\"]}sessions/", json: new Dictionary<string, string> {
                        {
                        "username",
                        configuration["auth"]["login"]},
                    {
                        "password",
                        configuration["auth"]["password"]}
                }).json();
                this.auth_token = response.get("token");
            }
            //log.info("auth token: %s", this.auth_token);
        }

        public static string place_order(
            object market_id,
            object contract_id,
            object price,
            object quantity,
            object side)
        {
            //log.info("placing order: m_id %s: c_id %s\t %s %s @ %s", market_id, contract_id, side, quantity, price);
            var response = requests.post($"{configuration[\"api\"][\"base_url\"]}orders/", json: new Dictionary<string, string> {
                {
                "market_id",
                    market_id},
                {
                "contract_id",
                    contract_id},
                {
                "price",
                    price},
                {
                "quantity",
                    quantity},
                {
                "reference_id",
                    Convert.ToInt32(datetime.datetime.utcnow().timestamp()).ToString()},
                {
                "side",
                    side}
        }, headers: this._auth_headers());
            var response_body = response.json();
            if (response.status_code != 200) {
                throw new OrderPlaceError(response_body.get("error_type"));
            }
    //log.info("order placed: m_id {market_id}: c_id {contract_id} \t {side} {quantity} @ {price}|balance:{response_body[\"available_balance\"]} executed:{response_body[\"total_executed_quantity\"]} exposure:{response_body[\"exposure\"]}");
        }

public virtual object cancel_order(object order_id)
{
    requests.delete($"{configuration[\"api\"][\"base_url\"]}orders/{order_id}/", headers: this._auth_headers());
        }

public virtual object cancel_all_orders(object market_id)
{
    requests.delete($"{configuration[\"api\"][\"base_url\"]}orders/?market_id={market_id}", headers: this._auth_headers());
        }

public virtual object get_orders(object states)
{
    var orders = new List<object>();
    var states_to_fetch = "&".join((from state in states
                                    select $"states={state}").ToList());
    var next_page = $"?limit={configuration[\"api\"][\"chunk_size\"]}&{states_to_fetch}";
            while (next_page)
    {
        var response = requests.get($"{configuration[\"api\"][\"base_url\"]}orders/{next_page}", headers: this._auth_headers()).json();

        //log.info(response);
        orders += response["orders"];
        next_page = response["pagination"]["next_page"];
    }
    return orders;
}

public virtual object get_available_events(object states, object types, object start_datetime_max, object limit)
{
    var states_filter = "&".join((from state in states
                                  select $"states={state}").ToList());
    var types_filter = "&".join((from type_ in types
                                 select $"types={type_}").ToList());
    var page_filter = "?{states_filter}&{types_filter}&sort=id&limit={limit}&start_datetime_max={start_datetime_max}";
    var events = new List<object>();
    while (page_filter)
    {
        var request_url = $"{configuration[\"api\"][\"base_url\"]}events/{page_filter}";
                var current_page = this._client_wrapper(request_url);
        events += current_page["events"];
        page_filter = current_page["pagination"]["next_page"];
    }
    return events;
}

public virtual object get_events(object event_ids)
{
    var event_ids_filter = "&".join((from event_id in event_ids
                                     select $"ids={event_id}").ToList());
    var request_url = $"{configuration[\"api\"][\"base_url\"]}events/?{event_ids_filter}";
            return this._client_wrapper(request_url).get("events");
}

public virtual object get_markets(object market_ids, object with_volumes = false)
{
    var markets = ",".join(market_ids);
    var request_url = $"{configuration[\"api\"][\"base_url\"]}markets/{markets}/?with_volumes={with_volumes}";
            return this._client_wrapper(request_url).get("markets");
}

public virtual object get_related_markets(object events)
{
    var markets = new List<object>();
    var event_ids = (from @event in events
                     select @event["id"]).ToList();
    var i = 0;
    var chunk_size = configuration["api"]["chunk_size"];
    while (i * chunk_size < event_ids.Count)
    {
        var events_to_fetch = ",".join(event_ids[(i * chunk_size)::((i + 1) * chunk_size)]);
        var request_url = "{configuration[\"api\"][\"base_url\"]}events/{events_to_fetch}/markets/?sort=event_id,display_order&with_volumes=true";
        markets += this._client_wrapper(request_url)["markets"];
        i += 1;
    }
    return markets;
}

public virtual object get_related_contracts(object markets)
{
    var contracts = new List<object>();
    var market_ids = (from market in markets
                      select market["id"]).ToList();
    var i = 0;
    var chunk_size = configuration["api"]["chunk_size"];
    while (i * chunk_size < market_ids.Count)
    {
        var markets_to_fetch = ",".join(market_ids[(i * chunk_size)::((i + 1) * chunk_size)]);
        var request_url = @"{configuration[""api""][""base_url""]}markets/{markets_to_fetch}/contracts/";
        contracts += this._client_wrapper(request_url)["contracts"];
        i += 1;
    }
    return contracts;
}

public virtual object get_quotes(object market_ids)
{
    var quotes = new List<object>();
    var i = 0;
    var chunk_size = configuration["api"]["chunk_size"];
    while (i * chunk_size < market_ids.Count)
    {
        var markets_to_fetch = ",".join(market_ids[(i * chunk_size)::((i + 1) * chunk_size)]);
        var request_url = $"{configuration[\"api\"][\"base_url\"]}markets/{markets_to_fetch}/quotes/";
                quotes += new List<object> {
                    this._client_wrapper(request_url)
                };
        i += 1;
    }
    var quotes_result = new Dictionary<string, string>
    {
    };
    foreach (var quote_entry in quotes)
    {
        foreach (var _tup_1 in quote_entry.items())
        {
            var contract_id = _tup_1.Item1;
            var order_book = _tup_1.Item2;
            quotes_result[contract_id] = order_book;
        }
    }
    return quotes_result;
}

public virtual object get_accounts()
{
    var response = requests.get($"{configuration[\"api\"][\"base_url\"]}accounts/", headers: this._auth_headers()).json();
            return response;
}

public virtual object _client_wrapper(object url)
{
    //log.info($"calling url: {url}");
    return requests.get(url).json();
}
    }
}

}
