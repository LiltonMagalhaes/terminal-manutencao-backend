# Terminal de Manutenção - Backend (API C#)

Esta é a API REST que alimenta o sistema **Terminal de Manutenção (TRS-80 Style)**. O backend foi construído com C# (.NET 8), utilizando o Entity Framework Core para a comunicação com o banco de dados SQLite.

## 🚀 Tecnologias

- C# (.NET 8)
- ASP.NET Core Web API
- Entity Framework Core
- SQLite

## ⚙️ Funcionalidades

- CRUD de Clientes.
- CRUD de Ordens de Serviço (OS).
- Autenticação de Usuários (Login).
- Criação automática do banco de dados via Migrations.

## 🛠️ Como rodar o projeto

1. Clone o repositório:
   `git clone https://github.com/LiltonMagalhaes/terminal-manutencao-backend.git`

2. Entre na pasta:
   `cd TerminalBackend`

3. Restaure os pacotes e aplique as migrações do banco de dados:
   ```bash
   dotnet restore
   dotnet ef database update
   ```
