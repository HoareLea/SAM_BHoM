using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BHG = BH.oM.Geometry;
using SAM2 = SAM.Geometry;

namespace SAM_BHoM
{
    public static partial class Convert
    {
        public static BHG.Polyline ToBHoM(this SAM2.Spatial.Polygon3D pgon)
        {
            return new BHG.Polyline
            {
                ControlPoints = pgon.GetPoints().Select(x => x.ToBHoM()).ToList(),
            };
        }

        public static SAM2.Spatial.Polygon3D ToSAM(this BHG.Polyline pLine)
        {
            return new SAM2.Spatial.Polygon3D(pLine.ControlPoints.Select(x => x.ToSAM()).ToList());
        }
    }
}
