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
        objl.innerHTML = "<img src='../validation/images/accept.png' alt='Correct..'/>"; err = errid.value; err = parseInt(err) - 1; errid.value = err; return;
    }
    // }
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

function OnlyInt(con) {
    var errid = document.getElementById('Err'); var err; //alert('err='+errid.value);
    var Form = document.getElementById('aspnetForm');
    var obj = document.getElementById(con);
    var objl = document.getElementById(con + 'L');
    document.getElementById(con).style.border = "solid 2px #999";
    data = document.getElementById(con).value;
    // alert(data);
    if (data == ""|| data.length > 12) {
       objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
      }
    if (isNaN(data)) {
        document.getElementById(con).focus();
        objl.innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
       }
    else {
        objl.innerHTML = "<img src='../validation/images/accept.png' alt='Error..'/>"; err = errid.value; err = parseInt(err) + 1; errid.value = err; return;
    }
  }
function ddlChkSelect(CtlID) {
    var ddl = document.getElementById(CtlID);
    document.getElementById(CtlID).style.visibility = "visible";
    return true;
}

function submitListingdata() {
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
    /////type
    if (document.getElementById("ctl00_ContentPlaceHolder1_rdbCourseTime_0").checked == false && document.getElementById("ctl00_ContentPlaceHolder1_rdbCourseTime_1").checked == false && document.getElementById("ctl00_ContentPlaceHolder1_rdbCourseTime_2").checked == false && document.getElementById("ctl00_ContentPlaceHolder1_rdbCourseTime_3").checked == false) {
        alert('Please Select Duration Type');
        //document.getElementById("ctl00_ContentPlaceHolder1_RadioButtonList1_0").focus();
        return false;
    }
    //Fees
    data = document.getElementById("ctl00_ContentPlaceHolder1_txtCourseFees").value;
    // alert(data);
    if (data == "" || data.length < 2) {
        alert('Please enter fees');
        document.getElementById("ctl00_ContentPlaceHolder1_txtCourseFeesL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        document.getElementById("ctl00_ContentPlaceHolder1_txtCourseFees").focus();
        return false;
    }
    if (isNaN(data)) {
        alert('In Fees Please Insert Numeric Or Decimal Values');
        document.getElementById("ctl00_ContentPlaceHolder1_txtCourseFees").focus();
        return false;
    }

}

function RequiredTastomonyNameCount(con) {
    var data = document.getElementById(con).value.length;
    if (data == 21 || data > 20)
    { alert('You can give 20 character in name'); }
    else {
        //  alert(Title);
        document.getElementById('ctl00_ContentPlaceHolder1_txttitleR').innerHTML = "(" + data + " <b>OF</b> 20) Character";
    }
}
//////Description
function RequiredTastomonyDescriptionCount(con) {
    var data = document.getElementById(con).value.length;
    if (data == 201 || data > 200)
    { alert('You can give 200 character in Description'); }
    else {
        //  alert(Title);
        document.getElementById('ctl00_ContentPlaceHolder1_Editor1R').innerHTML = "(" + data + " <b>OF</b> 200) Character";
    }
}

///////////////////////////////////
////////////////////////////////////////////
function submitTutorSubjectdata() {
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
    //Course name
    data = document.getElementById("ctl00_ContentPlaceHolder1_txtCrsFullname").value;
    // alert(data);
    if (data == "" || data.length < 2) {
        alert('Please Insert Course Name');
        document.getElementById("ctl00_ContentPlaceHolder1_txtCrsFullnameL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        document.getElementById("ctl00_ContentPlaceHolder1_txtCrsFullname").focus();
        return false;
    }
    //Duration Of Course
    if (document.getElementById("ctl00_ContentPlaceHolder1_ddlDuration").selectedIndex == 0) {
        alert("Please Subject Duration");
        document.getElementById("ctl00_ContentPlaceHolder1_ddlDuration").focus();
        document.getElementById("ctl00_ContentPlaceHolder1_ddlDurationL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        return false;

    }
    /////type
    if (document.getElementById("ctl00_ContentPlaceHolder1_rdbCourseTime_0").checked == false && document.getElementById("ctl00_ContentPlaceHolder1_rdbCourseTime_1").checked == false && document.getElementById("ctl00_ContentPlaceHolder1_rdbCourseTime_2").checked == false && document.getElementById("ctl00_ContentPlaceHolder1_rdbCourseTime_3").checked == false) {
        alert('Please Select Duration Type');
        document.getElementById("ctl00_ContentPlaceHolder1_RadioButtonList1_0").focus();
        return false;
    }
    //Course Type
    if (document.getElementById("ctl00_ContentPlaceHolder1_ddlCollegeType").selectedIndex == 0) {
        alert("Please Select Course Type");
        document.getElementById("ctl00_ContentPlaceHolder1_ddlCollegeType").focus();
        document.getElementById("ctl00_ContentPlaceHolder1_ddlSubCourseCateL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        return false;

    }
    //Fees

    data = document.getElementById("ctl00_ContentPlaceHolder1_txtCourseFees").value;
    // alert(data);
    if (data == "" || data.length < 2) {
        alert('Please enter fees');
        document.getElementById("ctl00_ContentPlaceHolder1_txtCourseFeesL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        document.getElementById("ctl00_ContentPlaceHolder1_txtCourseFees").focus();
        return false;
    }
    if (isNaN(data)) {
        alert('In Fees Please Insert Numeric Or Decimal Values');
        document.getElementById("ctl00_ContentPlaceHolder1_txtCourseFeesL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        document.getElementById("ctl00_ContentPlaceHolder1_txtCourseFees").focus();
        return false;
    }
    //Seat

    data = document.getElementById("ctl00_ContentPlaceHolder1_txtNoOfSeat").value;
    // alert(data);
    if (data == "" || data.length < 2) {
        alert('Please Insert Seat');
        document.getElementById("ctl00_ContentPlaceHolder1_txtNoOfSeatL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        document.getElementById("ctl00_ContentPlaceHolder1_txtNoOfSeat").focus();
        return false;
    }
    if (isNaN(data)) {
        alert('Please Insert Numeric In Seat');
        document.getElementById("ctl00_ContentPlaceHolder1_txtNoOfSeatL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        document.getElementById("ctl00_ContentPlaceHolder1_txtCourseFees").focus();
        return false;
    }
    //Course Method
    if (document.getElementById("ctl00_ContentPlaceHolder1_ddlCrsMethod").selectedIndex == 0) {
        alert("Please Select Course Method");
        document.getElementById("ctl00_ContentPlaceHolder1_ddlCrsMethod").focus();
        document.getElementById("ctl00_ContentPlaceHolder1_ddlSubCourseCateL").innerHTML = "<img src='../validation/images/cross.png' alt='Error..'/>";
        return false;

    }
}

//////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////Testomony
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
