# Drinks Web API

This is a C# solution for a simple drinks web API. The API has the following endpoints:

| Action | Endpoint                              | Success Response                                 |
| ------ | ------------------------------------- | ------------------------------------------------ |
| `GET`  | `http://localhost:5143/`              | `Welcome to the Drinks API!`                     |
| `GET`  | `http://localhost:5143/coffee/lover`  | `I like coffee!`                                 |
| `GET`  | `http://localhost:5143/coffee/{name}` | `{"name":`_{name}_`,"id":`_auto-increment-id_`}` |
| `GET`  | `http://localhost:5143/coffee`        | `{"name":"latte","id":-1}`                       |

# Instructions

**Prerequisite**: The machine running the application should have [.NET 6.0](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) (or above) installed.

To run the application:

1. clone the repository to your computer
2. then navigate to the `API Interactive Lab 1` folder (with `cd` command or otherwise)
3. then run the following command

```c#
dotnet run
```
