# Aplicativo de Demonstração de Autenticação JWT

Aplicativo utilizando **.NET 6** para demonstrar a utilização de JWT para autenticação.

## Observações

O foco principal deste projeto é a utilização de **JWT (JSON Web Tokens)** para autenticação em uma API, e a implementação de **roles** para acesso a determinadas rotas, garantindo a segurança de acesso.

## Tecnologias Utilizadas

- [.NET 6](https://dotnet.microsoft.com/download/dotnet/6.0)
- [JWT (JSON Web Tokens)](https://jwt.io/)
- [ASP.NET Core](https://docs.microsoft.com/aspnet/core)

## Funcionalidades Principais

- **Autenticação com JWT**:
  - Implementação de autenticação utilizando JWT para garantir a segurança das rotas da API.
  
- **Controle de Acesso por Roles**:
  - Implementação de controle de acesso baseado em roles, permitindo que apenas usuários com permissões específicas acessem determinadas rotas.

## Como Executar o Projeto

1. Clone o repositório:
    ```sh
    git clone https://github.com/williansdg4/ApiAuth.git
    ```
2. Navegue até o diretório do projeto:
    ```sh
    cd ApiAuth
    ```
3. Restaure as dependências:
    ```sh
    dotnet restore
    ```
4. Configure as chaves secretas e outros parâmetros de autenticação no arquivo `appsettings.json`.
5. Execute a aplicação:
    ```sh
    dotnet run
    ```

## Exemplos de Uso

### Obter Token JWT

Faça uma requisição POST para `/v1/login` com as credenciais do usuário:
```json
{
  "id": 1,
  "username": "batman",
  "password": "batman",
  "role": "manager"
}
