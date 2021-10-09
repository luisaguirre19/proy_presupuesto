Public Class AuditoriaAutori
    Dim func As New cls_eventos
    Dim dt As New DataTable
    Dim dt1 As New DataTable
    Dim dt3 As New DataTable

    Private Sub AuditoriaAutori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If rol <> 3 Then TabControl1.TabPages.Remove(TabPage1)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.DataSource = Nothing
        If datos_conexion("sp_presupuesto") = False Then
            MsgBox("No hubo conexión con el SP favor revisar conexión con servidor")
            Me.Dispose()
        End If

        func.envio_sp("@operacion", Trim("S"))
        func.envio_sp("@suboperacion", Trim("H"))
        If Trim(txtusuario.Text) <> "" Then
            func.envio_sp("@nombre", Trim(txtusuario.Text))
        End If

        If Trim(txtcod.Text) <> "" Then
            func.envio_sp("@id", IIf(Trim(txtcod.Text) = "", Nothing, Trim(txtcod.Text)))
        End If

        func.envio_sp("@fecha_ini", Format(fecha_inicio.Value, "MM/dd/yyyy") + " 0:00")
        func.envio_sp("@fecha_fin", Format(fecha_fin.Value, "MM/dd/yyyy") + " 23:59")

        dt1 = func.mapeatabla()
        func.con_close()

        If dt1.Rows.Count > 0 Then
            DataGridView1.DataSource = dt1
        End If
    End Sub

    Private Sub txtcod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcod.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtusuario.Text = ""
        txtcod.Text = ""
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If datos_conexion("sp_presupuesto") = False Then
            MsgBox("No hubo conexión con el SP favor revisar conexión con servidor")
            Me.Dispose()
        End If

        func.envio_sp("@operacion", Trim("S"))
        func.envio_sp("@suboperacion", Trim("I"))
        func.envio_sp("@id", DataGridView1.CurrentRow.Cells(1).Value.ToString)

        dt3 = func.mapeatabla()
        func.con_close()

        If dt3.Rows.Count = 0 Then
            MsgBox("No se encontraron datos", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly)
        End If


        Dim frm As New autorizacionPres
        frm.monto = dt3.Rows(0)(1)
        frm.area = dt3.Rows(0)(2)
        frm.detalle_desc = dt3.Rows(0)(3)
        frm.estado_presup = dt3.Rows(0)(5)
        frm.fecha = dt3.Rows(0)(4)
        frm.usuario = dt3.Rows(0)(6)
        frm.ShowDialog()

        If frm.estado <> "salio" Then

            If datos_conexion("sp_presupuesto") = False Then
                MsgBox("No hubo conexión con el SP favor revisar conexión con servidor")
                Me.Dispose()
            End If

            func.envio_sp("@operacion", Trim("U"))
            func.envio_sp("@suboperacion", Trim("P"))
            func.envio_sp("@id", DataGridView1.CurrentRow.Cells(1).Value.ToString)
            func.envio_sp("@estado", frm.estado)
            func.envio_sp("@descripcion", frm.descripcion)
            func.envio_sp("@nombre", user)

            func.transmitir_sp()
            func.con_close()

        End If


        pendientes_autorizar()


    End Sub
End Class