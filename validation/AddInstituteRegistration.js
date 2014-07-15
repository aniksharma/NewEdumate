function Email(con) {

    var errid = document.getElementById('Err'); var err; //alert('err='+errid.value);
    var Form = document.getElementById('aspnetForm');
    var obj = document.getElementById(con);
    var objl = document.getElementById(con + 'L');
    document.getElementById(con).style.border = "solid 2px #999";
    var data = document.getElementById(con).value;
    if (data == "") {
        objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
    }
    if (data != "") {
        data = data.split('@');
        if (data[1] == null)
        { objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return; }
        else {
            var data1 = data[1];
            data1 = data1.split('.'); //alert(data1[1]);
            if (data1[1] == null || data1[1] == "") {
                objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
            }
            else {
                objl.innerHTML = "<img src='../validation/images/accept.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
            }
        }
    }
}


function VaryfyEmail(con) {

    var errid = document.getElementById('Err'); var err; //alert('err='+errid.value);
    var Form = document.getElementById('aspnetForm');
    var obj = document.getElementById(con);
    var objl = document.getElementById(con + 'L');
    document.getElementById(con).style.border = "solid 2px #999";
    var data = Form.ContentPlaceHolder1_txtemail.value;
    var cdata = document.getElementById(con).value;
    var cdata2 = document.getElementById(con).value;
    if (data == "") {
        objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
    }
    if (cdata != "") {
        cdata = cdata.split('@');
        if (cdata[1] == null) { objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return; }
        else {
            var cdata = cdata[1];
            cdata1 = cdata.split('.'); //alert(cdata1[1]);
            if (cdata1[1] == null || cdata[1] == "" || data != cdata2) {
                objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
            }
            else {
                objl.innerHTML = "<img src='../validation/images/accept.png' alt='Correct..'/>"; err = errid.value; err = parseInt(err) - 1; errid.value = err; return;
            }
        }
    }
   }
function Password(con) {

    var errid = document.getElementById('Err'); var err; //alert('err='+errid.value);
    var Form = document.getElementById('aspnetForm');
    var obj = document.getElementById(con);
    var objl = document.getElementById(con + 'L');
    document.getElementById(con).style.border = "solid 2px #999";
    var data = document.getElementById(con).value;
    if (data == "") {
        objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
    }
    else {
        if (data.length < 6 || data.length > 10) {
            alert('Give Password between 6 to 10');
            objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
        }
        else {
            objl.innerHTML = "<img src='../validation/images/accept.png' alt='Correct..'/>"; err = errid.value; err = parseInt(err) - 1; errid.value = err; return;
        }
    }
  }
function VaryfyPassword(con) {

    var errid = document.getElementById('Err'); var err; //alert('err='+errid.value);
    var Form = document.getElementById('aspnetForm');
    var obj = document.getElementById(con);
    var objl = document.getElementById(con + 'L');
    document.getElementById(con).style.border = "solid 2px #999";
    var data = Form.ContentPlaceHolder1_txtpassword.value;
    var cdata = document.getElementById(con).value;
    if (data == "") {
        objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
    }
    else {
        if (cdata.length < 3 || data != cdata) {
            objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
        }
        else {
            if (data == cdata) {
                objl.innerHTML = "<img src='../validation/images/accept.png' alt='Correct..'/>"; err = errid.value; err = parseInt(err) - 1; errid.value = err; return;
            }
        }
    }
 }
function Required(con) {
//alert('ok');
    var errid = document.getElementById('Err'); var err; //alert('err='+errid.value);
    var Form = document.getElementById('aspnetForm');
    var obj = document.getElementById(con);
    var objl = document.getElementById(con + 'L');
    document.getElementById(con).style.border = "solid 2px #999";
    var data = document.getElementById(con).value;
    // alert(data);
    if (data == "" || data.length < 1) {
        objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
    }
    else {
        objl.innerHTML = "<img src='../validation/images/accept.png' alt='Correct..'/>"; err = errid.value; err = parseInt(err) - 1; errid.value = err; return;
    }
  }

