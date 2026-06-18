//Programa que calcula el factorial de un número que se pide por teclado
Algoritmo factorial
	definir n1, cont, fact como entero
	Escribir "Mete el numero del que quieres saber el factorial"
	Leer n1
	
	fact=n1
	cont=n1-1
	
	Mientras cont > 0
		fact=fact*cont
		cont=cont-1
	FinMientras
	escribir fact

FinAlgoritmo
