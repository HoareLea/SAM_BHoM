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
            Geometry.Spatial.Polygon3D polygon3D = face3D.GetExternalEdge3D() as Geometry.Spatial.Polygon3D;

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

        public static BH.oM.Environment.Elements.Panel ToBHoM(this Panel panel, AnalyticalModel analyticalModel)
        {
            if(panel == null)
            {
                return null;
            }

            BH.oM.Environment.Elements.Panel result = ToBHoM(panel, analyticalModel?.AdjacencyCluster);

            return result;
        }

        public static BH.oM.Environment.Elements.Panel ToBHoM(this Panel panel, AdjacencyCluster adjacencyCluster)
        {
            if (panel == null)
            {
                return null;
            }

            Panel panel_Temp = adjacencyCluster?.GetObject<Panel>(panel.Guid);
            if(panel_Temp == null)
            {
                panel_Temp = panel;
            }
            
            
            BH.oM.Environment.Elements.Panel result = ToBHoM(panel_Temp);

            List<Space> spaces = adjacencyCluster?.GetSpaces(panel_Temp);
            if (spaces != null)
            {
                result.ConnectedSpaces = spaces.ConvertAll(x => x.Name);
            }

            return result;
        }
    }
}