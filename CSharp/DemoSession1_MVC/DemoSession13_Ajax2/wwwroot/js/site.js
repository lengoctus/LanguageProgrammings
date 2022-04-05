$(document).ready(function () {
    $("#keyword").autocomplete({
        source: "Product/Search",
        select: function (event, ui) {
            console.log("Selected: " + ui.item.value);
            window.location = 'product/result/' + ui.item.value;
        }
    });

    $("#cbbCategory").on("change", function () {
        var category = $("#cbbCategory option:selected").val();
        $.ajax({
            type: "post",
            datatype: "json",
            contentype: "application/json",
            url: "Product/SearchByCategory",
            data: { category },
            success: function (respone) {
                console.log(respone.length)
                var s = '';
                for (var i = 0; i < respone.length; i++) {
                    s += '<tr>';
                    s += '<td>' + respone[i].id + '</td>';
                    s += '<td>' + respone[i].name + '</td>';
                    s += '<td>' + respone[i].price + '</td>';
                    s += '<td>' + respone[i].category + '</td>';
                    s+= '</tr>'
                }

                $("table tbody").html(s);
            }
        })
    })
})