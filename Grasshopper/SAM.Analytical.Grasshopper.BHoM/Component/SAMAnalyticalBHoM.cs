using Grasshopper.Kernel;
using SAM.Analytical.BHoM;
using SAM.Analytical.Grasshopper.BHoM.Properties;
using SAM.Core;
using SAM.Core.Grasshopper;
using System;
using System.Collections.Generic;

namespace SAM.Analytical.Grasshopper.BHoM
{
    public class SAMAnalyticalBHoM : GH_SAMComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("f3018f46-4706-4ea0-beb3-1fbca8b6ed47");

        /// <summary>
        /// The latest version of this component
        /// </summary>
        public override string LatestComponentVersion => "1.0.1";

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        protected override System.Drawing.Bitmap Icon => Resources.SAM_BHoM;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public SAMAnalyticalBHoM()
          : base("SAMAnalytical.BHoM", "SAMAnalytical.BHoM",
              "Convert SAM Analytical Object ie. AdjacencyCluster, Panel, Space to BHoM",
              "SAM", "BHoM")
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_InputParamManager inputParamManager)
        {
            inputParamManager.AddParameter(new GooSAMObjectParam<SAMObject>(), "_sAMAnalytical", "_sAMAnalytical", "SAM Analytical Object", GH_ParamAccess.item);
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_OutputParamManager outputParamManager)
        {
            outputParamManager.AddGenericParameter("BHoMObjects", "BHoMObjects", "BHoM Objects", GH_ParamAccess.list);
        }

        /// <summary>
        /// Solves the instance.
        /// </summary>
        /// <param name="dataAccess">The data access.</param>
        protected override void SolveInstance(IGH_DataAccess dataAccess)
        {
            SAMObject sAMObject = null;
            if (!dataAccess.GetData(0, ref sAMObject) || sAMObject == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            List<BH.oM.Base.BHoMObject> bHoMObjects = null;
            if (sAMObject is Panel)
            {
                bHoMObjects = new List<BH.oM.Base.BHoMObject>() { Analytical.BHoM.Convert.ToBHoM((Panel)sAMObject) };
            }
            else if (sAMObject is Space)
            {
                bHoMObjects = new List<BH.oM.Base.BHoMObject>() { Analytical.BHoM.Convert.ToBHoM((Space)sAMObject) };
            }
            else if(sAMObject is AdjacencyCluster)
            {
                bHoMObjects = ((AdjacencyCluster)sAMObject).ToBHoM();
            }
            else if(sAMObject is AnalyticalModel)
            {
                bHoMObjects = ((AnalyticalModel)sAMObject).ToBHoM_BHoMObjects();
            }
            else
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            dataAccess.SetDataList(0, bHoMObjects);
        }
    }
}