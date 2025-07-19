# Desafio DIO: Configurando uma Instância de Banco de Dados na Azure

Este repositório documenta o aprendizado e as etapas teóricas para a **configuração de uma instância de Banco de Dados na Microsoft Azure**. O desafio teve como foco consolidar os conhecimentos sobre serviços de Banco de Dados como serviço (PaaS), praticando o processo de configuração e documentando as principais informações.

---

### Descrição do Desafio

Este laboratório visa praticar o processo de configuração de uma instância de Banco de Dados na plataforma Microsoft Azure. O entregável proposto é a criação de um repositório contendo resumos, anotações e dicas sobre o uso da Azure, servindo como material de apoio para estudos e futuras implementações.

### Objetivos de Aprendizagem

Ao final deste desafio, você será capaz de:

* **Aplicar os conceitos aprendidos** em um ambiente prático (mesmo que teórico, devido a limitações de recursos).
* **Documentar processos técnicos** de forma clara e estruturada.
* **Utilizar o GitHub** como ferramenta para compartilhamento de documentação técnica.

### Conceitos Abordados e Passos Teóricos para a Configuração de Banco de Dados (Azure SQL Managed Instance)

A configuração de uma instância de Banco de Dados como serviço (PaaS) no Azure simplifica a gestão e oferece alta disponibilidade e escalabilidade. Baseando-me nas aulas e na documentação oficial, o processo teórico para uma **Instância Gerenciada de SQL do Azure** seguiria as seguintes etapas:

1.  **Seleção do Serviço:** No Portal do Azure, navegaria até a opção "Instância Gerenciada de SQL do Azure" ou "Banco de Dados SQL" dependendo do nível de gerenciamento e funcionalidades desejadas (a Instância Gerenciada é mais próxima de um SQL Server local).

2.  **Detalhes Básicos:**
    * **Assinatura e Grupo de Recursos:** Selecionaria a assinatura Azure e criaria/selecionaria um **Grupo de Recursos** para organizar os recursos do banco de dados.
    * **Nome da Instância Gerenciada:** Definiria um nome único e significativo para a instância.
    * **Região:** Escolheria a região geográfica ideal para a instância.

3.  **Rede:** Este é um passo crucial para Instâncias Gerenciadas, que requerem uma **Rede Virtual (VNet)** e uma **Sub-rede dedicada** para garantir isolamento e segurança de rede. Eu criaria uma nova VNet ou usaria uma existente, configurando a sub-rede corretamente.

4.  **Cálculo e Armazenamento:**
    * **Camada de Serviço:** Escolheria a camada de serviço que melhor atendesse aos requisitos de workload (ex: **Propósito Geral** para cargas de trabalho comuns, **Comercialmente Crítico** para alta performance e disponibilidade).
    * **Gerações de Hardware:** Selecionaria a geração de hardware (ex: Gen5) para otimizar o desempenho.
    * **vCores:** Definiria o número de vCores, que impacta diretamente a capacidade de processamento.
    * **Armazenamento:** Especificaria o tamanho do armazenamento necessário para os dados do banco de dados.

5.  **Segurança:**
    * **Tipo de Autenticação:** Configurar o modo de autenticação (ex: Autenticação SQL, Autenticação do Azure AD).
    * **Firewall (para Azure SQL Database):** Se fosse um Azure SQL Database (não Instância Gerenciada), configuraria as regras de firewall para permitir o acesso de IPs específicos ou serviços do Azure. Para Instância Gerenciada, o controle é mais granular via VNet.
    * **Defender para SQL:** Habilitaria esta funcionalidade para detecção de ameaças e vulnerabilidades.

6.  **Configurações Adicionais:**
    * **Collation:** Definiria a ordenação padrão para a instância.
    * **Configurações de Fuso Horário:** Ajustaria o fuso horário da instância.
    * **Manutenção:** Configuraria as janelas de manutenção.

7.  **Revisar e Criar:** Revisaria todas as configurações para confirmar que estão alinhadas aos requisitos e, em seguida, iniciaria o processo de criação da instância.

### Dicas e Anotações para Implementações Futuras

* **Planejamento de Rede é Fundamental:** Especialmente para Instâncias Gerenciadas, a arquitetura de rede (VNet e sub-redes) deve ser bem planejada antecipadamente.
* **Segurança em Camadas:** Utilize não apenas o firewall, mas também Azure AD authentication, TDE (Transparent Data Encryption) e Azure Defender para SQL para uma proteção robusta.
* **Monitoramento Ativo:** Configure o monitoramento e alertas para acompanhar o desempenho, o uso de recursos e a saúde da instância.
* **Otimização de Custos:** Monitore o uso e ajuste a camada de serviço, vCores e armazenamento conforme a demanda para evitar gastos desnecessários.
* **Backups:** Compreenda a política de backup automático do Azure e saiba como realizar restaurações pontuais.

### Recursos Úteis

* **Início Rápido: criar Instância Gerenciada de SQL do Azure** - [Artigo no Microsoft Learning](https://learn.microsoft.com/pt-br/azure/azure-sql/managed-instance/instance-create-quickstart?view=azuresql&tabs=azure-portal)
* **GitHub Quick Start** - [Repositório com Link para Aulas de Git e GitHub](https://github.com/digitalinnovationone/github-quick-start)
* **GitBook: Formação GitHub Certification** - [Material textual sobre GitHub](https://www.gitbook.com/book/digitalinnovationone/formacao-github-certification/details)
* **Documentação do GitHub** - [Guia completo para uso do GitHub](https://docs.github.com/pt)
* **GitHub Markdown** - [Guia específico para Markdown no GitHub](https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax)
