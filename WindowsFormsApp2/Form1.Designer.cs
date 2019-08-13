namespace WindowsFormsApp2
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
      this.dataVertGridEh1 = new EhLib.WinForms.DataVertGridEh();
      this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.allTypesTablesDataSet = new WindowsFormsApp2.AllTypesTablesDataSet();
      this.employeesTableAdapter = new WindowsFormsApp2.AllTypesTablesDataSetTableAdapters.EmployeesTableAdapter();
      this.tableAdapterManager = new WindowsFormsApp2.AllTypesTablesDataSetTableAdapters.TableAdapterManager();
      this.dataVertGridEh1EmployeeIDRow = new EhLib.WinForms.DataVertGridTextRow();
      this.dataVertGridEh1LastNameRow = new EhLib.WinForms.DataVertGridTextRow();
      this.dataVertGridEh1FirstNameRow = new EhLib.WinForms.DataVertGridTextRow();
      this.dataVertGridEh1TitleRow = new EhLib.WinForms.DataVertGridTextRow();
      this.dataVertGridEh1TitleOfCourtesyRow = new EhLib.WinForms.DataVertGridTextRow();
      this.dataVertGridEh1BirthDateRow = new EhLib.WinForms.DataVertGridDateTimeRow();
      this.dataVertGridEh1HireDateRow = new EhLib.WinForms.DataVertGridDateTimeRow();
      this.dataVertGridEh1IncomeRow = new EhLib.WinForms.DataVertGridTextRow();
      this.dataVertGridEh1AddressRow = new EhLib.WinForms.DataVertGridTextRow();
      this.dataVertGridEh1CityRow = new EhLib.WinForms.DataVertGridTextRow();
      this.dataVertGridEh1RegionRow = new EhLib.WinForms.DataVertGridTextRow();
      this.dataVertGridEh1PostalCodeRow = new EhLib.WinForms.DataVertGridTextRow();
      this.dataVertGridEh1CountryRow = new EhLib.WinForms.DataVertGridTextRow();
      this.dataVertGridEh1HomePhoneRow = new EhLib.WinForms.DataVertGridTextRow();
      this.dataVertGridEh1ExtensionRow = new EhLib.WinForms.DataVertGridTextRow();
      this.dataVertGridEh1PhotoRow = new EhLib.WinForms.DataVertGridImageRow();
      this.dataVertGridEh1NotesRow = new EhLib.WinForms.DataVertGridTextRow();
      this.dataVertGridEh1ReportsToRow = new EhLib.WinForms.DataVertGridTextRow();
      this.dataVertGridEh1BooleanFieldRow = new EhLib.WinForms.DataVertGridCheckBoxRow();
      this.dataVertGridEh1Char1ForCheckBoxRow = new EhLib.WinForms.DataVertGridTextRow();
      this.dataVertGridEh1TimeFieldRow = new EhLib.WinForms.DataVertGridDateTimeRow();
      this.dataVertGridEh1TimeSecFieldRow = new EhLib.WinForms.DataVertGridDateTimeRow();
      this.dataVertGridEh1DateAsStringRow = new EhLib.WinForms.DataVertGridTextRow();
      ((System.ComponentModel.ISupportInitialize)(this.dataVertGridEh1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.allTypesTablesDataSet)).BeginInit();
      this.SuspendLayout();
      // 
      // dataVertGridEh1
      // 
      this.dataVertGridEh1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataVertGridEh1.AutoGenerateRows = true;
      // 
      // 
      // 
      this.dataVertGridEh1.Border.BorderSides.Bottom.Color = System.Drawing.SystemColors.WindowFrame;
      this.dataVertGridEh1.Border.BorderSides.Left.Color = System.Drawing.SystemColors.WindowFrame;
      this.dataVertGridEh1.Border.BorderSides.Right.Color = System.Drawing.SystemColors.WindowFrame;
      this.dataVertGridEh1.Border.BorderSides.Top.Color = System.Drawing.SystemColors.WindowFrame;
      this.dataVertGridEh1.Border.Color = System.Drawing.SystemColors.WindowFrame;
      this.dataVertGridEh1.DataMember = "";
      this.dataVertGridEh1.DataSource = this.employeesBindingSource;
      this.dataVertGridEh1.FixedBackFiller.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1.FixedBackFiller.FillStyle = EhLib.WinForms.CellFillStyle.VisualStyles;
      this.dataVertGridEh1.FixedBackFiller.InnerBorder = EhLib.WinForms.CellInnerBorderStyle.RaisedTopLeft;
      this.dataVertGridEh1.FixedBackFiller.SecondColor = System.Drawing.SystemColors.Window;
      // 
      // 
      // 
      this.dataVertGridEh1.IndicatorRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1.LineOptions.BrightColor = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1.LineOptions.DarkColor = System.Drawing.Color.Gainsboro;
      this.dataVertGridEh1.Location = new System.Drawing.Point(12, 26);
      this.dataVertGridEh1.Name = "dataVertGridEh1";
      this.dataVertGridEh1.RowOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1.RowOptions.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1.RowOptions.HeightOptions.AutoExpand = false;
      this.dataVertGridEh1.RowOptions.HeightOptions.ContentHeight = 1;
      this.dataVertGridEh1.RowOptions.HeightOptions.MaxContentHeight = 0;
      this.dataVertGridEh1.RowOptions.HeightOptions.Unit = EhLib.WinForms.GridRowHeightUnit.TextLine;
      this.dataVertGridEh1.RowOptions.HorzLine.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1.RowOptions.HorzLine.Style = System.Drawing.Drawing2D.DashStyle.Solid;
      this.dataVertGridEh1.RowOptions.HorzLine.Visible = true;
      this.dataVertGridEh1.RowOptions.SidePadding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.dataVertGridEh1.Size = new System.Drawing.Size(749, 454);
      this.dataVertGridEh1.StaticRows.AddRange(new EhLib.WinForms.PropertyAxisBar[] {
            this.dataVertGridEh1EmployeeIDRow,
            this.dataVertGridEh1LastNameRow,
            this.dataVertGridEh1FirstNameRow,
            this.dataVertGridEh1TitleRow,
            this.dataVertGridEh1TitleOfCourtesyRow,
            this.dataVertGridEh1BirthDateRow,
            this.dataVertGridEh1HireDateRow,
            this.dataVertGridEh1IncomeRow,
            this.dataVertGridEh1AddressRow,
            this.dataVertGridEh1CityRow,
            this.dataVertGridEh1RegionRow,
            this.dataVertGridEh1PostalCodeRow,
            this.dataVertGridEh1CountryRow,
            this.dataVertGridEh1HomePhoneRow,
            this.dataVertGridEh1ExtensionRow,
            this.dataVertGridEh1PhotoRow,
            this.dataVertGridEh1NotesRow,
            this.dataVertGridEh1ReportsToRow,
            this.dataVertGridEh1BooleanFieldRow,
            this.dataVertGridEh1Char1ForCheckBoxRow,
            this.dataVertGridEh1TimeFieldRow,
            this.dataVertGridEh1TimeSecFieldRow,
            this.dataVertGridEh1DateAsStringRow});
      this.dataVertGridEh1.TabIndex = 0;
      // 
      // 
      // 
      this.dataVertGridEh1.TitleColumn.BackFiller.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1.TitleColumn.BackFiller.FillStyle = EhLib.WinForms.CellFillStyle.VisualStyles;
      this.dataVertGridEh1.TitleColumn.BackFiller.InnerBorder = EhLib.WinForms.CellInnerBorderStyle.RaisedTopLeft;
      this.dataVertGridEh1.TitleColumn.BackFiller.SecondColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1.TitleColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1.TitleColumn.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1.TitleColumn.HorzLine.Color = System.Drawing.Color.Gainsboro;
      this.dataVertGridEh1.TitleColumn.HorzLine.Style = System.Drawing.Drawing2D.DashStyle.Solid;
      this.dataVertGridEh1.TitleColumn.HorzLine.Visible = true;
      this.dataVertGridEh1.TitleColumn.Padding = new System.Windows.Forms.Padding(2);
      this.dataVertGridEh1.TitleColumn.VertLine.Color = System.Drawing.Color.Gainsboro;
      this.dataVertGridEh1.TitleColumn.VertLine.Style = System.Drawing.Drawing2D.DashStyle.Solid;
      this.dataVertGridEh1.TitleColumn.VertLine.Visible = true;
      this.dataVertGridEh1.TitleColumn.Width = 164;
      this.dataVertGridEh1.UseVisualStyles = true;
      // 
      // employeesBindingSource
      // 
      this.employeesBindingSource.DataMember = "Employees";
      this.employeesBindingSource.DataSource = this.allTypesTablesDataSet;
      // 
      // allTypesTablesDataSet
      // 
      this.allTypesTablesDataSet.DataSetName = "AllTypesTablesDataSet";
      this.allTypesTablesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // employeesTableAdapter
      // 
      this.employeesTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
      this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.AllTypesTablesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // dataVertGridEh1EmployeeIDRow
      // 
      this.dataVertGridEh1EmployeeIDRow.AllowShowEditor = true;
      this.dataVertGridEh1EmployeeIDRow.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1EmployeeIDRow.DataPropertyName = "EmployeeID";
      this.dataVertGridEh1EmployeeIDRow.DataType = typeof(int);
      this.dataVertGridEh1EmployeeIDRow.ExternalCellManager = null;
      this.dataVertGridEh1EmployeeIDRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1EmployeeIDRow.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1EmployeeIDRow.HeightOptions.AutoExpand = false;
      this.dataVertGridEh1EmployeeIDRow.HeightOptions.ContentHeight = 1;
      this.dataVertGridEh1EmployeeIDRow.HeightOptions.MaxContentHeight = 0;
      this.dataVertGridEh1EmployeeIDRow.HeightOptions.Unit = EhLib.WinForms.GridRowHeightUnit.TextLine;
      this.dataVertGridEh1EmployeeIDRow.HorzAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // 
      // 
      this.dataVertGridEh1EmployeeIDRow.InternalCellManager.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1EmployeeIDRow.InternalCellManager.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1EmployeeIDRow.InternalCellManager.HorzAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.dataVertGridEh1EmployeeIDRow.Name = "dataVertGridEh1EmployeeIDRow";
      this.dataVertGridEh1EmployeeIDRow.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
      // 
      // 
      // 
      this.dataVertGridEh1EmployeeIDRow.Title.BackFiller.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1EmployeeIDRow.Title.BackFiller.FillStyle = EhLib.WinForms.CellFillStyle.VisualStyles;
      this.dataVertGridEh1EmployeeIDRow.Title.BackFiller.InnerBorder = EhLib.WinForms.CellInnerBorderStyle.RaisedTopLeft;
      this.dataVertGridEh1EmployeeIDRow.Title.BackFiller.SecondColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1EmployeeIDRow.Title.EndEllipsis = false;
      this.dataVertGridEh1EmployeeIDRow.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1EmployeeIDRow.Title.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1EmployeeIDRow.Title.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.dataVertGridEh1EmployeeIDRow.Title.Padding = new System.Windows.Forms.Padding(2);
      this.dataVertGridEh1EmployeeIDRow.Title.Text = "EmployeeID";
      this.dataVertGridEh1EmployeeIDRow.Title.VertAlign = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
      this.dataVertGridEh1EmployeeIDRow.VertLine.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1EmployeeIDRow.VertLine.Style = System.Drawing.Drawing2D.DashStyle.Solid;
      this.dataVertGridEh1EmployeeIDRow.VertLine.Visible = true;
      // 
      // dataVertGridEh1LastNameRow
      // 
      this.dataVertGridEh1LastNameRow.AllowShowEditor = true;
      this.dataVertGridEh1LastNameRow.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1LastNameRow.DataPropertyName = "LastName";
      this.dataVertGridEh1LastNameRow.DataType = typeof(string);
      this.dataVertGridEh1LastNameRow.ExternalCellManager = null;
      this.dataVertGridEh1LastNameRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1LastNameRow.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1LastNameRow.HeightOptions.AutoExpand = false;
      this.dataVertGridEh1LastNameRow.HeightOptions.ContentHeight = 1;
      this.dataVertGridEh1LastNameRow.HeightOptions.MaxContentHeight = 0;
      this.dataVertGridEh1LastNameRow.HeightOptions.Unit = EhLib.WinForms.GridRowHeightUnit.TextLine;
      this.dataVertGridEh1LastNameRow.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      // 
      // 
      // 
      this.dataVertGridEh1LastNameRow.InternalCellManager.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1LastNameRow.InternalCellManager.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1LastNameRow.Name = "dataVertGridEh1LastNameRow";
      this.dataVertGridEh1LastNameRow.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
      // 
      // 
      // 
      this.dataVertGridEh1LastNameRow.Title.BackFiller.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1LastNameRow.Title.BackFiller.FillStyle = EhLib.WinForms.CellFillStyle.VisualStyles;
      this.dataVertGridEh1LastNameRow.Title.BackFiller.InnerBorder = EhLib.WinForms.CellInnerBorderStyle.RaisedTopLeft;
      this.dataVertGridEh1LastNameRow.Title.BackFiller.SecondColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1LastNameRow.Title.EndEllipsis = false;
      this.dataVertGridEh1LastNameRow.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1LastNameRow.Title.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1LastNameRow.Title.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.dataVertGridEh1LastNameRow.Title.Padding = new System.Windows.Forms.Padding(2);
      this.dataVertGridEh1LastNameRow.Title.Text = "LastName";
      this.dataVertGridEh1LastNameRow.Title.VertAlign = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
      this.dataVertGridEh1LastNameRow.VertLine.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1LastNameRow.VertLine.Style = System.Drawing.Drawing2D.DashStyle.Solid;
      this.dataVertGridEh1LastNameRow.VertLine.Visible = true;
      // 
      // dataVertGridEh1FirstNameRow
      // 
      this.dataVertGridEh1FirstNameRow.AllowShowEditor = true;
      this.dataVertGridEh1FirstNameRow.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1FirstNameRow.DataPropertyName = "FirstName";
      this.dataVertGridEh1FirstNameRow.DataType = typeof(string);
      this.dataVertGridEh1FirstNameRow.ExternalCellManager = null;
      this.dataVertGridEh1FirstNameRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1FirstNameRow.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1FirstNameRow.HeightOptions.AutoExpand = false;
      this.dataVertGridEh1FirstNameRow.HeightOptions.ContentHeight = 1;
      this.dataVertGridEh1FirstNameRow.HeightOptions.MaxContentHeight = 0;
      this.dataVertGridEh1FirstNameRow.HeightOptions.Unit = EhLib.WinForms.GridRowHeightUnit.TextLine;
      this.dataVertGridEh1FirstNameRow.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      // 
      // 
      // 
      this.dataVertGridEh1FirstNameRow.InternalCellManager.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1FirstNameRow.InternalCellManager.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1FirstNameRow.Name = "dataVertGridEh1FirstNameRow";
      this.dataVertGridEh1FirstNameRow.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
      // 
      // 
      // 
      this.dataVertGridEh1FirstNameRow.Title.BackFiller.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1FirstNameRow.Title.BackFiller.FillStyle = EhLib.WinForms.CellFillStyle.VisualStyles;
      this.dataVertGridEh1FirstNameRow.Title.BackFiller.InnerBorder = EhLib.WinForms.CellInnerBorderStyle.RaisedTopLeft;
      this.dataVertGridEh1FirstNameRow.Title.BackFiller.SecondColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1FirstNameRow.Title.EndEllipsis = false;
      this.dataVertGridEh1FirstNameRow.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1FirstNameRow.Title.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1FirstNameRow.Title.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.dataVertGridEh1FirstNameRow.Title.Padding = new System.Windows.Forms.Padding(2);
      this.dataVertGridEh1FirstNameRow.Title.Text = "FirstName";
      this.dataVertGridEh1FirstNameRow.Title.VertAlign = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
      this.dataVertGridEh1FirstNameRow.VertLine.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1FirstNameRow.VertLine.Style = System.Drawing.Drawing2D.DashStyle.Solid;
      this.dataVertGridEh1FirstNameRow.VertLine.Visible = true;
      // 
      // dataVertGridEh1TitleRow
      // 
      this.dataVertGridEh1TitleRow.AllowShowEditor = true;
      this.dataVertGridEh1TitleRow.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1TitleRow.DataPropertyName = "Title";
      this.dataVertGridEh1TitleRow.DataType = typeof(string);
      this.dataVertGridEh1TitleRow.ExternalCellManager = null;
      this.dataVertGridEh1TitleRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1TitleRow.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1TitleRow.HeightOptions.AutoExpand = false;
      this.dataVertGridEh1TitleRow.HeightOptions.ContentHeight = 1;
      this.dataVertGridEh1TitleRow.HeightOptions.MaxContentHeight = 0;
      this.dataVertGridEh1TitleRow.HeightOptions.Unit = EhLib.WinForms.GridRowHeightUnit.TextLine;
      this.dataVertGridEh1TitleRow.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      // 
      // 
      // 
      this.dataVertGridEh1TitleRow.InternalCellManager.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1TitleRow.InternalCellManager.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1TitleRow.Name = "dataVertGridEh1TitleRow";
      this.dataVertGridEh1TitleRow.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
      // 
      // 
      // 
      this.dataVertGridEh1TitleRow.Title.BackFiller.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1TitleRow.Title.BackFiller.FillStyle = EhLib.WinForms.CellFillStyle.VisualStyles;
      this.dataVertGridEh1TitleRow.Title.BackFiller.InnerBorder = EhLib.WinForms.CellInnerBorderStyle.RaisedTopLeft;
      this.dataVertGridEh1TitleRow.Title.BackFiller.SecondColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1TitleRow.Title.EndEllipsis = false;
      this.dataVertGridEh1TitleRow.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1TitleRow.Title.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1TitleRow.Title.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.dataVertGridEh1TitleRow.Title.Padding = new System.Windows.Forms.Padding(2);
      this.dataVertGridEh1TitleRow.Title.Text = "Title";
      this.dataVertGridEh1TitleRow.Title.VertAlign = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
      this.dataVertGridEh1TitleRow.VertLine.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1TitleRow.VertLine.Style = System.Drawing.Drawing2D.DashStyle.Solid;
      this.dataVertGridEh1TitleRow.VertLine.Visible = true;
      // 
      // dataVertGridEh1TitleOfCourtesyRow
      // 
      this.dataVertGridEh1TitleOfCourtesyRow.AllowShowEditor = true;
      this.dataVertGridEh1TitleOfCourtesyRow.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1TitleOfCourtesyRow.DataPropertyName = "TitleOfCourtesy";
      this.dataVertGridEh1TitleOfCourtesyRow.DataType = typeof(string);
      this.dataVertGridEh1TitleOfCourtesyRow.ExternalCellManager = null;
      this.dataVertGridEh1TitleOfCourtesyRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1TitleOfCourtesyRow.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1TitleOfCourtesyRow.HeightOptions.AutoExpand = false;
      this.dataVertGridEh1TitleOfCourtesyRow.HeightOptions.ContentHeight = 1;
      this.dataVertGridEh1TitleOfCourtesyRow.HeightOptions.MaxContentHeight = 0;
      this.dataVertGridEh1TitleOfCourtesyRow.HeightOptions.Unit = EhLib.WinForms.GridRowHeightUnit.TextLine;
      this.dataVertGridEh1TitleOfCourtesyRow.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      // 
      // 
      // 
      this.dataVertGridEh1TitleOfCourtesyRow.InternalCellManager.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1TitleOfCourtesyRow.InternalCellManager.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1TitleOfCourtesyRow.Name = "dataVertGridEh1TitleOfCourtesyRow";
      this.dataVertGridEh1TitleOfCourtesyRow.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
      // 
      // 
      // 
      this.dataVertGridEh1TitleOfCourtesyRow.Title.BackFiller.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1TitleOfCourtesyRow.Title.BackFiller.FillStyle = EhLib.WinForms.CellFillStyle.VisualStyles;
      this.dataVertGridEh1TitleOfCourtesyRow.Title.BackFiller.InnerBorder = EhLib.WinForms.CellInnerBorderStyle.RaisedTopLeft;
      this.dataVertGridEh1TitleOfCourtesyRow.Title.BackFiller.SecondColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1TitleOfCourtesyRow.Title.EndEllipsis = false;
      this.dataVertGridEh1TitleOfCourtesyRow.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1TitleOfCourtesyRow.Title.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1TitleOfCourtesyRow.Title.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.dataVertGridEh1TitleOfCourtesyRow.Title.Padding = new System.Windows.Forms.Padding(2);
      this.dataVertGridEh1TitleOfCourtesyRow.Title.Text = "TitleOfCourtesy";
      this.dataVertGridEh1TitleOfCourtesyRow.Title.VertAlign = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
      this.dataVertGridEh1TitleOfCourtesyRow.VertLine.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1TitleOfCourtesyRow.VertLine.Style = System.Drawing.Drawing2D.DashStyle.Solid;
      this.dataVertGridEh1TitleOfCourtesyRow.VertLine.Visible = true;
      // 
      // dataVertGridEh1BirthDateRow
      // 
      this.dataVertGridEh1BirthDateRow.AllowShowEditor = true;
      this.dataVertGridEh1BirthDateRow.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1BirthDateRow.DataPropertyName = "BirthDate";
      this.dataVertGridEh1BirthDateRow.DataType = typeof(System.DateTime);
      this.dataVertGridEh1BirthDateRow.ExternalCellManager = null;
      this.dataVertGridEh1BirthDateRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1BirthDateRow.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1BirthDateRow.HeightOptions.AutoExpand = false;
      this.dataVertGridEh1BirthDateRow.HeightOptions.ContentHeight = 1;
      this.dataVertGridEh1BirthDateRow.HeightOptions.MaxContentHeight = 0;
      this.dataVertGridEh1BirthDateRow.HeightOptions.Unit = EhLib.WinForms.GridRowHeightUnit.TextLine;
      this.dataVertGridEh1BirthDateRow.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      // 
      // 
      // 
      this.dataVertGridEh1BirthDateRow.InternalCellManager.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1BirthDateRow.InternalCellManager.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1BirthDateRow.Name = "dataVertGridEh1BirthDateRow";
      this.dataVertGridEh1BirthDateRow.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
      // 
      // 
      // 
      this.dataVertGridEh1BirthDateRow.Title.BackFiller.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1BirthDateRow.Title.BackFiller.FillStyle = EhLib.WinForms.CellFillStyle.VisualStyles;
      this.dataVertGridEh1BirthDateRow.Title.BackFiller.InnerBorder = EhLib.WinForms.CellInnerBorderStyle.RaisedTopLeft;
      this.dataVertGridEh1BirthDateRow.Title.BackFiller.SecondColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1BirthDateRow.Title.EndEllipsis = false;
      this.dataVertGridEh1BirthDateRow.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1BirthDateRow.Title.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1BirthDateRow.Title.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.dataVertGridEh1BirthDateRow.Title.Padding = new System.Windows.Forms.Padding(2);
      this.dataVertGridEh1BirthDateRow.Title.Text = "BirthDate";
      this.dataVertGridEh1BirthDateRow.Title.VertAlign = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
      this.dataVertGridEh1BirthDateRow.VertLine.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1BirthDateRow.VertLine.Style = System.Drawing.Drawing2D.DashStyle.Solid;
      this.dataVertGridEh1BirthDateRow.VertLine.Visible = true;
      // 
      // dataVertGridEh1HireDateRow
      // 
      this.dataVertGridEh1HireDateRow.AllowShowEditor = true;
      this.dataVertGridEh1HireDateRow.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1HireDateRow.DataPropertyName = "HireDate";
      this.dataVertGridEh1HireDateRow.DataType = typeof(System.DateTime);
      this.dataVertGridEh1HireDateRow.ExternalCellManager = null;
      this.dataVertGridEh1HireDateRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1HireDateRow.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1HireDateRow.HeightOptions.AutoExpand = false;
      this.dataVertGridEh1HireDateRow.HeightOptions.ContentHeight = 1;
      this.dataVertGridEh1HireDateRow.HeightOptions.MaxContentHeight = 0;
      this.dataVertGridEh1HireDateRow.HeightOptions.Unit = EhLib.WinForms.GridRowHeightUnit.TextLine;
      this.dataVertGridEh1HireDateRow.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      // 
      // 
      // 
      this.dataVertGridEh1HireDateRow.InternalCellManager.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1HireDateRow.InternalCellManager.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1HireDateRow.Name = "dataVertGridEh1HireDateRow";
      this.dataVertGridEh1HireDateRow.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
      // 
      // 
      // 
      this.dataVertGridEh1HireDateRow.Title.BackFiller.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1HireDateRow.Title.BackFiller.FillStyle = EhLib.WinForms.CellFillStyle.VisualStyles;
      this.dataVertGridEh1HireDateRow.Title.BackFiller.InnerBorder = EhLib.WinForms.CellInnerBorderStyle.RaisedTopLeft;
      this.dataVertGridEh1HireDateRow.Title.BackFiller.SecondColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1HireDateRow.Title.EndEllipsis = false;
      this.dataVertGridEh1HireDateRow.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1HireDateRow.Title.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1HireDateRow.Title.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.dataVertGridEh1HireDateRow.Title.Padding = new System.Windows.Forms.Padding(2);
      this.dataVertGridEh1HireDateRow.Title.Text = "HireDate";
      this.dataVertGridEh1HireDateRow.Title.VertAlign = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
      this.dataVertGridEh1HireDateRow.VertLine.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1HireDateRow.VertLine.Style = System.Drawing.Drawing2D.DashStyle.Solid;
      this.dataVertGridEh1HireDateRow.VertLine.Visible = true;
      // 
      // dataVertGridEh1IncomeRow
      // 
      this.dataVertGridEh1IncomeRow.AllowShowEditor = true;
      this.dataVertGridEh1IncomeRow.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1IncomeRow.DataPropertyName = "Income";
      this.dataVertGridEh1IncomeRow.DataType = typeof(decimal);
      this.dataVertGridEh1IncomeRow.ExternalCellManager = null;
      this.dataVertGridEh1IncomeRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1IncomeRow.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1IncomeRow.HeightOptions.AutoExpand = false;
      this.dataVertGridEh1IncomeRow.HeightOptions.ContentHeight = 1;
      this.dataVertGridEh1IncomeRow.HeightOptions.MaxContentHeight = 0;
      this.dataVertGridEh1IncomeRow.HeightOptions.Unit = EhLib.WinForms.GridRowHeightUnit.TextLine;
      this.dataVertGridEh1IncomeRow.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      // 
      // 
      // 
      this.dataVertGridEh1IncomeRow.InternalCellManager.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1IncomeRow.InternalCellManager.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1IncomeRow.Name = "dataVertGridEh1IncomeRow";
      this.dataVertGridEh1IncomeRow.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
      // 
      // 
      // 
      this.dataVertGridEh1IncomeRow.Title.BackFiller.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1IncomeRow.Title.BackFiller.FillStyle = EhLib.WinForms.CellFillStyle.VisualStyles;
      this.dataVertGridEh1IncomeRow.Title.BackFiller.InnerBorder = EhLib.WinForms.CellInnerBorderStyle.RaisedTopLeft;
      this.dataVertGridEh1IncomeRow.Title.BackFiller.SecondColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1IncomeRow.Title.EndEllipsis = false;
      this.dataVertGridEh1IncomeRow.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1IncomeRow.Title.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1IncomeRow.Title.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.dataVertGridEh1IncomeRow.Title.Padding = new System.Windows.Forms.Padding(2);
      this.dataVertGridEh1IncomeRow.Title.Text = "Income";
      this.dataVertGridEh1IncomeRow.Title.VertAlign = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
      this.dataVertGridEh1IncomeRow.VertLine.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1IncomeRow.VertLine.Style = System.Drawing.Drawing2D.DashStyle.Solid;
      this.dataVertGridEh1IncomeRow.VertLine.Visible = true;
      // 
      // dataVertGridEh1AddressRow
      // 
      this.dataVertGridEh1AddressRow.AllowShowEditor = true;
      this.dataVertGridEh1AddressRow.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1AddressRow.DataPropertyName = "Address";
      this.dataVertGridEh1AddressRow.DataType = typeof(string);
      this.dataVertGridEh1AddressRow.ExternalCellManager = null;
      this.dataVertGridEh1AddressRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1AddressRow.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1AddressRow.HeightOptions.AutoExpand = false;
      this.dataVertGridEh1AddressRow.HeightOptions.ContentHeight = 1;
      this.dataVertGridEh1AddressRow.HeightOptions.MaxContentHeight = 0;
      this.dataVertGridEh1AddressRow.HeightOptions.Unit = EhLib.WinForms.GridRowHeightUnit.TextLine;
      this.dataVertGridEh1AddressRow.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      // 
      // 
      // 
      this.dataVertGridEh1AddressRow.InternalCellManager.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1AddressRow.InternalCellManager.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1AddressRow.Name = "dataVertGridEh1AddressRow";
      this.dataVertGridEh1AddressRow.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
      // 
      // 
      // 
      this.dataVertGridEh1AddressRow.Title.BackFiller.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1AddressRow.Title.BackFiller.FillStyle = EhLib.WinForms.CellFillStyle.VisualStyles;
      this.dataVertGridEh1AddressRow.Title.BackFiller.InnerBorder = EhLib.WinForms.CellInnerBorderStyle.RaisedTopLeft;
      this.dataVertGridEh1AddressRow.Title.BackFiller.SecondColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1AddressRow.Title.EndEllipsis = false;
      this.dataVertGridEh1AddressRow.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1AddressRow.Title.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1AddressRow.Title.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.dataVertGridEh1AddressRow.Title.Padding = new System.Windows.Forms.Padding(2);
      this.dataVertGridEh1AddressRow.Title.Text = "Address";
      this.dataVertGridEh1AddressRow.Title.VertAlign = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
      this.dataVertGridEh1AddressRow.VertLine.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1AddressRow.VertLine.Style = System.Drawing.Drawing2D.DashStyle.Solid;
      this.dataVertGridEh1AddressRow.VertLine.Visible = true;
      // 
      // dataVertGridEh1CityRow
      // 
      this.dataVertGridEh1CityRow.AllowShowEditor = true;
      this.dataVertGridEh1CityRow.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1CityRow.DataPropertyName = "City";
      this.dataVertGridEh1CityRow.DataType = typeof(string);
      this.dataVertGridEh1CityRow.ExternalCellManager = null;
      this.dataVertGridEh1CityRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1CityRow.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1CityRow.HeightOptions.AutoExpand = false;
      this.dataVertGridEh1CityRow.HeightOptions.ContentHeight = 1;
      this.dataVertGridEh1CityRow.HeightOptions.MaxContentHeight = 0;
      this.dataVertGridEh1CityRow.HeightOptions.Unit = EhLib.WinForms.GridRowHeightUnit.TextLine;
      this.dataVertGridEh1CityRow.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      // 
      // 
      // 
      this.dataVertGridEh1CityRow.InternalCellManager.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1CityRow.InternalCellManager.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1CityRow.Name = "dataVertGridEh1CityRow";
      this.dataVertGridEh1CityRow.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
      // 
      // 
      // 
      this.dataVertGridEh1CityRow.Title.BackFiller.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1CityRow.Title.BackFiller.FillStyle = EhLib.WinForms.CellFillStyle.VisualStyles;
      this.dataVertGridEh1CityRow.Title.BackFiller.InnerBorder = EhLib.WinForms.CellInnerBorderStyle.RaisedTopLeft;
      this.dataVertGridEh1CityRow.Title.BackFiller.SecondColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1CityRow.Title.EndEllipsis = false;
      this.dataVertGridEh1CityRow.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1CityRow.Title.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1CityRow.Title.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.dataVertGridEh1CityRow.Title.Padding = new System.Windows.Forms.Padding(2);
      this.dataVertGridEh1CityRow.Title.Text = "City";
      this.dataVertGridEh1CityRow.Title.VertAlign = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
      this.dataVertGridEh1CityRow.VertLine.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1CityRow.VertLine.Style = System.Drawing.Drawing2D.DashStyle.Solid;
      this.dataVertGridEh1CityRow.VertLine.Visible = true;
      // 
      // dataVertGridEh1RegionRow
      // 
      this.dataVertGridEh1RegionRow.AllowShowEditor = true;
      this.dataVertGridEh1RegionRow.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1RegionRow.DataPropertyName = "Region";
      this.dataVertGridEh1RegionRow.DataType = typeof(string);
      this.dataVertGridEh1RegionRow.ExternalCellManager = null;
      this.dataVertGridEh1RegionRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1RegionRow.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1RegionRow.HeightOptions.AutoExpand = false;
      this.dataVertGridEh1RegionRow.HeightOptions.ContentHeight = 1;
      this.dataVertGridEh1RegionRow.HeightOptions.MaxContentHeight = 0;
      this.dataVertGridEh1RegionRow.HeightOptions.Unit = EhLib.WinForms.GridRowHeightUnit.TextLine;
      this.dataVertGridEh1RegionRow.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      // 
      // 
      // 
      this.dataVertGridEh1RegionRow.InternalCellManager.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1RegionRow.InternalCellManager.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1RegionRow.Name = "dataVertGridEh1RegionRow";
      this.dataVertGridEh1RegionRow.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
      // 
      // 
      // 
      this.dataVertGridEh1RegionRow.Title.BackFiller.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1RegionRow.Title.BackFiller.FillStyle = EhLib.WinForms.CellFillStyle.VisualStyles;
      this.dataVertGridEh1RegionRow.Title.BackFiller.InnerBorder = EhLib.WinForms.CellInnerBorderStyle.RaisedTopLeft;
      this.dataVertGridEh1RegionRow.Title.BackFiller.SecondColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1RegionRow.Title.EndEllipsis = false;
      this.dataVertGridEh1RegionRow.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1RegionRow.Title.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1RegionRow.Title.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.dataVertGridEh1RegionRow.Title.Padding = new System.Windows.Forms.Padding(2);
      this.dataVertGridEh1RegionRow.Title.Text = "Region";
      this.dataVertGridEh1RegionRow.Title.VertAlign = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
      this.dataVertGridEh1RegionRow.VertLine.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1RegionRow.VertLine.Style = System.Drawing.Drawing2D.DashStyle.Solid;
      this.dataVertGridEh1RegionRow.VertLine.Visible = true;
      // 
      // dataVertGridEh1PostalCodeRow
      // 
      this.dataVertGridEh1PostalCodeRow.AllowShowEditor = true;
      this.dataVertGridEh1PostalCodeRow.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1PostalCodeRow.DataPropertyName = "PostalCode";
      this.dataVertGridEh1PostalCodeRow.DataType = typeof(string);
      this.dataVertGridEh1PostalCodeRow.ExternalCellManager = null;
      this.dataVertGridEh1PostalCodeRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1PostalCodeRow.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1PostalCodeRow.HeightOptions.AutoExpand = false;
      this.dataVertGridEh1PostalCodeRow.HeightOptions.ContentHeight = 1;
      this.dataVertGridEh1PostalCodeRow.HeightOptions.MaxContentHeight = 0;
      this.dataVertGridEh1PostalCodeRow.HeightOptions.Unit = EhLib.WinForms.GridRowHeightUnit.TextLine;
      this.dataVertGridEh1PostalCodeRow.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      // 
      // 
      // 
      this.dataVertGridEh1PostalCodeRow.InternalCellManager.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1PostalCodeRow.InternalCellManager.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1PostalCodeRow.Name = "dataVertGridEh1PostalCodeRow";
      this.dataVertGridEh1PostalCodeRow.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
      // 
      // 
      // 
      this.dataVertGridEh1PostalCodeRow.Title.BackFiller.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1PostalCodeRow.Title.BackFiller.FillStyle = EhLib.WinForms.CellFillStyle.VisualStyles;
      this.dataVertGridEh1PostalCodeRow.Title.BackFiller.InnerBorder = EhLib.WinForms.CellInnerBorderStyle.RaisedTopLeft;
      this.dataVertGridEh1PostalCodeRow.Title.BackFiller.SecondColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1PostalCodeRow.Title.EndEllipsis = false;
      this.dataVertGridEh1PostalCodeRow.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1PostalCodeRow.Title.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1PostalCodeRow.Title.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.dataVertGridEh1PostalCodeRow.Title.Padding = new System.Windows.Forms.Padding(2);
      this.dataVertGridEh1PostalCodeRow.Title.Text = "PostalCode";
      this.dataVertGridEh1PostalCodeRow.Title.VertAlign = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
      this.dataVertGridEh1PostalCodeRow.VertLine.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1PostalCodeRow.VertLine.Style = System.Drawing.Drawing2D.DashStyle.Solid;
      this.dataVertGridEh1PostalCodeRow.VertLine.Visible = true;
      // 
      // dataVertGridEh1CountryRow
      // 
      this.dataVertGridEh1CountryRow.AllowShowEditor = true;
      this.dataVertGridEh1CountryRow.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1CountryRow.DataPropertyName = "Country";
      this.dataVertGridEh1CountryRow.DataType = typeof(string);
      this.dataVertGridEh1CountryRow.ExternalCellManager = null;
      this.dataVertGridEh1CountryRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1CountryRow.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1CountryRow.HeightOptions.AutoExpand = false;
      this.dataVertGridEh1CountryRow.HeightOptions.ContentHeight = 1;
      this.dataVertGridEh1CountryRow.HeightOptions.MaxContentHeight = 0;
      this.dataVertGridEh1CountryRow.HeightOptions.Unit = EhLib.WinForms.GridRowHeightUnit.TextLine;
      this.dataVertGridEh1CountryRow.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      // 
      // 
      // 
      this.dataVertGridEh1CountryRow.InternalCellManager.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1CountryRow.InternalCellManager.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1CountryRow.Name = "dataVertGridEh1CountryRow";
      this.dataVertGridEh1CountryRow.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
      // 
      // 
      // 
      this.dataVertGridEh1CountryRow.Title.BackFiller.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1CountryRow.Title.BackFiller.FillStyle = EhLib.WinForms.CellFillStyle.VisualStyles;
      this.dataVertGridEh1CountryRow.Title.BackFiller.InnerBorder = EhLib.WinForms.CellInnerBorderStyle.RaisedTopLeft;
      this.dataVertGridEh1CountryRow.Title.BackFiller.SecondColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1CountryRow.Title.EndEllipsis = false;
      this.dataVertGridEh1CountryRow.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1CountryRow.Title.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1CountryRow.Title.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.dataVertGridEh1CountryRow.Title.Padding = new System.Windows.Forms.Padding(2);
      this.dataVertGridEh1CountryRow.Title.Text = "Country";
      this.dataVertGridEh1CountryRow.Title.VertAlign = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
      this.dataVertGridEh1CountryRow.VertLine.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1CountryRow.VertLine.Style = System.Drawing.Drawing2D.DashStyle.Solid;
      this.dataVertGridEh1CountryRow.VertLine.Visible = true;
      // 
      // dataVertGridEh1HomePhoneRow
      // 
      this.dataVertGridEh1HomePhoneRow.AllowShowEditor = true;
      this.dataVertGridEh1HomePhoneRow.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1HomePhoneRow.DataPropertyName = "HomePhone";
      this.dataVertGridEh1HomePhoneRow.DataType = typeof(string);
      this.dataVertGridEh1HomePhoneRow.ExternalCellManager = null;
      this.dataVertGridEh1HomePhoneRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1HomePhoneRow.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1HomePhoneRow.HeightOptions.AutoExpand = false;
      this.dataVertGridEh1HomePhoneRow.HeightOptions.ContentHeight = 1;
      this.dataVertGridEh1HomePhoneRow.HeightOptions.MaxContentHeight = 0;
      this.dataVertGridEh1HomePhoneRow.HeightOptions.Unit = EhLib.WinForms.GridRowHeightUnit.TextLine;
      this.dataVertGridEh1HomePhoneRow.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      // 
      // 
      // 
      this.dataVertGridEh1HomePhoneRow.InternalCellManager.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1HomePhoneRow.InternalCellManager.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1HomePhoneRow.Name = "dataVertGridEh1HomePhoneRow";
      this.dataVertGridEh1HomePhoneRow.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
      // 
      // 
      // 
      this.dataVertGridEh1HomePhoneRow.Title.BackFiller.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1HomePhoneRow.Title.BackFiller.FillStyle = EhLib.WinForms.CellFillStyle.VisualStyles;
      this.dataVertGridEh1HomePhoneRow.Title.BackFiller.InnerBorder = EhLib.WinForms.CellInnerBorderStyle.RaisedTopLeft;
      this.dataVertGridEh1HomePhoneRow.Title.BackFiller.SecondColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1HomePhoneRow.Title.EndEllipsis = false;
      this.dataVertGridEh1HomePhoneRow.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1HomePhoneRow.Title.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1HomePhoneRow.Title.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.dataVertGridEh1HomePhoneRow.Title.Padding = new System.Windows.Forms.Padding(2);
      this.dataVertGridEh1HomePhoneRow.Title.Text = "HomePhone";
      this.dataVertGridEh1HomePhoneRow.Title.VertAlign = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
      this.dataVertGridEh1HomePhoneRow.VertLine.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1HomePhoneRow.VertLine.Style = System.Drawing.Drawing2D.DashStyle.Solid;
      this.dataVertGridEh1HomePhoneRow.VertLine.Visible = true;
      // 
      // dataVertGridEh1ExtensionRow
      // 
      this.dataVertGridEh1ExtensionRow.AllowShowEditor = true;
      this.dataVertGridEh1ExtensionRow.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1ExtensionRow.DataPropertyName = "Extension";
      this.dataVertGridEh1ExtensionRow.DataType = typeof(string);
      this.dataVertGridEh1ExtensionRow.ExternalCellManager = null;
      this.dataVertGridEh1ExtensionRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1ExtensionRow.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1ExtensionRow.HeightOptions.AutoExpand = false;
      this.dataVertGridEh1ExtensionRow.HeightOptions.ContentHeight = 1;
      this.dataVertGridEh1ExtensionRow.HeightOptions.MaxContentHeight = 0;
      this.dataVertGridEh1ExtensionRow.HeightOptions.Unit = EhLib.WinForms.GridRowHeightUnit.TextLine;
      this.dataVertGridEh1ExtensionRow.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      // 
      // 
      // 
      this.dataVertGridEh1ExtensionRow.InternalCellManager.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1ExtensionRow.InternalCellManager.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1ExtensionRow.Name = "dataVertGridEh1ExtensionRow";
      this.dataVertGridEh1ExtensionRow.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
      // 
      // 
      // 
      this.dataVertGridEh1ExtensionRow.Title.BackFiller.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1ExtensionRow.Title.BackFiller.FillStyle = EhLib.WinForms.CellFillStyle.VisualStyles;
      this.dataVertGridEh1ExtensionRow.Title.BackFiller.InnerBorder = EhLib.WinForms.CellInnerBorderStyle.RaisedTopLeft;
      this.dataVertGridEh1ExtensionRow.Title.BackFiller.SecondColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1ExtensionRow.Title.EndEllipsis = false;
      this.dataVertGridEh1ExtensionRow.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1ExtensionRow.Title.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1ExtensionRow.Title.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.dataVertGridEh1ExtensionRow.Title.Padding = new System.Windows.Forms.Padding(2);
      this.dataVertGridEh1ExtensionRow.Title.Text = "Extension";
      this.dataVertGridEh1ExtensionRow.Title.VertAlign = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
      this.dataVertGridEh1ExtensionRow.VertLine.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1ExtensionRow.VertLine.Style = System.Drawing.Drawing2D.DashStyle.Solid;
      this.dataVertGridEh1ExtensionRow.VertLine.Visible = true;
      // 
      // dataVertGridEh1PhotoRow
      // 
      this.dataVertGridEh1PhotoRow.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1PhotoRow.DataPropertyName = "Photo";
      this.dataVertGridEh1PhotoRow.DataType = typeof(byte[]);
      this.dataVertGridEh1PhotoRow.ExternalCellManager = null;
      this.dataVertGridEh1PhotoRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1PhotoRow.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1PhotoRow.HeightOptions.AutoExpand = false;
      this.dataVertGridEh1PhotoRow.HeightOptions.ContentHeight = 5;
      this.dataVertGridEh1PhotoRow.HeightOptions.MaxContentHeight = 0;
      this.dataVertGridEh1PhotoRow.HeightOptions.Unit = EhLib.WinForms.GridRowHeightUnit.TextLine;
      this.dataVertGridEh1PhotoRow.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      // 
      // 
      // 
      this.dataVertGridEh1PhotoRow.InternalCellManager.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1PhotoRow.InternalCellManager.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1PhotoRow.Name = "dataVertGridEh1PhotoRow";
      this.dataVertGridEh1PhotoRow.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
      // 
      // 
      // 
      this.dataVertGridEh1PhotoRow.Title.BackFiller.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1PhotoRow.Title.BackFiller.FillStyle = EhLib.WinForms.CellFillStyle.VisualStyles;
      this.dataVertGridEh1PhotoRow.Title.BackFiller.InnerBorder = EhLib.WinForms.CellInnerBorderStyle.RaisedTopLeft;
      this.dataVertGridEh1PhotoRow.Title.BackFiller.SecondColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1PhotoRow.Title.EndEllipsis = false;
      this.dataVertGridEh1PhotoRow.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1PhotoRow.Title.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1PhotoRow.Title.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.dataVertGridEh1PhotoRow.Title.Padding = new System.Windows.Forms.Padding(2);
      this.dataVertGridEh1PhotoRow.Title.Text = "Photo";
      this.dataVertGridEh1PhotoRow.Title.VertAlign = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
      this.dataVertGridEh1PhotoRow.VertLine.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1PhotoRow.VertLine.Style = System.Drawing.Drawing2D.DashStyle.Solid;
      this.dataVertGridEh1PhotoRow.VertLine.Visible = true;
      // 
      // dataVertGridEh1NotesRow
      // 
      this.dataVertGridEh1NotesRow.AllowShowEditor = true;
      this.dataVertGridEh1NotesRow.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1NotesRow.DataPropertyName = "Notes";
      this.dataVertGridEh1NotesRow.DataType = typeof(string);
      this.dataVertGridEh1NotesRow.ExternalCellManager = null;
      this.dataVertGridEh1NotesRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1NotesRow.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1NotesRow.HeightOptions.AutoExpand = false;
      this.dataVertGridEh1NotesRow.HeightOptions.ContentHeight = 1;
      this.dataVertGridEh1NotesRow.HeightOptions.MaxContentHeight = 0;
      this.dataVertGridEh1NotesRow.HeightOptions.Unit = EhLib.WinForms.GridRowHeightUnit.TextLine;
      this.dataVertGridEh1NotesRow.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      // 
      // 
      // 
      this.dataVertGridEh1NotesRow.InternalCellManager.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1NotesRow.InternalCellManager.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1NotesRow.Name = "dataVertGridEh1NotesRow";
      this.dataVertGridEh1NotesRow.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
      // 
      // 
      // 
      this.dataVertGridEh1NotesRow.Title.BackFiller.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1NotesRow.Title.BackFiller.FillStyle = EhLib.WinForms.CellFillStyle.VisualStyles;
      this.dataVertGridEh1NotesRow.Title.BackFiller.InnerBorder = EhLib.WinForms.CellInnerBorderStyle.RaisedTopLeft;
      this.dataVertGridEh1NotesRow.Title.BackFiller.SecondColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1NotesRow.Title.EndEllipsis = false;
      this.dataVertGridEh1NotesRow.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1NotesRow.Title.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1NotesRow.Title.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.dataVertGridEh1NotesRow.Title.Padding = new System.Windows.Forms.Padding(2);
      this.dataVertGridEh1NotesRow.Title.Text = "Notes";
      this.dataVertGridEh1NotesRow.Title.VertAlign = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
      this.dataVertGridEh1NotesRow.VertLine.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1NotesRow.VertLine.Style = System.Drawing.Drawing2D.DashStyle.Solid;
      this.dataVertGridEh1NotesRow.VertLine.Visible = true;
      // 
      // dataVertGridEh1ReportsToRow
      // 
      this.dataVertGridEh1ReportsToRow.AllowShowEditor = true;
      this.dataVertGridEh1ReportsToRow.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1ReportsToRow.DataPropertyName = "ReportsTo";
      this.dataVertGridEh1ReportsToRow.DataType = typeof(int);
      this.dataVertGridEh1ReportsToRow.ExternalCellManager = null;
      this.dataVertGridEh1ReportsToRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1ReportsToRow.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1ReportsToRow.HeightOptions.AutoExpand = false;
      this.dataVertGridEh1ReportsToRow.HeightOptions.ContentHeight = 1;
      this.dataVertGridEh1ReportsToRow.HeightOptions.MaxContentHeight = 0;
      this.dataVertGridEh1ReportsToRow.HeightOptions.Unit = EhLib.WinForms.GridRowHeightUnit.TextLine;
      this.dataVertGridEh1ReportsToRow.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      // 
      // 
      // 
      this.dataVertGridEh1ReportsToRow.InternalCellManager.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1ReportsToRow.InternalCellManager.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1ReportsToRow.Name = "dataVertGridEh1ReportsToRow";
      this.dataVertGridEh1ReportsToRow.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
      // 
      // 
      // 
      this.dataVertGridEh1ReportsToRow.Title.BackFiller.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1ReportsToRow.Title.BackFiller.FillStyle = EhLib.WinForms.CellFillStyle.VisualStyles;
      this.dataVertGridEh1ReportsToRow.Title.BackFiller.InnerBorder = EhLib.WinForms.CellInnerBorderStyle.RaisedTopLeft;
      this.dataVertGridEh1ReportsToRow.Title.BackFiller.SecondColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1ReportsToRow.Title.EndEllipsis = false;
      this.dataVertGridEh1ReportsToRow.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1ReportsToRow.Title.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1ReportsToRow.Title.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.dataVertGridEh1ReportsToRow.Title.Padding = new System.Windows.Forms.Padding(2);
      this.dataVertGridEh1ReportsToRow.Title.Text = "ReportsTo";
      this.dataVertGridEh1ReportsToRow.Title.VertAlign = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
      this.dataVertGridEh1ReportsToRow.VertLine.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1ReportsToRow.VertLine.Style = System.Drawing.Drawing2D.DashStyle.Solid;
      this.dataVertGridEh1ReportsToRow.VertLine.Visible = true;
      // 
      // dataVertGridEh1BooleanFieldRow
      // 
      this.dataVertGridEh1BooleanFieldRow.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1BooleanFieldRow.DataPropertyName = "BooleanField";
      this.dataVertGridEh1BooleanFieldRow.DataType = typeof(bool);
      this.dataVertGridEh1BooleanFieldRow.ExternalCellManager = null;
      this.dataVertGridEh1BooleanFieldRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1BooleanFieldRow.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1BooleanFieldRow.HeightOptions.AutoExpand = false;
      this.dataVertGridEh1BooleanFieldRow.HeightOptions.ContentHeight = 1;
      this.dataVertGridEh1BooleanFieldRow.HeightOptions.MaxContentHeight = 0;
      this.dataVertGridEh1BooleanFieldRow.HeightOptions.Unit = EhLib.WinForms.GridRowHeightUnit.TextLine;
      this.dataVertGridEh1BooleanFieldRow.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      // 
      // 
      // 
      this.dataVertGridEh1BooleanFieldRow.InternalCellManager.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1BooleanFieldRow.InternalCellManager.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1BooleanFieldRow.Name = "dataVertGridEh1BooleanFieldRow";
      this.dataVertGridEh1BooleanFieldRow.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
      // 
      // 
      // 
      this.dataVertGridEh1BooleanFieldRow.Title.BackFiller.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1BooleanFieldRow.Title.BackFiller.FillStyle = EhLib.WinForms.CellFillStyle.VisualStyles;
      this.dataVertGridEh1BooleanFieldRow.Title.BackFiller.InnerBorder = EhLib.WinForms.CellInnerBorderStyle.RaisedTopLeft;
      this.dataVertGridEh1BooleanFieldRow.Title.BackFiller.SecondColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1BooleanFieldRow.Title.EndEllipsis = false;
      this.dataVertGridEh1BooleanFieldRow.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1BooleanFieldRow.Title.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1BooleanFieldRow.Title.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.dataVertGridEh1BooleanFieldRow.Title.Padding = new System.Windows.Forms.Padding(2);
      this.dataVertGridEh1BooleanFieldRow.Title.Text = "BooleanField";
      this.dataVertGridEh1BooleanFieldRow.Title.VertAlign = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
      this.dataVertGridEh1BooleanFieldRow.VertLine.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1BooleanFieldRow.VertLine.Style = System.Drawing.Drawing2D.DashStyle.Solid;
      this.dataVertGridEh1BooleanFieldRow.VertLine.Visible = true;
      // 
      // dataVertGridEh1Char1ForCheckBoxRow
      // 
      this.dataVertGridEh1Char1ForCheckBoxRow.AllowShowEditor = true;
      this.dataVertGridEh1Char1ForCheckBoxRow.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1Char1ForCheckBoxRow.DataPropertyName = "Char1ForCheckBox";
      this.dataVertGridEh1Char1ForCheckBoxRow.DataType = typeof(string);
      this.dataVertGridEh1Char1ForCheckBoxRow.ExternalCellManager = null;
      this.dataVertGridEh1Char1ForCheckBoxRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1Char1ForCheckBoxRow.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1Char1ForCheckBoxRow.HeightOptions.AutoExpand = false;
      this.dataVertGridEh1Char1ForCheckBoxRow.HeightOptions.ContentHeight = 1;
      this.dataVertGridEh1Char1ForCheckBoxRow.HeightOptions.MaxContentHeight = 0;
      this.dataVertGridEh1Char1ForCheckBoxRow.HeightOptions.Unit = EhLib.WinForms.GridRowHeightUnit.TextLine;
      this.dataVertGridEh1Char1ForCheckBoxRow.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      // 
      // 
      // 
      this.dataVertGridEh1Char1ForCheckBoxRow.InternalCellManager.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1Char1ForCheckBoxRow.InternalCellManager.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1Char1ForCheckBoxRow.Name = "dataVertGridEh1Char1ForCheckBoxRow";
      this.dataVertGridEh1Char1ForCheckBoxRow.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
      // 
      // 
      // 
      this.dataVertGridEh1Char1ForCheckBoxRow.Title.BackFiller.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1Char1ForCheckBoxRow.Title.BackFiller.FillStyle = EhLib.WinForms.CellFillStyle.VisualStyles;
      this.dataVertGridEh1Char1ForCheckBoxRow.Title.BackFiller.InnerBorder = EhLib.WinForms.CellInnerBorderStyle.RaisedTopLeft;
      this.dataVertGridEh1Char1ForCheckBoxRow.Title.BackFiller.SecondColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1Char1ForCheckBoxRow.Title.EndEllipsis = false;
      this.dataVertGridEh1Char1ForCheckBoxRow.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1Char1ForCheckBoxRow.Title.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1Char1ForCheckBoxRow.Title.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.dataVertGridEh1Char1ForCheckBoxRow.Title.Padding = new System.Windows.Forms.Padding(2);
      this.dataVertGridEh1Char1ForCheckBoxRow.Title.Text = "Char1ForCheckBox";
      this.dataVertGridEh1Char1ForCheckBoxRow.Title.VertAlign = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
      this.dataVertGridEh1Char1ForCheckBoxRow.VertLine.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1Char1ForCheckBoxRow.VertLine.Style = System.Drawing.Drawing2D.DashStyle.Solid;
      this.dataVertGridEh1Char1ForCheckBoxRow.VertLine.Visible = true;
      // 
      // dataVertGridEh1TimeFieldRow
      // 
      this.dataVertGridEh1TimeFieldRow.AllowShowEditor = true;
      this.dataVertGridEh1TimeFieldRow.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1TimeFieldRow.DataPropertyName = "TimeField";
      this.dataVertGridEh1TimeFieldRow.DataType = typeof(System.DateTime);
      this.dataVertGridEh1TimeFieldRow.ExternalCellManager = null;
      this.dataVertGridEh1TimeFieldRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1TimeFieldRow.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1TimeFieldRow.HeightOptions.AutoExpand = false;
      this.dataVertGridEh1TimeFieldRow.HeightOptions.ContentHeight = 1;
      this.dataVertGridEh1TimeFieldRow.HeightOptions.MaxContentHeight = 0;
      this.dataVertGridEh1TimeFieldRow.HeightOptions.Unit = EhLib.WinForms.GridRowHeightUnit.TextLine;
      this.dataVertGridEh1TimeFieldRow.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      // 
      // 
      // 
      this.dataVertGridEh1TimeFieldRow.InternalCellManager.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1TimeFieldRow.InternalCellManager.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1TimeFieldRow.Name = "dataVertGridEh1TimeFieldRow";
      this.dataVertGridEh1TimeFieldRow.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
      // 
      // 
      // 
      this.dataVertGridEh1TimeFieldRow.Title.BackFiller.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1TimeFieldRow.Title.BackFiller.FillStyle = EhLib.WinForms.CellFillStyle.VisualStyles;
      this.dataVertGridEh1TimeFieldRow.Title.BackFiller.InnerBorder = EhLib.WinForms.CellInnerBorderStyle.RaisedTopLeft;
      this.dataVertGridEh1TimeFieldRow.Title.BackFiller.SecondColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1TimeFieldRow.Title.EndEllipsis = false;
      this.dataVertGridEh1TimeFieldRow.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1TimeFieldRow.Title.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1TimeFieldRow.Title.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.dataVertGridEh1TimeFieldRow.Title.Padding = new System.Windows.Forms.Padding(2);
      this.dataVertGridEh1TimeFieldRow.Title.Text = "TimeField";
      this.dataVertGridEh1TimeFieldRow.Title.VertAlign = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
      this.dataVertGridEh1TimeFieldRow.VertLine.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1TimeFieldRow.VertLine.Style = System.Drawing.Drawing2D.DashStyle.Solid;
      this.dataVertGridEh1TimeFieldRow.VertLine.Visible = true;
      // 
      // dataVertGridEh1TimeSecFieldRow
      // 
      this.dataVertGridEh1TimeSecFieldRow.AllowShowEditor = true;
      this.dataVertGridEh1TimeSecFieldRow.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1TimeSecFieldRow.DataPropertyName = "TimeSecField";
      this.dataVertGridEh1TimeSecFieldRow.DataType = typeof(System.DateTime);
      this.dataVertGridEh1TimeSecFieldRow.ExternalCellManager = null;
      this.dataVertGridEh1TimeSecFieldRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1TimeSecFieldRow.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1TimeSecFieldRow.HeightOptions.AutoExpand = false;
      this.dataVertGridEh1TimeSecFieldRow.HeightOptions.ContentHeight = 1;
      this.dataVertGridEh1TimeSecFieldRow.HeightOptions.MaxContentHeight = 0;
      this.dataVertGridEh1TimeSecFieldRow.HeightOptions.Unit = EhLib.WinForms.GridRowHeightUnit.TextLine;
      this.dataVertGridEh1TimeSecFieldRow.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      // 
      // 
      // 
      this.dataVertGridEh1TimeSecFieldRow.InternalCellManager.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1TimeSecFieldRow.InternalCellManager.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1TimeSecFieldRow.Name = "dataVertGridEh1TimeSecFieldRow";
      this.dataVertGridEh1TimeSecFieldRow.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
      // 
      // 
      // 
      this.dataVertGridEh1TimeSecFieldRow.Title.BackFiller.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1TimeSecFieldRow.Title.BackFiller.FillStyle = EhLib.WinForms.CellFillStyle.VisualStyles;
      this.dataVertGridEh1TimeSecFieldRow.Title.BackFiller.InnerBorder = EhLib.WinForms.CellInnerBorderStyle.RaisedTopLeft;
      this.dataVertGridEh1TimeSecFieldRow.Title.BackFiller.SecondColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1TimeSecFieldRow.Title.EndEllipsis = false;
      this.dataVertGridEh1TimeSecFieldRow.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1TimeSecFieldRow.Title.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1TimeSecFieldRow.Title.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.dataVertGridEh1TimeSecFieldRow.Title.Padding = new System.Windows.Forms.Padding(2);
      this.dataVertGridEh1TimeSecFieldRow.Title.Text = "TimeSecField";
      this.dataVertGridEh1TimeSecFieldRow.Title.VertAlign = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
      this.dataVertGridEh1TimeSecFieldRow.VertLine.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1TimeSecFieldRow.VertLine.Style = System.Drawing.Drawing2D.DashStyle.Solid;
      this.dataVertGridEh1TimeSecFieldRow.VertLine.Visible = true;
      // 
      // dataVertGridEh1DateAsStringRow
      // 
      this.dataVertGridEh1DateAsStringRow.AllowShowEditor = true;
      this.dataVertGridEh1DateAsStringRow.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1DateAsStringRow.DataPropertyName = "DateAsString";
      this.dataVertGridEh1DateAsStringRow.DataType = typeof(string);
      this.dataVertGridEh1DateAsStringRow.ExternalCellManager = null;
      this.dataVertGridEh1DateAsStringRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1DateAsStringRow.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1DateAsStringRow.HeightOptions.AutoExpand = false;
      this.dataVertGridEh1DateAsStringRow.HeightOptions.ContentHeight = 1;
      this.dataVertGridEh1DateAsStringRow.HeightOptions.MaxContentHeight = 0;
      this.dataVertGridEh1DateAsStringRow.HeightOptions.Unit = EhLib.WinForms.GridRowHeightUnit.TextLine;
      this.dataVertGridEh1DateAsStringRow.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      // 
      // 
      // 
      this.dataVertGridEh1DateAsStringRow.InternalCellManager.BackColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1DateAsStringRow.InternalCellManager.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1DateAsStringRow.Name = "dataVertGridEh1DateAsStringRow";
      this.dataVertGridEh1DateAsStringRow.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
      // 
      // 
      // 
      this.dataVertGridEh1DateAsStringRow.Title.BackFiller.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1DateAsStringRow.Title.BackFiller.FillStyle = EhLib.WinForms.CellFillStyle.VisualStyles;
      this.dataVertGridEh1DateAsStringRow.Title.BackFiller.InnerBorder = EhLib.WinForms.CellInnerBorderStyle.RaisedTopLeft;
      this.dataVertGridEh1DateAsStringRow.Title.BackFiller.SecondColor = System.Drawing.SystemColors.Window;
      this.dataVertGridEh1DateAsStringRow.Title.EndEllipsis = false;
      this.dataVertGridEh1DateAsStringRow.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataVertGridEh1DateAsStringRow.Title.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataVertGridEh1DateAsStringRow.Title.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.dataVertGridEh1DateAsStringRow.Title.Padding = new System.Windows.Forms.Padding(2);
      this.dataVertGridEh1DateAsStringRow.Title.Text = "DateAsString";
      this.dataVertGridEh1DateAsStringRow.Title.VertAlign = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
      this.dataVertGridEh1DateAsStringRow.VertLine.Color = System.Drawing.SystemColors.ButtonFace;
      this.dataVertGridEh1DateAsStringRow.VertLine.Style = System.Drawing.Drawing2D.DashStyle.Solid;
      this.dataVertGridEh1DateAsStringRow.VertLine.Visible = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 511);
      this.Controls.Add(this.dataVertGridEh1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataVertGridEh1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.allTypesTablesDataSet)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private EhLib.WinForms.DataVertGridEh dataVertGridEh1;
    private AllTypesTablesDataSet allTypesTablesDataSet;
    private System.Windows.Forms.BindingSource employeesBindingSource;
    private AllTypesTablesDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
    private AllTypesTablesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    private EhLib.WinForms.DataVertGridTextRow dataVertGridEh1EmployeeIDRow;
    private EhLib.WinForms.DataVertGridTextRow dataVertGridEh1LastNameRow;
    private EhLib.WinForms.DataVertGridTextRow dataVertGridEh1FirstNameRow;
    private EhLib.WinForms.DataVertGridTextRow dataVertGridEh1TitleRow;
    private EhLib.WinForms.DataVertGridTextRow dataVertGridEh1TitleOfCourtesyRow;
    private EhLib.WinForms.DataVertGridDateTimeRow dataVertGridEh1BirthDateRow;
    private EhLib.WinForms.DataVertGridDateTimeRow dataVertGridEh1HireDateRow;
    private EhLib.WinForms.DataVertGridTextRow dataVertGridEh1IncomeRow;
    private EhLib.WinForms.DataVertGridTextRow dataVertGridEh1AddressRow;
    private EhLib.WinForms.DataVertGridTextRow dataVertGridEh1CityRow;
    private EhLib.WinForms.DataVertGridTextRow dataVertGridEh1RegionRow;
    private EhLib.WinForms.DataVertGridTextRow dataVertGridEh1PostalCodeRow;
    private EhLib.WinForms.DataVertGridTextRow dataVertGridEh1CountryRow;
    private EhLib.WinForms.DataVertGridTextRow dataVertGridEh1HomePhoneRow;
    private EhLib.WinForms.DataVertGridTextRow dataVertGridEh1ExtensionRow;
    private EhLib.WinForms.DataVertGridImageRow dataVertGridEh1PhotoRow;
    private EhLib.WinForms.DataVertGridTextRow dataVertGridEh1NotesRow;
    private EhLib.WinForms.DataVertGridTextRow dataVertGridEh1ReportsToRow;
    private EhLib.WinForms.DataVertGridCheckBoxRow dataVertGridEh1BooleanFieldRow;
    private EhLib.WinForms.DataVertGridTextRow dataVertGridEh1Char1ForCheckBoxRow;
    private EhLib.WinForms.DataVertGridDateTimeRow dataVertGridEh1TimeFieldRow;
    private EhLib.WinForms.DataVertGridDateTimeRow dataVertGridEh1TimeSecFieldRow;
    private EhLib.WinForms.DataVertGridTextRow dataVertGridEh1DateAsStringRow;
  }
}

