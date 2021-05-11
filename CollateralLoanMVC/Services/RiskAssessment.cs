using CollateralLoanMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CollateralLoanMVC.Services
{
	/// <summary>
	/// Concrete implementation of <see cref="IRiskAssessment"/>.
	/// </summary>
	public class RiskAssessment : IRiskAssessment
	{

		/// <summary>
		/// Base url for Risk Assessment Api, eg. https://localhost:5001. This url is specified in appsettings.json
		/// </summary>
		private readonly string _riskApiBaseUrl;

		/// <summary>
		/// Used to instantiate a new <see cref="HttpClient"/> instance rather than creating it directly. It helps in avoiding resource management 
		/// socket exhaustion.
		/// </summary>
		private IHttpClientFactory _httpClientFactory;

		public RiskAssessment(string riskApiBaseUrl, IHttpClientFactory httpClientFactory)
		{
			_riskApiBaseUrl = riskApiBaseUrl;
			_httpClientFactory = httpClientFactory;
		}

		public Risk Get(int loanId)
		{
			using (HttpClient client = _httpClientFactory.CreateClient())
			{
				//your code
				throw new NotImplementedException();//remove this
			}
		}
	}
}
