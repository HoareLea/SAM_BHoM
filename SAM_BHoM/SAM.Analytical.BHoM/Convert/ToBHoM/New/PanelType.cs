namespace SAM.Analytical.BHoM
{
    public static partial class Convert
    {
        public static BH.oM.Environment.Elements.PanelType ToBHoM(this PartitionAnalyticalType partitionAnalyticalType)
        {
            switch (partitionAnalyticalType)
            {
                case PartitionAnalyticalType.Air:
                    return BH.oM.Environment.Elements.PanelType.Air;

                case PartitionAnalyticalType.CurtainWall:
                    return BH.oM.Environment.Elements.PanelType.CurtainWall;

                case PartitionAnalyticalType.ExternalFloor:
                    return BH.oM.Environment.Elements.PanelType.FloorExposed;

                case PartitionAnalyticalType.InternalFloor:
                    return BH.oM.Environment.Elements.PanelType.FloorInternal;

                case PartitionAnalyticalType.Roof:
                    return BH.oM.Environment.Elements.PanelType.Roof;

                case PartitionAnalyticalType.Shade:
                    return BH.oM.Environment.Elements.PanelType.Shade;

                case PartitionAnalyticalType.OnGradeFloor:
                    return BH.oM.Environment.Elements.PanelType.SlabOnGrade;

                case PartitionAnalyticalType.Undefined:
                    return BH.oM.Environment.Elements.PanelType.Undefined;

                case PartitionAnalyticalType.UndergroundCeiling:
                    return BH.oM.Environment.Elements.PanelType.UndergroundCeiling;

                case PartitionAnalyticalType.UndergroundFloor:
                    return BH.oM.Environment.Elements.PanelType.UndergroundSlab;

                case PartitionAnalyticalType.UndergroundWall:
                    return BH.oM.Environment.Elements.PanelType.UndergroundWall;

                case PartitionAnalyticalType.ExternalWall:
                    return BH.oM.Environment.Elements.PanelType.WallExternal;

                case PartitionAnalyticalType.InternalWall:
                    return BH.oM.Environment.Elements.PanelType.WallInternal;

                default:
                    return BH.oM.Environment.Elements.PanelType.Undefined;
            }
        }
    }
}