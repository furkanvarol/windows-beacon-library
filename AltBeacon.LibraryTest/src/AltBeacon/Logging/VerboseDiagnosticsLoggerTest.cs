// <copyright file="VerboseDiagnosticsLoggerTest.cs" company="Radius Networks, Inc.">
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
    /// <see cref="AltBeacon.Logging.VerboseDiagnosticsLogger"/> test class.
    /// </summary>
    [TestClass]
    public class VerboseDiagnosticsLoggerTest : System.Diagnostics.TraceListener
    {
        #region Fields
        /// <summary>
        /// Last log message
        /// </summary>
        private string lastLogMessage;
        #endregion Fields

        #region Each Test Initialization and Cleanup
        /// <summary>
        /// Test initialize method which runs before each test.
        /// </summary>
        [TestInitialize]
        public void TestInitializeMethod()
        {
            System.Diagnostics.Debug.Listeners.Add(this);
            this.lastLogMessage = null;
        }

        /// <summary>
        /// Test cleanup method which runs after each test.
        /// </summary>
        [TestCleanup]
        public void TestCleanupMethod()
        {
            System.Diagnostics.Debug.Listeners.Remove(this);
            this.lastLogMessage = null;
        }
        #endregion Each Test Initialization and Cleanup

        #region Logger Name
        /// <summary>
        /// Logger Name Test
        /// </summary>
        [TestMethod]
        public void TestLoggerName()
        {
            var logger = new VerboseDiagnosticsLogger("VerboseDiagnosticsLoggerTest");

            Assert.AreEqual(
                "VerboseDiagnosticsLoggerTest",
                logger.Name,
                "Logger name should be set to VerboseDiagnosticsLoggerTest");
        }
        #endregion Logger Name

        #region Verbose
        /// <summary>
        /// Verbose Type Test
        /// </summary>
        [TestMethod]
        public void TestVerboseType()
        {
            var logger = new VerboseDiagnosticsLogger("VerboseDiagnosticsLoggerTest");

            logger.Verbose("dummy");

            StringAssert.Contains(
                this.lastLogMessage,
                "Verbose",
                "last log message must contain \"Verbose\"");
        }

        /// <summary>
        /// Verbose Log Message Test
        /// </summary>
        [TestMethod]
        public void TestVerboseMessage()
        {
            var logger = new VerboseDiagnosticsLogger("VerboseDiagnosticsLoggerTest");

            logger.Verbose("this is a test");

            StringAssert.Contains(
                this.lastLogMessage, 
                "this is a test", 
                "last log message must contain \"this is a test \"");
        }

        /// <summary>
        /// Verbose Log Message with Parameter (formatted string) Test
        /// </summary>
        [TestMethod]
        public void TestVerboseMessageWithParam()
        {
            var logger = new VerboseDiagnosticsLogger("VerboseDiagnosticsLoggerTest");

            logger.Verbose("{0} {1} {2} {3}", "this", "is", "a", "test");

            StringAssert.Contains(
                this.lastLogMessage, 
                "this is a test", 
                "last log message must contain \"this is a test\"");
        }

        /// <summary>
        /// Verbose Log with Exception Test
        /// </summary>
        [TestMethod]
        public void TestVerboseException()
        {
            var logger = new VerboseDiagnosticsLogger("VerboseDiagnosticsLoggerTest");

            logger.Verbose(new Exception("oops something went wrong!"), "dummy");

            StringAssert.Contains(
                this.lastLogMessage,
                "oops something went wrong!",
                "last log message must contain \"oops something went wrong!\"");
        }

        /// <summary>
        /// Verbose Log Message with Exception Test
        /// </summary>
        [TestMethod]
        public void TestVerboseExceptionMessage()
        {
            var logger = new VerboseDiagnosticsLogger("VerboseDiagnosticsLoggerTest");

            logger.Verbose(new Exception("oops something went wrong!"), "this is a test");

            StringAssert.Contains(
                this.lastLogMessage,
                "this is a test",
                "last log message must contain \"this is a test\"");
        }

        /// <summary>
        /// Verbose Log Message with Parameter (formatted string) and Exception Test
        /// </summary>
        [TestMethod]
        public void TestVerboseExceptionMessageWithParam()
        {
            var logger = new VerboseDiagnosticsLogger("VerboseDiagnosticsLoggerTest");

            logger.Verbose(new Exception("oops something went wrong!"), "{0} {1} {2} {3}", "this", "is", "a", "test");

            StringAssert.Contains(
                this.lastLogMessage,
                "this is a test",
                "last log message must contain \"this is a test\"");
        }
        #endregion Verbose

        #region Trace
        /// <summary>
        /// Trace Type Test
        /// </summary>
        [TestMethod]
        public void TestTraceType()
        {
            var logger = new VerboseDiagnosticsLogger("VerboseDiagnosticsLoggerTest");

            logger.Trace("dummy");

            StringAssert.Contains(
                this.lastLogMessage,
                "Trace",
                "last log message must contain \"Trace\"");
        }

        /// <summary>
        /// Trace Log Message Test
        /// </summary>
        [TestMethod]
        public void TestTraceMessage()
        {
            var logger = new VerboseDiagnosticsLogger("VerboseDiagnosticsLoggerTest");

            logger.Trace("this is a test");

            StringAssert.Contains(
                this.lastLogMessage,
                "this is a test",
                "last log message must contain \"this is a test \"");
        }

        /// <summary>
        /// Trace Log Message with Parameter (formatted string) Test
        /// </summary>
        [TestMethod]
        public void TestTraceMessageWithParam()
        {
            var logger = new VerboseDiagnosticsLogger("VerboseDiagnosticsLoggerTest");

            logger.Trace("{0} {1} {2} {3}", "this", "is", "a", "test");

            StringAssert.Contains(
                this.lastLogMessage,
                "this is a test",
                "last log message must contain \"this is a test\"");
        }

        /// <summary>
        /// Trace Log with Exception Test
        /// </summary>
        [TestMethod]
        public void TestTraceException()
        {
            var logger = new VerboseDiagnosticsLogger("VerboseDiagnosticsLoggerTest");

            logger.Trace(new Exception("oops something went wrong!"), "dummy");

            StringAssert.Contains(
                this.lastLogMessage,
                "oops something went wrong!",
                "last log message must contain \"oops something went wrong!\"");
        }

        /// <summary>
        /// Trace Log Message with Exception Test
        /// </summary>
        [TestMethod]
        public void TestTraceExceptionMessage()
        {
            var logger = new VerboseDiagnosticsLogger("VerboseDiagnosticsLoggerTest");

            logger.Trace(new Exception("oops something went wrong!"), "this is a test");

            StringAssert.Contains(
                this.lastLogMessage,
                "this is a test",
                "last log message must contain \"this is a test\"");
        }

        /// <summary>
        /// Trace Log Message with Parameter (formatted string) and Exception Test
        /// </summary>
        [TestMethod]
        public void TestTraceExceptionMessageWithParam()
        {
            var logger = new VerboseDiagnosticsLogger("VerboseDiagnosticsLoggerTest");

            logger.Trace(new Exception("oops something went wrong!"), "{0} {1} {2} {3}", "this", "is", "a", "test");

            StringAssert.Contains(
                this.lastLogMessage,
                "this is a test",
                "last log message must contain \"this is a test\"");
        }
        #endregion Trace

        #region Debug
        /// <summary>
        /// Debug Type Test
        /// </summary>
        [TestMethod]
        public void TestDebugType()
        {
            var logger = new VerboseDiagnosticsLogger("VerboseDiagnosticsLoggerTest");

            logger.Debug("dummy");

            StringAssert.Contains(
                this.lastLogMessage,
                "Debug",
                "last log message must contain \"Debug\"");
        }

        /// <summary>
        /// Debug Log Message Test
        /// </summary>
        [TestMethod]
        public void TestDebugMessage()
        {
            var logger = new VerboseDiagnosticsLogger("VerboseDiagnosticsLoggerTest");

            logger.Debug("this is a test");

            StringAssert.Contains(
                this.lastLogMessage,
                "this is a test",
                "last log message must contain \"this is a test \"");
        }

        /// <summary>
        /// Debug Log Message with Parameter (formatted string) Test
        /// </summary>
        [TestMethod]
        public void TestDebugMessageWithParam()
        {
            var logger = new VerboseDiagnosticsLogger("VerboseDiagnosticsLoggerTest");

            logger.Debug("{0} {1} {2} {3}", "this", "is", "a", "test");

            StringAssert.Contains(
                this.lastLogMessage,
                "this is a test",
                "last log message must contain \"this is a test\"");
        }

        /// <summary>
        /// Debug Log with Exception Test
        /// </summary>
        [TestMethod]
        public void TestDebugException()
        {
            var logger = new VerboseDiagnosticsLogger("VerboseDiagnosticsLoggerTest");

            logger.Debug(new Exception("oops something went wrong!"), "dummy");

            StringAssert.Contains(
                this.lastLogMessage,
                "oops something went wrong!",
                "last log message must contain \"oops something went wrong!\"");
        }

        /// <summary>
        /// Debug Log Message with Exception Test
        /// </summary>
        [TestMethod]
        public void TestDebugExceptionMessage()
        {
            var logger = new VerboseDiagnosticsLogger("VerboseDiagnosticsLoggerTest");

            logger.Debug(new Exception("oops something went wrong!"), "this is a test");

            StringAssert.Contains(
                this.lastLogMessage,
                "this is a test",
                "last log message must contain \"this is a test\"");
        }

        /// <summary>
        /// Debug Log Message with Parameter (formatted string) and Exception Test
        /// </summary>
        [TestMethod]
        public void TestDebugExceptionMessageWithParam()
        {
            var logger = new VerboseDiagnosticsLogger("VerboseDiagnosticsLoggerTest");

            logger.Debug(new Exception("oops something went wrong!"), "{0} {1} {2} {3}", "this", "is", "a", "test");

            StringAssert.Contains(
                this.lastLogMessage,
                "this is a test",
                "last log message must contain \"this is a test\"");
        }
        #endregion Debug

        #region Info
        /// <summary>
        /// Info Type Test
        /// </summary>
        [TestMethod]
        public void TestInfoType()
        {
            var logger = new VerboseDiagnosticsLogger("VerboseDiagnosticsLoggerTest");

            logger.Info("dummy");

            StringAssert.Contains(
                this.lastLogMessage,
                "Info",
                "last log message must contain \"Info\"");
        }

        /// <summary>
        /// Info Log Message Test
        /// </summary>
        [TestMethod]
        public void TestInfoMessage()
        {
            var logger = new VerboseDiagnosticsLogger("VerboseDiagnosticsLoggerTest");

            logger.Info("this is a test");

            StringAssert.Contains(
                this.lastLogMessage,
                "this is a test",
                "last log message must contain \"this is a test \"");
        }

        /// <summary>
        /// Info Log Message with Parameter (formatted string) Test
        /// </summary>
        [TestMethod]
        public void TestInfoMessageWithParam()
        {
            var logger = new VerboseDiagnosticsLogger("VerboseDiagnosticsLoggerTest");

            logger.Info("{0} {1} {2} {3}", "this", "is", "a", "test");

            StringAssert.Contains(
                this.lastLogMessage,
                "this is a test",
                "last log message must contain \"this is a test\"");
        }

        /// <summary>
        /// Info Log with Exception Test
        /// </summary>
        [TestMethod]
        public void TestInfoException()
        {
            var logger = new VerboseDiagnosticsLogger("VerboseDiagnosticsLoggerTest");

            logger.Info(new Exception("oops something went wrong!"), "dummy");

            StringAssert.Contains(
                this.lastLogMessage,
                "oops something went wrong!",
                "last log message must contain \"oops something went wrong!\"");
        }

        /// <summary>
        /// Info Log Message with Exception Test
        /// </summary>
        [TestMethod]
        public void TestInfoExceptionMessage()
        {
            var logger = new VerboseDiagnosticsLogger("VerboseDiagnosticsLoggerTest");

            logger.Info(new Exception("oops something went wrong!"), "this is a test");

            StringAssert.Contains(
                this.lastLogMessage,
                "this is a test",
                "last log message must contain \"this is a test\"");
        }

        /// <summary>
        /// Info Log Message with Parameter (formatted string) and Exception Test
        /// </summary>
        [TestMethod]
        public void TestInfoExceptionMessageWithParam()
        {
            var logger = new VerboseDiagnosticsLogger("VerboseDiagnosticsLoggerTest");

            logger.Info(new Exception("oops something went wrong!"), "{0} {1} {2} {3}", "this", "is", "a", "test");

            StringAssert.Contains(
                this.lastLogMessage,
                "this is a test",
                "last log message must contain \"this is a test\"");
        }
        #endregion Info

        #region Warn
        /// <summary>
        /// Warn Type Test
        /// </summary>
        [TestMethod]
        public void TestWarnType()
        {
            var logger = new VerboseDiagnosticsLogger("VerboseDiagnosticsLoggerTest");

            logger.Warn("dummy");

            StringAssert.Contains(
                this.lastLogMessage,
                "Warn",
                "last log message must contain \"Warn\"");
        }

        /// <summary>
        /// Warn Log Message Test
        /// </summary>
        [TestMethod]
        public void TestWarnMessage()
        {
            var logger = new VerboseDiagnosticsLogger("VerboseDiagnosticsLoggerTest");

            logger.Warn("this is a test");

            StringAssert.Contains(
                this.lastLogMessage,
                "this is a test",
                "last log message must contain \"this is a test \"");
        }

        /// <summary>
        /// Warn Log Message with Parameter (formatted string) Test
        /// </summary>
        [TestMethod]
        public void TestWarnMessageWithParam()
        {
            var logger = new VerboseDiagnosticsLogger("VerboseDiagnosticsLoggerTest");

            logger.Warn("{0} {1} {2} {3}", "this", "is", "a", "test");

            StringAssert.Contains(
                this.lastLogMessage,
                "this is a test",
                "last log message must contain \"this is a test\"");
        }

        /// <summary>
        /// Warn Log with Exception Test
        /// </summary>
        [TestMethod]
        public void TestWarnException()
        {
            var logger = new VerboseDiagnosticsLogger("VerboseDiagnosticsLoggerTest");

            logger.Warn(new Exception("oops something went wrong!"), "dummy");

            StringAssert.Contains(
                this.lastLogMessage,
                "oops something went wrong!",
                "last log message must contain \"oops something went wrong!\"");
        }

        /// <summary>
        /// Warn Log Message with Exception Test
        /// </summary>
        [TestMethod]
        public void TestWarnExceptionMessage()
        {
            var logger = new VerboseDiagnosticsLogger("VerboseDiagnosticsLoggerTest");

            logger.Warn(new Exception("oops something went wrong!"), "this is a test");

            StringAssert.Contains(
                this.lastLogMessage,
                "this is a test",
                "last log message must contain \"this is a test\"");
        }

        /// <summary>
        /// Warn Log Message with Parameter (formatted string) and Exception Test
        /// </summary>
        [TestMethod]
        public void TestWarnExceptionMessageWithParam()
        {
            var logger = new VerboseDiagnosticsLogger("VerboseDiagnosticsLoggerTest");

            logger.Warn(new Exception("oops something went wrong!"), "{0} {1} {2} {3}", "this", "is", "a", "test");

            StringAssert.Contains(
                this.lastLogMessage,
                "this is a test",
                "last log message must contain \"this is a test\"");
        }
        #endregion Warn

        #region Error
        /// <summary>
        /// Error Type Test
        /// </summary>
        [TestMethod]
        public void TestErrorType()
        {
            var logger = new VerboseDiagnosticsLogger("VerboseDiagnosticsLoggerTest");

            logger.Error("dummy");

            StringAssert.Contains(
                this.lastLogMessage,
                "Error",
                "last log message must contain \"Error\"");
        }

        /// <summary>
        /// Error Log Message Test
        /// </summary>
        [TestMethod]
        public void TestErrorMessage()
        {
            var logger = new VerboseDiagnosticsLogger("VerboseDiagnosticsLoggerTest");

            logger.Error("this is a test");

            StringAssert.Contains(
                this.lastLogMessage,
                "this is a test",
                "last log message must contain \"this is a test \"");
        }

        /// <summary>
        /// Error Log Message with Parameter (formatted string) Test
        /// </summary>
        [TestMethod]
        public void TestErrorMessageWithParam()
        {
            var logger = new VerboseDiagnosticsLogger("VerboseDiagnosticsLoggerTest");

            logger.Error("{0} {1} {2} {3}", "this", "is", "a", "test");

            StringAssert.Contains(
                this.lastLogMessage,
                "this is a test",
                "last log message must contain \"this is a test\"");
        }

        /// <summary>
        /// Error Log with Exception Test
        /// </summary>
        [TestMethod]
        public void TestErrorException()
        {
            var logger = new VerboseDiagnosticsLogger("VerboseDiagnosticsLoggerTest");

            logger.Error(new Exception("oops something went wrong!"), "dummy");

            StringAssert.Contains(
                this.lastLogMessage,
                "oops something went wrong!",
                "last log message must contain \"oops something went wrong!\"");
        }

        /// <summary>
        /// Error Log Message with Exception Test
        /// </summary>
        [TestMethod]
        public void TestErrorExceptionMessage()
        {
            var logger = new VerboseDiagnosticsLogger("VerboseDiagnosticsLoggerTest");

            logger.Error(new Exception("oops something went wrong!"), "this is a test");

            StringAssert.Contains(
                this.lastLogMessage,
                "this is a test",
                "last log message must contain \"this is a test\"");
        }

        /// <summary>
        /// Error Log Message with Parameter (formatted string) and Exception Test
        /// </summary>
        [TestMethod]
        public void TestErrorExceptionMessageWithParam()
        {
            var logger = new VerboseDiagnosticsLogger("VerboseDiagnosticsLoggerTest");

            logger.Error(new Exception("oops something went wrong!"), "{0} {1} {2} {3}", "this", "is", "a", "test");

            StringAssert.Contains(
                this.lastLogMessage,
                "this is a test",
                "last log message must contain \"this is a test\"");
        }
        #endregion Error

        #region Fatal
        /// <summary>
        /// Fatal Type Test
        /// </summary>
        [TestMethod]
        public void TestFatalType()
        {
            var logger = new VerboseDiagnosticsLogger("VerboseDiagnosticsLoggerTest");

            logger.Fatal("dummy");

            StringAssert.Contains(
                this.lastLogMessage,
                "Fatal",
                "last log message must contain \"Fatal\"");
        }

        /// <summary>
        /// Fatal Log Message Test
        /// </summary>
        [TestMethod]
        public void TestFatalMessage()
        {
            var logger = new VerboseDiagnosticsLogger("VerboseDiagnosticsLoggerTest");

            logger.Fatal("this is a test");

            StringAssert.Contains(
                this.lastLogMessage,
                "this is a test",
                "last log message must contain \"this is a test \"");
        }

        /// <summary>
        /// Fatal Log Message with Parameter (formatted string) Test
        /// </summary>
        [TestMethod]
        public void TestFatalMessageWithParam()
        {
            var logger = new VerboseDiagnosticsLogger("VerboseDiagnosticsLoggerTest");

            logger.Fatal("{0} {1} {2} {3}", "this", "is", "a", "test");

            StringAssert.Contains(
                this.lastLogMessage,
                "this is a test",
                "last log message must contain \"this is a test\"");
        }

        /// <summary>
        /// Fatal Log with Exception Test
        /// </summary>
        [TestMethod]
        public void TestFatalException()
        {
            var logger = new VerboseDiagnosticsLogger("VerboseDiagnosticsLoggerTest");

            logger.Fatal(new Exception("oops something went wrong!"), "dummy");

            StringAssert.Contains(
                this.lastLogMessage,
                "oops something went wrong!",
                "last log message must contain \"oops something went wrong!\"");
        }

        /// <summary>
        /// Fatal Log Message with Exception Test
        /// </summary>
        [TestMethod]
        public void TestFatalExceptionMessage()
        {
            var logger = new VerboseDiagnosticsLogger("VerboseDiagnosticsLoggerTest");

            logger.Fatal(new Exception("oops something went wrong!"), "this is a test");

            StringAssert.Contains(
                this.lastLogMessage,
                "this is a test",
                "last log message must contain \"this is a test\"");
        }

        /// <summary>
        /// Fatal Log Message with Parameter (formatted string) and Exception Test
        /// </summary>
        [TestMethod]
        public void TestFatalExceptionMessageWithParam()
        {
            var logger = new VerboseDiagnosticsLogger("VerboseDiagnosticsLoggerTest");

            logger.Fatal(new Exception("oops something went wrong!"), "{0} {1} {2} {3}", "this", "is", "a", "test");

            StringAssert.Contains(
                this.lastLogMessage,
                "this is a test",
                "last log message must contain \"this is a test\"");
        }
        #endregion Fatal

        #region System.Diagnostics.TraceListener Members
        /// <summary>
        /// When overridden in a derived class, writes the specified message to the listener you
        /// create in the derived class.
        /// </summary>
        /// <param name="message">
        /// A message to write.
        /// </param>
        public override void Write(string message)
        {
            this.lastLogMessage = message;
        }

        /// <summary>
        /// When overridden in a derived class, writes a message to the listener you
        /// create in the derived class, followed by a line terminator.
        /// </summary>
        /// <param name="message">
        /// A message to write.
        /// </param>
        public override void WriteLine(string message)
        {
            this.lastLogMessage = message;
        }
        #endregion System.Diagnostics.TraceListener Members
    }
}
