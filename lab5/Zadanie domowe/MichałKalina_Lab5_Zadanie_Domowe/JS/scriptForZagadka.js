//***********************************************************************************************************************
var points =0;
//Dobra odpowiedz
function Dobrze()
{
	alert("Dobrze");

	points=points+1;
	if(points>7)
	{
		alert("Wygraleś GRĘ. Kliknij OK aby przejść do strony głównej");
		location.href="Michal_Kalina_Lab5.html";
	}
}

//Zla odpowiedz
function Zle()
{
	alert("Zła odpowiedź");
}
//przekierowanie na zagadki
function StartPuzzle()
{
	setTimeout(function(){ alert("Minęłó pół minuty. Przegrales. Za 5 sekund zostaniesz przekierowany do menu"); }, 30000);
	setTimeout(function(){ location.href="Michal_Kalina_Lab5.html"; }, 35000);
}
