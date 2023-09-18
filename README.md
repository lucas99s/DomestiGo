# Introdução

Este projeto visa abordar uma das jornadas definidas na primeira parte, a jornada escolhida aborda o processo de cadastro de um usuario no sistema, demonstrando as funcionalidades da tela de login, cadastro e o processo para o usuário sair da aplicação através da página de perfil. Abaixo iremos listar as funcionalidades implementadas no protótipo. 

# Intruções para execução da aplicação

- Abrir o arquivo DomestiGo.sln, no Visual Studio.
- Executar o codigo através do botão "IIS Express", localizado na parte superior da ferramenta.
- A aplicação ira ser iniciada no browser.

# Requisitos nescessários para execução

- Instalação do Visual Studio 2022.
- Versão 7 do SDK.NET (Disponivel em: <https://dotnet.microsoft.com/pt-br/download/visual-studio-sdks>).

# Video Demonstrativo

Link (<https://www.youtube.com/watch?v=Wy7Z5zpUP8s>)

# Funcionalidades Implementadas

### Tela inicial

Através dessa tela duas opções serão habilitadas ao usuário

- Efetuar o Login através do botão "Entrar"
- Caso não possua cadastro, o usuário poderá cadastrar um usuário através da opção "Cadastrar".

### Tela de login

Através dessa tela o usuário irá efetuar o acesso à ferramenta, esta tela ira permitir ao usuário.

- Efetuar acesso à ferramenta, informando e-mail e senha cadastrados previamente.
- Caso o e-mail informado não esteja cadastrado, a ferramenta irá alertar que o perfil não existe.
- Caso a senha informada seja diferente da cadastrada, a ferramenta irá alertar que a senha informada é invalida.

### Tela de cadastro

Através dessa tela o usuário ira efetuar o cadastro na ferramenta, esta tela possui as seguintes funções.

- Cadastro do usuário informando (Nome, Sobrenome, E-mail e Senha).
- Caso o usuário informe um e-mail já cadastrado, a ferramenta irá mostrar um alerta informando o usuário.
- Caso o usuário coloque uma senha diferente no campo "Confirmar Senha" da senha informada anteriormente, a ferramenta irá mostrar um alerta, informando o usuário que a informação esta divergente.
- A senha informada pelo usuário deve conter no mínimo 8 caracteres, caso esse critério não seja atendido a ferramenta irá mostrar um alerta, informando que a senha não se encaixa no padrão estabelecido.

# Integrantes 

#### Grupo 07

- Camila Pereira Jolvino
- Lucas Rodrigues da Silva
- Henrique Silva Torres
- Juliana Zanella Sanches
