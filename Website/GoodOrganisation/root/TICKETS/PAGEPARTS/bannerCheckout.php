<?php 
    session_start();
    $_SESSION["BALANCE"];
    $bal = $_SESSION["BALANCE"];
    unset($_SESSION["BALANCE"]);
?>

<!-- Stuff to be loaded here with ajax -->
                <div id="Reg" class="top topcont toptext">
                    <h2>Checkout</h2><br>
                    <div class="extra toptext">
                        <p>Confirm the information and proceed.</p><br>
                        <form id="second-form">
                            <div class="tentresconfirm">
                                <table id="checkouttable">
                                    <tr>
                                        <th>Bracelet</th>
                                        <th>Total Price</th>
                                        <th><span id="balanceset" onclick="window.location = '../personal-page'">Balance <img src="../DEFAULT/IMAGES/gearFat.png" title="Go to the personal page to manage your balance" alt="Set"></span></th>
                                    </tr>
                                    <tr>
                                        <td width="33%">
                                            <select class="droptions" onchange="changePrice()">
                                                <option value="BEST">BEST</option>
                                                <option value="BETTER">BETTER</option>
                                                <option value="PERFECT">PERFECT</option>
                                            </select>
                                        </td>
                                        <td width="33%" id="tprice">
                                            <input type="number" readonly id="pr" name="price" value="<?php echo $_POST['price']?>">
                                        </td>
                                        <td width="33%" id="yourbalance">
                                            <input type="number" readonly id="ybal" name="ybal" value="<?php echo $bal ?>">
                                        </td>
                                        <!-- Extra for the balance -->
                                    </tr>

                                </table>
                                <input type="submit" value="CONFIRM" class="btn">
                            </div>
                        </form>



<p id="smallline" class="toclose">Click here <!--<span class="closebanner">(or anywhere outside the map below)</span>--> to go back 
                            <b><span class="closebanner x" onclick="HideBanner()">X</span></b></p>
                    </div>
                </div>