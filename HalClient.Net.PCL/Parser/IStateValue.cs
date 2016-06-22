namespace HalClient.Net.PCL.Parser
{
	public interface IStateValue
	{
		string Name { get; }
		string Value { get; }
		string Type { get; }
	}
}