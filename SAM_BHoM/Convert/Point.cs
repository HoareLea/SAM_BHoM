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
        public static BHG.Point ToBHoM(this SAMG.Spatial.Point3D pnt)
        {
            return new BHG.Point
            {
                X = pnt.X,
                Y = pnt.Y,
                Z = pnt.Z,
            };
        }

        public static SAMG.Spatial.Point3D ToSAM(this BHG.Point pnt)
        {
            return new SAMG.Spatial.Point3D
            {
                X = pnt.X,
                Y = pnt.Y,
                Z = pnt.Z,
            };
        }
    }
}