function DropDown(con) {

    var errid = document.getElementById('Err'); var err; //alert('err='+errid.value);
    var Form = document.getElementById('aspnetForm');
    var obj = document.getElementById(con);
    var objl = document.getElementById(con + 'L');
    document.getElementById(con).style.border = "solid 2px #999";
    var data = document.getElementById(con).selectedIndex;
    //  alert(data);
    if (data == 0) {
        objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
    }
    else {
        objl.innerHTML = "<img src='../validation/images/accept.png' alt='Correct..'/>"; err = errid.value; err = parseInt(err) - 1; errid.value = err; return;
    }
  }

function Mobile(con) {

    var errid = document.getElementById('Err'); var err; //alert('err='+errid.value);
    var Form = document.getElementById('aspnetForm');
    var obj = document.getElementById(con);
    var objl = document.getElementById(con + 'L');
    document.getElementById(con).style.border = "solid 2px #999";
    data = document.getElementById(con).value;
    // alert(data);
    if (data == "" || data.length < 10 || data.length > 12) {
        //  alert('Please enter mobile');
       objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
     }
    if (isNaN(data)) {
        // alert('In mobile Please enter Numbers only');
        document.getElementById(con).focus();
        objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
      }
    else {
        objl.innerHTML = "<img src='../validation/images/accept.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
    }
}

