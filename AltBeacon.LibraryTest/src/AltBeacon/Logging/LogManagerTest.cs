// <copyright file="LogManagerTest.cs" company="Radius Networks, Inc.">
//     Copyright (c) Radius Networks, Inc.
//     http://www.radiusnetworks.com
// </copyright>
// 
// Licensed to the Apache Software Foundation (ASF) under one
// or more contributor license agreements. See the NOTICE file
// distributed with this work for additional information
// regarding copyright ownership. The ASF licenses this file
// to you under the Apache License, Version 2.0 (the
// "License"); you may not use this file except in compliance
// with the License. You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied. See the License for the
// specific language governing permissions and limitations
// under the License.
namespace AltBeacon.Logging
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// <see cref="AltBeacon.Logging.LogManager"/> test class.
    /// </summary>
    [TestClass]
    public class LogManagerTest
    {
        [TestMethod]
        public void TestVerboseLoggingEnabledTrue()
        {
            LogManager.VerboseLoggingEnabled = false;
            LogManager.VerboseLoggingEnabled = true;

            Assert.AreEqual(
                true, 
                LogManager.VerboseLoggingEnabled, 
                "VerboseLoggingEnabled should be set to true");
        }

        [TestMethod]
        public void TestVerboseLoggingEnabledFalse()
        {
            LogManager.VerboseLoggingEnabled = true;
            LogManager.VerboseLoggingEnabled = false;

            Assert.AreEqual(
                false, 
                LogManager.VerboseLoggingEnabled, 
                "VerboseLoggingEnabled should be set to false");
        }

        [TestMethod]
        public void TestDefaultLoggerFactory()
        {
            Assert.AreEqual(
                LogManager.DefaultLoggerFactory, 
                LogManager.LoggerFactory, 
                "Initial value of the LoggerFactory must equal to DefaultLoggerFactory, " + 
                "this test can be failed because of checking static reference and " + 
                "it may be altered before this test is called. Just ignore it.");
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException), "LogManager.LoggerFactory can no be null.")]
        public void TestNullLoggerFactory()
        {
            LogManager.LoggerFactory = null;
        }

        [TestMethod]
        public void TestEmptyLoggerFactory()
        {
            LogManager.LoggerFactory = LogManager.EmptyLoggerFactory;

            Assert.AreEqual(
                LogManager.EmptyLoggerFactory, 
                LogManager.LoggerFactory, 
                "LoggerFactory should be set to EmptyLoggerFactory");
        }

        [TestMethod]
        public void TestVerboseDiagnosticsLoggerFactory()
        {
            LogManager.LoggerFactory = LogManager.VerboseDiagnosticsLoggerFactory;

            Assert.AreEqual(
                LogManager.VerboseDiagnosticsLoggerFactory, 
                LogManager.LoggerFactory, 
                "LoggerFactory should be set to VerboseDiagnosticsLoggerFactory");
        }

        [TestMethod]
        public void TestWarningDiagnosticsLoggerFactory()
        {
            LogManager.LoggerFactory = LogManager.WarningDiagnosticsLoggerFactory;

            Assert.AreEqual(
                LogManager.WarningDiagnosticsLoggerFactory, 
                LogManager.LoggerFactory, 
                "LoggerFactory should be set to WarningDiagnosticsLoggerFactory");
        }

        [TestMethod]
        public void TestEmptyLoggerFactoryName()
        {
            LogManager.LoggerFactory = LogManager.EmptyLoggerFactory;
            ILogger logger = LogManager.GetLogger("TestLogger");

            Assert.AreEqual(
                "TestLogger",
                logger.Name,
                "LoggerFactory.GetLogger must create a ILogger with the same name " + 
                    "it is provided to it if LoggerFactory is set to EmptyLoggerFactory");
        }

        [TestMethod]
        public void TestVerboseDiagnosticsLoggerFactoryName()
        {
            LogManager.LoggerFactory = LogManager.VerboseDiagnosticsLoggerFactory;
            ILogger logger = LogManager.GetLogger("TestLogger");

            Assert.AreEqual(
                "TestLogger",
                logger.Name,
                "LoggerFactory.GetLogger must create a ILogger with the same name " +
                    "it is provided to it if LoggerFactory is set to VerboseDiagnosticsLoggerFactory");
        }

        [TestMethod]
        public void TestWarningDiagnosticsLoggerFactoryName()
        {
            LogManager.LoggerFactory = LogManager.WarningDiagnosticsLoggerFactory;
            ILogger logger = LogManager.GetLogger("TestLogger");

            Assert.AreEqual(
                "TestLogger",
                logger.Name,
                "LoggerFactory.GetLogger must create a ILogger with the same name " +
                    "it is provided to it if LoggerFactory is set to WarningDiagnosticsLoggerFactory");
        }        

        [TestMethod]
        public void TestGetLoggerDifferentNameDifferentObject()
        {
            LogManager.LoggerFactory = LogManager.DefaultLoggerFactory;
            ILogger loggerFirst = LogManager.GetLogger("TestLoggerFirst");
            ILogger loggerSecond = LogManager.GetLogger("TestLoggerSecond");

            Assert.AreNotSame(
                loggerFirst,
                loggerSecond,
                "LoggerFactory.GetLogger must create different logger when different name is provided");
        }

        [TestMethod]
        public void TestGetLoggerSameNameDifferentObject()
        {
            LogManager.LoggerFactory = LogManager.DefaultLoggerFactory;
            ILogger loggerFirst1 = LogManager.GetLogger("TestLoggerFirst");
            ILogger loggerFirst2 = LogManager.GetLogger("TestLoggerFirst");

            Assert.AreNotSame(
                loggerFirst1,
                loggerFirst2,
                "LoggerFactory.GetLogger must create different logger even same name is provided");
        }
    }
}
