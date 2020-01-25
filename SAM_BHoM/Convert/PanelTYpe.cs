using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BHE = BH.oM.Environment.Elements;
using SAM2 = SAM.Analytical;
using BHG = BH.oM.Geometry;
using SAMG = SAM.Geometry;

using BH.Engine.Environment;
using BH.Engine.Geometry;

namespace BH.Engine.SAM
{
    public static partial class Convert
    {
        public static BHE.PanelType ToBHoM(this SAM2.PanelType panelType)
        {
            switch(panelType)
            {
                case SAM2.PanelType.Ceiling:
                    return BHE.PanelType.Ceiling;
                case SAM2.PanelType.CurtainWall:
                    return BHE.PanelType.CurtainWall;
                case SAM2.PanelType.Floor:
                    return BHE.PanelType.Floor;
                case SAM2.PanelType.FloorExposed:
                    return BHE.PanelType.FloorExposed;
                case SAM2.PanelType.FloorInternal:
                    return BHE.PanelType.FloorInternal;
                case SAM2.PanelType.FloorRaised:
                    return BHE.PanelType.FloorRaised;
                case SAM2.PanelType.Roof:
                    return BHE.PanelType.Roof;
                case SAM2.PanelType.Shade:
                    return BHE.PanelType.Shade;
                case SAM2.PanelType.SlabOnGrade:
                    return BHE.PanelType.SlabOnGrade;
                case SAM2.PanelType.SolarPanel:
                    return BHE.PanelType.SolarPanel;
                case SAM2.PanelType.Undefined:
                    return BHE.PanelType.Undefined;
                case SAM2.PanelType.UndergroundCeiling:
                    return BHE.PanelType.UndergroundCeiling;
                case SAM2.PanelType.UndergroundSlab:
                    return BHE.PanelType.UndergroundSlab;
                case SAM2.PanelType.UndergroundWall:
                    return BHE.PanelType.UndergroundWall;
                case SAM2.PanelType.Wall:
                    return BHE.PanelType.Wall;
                case SAM2.PanelType.WallExternal:
                    return BHE.PanelType.WallExternal;
                case SAM2.PanelType.WallInternal:
                    return BHE.PanelType.WallInternal;
                default:
                    return BHE.PanelType.Undefined;
            }
        }

        public static SAM2.PanelType ToSAM(this BHE.PanelType panelType)
        {
            switch (panelType)
            {
                case BHE.PanelType.Ceiling:
                    return SAM2.PanelType.Ceiling;
                case BHE.PanelType.CurtainWall:
                    return SAM2.PanelType.CurtainWall;
                case BHE.PanelType.Floor:
                    return SAM2.PanelType.Floor;
                case BHE.PanelType.FloorExposed:
                    return SAM2.PanelType.FloorExposed;
                case BHE.PanelType.FloorInternal:
                    return SAM2.PanelType.FloorInternal;
                case BHE.PanelType.FloorRaised:
                    return SAM2.PanelType.FloorRaised;
                case BHE.PanelType.Roof:
                    return SAM2.PanelType.Roof;
                case BHE.PanelType.Shade:
                    return SAM2.PanelType.Shade;
                case BHE.PanelType.SlabOnGrade:
                    return SAM2.PanelType.SlabOnGrade;
                case BHE.PanelType.SolarPanel:
                    return SAM2.PanelType.SolarPanel;
                case BHE.PanelType.Undefined:
                    return SAM2.PanelType.Undefined;
                case BHE.PanelType.UndergroundCeiling:
                    return SAM2.PanelType.UndergroundCeiling;
                case BHE.PanelType.UndergroundSlab:
                    return SAM2.PanelType.UndergroundSlab;
                case BHE.PanelType.UndergroundWall:
                    return SAM2.PanelType.UndergroundWall;
                case BHE.PanelType.Wall:
                    return SAM2.PanelType.Wall;
                case BHE.PanelType.WallExternal:
                    return SAM2.PanelType.WallExternal;
                case BHE.PanelType.WallInternal:
                    return SAM2.PanelType.WallInternal;
                default:
                    return SAM2.PanelType.Undefined;
            }
        }
    }
}
