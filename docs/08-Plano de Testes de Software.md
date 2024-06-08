
# Plano de Testes de Software

Os requisitos para realização dos testes de software são:

* Site publicado na Internet;
* Navegador da Internet - Chrome, Firefox, Edge, Opera e Safari.
* Conectividade de Internet para acesso às plataformas (APISs).
  
Os testes funcionais a serem realizados no aplicativo são descritos a seguir.
 
| **Caso de Teste** 	| **CT-01 – Cadastrar usuário** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - A aplicação deve permitir que o usuário gerencie o seu cadastro na plataforma. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site.<br> - Clicar em "Novo Cadastro" <br> - Preencher os campos obrigatórios (e-mail, nome, senha) <br> - Clicar em "Cadastrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  |  |
| **Caso de Teste** 	| **CT-02 – Editar usuário** 	|
|	Requisito Associado 	| RF-001 - A aplicação deve permitir que o usuário gerencie o seu cadastro na plataforma. RF-010 - A aplicação deve possibilitar ao Usuário alterar suas informações pessoais e senha. |
| Objetivo do Teste 	| Verificar se o usuário consegue editar seus dados de cadastro na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site.<br> - Fazer login <br> - Clicar em "Meu perfil" <br> - Clicar em "Editar dados" <br> - Alterar o nome <br> - Clicar em "Salvar"|
|Critério de Êxito | - Cadastro alterado com sucesso. |
|  |  |
| **Caso de Teste** 	| **CT-03 – Deletar usuário** 	|
|	Requisito Associado 	| RF-001 - A aplicação deve permitir que o usuário gerencie o seu cadastro na plataforma. |
| Objetivo do Teste 	| Verificar se o usuário consegue excluir seu cadastro na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site.<br> - Fazer login <br> - Clicar em "Meu perfil" <br> - Clicar em "Excluir Conta" <br> - Clicar em "Confirmar"|
|Critério de Êxito | - Usuário excluído com sucesso. |
|  |  |
| **Caso de Teste** 	| **CT-04 – Fazer login** 	|
|	Requisito Associado 	| RF-002 - A aplicação deve permitir o login com autenticação de usuário e senha. |
| Objetivo do Teste 	| Verificar se o usuário consegue logar na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site.<br> - Preencher o campo de e-mail <br> - Preencher o campo de senha <br> - Clicar em "Entrar"|
|Critério de Êxito | - Login feito com sucesso. |
|  |  |
| **Caso de Teste** 	| **CT-05 – Cadastrar morador** 	|
|	Requisito Associado 	| RF-003 - A aplicação deve permitir que o usuário gerencie moradores e suas informações como nome e e-mail. |
| Objetivo do Teste 	| Verificar se o usuário consegue cadastrar moradores em sua conta na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site.<br> - Fazer login <br> - Clicar em "Adicionar morador" <br> - Preencher os campos obrigatórios (nome e e-mail) <br> - Clicar em "Cadastrar" |
|Critério de Êxito | - Morador cadastrado com sucesso. |
|  |  |
| **Caso de Teste** 	| **CT-06 – Editar morador** 	|
|	Requisito Associado 	| RF-003 - A aplicação deve permitir que o usuário gerencie moradores e suas informações como nome e e-mail. |
| Objetivo do Teste 	| Verificar se o usuário consegue editar informações dos moradores em sua conta na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site.<br> - Fazer login <br> - Selecionar morador <br> - Clicar em "Editar morador" <br> - Alterar o nome <br> - Clicar em "Salvar" |
|Critério de Êxito | - Morador alterado com sucesso. |
|  |  |
| **Caso de Teste** 	| **CT-07 – Cadastrar morador** 	|
|	Requisito Associado 	| RF-003 - A aplicação deve permitir que o usuário gerencie moradores e suas informações como nome e e-mail. |
| Objetivo do Teste 	| Verificar se o usuário consegue deletar moradores em sua conta na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site.<br> - Fazer login <br> - Selecionar morador <br> - Clicar em "Excluir morador" <br> - Clicar em "Salvar" |
|Critério de Êxito | - Morador excluído com sucesso. |
|  |  |
| **Caso de Teste** 	| **CT-08 – Cadastrar despesa** 	|
|	Requisito Associado 	| RF-005 - A aplicação deve permitir que o usuário gerencie os gastos da casa em que mora.	|
| Objetivo do Teste 	| Verificar se o usuário consegue cadastrar despesas do seu grupo na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site.<br> - Fazer login <br> - Clicar em "Adicionar despesa" <br> - Preencher os campos obrigatórios (valor, tipo, descrição, data) <br> - Clicar em "Salvar" |
|Critério de Êxito | - Despesa cadastrada com sucesso. |
|  |  |
| **Caso de Teste** 	| **CT-9 – Editar despesa** 	|
|	Requisito Associado 	| RF-005 - A aplicação deve permitir que o usuário gerencie os gastos da casa em que mora.	|
| Objetivo do Teste 	| Verificar se o usuário consegue editar despesas do seu grupo na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site.<br> - Fazer login <br> - Selecionar despesa <br> - Clicar em "Editar despesa" <br> - Alterar valor <br> - Clicar em "Salvar" |
|Critério de Êxito | - Despesa alterada com sucesso. |
|  |  |
| **Caso de Teste** 	| **CT-10 – Deletar despesa** 	|
|	Requisito Associado 	| RF-005 - A aplicação deve permitir que o usuário gerencie os gastos da casa em que mora.	|
| Objetivo do Teste 	| Verificar se o usuário consegue deletar despesas do seu grupo na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site.<br> - Fazer login <br> - Selecionar despesa <br> - Clicar em "Excluir despesa" <br> - Clicar em "Confirmar"|
|Critério de Êxito | - Despesa excluída com sucesso. |
|  |  |
| **Caso de Teste** 	| **CT-11 – Lista relatórios despesas** 	|
|	Requisito Associado 	| RF-006 - A aplicação deve possuir uma página para exibir os relatórios de quanto cada morador deve contribuir ao final do mês. |
| Objetivo do Teste 	| Verificar se o usuário consegue visualizar a lista dos relatórios de cada morador na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site.<br> - Fazer login <br> - Selecionar "Relatórios" <br> - Clicar em "Valor mensal" <br>|
|Critério de Êxito | - Relatórios sobre o valor de contribuição de cada morador é exibido na tela. |
|  |  |
| **Caso de Teste** 	| **CT-12 – Relatório mensal de despesas** 	|
|	Requisito Associado 	| RF-007 - A aplicação deve disponibilizar um relatório mensal especificando as despesas e seu respectivo valor. |
| Objetivo do Teste 	| Verificar se o usuário consegue visualizar o relatório mensal de despesas na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site.<br> - Fazer login <br> - Selecionar "Relatórios" <br> - Clicar em "Valor mensal" <br>|
|Critério de Êxito | - Relatório sobre o valor mensal de despesas é exibido na tela. |
|  |  |
| **Caso de Teste** 	| **CT-13 – Gerar relatórios de despesas** 	|
|	Requisito Associado 	| RF-008 - A aplicação deve disponibilizar duas opções antes de gerar os relatórios: 1) Proporcional ao salário; 2) Sobre a divisão por pessoa. |
| Objetivo do Teste 	| Verificar se o usuário consegue gerar os relatórios de despesas de acordo com a opção escolhida na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site.<br> - Fazer login <br> - Selecionar "Relatórios" <br> - Clicar em "Gerar relatórios" <br> <br> - Clicar em "Proporcional ao Salário" <br>|
|Critério de Êxito | - Relatório gerado com sucesso. |
|  |  |
| **Caso de Teste** 	| **CT-14 – Gerar relatórios de despesas** 	|
|	Requisito Associado 	| RF-008 - A aplicação deve disponibilizar duas opções antes de gerar os relatórios: Proporcional ao salário; Sobre a divisão por pessoa. |
| Objetivo do Teste 	| Verificar se o usuário consegue gerar os relatórios de despesas de acordo com a opção escolhida na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site.<br> - Fazer login <br> - Selecionar "Relatórios" <br> - Clicar em "Gerar relatórios" <br> <br> - Clicar em "Divisão igual entre moradores" <br>|
|Critério de Êxito | - Relatório gerado com sucesso. |
|  |  |
|Critério de Êxito | - Relatório gerado com sucesso. |
|  |  |
| **Caso de Teste** 	| **CT-15 – Gerar gráficos de despesas** 	|
|	Requisito Associado 	| RF-009 - A aplicação deve gerar gráficos dentro da página de relatórios para ilustrar os gastos e as contribuições.	 |
| Objetivo do Teste 	| Verificar se o usuário consegue gerar os relatórios de despesas. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site.<br> - Fazer login <br> - Selecionar "Relatórios" <br> - Clicar em "Gerar relatórios" <br> <br> - Clicar em "Proporcional ao salário" <br>|
|Critério de Êxito | - Visualizar gráficos gerados com sucesso. |
|  |  |
| **Caso de Teste** 	| **CT-16 – Gerar gráficos de despesas** 	|
|	Requisito Associado 	| RF-009 - A aplicação deve gerar gráficos dentro da página de relatórios para ilustrar os gastos e as contribuições.	 |
| Objetivo do Teste 	| Verificar se o usuário consegue gerar os relatórios de despesas. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site.<br> - Fazer login <br> - Selecionar "Relatórios" <br> - Clicar em "Gerar relatórios" <br> <br> - Clicar em "Divisão igual entre moradores" <br>|
|Critério de Êxito | - Visualizar gráficos gerados com sucesso. |
|  |  |
| **Caso de Teste** 	| **CT-17 – Exibir menu de navegação** 	|
|	Requisito Associado 	| RF-011 - Todas as páginas devem possuir um menu de navegação no topo da página.	 |
| Objetivo do Teste 	| Verificar se o usuário consegue acessar o menu de navegação no topo de qualquer tela da aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site.<br> - Fazer login <br> - Selecionar "Relatórios" <br> - Clicar em "Gerar relatórios" <br> |
|Critério de Êxito | - Em todas as telas é exibido o menu de navegação no topo. |
|  |  |
| **Caso de Teste** 	| **CT-18 – Exibir rodapé** 	|
|	Requisito Associado 	| RF-012 - Todas as páginas devem possuir um rodpé com links das páginas de informação e do painel, além de direitos autorais.	 |
| Objetivo do Teste 	| Verificar se o usuário consegue visualizar o rodapé em qualquer tela da aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site.<br> - Fazer login <br> - Selecionar "Relatórios" <br> - Clicar em "Gerar relatórios" <br> |
|Critério de Êxito | - Em todas as telas é exibido o rodapé. |
|  |  |
