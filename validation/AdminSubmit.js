
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
function Email(con) {

    var errid = document.getElementById('Err'); var err; //alert('err='+errid.value);
    var Form = document.getElementById('aspnetForm');
    var obj = document.getElementById(con);
    var objl = document.getElementById(con + 'L');
    document.getElementById(con).style.border = "solid 2px #999";
    //Email
    //if (con == 'ctl00_ContentPlaceHolder1_txtemail') {
    var data = document.getElementById(con).value;
    if (data == "") {
        objl.innerHTML = "<img src='../../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
    }
    if (data != "") {
        data = data.split('@');
        if (data[1] == null)
        { objl.innerHTML = "<img src='../../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return; }
        else {
            var data1 = data[1];
            data1 = data1.split('.'); //alert(data1[1]);
            if (data1[1] == null || data1[1] == "") {
                objl.innerHTML = "<img src='../../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
            }
            else {
                objl.innerHTML = "<img src='../../validation/images/accept.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;

            }
        }
    }
    //}
    // AgainSTD(con);
}

//function CountCharacter(con) {
//    alter('ok')
//    var objl = document.getElementById(con + 'R');
//    var data = document.getElementById(con).value.length;
//    if (data == "101" || data > "100") {
//        alert('You Can Send Only 100 character Queery');
//    }
//    else {
//        document.getElementById('<%=ctl00_ContentPlaceHolder1_txt_titleR.ClientID%>').innerHTML = data + " <b>OF</b> 100";
//    }

//}
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
        objl.innerHTML = "<img src='../../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
    }
    else {
        objl.innerHTML = "<img src='../../validation/images/accept.png' alt='Correct..'/>"; err = errid.value; err = parseInt(err) - 1; errid.value = err; return;
    }
    // }
    // AgainSTD(con);
}
/////////counter
function RequiredTitleCount(con) {

    var errid = document.getElementById('Err'); var err; //alert('err='+errid.value);
    var Form = document.getElementById('aspnetForm');
    var obj = document.getElementById(con);
    var objl = document.getElementById(con + 'L');
    document.getElementById(con).style.border = "solid 2px #999";
    // name var data = document.getElementById(con).value.length;
    // if (con == 'ctl00_ContentPlaceHolder1_txttypename') {
    var data = document.getElementById(con).value.length;
   // var Title = document.getElementById(can).value;
    // alert(data);
    if (data == 0 || data < 1) {
        document.getElementById('ctl00_ContentPlaceHolder1_txt_titleR').innerHTML = "";
        objl.innerHTML = "<img src='../../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
    }
    else {
        if (data ==501|| data>500)
        { alert('You can Insert Only 500 character in Title'); }
        else {
          // alert(Title);
            document.getElementById('ctl00_ContentPlaceHolder1_txt_titleR').innerHTML = "(" + data + " <b>OF</b>500) Character";
            objl.innerHTML = "<img src='../../validation/images/accept.png' alt='Correct..'/>"; err = errid.value; err = parseInt(err) - 1; errid.value = err; return;
        }
    }
    // }
    // AgainSTD(con);
}

