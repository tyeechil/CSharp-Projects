//This is the jquery code used to make tablesorter work, you can comment the bottom section instead and uncomment this to re-enable tablesorter
//$(function () {
//    var pagerOptions = {
//        container: $(".pager"),
//        output: '{startRow} - {endRow} / {filteredRows} ({totalRows})',
//        fixedHeight: false,
//        removeRows: false,
//        cssGoto: '.gotoPage',
//        size: 25,
//        pageReset: 0
//    };
//    $('#tblContainer').CSVToTable('matchbox.csv', { loadingImage: 'images/loading.gif', startLine: 1, headers: ['First Name', 'Last Name', 'Employee ID'] }).bind("loadComplete", function () {
//        $('#tblContainer').find('TABLE').tablesorter({
//            widgets: ["filter"],
//            widgetOptions: {
//                filter_external: '.search',
//                filter_columnFilters: false, //search by column, don't think we need this.
//                filter_placeholder: { search: 'Search...' },
//                filter_saveFilters: true,
//                filter_reset: '.reset'
//            }
//        })
//        .tablesorterPager(pagerOptions)
//        var rows = $('table.tablesorter')[0].config.totalRows;
//        $('select.pagesize').find('option:contains("All")').val(rows);
//    });;
//});

$(function buildCSVTable() {
    //$.ajax({
    //    url: "browse.aspx",
    //    data: "get=csvdata",
    //    success: function (data) {
    $('#tblContainer').CSVToTable('matchbox.csv', { loadingImage: 'images/loading.gif', loadingText:'Loading data. This may take a few minutes, as there is a great deal of data to load', startLine: 1, headers: ['FIRST NAME', 'LAST NAME', 'EMPLOYEE ID'] }).bind("loadComplete", function () {
    // Just three fields: $('#tblContainer').CSVToTable('matchbox.csv', { loadingImage: 'images/loading.gif', startLine: 1, headers: ['FIRST NAME', 'LAST NAME', 'EMPLOYEE ID'] }).bind("loadComplete", function () {
            $('#tblContainer').find('TABLE').dataTable({
            //$('#tblContainer').dataTable({  
            //    "processing": true,
            //    "serverSide": true,
            //    "ajax": "browse.aspx?get=csvData",
               "columns": [
                    { "data": "FIRST NAME" },
                  { "data": "LAST NAME" },                    
                    { "data": "EMPLOYEE ID" }


                ],
                "searching": true,
                dom: "frtiS",
                scrollY: 400,
                "sScrollX": "100%",
                scrollCollapse: true,
                "deferRender": true
            });
            });;
    //    },
    //    error: function () { alert("Error"); }
    //});
});