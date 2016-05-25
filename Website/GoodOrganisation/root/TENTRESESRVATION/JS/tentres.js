var i;
var tenants = ["#leader", "#gu1", "#gu2", "#gu3", "#gu4", "#gu5"];
i = tenants.length;




$(document).ready(function () {
    // first page load
    // to load up the header
    //$( "#header").load( "../../default/headerstatic.html" );

    var globval = $("#tennum").val();
    for (j = globval; j < i; j++) {
        $(tenants[j]).hide();
    }


    // kind of event handlers
    $(".plus").click(function () {
        var value = $("#tennum").val();
        if (value != 6)
        {
            value++;
            $("#tennum").val(value);
            $(tenants[value - 1]).find(".form-control").prop('disabled', false);
            $(tenants[value - 1]).show();

            GetPrice();
        }
        
    });
    $(".minus").click(function () {
        var value = $("#tennum").val();
        if (value != 1)
        {
            value--;
            $("#tennum").val(value);
            $(tenants[value]).find(".form-control").removeAttr('value');
            $(tenants[value]).find(".form-control").prop('disabled', true);

            $(tenants[value]).hide();
            CheckForReps();
            GetPrice();
        }
    });
    $("input[name=datechoice]:radio").change(function () {
        GetPrice();
    });
    $(".emimp").blur(function() {
        var sender = "#"+this.id;
        CheckEmailUnique();
        //alert(sender);
    });
    //$(".emimp").focusout(CheckEmailUnique(this.id));
    
//    ("#dateeight").change(function () {
//        GetPrice();
//    });
//    ("#datenine").change(function () {
//        GetPrice();
//    });

    // banner
    // banner

});

// should not depend on which email to check but check all of them instead, thus a parameter should not be expected
function CheckEmailUnique() {
     CheckForReps();
//    var noProblems = true;
////    not good
////    for (var s = 0; s < tenants.length; s++)
////    {
////        var teninpid = ("#"+$(tenants[s]).find(".emimp").attr('id'));
////        var inpcont = $(tenants[s]).find(".emimp").val();
////        if (
////                $(elid).val() != "" 
////                &&
////                elid !== teninpid
////                &&
////                $(elid).val() ===  inpcont
////            )
////        {
////            //alert("Wrong!")
////            DisplayEmailAlert(elid, s);
////            noProblems = false;
////        }
////    }
//    var probid = "";
//    if(noProblems)
//    {
//        HideWarnings();
//    }
//    for (i = 0; i < (tenants.length - 1); i++)
//    {
//        for (j = (tenants.length - 1); j > i; j--)
//        {
//            probid = ("#"+$(tenants[j]).find(".emimp").attr('id'));
//            var leftcont = $(tenants[i]).find(".emimp").val();
//            var rightcont = $(tenants[j]).find(".emimp").val();
//            if (
//                    leftcont !== "" &&
//                    rightcont !== "" &&
//                    leftcont == rightcont
//                    )
//            {
//                //alert("Wrong!")
//                // gets an index of a first element the value of which is repeated further and displays the errors
//                DisplayEmailAlert(probid, i);
//                noProblems = false;
//            }
//        }
//    }
    
}
function CheckForReps() {
    var noProblems = true;
    var probid = "";
    if(noProblems)
    {
        HideWarnings();
    }
    for (i = 0; i < (tenants.length - 1); i++)
    {
        for (j = (tenants.length - 1); j > i; j--)
        {
            probid = ("#"+$(tenants[j]).find(".emimp").attr('id'));
            var leftcont = $(tenants[i]).find(".emimp").val();
            var rightcont = $(tenants[j]).find(".emimp").val();
            if (
                    leftcont !== "" &&
                    rightcont !== "" &&
                    leftcont == rightcont
                    )
            {
                //alert("Wrong!")
                // gets an index of a first element the value of which is repeated further and displays the errors
                DisplayEmailAlert(probid, i);
                noProblems = false;
            }
        }
    }
}

function HideWarnings() {
//    $(elid).css('background-color', '#FFD105');
   $("#submbtn").prop('disabled', false);
//    
    for (var s = 0; s < tenants.length; s++)
    {
        $(tenants[s]).find(".emimp").css('background-color', '#FFD105');
        $(tenants[s]).find(".nuwarning").hide();
    }
}
// takes an element the bg color of which should be changed and also an index of an alert to display
function DisplayEmailAlert(elid, tind) {
    $(elid).css('background-color', '#f58235');
    $(tenants[tind]).find(".emimp").css('background-color', '#f58235');
    $(tenants[tind]).find(".nuwarning").show();
    $("#submbtn").prop('disabled', true);
    
}


function HideBanner()
{
    $(".banner").hide();
}



function GetPrice()
{
    if ($('.rdbtn').is(':checked'))
    {
        var entrprice;
        if ($('#dateeight').is(':checked'))
        {
            entrprice = 25;
        }
        else
        {
            entrprice = 15;
        }
        var price = entrprice * $("#tennum").val();
        $('#finprice').val(price);
    }
}



