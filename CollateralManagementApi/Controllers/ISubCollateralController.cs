using CollateralManagementApi.DAL;
using CollateralManagementApi.DAL.DAO;
using CollateralManagementApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollateralManagementApi.Controllers
{
	public interface ISubCollateralController<T> where T : Collateral
	{
		[HttpPost("")]
		IActionResult Save([FromBody] T collateral, [FromServices] CollateralDb db);
	}
}
