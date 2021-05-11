using CollateralManagementApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace CollateralManagementApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TestController : ControllerBase
	{
		[HttpGet("")]
		public IActionResult Index()
		{
			return Content("Running...");
		}

		[HttpPost("")]
		public IActionResult Save([FromBody] JsonElement json)
		{
			string type = json.GetProperty("type").GetString();
			Collateral collateral = null;
			if (type == "Land")
				collateral = JsonSerializer.Deserialize<Land>(json.GetRawText(), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
			else if (type == "RealEstate")
				collateral = JsonSerializer.Deserialize<RealEstate>(json.GetRawText(), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
			else
				throw new NotSupportedException();
			return Ok(collateral);
		}
	}
}
