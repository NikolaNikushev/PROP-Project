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