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

namespace nmsEditor
{
    public class clsMicroWeb
    {

    }
    public class clsDLEditor
    {
        //--------------------------------------------------------
        clsBLado ADO = new clsBLado();
        clsPRPadoBL ADOprp;// = new clsPRPadoBL();
        clsPRPadoDL ADOprpDL;// = new clsPRPadoDL();
        clsPRPadoBL adoBL;//= new clsPRPadoBL(); 
        //--------------------------------------------------------


        public DataTable spSelectTemplateById(prpImagePlan objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@loginId", objprp.userId);
            

            ADOprp.SPName = "spSelectTemplateById";
            return ADO.DataTableWithProceduresAndParam(ADOprp);

        }

        public string userLayout(prpImagePlan objprp)
        {
            adoBL = new clsPRPadoBL();
            adoBL.ArrayPram = new SqlParameter[2];

            adoBL.ArrayPram[0] = new SqlParameter("@userId", objprp.userId);
            adoBL.ArrayPram[1] = new SqlParameter("@linkid", objprp.linkid);
            adoBL.SPName = "userLayout_sal";

            return ADO.ScalarQueryWithProceduresandParam(adoBL);

        }

        
        public string spTempLayout(prpImagePlan objprp)
        {
            adoBL = new clsPRPadoBL();
            adoBL.ArrayPram = new SqlParameter[3];

            adoBL.ArrayPram[0] = new SqlParameter("@userId", objprp.userId);
            adoBL.ArrayPram[1] = new SqlParameter("@linkid", objprp.linkid);
            adoBL.ArrayPram[2] = new SqlParameter("@layoutID", objprp.layout);
            //adoBL.ArrayPram[4] = new SqlParameter("@imageStatus", objprp.oldPassword);

            adoBL.SPName = "spTempLayout";

            return ADO.ScalarQueryWithProceduresandParam(adoBL);


        }




        public string spTempUser(prpImagePlan objprp)
        {
            adoBL = new clsPRPadoBL();
            adoBL.ArrayPram = new SqlParameter[2];

            adoBL.ArrayPram[0] = new SqlParameter("@userId", objprp.imageId);
            adoBL.ArrayPram[1] = new SqlParameter("@tempid", objprp.imagePath);
            //adoBL.ArrayPram[4] = new SqlParameter("@imageStatus", objprp.oldPassword);

            adoBL.SPName = "spTempUser";

            return ADO.ScalarQueryWithProceduresandParam(adoBL);

        }

        public string userTempate(prpImagePlan objprp)
        {
            adoBL = new clsPRPadoBL();
            adoBL.ArrayPram = new SqlParameter[1];

            adoBL.ArrayPram[0] = new SqlParameter("@userid", objprp.imageId);
          
            //adoBL.ArrayPram[4] = new SqlParameter("@imageStatus", objprp.oldPassword);

            adoBL.SPName = "userTempate";

            return ADO.ScalarQueryWithProceduresandParam(adoBL);

        }


        public string InsertPlanImage(prpImagePlan objprp)
        {
            adoBL = new clsPRPadoBL();
            adoBL.ArrayPram = new SqlParameter[4];

            adoBL.ArrayPram[0] = new SqlParameter("@imageName", objprp.imageName);
            adoBL.ArrayPram[1] = new SqlParameter("@imagePath", objprp.imagePath);
            adoBL.ArrayPram[2] = new SqlParameter("@imageFeature", objprp.imageFeature);
            adoBL.ArrayPram[3] = new SqlParameter("@imagePlanId", objprp.imagePlanId);
            //adoBL.ArrayPram[4] = new SqlParameter("@imageStatus", objprp.oldPassword);

            adoBL.SPName = "spInsertPlanImage";

            return ADO.ScalarQueryWithProceduresandParam(adoBL);

        }

        public string UpdatePlanImage(prpImagePlan objprp)
        {
            adoBL = new clsPRPadoBL();
            adoBL.ArrayPram = new SqlParameter[5];

            adoBL.ArrayPram[0] = new SqlParameter("@imageName", objprp.imageName);
            adoBL.ArrayPram[1] = new SqlParameter("@imagePath", objprp.imagePath);
            adoBL.ArrayPram[2] = new SqlParameter("@imageFeature", objprp.imageFeature);
            adoBL.ArrayPram[3] = new SqlParameter("@imagePlanId", objprp.imagePlanId);
            // adoBL.ArrayPram[4] = new SqlParameter("@imageStatus", objprp.imageStatus);
            adoBL.ArrayPram[4] = new SqlParameter("@imageId", objprp.imageId);

            adoBL.SPName = "spUpdatePlanImage";

            return ADO.ScalarQueryWithProceduresandParam(adoBL);

        }

