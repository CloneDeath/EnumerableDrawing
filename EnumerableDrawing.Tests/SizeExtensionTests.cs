using System.Drawing;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace EnumerableDrawing.Tests {
	public class UnitTest1 {
		[Fact]
		public void TheNumberOfPointsIsEqualToASizesArea() {
			var size = new Size(3, 4);
			size.GetContainingPoints().Should().HaveCount(12);
		}

		[Fact]
		public void ASingleRowOfPointsIsEnumeratedByTheWidth() {
			var size = new Size(10, 1);
			var points = size.GetContainingPoints().OrderBy(p => p.X).ToArray();
			for (var i = 0; i < 10; i++) {
				points[i].X.Should().Be(i);
				points[i].Y.Should().Be(0);
			}
		}
	}
}