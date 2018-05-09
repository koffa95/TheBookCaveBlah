// Write your JavaScript code.

$(document).ready(function() {
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
    }
    else if($("#location3").hasClass("active") == true)
    {
        $("#location3").removeClass("active");
        $("#location1").addClass("active");
        $( "#mapK, #mapL" ).toggle();
    }
    else if($("#location4").hasClass("active") == true)
    {
        $("#location4").removeClass("active");
        $("#location1").addClass("active");
        $( "#mapS, #mapL" ).toggle();
    }
});

$( "#location2" ).click(function() {
    if($("#location1").hasClass("active") == true)
    {
        $("#location1").removeClass("active");
        $("#location2").addClass("active");
        $( "#mapB, #mapL" ).toggle();
    }
    else if($("#location3").hasClass("active") == true)
    {
        $("#location3").removeClass("active");
        $("#location2").addClass("active");
        $( "#mapK, #mapB" ).toggle();
    }
    else if($("#location4").hasClass("active") == true)
    {
        $("#location4").removeClass("active");
        $("#location2").addClass("active");
        $( "#mapS, #mapB" ).toggle();
    }
});

$( "#location3" ).click(function() {
    if($("#location2").hasClass("active") == true)
    {
        $("#location2").removeClass("active");
        $("#location3").addClass("active");
        $( "#mapB, #mapK" ).toggle();
    }
    else if($("#location1").hasClass("active") == true)
    {
        $("#location1").removeClass("active");
        $("#location3").addClass("active");
        $( "#mapK, #mapL" ).toggle();
    }
    else if($("#location4").hasClass("active") == true)
    {
        $("#location4").removeClass("active");
        $("#location3").addClass("active");
        $( "#mapS, #mapK" ).toggle();
    }
});
$( "#location4" ).click(function() {
    if($("#location2").hasClass("active") == true)
    {
        $("#location2").removeClass("active");
        $("#location4").addClass("active");
        $( "#mapB, #maps" ).toggle();
    }
    else if($("#location3").hasClass("active") == true)
    {
        $("#location3").removeClass("active");
        $("#location4").addClass("active");
        $( "#mapK, #mapS" ).toggle();
    }
    else if($("#location1").hasClass("active") == true)
    {
        $("#location1").removeClass("active");
        $("#location4").addClass("active");
        $( "#mapS, #mapL" ).toggle();
    }
});