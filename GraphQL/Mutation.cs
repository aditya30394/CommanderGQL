using Commander.Models;
using CommanderGQL.Data;
using CommanderGQL.GraphQL.Commands;
using CommanderGQL.GraphQL.Platforms;
using CommanderGQL.Models;

namespace CommanderGQL.GraphQL
{
    public class Mutation
    {
        [UseDbContext(typeof(AppDbContext))]
        public async Task<AddPlatformPayload> AddPlatformAsync(
            AddPlatformInput input,
            [ScopedService] AppDbContext context,
            CancellationToken cancellationToken)
        {
            var platform = new Platform
            {
                Name = input.Name
            };
            
            context.Platforms.Add(platform);
            await context.SaveChangesAsync(cancellationToken);
            
            return new AddPlatformPayload(platform);
        }

        public async Task<AddCommandPayload> AddCommandAsync(
            AddCommandInput input,
            [ScopedService] AppDbContext context,
            CancellationToken cancellationToken)
        {
            var command = new Command
            {
                HowTo = input.HowTo,
                CommandLine = input.CommandLine,
                PlatformId = input.PlatformId
            };
            
            context.Commands.Add(command);
            await context.SaveChangesAsync(cancellationToken);
            
            return new AddCommandPayload(command);
        }

    }
        
}