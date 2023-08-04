﻿using FlyWeight.Infrastructure.Proxies;
using Microsoft.AspNetCore.Mvc;

namespace FlyWeight.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomersController : ControllerBase
{
    [HttpGet("get-blocked-customers")]
    public IActionResult GetBlockedCustomers([FromServices] CustomerRepositoryProxy proxy)
    {
        var blockedCustomers = proxy.GetBlockedCustomers();

        if (blockedCustomers == null)
            return Unauthorized();

        return Ok(blockedCustomers);
    }
}