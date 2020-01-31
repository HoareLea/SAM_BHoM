using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BHG = BH.oM.Geometry;
using SAMG = SAM.Geometry;

namespace BH.Engine.SAM
{
    public static partial class Convert
    {
        public static BHG.Polyline ToBHoM(this SAMG.Spatial.Polygon3D polygon3D)
        {
            return new BHG.Polyline
            {
                ControlPoints = polygon3D.GetPoints().Select(x => x.ToBHoM()).ToList(),
            };
        }

        public static SAMG.Spatial.Polygon3D ToSAM(this BHG.Polyline pLine)
        {
            return new SAMG.Spatial.Polygon3D(pLine.ControlPoints.Select(x => x.ToSAM()).ToList());
        }
    }
}
