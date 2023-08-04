using FlyWeight.Application.Configurations;
using FlyWeight.Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace FlyWeight.Controllers;

[ApiController]
[Route("api/orders")]
public class OrdersController : ControllerBase
{
    [HttpPost]
    public IActionResult Post(
        OrderInputModel model
    )
    {
        return Ok(BusinessHours.GetInstance());
    }
}