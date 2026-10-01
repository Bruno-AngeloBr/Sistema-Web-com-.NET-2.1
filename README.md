# Sistema-Web-com-.NET-2.1

Sistema web desenvolvido em ASP.NET Core MVC durante curso para gerenciamento de vendedores, departamentos e registros de vendas.

📖 Sobre o Projeto

O SalesWebMvc é uma aplicação desenvolvida com o objetivo de demonstrar conceitos de desenvolvimento web utilizando ASP.NET Core MVC, Entity Framework Core e banco de dados MySQL.

O sistema permite:

- Gerenciamento de departamentos;
- Cadastro e manutenção de vendedores;
- Registro de vendas;
- Relacionamento entre entidades;
- Consultas de vendas por período;
- Operações CRUD completas.
🛠 Tecnologias Utilizadas
- Backend
- ASP.NET Core MVC 2.1
- C#
- Entity Framework Core
- LINQ
- Banco de Dados: MySQL
- Pomelo.EntityFrameworkCore.MySql
- Frontend
- Razor Pages
- Bootstrap
- jQuery

📂 Estrutura do Projeto

🏗 Arquitetura MVC

- Models: Responsáveis pela representação das entidades do sistema e pelas regras de negócio.

- Views: Responsáveis pela interface com o usuário utilizando Razor.

- Controllers: Responsáveis por receber as requisições, processar os dados e retornar as Views.

⚙️ Configuração do Banco de Dados

No arquivo: JSON
- appsettings.json

Configure sua string de conexão:

JSON
{
"ConnectionStrings": {
"SalesWebMvcContext": "server=localhost;port=....;userid=....;password=;database=saleswebmvcappdb"
}
}
``

🚀 Como Executar o Projeto

1. Clonar o Repositório
- Shell
- git clone https://github.com/seu-usuario/SalesWebMvc.git

2. Restaurar Dependências
- Shell
- dotnet restore
- Mostrar mais linhas

3. Criar o Banco de Dados
- Executar as migrations:
- PowerShell
- Update-Database

Ou via CLI:
- Shell
- dotnet ef database update

4. Executar a Aplicação
- Shell
- dotnet run

A aplicação estará disponível em:

- Plain Text
- https://localhost:5001

ou

- Plain Text
- http://localhost:5000

🎯 Funcionalidades
- Departamentos
- Listar
- Criar
- Editar
- Excluir
- Visualizar detalhes
- Vendedores
- Listar
- Criar
- Editar
- Excluir
- Visualizar detalhes
- Registros de Vendas
- Pesquisa simples
- Pesquisa agrupada
- Filtro por período
- Relacionamento com vendedores
  
📚 Conceitos Aplicados
- MVC (Model View Controller)
- Dependency Injection
- Entity Framework Core
- Code First
- Migrations
- View Models
- LINQ
- Data Annotation Validation
- CRUD
- Relacionamentos entre entidades
