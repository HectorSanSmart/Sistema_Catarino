﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NUEVO_MEDICO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NUEVO_MEDICO))
        Me.CMBESPECIALIDAD = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BTNSALIR = New System.Windows.Forms.Button()
        Me.BTNACEPTAR = New System.Windows.Forms.Button()
        Me.TXTIDENTIDAD = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTMEDICO = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TXTHORARIO = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CBJUEVES = New System.Windows.Forms.CheckBox()
        Me.CBMIERCOLES = New System.Windows.Forms.CheckBox()
        Me.CBMARTES = New System.Windows.Forms.CheckBox()
        Me.CBLUNES = New System.Windows.Forms.CheckBox()
        Me.CBVIERNES = New System.Windows.Forms.CheckBox()
        Me.CMBCONSULTORIO = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXTCOMENTARIO = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BTNMODIFICAR = New System.Windows.Forms.Button()
        Me.CBACTIVO = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CBINACTIVO = New System.Windows.Forms.CheckBox()
        Me.BTNIDENTIDAD = New System.Windows.Forms.Button()
        Me.TXTTARJETA = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TXTCOD_ESPECIALIDAD = New System.Windows.Forms.TextBox()
        Me.TXTESTADO = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TXTCUPO = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CMBESPECIALIDAD
        '
        Me.CMBESPECIALIDAD.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.CMBESPECIALIDAD.FormattingEnabled = True
        Me.CMBESPECIALIDAD.Location = New System.Drawing.Point(239, 102)
        Me.CMBESPECIALIDAD.Name = "CMBESPECIALIDAD"
        Me.CMBESPECIALIDAD.Size = New System.Drawing.Size(327, 21)
        Me.CMBESPECIALIDAD.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 16)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "ESPECIALIDAD"
        '
        'BTNSALIR
        '
        Me.BTNSALIR.BackColor = System.Drawing.Color.Silver
        Me.BTNSALIR.BackgroundImage = CType(resources.GetObject("BTNSALIR.BackgroundImage"), System.Drawing.Image)
        Me.BTNSALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNSALIR.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BTNSALIR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNSALIR.Location = New System.Drawing.Point(635, 499)
        Me.BTNSALIR.Name = "BTNSALIR"
        Me.BTNSALIR.Size = New System.Drawing.Size(95, 89)
        Me.BTNSALIR.TabIndex = 17
        Me.BTNSALIR.UseVisualStyleBackColor = False
        '
        'BTNACEPTAR
        '
        Me.BTNACEPTAR.BackColor = System.Drawing.Color.Silver
        Me.BTNACEPTAR.BackgroundImage = CType(resources.GetObject("BTNACEPTAR.BackgroundImage"), System.Drawing.Image)
        Me.BTNACEPTAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNACEPTAR.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BTNACEPTAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNACEPTAR.Location = New System.Drawing.Point(308, 499)
        Me.BTNACEPTAR.Name = "BTNACEPTAR"
        Me.BTNACEPTAR.Size = New System.Drawing.Size(95, 89)
        Me.BTNACEPTAR.TabIndex = 15
        Me.BTNACEPTAR.UseVisualStyleBackColor = False
        '
        'TXTIDENTIDAD
        '
        Me.TXTIDENTIDAD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTIDENTIDAD.Location = New System.Drawing.Point(193, 67)
        Me.TXTIDENTIDAD.MaxLength = 15
        Me.TXTIDENTIDAD.Name = "TXTIDENTIDAD"
        Me.TXTIDENTIDAD.Size = New System.Drawing.Size(373, 20)
        Me.TXTIDENTIDAD.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(394, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(211, 29)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "NUEVO MEDICO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(359, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(295, 25)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "SAN PEDRO SULA, CORTES"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(236, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(524, 25)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "HOSPITAL NACIONAL DR. MARIO CATARINO RIVAS"
        '
        'TXTMEDICO
        '
        Me.TXTMEDICO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTMEDICO.Location = New System.Drawing.Point(193, 32)
        Me.TXTMEDICO.MaxLength = 50
        Me.TXTMEDICO.Name = "TXTMEDICO"
        Me.TXTMEDICO.Size = New System.Drawing.Size(373, 20)
        Me.TXTMEDICO.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 16)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "IDENTIDAD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "NOMBRE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(333, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(351, 25)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "SECRETARIA DE SALUD PUBLICA"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(799, 6)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(89, 107)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 33
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(208, 92)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 31
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 98)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(270, 324)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'TXTHORARIO
        '
        Me.TXTHORARIO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTHORARIO.Location = New System.Drawing.Point(194, 176)
        Me.TXTHORARIO.MaxLength = 50
        Me.TXTHORARIO.Name = "TXTHORARIO"
        Me.TXTHORARIO.Size = New System.Drawing.Size(372, 20)
        Me.TXTHORARIO.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 180)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(175, 16)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "HORARIO DE ATENCION"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 213)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(175, 16)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "DIAS DE ATENCION"
        '
        'CBJUEVES
        '
        Me.CBJUEVES.AutoSize = True
        Me.CBJUEVES.Location = New System.Drawing.Point(433, 212)
        Me.CBJUEVES.Name = "CBJUEVES"
        Me.CBJUEVES.Size = New System.Drawing.Size(67, 17)
        Me.CBJUEVES.TabIndex = 10
        Me.CBJUEVES.Text = "JUEVES"
        Me.CBJUEVES.UseVisualStyleBackColor = True
        '
        'CBMIERCOLES
        '
        Me.CBMIERCOLES.AutoSize = True
        Me.CBMIERCOLES.Location = New System.Drawing.Point(339, 212)
        Me.CBMIERCOLES.Name = "CBMIERCOLES"
        Me.CBMIERCOLES.Size = New System.Drawing.Size(88, 17)
        Me.CBMIERCOLES.TabIndex = 9
        Me.CBMIERCOLES.Text = "MIERCOLES"
        Me.CBMIERCOLES.UseVisualStyleBackColor = True
        '
        'CBMARTES
        '
        Me.CBMARTES.AutoSize = True
        Me.CBMARTES.Location = New System.Drawing.Point(262, 212)
        Me.CBMARTES.Name = "CBMARTES"
        Me.CBMARTES.Size = New System.Drawing.Size(71, 17)
        Me.CBMARTES.TabIndex = 8
        Me.CBMARTES.Text = "MARTES"
        Me.CBMARTES.UseVisualStyleBackColor = True
        '
        'CBLUNES
        '
        Me.CBLUNES.AutoSize = True
        Me.CBLUNES.Location = New System.Drawing.Point(194, 212)
        Me.CBLUNES.Name = "CBLUNES"
        Me.CBLUNES.Size = New System.Drawing.Size(62, 17)
        Me.CBLUNES.TabIndex = 7
        Me.CBLUNES.Text = "LUNES"
        Me.CBLUNES.UseVisualStyleBackColor = True
        '
        'CBVIERNES
        '
        Me.CBVIERNES.AutoSize = True
        Me.CBVIERNES.Location = New System.Drawing.Point(503, 211)
        Me.CBVIERNES.Name = "CBVIERNES"
        Me.CBVIERNES.Size = New System.Drawing.Size(73, 17)
        Me.CBVIERNES.TabIndex = 11
        Me.CBVIERNES.Text = "VIERNES"
        Me.CBVIERNES.UseVisualStyleBackColor = True
        '
        'CMBCONSULTORIO
        '
        Me.CMBCONSULTORIO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.CMBCONSULTORIO.FormattingEnabled = True
        Me.CMBCONSULTORIO.Location = New System.Drawing.Point(194, 136)
        Me.CMBCONSULTORIO.Name = "CMBCONSULTORIO"
        Me.CMBCONSULTORIO.Size = New System.Drawing.Size(372, 21)
        Me.CMBCONSULTORIO.Sorted = True
        Me.CMBCONSULTORIO.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 141)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(131, 16)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "NO. CONSULTORIO"
        '
        'TXTCOMENTARIO
        '
        Me.TXTCOMENTARIO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTCOMENTARIO.Location = New System.Drawing.Point(194, 244)
        Me.TXTCOMENTARIO.Multiline = True
        Me.TXTCOMENTARIO.Name = "TXTCOMENTARIO"
        Me.TXTCOMENTARIO.Size = New System.Drawing.Size(372, 50)
        Me.TXTCOMENTARIO.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(13, 248)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 16)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "COMENTARIO"
        '
        'BTNMODIFICAR
        '
        Me.BTNMODIFICAR.BackColor = System.Drawing.Color.Silver
        Me.BTNMODIFICAR.BackgroundImage = CType(resources.GetObject("BTNMODIFICAR.BackgroundImage"), System.Drawing.Image)
        Me.BTNMODIFICAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTNMODIFICAR.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(474, 499)
        Me.BTNMODIFICAR.Name = "BTNMODIFICAR"
        Me.BTNMODIFICAR.Size = New System.Drawing.Size(95, 89)
        Me.BTNMODIFICAR.TabIndex = 16
        Me.BTNMODIFICAR.UseVisualStyleBackColor = False
        '
        'CBACTIVO
        '
        Me.CBACTIVO.AutoSize = True
        Me.CBACTIVO.Location = New System.Drawing.Point(17, 39)
        Me.CBACTIVO.Name = "CBACTIVO"
        Me.CBACTIVO.Size = New System.Drawing.Size(65, 17)
        Me.CBACTIVO.TabIndex = 14
        Me.CBACTIVO.Text = "ACTIVO"
        Me.CBACTIVO.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CBINACTIVO)
        Me.GroupBox1.Controls.Add(Me.CBACTIVO)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 393)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ESTADO DEL MEDICO"
        '
        'CBINACTIVO
        '
        Me.CBINACTIVO.AutoSize = True
        Me.CBINACTIVO.Location = New System.Drawing.Point(100, 39)
        Me.CBINACTIVO.Name = "CBINACTIVO"
        Me.CBINACTIVO.Size = New System.Drawing.Size(76, 17)
        Me.CBINACTIVO.TabIndex = 15
        Me.CBINACTIVO.Text = "INACTIVO"
        Me.CBINACTIVO.UseVisualStyleBackColor = True
        '
        'BTNIDENTIDAD
        '
        Me.BTNIDENTIDAD.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BTNIDENTIDAD.BackgroundImage = CType(resources.GetObject("BTNIDENTIDAD.BackgroundImage"), System.Drawing.Image)
        Me.BTNIDENTIDAD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNIDENTIDAD.FlatAppearance.BorderSize = 50
        Me.BTNIDENTIDAD.Location = New System.Drawing.Point(569, 64)
        Me.BTNIDENTIDAD.Name = "BTNIDENTIDAD"
        Me.BTNIDENTIDAD.Size = New System.Drawing.Size(31, 25)
        Me.BTNIDENTIDAD.TabIndex = 3
        Me.BTNIDENTIDAD.UseVisualStyleBackColor = False
        '
        'TXTTARJETA
        '
        Me.TXTTARJETA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTTARJETA.Location = New System.Drawing.Point(193, 303)
        Me.TXTTARJETA.MaxLength = 8
        Me.TXTTARJETA.Name = "TXTTARJETA"
        Me.TXTTARJETA.Size = New System.Drawing.Size(188, 20)
        Me.TXTTARJETA.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 307)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(175, 16)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "HORARIO DE TARJETA"
        '
        'TXTCOD_ESPECIALIDAD
        '
        Me.TXTCOD_ESPECIALIDAD.Enabled = False
        Me.TXTCOD_ESPECIALIDAD.Location = New System.Drawing.Point(194, 102)
        Me.TXTCOD_ESPECIALIDAD.Name = "TXTCOD_ESPECIALIDAD"
        Me.TXTCOD_ESPECIALIDAD.Size = New System.Drawing.Size(43, 20)
        Me.TXTCOD_ESPECIALIDAD.TabIndex = 3
        '
        'TXTESTADO
        '
        Me.TXTESTADO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTESTADO.Location = New System.Drawing.Point(37, 499)
        Me.TXTESTADO.MaxLength = 50
        Me.TXTESTADO.Name = "TXTESTADO"
        Me.TXTESTADO.Size = New System.Drawing.Size(128, 20)
        Me.TXTESTADO.TabIndex = 62
        Me.TXTESTADO.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TXTCUPO)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TXTCOD_ESPECIALIDAD)
        Me.GroupBox2.Controls.Add(Me.TXTMEDICO)
        Me.GroupBox2.Controls.Add(Me.TXTTARJETA)
        Me.GroupBox2.Controls.Add(Me.TXTIDENTIDAD)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.BTNIDENTIDAD)
        Me.GroupBox2.Controls.Add(Me.CMBESPECIALIDAD)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TXTHORARIO)
        Me.GroupBox2.Controls.Add(Me.TXTCOMENTARIO)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.CBLUNES)
        Me.GroupBox2.Controls.Add(Me.CMBCONSULTORIO)
        Me.GroupBox2.Controls.Add(Me.CBMARTES)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.CBMIERCOLES)
        Me.GroupBox2.Controls.Add(Me.CBVIERNES)
        Me.GroupBox2.Controls.Add(Me.CBJUEVES)
        Me.GroupBox2.Location = New System.Drawing.Point(266, 145)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(615, 348)
        Me.GroupBox2.TabIndex = 63
        Me.GroupBox2.TabStop = False
        '
        'TXTCUPO
        '
        Me.TXTCUPO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTCUPO.Location = New System.Drawing.Point(488, 302)
        Me.TXTCUPO.MaxLength = 3
        Me.TXTCUPO.Name = "TXTCUPO"
        Me.TXTCUPO.Size = New System.Drawing.Size(79, 20)
        Me.TXTCUPO.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(418, 303)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 23)
        Me.Label13.TabIndex = 63
        Me.Label13.Text = "CUPOS"
        '
        'NUEVO_MEDICO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(893, 597)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TXTESTADO)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTNMODIFICAR)
        Me.Controls.Add(Me.BTNSALIR)
        Me.Controls.Add(Me.BTNACEPTAR)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "NUEVO_MEDICO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NUEVO MEDICO"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMBESPECIALIDAD As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BTNSALIR As System.Windows.Forms.Button
    Friend WithEvents BTNACEPTAR As System.Windows.Forms.Button
    Friend WithEvents TXTIDENTIDAD As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TXTMEDICO As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TXTHORARIO As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CBJUEVES As System.Windows.Forms.CheckBox
    Friend WithEvents CBMIERCOLES As System.Windows.Forms.CheckBox
    Friend WithEvents CBMARTES As System.Windows.Forms.CheckBox
    Friend WithEvents CBLUNES As System.Windows.Forms.CheckBox
    Friend WithEvents CBVIERNES As System.Windows.Forms.CheckBox
    Friend WithEvents CMBCONSULTORIO As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TXTCOMENTARIO As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents BTNMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents CBACTIVO As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CBINACTIVO As System.Windows.Forms.CheckBox
    Friend WithEvents BTNIDENTIDAD As System.Windows.Forms.Button
    Friend WithEvents TXTTARJETA As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TXTCOD_ESPECIALIDAD As System.Windows.Forms.TextBox
    Friend WithEvents TXTESTADO As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TXTCUPO As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
