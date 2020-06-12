Imports CapaLogica

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            MsgBox(ControladorPersona.ObtenerCantidad())
        Catch ex As Exception
            MsgBox("Hubo un error")
        End Try
    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        Try
            ControladorPersona.DarDeAlta(txtId.Text, txtNombre.Text, txtApellido.Text, txtMail.Text)
            MsgBox("Persona creada")
        Catch ex As Exception
            MsgBox("Hubo un error")
        End Try

    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Try
            Dim tabla As New DataTable
            tabla.Load(ControladorPersona.ListarTodo())
            ListaDePersonas.DataSource = tabla
        Catch ex As Exception
            MsgBox("Hubo un error")
        End Try

    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Try
            ControladorPersona.Borrar(txtId.Text)
            MsgBox("Persona eliminada correctamente")
        Catch ex As Exception
            MsgBox("Hubo un error")
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If txtId.Text = "" Then
                MsgBox("Por favor, indique un id")
            Else
                ControladorPersona.Modificar(txtId.Text, txtNombre.Text, txtApellido.Text, txtMail.Text)
                MsgBox("Persona modificada correctamente")
            End If

        Catch ex As Exception
            MsgBox("Hubo un error")

        End Try
    End Sub
End Class
