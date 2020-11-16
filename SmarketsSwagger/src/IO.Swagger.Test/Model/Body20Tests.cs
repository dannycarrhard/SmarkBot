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
    ///  Class for testing Body20
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class Body20Tests
    {
        // TODO uncomment below to declare an instance variable for Body20
        //private Body20 instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Body20
            //instance = new Body20();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Body20
        /// </summary>
        [Test]
        public void Body20InstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Body20
            //Assert.IsInstanceOfType<Body20> (instance, "variable 'instance' is a Body20");
        }


        /// <summary>
        /// Test the property 'BillingAddress'
        /// </summary>
        [Test]
        public void BillingAddressTest()
        {
            // TODO unit test for the property 'BillingAddress'
        }
        /// <summary>
        /// Test the property 'Bin'
        /// </summary>
        [Test]
        public void BinTest()
        {
            // TODO unit test for the property 'Bin'
        }
        /// <summary>
        /// Test the property 'CardholderName'
        /// </summary>
        [Test]
        public void CardholderNameTest()
        {
            // TODO unit test for the property 'CardholderName'
        }
        /// <summary>
        /// Test the property 'ExpiryMonth'
        /// </summary>
        [Test]
        public void ExpiryMonthTest()
        {
            // TODO unit test for the property 'ExpiryMonth'
        }
        /// <summary>
        /// Test the property 'ExpiryYear'
        /// </summary>
        [Test]
        public void ExpiryYearTest()
        {
            // TODO unit test for the property 'ExpiryYear'
        }
        /// <summary>
        /// Test the property 'Issuer'
        /// </summary>
        [Test]
        public void IssuerTest()
        {
            // TODO unit test for the property 'Issuer'
        }
        /// <summary>
        /// Test the property 'LastFour'
        /// </summary>
        [Test]
        public void LastFourTest()
        {
            // TODO unit test for the property 'LastFour'
        }
        /// <summary>
        /// Test the property 'ThreeDSecure'
        /// </summary>
        [Test]
        public void ThreeDSecureTest()
        {
            // TODO unit test for the property 'ThreeDSecure'
        }
        /// <summary>
        /// Test the property 'Token'
        /// </summary>
        [Test]
        public void TokenTest()
        {
            // TODO unit test for the property 'Token'
        }

    }

}