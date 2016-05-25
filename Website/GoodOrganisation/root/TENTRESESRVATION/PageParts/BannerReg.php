<?php 
    session_start();
    $_SESSION["LEADERDATA"];
    $leaderData = $_SESSION["LEADERDATA"];
    $tennum = $_SESSION["tennum"];
    $totalprice = $_SESSION["totalprice"];
    unset($_SESSION["LEADERDATA"]);
    unset($_SESSION["tennum"]);
    unset($_SESSION["totalprice"]);
    //echo print_r($leaderData);
?>


<div id="Reg" class="top topcont toptext">
    <h2>Checkout</h2><br>
    <div class="extra toptext">
        <p>Greetings <?php echo $leaderData["FNAME"].' '.$leaderData["LNAME"] ?>!</p><br>
        <p>You are halfway on becoming a new tent chief!</p>
        <p>Confirm the information and pay.</p><br>
        <form id="second-form">
        <div class="tentresconfirm">
            <table id="checkouttable">
                <tr>
                    <th>Tenants</th>
                    <th>Total Price</th>
                    <th>Your Balance</th>
                </tr>
                <tr>
                    <td width="25%"><?php echo $tennum ?></td>
                    <td width="25%" id="tprice"><?php echo $totalprice ?></td>
                    <td width="25%" id="ybal"><?php echo $leaderData["BALANCE"] ?></td>
                </tr>
                <tr>
                    <td></td>
                    <td><input type="submit" value="CONFIRM" class="btn"></td>
                </tr>

            </table>
        </div>
        </form>
        
        
        
    <p id="smallline" class="toclose">Click here <!--<span class="closebanner">(or anywhere outside the map below)</span>--> to go back 
            <b><span class="closebanner x" onclick="HideBanner()">X</span></b></p>
    </div>
</div>


<script>

</script>