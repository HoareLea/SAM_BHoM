using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BHE = BH.oM.Environment.Elements;
using SAMA = SAM.Analytical;
using BHG = BH.oM.Geometry;
using SAMG = SAM.Geometry;

using BH.Engine.Environment;
using BH.Engine.Geometry;

namespace BH.Engine.SAM
{
    public static partial class Convert
    {
        public static BHE.Panel ToBHoM(this SAMA.Panel panel)
        {
            SAMA.Boundary3D bounds = panel.Boundary3D;
            SAMG.Spatial.Face face = bounds.GetFace();
            SAMG.Spatial.Polygon3D pGon = face.ToClosedPlanar3D() as SAMG.Spatial.Polygon3D;

            return new BHE.Panel
            {
                ExternalEdges = pGon.ToBHoM().ToEdges(),
                Type = panel.PanelType.ToBHoM(),
            };
        }

        public static SAMA.Panel ToSAM(this BHE.Panel panel)
        {
            SAMG.Spatial.Polygon3D pGon = panel.Polyline().ToSAM();
            SAMG.Spatial.Face face = new SAMG.Spatial.Face(pGon);
            SAMA.Boundary3D bounds = new SAMA.Boundary3D(face);

            return new SAMA.Panel(null, panel.Type.ToSAM(), bounds);
        }
    }
}
