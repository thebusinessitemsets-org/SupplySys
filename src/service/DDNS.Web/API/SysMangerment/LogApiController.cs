﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDNS.Web.API.SysMangerment
{
    [Route("api")]
    [ApiController]
    public class LogApiController : ControllerBase
    {
        [Route("GetLog")]
        [HttpGet]
        public String Get()
        {
            return "get";
        }
    }
}