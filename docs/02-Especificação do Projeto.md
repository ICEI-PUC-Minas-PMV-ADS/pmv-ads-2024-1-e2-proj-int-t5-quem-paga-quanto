# Especificações do Projeto

## Personas
### Roberto da Silva
Roberto tem 26 anos, trabalha como desenvolvedor e mora com sua namorada que irá começar 
a contribuir nas contas de casa agora que formou e arranjou um emprego.

Roberto quer dividir as contas de forma proporcional já que no passado ao tentar dividir as contas 
da forma convencional (meio a meio), não sobrava nada para sua namorada. 
Considerando isso, ele está procurando uma ferramenta para calcular quanto cada um deve contribuir 
de uma forma que sobre dinheiro para ambos.

### Marlene Andrade de Souza
Marlene tem 45 anos, trabalha como doméstica e quer encontrar uma forma de influenciar seu filho a ter mais conciência finânceira, já que começou um estágio e começou a ganhar seu dinheiro agora oas 18 anos.

Marlente, quer que seu filho Enzo contribua financeiramente dentro de casa agora que conseguiu um estágio, porém entende que seu filho ganha bem pouco pois está começando a trabalhar agora e seu estágio não paga muito.

Para ser justa, Marlene está procurando algum aplicativo que seja simples de usar e a ajude a dividir as contas sem atrapalhar o lazer do seu filho que trabalha bastante.

### Atônio de Albuquerque Lourenço
Antônio tem 72 anos, é aposentado e mora com sua filha desde que sua esposa faleceu.

Antônio tinha um padrão de vida alto, mas, desde que aposentou, passou a receber uma remuneração consideravelmente mais baixa.
Sendo assim, ele busca uma divisão igualitária das despesas da casa para que nem ele, nem sua filha sejam sobrecarregados.

### Marcelo João Pereira
Macelo tem 23 anos e mora com seus irmãos em outra cidade para fazer faculdade federal. Já tentou morar em uma república mas teve vários problemas com a divisão dos gastos.

Agora Marcelo está enfrentando os mesmo problemas morando com seus irmãos mais velhos de 32 e 36 anos. 

Para resolver de forma justa, já que contribui com as despesas com a mesada que seus pais de pouca condição mandam todos os meses, quer encontrar um aplicativo para registras as contas básicas de comida, água, aluguel e luz para que todos irmãos contribuam de forma igual, já que por tratar do dinheiro de seus pais, os folgados de seus irmãos mais velhos comem tudo e não ajudam com muito.
## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `| QUERO/PRECISO ...  |PARA ...                 |
|--------------------|------------------------------------|----------------------------------------|
| Carlos  | Registrar meus gastos e de minha namorada em nossa casa.  | Ter maior controle do que foi gasto durante o mês. |
| Carlos | Encontrar uma forma simples para dividir as contas com minha namorada | Seja justa a divisão, mesmo que ambos ganhem diferente. |
| Marlene | De um aplicativo que forneça uma forma simples e justa de dividir as contas  | Que meu filho aprenda a contribuir no pagamento das contas de casa. |
| João | Poder cadastrar as contas de casa e dividir de forma igual todos os gastos. | Que consiga impor limites em sua casa, demonstrando as informações de forma clara e convincente os gastos para seus irmãos. |

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| A aplicação deve permitir que o usuário gerencie as informações moradores da sua casa como nome, idade e renda. | ALTA |
|RF-002| A aplicação deve permitir que o usuário gerencie os gastos da casa em que mora. | ALTA |
|RF-003| A aplicação deve possuir uma listagem dos gastos divididos por mês. | ALTA |
|RF-004| A aplicação deve possuir uma página para exibir os relatórios de quanto cada morador deve contribuir ao final do mês. | ALTA |
|RF-005| A aplicação deve possuir duas modalidade de divisão dos gastos, a o proporcional ao salário e a dividida por pessoas. | MEDIA |
|RF-006| A aplicação deve possibilitar o cadastro de gastos e contas pelas categorias: Casa, Comida, Fixos, Entreterimento e Outros. | BAIXA |
|RF-007| A aplicação deve gerar gráficos dentro da página de relatórios para ilustrar os gastos e as contribuições. | MEDIA |

### Requisitos de Qualidade (Não Funcionais)

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| A aplicação deve ser responsiva e adaptar a dispositivos móveis | MÉDIA | 
|RNF-002| A aplicação deve possuir layout e formulários com apenas campos necessários e com descrições claras do que deve ser informado. | MÉDIA |
|RNF-002| A aplicação deve possuir feedbacks claros quando ações de criação, exclusão e modificação forem executadas | MÉDIA |
|RNF-003 | A aplicação deve ser desenvolvida utilizando C#, HTML, CSS e JavaScript |
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