        public string DeletePlanImage(prpImagePlan objprp)
        {
            adoBL = new clsPRPadoBL();
            adoBL.ArrayPram = new SqlParameter[1];

            adoBL.ArrayPram[0] = new SqlParameter("@imageId", objprp.imageId);

            adoBL.SPName = "tblPlanImageDelete";

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

        public prpImagePlan selectImagePlanByImageId(prpImagePlan prp)
        {
            ADOprpDL = new clsPRPadoDL();
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@imageId", prp.imageId);
            ADOprpDL.SPName = "spPlanImageSelectImageId";
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

        public prpImagePlan selectImagePlanByPlanIdForFront(prpImagePlan prp)
        {
            ADOprpDL = new clsPRPadoDL();
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@planId", prp.imagePlanId);
            ADOprpDL.SPName = "spPlanImageSelectPlanIdForFront";
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


        public string InsertEditorData(PRPEditor objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[4];
            ADOprp.ArrayPram[0] = new SqlParameter("@forPage", objprp.Page);
            ADOprp.ArrayPram[1] = new SqlParameter("@forPagePosition", objprp.pagePositin);
            ADOprp.ArrayPram[2] = new SqlParameter("@contentData", objprp.content);
            ADOprp.ArrayPram[3] = new SqlParameter("@SchoolId", objprp.SchoolId);

            ADOprp.SPName = "spEditorDataInsert";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }

        public string UpdateEditorData(PRPEditor objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[5];
            ADOprp.ArrayPram[0] = new SqlParameter("@forPage", objprp.Page);
            ADOprp.ArrayPram[1] = new SqlParameter("@forPagePosition", objprp.pagePositin);
            ADOprp.ArrayPram[2] = new SqlParameter("@contentData", objprp.content);
            ADOprp.ArrayPram[3] = new SqlParameter("@ContentId", objprp.Id);
            ADOprp.ArrayPram[4] = new SqlParameter("@schoolId", objprp.SchoolId);

            ADOprp.SPName = "spEditorDataUpdate";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }


        public string DeleteEditorData(PRPEditor objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@ContentId", objprp.Id);
            ADOprp.SPName = "spEditorDataDelete";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

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


        public List<PRPEditor> viewEditorData()
        {
            ADOprpDL = new clsPRPadoDL();
            ADOprpDL.SPName = "spEditorDataView";

            ADO.ReaderWithProcedures(ADOprpDL);

            PRPEditor objprp;
            List<PRPEditor> lst = new List<PRPEditor>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPEditor(); 
                    objprp.Id = ADOprpDL.Dr["editorId"].ToString();
                    objprp.date = ADOprpDL.Dr["editorDate"].ToString();
                    objprp.Page = ADOprpDL.Dr["editorForPage"].ToString();
                    objprp.pagePositin = ADOprpDL.Dr["editorPagePosition"].ToString();
                    objprp.content = ADOprpDL.Dr["editorContent"].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPEditor();
                objprp.Id = "Result Not Find";
                lst.Add(objprp);
            }
            ADOprpDL.Dr.Close();
            ADOprpDL.Con.Close();
            
            //ADO.ReaderClose(ADOprpDL);
            return lst;

        }


        public string addedMobileNo(PRPEditor objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[2];
            ADOprp.ArrayPram[0] = new SqlParameter("@no1", objprp.Id);
            ADOprp.ArrayPram[1] = new SqlParameter("@mob", objprp.mobileNo2);
            ADOprp.SPName = "spAddMobileNO";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }

        public string selectMobileNo()
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.SPName = "spSelectMobileNo";
           return ADO.ScalarQueryWithProcedures(ADOprp);

        }

        public string CheckLogin(PRPEditor objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[2];

            ADOprp.ArrayPram[0] = new SqlParameter("@UserName", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@Password", objprp.password);


            ADOprp.SPName = "spLogin";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }

        public string UpdatePassword(PRPEditor objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[3];

            ADOprp.ArrayPram[0] = new SqlParameter("@loginUserId", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@loginPassword", objprp.password);
            ADOprp.ArrayPram[2] = new SqlParameter("@oldpassword", objprp.oldPassword);



            ADOprp.SPName = "spUpdatePassword";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }


        public string InsertNews(PRPEditor objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[2];
            ADOprp.ArrayPram[0] = new SqlParameter("@newsTitle", objprp.newsTitle);
            ADOprp.ArrayPram[1] = new SqlParameter("@newsDescription", objprp.newsDescription);

            ADOprp.SPName = "spAddNews";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }

        public string UpdateNews(PRPEditor objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[3];
            ADOprp.ArrayPram[0] = new SqlParameter("@newsTitle", objprp.newsTitle);
            ADOprp.ArrayPram[1] = new SqlParameter("@newsDescription", objprp.newsDescription);
            ADOprp.ArrayPram[2] = new SqlParameter("@newsId", objprp.newsId);

            ADOprp.SPName = "spUpdateNews";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }

        public string DeleteNews(PRPEditor objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@newsID", objprp.newsId);

            ADOprp.SPName = "spDeteleNews";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }

        public PRPEditor SelectNews(PRPEditor objprp)
        {
            ADOprpDL = new clsPRPadoDL();
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@newsId", objprp.newsId);
            ADOprpDL.SPName = "spSelectNews";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPEditor obj = new PRPEditor(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj.newsId = ADOprpDL.Dr["newsId"].ToString();
                    obj.newsTitle = ADOprpDL.Dr["newsTitle"].ToString();
                    obj.newsDescription = ADOprpDL.Dr["newsDescription"].ToString();
                    obj.newsDate = ADOprpDL.Dr["newsAddDate"].ToString();

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

        public DataTable viewFeedback(PRPEditor objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[2];
            ADOprp.ArrayPram[0] = new SqlParameter("@pageIndex", objprp.pageIndex);
            ADOprp.ArrayPram[1] = new SqlParameter("@pageSize", objprp.pageSize);

            ADOprp.SPName = "spDisplay";

            return ADO.DataTableWithProceduresAndParam(ADOprp);


        }


        public List<PRPEditor> ViewNews1()
        {
            ADOprpDL = new clsPRPadoDL();
            ADOprpDL.SPName = "spViewNews";

            ADO.ReaderWithProcedures(ADOprpDL);

            PRPEditor objprp;
            List<PRPEditor> lst = new List<PRPEditor>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPEditor();
                    objprp.newsId = ADOprpDL.Dr["newsId"].ToString();
                    objprp.newsTitle = ADOprpDL.Dr["newsTitle"].ToString();
                    objprp.newsDescription = ADOprpDL.Dr["newsDescription"].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPEditor();
                objprp.Id = "Result Not Find";
                lst.Add(objprp);
            }
            ADOprpDL.Dr.Close();
            ADOprpDL.Con.Close();
            
           // ADO.ReaderClose(ADOprpDL);
            return lst;

        }



        public string insertFeedBack(PRPEditor objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[8];
            ADOprp.ArrayPram[0] = new SqlParameter("@FirstName", objprp.FistName);
            ADOprp.ArrayPram[1] = new SqlParameter("@LastName", objprp.LastName);
            ADOprp.ArrayPram[2] = new SqlParameter("@Country", objprp.Country);
            ADOprp.ArrayPram[3] = new SqlParameter("@State", objprp.State);
            ADOprp.ArrayPram[4] = new SqlParameter("@EmailID", objprp.Email);
            ADOprp.ArrayPram[5] = new SqlParameter("@Mobile", objprp.Mob);
            ADOprp.ArrayPram[6] = new SqlParameter("@YourView", objprp.Feedback);
            ADOprp.ArrayPram[7] = new SqlParameter("@subject", objprp.subject);

            ADOprp.SPName = "spInsert";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }


        //---------------------Features------

        public string InsertFeatures(PRPEditor objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[1] = new SqlParameter("@FeaturesName", objprp.featuresName);
            
            ADOprp.SPName = "spFeaturesInsert";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }

        public string UpdateFeatures(PRPEditor objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[2];
            ADOprp.ArrayPram[0] = new SqlParameter("@Featuresid", objprp.Id);
            ADOprp.ArrayPram[1] = new SqlParameter("@FeaturesName", objprp.featuresName);
            
            ADOprp.SPName = "spFeaturesUpdate";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }

        public string DeleteFeatures(PRPEditor objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@Featuresid", objprp.Id);

            ADOprp.SPName = "spFeaturesDelete";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }

        public PRPEditor SelectFeatures(PRPEditor objprp)
        {
            ADOprpDL = new clsPRPadoDL();
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@Featuresid", objprp.Id);
            ADOprpDL.SPName = "spFeaturesSelect";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPEditor obj = new PRPEditor(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj.Id = ADOprpDL.Dr["Featuresid"].ToString();
                    obj.featuresName = ADOprpDL.Dr["FeaturesName"].ToString();
                }
            }
            ADO.ReaderClose(ADOprpDL);

            return obj;




        }

        public DataTable ViewFeatures()
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.SPName = "spFeaturesView";

            return ADO.DataTableWithProcedures(ADOprp);


        }

        public List<PRPEditor> ViewFeatures1()
        {
            ADOprpDL = new clsPRPadoDL();
            ADOprpDL.SPName = "spFeaturesView";

            ADO.ReaderWithProcedures(ADOprpDL);

            PRPEditor objprp;
            List<PRPEditor> lst = new List<PRPEditor>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPEditor();
                    objprp.Id = ADOprpDL.Dr["Featuresid"].ToString();
                    objprp.featuresName = ADOprpDL.Dr["FeaturesName"].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPEditor();
                objprp.Id = "Result Not Find";
                lst.Add(objprp);
            }
            ADOprpDL.Dr.Close();
            ADOprpDL.Con.Close();
            
           // ADO.ReaderClose(ADOprpDL);
            return lst;

        }


        //---------------------Courses------

        public string InsertCourse(PRPEditor objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[4];
            ADOprp.ArrayPram[0] = new SqlParameter("@courseName", objprp.courseName);
            ADOprp.ArrayPram[1] = new SqlParameter("@courseEligibity", objprp.courseEligibity);
            ADOprp.ArrayPram[2] = new SqlParameter("@courseDuration", objprp.courseDuration);
            ADOprp.ArrayPram[3] = new SqlParameter("@courseDescription", objprp.courseDescription);

            ADOprp.SPName = "spCourseInsert";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }

        public string UpdateCourse(PRPEditor objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[5];
            ADOprp.ArrayPram[0] = new SqlParameter("@courseName", objprp.courseName);
            ADOprp.ArrayPram[1] = new SqlParameter("@courseEligibity", objprp.courseEligibity);
            ADOprp.ArrayPram[2] = new SqlParameter("@courseDuration", objprp.courseDuration);
            ADOprp.ArrayPram[3] = new SqlParameter("@courseDescription", objprp.courseDescription);
            ADOprp.ArrayPram[4] = new SqlParameter("@courseId", objprp.courseId);

            ADOprp.SPName = "spCourseUpdate";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }

        public string DeleteCourse(PRPEditor objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@courseId", objprp.courseId);

            ADOprp.SPName = "spCourseDelete";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }

        public PRPEditor SelectCourse(PRPEditor objprp)
        {
            ADOprpDL = new clsPRPadoDL();
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@courseId", objprp.courseId);
            ADOprpDL.SPName = "spCourseSelect";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPEditor obj = new PRPEditor(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj.courseId = ADOprpDL.Dr["courseId"].ToString();
                    obj.courseName = ADOprpDL.Dr["courseName"].ToString();
                    obj.courseEligibity = ADOprpDL.Dr["courseEligibity"].ToString();
                    obj.courseDuration = ADOprpDL.Dr["courseDuration"].ToString();
                    obj.courseDescription = ADOprpDL.Dr["courseDescription"].ToString();
                    obj.courseDate = ADOprpDL.Dr["courseDate"].ToString();
                    obj.courseDescriptionfull = ADOprpDL.Dr["courseDescription"].ToString();
            
                }
            }
            ADO.ReaderClose(ADOprpDL);

            return obj;




        }

        public DataTable ViewCourse()
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.SPName = "spCourseView";

            return ADO.DataTableWithProcedures(ADOprp);


        }

        public List<PRPEditor> ViewCourse1()
        {
            ADOprpDL = new clsPRPadoDL();
            ADOprpDL.SPName = "spCourseView";

            ADO.ReaderWithProcedures(ADOprpDL);

            PRPEditor objprp;
            List<PRPEditor> lst = new List<PRPEditor>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPEditor();
                    objprp.courseId = ADOprpDL.Dr["courseId"].ToString();
                    objprp.courseName = ADOprpDL.Dr["courseName"].ToString();
                    objprp.courseEligibity = ADOprpDL.Dr["courseEligibity"].ToString();
                    objprp.courseDuration = ADOprpDL.Dr["courseDuration"].ToString();
                    objprp.courseDescription = ADOprpDL.Dr["courseDescription"].ToString();
                    objprp.courseDate = ADOprpDL.Dr["courseDate"].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPEditor();
                objprp.Id = "Result Not Find";
                lst.Add(objprp);
            }
            ADOprpDL.Dr.Close();
            ADOprpDL.Con.Close();
            
           // ADO.ReaderClose(ADOprpDL);
            return lst;

        }


        //---------------------Student------

        public string InsertStudent(PRPStudent objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[14];
            ADOprp.ArrayPram[0] = new SqlParameter("@studentName", objprp.studentName);
            ADOprp.ArrayPram[1] = new SqlParameter("@studentFather", objprp.studentFather);
            ADOprp.ArrayPram[2] = new SqlParameter("@studentGender", objprp.studentGender);
            ADOprp.ArrayPram[3] = new SqlParameter("@studentMarital", objprp.studentMarital);
            ADOprp.ArrayPram[4] = new SqlParameter("@studentCourse", objprp.studentCourse);
            ADOprp.ArrayPram[5] = new SqlParameter("@studentQualification", objprp.studentQualification);
            ADOprp.ArrayPram[6] = new SqlParameter("@studentCaste", objprp.studentCaste);
            ADOprp.ArrayPram[7] = new SqlParameter("@studentAddress", objprp.studentAddress);
            ADOprp.ArrayPram[8] = new SqlParameter("@studentCity", objprp.studentCity);
            ADOprp.ArrayPram[9] = new SqlParameter("@studentDistirct", objprp.studentDistirct);
            ADOprp.ArrayPram[10] = new SqlParameter("@studentMoibleNo", objprp.studentMoibleNo);
            ADOprp.ArrayPram[11] = new SqlParameter("@studentPhoneNo", objprp.studentPhoneNo);
            ADOprp.ArrayPram[12] = new SqlParameter("@studentMailId", objprp.studentMailId);
           ADOprp.ArrayPram[13] = new SqlParameter("@studentknowFrom", objprp.studentknowFrom);

           ADOprp.SPName = "spStudentInsert";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }

        //---------------Image Gellary ----------------------------------//


        public string GetMaxCategoryID()
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.SPName = "spGetCategoryMaxId";

