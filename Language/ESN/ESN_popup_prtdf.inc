#VERSION 0
;
ESN POPUP HELP
1 "No hay ningún tema de ayuda asociado con este ítem.":
10 "Este campo se utiliza para identificar a qué orden pertenece la pieza. En la primera operación de una orden se fija en PARENT, en otras operaciones se fija en el número o nombre de orden único.":
40 "Este campo se utiliza para identificar el número de pieza. Al pulsar el botón se mostrarán todos los números de pieza en la tabla de datos de producto. Si selecciona un número de pieza, cambiará automáticamente el nombre del producto.":
41 "Este campo contiene una lista de diferentes estatus que se pueden definir según una orden. Los valores se toman de la tabla de datos Estatus de orden, donde se puede agregar un estatus nuevo si es necesario. Se puede utilizar un patrón de barra de operación, fijado en la tabla de datos Estatus de orden según cada tipo de estatus, para definir el patrón de la barra de operaciones de la orden cuando esta esté programada en el secuenciador.":
45 "Este campo se utiliza para identificar el número de pieza.":
50 "Este campo se utiliza para identificar el nombre del producto. Utilice el botón para seleccionar el nombre y el número de pieza cambiará automáticamente.":
55 "Este campo se utiliza para identificar el nombre del producto.":
60 "Este campo se utiliza para identificar el número de orden de este producto. La orden podría ser un número de orden interno o uno especificado por el cliente. El número de orden debe ser único.":
70 "Este campo se puede utilizar para que contenga notas sobre esta orden. Podría ser un recordatorio con respecto a las fechas de vencimiento o simplemente un mensaje para el empaquetador/ensamblador en el taller.":
75 "Abre un cuadro de diálogo que muestra toda la información de atributos de la operación.":
80 "Utilice este campo para fijar la prioridad del trabajo que, a su vez, utilizará el secuenciador. Cuanto menor sea el número, mayor será la prioridad. Tenga en cuenta que las prioridades pueden ser negativas; una prioridad negativa es mayor que una positiva. Por ejemplo, -100 es superior a -1 y 0 es mayor que 10.":
90 "Este campo fija el número de operación de un trabajo. Se utiliza para secuenciar el trabajo en el secuenciador. Las operaciones de número más bajo se completarán antes de iniciar operaciones de número más alto. Si hay dos operaciones con el mismo número en un producto, ambas se completarán antes de que se inicien los números de operación más altos.":
110 "Es una descripción o nombre escritos de la operación que tiene lugar, también identificada por el número de operación.":
112 "Abre un cuadro de diálogo que contiene información acerca de los datos de recursos asignados a esta operación":
120 "Los grupos de ajuste inicial se definen en la tabla de datos Grupos de ajuste inicial, por ejemplo, Grupo de ajuste inicial 1, Grupo de ajuste inicial 2, etc. Estos valores se utilizan como ejes de una de las matrices de tiempo de ajuste inicial dependiente de la secuencia, que establece el tiempo de cambio entre productos en diferentes grupos de ajuste inicial (normalmente se ajustan en la tabla de datos de recursos). Los grupos de ajuste inicial individuales se asignan a los productos de la tabla de datos Productos, aunque este valor predeterminado se puede sobrescribir en el archivo de programación principal.":
130 "Este campo identifica el grupo de recursos válidos que puede llevar a cabo la operación actual.":
140 "Si es necesario, este campo se puede utilizar para identificar un recurso específico que debe procesar la operación. Si en la tabla de datos de productos se ha configurado como 'Seleccionar del grupo', se podría utilizar cualquiera de los recursos del grupo que se muestra en el campo Grupo de recursos. Si desea forzar la operación en un recurso específico del grupo, utilice la lista desplegable para seleccionar el recurso necesario.":
150 "Este campo mostrará el recurso real que procesará la operación. Si la orden no se ha programado antes, se fijará como 'No especificado'. Si la operación ya se ha cargado en el panel de planificación, se mostrará el recurso en el que está configurado para cargarse.":
180 "Este campo se utiliza para indicar si la velocidad de procesamiento se calcula como tiempo por lote, tiempo por ítem o velocidad por hora. Si se selecciona 'Tiempo por lote', el tiempo indicado en el campo siguiente es el necesario para procesar todas las piezas del lote. Si se selecciona 'Tiempo por ítem', el tiempo de proceso será el valor del campo siguiente multiplicado por el tamaño del lote. Si se selecciona 'Velocidad por hora', el tiempo de proceso se calculará directamente a partir del número del lote.":
220 "Actualmente ha seleccionado el tipo de tiempo de proceso 'Tiempo por ítem'. Debe especificar un tiempo de operación para cada ítem en este campo.":
230 "Actualmente ha seleccionado el tipo de tiempo de proceso 'Tiempo por lote'. Debe indicar un tiempo de operación total para el lote en este campo.":
240 "Actualmente ha seleccionado el tipo de tiempo de proceso 'Velocidad por hora'. Debe indicar cuántos ítems se pueden producir por hora en este campo.":
251 "El color de este campo indica al secuenciador que muestre una sección de la barra de diagramas de Gantt en un color distinto. El color marca la barra según el valor que se ha introducido en los campos Cantidad de lote media y Tiempo de lote medio.":
260 "Este campo se utiliza para especificar la cuenta de orden o de lote.":
270 "Este campo se utiliza para especificar el beneficio de orden o de lote que se puede utilizar para influir en la secuencia cuando al usar la regla de ponderación.":
280 "Este campo mostrará la hora de inicio de la primera operación en esta orden si la característica Crear intervalo está activada":
290 "Este campo mostrará la hora de finalización de la última operación en esta orden si la característica Crear intervalo está activada":
300 "Este valor determina la cantidad que debe procesarse para que se pueda iniciar la operación posterior. El valor No especificado impide el solape de operaciones":
360 "Se utiliza para especificar una fecha antes de la cual no se puede iniciar el trabajo. Podría ser, por ejemplo, el momento en el que los materiales estarán disponibles.":
370 "Este campo se usará para establecer la fecha de vencimiento. La fecha de vencimiento se utiliza para resaltar los ítems retrasados en el secuenciador y para priorizar la carga de trabajos en el panel de planificación si se selecciona la opción 'Fecha de vencimiento'.":
380 "Seleccione este conmutador para indicar al programador que lass hora de inicio y de finalización son valores 'reales'. Cuando se configura, este conmutador impide que se anule la selección de la orden en cualquiera de los recursos del secuenciador. De hecho, se fija permanentemente en el panel de planificación.":
390 "El programador fija este campo durante la secuencia en el momento en que se ha programado el trabajo para iniciar el proceso de ajuste inicial.":
400 "El programador actualiza este campo durante la secuencia en el momento en que se ha programado el inicio del trabajo.":
410 "El programador actualiza este campo durante la secuencia en el momento en que se ha programado la finalización del trabajo.":
420 "Configure este conmutador si no desea que se anule la asignación de este trabajo después de seleccionar Anular la selección de todos los trabajos en el secuenciador. Esto bloqueará la operación. También se puede lograr cuando se utiliza el modo de ubicación 'Resaltar operaciones bloqueadas' el modo en el secuenciador al señalar con el ratón una operación (icono o barra en la descripción general), al pulsar la tecla Mayús en el teclado y al pulsar el botón izquierdo del ratón.":
421 "Las operaciones que tienen este conmutador activado se dejarán sin asignar en la ventana de operaciones no asignadas al planificar automáticamente las operaciones.":
430 "Permite que las características definibles por el usuario se atribuyan a los productos, por ejemplo, color. En una característica específica, los registros de atributos obtienen una clasificación de prioridad, por ejemplo, los productos de color 'blanco' pueden tener una prioridad mayor que los de color 'amarillo'. Estos atributos se utilizan en las reglas de secuenciación preferidas del programador, con lo que se consolidan órdenes similares en la previsión.":
440 "Rellene la información sobre la cantidad completada y especifique la hora en la que se completó el 'lote de pieza' en el campo Tiempo de lote medio. El programador volverá a calcular automáticamente la 'hora de finalización' de esta operación.":
450 "Rellene el tiempo en que se completó el 'lote de pieza' e introduzca la información sobre la cantidad completada en el campo Cantidad de lote media. El programador volverá a calcular automáticamente la 'hora de finalización' de esta operación.":
460 "El campo Tiempo de operación efectivo utiliza entradas en los campos 'Cantidad de lote media' y 'Tiempo de lote medio' para calcular un tiempo de operación revisado según esta información. Debe tenerse en cuenta que para que esta función opere correctamente, se deben modificar los valores de 'Tiempos de lote medios' y 'Cantidades de lote medias' cuando se muestre el editor en el secuenciador; de lo contrario, el valor de 'Tiempo operativo efectivo' solo cambiará la próxima vez que se acceda al secuenciador.":
474 "Se utiliza para registrar el coste de un ítem en el punto donde se incorpora al proceso. El campo se puede utilizar para registrar costes fijos por ítem, como el tratamiento térmico de subcontrato, etc.":
476 "Utiliza el coste de material por ítem para proporcionar el coste de material del lote en el punto en que el coste por ítem se incorpora al proceso.":
477 "Coste directo del trabajo en el proceso actual.":
530 "Establece un horizonte temporal en el que los trabajos pueden agruparse para la producción. Un recurso que complete una operación del panel de planificación esperará ese punto a lo largo del horizonte temporal establecido por el intervalo de previsión. Los criterios de secuencia preferidos, ajuste inicial en la tabla de datos de recursos, se aplican para seleccionar trabajos del trabajo cuya fecha de vencimiento esté dentro de este horizonte temporal. El intervalo de previsión se puede establecer en productos individuales, en la tabla de datos de productos, y modificarse para las órdenes individuales en el archivo de programación principal o se puede establecer como una regla global en la información del ajuste inicial de la configuración.":
540 "Se establece en la tabla de datos de productos y proporciona acceso a un documento de Word que puede contener información sobre el producto. También se puede acceder al documento y editarlo desde el editor de archivos de la programación principal.":
541 "Este campo se utiliza para describir el avance de una operación individual. Hay cuatro estados de avance distintos: no iniciada, ajuste inicial, en ejecución y completada":
550 "Los productos pueden tener asociadas características concretas; en el programador se ajustan en la tabla de datos de atributo. Estas tablas están definidas por el usuario y, por ejemplo, la tabla de atributos de producto 1 puede reservarse para el color, donde los registros individuales se denominarían rojo, azul, verde, etc. Los atributos de producto pueden seleccionarse en el campo de concordancia similar de la tabla de datos de producto para definir un tiempo de ajuste inicial similar.":
560 "Se utiliza para establecer una clasificación de prioridad entre registros en la tabla de datos de atributos de producto 1, utilizada por la selección de secuencias de reglas APS.":
570 "Los productos pueden tener asociadas características concretas; en el programador se ajustan en las tablas de datos de atributo. Estas tablas están definidas por el usuario y, por ejemplo, la tabla de atributos 2 puede reservarse para el material, donde los registros individuales se denominarían acero, bronce, cobre, etc. Los atributos de producto pueden seleccionarse en el campo de concordancia similar de la tabla de datos de producto para definir un tiempo de ajuste inicial similar.":
580 "Se utiliza para establecer una clasificación de prioridad entre registros en la tabla de datos de atributos de producto 2, utilizada por la selección de secuencias de reglas APS.":
590 "Los productos pueden tener asociadas características concretas; en el programador se ajustan en las tablas de datos de atributo. Estas tablas están definidas por el usuario y, por ejemplo, la tabla de atributos 3 puede reservarse para los anchos de material, donde los registros individuales se denominarían 5 m, 6 m, 7 m, 8 m, etc. Los atributos de producto pueden seleccionarse en el campo de concordancia similar de la tabla de datos de producto para definir un tiempo de ajuste inicial similar.":
600 "Se utiliza para establecer una clasificación de prioridad entre registros en la tabla de datos de atributos de producto 3, utilizada por la selección de secuencias de reglas APS.":
602 "Este campo calcula la duración de toda la orden desde la hora de inicio del ajuste inicial de la primera operación hasta la hora de finalización de la última operación de la orden.":
620 "Una regla de envío que calcula un número de índice dividiendo el tiempo hasta la fecha de vencimiento restante entre el tiempo transcurrido esperado para terminar el trabajo. Un coeficiente inferior a 1 indica que el trabajo está atrasado y más de 1 indica que está adelantado con respecto a la programación.":
815 "Esta opción permite establecer los valores de los tiempos de ajuste inicial y de operación. También se utiliza para actualizar el avance de los trabajos en el sistema de producción.":
1020 "Especifica el nombre del grupo de recursos. Se utilizará para identificar grupos de recursos específicos, capaces de desempeñar funciones similares.":
1030 "Identifica los recursos válidos del grupo de recursos. Un recurso puede ser un miembro de varios grupos.":
1060 "Cuando se activa, este conmutador mostrará un ploteo de uso del grupo de recursos en la ventana de ploteo múltiple del secuenciador.":
1070 "Este color se mostrará en el ploteo de uso que está visible en la ventana de ploteo múltiple del secuenciador.":
1080 "El ploteo de uso, presente en la ventana de ploteo múltiple del secuenciador, mostrará este color cuando el uso supere el número de horas disponibles del recurso o grupo de recursos (si el campo Horas máx. de uso se ha fijado en No especificado). Si se ha introducido un valor en el campo Horas máx. de uso, el ploteo cambiará de color según este valor.":
1090 "El ploteo de uso, en la ventana de ploteo múltiple del secuenciador, utilizará este color para dibujar una línea que marque el uso de ajuste inicial medido en horas.":
2020 "Especifica el nombre del recurso individual.":
2023 "El coste por hora de ejecutar el recurso.":
2024 "Aplica los valores de '% de factor de coste', establecidos en los registros de calendario maestro, según el coste por hora del recurso.":
2030 "Este cuadro de diálogo contiene información sobre la forma en que se va a mostrar un recurso o un grupo de recursos en la ventana Descripción general de la secuencia y en Ploteos de uso.":
2040 "Se puede fijar en Visible, Minimizado o Desactivado. Se utiliza para controlar el estado inicial de la ventana de este recurso cuando se inicia el secuenciador. Normalmente se fija en Mínimo. Si se fija en Desactivado, el recurso no se utiliza para la secuenciación.":
2050 "Controla la escala horizontal (tiempo) de las ventanas de recursos de Gantt en el secuenciador. Puede variar de minutos a semanas por unidad.":
2070 "Permite fijar una capacidad de recursos en Finito, Infinito o Infinito con patrones de cambio.":
2071 "Permite fijar una capacidad de recursos en Finito, Infinito o Infinito con patrones de cambio cuando se ejecuta en el modo de secuenciador de capacidad infinita.":
2080 "Controla la escala horizontal (tiempo) de las ventanas de recursos en mosaico en el secuenciador.":
2100 "Selecciona las restricciones secundarias que se aplicarán a un recurso primario. Especifica la cantidad de restricciones que requiere el recurso y la forma en que se aplica la restricción al recurso primario.":
2110 "Estipula cuándo se debe incrementar o disminuir el uso del recurso secundario, por ejemplo, Incrementar en duración, que utiliza la restricción secundaria mientras dura la operación y la libera al terminar. Si se emplaza un trabajo en una fijación para varias operaciones, se puede especificar Incremento al iniciar en la primera operación y Disminución al finalizar en la última operación. Esto asegurará que la fijación no se pueda usar en otro trabajo mientras el primer trabajo esté esperando un recurso.":
2120 "Especifica la cantidad requerida de la restricción secundaria. Si se selecciona el valor 'Cantidad', la cantidad requerida es igual a la cantidad de lote que se está procesando.":
2130 "Define un atributo de una operación que evitará que se realicen simultáneamente operaciones diferentes en un recurso de capacidad infinita.":
2150 "Se utiliza en los productos APS para establecer los criterios que usarán las reglas de secuenciación preferidas al seleccionar el trabajo para el procesamiento.":
2160 "Se utiliza en los productos APS, mediante reglas de programación del tipo 'Minimizar WIP', para establecer búferes de tiempo en los que se pueda acumular WIP, para prever los recursos seleccionados.":
2180 "Valor numérico que se utiliza para clasificar el orden en el que se muestran los recursos en la tabla de datos de recursos. También se puede utilizar para sustituir el orden predeterminado en el que se muestran los recursos en la descripción general de la secuencia.":
2181 "Muestra el cuadro de diálogo donde se pueden definir las opciones de restricción de recursos avanzadas si es necesario":
2182 "Permite la definición de relaciones complejas entre recursos mediante expresiones. Los detalles de la sintaxis y la creación de la expresión se pueden encontrar en la documentación.":
2183 "Permite al usuario seleccionar un atributo de una operación en un recurso de capacidad infinita que especifica que solo se pueden programar al mismo tiempo las operaciones con el mismo valor en el atributo seleccionado.":
2185 "Determina si se muestra una línea de separador debajo del recurso en el diagrama de Gantt. Esto puede ser de ayuda al visualizar recursos en grupos.":
2190 "Determina la forma en que se mostrará el recurso en la descripción general de la secuencia. Las alternativas son 'Siempre', 'Solo en grupo' y 'Ocultar'.":
2191 "Determina la forma en que se mostrarán las operaciones en la descripción general de la secuencia. Las opciones son 'Apiladas' donde las operaciones se muestran en una línea de descripción general y 'Cascada' donde cada operación se muestra en su propia línea de descripción general.":
2200 "Se utiliza para establecer una matriz de valores de ajuste inicial dependiente de la secuencia, que define el tiempo de ajuste inicial necesario para cambiar de un producto de un tipo de atributo a otro.":
2201 "Este campo fija qué grupo de cambio se asigna a este recurso y, como resultado, determina qué tiempos de cambio se aplican entre las operaciones con diferentes atributos.":
2202 "Determina si los tiempos de ajuste inicial y de cambio relacionados con las operaciones de este recurso se aplican de forma simultánea o acumulativa.":
2205 "El uso de este cuadro de marca para la inclusión del recurso en los cálculos de métricas de rendimiento de la programación.":
2210 "Este campo se utiliza para seleccionar a qué sistema de visualizador pertenece el recurso. El campo contiene una lista de los nombres de sistema del programador tomados de la tabla de datos de la libreta de direcciones de PCO.":
2220 "Este botón abre un cuadro de diálogo que enumera los diferentes atributos asociados al recurso.":
2230 "Este campo permite que los datos de atributo de tipo cadena se introduzcan en el recurso.":
2240 "Este campo permite que los datos de atributo de tipo real se introduzcan en el recurso.":
2250 "Este campo permite que los datos de atributo de duración se introduzcan en el recurso.":
2260 "Este campo indica la eficiencia de un recurso. El valor predeterminado es 100%. Si la eficiencia se cambia a 200%, cualquier operación programada en este recurso se procesaría dos veces más rápido (la mitad del tiempo de proceso normal).":
2270 "Se trata de un campo de conmutador que, al activarse, aplicará el valor del campo % de eficiencia a todas las operaciones que tengan tiempos de ajuste inicial y estén programadas en el recurso en el que se fija el conmutador.":
2280 "Cuando se activa, este conmutador mostrará un ploteo de uso del recurso en la ventana de ploteo múltiple del secuenciador.":
2300 "Utilice este campo para seleccionar un grupo de restricciones secundarias del cual se asignará una restricción secundaria cuando se realice la secuenciación.":
2310 "Las restricciones secundarias asignadas de un grupo de restricciones secundarias serán asignadas a este campo.":
5035 "Un multiplicador de factor de coste que influye en el gasto operativo del recurso al que se aplica. Un valor del 100% no aplica ningún aumento, un valor del 150% incrementa el gasto operativo en un 50%. Se establecen en la tabla de datos de estados de calendario y proporcionan los valores predeterminados utilizados en los archivos del calendario maestro.":
6100 "Muestra un cuadro de diálogo que permite seleccionar los recursos del grupo seleccionado que son válidos y la asignación de los datos específicos de recursos.":
6110 "Este campo determina si el recurso se seleccionará durante la secuenciación automática. Si no está marcado, la operación todavía puede emplazarse manualmente en el recurso.":
6120 "Este campo permite establecer un valor de tiempo de ajuste inicial individual en cada uno de los recursos que son válidos para la operación.":
6130 "Este campo permite establecer un tiempo de operación individual en cada uno de los recursos que son válidos para la operación.":
6131 "Este campo permite establecer una velocidad por hora individual en cada uno de los recursos que son válidos para la operación.":
6132 "Este campo permite establecer un tiempo de lote individual en cada uno de los recursos que son válidos para la operación.":
6140 "Este campo se usa para definir un recurso secundario utilizado por el recurso primario durante la operación actual.":
6150 "Este campo se utiliza para especificar cómo se utiliza la restricción secundaria durante la operación, por ejemplo, Incrementar en duración, Incrementar solo el tiempo de ajuste inicial, etc.":
6160 "Utilice este campo para indicar el volumen de la restricción secundaria requerida durante la operación actual, por ejemplo, puede especificar que la operación requiera un portabrocas fijo.":
6170 "El programador utilizará este periodo de tiempo para intentar cargar la operación actual en el recurso preferido. Si no puede hacerlo al final de este tiempo, intentará cargar la operación en otro recurso del grupo.":
6180 "El comando Fijar grupo de recursos subsiguientes establece una 'lista forzada' de recursos, es decir, los especificadas en el grupo seleccionado. 'Obliga' a que las operaciones descendentes o subsiguientes utilicen únicamente los recursos que están en la 'lista forzada'. Por lo tanto, si una ruta de proceso llama a un grupo de recursos en una operación descendente que contenía algunos recursos que no son miembros de la lista, estos no se usan al secuenciar. El comando Fijar grupo de recursos subsiguientes es una función acumulativa y se puede utilizar en más de una operación en una ruta de proceso, con la adición de recursos a la 'lista forzada'.":
6190 "La función Restablecer grupo de recursos subsiguientes quita todos los recursos, incluidos en el grupo de recursos seleccionado, de la 'lista forzada' establecida mediante el comando Fijar grupo de recursos subsiguientes. Si se estableciera un grupo de recursos conceptuales, 'Todo', que incluyera todos los recursos disponibles, los recursos utilizados por las operaciones subsiguientes serían los ajustados inicialmente en la ruta del proceso original.":
6230 "Este campo permite especificar un tiempo de ajuste inicial, con la conversión del producto anterior al actual. Los valores del campo Tiempo de ajuste inicial se agregarán a los valores de ajuste inicial establecidos para el recurso mediante una matriz de tiempo de ajuste inicial dependiente de la secuencia.":
6430 "Seleccione un nombre de icono en el cuadro desplegable. El botón Editar le permitirá crear iconos nuevos.":
6470 "Muestra el cuadro de diálogo Restricciones secundarias válidas, lo que permite aplicar restricciones válidas a registros individuales de esta tabla. Aquí también se pueden editar las características del uso de restricciones.":
6530 "Especifica el intervalo de tiempo máximo que se permitirá entre dos operaciones secuenciales. El intervalo de tiempo máximo se cualifica mediante el campo 'Tipo de intervalo' que establece relaciones 'Inicio a inicio', 'Fin a fin', etc.":
6540 "Establece la relación utilizada para interponer el intervalo de tiempo máximo entre dos operaciones contiguas, establecido en el campo 'Tiempo máximo antes de la próxima operación'. Puede ser una relación 'Fin a fin', 'Fin a inicio', 'Inicio a inicio' o 'Inicio a fin'.":
6550 "Especifica el periodo de tiempo máximo, expresado como un porcentaje del tiempo de proceso teórico, que puede ampliar una operación cuando el secuenciador lo secuencia automáticamente.":
6560 "Define un periodo de tiempo de retardo determinado entre esta operación y la anterior.":
6565 "Define un periodo de tiempo de retardo determinado entre esta operación y la siguiente.":
6580 "Este campo se puede utilizar para aplicar una orden de multiplicación de velocidad de proceso para influir en la duración de la operación.":
6681 "Este campo se utiliza para especificar un atributo de este registro al que se hace referencia desde una de las tablas de atributos. Se pueden utilizar para influir en los tiempos de ajuste inicial, el orden de programación y el uso de restricciones.":
6682 "Este campo se utiliza para especificar un atributo de cadena de formato libre de este registro. Se puede utilizar para fijar las opciones de visualización y las operaciones de grupo.":
6683 "Este campo se utiliza para especificar un atributo numérico de este registro. Se puede utilizar para fijar las opciones de visualización, influir en el orden de programación y el uso de restricciones.":
6684 "Este campo se utiliza para especificar un atributo de fecha de este registro. Se puede utilizar para fijar las opciones de visualización e influir en el orden de programación.":
6685 "Este campo se utiliza para especificar un atributo de duración de este registro. Se puede utilizar para fijar las opciones de visualización e influir en el orden de programación.":
6690 "El campo Reserva de entrega contiene un tiempo de reserva que se resta de la fecha de vencimiento en secuencias inversas para que las operaciones se programen antes del último tiempo posible. Se hace para permitir retrasos inesperados en el proceso.":
7020 "El número de días anteriores a la hora actual que se pueden mostrar en la descripción general de la secuencia.":
7030 "El periodo de tiempo, después de la hora actual, que se puede mostrar en la descripción general del secuenciador.":
7035 "Abre un cuadro de diálogo de ajuste inicial de la configuración que permite al usuario personalizar la descripción general de la secuencia.":
7040 "Especifica un desplazamiento, desde el momento de la entrada de la orden, antes del cual no se puede iniciar un trabajo. Si se fija en No especificado, no hay ninguna restricción aparte de la hora actual.":
7050 "Especifica un desplazamiento, desde el momento de la entrada de la orden, en el que el trabajo debería estar disponible. Puede sobrescribirse.":
7060 "El periodo de tiempo por el que el terminador se ha desviado de la hora actual. El terminador representa la hora actual cuando el desplazamiento del terminador se ha fijado en 0 horas 0 min.":
7067 "Establece las opciones de cálculo de costes: Durante la secuencia, Después de la secuencia o Nunca.":
7120 "Fija el modo de descripción general de la secuencia.":
7130 "El número de días a partir de ahora hasta el inicio de la descripción general de la secuencia.":
7140 "El número de días a partir de ahora hasta la finalización de la descripción general de la secuencia.":
7320 "Permite que seleccionar la secuencia de comandos necesaria para importar órdenes de la tabla de datos 'Secuencias de comandos'.":
7330 "Permite que seleccionar la secuencia de comandos necesaria para exportar órdenes de la tabla de datos 'Secuencias de comandos'.":
7430 "Cuando este campo de conmutador está activado, cambia a un triángulo negro pequeño en cada operación del secuenciador. Esta característica facilita las operaciones de arrastrar que están asignadas en el panel de planificación, especialmente las operaciones más pequeñas.":
7450 "Especifica la secuencia de comandos de eventos PESP predeterminada que se debe ejecutar al importar órdenes con el botón 'Importar órdenes' del menú Transferencia de datos.":
7470 "Especifica la secuencia de comandos de eventos PESP predeterminada que se debe ejecutar al exportar órdenes con el botón 'Exportar órdenes' del menú Transferencia de datos.":
7480 "Especifica la secuencia de comandos de eventos PESP predeterminada que se debe ejecutar al liberar una programación con el botón 'Liberar programación' del menú Transferencia de datos.":
7490 "Especifica la secuencia de comandos de eventos PESP predeterminada que se debe ejecutar al asignar operaciones en el secuenciador con la opción Reglas APS activada.":
8020 "Nombre de la restricción secundaria.":
8030 "Permite seleccionar el color del ploteo de usuario de secuenciador cuando los valores se encuentran entre los límites alto y bajo.":
8040 "Fija el patrón de relleno de ploteo.":
8060 "Color de relleno de ploteo si este supera el límite de ploteo superior.":
8080 "Color de relleno de ploteo si este supera el límite de ploteo inferior.":
8090 "Especifica si esta restricción secundaria debe restringir la programación cuando se utiliza un producto 300 FCS o superior. En todas las versiones, si no se marca esta casilla de selección, el secuenciador dejará de emitir avisos si se superan los límites fijados para esta restricción secundaria.":
8091 "En el modo de secuenciador de capacidad infinita, este campo especifica si esta restricción secundaria debe restringir la programación cuando se usa un producto 300 FCS o superior.":
8092 "Opciones para controlar el comportamiento de esta restricción cuando el sistema está fijado en el modo de capacidad infinita.":
8100 "Determina cómo la eficiencia del calendario de recursos primarios afecta al uso de esta restricción secundaria. Las opciones son: Sin efecto, Inicio de la eficiencia de trabajo, Seguir los cambios de eficiencia y Usar el 100% si es mayor que el 0%":
8101 "En el modo de secuenciador de capacidad infinita, este campo determinará cómo la eficiencia del calendario de recursos primarios afecta al uso de esta restricción secundaria. Las opciones son: Sin efecto, Inicio de la eficiencia de trabajo, Seguir los cambios de eficiencia y Usar el 100% si es mayor que el 0%":
8120 "Este botón abre un cuadro de diálogo que enumera los diferentes atributos asociados a la restricción secundaria.":
8130 "Este campo permite que los datos de atributo de tipo cadena se introduzcan en la restricción secundaria.":
8140 "Este campo permite que los datos de atributo de tipo real se introduzcan en la restricción secundaria.":
8150 "Este campo permite que los datos de atributo de duración se introduzcan en la restricción secundaria.":
8160 "Cuando se activa, este conmutador mostrará un ploteo de uso de la restricción secundaria en la ventana de ploteo múltiple del secuenciador.":
8200 "El nombre del grupo de restricciones secundarias.":
8210 "Permite seleccionar las restricciones secundarios que son miembros de este grupo.":
9020 "Nombres del grupo de ajuste inicial que forman los ejes X e Y de la matriz de tiempo de ajuste inicial dependiente de la secuencia en la tabla de datos de recursos.":
12020 "Nombre de un registro de atributo en la tabla de datos de atributos de producto 1.":
13020 "Nombre de un registro de atributo en la tabla de datos de atributos de producto 2.":
14020 "Nombre de un registro de atributo en la tabla de datos de atributos de producto 3.":
16020 "El nombre utilizado para describir la configuración de visualización de pantalla guardada con el nombre de archivo. Esta descripción también se utiliza como pantalla de sugerencias para los iconos de la barra de herramientas de espacio de trabajo.":
16030 "El archivo se selecciona mediante la selección de un archivo en la opción que ofrece el botón situado a la izquierda del campo. El archivo de configuración del espacio de trabajo original se guarda con la extensión .WPI, mediante el comando Guardar espacio de trabajo en el menú Secuenciador.":
18510 "Nombre del individuo u organización que emplaza una orden.":
18520 "Nombre del contacto primario de una organización que emplaza una orden.":
18530 "Número de teléfono que se usará en relación con una orden.":
18540 "Dirección de correo electrónico que se usará en relación con una orden.":
21000 "Este campo permite que se introduzcan diferentes 'estatus de orden'; el estatus de la orden se puede seleccionar según una orden en el archivo de programación.":
21020 "Este campo se utiliza para contener la descripción de lo que significa el nombre de estatus de orden que se ha introducido en el campo 'Nombre de estatus de orden'.":
21100 "Nombre del registro de atributo en la tabla de datos de atributos.":
21110 "Se utiliza para establecer una clasificación de prioridad entre los registros de esta tabla de datos de atributos que se pueden utilizar mediante reglas de programación":
24000 "Este campo especifica si es un registro padre del conjunto de reglas o un hijo.":
24010 "Contiene el nombre del conjunto de reglas.":
24020 "Este conmutador se utiliza para borrar los enlaces de etiquetado solo para órdenes que se encuentran en la fila de espera de demanda del primer paso (activado o no) del conjunto de reglas.":
24030 "Contiene el nombre de la función concreta del paso de regla.":
24040 "Un conmutador que al fijarlo en verdadero activa el paso de regla; cuando se fija en falso, este paso de regla concreto se pasa por alto al ejecutar el conjunto de reglas.":
24050 "Cuando este conmutador se fija en verdadero y se ejecuta el conjunto de reglas, se creará un archivo de depuración en el directorio de trabajo.":
24060 "Este campo se utiliza para especificar los criterios que se pueden utilizar para restringir los ítems que se emplazan en la fila de espera de suministro interna. El valor predeterminado de este campo se fija en ALL, pero se puede cambiar introduciendo una expresión, por ejemplo: (~{$Tipo de orden}~==~Stock~). Esta fila de espera filtra los registros que se encuentran en la base de datos 'Órdenes de trabajo'.":
24070 "Este campo contiene criterios que se pueden utilizar para clasificar los ítems de la fila de espera de suministro interna. Por ejemplo, puede clasificar la fila de espera de suministro interna por fecha de vencimiento, fecha de inicio más temprana o prioridad.":
24080 "Este campo se utiliza para especificar los criterios que se pueden utilizar para restringir los ítems que se emplazan en la fila de espera de demanda. El valor predeterminado de este campo se fija en ALL, pero se puede cambiar introduciendo una expresión, por ejemplo: (~{$Tipo de orden}~==~Stock~). Esta fila de espera filtra los registros que se encuentran en la base de datos 'Órdenes de trabajo'.":
24090 "Este campo contiene criterios que se pueden utilizar para clasificar los ítems de la fila de espera de demanda interna. Por ejemplo, puede clasificar la fila de espera de demanda interna por fecha de vencimiento, fecha de inicio más temprana o prioridad.":
24100 "Este campo contiene una lista de las diversas reglas de etiquetado estándar que se pueden utilizar para etiquetar las órdenes juntas. También contiene tres ítems especiales (usuario definido, función de usuario y secuencia de comandos PESP) que proporcionan la oportunidad de crear reglas más personalizadas.":
24110 "Este campo solo está visible cuando el campo 'Tipo de regla' se fija en 'Definido por el usuario' o 'Función de usuario'. La expresión que se utilizará en la regla se introduce en este campo. Un ejemplo podría ser (~{+:$Atributo de producto 1}~==~{-:$Atributo de producto 1}~), que permite enlazar solo las órdenes de oferta y demanda si los campos 'Atributo de producto 1' tienen el mismo valor.":
24120 "Este campo solo está visible cuando el campo 'Tipo de regla' se fija en 'Secuencia de comandos PESP'. Este campo contiene el nombre de la secuencia de comandos PESP que se utilizará como la regla.":
24130 "Esta opción permite crear enlaces en líneas de LDM donde la cantidad de la línea de BOM no tiene que estar completamente satisfecha para que realice el enlace. Cualquier ítem que falte aparecerá resaltado como una carencia.":
24140 "Esta opción solo permitirá crear enlaces en líneas de LDM donde la cantidad de la línea de BOM esté completamente satisfecha. Cualquier ítem que falte aparecerá resaltado como una carencia.":
24141 "Cuando se marca esta opción, se sustituye el comportamiento predeterminado de SMC al permitir que se creen enlaces regresivos cuando se realiza la producción después del consumo.":
24150 "Cuando se fijan en verdadero, las órdenes que ya están programadas se pueden volver a enlazar.":
24160 "Cuando este conmutador se fija en verdadero, se activa el campo 'Clasificación de fila de espera de suministro' para permitir que los registros de suministro se clasifiquen según los criterios de selección del campo 'Clasificación de fila de espera de suministro'. Esta opción solo se debe seleccionar si todos los registros se encuentran en la base de datos 'Órdenes de trabajo'.":
24170 "Este campo se utiliza para especificar los criterios que se pueden utilizar para restringir los ítems que se emplazan en la fila de espera de suministro externa. El valor predeterminado de este campo se fija en ALL, pero se puede cambiar introduciendo una expresión, por ejemplo: (~{$Tipo de orden}~==~Stock~). Esta fila de espera filtra los registros que se mantienen en la base de datos 'Demanda'.":
24180 "Se procesará cualquier campo con la clasificación INHERIT FROM SUPPLY(nombre de campo).":
24190 "Se procesará cualquier campo con la clasificación INHERIT FROM DEMAND(nombre de campo).":
24200 "Cuando este conmutador se fija en verdadero, se activa el campo 'Clasificación de fila de espera de demanda' para permitir que los registros de demanda se clasifiquen según los criterios de selección del campo 'Clasificación de fila de espera de demanda'. Esta opción solo se debe seleccionar si todos los registros se encuentran en la base de datos 'Órdenes de trabajo'.":
24210 "La cantidad de un enlace creado se asignará en múltiplos específicos cuando este conmutador se fije en verdadero. Este múltiplo se especifica en los datos de LDM.":
24500 "Si se marca el campo de conmutador 'Usar siempre este conjunto de reglas', el conjunto de reglas de etiquetado fijación seleccionado en este campo será el conjunto de reglas que se ejecutará de forma predeterminada cuando se seleccione la opción 'Etiquetar materiales' en el secuenciador.":
24505 "Cuando se marca esta opción global, se sustituye el comportamiento predeterminado de SMC al permitir que se creen enlaces regresivos cuando se realiza la producción después del consumo.":
24510 "Cuando se marca este conmutador, se usa la regla seleccionada en el campo 'Conjunto de reglas de etiquetado seleccionado' como la regla predeterminada que se ejecutará cuando se seleccione la opción 'Etiquetar materiales' en el secuenciador. Si está desactivada la opción 'Usar siempre este conjunto de reglas', se mostrará un cuadro de diálogo de selección de reglas al seleccionar la opción 'Etiquetar materiales' en el secuenciador, lo que permitirá seleccionar en ese momento la regla que se va a ejecutar.":
25400 "Es el campo que se utiliza para contener el número de la orden de suministro.":
25410 "Este campo identifica el tipo de orden, por ejemplo, Stock o Compra.":
25420 "El nombre de la organización que suministra los materiales de la orden.":
25430 "El número de pieza al que corresponde la orden.":
25440 "Descripción de la pieza a la que corresponde la orden.":
25450 "Fecha en que se suministra el material.":
25500 "Este campo se utiliza para identificar a qué orden pertenece la pieza. La primera línea de una orden será el registro padre y mostrará PARENT en este campo; las demás líneas de orden que forman parte de esta orden serán registros hijo y mostrarán en este campo el número de orden al que pertenecen.":
25510 "Es el campo que se utiliza para contener el número de la orden de demanda.":
25520 "Este campo identifica el tipo de orden, por ejemplo, Fabricar para stock u Orden de venta.":
25530 "Identifica de forma exclusiva un ítem de línea de una orden.":
25540 "El nombre de la organización que solicita los materiales de la orden.":
25550 "Fecha en que se necesita el material.":
25560 "Especifica el múltiplo de un ítem que se debe etiquetar. A menudo una serie de ítems componen un paquete o una caja. Por ejemplo, 12 latas componen 1 caja y una orden que solicita 60 latas. Hay una orden de suministro de 50 latas. Preactor solo etiqueta 48 de las 50 latas y buscará en otra parte las 12 latas restantes que necesita, pero solo creará el enlace si se encuentra la cantidad exacta de 12. Para que esta característica se active, se debe marcar el campo 'Asignar solo múltiplos' en la base de datos 'Reglas de etiquetado'.":
25600 "Número de la orden a la que pertenece la línea de la BOM.":
25605 "Número de la pieza de la orden a la que pertenece la línea de la BOM.":
25610 "Número de la operación a la que pertenece la línea de la BOM.":
25611 "Nombre de la operación a la que pertenece la línea de la BOM.":
25615 "Número de pieza del producto que necesita el material especificado":
25620 "Número de pieza del ítem de la BOM.":
25630 "Cantidad requerida del ítem de la BOM.":
25640 "Cuando se fija en verdadero, este campo hace que la cantidad de la orden se multiplique por la cantidad de BOM solicitada.":
25650 "Hace que se pasen por alto las carencias al ejecutar la regla de etiquetado. Permite programar órdenes con carencias.":
25700 "Número de orden en la que se produce el coproducto.":
25705 "Número de pieza de la orden en la que se produce el coproducto.":
25710 "Número de la operación que produce el coproducto.":
25715 "Nombre de la operación que produce el coproducto.":
25720 "Nombre del coproducto.":
25730 "Cantidad de coproducto producida.":
25740 "Cuando se fija en verdadero, este campo hace que la cantidad del coproducto se multiplique por la cantidad de la orden.":
25800 "Este campo identifica el tipo de orden, por ejemplo: orden de trabajo, orden de compra, orden de venta o stock":
25810 "Cuando se marca, la operación no programada ya no se mostrará en la ventana 'Operaciones no programadas'.":
25820 "Muestra un cuadro de diálogo que presenta los campos relacionados con el control de material.":
25830 "Este campo proporciona información sobre el estatus de la demanda después de que los materiales se hayan etiquetado. Contendrá uno de los valores siguientes: 'Desconocido', 'Satisfecho', 'Todas las carencias pasadas por alto', 'Carencia', 'Suministro excesivo', 'Suministro excesivo, carencias', 'Aprovisionamiento excesivo, todas las carencias pasadas por alto'.":
25840 "Este campo se puebla después de que los materiales se hayan etiquetado. Cuando se ha creado un enlace a una orden de suministro en la base de datos 'Órdenes de suministro', el campo 'Fecha de demanda' de la base de datos 'Órdenes de trabajo' se puebla con el valor de 'Fecha de suministro' de la orden de suministro. Preactor evaluará el campo 'Fecha de suministro' según el campo 'Fecha de inicio más temprana' y usará la última de las dos fechas para determinar la fecha que se debe utilizar durante la programación.":
25850 "Este campo se puebla después de que los materiales se hayan etiquetado. Cuando se ha creado un enlace a una orden de demanda en la base de datos 'Órdenes de demanda', el campo 'Fecha de demanda' de la base de datos 'Órdenes de trabajo' se puebla con el valor de 'Fecha de demanda' de la orden de suministro a la que está enlazada. Preactor evaluará el campo 'Fecha de demanda' según el campo 'Fecha de inicio más temprana' y usará la primera de las dos fechas para determinar la fecha que se debe utilizar durante la programación.":
25900 "Muestra un cuadro de diálogo con campos relacionados con el estatus de una operación.":
25910 "Esta opción se puede seleccionar cuando una orden está dividida. Esta opción permite que cada lote de producción continúe de forma independiente por el proceso de fabricación, por ejemplo, todos los lotes no se deben estar completados en una operación para que pueda iniciarse una operación subsiguiente.":
25920 "Este campo especifica el color utilizado en la barra del diagrama de Gantt para este registro.":
26000 "Este campo define el nombre del grupo de cambio":
26100 "Este campo fija el periodo de tiempo de cambio que ha transcurrido cuando el atributo especificado cambia de una operación programada posterior a otra.":
26200 "El nombre de visualización de la herramienta de usuario":
26210 "La secuencia de comandos de evento que la herramienta de usuario ejecutará cuando se seleccione":
26220 "el nombre del menú de la herramienta de la ventana de usuario":
26230 "La función de código para poblar el contenido de la ventana de usuario":
26240 "la etiqueta de la ventana de usuario":
26300 "El nombre del botón de menú. Da una indicación de dónde se mostrará el botón en el sistema de menús":
26310 "Este campo controla si el botón está activado y, por lo tanto, si se muestra":
26320 "Este campo controla el texto que se mostrará en el botón":
26330 "La secuencia de comandos de evento que el botón de menú ejecutará cuando se seleccione":
;
