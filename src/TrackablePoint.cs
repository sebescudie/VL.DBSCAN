using Dbscan;
using Stride.Core.Mathematics;
using Point = Dbscan.Point;

namespace VL.Dbscan;

/// <summary>
/// Class implementing IPointData to use VL's Vector2 with DBSCAN plugin
/// </summary>
public class TrackablePoint : IPointData
{
    private readonly Point _point;
    /// <summary>
    /// Creates a TrackablePoint from a Vector2 to be used with VL DBSCAN plugin
    /// </summary>
    /// <param name="vector"></param>
    public TrackablePoint(Vector2 position) =>
        _point = Extensions.ToPoint(position);

    /// <summary>
    /// DBSCAN library's point
    /// </summary>
    public Point Point => _point;
}

