Public Class AuditoriaAutori
    Dim func As New cls_eventos
    Dim dt As New DataTable
    Private Sub AuditoriaAutori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pendientes_autorizar()
    End Sub

    Private Sub pendientes_autorizar()
        DataGridView2.DataSource = Nothing
        If datos_conexion("sp_presupuesto") = False Then
            MsgBox("No hubo conexión con el SP favor revisar conexión con servidor")
            Me.Dispose()
        End If

        Func.envio_sp("@operacion", Trim("S"))
        Func.envio_sp("@suboperacion", Trim("P"))
        func.envio_sp("@estado", Trim("AF"))


        dt = Func.mapeatabla()
        Func.con_close()

        If dt.Rows.Count > 0 Then
            DataGridView2.DataSource = dt
        End If
        Label7.Text = "Selecciona con doble click el registro a modificar"
    End Sub

    Private Sub DataGridView2_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        Dim frm As New autorizacionPres
        frm.monto = DataGridView2.CurrentRow.Cells(1).Value.ToString
        frm.area = DataGridView2.CurrentRow.Cells(2).Value.ToString
        frm.detalle_desc = DataGridView2.CurrentRow.Cells(3).Value.ToString
        frm.estado_presup = DataGridView2.CurrentRow.Cells(5).Value.ToString
        frm.fecha = DataGridView2.CurrentRow.Cells(4).Value.ToString
        frm.usuario = DataGridView2.CurrentRow.Cells(6).Value.ToString
        frm.ShowDialog()

        If frm.estado <> "salio" Then

            If datos_conexion("sp_presupuesto") = False Then
                MsgBox("No hubo conexión con el SP favor revisar conexión con servidor")
                Me.Dispose()
            End If

            func.envio_sp("@operacion", Trim("U"))
            func.envio_sp("@suboperacion", Trim("P"))
            func.envio_sp("@id", DataGridView2.CurrentRow.Cells(0).Value.ToString)
            func.envio_sp("@estado", frm.estado)
            func.envio_sp("@descripcion", frm.descripcion)
            func.envio_sp("@nombre", user)

            func.transmitir_sp()
            func.con_close()

        End If


        pendientes_autorizar()


    End Sub

End Class