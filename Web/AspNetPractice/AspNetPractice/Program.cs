using System.Text;
using Microsoft.AspNetCore.Server.Kestrel.Core;
// exercise option 1:
//      make an asp.net core app (start with the empty template) that
//      keeps track of some structured data in custom classes and uses serialization
//      to respond with the data. for example: static list of rock-paper-scissors roundresults,
//      and use XmlSerializer to convert it to XML in the response body.
// exercise option 2:
//      make an asp.net core app (start with the empty template) that
//      treat the "path" as a relative path on the server's file system.
//      the response should include the contents of that file.
//      example: https://localhost:7206/Program.cs
//      choose a good content type based on the file extension.
//      return 404 if no such file.
WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<KestrelServerOptions>(options => options.AllowSynchronousIO = true);
WebApplication app = builder.Build();


app.Run(context =>
{
    // the HttpContext parameter (context) gives access to all the request data
    // and lets you modify all the response data.

    string path = context.Request.Path;
    string subPath = path.Substring(1, path.Length-1);
    try
    {
        using var stream = new FileStream(subPath, FileMode.Open, FileAccess.Read);

        context.Response.StatusCode = 200;
        context.Response.ContentType = "image/png";
        // serializing the string as bytes using UTF8 encoding, and writing it to the
        // HTTP response directly
        stream.CopyTo(context.Response.Body);
    }catch (IOException ex)
    {
        context.Response.StatusCode = 404;
        Console.WriteLine(ex.Message);
    }
    // need this line so it compiles
    // (really this delegate should be async but we haven't done that yet)
    return Task.CompletedTask;
});

app.Run();
