## Pobieranie jednego katalogu z GitHub:

https://download-directory.github.io/


Pobieranie dotnet: https://dotnet.microsoft.com/en-us/download

```console
dotnet --version
dotnet --help
```
## Tworzenie projektu 

```console
dotnet new list //lista możliwych projektów
dotnet new web -o Nazwa-katalogu // pusta aplikacja webowa
dotnet new webapp -o nazwa-katalogu // aplikacja RazorPage
dotnet new mvc -o nazwa-katalogu aplikacja MVC
```
## Uruchamianie apliacji z dotnet
W katalogu w którym jest Program.cs
```console
dotnet run

dotnet new page -n Page3 //tworzenie strony !! W katalogu Pages !!


```
https://learn.microsoft.com/en-us/training/dotnet/