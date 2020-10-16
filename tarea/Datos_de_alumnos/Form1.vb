Public Class Form1
    Private alumnos() As String
    Private alturas() As Single

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim cant, i As Integer
        Dim suma, promedio As Single
        Me.Text = Me.Text & " de " & txtCurso.Text
        cant = txtCant.Text
        ReDim alumnos(cant)
        ReDim alturas(cant)

        For i = 0 To cant - 1
            alumnos(i) = InputBox("Ingrese el Nombre del alumno:")
            alturas(i) = InputBox("Ingrese la Altura del alumno:")
            suma += alturas(i)        Next
        promedio = suma / cant
        lblPromedio.Text = promedio
        For i = 0 To cant - 1
            If alturas(i) > promedio Then
                lstAlumnos.Items.Add(alumnos(i) & "-->" & alturas(i))
            End If
        Next
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class
