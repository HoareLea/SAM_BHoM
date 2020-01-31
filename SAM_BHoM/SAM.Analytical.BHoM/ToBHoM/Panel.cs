using BH.Engine.Environment;

using SAM.Geometry.BHoM;

namespace SAM.Analytical.BHoM
{
    public static partial class Convert
    {
        public static BH.oM.Environment.Elements.Panel ToBHoM(this Panel panel)
        {
            PlanarBoundary3D planarBoundary3D = panel.PlanarBoundary3D;
            Geometry.Spatial.Face face = planarBoundary3D.GetFace();
            Geometry.Spatial.Polygon3D polygon3D = face.ToClosedPlanar3D() as Geometry.Spatial.Polygon3D;

            return new BH.oM.Environment.Elements.Panel
            {
                ExternalEdges = polygon3D.ToBHoM().ToEdges(),
                Type = panel.PanelType.ToBHoM(),
            };
        }
    }
}
