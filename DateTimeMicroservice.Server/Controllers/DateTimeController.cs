using DateTimeMicroservice.Server.OpenApiGenerated.Controllers;
using DateTimeMicroservice.Server.OpenApiGenerated.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DateTimeMicroservice.Server.Controllers {
    public class DateTimeController : DateTimeApiController {
        public override IActionResult GetUtcDateTime() {
            //business logic (I know, it shouldn't be here)
            DateTime utcNow = DateTime.UtcNow;
            
            //presentation layer
            return new JsonResult(
                new DateTimeObject() {
                    DateTime = utcNow
                }
            );
        }
    }
}
