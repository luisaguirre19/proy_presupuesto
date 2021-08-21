Imports System.Data.SqlClient

Module MD_CONEXION
    Public cn As New SqlConnection(My.Resources.conexion)
    Public cmd As New SqlCommand
    Public sql_adapter As New SqlDataAdapter

    ''' <summary>
    ''' CREACIÓN DE LAS VARIABLES DE CONEXIÓN
    ''' </summary>
    ''' <param name="sp_name"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function datos_conexion(ByVal sp_name As String)
        Try
            cn.Open()
            cmd = New SqlCommand(sp_name, cn)
            cmd.CommandType = CommandType.StoredProcedure
            sql_adapter.SelectCommand = cmd
            Return True



        Catch ex As Exception
            MsgBox("error en clase datos conexión, no se puedo realizar la conexión correctamente con la base de datos " + ex.Message)
            Return False
        End Try

    End Function
End Module
