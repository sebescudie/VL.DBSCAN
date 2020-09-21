using System;
using System.Numerics;
using Stride.Core.Mathematics;

namespace DBSCAN.Utils
{
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
        public TrackablePoint(Vector2 vector) =>
            _point = new Point(vector.X, vector.Y);

        /// <summary>
        /// DBSCAN library's point
        /// </summary>
        public ref readonly Point Point => ref _point;

        /// <summary>
        /// Converts a TrackablePoint to a Vector2 for further use in VL
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public static Vector2 ToVector2(TrackablePoint point)
        {
            return new Vector2((float)point._point.X, (float)point._point.Y);
        }
    }
}