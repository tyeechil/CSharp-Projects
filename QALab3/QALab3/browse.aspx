<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="browse.aspx.cs" Inherits="QALab3.browse" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Matchbox Contact Browser</title>

    <!--<link rel="stylesheet" href="css/style.css" type="text/css" />-->
    <!-- jQuery -->    
	<script src="//code.jquery.com/jquery-1.11.2.min.js"></script>
    <!-- CSV to Table plugin -->
	<script type="text/javascript" src="js/jquery.csvToTable.js"></script> 
    <!-- tablesorter plugin files -->
    <!--<link rel="stylesheet" href="css/jquery.tablesorter.pager.css" type="text/css" />
    <script type="text/javascript" src="js/jquery.tablesorter.min.js"></script>
    <script type="text/javascript" src="js/jquery.tablesorter.widgets.min.js"></script>
    <script type="text/javascript" src="js/jquery.tablesorter.pager.min.js"></script>
    <script type="text/javascript" src="js/jquery.tablesorter.widgets.min.js"></script>-->

    <!-- DataTables files (Adam is looking into whether this plugin will work for us or not -->
    <link rel="stylesheet" href="css/jquery.dataTables.css" type="text/css" />
    <link rel="stylesheet" href="css/jquery.dataTables.scroller.css" type="text/css" />
    <script type="text/javascript" src="js/jquery.dataTables.js"></script>
    <script type="text/javascript" src="js/jquery.dataTables.scroller.js"></script>
    <script type="text/javascript" src="js/scripts.js?1"></script>

</head>
<body>
    <form id="form1" runat="server">    
        <h2>Matchbox</h2>
        <h4>Use this to search all fields of Matchbox table data</h4>
        <br />
        <asp:ScriptManager ID="ScriptManager1" runat="server" EnableCdn="true" AjaxFrameworkMode="Disabled" />
        <Scripts>
       <asp:ScriptReference
           Path="http://ajax.microsoft.com/ajax/jquery/jquery-1.4.1.min.js" />
        </Scripts>
        <!-- Search box that searches ALL, yes ALL records! -->  
		<!--Search all results: <input class="search" type="search" data-column="all">
        <!-- This button cancels all searches and returns the table to its original state
        <button type="button" class="reset">Reset</button><br /><br />
        <!-- Form for initializing the pager "toolbar" -->
        <%--<div class="pager">  
            <img src="images/first.png" class="first" title="First page" />
            <img src="images/prev.png" class="prev" title="Previous page" />
            <span class="pagedisplay"></span> <!-- this can be any element, including an input -->
            <img src="images/next.png" class="next" title="Next page" />
            <img src="images/last.png" class="last" title="Last page" />
            <select class="pagesize" title="Results shown" >
              <option selected="selected" value="25">25</option>
              <option value="50">50</option>
              <option value="100">100</option>
              <option value="250">250</option>
              <option value="All">All</option>
            </select>
            <!-- Adam: I don't think we need this, leaving it here just in case -->
            <!--<select class="gotoPage" title="Select page number"></select>--> 
        </div>--%>
        <div id="tblContainer" class="display" onload="buildCSVTable()">
            <!--<thead>                
                <tr>
                    <th>First Name</th>
                    <th>Last Name</th>
                    <th>Employee ID</th>
                </tr>
            </thead>
            <tbody>

            </tbody>-->
            <br />
        </div>
    </form>
</body>
</html>