////////////SubTitle
function RequiredSubTitleCount(con) {

    var errid = document.getElementById('Err'); var err; //alert('err='+errid.value);
    var Form = document.getElementById('aspnetForm');
    var obj = document.getElementById(con);
    var objl = document.getElementById(con + 'L');
    document.getElementById(con).style.border = "solid 2px #999";
    // name var data = document.getElementById(con).value.length;
    // if (con == 'ctl00_ContentPlaceHolder1_txttypename') {
    var data = document.getElementById(con).value.length;
    // var Title = document.getElementById(can).value;
    // alert(data);
    if (data == "" || data < 1) {
        document.getElementById('ctl00_ContentPlaceHolder1_txtSubTitleR').innerHTML = "";
        objl.innerHTML = "<img src='../../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
    }
    else {
     
        if (data == 501|| data>500)
        { alert('You can Insert Only 500 character in Title'); }
        else {
             //alert('ok');
            document.getElementById('ctl00_ContentPlaceHolder1_txtSubTitleR').innerHTML = "(" + data + " <b>OF</b> 500) Character";
            objl.innerHTML = "<img src='../../validation/images/accept.png' alt='Correct..'/>"; err = errid.value; err = parseInt(err) - 1; errid.value = err; return;
        }
    }
    // }
    // AgainSTD(con);
}
//////Description
function RequiredDescriptionCount(con) {
   // alert('pk');
    var errid = document.getElementById('Err'); var err; //alert('err='+errid.value);
    var Form = document.getElementById('aspnetForm');
    var obj = document.getElementById(con);
    var objl = document.getElementById(con + 'L');
     //document.getElementById(con).style.border = "solid 2px #999";
    // name var data = document.getElementById(con).value.length;
   // if (con == 'ctl00_ContentPlaceHolder1_txttypename') {
    var data = document.getElementById('ctl00_ContentPlaceHolder1_txt_desc').value.length;
    // var Title = document.getElementById(can).value;
    // alert(data);
    if (data == "" || data < 1) {
        document.getElementById('ctl00_ContentPlaceHolder1_txt_descL').innerHTML = "";
        objl.innerHTML = "<img src='../../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
    }
    else {
        if (data ==8001|| data>8000)
        { alert('You can Insert Only 8000 character in Title'); }
        else {
            //  alert(Title);
            document.getElementById('ctl00_ContentPlaceHolder1_txt_descR').innerHTML = "(" + data + " <b>OF</b> 8000) Character";
            objl.innerHTML = "<img src='../../validation/images/accept.png' alt='Correct..'/>"; err = errid.value; err = parseInt(err) - 1; errid.value = err; return;
        }
    }
    // }
    // AgainSTD(con);
}
//////testomony 
function RequiredTastomonyNameCount(con) {
   var data = document.getElementById(con).value.length;
      if (data == 21|| data>20)
        { alert('You can give 20 character in name'); }
        else {
            //  alert(Title);
            document.getElementById('ctl00_ContentPlaceHolder1_txttitleR').innerHTML = "(" + data + " <b>OF</b> 20) Character";
         }
    }
    //////Description
    function RequiredTastomonyDescriptionCount(con) {
        var data = document.getElementById(con).value.length;
        if (data == 201|| data>200)
        { alert('You can give 200 character in Description'); }
        else {
            //  alert(Title);
            document.getElementById('ctl00_ContentPlaceHolder1_Editor1R').innerHTML = "(" + data + " <b>OF</b> 200) Character";
        }
    }
    //////Title 
    function RequiredAddTextTitleCount(con) {
        var data = document.getElementById(con).value.length;
        if (data == 51 || data>50)
        { alert('You can give 50 character in Title'); }
        else {
            //  alert(Title);
            document.getElementById('ctl00_ContentPlaceHolder1_txt_titleR').innerHTML = "(" + data + " <b>OF</b> 50) Character";
        }
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
        objl.innerHTML = "<img src='../../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
    }
    else {
        if (isNaN(data)) {
            objl.innerHTML = "<img src='../../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
        }
        else {

            objl.innerHTML = "<img src='../../validation/images/accept.png' alt='Correct.'/>"; err = errid.value; err = parseInt(err) - 1; errid.value = err; return;
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
        objl.innerHTML = "<img src='../../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
    }
    else {
        objl.innerHTML = "<img src='../../validation/images/accept.png' alt='Correct..'/>"; err = errid.value; err = parseInt(err) - 1; errid.value = err; return;
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
        objl.innerHTML = "<img src='../../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
        // document.getElementById("ctl00_ContentPlaceHolder1_txtmobile").focus();

        // return false;
    }
    if (isNaN(data)) {
        // alert('In mobile Please enter Numbers only');
        document.getElementById(con).focus();
        objl.innerHTML = "<img src='../../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
        // return false;
    }
    else {
        objl.innerHTML = "<img src='../../validation/images/accept.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
    }
    // AgainSTD(con);
}
//////////////////////////
///////////////////////////////////////////////////////TextEditor
function submitTextEditordata() {
    ////Name
    data = document.getElementById("ctl00_ContentPlaceHolder1_txt_title").value;
    // alert(data);
    if (data == "" || data.length < 1) {
        alert('Please Insert Title');
        document.getElementById("ctl00_ContentPlaceHolder1_txt_title").focus();
        return false;
    }
}
//////////////////////////
///////////////////////////////////////////////////////submitNewsFordata
function submitNewsFordata() {
    ////Name
    data = document.getElementById("ctl00_ContentPlaceHolder1_txtUserName").value;
    // alert(data);
    if (data == "" || data.length < 1) {
        alert('Please Insert In Require Colum');
        document.getElementById("ctl00_ContentPlaceHolder1_txtUserName").focus();
        return false;
    }
}
//////////////////////////
///////////////////////////////////////////////////////Submit University Type
function submitUniversityTypedata() {
    ////Name
    data = document.getElementById("ctl00_ContentPlaceHolder1_txtUserName").value;
    // alert(data);
    if (data == "" || data.length < 1) {
        alert('Please Insert In University Type');
        document.getElementById("ctl00_ContentPlaceHolder1_txtUserName").focus();
        return false;
    }
    ////Name
    data = document.getElementById("ctl00_ContentPlaceHolder1_txtSubTitle").value;
    // alert(data);
    if (data == "" || data.length < 1) {
        alert('Please Insert In SubTitle Colum');
        document.getElementById("ctl00_ContentPlaceHolder1_txtSubTitle").focus();
        return false;
    }
    ////Name
    data = document.getElementById("ctl00_ContentPlaceHolder1_Editor1").value;
    // alert(data);
    if (data == "" || data.length < 1) {
        alert('Please Insert In Description Colum');
        document.getElementById("ctl00_ContentPlaceHolder1_Editor1").focus();
        return false;
    }
}
//////////////////////////////
////////////////////////////////////////////////////

