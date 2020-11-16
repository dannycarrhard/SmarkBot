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
    /// AccountActivityTransaction
    /// </summary>
    [DataContract]
        public partial class AccountActivityTransaction :  IEquatable<AccountActivityTransaction>, IValidatableObject
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
        public SideEnum? Side { get; set; }
        /// <summary>
        /// The source of the account activity row is the trigger that generated the transaction to occur
        /// </summary>
        /// <value>The source of the account activity row is the trigger that generated the transaction to occur</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum SourceEnum
        {
            /// <summary>
            /// Enum AdminCredit for value: admin.credit
            /// </summary>
            [EnumMember(Value = "admin.credit")]
            AdminCredit = 1,
            /// <summary>
            /// Enum AdminDebit for value: admin.debit
            /// </summary>
            [EnumMember(Value = "admin.debit")]
            AdminDebit = 2,
            /// <summary>
            /// Enum BonusCredit for value: bonus.credit
            /// </summary>
            [EnumMember(Value = "bonus.credit")]
            BonusCredit = 3,
            /// <summary>
            /// Enum BonusDebit for value: bonus.debit
            /// </summary>
            [EnumMember(Value = "bonus.debit")]
            BonusDebit = 4,
            /// <summary>
            /// Enum CommissionUpdate for value: commission.update
            /// </summary>
            [EnumMember(Value = "commission.update")]
            CommissionUpdate = 5,
            /// <summary>
            /// Enum ContractResettle for value: contract.resettle
            /// </summary>
            [EnumMember(Value = "contract.resettle")]
            ContractResettle = 6,
            /// <summary>
            /// Enum ContractSettle for value: contract.settle
            /// </summary>
            [EnumMember(Value = "contract.settle")]
            ContractSettle = 7,
            /// <summary>
            /// Enum ContractUnsettle for value: contract.unsettle
            /// </summary>
            [EnumMember(Value = "contract.unsettle")]
            ContractUnsettle = 8,
            /// <summary>
            /// Enum ContractVoid for value: contract.void
            /// </summary>
            [EnumMember(Value = "contract.void")]
            ContractVoid = 9,
            /// <summary>
            /// Enum Deposit for value: deposit
            /// </summary>
            [EnumMember(Value = "deposit")]
            Deposit = 10,
            /// <summary>
            /// Enum DepositApprove for value: deposit.approve
            /// </summary>
            [EnumMember(Value = "deposit.approve")]
            DepositApprove = 11,
            /// <summary>
            /// Enum DepositDeny for value: deposit.deny
            /// </summary>
            [EnumMember(Value = "deposit.deny")]
            DepositDeny = 12,
            /// <summary>
            /// Enum DepositRequest for value: deposit.request
            /// </summary>
            [EnumMember(Value = "deposit.request")]
            DepositRequest = 13,
            /// <summary>
            /// Enum ExecutionReduce for value: execution.reduce
            /// </summary>
            [EnumMember(Value = "execution.reduce")]
            ExecutionReduce = 14,
            /// <summary>
            /// Enum ExecutionSettle for value: execution.settle
            /// </summary>
            [EnumMember(Value = "execution.settle")]
            ExecutionSettle = 15,
            /// <summary>
            /// Enum ExecutionUnsettle for value: execution.unsettle
            /// </summary>
            [EnumMember(Value = "execution.unsettle")]
            ExecutionUnsettle = 16,
            /// <summary>
            /// Enum ExecutionVoid for value: execution.void
            /// </summary>
            [EnumMember(Value = "execution.void")]
            ExecutionVoid = 17,
            /// <summary>
            /// Enum MarketPartialunsettle for value: market.partial_unsettle
            /// </summary>
            [EnumMember(Value = "market.partial_unsettle")]
            MarketPartialunsettle = 18,
            /// <summary>
            /// Enum MarketResettle for value: market.resettle
            /// </summary>
            [EnumMember(Value = "market.resettle")]
            MarketResettle = 19,
            /// <summary>
            /// Enum MarketSettle for value: market.settle
            /// </summary>
            [EnumMember(Value = "market.settle")]
            MarketSettle = 20,
            /// <summary>
            /// Enum MarketUnsettle for value: market.unsettle
            /// </summary>
            [EnumMember(Value = "market.unsettle")]
            MarketUnsettle = 21,
            /// <summary>
            /// Enum MarketUnvoid for value: market.unvoid
            /// </summary>
            [EnumMember(Value = "market.unvoid")]
            MarketUnvoid = 22,
            /// <summary>
            /// Enum MarketVoid for value: market.void
            /// </summary>
            [EnumMember(Value = "market.void")]
            MarketVoid = 23,
            /// <summary>
            /// Enum OrderBookAccept for value: order.book.accept
            /// </summary>
            [EnumMember(Value = "order.book.accept")]
            OrderBookAccept = 24,
            /// <summary>
            /// Enum OrderBookCancel for value: order.book.cancel
            /// </summary>
            [EnumMember(Value = "order.book.cancel")]
            OrderBookCancel = 25,
            /// <summary>
            /// Enum OrderBookReduceqty for value: order.book.reduce_qty
            /// </summary>
            [EnumMember(Value = "order.book.reduce_qty")]
            OrderBookReduceqty = 26,
            /// <summary>
            /// Enum OrderBookReject for value: order.book.reject
            /// </summary>
            [EnumMember(Value = "order.book.reject")]
            OrderBookReject = 27,
            /// <summary>
            /// Enum OrderCancelReject for value: order.cancel.reject
            /// </summary>
            [EnumMember(Value = "order.cancel.reject")]
            OrderCancelReject = 28,
            /// <summary>
            /// Enum OrderCancelreplaceBookAccept for value: order.cancel_replace.book.accept
            /// </summary>
            [EnumMember(Value = "order.cancel_replace.book.accept")]
            OrderCancelreplaceBookAccept = 29,
            /// <summary>
            /// Enum OrderCancelreplaceBookReject for value: order.cancel_replace.book.reject
            /// </summary>
            [EnumMember(Value = "order.cancel_replace.book.reject")]
            OrderCancelreplaceBookReject = 30,
            /// <summary>
            /// Enum OrderCreate for value: order.create
            /// </summary>
            [EnumMember(Value = "order.create")]
            OrderCreate = 31,
            /// <summary>
            /// Enum OrderExecute for value: order.execute
            /// </summary>
            [EnumMember(Value = "order.execute")]
            OrderExecute = 32,
            /// <summary>
            /// Enum OrderExecuteConfirm for value: order.execute.confirm
            /// </summary>
            [EnumMember(Value = "order.execute.confirm")]
            OrderExecuteConfirm = 33,
            /// <summary>
            /// Enum OrderExecuteVoid for value: order.execute.void
            /// </summary>
            [EnumMember(Value = "order.execute.void")]
            OrderExecuteVoid = 34,
            /// <summary>
            /// Enum OrderPendingReplace for value: order.pending.replace
            /// </summary>
            [EnumMember(Value = "order.pending.replace")]
            OrderPendingReplace = 35,
            /// <summary>
            /// Enum OrderReduce for value: order.reduce
            /// </summary>
            [EnumMember(Value = "order.reduce")]
            OrderReduce = 36,
            /// <summary>
            /// Enum OrderRejectAccountsuspended for value: order.reject.account_suspended
            /// </summary>
            [EnumMember(Value = "order.reject.account_suspended")]
            OrderRejectAccountsuspended = 37,
            /// <summary>
            /// Enum OrderRejectInsufficientfunds for value: order.reject.insufficient_funds
            /// </summary>
            [EnumMember(Value = "order.reject.insufficient_funds")]
            OrderRejectInsufficientfunds = 38,
            /// <summary>
            /// Enum OrderRejectInvalidquantity for value: order.reject.invalid_quantity
            /// </summary>
            [EnumMember(Value = "order.reject.invalid_quantity")]
            OrderRejectInvalidquantity = 39,
            /// <summary>
            /// Enum OrderRejectLimitexceeded for value: order.reject.limit_exceeded
            /// </summary>
            [EnumMember(Value = "order.reject.limit_exceeded")]
            OrderRejectLimitexceeded = 40,
            /// <summary>
            /// Enum OrderRejectMarketnotfound for value: order.reject.market_not_found
            /// </summary>
            [EnumMember(Value = "order.reject.market_not_found")]
            OrderRejectMarketnotfound = 41,
            /// <summary>
            /// Enum OrderRejectStakelimitexceeded for value: order.reject.stake_limit_exceeded
            /// </summary>
            [EnumMember(Value = "order.reject.stake_limit_exceeded")]
            OrderRejectStakelimitexceeded = 42,
            /// <summary>
            /// Enum OrderSettle for value: order.settle
            /// </summary>
            [EnumMember(Value = "order.settle")]
            OrderSettle = 43,
            /// <summary>
            /// Enum OrderUnsettle for value: order.unsettle
            /// </summary>
            [EnumMember(Value = "order.unsettle")]
            OrderUnsettle = 44,
            /// <summary>
            /// Enum OrderUnvoid for value: order.unvoid
            /// </summary>
            [EnumMember(Value = "order.unvoid")]
            OrderUnvoid = 45,
            /// <summary>
            /// Enum OrderVoid for value: order.void
            /// </summary>
            [EnumMember(Value = "order.void")]
            OrderVoid = 46,
            /// <summary>
            /// Enum Withdraw for value: withdraw
            /// </summary>
            [EnumMember(Value = "withdraw")]
            Withdraw = 47,
            /// <summary>
            /// Enum WithdrawalApprove for value: withdrawal.approve
            /// </summary>
            [EnumMember(Value = "withdrawal.approve")]
            WithdrawalApprove = 48,
            /// <summary>
            /// Enum WithdrawalDeny for value: withdrawal.deny
            /// </summary>
            [EnumMember(Value = "withdrawal.deny")]
            WithdrawalDeny = 49,
            /// <summary>
            /// Enum WithdrawalRequest for value: withdrawal.request
            /// </summary>
            [EnumMember(Value = "withdrawal.request")]
            WithdrawalRequest = 50        }
        /// <summary>
        /// The source of the account activity row is the trigger that generated the transaction to occur
        /// </summary>
        /// <value>The source of the account activity row is the trigger that generated the transaction to occur</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public SourceEnum? Source { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountActivityTransaction" /> class.
        /// </summary>
        /// <param name="amount">Amount relative to the order.</param>
        /// <param name="bonusChange">A change in the bonus balance.</param>
        /// <param name="commission">How much commission was charged.</param>
        /// <param name="contractId">This ID uniquely identifies the contract.</param>
        /// <param name="eventId">This ID uniquely identifies an event.</param>
        /// <param name="exposure">Current exposure on the account.</param>
        /// <param name="extra">Additional information about this row.</param>
        /// <param name="label">Label is a user-defined string that will be stored in the order. It can be used to identify different trading strategies.</param>
        /// <param name="marketId">This ID uniquely identifies the market.</param>
        /// <param name="money">Balance of the account.</param>
        /// <param name="moneyChange">Change in the account&#x27;s balance.</param>
        /// <param name="orderId">This ID uniquely identifies an order.</param>
        /// <param name="price"> This price is in percentage basis points.&lt;br&gt; Example: 5000 &#x3D; 50% &lt;br&gt; To convert it to decimal odds, just divide 10000 by it&lt;br&gt; Example: 10000 / 5000 &#x3D; 2.0 (decimal odds).&lt;br&gt; This price has to conform to a valid tick on the exchange; an invalid price error will be returned if it does not..</param>
        /// <param name="quantity">     Quantity is the sum of the total pot (back+lay) in case the order is matched&lt;br&gt;     The units are 1/100 of a UK penny.&lt;br&gt;     Example: Quantity 1 &#x3D; 0.0001 GBP&lt;br&gt;     To convert it to back stake, just multiply by the price and divide by 100000000&lt;br&gt;     Example: 100000 (quantity) * 5000 (price) / 100000000 &#x3D; 5 GBP back stake.</param>
        /// <param name="quantityChange">Change in the quantity in GBP.</param>
        /// <param name="quantityUserCurrency">     Quantity is the sum of the total pot (back+lay) in case the order is matched&lt;br&gt;     The units are 1/10000 * one unit of the user&#x27;s currency.&lt;br&gt;     Example: Quantity 1 &#x3D; 0.0001 GBP&lt;br&gt;     To convert it to back stake, just multiply by the price and divide by 100000000&lt;br&gt;     Example: 100000 (quantity) * 5000 (price) / 100000000 &#x3D; 5 GBP back stake.</param>
        /// <param name="quantityUserCurrencyChange">Change in the quantity in user&#x27;s currency.</param>
        /// <param name="seq">Sequence number for the statement row.</param>
        /// <param name="side"> side can either be:&lt;ul&gt; &lt;li&gt;buy: backing a contract &lt;li&gt;sell: laying a contract &lt;/ul&gt;.</param>
        /// <param name="source">The source of the account activity row is the trigger that generated the transaction to occur.</param>
        /// <param name="subseq">Sub sequence number for the statement row.</param>
        /// <param name="timestamp">When this transaction took place.</param>
        public AccountActivityTransaction(string amount = default(string), string bonusChange = default(string), string commission = default(string), string contractId = default(string), string eventId = default(string), string exposure = default(string), string extra = default(string), string label = default(string), string marketId = default(string), string money = default(string), string moneyChange = default(string), string orderId = default(string), int? price = default(int?), int? quantity = default(int?), int? quantityChange = default(int?), int? quantityUserCurrency = default(int?), int? quantityUserCurrencyChange = default(int?), int? seq = default(int?), SideEnum? side = default(SideEnum?), SourceEnum? source = default(SourceEnum?), int? subseq = default(int?), DateTime? timestamp = default(DateTime?))
        {
            this.Amount = amount;
            this.BonusChange = bonusChange;
            this.Commission = commission;
            this.ContractId = contractId;
            this.EventId = eventId;
            this.Exposure = exposure;
            this.Extra = extra;
            this.Label = label;
            this.MarketId = marketId;
            this.Money = money;
            this.MoneyChange = moneyChange;
            this.OrderId = orderId;
            this.Price = price;
            this.Quantity = quantity;
            this.QuantityChange = quantityChange;
            this.QuantityUserCurrency = quantityUserCurrency;
            this.QuantityUserCurrencyChange = quantityUserCurrencyChange;
            this.Seq = seq;
            this.Side = side;
            this.Source = source;
            this.Subseq = subseq;
            this.Timestamp = timestamp;
        }
        
        /// <summary>
        /// Amount relative to the order
        /// </summary>
        /// <value>Amount relative to the order</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public string Amount { get; set; }

        /// <summary>
        /// A change in the bonus balance
        /// </summary>
        /// <value>A change in the bonus balance</value>
        [DataMember(Name="bonus_change", EmitDefaultValue=false)]
        public string BonusChange { get; set; }

        /// <summary>
        /// How much commission was charged
        /// </summary>
        /// <value>How much commission was charged</value>
        [DataMember(Name="commission", EmitDefaultValue=false)]
        public string Commission { get; set; }

        /// <summary>
        /// This ID uniquely identifies the contract
        /// </summary>
        /// <value>This ID uniquely identifies the contract</value>
        [DataMember(Name="contract_id", EmitDefaultValue=false)]
        public string ContractId { get; set; }

        /// <summary>
        /// This ID uniquely identifies an event
        /// </summary>
        /// <value>This ID uniquely identifies an event</value>
        [DataMember(Name="event_id", EmitDefaultValue=false)]
        public string EventId { get; set; }

        /// <summary>
        /// Current exposure on the account
        /// </summary>
        /// <value>Current exposure on the account</value>
        [DataMember(Name="exposure", EmitDefaultValue=false)]
        public string Exposure { get; set; }

        /// <summary>
        /// Additional information about this row
        /// </summary>
        /// <value>Additional information about this row</value>
        [DataMember(Name="extra", EmitDefaultValue=false)]
        public string Extra { get; set; }

        /// <summary>
        /// Label is a user-defined string that will be stored in the order. It can be used to identify different trading strategies
        /// </summary>
        /// <value>Label is a user-defined string that will be stored in the order. It can be used to identify different trading strategies</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// This ID uniquely identifies the market
        /// </summary>
        /// <value>This ID uniquely identifies the market</value>
        [DataMember(Name="market_id", EmitDefaultValue=false)]
        public string MarketId { get; set; }

        /// <summary>
        /// Balance of the account
        /// </summary>
        /// <value>Balance of the account</value>
        [DataMember(Name="money", EmitDefaultValue=false)]
        public string Money { get; set; }

        /// <summary>
        /// Change in the account&#x27;s balance
        /// </summary>
        /// <value>Change in the account&#x27;s balance</value>
        [DataMember(Name="money_change", EmitDefaultValue=false)]
        public string MoneyChange { get; set; }

        /// <summary>
        /// This ID uniquely identifies an order
        /// </summary>
        /// <value>This ID uniquely identifies an order</value>
        [DataMember(Name="order_id", EmitDefaultValue=false)]
        public string OrderId { get; set; }

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
        /// Change in the quantity in GBP
        /// </summary>
        /// <value>Change in the quantity in GBP</value>
        [DataMember(Name="quantity_change", EmitDefaultValue=false)]
        public int? QuantityChange { get; set; }

        /// <summary>
        ///      Quantity is the sum of the total pot (back+lay) in case the order is matched&lt;br&gt;     The units are 1/10000 * one unit of the user&#x27;s currency.&lt;br&gt;     Example: Quantity 1 &#x3D; 0.0001 GBP&lt;br&gt;     To convert it to back stake, just multiply by the price and divide by 100000000&lt;br&gt;     Example: 100000 (quantity) * 5000 (price) / 100000000 &#x3D; 5 GBP back stake
        /// </summary>
        /// <value>     Quantity is the sum of the total pot (back+lay) in case the order is matched&lt;br&gt;     The units are 1/10000 * one unit of the user&#x27;s currency.&lt;br&gt;     Example: Quantity 1 &#x3D; 0.0001 GBP&lt;br&gt;     To convert it to back stake, just multiply by the price and divide by 100000000&lt;br&gt;     Example: 100000 (quantity) * 5000 (price) / 100000000 &#x3D; 5 GBP back stake</value>
        [DataMember(Name="quantity_user_currency", EmitDefaultValue=false)]
        public int? QuantityUserCurrency { get; set; }

        /// <summary>
        /// Change in the quantity in user&#x27;s currency
        /// </summary>
        /// <value>Change in the quantity in user&#x27;s currency</value>
        [DataMember(Name="quantity_user_currency_change", EmitDefaultValue=false)]
        public int? QuantityUserCurrencyChange { get; set; }

        /// <summary>
        /// Sequence number for the statement row
        /// </summary>
        /// <value>Sequence number for the statement row</value>
        [DataMember(Name="seq", EmitDefaultValue=false)]
        public int? Seq { get; set; }



        /// <summary>
        /// Sub sequence number for the statement row
        /// </summary>
        /// <value>Sub sequence number for the statement row</value>
        [DataMember(Name="subseq", EmitDefaultValue=false)]
        public int? Subseq { get; set; }

        /// <summary>
        /// When this transaction took place
        /// </summary>
        /// <value>When this transaction took place</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountActivityTransaction {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BonusChange: ").Append(BonusChange).Append("\n");
            sb.Append("  Commission: ").Append(Commission).Append("\n");
            sb.Append("  ContractId: ").Append(ContractId).Append("\n");
            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  Exposure: ").Append(Exposure).Append("\n");
            sb.Append("  Extra: ").Append(Extra).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  MarketId: ").Append(MarketId).Append("\n");
            sb.Append("  Money: ").Append(Money).Append("\n");
            sb.Append("  MoneyChange: ").Append(MoneyChange).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  QuantityChange: ").Append(QuantityChange).Append("\n");
            sb.Append("  QuantityUserCurrency: ").Append(QuantityUserCurrency).Append("\n");
            sb.Append("  QuantityUserCurrencyChange: ").Append(QuantityUserCurrencyChange).Append("\n");
            sb.Append("  Seq: ").Append(Seq).Append("\n");
            sb.Append("  Side: ").Append(Side).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Subseq: ").Append(Subseq).Append("\n");
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
            return this.Equals(input as AccountActivityTransaction);
        }

        /// <summary>
        /// Returns true if AccountActivityTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountActivityTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountActivityTransaction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.BonusChange == input.BonusChange ||
                    (this.BonusChange != null &&
                    this.BonusChange.Equals(input.BonusChange))
                ) && 
                (
                    this.Commission == input.Commission ||
                    (this.Commission != null &&
                    this.Commission.Equals(input.Commission))
                ) && 
                (
                    this.ContractId == input.ContractId ||
                    (this.ContractId != null &&
                    this.ContractId.Equals(input.ContractId))
                ) && 
                (
                    this.EventId == input.EventId ||
                    (this.EventId != null &&
                    this.EventId.Equals(input.EventId))
                ) && 
                (
                    this.Exposure == input.Exposure ||
                    (this.Exposure != null &&
                    this.Exposure.Equals(input.Exposure))
                ) && 
                (
                    this.Extra == input.Extra ||
                    (this.Extra != null &&
                    this.Extra.Equals(input.Extra))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.MarketId == input.MarketId ||
                    (this.MarketId != null &&
                    this.MarketId.Equals(input.MarketId))
                ) && 
                (
                    this.Money == input.Money ||
                    (this.Money != null &&
                    this.Money.Equals(input.Money))
                ) && 
                (
                    this.MoneyChange == input.MoneyChange ||
                    (this.MoneyChange != null &&
                    this.MoneyChange.Equals(input.MoneyChange))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
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
                    this.QuantityChange == input.QuantityChange ||
                    (this.QuantityChange != null &&
                    this.QuantityChange.Equals(input.QuantityChange))
                ) && 
                (
                    this.QuantityUserCurrency == input.QuantityUserCurrency ||
                    (this.QuantityUserCurrency != null &&
                    this.QuantityUserCurrency.Equals(input.QuantityUserCurrency))
                ) && 
                (
                    this.QuantityUserCurrencyChange == input.QuantityUserCurrencyChange ||
                    (this.QuantityUserCurrencyChange != null &&
                    this.QuantityUserCurrencyChange.Equals(input.QuantityUserCurrencyChange))
                ) && 
                (
                    this.Seq == input.Seq ||
                    (this.Seq != null &&
                    this.Seq.Equals(input.Seq))
                ) && 
                (
                    this.Side == input.Side ||
                    (this.Side != null &&
                    this.Side.Equals(input.Side))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Subseq == input.Subseq ||
                    (this.Subseq != null &&
                    this.Subseq.Equals(input.Subseq))
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.BonusChange != null)
                    hashCode = hashCode * 59 + this.BonusChange.GetHashCode();
                if (this.Commission != null)
                    hashCode = hashCode * 59 + this.Commission.GetHashCode();
                if (this.ContractId != null)
                    hashCode = hashCode * 59 + this.ContractId.GetHashCode();
                if (this.EventId != null)
                    hashCode = hashCode * 59 + this.EventId.GetHashCode();
                if (this.Exposure != null)
                    hashCode = hashCode * 59 + this.Exposure.GetHashCode();
                if (this.Extra != null)
                    hashCode = hashCode * 59 + this.Extra.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.MarketId != null)
                    hashCode = hashCode * 59 + this.MarketId.GetHashCode();
                if (this.Money != null)
                    hashCode = hashCode * 59 + this.Money.GetHashCode();
                if (this.MoneyChange != null)
                    hashCode = hashCode * 59 + this.MoneyChange.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.QuantityChange != null)
                    hashCode = hashCode * 59 + this.QuantityChange.GetHashCode();
                if (this.QuantityUserCurrency != null)
                    hashCode = hashCode * 59 + this.QuantityUserCurrency.GetHashCode();
                if (this.QuantityUserCurrencyChange != null)
                    hashCode = hashCode * 59 + this.QuantityUserCurrencyChange.GetHashCode();
                if (this.Seq != null)
                    hashCode = hashCode * 59 + this.Seq.GetHashCode();
                if (this.Side != null)
                    hashCode = hashCode * 59 + this.Side.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Subseq != null)
                    hashCode = hashCode * 59 + this.Subseq.GetHashCode();
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
