﻿class Carrinho {

    clickIncremento(btn) {
        let data = this.getData(btn);
        data.Quantidade++;
        this.postQuantidade(data);        
    }

    clickDecremento(btn) {
        let data = this.getData(btn);
        data.Quantidade--;
        this.postQuantidade(data); 
    }

    getData(elemnt) {
        var linhaDoItem = $(elemnt).parents('[item-id]');
        var itemId = $(linhaDoItem).attr('item-id');
        var novaQtd = $(linhaDoItem).find('input').val();
        return {
            Id: itemId,
            Quantidade: novaQtd
        };
    }

    postQuantidade(data) {

        let token = $('[name=__RequestVerificationToken]').val();

        let headers = {};
        headers['RequestVerificationToken'] = token;

        $.ajax({
            url: '/pedido/updatequantidade',
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(data),
            headers: headers
        }).done(function (response) {
            let itemPedido = response.itemPedido;
            let linhaDoItem = $('[item-id=' + itemPedido.id + ']')
            linhaDoItem.find('input').val(itemPedido.quantidade);
            linhaDoItem.find('[subtotal]').html((itemPedido.subtotal).duasCasas());

            let carrinhoViewModel = response.carrinhoViewModel;
            $('[total]').html((carrinhoViewModel.total).duasCasas());
            $('[numero-itens]').html('Total: ' + carrinhoViewModel.itens.lenght + ' itens')
            if (itemPedido.quantidade == 0) {
                linhaDoItem.remove();
            }
        });
    }
}

var carrinho = new Carrinho();

Number.prototype.duasCasas = function () {
    return this.toFixed(2).replace('.', ',');
}