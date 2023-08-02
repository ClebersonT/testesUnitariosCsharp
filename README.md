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

Para simplificar o processo de desenvolvimento, estou utilizando o plugin "C# Extensions" para o VS Code.

Instanciei a classe calculadora dentro de program.cs e realizei o build com o comando:

```sh
$ cd Calculadora
$ dotnet run
$ 5 + 10 = 15
```

### Executando os Testes

Basta entrar na pasta "CalculadoraTestes" e executar:

```sh
$ dotnet test
```

Saida:

> Iniciando execução de teste, espere...
> 1 arquivos de teste no total corresponderam ao padrão especificado.
> <font color="green"> Aprovado!  - Com falha:     0, Aprovado:     1, 
> Ignorado:     0, Total:     1, Duração: < 1 ms </font> - CalculadoraTestes.dll
(net6.0)