function submitNewsTypedata() 
{
////
    if (document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversity").selectedIndex == 0) 
    {
        alert("Please Select News For");
        document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversity").focus();
        document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversityL").innerHTML = "<img src='../../validation/images/cross.png' alt='Error..'/>";
        return false;
    }
    ////Name
    data = document.getElementById("ctl00_ContentPlaceHolder1_txtUserName").value;
    // alert(data);
    if (data == "" || data.length < 1) {
        alert('Please Enter News Type');
        document.getElementById("ctl00_ContentPlaceHolder1_txtUserName").focus();
        return false;
    }
}
//////////////////////////////
//////////////////////////////////////////////////// TextCatagory

function submitTextCatagorydata() {
    ////
    if (document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversity").selectedIndex == 0) {
        alert("Please Select University");
        document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversity").focus();
       //document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversityL").innerHTML = "<img src='../../validation/images/cross.png' alt='Error..'/>";
        return false;
    }
    ////Name
    data = document.getElementById("ctl00_ContentPlaceHolder1_txtUserName").value;
    // alert(data);
    if (data == "" || data.length < 1) {
        alert('Please Enter Category Name');
        document.getElementById("ctl00_ContentPlaceHolder1_txtUserName").focus();
        return false;
    }
}
//////////////////////////////
//////////////////////////////////////////////////// AddUniText

function submitAddUniTextdata() {
    ////
    if (document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversity").selectedIndex == 0) {
        alert("Please Select University");
        document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversity").focus();
        //document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversityL").innerHTML = "<img src='../../validation/images/cross.png' alt='Error..'/>";
        return false;
    }
    //
    if (document.getElementById("ctl00_ContentPlaceHolder1_ddlTextCategory").selectedIndex == 0) {
        alert("Please Select Category");
        document.getElementById("ctl00_ContentPlaceHolder1_ddlTextCategory").focus();
        //document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversityL").innerHTML = "<img src='../../validation/images/cross.png' alt='Error..'/>";
        return false;
    }
    ////Name
    data = document.getElementById("ctl00_ContentPlaceHolder1_txt_title").value;
    // alert(data);
    if (data == "" || data.length < 1) {
        alert('Please Enter Title');
        document.getElementById("ctl00_ContentPlaceHolder1_txt_title").focus();
        return false;
    }
}
//////////////////////////////
////////////////////////////////////////////////////Add University

function submitAddUniversitydata() {
    ////
    if (document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversity0").selectedIndex == 0) {
        alert("Please Select Country");
        document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversity0").focus();
       // document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversityL").innerHTML = "<img src='../../validation/images/cross.png' alt='Error..'/>";
        return false;
    }
    ////
    if (document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversity").selectedIndex == 0) {
        alert("Please Select State");
        document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversity").focus();
       // document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversityL").innerHTML = "<img src='../../validation/images/cross.png' alt='Error..'/>";
        return false;
    }
    ////
    if (document.getElementById("ctl00_ContentPlaceHolder1_ddlDistrict").selectedIndex == 0) {
        alert("Please Select Disst.");
        document.getElementById("ctl00_ContentPlaceHolder1_ddlDistrict").focus();
       // document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversityL").innerHTML = "<img src='../../validation/images/cross.png' alt='Error..'/>";
        return false;
    }
    ////
    if (document.getElementById("ctl00_ContentPlaceHolder1_ddlCity").selectedIndex == 0) {
        alert("Please Select City ");
        document.getElementById("ctl00_ContentPlaceHolder1_ddlCity").focus();
       // document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversityL").innerHTML = "<img src='../../validation/images/cross.png' alt='Error..'/>";
        return false;
    }
    ////
    if (document.getElementById("ctl00_ContentPlaceHolder1_ddlUniType").selectedIndex == 0) {
        alert("Please Select University Type");
        document.getElementById("ctl00_ContentPlaceHolder1_ddlUniType").focus();
     //   document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversityL").innerHTML = "<img src='../../validation/images/cross.png' alt='Error..'/>";
        return false;
    }
    ////
    if (document.getElementById("ctl00_ContentPlaceHolder1_ddl").selectedIndex == 0) {
        alert("Please Select Edu Type");
        document.getElementById("ctl00_ContentPlaceHolder1_ddl").focus();
       // document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversityL").innerHTML = "<img src='../../validation/images/cross.png' alt='Error..'/>";
        return false;
    }

    data = document.getElementById("ctl00_ContentPlaceHolder1_txtName").value;
    // alert(data);
    if (data == "" || data.length < 1) {
        alert('Please Insert Name');
        document.getElementById("ctl00_ContentPlaceHolder1_txtName").focus();
        return false;
    }
    ////

    data = document.getElementById("ctl00_ContentPlaceHolder1_txtBranchCode").value;
    // alert(data);
    if (data == "" || data.length < 1) {
        alert('Please Enter Code');
        document.getElementById("ctl00_ContentPlaceHolder1_txtBranchCode").focus();
        return false;
    }
    ////

    data = document.getElementById("ctl00_ContentPlaceHolder1_txtmobNo").value;
    // alert(data);
    if (data == "" || data.length < 11) {
        alert('Please Enter Mobile no.');
        document.getElementById("ctl00_ContentPlaceHolder1_txtmobNo").focus();
        return false;
    }
    if (isNaN(data)) {
        alert('In mobile Please enter Numbers only');
        document.getElementById('ctl00_ContentPlaceHolder1_txtmobNo').focus();
        return false;
    }
    if (document.getElementById("ctl00_ContentPlaceHolder1_ddlRankList").selectedIndex == 0) {
        alert("Please Select Rank");
        document.getElementById("ctl00_ContentPlaceHolder1_ddlRankList").focus();
        // document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversityL").innerHTML = "<img src='../../validation/images/cross.png' alt='Error..'/>";
        return false;
    }
    ////Name
}
//////////////////////////////
////////////////////////////////////////////////////State

function submitStatedata() {
    ////
    if (document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversity").selectedIndex == 0) {
        alert("Please Select Country");
        document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversity").focus();
        document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversityL").innerHTML = "<img src='../../validation/images/cross.png' alt='Error..'/>";
        return false;
    }
    ////Name
    data = document.getElementById("ctl00_ContentPlaceHolder1_txtUserName").value;
    // alert(data);
    if (data == "" || data.length < 1) {
        alert('Please Enter State Name');
        document.getElementById("ctl00_ContentPlaceHolder1_txtUserName").focus();
        return false;
    }
}
//////////////////////////////
////////////////////////////////////////////////////Distict

function submitDistictdata() {
    ////
    if (document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversity0").selectedIndex == 0) {
        alert("Please Select Country");
        document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversity0").focus();
        document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversity0L").innerHTML = "<img src='../../validation/images/cross.png' alt='Error..'/>";
        return false;
    }
    ////
    if (document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversity").selectedIndex == 0) {
        alert("Please Select State");
        document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversity").focus();
        document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversityL").innerHTML = "<img src='../../validation/images/cross.png' alt='Error..'/>";
        return false;
    }
    ////Name
    data = document.getElementById("ctl00_ContentPlaceHolder1_txtUserName").value;
    // alert(data);
    if (data == "" || data.length < 1) {
        alert('Please Insert Distt. Name');
        document.getElementById("ctl00_ContentPlaceHolder1_txtUserName").focus();
        return false;
    }
}
//////////////////////////////
////////////////////////////////////////////////////City

function submitCitydata() {
    ////
    if (document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversity0").selectedIndex == 0) {
        alert("Please Select Country");
        document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversity0").focus();
        document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversity0L").innerHTML = "<img src='../../validation/images/cross.png' alt='Error..'/>";
        return false;
    }
    ////
    if (document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversity").selectedIndex == 0) {
        alert("Please Select State");
        document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversity").focus();
        document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversityL").innerHTML = "<img src='../../validation/images/cross.png' alt='Error..'/>";
        return false;
    }
    ////
    if (document.getElementById("ctl00_ContentPlaceHolder1_ddlDistrict").selectedIndex == 0) {
        alert("Please Select Distt.");
        document.getElementById("ctl00_ContentPlaceHolder1_ddlDistrict").focus();
        document.getElementById("ctl00_ContentPlaceHolder1_ddlDistrictL").innerHTML = "<img src='../../validation/images/cross.png' alt='Error..'/>";
        return false;
    }
    ////Name
    data = document.getElementById("ctl00_ContentPlaceHolder1_txtUserName").value;
    // alert(data);
    if (data == "" || data.length < 1) {
        alert('Please Insert City Name');
        document.getElementById("ctl00_ContentPlaceHolder1_txtUserName").focus();
        return false;
    }
}
//////////////////////////////
////////////////////////////////////////////////////ImageCat

function submitImageCatdata() {
    ////
    if (document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversity").selectedIndex == 0) {
        alert("Please Select University");
        document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversity").focus();
        document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversityL").innerHTML = "<img src='../../validation/images/cross.png' alt='Error..'/>";
        return false;
    }
    ////Name
    data = document.getElementById("ctl00_ContentPlaceHolder1_txtUserName").value;
    // alert(data);
    if (data == "" || data.length < 1) {
        alert('Please Insert Category Name');
        document.getElementById("ctl00_ContentPlaceHolder1_txtUserName").focus();
        return false;
    }
}
//////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////Add new
function submitAddNewsdata() {
    ////
    if (document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversity").selectedIndex == 0) {
        alert("Please Select News For");
        document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversity").focus();
        document.getElementById("ctl00_ContentPlaceHolder1_ddlUniversityL").innerHTML = "<img src='../../validation/images/cross.png' alt='Error..'/>";
        return false;
    }
    ///////
    if (document.getElementById("ctl00_ContentPlaceHolder1_ddlNewsType").selectedIndex == 0) {
        alert("Please Select News Type");
        document.getElementById("ctl00_ContentPlaceHolder1_ddlNewsType").focus();
        document.getElementById("ctl00_ContentPlaceHolder1_ddlNewsTypeL").innerHTML = "<img src='../../validation/images/cross.png' alt='Error..'/>";
        return false;
    }
    ///
    data = document.getElementById("ctl00_ContentPlaceHolder1_txtDate").value;
    // alert(data);
    if (data == "" || data.length < 1) {
        alert('Please Insert Date');
        document.getElementById("ctl00_ContentPlaceHolder1_txtDate").focus();
        return false;
    }
    ////Name
    data = document.getElementById("ctl00_ContentPlaceHolder1_txt_title").value;
    // alert(data);
    if (data == "" || data.length < 1) {
        alert('Please Enter News Title');
        document.getElementById("ctl00_ContentPlaceHolder1_txt_title").focus();
        return false;
    }
    data = document.getElementById("ctl00_ContentPlaceHolder1_txtSubTitle").value;
    // alert(data);
    if (data == "" || data.length < 1) {
        alert('Please Enter News Sub Title');
        document.getElementById("ctl00_ContentPlaceHolder1_txtSubTitle").focus();
        return false;
    }
    data = document.getElementById("ctl00_ContentPlaceHolder1_txt_desc").value;
    // alert(data);
    if (data == "" || data.length < 1) {
        alert('Please Enter News Description');
        document.getElementById("ctl00_ContentPlaceHolder1_txt_desc").focus();
        return false;
    }
}

//////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////Add new
function submitTastomonydata() {
    ///
    data = document.getElementById("ctl00_ContentPlaceHolder1_txttitle").value;
    // alert(data);
    if (data == "" || data.length < 1) {
        alert('Please Insert Title');
        document.getElementById("ctl00_ContentPlaceHolder1_txttitle").focus();
        return false;
    }
    ////Name
    data = document.getElementById("ctl00_ContentPlaceHolder1_Editor1").value;
    // alert(data);
    if (data == "" || data.length < 1) {
        alert('Please Insert Testomony Description');
        document.getElementById("ctl00_ContentPlaceHolder1_Editor1").focus();
        return false;
    }
}
//////////////////////////
///////////////////////////////////////////////////////Go Search button
function GoSearchButton() {
    ////Name
    data = document.getElementById("ctl00_ContentPlaceHolder1_txtGoPage").value;
    // alert(data);
    if (data == "" || data.length < 1) {
        alert('Please Insert Page No In TextBox');
        document.getElementById("ctl00_ContentPlaceHolder1_txtGoPage").focus();
        return false;
    }
}

