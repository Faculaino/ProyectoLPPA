$(document).ready(function () {
    $("#btnSiguiente").click(function () {

        $("#pantalla").slideUp();

        //Comienza Paso 1
        $("#Paso1").addClass("col-xs-3 bs-wizard-step complete");
        $("#Paso1Progress").css("background-color", "lightgreen");
        //Finaliza Paso 1

        //Comienza Paso 2
        $("#Paso2").addClass("col-xs-3 bs-wizard-step active");
        $("#Punto2").css("background-color", "lightgreen");


        $("#pantalla2").addClass("nuevoDIV2");
        $(".nuevoDIV2").slideUp();
        $(".nuevoDIV2").show();
        $(".nuevoDIV2").slideDown();

    });
    $("#btnSiguiente2").click(function () {

        $("#pantalla2").slideUp();

        //Paso 2 Complete
        $("#Paso2").addClass("col-xs-3 bs-wizard-step complete");
        $("#Paso2Progress").css("background-color", "lightgreen");
        //Finaliza Paso 2

        //Comienza Paso 3
        $("#Paso3").addClass("col-xs-3 bs-wizard-step active");
        $("#Punto3").css("background-color", "lightgreen");


        $("#pantalla3").addClass("nuevoDIV3");
        $(".nuevoDIV3").slideUp();
        $(".nuevoDIV3").show();
        $(".nuevoDIV3").slideDown();

        //$("#pantalla").slideDown();


    });
    $("#btnSiguiente3").click(function () {

        $("#pantalla3").slideUp();

        //Paso 3 Complete
        $("#Paso3").addClass("col-xs-3 bs-wizard-step complete");
        $("#Paso3Progress").css("background-color", "lightgreen");
        //Finaliza Paso 3

        //Comienza Paso 4
        $("#Paso4").addClass("col-xs-3 bs-wizard-step active");
        $("#Punto4").css("background-color", "lightgreen");


        $("#pantalla4").addClass("nuevoDIV4");
        $(".nuevoDIV4").slideUp();
        $(".nuevoDIV4").show();
        $(".nuevoDIV4").slideDown();

        //$("#pantalla").slideDown();


    });

  

});