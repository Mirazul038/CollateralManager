using LoanManagementApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace LoanManagementApi.DAL.DAO
{
	public class CollateralDao : ICollateralDao
	{
		private IHttpClientFactory _httpClientFactory;
		private readonly Uri _collateralEndpoint;

		public CollateralDao(IHttpClientFactory httpClientFactory, Uri collateralEndpoint)
		{
			_httpClientFactory = httpClientFactory;
			_collateralEndpoint = collateralEndpoint;
		}

		public Task<HttpResponseMessage> Save(List<dynamic> collaterals)
		{
			using (HttpClient client = _httpClientFactory.CreateClient())
			{
				HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, _collateralEndpoint)
				{
					Content = new StringContent(JsonConvert.SerializeObject(collaterals))
				};
				return client.SendAsync(request);
			}
		}
	}
}
