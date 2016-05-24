<?php 
    session_start();
    $_SESSION["LEADERDATA"];
    $leaderData = $_SESSION["LEADERDATA"];
    unset($_SESSION["LEADERDATA"]);
    echo print_r($leaderData);
?>


<div id="Reg" class="top topcont toptext">
    <h2>Checkout</h2><br>
    <div class="extra toptext">
        <p>Greetings <?php echo $leaderData["FNAME"].' '.$leaderData["LNAME"] ?>!</p><br>
        <p>You are halfway on becoming a new tent chief!</p>
        <p>Confirm the information and proceed.</p><br>
        <div class="tentresconfirm">
            <table id="checkouttable">
                <tr>
                    <th>Tenants</th>
                    <th>Price/Day</th>
                    <th>Your Balance</th>
                    <th>Total Price</th>
                </tr>
                <tr>
                    <td width="25%"></td>
                    <td width="25%"></td>
                    <td width="25%"><?php echo $leaderData["BALANCE"] ?></td>
                    <td width="25%"></td>
                    
                </tr>
                <tr>
                    <td>Cell</td>
                    <td>Cell</td>
                </tr>

            </table>
        </div>
        
        
        
    <p id="smallline" class="toclose">Click here <!--<span class="closebanner">(or anywhere outside the map below)</span>--> to go back 
            <b><span class="closebanner x" onclick="HideBanner()">X</span></b></p>
    </div>
</div>


<script>

</script>