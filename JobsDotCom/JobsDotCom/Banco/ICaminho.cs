using System;
using System.Collections.Generic;
using System.Text;

namespace JobsDotCom.Banco
{
    public interface ICaminho
    {
        string ObterCaminho(string NomeArquivoBanco);
    }
}
