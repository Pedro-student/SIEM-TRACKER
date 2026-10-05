SiemTracker
Um sistema SIEM (Security Information and Event Management) customizado, construído com foco em Arquitetura Web, .NET e boas práticas de engenharia de software.
Status do projeto: Em desenvolvimento ativo / Passível de alterações estruturais e visuais.
Sobre o Projeto
O SiemTracker foi criado com um objetivo principal: treinar e consolidar conceitos avançados de Arquitetura Web e Clean Architecture. Em vez de focar apenas em scripts isolados, o projeto foi estruturado para simular um ambiente real de monitoramento de segurança (SOC), separando responsabilidades de forma limpa entre Domínio, Aplicação, Infraestrutura, API e uma interface front-end customizada.
Nota sobre o desenvolvimento: Este projeto foi construído e iterado com o auxílio de Inteligência Artificial, utilizada como ferramenta de mentoria, co-programação e apoio na resolução de problemas estruturais e de compilação.
Arquitetura e Tecnologias
O projeto segue os princípios de Clean Architecture, dividido nas seguintes camadas:
SiemTracker.Domain: Entidades centrais de negócios (LogEvent, SecurityAlert).
SiemTracker.Application: Contratos, interfaces (ILogRepository) e regras de aplicação.
SiemTracker.Infrastructure: Persistência de dados com Entity Framework Core e SQLite (SiemDbContext, LogRepository).
SiemTracker.Api: Controladores RESTful (LogsController), injeção de dependência e configuração de CORS.
SiemTracker.Client: Painel front-end estático (dashboard estilo SOC) construído em HTML/JS puro para ingestão e visualização de logs.
Pontos Aprendidos e Desafios Superados
Durante o desenvolvimento do SiemTracker, diversos conceitos práticos foram consolidados:
Clean Architecture na prática: Isolamento de regras de negócios, inversão de controle e desacoplamento entre camadas.
Resolução de Conflitos de Namespace e Visibilidade: Compreensão profunda de como o compilador C# lida com referências entre projetos (como a importância correta de modificadores public e o alinhamento de namespaces).
Injeção de Dependência no .NET: Configuração de serviços, tempos de vida e contextos do EF Core no Program.cs.
Comunicação Cliente-Servidor: Configuração de políticas de CORS na API para permitir a integração com um front-end desacoplado.
Persistência Local com SQLite: Mapeamento e gravação assíncrona de eventos de segurança.
Como Executar o Projeto
Clonar o repositório:
git clone https://github.com/seu-usuario/SiemTracker.git
cd SiemTracker
Rodar a API (Backend):
dotnet run --project SiemTracker.Api/SiemTracker.Api.csproj
Abrir o Front-end:
Navegue até a pasta SiemTracker.Client e abra o arquivo index.html diretamente no seu navegador, ou utilize uma extensão de servidor local (como o Live Server no VS Code).
