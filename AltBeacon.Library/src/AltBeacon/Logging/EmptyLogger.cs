// <copyright file="EmptyLogger.cs" company="Radius Networks, Inc.">
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
    /// A logger that doesn't do anything.
    /// This class can not be inherited.
    /// </summary>
    public sealed class EmptyLogger : ILogger
    {
        /// <summary>
        /// <see cref="Name"/>
        /// </summary>
        private string name;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmptyLogger"/> class.
        /// </summary>
        /// <param name="name">
        /// Identifier of the source of a log message. It usually
        /// identifies the class or activity where the log call occurs.
        /// </param>
        public EmptyLogger(string name)
        {
            this.name = name;
        }

        #region Name
        /// <summary>
        /// Gets identifier of the source of a log message. It usually
        /// identifies the class or activity where the log call occurs.
        /// </summary>
        public string Name
        { 
            get
            {
                return this.name;
            }
        }
        #endregion Error

        #region Trace
        /// <summary>
        /// Does nothing.
        /// </summary>
        /// <param name="message">
        /// The parameter is not used.
        /// </param>
        /// <param name="args">
        /// The parameter is not used.
        /// </param>
        /// <seealso cref="Verbose(String, Object[])"/>
        public void Trace(string message, params object[] args)
        {
        }

        /// <summary>
        /// Does nothing.
        /// </summary>
        /// <param name="exception">
        /// The parameter is not used.
        /// </param>
        /// <param name="message">
        /// The parameter is not used.
        /// </param>
        /// <param name="args">
        /// The parameter is not used.
        /// </param>
        /// <seealso cref="Verbose(Exception, String, Object[])"/>
        public void Trace(Exception exception, string message, params object[] args)
        {
        }
        #endregion Trace

        #region Verbose
        /// <summary>
        /// Does nothing.
        /// </summary>
        /// <param name="message">
        /// The parameter is not used.
        /// </param>
        /// <param name="args">
        /// The parameter is not used.
        /// </param>
        /// <seealso cref="Trace(String, Object[])"/>
        public void Verbose(string message, params object[] args)
        {
        }

        /// <summary>
        /// Does nothing.
        /// </summary>
        /// <param name="exception">
        /// The parameter is not used.
        /// </param>
        /// <param name="message">
        /// The parameter is not used.
        /// </param>
        /// <param name="args">
        /// The parameter is not used.
        /// </param>
        /// <seealso cref="Trace(Exception, String, Object[])"/>
        public void Verbose(Exception exception, string message, params object[] args)
        {
        }
        #endregion Verbose

        #region Debug
        /// <summary>
        /// Does nothing.
        /// </summary>
        /// <param name="message">
        /// The parameter is not used.
        /// </param>
        /// <param name="args">
        /// The parameter is not used.
        /// </param>
        public void Debug(string message, params object[] args)
        {
        }

        /// <summary>
        /// Does nothing.
        /// </summary>
        /// <param name="exception">
        /// The parameter is not used.
        /// </param>
        /// <param name="message">
        /// The parameter is not used.
        /// </param>
        /// <param name="args">
        /// The parameter is not used.
        /// </param>
        public void Debug(Exception exception, string message, params object[] args)
        {
        }
        #endregion Debug

        #region Info
        /// <summary>
        /// Does nothing.
        /// </summary>
        /// <param name="message">
        /// The parameter is not used.
        /// </param>
        /// <param name="args">
        /// The parameter is not used.
        /// </param>
        public void Info(string message, params object[] args)
        {
        }

        /// <summary>
        /// Does nothing.
        /// </summary>
        /// <param name="exception">
        /// The parameter is not used.
        /// </param>
        /// <param name="message">
        /// The parameter is not used.
        /// </param>
        /// <param name="args">
        /// The parameter is not used.
        /// </param>
        public void Info(Exception exception, string message, params object[] args)
        {
        }
        #endregion Info

        #region Warn
        /// <summary>
        /// Does nothing.
        /// </summary>
        /// <param name="message">
        /// The parameter is not used.
        /// </param>
        /// <param name="args">
        /// The parameter is not used.
        /// </param>
        public void Warn(string message, params object[] args)
        {
        }

        /// <summary>
        /// Does nothing.
        /// </summary>
        /// <param name="exception">
        /// The parameter is not used.
        /// </param>
        /// <param name="message">
        /// The parameter is not used.
        /// </param>
        /// <param name="args">
        /// The parameter is not used.
        /// </param>
        public void Warn(Exception exception, string message, params object[] args)
        {
        }
        #endregion Warn

        #region Error
        /// <summary>
        /// Does nothing.
        /// </summary>
        /// <param name="message">
        /// The parameter is not used.
        /// </param>
        /// <param name="args">
        /// The parameter is not used.
        /// </param>
        public void Error(string message, params object[] args)
        {
        }

        /// <summary>
        /// Does nothing.
        /// </summary>
        /// <param name="exception">
        /// The parameter is not used.
        /// </param>
        /// <param name="message">
        /// The parameter is not used.
        /// </param>
        /// <param name="args">
        /// The parameter is not used.
        /// </param>
        public void Error(Exception exception, string message, params object[] args)
        {
        }
        #endregion Error

        #region Fatal
        /// <summary>
        /// Does nothing.
        /// </summary>
        /// <param name="message">
        /// The parameter is not used.
        /// </param>
        /// <param name="args">
        /// The parameter is not used.
        /// </param>
        /// <seealso cref="Error(String, Object[])"/>
        public void Fatal(string message, params object[] args)
        {
        }

        /// <summary>
        /// Does nothing.
        /// </summary>
        /// <param name="exception">
        /// The parameter is not used.
        /// </param>
        /// <param name="message">
        /// The parameter is not used.
        /// </param>
        /// <param name="args">
        /// The parameter is not used.
        /// </param>
        /// <seealso cref="Error(Exception, String, Object[])"/>
        public void Fatal(Exception exception, string message, params object[] args)
        {
        }
        #endregion Fatal
    }
}
