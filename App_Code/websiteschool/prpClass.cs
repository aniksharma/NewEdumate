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
namespace SpSchoolProject
{

public interface prptr
{
String Pid{get;set;}
String Pname{get;set;}
String PDateOfBirth{get;set;}
String PSex{get;set;}
String PNature{get;set;}
String PLanguage{get;set;}
String PGroupCode{get;set;}
String PGroupName{get;set;}
String Pcode{get;set;}
String Psection{get;set;}
String PDescription{get;set;}
String PPriodStart{get;set;}
String PPriodEnd{get;set;}
String UserName{get;set;}
String Password{get;set;}
String oldPassword { get; set; }

}
public class usprp1 : prptr
{
string name, DateOfbirth, sex, nature, language, groupcode, groupname, id, code, section, Description, PriodStart, PriodEnd;
string _password, _username, _oldPassword;
#region prptr Members


public string Password{get{return _password;}set{_password = value;}}
public string UserName{get{return _username;}set{_username = value;}}
public string oldPassword { get { return _oldPassword; } set { _oldPassword = value; } }

public string PPriodStart{get{return PriodStart;}set{PriodStart = value;}}
public string PPriodEnd{get{return PriodEnd;}set{PriodEnd = value;}}
public string PDescription{get{return Description;}set{Description = value;}}
public string Psection{get{return section;}set{section = value;}}
public string Pcode{get{return code;}set{code = value;}}
public string Pid { get { return id; } set { id = value; } }
public string Pname{get{return name;}set{name = value;}}
public string PDateOfBirth{get{return DateOfbirth;}set{DateOfbirth = value;}}
public string PSex{get{return sex;}set{sex = value;}}
public string PNature{get{return nature;}set{nature = value;}}
public string PLanguage{get{return language;}set{language = value;}}
public string PGroupCode{get{return groupcode;}set{groupcode = value;}}
public string PGroupName{get{return groupname;}set{groupname = value;}}

#endregion
}



}