// <copyright file="ILogger.cs" company="Radius Networks, Inc.">
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

    /// <summary>
    /// Logging interface for logging messages in the AltBeacon Library.
    /// To set a custom logger, implement <see cref="AltBeacon.Logging.ILoggerFactory"/>
    /// interface and set it with 
    /// <see cref="AltBeacon.Logging.LogManager#SetLoggerFactory(ILoggerFactory)"/>
    /// </summary>
    public interface ILogger
    {
        #region Name
        /// <summary>
        /// Gets identifier of the source of a log message. It usually
        /// identifies the class or activity where the log call occurs.
        /// </summary>
        string Name { get; }
        #endregion Error

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
        /// <seealso cref="Verbose(String, Object[])"/>
        void Trace(string message, params object[] args);

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
        /// <seealso cref="Verbose(Exception, String, Object[])"/>
        void Trace(Exception exception, string message, params object[] args);
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
        /// <seealso cref="Trace(String, Object[])"/>
        void Verbose(string message, params object[] args);

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
        /// <seealso cref="Trace(Exception, String, Object[])"/>
        void Verbose(Exception exception, string message, params object[] args);
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
        void Debug(string message, params object[] args);
        
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
        void Debug(Exception exception, string message, params object[] args);
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
        void Info(string message, params object[] args);

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
        void Info(Exception exception, string message, params object[] args);
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
        void Warn(string message, params object[] args);

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
        void Warn(Exception exception, string message, params object[] args);
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
        void Error(string message, params object[] args);

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
        void Error(Exception exception, string message, params object[] args);
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
        void Fatal(string message, params object[] args);

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
        void Fatal(Exception exception, string message, params object[] args);
        #endregion Fatal
    }
}