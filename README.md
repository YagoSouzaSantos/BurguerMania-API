# BurguerMania API 🍔

Bem-vindo à **BurguerMania API**, uma API RESTful desenvolvida em .NET 8 para gerenciar um sistema de pedidos e cardápio de hamburguerias. Este projeto utiliza Entity Framework Core para acesso a banco de dados e segue.
O projeto faz parte da avaliação da Unidade 10 da trilha de FullStack da Restic36.

## Tecnologias Utilizadas 🛠️

- **.NET 8.0** - Framework principal da aplicação.
- **Entity Framework Core 8.0.2** - ORM para acesso a banco de dados.
- **Pomelo.EntityFrameworkCore.MySql 8.0.2** - Provedor MySQL para EF Core.
- **AutoMapper 13.0.1** - Mapeamento de objetos.
- **Newtonsoft.Json** - Suporte para serialização/deserialização JSON no ASP.NET Core.
- **Swashbuckle.AspNetCore 6.6.2** - Geração de documentação interativa com Swagger.

## Pré-requisitos 🚀

Antes de iniciar, certifique-se de ter:

- **.NET SDK 8.0** instalado.
- Um banco de dados **MySQL** configurado.
- Ferramentas como **Visual Studio** ou **VS Code** para desenvolvimento.

## Configuração do Projeto ⚙️

1. Clone o repositório:
   ```bash
   git clone https://github.com/YagoSouzaSantos/BurguerMania-API.git
   cd burguer-mania-api
2. Restaure os Pacotes NuGet:
   ```bash
   dotnet restore
   
3. Configure a conexão com o banco de dados no arquivo appsettings.json:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=localhost;Database=burguer_mania;User=root;Password=senha;"
     }
    }
4. Execute as migrações para criar o banco de dados:
   ```bash
    dotnet ef database update

5. Inicie a aplicação:
   ````dotnet run

## Documentação 📖
A API utiliza o Swagger para documentação. Após iniciar a aplicação, você pode acessar a interface interativa em:
  ```bash
  http://localhost:5255/swagger
Atenção: O número da porta de comunicação pode variar, consulte o valor real após rodar o passo de número 5

