# Rocket Infused Chicken Draft Simulator

This project is being used to develop a real working application in realtime, exploring the various different elements and pitfalls of developing an application.

## Purpose of the application

The application is just intended to simulate the act of drafting. The user should be able to select the set they want to draft, how many people they want to simulate drafting with, then press go. The application should then show them a screen that allows them to see the draft cards & see what cards they've already put in their deck.

## Project milestones

0. Project Overview

The first thing we should do first is make sure we have an idea of what we're trying to build.

1. Initial Commit

The creation of the project, adding to source control and ensuring that it's pushed onto GitHub.

This step involves:

* Initialising a Git repository.
* Configuring the git config and remotes.
* Creating a new .NET Core MVC application
* Adding any initial resources that are available.

2. Basic look and feel

Let's first get the application looking kinda good, then we can work on adding the functionality from there. We'll only be creating two pages initially, a homepage which will act as a menu for selecting which set you want to draft, and the drafting page itself. For the large part, we'll be using HTML, CSS, C# and various .NET Core MVC syntax.

3. Building the database

Once we've got a front-end, it's time to dive straight to the back end an plan out the database schema. For this, we'll refer to the section in this document explaining what the application will do and work out what we need to store. We'll be integrating with SQL Server, using .NET Core and Entity Framework (EF) Core as an ORM.

4. Populating the initial datastore

This is the first major undertaking for the server-side code. We'll be implementing an enpoint that we can call which will allow us to call the Magic the Gathering API and bring back all the information we need and store it for whatever set we want. For this we'll be using .NET Core and C# quiet heavily. We'll also be using an application called Postman which allows us to write API calls and see them in action easier.

5. Everything else

It's difficult to determine the exact order for all the other things that'll come next, and even what bits are required. But as an inidication of how it might progress, these are some of the items that I think would be on the path to completion.

* Creating and storing "The Draft" - Making sure that we have a way of passing packs between imaginary other people, so that in X picks turns, your initial pack is returned to you.
* Generating packs - We need to be able to get a random bunch of cards from a set, but they must be generated as per the pack rules from that set (e.g. Guilds of Ravnica always contains a guild gate).
* Selecting a card - We need a mechanic that takes a card from a pack, in a draft, and puts it into your deck.
* Simulate opponents selecting a card - While it would be fantastic to have a realistic mechanism for this, I think initially we could write this as "select a card at random". If we write it in such a way that it could be improved and extended later to maybe "draft a few cards, then stick to that colour-base", or any other better way of working it out.
* Second & third pack mechanic - Once we've successfully got one pack drafting, we need to then consider how to do multiple additional packs after that.