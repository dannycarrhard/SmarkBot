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
    ///  Class for testing EachWayRequestSchema
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class EachWayRequestSchemaTests
    {
        // TODO uncomment below to declare an instance variable for EachWayRequestSchema
        //private EachWayRequestSchema instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of EachWayRequestSchema
            //instance = new EachWayRequestSchema();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EachWayRequestSchema
        /// </summary>
        [Test]
        public void EachWayRequestSchemaInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" EachWayRequestSchema
            //Assert.IsInstanceOfType<EachWayRequestSchema> (instance, "variable 'instance' is a EachWayRequestSchema");
        }


        /// <summary>
        /// Test the property 'PlaceContractId'
        /// </summary>
        [Test]
        public void PlaceContractIdTest()
        {
            // TODO unit test for the property 'PlaceContractId'
        }
        /// <summary>
        /// Test the property 'PlacePrice'
        /// </summary>
        [Test]
        public void PlacePriceTest()
        {
            // TODO unit test for the property 'PlacePrice'
        }
        /// <summary>
        /// Test the property 'ReferenceId'
        /// </summary>
        [Test]
        public void ReferenceIdTest()
        {
            // TODO unit test for the property 'ReferenceId'
        }
        /// <summary>
        /// Test the property 'Stake'
        /// </summary>
        [Test]
        public void StakeTest()
        {
            // TODO unit test for the property 'Stake'
        }
        /// <summary>
        /// Test the property 'WinContractId'
        /// </summary>
        [Test]
        public void WinContractIdTest()
        {
            // TODO unit test for the property 'WinContractId'
        }
        /// <summary>
        /// Test the property 'WinPrice'
        /// </summary>
        [Test]
        public void WinPriceTest()
        {
            // TODO unit test for the property 'WinPrice'
        }

    }

}