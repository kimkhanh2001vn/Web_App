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
                var htmlAside = '';
                var total = 0;
                $.each(res, function (i, item) {
                    if (res.length === 0) {
                        value = true;
                    }
                    html += "<tr>"
                        + "<td class=\"pro-remove\"><i class=\"lastudioicon-e-remove\"></i></td >"
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
                        + "</div>"
                        + "</div>"
                        + "</div>"
                        + "<td class=\"pro-subtotal\"><span>" + numberWithCommas(item.price * item.quantity) + "</span></td>"
                        + "</tr>";

                    htmlAside += "<div class=\"product-cart-item\">"
                        + "<div class=\"product-img\" >"
                        + "  <a href=\"shop.html\"><img src=\"" + $('#hidBaseAddress').val() + item.images + "\" alt=\"\"></a>"
                        + "</div>"
                        + "<div class=\"product-info\">"
                        + "  <h4 class=\"title\"><a href=\"shop.html\">" + item.name + "</a></h4>"
                        + "<span class=\"info\">" + item.quantity + " × " + numberWithCommas(item.price) + "</span>"
                        + "</div>"
                        + "<div class=\"product-delete\"><a href=\"#\">×</a></div>"
                        + " </div>";
                    total += item.price * item.quantity;
                });
                $('#cart_body').html(html);
                $('#list_cart').html(htmlAside);
                $('#lb_total').text(numberWithCommas(total) > 0 ? numberWithCommas(total) : 0);
            }
        });
    }
}