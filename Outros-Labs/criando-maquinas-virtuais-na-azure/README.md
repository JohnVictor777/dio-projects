# Desafio DIO: Criando Máquinas Virtuais na Azure

Este repositório documenta a experiência e o aprendizado no desafio de **Criar Máquinas Virtuais (VMs) na Microsoft Azure**. O objetivo principal foi consolidar conhecimentos sobre a infraestrutura de VMs na nuvem, aplicando conceitos aprendidos e registrando o processo de forma clara e estruturada.

---

### Descrição do Desafio

Este laboratório visa aprofundar os conhecimentos em máquinas virtuais da Azure. O desafio proposto requer a aplicação dos conceitos abordados nas aulas e a documentação detalhada da experiência, com o intuito de demonstrar a compreensão dos temas discutidos.

### Objetivos de Aprendizagem

Ao final deste desafio, você será capaz de:

* **Aplicar os conceitos aprendidos** em um ambiente prático (mesmo que teórico, devido a limitações de recursos).
* **Documentar processos técnicos** de forma clara e estruturada.
* **Utilizar o GitHub** como ferramenta para compartilhamento de documentação técnica.

### Conceitos Abordados e Passos Teóricos para a Criação de VMs

A criação de uma máquina virtual no Azure envolve uma série de configurações cruciais para garantir seu funcionamento, segurança e otimização de custos. Baseando-me nas vídeo aulas e na documentação oficial, o processo teórico seguiria as seguintes etapas:

1.  **Grupo de Recursos:** Iniciaria criando um **Grupo de Recursos** (Resource Group) para organizar todos os recursos relacionados à VM (VM em si, disco, interface de rede, IP público, etc.). Isso facilita o gerenciamento e a exclusão futura dos recursos.

2.  **Detalhes da Instância:**
    * **Nome da Máquina Virtual:** Definiria um nome claro e identificável para a VM.
    * **Região:** Selecionaria a região geográfica mais próxima ou adequada para minimizar latência.
    * **Opções de Disponibilidade:** Avaliaria a necessidade de redundância, como Conjuntos de Disponibilidade ou Zonas de Disponibilidade, para garantir alta disponibilidade.
    * **Imagem (Sistema Operacional):** Escolheria a imagem do sistema operacional, por exemplo, "Windows Server 2019 Datacenter".
    * **Tamanho:** Selecionaria o tamanho da VM (ex: `Standard_B2s`), que define a quantidade de vCPUs, memória e armazenamento temporário, impactando diretamente o desempenho e o custo.

3.  **Conta de Administrador:** Criaria um nome de usuário e uma senha robusta para acessar a VM. Para máquinas Linux, optaria por autenticação via chave SSH.

4.  **Regras de Porta de Entrada:** Configuraria as portas que permitiriam o acesso externo à VM. Para um servidor Windows, a porta **RDP (3389)** seria permitida para acesso remoto. Em cenários de produção, restringiria o acesso RDP a IPs específicos.

5.  **Discos:**
    * **Tipo de Disco OS:** Selecionaria o tipo de disco para o sistema operacional (ex: **SSD Premium** para desempenho, **SSD Standard** para custo-benefício).
    * **Discos de Dados:** Adicionaria discos de dados se necessário, definindo seus tamanhos e tipos.

6.  **Rede:**
    * **Rede Virtual (VNet) e Sub-rede:** Configuraria uma **Rede Virtual (VNet)** e uma **Sub-rede** para a VM, garantindo o isolamento e a organização da rede.
    * **IP Público:** Atribuiria um **IP Público** à VM para que ela fosse acessível via internet.
    * **Grupo de Segurança de Rede (NSG):** Configuraria um **NSG** para atuar como um firewall de rede, controlando o tráfego de entrada e saída, complementando as regras de porta definidas anteriormente.

7.  **Gerenciamento, Monitoramento e Tags (Opcional):**
    * Habilitaria o **Diagnóstico de Inicialização** para solucionar problemas de boot.
    * Configuraria o **Desligamento Automático** para otimizar custos.
    * Adicionaria **Tags** para organização e gerenciamento de custos.

8.  **Revisar e Criar:** Por fim, revisaria todas as configurações para garantir que tudo estivesse conforme o planejado e iniciaria a criação da VM.

### Reflexões e Aprendizados

Apesar da impossibilidade de executar as etapas na prática devido à limitação de créditos, este desafio foi fundamental para aprofundar a compreensão sobre o ciclo de vida de uma VM no Azure. Percebi a importância de cada detalhe, desde o planejamento do grupo de recursos até as configurações de rede e segurança. A documentação teórica reforçou a necessidade de um bom planejamento antes da implantação real para garantir performance, segurança e otimização de custos.

### Recursos Úteis

* **Início Rápido: Criar uma máquina virtual do Windows no Portal do Azure** - [Artigo no Microsoft Learning](https://learn.microsoft.com/pt-br/azure/virtual-machines/windows/quick-create-portal)
* **GitHub Quick Start** - [Repositório com Link para Aulas de Git e GitHub](https://github.com/digitalinnovationone/github-quick-start)
* **GitBook: Formação GitHub Certification** - [Material textual sobre GitHub](https://www.gitbook.com/book/digitalinnovationone/formacao-github-certification/details)
* **Documentação do GitHub** - [Guia completo para uso do GitHub](https://docs.github.com/pt)
* **GitHub Markdown** - [Guia específico para Markdown no GitHub](https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax)
