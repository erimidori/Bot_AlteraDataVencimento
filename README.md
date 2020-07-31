# Bot_AlteraDataVencimento

<b><h3>1. Descrição </b></h3>
Bot desenvolvido para o Tech Challenge do Banco Carrefour, promovido pela Digital Innovation One.

O objetivo do bot é permitir que o usuário selecione uma nova data de vencimento para o cartão.

<b><h3>2. Pré requisitos </b></h3>

2.1. Gerar um novo token do Telegram

- Abrir o Telegram
- Pesquisar por @BotFather
- Iniciar a conversar e executar o seguinte comando: /newbot
- Será solicitado um nome para bot
- Após, será solicitado para informar um username, este deve finalizar com 'bot'.
- Estando tudo certo, será informado o token gerado.

2.2. Instalar a biblioteca do Telegram.Bot

<b><h3>3. Sobre o programa</b></h3>

Utilizado a linguagem C#

Na linha 8 do arquivo Program.cs, onde está escrito "Seu token", substituir pelo novo token gerado pelo BotFather.

O Bot só entende as seguintes mensagens e devem ser escritas exatamente como estão escritas sem as aspas "":

"Bom dia"
<br>"Boa tarde"
<br>"Boa noite"
<br>"Alterar vencimento"
<br>"1"
<br>"2"
<br>"5"
<br>"10"
<br>"15"
<br>"20"
<br>"Não"

<b>Respostas do bot:</b>

Quando o usuário digita "Bom dia", "Boa tarde" ou "Boa noite", o bot retorna a mensagem "Como posso te ajudar? " + o primeiro nome do usuário.

Quando usuário digita "Alterar vencimento", o bot retorna a mensagem "OK. Qual a melhor data?"

Quando usuário digita "1", "2", "5", "10", "15" ou "20", o bot retorna a mensagem "Ok. Sua nova data de vencimento é: " + o número digitado pelo usuário + a mensagem "Posso te ajudar em algo mais? "

Quando usuário digita "Não", o bot retorna a mensagem "Obrigado pelo contato"

Quando usuário digita qualquer mensagem diferente das mensagens descritas acima, o bot retorna a mensagem "Desculpe, não consegui entender"

<b>OBSERVAÇÃO:</b> As datas de vencimento desse bot são fictícias. São somente para exemplificar a execução do bot.

