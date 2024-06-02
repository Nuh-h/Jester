# Jester

A web app created to demonstrate and explore the development of enterprise-like applications.

With previous self-taught experience, I return with an ambitious attempt to revive my Back End skills and finally put to bed blockers I encountered when I had no commercial experience of any kind.

It has been a thrilling few days so far building this, and I am hugely excited to be building and growing along with this challenge.

This is part of my journey towards full stack (.NET and Javascript-based front ends).

# Demo

I'll try to add a video here later.

<!-- [Watch this preview](./Demo/Demo%20(FE)%202024-05-26.mp4) -->

You can also build it yourself, see below for details.

# Build it yourself

This is an ASP.NET Core project, you'll need .NET SDK at a minimum, and optionally VS Code.

You can clone the repo as usual but you will need a `postgreSQL` instance running. You can update credential details on `appsettings.{environment}.json` files. I recommend using docker for installing the db, just make sure you expose to the same network as the app (usually, your host machine).

Feel free to swap out PostgresSQL for other ORMs that EF Core supports.

## Features

- [x] Getting data and showing all
- [x] Searching for particular news
- [x] Paginating results
- [x] Hyperlinking (for content, authors, tags, categories)
- [x] Content pages (to read full)
- [x] Adding "related articles" view component (delightful!) Learn about adding TagHelpers! +1
- [x] Dockerise so it can be deployed to _free_ hosts other than Azure
- [ ] Connecting to other docker a pain unless you can provide server ip directly (fine in prod as can be injected via env vars)
- [x] Update pagination count
- [ ] Setup tailwindcss
- [x] Update pagination UI
- [x] Extend view component to accept author and maybe other tags
- [ ] When editing / creating, enable option to dump json in one go
- [ ] Set up WYSIWYG editor page for each article
- [ ] Reactions
- [ ] Filtering results
- [ ] Restful API endpoints
- [ ] Add Swagger
- [ ] Database indexes
- [ ] Caching
- [ ] Error handling and pages
- [ ] Testing
- [ ] Notifications
- [ ] Authentication and Authorisation
- [ ] Analytics dashboard
- [ ] Maybe Admin Panel

## Release checklist

- [x] Prepare dockerfile
- [x] Test locally
- [x] Setup accounts on Railway and Supabase
- [x] Initialise
- [x] Deploy code to git
- [x] Let Railway do its thing
- [x] Test Supabase connection
- [x] Generate Railway domain
- [ ] App is live 🚀
        
    - [x] Fix issue with port (fixed by adding PORT var to railway)
    - [x] Fix issue with connection string (fixed by correcting env var name on railway)
    - [ ] Fix issue with seeding file not being available on the prod workdir

