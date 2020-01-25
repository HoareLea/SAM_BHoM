using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BHE = BH.oM.Environment.Elements;
using SAMA = SAM.Analytical;
using BHG = BH.oM.Geometry;
using SAMG = SAM.Geometry;

using BH.Engine.Environment;
using BH.Engine.Geometry;

namespace BH.Engine.SAM
{
    public static partial class Convert
    {
        public static BHE.PanelType ToBHoM(this SAMA.PanelType panelType)
        {
            switch(panelType)
            {
                case SAMA.PanelType.Ceiling:
                    return BHE.PanelType.Ceiling;
                case SAMA.PanelType.CurtainWall:
                    return BHE.PanelType.CurtainWall;
                case SAMA.PanelType.Floor:
                    return BHE.PanelType.Floor;
                case SAMA.PanelType.FloorExposed:
                    return BHE.PanelType.FloorExposed;
                case SAMA.PanelType.FloorInternal:
                    return BHE.PanelType.FloorInternal;
                case SAMA.PanelType.FloorRaised:
                    return BHE.PanelType.FloorRaised;
                case SAMA.PanelType.Roof:
                    return BHE.PanelType.Roof;
                case SAMA.PanelType.Shade:
                    return BHE.PanelType.Shade;
                case SAMA.PanelType.SlabOnGrade:
                    return BHE.PanelType.SlabOnGrade;
                case SAMA.PanelType.SolarPanel:
                    return BHE.PanelType.SolarPanel;
                case SAMA.PanelType.Undefined:
                    return BHE.PanelType.Undefined;
                case SAMA.PanelType.UndergroundCeiling:
                    return BHE.PanelType.UndergroundCeiling;
                case SAMA.PanelType.UndergroundSlab:
                    return BHE.PanelType.UndergroundSlab;
                case SAMA.PanelType.UndergroundWall:
                    return BHE.PanelType.UndergroundWall;
                case SAMA.PanelType.Wall:
                    return BHE.PanelType.Wall;
                case SAMA.PanelType.WallExternal:
                    return BHE.PanelType.WallExternal;
                case SAMA.PanelType.WallInternal:
                    return BHE.PanelType.WallInternal;
                default:
                    return BHE.PanelType.Undefined;
            }
        }

        public static SAMA.PanelType ToSAM(this BHE.PanelType panelType)
        {
            switch (panelType)
            {
                case BHE.PanelType.Ceiling:
                    return SAMA.PanelType.Ceiling;
                case BHE.PanelType.CurtainWall:
                    return SAMA.PanelType.CurtainWall;
                case BHE.PanelType.Floor:
                    return SAMA.PanelType.Floor;
                case BHE.PanelType.FloorExposed:
                    return SAMA.PanelType.FloorExposed;
                case BHE.PanelType.FloorInternal:
                    return SAMA.PanelType.FloorInternal;
                case BHE.PanelType.FloorRaised:
                    return SAMA.PanelType.FloorRaised;
                case BHE.PanelType.Roof:
                    return SAMA.PanelType.Roof;
                case BHE.PanelType.Shade:
                    return SAMA.PanelType.Shade;
                case BHE.PanelType.SlabOnGrade:
                    return SAMA.PanelType.SlabOnGrade;
                case BHE.PanelType.SolarPanel:
                    return SAMA.PanelType.SolarPanel;
                case BHE.PanelType.Undefined:
                    return SAMA.PanelType.Undefined;
                case BHE.PanelType.UndergroundCeiling:
                    return SAMA.PanelType.UndergroundCeiling;
                case BHE.PanelType.UndergroundSlab:
                    return SAMA.PanelType.UndergroundSlab;
                case BHE.PanelType.UndergroundWall:
                    return SAMA.PanelType.UndergroundWall;
                case BHE.PanelType.Wall:
                    return SAMA.PanelType.Wall;
                case BHE.PanelType.WallExternal:
                    return SAMA.PanelType.WallExternal;
                case BHE.PanelType.WallInternal:
                    return SAMA.PanelType.WallInternal;
                default:
                    return SAMA.PanelType.Undefined;
            }
        }
    }
}
