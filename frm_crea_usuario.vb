Public Class frm_crea_usuario
    Dim func As New cls_eventos
    Dim dt As New DataTable
    Private Sub frm_crea_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consulta_usuario()
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox(ComboBox1.SelectedItem & " " & ComboBox1.SelectedIndex & " " & ComboBox1.SelectedValue)
    End Sub
End Class