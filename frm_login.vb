Public Class frm_login
    Dim func As New cls_eventos
    Dim dt As New DataTable

    Private Sub btn_ingresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click
        If datos_conexion("sp_presupuesto") = False Then
            MsgBox("No hubo conexión con el SP favor revisar conexión con servidor")
            Me.Dispose()
        End If

        func.envio_sp("@operacion", Trim("S"))
        func.envio_sp("@suboperacion", Trim("L"))
        func.envio_sp("@mail", Trim(txt_correo.Text))
        func.envio_sp("@pass", Trim(txt_password.Text))

        dt = func.mapeatabla()
        func.con_close()
        If dt.Rows.Count > 0 Then
            If dt.Rows(0)(0) = 2 Then
                frm_crea_usuario.ShowDialog()
                Me.Close()
            Else
                MsgBox("usuarios no tiene autorizacion")
            End If
        Else
            MsgBox("nada")
        End If
        func.con_close()
    End Sub
End Class