function popupf(id) {
    // alert('ok');
    $("#GradientLayer").css({
        "opacity": "0.7"
    });
    $("#GradientLayer").fadeIn("slow");
    //document.getElementById('raj').style.visibility = "visible";
    document.getElementById(id).style.display = "block";
   // document.getElementById(id).style.background-color = "#444444";
    //document.getElementById("popup_text").openPopupAtScreen(200, 200, false);:;
    //  document.bgColor = "#444444";
  //   document.body.style.background = "#cccccc";
    // document.body.setAttribute('class', backcss);
    ////document.aspnetForm.style.background = "red";
     // document.body.fadeIn("slow");
    var data="  <div style=\"background: none repeat scroll 0 0 #525252; padding: 10px; z-index: 100000; display: block; width: 350px; left: 278px; top: 456px;\"> <div style=\"background: none repeat scroll 0 0 #6391CC; padding: 12px 10px;\">  <span style=\"float:right; margin-top:-12px;\">   <a href=\"#\" style=\"color:#fff; text-decoration:none;\" onfocus='javascript:closes('ctl00_Resistration_Error');'>X</a>  </span></div> <div style=\"background: none repeat scroll 0 0 #FFFFFF; padding: 10px;\"><div style=\"background-color:#ffffff;text-align:left;\"><div><table width=\"100%\"> <tr><td style=\"height: 22px;text-align:left; padding-left:50px; \" colspan=\"2\"> <p>Sign up now.</p></td></tr>";
    var data1 = " <tr> <td colspan=\"2\" style=\"padding-left:50px;\"><div  style=\"width:205px;\"><a href=\"../Add%20Institute/TutorRegistration.aspx\" style=\"text-decoration:none; line-height:30px; \" >Teacher</a></div> <div  style=\"width:205px;\">  <a href='http://www.edumate.edu.in/other/createprofile.aspx' style=\"text-decoration:none; line-height:30px;\" > Professional/Other</a></div><div  style=\"width:205px;\">  <a href=\"../Add%20Institute/registration.aspx\" style=\"text-decoration:none; line-height:30px;\" > School/College/Institute</a></div>        </td> </tr><tr><td colspan=\"2\" style=\"height:25px\"> </td> </tr>         </table>      </div>  </div> </div> </div>";
    document.getElementById(id).innerHTML = data + data1;
}
////
function closes(id) {
    // alert('ok');
    //document.getElementById('raj').style.visibility = "visible";
    document.getElementById(id).style.display = "none";
    //document.getElementById("popup_text").openPopupAtScreen(200, 200, false);

}