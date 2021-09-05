Imports System

Module Program
    Sub Main(args As String())
        Dim p As String

        Do
            Console.Clear()
            Console.WriteLine("0. Salutaciones" & vbCrLf & "1. Suma y Porcentaje" & vbCrLf & "2. Numero Primo" & vbCrLf _
                              & "3. Numero magico" & vbCrLf)

            Console.Write("EScribe una opcion: ")
            p = Console.ReadLine()
            Console.Clear()

            If p = "" Then Exit Sub
            Select Case p
                Case 0
                    Salutaciones()
                Case 1
                    Dim l As Double = SumaNumeros()
                    TantoPorCiento(l)
                Case 2
                    Dim s As String
                    Dim n As Integer
                    Do
                        Console.Write("EScribe un numero para comprobar si es primo : ")
                        s = Console.ReadLine()
                        If s = "" Then Exit Do
                        n = Int(s)
                        NumeroPrimo(n)
                    Loop

                Case 3
                    Do
                        Dim n As String
                        Console.WriteLine("El numero magico es la suma de las cifras de tu fecha de nacimiento, escribe diamesaño : ")
                        n = Console.ReadLine()
                        If n = "" Then Exit Do
                        GetSumaCifrasNumero((n))
                    Loop
            End Select
            Console.Write(vbCrLf & "Pulsa enter para volver al inicio ... ")
            Console.ReadLine()

        Loop

    End Sub


    Sub GetSumaCifrasNumero(n As String)
        Dim suma As Integer = 0
        For i = 1 To n.Length
            suma += Val(GetChar(n, i))
        Next
        Console.WriteLine("la suma de " & n & " es : " & suma)
    End Sub

    Sub NumeroPrimo(n As Integer)
        'PARA AHCER
        'Dim n As Integer = 71
        Dim primo As Boolean = True
        Dim div As Integer = 0
        Dim i As Integer

        If n Mod 2 = 0 Then
            'n es par
            Console.WriteLine(n & " es par y no es primo")
            div = 2
            primo = False
        Else
            For i = 3 To Int(n / 2) Step 2
                If n Mod i = 0 Then
                    'n no es primo
                    Console.WriteLine(n & " Es divisible por " & i)
                    div = i
                    primo = False
                    'Exit For
                End If
            Next
        End If
        If div <> 0 Then
            ' Console.WriteLine("Divisor es: " & div)
        Else
            Console.WriteLine(n & " es primo =" & primo)
        End If


    End Sub

    Sub TantoPorCiento(l As Double)
        Const porcentaje As Integer = 20
        Dim p As Double = porcentaje / 100 * l
        Console.WriteLine("EL porcentaje de ahorro del " & porcentaje & "% sobre un total de " & l & " € es de " & p)

    End Sub
    Sub Salutaciones()
        Console.WriteLine("  Bienvenido a mi mundo!!!!    " & vbCrLf)
        Console.WriteLine("Escribe tu Nombre : ")
        Dim c As String = Console.ReadLine()
        Console.WriteLine("Te LLAmas " & c & vbCrLf)
        Console.WriteLine("Dinos Tu edad : ")
        Dim i As Long = Val(Console.ReadLine())
        Console.WriteLine("NAciste en el " & (Now.Year - i))

    End Sub
    Function SumaNumeros() As Double
        Console.WriteLine("Introduce los precios de tu lista de la compra  : ")
        Dim s As String = Console.ReadLine()
        s = s.Replace(".", ",")
        Dim ns() As String = Split(s, " ")
        Dim f As Double
        For Each x As Double In ns
            Console.Write(x & " ")
            f += x
        Next
        Console.WriteLine("LA suma es : " & (f))
        Return f
    End Function
End Module


