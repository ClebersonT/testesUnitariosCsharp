## Testes unitarios em C#, utilizando xUnit

Foi criado duas pastas para diferenciar o codigo e o teste em si.

### :grinning: Criando um novo projeto
Acessei a pasta "Calculadora" e executei:

```sh
$ dotnet new console
```

Acessei a pasta "CalculadoraTestes" e executei:
```sh
$ dotnet new xunit
```

### Vamos agrupar esses projetos em uma solution:

para isso... podemos instalar um plugin do VS Code chamado "vscode-solution-explorer" 

ou simplesmente digitar no terminal, dentro da raiz do projeto:
```sh
$  dotnet new sln -n "NomeDaSolution"
```

Você pode adicionar os projetos via plugin ou via terminal...

```sh   
$ dotnet sln "c:\Users\Cleberson\Documents\TestesDio\ModulotestesDIO.sln" add "c:\Users\Cleberson\Documents\TestesDio\CalculadoraTestes\CalculadoraTestes.csproj"

$ dotnet sln "c:\Users\Cleberson\Documents\TestesDio\ModulotestesDIO.sln" add "c:\Users\Cleberson\Documents\TestesDio\Calculadora\Calculadora.csproj"
```

### Adicionando referência do nosso projeto "Calculadora" no projeto "CalculadoraTestes"

mesma coisa, pode-se adicionar via plugin ou via terminal

```sh
 $ dotnet add "c:\Users\Cleberson\Documents\TestesDio\CalculadoraTestes\CalculadoraTestes.csproj" reference "c:\Users\Cleberson\Documents\TestesDio\Calculadora\Calculadora.csproj"
```
