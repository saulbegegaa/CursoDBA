Algoritmo edad
	//Definimos variables
	definir n1 Como Entero
	//Pedimos que introduzca la edad
	Escribir 'Dime la edad'
	//Escribimos la edad
	Leer n1
	//Hacemos la operatoria
	//Si es menor que 0 mostrar error
	SI 		n1 < 0 			Entonces
		Escribir 'La edad tiene que ser un número positivo'
	//Si es mayor que 0 mirar si es mayor o menor de 18
	SiNo
	//Si la edad es menor de 18 años mostrar menor de edad
		SI 	n1<18
			Escribir 'Es menor de edad'
	//Si no es menor de 18 años mostrar mayor de edad
		SiNo
			Escribir 'Es mayor de edad'
		FinSi
	//Fin de si es mayor que 0
	FINSI
	//Fin de si es menor que 0
	
FinAlgoritmo
