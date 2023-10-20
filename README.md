# Comunicación por puertos COM
Programa donde se mantiene una comunicación a través de un puerto COM con un periférico (bascula) en C#.

## Pantalla Principal 
Contiene botones para la visualizacion de 4 diferentes naves (basculas) para poder leer los datos que estas manden, 
tambien existen botones para la configuracion del puerto COM, conexión a la base de datos y finalmente los creditos.
![image](https://github.com/HSamuelGomezC/Comunicaci-n-por-puertos-COM/assets/142279815/2a69093a-d158-459e-a1f3-2da7d721f82f)


## Pestaña de Configuracion
![image](https://github.com/HSamuelGomezC/Comunicaci-n-por-puertos-COM/assets/142279815/4ce3c712-c8cc-4047-a6d1-3e5903d4969a)

En esta list box se detecta automaticamente los puertos disponibles del ordenador.
Y en los respectivos checkbox se activan o desactivan las naves necesarias.

![image](https://github.com/HSamuelGomezC/Comunicaci-n-por-puertos-COM/assets/142279815/b31a8be3-3dc8-404f-b62e-e6f759667186)

Toda esta configuracion se guarda en un archivo llamado 'Settings1.settings'
![image](https://github.com/HSamuelGomezC/Comunicaci-n-por-puertos-COM/assets/142279815/a940585c-9173-4b5b-93f3-f66f2461e867)

## Pestaña de Conexión a la DB
![image](https://github.com/HSamuelGomezC/Comunicaci-n-por-puertos-COM/assets/142279815/e98aee8e-1042-4f8f-b7b0-e8d5d149e6aa)

En esta pestaña el usuario introduce las credenciales necesarias para establecer la conexión a una base de datos previamente creada.

Toda esta configuracion se guarda en un archivo llamado 'Settings2.settings'
![image](https://github.com/HSamuelGomezC/Comunicaci-n-por-puertos-COM/assets/142279815/8cae68ea-d021-43c4-9bb7-c5a12a4c759e)

## Pestaña de Creditos
Pequeña ventana donde se dan creditos al autor del software.
![image](https://github.com/HSamuelGomezC/Comunicaci-n-por-puertos-COM/assets/142279815/1b309d9f-6ebd-4f33-905a-176d419451c0)

## Ventana A,B,C
En esta ventana se leen los datos recibidos por la nave (bascula ). Cada cierto segundos se van leyendo diferentes datos y se guardan automaticamente en la DB.
![image](https://github.com/HSamuelGomezC/Comunicaci-n-por-puertos-COM/assets/142279815/49a0fec3-2454-43c0-91f2-3046495ab8fb)

En la sub-pestaña llamada 'Base de datos' es donde se pueden mostrar todos los datos de la tabla en la DB, tambien se puede filtrar por Lote y Fecha.
Ademas se puede exportar los datos buscados a un archivo excel para trabajar con esos datos.
![image](https://github.com/HSamuelGomezC/Comunicaci-n-por-puertos-COM/assets/142279815/7d1900d2-f243-4d7f-9d64-db07888d94ea)

**LAS VENTANAS A, B, C MANEJAN EL MISMO FORMATO**

## Ventana SDR
La ventana SDR es la unica que cambia ya que maneja mas datos en la comunicación.
![image](https://github.com/HSamuelGomezC/Comunicaci-n-por-puertos-COM/assets/142279815/a97e7de5-d372-400c-98d8-b45c573b9db5)

La sub-pestaña sigue siendo igual que las demas ventanas.


