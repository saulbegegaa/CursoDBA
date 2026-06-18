Algoritmo Notas
	//Definimos las variables
	Definir nota Como Entero
	//Pedimos la nota
	Escribir '¿Qué nota sacó?'
	//Escribimos la nota
	Leer nota
	//Si la nota es menor que 5 entonces muestra suspenso
	SI nota < 5 Entonces
		ESCRIBIR 'Suspenso'
	FinSi
	//Si la nota está entre 5 y 6 muestra aprobado
	SI nota >= 5 Y nota <= 6 Entonces
		ESCRIBIR 'Aprobado'
	FinSi
	//Si la nota está entre 7 y 8 muestra notable
	SI Nota >= 7 Y Nota <= 8 Entonces
		Escribir 'Notable'
	FinSi
	//Si la nota está entre 9 y 10 muestra sobresaliente
	SI nota >= 9 Y nota <= 10 Entonces
		Escribir 'Sobresaliente'
	FinSi
	//Si la nota es menor que 0 o mayor que 10 que muestre que la nota no es válida
	SI nota > 10 O nota <0 Entonces
		Escribir 'La nota no es válida'
	FinSi
FinAlgoritmo
