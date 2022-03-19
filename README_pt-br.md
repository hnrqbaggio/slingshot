# Slingshot

Docs in [English](./README.md)

Um programa simples para organizar as screenshots do Tibia em sub-pastas.

## O que esse programa faz?

Move as imagens na pasta de screenshots do Tibia de acordo com o nome do character e o tipo de screenshot.

Examplo dos resultados:

```text
Tibia Folder
|--- screenshots
|    |--- Aragorn
|    |    |--- Achievement
|    |    |--- BossDefeated
|    |    |    |--- 2021-03-24_181034186_Aragorn_BossDefeated.png       <-- Venceu o Nazgul
|    |    |--- DeathPvE
|    |    |--- LevelUp
|    |    |--- LowHealth
|    |    |--- SkillUp
|    |--- Gandalf
|    |    |--- Achievement
|    |    |    |--- 2021-09-11_201423412_Gandalf_Achievement.png        <-- Ganhou a White Wizard outfit
|    |    |    |--- 2021-06-01_163617752_Gandalf_Achievement.png        <-- Ganhou a mount Shadowfax
|    |    |--- BossDefeated
|    |    |    |--- 2021-09-11_201423412_Gandalf_BossDefeated.png       <-- Lutou contra o Balrog
|    |    |--- DeathPvE
|    |    |    |--- 2021-09-11_201423412_Gandalf_DeathPvE.png           <-- Lutou contra o Balrog
|    |    |--- Hotkey
|    |    |--- LevelUp
|    |    |--- LowHealth
|    |    |--- SkillUp
|    |--- Galadriel
|    |--- Frodo
|         |--- Achievement
|              |--- 2022-03-12_163115024_Frodo_Achievement.png          <-- Ganhou a Eagle mount (quest de service)
```

Você pode executar o programa múltiplas vezes e ele irá mover qualquer novo arquivo para as sub-pastas.
Note que o programa NÃO irá mover um arquivo se a pasta de destinho já possuir um com o mesmo nome.

## O que esse programa NÃO faz?

> Em absolutamente NENHUMA circunstância esse programa transmite alguma infomação para a internet e/out irá acessar algum arquivo no seu computador além das imagens sendo movidas para as sub-pastas.

> Esse programa não irá pedir NENHUMA informação além da localização da pasta de screenshots e não depende to cliente do Tibia em nenhum aspecto (por exemplo, você pode apontar para uma _cópia_ da pasta original do Tibia).

> O PROGRAMA NUNCA IRÁ PEDIR NENHUMA INFORMAÇÃO PESSOAL OU DA CONTA DO JOGO.

## Como usar

- Baixe o arquivo zip da página de downlaods: (link here).
- Clique com o botão direito no .zip e escolha `Extract All...`
- O Windows irá peguntar o local para extrair os arquivos. Qualquer pasta server. Marque a opção `show files after extracting` para abrir a pasta de destino.
- Clique com o botão direito no arquivo `Slingshot.exe` e selecione `Send To` > `Desktop (Create Shortcut)`.

Pronto, agora você só precisa clicar no atalho para rodar o programa quando quiser organizar os arquivos.
Ele irá abrir uma janela, mostrar o progresso da operação (pode levar uns segundos dependendo do número de arquivos), mostrar uma mensagem e terminar.

## O programa reclama que não consegue achar a pasta de screenshots

Você pode configurar a pasta de entrada alterando os parâmetros do atalho criado nos passos acima.

- Ache a pasta de screenshots do Tibia
  - O jeito mais fácil é usando o cliente: `Settings` > `Misc` > `Open Screenshots folder`.
  - Copie o caminho na barra de endereço
- Clique com o botão direito no atalho do programa, e selecione Properties
- Adicione o caminho no campo `Target` das opções, entre aspas.
- Clique OK e tente rodar o programa novamente.

## O progama reclara que não consegue achar nenhum arquivo

- Verifique se o caminho mostrado na tela tem alguma nova imagem para copiar
- Verifique se o Tibia está rodando, pois o cliente pode bloquear o acesso aos arquivos enquanto está ativo.
