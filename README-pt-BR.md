# Introdução
Este teste técnico tem como objetivo avaliar suas habilidades e conhecimentos como desenvolvedor .NET no contexto de backend. Você será responsável por criar uma API RESTful em .NET Core para gerenciar produtos, integrando-a com bancos de dados SQL Server e MongoDB. Além disso, deve implementar uma funcionalidade de mensageria usando Rabbit MQ e escrever testes de unidade para garantir a qualidade do código. Versionar o projeto no GitHub e documentar a API também são partes essenciais deste teste.

# Entregáveis:
1. Um vídeo gravado de você completando a tarefa e explicando seu processo de pensamento e implementação de código.
2. Seu código deve ser enviado para um repositório no github utilizando este template como base.

# Tarefas:
1. **Desenvolvimento de API RESTful:**
   - Crie uma API RESTful usando .NET Core que seja capaz de realizar operações CRUD (Criar, Ler, Atualizar e Deletar) para uma entidade "Produto". A entidade "Produto" deve conter os seguintes atributos:
     - Id (inteiro) - identificador único do produto
     - Nome (string) - nome do produto
     - Descrição (string) - descrição do produto
     - Preço (decimal) - preço do produto

2. **Banco de Dados:**
   - Utilize o Entity Framework para mapear a entidade "Produto" no banco de dados. A aplicação deve ser capaz de persistir os produtos em um banco de dados SQL Server. Além disso, permita também a opção de utilizar um banco de dados MongoDB para persistência.

3. **Integração de Mensageria:**
   - Implemente uma funcionalidade para enviar uma mensagem para uma fila do Rabbit MQ sempre que um novo produto for criado na API. A mensagem deve conter o Id e o Nome do produto criado.

4. **Testes Unitários:**
   - Escreva testes unitários para garantir a qualidade do código e a funcionalidade da API. Utilize uma estrutura de teste de sua escolha (por exemplo, MSTest, NUnit, XUnit).

5. **Controle de Versão:**
   - Versione o código do seu projeto usando o GitHub.

6. **Documentação:**
   - Documente o projeto descrevendo a estrutura da API, a arquitetura utilizada e instruções detalhadas para executar a aplicação localmente. Utilize o arquivo README.md para esta finalidade.


# Critério de Avaliação:
Sua solução será avaliada seguindo os seguintes critérios:
- Qualidade do código
- Design de componentes e arquitetura
- Experiência de usuário
- Performance
