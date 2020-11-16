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
    ///  Class for testing GetCommentsReponseComments
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class GetCommentsReponseCommentsTests
    {
        // TODO uncomment below to declare an instance variable for GetCommentsReponseComments
        //private GetCommentsReponseComments instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of GetCommentsReponseComments
            //instance = new GetCommentsReponseComments();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GetCommentsReponseComments
        /// </summary>
        [Test]
        public void GetCommentsReponseCommentsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" GetCommentsReponseComments
            //Assert.IsInstanceOfType<GetCommentsReponseComments> (instance, "variable 'instance' is a GetCommentsReponseComments");
        }


        /// <summary>
        /// Test the property 'CommentText'
        /// </summary>
        [Test]
        public void CommentTextTest()
        {
            // TODO unit test for the property 'CommentText'
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
        /// Test the property 'Created'
        /// </summary>
        [Test]
        public void CreatedTest()
        {
            // TODO unit test for the property 'Created'
        }
        /// <summary>
        /// Test the property 'EventId'
        /// </summary>
        [Test]
        public void EventIdTest()
        {
            // TODO unit test for the property 'EventId'
        }
        /// <summary>
        /// Test the property 'HideStake'
        /// </summary>
        [Test]
        public void HideStakeTest()
        {
            // TODO unit test for the property 'HideStake'
        }
        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'LegacyCommentId'
        /// </summary>
        [Test]
        public void LegacyCommentIdTest()
        {
            // TODO unit test for the property 'LegacyCommentId'
        }
        /// <summary>
        /// Test the property 'Link'
        /// </summary>
        [Test]
        public void LinkTest()
        {
            // TODO unit test for the property 'Link'
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
        /// Test the property 'MemberId'
        /// </summary>
        [Test]
        public void MemberIdTest()
        {
            // TODO unit test for the property 'MemberId'
        }
        /// <summary>
        /// Test the property 'Mentions'
        /// </summary>
        [Test]
        public void MentionsTest()
        {
            // TODO unit test for the property 'Mentions'
        }
        /// <summary>
        /// Test the property 'NumComments'
        /// </summary>
        [Test]
        public void NumCommentsTest()
        {
            // TODO unit test for the property 'NumComments'
        }
        /// <summary>
        /// Test the property 'Odds'
        /// </summary>
        [Test]
        public void OddsTest()
        {
            // TODO unit test for the property 'Odds'
        }
        /// <summary>
        /// Test the property 'ParentCommentId'
        /// </summary>
        [Test]
        public void ParentCommentIdTest()
        {
            // TODO unit test for the property 'ParentCommentId'
        }
        /// <summary>
        /// Test the property 'Reactions'
        /// </summary>
        [Test]
        public void ReactionsTest()
        {
            // TODO unit test for the property 'Reactions'
        }
        /// <summary>
        /// Test the property 'Stake'
        /// </summary>
        [Test]
        public void StakeTest()
        {
            // TODO unit test for the property 'Stake'
        }

    }

}
