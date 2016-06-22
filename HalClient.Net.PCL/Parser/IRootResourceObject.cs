using System;

namespace HalClient.Net.PCL.Parser
{
	public interface IRootResourceObject : IResourceObject
	{
		Uri GetDocumentationUri(IHaveLinkRelation link);
	}
}