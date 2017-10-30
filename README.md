# Angular 4 Demo App (Comic Book Store)

This is a learning project for Angular 4. It is composed of a .Net Web Api backend with an Angular 4 SPA frontend. The site is a simple Comic Book Store, which allows you to view comics and add them to a pull list. 

# Running from a Dev Environment 

To run from a dev environment, debug/run an instance of the api project from your IDE (Visual Studio 2017).

Then from the Web project, run `npm install` to install the dependencies, and `npm start` to serve the web project. You can then access the web project from http://localhost:4200/

# Basics of Angular 2^ Cli

Here are some basics for Angular 2^.

## Setting up a new Angular 4 cli project
In a terminal window from the root of your project folder, enter the following commands: 
```
> npm install -g @angular/cli
> ng new my-app-name
> cd my-app-name
> ng serve
```

## Creating VS solution w/ WebApi backend 
If you want to create a VS solution w/ a WebApi backend, 
you should:
- make a new solution
- add a web api project 
- add a empty project for the angular app
- copy all of the files in the angular cli app folder that you created with the cli to the new empty project folder. 
- from VS, "include" all of the folders/files you copied over. 

## Creating new Modules and Components with angular cli 
You can use the CLI to create new modules and components for you from the terminal. 

To create a new Module: 
- `ng g module newModuleName`

To create a new Component within that Module:
- `cd newModuleName` to change directory into the newModule folder
- `ng g component newComponent` to create a component as a child of the module

From there, you can implement your new module/component. Don't forget to wire up your component to the module, and finally wire up your module to your app. 