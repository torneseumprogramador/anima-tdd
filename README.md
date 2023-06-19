# Documentação dos Comandos

Aqui estão os comandos utilizados durante a aula:

## Criação do diretório e navegação

```shell
mkdir tdd
cd tdd/
```

O comando `mkdir` é usado para criar um diretório chamado "tdd". Em seguida, o comando `cd` é usado para entrar no diretório recém-criado.

## Listagem de arquivos e diretórios

```shell
ls
```

O comando `ls` é usado para listar os arquivos e diretórios presentes no diretório atual.

## Criação de uma solução do projeto

```shell
dotnet new sln
```

O comando `dotnet new sln` é usado para criar uma solução vazia do projeto.

## Abertura do Visual Studio Code

```shell
code .
```

O comando `code .` é usado para abrir o Visual Studio Code no diretório atual.

## Listagem de projetos na solução

```shell
dotnet list
```

O comando `dotnet list` lista os projetos presentes na solução atual.

## Criação de um novo projeto de teste

```shell
dotnet new mstest -o tests
```

O comando `dotnet new mstest -o tests` é usado para criar um novo projeto de teste utilizando o framework MSTest. O parâmetro `-o` especifica o nome da pasta de destino, neste caso, "tests".

## Compilação de um projeto de teste

```shell
cd tests/
dotnet build
```

Os comandos `cd tests/` e `dotnet build` são usados para entrar no diretório do projeto de teste e compilá-lo, respectivamente.

## Execução de testes

```shell
dotnet test
```

O comando `dotnet test` é usado para executar os testes no projeto atual.

## Criação de um novo projeto WebAPI

```shell
dotnet new webapi -o interface_api
```

O comando `dotnet new webapi -o interface_api` é usado para criar um novo projeto WebAPI. O parâmetro `-o` especifica o nome da pasta de destino, neste caso, "interface_api".

## Adição de projetos à solução

```shell
dotnet sln add tests/tests.csproj 
dotnet sln add interface_api/interface_api.csproj 
```

Os comandos `dotnet sln add` são usados para adicionar os projetos de teste e a interface API à solução.

## Compilação e execução de testes na solução

```shell
dotnet build
dotnet test
```

Os comandos `dotnet build` e `dotnet test` são usados para compilar a solução e executar os testes presentes nela.

## Referência entre projetos

```shell
cd tests/
dotnet add reference ../interface_api/interface_api.csproj 
```

Os comandos `cd tests/` e `dotnet add reference` são usados para entrar no diretório do projeto de teste e adicionar uma referência ao projeto da interface API.

## Execução contínua de testes

```shell
dotnet test
```

O comando `dotnet test` é usado para executar os test
