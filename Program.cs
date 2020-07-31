using System;
using Telegram.Bot;

namespace BC_Vencimento
{
    class Program
    {
        private static readonly TelegramBotClient Bot = new TelegramBotClient("Seu token"); // Informar o token gerado pelo BotFather
        static void Main(string[] args)
        {
            Bot.OnMessage += Bot_OnMessage;
            Bot.OnMessageEdited += Bot_OnMessage;

            Bot.StartReceiving();
            Console.ReadLine();
            Bot.StopReceiving();

        static async void Bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            
            if(e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text)
            {
                if(e.Message.Text == "Bom dia" | e.Message.Text == "Boa tarde" | e.Message.Text == "Boa noite")
                    await Bot.SendTextMessageAsync(e.Message.Chat.Id, "Como posso te ajudar? " + e.Message.Chat.FirstName);
                else if(e.Message.Text == "Alterar vencimento")
                    await Bot.SendTextMessageAsync(e.Message.Chat.Id, "OK. Qual a melhor data?");
                else if(e.Message.Text == "1" | e.Message.Text == "2" | e.Message.Text == "5" | e.Message.Text == "10" | e.Message.Text == "15" | e.Message.Text == "20")
                    await Bot.SendTextMessageAsync(e.Message.Chat.Id, "Ok. Sua nova data de vencimento é: " + e.Message.Text + "\nPosso te ajudar em algo mais? ");
                else if(e.Message.Text == "Não")
                    await Bot.SendTextMessageAsync(e.Message.Chat.Id, "Obrigado pelo contato");
                else 
                    await Bot.SendTextMessageAsync(e.Message.Chat.Id, "Desculpe, não consegui entender");
            }
        }

        }
    }
}
