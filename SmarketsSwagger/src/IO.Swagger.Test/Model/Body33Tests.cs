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
    ///  Class for testing Body33
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class Body33Tests
    {
        // TODO uncomment below to declare an instance variable for Body33
        //private Body33 instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Body33
            //instance = new Body33();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Body33
        /// </summary>
        [Test]
        public void Body33InstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Body33
            //Assert.IsInstanceOfType<Body33> (instance, "variable 'instance' is a Body33");
        }


        /// <summary>
        /// Test the property 'Amount'
        /// </summary>
        [Test]
        public void AmountTest()
        {
            // TODO unit test for the property 'Amount'
        }
        /// <summary>
        /// Test the property 'FailUrl'
        /// </summary>
        [Test]
        public void FailUrlTest()
        {
            // TODO unit test for the property 'FailUrl'
        }
        /// <summary>
        /// Test the property 'MethodId'
        /// </summary>
        [Test]
        public void MethodIdTest()
        {
            // TODO unit test for the property 'MethodId'
        }
        /// <summary>
        /// Test the property 'SecureId'
        /// </summary>
        [Test]
        public void SecureIdTest()
        {
            // TODO unit test for the property 'SecureId'
        }
        /// <summary>
        /// Test the property 'SuccessUrl'
        /// </summary>
        [Test]
        public void SuccessUrlTest()
        {
            // TODO unit test for the property 'SuccessUrl'
        }

    }

}
