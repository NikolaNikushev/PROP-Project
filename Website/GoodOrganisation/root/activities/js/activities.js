// jQuery hovering functionality
$(document).ready(function() {

    $("#managingbtn").click(function() {
        closeOrOpen();
    });

});


$tabOpened = false;

function closeOrOpen() {
    if ($tabOpened) {
        $(".tocloseoropen").hide();
        $tabOpened = false;

    } else {
        $tabOpened = true;
        $(".tocloseoropen").show();

    }
}