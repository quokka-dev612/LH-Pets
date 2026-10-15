# LH-Pets 🐾

## Sobre o projeto

O LH-Pets é uma API REST desenvolvida em C# com ASP.NET Core para realizar o cadastro e a consulta de clientes e seus animais de estimação.

O projeto utiliza listas em memória para armazenar os dados durante a execução, sem necessidade de banco de dados.

## Tecnologias utilizadas

- C#
- ASP.NET Core Web API
- Controllers e rotas HTTP
- Swagger para documentação e testes da API
- Listas em memória (`List<T>`)

## Funcionalidades

### Clientes
- Listar todos os clientes: `GET /api/Clientes`
- Cadastrar um cliente: `POST /api/Clientes`

### Pets
- Listar todos os pets: `GET /api/Pets`
- Cadastrar um pet: `POST /api/Pets`
- Listar os pets de um cliente: `GET /api/Pets/cliente/{clienteId}`

## Como executar

1. Instale o SDK do .NET 5.0.
2. Abra o terminal na pasta do projeto.
3. Execute `dotnet restore`.
4. Execute `dotnet run`.
5. Acesse o Swagger pelo endereço HTTPS ou HTTP informado no terminal, acrescentando `/swagger`.

## Observação

Os dados são armazenados em memória e são perdidos quando a aplicação é encerrada.

## Objetivo acadêmico

Projeto desenvolvido para praticar programação orientada a objetos, criação de APIs REST, utilização de Controllers, verbos HTTP e relacionamento entre entidades.