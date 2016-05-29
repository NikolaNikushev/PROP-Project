
$(document).ready(function () {
    $(document).on('submit', '#second-form', function () {

        // converting the strings to numeric values
        $price = parseInt($("#pr").val(), 10);
        $ybal = parseInt($("#ybal").val(), 10);
        $("#ybal").css("background-color","#3B4D81");
        if ($price <= $ybal)
        {
            data = $(this).serialize();

            $.ajax({
                type: 'POST',
                url: 'php/ProcessTicketing.php',
                data: data,
                success: function (response) {
                    if (response.includes('sucessful')) {
                        $(".banner").hide();

                        swal({
                            html: true,
                            title: "<span style= \"color:#fce600\" >Succesfully purchased a ticket!</span>",
                            text: "<span style= \"color:#ff9933\" >Now you are going to be redirected to your personal page!</span>",
                            type: "success",
                            confirmButtonColor: "#333399",
                            confirmButtonText: "Okay"
                        }, function (isConfirm) {
                            if (isConfirm) {
                                window.location = "../personal-page";
                            }
                        });
                        //alert('Sorry, it is not possible yet, we are working on it though');
                        //$("#Reg").show();
                        //alert(response);

                    } else {
                        alert(response);
                        //$("#noReg").show();
                    }
                }
            });
        }
        else
        {
            $("#ybal").css("background-color","#f58235")
        }
        return false;
    });
});



function changePrice(){
  var choice = $(".droptions").val();
  switch(choice) {
    case "BEST":
        $("#pr").val(55);
        break;
    case "BETTER":
        $("#pr").val(85);
        break;
    case "PERFECT":
        $("#pr").val(125);
        break;
    }
};