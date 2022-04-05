$(document).ready(function () {
    $("#dm1").click(function () {
        $.ajax({
            url: "Demo/Demo1",
            type: "GET",
            success: function (respone) {
                $("#result1").text(respone)
            }
        });
    });

    $("#dm2").click(function () {
        var fullname = "Le Ngoc Tu";
        $.ajax({
            url: "Demo/Demo2",
            type: "GET",
            data: { fullname: "Le Ngoc Tu" },
            success: function (respone) {
                $("#result2").text(respone)
            }
        });
    })

    $("#dm3").click(function () {
        $.ajax({
            url: "Demo/Demo3",
            type: "post",
            data: { fullname: "Ngoc Tu", email: "ahi@dd" },
            success: function (respone) {
                $("#result3").text(respone)
            }
        });
    });


    $("#check").click(function () {
        $.ajax({
            url: "Demo/Demo4",
            type: "post",
            data: { fullname: $("#username").val() },
            success: function (respone) {
                $("#result4").text(respone)
            }
        });
    })

    $("#dm5").click(function () {
        $.ajax({
            url: "Demo/Demo5",
            type: "get",
            dataType: "json",
            contentType: "application/json",
            cache: false,
            data: { fullname: $("#username").val() },
            success: function (respone) {
                var s = 'Id: ' + respone.id;
                s += '<br/>Name: ' + respone.name;
                s += '<br/>Price: ' + respone.price;
                $("#result5").html(s)
            }
        });
    });

    $("#dm6").click(function () {
        $.ajax({
            url: "Demo/Demo6",
            type: "get",
            dataType: "json",
            contentType: "application/json",
            cache: false,
            success: function (respone) {
                var s = '';
                for (var i = 0; i < respone.length; i++) {
                    s += '<tr>';
                    s += '<td>' + respone[i].id + '</td>'
                    s += '<td>' + respone[i].name + '</td>'
                    s += '<td>' + respone[i].price + '</td>'
                    s += '<tr>';

                    $("#prods tbody").html(s)
                }
            }
        });
    })

})