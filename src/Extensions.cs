using Dbscan;
using Stride.Core.Mathematics;
using Point = Dbscan.Point;

namespace VL.Dbscan;

public static class Extensions
{
    /// <summary>
    /// Converts a IPointData to a Vector2 for further use in VL
    /// </summary>
    /// <param name="point"></param>
    /// <returns></returns>
    public static Vector2 ToVector2(IPointData point) =>
         new Vector2((float)point.Point.X, (float)point.Point.Y);

    /// <summary>
    /// Converts Vector2 to Dbscan.Point
    /// </summary>
    /// <param name="position"></param>
    /// <returns></returns>
    public static Point ToPoint(Vector2 position) => new Point(position.X, position.Y);
}
