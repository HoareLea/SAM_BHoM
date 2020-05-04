using BH.oM.Geometry;
using System.Linq;

namespace SAM.Geometry.BHoM
{
    public static partial class Convert
    {
        public static Spatial.Polygon3D ToSAM(this Polyline polyline)
        {
            return new Spatial.Polygon3D(polyline.ControlPoints.Select(x => x.ToSAM()).ToList());
        }
    }
}