using System;
using System.Net;
using System.Runtime.Serialization;
using HalClient.Net.PCL.Parser;

namespace HalClient.Net.PCL
{
	[DataContract]
	public class HalHttpRequestException : Exception
	{
		public HalHttpRequestException(HttpStatusCode statusCode, string reason, IRootResourceObject resource = null) 
			: base($"{(int)statusCode} ({reason})")
		{
			StatusCode = statusCode;
			Resource = resource;
		}

		public HttpStatusCode StatusCode { get; }
		public IRootResourceObject Resource { get; }
	}
}