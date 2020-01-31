namespace SAM.Analytical.BHoM
{
    public static partial class Convert
    {
        public static PanelType ToSAM(this BH.oM.Environment.Elements.PanelType panelType)
        {
            switch (panelType)
            {
                case BH.oM.Environment.Elements.PanelType.Ceiling:
                    return PanelType.Ceiling;
                case BH.oM.Environment.Elements.PanelType.CurtainWall:
                    return PanelType.CurtainWall;
                case BH.oM.Environment.Elements.PanelType.Floor:
                    return PanelType.Floor;
                case BH.oM.Environment.Elements.PanelType.FloorExposed:
                    return PanelType.FloorExposed;
                case BH.oM.Environment.Elements.PanelType.FloorInternal:
                    return PanelType.FloorInternal;
                case BH.oM.Environment.Elements.PanelType.FloorRaised:
                    return PanelType.FloorRaised;
                case BH.oM.Environment.Elements.PanelType.Roof:
                    return PanelType.Roof;
                case BH.oM.Environment.Elements.PanelType.Shade:
                    return PanelType.Shade;
                case BH.oM.Environment.Elements.PanelType.SlabOnGrade:
                    return PanelType.SlabOnGrade;
                case BH.oM.Environment.Elements.PanelType.SolarPanel:
                    return PanelType.SolarPanel;
                case BH.oM.Environment.Elements.PanelType.Undefined:
                    return PanelType.Undefined;
                case BH.oM.Environment.Elements.PanelType.UndergroundCeiling:
                    return PanelType.UndergroundCeiling;
                case BH.oM.Environment.Elements.PanelType.UndergroundSlab:
                    return PanelType.UndergroundSlab;
                case BH.oM.Environment.Elements.PanelType.UndergroundWall:
                    return PanelType.UndergroundWall;
                case BH.oM.Environment.Elements.PanelType.Wall:
                    return PanelType.Wall;
                case BH.oM.Environment.Elements.PanelType.WallExternal:
                    return PanelType.WallExternal;
                case BH.oM.Environment.Elements.PanelType.WallInternal:
                    return PanelType.WallInternal;
                default:
                    return PanelType.Undefined;
            }
        }
    }
}
