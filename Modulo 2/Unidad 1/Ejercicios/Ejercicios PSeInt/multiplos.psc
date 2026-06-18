Algoritmo múltiplos
	//si es multiplo de 2 y 5 a la vez
	// si es multiplo de solo uno de ellos
	//si no es multiplo de ninguno
	//definimos variables
	definir n1 Como Entero
	definir mult2, mult5 Como Real
	escribir 'dame el numero que quieres saber si es múltiplo de 2 y 5'
	leer n1
	mult2<-n1%2
	mult5<-n1%5
	SI mult2=0 Y mult5=0 Entonces
		Escribir n1 ' es múltiplo de ambos'
	SiNo
		Si mult2<>0 Y mult5=0
			Escribir n1 ' es múltiplo sólo de 5'
		SiNo
			Si mult2=0 Y mult5<>0
				Escribir n1 ' es múltiplo de 2'
			SiNo
				Escribir n1 ' no es múltiplo ni de 2 ni de 5'
			FinSi
		FinSi
	FinSi
FinAlgoritmo
