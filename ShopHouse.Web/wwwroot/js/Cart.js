var CartController = function () {

    this.initialize = function () {
        registerEvents();
        loadData();
    }

    function registerEvents() {
        $('body').on('click', '.btn-plus', function (e) {
            e.preventDefault();
            var id = parseInt($(this).data('id'));
            const quantity = parseInt($("#txt_quantity_" + id).val()) + 1;
            updateCart(id, quantity);
        });
        $('body').on('click', '.btn-minus', function (e) {
            e.preventDefault();
            var id = parseInt($(this).data('id'));
            const quantity = parseInt($("#txt_quantity_" + id).val()) - 1;
            updateCart(id, quantity);
        });

        $('body').on('click', '.btn-remove', function (e) {
            e.preventDefault();
            var id = parseInt($(this).data('id'));
            updateCart(id, 0);
        });

        $("input[type='radio'][name='flexRadioDefault']").click(function () {
            var totalNotShipping = parseInt(document.getElementById('totalNotshipping').innerHTML);
            var totalshipping = 0;
            const culture = $('#hidCulture').val();
            if ($("input[type='radio'][name='flexRadioDefault']:checked").val() == '1') {
                totalshipping = totalNotShipping + 50000;
                document.getElementById('totalShipping').innerHTML = numberWithCommas(totalshipping) + '.00';
            }
            if ($("input[type='radio'][name='flexRadioDefault']:checked").val() == '2') {
                document.getElementById('totalShipping').innerHTML = numberWithCommas(totalNotShipping) + '.00';
            }
            $.ajax({
                type: "POST",
                url: "/" + culture + '/Cart/TakePriceShipping',
                data: {
                    price: totalshipping
                },
                success: function (res) {
                },
                error: function (err) {
                    console.log(err);
                }
            });
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
                window.location.reload();
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
                if (res.length === 0) {
                    document.getElementById('btn-checkout').hidden = true;
                    $('#cart_body').hide();
                }
                $.each(res, function (i, item) {
                    if (res.length === 0) {
                        value = true;
                    }
                    html += "<tr>"
                        + "<td class=\"pro-remove\"><a href=\"#\" class=\"btn-remove\" data-id=\"" + item.productId + "\"><i class=\"lastudioicon-e-remove\"></i></a></td >"
                        + "<td class=\"pro-thumbnail\">"
                        + "<div class=\"pro-info\">"
                        + "<div class=\"pro-img\">"
                        + "<a href=\"shop-single-product.html\"><img src=\"" + $('#hidBaseAddress').val() + item.images + "\" alt=\"Moren-Shop\"></a>"
                        + "</div>"
                        + "</div>"
                        + "</td>"
                        + "<td class=\"pro-name\"><span>" + item.name + "</span></td>"
                        + "<td class=\"pro-price\"><span>" + numberWithCommas(item.price) + "</span></td>"
                        + "<td class=\"pro-quantity\">"
                        + "<div class=\"action-top\">"
                        + "<div class=\"pro-qty-area\">"
                        + "<div class=\"pro-qty\">"
                        + "<input type=\"text\" id=\"txt_quantity_" + item.productId + "\" value=\"" + item.quantity + "\" size=\"16\" min=\"0\">"
                        + "<a href=\"#\" class=\"btn-plus inc qty-btn\" data-id=\"" + item.productId + "\">+</a><a href=\"#\" class=\"btn-minus dec qty-btn\" data-id=\"" + item.productId + "\">-</a>"
                        + "</div>"
                        + "</div>"
                        + "</div>"
                        + "<td class=\"pro-subtotal\"><span>" + numberWithCommas(item.price * item.quantity) + "</span></td>"
                        + "</tr>";
                });
                $('#cart_body').html(html);
                $('#lb_total').text(numberWithCommas(total));
            }
        });
    }
}
function numberWithCommas(x) {
    return x.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",");
}