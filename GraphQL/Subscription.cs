using Commander.Models;

namespace CommanderGQL.GraphQL
{
    public class Subscription
    {
         [Subscribe]  
         [Topic]
         public Platform OnPlatformAdded([EventMessage] Platform platform)
         {
            return platform;
         } 
    }
}