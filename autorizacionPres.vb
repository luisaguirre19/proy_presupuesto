Public Class autorizacionPres
    Public estado As String
    Public descripcion As String
    Public monto As String
    Public area As String
    Public detalle_desc As String
    Public fecha As String
    Public usuario As String
    Public estado_presup As String

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        estado = "salio"
        Me.Close()
    End Sub

    Private Sub autorizar_Click(sender As Object, e As EventArgs) Handles autorizar.Click
        If txt_desc.Text = "" Then
            MsgBox("Debe ingresar una breve descripcion de la accion elegida")
            Exit Sub
        End If
        If estado_presup = "Ingresado" Then
            estado = "AF"
        ElseIf estado_presup = "AF" Then
            estado = "AG"
        ElseIf estado_presup = "AG" Then
            estado = "AA"
        End If
        descripcion = txt_desc.Text
        MsgBox("Se autoriza el presupuesto", MsgBoxStyle.OkOnly)
        Me.Close()
    End Sub

    Private Sub denegar_Click(sender As Object, e As EventArgs) Handles denegar.Click
        If txt_desc.Text = "" Then
            MsgBox("Debe ingresar una breve descripcion de la accion elegida")
        End If
        estado = "Denegado"
        descripcion = txt_desc.Text
        Me.Close()
    End Sub

    Private Sub autorizacionPres_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtarea.Text = area
        txtdesc.Text = detalle_desc
        txtfecha.Text = fecha
        txtmonto.Text = monto
        txtusuario.Text = usuario
    End Sub
End Class