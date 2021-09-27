namespace SAM.Analytical.BHoM
{
    public static partial class Convert
    {
        public static BH.oM.Environment.Elements.PanelType ToBHoM(this PanelType panelType)
        {
            switch (panelType)
            {
                case PanelType.Air:
                    return BH.oM.Environment.Elements.PanelType.Air;

                case PanelType.Ceiling:
                    return BH.oM.Environment.Elements.PanelType.Ceiling;

                case PanelType.CurtainWall:
                    return BH.oM.Environment.Elements.PanelType.CurtainWall;

                case PanelType.Floor:
                    return BH.oM.Environment.Elements.PanelType.Floor;

                case PanelType.FloorExposed:
                    return BH.oM.Environment.Elements.PanelType.FloorExposed;

                case PanelType.FloorInternal:
                    return BH.oM.Environment.Elements.PanelType.FloorInternal;

                case PanelType.FloorRaised:
                    return BH.oM.Environment.Elements.PanelType.FloorRaised;

                case PanelType.Roof:
                    return BH.oM.Environment.Elements.PanelType.Roof;

                case PanelType.Shade:
                    return BH.oM.Environment.Elements.PanelType.Shade;

                case PanelType.SlabOnGrade:
                    return BH.oM.Environment.Elements.PanelType.SlabOnGrade;

                case PanelType.SolarPanel:
                    return BH.oM.Environment.Elements.PanelType.SolarPanel;

                case PanelType.Undefined:
                    return BH.oM.Environment.Elements.PanelType.Undefined;

                case PanelType.UndergroundCeiling:
                    return BH.oM.Environment.Elements.PanelType.UndergroundCeiling;

                case PanelType.UndergroundSlab:
                    return BH.oM.Environment.Elements.PanelType.UndergroundSlab;

                case PanelType.UndergroundWall:
                    return BH.oM.Environment.Elements.PanelType.UndergroundWall;

                case PanelType.Wall:
                    return BH.oM.Environment.Elements.PanelType.Wall;

                case PanelType.WallExternal:
                    return BH.oM.Environment.Elements.PanelType.WallExternal;

                case PanelType.WallInternal:
                    return BH.oM.Environment.Elements.PanelType.WallInternal;

                default:
                    return BH.oM.Environment.Elements.PanelType.Undefined;
            }
        }
    }
}