// https://discord.com/oauth2/authorize?client_id=1250457947440545853&permissions=532576466944&integration_type=0&scope=bot
// https://discord.com/oauth2/authorize?client_id=1250457947440545853&permissions=8&integration_type=0&scope=bot


using System.Text;
using Discord;
using Discord.WebSocket;
using DotNetEnv;
using ExcelDataReader;
using Newtonsoft.Json.Linq;

 Env.Load();
var discordToken = Environment.GetEnvironmentVariable("DiscordToken");



async Task RunBotAsync()
{
    var client = new DiscordSocketClient();
    await client.LoginAsync(TokenType.Bot, discordToken);
    
    await client.StartAsync();

    client.Ready += async () => 

    {
        var guild = client.GetGuild(1205252642440216666);
        var channel = guild.GetTextChannel(1250513563500548167);

        await channel.SendMessageAsync("Mensagem de teste");

        var embeb = new EmbedBuilder();
        embeb.WithImageUrl("");
        await channel.SendMessageAsync(embed: embeb.Build());
        await channel.SendMessageAsync("");

        await client.DisposeAsync();

    };

}

await RunBotAsync();
Console.ReadKey();



/*
class Program
{
    private static readonly string SpreadsheetId = "1asdbf9J0djoiZMKMuiz15kDtDJmvFkH-aHDBAsbN4FQ";
    private static readonly string Range = "Sheet1!A1:D10"; 
    private static readonly string ApiKey = "YOUR_API_KEY"; 

    private DiscordSocketClient _client;

    static async Task Main(string[] args)
    {
        await new Program().RunBotAsync();
        Console.ReadKey();
    }

    public async Task RunBotAsync()
    {
        // Carregar variáveis de ambiente
        Env.Load();
        var discordToken = Environment.GetEnvironmentVariable("DiscordToken");

        // Verifique se o token não é nulo ou vazio
        if (string.IsNullOrWhiteSpace(discordToken))
        {
            Console.WriteLine("O token do Discord não foi encontrado.");
            return;
        }

        // Inicializar o cliente do Discord
        _client = new DiscordSocketClient();

        // Event handler para quando o bot estiver pronto
        _client.Ready += OnReadyAsync;

        // Logar no Discord
        try
        {
            await _client.LoginAsync(TokenType.Bot, discordToken);
            await _client.StartAsync();

            // Manter o programa rodando
            await Task.Delay(-1);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao iniciar o bot: {ex.Message}");
        }
    }

    private async Task OnReadyAsync()
    {
        try
        {
            // Pegue o guild e o canal

            var guild = _client.GetGuild(1205252642440216666);
            var channel = guild.GetTextChannel(1205254123189174412);
            
            // Verifique se o canal é nulo ou se não tem permissões
            if (channel == null)
            {
                Console.WriteLine("O canal não foi encontrado ou o bot não tem permissões.");
                return;
            }

            // Ler a planilha pública do Google Sheets e obter dados
            var data = await ReadGoogleSheetAsync();

            // Enviar dados ao canal
            await channel.SendMessageAsync(data);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao enviar mensagem: {ex.Message}");
        }
        finally
        {
            // Desconectar o bot após enviar a mensagem
            await _client.LogoutAsync();
            await _client.StopAsync();
            await _client.DisposeAsync();
        }
    }

    private async Task<string> ReadGoogleSheetAsync()
    {
        using var client = new HttpClient();
        var url = $"https://sheets.googleapis.com/v4/spreadsheets/{SpreadsheetId}/values/{Range}?key={ApiKey}";
        var response = await client.GetStringAsync(url);
        var json = JObject.Parse(response);
        var values = json["values"];

        if (values == null || !values.HasValues)
        {
            return "Nenhum dado encontrado na planilha.";
        }

        // Construir uma string com os dados
        var data = "Dados da planilha:\n";
        foreach (var row in values)
        {
            data += string.Join("\t", row) + "\n";
        }

        return data;
    }
}

*/


