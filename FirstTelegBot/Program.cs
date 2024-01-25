using PRTelegramBot.Core;

const string EXIST_COMMAND = "exist";
var telegram = new PRBot(options =>
{
    options.Token = "6533200832:AAFwWxynCNrtd6j846rsWINlc8Q26Q3_hnQ";
    options.ClearUpdatesOnStart = true;
    options.WhiteListUsers = new List<long>() { };
    options.Admins = new List<long>() { };
    options.BotId = 0;
});
telegram.OnLogCommon += Telegram_OnLogCommon;
telegram.OnLogError += Telegram_OnLogError;
await telegram.Start();
void Telegram_OnLogCommon(string msg, Enum typeEvent, ConsoleColor color) 
{
    //Console.ForegroundColor = ConsoleColor.Yellow;
    Console.ForegroundColor = color;
    Console.WriteLine($"{DateTime.Now}:{msg}");
    Console.ResetColor();
}
void Telegram_OnLogError(Exception ex, long? id)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"{DateTime.Now}:{ex}");
    Console.ResetColor();
}

while (true)
{
    var result = Console.ReadLine();
    if (result.ToLower() == EXIST_COMMAND)
    {
        Environment.Exit(0);
    }
}
