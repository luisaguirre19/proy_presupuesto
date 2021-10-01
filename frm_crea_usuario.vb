Public Class frm_crea_usuario
    Dim func As New cls_eventos
    Dim dt As New DataTable
    Private Sub frm_crea_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consulta_usuario()
        pendientes_autorizar()

    End Sub

    Private Sub pendientes_autorizar()
        DataGridView2.DataSource = Nothing
        If datos_conexion("sp_presupuesto") = False Then
            MsgBox("No hubo conexión con el SP favor revisar conexión con servidor")
            Me.Dispose()
        End If

        func.envio_sp("@operacion", Trim("S"))
        func.envio_sp("@suboperacion", Trim("P"))
        func.envio_sp("@estado", Trim("Ingresado"))


        dt = func.mapeatabla()
        func.con_close()

        If dt.Rows.Count > 0 Then
            DataGridView2.DataSource = dt
        End If
        Label7.Text = "Selecciona con doble click el registro a modificar"
    End Sub

    Private Sub consulta_usuario()
        If datos_conexion("sp_presupuesto") = False Then
            MsgBox("No hubo conexión con el SP favor revisar conexión con servidor")
            Me.Dispose()
        End If

        func.envio_sp("@operacion", Trim("S"))
        func.envio_sp("@suboperacion", Trim("U"))

        dt = func.mapeatabla()
        func.con_close()

        If dt.Rows.Count > 0 Then
            DataGridView1.DataSource = dt
        End If
        txt_nombre.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txt_apellido.Text = "0" Or txt_nombre.Text = "" Or txt_correo.Text = "" Or txt_pass.Text = "" Or ComboBox1.SelectedIndex = -1 Then
            MsgBox("Es necesario llenar todos los campos", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Campos vacios")
            Exit Sub
        End If

        If datos_conexion("sp_presupuesto") = False Then
            MsgBox("No hubo conexión con el SP favor revisar conexión con servidor")
            Me.Dispose()
        End If

        func.envio_sp("@operacion", Trim("I"))
        func.envio_sp("@suboperacion", Trim("U"))
        func.envio_sp("@nombre", Trim(txt_nombre.Text))
        func.envio_sp("@apellido", Trim(txt_apellido.Text))
        func.envio_sp("@mail", Trim(txt_correo.Text))
        func.envio_sp("@pass", Trim(txt_pass.Text))
        func.envio_sp("@rol", ComboBox1.SelectedIndex)
        func.transmitir_sp()
        func.con_close()

        consulta_usuario()

    End Sub



    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If MsgBox("esta seguro que desea eliminar el usuario " + DataGridView1.CurrentRow.Cells(1).Value.ToString, MsgBoxStyle.Question Or MsgBoxStyle.OkCancel, "Confirmar borrado") = vbOK Then
            If datos_conexion("sp_presupuesto") = False Then
                MsgBox("No hubo conexión con el SP favor revisar conexión con servidor")
                Me.Dispose()
            End If

            func.envio_sp("@operacion", Trim("D"))
            func.envio_sp("@suboperacion", Trim("U"))
            func.envio_sp("@id", DataGridView1.CurrentRow.Cells(0).Value.ToString)
            func.transmitir_sp()
            func.con_close()

            consulta_usuario()
        End If

    End Sub

    Private Sub DataGridView2_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        Dim frm As New autorizacionPres
        frm.monto = DataGridView2.CurrentRow.Cells(1).Value.ToString
        frm.area = DataGridView2.CurrentRow.Cells(2).Value.ToString
        frm.detalle_desc = DataGridView2.CurrentRow.Cells(3).Value.ToString
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

            func.transmitir_sp()
            func.con_close()

        End If


        pendientes_autorizar()


    End Sub
End Class
