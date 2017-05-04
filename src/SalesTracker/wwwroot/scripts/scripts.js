$(document).ready(function () {
    
    $('.display-view').click(function () {
        $.ajax({
            type: 'GET',
            dataType: 'html',
            url: $(this).data('request-url'),
            success: function (result) {
                $('#result').html(result);
                $(".buy-car").click(function () {
                    console.log($(this).attr('id'));
                    //$(this).attr('id');
                    $.ajax({
                        type: 'GET',
                        url: $(this).data('request-url'),
                        dataType: 'html',
                        success: function (result) {
                            $(".sale-display").html(result);
                        }
                    });
                  });
            }
        });
    });

    $('.new-car').submit(function (event) {
        event.preventDefault();
        //if (!$(this).hasClass("showCars")) {
        //    $(this).addClass("showCars");
        //}
        //else {
        //    $(this).removeClass("showCars");
        //}
        
        $.ajax({
            url: $(this).data('request-url'),
            type: 'POST',
            dataType: 'json',
            data: $(this).serialize(),
            success: function (result) {
                var resultMessage = 'You\'ve added a new car to the database!<br>Make: ' + result.make + '<br>Model: ' + result.model + '<br> Year:' + result.year + '<br> Price:' + result.price + '<br>Description: ' + result.description + '<br><button class="btn btn-success okay">Okay</button>';                 
                $('#SaveNewCar').html(resultMessage);           
                $('.new-car').hide();
                $("input").val("");
                $('.okay').click(function () {
                    console.log("Hey there");
                    $('#SaveNewCar').hide();
                });
            }                              
        });

        $('.new-sale').submit(function (event) {
            event.preventDefault();
            if (!$(this).hasClass("showSale")) {
                $(this).addClass("showSale");
            }
            else {
                $(this).removeClass("showCars");
            }
        
            $.ajax({
                url: $(this).data('request-url'),
                type: 'POST',
                dataType: 'json',
                data: $(this).serialize(),
                success: function (result) {
                    var resultMessage = 'You\'ve added a new car to the database!<br>Make: ' + result.make + '<br>Model: ' + result.model + '<br> Year:' + result.year + '<br> Price:' + result.price + '<br>Description: ' + result.description + '<br><button class="btn btn-success okay">Okay</button>';                 
                    $('#SaveNewCar').html(resultMessage);           
                    $('.new-car').hide();
                    $("input").val("");
                    $('.okay').click(function () {
                        console.log("Hey there");
                        $('#SaveNewCar').hide();
                    });
                }                              
            });
    });

    //$('.buy-car').click(function () {
    //    console.log("click");
    //    $.ajax({
    //        type: 'GET',
    //        url: $(this).data('request-url'),
    //        dataType: 'html',
    //        success: function (result) {
    //            $(".sale-display").html(result);
    //        }
    //    });
    //});
});

