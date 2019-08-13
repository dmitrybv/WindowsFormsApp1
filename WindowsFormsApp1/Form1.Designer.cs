namespace WindowsFormsApp1
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.dataGridEh1 = new EhLib.WinForms.DataGridEh();
      this.allTypesTablesDataSet = new WindowsFormsApp1.AllTypesTablesDataSet();
      this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.employeesTableAdapter = new WindowsFormsApp1.AllTypesTablesDataSetTableAdapters.EmployeesTableAdapter();
      this.tableAdapterManager = new WindowsFormsApp1.AllTypesTablesDataSetTableAdapters.TableAdapterManager();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridEh1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.allTypesTablesDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridEh1
      // 
      this.dataGridEh1.AutoGenerateColumns = true;
      // 
      // 
      // 
      this.dataGridEh1.Border.BorderSides.Bottom.Color = System.Drawing.SystemColors.WindowFrame;
      this.dataGridEh1.Border.BorderSides.Left.Color = System.Drawing.SystemColors.WindowFrame;
      this.dataGridEh1.Border.BorderSides.Right.Color = System.Drawing.SystemColors.WindowFrame;
      this.dataGridEh1.Border.BorderSides.Top.Color = System.Drawing.SystemColors.WindowFrame;
      this.dataGridEh1.Border.Color = System.Drawing.SystemColors.WindowFrame;
      this.dataGridEh1.ColumnOptions.CacheDisplayValues = false;
      this.dataGridEh1.ColumnOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataGridEh1.ColumnOptions.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataGridEh1.ColumnOptions.SidePadding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.dataGridEh1.ColumnOptions.VertLine.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataGridEh1.ColumnOptions.VertLine.Style = System.Drawing.Drawing2D.DashStyle.Solid;
      this.dataGridEh1.ColumnOptions.VertLine.Visible = true;
      this.dataGridEh1.DataMember = "";
      this.dataGridEh1.DataSource = this.employeesBindingSource;
      // 
      // 
      // 
      this.dataGridEh1.EmptyDataInfo.BackColor = System.Drawing.SystemColors.Window;
      this.dataGridEh1.EmptyDataInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataGridEh1.EmptyDataInfo.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataGridEh1.EmptyDataInfo.FrameColor = System.Drawing.SystemColors.ButtonFace;
      this.dataGridEh1.EmptyDataInfo.Text = "<No Records>";
      this.dataGridEh1.FixedBackFiller.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataGridEh1.FixedBackFiller.FillStyle = EhLib.WinForms.CellFillStyle.VisualStyles;
      this.dataGridEh1.FixedBackFiller.InnerBorder = EhLib.WinForms.CellInnerBorderStyle.RaisedTopLeft;
      this.dataGridEh1.FixedBackFiller.SecondColor = System.Drawing.SystemColors.Window;
      // 
      // dataGridEh1.Footer
      // 
      this.dataGridEh1.Footer.BackFiller.Color = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
      this.dataGridEh1.Footer.BackFiller.FillStyle = EhLib.WinForms.CellFillStyle.Solid;
      this.dataGridEh1.Footer.BackFiller.InnerBorder = EhLib.WinForms.CellInnerBorderStyle.None;
      this.dataGridEh1.Footer.BackFiller.SecondColor = System.Drawing.SystemColors.Window;
      this.dataGridEh1.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataGridEh1.Footer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataGridEh1.Footer.HorzLine.Color = System.Drawing.Color.Gainsboro;
      this.dataGridEh1.Footer.HorzLine.Style = System.Drawing.Drawing2D.DashStyle.Solid;
      this.dataGridEh1.Footer.HorzLine.Visible = true;
      this.dataGridEh1.Footer.VertLine.Color = System.Drawing.Color.Gainsboro;
      this.dataGridEh1.Footer.VertLine.Style = System.Drawing.Drawing2D.DashStyle.Solid;
      this.dataGridEh1.Footer.VertLine.Visible = true;
      // 
      // dataGridEh1.IndicatorColumn
      // 
      this.dataGridEh1.IndicatorColumn.BackFiller.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataGridEh1.IndicatorColumn.BackFiller.FillStyle = EhLib.WinForms.CellFillStyle.VisualStyles;
      this.dataGridEh1.IndicatorColumn.BackFiller.InnerBorder = EhLib.WinForms.CellInnerBorderStyle.RaisedTopLeft;
      this.dataGridEh1.IndicatorColumn.BackFiller.SecondColor = System.Drawing.SystemColors.Window;
      this.dataGridEh1.IndicatorColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataGridEh1.IndicatorColumn.HorzLine.Color = System.Drawing.Color.Gainsboro;
      this.dataGridEh1.IndicatorColumn.HorzLine.Style = System.Drawing.Drawing2D.DashStyle.Solid;
      this.dataGridEh1.IndicatorColumn.HorzLine.Visible = true;
      this.dataGridEh1.IndicatorColumn.VertLine.Color = System.Drawing.Color.Gainsboro;
      this.dataGridEh1.IndicatorColumn.VertLine.Style = System.Drawing.Drawing2D.DashStyle.Solid;
      this.dataGridEh1.IndicatorColumn.VertLine.Visible = true;
      this.dataGridEh1.LineOptions.BrightColor = System.Drawing.SystemColors.ButtonFace;
      this.dataGridEh1.LineOptions.DarkColor = System.Drawing.Color.Gainsboro;
      this.dataGridEh1.LineOptions.DataBoundaryColor = System.Drawing.Color.Gainsboro;
      this.dataGridEh1.Location = new System.Drawing.Point(12, 21);
      this.dataGridEh1.Name = "dataGridEh1";
      this.dataGridEh1.RowOptions.EvenColor = System.Drawing.Color.Empty;
      this.dataGridEh1.RowOptions.HeightOptions.AutoExpand = false;
      this.dataGridEh1.RowOptions.HeightOptions.ContentHeight = 1;
      this.dataGridEh1.RowOptions.HeightOptions.MaxContentHeight = 0;
      this.dataGridEh1.RowOptions.HeightOptions.Unit = EhLib.WinForms.GridRowHeightUnit.TextLine;
      this.dataGridEh1.RowOptions.HorzLine.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataGridEh1.RowOptions.HorzLine.Style = System.Drawing.Drawing2D.DashStyle.Solid;
      this.dataGridEh1.RowOptions.HorzLine.Visible = true;
      this.dataGridEh1.RowOptions.OddColor = System.Drawing.Color.Empty;
      this.dataGridEh1.Size = new System.Drawing.Size(760, 399);
      this.dataGridEh1.TabIndex = 0;
      // 
      // dataGridEh1.Title
      // 
      this.dataGridEh1.Title.BackFiller.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataGridEh1.Title.BackFiller.FillStyle = EhLib.WinForms.CellFillStyle.VisualStyles;
      this.dataGridEh1.Title.BackFiller.InnerBorder = EhLib.WinForms.CellInnerBorderStyle.RaisedTopLeft;
      this.dataGridEh1.Title.BackFiller.SecondColor = System.Drawing.SystemColors.Window;
      this.dataGridEh1.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataGridEh1.Title.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataGridEh1.Title.HeightOptions.AutoExpand = false;
      this.dataGridEh1.Title.HeightOptions.ContentHeight = 1;
      this.dataGridEh1.Title.HeightOptions.MaxContentHeight = 0;
      this.dataGridEh1.Title.HeightOptions.Unit = EhLib.WinForms.GridRowHeightUnit.TextLine;
      this.dataGridEh1.Title.HorzLine.Color = System.Drawing.Color.Gainsboro;
      this.dataGridEh1.Title.HorzLine.Style = System.Drawing.Drawing2D.DashStyle.Solid;
      this.dataGridEh1.Title.HorzLine.Visible = true;
      this.dataGridEh1.Title.Padding = new System.Windows.Forms.Padding(3, 2, 3, 4);
      this.dataGridEh1.Title.SortMarking.SortMarkerStyle = EhLib.WinForms.SortMarkerStyle.Themed;
      this.dataGridEh1.Title.VertLine.Color = System.Drawing.Color.Gainsboro;
      this.dataGridEh1.Title.VertLine.Style = System.Drawing.Drawing2D.DashStyle.Solid;
      this.dataGridEh1.Title.VertLine.Visible = true;
      this.dataGridEh1.UseVisualStyles = true;
      // 
      // allTypesTablesDataSet
      // 
      this.allTypesTablesDataSet.DataSetName = "AllTypesTablesDataSet";
      this.allTypesTablesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // employeesBindingSource
      // 
      this.employeesBindingSource.DataMember = "Employees";
      this.employeesBindingSource.DataSource = this.allTypesTablesDataSet;
      // 
      // employeesTableAdapter
      // 
      this.employeesTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
      this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.AllTypesTablesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.dataGridEh1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridEh1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.allTypesTablesDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private EhLib.WinForms.DataGridEh dataGridEh1;
    private AllTypesTablesDataSet allTypesTablesDataSet;
    private System.Windows.Forms.BindingSource employeesBindingSource;
    private AllTypesTablesDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
    private AllTypesTablesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
  }
}

