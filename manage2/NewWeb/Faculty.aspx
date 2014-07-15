<%@ Page Title="" Language="C#" MasterPageFile="~/manage2/NewWeb/home2.master" AutoEventWireup="true" CodeFile="~/manage2/NewWeb/Faculty.aspx.cs" Inherits="manage2_NewWeb_Faculty" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


<link href="css/micro-webstyle.css" rel="stylesheet" type="text/css" />
<div class="slct-sectn">
<select name="" class="slct-fld">
<option selected="selected" value="0"><---------Select---------></option>
	<option value="1">Year</option>
	<option value="2">2020</option>
	<option value="3">2019</option>
	<option value="4">2018</option>
	<option value="5">2019</option>
	<option value="6">2018</option>
	<option value="7">2017</option>
	<option value="8">2016</option>
	<option value="9">2015</option>
<option value="10">2014</option>
<option value="11">2013</option>
<option value="12">2012</option>
</select>
</div>
<div class="slct-sectn-rght">
<select name="" class="slct-fld">
<option selected="selected" value="0"><---------Select---------></option>
	<option value="1">Category</option>
	<option value="2">B.A 1st</option>
    <option value="2">B.A 2st</option>
    <option value="2">B.A 3st</option>
	<option value="3">M.A 1st</option>
    <option value="3">M.A 2st</option>
</select>
</div>

<div class="middle-sectn-02">
<section class="batch-year">
<div class="lft-txt-hdng-sectn">
<h1 class="hng-txt">&nbsp;&nbsp;Batch Year : <span class="sub-hng-txt"> 2013-2014 </span></h1></div>
<div class="rght-txt-hdng-sectn">
<h1 class="hng-txt">&nbsp;&nbsp;Category : <span class="sub-hng-txt"> B.A 1<sup>st</sup> Year</span></h1></div>
</section>
<article class="artcless-middle">

               <%
                   for (int i = 0; i < totalcount; i++)
                   {

                       string Collegeid = ds1.Tables[0].Rows[i]["collegeImage"].ToString();
                       string title = ds1.Tables[0].Rows[i]["collegeName"].ToString();
                       string code = ds1.Tables[0].Rows[i]["collegeName"].ToString();
                       
                    %>
                    <p class="img-02-blk">
<a class="readmore" target ="_blank" href="~/../../../../../../mktst/<%=code %>/<%= code%>"><img src="~/../../../../../<%=Collegeid%>" id="img<%=i%>image" title ="<%=title %>" alt ="<%=title %>" class="innr-img-setn" /></a></p>


<%} %>
</article>

</div>


<section class="middle-seacrh-sectn-001">
<div class="slct-sectn">

</div>
<div class="slct-sectn-rght">

</div>
</section>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>

