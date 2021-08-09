class Operaciones:
    @staticmethod
    def metodosCongruentes(nroOp):
        x0 = int(input("Ingrese el valor de la semilla (debe ser un nro impar): "))
        while x0 % 2 == 0:
            x0 = int(input("El valor de la semilla debe ser impar: "))
        k = int(input("Ingrese el valor de la cte k (debe ser entero): "))
        g = int(input("Ingrese el valor de la cte g (debe ser entero): "))
        # si la opcion elejida es 2, el metodo mixto, pide un valor a c
        if nroOp == 2:
            c = int(input("Ingrese valor de la cte c: "))
        else:
            c = 0
        serie = (40)

        m = (2 ** g)
        a = 3 + (8 * k)
        lista = []
        # se guarda el primer valor para luego compararlo con los siguientes
        # y así cortar la generacion de nros cuando se vuelva a repetir
        primerValor = ((a * x0) + c) % m
        for i in range(serie):
            x0 = ((a * x0) + c) % m
            ri = x0 / (m - 1)
            # en la primera vuelta no se hace la comparacion
            if i != 0:
                if x0 == primerValor:
                    break
            lista.append(ri)

        return lista


    def menuMostrarLista(self, lista):
        desde = 0
        self.mostrarLista(lista, desde)
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
                self.mostrarLista(lista, desde)
            elif op == 3:
                pass
            elif op == 4:
                pass
            desde += 2

    @staticmethod
    def mostrarLista(lista, desde):
        tam = len(lista)
        #va a ir mostrando "desde" hasta el tamaño de la lista y de a 20
        for i in range(desde, tam, 2):
            print(lista[i])