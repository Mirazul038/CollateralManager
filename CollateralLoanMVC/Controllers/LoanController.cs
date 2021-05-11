using CollateralLoanMVC.DAL;
using CollateralLoanMVC.Models;
using CollateralLoanMVC.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CollateralLoanMVC.Controllers
{
	public class LoanController : Controller
	{
		/// <summary>
		/// Used for communicating with the Loan Management Api.
		/// </summary>
		private readonly ILoanManagement _loanManagement;

		/// <summary>
		/// Used for communicating with the Risk Assessment Api.
		/// </summary>
		private readonly IRiskAssessment _riskAssessment;

		public LoanController(ILoanManagement loanManagement, IRiskAssessment riskAssessment)
		{
			_loanManagement = loanManagement;
			_riskAssessment = riskAssessment;
		}

		/// <summary>
		/// Used to get the view for creating a new loan instance. 
		/// </summary>
		/// <returns>view for new loan</returns>
		[HttpGet("[action]")]
		public ActionResult New()
		{
			//TODO: New action
			throw new NotImplementedException();//remove this
		}

		/// <summary>
		/// Used to get the view for viewing an individual loan in more detailed manner.
		/// </summary>
		/// <param name="loanId">Id of the loan to be viewed</param>
		/// <returns>view for viewing an individual loan</returns>
		[HttpGet("{id}")]
		public ActionResult View(int loanId)
		{
			//TODO: View action
			throw new NotImplementedException();//remove this
		}

		/// <summary>
		/// Used to get the list of loans to populate the index page.
		/// </summary>
		/// <param name="page"><see cref="Page"/> instance to get the list of loans in paginated format</param>
		/// <param name="filter"><see cref="Filter"/> instance to filter the list of loans</param>
		/// <returns></returns>
		[HttpGet("[action]")]
		public List<Loan> List([FromQuery] Page page, [FromQuery] Filter filter)
		{
			//TODO: Loans action
			throw new NotImplementedException();//remove this
		}
	}
}
