using BH.Engine.Environment;

using SAM.Geometry.BHoM;
using System.Collections.Generic;

namespace SAM.Analytical.BHoM
{
    public static partial class Convert
    {
        public static BH.oM.Environment.Elements.Panel ToBHoM(this Panel panel)
        {
            PlanarBoundary3D planarBoundary3D = panel.PlanarBoundary3D;
            Geometry.Spatial.Face3D face3D = planarBoundary3D.GetFace3D();
            Geometry.Spatial.Polygon3D polygon3D = face3D.GetExternalEdge() as Geometry.Spatial.Polygon3D;

            List<BH.oM.Environment.Elements.Opening> openings = new List<BH.oM.Environment.Elements.Opening>();

            List<Aperture> apertures = panel.Apertures;
            if (apertures != null && apertures.Count > 0)
                apertures.ForEach(x => openings.Add(x.ToBHoM()));

            return new BH.oM.Environment.Elements.Panel
            {
                ExternalEdges = polygon3D.ToBHoM().ToEdges(),
                Type = panel.PanelType.ToBHoM(),
                Openings = openings,
            };
        }

        public static BH.oM.Environment.Elements.Panel ToBHoM(this Panel panel, List<string> connectedSpaces)
        {
            PlanarBoundary3D planarBoundary3D = panel.PlanarBoundary3D;
            Geometry.Spatial.Face3D face3D = planarBoundary3D.GetFace3D();
            Geometry.Spatial.Polygon3D polygon3D = face3D.GetExternalEdge() as Geometry.Spatial.Polygon3D;

            List<BH.oM.Environment.Elements.Opening> openings = new List<BH.oM.Environment.Elements.Opening>();

            List<Aperture> apertures = panel.Apertures;
            if (apertures != null && apertures.Count > 0)
                apertures.ForEach(x => openings.Add(x.ToBHoM()));

            List<string> connectedSpaces_Temp = connectedSpaces;
            if (connectedSpaces_Temp == null)
                connectedSpaces_Temp = new List<string>();

            return new BH.oM.Environment.Elements.Panel
            {
                ExternalEdges = polygon3D.ToBHoM().ToEdges(),
                Type = panel.PanelType.ToBHoM(),
                ConnectedSpaces = connectedSpaces_Temp,
                Openings = openings,
            };
        }
    }
}