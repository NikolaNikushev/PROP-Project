<!--snippet of html code which is loaded dynamically with the click of the corresponding button  -->
<div class="row"></div>

  <div class="row">
    <div class="col-xs-12">
      <p id ="ballance-info-bar">
        Here you can increse the ballace of your credits and use them on the territory of the event
      </p>
    </div>

  </div>
<form id="add-credits">
  <div class="row">
    <div class="col-xs-4">
    <p id="amount-text">
      Amount:
    </p>
    </div>
    <div class="col-xs-5">
      <input type="number" name="amount" min="1" id=input-number>
    </div>
    <div class="col-xs-1">
      <button type="submit" class="btn" id="submit-button">Add</button>
    </div>
  </div>

</form>
<hr>
<div class="row">
  <div class="col-xs-3 col-xs-offset-9">
    <a href="#/">
        <p id="balance-close-button" class="object-text-general">
            close
        </p>
    </a>
  </div>
</div>