////////////////////////////On Submit
function submitdata() {
    //alert('ok');
    var data = document.getElementById("ContentPlaceHolder1_txtemail").value;

    if (data == "") {
        // alert('fd');
        document.getElementById("ContentPlaceHolder1_txtemailL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        //objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        alert('Please enter emailid');
        document.getElementById("ContentPlaceHolder1_txtemail").focus();
        return false;
    }
    if (data != "") {
        data = data.split('@');
        if (data[1] == null) {//objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
            alert('Please enter valid email'); document.getElementById("ContentPlaceHolder1_txtemail").focus(); return false;
        }
        else {
            var data1 = data[1];
            data1 = data1.split('.'); //alert(data1[1]);
            if (data1[1] == null || data1[1] == "") {
                //objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
                alert('Please enter valid email'); document.getElementById("ContentPlaceHolder1_txtemail").focus(); return false;
                document.getElementById("ContentPlaceHolder1_txtemailL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";

            }
        }
    }
    // verify email
    var data = document.getElementById("ContentPlaceHolder1_Txtvaryfy").value; //var obj1=document.getElementById('usernL');
    var cdata2 = document.getElementById("ContentPlaceHolder1_txtemail").value;
    if (data == "" || data != cdata2) {
        //objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        alert('Please verify emailid');
        document.getElementById("ContentPlaceHolder1_Txtvaryfy").focus();
        return false;
        document.getElementById("ContentPlaceHolder1_TxtvaryfyL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
    }
    //password validate
    var data = document.getElementById("ContentPlaceHolder1_txtpassword").value; //obj1=document.getElementById('userpL');
    if (data == "") {
        //objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        alert('Please enter password'); document.getElementById("ContentPlaceHolder1_txtpassword").focus(); return false;
    }
    else {
        if (data.length < 6 || data.length > 10) {

            alert('Please enter password between six to ten characters'); document.getElementById("ContentPlaceHolder1_txtpassword").focus(); return false;
            document.getElementById("ContentPlaceHolder1_txtpasswordL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        }
    }
    //confurm pwd
    data = document.getElementById("ContentPlaceHolder1_txtpassword").value;
    var cdata = document.getElementById("ContentPlaceHolder1_txtpassVaryfy").value; //obj1=document.getElementById('usercpL');
    if (data == "") {
        //objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        alert('Please enter confirm password'); document.getElementById("ContentPlaceHolder1_txtpassVaryfy").focus(); return false;
    }
    else {
        if (cdata.length < 6 || cdata.length > 10 || data != cdata) {
            //objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
            alert('Please enter confirm password between six to ten characters'); document.getElementById("ContentPlaceHolder1_txtpassVaryfy").focus(); return false;
            document.getElementById("ContentPlaceHolder1_txtpassVaryfyL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        }

    }
    ////Type
    if (document.getElementById("ContentPlaceHolder1_RadioButtonList1_0").checked == false && document.getElementById("ContentPlaceHolder1_RadioButtonList1_1").checked == false && document.getElementById("ContentPlaceHolder1_RadioButtonList1_2").checked == false) {
        alert('Please Select Type');
        //document.getElementById("ContentPlaceHolder1_RadioButtonList1_0").focus();
        return false;
    }
    //organization name
    var data = document.getElementById("ContentPlaceHolder1_txttypename").value; //var obj1=document.getElementById('usernL');
    if (data == "") {
        alert('Please Insert Name');
        document.getElementById("ContentPlaceHolder1_txttypename").focus();
        document.getElementById("ContentPlaceHolder1_txttypenameL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        return false;

    }
    ////////Select State
    if (document.getElementById("ContentPlaceHolder1_ddlUniversity").selectedIndex == 0) {
        alert("Please Select State!");
        document.getElementById("ContentPlaceHolder1_ddlUniversity").focus();
        document.getElementById("ContentPlaceHolder1_ddlUniversityL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        return false;

    }
    ////Distict
    if (document.getElementById("ContentPlaceHolder1_ddlDist").selectedIndex == 0) {
        alert("Please Select Distict");
        document.getElementById("ContentPlaceHolder1_ddlDist").focus();
        document.getElementById("ContentPlaceHolder1_ddlDistL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        return false;

    }
    ////City
    if (document.getElementById("ContentPlaceHolder1_ddlCity").selectedIndex == 0) {
        alert("Please Select City!");
        document.getElementById("ContentPlaceHolder1_ddlCity").focus();
        document.getElementById("ContentPlaceHolder1_ddlCityL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        return false;

    }
   

    //Address
    data = document.getElementById("ContentPlaceHolder1_txtaddress").value;
    // alert(data);
    if (data == "" || data.length < 1) {
        alert('Please enter organization address');
        // objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        document.getElementById("ContentPlaceHolder1_txtaddress").focus();
        return false;
    }
    //pincode
    data = document.getElementById("ContentPlaceHolder1_txtpincode").value;
    // alert(data);
    if (data == "" || data.length < 6) {
        alert('Please enter pincode');
        // objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        document.getElementById("ContentPlaceHolder1_txtpincode").focus();
        return false;
    }
    if (isNaN(data)) {
        alert('in pincode Please enter Numbers only');
        document.getElementById("ContentPlaceHolder1_txtpincode").focus();
        return false;
    }
    //code

    //mobile
    data = document.getElementById("ContentPlaceHolder1_txtmobile").value;
    // alert(data);
    if (data == "" || data.length < 10 || data.length > 12) {
        alert('Please enter mobile');
        // objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        document.getElementById("ContentPlaceHolder1_txtmobile").focus();
        return false;
    }
    if (isNaN(data)) {
        alert('In mobile Please enter Numbers only');
        document.getElementById("ContentPlaceHolder1_txtmobile").focus();
        return false;
    }
    //Terms and conditions 
    //var data2 = document.getElementById("ContentPlaceHolder1_NNeTerm").value;
    if (document.getElementById("ContentPlaceHolder1_NNeTerm").checked == false) {
        alert('Do you agree with our Terms of Service?');
        document.getElementById("ContentPlaceHolder1_NNeTermL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        return false;
    }
    // Captcha code
    var data = document.getElementById("ContentPlaceHolder1_Veryfycode").value; //var obj1=document.getElementById('usernL');

    if (data == "") {
        //objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        alert('Please enter Veryfycode code');
        document.getElementById("ContentPlaceHolder1_Veryfycode").focus();
        return false;
    }
    //var theForm = document.getElementById('aspnetForm');
    //theForm.Button1_Click();
}


///////////////////////////////Totur validation

////////////////////////////On Totur Submit
function Totursubmitdata() {
    var data = document.getElementById("ContentPlaceHolder1_txtemail").value;

    if (data == "") {
        // alert('fd');
        document.getElementById("ContentPlaceHolder1_txtemailL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        //objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        alert('Please enter emailid');
        document.getElementById("ContentPlaceHolder1_txtemail").focus();
        return false;
    }
    if (data != "") {
        data = data.split('@');
        if (data[1] == null) {//objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
            alert('Please enter valid email'); document.getElementById("ContentPlaceHolder1_txtemail").focus(); return false;
        }
        else {
            var data1 = data[1];
            data1 = data1.split('.'); //alert(data1[1]);
            if (data1[1] == null || data1[1] == "") {
                //objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
                alert('Please enter valid email'); document.getElementById("ContentPlaceHolder1_txtemail").focus(); return false;
                document.getElementById("ContentPlaceHolder1_txtemailL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";

            }
        }
    }
    // verify email
    var data = document.getElementById("ContentPlaceHolder1_Txtvaryfy").value; //var obj1=document.getElementById('usernL');
    var cdata2 = document.getElementById("ContentPlaceHolder1_txtemail").value;
    if (data == "" || data != cdata2) {
        //objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        alert('Please verify emailid');
        document.getElementById("ContentPlaceHolder1_Txtvaryfy").focus();
        return false;
        document.getElementById("ContentPlaceHolder1_TxtvaryfyL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
    }
    //password validate
    var data = document.getElementById("ContentPlaceHolder1_txtpassword").value; //obj1=document.getElementById('userpL');
    if (data == "") {
        //objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        alert('Please enter password'); document.getElementById("ContentPlaceHolder1_txtpassword").focus(); return false;
    }
    else {
        if (data.length < 6 || data.length > 10) {
            //objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
            alert('Please enter password between six to ten characters'); document.getElementById("ContentPlaceHolder1_txtpassword").focus(); return false;
            document.getElementById("ContentPlaceHolder1_txtpasswordL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        }
    }
    //confurm pwd
    data = document.getElementById("ContentPlaceHolder1_txtpassword").value;
    var cdata = document.getElementById("ContentPlaceHolder1_txtpassVaryfy").value; //obj1=document.getElementById('usercpL');
    if (data == "") {
        //objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        alert('Please enter confirm password'); document.getElementById("ContentPlaceHolder1_txtpassVaryfy").focus(); return false;
    }
    else {
        if (cdata.length < 6 || cdata.length > 10 || data != cdata) {
            //objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
            alert('Please enter confirm password between six to ten characters'); document.getElementById("ContentPlaceHolder1_txtpassVaryfy").focus(); return false;
            document.getElementById("ContentPlaceHolder1_txtpassVaryfyL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        }

    }
    ////Type
    if (document.getElementById("ContentPlaceHolder1_RadioButtonList1_0").checked == false && document.getElementById("ContentPlaceHolder1_RadioButtonList1_1").checked == false && document.getElementById("ContentPlaceHolder1_RadioButtonList1_2").checked == false) {
        alert('Please Select Type');
        //document.getElementById("ContentPlaceHolder1_RadioButtonList1_0").focus();
        return false;
    }
    //organization name
    var data = document.getElementById("ContentPlaceHolder1_txttypename").value; //var obj1=document.getElementById('usernL');
    if (data == "") {
        alert('Please Insert Name');
        document.getElementById("ContentPlaceHolder1_txttypename").focus();
        document.getElementById("ContentPlaceHolder1_txttypenameL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        return false;

    }
    //DOB
    data = document.getElementById("ContentPlaceHolder1_txtAge").value;
    if (data == "") {
        alert('Please Insert DOB');
        document.getElementById("ContentPlaceHolder1_txtAge").focus();
        document.getElementById("ContentPlaceHolder1_txtAgeL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        return false;
    }
    data = document.getElementById("ContentPlaceHolder1_txtAge").value;
    if (data != "") {
        data = data.split('/');
        if (data[0] == "" || data[1] == "" || data[2] == "" && data[0] == null || data[1] == null || data[2] == null) {
            alert('Please Insert A Valid Date');
            document.getElementById("ContentPlaceHolder1_txtAge").focus();
            objl.innerHTML = "<img src='../validation/images/cross.png' alt='Correct.'/>"; err = errid.value; err = parseInt(err) - 1; errid.value = err;
            return false;
        }
        else if (isNaN(data[0]) || isNaN(data[1]) || isNaN(data[2])) {
            alert('Please Insert A Valid Date');
            document.getElementById("ContentPlaceHolder1_txtAge").focus();
            objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err;
            return false;
        }
    }
    //        else
    //         {
    //            objl.innerHTML = "<img src='../validation/images/accept.png' alt='Correct.'/>"; err = errid.value; err = parseInt(err) - 1; errid.value = err; return;
    //        }

    if (data == "" || data.length < 1) {
        alert('Please Enter DOB');
        // objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        document.getElementById("ContentPlaceHolder1_txtAge").focus();
        return false;
    }
    ////////Select State
    if (document.getElementById("ContentPlaceHolder1_ddlUniversity").selectedIndex == 0) {
        alert("Please Select State!");
        document.getElementById("ContentPlaceHolder1_ddlUniversity").focus();
        document.getElementById("ContentPlaceHolder1_ddlUniversityL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        return false;

    }
    ////Distict
    if (document.getElementById("ContentPlaceHolder1_ddlDist").selectedIndex == 0) {
        alert("Please Select Distict");
        document.getElementById("ContentPlaceHolder1_ddlDist").focus();
        document.getElementById("ContentPlaceHolder1_ddlDistL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        return false;

    }
    ////City
    if (document.getElementById("ContentPlaceHolder1_ddlCity").selectedIndex == 0) {
        alert("Please Select City!");
        document.getElementById("ContentPlaceHolder1_ddlCity").focus();
        document.getElementById("ContentPlaceHolder1_ddlCityL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        return false;

    }

    //Address
    data = document.getElementById("ContentPlaceHolder1_txtaddress").value;
    // alert(data);
    if (data == "" || data.length < 1) {
        alert('Please enter organization address');
        // objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        document.getElementById("ContentPlaceHolder1_txtaddress").focus();
        return false;
    }

    //mobile
    data = document.getElementById("ContentPlaceHolder1_txtmobile").value;
    // alert(data);
    if (data == "" || data.length < 10 || data.length > 12) {
        alert('Please enter mobile');
        // objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        document.getElementById("ContentPlaceHolder1_txtmobile").focus();
        return false;
    }
    if (isNaN(data)) {
        alert('In mobile Please enter Numbers only');
        document.getElementById("ContentPlaceHolder1_txtmobile").focus();
        return false;
    }
    //ShotDescription
    data = document.getElementById("ContentPlaceHolder1_ShortDescription").value;
    // alert(data);
    if (data == "" || data.length < 1) {
        alert('Please Enter Education Qualification');
        // objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        document.getElementById("ContentPlaceHolder1_ShortDescription").focus();
        return false;
    }
    //ddlCourse Type
    if (document.getElementById("ContentPlaceHolder1_ddlCourseType").selectedIndex == 0) {
        alert("Please Select Class");
        document.getElementById("ContentPlaceHolder1_ddlCourseType").focus();
        document.getElementById("ContentPlaceHolder1_ddlCourseTypeL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        return false;

    }

    //select Subsegment
    if (document.getElementById("ContentPlaceHolder1_CheckBoxList1").checked == false) {
        alert('Do sub Segment');
        document.getElementById("ContentPlaceHolder1_CheckBoxList1").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        return false;
    }
    //Fees
    data = document.getElementById("ContentPlaceHolder1_txtCourseFees").value;
    // alert(data);
    if (data == "" || data.length < 2) {
        alert('Please enter fees');
        // objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        document.getElementById("ContentPlaceHolder1_txtCourseFees").focus();
        return false;
    }
    if (isNaN(data)) {
        alert('In Fees Please Insert Numeric Or Decimal Values');
        document.getElementById("ContentPlaceHolder1_txtCourseFees").focus();
        return false;
    }
    ////LongDescription
    data = document.getElementById("ContentPlaceHolder1_LongDescription").value;
    if (data == "" || data.length < 1) {
        alert('Please Enter Tutoring Approach');
        // objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        document.getElementById("ContentPlaceHolder1_LongDescription").focus();
        return false;
    }
    //Terms and conditions 
    //var data2 = document.getElementById("ContentPlaceHolder1_NNeTerm").value;
    if (document.getElementById("ContentPlaceHolder1_NNeTerm").checked == false) {
        alert('Do you agree with our Terms of Service?');
        document.getElementById("ContentPlaceHolder1_NNeTermL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        return false;
    }
    // Captcha code
    var data = document.getElementById("ContentPlaceHolder1_Veryfycode").value; //var obj1=document.getElementById('usernL');

    if (data == "") {
        //objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        alert('Please enter Veryfycode code');
        document.getElementById("ContentPlaceHolder1_Veryfycode").focus();
        return false;
    }
    //var theForm = document.getElementById('aspnetForm');
    //theForm.Button1_Click();
}