            return ADO.ScalarQueryWithProcedures(ADOprp);
        }


        public string spGetProductMaxId()
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.SPName = "spGetProductMaxId";

            return ADO.ScalarQueryWithProcedures(ADOprp);
        }
        


        public string spGetStaffMaxId()
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.SPName = "spGetStaffMaxId";

            return ADO.ScalarQueryWithProcedures(ADOprp);
        }

        


        public string GetMaxPropertyOfID()
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.SPName = "spGetPropertyOfMaxId";

            return ADO.ScalarQueryWithProcedures(ADOprp);
        }

        public string GetMaxFileId()
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.SPName = "spGetfileMaxId";

            return ADO.ScalarQueryWithProcedures(ADOprp);
        }



        public string InsertImageGallery(PRPPImageGellery objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[7];
            ADOprp.ArrayPram[0] = new SqlParameter("@imageTitle", objprp.imageTitle);
            ADOprp.ArrayPram[1] = new SqlParameter("@imagePath", objprp.imagePath);
            ADOprp.ArrayPram[2] = new SqlParameter("@imageDescription", objprp.imageDescription);
            ADOprp.ArrayPram[3] = new SqlParameter("@imageStatus", objprp.imageStatus);
            ADOprp.ArrayPram[4] = new SqlParameter("@imageOrderNO", objprp.imageOrderNO);
            ADOprp.ArrayPram[5] = new SqlParameter("@imageCaloneyId", objprp.caloneyId);
            ADOprp.ArrayPram[6] = new SqlParameter("@schoolid", objprp.id);
            ADOprp.SPName = "spImageGalleryInsert";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }



        public string spInssertWebProduct(PRPPImageGellery objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[7];
            ADOprp.ArrayPram[0] = new SqlParameter("@productName", objprp.imageTitle);
            ADOprp.ArrayPram[1] = new SqlParameter("@productImage", objprp.imagePath);
            ADOprp.ArrayPram[2] = new SqlParameter("@productPrice", objprp.line1);
            ADOprp.ArrayPram[3] = new SqlParameter("@productDiscount", objprp.line2);
            ADOprp.ArrayPram[4] = new SqlParameter("@productDescription", objprp.imageDescription);
            ADOprp.ArrayPram[5] = new SqlParameter("@productIsactive", objprp.imageStatus);
            ADOprp.ArrayPram[6] = new SqlParameter("@productSchoolId", objprp.id);
            ADOprp.SPName = "spInssertWebProduct";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }

        public string UpdateImageGallery(PRPPImageGellery objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[7];
            ADOprp.ArrayPram[0] = new SqlParameter("@imageTitle", objprp.imageTitle);
            ADOprp.ArrayPram[1] = new SqlParameter("@imagePath", objprp.imagePath);
            ADOprp.ArrayPram[2] = new SqlParameter("@imageDescription", objprp.imageDescription);
            ADOprp.ArrayPram[3] = new SqlParameter("@imageStatus", objprp.imageStatus);
            ADOprp.ArrayPram[4] = new SqlParameter("@imageOrderNO", objprp.imageOrderNO);
            ADOprp.ArrayPram[5] = new SqlParameter("@imageId", objprp.imageId);
            ADOprp.ArrayPram[6] = new SqlParameter("@imageCaloneyId", objprp.caloneyId);

            ADOprp.SPName = "spImageGalleryUpdate";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }



        public string spUpdateWebProduct(PRPPImageGellery objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[7];
            ADOprp.ArrayPram[0] = new SqlParameter("@productId", objprp.imageId);
            ADOprp.ArrayPram[1] = new SqlParameter("@productName", objprp.imageTitle);
            ADOprp.ArrayPram[2] = new SqlParameter("@productImage", objprp.imagePath);
            ADOprp.ArrayPram[3] = new SqlParameter("@productPrice", objprp.line1);
            ADOprp.ArrayPram[4] = new SqlParameter("@productDiscount", objprp.line2);
            ADOprp.ArrayPram[5] = new SqlParameter("@productDescription", objprp.imageDescription);
            ADOprp.ArrayPram[6] = new SqlParameter("@productIsactive", objprp.imageStatus);

            ADOprp.SPName = "spUpdateWebProduct";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }



        public string DeleteImageGallery(PRPPImageGellery objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@imageId", objprp.imageId);

            ADOprp.SPName = "spImageGalleryDelete";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }


        public string spdeletewebProduct(PRPPImageGellery objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@imageId", objprp.imageId);

            ADOprp.SPName = "spdeletewebProduct";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }
        public PRPPImageGellery SelectImageGallery(PRPPImageGellery objprp)
        {
            ADOprpDL = new clsPRPadoDL();
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@imageId", objprp.imageId);
            ADOprpDL.SPName = "spImageGallerySelect";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPPImageGellery obj = new PRPPImageGellery(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj.imageId = ADOprpDL.Dr["imageId"].ToString();
                    obj.imageTitle = ADOprpDL.Dr["imageTitle"].ToString();
                    obj.imagePath = ADOprpDL.Dr["imagePath"].ToString();
                    obj.imageDescription = ADOprpDL.Dr["imageDescription"].ToString();
                    obj.imageStatus = ADOprpDL.Dr["imageStatus"].ToString();
                    obj.imageOrderNO = ADOprpDL.Dr["imageOrderNO"].ToString();
                    obj.caloneyName = ADOprpDL.Dr["caloneyName"].ToString();
                    
                }
            }
            ADO.ReaderClose(ADOprpDL);

            return obj;

        }


        public PRPPImageGellery spwebProductById(PRPPImageGellery objprp)
        {
            ADOprpDL = new clsPRPadoDL();
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@imageId", objprp.imageId);
            ADOprpDL.SPName = "spwebProductById";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPPImageGellery obj = new PRPPImageGellery(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj.imageId = ADOprpDL.Dr["productId"].ToString();
                    obj.imageTitle = ADOprpDL.Dr["productName"].ToString();
                    obj.imagePath = ADOprpDL.Dr["productImage"].ToString();
                    obj.imageDescription = ADOprpDL.Dr["productDescription"].ToString();
                    obj.imageStatus = ADOprpDL.Dr["productIsactive"].ToString();
                    obj.imageOrderNO = ADOprpDL.Dr["productSchoolId"].ToString();
                    obj.caloneyName = ADOprpDL.Dr["caloneyName"].ToString();
                    obj.line1 = ADOprpDL.Dr["productPrice"].ToString();
                    obj.line2 = ADOprpDL.Dr["productDiscount"].ToString();

                }
            }
            ADO.ReaderClose(ADOprpDL);

            return obj;

        }
        public DataTable viewImageGallery()
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.SPName = "spImageGallery";

            return ADO.DataTableWithProcedures(ADOprp);


        }

        public List<PRPPImageGellery> viewImageGalleryList()
        {
            ADOprpDL = new clsPRPadoDL();
            ADOprpDL.SPName = "spImageGallery";

            ADO.ReaderWithProcedures(ADOprpDL);

            PRPPImageGellery objprp;
            List<PRPPImageGellery> lst = new List<PRPPImageGellery>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPPImageGellery();
                    objprp.imageId = ADOprpDL.Dr["imageId"].ToString();
                    objprp.imageTitle = ADOprpDL.Dr["imageTitle"].ToString();
                    objprp.imagePath = ADOprpDL.Dr["imagePath"].ToString();
                    objprp.imageDescription = ADOprpDL.Dr["imageDescription"].ToString();
                    objprp.imageStatus = ADOprpDL.Dr["imageStatus"].ToString();
                    objprp.imageOrderNO = ADOprpDL.Dr["imageOrderNO"].ToString();
                    objprp.caloneyName = ADOprpDL.Dr["caloneyName"].ToString();

                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPPImageGellery();
                objprp.id = "Result Not Find";
                lst.Add(objprp);
            }
            ADOprpDL.Dr.Close();
            ADOprpDL.Con.Close();
            
            //ADO.ReaderClose(ADOprpDL);
            return lst;

        }


        public List<PRPPImageGellery> viewImageGalleryShow()
        {
            ADOprpDL = new clsPRPadoDL();
            ADOprpDL.SPName = "spImageGalleryshow";

            ADO.ReaderWithProcedures(ADOprpDL);

            PRPPImageGellery objprp;
            List<PRPPImageGellery> lst = new List<PRPPImageGellery>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPPImageGellery();
                    objprp.imageId = ADOprpDL.Dr["imageId"].ToString();
                    objprp.imageTitle = ADOprpDL.Dr["imageTitle"].ToString();
                    objprp.imagePath = ADOprpDL.Dr["imagePath"].ToString();
                    objprp.imageDescription = ADOprpDL.Dr["imageDescription"].ToString();
                    objprp.imageStatus = ADOprpDL.Dr["imageStatus"].ToString();
                    objprp.imageOrderNO = ADOprpDL.Dr["imageOrderNO"].ToString();
                    objprp.caloneyName = ADOprpDL.Dr["caloneyName"].ToString();

                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPPImageGellery();
                objprp.id = "Result Not Find";
                lst.Add(objprp);
            }
            ADOprpDL.Dr.Close();
            ADOprpDL.Con.Close();
            
            //ADO.ReaderClose(ADOprpDL);
            return lst;

        }
        public List<PRPPImageGellery> spImageGalleryshowByCaloneyId_sal(PRPPImageGellery objpram)
        {

            ADOprpDL = new clsPRPadoDL();
            ADOprpDL.ArrayPram = new SqlParameter[2];

            ADOprpDL.SPName = "spImageGalleryshowByCaloneyId_sal";


            ADOprpDL.ArrayPram[0] = new SqlParameter("@caloneyId", objpram.caloneyId);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@schoolId", objpram.id);


            ADO.ReaderWithProceduresandParam(ADOprpDL);


            PRPPImageGellery objprp;
            List<PRPPImageGellery> lst = new List<PRPPImageGellery>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPPImageGellery();
                    objprp.imageId = ADOprpDL.Dr["imageId"].ToString();
                    objprp.imageTitle = ADOprpDL.Dr["imageTitle"].ToString();
                    objprp.imagePath = ADOprpDL.Dr["imagePath"].ToString();
                    objprp.imageDescription = ADOprpDL.Dr["imageDescription"].ToString();
                    objprp.imageStatus = ADOprpDL.Dr["imageStatus"].ToString();
                    objprp.imageOrderNO = ADOprpDL.Dr["imageOrderNO"].ToString();
                    objprp.caloneyName = ADOprpDL.Dr["caloneyName"].ToString();
                    objprp.imagepath1 = ADOprpDL.Dr["imagepath1"].ToString();
                    objprp.id = ADOprpDL.Dr["srno"].ToString();
                    objprp.layout = ADOprpDL.Dr["layout"].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPPImageGellery();
                objprp.id = "Result Not Find";
                lst.Add(objprp);
            }
            ADOprpDL.Dr.Close();
            ADOprpDL.Con.Close();

            //ADO.ReaderClose(ADOprpDL);
            return lst;

        }

 public List<PRPPImageGellery> viewImageGalleryShowByCaloneyId(PRPPImageGellery objpram)
        {

            ADOprpDL = new clsPRPadoDL();
            ADOprpDL.ArrayPram = new SqlParameter[2];

            ADOprpDL.SPName = "spImageGalleryshowByCaloneyId_sal";


            ADOprpDL.ArrayPram[0] = new SqlParameter("@caloneyId", objpram.caloneyId);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@schoolId", objpram.id);

            
            ADO.ReaderWithProceduresandParam(ADOprpDL);


            PRPPImageGellery objprp;
            List<PRPPImageGellery> lst = new List<PRPPImageGellery>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPPImageGellery();
                    objprp.imageId = ADOprpDL.Dr["imageId"].ToString();
                    objprp.imageTitle = ADOprpDL.Dr["imageTitle"].ToString();
                    objprp.imagePath = ADOprpDL.Dr["imagePath"].ToString();
                    objprp.imageDescription = ADOprpDL.Dr["imageDescription"].ToString();
                    objprp.imageStatus = ADOprpDL.Dr["imageStatus"].ToString();
                    objprp.imageOrderNO = ADOprpDL.Dr["imageOrderNO"].ToString();
                    objprp.caloneyName = ADOprpDL.Dr["caloneyName"].ToString();
                    objprp.imagepath1 = ADOprpDL.Dr["imagepath1"].ToString();
                    objprp.id = ADOprpDL.Dr["srno"].ToString();
                    objprp.layout = ADOprpDL.Dr["layout"].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPPImageGellery();
                objprp.id = "Result Not Find";
                lst.Add(objprp);
            }
            ADOprpDL.Dr.Close();
            ADOprpDL.Con.Close();
            
            //ADO.ReaderClose(ADOprpDL);
            return lst;

        }


 public List<PRPPImageGellery> viewImageGalleryShowByStudent(PRPPImageGellery objpram)
 {
     ADOprpDL = new clsPRPadoDL();
     ADOprpDL.ArrayPram = new SqlParameter[2];

     ADOprpDL.SPName = "spImageGalleryshowStudent";


     ADOprpDL.ArrayPram[0] = new SqlParameter("@caloneyId", objpram.caloneyId);
     ADOprpDL.ArrayPram[1] = new SqlParameter("@schoolId", objpram.id);


     ADO.ReaderWithProceduresandParam(ADOprpDL);


     PRPPImageGellery objprp;
     List<PRPPImageGellery> lst = new List<PRPPImageGellery>();

    
     ADOprpDL.Dr.Close();
     ADOprpDL.Con.Close();

     //ADO.ReaderClose(ADOprpDL);
     return lst;

 }

        //---------------Loction ----------------------------------//


        public List<PRPPImageGellery> spwebProductBySchool(PRPPImageGellery objpram)
        {
            ADOprpDL = new clsPRPadoDL();
            ADOprpDL.ArrayPram = new SqlParameter[1];

            ADOprpDL.SPName = "spwebProductBySchool";

            // ADOprpDL.ArrayPram[0] = new SqlParameter("@caloneyId", objpram.caloneyId);
            ADOprpDL.ArrayPram[0] = new SqlParameter("@schoolId", objpram.id);


            ADO.ReaderWithProceduresandParam(ADOprpDL);


            PRPPImageGellery objprp;
            List<PRPPImageGellery> lst = new List<PRPPImageGellery>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPPImageGellery();
                    objprp.imageId = ADOprpDL.Dr["productId"].ToString();
                    objprp.imageTitle = ADOprpDL.Dr["productName"].ToString();
                    objprp.imagePath = ADOprpDL.Dr["productImage"].ToString();
                    objprp.imageDescription = ADOprpDL.Dr["productDescription"].ToString();
                    objprp.imageStatus = ADOprpDL.Dr["productIsactive"].ToString();
                    objprp.line1 = ADOprpDL.Dr["productPrice"].ToString();
                    objprp.line2 = ADOprpDL.Dr["productDiscount"].ToString();
                    objprp.line3 = ADOprpDL.Dr["productNetAmount"].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPPImageGellery();
                objprp.id = "Result Not Find";
                lst.Add(objprp);
            }
            ADOprpDL.Dr.Close();
            ADOprpDL.Con.Close();

            //ADO.ReaderClose(ADOprpDL);
            return lst;

        }


        public DataTable spShowHotproperty()
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.SPName = "spShowHotproperty";

            return ADO.DataTableWithProcedures(ADOprp);


        }



        public DataTable spTemplateSelect()
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.SPName = "spTemplateSelect";

            return ADO.DataTableWithProcedures(ADOprp);


        }


        //----------------------End Location----------------------------------------//


        
        
        //---------------------Caloney----------------------------------
        public string InsertCaloney(PRPPImageGellery objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[4];
            ADOprp.ArrayPram[0] = new SqlParameter("@caloneyName", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@caloneyStatus", objprp.status);
            ADOprp.ArrayPram[2] = new SqlParameter("@schoolid", objprp.schoolid);
            ADOprp.ArrayPram[3] = new SqlParameter("@pageType", objprp.Type);
            
            ADOprp.SPName = "spInfoCaloneyInsert";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }

        public string UpdateCaloney(PRPPImageGellery objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[3];
            ADOprp.ArrayPram[0] = new SqlParameter("@caloneyId", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@caloneyName", objprp.name);
            ADOprp.ArrayPram[2] = new SqlParameter("@caloneyStatus", objprp.status);
            

            ADOprp.SPName = "spInfoCaloneyUpdate";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }

        public string DeleteCaloney(PRPPImageGellery objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@caloneyId", objprp.id);

            ADOprp.SPName = "spInfoCaloneyDelete";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }

        public PRPPImageGellery SelectCaloney(PRPPImageGellery objprp)
        {
            ADOprpDL = new clsPRPadoDL();
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@caloneyId", objprp.id);
            ADOprpDL.SPName = "spInfoCaloneySelect";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPPImageGellery obj = new PRPPImageGellery(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj.id = ADOprpDL.Dr["caloneyId"].ToString();
                    obj.name = ADOprpDL.Dr["caloneyName"].ToString();
                    obj.status = ADOprpDL.Dr["caloneyStatus"].ToString();
                    
                }
            }
            ADO.ReaderClose(ADOprpDL);

            return obj;




        }

        public DataTable ViewCaloney()
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.SPName = "spInfoCaloney";

            return ADO.DataTableWithProcedures(ADOprp);


        }

        public List<PRPPImageGellery> ViewCaloney1(PRPPImageGellery objprp1)
        {
            ADOprpDL = new clsPRPadoDL();
            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@schoolId", objprp1.schoolid);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@type", objprp1.Type);
            ADOprpDL.SPName = "spInfoCaloney";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPPImageGellery objprp;
            List<PRPPImageGellery> lst = new List<PRPPImageGellery>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPPImageGellery();
                    objprp.caloneyId = ADOprpDL.Dr["srno"].ToString();
                    objprp.id = ADOprpDL.Dr["linkid"].ToString();
                    objprp.name = ADOprpDL.Dr["linkname"].ToString();
                    objprp.status = ADOprpDL.Dr["linkisactive"].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPPImageGellery();
                objprp.id = "Result Not Find";
                lst.Add(objprp);
            }
            ADOprpDL.Dr.Close();
            ADOprpDL.Con.Close();
            
         //   ADO.ReaderClose(ADOprpDL);
            return lst;

        }


        public List<PRPPImageGellery> spImageGalleryshowByCaloneyIdtop5(PRPPImageGellery objpram)
        {
            ADOprpDL = new clsPRPadoDL();
            ADOprpDL.ArrayPram = new SqlParameter[2];

            ADOprpDL.SPName = "spImageGalleryshowByCaloneyIdtop5";

            ADOprpDL.ArrayPram[0] = new SqlParameter("@caloneyId", objpram.caloneyId);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@schoolId", objpram.id);


            ADO.ReaderWithProceduresandParam(ADOprpDL);


            PRPPImageGellery objprp;
            List<PRPPImageGellery> lst = new List<PRPPImageGellery>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPPImageGellery();
                    objprp.imageId = ADOprpDL.Dr["imageId"].ToString();
                    objprp.imageTitle = ADOprpDL.Dr["imageTitle"].ToString();
                    objprp.imagePath = ADOprpDL.Dr["imagePath"].ToString();
                    objprp.imageDescription = ADOprpDL.Dr["imageDescription"].ToString();
                    objprp.imageStatus = ADOprpDL.Dr["imageStatus"].ToString();
                    objprp.imageOrderNO = ADOprpDL.Dr["imageOrderNO"].ToString();
                    objprp.caloneyName = ADOprpDL.Dr["caloneyName"].ToString();

                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPPImageGellery();
                objprp.id = "Result Not Find";
                lst.Add(objprp);
            }
            ADOprpDL.Dr.Close();
            ADOprpDL.Con.Close();

            //ADO.ReaderClose(ADOprpDL);
            return lst;

        }


        public List<PRPPImageGellery> homepageAllWeb(PRPPImageGellery objpram)
        {
            ADOprpDL = new clsPRPadoDL();
            ADOprpDL.ArrayPram = new SqlParameter[1];

            ADOprpDL.SPName = "homepageAllWeb";
            ADOprpDL.ArrayPram[0] = new SqlParameter("@schoolId", objpram.id); //homepageAllWeb


            ADO.ReaderWithProceduresandParam(ADOprpDL);


            PRPPImageGellery objprp;
            List<PRPPImageGellery> lst = new List<PRPPImageGellery>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPPImageGellery();
                    objprp.imageId = ADOprpDL.Dr["imageId"].ToString();
                    objprp.imageTitle = ADOprpDL.Dr["imageTitle"].ToString();
                    objprp.imagePath = ADOprpDL.Dr["imagePath"].ToString();
                    objprp.imageDescription = ADOprpDL.Dr["imageDescription"].ToString();
                    objprp.imageStatus = ADOprpDL.Dr["imageStatus"].ToString();
                    objprp.imageOrderNO = ADOprpDL.Dr["imageOrderNO"].ToString();
                    objprp.caloneyName = ADOprpDL.Dr["caloneyName"].ToString();

                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPPImageGellery();
                objprp.id = "Result Not Find";
                lst.Add(objprp);
            }
            ADOprpDL.Dr.Close();
            ADOprpDL.Con.Close();

            //ADO.ReaderClose(ADOprpDL);
            return lst;

        }
     
       //---------------------End Caloney----------------------------------



        //---------------------Location----------------------------------

        public string InsertLocation(PRPPImageGellery objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[2];
            ADOprp.ArrayPram[0] = new SqlParameter("@locationName", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@locationStatus", objprp.status);

            ADOprp.SPName = "spInfoLocationInsert";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }

        public string UpdateLocation(PRPPImageGellery objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[3];
            ADOprp.ArrayPram[0] = new SqlParameter("@locationId", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@locationName", objprp.name);
            ADOprp.ArrayPram[2] = new SqlParameter("@locationStatus", objprp.status);


            ADOprp.SPName = "spInfoLocationUpdate";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }

        public string DeleteLocation(PRPPImageGellery objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@locationId", objprp.id);

            ADOprp.SPName = "spInfoLocationDelete";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }

        public PRPPImageGellery SelectLocation(PRPPImageGellery objprp)
        {
            ADOprpDL = new clsPRPadoDL();
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@locationId", objprp.id);
            ADOprpDL.SPName = "spInfoLocationSelect";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPPImageGellery obj = new PRPPImageGellery(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj.id = ADOprpDL.Dr["locationId"].ToString();
                    obj.name = ADOprpDL.Dr["locationName"].ToString();
                    obj.status = ADOprpDL.Dr["locationStatus"].ToString();

                }
            }
            ADO.ReaderClose(ADOprpDL);

            return obj;

        }

        public DataTable ViewLocation()
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.SPName = "spInfoLocation";

            return ADO.DataTableWithProcedures(ADOprp);


        }

        public List<PRPPImageGellery> ViewLocation1()
        {
            ADOprpDL = new clsPRPadoDL();
            ADOprpDL.SPName = "spInfoLocation";

            ADO.ReaderWithProcedures(ADOprpDL);

            PRPPImageGellery objprp;
            List<PRPPImageGellery> lst = new List<PRPPImageGellery>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPPImageGellery();
                    objprp.id = ADOprpDL.Dr["locationId"].ToString();
                    objprp.name = ADOprpDL.Dr["locationName"].ToString();
                    objprp.status = ADOprpDL.Dr["locationStatus"].ToString();

                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPPImageGellery();
                objprp.id = "Result Not Find";
                lst.Add(objprp);
            }
            ADOprpDL.Dr.Close();
            ADOprpDL.Con.Close();
            
            //ADO.ReaderClose(ADOprpDL);
            return lst;

        }
        //---------------------End Location----------------------------------

        //---------------------property type----------------------------------

        public string InsertPropertyType(PRPPImageGellery objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[2];
            ADOprp.ArrayPram[0] = new SqlParameter("@PropertyTypeName", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@PropertyTypeStatus", objprp.status);

            ADOprp.SPName = "spInfoPropertyTypeInsert";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }

        public string UpdatePropertyType(PRPPImageGellery objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[3];
            ADOprp.ArrayPram[0] = new SqlParameter("@PropertyTypeId", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@PropertyTypeName", objprp.name);
            ADOprp.ArrayPram[2] = new SqlParameter("@PropertyTypeStatus", objprp.status);


            ADOprp.SPName = "spInfoPropertyTypeUpdate";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }

        public string DeletePropertyType(PRPPImageGellery objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@PropertyTypeId", objprp.id);

            ADOprp.SPName = "spInfoPropertyTypeDelete";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }

        public PRPPImageGellery SelectPropertyType(PRPPImageGellery objprp)
        {
            ADOprpDL = new clsPRPadoDL();
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@PropertyTypeId", objprp.id);
            ADOprpDL.SPName = "spInfoPropertyTypeSelect";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPPImageGellery obj = new PRPPImageGellery(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj.id = ADOprpDL.Dr["PropertyTypeId"].ToString();
                    obj.name = ADOprpDL.Dr["PropertyTypeName"].ToString();
                    obj.status = ADOprpDL.Dr["PropertyTypeStatus"].ToString();

                }
            }
            ADO.ReaderClose(ADOprpDL);

            return obj;

        }

        public DataTable ViewPropertyType()
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.SPName = "spInfoPropertyType";

            return ADO.DataTableWithProcedures(ADOprp);


        }

        public List<PRPPImageGellery> ViewPropertyType1()
        {
            ADOprpDL = new clsPRPadoDL();
            ADOprpDL.SPName = "spInfoPropertyType";

            ADO.ReaderWithProcedures(ADOprpDL);

            PRPPImageGellery objprp;
            List<PRPPImageGellery> lst = new List<PRPPImageGellery>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPPImageGellery();
                    objprp.id = ADOprpDL.Dr["PropertyTypeId"].ToString();
                    objprp.name = ADOprpDL.Dr["PropertyTypeName"].ToString();
                    objprp.status = ADOprpDL.Dr["PropertyTypeStatus"].ToString();

                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPPImageGellery();
                objprp.id = "Result Not Find";
                lst.Add(objprp);
            }
            ADOprpDL.Dr.Close();
            ADOprpDL.Con.Close();
            
         //   ADO.ReaderClose(ADOprpDL);
            return lst;

        }
        //---------------------End property type----------------------------------



        //--------------------- TenantType----------------------------------

        public string InsertTenantType(PRPPImageGellery objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[2];
            ADOprp.ArrayPram[0] = new SqlParameter("@TenantName", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@TenantStatus", objprp.status);

            ADOprp.SPName = "spInfoTenantInsert";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }

        public string UpdateTenantType(PRPPImageGellery objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[3];
            ADOprp.ArrayPram[0] = new SqlParameter("@TenantId", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@TenantName", objprp.name);
            ADOprp.ArrayPram[2] = new SqlParameter("@TenantStatus", objprp.status);


            ADOprp.SPName = "spInfoTenantUpdate";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }

        public string DeleteTenantType(PRPPImageGellery objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@TenantId", objprp.id);

            ADOprp.SPName = "spInfoTenantDelete";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }

        public PRPPImageGellery SelectTenantType(PRPPImageGellery objprp)
        {
            ADOprpDL = new clsPRPadoDL();
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@TenantId", objprp.id);
            ADOprpDL.SPName = "spInfoTenantSelect";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPPImageGellery obj = new PRPPImageGellery(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj.id = ADOprpDL.Dr["TenantId"].ToString();
                    obj.name = ADOprpDL.Dr["TenantName"].ToString();
                    obj.status = ADOprpDL.Dr["TenantStatus"].ToString();

                }
            }
            ADO.ReaderClose(ADOprpDL);

            return obj;

        }

        public DataTable ViewTenantType()
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.SPName = "spInfoTenant";

            return ADO.DataTableWithProcedures(ADOprp);


        }

        public List<PRPPImageGellery> ViewTenantType1()
        {
            ADOprpDL = new clsPRPadoDL();
            ADOprpDL.SPName = "spInfoTenant";

            ADO.ReaderWithProcedures(ADOprpDL);

            PRPPImageGellery objprp;
            List<PRPPImageGellery> lst = new List<PRPPImageGellery>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPPImageGellery();
                    objprp.id = ADOprpDL.Dr["TenantId"].ToString();
                    objprp.name = ADOprpDL.Dr["TenantName"].ToString();
                    objprp.status = ADOprpDL.Dr["TenantStatus"].ToString();

                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPPImageGellery();
                objprp.id = "Result Not Find";
                lst.Add(objprp);
            }
            ADOprpDL.Dr.Close();
            ADOprpDL.Con.Close();
            
           // ADO.ReaderClose(ADOprpDL);
            return lst;

        }
        //---------------------End Tenant Type----------------------------------


        //--------------------buyerSeller Handler------------------------------------



        public string InsertBuyer(PRPProfile objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[36];
            ADOprp.ArrayPram[0] = new SqlParameter("@sellerContactPerson", objprp.sellerContactPerson);
            ADOprp.ArrayPram[1] = new SqlParameter("@sellerContactNo", objprp.sellerContactNo);
            ADOprp.ArrayPram[2] = new SqlParameter("@sellermailId", objprp.sellermailId);
            ADOprp.ArrayPram[3] = new SqlParameter("@sellerAddress", objprp.sellerAddress);
            ADOprp.ArrayPram[4] = new SqlParameter("@sellerCity", objprp.sellerCity);
            ADOprp.ArrayPram[5] = new SqlParameter("@sellerDistrict", objprp.sellerDistrict);
            ADOprp.ArrayPram[6] = new SqlParameter("@sellerState", objprp.sellerState);
            ADOprp.ArrayPram[7] = new SqlParameter("@sellerPinCode", objprp.sellerPinCode);
            ADOprp.ArrayPram[8] = new SqlParameter("@sellerPhoneNo", objprp.sellerPhoneNo);
            ADOprp.ArrayPram[9] = new SqlParameter("@sellerWantTo", objprp.sellerWantTo);
            ADOprp.ArrayPram[10] = new SqlParameter("@sellerPropertyType", objprp.sellerPropertyType);
            ADOprp.ArrayPram[11] = new SqlParameter("@sellerBedRoomNo", objprp.sellerBedRoomNo);
            ADOprp.ArrayPram[12] = new SqlParameter("@sellerBathRoomNo", objprp.sellerBathRoomNo);
            ADOprp.ArrayPram[13] = new SqlParameter("@sellerBHKNo", objprp.sellerBHKNo);
            ADOprp.ArrayPram[14] = new SqlParameter("@sellerFloorNo", objprp.sellerFloorNo);
            ADOprp.ArrayPram[15] = new SqlParameter("@sellerPlotSizeLength", objprp.sellerPlotSizeLength);
            ADOprp.ArrayPram[16] = new SqlParameter("@sellerPlotSizeWidth", objprp.sellerPlotSizeWidth);
            ADOprp.ArrayPram[17] = new SqlParameter("@sellerFurnished", objprp.sellerFurnished);
            ADOprp.ArrayPram[18] = new SqlParameter("@sellerCoveredArea", objprp.sellerCoveredArea);
            ADOprp.ArrayPram[19] = new SqlParameter("@sellerCoverAreaType", objprp.sellerCoverAreaType);
            ADOprp.ArrayPram[20] = new SqlParameter("@sellerPropertyDescription", objprp.sellerPropertyDescription);
            ADOprp.ArrayPram[21] = new SqlParameter("@sellerPropertyLocation", objprp.sellerPropertyLocation);
            ADOprp.ArrayPram[22] = new SqlParameter("@sellerPropertyLandmark", objprp.sellerPropertyLandmark);
            ADOprp.ArrayPram[23] = new SqlParameter("@sellerPropertyAddress", objprp.sellerPropertyAddress);
            ADOprp.ArrayPram[24] = new SqlParameter("@sellerTenanType", objprp.sellerTenanType);
            ADOprp.ArrayPram[25] = new SqlParameter("@sellerRentMin", objprp.sellerRentMin);
            ADOprp.ArrayPram[26] = new SqlParameter("@sellerRentMax", objprp.sellerRentMax);
            ADOprp.ArrayPram[27] = new SqlParameter("@sellerSecuirty", objprp.sellerSecuirty);
            ADOprp.ArrayPram[28] = new SqlParameter("@sellerAgreement", objprp.sellerAgreement);
            ADOprp.ArrayPram[29] = new SqlParameter("@selleravailabilty", objprp.selleravailabilty);
            ADOprp.ArrayPram[30] = new SqlParameter("@sellerCompanyLease", objprp.sellerCompanyLease);
            ADOprp.ArrayPram[31] = new SqlParameter("@sellerMinCoste", objprp.sellerMinCoste);
            ADOprp.ArrayPram[32] = new SqlParameter("@sellerMaxCoste", objprp.sellerMaxCoste);
            ADOprp.ArrayPram[33] = new SqlParameter("@sellerType", objprp.sellerType);
            ADOprp.ArrayPram[34] = new SqlParameter("@SellerStatus", objprp.SellerStatus);
            ADOprp.ArrayPram[35] = new SqlParameter("@SellerRemaark", objprp.SellerRemaark);
            
            ADOprp.SPName = "spsellerDetailInsert";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }

        public string updateBuyer(PRPProfile objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[23];
            ADOprp.ArrayPram[0] = new SqlParameter("@sellerId", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@sellerContactPerson", objprp.sellerContactPerson);
            ADOprp.ArrayPram[2] = new SqlParameter("@sellerContactNo", objprp.sellerContactNo);
            ADOprp.ArrayPram[3] = new SqlParameter("@sellermailId", objprp.sellermailId);
            ADOprp.ArrayPram[4] = new SqlParameter("@sellerAddress", objprp.sellerAddress);
            ADOprp.ArrayPram[5] = new SqlParameter("@sellerCity", objprp.sellerCity);
            ADOprp.ArrayPram[6] = new SqlParameter("@sellerWantTo", objprp.sellerWantTo);
            ADOprp.ArrayPram[7] = new SqlParameter("@sellerPropertyType", objprp.sellerPropertyType);
            ADOprp.ArrayPram[8] = new SqlParameter("@sellerPlotSizeLength", objprp.sellerPlotSizeLength);
            ADOprp.ArrayPram[9] = new SqlParameter("@sellerPlotSizeWidth", objprp.sellerPlotSizeWidth);
            ADOprp.ArrayPram[10] = new SqlParameter("@sellerFurnished", objprp.sellerFurnished);
            ADOprp.ArrayPram[11] = new SqlParameter("@sellerCoveredArea", objprp.sellerCoveredArea);
            ADOprp.ArrayPram[12] = new SqlParameter("@sellerCoverAreaType", objprp.sellerCoverAreaType);
            ADOprp.ArrayPram[13] = new SqlParameter("@sellerPropertyDescription", objprp.sellerPropertyDescription);
            ADOprp.ArrayPram[14] = new SqlParameter("@sellerPropertyLocation", objprp.sellerPropertyLocation);
            ADOprp.ArrayPram[15] = new SqlParameter("@sellerPropertyLandmark", objprp.sellerPropertyLandmark);
            ADOprp.ArrayPram[16] = new SqlParameter("@sellerPropertyAddress", objprp.sellerPropertyAddress);
            ADOprp.ArrayPram[17] = new SqlParameter("@sellerTenanType", objprp.sellerTenanType);
            ADOprp.ArrayPram[18] = new SqlParameter("@sellerRentMin", objprp.sellerRentMin);
            ADOprp.ArrayPram[19] = new SqlParameter("@sellerRentMax", objprp.sellerRentMax);
            ADOprp.ArrayPram[20] = new SqlParameter("@selleravailabilty", objprp.selleravailabilty);
            ADOprp.ArrayPram[21] = new SqlParameter("@sellerMinCoste", objprp.sellerMinCoste);
            ADOprp.ArrayPram[22] = new SqlParameter("@sellerMaxCoste", objprp.sellerMaxCoste);

            ADOprp.SPName = "spsellerDetailUpdate";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }


        public List<PRPProfile> ViewSellerDetail(PRPProfile objpram)
        {
            ADOprpDL = new clsPRPadoDL();
            ADOprpDL.ArrayPram = new SqlParameter[3];

            ADOprpDL.SPName = "spsellerDetail";

            ADOprpDL.ArrayPram[0] = new SqlParameter("@type", objpram.sellerType);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageIndex", objpram.pageIndex);
            ADOprpDL.ArrayPram[2] = new SqlParameter("@pageSize", objpram.pageSize);

            ADO.ReaderWithProceduresandParam(ADOprpDL);


            PRPProfile objprp;
            List<PRPProfile> lst = new List<PRPProfile>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPProfile();
                    objprp.id = ADOprpDL.Dr["sellerId"].ToString();
                    objprp.sellerContactPerson = ADOprpDL.Dr["sellerContactPerson"].ToString();
                    objprp.sellerContactNo = ADOprpDL.Dr["sellerContactNo"].ToString();
                    objprp.sellermailId = ADOprpDL.Dr["sellermailId"].ToString();
                    objprp.sellerAddress = ADOprpDL.Dr["sellerAddress"].ToString();
                    objprp.sellerCity = ADOprpDL.Dr["sellerCity"].ToString();
                    objprp.sellerDistrict = ADOprpDL.Dr["sellerDistrict"].ToString();
                    objprp.sellerState = ADOprpDL.Dr["sellerState"].ToString();
                    objprp.sellerPinCode = ADOprpDL.Dr["sellerPinCode"].ToString();
                    objprp.sellerPhoneNo = ADOprpDL.Dr["sellerPhoneNo"].ToString();
                    objprp.sellerWantTo = ADOprpDL.Dr["sellerWantTo"].ToString();
                    objprp.sellerPropertyType = ADOprpDL.Dr["sellerPropertyType"].ToString();
                    objprp.sellerBedRoomNo = ADOprpDL.Dr["sellerBedRoomNo"].ToString();
                    objprp.sellerBathRoomNo = ADOprpDL.Dr["sellerBathRoomNo"].ToString();
                    objprp.sellerBHKNo = ADOprpDL.Dr["sellerBHKNo"].ToString();
                    objprp.sellerFloorNo = ADOprpDL.Dr["sellerFloorNo"].ToString();
                    objprp.sellerPlotSizeLength = ADOprpDL.Dr["sellerPlotSizeLength"].ToString();
                    objprp.sellerPlotSizeWidth = ADOprpDL.Dr["sellerPlotSizeWidth"].ToString();
                    objprp.sellerFurnished = ADOprpDL.Dr["sellerFurnished"].ToString();
                    objprp.sellerCoveredArea = ADOprpDL.Dr["sellerCoveredArea"].ToString();
                    objprp.sellerCoverAreaType = ADOprpDL.Dr["sellerCoverAreaType"].ToString();
                    objprp.sellerPropertyDescription = ADOprpDL.Dr["sellerPropertyDescription"].ToString();
                    objprp.sellerPropertyLocation = ADOprpDL.Dr["sellerPropertyLocation"].ToString();
                    objprp.sellerPropertyLandmark = ADOprpDL.Dr["sellerPropertyLandmark"].ToString();
                    objprp.sellerPropertyAddress = ADOprpDL.Dr["sellerPropertyAddress"].ToString();
                    objprp.sellerTenanType = ADOprpDL.Dr["sellerTenanType"].ToString();
                    objprp.sellerRentMin = ADOprpDL.Dr["sellerRentMin"].ToString();
                    objprp.sellerRentMax = ADOprpDL.Dr["sellerRentMax"].ToString();
                    objprp.sellerSecuirty = ADOprpDL.Dr["sellerSecuirty"].ToString();
                    objprp.sellerAgreement = ADOprpDL.Dr["sellerAgreement"].ToString();
                    objprp.selleravailabilty = ADOprpDL.Dr["selleravailabilty"].ToString();
                    objprp.sellerCompanyLease = ADOprpDL.Dr["sellerCompanyLease"].ToString();
                    objprp.sellerMinCoste = ADOprpDL.Dr["sellerMinCoste"].ToString();
                    objprp.sellerMaxCoste = ADOprpDL.Dr["sellerMaxCoste"].ToString();
                    objprp.SellerStatus = ADOprpDL.Dr["SellerStatus"].ToString();
                    objprp.Sellerdate = ADOprpDL.Dr["Sellerdate"].ToString();
                    objprp.SellerRemaark = ADOprpDL.Dr["SellerRemaark"].ToString();
                    lst.Add(objprp);
                    
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPProfile();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPProfile();
                objprp.id = "Result Not Find";
                lst.Add(objprp);
            }


            ADOprpDL.Dr.Close();
            ADOprpDL.Con.Close();
             
         //   ADO.ReaderClose(ADOprpDL);
            return lst;

        }

        public PRPProfile SelectSellerById(PRPPImageGellery objprp1)
        {
            ADOprpDL = new clsPRPadoDL();
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@id", objprp1.id);
            ADOprpDL.SPName = "spsellerDetailByID";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPProfile objprp = new PRPProfile(); 

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp.id = ADOprpDL.Dr["sellerId"].ToString();
                    objprp.sellerContactPerson = ADOprpDL.Dr["sellerContactPerson"].ToString();
                    objprp.sellerContactNo = ADOprpDL.Dr["sellerContactNo"].ToString();
                    objprp.sellermailId = ADOprpDL.Dr["sellermailId"].ToString();
                    objprp.sellerAddress = ADOprpDL.Dr["sellerAddress"].ToString();
                    objprp.sellerCity = ADOprpDL.Dr["sellerCity"].ToString();
                    objprp.sellerDistrict = ADOprpDL.Dr["sellerDistrict"].ToString();
                    objprp.sellerState = ADOprpDL.Dr["sellerState"].ToString();
                    objprp.sellerPinCode = ADOprpDL.Dr["sellerPinCode"].ToString();
                    objprp.sellerPhoneNo = ADOprpDL.Dr["sellerPhoneNo"].ToString();
                    objprp.sellerWantTo = ADOprpDL.Dr["sellerWantTo"].ToString();
                    objprp.sellerPropertyType = ADOprpDL.Dr["sellerPropertyType"].ToString();
                    objprp.sellerBedRoomNo = ADOprpDL.Dr["sellerBedRoomNo"].ToString();
                    objprp.sellerBathRoomNo = ADOprpDL.Dr["sellerBathRoomNo"].ToString();
                    objprp.sellerBHKNo = ADOprpDL.Dr["sellerBHKNo"].ToString();
                    objprp.sellerFloorNo = ADOprpDL.Dr["sellerFloorNo"].ToString();
                    objprp.sellerPlotSizeLength = ADOprpDL.Dr["sellerPlotSizeLength"].ToString();
                    objprp.sellerPlotSizeWidth = ADOprpDL.Dr["sellerPlotSizeWidth"].ToString();
                    objprp.sellerFurnished = ADOprpDL.Dr["sellerFurnished"].ToString();
                    objprp.sellerCoveredArea = ADOprpDL.Dr["sellerCoveredArea"].ToString();
                    objprp.sellerCoverAreaType = ADOprpDL.Dr["sellerCoverAreaType"].ToString();
                    objprp.sellerPropertyDescription = ADOprpDL.Dr["sellerPropertyDescription"].ToString();
                    objprp.sellerPropertyLocation = ADOprpDL.Dr["sellerPropertyLocation"].ToString();
                    objprp.sellerPropertyLandmark = ADOprpDL.Dr["sellerPropertyLandmark"].ToString();
                    objprp.sellerPropertyAddress = ADOprpDL.Dr["sellerPropertyAddress"].ToString();
                    objprp.sellerTenanType = ADOprpDL.Dr["sellerTenanType"].ToString();
                    objprp.sellerRentMin = ADOprpDL.Dr["sellerRentMin"].ToString();
                    objprp.sellerRentMax = ADOprpDL.Dr["sellerRentMax"].ToString();
                    objprp.sellerSecuirty = ADOprpDL.Dr["sellerSecuirty"].ToString();
                    objprp.sellerAgreement = ADOprpDL.Dr["sellerAgreement"].ToString();
                    objprp.selleravailabilty = ADOprpDL.Dr["selleravailabilty"].ToString();
                    objprp.sellerCompanyLease = ADOprpDL.Dr["sellerCompanyLease"].ToString();
                    objprp.sellerMinCoste = ADOprpDL.Dr["sellerMinCoste"].ToString();
                    objprp.sellerMaxCoste = ADOprpDL.Dr["sellerMaxCoste"].ToString();
                    objprp.SellerStatus = ADOprpDL.Dr["SellerStatus"].ToString();
                    objprp.Sellerdate = ADOprpDL.Dr["Sellerdate"].ToString();
                    objprp.SellerRemaark = ADOprpDL.Dr["SellerRemaark"].ToString();
                    objprp.tenantName = ADOprpDL.Dr["TenantName"].ToString();
                    objprp.locationName = ADOprpDL.Dr["locationName"].ToString();
                    objprp.propertyType = ADOprpDL.Dr["PropertyTypeName"].ToString();
            
                }
            }
            ADO.ReaderClose(ADOprpDL);

            return objprp;

        }


        //---------------------end----buyerSeller Handler-------------------------------

        //----------------------------document Handler ---------------------------------------
     
        public string InsertDocmentFile(PRPPImageGellery objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[4];
            ADOprp.ArrayPram[0] = new SqlParameter("@docName", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@docPath", objprp.path);
            ADOprp.ArrayPram[2] = new SqlParameter("@docStatus", objprp.status);
            ADOprp.ArrayPram[3] = new SqlParameter("@schoolID", objprp.schoolid);
            ADOprp.SPName = "spDataForDownloadInsert";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }

        public string UpdateDocmentFile(PRPPImageGellery objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[4];
            ADOprp.ArrayPram[0] = new SqlParameter("@docId", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@docName", objprp.name);
            ADOprp.ArrayPram[2] = new SqlParameter("@docStatus", objprp.status);
            ADOprp.ArrayPram[3] = new SqlParameter("@docPath", objprp.path);


            ADOprp.SPName = "spDataForDownloadUpdate";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }

        public string DeleteDocmentFile(PRPPImageGellery objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@docId", objprp.id);

            ADOprp.SPName = "spDataForDownloadDelete";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }

        public PRPPImageGellery SelectDocmentFile(PRPPImageGellery objprp)
        {
            ADOprpDL = new clsPRPadoDL();
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@docId", objprp.id);
            ADOprpDL.SPName = "spDataForDownloadSelect";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPPImageGellery obj = new PRPPImageGellery(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj.id = ADOprpDL.Dr["docId"].ToString();
                    obj.status = ADOprpDL.Dr["docStatus"].ToString();
                    obj.path = ADOprpDL.Dr["docPath"].ToString();
                    obj.name = ADOprpDL.Dr["docname"].ToString();
                    obj.shortPath = ADOprpDL.Dr["sortpath"].ToString();

                }
            }
            ADO.ReaderClose(ADOprpDL);

            return obj;

        }

        public DataTable ViewDocmentFile()
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.SPName = "spDataForDownload";

            return ADO.DataTableWithProcedures(ADOprp);

        }

        public List<PRPPImageGellery> ViewDocmentFile1(PRPPImageGellery objpr)
        {
            
            ADOprpDL = new clsPRPadoDL();
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@schoolid", objpr.schoolid);
            ADOprpDL.SPName = "spDataForDownload";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            
            PRPPImageGellery objprp;
            List<PRPPImageGellery> lst = new List<PRPPImageGellery>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPPImageGellery();
                    objprp.id = ADOprpDL.Dr["docId"].ToString();
                    objprp.status = ADOprpDL.Dr["docStatus"].ToString();
                    objprp.path = ADOprpDL.Dr["docPath"].ToString();
                    objprp.name = ADOprpDL.Dr["docname"].ToString();
                    objprp.shortPath = ADOprpDL.Dr["sortpath"].ToString();

                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPPImageGellery();
                objprp.id = "Result Not Find";
                lst.Add(objprp);
            }
            ADOprpDL.Dr.Close();
            ADOprpDL.Con.Close();
            
         //   ADO.ReaderClose(ADOprpDL);
            return lst;

        }

        //-------------------------end---document Handler ---------------------------------------


        //----------------------------Availability File ---------------------------------------
        
        public string InsertAvailability(PRPPImageGellery objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[3];
            ADOprp.ArrayPram[0] = new SqlParameter("@AvailabilityName", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@AvailabilityTotal", objprp.total);
            ADOprp.ArrayPram[2] = new SqlParameter("@Availabilitystatus", objprp.status);

            ADOprp.SPName = "sppropertyAvailabilityInsert";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }

        public string UpdateAvailability(PRPPImageGellery objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[4];
            ADOprp.ArrayPram[0] = new SqlParameter("@availabilityId", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@AvailabilityName", objprp.name);
            ADOprp.ArrayPram[2] = new SqlParameter("@AvailabilityTotal", objprp.total);
            ADOprp.ArrayPram[3] = new SqlParameter("@Availabilitystatus", objprp.status);


            ADOprp.SPName = "sppropertyAvailabilityUpdate";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }

        public string DeleteAvailability(PRPPImageGellery objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@availabilityId", objprp.id);

            ADOprp.SPName = "sppropertyAvailabilityDelete";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }

        public PRPPImageGellery SelectAvailability(PRPPImageGellery objprp)
        {
            ADOprpDL = new clsPRPadoDL();
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@availabilityId", objprp.id);
            ADOprpDL.SPName = "sppropertyAvailabilitySelect";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPPImageGellery obj = new PRPPImageGellery(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj.id = ADOprpDL.Dr["availabilityId"].ToString();
                    obj.name = ADOprpDL.Dr["AvailabilityName"].ToString();
                    obj.total = ADOprpDL.Dr["AvailabilityTotal"].ToString();
                    obj.status = ADOprpDL.Dr["Availabilitystatus"].ToString();
                    
                }
            }
            ADO.ReaderClose(ADOprpDL);

            return obj;

        }

        public DataTable ViewAvailability()
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.SPName = "sppropertyAvailability";

            return ADO.DataTableWithProcedures(ADOprp);

        }

        public List<PRPPImageGellery> ViewAvailability1()
        {
            ADOprpDL = new clsPRPadoDL();
            ADOprpDL.SPName = "sppropertyAvailability";

            ADO.ReaderWithProcedures(ADOprpDL);

            PRPPImageGellery objprp;
            List<PRPPImageGellery> lst = new List<PRPPImageGellery>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPPImageGellery();
                    objprp.id = ADOprpDL.Dr["availabilityId"].ToString();
                    objprp.name = ADOprpDL.Dr["AvailabilityName"].ToString();
                    objprp.total = ADOprpDL.Dr["AvailabilityTotal"].ToString();
                    objprp.status = ADOprpDL.Dr["Availabilitystatus"].ToString();
                    
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPPImageGellery();
                objprp.id = "Result Not Find";
                lst.Add(objprp);
            }
            ADOprpDL.Dr.Close();
            ADOprpDL.Con.Close();
            
            //ADO.ReaderClose(ADOprpDL);
            return lst;

        }

        //-------------------------end---Availability file ---------------------------------------


        //----------------------------Availability File ---------------------------------------

        public string InsertPropertyOfTheDay(PRPPImageGellery objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[6];
            ADOprp.ArrayPram[0] = new SqlParameter("@dayNameTitile", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@dayLine1", objprp.line1);
            ADOprp.ArrayPram[2] = new SqlParameter("@dayLine2", objprp.line2);
            ADOprp.ArrayPram[3] = new SqlParameter("@dayLine3", objprp.line3);
            ADOprp.ArrayPram[4] = new SqlParameter("@dayLine4", objprp.line4);
            ADOprp.ArrayPram[5] = new SqlParameter("@dayImagePath", objprp.path);

            ADOprp.SPName = "spPropertyOfTheDayInsert";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }

        public string UpdatePropertyOfTheDay(PRPPImageGellery objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[7];
            ADOprp.ArrayPram[0] = new SqlParameter("@dayId", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@dayNameTitile", objprp.name);
            ADOprp.ArrayPram[2] = new SqlParameter("@dayImagePath", objprp.path);
            ADOprp.ArrayPram[3] = new SqlParameter("@dayLine2", objprp.line2);
            ADOprp.ArrayPram[4] = new SqlParameter("@dayLine3", objprp.line3);
            ADOprp.ArrayPram[5] = new SqlParameter("@dayLine4", objprp.line4);
            ADOprp.ArrayPram[6] = new SqlParameter("@dayLine1", objprp.line1);


            ADOprp.SPName = "spPropertyOfTheDayUpdate";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }

        public string DeletePropertyOfTheDay(PRPPImageGellery objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@dayId", objprp.id);

            ADOprp.SPName = "spPropertyOfTheDayDelete";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }

        public PRPPImageGellery SelectPropertyOfTheDay(PRPPImageGellery objprp)
        {
            ADOprpDL = new clsPRPadoDL();
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@dayId", objprp.id);
            ADOprpDL.SPName = "spPropertyOfTheDaySelect";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPPImageGellery obj = new PRPPImageGellery(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj.id = ADOprpDL.Dr["dayId"].ToString();
                    obj.name = ADOprpDL.Dr["dayNameTitile"].ToString();
                    obj.path = ADOprpDL.Dr["dayImagePath"].ToString();
                    obj.line1 = ADOprpDL.Dr["dayLine1"].ToString();
                    obj.line2 = ADOprpDL.Dr["dayLine2"].ToString();
                    obj.line3 = ADOprpDL.Dr["dayLine3"].ToString();
                    obj.line4 = ADOprpDL.Dr["dayLine4"].ToString();

                }
            }
            ADO.ReaderClose(ADOprpDL);

            return obj;

        }

        public DataTable ViewPropertyOfTheDay()
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.SPName = "spPropertyOfTheDay";

            return ADO.DataTableWithProcedures(ADOprp);

        }


        public DataTable ViewPropertyOfTheDayHome()
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.SPName = "spPropertyOfTheDayHome";

            return ADO.DataTableWithProcedures(ADOprp);

        }

        public List<PRPPImageGellery> ViewPropertyOfTheDayHomeByList()
        {
            ADOprpDL = new clsPRPadoDL();
            ADOprpDL.SPName = "spPropertyOfTheDayHome";

            ADO.ReaderWithProcedures(ADOprpDL);

            PRPPImageGellery objprp;
            List<PRPPImageGellery> lst = new List<PRPPImageGellery>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPPImageGellery();
                    objprp.path = ADOprpDL.Dr["ImageUrl"].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPPImageGellery();
                objprp.id = "Result Not Find";
                lst.Add(objprp);

            }
            ADOprpDL.Dr.Close();
            ADOprpDL.Con.Close();

            //  ADO.ReaderClose(ADOprpDL);
            return lst;

        }

        public List<PRPPImageGellery> ViewPropertyOfTheDay1()
        {
            ADOprpDL = new clsPRPadoDL();
            ADOprpDL.SPName = "spPropertyOfTheDay";

            ADO.ReaderWithProcedures(ADOprpDL);

            PRPPImageGellery objprp;
            List<PRPPImageGellery> lst = new List<PRPPImageGellery>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPPImageGellery();
                    objprp.id = ADOprpDL.Dr["dayId"].ToString();
                    objprp.name = ADOprpDL.Dr["dayNameTitile"].ToString();
                    objprp.path = ADOprpDL.Dr["dayImagePath"].ToString();
                    objprp.line1 = ADOprpDL.Dr["dayLine1"].ToString();
                    objprp.line2 = ADOprpDL.Dr["dayLine2"].ToString();
                    objprp.line3 = ADOprpDL.Dr["dayLine3"].ToString();
                    objprp.line4 = ADOprpDL.Dr["dayLine4"].ToString();
                    objprp.shortPath = ADOprpDL.Dr["dayImagePathshort"].ToString();
                 
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPPImageGellery();
                objprp.id = "Result Not Find";
                lst.Add(objprp);
            
            }
            ADOprpDL.Dr.Close();
            ADOprpDL.Con.Close();
            
          //  ADO.ReaderClose(ADOprpDL);
            return lst;

        }

        public DataTable spImageDetail()
        {

            ADOprp = new clsPRPadoBL();
            ADOprp.SPName = "spImageDetail";
            return ADO.DataTableWithProcedures(ADOprp);
        }


        public string DeleleSellerDetail(PRPEditor objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@id", objprp.Id);

            ADOprp.SPName = "spSellerDetailDelele";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }


        
        //-------------------------end---Availability file ---------------------------------------


        public DataTable spQuickBind(PRPEditor objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[3];
            ADOprp.ArrayPram[0] = new SqlParameter("@Id", objprp.Id);
            ADOprp.ArrayPram[1] = new SqlParameter("@PageType", objprp.pagePositin);
            ADOprp.ArrayPram[2] = new SqlParameter("@tempid", objprp.password);
            ADOprp.SPName = "spQuickBind";

            return ADO.DataTableWithProceduresAndParam(ADOprp);


        }


