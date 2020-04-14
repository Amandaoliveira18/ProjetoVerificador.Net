using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVerificador.VerificadoresDeArquivos
{
    public class VerificadorArquivo_silva_txt : VerificadorArquivos
    {
        public VerificadorArquivo_silva_txt() : base(path: @"C:\Arquivo_silva_txt\silva.txt", horario_de_verificacao_inicial: "14:38:00", horario_de_verificacao_final: "14:55:45")
        {

        }




    }
}