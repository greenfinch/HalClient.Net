namespace HalClient.Net.PCL.Parser
{
	public interface IHalJsonParser
	{
		HalJsonParseResult Parse(string json);
	}
}