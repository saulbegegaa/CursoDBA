Algoritmo MayorMenor
	Definir n1, nmayor, nmenor, cont Como Entero
	Definir SIoNO Como Caracter
	Repetir
		Escribir "¿Deseas ejecutar el algoritmo? (S/N)"
		Leer SIoNO
		Si SioNO <> 'N' Y SioNO <> 'n' Entonces
			Limpiar Pantalla
			Escribir 'Dime el Primer Numero'
			Leer n1
			nmayor <- n1
			nmenor <- n1
			Para cont<-2 Hasta 5 Con Paso 1 Hacer
				Escribir 'Dime el ', cont, 'º número'
				Leer n1
				Si n1>nmayor Entonces
					nmayor <- n1
				FinSi
				Si n1<nmenor Entonces
					nmenor <- n1
				FinSi
			FinPara
			Escribir 'El número mayor es ', nmayor, ' y el número menor es ', nmenor
		FinSi
Hasta Que SIoNO = 'N' o SIoNO='n'
	
FinAlgoritmo
