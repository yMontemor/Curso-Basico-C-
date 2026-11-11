# Curso de C# - Fundamentos e Prática

Repositório de estudos práticos em **C# (.NET 10.0)** acompanhando a trilha de introdução à linguagem, tipos de dados, manipulação de strings, operações matemáticas e uso da Biblioteca de Classes do .NET.

---

## 🛠️ Tecnologias e Pré-requisitos

- **Linguagem:** C#
- **Framework:** .NET 10.0 (`net10.0`)
- **Tipo de Projeto:** Aplicação de Console (`Exe`)

---

## 📚 Conteúdo Desenvolvido até Agora

Todo o código prático encontra-se no arquivo [`Program.cs`](./Program.cs), organizado por aulas e módulos:

### 1. Módulo 1 — Introdução ao C#
- Diferença entre `Console.WriteLine()` (imprime e pula linha) e `Console.Write()` (imprime na mesma linha).
- **Desafio 1:** Impressão de múltiplas linhas no console.

### 2. Módulo 2 — Tipos de Dados e Variáveis em C#
- **Literais e Tipos Primitivos:**
  - `char` (aspas simples, ex.: `'b'`)
  - `string` (aspas duplas, ex.: `"Gabriel"`)
  - `int` (números inteiros, ex.: `42`)
  - `decimal` (números com ponto flutuante de alta precisão usando o sufixo `m`, ex.: `12.3m`)
  - `bool` (valores lógicos `true` e `false`)
- **Variáveis Tipadas Explicitamente:** Declaração, atribuição e reatribuição de valores (`string`, `int`).
- **Variáveis de Tipo Implícito (`var`):** Inferência automática de tipos pelo compilador com base no valor atribuído.
- **Desafio 2:** Exibição de uma mensagem combinando múltiplas variáveis (`nome`, `number`, `temperatura`).

### 3. Módulo 3 — Formatação e Concatenação de Strings
- **Sequências de Escape:** Uso de tabulação (`\t`) e quebra de linha (`\n`).
- **Concatenação de Strings:** União de variáveis e textos utilizando o operador `+`.
- **Interpolação de Strings:** Uso do prefixo `$` com expressões entre chaves `{}` e formatação numérica (ex.: `{celsius:F1}`).

### 4. Módulo 4 — Operações Básicas em Números
- **Operadores Aritméticos:** Adição (`+`), subtração (`-`), multiplicação (`*`), divisão inteira e decimal (`/`) e módulo/resto da divisão (`%`).
- **Precedência de Operadores:** Uso de parênteses `()` para priorizar somas numéricas antes da concatenação com strings.
- **Operadores de Atribuição Composta e Incremento/Decremento:**
  - `+=` e `-=`
  - Incremento (`++`) e decremento (`--`)
  - Diferença entre **pós-incremento** (`valor++`) e **pré-incremento** (`++valor`).
- **Exercício Prático:** Conversão de temperatura de Fahrenheit para Celsius (`(fahrenheit - 32) * 5 / 9`) com saída formatada.

### 5. Módulo 5 — Chamada de Métodos da Biblioteca de Classes do .NET (Em andamento)
- Instanciação da classe `Random` (`new Random()`).
- Simulação de lançamento de um dado de 6 lados com o método `dice.Next(1, 7)`.

---

## ▶️ Como Executar o Projeto

No terminal, dentro da pasta raiz do projeto (`CursoC#`), execute:

```bash
dotnet run
```

Para apenas compilar o projeto sem executá-lo:

```bash
dotnet build
```

---

## 📂 Estrutura do Projeto

```text
CursoC#/
├── CursoC#.csproj   # Configuração do projeto .NET 10.0
├── Program.cs       # Código-fonte com os exemplos e desafios dos módulos 1 a 5
└── README.md        # Documentação do projeto
```
