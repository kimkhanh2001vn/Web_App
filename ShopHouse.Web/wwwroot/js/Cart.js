var CartController = function () {

    this.initialize = function () {
        registerEvents();
        loadData();
    }

    function registerEvents() {
        $('body').on('click', '.btn-edit', function (e) {
            e.preventDefault();
            var id = parseInt($(this).data('id'));
            const quantity = $("#txt_quantity_" + id).val();
            updateCart(id, quantity);
        });

        $('body').on('click', '.btn-remove', function (e) {
            e.preventDefault();
            var id = parseInt($(this).data('id'));
            updateCart(id, 0);
        });
    }
    function updateCart(id, quantity) {
        const culture = $('#hidCulture').val();
        $.ajax({
            type: "POST",
            url: "/" + culture + '/Cart/UpdateCart',
            data: {
                id: id,
                quantity: quantity
            },
            success: function (res) {
                $('#lbl_number_items_header').text(res.length);
                loadData();
            },
            error: function (err) {
                console.log(err);
            }
        });
    }
    function loadData() {
        const culture = $('#hidCulture').val();
        $.ajax({
            type: "GET",
            url: "/" + culture + "/Cart/GetListItems",
            success: function (res) {
                var html = '';
                var total = 0;
                $.each(res, function (i, item) {
                    if (res.length === 0) {
                        value = true;
                    }
                    html += "<tr>"
                        + "<td class=\"p_dtl\" >"
                        + "<div class=\"block-stl9\">"
                        + "<div class=\"img-holder\">"
                        + "<img src=\"" + $('#hidBaseAddress').val() + item.images + "\" alt=\"\" class=\"img-responsive\">"
                        + "</div>"
                        + "<div class=\"info-block\">"
                        + "<h5>" + item.name + "</h5>"
                        + "<p class=\"txt-cat\">Regular</p>"
                        + "<p class=\"ab-txt-block\">" + item.description + "</p>"
                        + "</div>"
                        + "</div>"
                        + "</td>"
                        + "<td class=\"p_btn\">"
                        + " <a href=\"#\" data-id=\" " + item.productId + " \" class=\"btn1 stl3 btn-edit\">Edit</a>"
                        + "<a href=\"#\" data-id=\"" + item.productId + "\" class=\"btn1 stl3 btn-remove\">Remove</a>"
                        + "</td>"
                        + "<td class=\"p_price\">" + numberWithCommas(item.price) + "</td>"
                        + "<td class=\"p_quantity\">"
                        + "<div class=\"quantity\">"
                        + "<input  class=\"form-control text-center \" type=\"number\" id=\"txt_quantity_" + item.productId + "\" value=\"" + item.quantity + "\" size=\"16\" min=\"0\">"
                        + "</div>"
                        + "</td>"
                        + "<td class=\"p_ttl\">" + numberWithCommas(item.price * item.quantity) + "</td>"
                        + "</tr>";
                    total += item.price * item.quantity;
                });
                $('#cart_body').html(html);
                $('#lb_total').text(numberWithCommas(total));
            }
        });
    }
}