using BH.oM.Geometry;
using System.Linq;

namespace SAM.Geometry.BHoM
{
    public static partial class Convert
    {
        public static Polyline ToBHoM(this Spatial.Polygon3D polygon3D)
        {
            return new Polyline
            {
                ControlPoints = polygon3D.GetPoints().Select(x => x.ToBHoM()).ToList(),
            };
        }
    }
}