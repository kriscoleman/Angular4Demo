# Angular 4 Demo App (Comic Book Store)

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