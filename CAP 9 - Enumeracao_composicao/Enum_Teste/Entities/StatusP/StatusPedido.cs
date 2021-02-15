using System;
using System.Collections.Generic;
using System.Text;

namespace Enum_Teste.Entities.StatusP
{
    enum StatusPedido : int
    {
        PendenteDePagamento = 0,
        Processando = 1,
        EnviadoParaEntrega = 2,
        Entregue = 3,

    }
}
