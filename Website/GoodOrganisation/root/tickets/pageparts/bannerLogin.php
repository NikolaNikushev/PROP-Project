<!-- Stuff to be loaded here with ajax -->
                <div id="Reg" class="top topcont toptext forlogin">
                    <h2>SIGN IN</h2><br>
                    <div class="extra toptext">
                        <p class="expl">Please, verify your account or <a id="regis" href="../register/">register</a> before you can continue.</p><br>
                        <form id="loginform">
                            <div class="loginconfirm">
                                <label>Email </label><br><input type="email" class="form-control ban" id="user_email" name="user_email" required>
                                <br>
                                <label>Password </label><br><input type="password" class="form-control ban" id="password" name="password" required>
                            </div>
                            <div class="errorconsole">
                                <!-- loads a errcon textarea in case of troubles -->
                            </div>
                            <input type="submit" value="CONFIRM" class="btn">
                        </form>
                            <p id="smallline" class="toclose">Click here to go back 
                            <b><span class="closebanner x" onclick="HideBanner()">X</span></b></p>
                    </div>
                </div>