//---Start Title- Meta Tag Setting.---
        public string insTitlePageWiseMicro(PRPPImageGellery objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[4];
            ADOprp.ArrayPram[0] = new SqlParameter("@name", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@pageId", objprp.caloneyId);
            ADOprp.ArrayPram[2] = new SqlParameter("@collegeId", objprp.schoolid);
            ADOprp.ArrayPram[3] = new SqlParameter("@url", objprp.shortPath);
            ADOprp.SPName = "insTitlePageWiseMicro";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }

        public DataSet spMenuForMicro(PRPEditor objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[2];
            ADOprp.ArrayPram[0] = new SqlParameter("@linkid", objprp.Id);
            ADOprp.ArrayPram[1] = new SqlParameter("@tempid", objprp.State);
            ADOprp.SPName = "spMenuForMicro_srikant_sal1";
            //spMenuForMicro_srikant
            return ADO.DataSetWithProceduresandParam(ADOprp);
        }

        public DataSet spMenuForMicro_srikant_sal_stu(PRPEditor objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[2];
            ADOprp.ArrayPram[0] = new SqlParameter("@linkid", objprp.Id);
            ADOprp.ArrayPram[1] = new SqlParameter("@tempid", objprp.State);
            ADOprp.SPName = "spMenuForMicro_srikant_sal_stu";
            //spMenuForMicro_srikant
            return ADO.DataSetWithProceduresandParam(ADOprp);
        }

        public PRPPImageGellery selTitlePageWiseMicro(PRPPImageGellery objprp)
        {
            ADOprpDL = new clsPRPadoDL();
            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageId", objprp.caloneyId);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@collegeId", objprp.schoolid);
            ADOprpDL.SPName = "selTitlePageWiseMicro_sal";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPPImageGellery obj = new PRPPImageGellery(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj.id = ADOprpDL.Dr["id"].ToString();
                    obj.name = ADOprpDL.Dr["name"].ToString();
                    obj.caloneyName = ADOprpDL.Dr["caloneyName"].ToString();
                    obj.shortPath = ADOprpDL.Dr["tURL"].ToString();
                }
            }

            ADO.ReaderClose(ADOprpDL);

            return obj;

        }
     
