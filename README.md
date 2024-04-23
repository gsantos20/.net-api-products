
# .NET - API Product



## 🚀 Como executar o projeto



### Pré-requisitos

Antes de começar, você vai precisar ter instalado em sua máquina as seguintes ferramentas:
[Git](https://git-scm.com), [.NET SDK](https://dotnet.microsoft.com/pt-br/download). 
Além disto é bom ter um editor para trabalhar com o código como [VSCode Comunity 2022](https://visualstudio.microsoft.com/pt-br/vs/community/)


### Configurações local

#### 🎲 Rodando o Backend ( API )

Para rodar a API , você vai precisar adicionar as seguintes variáveis de ambiente em sua enviroment

`DbServer` - Url de acesso do banco de dados.

- #### Exemplo : localhost

`DbPort` - Porta de acesso do banco de dados.

- #### Exemplo : 1433

`DbUser` - Credenciais de acesso do banco de dados.

- #### Exemplo : SA

`Password` - Credenciais de acesso do banco de dados.

 - #### Exemplo : SA

`Database` - Base de dados utilizada na aplicação.

- #### Exemplo : ProductsDb




#### Executando a aplicação

```bash
# Clone este repositório
$ git clone https://github.com/gsantos20/.net-api-products.git

# Acesse a pasta do projeto no seu terminal/cmd
$ cd ProductsAPI

# Instale o framework Entity Framweork
$ dotnet tool install --global dotnet ef

# Execute o build do projeto
$ dotnet builld

# Execute as migrações inicias do projeto
$ dotnet ef migrations add initial-migrition
$ dotnet ef database update

# Execute a aplicação
$ dotnet run

# A aplicação será aberta na porta:5000
Acesse - http://localhost:5000/

```

#### 👾  Executando a aplicação utlizando Docker

Para rodar a API utlizando docker , é necessario ter o docker e docker compose instalados e configurados em sua maquina

```bash
# Clone este repositório
$ git clone https://github.com/gsantos20/.net-api-products.git

# Acesse a pasta do projeto no seu terminal/cmd
$ cd ProductsAPI

# Instale o framework Entity Framweork
$ docker compose up --build

# A aplicação será aberta na porta:5000
Acesse - http://localhost:5000/
```

#### 🔒  Iniciar Testes

```bash
# No Terminal use os seguintes comandos

```

#### ⚙ Build do Projeto

```bash
# No Terminal use os seguintes comandos para gerar o build
$ dotnet build
```


## 📖 Documentação da API

 - #### Products

```http
  GET /api/product
```

 Retorna um Array de objetos dos produtos na base de dados.

### 

```http
  POST /api/product
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |  
| `Name`      | `Bearer` | Nome do produto |
| `Description`      | `String` | Descrição do produto |
| `Price`      | `String` | Preço do produto |

Insere um produto de acordo com os parametros utilizados.

### 

```http
  PUT /api/product/:id
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id`      | `int` | Identificador do produto |  
| `Name`      | `Bearer` | Nome do produto |
| `Description`      | `String` | Descrição do produto |
| `Price`      | `String` | Preço do produto |

Atualiza um produto de acordo com o id e parametros utilizados.

### 

```http
  DELETE /api/product/:id
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id`      | `string` | Identificador do produto |      

Deleta um produto de acordo com o id.



## 🏗 Arquitetura

 - #### Products
 
   * #### SQL Server

    ![Product-SQL](https://i.imgur.com/wh9TkRa.png)

   * #### MongoDB

    ![Product-Mongo](https://i.imgur.com/RpQwtpY.png)


####

## 🛠 Tecnologias

As seguintes ferramentas foram usadas na construção do projeto:

#### **API**  ([.NET Core](https://dotnet.microsoft.com/pt-br/download) + [Entity Framework](https://learn.microsoft.com/en-us/aspnet/entity-framework) + [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads))


## 🧾 Conceitos utilizados

- Conceitos de SOLID
- Injeção de Dependência (Dependency Injection)
- Repository Pattern
- Service Pattern
## 🦸 Autor

<div>
 <img style="border-radius: 50%;" src="https://avatars3.githubusercontent.com/u/100292023?s=460&u=61b426b901b8fe02e12019b1fdb67bf0072d4f00&v=4" width="100px;" alt=""/>
   <br />
 <sub><b>Gustavo Santos</b></sub></a> <a href="https://www.linkedin.com/in/gsantos20">🚀</a>
</div>
 <br />

<div>
  <a href="https://instagram.com/guuztta" target="_blank"><img src="https://img.shields.io/badge/-Instagram-%23E4405F?style=for-the-badge&logo=instagram&logoColor=white" target="_blank"></a>
  <a href ="mailto:nerisgs20@gmail.com"><img src="https://img.shields.io/badge/Gmail-D14836?style=for-the-badge&logo=gmail&logoColor=white" target="_blank"></a>
  <a href="https://www.linkedin.com/in/gsantos20" target="_blank"><img src="https://img.shields.io/badge/-LinkedIn-%230077B5?style=for-the-badge&logo=linkedin&logoColor=white" target="_blank"></a>
</div>

---

## 📝 Licença

Este projeto esta sobe a licença [MIT](./LICENSE).

Feito com ❤️ por Gustavo Santos 👋🏽 [Entre em contato!](https://www.linkedin.com/in/gsantos20/)

---
