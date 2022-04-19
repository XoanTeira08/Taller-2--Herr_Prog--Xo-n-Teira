Imports System

Module Program
    Public Function titulo()
        Dim Fecha As String
        Fecha = Format(Now(), "General Date")
        'ENCABEZADO'
        Console.WriteLine("|-------------------------------------------------------------------------------|")
        Console.WriteLine("|                                 GRUPO CONTABLE.SA                             |")
        Console.WriteLine("|             Aplicación de consolo para calculo de descuento y salario         |")
        Console.WriteLine("|                                    RUC: 7-NP-1-12  DV.10                      |")
        Console.WriteLine("|                         Ubicación: C. 68A Este, Panamá                        |")
        Console.WriteLine("|-------------------------------------------------------------------------------|")
        Console.WriteLine("|                 Todos los derechos reservados a: XAT Software  2022           |")
        Console.WriteLine("|-------------------------------------------------------------------------------|")
        Console.WriteLine("|                           " & Fecha & "                            |")
        Console.WriteLine("|-------------------------------------------------------------------------------|")
    End Function
    Public Function problema1()
        'Variables'
        Dim contador2, contador3, contador4, contador5, contadorCase1, contadorCase2 As Boolean
        contador2 = False
        Dim cantidadV As Integer, precioUni As Double, precioPar As Double, opcion1 As Integer, opcion2 As Integer, porcenDescuento As Decimal
        Dim precioNeto As Double
        Console.WriteLine("|-------------------------------------------------------------------------------|")
        Console.WriteLine("|                                 Calculo de descuento                          |")
        Console.WriteLine("|-------------------------------------------------------------------------------|")
        Console.WriteLine("|    Por favor ingrese el precio unitario del producto vendido:                 |")
        Console.WriteLine("|-------------------------------------------------------------------------------|")
        Do While (contador2 = False)
            Try
                precioUni = Console.ReadLine() 'Ingreso del precio'
                contador2 = True
                Console.WriteLine("|-------------------------------------------------------------------------------|")
                Console.WriteLine("|    Por favor ingrese la cantidad de venta del producto :                      |")
                Console.WriteLine("|-------------------------------------------------------------------------------|")
                Do While (contador3 = False)
                    Try
                        cantidadV = Console.ReadLine() 'Ingreso de la cantidad'
                        contador3 = True
                        Console.WriteLine("|-------------------------------------------------------------------------------|")
                        Console.WriteLine("|    ¿Desea hacer descuento? Escoga la opción correspondiente:                  |")
                        Console.WriteLine("|    1. Si                                                                      |")
                        Console.WriteLine("|    2. No                                                                      |")
                        Console.WriteLine("|-------------------------------------------------------------------------------|")
                        Do While (contador4 = False)
                            Try
                                Do While (contadorCase1 = False)
                                    opcion1 = Console.ReadLine()
                                    contador4 = True
                                    Select Case opcion1 'Case si desea ingresar descuento'
                                        Case 1
                                            Console.WriteLine("|-------------------------------------------------------------------------------|")
                                            Console.WriteLine("|    ¿Que descuento desea realizar? Escoga la opción correspondiente:           |")
                                            Console.WriteLine("|    1. 7%                                                                      |")
                                            Console.WriteLine("|    2. 10%                                                                     |")
                                            Console.WriteLine("|    3. 20%                                                                     |")
                                            Console.WriteLine("|    4. 30%                                                                     |")
                                            Console.WriteLine("|    5. 40%                                                                     |")
                                            Console.WriteLine("|    6. 50%                                                                     |")
                                            Console.WriteLine("|-------------------------------------------------------------------------------|")
                                            Do While (contador5 = False)
                                                Try
                                                    Do While (contadorCase2 = False)
                                                        opcion2 = Console.ReadLine()
                                                        contador5 = True
                                                        Select Case opcion2 'Case de los porcentajes de descuento'
                                                            Case 1
                                                                porcenDescuento = 0.07
                                                                contadorCase2 = True
                                                            Case 2
                                                                porcenDescuento = 0.1
                                                                contadorCase2 = True
                                                            Case 3
                                                                porcenDescuento = 0.2
                                                                contadorCase2 = True
                                                            Case 4
                                                                porcenDescuento = 0.3
                                                                contadorCase2 = True
                                                            Case 5
                                                                porcenDescuento = 0.4
                                                                contadorCase2 = True
                                                            Case 6
                                                                porcenDescuento = 0.5
                                                                contadorCase2 = True
                                                            Case Else
                                                                Console.WriteLine("ERROR!:Opcion ingresa no valida. Por favor ingresa una opcion valida")
                                                        End Select
                                                    Loop
                                                Catch ex As Exception
                                                    Console.WriteLine("ERROR!:El formato ingresado no es valido. Ingrese uno valido ")
                                                End Try
                                            Loop
                                            contadorCase1 = True
                                        Case 2
                                            porcenDescuento = 0
                                            contadorCase1 = True
                                        Case Else
                                            Console.WriteLine("ERROR!:Opcion ingresa no valida. Por favor ingresa una opcion valida")
                                    End Select
                                Loop
                                precioPar = precioUni * cantidadV
                                precioNeto = precioPar - (precioPar * porcenDescuento)
                                'Impresion final'
                                Console.WriteLine("|-------------------------------------------------------------------------------|")
                                Console.WriteLine("|    Precio parcial:" & Math.Round(precioPar, 2) & "                                                        |")
                                Console.WriteLine("|    Descuento:" & Math.Round(precioPar * porcenDescuento, 2) & "                                                             |")
                                Console.WriteLine("|-------------------------------------------------------------------------------|")
                                Console.WriteLine("|    PRECIO NETO:" & Math.Round(precioNeto, 2) & "                                                           |")
                                Console.WriteLine("|-------------------------------------------------------------------------------|")
                            Catch ex As Exception
                                Console.WriteLine("ERROR!:El formato ingresado no es valido. Ingrese uno valido ")
                            End Try

                        Loop
                    Catch ex As Exception
                        Console.WriteLine("ERROR!:El formato ingresado no es valido. Ingrese uno valido ")
                    End Try
                Loop
            Catch ex As Exception
                Console.WriteLine("ERROR!:El formato ingresado no es valido. Ingrese uno valido ")
            End Try
        Loop
    End Function
    Public Function problema2()
        Dim contador As Boolean
        Dim salario, salarioAumen, primaA, vacaciones, decimoTercer, liquida As Double
        Dim años As Integer
        Dim aumento As Decimal
        salario = 12000
        Console.WriteLine("|-------------------------------------------------------------------------------|")
        Console.WriteLine("|                         Calculo de sueldo y liquidacion                       |")
        Console.WriteLine("|-------------------------------------------------------------------------------|")
        Console.WriteLine("|    Ingresa la cantidad de años que llevas trabajando:                         |")
        Console.WriteLine("|-------------------------------------------------------------------------------|")
        Do While (contador = False)
            Try
                años = Console.ReadLine()
                contador = True
                Do While (años > 50)
                    Console.WriteLine("Ingrese una cantidad de años valida")
                    años = Console.ReadLine()
                Loop
                If años >= 10 Then
                    aumento = 1.1
                ElseIf años <= 10 And años >= 5 Then
                    aumento = 1.07
                ElseIf años <= 5 And años >= 3 Then
                    aumento = 1.05
                ElseIf años <= 3 Then
                    aumento = 1.03
                End If
                'Calculos para la liquidacion'
                salarioAumen = salario * aumento
                primaA = salarioAumen * 0.0192
                vacaciones = salarioAumen * 0.0909
                decimoTercer = (salarioAumen + vacaciones) * 0.0833
                vacaciones = vacaciones - (vacaciones * 0.0975)
                vacaciones = vacaciones - (vacaciones * 0.0125)
                decimoTercer = decimoTercer - (decimoTercer * 0.0725)
                liquida = primaA + vacaciones + decimoTercer
                Console.WriteLine("|-------------------------------------------------------------------------------|")
                Console.WriteLine("|    Salario original:" & Math.Round(salario, 2) & "                                                         |")
                Console.WriteLine("|    Salario con aumtento:" & Math.Round(salarioAumen, 2) & "                                                  |")
                Console.WriteLine("|-------------------------------------------------------------------------------|")
                Console.WriteLine("|    Liquidacion:" & Math.Round(liquida, 2) & "                                                        |")
                Console.WriteLine("|-------------------------------------------------------------------------------|")
            Catch ex As Exception
                Console.WriteLine("ERROR!:El formato ingresado no es valido. Ingrese uno valido ")
            End Try
        Loop
    End Function
    Sub Main(args As String())
        'VARIABLES'
        Dim contador, contadorCase As Boolean
        contador = False
        Console.ForegroundColor = ConsoleColor.Blue
        'PROGRAMA'
        titulo()
        'MENU DE SELECCIÓN'
        Console.WriteLine("|-------------------------------------------------------------------------------|")
        Console.WriteLine("|                                 Menú de Opciones                              |")
        Console.WriteLine("|-------------------------------------------------------------------------------|")
        Console.WriteLine("|    Por favor ingrese la opción que desea ingresar:                            |")
        Console.WriteLine("|    1. Calculo de descuento                                                    |")
        Console.WriteLine("|    2. Calculo de sueldo                                                       |")
        Console.WriteLine("|-------------------------------------------------------------------------------|")
        Do While (contador = False)
            Try 'TRY-CATCH PARA INGRESAR LA OPCION'
                Dim opcion As Integer
                Do While (contadorCase = False)
                    opcion = Console.ReadLine()
                    contador = True
                    'CASE PARA LAS OPCIONES DEL PROGRAMA'
                    Select Case opcion
                        Case 1
                            problema1()
                            contadorCase = True
                        Case 2
                            problema2()
                            contadorCase = True
                        Case Else
                            Console.WriteLine("Por favor ingresa una opcion valida")
                    End Select
                Loop
            Catch ex As Exception
                Console.WriteLine("ERROR!:El formato ingresado no es valido. Ingrese uno valido ")
            End Try
        Loop
    End Sub
End Module
