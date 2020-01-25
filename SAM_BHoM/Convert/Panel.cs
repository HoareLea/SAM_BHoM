using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BHE = BH.oM.Environment.Elements;
using SAM2 = SAM.Analytical;
using BHG = BH.oM.Geometry;
using SAMG = SAM.Geometry;

using BH.Engine.Environment;
using BH.Engine.Geometry;

namespace SAM_BHoM
{
    public static partial class Convert
    {
        public static BHE.Panel ToBHoM(this SAM2.Panel panel)
        {
            SAM2.Boundary3D bounds = panel.Boundary3D;
            SAMG.Spatial.Face face = bounds.GetFace();
            SAMG.Spatial.Polygon3D pGon = face.ToClosedPlanar3D() as SAMG.Spatial.Polygon3D;

            return new BHE.Panel
            {
                ExternalEdges = pGon.ToBHoM().ToEdges(),
                Type = panel.PanelType.ToBHoM(),
            };
        }

        public static SAM2.Panel ToSAM(this BHE.Panel panel)
        {
            SAMG.Spatial.Polygon3D pGon = panel.Polyline().ToSAM();
            SAMG.Spatial.Face face = new SAMG.Spatial.Face(pGon);
            SAM2.Boundary3D bounds = new SAM2.Boundary3D(face);

            return new SAM2.Panel(null, panel.Type.ToSAM(), bounds);
        }
    }
}
