function CountCharacter(con) {
    //  var obj = document.getElementById(con);
    //  if (con == 'txtPhone') {
    var data = document.getElementById(con).value.length;
    // form1.Label3.innerHTML = data;
    if (data == "101" || data > "100") {
        //alert(document.getElementById(con).value.length);
        alert('You Can Send Only 100 character Queery');
    }
    else {
        //alert('low');
        document.getElementById('<%=Label1.ClientID%>').innerHTML = data + " <b>OF</b> 100";
    }
    //  }
}

function STD(Control) {
  //  if (Control.value == "STD Code") {
    document.getElementById(Control).value = "";
    document.getElementById(Control).style.color = "";
   // }
}
function AgainSTD(Control) {
    if (document.getElementById(Control).value.length == 0) {
       // Control.value = "STD Code";
        document.getElementById(Control).style.color = "Gray";
    }
}
function Email(con) 
{

    var errid = document.getElementById('Err'); var err; //alert('err='+errid.value);
    var Form = document.getElementById('aspnetForm');
    var obj = document.getElementById(con);
    var objl = document.getElementById(con + 'L');
    document.getElementById(con).style.border = "solid 2px #999";
    //Email
    //if (con == 'ctl00_ContentPlaceHolder1_txtemail') {
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
        //}
       // AgainSTD(con);
}
function VaryfyEmail(con) {

    var errid = document.getElementById('Err'); var err; //alert('err='+errid.value);
    var Form = document.getElementById('aspnetForm');
    var obj = document.getElementById(con);
    var objl = document.getElementById(con + 'L');
    document.getElementById(con).style.border = "solid 2px #999";
    //verify email
    //if (con == 'ctl00_ContentPlaceHolder1_Txtvaryfy') {
        var data = Form.ctl00_ContentPlaceHolder1_txtemail.value;
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
        //}
       // AgainSTD(con);
}
function Password(con) {

    var errid = document.getElementById('Err'); var err; //alert('err='+errid.value);
    var Form = document.getElementById('aspnetForm');
    var obj = document.getElementById(con);
    var objl = document.getElementById(con + 'L');
    document.getElementById(con).style.border = "solid 2px #999";
    //password validate
  // if (con == 'ctl00_ContentPlaceHolder1_txtpassword') {
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
        // }
       // AgainSTD(con);
}
function VaryfyPassword(con) {

    var errid = document.getElementById('Err'); var err; //alert('err='+errid.value);
    var Form = document.getElementById('aspnetForm');
    var obj = document.getElementById(con);
    var objl = document.getElementById(con + 'L');
    document.getElementById(con).style.border = "solid 2px #999";
    //confurm pwd
 //  if (con == 'ctl00_ContentPlaceHolder1_txtpassVaryfy') {//alert('usercp='+con);
        var data = Form.ctl00_ContentPlaceHolder1_txtpassword.value;
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
        // }
       // AgainSTD(con);
}
function Required(con) {

    var errid = document.getElementById('Err'); var err; //alert('err='+errid.value);
    var Form = document.getElementById('aspnetForm');
    var obj = document.getElementById(con);
    var objl = document.getElementById(con + 'L');
    document.getElementById(con).style.border = "solid 2px #999";
    // name
  // if (con == 'ctl00_ContentPlaceHolder1_txttypename') {
    var data = document.getElementById(con).value;
        // alert(data);
        if (data == "" || data.length < 1) {
            objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
        }
        else {
            objl.innerHTML = "<img src='../validation/images/accept.png' alt='Correct.'/>"; err = errid.value; err = parseInt(err) - 1; errid.value = err; return;
        }
        // }
       // AgainSTD(con);
}

function OnlyInt(con) {

    var errid = document.getElementById('Err'); var err; //alert('err='+errid.value);
    var Form = document.getElementById('aspnetForm');
    var obj = document.getElementById(con);
    var objl = document.getElementById(con + 'L');
    document.getElementById(con).style.border = "solid 2px #999";
    //Fees
   // if (con == 'ctl00_ContentPlaceHolder1_txtCourseFees') {
    var data = document.getElementById(con).value;
        // alert(data);
        if (data == "") {
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
        //}
       // AgainSTD(con);
}
function DropDown(con) {

    var errid = document.getElementById('Err'); var err; //alert('err='+errid.value);
    var Form = document.getElementById('aspnetForm');
    var obj = document.getElementById(con);
    var objl = document.getElementById(con + 'L');
    document.getElementById(con).style.border = "solid 2px #999";
    //Drop
   // if (con == 'ctl00_ContentPlaceHolder1_ddlUniversity') {
    var data = document.getElementById(con).selectedIndex;
        //  alert(data);
        if (data == 0) {
            objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
        }
        else {
            objl.innerHTML = "<img src='../validation/images/accept.png' alt='Correct..'/>"; err = errid.value; err = parseInt(err) - 1; errid.value = err; return;
        }
        //  }
       // AgainSTD(con);
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
        // objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
       // document.getElementById("ctl00_ContentPlaceHolder1_txtmobile").focus();
      
       // return false;
    }
    if (isNaN(data)) {
       // alert('In mobile Please enter Numbers only');
        document.getElementById("ctl00_ContentPlaceHolder1_txtmobile").focus();
        objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
       // return false;
    }
    else {
        objl.innerHTML = "<img src='../validation/images/accept.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return; 
    }
   // AgainSTD(con);
}

