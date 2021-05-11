using CollateralManagementApi.DAL;
using CollateralManagementApi.DAL.DAO;
using CollateralManagementApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CollateralManagementApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CollateralController : ControllerBase
	{
		private ICollateralDao _dao;

		public CollateralController(ICollateralDao dao)
		{
			_dao = dao;
		}

		[HttpGet("")]
		public IActionResult Get([FromQuery] Page page, [FromQuery] Filter filter, [FromServices] CollateralDb db)
		{
			if (page == null || page.PageNo < 1 || page.PageSize < 1)
				return StatusCode((int)HttpStatusCode.BadRequest, new { error = "invalid page details" });

			return Ok(_dao.GetAll(db, page, filter));
		}

		[HttpGet("{id}")]
		public IActionResult GetById(int id, [FromServices] CollateralDb db)
		{
			Collateral collateral = _dao.GetById(db, id);
			if (collateral == null)
				return StatusCode((int)HttpStatusCode.NotFound, new { error = $"no entity found by id: {id}" });
			return Ok(collateral);
		}

		//(DEBUG) Used to populate the database with seed data.
		[HttpPost("[action]")]
		public IActionResult Seed([FromServices] CollateralDb db)
		{
			db.SeedData();
			return Ok();
		}
	}
}
