/* 
 * Smarkets HTTP API
 *
 * This is the HTTP trading API for Smarkets. It can be used to trade on our exchange.     <br><br>For authenticated requests:<br>     <ul>     <li>Get a session token using the login route:     <a class=\"nostyle\" href=\"#/sessions/create_session\"><span>GET /v3/sessions/</span></a></li>     <li>Click on 'Authorize 🔓', enter your token after 'Session-Token ' and click on the 'Authorize' button</li>     </ul>     <p>In order to place bets and get the latest prices without restrictions     using this API, you need to be a Smarkets API user.<br></p>     <p>To become one, please fill <a href=\"https://docs.google.com/forms/d/1qI8RqypNimakPx- bmoUE_lA0YSP3YogKfL8N14STNSM/viewform?edit_requested=true\">this form</a>.</p>     <p>For questions and feedback about the API, use <a href=\"https://community.smarkets.com/c/developers\">our forum</a>.</p>     <p>The API is not public, but we are granting users access on an ongoing basis.</p>     <p>You can find some sample code to help you bootstrap your integration <a href=\"https://github.com/ smarkets/smk_trading_bot\">here</a>.</p>     
 *
 * OpenAPI spec version: 3
 * Contact: api@smarkets.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IO.Swagger.Api;
using IO.Swagger.Model;
using IO.Swagger.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing InlineResponse20031
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class InlineResponse20031Tests
    {
        // TODO uncomment below to declare an instance variable for InlineResponse20031
        //private InlineResponse20031 instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of InlineResponse20031
            //instance = new InlineResponse20031();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of InlineResponse20031
        /// </summary>
        [Test]
        public void InlineResponse20031InstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" InlineResponse20031
            //Assert.IsInstanceOfType<InlineResponse20031> (instance, "variable 'instance' is a InlineResponse20031");
        }


        /// <summary>
        /// Test the property 'AvailableBalance'
        /// </summary>
        [Test]
        public void AvailableBalanceTest()
        {
            // TODO unit test for the property 'AvailableBalance'
        }
        /// <summary>
        /// Test the property 'AvailableQuantity'
        /// </summary>
        [Test]
        public void AvailableQuantityTest()
        {
            // TODO unit test for the property 'AvailableQuantity'
        }
        /// <summary>
        /// Test the property 'ContractId'
        /// </summary>
        [Test]
        public void ContractIdTest()
        {
            // TODO unit test for the property 'ContractId'
        }
        /// <summary>
        /// Test the property 'ExecutedAvgPrice'
        /// </summary>
        [Test]
        public void ExecutedAvgPriceTest()
        {
            // TODO unit test for the property 'ExecutedAvgPrice'
        }
        /// <summary>
        /// Test the property 'Exposure'
        /// </summary>
        [Test]
        public void ExposureTest()
        {
            // TODO unit test for the property 'Exposure'
        }
        /// <summary>
        /// Test the property 'MarketId'
        /// </summary>
        [Test]
        public void MarketIdTest()
        {
            // TODO unit test for the property 'MarketId'
        }
        /// <summary>
        /// Test the property 'OrderId'
        /// </summary>
        [Test]
        public void OrderIdTest()
        {
            // TODO unit test for the property 'OrderId'
        }
        /// <summary>
        /// Test the property 'OrigPrice'
        /// </summary>
        [Test]
        public void OrigPriceTest()
        {
            // TODO unit test for the property 'OrigPrice'
        }
        /// <summary>
        /// Test the property 'Price'
        /// </summary>
        [Test]
        public void PriceTest()
        {
            // TODO unit test for the property 'Price'
        }
        /// <summary>
        /// Test the property 'Quantity'
        /// </summary>
        [Test]
        public void QuantityTest()
        {
            // TODO unit test for the property 'Quantity'
        }
        /// <summary>
        /// Test the property 'Side'
        /// </summary>
        [Test]
        public void SideTest()
        {
            // TODO unit test for the property 'Side'
        }
        /// <summary>
        /// Test the property 'TotalExecutedQuantity'
        /// </summary>
        [Test]
        public void TotalExecutedQuantityTest()
        {
            // TODO unit test for the property 'TotalExecutedQuantity'
        }

    }

}