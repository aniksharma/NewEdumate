
function validate(con) {

    var errid = document.getElementById('Err'); var err; //alert('err='+errid.value);
    var Form = document.getElementById('aspnetForm');
    var obj = document.getElementById(con);
    var objl = document.getElementById(con + 'L');
    var objm = document.getElementById(con + 'M');
    document.getElementById(con).style.border = "solid 2px #999";

    if (con == 'ctl00_ContentPlaceHolder1_ddlUniversity') 
    {
        var data = Form.ctl00_ContentPlaceHolder1_ddlUniversity.selectedIndex;
        //  alert(data);
        if (data == 0) {
            objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
        }
        else {
            objl.innerHTML = "<img src='../validation/images/accept.png' alt='Correct..'/>"; err = errid.value; err = parseInt(err) - 1; errid.value = err; return;
        }
    }
    //Class
    if (con == 'ctl00_ContentPlaceHolder1_ddlCourseType') {
        var data = Form.ctl00_ContentPlaceHolder1_ddlCourseType.selectedIndex;
        //  alert(data);
        if (data == 0) {
            objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
        }
        else {
            objl.innerHTML = "<img src='../validation/images/accept.png' alt='Correct..'/>"; err = errid.value; err = parseInt(err) - 1; errid.value = err; return;
        }
    }
    //Sub Category
    if (con == 'ctl00_ContentPlaceHolder1_ddlSubCourseCate') {
        var data = Form.ctl00_ContentPlaceHolder1_ddlSubCourseCate.selectedIndex;
        //  alert(data);
        if (data == 0) {
            objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
        }
        else {
            objl.innerHTML = "<img src='../validation/images/accept.png' alt='Correct..'/>"; err = errid.value; err = parseInt(err) - 1; errid.value = err; return;
        }
    }
    //Sub Duration
    if (con == 'ctl00_ContentPlaceHolder1_ddlDuration') {
        var data = Form.ctl00_ContentPlaceHolder1_ddlDuration.selectedIndex;
        //  alert(data);
        if (data == 0) {
            objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
        }
        else {
            objl.innerHTML = "<img src='../validation/images/accept.png' alt='Correct..'/>"; err = errid.value; err = parseInt(err) - 1; errid.value = err; return;
        }
    }
    //LongDescription
    if (con == 'ctl00_ContentPlaceHolder1_LongDescription') {
        var data = Form.ctl00_ContentPlaceHolder1_LongDescription.value; //var obj1=document.getElementById('usernL');
         if (data == "") {
             // alert('Please Insert DOB');
             document.getElementById("ctl00_ContentPlaceHolder1_LongDescription").focus();
             objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
             return false;

         }
         else {
             objl.innerHTML = "<img src='../validation/images/accept.png' alt='Correct.'/>"; err = errid.value; err = parseInt(err) - 1; errid.value = err; return;
         }
     }
    //Email
   if (con == 'ctl00_ContentPlaceHolder1_txtemail') {
        var data = Form.ctl00_ContentPlaceHolder1_txtemail.value;
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
    //verify email
    if (con == 'ctl00_ContentPlaceHolder1_Txtvaryfy') {
        var data = Form.ctl00_ContentPlaceHolder1_txtemail.value;
        var cdata = Form.ctl00_ContentPlaceHolder1_Txtvaryfy.value;
        var cdata2 = Form.ctl00_ContentPlaceHolder1_Txtvaryfy.value;
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
    //password validate
    if (con == 'ctl00_ContentPlaceHolder1_txtpassword') {
        var data = Form.ctl00_ContentPlaceHolder1_txtpassword.value;
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
    //confurm pwd
    if (con == 'ctl00_ContentPlaceHolder1_txtpassVaryfy') {//alert('usercp='+con);
        var data = Form.ctl00_ContentPlaceHolder1_txtpassword.value;
        var cdata = Form.ctl00_ContentPlaceHolder1_txtpassVaryfy.value;
        if (data == "") {
            objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
        }
        else {
            if (cdata.length < 3 ||  data != cdata) {
                objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
            }
            else {
                if (data == cdata) {
                    objl.innerHTML = "<img src='../validation/images/accept.png' alt='Correct..'/>"; err = errid.value; err = parseInt(err) - 1; errid.value = err; return;
                }
            }
        }
    }
    //organization name
    if (con == 'ctl00_ContentPlaceHolder1_txttypename') {
        var data = Form.ctl00_ContentPlaceHolder1_txttypename.value;
        // alert(data);
        if (data == "" || data.length < 1) {
            objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
        }
        else {
            objl.innerHTML = "<img src='../validation/images/accept.png' alt='Correct.'/>"; err = errid.value; err = parseInt(err) - 1; errid.value = err; return;
        }
    }
    //organization Address
    if (con == 'ctl00_ContentPlaceHolder1_txtaddress') {
        var data = Form.ctl00_ContentPlaceHolder1_txtaddress.value;
        // alert(data);
        if (data == "" || data.length < 1) {
            objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
        }
        else {
            objl.innerHTML = "<img src='../validation/images/accept.png' alt='Correct.'/>"; err = errid.value; err = parseInt(err) - 1; errid.value = err; return;
        }
    }
    //DateOfBirth
    if (con == 'ctl00_ContentPlaceHolder1_txtAge')
     {
        var data = Form.ctl00_ContentPlaceHolder1_txtAge.value; //var obj1=document.getElementById('usernL');
        if (data == "") {
            // alert('Please Insert DOB');
            document.getElementById("ctl00_ContentPlaceHolder1_txtAge").focus();
            document.getElementById("ctl00_ContentPlaceHolder1_txtAgeL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
            return false;

        }
        else 
        {
            data = data.split('/');
            if (data[0] == "" || data[1] == "" || data[2] == "" && data[0] == null || data[1] == null || data[2] == null) {

                objl.innerHTML = "<img src='../validation/images/cross.png' alt='Correct.'/>"; err = errid.value; err = parseInt(err) - 1; errid.value = err; return;
            }
            else {
                if (isNaN(data[0])) {

                    objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
                }
                else if (isNaN(data[1])) {

                    objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
                }
                else if (isNaN(data[2])) {

                    objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
                }
                else {
                    objl.innerHTML = "<img src='../validation/images/accept.png' alt='Correct.'/>"; err = errid.value; err = parseInt(err) - 1; errid.value = err; return;
                } 
            }
        }
     }
     
     //ShortDescription
     if (con == 'ctl00_ContentPlaceHolder1_ShortDescription') {
         var data = Form.ctl00_ContentPlaceHolder1_ShortDescription.value; //var obj1=document.getElementById('usernL');
         if (data == "") {
             // alert('Please Insert DOB');
             document.getElementById("ctl00_ContentPlaceHolder1_ShortDescription").focus();
             objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
             return false;

         }
         else {
             objl.innerHTML = "<img src='../validation/images/accept.png' alt='Correct.'/>"; err = errid.value; err = parseInt(err) - 1; errid.value = err; return;
         }
     }
    //pincode
    if (con == 'ctl00_ContentPlaceHolder1_txtpincode') {
        var data = Form.ctl00_ContentPlaceHolder1_txtpincode.value;
        // alert(data);
        if (data == "" || data.length < 6) {
            objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
        }
        else {
            if (isNaN(data)) {
                objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
            }
            else {

                objl.innerHTML = "<img src='../validation/images/accept.png' alt='Correct.'/>"; err = errid.value; err = parseInt(err) - 1; errid.value = err; return;
            }
        }
    }
    //Fees
    if (con == 'ctl00_ContentPlaceHolder1_txtCourseFees') {
        var data = Form.ctl00_ContentPlaceHolder1_txtCourseFees.value;
        // alert(data);
        if (data == "" ) {
            objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
        }
        else {
            if (isNaN(data)) {
                objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
            }
            else {

                objl.innerHTML = "<img src='../validation/images/accept.png' alt='Correct.'/>"; err = errid.value; err = parseInt(err) - 1; errid.value = err; return;
            }
        }
    }
    ////Term and Condition
    if (con == 'ctl00_ContentPlaceHolder1_NNeTerm') {
        var data = Form.ctl00_ContentPlaceHolder1_NNeTerm.value;
        // alert(data);
        if (data.checked == false) 
        {
            objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
        }
        else {
            objl.innerHTML = "<img src='../validation/images/accept.png' alt='Correct.'/>"; err = errid.value; err = parseInt(err) - 1; errid.value = err; return;
        }
    }
    //Code
    if (con == 'ctl00_ContentPlaceHolder1_txtcode') {
        var data = Form.ctl00_ContentPlaceHolder1_txtcode.value;
        if (data == "" || data.length < 1) {
            objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
            err = errid.value; err = parseInt(err) + 1; errid.value = err;
            return;
        }
        else {
            if (isNaN(data)) {

                objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
            }
            else {

                objl.innerHTML = "<img src='../validation/images/accept.png' alt='Correct.'/>"; err = errid.value; err = parseInt(err) - 1; errid.value = err; return;
            }
        }
    }
    //Number
    if (con == 'ctl00_ContentPlaceHolder1_txtnumber') {
        var data = Form.ctl00_ContentPlaceHolder1_txtnumber.value;

        if (data == "" || data.length < 1) {
            objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
        }
        else {
            //           if (isNaN(data)) {

            //               objl.innerHTML = "<img src='images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
            //           }
            //           else {

            objl.innerHTML = "<img src='../validation/images/accept.png' alt='Correct.'/>"; err = errid.value; err = parseInt(err) - 1; errid.value = err; return;
            //}
        }
    }
    //fax
    if (con == 'userf') {
        var data = Form.userf.value;
        // alert(data);
        // data == "" ||
        if (data != "") {
            if (data.length < 1) {
                objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
            }
            else {
                if (isNaN(data)) {

                    objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
                }
                else {

                    objl.innerHTML = "<img src='../validation/images/accept.png' alt='Correct.'/>"; err = errid.value; err = parseInt(err) - 1; errid.value = err; return;
                }
            }
        }
    }
    //mobile
    if (con == 'ctl00_ContentPlaceHolder1_txtmobile') {
        var data = Form.ctl00_ContentPlaceHolder1_txtmobile.value;
        // alert(data);
        if (data == "" || data.length < 10 || data.length > 12) {
            objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
        }
        else {
            if (isNaN(data)) {

                objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
            }
            else {

                objl.innerHTML = "<img src='../validation/images/accept.png' alt='Correct.'/>"; err = errid.value; err = parseInt(err) - 1; errid.value = err; return;
            }
        }
    }

}


function validateNumbers() 
        {
            var Form = document.getElementById('form1');
            var checkOK = "0123456789, ";
            var checkStr = Form.ctl00_ContentPlaceHolder1_txtnumber.value;
            var allValid = true;
            var validGroups = true;
            var decPoints = 0;
            var allNum = "";
            for (i = 0; i < checkStr.length; i++) {
                ch = checkStr.charAt(i);
                for (j = 0; j < checkOK.length; j++)
                    if (ch == checkOK.charAt(j))
                    break;
                if (j == checkOK.length) {
                    allValid = false;
                    break;
                }
                allNum += ch;
            }
            if (!allValid) 
            {
                alert("Please enter only digits (numbers) in the Phone field.");
                Form.ctl00_ContentPlaceHolder1_txtnumber.focus();
                return (false);
            }
        }

         function STD(Control) {
            if (Control.value == "STD Code") {
                Control.value = "";
                Control.style.color = "";
            }
        }
         function AgainSTD(Control) {
            if (Control.value.length == 0) {
                Control.value = "STD Code";
                Control.style.color = "Gray";
            }
        }
function validateNumbers1(obj)
 {
    var errid = document.getElementById('Err'); var err;
    var Form = document.getElementById('aspnetForm');
    var checkOK = "0123456789, ";
    var checkStr = Form.ctl00_ContentPlaceHolder1_txtnumber.value;
    var allValid = true;
    var validGroups = true;
    var decPoints = 0;
    var allNum = "";
    for (i = 0; i < checkStr.length; i++) {
        ch = checkStr.charAt(i);
        for (j = 0; j < checkOK.length; j++)
            if (ch == checkOK.charAt(j))
            break;
        if (j == checkOK.length) {
            allValid = false;
            break;
        }
        allNum += ch;
    }
    if (!allValid) {

        obj.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
        Form.ctl00_ContentPlaceHolder1_txtnumber.focus();
        return (false);
    }
    else {
        if (checkStr.length == 0) {
            obj.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
        }
        else {
            obj.innerHTML = "<img src='../validation/images/accept.png' alt='Correct..'/>"; err = errid.value; err = parseInt(err) - 1; errid.value = err; return;
        }
    }

}
////////////////////////////On Submit
function submitdata() 
{
    var data = document.getElementById("ctl00_ContentPlaceHolder1_txtemail").value;

    if (data == "") 
    {
       // alert('fd');
        document.getElementById("ctl00_ContentPlaceHolder1_txtemailL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        //objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        alert('Please enter emailid');
        document.getElementById("ctl00_ContentPlaceHolder1_txtemail").focus();
        return false;
    }
    if (data != "") 
    {
        data = data.split('@');
        if (data[1] == null) {//objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
            alert('Please enter valid email'); document.getElementById("ctl00_ContentPlaceHolder1_txtemail").focus(); return false;
        }
        else {
            var data1 = data[1];
            data1 = data1.split('.'); //alert(data1[1]);
            if (data1[1] == null || data1[1] == "") {
                //objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
                alert('Please enter valid email'); document.getElementById("ctl00_ContentPlaceHolder1_txtemail").focus(); return false;
                document.getElementById("ctl00_ContentPlaceHolder1_txtemailL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";

            }
        }
    }
    // verify email
    var data = document.getElementById("ctl00_ContentPlaceHolder1_Txtvaryfy").value; //var obj1=document.getElementById('usernL');
    var cdata2 = document.getElementById("ctl00_ContentPlaceHolder1_txtemail").value;
    if (data == "" || data != cdata2) 
    {
        //objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        alert('Please verify emailid');
        document.getElementById("ctl00_ContentPlaceHolder1_Txtvaryfy").focus();
        return false;
        document.getElementById("ctl00_ContentPlaceHolder1_TxtvaryfyL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
    }
    //password validate
    var data = document.getElementById("ctl00_ContentPlaceHolder1_txtpassword").value; //obj1=document.getElementById('userpL');
    if (data == "") {
        //objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        alert('Please enter password'); document.getElementById("ctl00_ContentPlaceHolder1_txtpassword").focus(); return false;
    }
    else {
        if (data.length < 6 || data.length > 10) {
           
            alert('Please enter password between six to ten characters'); document.getElementById("ctl00_ContentPlaceHolder1_txtpassword").focus(); return false;
            document.getElementById("ctl00_ContentPlaceHolder1_txtpasswordL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        }
    }
    //confurm pwd
    data = document.getElementById("ctl00_ContentPlaceHolder1_txtpassword").value;
    var cdata = document.getElementById("ctl00_ContentPlaceHolder1_txtpassVaryfy").value; //obj1=document.getElementById('usercpL');
    if (data == "") {
        //objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        alert('Please enter confirm password'); document.getElementById("ctl00_ContentPlaceHolder1_txtpassVaryfy").focus(); return false;
    }
    else {
        if (cdata.length < 6 || cdata.length > 10 || data != cdata) {
            //objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
            alert('Please enter confirm password between six to ten characters'); document.getElementById("ctl00_ContentPlaceHolder1_txtpassVaryfy").focus(); return false;
            document.getElementById("ctl00_ContentPlaceHolder1_txtpassVaryfyL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        }

    }
    ////Type
    if (document.getElementById("ctl00_ContentPlaceHolder1_RadioButtonList1_0").checked == false && document.getElementById("ctl00_ContentPlaceHolder1_RadioButtonList1_1").checked == false && document.getElementById("ctl00_ContentPlaceHolder1_RadioButtonList1_2").checked == false)
         {     alert('Please Select Type');
             //document.getElementById("ctl00_ContentPlaceHolder1_RadioButtonList1_0").focus();
           return false;
          }
////////Select State
   if (document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversity").selectedIndex == 0) {
        alert("Please Select State!");
        document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversity").focus();
        document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversityL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        return false;
       
    }
    ////Distict
    if (document.getElementById("ctl00_ContentPlaceHolder1_ddlDist").selectedIndex == 0) {
        alert("Please Select Distict");
        document.getElementById("ctl00_ContentPlaceHolder1_ddlDist").focus();
        document.getElementById("ctl00_ContentPlaceHolder1_ddlDistL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        return false;
       
    }
////City
    if (document.getElementById("ctl00_ContentPlaceHolder1_ddlCity").selectedIndex == 0) {
        alert("Please Select City!");
        document.getElementById("ctl00_ContentPlaceHolder1_ddlCity").focus();
        document.getElementById("ctl00_ContentPlaceHolder1_ddlCityL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        return false;
        
    }
    //organization name
    var data = document.getElementById("ctl00_ContentPlaceHolder1_txttypename").value; //var obj1=document.getElementById('usernL');
 if (data == "") {
     alert('Please Insert Name');
     document.getElementById("ctl00_ContentPlaceHolder1_txttypename").focus();
     document.getElementById("ctl00_ContentPlaceHolder1_txttypenameL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
     return false;

 }

 //Address
 data = document.getElementById("ctl00_ContentPlaceHolder1_txtaddress").value;
    // alert(data);
    if (data == "" || data.length < 1) {
        alert('Please enter organization address');
        // objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        document.getElementById("ctl00_ContentPlaceHolder1_txtaddress").focus();
        return false;
    }
    //pincode
    data = document.getElementById("ctl00_ContentPlaceHolder1_txtpincode").value;
    // alert(data);
    if (data == "" || data.length < 6) {
        alert('Please enter pincode');
        // objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        document.getElementById("ctl00_ContentPlaceHolder1_txtpincode").focus();
        return false;
    }
    if (isNaN(data)) 
    {
        alert('in pincode Please enter Numbers only');
        document.getElementById("ctl00_ContentPlaceHolder1_txtpincode").focus();
        return false;
    }
    //code
    data = document.getElementById("ctl00_ContentPlaceHolder1_txtcode").value;
    // alert(data);
    if (data == "" || data.length < 1) {
        alert('Please enter code');
        // objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        document.getElementById("ctl00_ContentPlaceHolder1_txtcode").focus();
        return false;
    }
    if (isNaN(data)) 
    {
        alert('In code Please enter Numbers only');
        document.getElementById("ctl00_ContentPlaceHolder1_txtcode").focus();
        return false;
    }
    //Number validateNumbers();
    data = document.getElementById("ctl00_ContentPlaceHolder1_txtnumber").value;
    if (data == "" || data.length < 1) {
        alert('Please enter phone number');
        // objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        if (validateNumbers() == false) 
        {
            alert("Please enter only digits (numbers) in the Phone field.");
            return false;
        }
        document.getElementById("ctl00_ContentPlaceHolder1_txtnumber").focus();
        return false;
    }
    //mobile
         data = document.getElementById("ctl00_ContentPlaceHolder1_txtmobile").value;
    // alert(data);
         if (data == "" || data.length < 10 || data.length > 12) {
        alert('Please enter mobile');
        // objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        document.getElementById("ctl00_ContentPlaceHolder1_txtmobile").focus();
        return false;
    }
    if (isNaN(data)) {
        alert('In mobile Please enter Numbers only');
        document.getElementById("ctl00_ContentPlaceHolder1_txtmobile").focus();
        return false;
    }
    //Terms and conditions 
    //var data2 = document.getElementById("ctl00_ContentPlaceHolder1_NNeTerm").value;
    if (document.getElementById("ctl00_ContentPlaceHolder1_NNeTerm").checked == false) {
        alert('Do you agree with our Terms of Service?');
        document.getElementById("ctl00_ContentPlaceHolder1_NNeTermL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        return false;
    }
    // Captcha code
    var data = document.getElementById("ctl00_ContentPlaceHolder1_Veryfycode").value; //var obj1=document.getElementById('usernL');

    if (data == "") {
        //objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        alert('Please enter Veryfycode code');
        document.getElementById("ctl00_ContentPlaceHolder1_Veryfycode").focus();
        return false;
    }
    //var theForm = document.getElementById('aspnetForm');
   //theForm.Button1_Click();
}
///////////////////////////////Totur validation

////////////////////////////On Totur Submit
function Totursubmitdata() {
    var data = document.getElementById("ctl00_ContentPlaceHolder1_txtemail").value;

    if (data == "") {
        // alert('fd');
        document.getElementById("ctl00_ContentPlaceHolder1_txtemailL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        //objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        alert('Please enter emailid');
        document.getElementById("ctl00_ContentPlaceHolder1_txtemail").focus();
        return false;
    }
    if (data != "") {
        data = data.split('@');
        if (data[1] == null) {//objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
            alert('Please enter valid email'); document.getElementById("ctl00_ContentPlaceHolder1_txtemail").focus(); return false;
        }
        else {
            var data1 = data[1];
            data1 = data1.split('.'); //alert(data1[1]);
            if (data1[1] == null || data1[1] == "") {
                //objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
                alert('Please enter valid email'); document.getElementById("ctl00_ContentPlaceHolder1_txtemail").focus(); return false;
                document.getElementById("ctl00_ContentPlaceHolder1_txtemailL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";

            }
        }
    }
    // verify email
    var data = document.getElementById("ctl00_ContentPlaceHolder1_Txtvaryfy").value; //var obj1=document.getElementById('usernL');
    var cdata2 = document.getElementById("ctl00_ContentPlaceHolder1_txtemail").value;
    if (data == "" || data != cdata2) {
        //objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        alert('Please verify emailid');
        document.getElementById("ctl00_ContentPlaceHolder1_Txtvaryfy").focus();
        return false;
        document.getElementById("ctl00_ContentPlaceHolder1_TxtvaryfyL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
    }
    //password validate
    var data = document.getElementById("ctl00_ContentPlaceHolder1_txtpassword").value; //obj1=document.getElementById('userpL');
    if (data == "") {
        //objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        alert('Please enter password'); document.getElementById("ctl00_ContentPlaceHolder1_txtpassword").focus(); return false;
    }
    else {
        if (data.length < 6 || data.length > 10) {
            //objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
            alert('Please enter password between six to ten characters'); document.getElementById("ctl00_ContentPlaceHolder1_txtpassword").focus(); return false;
            document.getElementById("ctl00_ContentPlaceHolder1_txtpasswordL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        }
    }
    //confurm pwd
    data = document.getElementById("ctl00_ContentPlaceHolder1_txtpassword").value;
    var cdata = document.getElementById("ctl00_ContentPlaceHolder1_txtpassVaryfy").value; //obj1=document.getElementById('usercpL');
    if (data == "") {
        //objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        alert('Please enter confirm password'); document.getElementById("ctl00_ContentPlaceHolder1_txtpassVaryfy").focus(); return false;
    }
    else {
        if (cdata.length < 6 || cdata.length > 10 || data != cdata) {
            //objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
            alert('Please enter confirm password between six to ten characters'); document.getElementById("ctl00_ContentPlaceHolder1_txtpassVaryfy").focus(); return false;
            document.getElementById("ctl00_ContentPlaceHolder1_txtpassVaryfyL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        }

    }
    ////Type
    if (document.getElementById("ctl00_ContentPlaceHolder1_RadioButtonList1_0").checked == false && document.getElementById("ctl00_ContentPlaceHolder1_RadioButtonList1_1").checked == false && document.getElementById("ctl00_ContentPlaceHolder1_RadioButtonList1_2").checked == false) {
        alert('Please Select Type');
        //document.getElementById("ctl00_ContentPlaceHolder1_RadioButtonList1_0").focus();
        return false;
    }
       //organization name
    var data = document.getElementById("ctl00_ContentPlaceHolder1_txttypename").value; //var obj1=document.getElementById('usernL');
    if (data == "") 
    {
        alert('Please Insert Name');
        document.getElementById("ctl00_ContentPlaceHolder1_txttypename").focus();
        document.getElementById("ctl00_ContentPlaceHolder1_txttypenameL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        return false;

    }
    //DOB
    data = document.getElementById("ctl00_ContentPlaceHolder1_txtAge").value;
   if (data == "") 
    {
        alert('Please Insert DOB');
        document.getElementById("ctl00_ContentPlaceHolder1_txtAge").focus();
        document.getElementById("ctl00_ContentPlaceHolder1_txtAgeL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        return false;
    }
    data = document.getElementById("ctl00_ContentPlaceHolder1_txtAge").value;
    if (data != "")    
     {
       data = data.split('/');
       if (data[0] == "" || data[1] == "" || data[2] == "" && data[0] == null || data[1] == null || data[2] == null) 
        {
            alert('Please Insert A Valid Date');
            document.getElementById("ctl00_ContentPlaceHolder1_txtAge").focus();
            objl.innerHTML = "<img src='../validation/images/cross.png' alt='Correct.'/>"; err = errid.value; err = parseInt(err) - 1; errid.value = err; 
            return false; 
        }
        else if (isNaN(data[0]) || isNaN(data[1]) || isNaN(data[2])) 
            {
                alert('Please Insert A Valid Date');
                document.getElementById("ctl00_ContentPlaceHolder1_txtAge").focus();
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
        document.getElementById("ctl00_ContentPlaceHolder1_txtAge").focus();
        return false;
    }
    ////////Select State
    if (document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversity").selectedIndex == 0) 
    {
        alert("Please Select State!");
        document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversity").focus();
        document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversityL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        return false;

    }
    ////Distict
    if (document.getElementById("ctl00_ContentPlaceHolder1_ddlDist").selectedIndex == 0) 
    {
        alert("Please Select Distict");
        document.getElementById("ctl00_ContentPlaceHolder1_ddlDist").focus();
        document.getElementById("ctl00_ContentPlaceHolder1_ddlDistL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        return false;

    }
    ////City
    if (document.getElementById("ctl00_ContentPlaceHolder1_ddlCity").selectedIndex == 0) 
    {
        alert("Please Select City!");
        document.getElementById("ctl00_ContentPlaceHolder1_ddlCity").focus();
        document.getElementById("ctl00_ContentPlaceHolder1_ddlCityL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        return false;

    }

    //Address
    data = document.getElementById("ctl00_ContentPlaceHolder1_txtaddress").value;
    // alert(data);
    if (data == "" || data.length < 1) 
    {
        alert('Please enter organization address');
        // objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        document.getElementById("ctl00_ContentPlaceHolder1_txtaddress").focus();
        return false;
    }
  
    //mobile
    data = document.getElementById("ctl00_ContentPlaceHolder1_txtmobile").value;
    // alert(data);
    if (data == "" || data.length < 10 || data.length > 12) 
    {
        alert('Please enter mobile');
        // objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        document.getElementById("ctl00_ContentPlaceHolder1_txtmobile").focus();
        return false;
    }
    if (isNaN(data)) 
    {
        alert('In mobile Please enter Numbers only');
        document.getElementById("ctl00_ContentPlaceHolder1_txtmobile").focus();
        return false;
    }
    //ShotDescription
    data = document.getElementById("ctl00_ContentPlaceHolder1_ShortDescription").value;
    // alert(data);
    if (data == "" || data.length < 1) 
    {
        alert('Please Enter Education Qualification');
        // objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        document.getElementById("ctl00_ContentPlaceHolder1_ShortDescription").focus();
        return false;
    }
    //ddlCourse Type
    if (document.getElementById("ctl00_ContentPlaceHolder1_ddlCourseType").selectedIndex == 0) 
    {
        alert("Please Select Class");
        document.getElementById("ctl00_ContentPlaceHolder1_ddlCourseType").focus();
        document.getElementById("ctl00_ContentPlaceHolder1_ddlCourseTypeL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        return false;

    }
    
    //select Subsegment
    if (document.getElementById("ctl00_ContentPlaceHolder1_CheckBoxList1").checked == false) 
   {
       alert('Do sub Segment');
       document.getElementById("ctl00_ContentPlaceHolder1_CheckBoxList1").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
       return false;
   }
    //Fees
    data = document.getElementById("ctl00_ContentPlaceHolder1_txtCourseFees").value;
    // alert(data);
    if (data == "" || data.length < 2) 
    {
        alert('Please enter fees');
        // objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        document.getElementById("ctl00_ContentPlaceHolder1_txtCourseFees").focus();
        return false;
    }
    if (isNaN(data)) 
    {
        alert('In Fees Please Insert Numeric Or Decimal Values');
        document.getElementById("ctl00_ContentPlaceHolder1_txtCourseFees").focus();
        return false;
    }
    ////LongDescription
    data = document.getElementById("ctl00_ContentPlaceHolder1_LongDescription").value;
    if (data == "" || data.length < 1) 
    {
        alert('Please Enter Tutoring Approach');
        // objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        document.getElementById("ctl00_ContentPlaceHolder1_LongDescription").focus();
        return false;
    }
    //Terms and conditions 
    //var data2 = document.getElementById("ctl00_ContentPlaceHolder1_NNeTerm").value;
    if (document.getElementById("ctl00_ContentPlaceHolder1_NNeTerm").checked == false) 
    {
        alert('Do you agree with our Terms of Service?');
        document.getElementById("ctl00_ContentPlaceHolder1_NNeTermL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        return false;
    }
    // Captcha code
    var data = document.getElementById("ctl00_ContentPlaceHolder1_Veryfycode").value; //var obj1=document.getElementById('usernL');

    if (data == "") 
    {
        //objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        alert('Please enter Veryfycode code');
        document.getElementById("ctl00_ContentPlaceHolder1_Veryfycode").focus();
        return false;
    }
    //var theForm = document.getElementById('aspnetForm');
    //theForm.Button1_Click();
}
///////Listing Submit
function submitListingdata() 
{
    //ddlCourse Type 
    if (document.getElementById("ctl00_ContentPlaceHolder1_ddlCourseType").selectedIndex == 0) {
        alert("Please Course Category");
        document.getElementById("ctl00_ContentPlaceHolder1_ddlCourseType").focus();
        document.getElementById("ctl00_ContentPlaceHolder1_ddlCourseTypeL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        return false;

    }
    //Subcategory Type

    if (document.getElementById("ctl00_ContentPlaceHolder1_ddlSubCourseCate").selectedIndex == 0) {
        alert("Please Select SubCategory");
        document.getElementById("ctl00_ContentPlaceHolder1_ddlSubCourseCate").focus();
        document.getElementById("ctl00_ContentPlaceHolder1_ddlSubCourseCateL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        return false;

    }
    //Duration Of Course
    if (document.getElementById("ctl00_ContentPlaceHolder1_ddlDuration").selectedIndex == 0) {
        alert("Please Subject Duration");
        document.getElementById("ctl00_ContentPlaceHolder1_ddlDuration").focus();
        document.getElementById("ctl00_ContentPlaceHolder1_ddlDurationL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        return false;

    }
    //Fees
    data = document.getElementById("ctl00_ContentPlaceHolder1_txtCourseFees").value;
    // alert(data);
    if (data == "" || data.length < 2) {
        alert('Please enter fees');
        // objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        document.getElementById("ctl00_ContentPlaceHolder1_txtCourseFees").focus();
        return false;
    }
    if (isNaN(data)) {
        alert('In Fees Please Insert Numeric Or Decimal Values');
        document.getElementById("ctl00_ContentPlaceHolder1_txtCourseFees").focus();
        return false;
    }
    
}

