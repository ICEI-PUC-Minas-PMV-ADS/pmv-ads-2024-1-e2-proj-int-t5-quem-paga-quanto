# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

1) Roberto tem 26 anos, trabalha como desenvolvedor e mora com sua namorada que irá começar 
a contribuir nas contas de casa agora que formou e arranjou um emprego.
<br><br> Roberto quer dividir as contas de forma proporcional já que no passado ao tentar dividir as contas 
da forma convencional (meio a meio), não sobrava nada para sua namorada. 
Considerando isso, ele está procurando uma ferramenta para calcular quanto cada um deve contribuir 
de uma forma que sobre dinheiro para ambos.

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Usuário do sistema  | Registrar os gastos da minha casa.  | Ter controle do que foi gasto. |
|Usuário do sistema | Cadastrar os moradores da minha casa e suas rendas mensais. | Que haja dados para calcular suas contribuições mensais.  |
|Usuário do sistema  | Calcular quanto cada morador da minha casa deve contribuir de forma proporcional a renda. | Que ambos contribuam a mesma proporção referente a renda e os gastos. |

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| A aplicação deve permitir que o usuário cadastre as informações moradores da sua casa como nome, idade e renda | ALTA |
|RF-002| A Aplicação deve permitir que o usuário cadastre os gastos da casa em que mora | ALTA |
|RF-003| A aplicação deve possuir uma listagem dos gastos divididos por mês | ALTA |
|RF-004| A aplicação deve possuir uma página para exibir os relatórios de quanto cada morador deve contribuir ao final do mês | ALTA |
|RF-005| A aplicação deve possuir duas modalidade de divisão dos gastos, a o proporcional ao salário e a dividida por pessoas | MEDIA |
|RF-006| A aplicação deve possubilitar o cadastro de gastos e contas por categoria | BAIXA |
|RF-007| A aplicação deve gerar gráficos dentro da página de relatórios para ilustrar os gastos e as contribuições | MEDIA |
|RF-008| A aplicação deve possibilitar o cadastros do usuário que registrará os moradores da residência. | ALTA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| A aplicação deve ser responsiva | MÉDIA | 
|RNF-002| A aplicação deve possuir layout e formulários simples | MÉDIA |
|RNF-002| A aplicação deve possuir feedbacks claros quando ações de criação, exclusão e modificação forem executadas | MÉDIA |

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
