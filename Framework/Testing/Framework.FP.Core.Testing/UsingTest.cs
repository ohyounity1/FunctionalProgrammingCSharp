using System.IO;
using System.Text;
using Xunit;

namespace Framework.FP.Core.Testing
{
	using static Framework.FP.Core.Using.FP;

	public class UsingTest
	{
		[Fact]
		public void Test()
		{
			var memoryStream = new MemoryStream();
			var result = Using(new StreamWriter(memoryStream, Encoding.Default, -1, true),
					(stream) =>
					{
						stream.WriteLine("Hello, xUnit!");
						stream.Flush();
						return true;
					});

			memoryStream.Position = 0;

			Assert.True(result);
			var buffer = new byte[memoryStream.Length];

			memoryStream.Read(buffer, 0, (int)memoryStream.Length);

			var asString = Encoding.Default.GetString(buffer).Trim();

			Assert.Equal("Hello, xUnit!", asString);
		}
	}
}
