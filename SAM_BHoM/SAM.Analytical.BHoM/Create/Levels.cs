﻿using System.Collections.Generic;

namespace SAM.Analytical.BHoM
{
    public static partial class Create
    {
        public static List<BH.oM.Spatial.SettingOut.Level> Levels(this AdjacencyCluster adjacencyCluster, double tolerance = Core.Tolerance.MacroDistance)
        {
            List<Architectural.Level> levels = Architectural.Create.Levels(adjacencyCluster?.GetPanels(), tolerance);
            if (levels == null)
                return null;

            List<BH.oM.Spatial.SettingOut.Level> result = new List<BH.oM.Spatial.SettingOut.Level>();

            foreach (Architectural.Level level in levels)
            {
                BH.oM.Spatial.SettingOut.Level level_BHoM = Architectural.BHoM.Convert.ToBHoM(level);
                if (level_BHoM != null)
                    result.Add(level_BHoM);
            }

            return result;
        }

        public static List<BH.oM.Spatial.SettingOut.Level> Levels(this AnalyticalModel analyticalModel, double tolerance = Core.Tolerance.MacroDistance)
        {
            return Levels(analyticalModel?.AdjacencyCluster, tolerance);
        }
    }
}