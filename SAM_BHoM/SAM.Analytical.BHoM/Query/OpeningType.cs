namespace SAM.Analytical.BHoM
{
    public static partial class Query
    {
        public static BH.oM.Environment.Elements.OpeningType? OpeningType(this IOpening opening)
        {
            if(opening == null)
            {
                return null;
            }

            if(opening is Window)
            {
                return BH.oM.Environment.Elements.OpeningType.Window;
            }

            if(opening is Door)
            {
                return BH.oM.Environment.Elements.OpeningType.Door;
            }

            return null;
        }
    }
}