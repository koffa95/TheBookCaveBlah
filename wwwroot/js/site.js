// Write your JavaScript code.

$(document).ready(function() {
    $("#bankastraeti").hide();
    $("#kringlan").hide();
    $("#smaralind").hide();
    $("#mapB").hide();
    $("#mapK").hide(); 
    $("#mapS").hide();
});

$( "#location1" ).click(function() {
    if($("#location2").hasClass("active") == true)
    {
        $("#location2").removeClass("active");
        $("#location1").addClass("active");
        $( "#mapB, #mapL" ).toggle();
        $( "#lagmuli, #bankastraeti" ).toggle();
    }
    else if($("#location3").hasClass("active") == true)
    {
        $("#location3").removeClass("active");
        $("#location1").addClass("active");
        $( "#mapK, #mapL" ).toggle();
        $( "#lagmuli, #kringlan" ).toggle();
    }
    else if($("#location4").hasClass("active") == true)
    {
        $("#location4").removeClass("active");
        $("#location1").addClass("active");
        $( "#mapS, #mapL" ).toggle();
        $( "#lagmuli, #smaralind" ).toggle();
    }
});

$( "#location2" ).click(function() {
    if($("#location1").hasClass("active") == true)
    {
        $("#location1").removeClass("active");
        $("#location2").addClass("active");
        $( "#mapB, #mapL" ).toggle();
        $( "#lagmuli, #bankastraeti" ).toggle();
    }
    else if($("#location3").hasClass("active") == true)
    {
        $("#location3").removeClass("active");
        $("#location2").addClass("active");
        $( "#mapK, #mapB" ).toggle();
        $( "#bankastraeti, #kringlan" ).toggle();
    }
    else if($("#location4").hasClass("active") == true)
    {
        $("#location4").removeClass("active");
        $("#location2").addClass("active");
        $( "#mapS, #mapB" ).toggle();
        $( "#bankastraeti, #smaralind" ).toggle();
    }
});

$( "#location3" ).click(function() {
    if($("#location2").hasClass("active") == true)
    {
        $("#location2").removeClass("active");
        $("#location3").addClass("active");
        $( "#mapB, #mapK" ).toggle();
        $( "#kringlan, #bankastraeti" ).toggle();
    }
    else if($("#location1").hasClass("active") == true)
    {
        $("#location1").removeClass("active");
        $("#location3").addClass("active");
        $( "#mapK, #mapL" ).toggle();
        $( "#kringlan, #lagmuli" ).toggle();        
    }
    else if($("#location4").hasClass("active") == true)
    {
        $("#location4").removeClass("active");
        $("#location3").addClass("active");
        $( "#mapS, #mapK" ).toggle();
        $( "#kringlan, #smaralind" ).toggle();
    }
});
$( "#location4" ).click(function() {
    if($("#location2").hasClass("active") == true)
    {
        $("#location2").removeClass("active");
        $("#location4").addClass("active");
        $( "#mapB, #maps" ).toggle();
        $( "#smaralind, #bankastraeti" ).toggle();
    }
    else if($("#location3").hasClass("active") == true)
    {
        $("#location3").removeClass("active");
        $("#location4").addClass("active");
        $( "#mapK, #mapS" ).toggle();
        $( "#smaralind, #kringlan" ).toggle();
    }
    else if($("#location1").hasClass("active") == true)
    {
        $("#location1").removeClass("active");
        $("#location4").addClass("active");
        $( "#mapS, #mapL" ).toggle();
        $( "#smaralind, #lagmuli" ).toggle();
    }
});