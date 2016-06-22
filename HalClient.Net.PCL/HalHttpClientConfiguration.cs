using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace HalClient.Net.PCL
{
	public class HalHttpClientConfiguration : IHalHttpClientConfiguration
	{
		readonly HttpClient _httpClient;

		public HalHttpClientConfiguration(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public Uri BaseAddress
		{
			get { return _httpClient.BaseAddress; }
			set { _httpClient.BaseAddress = value; }
		}

		public long MaxResponseContentBufferSize
		{
			get { return _httpClient.MaxResponseContentBufferSize; }
			set { _httpClient.MaxResponseContentBufferSize = value; }
		}

		public TimeSpan Timeout
		{
			get { return _httpClient.Timeout; }
			set { _httpClient.Timeout = value; }
		}

		public HttpRequestHeaders Headers => _httpClient.DefaultRequestHeaders;
	}
}