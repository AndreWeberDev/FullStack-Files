using System;
using System.Collections.Generic;
using System.Text;

namespace Iprodutos.UI

internal interface IProduto
{
    string RealizarCompra();
    string VerificarEstoque();

    string EscolherOpçoes();

    string AvaliarProduto();

    double CalcularEstoque();

    double CalcularTotalDaCompra();

    double ExibirValor();

}
