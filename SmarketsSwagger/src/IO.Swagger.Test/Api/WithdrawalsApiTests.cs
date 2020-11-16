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
    ///  Class for testing WithdrawalsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class WithdrawalsApiTests
    {
        private WithdrawalsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new WithdrawalsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of WithdrawalsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' WithdrawalsApi
            //Assert.IsInstanceOfType(typeof(WithdrawalsApi), instance, "instance is a WithdrawalsApi");
        }

        /// <summary>
        /// Test CancelWithdrawal
        /// </summary>
        [Test]
        public void CancelWithdrawalTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string provider = null;
            //string withdrawalId = null;
            //var response = instance.CancelWithdrawal(provider, withdrawalId);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test ConfirmQueuedWithdrawalCancelBlock
        /// </summary>
        [Test]
        public void ConfirmQueuedWithdrawalCancelBlockTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ConfirmQueuedWithdrawalCancelBlock();
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test CreateWithdrawalCancelBlock
        /// </summary>
        [Test]
        public void CreateWithdrawalCancelBlockTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.CreateWithdrawalCancelBlock();
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test GetPendingWithdrawals
        /// </summary>
        [Test]
        public void GetPendingWithdrawalsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetPendingWithdrawals();
            //Assert.IsInstanceOf<PendingWithdrawalResponse> (response, "response is PendingWithdrawalResponse");
        }
        /// <summary>
        /// Test GetQueuedWithdrawalCancelBlock
        /// </summary>
        [Test]
        public void GetQueuedWithdrawalCancelBlockTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetQueuedWithdrawalCancelBlock();
            //Assert.IsInstanceOf<WithdrawalCancelBlockQueuedResponse1> (response, "response is WithdrawalCancelBlockQueuedResponse1");
        }
        /// <summary>
        /// Test GetWithdrawalCancelBlock
        /// </summary>
        [Test]
        public void GetWithdrawalCancelBlockTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetWithdrawalCancelBlock();
            //Assert.IsInstanceOf<WithdrawalCancelBlockQueuedResponse> (response, "response is WithdrawalCancelBlockQueuedResponse");
        }
        /// <summary>
        /// Test RemoveQueuedWithdrawalCancelBlock
        /// </summary>
        [Test]
        public void RemoveQueuedWithdrawalCancelBlockTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.RemoveQueuedWithdrawalCancelBlock();
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test RemoveWithdrawalCancelBlock
        /// </summary>
        [Test]
        public void RemoveWithdrawalCancelBlockTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.RemoveWithdrawalCancelBlock();
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test RequestWithdrawal
        /// </summary>
        [Test]
        public void RequestWithdrawalTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Body60 body = null;
            //var response = instance.RequestWithdrawal(body);
            //Assert.IsInstanceOf<PostWithdrawalResponse> (response, "response is PostWithdrawalResponse");
        }
        /// <summary>
        /// Test RequestWithdrawalTrustly
        /// </summary>
        [Test]
        public void RequestWithdrawalTrustlyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Body57 body = null;
            //var response = instance.RequestWithdrawalTrustly(body);
            //Assert.IsInstanceOf<PostTrustlyWithdrawalResponse> (response, "response is PostTrustlyWithdrawalResponse");
        }
    }

}