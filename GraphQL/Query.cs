using Commander.Models;
using CommanderGQL.Data;

namespace CommanderGQL.GraphQL
{
    public class Query
    {
        public IQueryable<Platform> GetPlatform([Service] AppDbContext context)
        {
            return context.Platforms;
        }
    }
}