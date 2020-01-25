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
        public static BHG.Point ToBHoM(this SAM2.Spatial.Point3D pnt)
        {
            return new BHG.Point
            {
                X = pnt.X,
                Y = pnt.Y,
                Z = pnt.Z,
            };
        }

        public static SAM2.Spatial.Point3D ToSAM(this BHG.Point pnt)
        {
            return new SAM2.Spatial.Point3D
            {
                X = pnt.X,
                Y = pnt.Y,
                Z = pnt.Z,
            };
        }
    }
}
