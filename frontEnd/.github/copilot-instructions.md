<!-- Instruções concisas para agentes de código (Copilot / AI) -->
# Copilot instructions — FullStack-Files (português)

Objetivo: ajudar agentes a serem produtivos rapidamente neste repositório de exercícios front-end (HTML/JS estático).

1. Big picture
- Projeto: coleção de aulas (`aula01..aula20`) com exemplos e exercícios em HTML/JavaScript. Não há build system ou dependências externas declaradas.
- Fluxo de dados: páginas estáticas executadas no navegador; interações feitas via DOM/`document.write` ou `console`.

2. Estrutura e pontos importantes
- `aula04/varLetConst.js`: exemplo de migração de `var` → `let`/`const` e escopo de bloco.
- `helloWorld/helloworld.js`: padrões de uso de `const` para strings imutáveis.
- `aula05/*.html` e `aula18/exerciciosMetodosArrays/`: conjuntos de exercícios que devem manter enunciados e estrutura pedagógica.

3. Convenções do projeto (observáveis nos arquivos)
- Preferir `const` para valores imutáveis e `let` para variáveis que mudam; evitar `var`.
- Os arquivos já incluem `;` no final das declarações: preserve esse estilo ao editar.
- Nomes de variáveis em minúsculas e descritivos (ex.: `n1`, `n1Local`, `saudacao`).
- Evitar remover enunciados/`prompt`s em exercícios — objetivo é corrigir bugs mantendo a intenção pedagógica.

4. Workflows e comandos úteis
- Não há build; abra arquivos HTML diretamente no navegador ou use um servidor estático:

  - Python 3 (terminal):
    ```bash
    python -m http.server 8000
    ```

  - VS Code: usar extensão "Live Server" para testar páginas locais.

5. Debugging e verificação
- Usar DevTools do navegador (Console, Sources) para executar e inspecionar `*.js`.
- Preferir `console.log` ou breakpoints em vez de mudanças massivas nos exercícios.

6. Áreas a preservar ao editar
- Ao corrigir variaveis, escopos, functions e etc, siga estas regras:
   1. os nomes descritivos das variáveis devem ser em português e em letras minúsculas, em funções devem ser palavras que são ações (ex.: `n1`, `saudacao`).
  2. Manter o uso de `const` para valores que não mudam e `let` para os que mudam.
  3. Evitar o uso de `var`
  4. Manter o uso de `;` no final das declarações.
- Não remover conteúdo do enunciado dos exercícios em `aulaXX`.
- Ao corrigir, aplique mudanças mínimas que resolvam o problema (ex.: renomear variável para evitar redeclaração em `aula04/varLetConst.js`).

7. Exemplos rápidos (como citar no PR)
- "Corrige hoisting/rededclaração em `aula04/varLetConst.js`: substitui `var` por `let` e renomeia `n1` local para `n1Local`."
- "Padroniza `const` em `helloWorld/helloworld.js` para valores imutáveis."

8. O que NÃO fazer
- NÃO adicionar ferramentas de build ou dependências sem orientação do mantenedor.
- NÃO apagar enunciados ou exemplos pedagógicos ao limpar código.

Se algo estiver ambíguo (ex.: intenção de um exercício), pergunte antes de aplicar mudanças invasivas.

-- Fim --
