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
    ///  Class for testing UsersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class UsersApiTests
    {
        private UsersApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UsersApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UsersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' UsersApi
            //Assert.IsInstanceOfType(typeof(UsersApi), instance, "instance is a UsersApi");
        }

        /// <summary>
        /// Test AccountActivity
        /// </summary>
        [Test]
        public void AccountActivityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? startDatetime = null;
            //DateTime? endDatetime = null;
            //var response = instance.AccountActivity(startDatetime, endDatetime);
            //Assert.IsInstanceOf<InlineResponse20017> (response, "response is InlineResponse20017");
        }
        /// <summary>
        /// Test BalanceExposure
        /// </summary>
        [Test]
        public void BalanceExposureTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.BalanceExposure();
            //Assert.IsInstanceOf<InlineResponse20018> (response, "response is InlineResponse20018");
        }
        /// <summary>
        /// Test Current
        /// </summary>
        [Test]
        public void CurrentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.Current();
            //Assert.IsInstanceOf<InlineResponse20016> (response, "response is InlineResponse20016");
        }
        /// <summary>
        /// Test Finance
        /// </summary>
        [Test]
        public void FinanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.Finance();
            //Assert.IsInstanceOf<InlineResponse20020> (response, "response is InlineResponse20020");
        }
        /// <summary>
        /// Test GetPaymentTermsAccepted
        /// </summary>
        [Test]
        public void GetPaymentTermsAcceptedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetPaymentTermsAccepted();
            //Assert.IsInstanceOf<InlineResponse20012> (response, "response is InlineResponse20012");
        }
        /// <summary>
        /// Test GetUser
        /// </summary>
        [Test]
        public void GetUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetUser();
            //Assert.IsInstanceOf<UserDetails> (response, "response is UserDetails");
        }
        /// <summary>
        /// Test PasswordResetV0
        /// </summary>
        [Test]
        public void PasswordResetV0Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string token = null;
            //Body11 body = null;
            //var response = instance.PasswordResetV0(token, body);
            //Assert.IsInstanceOf<InlineResponse20025> (response, "response is InlineResponse20025");
        }
        /// <summary>
        /// Test PasswordTokenValidationV0
        /// </summary>
        [Test]
        public void PasswordTokenValidationV0Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Body12 body = null;
            //var response = instance.PasswordTokenValidationV0(body);
            //Assert.IsInstanceOf<InlineResponse20026> (response, "response is InlineResponse20026");
        }
        /// <summary>
        /// Test Pnl
        /// </summary>
        [Test]
        public void PnlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.Pnl();
            //Assert.IsInstanceOf<InlineResponse20028> (response, "response is InlineResponse20028");
        }
        /// <summary>
        /// Test PostPaymentTermsAccepted
        /// </summary>
        [Test]
        public void PostPaymentTermsAcceptedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Body1 body = null;
            //var response = instance.PostPaymentTermsAccepted(body);
            //Assert.IsInstanceOf<Body1> (response, "response is Body1");
        }
        /// <summary>
        /// Test PotentialWinnings
        /// </summary>
        [Test]
        public void PotentialWinningsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.PotentialWinnings();
            //Assert.IsInstanceOf<InlineResponse20029> (response, "response is InlineResponse20029");
        }
        /// <summary>
        /// Test SaveAffiliateInformation
        /// </summary>
        [Test]
        public void SaveAffiliateInformationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //AffiliateSignup body = null;
            //var response = instance.SaveAffiliateInformation(userId, body);
            //Assert.IsInstanceOf<AffiliateSignup> (response, "response is AffiliateSignup");
        }
        /// <summary>
        /// Test SendPasswordResetEmailV0
        /// </summary>
        [Test]
        public void SendPasswordResetEmailV0Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Body10 body = null;
            //var response = instance.SendPasswordResetEmailV0(body);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test Signup
        /// </summary>
        [Test]
        public void SignupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UsersSignup body = null;
            //var response = instance.Signup(body);
            //Assert.IsInstanceOf<UserDetails> (response, "response is UserDetails");
        }
        /// <summary>
        /// Test UserWithoutRate
        /// </summary>
        [Test]
        public void UserWithoutRateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.UserWithoutRate();
            //Assert.IsInstanceOf<InlineResponse20021> (response, "response is InlineResponse20021");
        }
    }

}
