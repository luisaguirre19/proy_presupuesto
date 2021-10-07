Public Class ingresoPresupuesto
    Dim func As New cls_eventos
    Dim dt As New DataTable
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Esta seguro que desea salir, esta accion borrar los datos ingresado sin guardar", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkCancel) = vbOK Then
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If datos_conexion("sp_presupuesto") = False Then
            MsgBox("No hubo conexión con el SP favor revisar conexión con servidor")
            Me.Dispose()
        End If

        func.envio_sp("@operacion", Trim("I"))
        func.envio_sp("@suboperacion", Trim("P"))
        func.envio_sp("@monto", Trim(CDec(monto.Text)))
        func.envio_sp("@area", Trim(area_presupuesto.Text))
        func.envio_sp("@descripcion", Trim(desc_presupuesto.Text))
        func.envio_sp("@nombre", (user))

        dt = Func.mapeatabla()
        func.con_close()
        If MsgBox("El presupuesto fue ingresado correctamente, ¿Desea ingresar otro?", MsgBoxStyle.YesNo Or MsgBoxStyle.Information) = vbNo Then
            Me.Close()
        End If
        PL_LIMPIAR()

    End Sub

    Private Sub PL_LIMPIAR()
        monto.Text = ""
        desc_presupuesto.Text = ""
        area_presupuesto.Text = ""
    End Sub
End Class