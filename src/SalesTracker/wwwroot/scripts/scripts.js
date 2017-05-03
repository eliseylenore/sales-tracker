$(document).ready(function () {
    console.log("I see your js");
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
});

