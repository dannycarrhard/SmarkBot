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
    ///  Class for testing FileUploadResult
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class FileUploadResultTests
    {
        // TODO uncomment below to declare an instance variable for FileUploadResult
        //private FileUploadResult instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of FileUploadResult
            //instance = new FileUploadResult();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FileUploadResult
        /// </summary>
        [Test]
        public void FileUploadResultInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" FileUploadResult
            //Assert.IsInstanceOfType<FileUploadResult> (instance, "variable 'instance' is a FileUploadResult");
        }


        /// <summary>
        /// Test the property 'Error'
        /// </summary>
        [Test]
        public void ErrorTest()
        {
            // TODO unit test for the property 'Error'
        }
        /// <summary>
        /// Test the property 'FileName'
        /// </summary>
        [Test]
        public void FileNameTest()
        {
            // TODO unit test for the property 'FileName'
        }
        /// <summary>
        /// Test the property 'Success'
        /// </summary>
        [Test]
        public void SuccessTest()
        {
            // TODO unit test for the property 'Success'
        }

    }

}
