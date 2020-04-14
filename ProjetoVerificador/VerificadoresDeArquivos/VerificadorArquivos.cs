using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;

namespace ProjetoVerificador.VerificadoresDeArquivos
{
    public abstract class VerificadorArquivos
    {
        private static readonly TelegramBotClient Bot = new TelegramBotClient("1190870071:AAG0HcCaM35-BmLs_dcE0RBVoHy24JUdSdo");
        public string Path { get; }
        public string Horario_de_Verificacao_Inicial { get; }
        public string Horario_de_Verificacao_Final { get; }

        public VerificadorArquivos(string path, string horario_de_verificacao_inicial, string horario_de_verificacao_final)
        {

            Path = path;
            Horario_de_Verificacao_Inicial = horario_de_verificacao_inicial;
            Horario_de_Verificacao_Final = horario_de_verificacao_final;



        }

        public void VerificarDiasDaSemana()
        {
            DateTime date = DateTime.Now;

            string dateToday = date.ToString("d");
            DayOfWeek day = DateTime.Now.DayOfWeek;
            string dayToday = day.ToString();


            if (day >= DayOfWeek.Sunday || day < DayOfWeek.Saturday)
            {
                TransformarHorario();
            }

            else
            {
                Console.WriteLine(dateToday + "Final de semana, fora da agenda");
            }
        }

        public void TransformarHorario()
        {
            var horario_agendado_inicial = TimeSpan.Parse(Horario_de_Verificacao_Inicial);
            var horario_agendado_final = TimeSpan.Parse(Horario_de_Verificacao_Final);
            var horario_atual = TimeSpan.Parse(DateTime.Now.ToShortTimeString());



            if (horario_atual >= horario_agendado_inicial && horario_atual <= horario_agendado_final)
            {
                GetProcurarArquivo();
            }
            else
            {
                Console.WriteLine("execução não permitida");
            }


        }


        public void GetProcurarArquivo()
        {
            if (File.Exists(Path))
            {
                Bot.SendTextMessageAsync(-440643858, "   O Arquivo:" + Path + "  Existe");

            }
            else
            {
                Bot.SendTextMessageAsync(-440643858, "   O Arquivo:" + Path + "  Não Existe");

            }
        }




    }

}
