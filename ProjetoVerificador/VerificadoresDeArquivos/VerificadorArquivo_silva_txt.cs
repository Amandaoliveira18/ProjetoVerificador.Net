using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;

namespace ProjetoVerificador.VerificadoresDeArquivos
{
    public class VerificadorArquivo_silva_txt : VerificadorArquivos
    {
        public VerificadorArquivo_silva_txt() : base(path: @"C:\Arquivo_silva_txt\silva.txt", horario_de_verificacao_inicial: "19:38:00", horario_de_verificacao_final: "23:55:45")
        {

        }




    }
}