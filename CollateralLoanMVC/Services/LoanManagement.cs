using CollateralLoanMVC.Models;
using CollateralLoanMVC.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace CollateralLoanMVC.Services
{
	/// <summary>
	/// Concrete implementation of <see cref="ILoanManagement"/>.
	/// </summary>
	public class LoanManagement : ILoanManagement
	{
		/// <summary>
		/// Base url for Loan Management Api, eg. https://localhost:5001. This url is specified in appsettings.json
		/// </summary>
		private readonly string _loanApiBaseUrl;

		/// <summary>
		/// Used to instantiate a new <see cref="HttpClient"/> instance rather than creating it directly. It helps in avoiding resource management 
		/// socket exhaustion.
		/// </summary>
		private readonly IHttpClientFactory _httpClientFactory;

		public LoanManagement(string loanApiBaseUrl, IHttpClientFactory httpClientFactory)
		{
			_loanApiBaseUrl = loanApiBaseUrl;
			_httpClientFactory = httpClientFactory;
		}

		public bool Delete(int loanId)
		{
			using(HttpClient client = _httpClientFactory.CreateClient())
			{
				//your code
				throw new NotImplementedException();//remove this
			}
		}

		public async Task<Loan> Get(int loanId)
		{
			using (HttpClient client = _httpClientFactory.CreateClient())
			{
				//your code
				//var client = new HttpClient();
				client.BaseAddress = new Uri(_loanApiBaseUrl);
				var l = new Loan();
				HttpResponseMessage res = await client.GetAsync($"api/loan/{loanId}");
				if (res.IsSuccessStatusCode)
				{
					var results = await res.Content.ReadAsStringAsync();
					l = System.Text.Json.JsonSerializer.Deserialize<Loan>(results, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
				}
				return l;
				//throw new NotImplementedException();//remove this
			}
						
		}

		public List<Loan> GetAll(Page page, LoanFilter filter)
		{
			using (HttpClient client = _httpClientFactory.CreateClient())
			{
				//your code
				throw new NotImplementedException();//remove this
			}
		}

		public bool Save(Loan loan)
		{
			using (HttpClient client = _httpClientFactory.CreateClient())
			{
				//your code
				client.BaseAddress = new Uri(_loanApiBaseUrl);
				StringContent content = new StringContent(JsonConvert.SerializeObject(loan), Encoding.UTF8, "application/json");
				var postTask = client.PostAsync("api/loan", content);
				postTask.Wait();
				var result = postTask.Result;
				if (result.IsSuccessStatusCode)
				{
					return true;
				}
				return false;
				//throw new NotImplementedException();//remove this
			}
			
		}
	}
}
