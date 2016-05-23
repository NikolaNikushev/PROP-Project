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
            GetPrice();
        }
    });
    $("input[name=datechoice]:radio").change(function () {
        GetPrice();
    });
//    ("#dateeight").change(function () {
//        GetPrice();
//    });
//    ("#datenine").change(function () {
//        GetPrice();
//    });

    // banner
    // banner
    
});


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



