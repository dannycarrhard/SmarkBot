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
    ///  Class for testing NotificationsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class NotificationsApiTests
    {
        private NotificationsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new NotificationsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of NotificationsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' NotificationsApi
            //Assert.IsInstanceOfType(typeof(NotificationsApi), instance, "instance is a NotificationsApi");
        }

        /// <summary>
        /// Test AddEventSubscription
        /// </summary>
        [Test]
        public void AddEventSubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? eventId = null;
            //var response = instance.AddEventSubscription(eventId);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test CreateRegistration
        /// </summary>
        [Test]
        public void CreateRegistrationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Body35 body = null;
            //var response = instance.CreateRegistration(body);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test DeleteEventSubscriptions
        /// </summary>
        [Test]
        public void DeleteEventSubscriptionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? eventId = null;
            //var response = instance.DeleteEventSubscriptions(eventId);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test DeleteRegistration
        /// </summary>
        [Test]
        public void DeleteRegistrationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string registrationId = null;
            //var response = instance.DeleteRegistration(registrationId);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test GetEventSubscriptions
        /// </summary>
        [Test]
        public void GetEventSubscriptionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int?> eventIds = null;
            //var response = instance.GetEventSubscriptions(eventIds);
            //Assert.IsInstanceOf<InlineResponse20046> (response, "response is InlineResponse20046");
        }
        /// <summary>
        /// Test GetSubscriptions
        /// </summary>
        [Test]
        public void GetSubscriptionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetSubscriptions();
            //Assert.IsInstanceOf<InlineResponse20045> (response, "response is InlineResponse20045");
        }
        /// <summary>
        /// Test SendSampleNotification
        /// </summary>
        [Test]
        public void SendSampleNotificationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.SendSampleNotification();
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test SendTestNotification
        /// </summary>
        [Test]
        public void SendTestNotificationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string registrationId = null;
            //var response = instance.SendTestNotification(registrationId);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test UpdateEventSubscriptions
        /// </summary>
        [Test]
        public void UpdateEventSubscriptionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? eventId = null;
            //Body37 body = null;
            //var response = instance.UpdateEventSubscriptions(eventId, body);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test UpdateSubscriptions
        /// </summary>
        [Test]
        public void UpdateSubscriptionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Body36 body = null;
            //var response = instance.UpdateSubscriptions(body);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
    }

}
