from Operaciones import *


def menu():
    men = True
    while men:
        print("Menú de opciones.")
        print("1. Generación número aleatorio con método Congruencial multiplicativo. \n"
              "2. Generación número aleatorio con método Congruencial mixto \n"
              "3. Prueba de frecuencia con Chi cuadrado\n"
              "4. Prueba De frecuencia con método Congruencial mixto. \n"
              "5. Salir.\n")
        op = int(input("Seleccione opción: "))

        if op == 1:
            lista = metodosCongruentes(op)
            print(lista)
            menuMostrarLista(lista)
        elif op == 2:
            lista = metodosCongruentes(op)
            print(lista)
            menuMostrarLista(lista)
        elif op == 3:
            tam = int(input('Ingresar cantidad de numeros a generar: '))
            lista = generarListaAleatoria(tam)
        
            #menuMostrarLista(lista)
            testChiCuadrado(lista)

        elif op == 4:
            pass
        elif op == 5:
            print("Fin del programa.")
            men = False
        else:
            print("Opción no valida.")

menu()