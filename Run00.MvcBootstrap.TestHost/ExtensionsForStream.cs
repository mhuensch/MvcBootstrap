using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Run00.MvcBootstrap.TestHost
{
	public static class ExtensionsForStream
	{
		public static bool Matches(this Stream original, Stream compareTo)
		{
			var originalPosition = original.Position;
			var compareToPosition = compareTo.Position;

			if (original.CanSeek)
				original.Position = 0;

			if (compareTo.CanSeek)
				compareTo.Position = 0;

			var result = original.ContentMatches(compareTo);

			if (original.CanSeek)
				original.Position = originalPosition;

			if (compareTo.CanSeek)
				compareTo.Position = compareToPosition;

			return result;
		}

		private static bool ContentMatches(this Stream original, Stream compareTo)
		{
			var originalByte = original.ReadByte();
			var compareToByte = original.ReadByte();

			if (originalByte != compareToByte)
				return false;

			if (originalByte == -1 && compareToByte == -1)
				return true;

			return ContentMatches(original, compareTo);
		}
	}
}