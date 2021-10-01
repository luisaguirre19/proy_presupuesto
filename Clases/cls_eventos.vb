Public Class cls_eventos
    Dim dat As New DataTable
    Public usuario As String
    ''' <summary>
    ''' AGREGACIÓN DE PARÁMETROS PARA LA EJECUCIÓN DEL SP
    ''' </summary>
    ''' <param name="param_name"></param>
    ''' <param name="dato_envia"></param>
    ''' <param name="mandar"></param>
    ''' <remarks></remarks>
    Public Sub envio_sp(ByVal param_name As String, ByVal dato_envia As String, Optional ByVal mandar As Boolean = False)
        Try

            cmd.Parameters.AddWithValue(param_name, dato_envia)

        Catch ex As Exception
            MsgBox("error")
        Finally
        End Try
    End Sub

    Public Sub envio_sp_int(ByVal param_name As String, ByVal dato_envia As Integer, Optional ByVal mandar As Boolean = False)
        Try

            cmd.Parameters.AddWithValue(param_name, dato_envia)

        Catch ex As Exception
            MsgBox("error")
        Finally
        End Try
    End Sub
    Public Sub envio_sp_float(ByVal param_name As String, ByVal dato_envia As Double, Optional ByVal mandar As Boolean = False)
        Try

            cmd.Parameters.AddWithValue(param_name, dato_envia)

        Catch ex As Exception
            MsgBox("error")
        Finally
        End Try
    End Sub

    ''' <summary>
    ''' TRANSMITE LOS DATOS AL SP
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function transmitir_sp(Optional id As String = "", Optional padre As String = "", Optional precio As Decimal = 0.00, Optional costo As Decimal = 0.00)
        Try
            If cmd.ExecuteNonQuery() > 0 Then

                Return True
            Else
                Return False
                cn.Close()
            End If

        Catch ex As Exception
            cn.Close()
            MsgBox("error " & id & " " & padre & " " & precio & " " & costo & " " & ex.Message)
            Return False
        Finally
        End Try
    End Function

    ''' <summary>
    ''' SI ES UNA TABLA LA QUE RETORNA ESTE SE EJECUTA PARA MAPEARLA
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function mapeatabla()
        Try
            Dim dt = New DataTable
            sql_adapter.Fill(dt)
            Return dt
        Catch ex As Exception
            cn.Close()
            MsgBox("error mapeando tabla --> " + ex.Message)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' CIERRE DE CONEXIÓN CON LA BASE DE DATOS
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub con_close()
        Try
            cn.Close()
        Catch ex As Exception
            MsgBox("ERROR AL CERRAR LA CONEXIÓN")
        End Try
    End Sub
End Class
