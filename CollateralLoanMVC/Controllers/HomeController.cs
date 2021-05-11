using CollateralLoanMVC.Models;
using CollateralLoanMVC.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CollateralLoanMVC.Controllers
{
	public class HomeController : Controller
	{
		/// <summary>
		/// Used for communicating with the Loan Management Api.
		/// </summary>
		private readonly ILoanManagement _loanManagement;

		/// <summary>
		/// Used for communicating with the Risk Assessment Api.
		/// </summary>
		private readonly IRiskAssessment _riskAssessment;

		public HomeController(ILoanManagement loanManagement, IRiskAssessment riskAssessment)
		{
			_loanManagement = loanManagement;
			_riskAssessment = riskAssessment;
		}

		//add actions
	}
}
