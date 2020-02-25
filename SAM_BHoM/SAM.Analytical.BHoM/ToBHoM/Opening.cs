using BH.Engine.Environment;

using SAM.Geometry.BHoM;

namespace SAM.Analytical.BHoM
{
    public static partial class Convert
    {
        public static BH.oM.Environment.Elements.Opening ToBHoM(this Aperture aperture)
        {
            PlanarBoundary3D planarBoundary3D = aperture.GetPlanarBoundary3D();
            Geometry.Spatial.Face3D face3D = planarBoundary3D.GetFace3D();
            Geometry.Spatial.Polygon3D polygon3D = face3D.GetExternalEdge() as Geometry.Spatial.Polygon3D;

            return new BH.oM.Environment.Elements.Opening
            {
                Edges = polygon3D.ToBHoM().ToEdges(),
                Type = aperture.ApertureConstruction.ApertureType.ToBHoM()
            };
        }
    }
}
