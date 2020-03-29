/* 
 * TomiSoft DateTime Test Api
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using DateTimeMicroservice.Client.OpenApiGenerated.Client;
using DateTimeMicroservice.Client.OpenApiGenerated.Model;

namespace DateTimeMicroservice.Client.OpenApiGenerated.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDateTimeApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets the server&#39;s current date-time in UTC format
        /// </remarks>
        /// <exception cref="DateTimeMicroservice.Client.OpenApiGenerated.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>DateTimeObject</returns>
        DateTimeObject GetUtcDateTime ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets the server&#39;s current date-time in UTC format
        /// </remarks>
        /// <exception cref="DateTimeMicroservice.Client.OpenApiGenerated.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of DateTimeObject</returns>
        ApiResponse<DateTimeObject> GetUtcDateTimeWithHttpInfo ();
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDateTimeApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets the server&#39;s current date-time in UTC format
        /// </remarks>
        /// <exception cref="DateTimeMicroservice.Client.OpenApiGenerated.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of DateTimeObject</returns>
        System.Threading.Tasks.Task<DateTimeObject> GetUtcDateTimeAsync ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets the server&#39;s current date-time in UTC format
        /// </remarks>
        /// <exception cref="DateTimeMicroservice.Client.OpenApiGenerated.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (DateTimeObject)</returns>
        System.Threading.Tasks.Task<ApiResponse<DateTimeObject>> GetUtcDateTimeAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDateTimeApi : IDateTimeApiSync, IDateTimeApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DateTimeApi : IDateTimeApi
    {
        private DateTimeMicroservice.Client.OpenApiGenerated.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DateTimeApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DateTimeApi(String basePath)
        {
            this.Configuration = DateTimeMicroservice.Client.OpenApiGenerated.Client.Configuration.MergeConfigurations(
                DateTimeMicroservice.Client.OpenApiGenerated.Client.GlobalConfiguration.Instance,
                new DateTimeMicroservice.Client.OpenApiGenerated.Client.Configuration { BasePath = basePath }
            );
            this.Client = new DateTimeMicroservice.Client.OpenApiGenerated.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new DateTimeMicroservice.Client.OpenApiGenerated.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = DateTimeMicroservice.Client.OpenApiGenerated.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DateTimeApi(DateTimeMicroservice.Client.OpenApiGenerated.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = DateTimeMicroservice.Client.OpenApiGenerated.Client.Configuration.MergeConfigurations(
                DateTimeMicroservice.Client.OpenApiGenerated.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new DateTimeMicroservice.Client.OpenApiGenerated.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new DateTimeMicroservice.Client.OpenApiGenerated.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = DateTimeMicroservice.Client.OpenApiGenerated.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public DateTimeApi(DateTimeMicroservice.Client.OpenApiGenerated.Client.ISynchronousClient client,DateTimeMicroservice.Client.OpenApiGenerated.Client.IAsynchronousClient asyncClient, DateTimeMicroservice.Client.OpenApiGenerated.Client.IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = DateTimeMicroservice.Client.OpenApiGenerated.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public DateTimeMicroservice.Client.OpenApiGenerated.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public DateTimeMicroservice.Client.OpenApiGenerated.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public DateTimeMicroservice.Client.OpenApiGenerated.Client.IReadableConfiguration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public DateTimeMicroservice.Client.OpenApiGenerated.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        ///  Gets the server&#39;s current date-time in UTC format
        /// </summary>
        /// <exception cref="DateTimeMicroservice.Client.OpenApiGenerated.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>DateTimeObject</returns>
        public DateTimeObject GetUtcDateTime ()
        {
             DateTimeMicroservice.Client.OpenApiGenerated.Client.ApiResponse<DateTimeObject> localVarResponse = GetUtcDateTimeWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Gets the server&#39;s current date-time in UTC format
        /// </summary>
        /// <exception cref="DateTimeMicroservice.Client.OpenApiGenerated.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of DateTimeObject</returns>
        public DateTimeMicroservice.Client.OpenApiGenerated.Client.ApiResponse< DateTimeObject > GetUtcDateTimeWithHttpInfo ()
        {
            DateTimeMicroservice.Client.OpenApiGenerated.Client.RequestOptions localVarRequestOptions = new DateTimeMicroservice.Client.OpenApiGenerated.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = DateTimeMicroservice.Client.OpenApiGenerated.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = DateTimeMicroservice.Client.OpenApiGenerated.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request
            var localVarResponse = this.Client.Get< DateTimeObject >("/currentTime", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetUtcDateTime", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Gets the server&#39;s current date-time in UTC format
        /// </summary>
        /// <exception cref="DateTimeMicroservice.Client.OpenApiGenerated.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of DateTimeObject</returns>
        public async System.Threading.Tasks.Task<DateTimeObject> GetUtcDateTimeAsync ()
        {
             DateTimeMicroservice.Client.OpenApiGenerated.Client.ApiResponse<DateTimeObject> localVarResponse = await GetUtcDateTimeAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Gets the server&#39;s current date-time in UTC format
        /// </summary>
        /// <exception cref="DateTimeMicroservice.Client.OpenApiGenerated.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (DateTimeObject)</returns>
        public async System.Threading.Tasks.Task<DateTimeMicroservice.Client.OpenApiGenerated.Client.ApiResponse<DateTimeObject>> GetUtcDateTimeAsyncWithHttpInfo ()
        {

            DateTimeMicroservice.Client.OpenApiGenerated.Client.RequestOptions localVarRequestOptions = new DateTimeMicroservice.Client.OpenApiGenerated.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<DateTimeObject>("/currentTime", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetUtcDateTime", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
