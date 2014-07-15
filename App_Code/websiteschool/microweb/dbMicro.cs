using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Data.SqlClient;
using nmsADOI;

namespace nmsMicro
{
    public class clsDLMicroWeb
    {
        //--------------------------------------------------------
        clsBLado ADO = new clsBLado();
        clsPRPadoBL ADOprp;// = new clsPRPadoBL();
        clsPRPadoDL ADOprpDL;// = new clsPRPadoDL();
        clsPRPadoBL adoBL;//= new clsPRPadoBL(); 

        //--------------------------------------------------------

        public DataTable SpBindLinks(prpMicroWeb objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@loginId", objprp.UserId);
            

            ADOprp.SPName = "SpBindLinks";

            return ADO.DataTableWithProceduresAndParam(ADOprp);


        }

   
        
        //--------------------------------------------------------

        
        
        //--------------------------------------------------------
     /*   public string spTempUser(prpImagePlan objprp)
        {
            adoBL = new clsPRPadoBL();
            adoBL.ArrayPram = new SqlParameter[2];

            adoBL.ArrayPram[0] = new SqlParameter("@userId", objprp.imageId);
            adoBL.ArrayPram[1] = new SqlParameter("@tempid", objprp.imagePath);
            //adoBL.ArrayPram[4] = new SqlParameter("@imageStatus", objprp.oldPassword);

            adoBL.SPName = "spTempUser";

            return ADO.ScalarQueryWithProceduresandParam(adoBL);

        }
        public List<prpImagePlan> viewPlanImage()
        {
            ADOprpDL = new clsPRPadoDL();

            ADOprpDL.SPName = "spPlanImageView";
            ADO.ReaderWithProcedures(ADOprpDL);

            prpImagePlan objprp = new prpImagePlan();
            List<prpImagePlan> lst = new List<prpImagePlan>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new prpImagePlan();
                    objprp.imageId = ADOprpDL.Dr["imageId"].ToString();
                    objprp.imageName = ADOprpDL.Dr["imageName"].ToString();
                    objprp.imagePath = ADOprpDL.Dr["imagePath"].ToString();
                    objprp.imageFeature = ADOprpDL.Dr["imageFeature"].ToString();
                    objprp.imageStatus = ADOprpDL.Dr["imageStatus"].ToString();
                    objprp.imagePlanId = ADOprpDL.Dr["imagePlanId"].ToString();

                    lst.Add(objprp);
                }
            }
            else
            {
                objprp = new prpImagePlan();
                objprp.imageId = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;


        }
        public prpImagePlan selectImagePlanByPlanId(prpImagePlan prp)
        {
            ADOprpDL = new clsPRPadoDL();
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@planId", prp.imagePlanId);
            ADOprpDL.SPName = "spPlanImageSelectPlanId";
            ADO.ReaderWithProceduresandParam(ADOprpDL);


            prpImagePlan objprp = new prpImagePlan();
            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new prpImagePlan();
                    objprp.imageId = ADOprpDL.Dr["imageId"].ToString();
                    objprp.imageName = ADOprpDL.Dr["imageName"].ToString();
                    objprp.imagePath = ADOprpDL.Dr["imagePath"].ToString();
                    objprp.imageFeature = ADOprpDL.Dr["imageFeature"].ToString();
                    objprp.imageStatus = ADOprpDL.Dr["imageStatus"].ToString();
                    objprp.imagePlanId = ADOprpDL.Dr["imagePlanId"].ToString();
                }
            }
            else
            {
                objprp = new prpImagePlan();
                objprp.imageId = "Result Not Find";
            }
            ADO.ReaderClose(ADOprpDL);
            return objprp;
        }
        public PRPEditor SelectEditorData(PRPEditor objprp)
        {
            ADOprpDL = new clsPRPadoDL();
            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@ContentId", objprp.Id);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@schoolId", objprp.SchoolId);

            ADOprpDL.SPName = "spEditorDataSelect";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPEditor obj = new PRPEditor();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj.Id = ADOprpDL.Dr["editorId"].ToString();
                    obj.date = ADOprpDL.Dr["editorDate"].ToString();
                    obj.Page = ADOprpDL.Dr["editorForPage"].ToString();
                    obj.pagePositin = ADOprpDL.Dr["editorPagePosition"].ToString();
                    obj.content = ADOprpDL.Dr["editorContent"].ToString();

                }
            }
            ADO.ReaderClose(ADOprpDL);

            return obj;




        }
        public DataTable ViewNews()
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.SPName = "spViewNews";

            return ADO.DataTableWithProcedures(ADOprp);


        }
        //---------------------Features------
        */
        

    
    }
}
