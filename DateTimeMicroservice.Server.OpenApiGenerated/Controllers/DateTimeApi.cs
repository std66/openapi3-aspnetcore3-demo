/*
 * TomiSoft DateTime Test Api
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using DateTimeMicroservice.Server.OpenApiGenerated.Attributes;
using Microsoft.AspNetCore.Authorization;
using DateTimeMicroservice.Server.OpenApiGenerated.Models;

namespace DateTimeMicroservice.Server.OpenApiGenerated.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public abstract class DateTimeApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Gets the server&#39;s current date-time in UTC format</remarks>
        /// <response code="200">Represents the response of /currentTime API path</response>
        [HttpGet]
        [Route("/currentTime")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(DateTimeObject))]
        public abstract IActionResult GetUtcDateTime();
    }
}