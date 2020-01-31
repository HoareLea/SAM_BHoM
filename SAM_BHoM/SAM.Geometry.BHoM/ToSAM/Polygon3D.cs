using System.Linq;

using BH.oM.Geometry;


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