//---End Title - Meta Tag Setting---

//---Start Title- Meta Tag Setting.---
        public string insMetaPageWiseMicro(PRPPImageGellery objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[4];
            ADOprp.ArrayPram[0] = new SqlParameter("@name", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@description", objprp.imageDescription);
            ADOprp.ArrayPram[2] = new SqlParameter("@pageId", objprp.caloneyId);
            ADOprp.ArrayPram[3] = new SqlParameter("@collegeId", objprp.schoolid);
            ADOprp.SPName = "insMetaPageWiseMicro";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }
        public string updMetaPageWiseMicro(PRPPImageGellery objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[3];
            ADOprp.ArrayPram[0] = new SqlParameter("@name", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@mid", objprp.id);
            ADOprp.ArrayPram[2] = new SqlParameter("@description", objprp.imageDescription);
            ADOprp.SPName = "updMetaPageWiseMicro";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string delMetaPageWiseMicro(PRPPImageGellery objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@mId", objprp.id);

            ADOprp.SPName = "delMetaPageWiseMicro";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }
        public PRPPImageGellery selMetaPageWiseMicro(PRPPImageGellery objprp)
        {
            ADOprpDL = new clsPRPadoDL();
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@mId", objprp.id);
            ADOprpDL.SPName = "selMetaPageWiseMicro";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPPImageGellery obj = new PRPPImageGellery(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj.id = ADOprpDL.Dr["id"].ToString();
                    obj.name = ADOprpDL.Dr["name"].ToString();
                    obj.imageDescription = ADOprpDL.Dr["mDescription"].ToString();
                    obj.caloneyName = ADOprpDL.Dr["caloneyName"].ToString();
                }
            }
            ADO.ReaderClose(ADOprpDL);

            return obj;

        }
        public List<PRPPImageGellery> viewMetaPageWiseMicro(PRPPImageGellery objpram)
        {
            ADOprpDL = new clsPRPadoDL();
            ADOprpDL.ArrayPram = new SqlParameter[2];

            ADOprpDL.SPName = "viewMetaPageWiseMicro_sal";

            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageId", objpram.caloneyId);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@collegeId", objpram.schoolid);


            ADO.ReaderWithProceduresandParam(ADOprpDL);


            PRPPImageGellery objprp;
            List<PRPPImageGellery> lst = new List<PRPPImageGellery>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPPImageGellery();
                    objprp.id = ADOprpDL.Dr["id"].ToString();
                    objprp.name = ADOprpDL.Dr["name"].ToString();
                    objprp.imageDescription = ADOprpDL.Dr["mDescription"].ToString();
                    objprp.caloneyName = ADOprpDL.Dr["caloneyName"].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPPImageGellery();
                objprp.id = "Result Not Find";
                lst.Add(objprp);
            }
            ADOprpDL.Dr.Close();
            ADOprpDL.Con.Close();

            //ADO.ReaderClose(ADOprpDL);
            return lst;

        }
