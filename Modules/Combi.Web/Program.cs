using Combi.Web.Middleware;
using Combi.Domain.Configuration;
using Combi.Dal.Configuration;
using Microsoft.AspNetCore.Rewrite;

var builder = WebApplication.CreateBuilder(args);

#if DEBUG
var connectionString = "test";//builder.Configuration.GetConnectionString("CombiDbContext"); 
#else
    var connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING");
#endif

// Add services to the container.
builder.Services.AddCombiDal(connectionString);
builder.Services.AddCombiDomain();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

var options = new RewriteOptions()
    .Add(Rewrites.DoNotRedirectFilesOrApi)
    //.AddRewrite(@"areas/(.*)/(.*)", "/areas/$1/index.html", skipRemainingRules: true)
    .AddRewrite(@".*", "/index.html", skipRemainingRules: true);

app.UseRewriter(options);

//app.UseHttpsRedirection();
app.UseDefaultFiles();
app.UseStaticFiles();


app.UseAuthorization();



app.MapControllers();


app.Run();
