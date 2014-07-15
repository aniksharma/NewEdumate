<%@ Page Title="" Language="C#" MasterPageFile="~/InstitutePanel/MasterPage2.master" AutoEventWireup="true" CodeFile="UpdateJobProfile.aspx.cs" Inherits="JobPlacement_UpdateJobProfile" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table id="tbl" runat="server" width="100%">
    <tr>
    <td colspan="2">

					<label for="ac-1" class="tab-hdng">Current Job Details</label>
    </td>
    </tr>
        <tr>
        <td>Skills</td>
        <td><asp:TextBox ID="txtSkills" runat="server" CssClass="txt-flds"></asp:TextBox>
        <asp:RequiredFieldValidator ID="reqSkills" runat="server" ControlToValidate="txtSkills" Text="*" ForeColor="Red" ValidationGroup="v1"></asp:RequiredFieldValidator>
        </td>
        </tr>
         <tr>
        <td>Industry</td>
        <td><asp:TextBox ID="txtIndustry" runat="server" CssClass="txt-flds"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtIndustry" Text="*" ForeColor="Red" ValidationGroup="v1"></asp:RequiredFieldValidator>
        </td>
        </tr>
         <tr>
        <td>Functional Area</td>
        <td>
        <asp:DropDownList ID="ddlFunctionalArea" runat="server"  CssClass="txt-drps">
        <asp:ListItem>--Select--</asp:ListItem>
        <asp:ListItem>Teaching, Education</asp:ListItem>
        <asp:ListItem>Education/ Teaching/Training</asp:ListItem>
        <asp:ListItem>Teacher / Lecturer / Professor / Academic Research</asp:ListItem>
        <asp:ListItem>HR / Administration, IR</asp:ListItem>
        <asp:ListItem>Teaching</asp:ListItem>
        <asp:ListItem>Others</asp:ListItem>
    </asp:DropDownList>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ddlFunctionalArea" Text="*" ForeColor="Red" ValidationGroup="v1"></asp:RequiredFieldValidator>
        </td>
        </tr>
         <tr>
        <td>Role</td>
        <td>
        <asp:DropDownList ID="ddlRole" runat="server" CssClass="txt-drps">
              <asp:ListItem>Select Role</asp:ListItem>
              <asp:ListItem>Advisors</asp:ListItem>
              <asp:ListItem>Assessor</asp:ListItem>
              <asp:ListItem>Business Manager/Bursar</asp:ListItem>
              <asp:ListItem>Classroom Teacher</asp:ListItem>
              <asp:ListItem>Co-ordinator</asp:ListItem>
              <asp:ListItem>Consultant</asp:ListItem>
              <asp:ListItem>Content Specialists</asp:ListItem>
              <asp:ListItem>Curriculum Leader</asp:ListItem>
              <asp:ListItem>Customer Support/Manager</asp:ListItem>
              <asp:ListItem>Deputy Head Teacher</asp:ListItem>
              <asp:ListItem>Director/Principal</asp:ListItem>
              <asp:ListItem>Education Officer</asp:ListItem>
              <asp:ListItem>Educational Psychologist</asp:ListItem>
              <asp:ListItem>Examiner</asp:ListItem>
              <asp:ListItem>Freelance Teacher</asp:ListItem>
              <asp:ListItem>Head of Department</asp:ListItem>
              <asp:ListItem>Head Teacher</asp:ListItem>
              <asp:ListItem>Leadership/Excellence Teacher</asp:ListItem>
              <asp:ListItem>Lecturer</asp:ListItem>
              <asp:ListItem>Librarian</asp:ListItem>
              <asp:ListItem>Manager</asp:ListItem>
              <asp:ListItem>Nursery Teacher</asp:ListItem>
              <asp:ListItem>Special Needs Teacher</asp:ListItem>
              <asp:ListItem>Teaching Assistant</asp:ListItem>
              <asp:ListItem>Tutor</asp:ListItem>
              <asp:ListItem>Other</asp:ListItem>               
             </asp:DropDownList>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ddlRole" Text="*" ForeColor="Red" ValidationGroup="v1"></asp:RequiredFieldValidator>
        </td>
        </tr>
         <tr>
        <td>Category</td>
        <td>
        <asp:DropDownList ID="ddlCategory" runat="server" CssClass="txt-drps">
                
                    <asp:ListItem>Select category</asp:ListItem>
                    <asp:ListItem>Schools</asp:ListItem>
                    <asp:ListItem>College</asp:ListItem>
                    <asp:ListItem>University</asp:ListItem>
                    <asp:ListItem>Company</asp:ListItem>
                    <asp:ListItem>Training/Coaching Institutes</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ddlCategory" Text="*" ForeColor="Red" ValidationGroup="v1"></asp:RequiredFieldValidator>
        </td>
        </tr>
         <tr>
        <td>Current Employer</td>
        <td><asp:TextBox ID="txtCurrentEmployer" runat="server" CssClass="txt-flds"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtCurrentEmployer" Text="*" ForeColor="Red" ValidationGroup="v1"></asp:RequiredFieldValidator>
        </td>
        </tr>
         <tr>
        <td>Current Salary</td>
        <td>
        <asp:DropDownList ID="ddlcurrentsalary" runat="server" CssClass="txt-drps">
                
                    <asp:ListItem>Select One</asp:ListItem>
                    <asp:ListItem>10,000 - 14,999</asp:ListItem>
                    <asp:ListItem>15,000 - 19,999</asp:ListItem>
                    <asp:ListItem>20,000 - 24,999</asp:ListItem>
                    <asp:ListItem>25,000 - 29,999</asp:ListItem>
                    <asp:ListItem>30,000 - 34,999</asp:ListItem>
                    <asp:ListItem>35,000 - 39,999</asp:ListItem>
                    <asp:ListItem>40,000 - 44,999</asp:ListItem>
                    <asp:ListItem>45,000 - 49,999</asp:ListItem>
                    <asp:ListItem>50,000 - 54,999</asp:ListItem>
                    <asp:ListItem>55,000 - 59,999</asp:ListItem>
                    <asp:ListItem>60,000 - 64,999</asp:ListItem>
                    <asp:ListItem>65,000 - 69,999</asp:ListItem>
                    <asp:ListItem>70,000 - 99,999</asp:ListItem>
                    <asp:ListItem>1,00,000 - 1,49,999</asp:ListItem>
                    <asp:ListItem>1,50,000 - 1,99,999</asp:ListItem>
                    <asp:ListItem>2,00,000 - 2,99,999</asp:ListItem>
                    <asp:ListItem>3,00,000 - 3,99,999</asp:ListItem>
                    <asp:ListItem>4,00,000 - 4,99,999</asp:ListItem>
                    <asp:ListItem>5,00,000 - 5,99,999</asp:ListItem>
                    <asp:ListItem>6,00,000 +</asp:ListItem>
                    <asp:ListItem>Negotiable</asp:ListItem>
                 </asp:DropDownList>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="ddlcurrentsalary" Text="*" ForeColor="Red" ValidationGroup="v1"></asp:RequiredFieldValidator>
        </td>
        </tr>
         <tr>
        <td>Expected Salary<asp:Label ID="lblSalary" Text="*" runat="server" ForeColor="Red"></asp:Label></td>
        <td>
        <asp:DropDownList ID="ddlExpectedSalary" runat="server" CssClass="txt-drps">
               
                    <asp:ListItem>Select One</asp:ListItem>
                    <asp:ListItem>10,000 - 14,999</asp:ListItem>
                    <asp:ListItem>15,000 - 19.999</asp:ListItem>
                    <asp:ListItem>20,000 - 24,999</asp:ListItem>
                    <asp:ListItem>25,000 - 29,999</asp:ListItem>
                    <asp:ListItem>30,000 - 34,999</asp:ListItem>
                    <asp:ListItem>35,000 - 39,999</asp:ListItem>
                    <asp:ListItem>40,000 - 44,999</asp:ListItem>
                    <asp:ListItem>45,000 - 49,999</asp:ListItem>
                    <asp:ListItem>50,000 - 54,999</asp:ListItem>
                    <asp:ListItem>55,000 - 59,999</asp:ListItem>
                    <asp:ListItem>60,000 - 64,999</asp:ListItem>
                    <asp:ListItem>65,000 - 69,999</asp:ListItem>
                    <asp:ListItem>70,000 - 99,999</asp:ListItem>
                    <asp:ListItem>1,00,000 - 1,49,999</asp:ListItem>
                    <asp:ListItem>1,50,000 - 1,99,999</asp:ListItem>
                    <asp:ListItem>2,00,000 - 2,99,999</asp:ListItem>
                    <asp:ListItem>3,00,000 - 3,99,999</asp:ListItem>
                    <asp:ListItem>4,00,000 - 4,99,999</asp:ListItem>
                    <asp:ListItem>5,00,000 - 5,99,999</asp:ListItem>
                    <asp:ListItem>6,00,000 +</asp:ListItem>
                    <asp:ListItem>Negotiable</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="ddlExpectedSalary" Text="*" ForeColor="Red" ValidationGroup="v1"></asp:RequiredFieldValidator>
        </td>
        </tr>
         <tr>
        <td>Previous Employer</td>
        <td> <asp:TextBox ID="txtPreviousEmployer" runat="server" CssClass="txt-flds"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtPreviousEmployer" Text="*" ForeColor="Red" ValidationGroup="v1"></asp:RequiredFieldValidator>
        </td>
        </tr>
         <tr>
        <td>Present Job Location<asp:Label ID="Label1" Text="*" runat="server" ForeColor="Red"></asp:Label></td>
        <td><asp:TextBox ID="txtpresentJobLocation" runat="server" CssClass="txt-flds"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtpresentJobLocation" Text="*" ForeColor="Red" ValidationGroup="v1"></asp:RequiredFieldValidator>
        </td>
        </tr>
         <tr>
        <td>Preferred Job Location<asp:Label ID="Label2" Text="*" runat="server" ForeColor="Red"></asp:Label></td>
        <td>
        <asp:DropDownList id="ddlCountry" runat="server" CssClass="txt-drps">
