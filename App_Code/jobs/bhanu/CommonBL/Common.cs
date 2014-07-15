using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Linq;

namespace bal.CommonBL
{
    public class Common
    {
        string filename, thumbfile, msg;
        public string uploadFile(FileUpload fu)
        {
            if (fu.HasFile)
            {
                try
                {
                    filename = Path.GetFileName(fu.FileName);
                    string getExt = Path.GetExtension(fu.FileName).ToLower();

                    if (getExt == ".doc" || getExt == ".docx" || getExt == ".pdf")
                    {

                        fu.SaveAs(System.Web.HttpContext.Current.Server.MapPath("~/JobSeaker/Resume/") + filename);
                        msg = "Upload status: File uploaded!";
                        if (getExt == ".doc" || getExt == ".docx")
                        {
                            thumbfile = "word-thumbnail.png";
                        }

                        else
                        {
                            thumbfile = "pdf-icon-large.jpg";
                        }
                    }

                    else
                    {
                        msg = "Upload status: Invalid File upload!";
                        filename = null;
                    }
                    return filename;
                }
                catch (Exception ex)
                {
                    msg = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                    filename = null;
                    return filename;
                }

            }
            else
            {
                msg = "Please select file.";
                filename = null;
                return filename;

            }
        }

        public string uploadFileImage(FileUpload fu)
        {
            if (fu.HasFile)
            {
                try
                {
                    filename = Path.GetFileName(fu.FileName);
                    string getExt = Path.GetExtension(fu.FileName).ToLower();

                    if (getExt == ".jpg" || getExt == ".gif" || getExt == ".png")
                    {

                        fu.SaveAs(System.Web.HttpContext.Current.Server.MapPath("~/InstitutePanel/Profile_Picture/") + filename);
                        msg = "Upload status: File uploaded!";
                        if (getExt == ".doc" || getExt == ".docx")
                        {
                            thumbfile = "word-thumbnail.png";
                        }

                        else
                        {
                            thumbfile = "pdf-icon-large.jpg";
                        }
                    }

                    else
                    {
                        msg = "Upload status: Invalid File upload!";
                        filename = null;
                    }
                    return filename;
                }
                catch (Exception ex)
                {
                    msg = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                    filename = null;
                    return filename;
                }

            }
            else
            {
                msg = "Please select file.";
                filename = null;
                return filename;

            }
        }
    }
}