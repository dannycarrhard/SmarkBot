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
    ///  Class for testing ExecutionsTimeSeriesResponseAfter
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ExecutionsTimeSeriesResponseAfterTests
    {
        // TODO uncomment below to declare an instance variable for ExecutionsTimeSeriesResponseAfter
        //private ExecutionsTimeSeriesResponseAfter instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ExecutionsTimeSeriesResponseAfter
            //instance = new ExecutionsTimeSeriesResponseAfter();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ExecutionsTimeSeriesResponseAfter
        /// </summary>
        [Test]
        public void ExecutionsTimeSeriesResponseAfterInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ExecutionsTimeSeriesResponseAfter
            //Assert.IsInstanceOfType<ExecutionsTimeSeriesResponseAfter> (instance, "variable 'instance' is a ExecutionsTimeSeriesResponseAfter");
        }


        /// <summary>
        /// Test the property 'NumTrades'
        /// </summary>
        [Test]
        public void NumTradesTest()
        {
            // TODO unit test for the property 'NumTrades'
        }
        /// <summary>
        /// Test the property 'Ohlc'
        /// </summary>
        [Test]
        public void OhlcTest()
        {
            // TODO unit test for the property 'Ohlc'
        }
        /// <summary>
        /// Test the property 'Timestamp'
        /// </summary>
        [Test]
        public void TimestampTest()
        {
            // TODO unit test for the property 'Timestamp'
        }
        /// <summary>
        /// Test the property 'VolumeBks'
        /// </summary>
        [Test]
        public void VolumeBksTest()
        {
            // TODO unit test for the property 'VolumeBks'
        }
        /// <summary>
        /// Test the property 'VolumeQty'
        /// </summary>
        [Test]
        public void VolumeQtyTest()
        {
            // TODO unit test for the property 'VolumeQty'
        }

    }

}