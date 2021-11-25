using BH.oM.Environment.Elements;
using SAM.Architectural;
using System.Collections.Generic;

namespace SAM.Analytical.BHoM
{
    public static partial class Convert
    {
        public static List<BH.oM.Base.BHoMObject> ToBHoM_BHoMObjects(this BuildingModel buildingModel)
        {
            if(buildingModel == null)
            {
                return null;
            }

            List<BH.oM.Base.BHoMObject> result = new List<BH.oM.Base.BHoMObject>();

            Building building = buildingModel.ToBHoM();
            if(building != null)
            {
                result.Add(building);
            }

            List<IPartition> partitions = buildingModel.GetPartitions();
            if(partitions != null)
            {
                foreach(IPartition partition in partitions)
                {
                    BH.oM.Environment.Elements.Panel panel_BHoM = partition.ToBHoM(buildingModel);
                    if(panel_BHoM != null)
                    {
                        result.Add(panel_BHoM);
                    }
                }

                List<Level> levels =  partitions.Levels();
                if(levels != null)
                {
                    foreach(Level level in levels)
                    {
                        BH.oM.Geometry.SettingOut.Level level_BHoM = Architectural.BHoM.Convert.ToBHoM(level);
                        if(level_BHoM != null)
                        {
                            result.Add(level_BHoM);
                        }

                    }
                }
            }

            List<Space> spaces = buildingModel.GetSpaces();
            if(spaces != null)
            {
                foreach(Space space in spaces)
                {
                    BH.oM.Environment.Elements.Space space_BHoM = space.ToBHoM(buildingModel);
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