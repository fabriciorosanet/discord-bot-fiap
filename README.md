# Discord Bot - Postech News

Projeto de criação de bot de mensagem no Discord, para envio automático de notícias de tecnologia para as turmas da Postech.

## Descrição

Este projeto visa desenvolver um bot para o Discord que envia automaticamente notícias de tecnologia para os canais das turmas da Postech. O objetivo é manter os alunos atualizados com as últimas novidades do mundo da tecnologia de maneira prática e eficiente.

## Funcionalidades

- Envio automático de notícias de tecnologia em horários pré-definidos.
- Personalização dos canais de destino para as notícias.
- Suporte a múltiplas fontes de notícias.
- Logs de envio para monitoramento.

## Tecnologias Utilizadas

- [C#](https://docs.microsoft.com/en-us/dotnet/csharp/): Linguagem de programação utilizada para desenvolver o bot.
- [.NET](https://dotnet.microsoft.com/): Plataforma de desenvolvimento utilizada para construir e executar o bot.
- [Discord API](https://discord.com/developers/docs/intro): API para interagir com o Discord.

## Instalação

1. Clone o repositório:

    ```sh
    git clone https://github.com/fabriciorosanet/discord-bot-fiap.git
    cd discord-bot-fiap
    ```

2. Abra o projeto no Visual Studio.

3. Instale as dependências necessárias. No Visual Studio, isso geralmente é feito automaticamente ao abrir o projeto.

4. Configure as variáveis de ambiente no arquivo `appsettings.json` (exemplo fornecido em `appsettings.example.json`):

    ```json
    {
      "DiscordToken": "seu_token_aqui",
      "NewsApiKey": "sua_chave_api_aqui"
    }
    ```

5. Execute o bot:

    - No Visual Studio, pressione abra o terminal e passe o comando "dotnet run"

## Contato

Para mais informações, entre em contato:

- Nome: Fabrício Rosa
- Email: fabricio.oliveira@fiap.com.br
- GitHub: [fabriciorosanet](https://github.com/fabriciorosanet)
