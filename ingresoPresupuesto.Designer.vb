﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ingresoPresupuesto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.desc_presupuesto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fecha_presupuesto = New System.Windows.Forms.DateTimePicker()
        Me.area_presupuesto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.monto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.desc_presupuesto)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.fecha_presupuesto)
        Me.Panel1.Controls.Add(Me.area_presupuesto)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.monto)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(742, 648)
        Me.Panel1.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(454, 561)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(134, 54)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(164, 561)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 54)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Enviar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'desc_presupuesto
        '
        Me.desc_presupuesto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desc_presupuesto.Location = New System.Drawing.Point(53, 387)
        Me.desc_presupuesto.Multiline = True
        Me.desc_presupuesto.Name = "desc_presupuesto"
        Me.desc_presupuesto.Size = New System.Drawing.Size(656, 129)
        Me.desc_presupuesto.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(48, 355)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 27)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Descripción"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(48, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(262, 27)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fecha del Presupuesto"
        '
        'fecha_presupuesto
        '
        Me.fecha_presupuesto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha_presupuesto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_presupuesto.Location = New System.Drawing.Point(53, 283)
        Me.fecha_presupuesto.Name = "fecha_presupuesto"
        Me.fecha_presupuesto.Size = New System.Drawing.Size(250, 30)
        Me.fecha_presupuesto.TabIndex = 5
        '
        'area_presupuesto
        '
        Me.area_presupuesto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.area_presupuesto.Location = New System.Drawing.Point(421, 165)
        Me.area_presupuesto.Multiline = True
        Me.area_presupuesto.Name = "area_presupuesto"
        Me.area_presupuesto.Size = New System.Drawing.Size(288, 38)
        Me.area_presupuesto.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(416, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(238, 27)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Area de Presupuesto"
        '
        'monto
        '
        Me.monto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.monto.Location = New System.Drawing.Point(53, 165)
        Me.monto.Multiline = True
        Me.monto.Name = "monto"
        Me.monto.Size = New System.Drawing.Size(249, 38)
        Me.monto.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Monto"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(716, 72)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingreso de Presupuesto"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ingresoPresupuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 648)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ingresoPresupuesto"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents desc_presupuesto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents fecha_presupuesto As DateTimePicker
    Friend WithEvents area_presupuesto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents monto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
