/* 
 * BitMEX API
 *
 * ## REST API for the BitMEX Trading Platform  [View Changelog](/app/apiChangelog)    #### Getting Started  Base URI: [https://www.bitmex.com/api/v1](/api/v1)  ##### Fetching Data  All REST endpoints are documented below. You can try out any query right from this interface.  Most table queries accept `count`, `start`, and `reverse` params. Set `reverse=true` to get rows newest-first.  Additional documentation regarding filters, timestamps, and authentication is available in [the main API documentation](/app/restAPI).  *All* table data is available via the [Websocket](/app/wsAPI). We highly recommend using the socket if you want to have the quickest possible data without being subject to ratelimits.  ##### Return Types  By default, all data is returned as JSON. Send `?_format=csv` to get CSV data or `?_format=xml` to get XML data.  ##### Trade Data Queries  *This is only a small subset of what is available, to get you started.*  Fill in the parameters and click the `Try it out!` button to try any of these queries.  * [Pricing Data](#!/Quote/Quote_get)  * [Trade Data](#!/Trade/Trade_get)  * [OrderBook Data](#!/OrderBook/OrderBook_getL2)  * [Settlement Data](#!/Settlement/Settlement_get)  * [Exchange Statistics](#!/Stats/Stats_history)  Every function of the BitMEX.com platform is exposed here and documented. Many more functions are available.  ##### Swagger Specification  [⇩ Download Swagger JSON](swagger.json)    ## All API Endpoints  Click to expand a section. 
 *
 * OpenAPI spec version: 1.2.0
 * Contact: support@bitmex.com
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
    ///  Class for testing TradeBin
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class TradeBinTests
    {
        // TODO uncomment below to declare an instance variable for TradeBin
        //private TradeBin instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of TradeBin
            //instance = new TradeBin();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TradeBin
        /// </summary>
        [Test]
        public void TradeBinInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" TradeBin
            //Assert.IsInstanceOfType<TradeBin> (instance, "variable 'instance' is a TradeBin");
        }


        /// <summary>
        /// Test the property 'Timestamp'
        /// </summary>
        [Test]
        public void TimestampTest()
        {
            // TODO unit test for the property 'Timestamp'
        }
        /// <summary>
        /// Test the property 'Symbol'
        /// </summary>
        [Test]
        public void SymbolTest()
        {
            // TODO unit test for the property 'Symbol'
        }
        /// <summary>
        /// Test the property 'Open'
        /// </summary>
        [Test]
        public void OpenTest()
        {
            // TODO unit test for the property 'Open'
        }
        /// <summary>
        /// Test the property 'High'
        /// </summary>
        [Test]
        public void HighTest()
        {
            // TODO unit test for the property 'High'
        }
        /// <summary>
        /// Test the property 'Low'
        /// </summary>
        [Test]
        public void LowTest()
        {
            // TODO unit test for the property 'Low'
        }
        /// <summary>
        /// Test the property 'Close'
        /// </summary>
        [Test]
        public void CloseTest()
        {
            // TODO unit test for the property 'Close'
        }
        /// <summary>
        /// Test the property 'Trades'
        /// </summary>
        [Test]
        public void TradesTest()
        {
            // TODO unit test for the property 'Trades'
        }
        /// <summary>
        /// Test the property 'Volume'
        /// </summary>
        [Test]
        public void VolumeTest()
        {
            // TODO unit test for the property 'Volume'
        }
        /// <summary>
        /// Test the property 'Vwap'
        /// </summary>
        [Test]
        public void VwapTest()
        {
            // TODO unit test for the property 'Vwap'
        }
        /// <summary>
        /// Test the property 'LastSize'
        /// </summary>
        [Test]
        public void LastSizeTest()
        {
            // TODO unit test for the property 'LastSize'
        }
        /// <summary>
        /// Test the property 'Turnover'
        /// </summary>
        [Test]
        public void TurnoverTest()
        {
            // TODO unit test for the property 'Turnover'
        }
        /// <summary>
        /// Test the property 'HomeNotional'
        /// </summary>
        [Test]
        public void HomeNotionalTest()
        {
            // TODO unit test for the property 'HomeNotional'
        }
        /// <summary>
        /// Test the property 'ForeignNotional'
        /// </summary>
        [Test]
        public void ForeignNotionalTest()
        {
            // TODO unit test for the property 'ForeignNotional'
        }

    }

}
