
//section opening
var isOpen = 0;
var isSectOpen = [];
isSectOpen["firstsec"] = 0;
isSectOpen["secsec"] = 0;
isSectOpen["thirsec"] = 0;
//contentchanging
var BtnIndics = ["leftBtnDay","centerBtnDay","rightBtnDay"];
var contents = [];
contents["leftBtnDay"] = "data/fdaysched.html";
contents["centerBtnDay"] = "data/sdaysched.html";
contents["rightBtnDay"] = "data/tdaysched.html";
var isLoaded = [];
isLoaded["leftBtnDay"] = 1;
isLoaded["centerBtnDay"] = 0;
isLoaded["rightBtnDay"] = 0;

// Opeing tabs with info
function OpenSec(indicSec, indicTxt)
{
	if(isSectOpen[indicSec] === 0)
	{
		document.getElementById(indicSec).style.width = "auto";
		document.getElementById(indicTxt).style.display = "block";
		isSectOpen[indicSec] = 1;
		isOpen = 1;
	}
	else
	{
		document.getElementById(indicSec).style.width = "2vw";
		document.getElementById(indicTxt).style.display = "none";
		isSectOpen[indicSec] = 0;
		isOpen = 0;
	}
}

// JS for handling buttons
function DayClick(indicBtn)
{
	// change appearance begin
	var Btn = document.getElementById(indicBtn);
	
	Btn.style.background = "#D7E1F2";
	Btn.style.color = "#F58235";
	var i= 0;
	for	(index = 0; index < BtnIndics.length; index++) 
	{
		if(BtnIndics[index] != indicBtn)
		{
			document.getElementById(BtnIndics[index]).style.background = "#3B4D81";
			document.getElementById(BtnIndics[index]).style.color = "#FFD105";
		};
	}
	// change appearance end
	
	
	// load content
	if(isLoaded[indicBtn] === 0)
	{
		$( ".schedule" ).load( "program/blank.html" );
		$( ".schedule" ).load( contents[indicBtn] );
		isLoaded[indicBtn] = 1;
		
		for	(index = 0; index < BtnIndics.length; index++) 
		{
			if(BtnIndics[index] != indicBtn)
			{
				isLoaded[BtnIndics[index]] = 0;
			};
		}
	}
	
}



// jQuery hovering functionality
$(document).ready(function() {
	// first page load
	// to load up the header
	//$( "#header").load( "default/headerstatic.html" );
	// to load the schedule
	$( ".schedule" ).load( "data/fdaysched.html" );
  // only if this thing is not yet open
   if(isOpen === 0)
   {
	$(".sectionimg").mouseenter(function() {
		
		$(this).animate({
			marginLeft: '+=8px'
		});
		
	});
	$(".sectionimg").mouseleave(function() {
		
		$(this).animate({
			marginLeft: '-=8px'
		}); 
		
	});
	
	
   }
});



