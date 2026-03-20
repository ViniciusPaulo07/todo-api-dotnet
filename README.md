# Simples Todo List API com ASP.NET Core

## 📌 Descrição do projeto

Uma REST API para gerenciamento de tarefas com operações CRUD em ASP.NET Core.
Permitindo que você crie, liste, atualize e remova suas tarefas, dando mais autonomia para sua rotina.

## 🚀 Funcionalidades

- Criar Tarefas
- Listar Tarefas
- Atualizar Tarefas
- Remover Tarefas

## 🛠 Tecnologias Utilizadas

- C#
- ASP.NET Core Web API
- Swashbuckle

## ▶️ Como Rodar o Projeto

1. Clonar o repositório
   ```bash
   git clone https://github.com/ViniciusPaulo07/todo-api-dotnet.git
   ```
2. Entrar na pasta
   ```bash
   cd todo-api-dotnet
   ```
3. Rodar o projeto
   ```bash
   dotnet run
   ```

## 📖 Documentação

A API pode ser testada através do Swagger após rodar o projeto:

https://localhost:xxxx/swagger

## 📡 Endpoints

GET /api/tasks
POST /api/tasks
PUT /api/tasks/{id}
DELETE /api/tasks/{id}

## 📦 Exemplo de requisição (POST)

{
"titulo": "Estudar C#",
"estaCompleta": false
}
