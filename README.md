# FAC-DOTNET-Workshop-Week2

Link here [ASP.NET Challenge](https://github.com/foundersandcoders/DOTNET-Workshop)

# ASP.NET Challenge

Practice using ASP.NET to create and manage routes in a web application.

## Setup

Make sure you have Git and .NET SDK (v6.0) installed.

1. clone your copy, and cd into it
2. Run `dotnet restore` to install all the dependencies
3. Run `dotnet run` to start the server should be fairly similar to how the last workshop ended but it has persisting database memory now.

This app already has a working API but the file that should test the games controller (Test.Api.Tests\Controllers\GamesControllerTest.cs) is empty. You will have to tweak the API by adding dependency injections to get testing to work as well as writing the test file ( hint use moq ).

## Checking your work

run dotnet test and if everything is good the tests should pass

## Challenge 1: Test the get request method

Set up a interface and moq to allow the tests to run tests on the functions without altering your database. The original project should also still be able to run. This is complicated enough that one challenge is enough.
