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
        $.ajax({
            url: '/pedido/updatequantidade',
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(data)
        });
    }

    updateQuantidade(input) {
        let data = this.getData(input);
        this.postQuantidade(data);
    }
}

var carrinho = new Carrinho();