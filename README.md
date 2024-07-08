# Invernadero automatizado
##### Junio/2019
#
El proyecto consistió en un invernadero controlado por medio de una interfaz gráfica de usuario y un microcontrolador (arduino) utilizado como tarjeta de adquisición de datos.

El microcontrolador implementado fue el arduino nano el cual fue utilizado por su tamaño compacto además de que su capacidad y eficiencia concordaba con los requerimientos. 

Para la realización de la interfaz gráfica se utilizó el programa Visual Studio y el lenguaje de programación C#, de los cuales se utilizaron las herramientas aprendidas a lo largo del curso, entre las que se destacan textBox, button, tabControl, label, groupBox, timer, serialPort, entre otras.

La interfaz gráfica se encarga de mandar y recibir las señales del arduino para que este haga lo necesario con los sensores y los actuadores utilizados.

El invernadero consta de una estructura hecha con palitos de banderilla, paredes de acetato, base de MDF, contenedor de agua para las plantas el cual fue hecho con acetato (en un invernadero real no es viable que en contenedor sea transparente debido a que con la radiación solar daña las raíces pero aquí se implementó así para observar el funcionamiento) y tres plantas con sus respectivos contenedores individuales.

La parte electrónica está compuesta del arduino, un sensor de humedad (el cual se utilizó para medir el nivel de agua), un termistor (el cual se utilizó para medir la temperatura), una bomba de agua (la cual sirve para suministrar el agua del contenedor), una bomba de aire (esta sirve para oxigenar el agua de la plantas y evitar que esta se estanque), un ventilador (utilizado para bajar la temperatura), una resistencia de alambre de nicromo (utilizada para subir la temperatura) y un servomotor (utilizado para abrir y cerrar la ventana de ventilación localizada en el techo); todo esto conectado con sus respectivos complementos (resistores, capacitores, transistores, relevadores, etc.) y en una protoboard.

En este caso las plantas son regadas por el sistema conocido como Hidroponia el cual consiste en suministrar los nutrientes y oxigenación necesarios para la vida de las plantas por medio del agua; este sistema se utilizó porque pareció algo novedoso y sencillo de controlar.

El invernadero se controla de forma manual o de forma autónoma, dependiendo de la decisión del usuario.