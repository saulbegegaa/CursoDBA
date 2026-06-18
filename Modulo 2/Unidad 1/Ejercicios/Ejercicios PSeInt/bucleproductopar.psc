//Pseudocodigo para calcular el producto de numeros enteros del 10 al 20
Algoritmo bucleproductopar
	//Definimos las variables
	Definir cont, producto Como Entero
	cont<-10
	producto<-1
	Mientras cont <= 20
		producto<-producto*cont
		Escribir producto
		cont<-cont+2
	FinMientras
	Escribir "El producto total es " producto
FinAlgoritmo
