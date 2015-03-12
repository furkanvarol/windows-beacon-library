﻿// <copyright file="VerboseDiagnosticsLoggerFactoryTest.cs" company="Radius Networks, Inc.">
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
    /// <see cref="AltBeacon.Logging.VerboseDiagnosticsLoggerFactory"/> test class.
    /// </summary>
    [TestClass]
    public class VerboseDiagnosticsLoggerFactoryTest
    {
        #region Logger Name
        /// <summary>
        /// Logger Name Test
        /// </summary>
        [TestMethod]
        public void TestLoggerName()
        {
            var logger = new VerboseDiagnosticsLoggerFactory().GetLogger("VerboseDiagnosticsLoggerFactoryTest");

            Assert.AreEqual(
                "VerboseDiagnosticsLoggerFactoryTest",
                logger.Name,
                "Logger name should be set to VerboseDiagnosticsLoggerFactoryTest");
        }
        #endregion Logger Name

        #region Logger Type
        /// <summary>
        /// Logger Type Test
        /// </summary>
        [TestMethod]
        public void TestLoggerType()
        {
            var logger = new VerboseDiagnosticsLoggerFactory().GetLogger("VerboseDiagnosticsLoggerFactoryTest");

            Assert.IsInstanceOfType(
                logger,
                typeof(VerboseDiagnosticsLogger),
                "VerboseDiagnosticsLoggerFactory.GetLogger method must give VerboseDiagnosticsLogger objects");
        }
        #endregion Logger Type

        #region Logger Reference (Two Logger Same Name)
        /// <summary>
        /// Logger Reference Test (Two Logger Same Name)
        /// </summary>
        [TestMethod]
        public void TestTwoLoggerWithSameName()
        {
            var logger1 = new VerboseDiagnosticsLoggerFactory().GetLogger("VerboseDiagnosticsLoggerFactoryTest");
            var logger2 = new VerboseDiagnosticsLoggerFactory().GetLogger("VerboseDiagnosticsLoggerFactoryTest");

            Assert.AreNotSame(
                logger1,
                logger2,
                "When getting logger with same name twice, different logger should be returned");
        }
        #endregion Logger Reference (Two Logger Same Name)
    }
}