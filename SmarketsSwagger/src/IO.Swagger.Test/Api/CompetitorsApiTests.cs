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
    ///  Class for testing CompetitorsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CompetitorsApiTests
    {
        private CompetitorsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CompetitorsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CompetitorsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CompetitorsApi
            //Assert.IsInstanceOfType(typeof(CompetitorsApi), instance, "instance is a CompetitorsApi");
        }

        /// <summary>
        /// Test GetCompetitors
        /// </summary>
        [Test]
        public void GetCompetitorsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int?> eventIds = null;
            //var response = instance.GetCompetitors(eventIds);
            //Assert.IsInstanceOf<Competitors> (response, "response is Competitors");
        }
    }

}
