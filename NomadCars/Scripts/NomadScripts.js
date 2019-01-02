//if (!Modernizr.inputtypes.date)
//{
//    $('input[type=date]').datepicker(
//        {
//            dateFormat: "dd/mm/yyyy"
//        });
//}

if (!Modernizr.inputtypes.date) {
    $(function () {
        $("input[type='date']")
            .datepicker()
            .get(0)
            .setAttribute("type", "text");
    })
}

$(function () {
    $(".datepicker").datepicker({
        dateFormat: 'dd-mm-yyyy'
    });
});

//$('input[type="date"]').datepicker();

//$.validator.methods["date"] = function (value, element) { return true; } 
