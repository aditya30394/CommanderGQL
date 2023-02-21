## GraphQL API with .NET 6 and Hot Chocolate

A project showing how to build a GraphQL API using C# and Hot Chocolate.

GraphQL is a query language for APIs and a runtime for fulfilling those queries with your existing data. GraphQL provides a complete and understandable description of the data in your API, gives clients the power to ask for exactly what they need and nothing more, makes it easier to evolve APIs over time, and enables powerful developer tools.

### GraphQL vs REST

#### REST

* Multiple endpoints for different data type
* Chained requests to get the data we need
* Over-fetch: We get more information from what we need.
* Under-fetch: we get less data so we need to make a lot of requests to get the info

#### GraphQL

* One Endpoint
* One Request with different mapping
* No Over-fetch
* No Under-fetch
* Type System
* Predictable

### When to use it

#### REST

* Non-Interactive (System to System)
* Microservices
* Simple Object Hierarchy
* Repeated Simple queries
* Easier to develop
* more complex to consume by clients

#### GraphQL

* real time applications
* mobile applications
* complex object hierarchy
* complex query
* Complicated to develop
* Easier to consume by clients

Original Source : 
1. https://www.youtube.com/watch?v=HuN94qNwQmM
2. https://dev.to/moe23/net-5-api-with-graphql-step-by-step-2b20
3. https://graphql.org/
