# Produtos API

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white) ![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white) ![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-512BD4?style=for-the-badge&logo=dotnet&logoColor=white) ![MySQL](https://img.shields.io/badge/MySQL-4479A1?style=for-the-badge&logo=mysql&logoColor=white)

API REST para gerenciamento de produtos, construída em ASP.NET Core com Entity Framework Core e banco de dados MySQL.

Fornece endpoints para operações de CRUD.

## Pré-requisitos
-  .NET 6 SDK ou superior
  -   MySQL Server instalado e rodando
  
## API Endpoints
```bash
 GET /api/v1/produtos → Lista todos os produtos

 POST /api/v1/produtos → Adiciona novo produto

 PUT /api/v1/produtos/{id} → Atualiza produto existente

 DELETE /api/v1/produtos/{id} → Remove produto
```

## Como rodar
1. **Clonar repositório**
```bash
git clone https://github.com/miltonjss/produtos-api.git
```
2. **Configurar o banco MySQL**
```bash
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=produtos;User=root;Password=SENHA"
}
```
3.  **Rodar a API**

   ```
 cd produtos-api
 dotnet run 
  ```
 4. **Acessar Swagger**
   
   ```
   https://localhost:7206/swagger
 ```
 



