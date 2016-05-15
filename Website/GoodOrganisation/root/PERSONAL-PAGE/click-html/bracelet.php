<?php
session_start();
require_once '../php/dbconfig.php';
require_once '../php/loanItemsData.php';
 ?>
<div class="row"> </div>
<div class="row">
  <div class="col-xs-5">
    <p class="object-info-bracelet">
      Status:
    </p>
  </div>
  <div class="col-xs-7">
    <p class="object-text-bracelet">
      <?php echo $STATUS ?>
    </p>
  </div>
</div>
<div class="row">
  <div class="col-xs-5">
    <p class="object-info-bracelet">
      Bracelet ID:
    </p>
  </div>
  <div class="col-xs-7">
    <p class="object-text-bracelet">
      <?php echo $BRACELET_ID ?>
    </p>
  </div>
</div>
<hr>
<div class="row">
  <div class="col-xs-3 col-xs-offset-9">
    <a href="#/">
        <p id="bracelet-close-button" class="object-text-general">
            close
        </p>
    </a>
  </div>
</div>
