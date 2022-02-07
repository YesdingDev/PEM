function openCity(evt, cityName) {
    var i, tabcontent, tablinks;
    tabcontent = document.getElementsByClassName("tabcontent");
    for (i = 0; i < tabcontent.length; i++) {
      tabcontent[i].style.display = "none";
    }
    tablinks = document.getElementsByClassName("tablinks");
    for (i = 0; i < tablinks.length; i++) {
      tablinks[i].className = tablinks[i].className.replace(" active", "");
    }
    document.getElementById(cityName).style.display = "block";
    evt.currentTarget.className += " active";
  }

 // function myfunction() {
    //  jump = document.getElementById("firm").readonly = false;
     // return jump;
  //}

  $(document).ready(function()
{
 $('#btnEdt','btnEditnnn').click(function()
 {
     $("input[name='fiscal_year'],[name='tax_period'],[name='relief'],[name='gross']").removeAttr("readonly");
 });

  });

$(document).ready(function()
{
    $("#btnEdt, ").click(function ()
    {
        $(this).hide();
        $("#savbnt,#cancebtn").show();
    })
})

$(document).ready(function () {
    $("#cancebtn").click(function () {
        $("#cancebtn, #savebtn ").hide();
        $("#btnEdt").show();
    });
});



/*PFA TYPE*/
$(document).ready(function(){
    $("#tnEdti").click(function(){
        $("input[name='group'],[name='descript'],[name='next'],[name='pon'],[name='ema'],[name='cop'],[name='rec'],[name='acc'],[name='frd'],[name='inn'],[name='emp']").removeAttr("readonly");
    });
});

$(document).ready(function()
{
    $("#tnEdti").click(function()
    {
        $(this).hide();
        $("#saveebtn, #cancellbtn").show();
    })
})

$(document).ready(function(){
    $(" #saveebtn, #cancellbtn").click(function()
    {
        $("#cancellbtn, #saveebtn").hide();
        $("#tnEdti").show();
    });
});
/*END*/

/*Creat New Employee**/
$('#nextbtn').click(function (){
        $('#Main').hide();
        $('#Main2').show();
});
/**End/*/



$(document).ready(function(){
    $('#btnEditnnn').click(function(){
        $("input[name='desi'],[name='ded']").removeAttr("readonly");
    });
})


$(document).ready(function () {
    $('#btnEditnnn').click(function () {
        $(this).hide();
        $('#savebtnnn, #cancelbtnnn').show();
    })
})

$(document).ready(function () {
    $('#savebtnnn, #cancelbtnnn').click(function () {
        $('#cancelbtnnn, #savebtnnn').hide();
        $('#btnEditnnn').show();
    });
});
