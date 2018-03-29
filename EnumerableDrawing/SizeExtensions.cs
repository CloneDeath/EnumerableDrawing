using System.Collections.Generic;
using System.Drawing;

namespace EnumerableDrawing {
	public static class SizeExtensions {
		public static IEnumerable<Point> GetContainingPoints(this Size self) {
			for (var y = 0; y < self.Height; y++)
			for (var x = 0; x < self.Width; x++) {
				yield return new Point(x, y);
			}
		}
	}
}