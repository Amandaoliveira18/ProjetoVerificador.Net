using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoVerificador.VerificadoresDeArquivos;
using Telegram.Bot;

namespace ProjetoVerificador
{
    public class Mensageiro : VerificadorArquivos
    {

        public int Chatid { get; set; }
        private static readonly TelegramBotClient Bot = new TelegramBotClient("1190870071:AAG0HcCaM35-BmLs_dcE0RBVoHy24JUdSdo");

        public Mensageiro(string path, string horario_de_verificacao_inicial, string horario_de_verificacao_final) : base(path, horario_de_verificacao_inicial, horario_de_verificacao_final)
        {
        }

        public override void GetProcurarArquivo()
        {
            Chatid = -440643858;

            if (File.Exists(Path))
            {
                Bot.SendTextMessageAsync(Chatid, "   O Arquivo:" + Path + "  Existe");

            }
            else
            {
                Bot.SendTextMessageAsync(Chatid, "   O Arquivo:" + Path + "  Não Existe");

            } 
        }
    }
}
