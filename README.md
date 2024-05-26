# Jester

A web app created to demonstrate and explore the development of enterprise-like applications.

With previous self-taught experience, I return with an ambitious attempt to revive my Back End skills and finally put to bed blockers I encountered when I had no commercial experience of any kind.

It has been a thrilling few days so far building this, and I am hugely excited to be building and growing along with this challenge. 

This is part of my journey towards full stack (.NET and Javascript-based front ends).

# Demo

[Watch this preview](./Demo/Demo%20(FE)%202024-05-26.mp4)

You can also build it yourself, see below for details.

# Build it yourself

This is an ASP.NET Core project, you'll need .NET SDK at a minimum, and optionally VS Code.

You can clone the repo as usual but you will need a `postgreSQL` instance running. You can update credential details on `appsettings.{environment}.json` files. I recommend using docker for installing the db, just make sure you expose to the same network as the app (usually, your host machine).

Feel free to swap out PostgresSQL for other ORMs that EF Core supports.