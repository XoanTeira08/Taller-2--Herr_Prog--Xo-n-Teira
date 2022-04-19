Imports System

Module Program
    Sub Main(args As String())
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
                precioUni = Console.ReadLine()
                contador2 = True
                Console.WriteLine("|-------------------------------------------------------------------------------|")
                Console.WriteLine("|    Por favor ingrese la cantidad de venta del producto :                      |")
                Console.WriteLine("|-------------------------------------------------------------------------------|")
                Do While (contador3 = False)
                    Try
                        cantidadV = Console.ReadLine()
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
                                    Select Case opcion1
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
                                                        Select Case opcion2
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
    End Sub
End Module
