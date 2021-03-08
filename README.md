# Desenvolvedor.io - Iniciando com ASP.NET Core

https://desenvolvedor.io/

## <a name="indice">Índice</a>

Aula | Check
--- | --- 
Apresentação | :heavy_check_mark:
Contexto Histórico | :heavy_check_mark:
Por que um novo stack? | :heavy_check_mark:
Novidades no ASP.NET Core | :heavy_check_mark:
.NET Core | :heavy_check_mark:
.NET CLI | :heavy_check_mark:
.NET Standard | :heavy_check_mark:
IDE`s que utilizaremo | :heavy_check_mark:
Testando os Conhecimentos | :heavy_check_mark:
Instalação do .NET Core | :heavy_check_mark:
Gerenciando Versões | :heavy_check_mark:
Minha primeira APP ASP.NET Core | :heavy_check_mark:
Tipos de Projetos | :heavy_check_mark:
Minha primeira App VS | :heavy_check_mark:
Estrutura do Projeto | :heavy_check_mark:
Launch Settings | :heavy_check_mark:
Pasta wwwroot | :heavy_check_mark:
App Settings | :heavy_check_mark:
Classes de Configuração | :heavy_check_mark:
Minha primeira App VS Code | :heavy_check_mark:
Trabalhando com VS Code | :heavy_check_mark:
OWIN | :heavy_check_mark:
Middlewares | :heavy_check_mark:
Interfaces | :heavy_check_mark:
Startup.cs e Middlewares | :heavy_check_mark:
Recapitulando | :heavy_check_mark:

---

### Tipos de Projetos

![Tipos de Projetos](/img/arq-aspnetcore.png)

---

### OWIN

![OWIN](/img/owin.png)

---

### Middlewares

![Middlewares 1](/img/middlewares.png)

![Middlewares 2](/img/middlewares_2.png)

![Middlewares 3](/img/middlewares_3.png)

---

### Interfaces

![Interfaces 1](/img/interfaces_1.png)

![Interfaces 2](/img/interfaces_2.png)

![Interfaces 3](/img/interfaces_3.png)

![Interfaces 4](/img/interfaces_4.png)

---

### Startup.cs e Middlewares

```csharp
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Builder;

public class MeuMiddleware
{
    private readonly RequestDelegate _next;

    public MeuMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        Console.WriteLine("\n\r ------- ANTES --------- \n\r");

        await _next(context);
        
        Console.WriteLine("\n\r ------- DEPOIS --------- \n\r");

    }
}

public static class MeuMiddlewareExtension
{
    public static IApplicationBuilder useMeuMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<MeuMiddleware>();
    }
}

```

```csharp

            //app.UseMiddleware<MeuMiddleware>();
            app.useMeuMiddleware();

```

---

### Recapitulando

![resumo](/img/resumo.png)