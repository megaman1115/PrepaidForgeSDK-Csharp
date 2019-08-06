/* 
 * Prepaidforge API
 *
 * The public api for prepaidforge
 *
 * The version of the OpenAPI document: 1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using PrepaidforgeSDK.Client;
using PrepaidforgeSDK.Api;
using PrepaidforgeSDK.Model;

namespace PrepaidforgeSDK.Test
{
    /// <summary>
    ///  Class for testing OrdersCodesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class OrdersCodesApiTests
    {
        private OrdersCodesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            Configuration.Default.BasePath = "https://devapi.prepaidforge.com/v1";
            instance = new OrdersCodesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OrdersCodesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' OrdersCodesApi
            //Assert.IsInstanceOf(typeof(OrdersCodesApi), instance);
        }

        
        /// <summary>
        /// Test CreateSingleOrder
        /// </summary>
        [Test]
        public void CreateSingleOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SkuRequest skuRequest = null;
            //var response = instance.CreateSingleOrder(skuRequest);
            //Assert.IsInstanceOf(typeof(CodeDeliveryPojo), response, "response is CodeDeliveryPojo");
        }
        
        /// <summary>
        /// Test GetResponseOfSingleCodeRequest
        /// </summary>
        [Test]
        public void GetResponseOfSingleCodeRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SkuRequest skuRequest = null;
            //var response = instance.GetResponseOfSingleCodeRequest(skuRequest);
            //Assert.IsInstanceOf(typeof(CodeDeliveryPojo), response, "response is CodeDeliveryPojo");
        }
        
    }

}
