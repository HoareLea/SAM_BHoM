using BH.oM.Environment.Elements;
using SAM.Architectural;
using System.Collections.Generic;

namespace SAM.Analytical.BHoM
{
    public static partial class Convert
    {
        public static List<BH.oM.Base.BHoMObject> ToBHoM_BHoMObjects(this AnalyticalModel analyticalModel)
        {
            if(analyticalModel == null)
            {
                return null;
            }

            List<BH.oM.Base.BHoMObject> result = new List<BH.oM.Base.BHoMObject>();

            Building building = analyticalModel.ToBHoM();
            if(building != null)
            {
                result.Add(building);
            }

            List<Panel> panels = analyticalModel.GetPanels();
            if(panels != null)
            {
                foreach(Panel panel in panels)
                {
                    BH.oM.Environment.Elements.Panel panel_BHoM = panel.ToBHoM(analyticalModel);
                    if(panel_BHoM != null)
                    {
                        result.Add(panel_BHoM);
                    }
                }

                List<Level> levels =  panels.Levels();
                if(levels != null)
                {
                    foreach(Level level in levels)
                    {
                        BH.oM.Spatial.SettingOut.Level level_BHoM = Architectural.BHoM.Convert.ToBHoM(level);
                        if(level_BHoM != null)
                        {
                            result.Add(level_BHoM);
                        }

                    }
                }
            }

            List<Space> spaces = analyticalModel.GetSpaces();
            if(spaces != null)
            {
                foreach(Space space in spaces)
                {
                    BH.oM.Environment.Elements.Space space_BHoM = space.ToBHoM(analyticalModel);
                    if (space_BHoM != null)
                    {
                        result.Add(space_BHoM);
                    }
                }
            }

            return result;
        }

        public static List<BH.oM.Base.BHoMObject> ToBHoM(this AdjacencyCluster adjacencyCluster)
        {
            if (adjacencyCluster == null)
            {
                return null;
            }

            List<BH.oM.Base.BHoMObject> result = new List<BH.oM.Base.BHoMObject>();

            List<Panel> panels = adjacencyCluster.GetPanels();
            if (panels != null)
            {
                foreach (Panel panel in panels)
                {
                    BH.oM.Environment.Elements.Panel panel_BHoM = panel.ToBHoM(adjacencyCluster);
                    if (panel_BHoM != null)
                    {
                        result.Add(panel_BHoM);
                    }
                }

                List<Level> levels = panels.Levels();
                if (levels != null)
                {
                    foreach (Level level in levels)
                    {
                        BH.oM.Spatial.SettingOut.Level level_BHoM = Architectural.BHoM.Convert.ToBHoM(level);
                        if (level_BHoM != null)
                        {
                            result.Add(level_BHoM);
                        }

                    }
                }
            }

            List<Space> spaces = adjacencyCluster.GetSpaces();
            if (spaces != null)
            {
                foreach (Space space in spaces)
                {
                    BH.oM.Environment.Elements.Space space_BHoM = space.ToBHoM(adjacencyCluster);
                    if (space_BHoM != null)
                    {
                        result.Add(space_BHoM);
                    }
                }
            }

            return result;
        }
    }
}