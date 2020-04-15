using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;

namespace ProjetoVerificador.VerificadoresDeArquivos
{
    public class VerificadorArquivo_amanda_txt : VerificadorArquivos

    {
        public VerificadorArquivo_amanda_txt() : base(path: @"C:\Arquivo_amanda_txt\amanda.txt", horario_de_verificacao_inicial: "16:12:00", horario_de_verificacao_final: "23:00:00")
        {

        }

        public override void GetProcurarArquivo()
        {
           
        }
    }
}
