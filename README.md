# Drinks Web API

This is a C# solution for a simple drinks web API. The API has the following endpoints:

| Action | Endpoint         | Success Response                                 |
| ------ | ---------------- | ------------------------------------------------ |
| `GET`  | `/`              | `Welcome to the Drinks API!`                     |
| `GET`  | `/coffee/lover`  | `I like coffee!`                                 |
| `GET`  | `/coffee/{name}` | `{"name":`_{name}_`,"id":`_auto-increment-id_`}` |
| `GET`  | `/coffee`        | `{"name":"latte","id":-1}`                       |

### Local Base URL

If you run this application locally, then the **base URL** is [http://localhost:5143/](http://localhost:5143/).

(For example, [http://localhost:5143/coffee](http://localhost:5143/coffee))

### Remote Base URL (on Heroku)

Alternatively, you can simply go to [https://francochanco-drinkswebapi.herokuapp.com/](https://francochanco-drinkswebapi.herokuapp.com/) as **base URL**, without having to run anything locally.

(For example, [https://francochanco-drinkswebapi.herokuapp.com/coffee](https://francochanco-drinkswebapi.herokuapp.com/coffee))

# Instructions for running locally

**Prerequisite**: The machine running the application should have [.NET 6.0](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) (or above) installed.

To run the application:

1. clone the repository to your computer
2. then navigate to the `API Interactive Lab 1` folder (with `cd` command or otherwise)
3. then run the following command

```c#
dotnet run
```
