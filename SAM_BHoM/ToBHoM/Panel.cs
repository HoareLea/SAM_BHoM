using BHE = BH.oM.Environment.Elements;
using SAMA = SAM.Analytical;
using SAMG = SAM.Geometry;

using BH.Engine.Environment;

namespace BH.Engine.SAM
{
    public static partial class Convert
    {
        public static BHE.Panel ToBHoM(this SAMA.Panel panel)
        {
            SAMA.PlanarBoundary3D bounds = panel.PlanarBoundary3D;
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
            SAMA.PlanarBoundary3D bounds = new SAMA.PlanarBoundary3D(face);

            return new SAMA.Panel(null, panel.Type.ToSAM(), bounds);
        }
    }
}
