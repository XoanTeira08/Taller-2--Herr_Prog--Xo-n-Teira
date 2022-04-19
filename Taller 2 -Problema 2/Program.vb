Imports System

Module Program
    Sub Main(args As String())
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
    End Sub
End Module
