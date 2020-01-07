class Carrinho {

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
        $.ajax({
            url: '/pedido/updatequantidade',
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(data)
        }).done(function (response) {
            let itemPedido = response.itemPedido;
            let linhaDoItem = $('[item-id=' + itemPedido.id + ']')
            linhaDoItem.find('input').val(itemPedido.quantidade);
            linhaDoItem.find('[subtotal]').html((itemPedido.subtotal).duasCasas());

            let carrinhoViewModel = response.carrinhoViewModel;
            $('[numero-itens]').html('Total: ' + carrinhoViewModel.itens.lenght + ' itens')
        });
    }
}

var carrinho = new Carrinho();

Number.prototype.duasCasas = function () {
    return this.toFixed(2).replace('.', ',');
}