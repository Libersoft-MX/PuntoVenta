﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsuarioConsultar
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
        Me.CUsuario = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Datos = New System.Windows.Forms.GroupBox()
        Me.TDireccion = New System.Windows.Forms.Label()
        Me.TSexo = New System.Windows.Forms.Label()
        Me.TNacimiento = New System.Windows.Forms.Label()
        Me.TApellidos = New System.Windows.Forms.Label()
        Me.TNombre = New System.Windows.Forms.Label()
        Me.TTipo = New System.Windows.Forms.Label()
        Me.TPassword = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BCerrar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TRegistro = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Datos.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CUsuario
        '
        Me.CUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CUsuario.FormattingEnabled = True
        Me.CUsuario.Location = New System.Drawing.Point(136, 50)
        Me.CUsuario.Name = "CUsuario"
        Me.CUsuario.Size = New System.Drawing.Size(183, 26)
        Me.CUsuario.TabIndex = 64
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(43, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 19)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Usuario :"
        '
        'Datos
        '
        Me.Datos.Controls.Add(Me.TRegistro)
        Me.Datos.Controls.Add(Me.Label11)
        Me.Datos.Controls.Add(Me.TDireccion)
        Me.Datos.Controls.Add(Me.TSexo)
        Me.Datos.Controls.Add(Me.TNacimiento)
        Me.Datos.Controls.Add(Me.TApellidos)
        Me.Datos.Controls.Add(Me.TNombre)
        Me.Datos.Controls.Add(Me.TTipo)
        Me.Datos.Controls.Add(Me.TPassword)
        Me.Datos.Controls.Add(Me.Label9)
        Me.Datos.Controls.Add(Me.GroupBox2)
        Me.Datos.Controls.Add(Me.Label6)
        Me.Datos.Controls.Add(Me.Label5)
        Me.Datos.Controls.Add(Me.Label4)
        Me.Datos.Controls.Add(Me.Label3)
        Me.Datos.Controls.Add(Me.Label2)
        Me.Datos.Controls.Add(Me.Label1)
        Me.Datos.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Datos.Location = New System.Drawing.Point(37, 82)
        Me.Datos.Name = "Datos"
        Me.Datos.Size = New System.Drawing.Size(384, 408)
        Me.Datos.TabIndex = 62
        Me.Datos.TabStop = False
        Me.Datos.Text = "Datos"
        '
        'TDireccion
        '
        Me.TDireccion.AutoSize = True
        Me.TDireccion.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDireccion.ForeColor = System.Drawing.Color.DodgerBlue
        Me.TDireccion.Location = New System.Drawing.Point(120, 224)
        Me.TDireccion.Name = "TDireccion"
        Me.TDireccion.Size = New System.Drawing.Size(0, 18)
        Me.TDireccion.TabIndex = 64
        '
        'TSexo
        '
        Me.TSexo.AutoSize = True
        Me.TSexo.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSexo.ForeColor = System.Drawing.Color.DodgerBlue
        Me.TSexo.Location = New System.Drawing.Point(120, 192)
        Me.TSexo.Name = "TSexo"
        Me.TSexo.Size = New System.Drawing.Size(0, 18)
        Me.TSexo.TabIndex = 63
        '
        'TNacimiento
        '
        Me.TNacimiento.AutoSize = True
        Me.TNacimiento.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TNacimiento.ForeColor = System.Drawing.Color.DodgerBlue
        Me.TNacimiento.Location = New System.Drawing.Point(195, 158)
        Me.TNacimiento.Name = "TNacimiento"
        Me.TNacimiento.Size = New System.Drawing.Size(0, 18)
        Me.TNacimiento.TabIndex = 62
        '
        'TApellidos
        '
        Me.TApellidos.AutoSize = True
        Me.TApellidos.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TApellidos.ForeColor = System.Drawing.Color.DodgerBlue
        Me.TApellidos.Location = New System.Drawing.Point(120, 126)
        Me.TApellidos.Name = "TApellidos"
        Me.TApellidos.Size = New System.Drawing.Size(0, 18)
        Me.TApellidos.TabIndex = 61
        '
        'TNombre
        '
        Me.TNombre.AutoSize = True
        Me.TNombre.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TNombre.ForeColor = System.Drawing.Color.DodgerBlue
        Me.TNombre.Location = New System.Drawing.Point(120, 97)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(0, 18)
        Me.TNombre.TabIndex = 60
        '
        'TTipo
        '
        Me.TTipo.AutoSize = True
        Me.TTipo.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTipo.ForeColor = System.Drawing.Color.DodgerBlue
        Me.TTipo.Location = New System.Drawing.Point(120, 65)
        Me.TTipo.Name = "TTipo"
        Me.TTipo.Size = New System.Drawing.Size(0, 18)
        Me.TTipo.TabIndex = 59
        '
        'TPassword
        '
        Me.TPassword.AutoSize = True
        Me.TPassword.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPassword.ForeColor = System.Drawing.Color.DodgerBlue
        Me.TPassword.Location = New System.Drawing.Point(120, 33)
        Me.TPassword.Name = "TPassword"
        Me.TPassword.Size = New System.Drawing.Size(0, 18)
        Me.TPassword.TabIndex = 58
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 158)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(183, 19)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Fecha de  Nacimiento :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckedListBox1)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 277)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(353, 125)
        Me.GroupBox2.TabIndex = 54
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Permisos"
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(10, 25)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(333, 46)
        Me.CheckedListBox1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 19)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Tipo :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 19)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Sexo :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 19)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Dirección :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 19)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Apellidos :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 19)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Nombre :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 19)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Contraseña :"
        '
        'BCerrar
        '
        Me.BCerrar.Location = New System.Drawing.Point(332, 496)
        Me.BCerrar.Name = "BCerrar"
        Me.BCerrar.Size = New System.Drawing.Size(93, 29)
        Me.BCerrar.TabIndex = 60
        Me.BCerrar.Text = "Cerrar"
        Me.BCerrar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(252, 29)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Consulta de usuario:"
        '
        'TRegistro
        '
        Me.TRegistro.AutoSize = True
        Me.TRegistro.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TRegistro.ForeColor = System.Drawing.Color.DodgerBlue
        Me.TRegistro.Location = New System.Drawing.Point(159, 255)
        Me.TRegistro.Name = "TRegistro"
        Me.TRegistro.Size = New System.Drawing.Size(0, 18)
        Me.TRegistro.TabIndex = 66
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 255)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(152, 19)
        Me.Label11.TabIndex = 65
        Me.Label11.Text = "Fecha de registro :"
        '
        'UsuarioConsultar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 537)
        Me.Controls.Add(Me.CUsuario)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Datos)
        Me.Controls.Add(Me.BCerrar)
        Me.Controls.Add(Me.Label8)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UsuarioConsultar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de usuario"
        Me.Datos.ResumeLayout(False)
        Me.Datos.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Datos As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BCerrar As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TDireccion As System.Windows.Forms.Label
    Friend WithEvents TSexo As System.Windows.Forms.Label
    Friend WithEvents TNacimiento As System.Windows.Forms.Label
    Friend WithEvents TApellidos As System.Windows.Forms.Label
    Friend WithEvents TNombre As System.Windows.Forms.Label
    Friend WithEvents TTipo As System.Windows.Forms.Label
    Friend WithEvents TPassword As System.Windows.Forms.Label
    Friend WithEvents TRegistro As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
