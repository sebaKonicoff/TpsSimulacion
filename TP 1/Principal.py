import Operaciones

def menu():
    operacion = Operaciones
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
            lista = operacion.Operaciones.metodosCongruentes(op)
            print(lista)
        elif op == 2:
            lista = operacion.Operaciones.metodosCongruentes(op)
            print(lista)
        elif op == 3:
            pass
        elif op == 4:
            pass
        elif op == 5:
            print("Fin del programa.")
            men = False
        else:
            print("Opción no valida.")

menu()