Algoritmo bisiestos
	//Pide un año y determina si es bisiesto. Regla es divisible entre 4 pero no entre 100 excepto si también es divisible entre 400
	definir n1 Como Entero
	//Pedir el año
	Escribir 'Dime el año'
	//Escribir el año
	Leer n1
	//Calcular
	Si 		
	//Si el año es divisible entre 4 y no entre 100
		(n1%4=0 y n1%100<>0) 
		o
	//o si el año es divisible entre 4, entre 100 y también entre 400
		(n1%4=0 y n1%100=0 y n1%400=0) 
	//ES BISIESTO
		Entonces ESCRIBIR'Es bisiesto'
	//Si no cumple ninguna de las dos anteriores
	SiNo
	//Escribir no es bisiesto
		Escribir 'No es bisiesto'
	FinSI

	
FinAlgoritmo
