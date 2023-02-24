#VERSION 0
;
FRA POPUP HELP
1 "Aucune aide n'est associée à cet objet.":
10 "Ce champ permet d'identifier l'ordre auquel la pièce appartient. Dans la première opération d'un ordre, il est défini sur PARENT ; dans d'autres opérations, il est défini sur le numéro ou le nom d'ordre unique.":
40 "Ce champ permet d'identifier la référence. Si vous appuyez sur le bouton, toutes les références présentes dans la table de données des produits apparaîtront. Si vous sélectionnez une référence, le nom du produit sera automatiquement modifié.":
41 "Ce champ contient une liste des différents états qui peuvent être définis en fonction d'un ordre. Les valeurs sont tirées de la table de données des états d'ordres, dans laquelle de nouveaux états peuvent être ajoutés le cas échéant. Un motif de barre d'opération, défini dans la table de données des états d'ordres en fonction de chaque type d'état, peut être utilisé pour définir le motif de la barre d'opération de l'ordre quand l'ordre est programmé dans l'ordonnanceur.":
45 "Ce champ permet d'identifier la référence.":
50 "Ce champ permet d'identifier le nom du produit. Utilisez le bouton pour sélectionner le nom ; la référence sera automatiquement modifiée.":
55 "Ce champ permet d'identifier le nom du produit.":
60 "Ce champ permet d'identifier le numéro d'ordre correspondant à ce produit. Il pourrait s'agir d'un numéro d'ordre interne ou d'un numéro d'ordre indiqué par le client. Le numéro d'ordre doit être unique.":
70 "Ce champ peut contenir des notes relatives à cet ordre. Il peut s'agir d'un rappel concernant des délais, ou simplement d'un message adressé à l'emballeur/assembleur de l'atelier.":
75 "Ouvre une boîte de dialogue présentant toutes les informations d'attribut de l'opération.":
80 "Ce champ permet de définir la priorité d'une tâche qui sera à son tour utilisée par l'ordonnanceur. Plus le numéro est bas, plus la priorité est élevée. Notez bien que les priorités peuvent être négatives ; une priorité négative est supérieure à une priorité positive. Par exemple, -100 est supérieur à -1, et 0 est supérieur à 10.":
90 "Ce champ définit le numéro d'opération correspondant à une tâche. Il permet d'ordonner la tâche dans l'ordonnanceur. Les opérations aux numéros les plus bas seront menées à bien avant que les opérations aux numéros les plus élevés débutent. Si deux opérations présentent le même numéro dans un produit, elles seront toutes les deux menées à bien avant que des opérations à niveaux plus élevés débutent.":
110 "Il s'agit de la description ou du nom écrit(e) de l'opération qui a lieu, aussi identifié(e) par le numéro d'opération.":
112 "Ouvre une boîte de dialogue contenant des informations relatives aux données de ressource attribuées à cette opération":
120 "Des groupes de réglage sont définis dans la table de données des groupes de réglage (par ex., Groupe de réglage 1, Groupe de réglage 2, etc). Ces valeurs sont utilisées en tant qu'axes de l'une des matrices de temps de réglage dépendant d'un ordonnancement, lesquelles établissent le temps de changement entre des produits appartenant à des groupes de réglage différents (généralement configurés dans la table de données des ressources). Des groupes de réglage individuels sont alloués aux produits dans la table de données des produits, bien que la valeur par défaut puisse être remplacée dans le fichier de planning principal.":
130 "Ce champ identifie le groupe de ressources valides pouvant mener à bien l'opération en cours.":
140 "Si nécessaire, ce champ peut être utilisé pour identifier une ressource spécifique qui doit traiter l'opération. Si, dans la table de données des produits, il a été défini sur 'Sélectionner dans groupe', n'importe quelle ressource du groupe affichée dans le champ Groupe de ressources pourrait être utilisée. Si vous voulez imposer l'opération à une ressource spécifique du groupe, utilisez la liste déroulante pour sélectionner la ressource voulue.":
150 "Ce champ affiche la ressource qui traitera l'opération. Si l'ordre n'a pas été planifié avant, il sera défini sur 'Indéfini'. Si l'opération a déjà été chargée sur le planning, la ressource pour laquelle elle doit actuellement être chargée s'affichera.":
180 "Ce champ permet de stipuler si la vitesse de traitement est calculée en tant que temps par lot, temps par item ou taux par heure. Si l'option 'Temps par lot' est sélectionnée, le temps affiché dans le champ dessous est le temps consacré au traitement de toutes les pièces du lot. Si l'option 'Temps par item' est sélectionnée, le temps de traitement sera la valeur indiquée dans le champ dessous multipliée par la taille du lot. Si l'option 'Taux par heure' est sélectionnée, le temps de traitement sera calculé directement à partir du nombre qui figure dans le lot.":
220 "Vous avez actuellement choisi comme type de temps de traitement 'Temps par item'. Vous devez saisir un temps d'opération pour chaque item dans ce champ.":
230 "Vous avez actuellement choisi comme type de temps de traitement 'Temps par lot'. Vous devez saisir un temps d'opération pour chaque lot dans ce champ.":
240 "Vous avez actuellement choisi comme type de temps de traitement 'Taux par heure'. Vous devez stipuler combien d'items peuvent être produits par heure dans ce champ.":
251 "La couleur indiquée dans ce champ indique à l'ordonnanceur d'afficher une section de la barre du diagramme de Gantt dans une couleur différente. La couleur marque la barre en fonction de la valeur qui a été saisie dans les champs 'Quantité du processus en cours' et 'Horodatage du processus en cours'.":
260 "Ce champ permet d'indiquer la quantité d'ordres ou de lots.":
270 "Ce champ permet d'indiquer le profit de l'ordre ou du lot et peut être utilisé pour influencer l'ordonnancement lors de l'utilisation d'une règle de pondération.":
280 "Ce champ présente l'heure de début de la première opération de cet ordre si la fonction Durée de production est activée":
290 "Ce champ présente l'heure de fin de la première opération de cet ordre si la fonction Durée de production est activée":
300 "Cette valeur détermine la quantité devant être traitée avant que l'opération suivante puisse être démarrée. La valeur Indéfini empêche le chevauchement d'opérations":
360 "Permet d'indiquer une date avant laquelle la tâche ne peut pas être lancée. Il peut par exemple s'agir de l'heure à laquelle les composants seront disponibles.":
370 "Ce champ permet d'établir le délai. Le délai est utilisé pour mettre en lumière les items en retard dans l'ordonnanceur et pour changer la priorité du chargement de tâches dans le planning si l'option 'Délai' est sélectionnée.":
380 "Sélectionnez ce bouton bascule pour montrer à l'ordonnanceur que les heures de début et de fin sont des valeurs 'réelles'. Lorsqu'il est sélectionné, ce bouton bascule empêche l'ordre d'être déplanifié de toute ressource présente dans l'ordonnanceur. En effet, il est fixé définitivement dans le planning.":
390 "L'ordonnanceur définit ce champ, pendant l'ordonnancement, sur l'heure à laquelle la tâche doit lancer le processus de réglage.":
400 "L'ordonnanceur met ce champ à jour pendant l'ordonnancement en indiquant l'heure à laquelle la tâche doit commencer.":
410 "L'ordonnanceur met ce champ à jour pendant l'ordonnancement en indiquant l'heure à laquelle la tâche doit se terminer.":
420 "Sélectionnez ce bouton bascule si vous ne voulez pas que cette tâche soit déplanifiée après avoir choisi de déplanifier toutes les tâches dans l'ordonnanceur. L'opération sera ainsi déverrouillée. Cela peut être réalisé lors de l'utilisation du mode de localisation 'Opérations verrouillées en sur-brillance' dans l'ordonnanceur en pointant avec la souris sur une opération (icône ou barre dans la vue d'ensemble), en relâchant la touche Maj du clavier et en cliquant avec le bouton gauche de la souris.":
421 "Les opérations pour lesquelles ce bouton bascule est sélectionné resteront déplanifiées dans la fenêtre des opérations déplanifiées, lors de la planification automatique des opérations.":
430 "Permet d'attribuer des caractéristiques définies par l'utilisateur à des produits (par ex., une couleur). Au sein d'une caractéristique spécifique, des enregistrements d'attribut se voient attribuer un ordre de priorité (par ex., les produits 'blancs' peuvent être prioritaires sur les produits 'jaunes'). Ces attributs sont utilisés par les règles de séquence préférée de l'ordonnanceur, regroupant des ordres similaires au sein de la fenêtre d'anticipation.":
440 "Complétez les informations sur la quantité réalisée, et saisissez le temps de réalisation du lot partiel dans le champ 'Horodatage du processus en cours'. L'ordonnanceur recalculera automatiquement l'heure de fin de cette opération.":
450 "Indiquez le temps de réalisation du lot partiel et saisissez les informations relatives à la quantité réalisée dans le champ 'Quantité du processus en cours'. L'ordonnanceur recalculera automatiquement l'heure de fin de cette opération.":
460 "Le temps d'opération effectif utilise les entrées des champs 'Quantité du processus en cours' et 'Horodatage du processus en cours' pour calculer le temps révisé d'une opération en fonction de ces informations. Il convient de noter que pour assurer un bon fonctionnement, les heures et quantités du processus en cours doivent être modifiées quand l'éditeur est affiché dans l'ordonnanceur, sinon le temps effectif du processus ne changera que lorsque vous entrerez de nouveau dans l'ordonnanceur.":
474 "Permet d'enregistrer le coût d'un item au moment où il est introduit dans le processus. Ce champ peut être utilisé pour enregistrer des coûts fixes par item, comme un traitement thermique en sous-traitance, etc.":
476 "Utilise le Coût matière par unité pour fournir le coût des composants du lot au moment où le coût par item (unité) est introduit dans le processus.":
477 "Coût direct de la tâche au processus en cours.":
530 "Établit un horizon temporel dans lequel les tâches peuvent être regroupées par lots pour la  production. Une ressource terminant une opération dans le tableau de prévision anticipera à partir de ce point sur l'horizon temporel établi par la fenêtre de prévisions. Les critères d'ordonnancement préférés, configurés dans la table de données Ressources, sont appliqués pour sélectionner les tâches du travail dont l'échéance rentre dans cet horizon temporel. La fenêtre de prévisions peut être établie individuellement par rapport aux produits, dans la table de données Produits et modifiée individuellement pour les ordres dans le fichier Planning principal ou elle peut être établie comme règle globale dans les Informations sur le réglage de la configuration.":
540 "Établi dans la table de données Produits, ceci permet l'accès à un document Word qui peut contenir des informations sur le produit. Le document est également accessible et édité dans l'éditeur de fichiers Planning principal.":
541 "Ce champ permet de décrire individuellement l'avancement d'une opération. Il y a quatre états d'avancement différents : Non commencée, Configurée, En cours d'exécution et Terminée":
550 "Des caractéristiques spécifiques peuvent être associées aux produits. Dans l'ordonnanceur, elles sont contenues dans la table de données Attribut. Ces tables sont définies par l'utilisateur et par exemple, la table Attribut 2 de produit peut être réservée à la couleur, où les enregistrements seraient nommés individuellement - rouge, bleu, vert etc. Les attributs de produits peuvent être sélectionnés dans le champ Correspondance semblable de la table de données Produits pour définir un délai de réglage semblable.":
560 "Utilisé pour établir un classement prioritaire entre les enregistrements dans la table de données Attribut 1 de produit, utilisée par la sélection de l'ordonnancement des règles ASP.":
570 "Des caractéristiques spécifiques peuvent être associées aux produits. Dans l'ordonnanceur, elles sont contenues dans les tables de données Attribut. Ces tables sont définies par l'utilisateur et par exemple, la table Attribut 2 peut être réservée au matériau, où les enregistrements seraient nommés individuellement - acier, laiton, cuivre, etc. Les attributs de produits peuvent être sélectionnés dans le champ Correspondance exacte de la table de données Produits pour définir un délai de réglage semblable.":
580 "Utilisé pour établir un classement prioritaire entre les enregistrements dans la table de données Attribut 2 de produit, utilisée par la sélection de l'ordonnancement des règles ASP.":
590 "Des caractéristiques spécifiques peuvent être associées aux produits. Dans l'ordonnanceur, elles sont contenues dans les tables de données Attribut. Ces tables sont définies par l'utilisateur et par exemple, la table Attribut 3 peut être réservée aux largeurs du matériau, où les enregistrements seraient nommés individuellement - 16 pouces, 18 pouces, 20 pouces, 24 pouces, etc. Les attributs de produits peuvent être sélectionnés dans le champ Correspondance exacte de la table de données Produits pour définir un délai de réglage semblable.":
600 "Utilisé pour établir un classement prioritaire entre les enregistrements dans la table de données Attribut 3 de produit, utilisée par la sélection de l'ordonnancement des règles ASP.":
602 "Ce champ calcule la durée de l'ordre entier entre l'heure de début de réglage de la première opération et l'heure de fin de la dernière opération de l'ordre.":
620 "Une règle de priorité qui calcule un indice en divisant le temps restant jusqu'à l'échéance par le temps écoulé prévu pour terminer le travail. Un ratio de moins de 1 indique que la tâche est en retard, plus de 1 indique qu'elle est en avance.":
815 "Cette option permet de définir les temps de réglage et d'opération. Elle permet également de mettre à jour l'avancement des tâches à travers le système de production.":
1020 "Indique le nom du groupe de ressources. Ceci permettra d'identifier les groupes spécifiques de ressources, capables d'effectuer des fonctions semblables.":
1030 "Identifie les ressources valides du groupe de ressources. Une ressource peut être membre de plusieurs groupes.":
1060 "Lorsqu'elle sera activée, cette bascule affichera un graphe d'utilisation du groupe de ressources dans la fenêtre multi-graphe de l'ordonnanceur.":
1070 "Cette couleur sera affichée dans le graphe d'utilisation visible dans la fenêtre multi-graphe de l'ordonnanceur.":
1080 "Le graphe d'utilisation, présent dans la fenêtre multi-graphe de l'ordonnanceur, affichera cette couleur lorsque l'utilisation dépasse le nombre d'heures disponibles pour la ressource ou le groupe de ressources (si le champ Heures max. d'utilisation est paramétré comme indéfini). Si une valeur a été saisie dans le champ Heures max. d'utilisation, le graphe changera de couleur selon cette valeur.":
1090 "Le graphe d'utilisation, dans la fenêtre multi-graphe de l'ordonnanceur, utilisera cette couleur pour tracer une ligne qui marque l'utilisation du réglage mesurée en heures.":
2020 "Indique le nom de la ressource individuelle.":
2023 "Le coût horaire d'exécution de la ressource.":
2024 "Applique les valeurs '% facteur de coût', établies dans les enregistrements du calendrier maître, au coût horaire de la ressource.":
2030 "Cette boîte de dialogue contient des informations sur le mode d'affichage d'un groupe ou groupe de ressources dans la fenêtre Aperçu de l'ordonnancement.":
2040 "Peut être défini sur Visible, Réduite ou Désactivée. Permet de contrôler l'état initial de la fenêtre de la ressource lorsque l'ordonnanceur démarre. Est normalement définie sur Réduite. Si elle est définie sur Désactivée, la ressource n'est pas utilisée pour l'ordonnancement.":
2050 "Contrôle l'échelle (temps) horizontale des fenêtres de ressources de Gantt de l'ordonnanceur. Peut varier de minutes en semaines par unité.":
2070 "Permet de définir une capacité de ressource sur Finie, Infinie ou Infinie Avec Calendriers.":
2071 "Permet de définir une capacité de ressource sur Finie, Infinie ou Infinie avec des modèles de poste en Mode ordonnanceur de capacité infinie.":
2080 "Contrôle l'échelle (temps) horizontale de la fenêtre de ressources en mosaïque de l'ordonnanceur.":
2100 "Sélectionne les contraintes secondaires à appliquer à une ressource primaire. Précise la quantité de contraintes requises par la ressource et le mode d'application de la contrainte à la ressource primaire.":
2110 "Stipule lorsque l'utilisation de la ressource secondaire doit être incrémentée ou décrémentée, par ex., Incrément de la durée qui utilise la contrainte secondaire pendant la durée de l'opération et la libère à la fin. Si une tâche est placée sur un dispositif pour plusieurs opérations, les options Incrément au début de la première opération et Décrément à la fin de la dernière opération peuvent être précisées. Ceci garantira que le dispositif ne soit pas utilisé pour toute autre tâche tandis que la première est en attente d'une ressource.":
2120 "Indique la quantité requise de la contrainte secondaire. Si la valeur 'Quantité' est sélectionnée, la quantité nécessaire est égale à la quantité de lots traitée.":
2130 "Définit un attribut d'une opération qui évitera l'exécution simultanée d'opérations différentes dans une ressource de capacité infinie.":
2150 "Utilisé dans les produits APS, pour établir les critères à utiliser pour les règles d'ordonnancement préférées en sélectionnant le travail pour le traitement.":
2160 "Utilisé dans le produit APS, par les règles d'ordonnancement 'Réduire WIP', pour établir des marges dans lesquelles WIP peut accumuler des ressources sélectionnées à l'avance.":
2180 "Une valeur numérique permettant de trier l'ordre d'affichage des ressources dans la table de données Ressources. Elle peut être utilisée pour ne pas tenir compte de l'ordre d'affichage par défaut dans l'aperçu de l'ordonnancement.":
2181 "Affiche la boîte de dialogue où les options de contraintes de ressources avancées peuvent être définies, si nécessaire":
2182 "Permet la définition de relations inter-ressources complexes utilisant des expressions. Les détails de la syntaxe et création des expressions sont disponibles dans la documentation.":
2183 "Permet de choisir un attribut d'opération dans une ressource de capacité infinie qui indique que seules les opérations avec la même valeur dans l'attribut sélectionné peuvent être ordonnancées en même temps.":
2185 "Détermine si une ligne séparatrice est affichée au-dessous de la ressource sur le graphe de Gantt. Ceci peut aider lors de la visualisation de ressources dans les groupes.":
2190 "Détermine le mode d'affichage de la ressource dans l'aperçu de l'ordonnancement. Les alternatives sont 'Toujours', 'Uniquement dans le groupe' et 'Masquer'.":
2191 "Détermine le mode d'affichage des opérations dans l'aperçu de l'ordonnancement. Les options sont 'Empilé' là où les opérations sont affichées sur une ligne d'aperçu, et 'Cascade' là où chaque opération est affichée sur sa propre ligne d'aperçu.":
2200 "Permet d'établir une matrice de valeurs de réglage dépendantes de l'ordonnancement, en définissant le temps de réglage requis pour passer d'un produit d'un type d'attribut à un autre.":
2201 "Ce champ définit quelle groupe de changement est affecté à cette ressource et par conséquent, détermine quels temps de changement sont appliqués entre les opérations avec différents attributs.":
2202 "Détermine si les temps de réglage et de changement associés aux opérations dans cette ressource sont appliqués simultanément ou cumulativement.":
2205 "L'utilisation de cette case à cocher arrête l'insertion de la ressource dans les calculs de métriques des performances du planning.":
2210 "Ce champ permet de sélectionner à quel système de visionneuse la ressource appartient. Le champ contient une liste de noms système de l'ordonnanceur extraits de la table de données Carnet d'adresse PCO.":
2220 "Ce bouton ouvre une boîte de dialogue indiquant les différents attributs associés à la ressource.":
2230 "Ce champ permet de saisir des données d'attributs de chaîne en fonction de la ressource.":
2240 "Ce champ permet de saisir des données d'attributs réels pour la ressource.":
2250 "Ce champ permet de saisir des données d'attributs de durée en fonction de la ressource.":
2260 "Ce champ décrit l'efficacité d'une ressource, la valeur par défaut est 100 %. Si l'efficacité passe à 200 %, les opérations planifiées dans cette ressource seront traitées deux fois plus vite (la moitié du temps de traitement normal).":
2270 "Ceci est un champ bascule qui lorsqu'activé, appliquera la valeur dans le champ % d'efficacité à toutes les opérations comportant des temps de réglage et qui sont planifiés dans la ressource sur laquelle la bascule est définie.":
2280 "Lorsqu'elle sera activée, cette bascule affichera un graphe d'utilisation de la ressource dans la fenêtre multi-graphe de l'ordonnanceur.":
2300 "Utiliser ce champ pour sélectionner un groupe de Contraintes secondaires à partir duquel sera alloué une Contrainte secondaire lors de l'Ordonnancement.":
2310 "La Contrainte secondaire allouée depuis le groupe de Contraintes secondaires sera assignée dans ce champ.":
5035 "Un multiplicateur de facteur de coût, qui influence le coût d'exploitation de la ressource à laquelle il s'applique. Une valeur de 100 % n'applique aucune augmentation, une valeur de 150 % augmente le coût d'exploitation de 50 %. Établis dans la table de données États du calendrier, ils fournissent les valeurs par défaut utilisées dans les fichiers du calendrier maître.":
6100 "Affiche une boîte de dialogue qui permet la sélection des ressources valides provenant du groupe sélectionné et l'affectation des données spécifiques des ressources.":
6110 "Ce champ détermine si la ressource sera sélectionnée lors de l'ordonnancement automatique. Si désélectionnée, l'opération peut rester manuellement placée sur la ressource.":
6120 "Ce champ permet d'établir individuellement une valeur de temps de réglage pour chacune des ressources valides pour l'opération.":
6130 "Ce champ permet d'établir individuellement un temps d'opération pour chacune des ressources valides pour l'opération.":
6131 "Ce champ permet d'établir individuellement un taux par heure pour chacune des ressources valides pour l'opération.":
6132 "Ce champ permet d'établir individuellement un temps de traitement par lots pour chacune des ressources valides pour l'opération.":
6140 "Ce champ permet de définir une ressource secondaire utilisée par la ressource primaire lors de l'opération en cours.":
6150 "Ce champ permet d'indiquer le mode d'utilisation de la contrainte secondaire lors de l'opération, par ex. Incrément de la durée, Incrémenter le temps de réglage uniquement, etc.":
6160 "Ce champ permet d'indiquer la quantité de contrainte secondaire nécessaire pendant l'opération en cours, par ex, vous pouvez préciser que l'opération nécessitait un Mandrin stable.":
6170 "L'ordonnanceur utilisera cette période pour tenter de charger l'opération en cours sur la ressource préférée. S'il n'y parvient pas à la fin de cette période, il tentera de charger l'opération sur les autres ressources du groupe.":
6180 "La fonction Définir le groupe de ressources suivant établit une 'liste forcée' de ressources, c-à-d, celles indiquées dans le groupe sélectionné. Elle 'force' les opérations en aval ou suivantes à n'utiliser que les ressources contenues dans la 'liste forcée'. Par conséquent, si un chemin de processus appelle un groupe de ressources dans une opération en aval qui contenait des ressources qui ne sont pas membres de la liste, elles ne seront pas utilisées lors de l'ordonnancement. La fonction Définir le groupe de ressources suivant est une fonction cumulative et peut être utilisée dans plusieurs opérations d'un chemin de processus, en ajoutant des ressources à la 'liste forcée'.":
6190 "La fonction Redéfinir le groupe de ressources suivant supprime les ressources, contenues dans le groupe de ressources sélectionné, de la 'liste forcée' établie par la commande Définir le groupe de ressources suivant. Si un groupe de ressources conceptuel, 'Tous' a été établi, qui comprenait toutes les ressources disponibles, celles utilisées par les opérations suivantes sont celles configurées dans le chemin de processus d'origine.":
6230 "Ce champ permet de définir un temps de réglage, en convertissant le produit précédent en produit actuel. Les valeurs dans le champ Temps de réglage seront ajoutées aux valeurs de réglage établies pour la ressource par une matrice Temps de réglage dépendant de l'ordonnancement.":
6430 "Sélectionnez un nom d'icône dans la zone de liste déroulante. Le bouton Éditer permettra de créer des icônes.":
6470 "Affiche la boîte de dialogue Contraintes secondaires valides, qui permet d'appliquer individuellement des contraintes valides aux enregistrements dans cette table. Les caractéristiques d'utilisation des contraintes peuvent être également éditées ici.":
6530 "Indique l'intervalle de temps maximum qui sera autorisé entre deux opérations séquentielles. L'intervalle de temps maximum est qualifié par le champ 'Type d'intervalle' qui établit les relations de début à début, de fin à fin, etc.":
6540 "Établit la relation utilisée pour interposer l'intervalle de temps maximum entre deux opérations contigües, définie dans le champ 'Temps max avant prochaine op' . Ceci peut être une relation 'Fin à fin', 'Début à fin', 'Début à début' ou 'Début à fin'.":
6550 "Indique la période maximum, exprimée en pourcentage du temps de processus théorique, au cours de laquelle une opération peut se prolonger lorsque l'ordonnanceur la planifie automatiquement.":
6560 "Définit une période creuse donnée à intégrer entre cette opération et la précédente.":
6565 "Définit une période creuse donnée à intégrer entre cette opération et la suivante.":
6580 "Ce champ permet d'appliquer un ordre de multiplicateur de taux de processus pour influencer la durée de l'opération.":
6681 "Ce champ permet de préciser un attribut de cet enregistrement qui est référencé à partir d'une des tables d'attributs. Il peut être utilisé pour influencer les temps de réglage, l'ordre d'ordonnancement et l'utilisation des contraintes.":
6682 "Ce champ permet d'indiquer un attribut de chaîne de format libre de cet enregistrement. Il peut être utilisé pour définir les options d'affichage et les opérations de groupes.":
6683 "Ce champ permet d'indiquer un attribut numérique de cet enregistrement. Il peut être utilisé pour définir les options d'affichage, influencer l'ordre d'ordonnancement et l'utilisation des contraintes.":
6684 "Ce champ permet d'indiquer un attribut de date de cet enregistrement. Il peut être utilisé pour définir les options d'affichage et influencer l'ordre d'ordonnancement.":
6685 "Ce champ permet d'indiquer un attribut de durée de cet enregistrement. Il peut être utilisé pour définir les options d'affichage et influencer l'ordre d'ordonnancement.":
6690 "Le champ Tampon de livraison contient une marge soustraite de l'échéance lors de l'ordonnancement inverse si bien que les opérations sont planifiées bien plus en avance. Ceci permet des retards inattendus dans le processus.":
7020 "Le nombre de jours avant le délai actuel qui peut être affiché dans l'aperçu de l'ordonnancement.":
7030 "La période, après le délai actuel qui peut être affichée dans l'aperçu de l'ordonnancement.":
7035 "Ouvre une boîte de dialogue de réglage de la configuration qui permet de personnaliser l'aperçu de l'ordonnancement.":
7040 "Indique un décalage, à partir de l'heure de saisie de l'ordre, avant lequel une tâche peut être commencée. Si paramétré sur Indéfini, il n'y a aucune autre restriction que le délai en cours.":
7050 "Indique un décalage, à partir de l'heure de saisie de l'ordre, de disponibilité d'une tâche. Peut être remplacé.":
7060 "La période de décalage de la terminaison par rapport au délai actuel. La terminaison représente le délai actuel lorsque le décalage de la terminaison est réglé sur 0 heure 00 min.":
7067 "Établit les options de calcul des coûts. Ce sont : Durant l'ordonnancement, Après l'ordonnancement ou Jamais.":
7120 "Définit le mode aperçu de l'ordonnancement.":
7130 "Le nombre de jours à compter de maintenant pour commencer l'aperçu de l'ordonnancement.":
7140 "Le nombre de jours à compter de maintenant pour terminer l'aperçu de l'ordonnancement.":
7320 "Permet de sélectionner le script nécessaire à l'importation des ordres dans la table de données 'Scripts'.":
7330 "Permet de sélectionner le script nécessaire à l'exportation des ordres dans la table de données 'Scripts'.":
7430 "Lorsque sélectionné, ce  champ bascule active un petit triangle noir par rapport à chaque barre d'opération dans l'ordonnanceur. Cette fonction permet de faire glisser plus facilement les opérations allouées sur le tableau de planification, surtout les plus petites opérations.":
7450 "Indique le script d'événement PESP par défaut qui devrait être exécuté lors de l'importation des ordres depuis le bouton 'Importer ordres' dans le Menu de transfert des données.":
7470 "Indique le script d'événement PESP par défaut qui devrait être exécuté lors de l'exportation des ordres depuis le bouton 'Exporter ordres' dans le Menu de transfert des données.":
7480 "Indique le script d'événement PESP par défaut qui devrait être exécuté lors de la publication d'un planning depuis le bouton 'Publier planning' dans le Menu de transfert des données.":
7490 "Indique le script d'événement PESP par défaut qui devrait être exécuté lors de l'affectation d'opérations dans l'ordonnanceur avec l'option Règles APS activée.":
8020 "Nom de contrainte secondaire.":
8030 "Permet de sélectionner la couleur du graphe utilisateur de l'ordonnanceur lorsque les valeurs se situent entre les limites basse et haute.":
8040 "Définit le motif de remplissage du graphe.":
8060 "Couleur de remplissage du graphe si celui-ci doit franchir la limite supérieure du graphe.":
8080 "Couleur de remplissage du graphe si celui-ci doit franchir la limite inférieure du graphe.":
8090 "Indique si cette contrainte secondaire doit ou non restreindre le planning lorsque vous utilisez un produit 300 FCS ou ultérieur. Dans toutes les versions, la non-sélection de cette case empêchera l'ordonnanceur de générer des avertissements si les limites définies pour cette contrainte secondaire sont dépassées.":
8091 "En Mode d'ordonnanceur de capacité infinie, ce champ indique si cette contrainte secondaire doit restreindre le planning lorsque vous utilisez un produit 300 FCS ou ultérieur.":
8092 "Options pour contrôler le comportement de cette contrainte lorsque le système est défini sur le mode capacité infinie.":
8100 "Détermine la manière dont l'efficacité du calendrier de ressources principales influence l'utilisation de cette contrainte secondaire. Les options sont les suivantes : Aucun effet, Début de l'efficacité tâche, Suivre modifications efficacité, Utiliser 100 % si supérieure à 0 %":
8101 "En Mode d'ordonnanceur de capacité infinie, ce champ détermine la manière dont l'efficacité du calendrier de ressources principales influence l'utilisation de cette contrainte secondaire. Les options sont les suivantes : Aucun effet, Début de l'efficacité tâche, Suivre modifications efficacité, Utiliser 100 % si supérieure à 0 %":
8120 "Ce bouton ouvre une boîte de dialogue indiquant les différents attributs associés à la contrainte secondaire.":
8130 "Ce champ permet de saisir les données d'attributs de chaîne pour la contrainte secondaire.":
8140 "Ce champ permet de saisir les données d'attributs réels pour la contrainte secondaire.":
8150 "Ce champ permet de saisir les données d'attributs de durée pour la contrainte secondaire.":
8160 "Lorsqu'elle sera activée, cette bascule affichera un graphe d'utilisation de la contrainte secondaire dans la fenêtre multi-graphe de l'ordonnanceur.":
8200 "Le nom du groupe de Contraintes secondaires.":
8210 "Permet de sélectionner quelles Contraintes secondaires sont membres de ce groupe.":
9020 "Noms du groupe de réglage. Ceux-ci forment les axes X et Y de la matrice Temps de réglage dépendant de l'ordonnancement dans la table de données Ressources.":
12020 "Nom de l'enregistrement d'attribut dans la table de données Attribut 1 de produit.":
13020 "Nom de l'enregistrement d'attribut dans la table de données Attribut 2 de produit.":
14020 "Nom de l'enregistrement d'attribut dans la table de données Attribut 3 de produit.":
16020 "Le nom utilisé pour décrire la configuration de l'affichage de l'écran enregistrée sous le Nom de fichier. Cette description est également utilisée comme info-bulle pour les icônes de la barre d'outils de l'espace de travail.":
16030 "Le fichier est choisi par sélection d'un fichier depuis l'option proposée par le bouton à gauche du champ. Le fichier de configuration de l'espace de travail d'origine est enregistré, avec une extension de fichier .WPI, en utilisant la commande Enregistrer espace de travail dans le menu Ordonnanceur.":
18510 "Le nom de l'individu ou de l'organisation qui a effectué un ordre.":
18520 "Nom du contact primaire dans une organisation qui a effectué un ordre.":
18530 "Numéro de téléphone à utiliser conjointement avec un ordre.":
18540 "Adresse électronique à utiliser conjointement avec un ordre.":
21000 "Ce champ permet la saisie d'un 'statut ordre' différent. Le statut de l'ordre peut être sélectionné pour un ordre dans le fichier Planning.":
21020 "Ce champ est utilisé pour contenir la description de la signification du nom du statut de l'ordre saisi dans le champ 'Nom statut ordre'.":
21100 "Nom de l'enregistrement d'attribut dans la table de données Attribut.":
21110 "Utilisé pour établir un classement prioritaire entre les enregistrements dans la table de données Attribut, qui peuvent être utilisés par les règles d'ordonnancement":
24000 "Ce champ indique si l'enregistrement est un enregistrement parent de l'ensemble de règles ou un enfant.":
24010 "Contient le nom de l'ensemble de règles.":
24020 "Cette bascule permet d'effacer les liens de rattachement pour les ordres qui figurent dans la file d'attente de ventes du premier passage (qu'elle soit activée ou non) de l'ensemble de règles.":
24030 "Contient le nom de la fonction spécifique du passage de règle.":
24040 "Une bascule qui lorsque définie sur vrai active le passage de règle. Lorsque définie sur faux, ce passage de règle spécifique sera ignoré lors de l'exécution de l'ensemble de règles.":
24050 "Lorsque cette bascule sera définie sur vrai, et l'ensemble de règles est exécutée, un fichier de débogage sera créé dans le répertoire de travail.":
24060 "Ce champ permet d'indiquer les critères qui peuvent être utilisés pour restreindre les items placés dans la file des approvisionnements internes.  La valeur par défaut de ce champ est définie comme TOUT, mais vous pouvez la modifier en saisissant une expression, par ex : (~{$Order Type}~==~Stock~).  Cette file d'attente filtre les enregistrements contenus dans la base de données 'Ordres de travail'.":
24070 "Ce champ contient les critères qui peuvent être utilisés pour classer les items dans la file d'approvisionnements internes. Par exemple, vous pouvez classer la file d'offres internes par Échéance, Date de début au plus tôt ou Priorité.":
24080 "Ce champ permet d'indiquer les critères qui peuvent être utilisés pour restreindre les items placés dans la file de ventes.  La valeur par défaut de ce champ est définie comme TOUT, mais vous pouvez la modifier en saisissant une expression, par ex : (~{$Order Type}~==~Stock~).  Cette file d'attente filtre les enregistrements contenus dans la base de données 'Ordres de travail'.":
24090 "Ce champ contient les critères qui peuvent être utilisés pour classer les items dans la file de ventes internes. Par exemple, vous pouvez classer la file de ventes internes par Échéance, Date de début au plus tôt ou Priorité.":
24100 "Ce champ contient une liste des différentes règles standard de rattachement qui permettent de rattacher les ordres. Elle contient également trois items spéciaux – Défini par l'utilisateur, Fonction utilisateur et Script PESP qui permettent de créer des règles plus personnalisées.":
24110 "Ce champ n'est visible que lorsque le champ 'Type de règle' est paramétré sur 'Défini par l'utilisateur' ou 'Fonction utilisateur'. L'expression à utiliser pour la règle est saisie dans ce champ. Exemple : (~{+:$Product Attribute 1}~==~{-:$Product Attribute 1}~) permettant uniquement de relier les ordres d'approvisionnements et de ventes si les champs de 'Attribut 1 de produit' possèdent la même valeur.":
24120 "Ce champ n'est visible que lorsque le champ 'Type de règle' est défini sur 'Script PESP'. Ce champ contient le nom du script PESP à utiliser comme règle.":
24130 "Cette option permet de créer des liens sur les lignes de nomenclature là où il n'est pas nécessaire que la quantité de la ligne de nomenclature soit entièrement satisfaite pour que le lien soit créé. Les éléments qui manquent seront mis en évidence comme manquants.":
24140 "Cette option permet uniquement de créer des liens sur les lignes de nomenclature là où il n'est pas nécessaire que la quantité de la ligne de nomenclature soit entièrement satisfaite. Les éléments qui manquent seront mis en évidence comme manquants.":
24141 "Lorsque cette option est cochée, le comportement par défaut de SMC est ignoré en permettant la création de liens retour lorsque la production a lieu après la consommation.":
24150 "Lorsque l'option est définie sur vrai, les ordres déjà planifiés peuvent être liés de nouveau.":
24160 "Lorsque cette bascule est définie sur vrai, le champ 'Classement des files d'approvisionnements' s'active et permet de classer les enregistrements d'offres en fonction des critères de sélection dans le champ 'Classement des files d'offres'. Cette option ne devrait être sélectionnée que si tous les enregistrements sont conservés dans la base de données 'Ordres de travail'.":
24170 "Ce champ permet d'indiquer les critères qui peuvent être utilisés pour restreindre les items placés dans la file d'attente d'approvisionnements externes. La valeur par défaut de ce champ est définie comme TOUT, mais vous pouvez la modifier en saisissant une expression, par ex : (~{$Order Type}~==~Stock~).  Cette file d'attente filtre les enregistrements contenus dans la base de données 'Ventes'.":
24180 "Tout champ avec la classification INHERIT FROM SUPPLY(Nom du champ) sera traité.":
24190 "Tout champ avec la classification INHERIT FROM DEMAND(Nom du champ) sera traité.":
24200 "Lorsque cette bascule est définie sur vrai, le champ 'Classement des files de ventes' s'active et permet de classer les enregistrements de ventes en fonction des critères de sélection dans le champ 'Classement des files de ventes'. Cette option ne devrait être sélectionnée que si tous les enregistrements sont conservés dans la base de données 'Ordres de travail'.":
24210 "La quantité d'un lien créé sera affectée dans des multiples spécifiques lorsque cette bascule est définie sur vrai. Ce multiple est indiqué dans les données de la nomenclature.":
24500 "Si le champ bascule 'Toujours utiliser l'ensemble de règles' est coché, l'ensemble de règles de rattachement sélectionné sera celui exécuté par défaut lorsque l'option 'Rattacher matériaux' est sélectionnée dans l'ordonnanceur.":
24505 "Lorsque cette option globale est cochée, le comportement par défaut de SMC est ignoré en permettant la création de liens retour lorsque la production a lieu après la consommation.":
24510 "Lorsqu'elle sera cochée, cette bascule utilisera la règle sélectionnée dans le champ 'Ensemble de règles de rattachement sélectionné'. Si l'option 'Toujours utiliser cet ensemble de règles' est décoché, une boîte de dialogue de sélection des règles s'affichera lorsque vous sélectionnez l'option 'Rattacher matériaux' dans l'ordonnanceur. Ceci permettra de sélectionner la règle qui doit être exécutée à ce moment spécifique.":
25400 "Ceci est le champ qui contient le numéro d'ordre d'approvisionnements.":
25410 "Ce champ identifie le type d'ordre, par exemple Stock ou Achat.":
25420 "Le nom de l'organisation fournissant les matériaux pour l'ordre.":
25430 "La référence associée à l'ordre.":
25440 "Description du composant associé à l'ordre.":
25450 "Date d'approvisionnement du matériau.":
25500 "Ce champ permet d'identifier l'ordre associé au composant. La première ligne d'un ordre sera l'enregistrement parent et affichera PARENT dans ce champ. Les autres lignes qui font partie de cet ordre seront les enregistrements enfants et afficheront le le numéro d'ordre auquel ils appartiennent dans ce champ.":
25510 "C'est le champ qui contient le numéro de l'ordre de ventes.":
25520 "Ce champ identifie le type d'ordre, par exemple Production sur stock ou Ordre de ventes.":
25530 "Identifie de façon unique un poste d'ordre.":
25540 "Le nom de l'organisation exigeant les matériaux de l'ordre.":
25550 "Date à laquelle le matériau est requis.":
25560 "Spécifie le multiple d'un élément qui doit être rattaché. Plusieurs éléments composeront souvent une caisse ou une boîte. Par exemple, 12 conserver peuvent composer 1 boîte, une commande de 60 conserves arrive. Il y a une commande pour 50 conserves. Le contrôle des composants n'établira un lien qu'avec 48 conserves sur les 50. Il recherchera ailleurs les 12 conserves restantes dont il a besoin, mais il ne fera le lien que s'il ne trouve la quantité exacte de 12. Le champ 'Allocate Multiples Only' doit être coché dans la base de données  'Pegging Rules' pour pouvoir activer cette fonctionnalité.":
25600 "Numéro d'ordre associé à la ligne de nomenclature.":
25605 "Référence de l'ordre associée à la ligne de nomenclature.":
25610 "Numéro d'opération associé à la ligne de nomenclature.":
25611 "Nom de l'opération associé à la ligne de nomenclature.":
25615 "Référence du produit qui nécessite le matériau indiqué":
25620 "Référence de l'item de nomenclature.":
25630 "Quantité requise de l'item de nomenclature.":
25640 "Lorsque défini sur vrai, ce champ permettra de multiplier la quantité de l'ordre par la quantité de nomenclature requise.":
25650 "Permet d'ignorer les manquants lors de l'exécution de la règle de rattachement. Permet de planifier les ordres avec des manquants.":
25700 "Numéro d'ordre dans lequel le co-produit est produit.":
25705 "Référence de l'ordre dans lequel le co-produit est produit.":
25710 "Numéro d'opération qui crée le co-produit.":
25715 "Nom d'opération qui crée le co-produit.":
25720 "Nom du co-produit.":
25730 "Quantité de co-produit produit.":
25740 "Quand défini sur vrai, ce champ entraîne la multiplication de la quantité du co-produit par la quantité d'ordre.":
25800 "Ce champ identifie le type d'ordre, par exemple : Ordre de travail, Ordre d'achat, Ordre de ventes ou Stock":
25810 "Lorsque coché, l'opération non planifiée ne sera plus affichée dans la fenêtre 'Opérations non planifiées'.":
25820 "Affiche une boîte de dialogue indiquant les champs associés au contrôle des matériaux.":
25830 "Ce champ contient des informations sur le statut de ventes après le rattachement des matériaux. Il contiendra une des valeurs suivantes : 'Inconnu', 'Satisfait, 'Tous les manquants ignorés', 'Manquants', 'Sur-approvisionné', 'Sur-approvisionné, Manquants', 'Sur-approvisionné, Tous les manquants ignorés'.":
25840 "Ce champ est rempli après le rattachement des matériaux. Lorsqu'un lien a été créé vers un ordre d'approvisionnements dans la base de données 'Ordres d'approvisionnements', le champ 'Date de demande' dans la base de données 'Ordres de travail' est rempli avec la 'Date d'approvisionnement' de l'ordre d'approvisionnements associé. Le champ 'Date d'approvisionnement' sera évalué par rapport au champ 'Date de début la plus récente' et la dernière des deux dates sera utilisée pour déterminer quelle date doit être utilisée lors de la planification.":
25850 "Ce champ est rempli après le rattachement des matériaux. Lorsqu'un lien a été créé vers un ordre de demandes dans la base de données 'Ordres de ventes', le champ 'Date d'approvisionnement' dans la base de données 'Ordres de travail' est rempli avec la 'Date de vente' de l'ordre de ventes associé. Le champ 'Date de vente' sera évalué par rapport au champ 'Échéance' et la plus récente des deux dates sera utilisée pour déterminer quelle date doit être utilisée lors de la planification.":
25900 "Affiche une boîte de dialogue avec les champs associés au statut d'une opération.":
25910 "Vous pouvez sélectionner cette option lorsqu'une commande est fragmentée. Cette option permet un traitement indépendant de chaque lot de production dans le processus de fabrication. Par exemple, il n'est pas nécessaire que tous les lots soient terminés en une seule opération avant de commencer l'opération suivante.":
25920 "Ce champ indique la couleur utilisée sur la barre du diagramme de Gantt pour cet enregistrement.":
26000 "Ce champ définit le nom du groupe de changement":
26100 "Ce champ définit le temps de changement requis lorsque l'attribut a indiqué des changements entre les opérations planifiées l'une à la suite de l'autre.":
26200 "Le nom complet de l'outil utilisateur":
26210 "Le script d'événement que l'outil utilisateur exécutera lorsque sélectionné":
26220 "Le nom du menu outil de la fenêtre utilisateur":
26230 "La fonction code pour remplir le contenu de la fenêtre utilisateur":
26240 "Le libellé de la fenêtre utilisateur":
26300 "Le nom du bouton de menu. Ceci donne une indication de l'emplacement de l'affichage du bouton dans le système de menus":
26310 "Ce champ contrôle si le bouton est activé ou non et par conséquent s'il s'affiche":
26320 "Ce champ contrôle le texte qui apparaîtra sur le bouton":
26330 "Le script d'événement que le bouton de menu exécutera lorsque sélectionné":
;
