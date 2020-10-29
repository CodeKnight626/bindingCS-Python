import sys

"""Script en python que se ejecutara desde C#"""

######

# Funcion definida para sumar dos numeros
def addTwoNumbers(n1, n2):
	return (int(n1) + int(n2))

# Convertimos los argumentos del sistema en variables string
num1 = str(sys.argv[1])
num2 = str(sys.argv[2])

# Imprimimos en pantalla el resultado de la suma el cual sera retornado al programa de c#
print("Hola C# el resultado es: " + str(addTwoNumbers(num1, num2)))