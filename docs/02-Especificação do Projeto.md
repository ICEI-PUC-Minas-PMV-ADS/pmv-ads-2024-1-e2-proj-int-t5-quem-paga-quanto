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

2) Gisele tem 47 anos, trabalha como diretora de uma multinacional e mora com seu marido.
<br><br> Gisele busca uma divisão mais justa das contas, uma vez que arca com todas as despesas da casa e gostaria que seu marido passasse a contribuir de alguma forma.
Ela está buscando uma ferramenta que facilite este cálculo de forma simples e rápida já que sua rotina é muito intensa e ela não tem tempo para realizá-lo.

3) Enzo tem 18 anos, trabalha como estagiário e mora com sua mãe.
<br><br> A mãe de Enzo começou a passar algumas responsabilidades financeiras da casa a ele desde que ele conseguiu seu estágio.
Enzo busca contribuir em casa de uma forma justa para que sobre uma parte do seu baixo salário para atividades de lazer e estudo.

4) Antônio tem 72 anos, é aposentado e mora com sua filha desde que sua esposa faleceu.
<br><br> Antônio tinha um padrão de vida alto, mas, desde que aposentou, passou a receber uma remuneração consideravelmente mais baixa.
Sendo assim, ele busca uma divisão igualitária das despesas da casa para que nem ele, nem sua filha sejam sobrecarregados.

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
|RF-001| A aplicação deve permitir que o usuário cadastre as informações moradores da sua casa como nome, idade e renda. | ALTA |
|RF-002| A aplicação deve permitir que o usuário cadastre os gastos da casa em que mora. | ALTA |
|RF-003| A aplicação deve possuir uma listagem dos gastos divididos por mês. | ALTA |
|RF-004| A aplicação deve possuir uma página para exibir os relatórios de quanto cada morador deve contribuir ao final do mês. | ALTA |
|RF-005| A aplicação deve possuir duas modalidade de divisão dos gastos, a o proporcional ao salário e a dividida por pessoas. | MEDIA |
|RF-006| A aplicação deve possibilitar o cadastro de gastos e contas por categoria. | BAIXA |
|RF-007| A aplicação deve gerar gráficos dentro da página de relatórios para ilustrar os gastos e as contribuições. | MEDIA |
|RF-008| A aplicação deve possibilitar o cadastros do usuário que registrará os moradores da residência. | ALTA |

### Requisitos de Qualidade (Não Funcionais)

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| A aplicação deve ser responsiva | MÉDIA | 
|RNF-002| A aplicação deve possuir layout e formulários simples | MÉDIA |
|RNF-002| A aplicação deve possuir feedbacks claros quando ações de criação, exclusão e modificação forem executadas | MÉDIA |

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| <p align="justify">Devido às limitações financeiras do projeto, é essencial otimizar o uso dos recursos disponíveis. Isso implica priorizar o uso de tecnologias de baixo custo ou gratuitas sempre que possível. Qualquer despesa adicional será submetida a uma cuidadosa análise e aprovação pela equipe de gerenciamento, garantindo que permaneçamos dentro do orçamento estabelecido.</p>|
|02| <p align="justify">Estabelecemos um prazo de seis meses para o desenvolvimento da aplicação, levando em consideração a complexidade do projeto e os recursos disponíveis. Durante esse período, definimos marcos e objetivos claros para cada fase do desenvolvimento, incluindo design, desenvolvimento de código, testes e lançamento da aplicação. Para garantir que o projeto progrida de acordo com o cronograma estabelecido, realizaremos reuniões de acompanhamento semanais para revisar o progresso, identificar quaisquer obstáculos e ajustar o plano, para garantir que o prazo final seja cumprido com sucesso.</p>|
|03| <p align="justify">Considerando a necessidade de proteger a privacidade dos usuários e cumprir as regulamentações legais, como a Lei Geral de Proteção de Dados (LGPD), a aplicação adotará medidas de segurança rigorosas. A equipe técnica implementará políticas de acesso restrito aos dados, garantindo que apenas pessoal autorizado tenha acesso aos dados dos usuários. Além disso, serão estabelecidos procedimentos para assegurar que os dados sejam armazenados de forma segura e protegidos contra ameaças externas. A aplicação seguirá as diretrizes da LGPD em relação à coleta, armazenamento e processamento de dados pessoais, buscando proteger a privacidade e a segurança das informações dos usuários.</p>|

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
