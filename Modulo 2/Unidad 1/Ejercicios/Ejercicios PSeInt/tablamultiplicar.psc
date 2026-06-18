Algoritmo tablamultiplicar
	definir n1,cont,mult Como Entero
	cont<-0
	mult<- cont * n1
	Escribir "Dime el numero del que quieres ver su tabla"
	Leer n1
	Mientras cont<=10
		mult<- cont * n1
		Escribir n1 " X " cont " = " mult
		cont=cont+1
	FinMientras
FinAlgoritmo
