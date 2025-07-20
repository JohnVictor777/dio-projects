# 🚀 API de Gerenciamento de Veículos (ASP.NET Minimal APIs)

Este projeto é uma **API RESTful** para gerenciamento de veículos, construída com **ASP.NET Minimal APIs**, **Entity Framework Core** e **SQL Server**. Ele foca em demonstrar uma abordagem moderna de desenvolvimento, incluindo **autenticação JWT**, **autorização por perfis** e **testes unitários com MSTest**.

---

## ✨ Funcionalidades

- **Autenticação JWT:** Login para administradores (`POST /login`).
- **Gestão de Administradores (Perfil `Admin`):**
  - Criar (`POST /admin/criar`)
  - Listar todos (`GET /veiculos`)
  - Detalhes por ID (`GET /veiculos/{id}`)
- **CRUD de Veículos (Autenticado):**
  - Cadastrar (`POST /veiculos`)
  - Listar todos (`GET /veiculos`)
  - Detalhes por ID (`GET /veiculos/{id}`)
  - Atualizar (`PUT /veiculos/{id}`)
  - Excluir (`DELETE /veiculos/{id}`)
- **Autorização:** Controle de acesso via perfis (`Admin`, `Editor`).
- **Validação de Dados:** Integridade garantida nas operações de veículo.
- **Swagger/OpenAPI:** Documentação e interface para testes da API.

---

## 🛠️ Tecnologias

- **ASP.NET Core 7/8+ Minimal APIs**
- **C\#**
- **Entity Framework Core**
- **SQL Server**
- **JWT (JSON Web Tokens)**
- **Swagger**
- **MSTest** (para Testes Unitários)
- **Git**

---

## 🚀 Como Rodar Localmente

### Pré-requisitos

- [.NET SDK 7/8+](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads) (ou LocalDB)
- [Visual Studio](https://visualstudio.microsoft.com/pt-br/vs/) ou [Visual Studio Code](https://code.visualstudio.com/)

### 1\. Clonar o Repositório

```bash
git clone https://github.com/JohnVictor777/SEU_REPOSITORIO.git # Ajuste para o seu nome de repositório se for diferente
cd SEU_REPOSITORIO
```

### 2\. Configurar o Banco de Dados (SQL Server)

1.  **String de Conexão:** No `appsettings.Development.json` do projeto da API, configure sua string de conexão:

    ```json
    {
      "ConnectionStrings": {
        "DefaultConnection": "Server=SEU_SERVIDOR;Database=NomeDoSeuBanco;User Id=SEU_USUARIO;Password=SUA_SENHA;TrustServerCertificate=True"
      }
    }
    ```

    _(Para LocalDB/Windows Auth, use: `"Server=(localdb)\\mssqllocaldb;Database=MinimalApiDB;Trusted_Connection=True;MultipleActiveResultSets=true"`)_

2.  **Migrações e Seed:** No terminal, na pasta do projeto principal da API, execute:

    ```bash
    dotnet ef database update
    ```

    _(Isso criará o banco e tabelas, com um admin padrão: `admin` / `senha123`)_

### 3\. Executar Testes Unitários

Na pasta do seu projeto de testes (`SeuProjeto.Tests`), execute:

```bash
dotnet test
```

### 4\. Iniciar a Aplicação

Na pasta do projeto principal da API, execute:

```bash
dotnet run
```

A API estará acessível em `https://localhost:PORTA_DO_PROJETO` (a porta será exibida no terminal).

### 5\. Acessar Swagger

Com a API rodando, abra seu navegador em:

- `https://localhost:PORTA_DO_PROJETO/swagger`

---

## 🔐 Autenticação no Swagger

1.  **Login:**
    - Use `POST /login` no Swagger com `administrador@teste.com` / `123456`.
    - **Copie o token JWT** retornado.
2.  **Autorizar:**
    - Clique em **"Authorize"** no topo do Swagger.
    - Insira `Bearer SEU_TOKEN_AQUI` (substitua pelo token copiado).
    - Clique em `Authorize` para testar os endpoints protegidos.

---

## 🤝 Contato

- **GitHub:** [github.com/JohnVictor777](https://github.com/JohnVictor777)
- **LinkedIn:** [www.linkedin.com/in/johnvic7or/](https://www.linkedin.com/in/johnvic7or/)

---
