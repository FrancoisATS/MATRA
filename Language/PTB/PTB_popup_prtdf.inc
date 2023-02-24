#VERSION 0
;
PTB POPUP HELP
1 "Nenhum tópico de ajuda está associado à este item.":
10 "Este campo é utilizado para identificar a que pedido a peça pertence. Na primeira operação de um pedido, ele é definido como PARENT, nas outras operações, é definido com um número sequencial ou nome único.":
40 "Este campo é usado para identificar o número da peça. Pressionando o botão será mostrado todos os números de peça na tabela de dados de produtos. A seleção de um número de peça mudará automaticamente o nome do produto.":
41 "Esse campo contém uma lista de diferentes status que podem ser definidos para uma Ordem. O valor é capturado da tabela de dados Status da Ordem onde novos status podem ser adicionados.":
45 "Este campo é usado para identificar o número da peça.":
50 "Este campo é usado para identificar o nome do produto. Use o botão para selecionar o nome, o número da peça será automaticamente alterado.":
55 "Este campo é usado para identificar o nome do produto.":
60 "Este campo é usado para identificar o número da Ordem para este produto. A Ordem pode ser um número de uma Ordem interna ou outra especificada pelo cliente. O número da Ordem precisa ser único.":
70 "Este campo pode ser usado para conter comentários sobre o pedido. Pode ser um lembrete sobre datas de entrega ou simplesmente uma mensagem para um montador/embalador do chão de fábrica.":
75 "Abre uma caixa de diálogo que mostra todas as informações de atributos para a operação.":
80 "Use este campo para definir a prioridade para um trabalho que será usado pelo sequenciador (PRS). Quanto menor o número, maior a prioridade. Note que prioridades podem ser negativas.":
90 "Este campo define o número da operação para um trabalho. Isso é usado para sequenciar o trabalho no sequenciador (PRS). Número de operação menores serão terminados antes de números maiores. Se existem duas operações com o mesmo número, então ambas as operações devem ser terminadas para que uma operação com número maior possa começar.":
110 "Esta é uma descrição escrita ou nome da operação que se realiza, também identificado pelo número de operação.":
112 "Abre uma tela que contém informações sobre os dados de recursos atribuídos a esta operação":
120 "Grupos de setups são definidos na tabela de dados Grupos de Setups. Esses valores são usados como eixos das matrizes de Setup Dependente de Sequência, que estabelece o setup entre produtos de diferentes grupos de setup. Setups individuais são alocados a produtos na tabela de dados Produtos, entretanto esse valor será sobrescrito.":
130 "Este campo identifica o grupo de recursos válidos que pode processar a operação atual.":
140 "Se necessário, este campo pode ser usado para identificar um Recurso específico que deve processar a operação. Se na tabela de dados do Produto este campo foi definido como 'Selecionar do Grupo, então qualquer um dos Recursos no grupo de Recursos pode ser usado. Se você quer forçar uma operação a ser sequenciada em um Recurso específico, então selecione um Recurso da lista.":
150 "Esse campo mostra o Recurso que vai processar a operação. Se a Ordem ainda não estiver sequenciada, então este campo será definido como Não Especificado. Se a operação já estiver sido especificado então o Recurso exibido neste campo será o Recurso onde a programação foi programada.":
180 "Esse campo é usado para indicar se a taxa de produção é calculado como tempo por lote, tempo por item ou taxa por hora. Se 'Tempo por Lote' é selecionado então o tempo exibido neste campo é o tempo que leva para processar todas as partes no lote. Se 'tempo por item' é selecionado então o tempo de processo será o valor no campo abaixo multiplicado pelo tamanho do lote. Se 'taxa por hora' é selecionado então o tempo de processo será calculado diretamente do número no lote.":
220 "Você selecionou o Tipo de Tempo de Processo como 'Tempo por Item'. Você precisa de definir um tempo de operação para cada item neste campo.":
230 "Você selecionou o Tipo de Tempo de Processo como 'Tempo por Lote'. Você precisa indicar o tempo total de operação por lote neste campo.":
240 "Você selecionou o Tipo de Tempo de Processo 'Taxa por Hora'. Você necessita especificar quantos itens podem ser produzidos por hora neste campo.":
251 "A cor neste campo instrui o sequenciador a exibir uma parte da barra do gráfico de Gantt com uma cor diferente.":
260 "Este campo é usado para especificar a quantidade da Ordem ou do lote.":
270 "Este campo é usado para especificar o lucro do pedido ou do lote e pode ser usado para influenciar o sequenciamento quando se usa a regra de ponderação.":
280 "Este campo mostra a hora inicial da primeira operação deste pedido quando o recurso MakeSpan está ativado":
290 "Este campo mostra a hora final da última operação deste pedido quando o recurso MakeSpan está ativado":
300 "Este valor determina a quantidade que deve ser processada antes de a operação subsequente poder ser iniciada. Um valor não especificado impede a sobreposição entre operações":
360 "usado para especificar uma data que a Ordem não pode começar antes dela. Como exemplo, essa data pode ser a data onde existirá material disponível para ela.":
370 "Este campo deve ser usado para informar a data de entrega. A data de entrega é usado para realçar os itens atrasados no sequenciador e priorizar o carregamento do trabalho no planejamento se a opção 'data de entrega' é selecionada.":
380 "Selecione este campo para mostrar ao sequenciador que os tempos no Tempo de Início e Tempo de Fim são valores reais. Quando definido, esse campo previne a Ordem de ser desalocada de qualquer Recurso no sequenciador.":
390 "O sequenciador define este campo, durante o sequenciamento, com o tempo de inicio do setup da operação.":
400 "O sequenciador atualiza este campo durante o sequenciamento com o tempo que o trabalho está programado para começar.":
410 "O sequenciador atualiza este campo durante o sequenciamento com o tempo que o trabalho está programado para terminar.":
420 "Marque este campo se não quiser desalocar esta operação depois de selecionar Desprogramar todas as operações. Isto irá travar a operação.":
421 "Operações que tem esse campo marcado vai permanecer desalocada na janela de operações desprogramadas, quando automaticamente sequenciar operações.":
430 "Permite que características definidas pelo usuário sejam definidas à Produtos (como cores). É possível definir Ranks para os atributos para que sejam utilizados pela regra de programação Sequência Preferida.":
440 "Preenche a informação sobre a quantidade concluída e define o tempo que o lote foi completado. O sequenciador vai automaticamente recalcular o tempo de fim da operação.":
450 "Preenche o tempo que o lote foi completado e define a informação da quantidade concluída. O sequenciador vai recalcular automaticamente o fim para essa operação.":
460 "O Tempo Efetivo de Operação utiliza entradas nos campos Quantidade do Lote e Tempo do Lote para calcular um tempo de operação revisado baseado nessas informações.":
474 "Usado para gravar o custo de um item quando ele é introduzido no processo. Esse campo pode ser usado para gravar custos fixos por item.":
476 "use o Custo de Material por Item para fornecer o custo de material do lote no ponto onde o custo por item é introduzido no processo.":
477 "Custo direto do trabalho no processo atual.":
530 "Estabelece um horizonte de tempo em que ordens podem ser agrupadas para produção. Um Recurso, após completar uma operação, vai procurar nesse ponto após o horizonte de tempo estabelecido no Horizonte de Otimização.":
540 "Estabelecido na tabela de dados Produtos, promove acesso a um documento que pode conter informações do produto. Esse documento pode também ser acessado e editado a partir do arquivo de edição da Programação.":
541 "Esse campo é utilizado para descrever o progresso de uma operação individual. Existem 4 status diferentes: Não Iniciada; Setup; Em Execução; Concluída":
550 "Produtos podem ter características individuais associadas à eles que são armazenadas na tabela de dados Atributos. Essas tabelas são definidas pelo usuário e, por exemplo, a tabela Atributos do Produto 1 pode ser utilizada para a cor do produto.":
560 "Utilizado para estabelecer Ranks entre registros na tabela de dados Atributos do Produto 1.":
570 "Produtos podem ter características individuais associadas à eles que são armazenadas na tabela de dados Atributos. Essas tabelas são definidas pelo usuário e, por exemplo, a tabela Atributos do Produto 1 pode ser utilizada para a cor do produto.":
580 "Usado para estabelecer o Rank de Prioridade entre registros na tabela de dados Atributos do Produto 2.":
590 "Produtos podem ter características individuais associadas à eles que são armazenadas na tabela de dados Atributos. Essas tabelas são definidas pelo usuário e, por exemplo, a tabela Atributos do Produto 1 pode ser utilizada para a cor do produto.":
600 "Usado para estabelecer uma Rank de prioridade entre registros.":
602 "Este campo calcula a duração total da Ordem contando o começo do setup da primeira operação até o final da última operação.":
620 "Regra que calcula um número, dividindo o tempo que falta para o tempo definido na data de Entrega pelo tempo esperado que passou para completar a operação. Um valor menor que 1 indica que a Ordem está atrasado e um valor maior que 1 indica que a Ordem está adiantada.":
815 "Essa opção permite que valores de setup e tempos de operação sejam estabelecidos. Também é utilizado para atualizar o progresso de ordens no sistema de produção.":
1020 "Especifica o nome do grupo de Recursos. Esse nome será usado para identificar grupos específicos de Recursos que são capazes de realizar funções similares.":
1030 "Identifica os Recursos válidos para esse grupo de Recurso. Um Recurso pode pertencer a mais de um grupo de Recurso.":
1060 "Quando marcado, esse campo vai mostrar o gráfico de utilização do grupo de Recurso na janela de gráficos de utilização dentro do sequenciador.":
1070 "Essa cor vai ser exibida no gráfico de utilização que é visível na janela de gráfico no sequenciador.":
1080 "O gráfico de utilização vai exibir essa cor quando a utilização ultrapassa o número de horas disponíveis para o Recurso ou grupo de Recurso.":
1090 "O gráfico de utilização vai usar esta cor para desenhar uma linha que marca o tempo de setups (calculado em horas).":
2020 "Especifica o nome do Recurso individual.":
2023 "O custo por hora para trabalhar com o Recurso.":
2024 "Aplica o valor 'Fator de Custo %' no custo por hora do Recurso.":
2030 "Esta janela contém informações sobre a maneira com que um Recurso ou grupo de Recursos deve ser exibido na Visão Geral da Sequência e do Gráfico de Utilização.":
2040 "Pode ser definido como Visível, Minimizado e Desabilitado. usado para controlar o estado inicial desta janela de Recurso quando o sequenciador é iniciado. Normalmente definido como Minimizado. Se definido como Desabilitado, o Recurso não será usado no sequenciamento.":
2050 "Controla a escala do horizonte do Gantt no sequenciador. Pode variar de minutos até semanas por unidades.":
2070 "Permite definir a capacidade de um Recurso como Infinita, Finita ou Infinita com turno.":
2071 "Permite definir a capacidade do recurso como Finito, Infinito ou Infinito com padrões de turno ao executar no modo de sequenciador de capacidade infinita.":
2080 "Controla a escala do horizonte do Recurso no sequenciador.":
2100 "Seleciona a Recurso Secundário que será aplicada ao Recurso primário. Especifica a quantidade da restrição requerida pelo Recurso e a maneira que a restrição é aplicada ao Recurso primário.":
2110 "Estipula quando a utilização do Recurso Secundário deve ser incrementada ou decrementada. Se um trabalho é colocado em um dispositivo elétrico para várias operações, o incremento no início para a primeira operação e Decremento em Concluir para a última operação pode ser especificado. Isto irá assegurar que o dispositivo não pode ser usado para qualquer outro trabalho, enquanto a primeira Ordem está na fila para um Recurso.":
2120 "Especifica a quantidade requerida para a Recurso Secundário. Se o valor 'Quantidade' é selecionado então a quantidade requerida é igual à quantidade do lote que está sendo processado.":
2130 "Define um atributo para uma operação que vai prevenir que operações não similares sejam sequenciadas simultaneamente em um Recurso de capacidade infinita.":
2150 "Usado em produtos APS para estabelecer o critério que será usado na regra de sequenciamento preferida.":
2160 "Usado pela regra de sequenciamento ´Minimizar WIP' para estabelecer quando o  WIP pode acumular no Recurso selecionado.":
2180 "Um valor numérico usado para organizar a ordem que os Recursos são exibidos na tabela de dados dos Recursos. Também usado para alterar a ordem padrão em que os Recursos são exibidos na Visão Geral do sequenciador.":
2181 "Mostra a caixa de diálogo onde opções avançadas de restrições da operação podem ser definidos, se necessário":
2182 "Permite a definição de relacionamentos entre recursos complexos usando expressões. Detalhes da sintaxe da expressão e criação podem ser encontrados na documentação.":
2183 "Permite ao usuário escolher um atributo de uma operação em um recurso de capacidade infinita, que especifica que apenas operações com o mesmo valor no atributo selecionado podem ser programadas ao mesmo tempo.":
2185 "Determina se uma linha separadora é exibida abaixo do recurso no gráfico de Gantt. Ajuda a melhor visualizar os recursos em grupos.":
2190 "Determina a maneira que os Recursos são exibidos na Visão Geral do sequenciador. As alternativas são Sempre, Apenas em Grupo e Esconder.":
2191 "Determina a maneira pela qual as operações serão exibidas na visão geral do sequenciador. As opções são 'Empilhadas', onde as operações são exibidas em uma linha de visão geral, e 'Cascata', onde cada operação é exibida na sua própria linha de visão geral.":
2200 "Usado para definir a matriz de valores de configuração dependentes da sequência, definindo o tempo de configuração exigido mudando de um produto de um tipo de atributo para outro.":
2201 "Este campo define que grupo de troca é atribuído a este recurso e, como resultado, determina quais tempos de troca entre operações com diferentes atributos são aplicados.":
2202 "Determina se os tempos de configuração e de troca relacionados às operações neste recurso são aplicados de forma acumulativa ou simultânea.":
2205 "Retira este Recurso do cálculo da performance métrica da programação.":
2210 "Esse campo é usado para selecionar qual sistema Preactor Viewer o Recurso pertence. Esse campo contém uma lista com os nomes dos sistemas de sequenciamento retirados da tabela de dados PCO.":
2220 "Esse botão abre uma janela listando os diferentes atributos associados com o Recurso.":
2230 "Esse campo permite que atributos do tipo string sejam definidos ao Recurso.":
2240 "Esse campo permite que atributos do tipo real sejam definidos ao Recurso.":
2250 "Esse campo permite que atributos do tipo duração sejam definidos ao Recurso.":
2260 "Esse campo indica a eficiência de um Recurso (o valor padrão é 100%), se a eficiência é alterada para 200%, então qualquer operação programada nesse Recurso vai ser processada duas vezes mais rápida.":
2270 "Quando marcado, aplicará o valor no campo % Eficiência para todas as operações que tem tempos de setup e estão sequenciadas em Recursos que este campo está marcado.":
2280 "Quando marcado, esse toogle vai mostrar o gráfico de utilização para o Recurso no gráfico de utilização do sequenciador.":
2300 "Use este campo para selecionar um Grupo de Restrições Secundárias a partir do qual uma Restrição Secundária será alocada no Sequenciamento.":
2310 "A Restrição Secundária alocada do Grupo de Restrições Secundárias será atribuída a este campo.":
5035 "Um fator de multiplicador do custo que influencia o custo de execução do Recurso. Um valor de 100% não incrementa o custo, um valor de 150% aumenta o valor do custo em 50%. Estabelecido na tabela de dados Estado do Calendário.":
6100 "Mostra uma caixa de diálogo que permite a seleção de quais recursos de um grupo específico são válidos e a atribuição dos dados específicos do recurso.":
6110 "Este campo determina se o recurso será selecionado automaticamente durante o sequenciamento. Se o campo for desmarcado, a operação ainda pode ser manualmente alocadas ao recurso.":
6120 "Este campo permite que um valor específico de tempo de configuração possa ser definido para cada recurso válido para a operação.":
6130 "Este campo permite que um tempo de operação individual seja estabelecido para cada recurso válido para a operação.":
6131 "Este campo permite que uma taxa por hora individual seja estabelecida para cada recurso válido para a operação.":
6132 "Este campo permite que um tempo de lote específico seja estabelecido para cada recurso válido para a operação.":
6140 "Este campo é usado para definir um recurso secundário usado pelo recurso primário durante a operação atual.":
6150 "Esse campo é utilizado para especificar como uma Recurso Secundário é usada durante uma operação.":
6160 "Use este campo para indicar a quantidade do Recurso Secundário requerida durante a operação.":
6170 "O programador usará este período de tempo para tentar carregar a operação atual no recurso preferencial. Se não for possível fazer isso até o final deste período, ele tentará carregar a operação em qualquer recurso do grupo.":
6180 "Definir um Grupo de Recursos Subsequentes significa 'limitar' a escolha dos Recursos dentro da lista.":
6190 "Remove todos os Recursos contidos no Grupo de Recursos selecionado da lista estabelecida pelo comando Definir Grupo de Recurso Subsequente.":
6230 "Esse campo permite definir um tempo de setup , quando se troca de um produto para outro. Valores definidos no campo Tempo de Setup serão adicionados para qualquer valores de setups estabelecidos para o Recurso em uma matriz de Setup Dependente de Sequência.":
6430 "Selecione um nome do ícone. O botão de editar permite a você criar novos ícones.":
6470 "Exibe a caixa de diálogo Restrições secundárias válidas, permitindo que restrições válidas sejam aplicadas a registros individuais nesta tabela. As características de uso de restrição também podem ser editadas aqui.":
6530 "Especifica o intervalo máximo que será permitido entre duas operações sequenciadas. O tempo máximo de intervalo é qualificado pelo 'Tipo de Intervalo'.":
6540 "Estabelece a relação usada para interpolar o tempo máximo de intervalo entre duas operações subsequentes.":
6550 "Especifica o máximo de tempo que a operação pode estender quando sequenciada automaticamente pelo sequenciador.":
6560 "Define um determinado período de tempo de folga a ser considerado entre esta operação e a anterior.":
6565 "Define um determinado período de tempo de folga a ser criado entre esta operação e a próxima.":
6580 "Este campo pode ser usado para aplicar multiplicador de taxa de processo que afeta a duração da operação.":
6681 "Este campo é usado especificar um atributo deste registro, referenciado em uma das tabelas de atributos. Esses podem ser usados para afetar os tempos de configuração, programação de pedido e uso de restrições.":
6682 "Este campo é usado para especificar um atributo de texto de formato livre deste registro. Estes valores podem ser usados para definir as opções de exibição e operações de grupos.":
6683 "Este campo é usado para especificar um atributo numérico deste registro. Este valor pode ser usado para definir opções de exibição, influenciar a programação do pedido ou uso de restrições.":
6684 "Este campo é usado para especificar um atributo de data deste registro. Este valor pode ser usado para definir opções de exibição e influenciar a programação do pedido.":
6685 "Este campo é usado para especificar um atributo de duração deste registro. Este valor pode ser usado para definir opções de exibição e influenciar a programação do pedido.":
6690 "Contém um tempo que será subtraído da Data de Entrega quando sequenciado para trás para que as operações sejam programadas antes, evitando grandes problemas com atrasos não planejados.":
7020 "O número de dias a partir da data atual que podem ser exibidos na Visão Geral do Sequenciador.":
7030 "O periodo de tempo, a partir da data atual, que podem ser exibidos na Visão Geral do Sequenciador.":
7035 "Abre a caixa de configuração do setup que permite ao usuário customizar a Visão Geral do sequenciador.":
7040 "Especifica uma margem, desde o momento da entrada do pedido, antes que uma Ordem não possa ser iniciada. Se definido como não especificado, não há outra restrição além o tempo atual.":
7050 "Especifica uma margem, desde o momento da entrada do pedido até quando a Ordem possa estar disponível. Pode ser substituído.":
7060 "A quantidade de tempo que o Terminador foi deslocado do tempo atual. O Terminador representa o tempo atual quando a margem do Terminador é definido como 0 hr 00 min.":
7067 "Estabelece as opções de cálculo de custo: Durante a Sequência, Depois da Sequência ou Nunca.":
7120 "Define o modo do exibição do sequenciador.":
7130 "O número de dias a partir de agora para iniciar a visão geral do sequenciador.":
7140 "O número de dias a partir de agora para terminar a visão geral do sequenciador.":
7320 "Habilita o script da tabela de dados Script requerido para importar ordens.":
7330 "Habilita o script da tabela de dados Script requerido para exportar ordens.":
7430 "Esse campo adiciona um pequeno triângulo preto em cada operação sequenciada, facilitando o drag and drop dessas operações, especialmente de operações pequenas.":
7450 "Especifica o evento de script PESP padrão que será executado quando ordens forem importadas a partir do botão 'Importar Ordens' no menu de Integração.":
7470 "Especifica o evento de script PESP padrão que será executado quando ordens forem exportadas a partir do botão 'Exportar Ordens' no menu de Integração.":
7480 "Especifica o evento de script PESP padrão que será executado quando uma programação for liberada a partir do botão 'Liberar Programação' a partir do menu de Integração.":
7490 "Especifica o evento de script PESP padrão que será executado quando operações forem alocadas no sequenciados quando a opção Regra APS estiver marcada.":
8020 "Nome do Recurso Secundário.":
8030 "Permite a você selecionar a cor do Gráfico do Usuário quando os valores estão entre os valores limites.":
8040 "Define o padrão de preenchimento do gráfico.":
8060 "Cor do gráfico se este passar o valor limite máximo.":
8080 "Cor do gráfico se este passar o valor limite mínimo.":
8090 "Especifica se essa restrição restringirá de fato o sequenciamento quando se utiliza o Preactor 300 ou superior. Em todas as versões, se esse campo permanecer desmarcado o sequenciador não exibirá as mensagens de alerta avisando que a restrição foi ultrapassada.":
8091 "Quando no modo do sequenciador de capacidade infinita, este campo determina se a restrição secundária deve restringir a programação ao usar o produto 300 FCS ou acima.":
8092 "Opções para controlar o comportamento desta restrição quando o sistema está definido no modo de capacidade infinita.":
8100 "Determina como a eficiência do calendário do Recurso primário vai afetar a utilização dessa Recurso Secundário":
8101 "Quando no modo de sequenciador de capacidade infinita, este campo determina como a eficiência do calendário de recurso primário afeta o uso desta restrição secundária. As opções são: Sem efeito, Início da eficiência do trabalho, Seguir alterações de eficiência e Usar 100% se maior que 0%":
8120 "Esse botão abre um diálogo listando os diferentes atributos associados com a Recurso Secundário.":
8130 "Esse campo permite atributos do tipo string a serem definidos nos Recurso Secundário.":
8140 "Esse campo permite atributos do tipo real a serem definidos nos Recurso Secundário.":
8150 "Esse campo permite que dados de atributos do tipo duração sejam definidos nos Recurso Secundário.":
8160 "Quando marcado, esse toogle mostrará um gráfico de utilização para a Recurso Secundário.":
8200 "O nome do Grupo de Restrições Secundárias.":
8210 "Permite que você selecione quais Restrições Secundárias são membros deste grupo.":
9020 "Nome de Grupos de Setups que formam os eixos X e Y da matriz.":
12020 "Nome de um atributo na tabela de dados de atributos de produto.":
13020 "Nome de um atributo na tabela de dados de atributos de produto.":
14020 "Nome de um atributo na tabela de dados de atributos de produto.":
16020 "O nome usado para descrever a configuração da tela salva com o nome do arquivo. Esta descrição é também usada como dica para mostrar ícones.":
16030 "O arquivo é escolhido selecionando um arquivo a partir da opção oferecida pelo botão no canto esquerdo deste campo.":
18510 "O nome do indivíduo ou organização referente à Ordem.":
18520 "Nome do contato principal da organização referente à Ordem.":
18530 "Número de telefone para ser usado em conexão com uma Ordem.":
18540 "Endereço de E-mail para ser usado em conexão com uma Ordem.":
21000 "Este campo permite que diferentes status da Ordem sejam definidos.":
21020 "Este campo é utilizado para conter a descrição do que o nome do estado de Ordem significa que tenha sido definido no campo 'Nome de Ordem '.":
21100 "Nome do registro de atributo na tabela de dados Atributos.":
21110 "Usado para estabelecer uma classificação de prioridade entre os registros nesta tabela de dados Atributos, que pode ser usado pelas regras de programação":
24000 "Este campo especifica se o registro é um registro pai da regra ou se é um registro filho.":
24010 "Contém o nome do conjunto de regras.":
24020 "Este campo é usado para limpar os links de alocação somente para pedidos que estão na fila de demanda da primeira passagem ( habilitado ou não) do conjunto de regras.":
24030 "Armazena o nome de uma função particular da passagem de regra.":
24040 "Um campo que, quando marcado, habilita a passagem da regra e, quando desmarcado, essa passagem de regra específica será ignorada durante a execução do conjunto de regras.":
24050 "Quando este campo for selecionado, o conjunto de regras é executado, um arquivo de depuração será criado no diretório de trabalho.":
24060 "Este campo é usado para especificar critérios que podem ser usados para restringir quais itens são colocados na fila de suprimento interno. O valor padrão para este campo é definido como TODOS, mas isso pode ser alterado inserindo uma expressão, por exemplo, (~{$Order Type}~==~Stock~). Esta fila filtra registros mantidos no banco de dados 'Pedidos de trabalho'.":
24070 "Este campo contém critérios que podem ser usados para classificar os itens na fila de suprimento interna. Por exemplo, você pode classificar a fila de suprimento interna por data de entrega, primeira data de início ou prioridade.":
24080 "Este campo é usado para especificar os critérios que podem ser usados ​​para restringir os itens que são colocados na Fila de demanda. O valor padrão para este campo é definido como TODOS, mas isso pode ser mudado inserindo uma expressão, por exemplo (~{$Order Type}~==~Stock~). Esta fila filtra registros mantidos no banco de dados 'Pedidos de trabalho'.":
24090 "Este campo contém os critérios que podem ser usados ​​para classificar os itens na fila de demanda interna. Por exemplo, você pode classificar a fila de demanda interna por data de entrega, primeira data de início ou prioridade.":
24100 "Este campo contém uma lista das várias regras de alocação padrão que podem ser usadas para os pedidos. Ele também contém três itens especiais - Definidos pelo usuário, Funções de usuário e Script PESP que fornecem a oportunidade de criar regras mais personalizadas.":
24110 "Este campo só é visível quando o campo 'Tipo de regra” é definido pelo usuário ou quando é uma função do usuário. A expressão a ser usada para a regra entra neste campo. Um exemplo pode ser assim: (~{+:$Product Attribute 1}~==~{-:$Product Attribute 1}~) permitindo fornecer apenas pedidos de demanda e de suprimento a ser vinculados se os campos 'Atributos do produto 1' tiverem o mesmo valor.":
24120 "Este campo só é visível quando o campo 'Tipo de regra' é definido como 'Script PESP'. Este campo contém o nome do Script PESP a ser usado como regra.":
24130 "Esta opção permite a criação de links em linhas de BoM, onde a quantidade de linha BoM não tem que ser totalmente satisfeita para que o link seja feito. Qualquer item que esteja faltando será destacado como em falta.":
24140 "Esta opção só permitirá a criação de links em linhas BoM onde a quantidade da linha BoM esteja totalmente satisfeita. Quaisquer itens faltando serão destacados como em falta.":
24141 "Quando esta opção estiver marcada, o comportamento padrão do SMC é substituído, permitindo que links inversos sejam criado quando a produção ocorrer depois do consumo.":
24150 "Quando definido como verdadeiro, os pedidos que já estiverem programados podem ser revinculados.":
24160 "Quando esta opção estiver marcada, o campo 'Classificação de fila de fornecimento' fica ativa, permitindo que os registros de fornecimento sejam classificadas de acordo com os critérios de seleção no campo 'Classificação de fila de suprimento'. Esta opção deve ser selecionada apenas se todos os registros forem mantidos no banco de dados 'Pedidos de trabalhos'.":
24170 "Este campo é usado para especificar os critérios que podem ser usados ​​para restringir os itens que são colocados na fila de fornecimento externa. O valor padrão para este campo é definido como TODOS, mas isso pode ser alterado inserindo uma expressão, por exemplo (~{$Order Type}~==~Stock~). Esta fila filtra registros mantidos no banco de dados 'Demanda'.":
24180 "Qualquer campo com uma classificação HERDAR DO FORNECIMENTO(Nome do campo) será processado.":
24190 "Qualquer campo com a classificação HERDAR DA DEMANDA(Nome do campo) será processado.":
24200 "Quando esta opção estiver definida, o campo 'Classificação da fila de demanda' torna-se habilitado, permitindo que registros de demanda sejam classificados de acordo com os critérios de seleção no campo 'Classificação de fila de demanda'. Esta opção deve ser selecionada somente se todos os registros forem mantidos no banco de dados 'Pedidos de trabalho'.":
24210 "A quantidade de um link criado será alocada em múltiplos específicos quando esta opção estiver definida como verdadeira. Este múltiplo é especificado nos Dados de BoM.":
24500 "Se o campo 'Sempre usar esta regra' estiver marcado, o conjunto de regras de alocação selecionado neste campo será aquela que, por padrão, será executado quando a opção 'Materiais de alocação' estiver selecionado no sequenciador.":
24505 "Quando esta opção global está marcada, o comportamento padrão do SMC é substituído permitindo que os links inversos sejam criados quando a produção ocorrer após o consumo.":
24510 "Se esta opção estiver marcada, será usada a regra selecionada no campo 'Conjunto de regras de alocação selecionado' como regra padrão, quando a opção 'Materiais de alocação' estiver selecionada no sequenciador. Se a opção 'Sempre usar este conjunto de regras' estiver desmarcado, uma caixa de diálogo de seleção de regras será exibida ao selecionar a opção 'Materiais de alocação' no sequenciador. Isso permitirá que a regra que deve ser executada seja selecionada neste momento.":
25400 "Esse campo é usado para armazenar o número do pedido do pedido de fornecimento.":
25410 "Este campo identifica o tipo de pedido, por exemplo, Estoque ou Compra.":
25420 "O nome da organização que está fornecendo materiais para o pedido.":
25430 "O número de peça para o qual o pedido é feito.":
25440 "Descrição da peça para o qual o pedido é feito.":
25450 "Data de quando o material é fornecido.":
25500 "Este campo é usado para identificar a qual pedido a peça pertence. A linha do primeiro pedido de um pedido será o registro pai e exibirá PARENT neste campo; as outras linhas de pedidos que são parte deste pedido serão registros filhos e exibirão o número de pedidos ao qual pertencem neste campo.":
25510 "Este é o campo usado para armazenar o número de pedido do pedido de demanda.":
25520 "Este campo identifica o tipo do pedido, por exemplo, Produzir para estoque ou Pedido de vendas.":
25530 "Identifica um item de linha de um pedido de maneira única.":
25540 "O nome da organização que está exigindo materiais para o pedido.":
25550 "Data de quando o material é exigido.":
25560 "Especifica o múltiplo de um item que precisa ser alocado. Normalmente um número de itens comporá uma caixa ou pasta, um exemplo pode ser onde 12 latas compõem 1 caixa, um pedido exigindo 60 latas chega. Há um pedido de fornecimento de 50 latas. O controle de material alocará apenas 48 latas das 50, depois procurará em outro local pelas 12 latas de que precisa, mas criará o link apenas se a quantidade exata de 12 for encontrada. O campo 'Alocar apenas múltiplos' deve ser verificado no banco de dados 'Regras de alocação' para este recurso ser ativado.":
25600 "Número do pedido ao qual a linha BoM pertence.":
25605 "Número da peça do pedido ao qual a linha BoM pertence.":
25610 "Número da operação à qual a linha BoM pertence.":
25611 "Nome da operação à qual a linha BoM pertence.":
25615 "Número da peça do produto que requer o material especificado":
25620 "Número da peça do item da BoM.":
25630 "Quantidade requerida do item da BoM.":
25640 "Quando marcado, este campo fará com que a quantidade do pedido seja multiplicada pela quantidade requerida da BoM.":
25650 "Faz com que as faltas de materiais sejam ignoradas ao executar uma regra de alocação. Permite que os pedidos com faltas sejam programados.":
25700 "Número do pedido no qual o co-produto é produzido.":
25705 "Número da peça do pedido em que o co-produto é produzido.":
25710 "Número da operação que produz o co-produto.":
25715 "Nome da operação que produz o co-produto.":
25720 "Nome do co-produto.":
25730 "Quantidade do co-produto produzida.":
25740 "Quando marcado, este campo faz com que a quantidade do co-produto seja multiplicada pela quantidade do pedido.":
25800 "Este campo identifica o tipo de pedido, por exemplo: Pedido de trabalho, Pedido de compra, Pedido de vendas ou Estoque":
25810 "Quando marcada, a operação não programada não será mais exibida na janela 'Operações não programadas'.":
25820 "Exibe uma caixa de diálogo que exibe os campos relacionados com o Controle de material.":
25830 "Este campo fornece informações sobre o status da demanda após os materiais terem sido alocados. Ele contém um dos seguintes valores: 'Desconhecido', 'Satisfeito', 'Faltas', 'Escassez', 'Todas as faltas ignoradas'.":
25840 "Este campo é preenchido após os materiais terem sido alocados. Quando um link para um pedido de fornecimento no banco de dados de 'Pedidos de suprimento' tiver sido feito, o campo 'Data da demanda' no banco de dados 'Pedidos de trabalhos' é preenchido com a 'Data de fornecimento' do pedido de fornecimento. O campo 'Data de suprimento' será avaliado em relação ao campo 'Data de início mais cedo', e a data mais recente será usada para determinar qual data deve ser usada ao programar.":
25850 "Este campo é preenchido após os materiais terem sido alocados. Quando um link para um pedido de demanda no banco de dados de 'Pedidos de demanda' tiver sido feito, o campo 'Data do fornecimento' no banco de dados 'Pedidos de trabalhos' é preenchido com a 'Data de demanda' do pedido de demanda ao qual está vinculado. O campo 'Data de demanda' será avaliado em relação ao campo 'Data de entrega' e a data mais recente será usada para determinar qual data deve ser usada ao programar.":
25900 "Mostra uma janela com os campos relacionados ao status de uma operação.":
25910 "Esta opção pode ser selecionada quando um pedido é dividido, esta opção permite que cada lote de produção prossiga de forma independente através do processo de fabricação, por exemplo, todos os lotes não têm que serem concluídos em uma operação antes de uma operação subsequente possa começar.":
25920 "Este campo define a cor usada na barra do gráfico de Gantt para este registro.":
26000 "Este campo define o nome do grupo de troca":
26100 "Este campo define a quantidade de tempo de troca que se incorre quando o atributo especificado muda entre as operações programadas uma ao lado da outra.":
26200 "O nome de exibição da ferramenta do usuário":
26210 "O script de evento que a ferramenta de usuário executará quando selecionada":
26220 "o nome do menu de ferramenta da janela do usuário":
26230 "A função de código para preencher o conteúdo da janela do usuário":
26240 "o rótulo da janela do usuário":
26300 "O nome do botão de menu. Isto dá uma indicação de onde o botão será exibido no sistema de menus":
26310 "Este campo controla se o botão está habilitado e, portanto, se ele é exibido":
26320 "Este campo controla o texto que exibido no botão":
26330 "O script de evento que o botão de menu executa quando selecionado":
;
