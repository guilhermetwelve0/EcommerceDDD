

var ObjetoVenda = new Object();

ObjetoVenda.CaregaProdutos = function() {

    $.ajax({
        type: 'GET',
        url: "/api/ListarProdutosComEstoque",
        dataType: "JSON",
        cache: false,
        async: true,
        sucess: function (data) {

            var htmlConteudo = "";

            data.forEach(function (entitie) {

                htmlConteudo += " <div class='col-xs-12 col-sm-4 col-md-4 col-lg-4'>";

                var idNome = "nome_" + Entitie.id;
                var idQtd = "qtd_" + Entitie.id;

                htmlConteudo += "<label id='" + idNome + "' > Produto: " + Entitie.nome + "</label></br>";
                htmlConteudo += "<label> Valor: " + Entitie.valor + "</label></br>";

                htmlConteudo += "Quantidade : <input type'number' value='1' id='" + idQtd + "'>";


            });

        }
    });
}


$(function () {
    ObjetoVenda.CaregaProdutos();
});