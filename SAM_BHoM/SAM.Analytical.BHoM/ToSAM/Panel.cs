using BH.Engine.Environment;

namespace SAM.Analytical.BHoM
{
    public static partial class Convert
    {
        public static Panel ToSAM(this BH.oM.Environment.Elements.Panel panel)
        {
            Geometry.Spatial.Polygon3D polygon3D = Geometry.BHoM.Convert.ToSAM(panel.Polyline());
            Geometry.Spatial.Face face = new Geometry.Spatial.Face(polygon3D);
            PlanarBoundary3D planarBoundary3D = new PlanarBoundary3D(face);

            return new Panel(null, panel.Type.ToSAM(), planarBoundary3D);
        }
    }
}
