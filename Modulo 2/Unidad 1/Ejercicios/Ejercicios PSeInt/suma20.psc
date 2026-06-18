//Realizar un programa que calcule la suma de los 20 primeros numeros naturales
Algoritmo suma20
	//Definimos las variables
	Definir contador, suma Como Entero
	suma=0
	contador=1
	//Iniciamos el proceso siempre que el contador sea menor o igual que 20
	Mientras contador<=20
		//la suma será el contador + la suma acumulada
		suma=contador+suma
		//Escribimos la suma intermedia
		Escribir "Suma nº" contador " es igual a " suma
		//despues de sumar el contador crecerá en uno
		contador=contador+1
		//Cuando el contador sea mayor que 20 el proceso acabará
	FinMientras
	//Escribimos la suma total
	Escribir "La suma total es " suma
FinAlgoritmo
