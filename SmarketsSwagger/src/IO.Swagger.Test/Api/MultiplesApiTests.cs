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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing MultiplesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class MultiplesApiTests
    {
        private MultiplesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MultiplesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MultiplesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' MultiplesApi
            //Assert.IsInstanceOfType(typeof(MultiplesApi), instance, "instance is a MultiplesApi");
        }

        /// <summary>
        /// Test GetEachWayOrderStatus
        /// </summary>
        [Test]
        public void GetEachWayOrderStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? winContractId = null;
            //int? placeContractId = null;
            //string uId = null;
            //var response = instance.GetEachWayOrderStatus(winContractId, placeContractId, uId);
            //Assert.IsInstanceOf<EachWayStatusSchema> (response, "response is EachWayStatusSchema");
        }
        /// <summary>
        /// Test GetEachWaySinglePrice
        /// </summary>
        [Test]
        public void GetEachWaySinglePriceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? winContractId = null;
            //int? placeContractId = null;
            //decimal? stake = null;
            //var response = instance.GetEachWaySinglePrice(winContractId, placeContractId, stake);
            //Assert.IsInstanceOf<EachWaySinglePrice> (response, "response is EachWaySinglePrice");
        }
        /// <summary>
        /// Test GetMultiTickSingleCashoutPrice
        /// </summary>
        [Test]
        public void GetMultiTickSingleCashoutPriceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? contractId = null;
            //var response = instance.GetMultiTickSingleCashoutPrice(contractId);
            //Assert.IsInstanceOf<MultiTickPrice> (response, "response is MultiTickPrice");
        }
        /// <summary>
        /// Test GetMultiTickSinglePrice
        /// </summary>
        [Test]
        public void GetMultiTickSinglePriceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? contractId = null;
            //decimal? stake = null;
            //var response = instance.GetMultiTickSinglePrice(contractId, stake);
            //Assert.IsInstanceOf<MultiTickPrice1> (response, "response is MultiTickPrice1");
        }
        /// <summary>
        /// Test GetMultipleOrderStatus
        /// </summary>
        [Test]
        public void GetMultipleOrderStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int?> contractIds = null;
            //string uId = null;
            //var response = instance.GetMultipleOrderStatus(contractIds, uId);
            //Assert.IsInstanceOf<MultiplesStatusSchema> (response, "response is MultiplesStatusSchema");
        }
        /// <summary>
        /// Test GetMultiplesCashoutPrice
        /// </summary>
        [Test]
        public void GetMultiplesCashoutPriceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int?> contractIds = null;
            //string side = null;
            //var response = instance.GetMultiplesCashoutPrice(contractIds, side);
            //Assert.IsInstanceOf<Pricing> (response, "response is Pricing");
        }
        /// <summary>
        /// Test GetMultiplesPricing
        /// </summary>
        [Test]
        public void GetMultiplesPricingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int?> contractIds = null;
            //string side = null;
            //var response = instance.GetMultiplesPricing(contractIds, side);
            //Assert.IsInstanceOf<Pricing> (response, "response is Pricing");
        }
        /// <summary>
        /// Test GetRandomMultiple
        /// </summary>
        [Test]
        public void GetRandomMultipleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? numLegs = null;
            //List<string> contractId = null;
            //var response = instance.GetRandomMultiple(numLegs, contractId);
            //Assert.IsInstanceOf<Random> (response, "response is Random");
        }
        /// <summary>
        /// Test GetSingleOrderStatus
        /// </summary>
        [Test]
        public void GetSingleOrderStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int?> contractIds = null;
            //string uIds = null;
            //var response = instance.GetSingleOrderStatus(contractIds, uIds);
            //Assert.IsInstanceOf<MultiTickStatusSchema> (response, "response is MultiTickStatusSchema");
        }
        /// <summary>
        /// Test PlaceEachWaySingle
        /// </summary>
        [Test]
        public void PlaceEachWaySingleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EachWayRequestSchema body = null;
            //var response = instance.PlaceEachWaySingle(body);
            //Assert.IsInstanceOf<EachWayPlace> (response, "response is EachWayPlace");
        }
        /// <summary>
        /// Test PlaceMultiTickSingle
        /// </summary>
        [Test]
        public void PlaceMultiTickSingleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MultiTickRequestSchema body = null;
            //var response = instance.PlaceMultiTickSingle(body);
            //Assert.IsInstanceOf<MultiTickPlace> (response, "response is MultiTickPlace");
        }
        /// <summary>
        /// Test PlaceMultiTickSingleCashout
        /// </summary>
        [Test]
        public void PlaceMultiTickSingleCashoutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MultiTickRequestSchema1 body = null;
            //var response = instance.PlaceMultiTickSingleCashout(body);
            //Assert.IsInstanceOf<MultiTickPlace> (response, "response is MultiTickPlace");
        }
        /// <summary>
        /// Test PlaceMultipleCashoutOrder
        /// </summary>
        [Test]
        public void PlaceMultipleCashoutOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MultiplesCashoutRequestSchema body = null;
            //var response = instance.PlaceMultipleCashoutOrder(body);
            //Assert.IsInstanceOf<MultiplesResponseSchema> (response, "response is MultiplesResponseSchema");
        }
        /// <summary>
        /// Test PlaceMultipleOrder
        /// </summary>
        [Test]
        public void PlaceMultipleOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MultiplesRequestSchema body = null;
            //var response = instance.PlaceMultipleOrder(body);
            //Assert.IsInstanceOf<MultiplesResponseSchema> (response, "response is MultiplesResponseSchema");
        }
    }

}
