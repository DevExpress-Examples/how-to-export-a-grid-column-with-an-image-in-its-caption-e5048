﻿' Developer Express Code Central Example:
' How to create a GridView descendant class and register it for design-time use
' 
' This is an example of a custom GridView and a custom control that inherits the
' DevExpress.XtraGrid.GridControl. Make sure to build the project prior to opening
' Form1 in the designer. Please refer to the http://www.devexpress.com/scid=A859
' Knowledge Base article for the additional information.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E900


Imports Microsoft.VisualBasic
Imports System
Namespace MyXtraGrid
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.myGridControl1 = New MyXtraGrid.MyGridControl()
			Me.myGridView1 = New MyXtraGrid.MyGridView()
			Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
			Me.repositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
			Me.ordersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.northwindDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.northwindDataSet = New MyXtraGrid.NorthwindDataSet()
			Me.ordersTableAdapter = New MyXtraGrid.NorthwindDataSetTableAdapters.OrdersTableAdapter()
			Me.order_DetailsTableAdapter1 = New MyXtraGrid.NorthwindDataSetTableAdapters.Order_DetailsTableAdapter()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.myGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.northwindDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' myGridControl1
			' 
			Me.myGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.myGridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
			Me.myGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.myGridControl1.LookAndFeel.UseDefaultLookAndFeel = False
			Me.myGridControl1.MainView = Me.myGridView1
			Me.myGridControl1.Margin = New System.Windows.Forms.Padding(4)
			Me.myGridControl1.Name = "myGridControl1"
			Me.myGridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemComboBox1})
			Me.myGridControl1.Size = New System.Drawing.Size(1160, 577)
			Me.myGridControl1.TabIndex = 1
			Me.myGridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.myGridView1})
			' 
			' myGridView1
			' 
			Me.myGridView1.GridControl = Me.myGridControl1
			Me.myGridView1.Images = Me.imageCollection1
			Me.myGridView1.Name = "myGridView1"
			Me.myGridView1.OptionsView.ShowFooter = True
			' 
			' imageCollection1
			' 
			Me.imageCollection1.ImageStream = (CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.imageCollection1.InsertGalleryImage("add_16x16.png", "images/actions/add_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/add_16x16.png"), 0)
			Me.imageCollection1.Images.SetKeyName(0, "add_16x16.png")
			Me.imageCollection1.InsertGalleryImage("apply_16x16.png", "images/actions/apply_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_16x16.png"), 1)
			Me.imageCollection1.Images.SetKeyName(1, "apply_16x16.png")
			Me.imageCollection1.InsertGalleryImage("cancel_16x16.png", "images/actions/cancel_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_16x16.png"), 2)
			Me.imageCollection1.Images.SetKeyName(2, "cancel_16x16.png")
			' 
			' repositoryItemComboBox1
			' 
			Me.repositoryItemComboBox1.AutoHeight = False
			Me.repositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemComboBox1.Name = "repositoryItemComboBox1"
			' 
			' ordersBindingSource
			' 
			Me.ordersBindingSource.DataMember = "Orders"
			Me.ordersBindingSource.DataSource = Me.northwindDataSetBindingSource
			' 
			' northwindDataSetBindingSource
			' 
			Me.northwindDataSetBindingSource.DataSource = Me.northwindDataSet
			Me.northwindDataSetBindingSource.Position = 0
			' 
			' northwindDataSet
			' 
			Me.northwindDataSet.DataSetName = "NorthwindDataSet"
			Me.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' ordersTableAdapter
			' 
			Me.ordersTableAdapter.ClearBeforeFill = True
			' 
			' order_DetailsTableAdapter1
			' 
			Me.order_DetailsTableAdapter1.ClearBeforeFill = True
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(1017, 0)
			Me.simpleButton1.Margin = New System.Windows.Forms.Padding(4)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(130, 28)
			Me.simpleButton1.TabIndex = 2
			Me.simpleButton1.Text = "Show print preview"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1160, 577)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.myGridControl1)
			Me.Margin = New System.Windows.Forms.Padding(4)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.myGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.northwindDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private myGridControl1 As MyGridControl
		Private myGridView1 As MyGridView
		Private repositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
		Private northwindDataSetBindingSource As System.Windows.Forms.BindingSource
		Private northwindDataSet As NorthwindDataSet
		Private ordersBindingSource As System.Windows.Forms.BindingSource
		Private ordersTableAdapter As NorthwindDataSetTableAdapters.OrdersTableAdapter
		Private order_DetailsTableAdapter1 As NorthwindDataSetTableAdapters.Order_DetailsTableAdapter
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private imageCollection1 As DevExpress.Utils.ImageCollection
	End Class
End Namespace

