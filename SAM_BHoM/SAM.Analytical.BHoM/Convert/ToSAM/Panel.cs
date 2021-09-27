using BH.Engine.Environment;

namespace SAM.Analytical.BHoM
{
    public static partial class Convert
    {
        public static Panel ToSAM(this BH.oM.Environment.Elements.Panel panel)
        {
            Geometry.Spatial.Polygon3D polygon3D = Geometry.BHoM.Convert.ToSAM(panel.Polyline());
            Geometry.Spatial.Face3D face3D = new Geometry.Spatial.Face3D(polygon3D);
            //PlanarBoundary3D planarBoundary3D = new PlanarBoundary3D(face3D);

            return Analytical.Create.Panel(null, panel.Type.ToSAM(), face3D);
        }
    }
}