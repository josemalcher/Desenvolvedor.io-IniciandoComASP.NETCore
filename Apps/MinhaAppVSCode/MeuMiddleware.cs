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
