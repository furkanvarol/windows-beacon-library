// <copyright file="VerboseDiagnosticsLogger.cs" company="Radius Networks, Inc.">
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
    using System.Diagnostics;
    using System.Text;

    /// <summary>
    /// A logger that uses <see cref="System.Diagnostics.Debug"/>
    /// class for logs Verbose (Trace) or higher level.
    /// This class can not be inherited.
    /// </summary>
    public sealed class VerboseDiagnosticsLogger : BaseDiagnosticsLogger
    {
        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="VerboseDiagnosticsLogger"/> class.
        /// </summary>
        /// <param name="name">
        /// Identifier of the source of a log message. It usually
        /// identifies the class or activity where the log call occurs.
        /// </param>
        public VerboseDiagnosticsLogger(string name)
            : base(name)
        {
        }
        #endregion Constructor

        #region Trace
        /// <summary>
        /// Logs a trace message (same level as verbose - NLog Trace).
        /// </summary>
        /// <param name="message">
        /// The message you would like logged. This message may contain
        /// string formatting which will be replaced with values from args.
        /// </param>
        /// <param name="args">
        /// Arguments for string formatting.
        /// </param>
        /// <seealso cref="Verbose(string, params object[])"/>
        public override void Trace(string message, params object[] args)
        {
            this.WriteLine("Trace", message, args);
        }

        /// <summary>
        /// Logs a trace message (same level as verbose - NLog Trace).
        /// </summary>
        /// <param name="exception">
        /// An exception to log.
        /// </param>
        /// <param name="message">
        /// The message you would like logged. This message may contain
        /// string formatting which will be replaced with values from args.
        /// </param>
        /// <param name="args">
        /// Arguments for string formatting.
        /// </param>
        /// <seealso cref="Verbose(string, params object[])"/>
        public override void Trace(Exception exception, string message, params object[] args)
        {
            this.WriteLine("Trace", exception, message, args);
        }
        #endregion Trace

        #region Verbose
        /// <summary>
        /// Logs a verbose message (same level as trace also to support Android based coders).
        /// </summary>
        /// <param name="message">
        /// The message you would like logged. This message may contain
        /// string formatting which will be replaced with values from args.
        /// </param>
        /// <param name="args">
        /// Arguments for string formatting.
        /// </param>
        /// <seealso cref="Verbose(string, params object[])"/>
        public override void Verbose(string message, params object[] args)
        {
            this.WriteLine("Verbose", message, args);
        }

        /// <summary>
        /// Logs a verbose message (same level as trace also to support Android based coders).
        /// </summary>
        /// <param name="exception">
        /// An exception to log.
        /// </param>
        /// <param name="message">
        /// The message you would like logged. This message may contain
        /// string formatting which will be replaced with values from args.
        /// </param>
        /// <param name="args">
        /// Arguments for string formatting.
        /// </param>
        /// <seealso cref="Verbose(string, params object[])"/>
        public override void Verbose(Exception exception, string message, params object[] args)
        {
            this.WriteLine("Verbose", exception, message, args);
        }
        #endregion Verbose

        #region Debug
        /// <summary>
        /// Logs a debug message.
        /// </summary>
        /// <param name="message">
        /// The message you would like logged. This message may contain
        /// string formatting which will be replaced with values from args.
        /// </param>
        /// <param name="args">
        /// Arguments for string formatting.
        /// </param>
        /// <seealso cref="Verbose(string, params object[])"/>
        public override void Debug(string message, params object[] args)
        {
            this.WriteLine("Debug", message, args);
        }

        /// <summary>
        /// Logs a debug message.
        /// </summary>
        /// <param name="exception">
        /// An exception to log.
        /// </param>
        /// <param name="message">
        /// The message you would like logged. This message may contain
        /// string formatting which will be replaced with values from args.
        /// </param>
        /// <param name="args">
        /// Arguments for string formatting.
        /// </param>
        /// <seealso cref="Verbose(string, params object[])"/>
        public override void Debug(Exception exception, string message, params object[] args)
        {
            this.WriteLine("Debug", exception, message, args);
        }
        #endregion Debug

        #region Info
        /// <summary>
        /// Logs a info message.
        /// </summary>
        /// <param name="message">
        /// The message you would like logged. This message may contain
        /// string formatting which will be replaced with values from args.
        /// </param>
        /// <param name="args">
        /// Arguments for string formatting.
        /// </param>
        /// <seealso cref="Verbose(string, params object[])"/>
        public override void Info(string message, params object[] args)
        {
            this.WriteLine("Info", message, args);
        }

        /// <summary>
        /// Logs a info message.
        /// </summary>
        /// <param name="exception">
        /// An exception to log.
        /// </param>
        /// <param name="message">
        /// The message you would like logged. This message may contain
        /// string formatting which will be replaced with values from args.
        /// </param>
        /// <param name="args">
        /// Arguments for string formatting.
        /// </param>
        /// <seealso cref="Verbose(string, params object[])"/>
        public override void Info(Exception exception, string message, params object[] args)
        {
            this.WriteLine("Info", exception, message, args);
        }
        #endregion Info

        #region Warn
        /// <summary>
        /// Logs a warning message.
        /// </summary>
        /// <param name="message">
        /// The message you would like logged. This message may contain
        /// string formatting which will be replaced with values from args.
        /// </param>
        /// <param name="args">
        /// Arguments for string formatting.
        /// </param>
        /// <seealso cref="Verbose(string, params object[])"/>
        public override void Warn(string message, params object[] args)
        {
            this.WriteLine("Warn", message, args);
        }

        /// <summary>
        /// Logs a warning message.
        /// </summary>
        /// <param name="exception">
        /// An exception to log.
        /// </param>
        /// <param name="message">
        /// The message you would like logged. This message may contain
        /// string formatting which will be replaced with values from args.
        /// </param>
        /// <param name="args">
        /// Arguments for string formatting.
        /// </param>
        /// <seealso cref="Verbose(string, params object[])"/>
        public override void Warn(Exception exception, string message, params object[] args)
        {
            this.WriteLine("Warn", exception, message, args);
        }
        #endregion Warn

        #region Error
        /// <summary>
        /// Logs a error message.
        /// </summary>
        /// <param name="message">
        /// The message you would like logged. This message may contain
        /// string formatting which will be replaced with values from args.
        /// </param>
        /// <param name="args">
        /// Arguments for string formatting.
        /// </param>
        /// <seealso cref="Verbose(string, params object[])"/>
        public override void Error(string message, params object[] args)
        {
            this.WriteLine("Error", message, args);
        }

        /// <summary>
        /// Logs a error message.
        /// </summary>
        /// <param name="exception">
        /// An exception to log.
        /// </param>
        /// <param name="message">
        /// The message you would like logged. This message may contain
        /// string formatting which will be replaced with values from args.
        /// </param>
        /// <param name="args">
        /// Arguments for string formatting.
        /// </param>
        /// <seealso cref="Verbose(string, params object[])"/>
        public override void Error(Exception exception, string message, params object[] args)
        {
            this.WriteLine("Error", exception, message, args);
        }
        #endregion Error
        
        #region Fatal
        /// <summary>
        /// Logs a fatal message (for NLog fatal).
        /// </summary>
        /// <param name="message">
        /// The message you would like logged. This message may contain
        /// string formatting which will be replaced with values from args.
        /// </param>
        /// <param name="args">
        /// Arguments for string formatting.
        /// </param>
        /// <seealso cref="Error(String, Object[])"/>
        public override void Fatal(string message, params object[] args)
        {
            this.WriteLine("Fatal", message, args);
        }

        /// <summary>
        /// Logs a fatal message (for NLog fatal).
        /// </summary>
        /// <param name="exception">
        /// An exception to log.
        /// </param>
        /// <param name="message">
        /// The message you would like logged. This message may contain
        /// string formatting which will be replaced with values from args.
        /// </param>
        /// <param name="args">
        /// Arguments for string formatting.
        /// </param>
        /// <seealso cref="Error(Exception, String, Object[])"/>
        public override void Fatal(Exception exception, string message, params object[] args)
        {
            this.WriteLine("Fatal", exception, message, args);
        }
        #endregion Fatal
    }
}
