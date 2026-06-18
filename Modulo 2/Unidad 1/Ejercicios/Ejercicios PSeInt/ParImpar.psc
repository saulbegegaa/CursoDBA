Algoritmo ParImpar
	Definir cont,sumapar,sumaimpar Como Entero
	cont=1
	Para cont=1 Hasta 100 Con Paso 1 Hacer
		Si cont%2=0 Entonces
			sumapar=sumapar+cont
			Escribir cont ". La suma de los pares es " sumapar " y la suma de los impares " sumaimpar
		SiNo
			sumaimpar=sumaimpar+cont
			Escribir cont ". La suma de los pares es " sumapar " y la suma de los impares es " sumaimpar
		FinSi
	FinPara
	Escribir "La suma de lus pares es " sumapar
	Escribir "La suma de los impares es " sumaimpar
FinAlgoritmo
