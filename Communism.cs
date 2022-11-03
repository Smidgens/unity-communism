// smidgens @ github

namespace Smidgenomics.Unity.Communism
{
	/// <summary>
	/// Communism entry
	/// </summary>
	public static class Communism
	{
		/// <summary>
		/// Run communism of given type
		/// </summary>
		/// <typeparam name="T">ICommunism</typeparam>
		public static void Run<T>
		()
		where T : struct, class, ICommunism
		{
			var c = new T();
			c.Run();
		}
	}
}