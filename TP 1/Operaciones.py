class Operaciones:
    @staticmethod
    def metodosCongruentes(nroOp):
        x0 = int(input("Ingrese el valor de la semilla (debe ser un nro impar): "))
        while x0 % 2 == 0:
            x0 = int(input("El valor de la semilla debe ser impar: "))
        k = int(input("Ingrese el valor de la cte k (debe ser entero): "))
        g = int(input("Ingrese el valor de la cte g (debe ser entero): "))
        if nroOp == 2:
            c = int(input("Ingrese valor de la cte c: "))
        else:
            c = 0
        serie = (40)

        m = (2**g)
        a = 3 + (8*k)
        lista = []
        primerValor = ((a * x0) + c) % m
        for i in range(serie):
            x0 = ((a * x0) + c) % m
            ri = x0 / (m-1)
            if i != 0:
                if x0 == primerValor:
                    break
            lista.append(ri)

        return lista

    @staticmethod
    def menuMostrarLista(lista):

        men = True
        while men:
            print("1. Dejar de listar. \n"
                  "2. Continuar con los proximos 20. \n"
                  "3. Listar hasta el final. \n"
                  "4. Listar Desde ... Hasta.")
            op = int(input("Ingrese opcion: "))

            if op == 1:
                men = False
            elif op == 2:
                pass
            elif op == 3:
                pass
            elif op == 4:
                pass

    @staticmethod
    def mostrarLista(lista, nroOp):
        pass