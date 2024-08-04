public class Program
{
	public static void Main(string[] args)
	{
		var assemblyToSearch = typeof(Program).Assembly;
		var manifestNames = assemblyToSearch.GetManifestResourceNames();
		foreach (var name in manifestNames)
		{
			System.Console.WriteLine(name);
		}
	}
}