//---End Title -  Setting---   

        //--Start Enquiry form-------------------
        public string InsertEnquiry(PRPEditor objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[6];
            ADOprp.ArrayPram[0] = new SqlParameter("@firstName", objprp.FistName);
            ADOprp.ArrayPram[1] = new SqlParameter("@lastName", objprp.LastName);
            ADOprp.ArrayPram[2] = new SqlParameter("@emailId", objprp.Email);
            ADOprp.ArrayPram[3] = new SqlParameter("@mobileNo", objprp.mobileNo1);
            ADOprp.ArrayPram[4] = new SqlParameter("@remarks", objprp.newsDescription);
            ADOprp.ArrayPram[5] = new SqlParameter("@collegeId", objprp.SchoolId);
            ADOprp.SPName = "insEnquiry";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string UpdateEnquiry(PRPEditor objprp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[2];
            ADOprp.ArrayPram[0] = new SqlParameter("@id", objprp.Id);
            ADOprp.ArrayPram[1] = new SqlParameter("@status", objprp.newsDescription);
            ADOprp.SPName = "SpUpdatestuenqury";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public List<PRPEditor> viewEnquiry(PRPEditor prp)
        {
            ADOprpDL = new clsPRPadoDL();
            ADOprpDL.ArrayPram = new SqlParameter[3];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.ArrayPram[2] = new SqlParameter("@collegeId", prp.SchoolId);
            ADOprpDL.SPName = "spviewEnquiry";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPEditor objprp;
            List<PRPEditor> lst = new List<PRPEditor>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPEditor();
                    objprp.Id = ADOprpDL.Dr["Id"].ToString();
                    objprp.FistName = ADOprpDL.Dr["firstName"].ToString();
                    objprp.LastName = ADOprpDL.Dr["lastName"].ToString();
                    objprp.Email = ADOprpDL.Dr["emailId"].ToString();
                    objprp.mobileNo1 = ADOprpDL.Dr["mobileNo"].ToString();
                    objprp.newsDescription = ADOprpDL.Dr["remarks"].ToString();
                    objprp.courseDescription = ADOprpDL.Dr["markStatus"].ToString();
                    objprp.date = ADOprpDL.Dr["Date"].ToString();
                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPEditor();
                    objprp.State = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPEditor();
                objprp.State = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
        public string DelEnquiry(PRPEditor prp)
        {
            ADOprp = new clsPRPadoBL();
            ADOprp.ArrayPram = new SqlParameter[1];

            ADOprp.ArrayPram[0] = new SqlParameter("@id", prp.Id);

            ADOprp.SPName = "delInquery";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        //----End Enquiry form----------------
    }
}
