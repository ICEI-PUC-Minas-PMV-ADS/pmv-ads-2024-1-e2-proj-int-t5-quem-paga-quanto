# Programação de Funcionalidades

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="4-Metodologia.md"> Metodologia</a>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="5-Arquitetura da Solução.md"> Arquitetura da Solução</a>

Implementação do sistema descrita por meio dos requisitos funcionais e/ou não funcionais. Deve relacionar os requisitos atendidos com os artefatos criados (código fonte), deverão apresentadas as instruções para acesso e verificação da implementação que deve estar funcional no ambiente de hospedagem.

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) | Responsável(is) |
|------|-----------------------------------------|----|--|
|RF-001| A aplicação deve permitir que o usuário gerencie o seu cadastro na plataforma. | Views/Auth/*.cshtml, AuthController.cs | Carlos Roberto |
|RF-002| A aplicação deve permitir o login com autenticação de usuário e senha. | Views/Usuarios/*.cshtml, UsuariosController.cs | Carlos Roberto |
|RF-003| A aplicação deve permitir que o usuário gerencie moradores e suas informações como nome e e-mail. | Views/Usuarios/*.cshtml, MoradoresController.cs | Bárbara |
|RF-004| A aplicação deve possuir uma página inicial com informações sobre a aplicação e objetivos da aplicação. | - | Em desenvolvimento |
|RF-005| A aplicação deve permitir que o usuário gerencie os gastos da casa em que mora. | Views/Despesas/*.cshtml, DespesasController.cs | Guilherme |
|RF-006| A aplicação deve possuir uma página para exibir os relatórios de quanto cada morador deve contribuir ao final do mês. | Views/Grupos/Relatorio.cshtml, GruposController.cs | Raissa |
|RF-007| A aplicação deve disponibilizar um relatório mensal especificando as despesas e seu respectivo valor. | - | Em desenvolvimento |
|RF-008| A aplicação deve disponibilizar duas opções antes de gerar os relatórios: <br> 1) Proporcional ao salário; <br> 2) Sobre a divisão por pessoa. | - | Em desenvolvimento |
|RF-009| A aplicação deve gerar gráficos dentro da página de relatórios para ilustrar os gastos e as contribuições. | - | Em desenvolvimento |
|RF-010| A aplicação deve possibilitar ao Usuário alterar suas informações pessoais e senha. | - | Em desenvolvimento |
|RF-011| Todas as páginas devem possuir um menu de navegação no topo da página. | Views/Shared/_Layout.cshtml | Carlos Roberto |
|RF-012| Todas as páginas devem possuir um rodpé com links das páginas de informação e do painel, além de direitos autorais. | - | Em desenvolvimento |
|RF-013| A aplicação deve permitir que o usuário gerencie seus grupos grupos/casas. | Views/Grupos/*.cshtml, GruposController.cs | Jessica |
|RF-014| A aplicação deve permitir que o usuário gerencie as rendas de cada morador. | Views/Rendas/*.cshtml, RendasController.cs - | Laura |

# Instruções de acesso

Não deixe de informar o link onde a aplicação estiver disponível para acesso (por exemplo: https://adota-pet.herokuapp.com/src/index.html).

Se houver usuário de teste, o login e a senha também deverão ser informados aqui (por exemplo: usuário - admin / senha - admin).

O link e o usuário/senha descritos acima são apenas exemplos de como tais informações deverão ser apresentadas.

> **Links Úteis**:
>
> - [Trabalhando com HTML5 Local Storage e JSON](https://www.devmedia.com.br/trabalhando-com-html5-local-storage-e-json/29045)
> - [JSON Tutorial](https://www.w3resource.com/JSON)
> - [JSON Data Set Sample](https://opensource.adobe.com/Spry/samples/data_region/JSONDataSetSample.html)
> - [JSON - Introduction (W3Schools)](https://www.w3schools.com/js/js_json_intro.asp)
> - [JSON Tutorial (TutorialsPoint)](https://www.tutorialspoint.com/json/index.htm)
