<?php
require_once '../php/dbconfig.php';
require_once '../php/data.php';
 ?>
 <div class="row"> </div>
 <div class="row">
   <div class="col-xs-6">
     <p class="object-info-general">
       Date Of Birth:
     </p>
   </div>
   <div class="col-xs-6">
     <p class="object-text-general">
       <?php echo $date_of_birth; ?>

     </p>
   </div>
 </div>
<div class="row">
  <div class="col-xs-6">
    <p class="object-info-general">
      Address:
    </p>
  </div>
  <div class="col-xs-6">
    <p class="object-text-general">
      <?php echo $address_array[0] ?>


    </p>
  </div>
</div>
<div class="row">
  <div class="col-xs-6">
    <p class="object-info-general">
      Password
    </p>
  </div>
  <div class="col-xs-6">
    <a href="#/">
      <p class="object-text-general">
        Reset
      </p>
    </a>
  </div>
</div>
<hr>
<div class="row">
  <div class="col-xs-3 col-xs-offset-9">
    <a href="#/">
        <p id="general-close-button" class="object-text-general">
            close
        </p>
    </a>
  </div>
</div>