using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVerificador.VerificadoresDeArquivos
{
    public class VerificadorArquivo_amanda_jpg : VerificadorArquivos
    {


        public VerificadorArquivo_amanda_jpg() : base(path: @"C:\Arquivo_amanda_img\amanda.jpg", horario_de_verificacao_inicial: "13:55:15", horario_de_verificacao_final: "22:00:00")
        {

        }




    }
}

