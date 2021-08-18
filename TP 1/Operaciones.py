import random
import numpy as np
from matplotlib import pyplot as plt
from scipy.stats import chisquare

def metodosCongruentes(nroOp):
        serie = int(input("Ingrese la cantidad de numeros a generar: "))
        x0 = int(input("Ingrese el valor de la semilla (debe ser un nro impar): "))
        while x0 % 2 == 0:
            x0 = int(input("El valor de la semilla debe ser impar: "))
        a = int(input("Ingrese el valor de la cte multiplicativa (a): "))
        m = int(input("Ingrese el valor del modulo: "))
        #k = int(input("Ingrese el valor de la cte k (debe ser entero): "))
        #g = int(input("Ingrese el valor de la cte g (debe ser entero): "))
        # si la opcion elejida es 2, el metodo mixto, pide un valor a c
        if nroOp == 2 or nroOp == 4:
            c = int(input("Ingrese valor de la cte aditiva (c): "))
        else:
            c = 0


        #m = (2 ** g)
        #a = 1 + (4 * k)
        lista = []
        # se guarda el primer valor para luego compararlo con los siguientes
        # y así cortar la generacion de nros cuando se vuelva a repetir
        primerValor = ((a * x0) + c) % m
        for i in range(serie):
            x0 = ((a * x0) + c) % m
            ri = x0 / (m )
            # en la primera vuelta no se hace la comparacion
            """if i != 0:
                if x0 == primerValor:
                    break"""
            lista.append(ri)

        return lista

def menuMostrarLista(lista):
        desde = 0
        hasta = 20
        mostrarLista(lista, desde, hasta)
        men = True
        while men:
            print("1. Dejar de listar. \n"
                  "2. Continuar con los proximos 20. \n"
                  "3. Listar hasta el final. \n"
                  "4. Listar Desde ... Hasta.")
            op = int(input("Ingrese opcion: \n"))
            desde += 20
            hasta += 20
            if op == 1:
                men = False
            elif op == 2:
                mostrarLista(lista, desde, hasta)
            elif op == 3:
                mostrarLista(lista, desde, len(lista))
                desde = len(lista)
                print("Listado hasta el final.")
            elif op == 4:
                des = int(input("Ingrese desde donde quiere mostrar: "))
                hast = int(input("Ingrese hasta donde quiere mostrar: "))
                while hast <= des or hast > len(lista):
                    hast = int(input("Ingrese hasta donde quiere mostrar(debe ser mayor a Desde): "))
                mostrarLista(lista, des, hast+1)



def mostrarLista(lista, desde, hasta):
        #va a ir mostrando "desde" hasta el tamaño de la lista y de a 20
        try:
            for i in range(desde, hasta):
                print(lista[i])
        except IndexError:
            print("No hay más números para mostrar")


def testChiCuadrado(lista):
    #la cantidad sugerida de intervalos es la raíz cuadrada de la cantidad de números
    tam = len(lista)
    q_intervalos = round(tam**0.5)
    intervalos_desde = []
    for i in range(q_intervalos):
        intervalos_desde.append(i/q_intervalos)
    frecuencias = [0]*q_intervalos
    for i in range(tam):
        for j in range(q_intervalos):
            if 0 <= lista[i] - intervalos_desde[j] < 1/q_intervalos:
                frecuencias[j] += 1
            
    fe = tam/q_intervalos
    chi_cuadrado = 0
    for i in range(q_intervalos):
        chi_cuadrado += ((frecuencias[i] - fe)**2) / fe
    frecuencias_esperadas = [fe]*q_intervalos
    mostrarGraficoFrec(frecuencias, frecuencias_esperadas, intervalos_desde)
    
    chi_tabulado, p = chisquare(frecuencias)
    if chi_cuadrado > chi_tabulado:
        print("Se rechaza la hipótesis.")
    else:
        print("No se puede rechazar la hipótesis.")


def generarListaAleatoria(tam):
    lista = []
    sem = int(input("Ingresar semilla: "))
    random.seed(sem)
            
    for i in range(tam):
        lista.append(random.random()) 
            
    return lista


def generarTablaDeFrecuencias(lista):
    cinterv = int(input('Ingrese la cantidad de intervalos: '))
    frec, extr = np.histogram(lista, bins=cinterv, density=False)
    print(frec, extr)
    plt.hist(extr[:-1], extr, weights=frec)
    plt.show()

def mostrarGraficoFrec(frec,frec_esp,intervalos_desde):

    
    numero_de_grupos = len(frec)
    indice_barras = np.arange(numero_de_grupos)
    ancho_barras =0.35

    print(frec)
    
    plt.bar(indice_barras, frec, width=ancho_barras, label='Frecuencias Observadas')
    plt.bar(indice_barras + ancho_barras, frec_esp, width=ancho_barras, label='Frecuencias Esperadas')
    plt.legend(loc='best')
    ## Se colocan los indicadores en el eje x
    plt.xticks(indice_barras + ancho_barras, intervalos_desde)
    
    plt.ylabel('Frecuencias')
    plt.xlabel('Intervalos')
    plt.title('Frecuencias esperadas vs Frecuencias Observadas')
    
    plt.show()
