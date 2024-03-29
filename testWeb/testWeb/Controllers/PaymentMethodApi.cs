/*
 * CustomerManagement
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2.4.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;
using IO.Swagger.Security;
using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class PaymentMethodApiController : ControllerBase
    { 
        /// <summary>
        /// Updates paymentMethod of a &#39;Customer&#39; by Id
        /// </summary>
        
        /// <param name="authorization">token to be passed as a header linked to the user whose identity is requested</param>
        /// <param name="id">Identifier of the Customer</param>
        /// <param name="paymentMethodRef">PaymentMethodRef</param>
        /// <response code="200">Updated</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        /// <response code="405">Method Not allowed</response>
        /// <response code="409">Conflict</response>
        /// <response code="500">Internal Server Error</response>
        [HttpPatch]
        [Route("/customerManagement/customer/{id}/paymentMethod")]
        [ValidateModelState]
        [SwaggerOperation("PatchCustomerPaymentMethod")]
        [SwaggerResponse(statusCode: 200, type: typeof(PaymentMethodRef), description: "Updated")]
        [SwaggerResponse(statusCode: 400, type: typeof(Error), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(Error), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 403, type: typeof(Error), description: "Forbidden")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error), description: "Not Found")]
        [SwaggerResponse(statusCode: 405, type: typeof(Error), description: "Method Not allowed")]
        [SwaggerResponse(statusCode: 409, type: typeof(Error), description: "Conflict")]
        [SwaggerResponse(statusCode: 500, type: typeof(Error), description: "Internal Server Error")]
        public virtual IActionResult PatchCustomerPaymentMethod([FromHeader][Required()]string authorization, [FromRoute][Required]string id, [FromBody]PaymentMethodRef paymentMethodRef)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(PaymentMethodRef));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(Error));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Error));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(Error));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(Error));

            //TODO: Uncomment the next line to return response 405 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(405, default(Error));

            //TODO: Uncomment the next line to return response 409 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(409, default(Error));

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500, default(Error));

            string exampleJson = null;
            exampleJson = "{\n  \"name\" : \"name\",\n  \"href\" : \"href\",\n  \"id\" : \"id\"\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PaymentMethodRef>(exampleJson)
            : default(PaymentMethodRef);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
