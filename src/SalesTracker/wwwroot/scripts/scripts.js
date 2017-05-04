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
                            $('.new-sale').submit(function (event) {
                                event.preventDefault()
                                console.log("Clicked :)")
                                $.ajax({
                                    url: $(this).data('request-url'),
                                    type: 'POST',
                                    dataType: 'json',
                                    data: $(this).serialize(),
                                    success: function (result) {
                                        console.log("success!!!")
                                        var resultMessage = 'You\'ve completed the sale!<br>Comments: ' + result.comment;
                                        //+ '<br>Model: ' + result.car.model + '<br> Year:' + result.year + '<br> Price:' + result.car.price + '<br>Description: ' + result.car.description + '<br><button class="btn btn-success okay">Okay</button>';
                                        $('#save-new-sale').html(resultMessage);
                                        $('.new-sale').hide();
                                        $("input").val("");
                                        $('.okay').click(function () {
                                            $('#save-new-sale').hide();
                                        });
                                    }
                                });
                            });
                        }
                    });
                });
                
            }
        });
    });

    $('.new-car').submit(function (event) {
        event.preventDefault();

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

});