using System;
using System.Net.Http.Headers;

namespace HalClient.Net.PCL
{
	public interface IHalHttpClientConfiguration
	{
		Uri BaseAddress { get; set; }
		long MaxResponseContentBufferSize { get; set; }
		TimeSpan Timeout { get; set; }
		HttpRequestHeaders Headers { get; }
	}
}