function submitEnquirydata() {
////Name
    data = document.getElementById("ctl00_ContentPlaceHolder1_Txtname").value;
    // alert(data);
    if (data == "" || data.length < 1) {
        alert('Please Enter Name');
        // objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        document.getElementById("ctl00_ContentPlaceHolder1_Txtname").focus();
        return false;
    }
    ////Email
    var data = document.getElementById("ctl00_ContentPlaceHolder1_txtEmail").value;

    if (data == "") {
        // alert('fd');
        document.getElementById("ctl00_ContentPlaceHolder1_txtEmailL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        //objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        alert('Please enter emailid');
        document.getElementById("ctl00_ContentPlaceHolder1_txtEmail").focus();
        return false;
    }
    if (data != "") {
        data = data.split('@');
        if (data[1] == null) {//objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
            alert('Please enter valid email'); document.getElementById("ctl00_ContentPlaceHolder1_txtEmail").focus(); return false;
        }
        else {
            var data1 = data[1];
            data1 = data1.split('.'); //alert(data1[1]);
            if (data1[1] == null || data1[1] == "") {
                //objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
                alert('Please enter valid email'); document.getElementById("ctl00_ContentPlaceHolder1_txtEmail").focus(); return false;
                document.getElementById("ctl00_ContentPlaceHolder1_txtEmailL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";

            }
        }
    }
    //Phone Number
    data = document.getElementById("ctl00_ContentPlaceHolder1_TxtPhone").value;
    // alert(data);
    if (data == "" || data.length < 10 || data.length > 12) {
        alert('Please enter mobile');
        // objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        document.getElementById("ctl00_ContentPlaceHolder1_TxtPhone").focus();
        return false;
    }
    if (isNaN(data)) {
        alert('In mobile Please enter Numbers only');
        document.getElementById("ctl00_ContentPlaceHolder1_TxtPhone").focus();
        return false;
    }
    //Enquiry
    data = document.getElementById("ctl00_ContentPlaceHolder1_txtEnquiry").value;
    // alert(data);
    if (data == "" || data.length < 1) {
        alert('Please Enter Enquiry');
        // objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        document.getElementById("ctl00_ContentPlaceHolder1_txtEnquiry").focus();
        return false;
    }
}


function submitMasterEnquirydata() {
    ////Name
    data = document.getElementById("ctl00_txtname").value;
    // alert(data);
    if (data == "" || data.length < 1) {
        alert('Please Enter Name');
        // objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        document.getElementById("ctl00_txtname").focus();
        return false;
    }
    ////Email
    var data = document.getElementById("ctl00_txtemail").value;

    if (data == "") {
        // alert('fd');
        document.getElementById("ctl00_txtemail").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        //objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        alert('Please enter emailid');
        document.getElementById("ctl00_txtemail").focus();
        return false;
    }
    if (data != "") {
        data = data.split('@');
        if (data[1] == null) {//objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
            alert('Please enter valid email'); document.getElementById("ctl00_ContentPlaceHolder1_txtEmail").focus(); return false;
        }
        else {
            var data1 = data[1];
            data1 = data1.split('.'); //alert(data1[1]);
            if (data1[1] == null || data1[1] == "") {
                //objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
                alert('Please enter valid email'); document.getElementById("ctl00_ContentPlaceHolder1_txtEmail").focus(); return false;
                document.getElementById("ctl00_ContentPlaceHolder1_txtEmailL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";

            }
        }
    }
    //Phone Number
    data = document.getElementById("ctl00_txtPhone").value;
    // alert(data);
    if (data == "" || data.length < 10 || data.length > 12) {
        alert('Please enter mobile');
        // objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        document.getElementById("ctl00_txtPhone").focus();
        return false;
    }
    if (isNaN(data)) {
        alert('In mobile Please enter Numbers only');
        document.getElementById("ctl00_txtPhone").focus();
        return false;
    }
    //Enquiry
    data = document.getElementById("ctl00_txtEnquiry").value;
    // alert(data);
    if (data == "" || data.length < 1) {
        alert('Please Enter Enquiry');
        // objl.innerHTML="<img src='img/errlogo.gif' alt='Error..'/>";
        document.getElementById("ctl00_txtEnquiry").focus();
        return false;
    }
}