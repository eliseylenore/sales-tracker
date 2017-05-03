$(document).ready(function () {
    
    $('.display-view').click(function () {
        $.ajax({
            type: 'GET',
            dataType: 'html',
            url: $(this).data('request-url'),
            success: function (result) {
                $('#result').html(result);
            }
        });
    });

    $('.new-car').submit(function (event) {
        event.preventDefault();
        console.log("I see your js");
        $.ajax({
            url: $(this).data('request-url'),
            type: 'POST',
            dataType: 'json',
            data: $(this).serialize(),
            success: function (result) {
                var resultMessage = 'You\'ve added a new car to the database!<br>Make: ' + result.make + '<br>Model: ' + result.model + '<br> Year:' + result.year + '<br> Price:' + result.price + '<br>Description: ' + result.description ;
                $('#SaveNewCar').html(resultMessage);
            }
        })
    });
});

