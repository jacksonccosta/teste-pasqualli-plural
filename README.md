## README.md

##TESTE PRÁTICO - JACKSON COSTA

### Descrição da Aplicação

Esta é uma aplicação web full-stack desenvolvida para demonstrar a integração entre um backend em ASP.NET Core e um frontend em Angular. A aplicação exibe uma lista de pessoas com funcionalidades de paginação e filtro, permitindo uma navegação eficiente e uma experiência de usuário aprimorada.

### Arquitetura

A aplicação segue uma arquitetura cliente-servidor, com responsabilidades bem definidas entre o frontend e o backend:

*   **Frontend (Angular 17):** Responsável pela interface do usuário e interação. Utiliza componentes para modularidade, serviços para lógica de negócios e comunicação com o backend, e o Angular Router para navegação entre visualizações.
*   **Backend (ASP.NET Core):** Responsável por fornecer os dados através de uma API RESTful. Segue uma arquitetura em camadas, com Controllers para lidar com as requisições HTTP, Services para a lógica de negócios (embora neste exemplo simples, a lógica está no controller), e Models para representar os dados.

### Padrões de Projeto e Design Patterns

Durante o desenvolvimento desta aplicação, diversos padrões de projeto e design patterns foram aplicados para garantir um código organizado, manutenível e escalável:

**Frontend (Angular):**

1.  **Component-Based Architecture:** O Angular por si só é construído sobre o conceito de componentes, promovendo a reutilização e a separação de preocupações. Cada parte da interface do usuário é um componente independente.
2.  **Dependency Injection (DI):** O Angular utiliza DI extensivamente para fornecer dependências (como serviços) aos componentes. Isso facilita a testabilidade e a modularidade.
3.  **Observer Pattern (via RxJS):** O Angular utiliza RxJS para lidar com operações assíncronas e fluxos de dados. Observables e Observers são centrais para a comunicação entre componentes e serviços, especialmente para lidar com respostas de API e eventos do usuário.
4.  **Singleton Pattern:** Serviços em Angular são, por padrão, singletons quando injetados no root injector. Isso garante que haja apenas uma instância de um serviço compartilhada por toda a aplicação, o que é útil para gerenciar estado global e compartilhar dados.

**Backend (ASP.NET Core):**

1.  **MVC (Model-View-Controller) / API Endpoints:** Embora seja uma API REST e não uma aplicação MVC tradicional com views renderizadas no servidor, os princípios do MVC são aplicados. Os Controllers lidam com as requisições HTTP, os Models representam os dados e a lógica de negócios (neste caso, simples) reside nos controllers ou poderia ser movida para Services em aplicações maiores.
2.  **Repository Pattern (Conceitual):** Embora não implementado com interfaces e classes separadas neste exemplo simples devido à natureza mockada dos dados, a ideia de abstrair o acesso aos dados é fundamental. Em uma aplicação real com banco de dados, o Repository Pattern seria usado para encapsular a lógica de acesso aos dados, promovendo a separação de interesses e facilitando testes e manutenção.
3.  **Dependency Injection (DI):** O ASP.NET Core possui um sistema de DI robusto e integrado. As dependências são injetadas nos construtores das classes, promovendo baixo acoplamento e alta coesão.

**Geral:**

1.  **RESTful API Design:** A comunicação entre o frontend e o backend segue os princípios REST, utilizando verbos HTTP (GET, POST, PUT, DELETE) e status codes padronizados para representar operações e seus resultados.

### Tecnologias Utilizadas

*   **Frontend:**
    *   Angular 17
    *   TypeScript
    *   HTML5
    *   CSS3 / SCSS
    *   Bootstrap 5 (ou a versão utilizada)
*   **Backend:**
    *   .NET 7 (ou a versão utilizada)
    *   ASP.NET Core Web API
    *   C#
*   **Ferramentas de Desenvolvimento:**
    *   Visual Studio Code (ou outra IDE de preferência)
    *   Node.js e npm (para o frontend)
    *   .NET SDK (para o backend)
    *   Git (para controle de versão)

### Instruções de Execução

**Pré-requisitos:**

*   Node.js e npm instalados
*   .NET SDK instalado
*   Git instalado (opcional, para clonar o projeto)

**Passos para Execução:**

1.  **Clonar o repositório (se aplicável):**
    ```bash
    git clone https://github.com/jacksonccosta/teste-pasqualli-plural.git
    cd teste-pasqualli-plural
    ```

2.  **Executar o Backend (ASP.NET Core API):**
    ```bash
    cd backend # Navegue até a pasta do backend
    dotnet run
    ```
    Por padrão, a API estará disponível em `http://localhost:5000` ou `https://localhost:5001`.

3.  **Executar o Frontend (Angular):**
    Abra um novo terminal.
    ```bash
    cd frontend # Navegue até a pasta do frontend
    npm install # Instala as dependências (apenas na primeira vez)
    ng serve -o
    ```
    A aplicação Angular será aberta automaticamente no seu navegador, geralmente em `http://localhost:4200`.

Com esses passos, a aplicação estará rodando localmente e pronta para ser utilizada.