<asp:ListItem>Select Country</asp:ListItem>
<asp:ListItem>Afghanistan</asp:ListItem>
<asp:ListItem>Albania</asp:ListItem>
<asp:ListItem>Algeria</asp:ListItem>
<asp:ListItem>American Samoa</asp:ListItem>
<asp:ListItem>Andorra</asp:ListItem>
<asp:ListItem>Angola</asp:ListItem>
<asp:ListItem>Anguilla</asp:ListItem>
<asp:ListItem>Antarctica</asp:ListItem>
<asp:ListItem>Antigua And Barbuda</asp:ListItem>
<asp:ListItem>Argentina</asp:ListItem>
<asp:ListItem>Armenia</asp:ListItem>
<asp:ListItem>Aruba</asp:ListItem>
<asp:ListItem>Australia</asp:ListItem>
<asp:ListItem>Austria</asp:ListItem>
<asp:ListItem>Azerbaijan</asp:ListItem>
<asp:ListItem>Bahamas</asp:ListItem>
<asp:ListItem>Bahrain</asp:ListItem>
<asp:ListItem>Bangladesh</asp:ListItem>
<asp:ListItem>Barbados</asp:ListItem>
<asp:ListItem>Belarus</asp:ListItem>
<asp:ListItem>Belgium</asp:ListItem>
<asp:ListItem>Belize</asp:ListItem>
<asp:ListItem>Benin</asp:ListItem>
<asp:ListItem>Bermuda</asp:ListItem>
<asp:ListItem>Bhutan</asp:ListItem>
<asp:ListItem>Bolivia</asp:ListItem>
<asp:ListItem>Bosnia And Herzegowina</asp:ListItem>
<asp:ListItem>Botswana</asp:ListItem>
<asp:ListItem>Bouvet Island</asp:ListItem>
<asp:ListItem>Brazil</asp:ListItem>
<asp:ListItem>British Indian Ocean Territory</asp:ListItem>
<asp:ListItem>Brunei Darussalam</asp:ListItem>
<asp:ListItem>Bulgaria</asp:ListItem>
<asp:ListItem>Burkina Faso</asp:ListItem>
<asp:ListItem>Burundi</asp:ListItem>
<asp:ListItem>Cambodia</asp:ListItem>
<asp:ListItem>Cameroon</asp:ListItem>
<asp:ListItem>Canada</asp:ListItem>
<asp:ListItem>Cape Verde</asp:ListItem>
<asp:ListItem>Cayman Islands</asp:ListItem>
<asp:ListItem>Central African Republic</asp:ListItem>
<asp:ListItem>Chad</asp:ListItem>
<asp:ListItem>Chile</asp:ListItem>
<asp:ListItem>China</asp:ListItem>
<asp:ListItem>Christmas Island</asp:ListItem>
<asp:ListItem>Cocos (Keeling) Islands</asp:ListItem>
<asp:ListItem>Colombia</asp:ListItem>
<asp:ListItem>Comoros</asp:ListItem>
<asp:ListItem>Congo</asp:ListItem>
<asp:ListItem>Cook Islands</asp:ListItem>
<asp:ListItem>Costa Rica</asp:ListItem>
<asp:ListItem>Cote D'Ivoire</asp:ListItem>
<asp:ListItem>Croatia (Local Name: Hrvatska)</asp:ListItem>
<asp:ListItem>Cuba</asp:ListItem>
<asp:ListItem>Cyprus</asp:ListItem>
<asp:ListItem>Czech Republic</asp:ListItem>
<asp:ListItem>Denmark</asp:ListItem>
<asp:ListItem>Djibouti</asp:ListItem>
<asp:ListItem>Dominica</asp:ListItem>
<asp:ListItem>Dominican Republic</asp:ListItem>
<asp:ListItem>East Timor</asp:ListItem>
<asp:ListItem>Ecuador</asp:ListItem>
<asp:ListItem>Egypt</asp:ListItem>
<asp:ListItem>El Salvador</asp:ListItem>
<asp:ListItem>Equatorial Guinea</asp:ListItem>
<asp:ListItem>Eritrea</asp:ListItem>
<asp:ListItem>Estonia</asp:ListItem>
<asp:ListItem>Ethiopia</asp:ListItem>
<asp:ListItem>Falkland Islands (Malvinas)</asp:ListItem>
<asp:ListItem>Faroe Islands</asp:ListItem>
<asp:ListItem>Fiji</asp:ListItem>
<asp:ListItem>Finland</asp:ListItem>
<asp:ListItem>France</asp:ListItem>
<asp:ListItem>French Guiana</asp:ListItem>
<asp:ListItem>French Polynesia</asp:ListItem>
<asp:ListItem>French Southern Territories</asp:ListItem>
<asp:ListItem>Gabon</asp:ListItem>
<asp:ListItem>Gambia</asp:ListItem>
<asp:ListItem>Georgia</asp:ListItem>
<asp:ListItem>Germany</asp:ListItem>
<asp:ListItem>Ghana</asp:ListItem>
<asp:ListItem>Gibraltar</asp:ListItem>
<asp:ListItem>Greece</asp:ListItem>
<asp:ListItem>Greenland</asp:ListItem>
<asp:ListItem>Grenada</asp:ListItem>
<asp:ListItem>Guadeloupe</asp:ListItem>
<asp:ListItem>Guam</asp:ListItem>
<asp:ListItem>Guatemala</asp:ListItem>
<asp:ListItem>Guinea</asp:ListItem>
<asp:ListItem>Guinea-Bissau</asp:ListItem>
<asp:ListItem>Guyana</asp:ListItem>
<asp:ListItem>Haiti</asp:ListItem>
<asp:ListItem>Heard And Mc Donald Islands</asp:ListItem>
<asp:ListItem>Holy See (Vatican City State)</asp:ListItem>
<asp:ListItem>Honduras</asp:ListItem>
<asp:ListItem>Hong Kong</asp:ListItem>
<asp:ListItem>Hungary</asp:ListItem>
<asp:ListItem>Icel And</asp:ListItem>
<asp:ListItem>India</asp:ListItem>
<asp:ListItem>Indonesia</asp:ListItem>
<asp:ListItem>Iran (Islamic Republic Of)</asp:ListItem>
<asp:ListItem>Iraq</asp:ListItem>
<asp:ListItem>Ireland</asp:ListItem>
<asp:ListItem>Israel</asp:ListItem>
<asp:ListItem>Italy</asp:ListItem>
<asp:ListItem>Jamaica</asp:ListItem>
<asp:ListItem>Japan</asp:ListItem>
<asp:ListItem>Jordan</asp:ListItem>
<asp:ListItem>Kazakhstan</asp:ListItem>
<asp:ListItem>Kenya</asp:ListItem>
<asp:ListItem>Kiribati</asp:ListItem>
<asp:ListItem>Korea, Dem People'S Republic</asp:ListItem>
<asp:ListItem>Korea, Republic Of</asp:ListItem>
<asp:ListItem>Kuwait</asp:ListItem>
<asp:ListItem>Kyrgyzstan</asp:ListItem>
<asp:ListItem>Lao People'S Dem Republic</asp:ListItem>
<asp:ListItem>Latvia</asp:ListItem>
<asp:ListItem>Lebanon</asp:ListItem>
<asp:ListItem>Lesotho</asp:ListItem>
<asp:ListItem>Liberia</asp:ListItem>
<asp:ListItem>Libyan Arab Jamahiriya</asp:ListItem>
<asp:ListItem>Liechtenstein</asp:ListItem>
<asp:ListItem>Lithuania</asp:ListItem>
<asp:ListItem>Luxembourg</asp:ListItem>
<asp:ListItem>Macau</asp:ListItem>
<asp:ListItem>Macedonia</asp:ListItem>
<asp:ListItem>Madagascar</asp:ListItem>
<asp:ListItem>Malawi</asp:ListItem>
<asp:ListItem>Malaysia</asp:ListItem>
<asp:ListItem>Maldives</asp:ListItem>
<asp:ListItem>Mali</asp:ListItem>
<asp:ListItem>Malta</asp:ListItem>
<asp:ListItem>Marshall Islands</asp:ListItem>
<asp:ListItem>Martinique</asp:ListItem>
<asp:ListItem>Mauritania</asp:ListItem>
<asp:ListItem>Mauritius</asp:ListItem>
<asp:ListItem>Mayotte</asp:ListItem>
<asp:ListItem>Mexico</asp:ListItem>
<asp:ListItem>Micronesia, Federated States</asp:ListItem>
<asp:ListItem>Moldova, Republic Of</asp:ListItem>
<asp:ListItem>Monaco</asp:ListItem>
<asp:ListItem>Mongolia</asp:ListItem>
<asp:ListItem>Montserrat</asp:ListItem>
<asp:ListItem>Morocco</asp:ListItem>
<asp:ListItem>Mozambique</asp:ListItem>
<asp:ListItem>Myanmar</asp:ListItem>
<asp:ListItem>Namibia</asp:ListItem>
<asp:ListItem>Nauru</asp:ListItem>
<asp:ListItem>Nepal</asp:ListItem>
<asp:ListItem>Netherlands</asp:ListItem>
<asp:ListItem>Netherlands Ant Illes</asp:ListItem>
<asp:ListItem>New Caledonia</asp:ListItem>
<asp:ListItem>New Zealand</asp:ListItem>
<asp:ListItem>Nicaragua</asp:ListItem>
<asp:ListItem>Niger</asp:ListItem>
<asp:ListItem>Nigeria</asp:ListItem>
<asp:ListItem>Niue</asp:ListItem>
<asp:ListItem>Norfolk Island</asp:ListItem>
<asp:ListItem>Northern Mariana Islands</asp:ListItem>
<asp:ListItem>Norway</asp:ListItem>
<asp:ListItem>Oman</asp:ListItem>
<asp:ListItem>Pakistan</asp:ListItem>
<asp:ListItem>Palau</asp:ListItem>
<asp:ListItem>Panama</asp:ListItem>
<asp:ListItem>Papua New Guinea</asp:ListItem>
<asp:ListItem>Paraguay</asp:ListItem>
<asp:ListItem>Peru</asp:ListItem>
<asp:ListItem>Philippines</asp:ListItem>
<asp:ListItem>Pitcairn</asp:ListItem>
<asp:ListItem>Poland</asp:ListItem>
<asp:ListItem>Portugal</asp:ListItem>
<asp:ListItem>Puerto Rico</asp:ListItem>
<asp:ListItem>Qatar</asp:ListItem>
<asp:ListItem>Reunion</asp:ListItem>
<asp:ListItem>Romania</asp:ListItem>
<asp:ListItem>Russian Federation</asp:ListItem>
<asp:ListItem>Rwanda</asp:ListItem>
<asp:ListItem>Saint K Itts And Nevis</asp:ListItem>
<asp:ListItem>Saint Lucia</asp:ListItem>
<asp:ListItem>Saint Vincent, The Grenadines</asp:ListItem>
<asp:ListItem>Samoa</asp:ListItem>
<asp:ListItem>San Marino</asp:ListItem>
<asp:ListItem>Sao Tome And Principe</asp:ListItem>
<asp:ListItem>Saudi Arabia</asp:ListItem>
<asp:ListItem>Senegal</asp:ListItem>
<asp:ListItem>Seychelles</asp:ListItem>
<asp:ListItem>Sierra Leone</asp:ListItem>
<asp:ListItem>Singapore</asp:ListItem>
<asp:ListItem>Slovakia (Slovak Republic)</asp:ListItem>
<asp:ListItem>Slovenia</asp:ListItem>
<asp:ListItem>Solomon Islands</asp:ListItem>
<asp:ListItem>Somalia</asp:ListItem>
<asp:ListItem>South Africa</asp:ListItem>
<asp:ListItem>South Georgia , S Sandwich Is.</asp:ListItem>
<asp:ListItem>Spain</asp:ListItem>
<asp:ListItem>Sri Lanka</asp:ListItem>
<asp:ListItem>St. Helena</asp:ListItem>
<asp:ListItem>St. Pierre And Miquelon</asp:ListItem>
<asp:ListItem>Sudan</asp:ListItem>
<asp:ListItem>Suriname</asp:ListItem>
<asp:ListItem>Svalbard, Jan Mayen Islands</asp:ListItem>
<asp:ListItem>Sw Aziland</asp:ListItem>
<asp:ListItem>Sweden</asp:ListItem>
<asp:ListItem>Switzerland</asp:ListItem>
<asp:ListItem>Syrian Arab Republic</asp:ListItem>
<asp:ListItem>Taiwan</asp:ListItem>
<asp:ListItem>Tajikistan</asp:ListItem>
<asp:ListItem>Tanzania, United Republic Of</asp:ListItem>
<asp:ListItem>Thailand</asp:ListItem>
<asp:ListItem>Togo</asp:ListItem>
<asp:ListItem>Tokelau</asp:ListItem>
<asp:ListItem>Tonga</asp:ListItem>
<asp:ListItem>Trinidad And Tobago</asp:ListItem>
<asp:ListItem>Tunisia</asp:ListItem>
<asp:ListItem>Turkey</asp:ListItem>
<asp:ListItem>Turkmenistan</asp:ListItem>
<asp:ListItem>Turks And Caicos Islands</asp:ListItem>
<asp:ListItem>Tuvalu</asp:ListItem>
<asp:ListItem>Uganda</asp:ListItem>
<asp:ListItem>Ukraine</asp:ListItem>
<asp:ListItem>United Arab Emirates</asp:ListItem>
<asp:ListItem>United Kingdom</asp:ListItem>
<asp:ListItem>United States</asp:ListItem>
<asp:ListItem>United States Minor Is.</asp:ListItem>
<asp:ListItem>Uruguay</asp:ListItem>
<asp:ListItem>Uzbekistan</asp:ListItem>
<asp:ListItem>Vanuatu</asp:ListItem>
<asp:ListItem>Venezuela</asp:ListItem>
<asp:ListItem>Viet Nam</asp:ListItem>
<asp:ListItem>Virgin Islands (British)</asp:ListItem>
<asp:ListItem>Virgin Islands (U.S.)</asp:ListItem>
<asp:ListItem>Wallis And Futuna Islands</asp:ListItem>
<asp:ListItem>Western Sahara</asp:ListItem>
<asp:ListItem>Yemen</asp:ListItem>
<asp:ListItem>Zaire</asp:ListItem>
<asp:ListItem>Zambia</asp:ListItem>
<asp:ListItem>Zimbabwe</asp:ListItem>
</asp:DropDownList>
<asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="ddlCountry" Text="*" ForeColor="Red" ValidationGroup="v1"></asp:RequiredFieldValidator>
        </td>
        </tr>
         <tr>
        <td>Total Experience</td>
        <td>
 <asp:DropDownList id="ddltotalexperience" runat="server" CssClass="txt-drps-small-01">
                    <asp:ListItem>- Year -</asp:ListItem>
                    <asp:ListItem>0</asp:ListItem>
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                    <asp:ListItem>13</asp:ListItem>
                    <asp:ListItem>14</asp:ListItem>
                    <asp:ListItem>15</asp:ListItem>
                    <asp:ListItem>16</asp:ListItem>
                    <asp:ListItem>17</asp:ListItem>
                    <asp:ListItem>18</asp:ListItem>
                    <asp:ListItem>19</asp:ListItem>
                    <asp:ListItem>20</asp:ListItem>
                    <asp:ListItem>21</asp:ListItem>
                    <asp:ListItem>22</asp:ListItem>
                    <asp:ListItem>23</asp:ListItem>
                    <asp:ListItem>24</asp:ListItem>
                    <asp:ListItem>25</asp:ListItem>
                    <asp:ListItem>26</asp:ListItem>
                    <asp:ListItem>27</asp:ListItem>
                    <asp:ListItem>28</asp:ListItem>
                    <asp:ListItem>29</asp:ListItem>
                    <asp:ListItem>30</asp:ListItem>
                    <asp:ListItem>31</asp:ListItem>
                    <asp:ListItem>32</asp:ListItem>
                    <asp:ListItem>33</asp:ListItem>
                    <asp:ListItem>34</asp:ListItem>
                    <asp:ListItem>35</asp:ListItem>
                    <asp:ListItem>36</asp:ListItem>
                    <asp:ListItem>37</asp:ListItem>
                    <asp:ListItem>38</asp:ListItem>
                    <asp:ListItem>39</asp:ListItem>
                    <asp:ListItem>40</asp:ListItem>
                    <asp:ListItem>41</asp:ListItem>
                    <asp:ListItem>42</asp:ListItem>
                    <asp:ListItem>43</asp:ListItem>
                    <asp:ListItem>44</asp:ListItem>
                    <asp:ListItem>45</asp:ListItem>
                    <asp:ListItem>46</asp:ListItem>
                    <asp:ListItem>47</asp:ListItem>
                    <asp:ListItem>48</asp:ListItem>
                    <asp:ListItem>49</asp:ListItem>
                    <asp:ListItem>50</asp:ListItem>
                </asp:DropDownList>
                    <asp:DropDownList id="ddlMonths" runat="server" CssClass="txt-drps-small-01">
                    <asp:ListItem>- Month -</asp:ListItem>
                    <asp:ListItem>0</asp:ListItem>
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                </asp:DropDownList>          
                <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="ddltotalexperience" Text="*" ForeColor="Red" ValidationGroup="v1"></asp:RequiredFieldValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="ddlMonths" Text="*" ForeColor="Red" ValidationGroup="v1"></asp:RequiredFieldValidator>
        </td>
        </tr>
         <tr>
        <td>Interested Job Type<asp:Label ID="Label3" Text="*" runat="server" ForeColor="Red"></asp:Label></td>
        <td>
       <asp:DropDownList id="ddlJobtype" runat="server" CssClass="txt-drps">
                   <asp:ListItem>- Select Job Type -</asp:ListItem>
                    <asp:ListItem>Dean</asp:ListItem>
                    <asp:ListItem>Director</asp:ListItem>
                    <asp:ListItem>Vice Chancellor</asp:ListItem>
                    <asp:ListItem>Registrar</asp:ListItem>
                    <asp:ListItem>Principal</asp:ListItem>
                    <asp:ListItem>Vice Principal</asp:ListItem>
                    <asp:ListItem>TGT</asp:ListItem>
                    <asp:ListItem>PGT</asp:ListItem>
                    <asp:ListItem>PRT</asp:ListItem>
                    <asp:ListItem>Head Mistress</asp:ListItem>
                    <asp:ListItem>Administrator</asp:ListItem>
                    <asp:ListItem>Activity Teacher</asp:ListItem>
                    <asp:ListItem>Dance Teacher</asp:ListItem>
                    <asp:ListItem>Maths Teacher</asp:ListItem>
                    <asp:ListItem>English Teacher</asp:ListItem>
                    <asp:ListItem>Hindi Teacher</asp:ListItem>
                    <asp:ListItem>Science Teacher</asp:ListItem>
                    <asp:ListItem>Social Science Teacher</asp:ListItem>
                    <asp:ListItem>Language Teacher</asp:ListItem>
                    <asp:ListItem>Music Teacher</asp:ListItem>
                    <asp:ListItem>Art & Craft Teacher</asp:ListItem>
                    <asp:ListItem>Coordinator</asp:ListItem>
                    <asp:ListItem>Head of the Department</asp:ListItem>
                    <asp:ListItem>Professor</asp:ListItem>
                    <asp:ListItem>Asst. Professor</asp:ListItem>
                    <asp:ListItem>Reader</asp:ListItem>
                    <asp:ListItem>Associate Lecturer</asp:ListItem>
                    <asp:ListItem>Lecturer</asp:ListItem>
                    <asp:ListItem>Librarian</asp:ListItem>
                    <asp:ListItem>Accountant</asp:ListItem>
                    <asp:ListItem>Physical Trainer</asp:ListItem>
                    <asp:ListItem>Lab Technician</asp:ListItem>
                    <asp:ListItem>Lab Assistant</asp:ListItem>
                    <asp:ListItem>Head Master</asp:ListItem>
                    <asp:ListItem>Nursery Teacher</asp:ListItem>
                    <asp:ListItem>Primary Teacher</asp:ListItem>
                    <asp:ListItem>Secondary Teacher</asp:ListItem>
                    <asp:ListItem>Sr.Secondary Teacher</asp:ListItem>
                    <asp:ListItem>Public Relation Officer</asp:ListItem>
                    <asp:ListItem>Others</asp:ListItem>
               </asp:DropDownList>
               <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="ddlJobtype" Text="*" ForeColor="Red" ValidationGroup="v1"></asp:RequiredFieldValidator>
        </td>
        </tr>
         <tr>
        <td>Highest Qualification<asp:Label ID="Label4" Text="*" runat="server" ForeColor="Red"></asp:Label></td>
        <td>
        <asp:DropDownList id="ddlhighestQualification" runat="server" CssClass="txt-drps">
                    <asp:ListItem>-Select Degree-</asp:ListItem>
                    <asp:ListItem>Any graduate</asp:ListItem>
                    <asp:ListItem>Aviation</asp:ListItem>
                    <asp:ListItem>B.A</asp:ListItem>
                    <asp:ListItem>B.Com</asp:ListItem>
                    <asp:ListItem>B.Tech</asp:ListItem>
                    <asp:ListItem>B.Ed</asp:ListItem>
                    <asp:ListItem>BCA</asp:ListItem>
                    <asp:ListItem>B.Pharm</asp:ListItem>
                    <asp:ListItem>B.Sc</asp:ListItem>
                    <asp:ListItem>BBA</asp:ListItem>
                    <asp:ListItem>Human Resources</asp:ListItem>
                    <asp:ListItem>B.Arch</asp:ListItem>
                    <asp:ListItem>MBA</asp:ListItem>
                    <asp:ListItem>MBBS</asp:ListItem>
                    <asp:ListItem>MCA</asp:ListItem>
                    <asp:ListItem>M.Com</asp:ListItem>
                    <asp:ListItem>MD/MS</asp:ListItem>
                    <asp:ListItem>M.Ed</asp:ListItem>
                    <asp:ListItem>M.E/M.Tech/MS</asp:ListItem>
                    <asp:ListItem>ML/LLM</asp:ListItem>
                    <asp:ListItem>M.Pharm</asp:ListItem>
                    <asp:ListItem>Mphil</asp:ListItem>
                    <asp:ListItem>M.Sc</asp:ListItem>
                    <asp:ListItem>PGDCA</asp:ListItem>
                    <asp:ListItem>Mphil</asp:ListItem>
                    <asp:ListItem>M.Sc</asp:ListItem>
                    <asp:ListItem>PGDCA</asp:ListItem>
                    <asp:ListItem>PG Diploma</asp:ListItem>
                    <asp:ListItem>PGDM</asp:ListItem>
                    <asp:ListItem>Phd</asp:ListItem>
                    <asp:ListItem>Other</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ControlToValidate="ddlhighestQualification" Text="*" ForeColor="Red" ValidationGroup="v1"></asp:RequiredFieldValidator>
        </td>
        </tr>
         <tr>
        <td>Passing Year<asp:Label ID="Label5" Text="*" runat="server" ForeColor="Red"></asp:Label></td>
        <td>
        <asp:DropDownList id="ddlPassingYear" runat="server" CssClass="txt-drps">
                    <asp:ListItem>-Passing Year-</asp:ListItem>
                    <asp:ListItem>2011</asp:ListItem>
                    <asp:ListItem>2010</asp:ListItem>
                    <asp:ListItem>2009</asp:ListItem>
                    <asp:ListItem>2008</asp:ListItem>
                    <asp:ListItem>2007</asp:ListItem>
                    <asp:ListItem>2006</asp:ListItem>
                    <asp:ListItem>2005</asp:ListItem>
                    <asp:ListItem>2004</asp:ListItem>
                    <asp:ListItem>2003</asp:ListItem>
                    <asp:ListItem>2002</asp:ListItem>
                    <asp:ListItem>2001</asp:ListItem>
                    <asp:ListItem>2000</asp:ListItem>
                    <asp:ListItem>1999</asp:ListItem>
                    <asp:ListItem>1998</asp:ListItem>
                    <asp:ListItem>1997</asp:ListItem>
                    <asp:ListItem>1996</asp:ListItem>
                    <asp:ListItem>1995</asp:ListItem>
                    <asp:ListItem>1994</asp:ListItem>
                    <asp:ListItem>1993</asp:ListItem>
                    <asp:ListItem>1992</asp:ListItem>
                    <asp:ListItem>1991</asp:ListItem>
                    <asp:ListItem>1990</asp:ListItem>
                    <asp:ListItem>1989</asp:ListItem>
                    <asp:ListItem>1988</asp:ListItem>
                    <asp:ListItem>1987</asp:ListItem>
                    <asp:ListItem>1986</asp:ListItem>
                    <asp:ListItem>1985</asp:ListItem>
                    <asp:ListItem>1984</asp:ListItem>
                    <asp:ListItem>1983</asp:ListItem>
                    <asp:ListItem>1982</asp:ListItem>
                    <asp:ListItem>1981</asp:ListItem>
                    <asp:ListItem>1980</asp:ListItem>
                    <asp:ListItem>1979</asp:ListItem>
                    <asp:ListItem>1978</asp:ListItem>
                    <asp:ListItem>1977</asp:ListItem>
                    <asp:ListItem>1976</asp:ListItem>
                    <asp:ListItem>1975</asp:ListItem>
                    <asp:ListItem>1974</asp:ListItem>
                    <asp:ListItem>1973</asp:ListItem>
                    <asp:ListItem>1972</asp:ListItem>
                    <asp:ListItem>1971</asp:ListItem>
                    <asp:ListItem>1970</asp:ListItem>
                    <asp:ListItem>1969</asp:ListItem>
                    <asp:ListItem>1968</asp:ListItem>
                    <asp:ListItem>1967</asp:ListItem>
                    <asp:ListItem>1966</asp:ListItem>
                    <asp:ListItem>1965</asp:ListItem>
                    <asp:ListItem>1964</asp:ListItem>
                    <asp:ListItem>1963</asp:ListItem>
                    <asp:ListItem>1962</asp:ListItem>
                    <asp:ListItem>1961</asp:ListItem>
                    <asp:ListItem>1960</asp:ListItem>  
                             </asp:DropDownList>
                             <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ControlToValidate="ddlPassingYear" Text="*" ForeColor="Red" ValidationGroup="v1"></asp:RequiredFieldValidator>
        </td>
        </tr>
         <tr>
        <td>Language<asp:Label ID="Label6" Text="*" runat="server" ForeColor="Red"></asp:Label></td>
        <td><asp:TextBox ID="txtLanguage" runat="server" CssClass="txt-flds"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" ControlToValidate="txtLanguage" Text="*" ForeColor="Red" ValidationGroup="v1"></asp:RequiredFieldValidator>
        </td>
        </tr>
        <tr>
        <td>Resume Title<asp:Label ID="Label7" Text="*" runat="server" ForeColor="Red"></asp:Label></td>
        <td><asp:TextBox ID="txtResumeTitle" runat="server" CssClass="txt-flds"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" ControlToValidate="txtResumeTitle" Text="*" ForeColor="Red" ValidationGroup="v1"></asp:RequiredFieldValidator>
        </td>
        </tr>
        <tr>
        <td>Upload Your Cv<asp:Label ID="Label8" Text="*" runat="server" ForeColor="Red"></asp:Label></td>
        <td>
            <asp:FileUpload ID="FileUploadCV" runat="server" CssClass="txt-flds"/>
            <asp:Label ID="lblFileupload" ForeColor="Green" runat="server">
            
            </asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" ControlToValidate="FileUploadCV" Text="*" ForeColor="Red" ValidationGroup="v1"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td></td>
            <td><asp:Button ID="btnSubmit" Text="Submit" runat="server" ValidationGroup="v1"
                    onclick="btnSubmit_Click"  CssClass="sbmt-btn"/></td>

        </tr>
        <tr>
        <td></td><td><asp:Label ID="lblMsg" Text="" runat="server"></asp:Label>
        <asp:Label ID="lblId" Text="" runat="server"></asp:Label>
            <asp:LinkButton ID="LinkButton1" PostBackUrl="~/JobPlacement/Resume.aspx" runat="server">View Resume</asp:LinkButton>
        </td>
        </tr>
    </table>
</asp:Content>

