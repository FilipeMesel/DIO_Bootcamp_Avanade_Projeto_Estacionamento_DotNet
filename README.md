# Sistema de Estacionamento em C#

Este é um simples sistema de estacionamento desenvolvido em C# para simular as operações básicas de um estacionamento, como cadastrar carros, remover carros, listar carros e calcular o valor a ser pago com base no tempo de permanência.

## Funcionamento

O sistema consiste em três principais arquivos:

### `Program.cs`

Este arquivo contém a classe `Program` que controla a execução do sistema. Ele exibe um menu interativo no console onde o usuário pode selecionar diferentes opções:

1. **Cadastrar novo carro**: Permite ao usuário inserir uma nova placa e modelo de carro para ser adicionado ao estacionamento.
2. **Remover carro**: Permite ao usuário remover um carro do estacionamento informando a placa.
3. **Listar carros**: Exibe a lista de carros atualmente no estacionamento.
4. **Limpar cmd**: Limpa o console.
5. **Encerrar o dia**: Encerra a execução do programa.

### `Estacionamento.cs`

Este arquivo contém a definição da classe `Estacionamento`. A classe `Estacionamento` mantém uma lista estática de carros (`Carros`) e permite adicionar (`AddCarro`) e remover (`RemoverCarro`) carros desta lista.

### `Carro.cs`

Este arquivo contém a definição da classe `Carro`. Cada instância da classe `Carro` representa um carro com atributos como placa, modelo e hora de entrada.

## Como Rodar

Para executar este projeto localmente, siga estas etapas:

1. Clone este repositório em sua máquina local:
   ```bash
   git clone https://github.com/seu-usuario/nome-do-repositorio.git
   ```

2. Abra o terminal (ou prompt de comando) na pasta raiz do projeto.

3. Execute o comando para rodar o projeto:
   ```bash
   dotnet run
   ```
4. Siga as instruções exibidas no console para interagir com o sistema.

## Requisitos
Certifique-se de ter o .NET SDK instalado em sua máquina para compilar e executar o projeto.