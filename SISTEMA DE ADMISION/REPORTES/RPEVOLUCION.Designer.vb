﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RPEVOLUCION
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
        Me.CREVOLUCION = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.EVOLUCION = New SISTEMA_DE_ADMISION.EVOLUCION()
        Me.SuspendLayout()
        '
        'CREVOLUCION
        '
        Me.CREVOLUCION.ActiveViewIndex = -1
        Me.CREVOLUCION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CREVOLUCION.Cursor = System.Windows.Forms.Cursors.Default
        Me.CREVOLUCION.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CREVOLUCION.Location = New System.Drawing.Point(0, 0)
        Me.CREVOLUCION.Name = "CREVOLUCION"
        Me.CREVOLUCION.Size = New System.Drawing.Size(971, 643)
        Me.CREVOLUCION.TabIndex = 0
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.EVOLUCION
        Me.CrystalReportViewer1.ShowCloseButton = False
        Me.CrystalReportViewer1.ShowCopyButton = False
        Me.CrystalReportViewer1.ShowExportButton = False
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowLogo = False
        Me.CrystalReportViewer1.ShowParameterPanelButton = False
        Me.CrystalReportViewer1.ShowRefreshButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(971, 643)
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'RPEVOLUCION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(971, 643)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.CREVOLUCION)
        Me.MinimizeBox = False
        Me.Name = "RPEVOLUCION"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HOJA DE EVOLUCION"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CREVOLUCION As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents EVOLUCION As SISTEMA_DE_ADMISION.EVOLUCION
End Class
