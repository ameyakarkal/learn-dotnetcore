# startup

> Simple api to learn dotnet core on the mac side using visual studio code

## setup project

``` bash
  dotnet --version
  // returns 2.1.105
```

```bash
  dotnet new webapi -n api
  /*
    webapi : template
    api : name of the project
  */
```

run project

```bash
  dotnet build [path to api.csproj]
  dotnet run --evnironment Development --project startup/api/api.csproj
```
