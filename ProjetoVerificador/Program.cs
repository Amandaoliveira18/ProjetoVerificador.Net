using ProjetoVerificador.VerificadoresDeArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;

namespace ProjetoVerificador
{
    class Program
    {
        static void Main(string[] args)
        { 

            //Bot.OnMessage += Bot_OnMessage;
            //Bot.OnMessageEdited += Bot_OnMessage;



            //Bot.StartReceiving();
            //Console.ReadLine();
            //Bot.StopReceiving();



            VerificadorArquivos amanda_jpg = new VerificadorArquivo_amanda_jpg();
            VerificadorArquivos amanda_txt = new VerificadorArquivo_amanda_txt();
            VerificadorArquivos silva_txt = new VerificadorArquivo_silva_txt();

            amanda_jpg.VerificarDiasDaSemana();
            amanda_txt.VerificarDiasDaSemana();
            silva_txt.VerificarDiasDaSemana();

          

            // var botClient = new TelegramBotClient("1190870071:AAG0HcCaM35-BmLs_dcE0RBVoHy24JUdSdo");
            //  var me = botClient.GetMeAsync().Result;
            //  var t = botClient.SendTextMessageAsync("@CSharpePV_bot", "Olá");
            // Console.WriteLine($"Hello, World! I am user {me.Id} and my name is {me.FirstName}.");


            //1190870071
            //chat id: -440643858





        }

             //private static void Bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
             //{
            //    if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text)
            //    {
            //        Bot.SendTextMessageAsync(e.Message.Chat.Id, "Tudo bem e voce?");
            //    }



            //}

    }
}