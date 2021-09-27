using BH.Engine.Environment;

using SAM.Geometry.BHoM;
using System.Collections.Generic;

namespace SAM.Analytical.BHoM
{
    public static partial class Convert
    {
        public static List<BH.oM.Environment.Elements.Panel> ToBHoM_Panels(this AdjacencyCluster adjacencyCluster)
        {
            List<Panel> panels = adjacencyCluster?.GetPanels();
            if (panels == null)
                return null;

            List<BH.oM.Environment.Elements.Panel> result = new List<BH.oM.Environment.Elements.Panel>();
            foreach (Panel panel in panels)
            {
                List<string> connectedSpaces = new List<string>();

                List<Space> spaces = adjacencyCluster.GetRelatedObjects<Space>(panel);
                if (spaces != null)
                    foreach (Space space in spaces)
                        connectedSpaces.Add(space.Name);

                BH.oM.Environment.Elements.Panel panel_BHoM = ToBHoM(panel, adjacencyCluster);
                if (panel_BHoM != null)
                    result.Add(panel_BHoM);
            }

            return result;
        }
    }
}