using System.Data;
using CommanderGQL.Data;
using CommanderGQL.GraphQL;
using CommanderGQL.GraphQL.Platforms;
using GraphQL.Server.Ui.Voyager;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;

builder.Services.AddControllers();
builder.Services.AddPooledDbContextFactory<AppDbContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("CommandConStr")));

builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .AddType<PlatformType>()
    .AddType<CommanderGQL.GraphQL.Commands.CommandType>()
    .AddFiltering()
    .AddSorting();

var environment = builder.Environment;

var app = builder.Build();

if(environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

//app.UseHttpsRedirection();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGraphQL();
});

app.UseGraphQLVoyager("/graphql-voyager",
new VoyagerOptions()
{
    GraphQLEndPoint = "/graphql",
});

app.Run();