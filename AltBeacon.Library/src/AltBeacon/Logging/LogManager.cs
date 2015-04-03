// <copyright file="LogManager.cs" company="Radius Networks, Inc.">
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
    /// Manager for logging in the AltBeacon Library.
    /// The default is <see cref="WarningDiagnosticsLoggerFactory"/>
    /// This class can not be inherited nor initialized.
    /// </summary>
    public static class LogManager
    {
        #region Factory Fields
        /// <summary>
        /// Default Logger Factory
        /// <see cref="WarningDiagnosticsLoggerFactory"/>
        /// </summary>
        public static readonly ILoggerFactory DefaultLoggerFactory = new WarningDiagnosticsLoggerFactory();

        /// <summary>
        /// Predefined Empty Logger Factory
        /// <see cref="AltBeacon.Logging.EmptyLoggerFactory"/>
        /// </summary>
        public static readonly ILoggerFactory EmptyLoggerFactory = new EmptyLoggerFactory();

        /// <summary>
        /// Predefined Verbose(Trace) or higher level Logger Factory
        /// <see cref="AltBeacon.Logging.VerboseDiagnosticsLoggerFactory"/>
        /// </summary>
        public static readonly ILoggerFactory VerboseDiagnosticsLoggerFactory =
            new VerboseDiagnosticsLoggerFactory();

        /// <summary>
        /// Predefined Warning or higher level Logger Factory
        /// <see cref="AltBeacon.Logging.WarningDiagnosticsLoggerFactory"/>
        /// </summary>
        public static readonly ILoggerFactory WarningDiagnosticsLoggerFactory =
            new WarningDiagnosticsLoggerFactory();
        #endregion Factory Fields

        #region Private Fields
        /// <summary>
        /// <see cref="LoggerFactory"/>
        /// </summary>
        private static ILoggerFactory loggerFactory = DefaultLoggerFactory;

        /// <summary>
        /// <see cref="DebugLoggingEnabled"/>
        /// </summary>
        private static bool debugLoggingEnabled = false;
        #endregion Private Fields

        #region Properties
        /// <summary>
        /// Gets or sets logger factory which will create loggers
        /// that the AltBeacon Library will use to send it's log messages to.
        /// </summary>
        /// <exception cref="NullReferenceException">
        /// When null is given.
        /// </exception>
        public static ILoggerFactory LoggerFactory
        {
            get
            {
                return loggerFactory;
            }

            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("LoggerFactory can not be null!");
                }

                loggerFactory = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether verbose logging is enabled.
        /// If not, expensive calculations to create log strings should be avoided.
        /// This flag is extensively used in BeaconParser.
        /// </summary>
        public static bool DebugLoggingEnabled
        {
            get
            {
                return debugLoggingEnabled;
            }

            set
            {
                debugLoggingEnabled = value;
            }
        }
        #endregion Properties

        #region Methods
        /// <summary>
        /// Gets the specified named logger.
        /// </summary>
        /// <param name="name">
        /// Name of the logger.
        /// </param>
        /// <returns>
        /// The logger reference. Multiple calls to <code>GetLogger</code> with 
        /// the same argument aren't guaranteed to return the same logger reference.
        /// </returns>
        public static ILogger GetLogger(string name)
        {
            return loggerFactory.GetLogger(name);
        }
        #endregion Methods
    }
}
