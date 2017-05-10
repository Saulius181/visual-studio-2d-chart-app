namespace ResultStudio
{
  partial class ResultStudioForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.resultStudioFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lower_tolerance_label = new System.Windows.Forms.Label();
            this.upper_tolerance_label = new System.Windows.Forms.Label();
            this.median_z_label_value = new System.Windows.Forms.Label();
            this.median_y_label_value = new System.Windows.Forms.Label();
            this.median_x_label_value = new System.Windows.Forms.Label();
            this.median_z_label = new System.Windows.Forms.Label();
            this.median_y_label = new System.Windows.Forms.Label();
            this.median_x_label = new System.Windows.Forms.Label();
            this.deltaAvg_z_label_value = new System.Windows.Forms.Label();
            this.deltaAvg_y_label_value = new System.Windows.Forms.Label();
            this.deltaAvg_x_label_value = new System.Windows.Forms.Label();
            this.deltaAvg_z_label = new System.Windows.Forms.Label();
            this.deltaAvg_y_label = new System.Windows.Forms.Label();
            this.deltaAvg_x_label = new System.Windows.Forms.Label();
            this.deltaMax_z_label_value = new System.Windows.Forms.Label();
            this.deltaMax_y_label_value = new System.Windows.Forms.Label();
            this.deltaMax_x_label_value = new System.Windows.Forms.Label();
            this.deltaMax_z_label = new System.Windows.Forms.Label();
            this.deltaMax_y_label = new System.Windows.Forms.Label();
            this.deltaMax_x_label = new System.Windows.Forms.Label();
            this.variance_z_label_value = new System.Windows.Forms.Label();
            this.variance_y_label_value = new System.Windows.Forms.Label();
            this.variance_z_label = new System.Windows.Forms.Label();
            this.variance_y_label = new System.Windows.Forms.Label();
            this.variance_x_label_value = new System.Windows.Forms.Label();
            this.variance_x_label = new System.Windows.Forms.Label();
            this.min_z_label_value = new System.Windows.Forms.Label();
            this.min_y_label_value = new System.Windows.Forms.Label();
            this.min_x_label_value = new System.Windows.Forms.Label();
            this.max_z_label_value = new System.Windows.Forms.Label();
            this.max_y_label_value = new System.Windows.Forms.Label();
            this.max_x_label_value = new System.Windows.Forms.Label();
            this.mix_z_label = new System.Windows.Forms.Label();
            this.mix_y_label = new System.Windows.Forms.Label();
            this.mix_x_label = new System.Windows.Forms.Label();
            this.max_z_label = new System.Windows.Forms.Label();
            this.max_y_label = new System.Windows.Forms.Label();
            this.max_x_label = new System.Windows.Forms.Label();
            this.average_z_label_value = new System.Windows.Forms.Label();
            this.average_y_label_value = new System.Windows.Forms.Label();
            this.average_x_label_value = new System.Windows.Forms.Label();
            this.average_z_label = new System.Windows.Forms.Label();
            this.average_y_label = new System.Windows.Forms.Label();
            this.average_x_label = new System.Windows.Forms.Label();
            this.Measurement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Axis = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nominal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToleranceLower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToleranceUpper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultStudioFormBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Measurement,
            this.Axis,
            this.Value,
            this.Nominal,
            this.ToleranceLower,
            this.ToleranceUpper});
            this.dataGridView.Location = new System.Drawing.Point(12, 13);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(759, 577);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView_CellValidating);
            this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
            this.dataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView_DefaultValuesNeeded);
            this.dataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView_RowsAdded);
            // 
            // chart
            // 
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(777, 12);
            this.chart.Name = "chart";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.IsValueShownAsLabel = true;
            series4.LabelBackColor = System.Drawing.Color.White;
            series4.Legend = "Legend1";
            series4.MarkerColor = System.Drawing.Color.Black;
            series4.MarkerSize = 8;
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Cross;
            series4.Name = "X";
            series4.YValuesPerPoint = 6;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.IsValueShownAsLabel = true;
            series5.Legend = "Legend1";
            series5.Name = "Y";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.IsValueShownAsLabel = true;
            series6.Legend = "Legend1";
            series6.Name = "Z";
            this.chart.Series.Add(series4);
            this.chart.Series.Add(series5);
            this.chart.Series.Add(series6);
            this.chart.Size = new System.Drawing.Size(517, 577);
            this.chart.TabIndex = 1;
            this.chart.Click += new System.EventHandler(this.chart_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lower_tolerance_label);
            this.panel1.Controls.Add(this.upper_tolerance_label);
            this.panel1.Controls.Add(this.median_z_label_value);
            this.panel1.Controls.Add(this.median_y_label_value);
            this.panel1.Controls.Add(this.median_x_label_value);
            this.panel1.Controls.Add(this.median_z_label);
            this.panel1.Controls.Add(this.median_y_label);
            this.panel1.Controls.Add(this.median_x_label);
            this.panel1.Controls.Add(this.deltaAvg_z_label_value);
            this.panel1.Controls.Add(this.deltaAvg_y_label_value);
            this.panel1.Controls.Add(this.deltaAvg_x_label_value);
            this.panel1.Controls.Add(this.deltaAvg_z_label);
            this.panel1.Controls.Add(this.deltaAvg_y_label);
            this.panel1.Controls.Add(this.deltaAvg_x_label);
            this.panel1.Controls.Add(this.deltaMax_z_label_value);
            this.panel1.Controls.Add(this.deltaMax_y_label_value);
            this.panel1.Controls.Add(this.deltaMax_x_label_value);
            this.panel1.Controls.Add(this.deltaMax_z_label);
            this.panel1.Controls.Add(this.deltaMax_y_label);
            this.panel1.Controls.Add(this.deltaMax_x_label);
            this.panel1.Controls.Add(this.variance_z_label_value);
            this.panel1.Controls.Add(this.variance_y_label_value);
            this.panel1.Controls.Add(this.variance_z_label);
            this.panel1.Controls.Add(this.variance_y_label);
            this.panel1.Controls.Add(this.variance_x_label_value);
            this.panel1.Controls.Add(this.variance_x_label);
            this.panel1.Controls.Add(this.min_z_label_value);
            this.panel1.Controls.Add(this.min_y_label_value);
            this.panel1.Controls.Add(this.min_x_label_value);
            this.panel1.Controls.Add(this.max_z_label_value);
            this.panel1.Controls.Add(this.max_y_label_value);
            this.panel1.Controls.Add(this.max_x_label_value);
            this.panel1.Controls.Add(this.mix_z_label);
            this.panel1.Controls.Add(this.mix_y_label);
            this.panel1.Controls.Add(this.mix_x_label);
            this.panel1.Controls.Add(this.max_z_label);
            this.panel1.Controls.Add(this.max_y_label);
            this.panel1.Controls.Add(this.max_x_label);
            this.panel1.Controls.Add(this.average_z_label_value);
            this.panel1.Controls.Add(this.average_y_label_value);
            this.panel1.Controls.Add(this.average_x_label_value);
            this.panel1.Controls.Add(this.average_z_label);
            this.panel1.Controls.Add(this.average_y_label);
            this.panel1.Controls.Add(this.average_x_label);
            this.panel1.Location = new System.Drawing.Point(654, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 577);
            this.panel1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 429);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 45;
            this.textBox2.Text = "5";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 375);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 44;
            this.textBox1.Text = "5";
            // 
            // lower_tolerance_label
            // 
            this.lower_tolerance_label.AutoSize = true;
            this.lower_tolerance_label.Location = new System.Drawing.Point(3, 413);
            this.lower_tolerance_label.Name = "lower_tolerance_label";
            this.lower_tolerance_label.Size = new System.Drawing.Size(86, 13);
            this.lower_tolerance_label.TabIndex = 43;
            this.lower_tolerance_label.Text = "Lower tolerance:";
            // 
            // upper_tolerance_label
            // 
            this.upper_tolerance_label.AutoSize = true;
            this.upper_tolerance_label.Location = new System.Drawing.Point(3, 358);
            this.upper_tolerance_label.Name = "upper_tolerance_label";
            this.upper_tolerance_label.Size = new System.Drawing.Size(86, 13);
            this.upper_tolerance_label.TabIndex = 42;
            this.upper_tolerance_label.Text = "Upper tolerance:";
            // 
            // median_z_label_value
            // 
            this.median_z_label_value.AutoSize = true;
            this.median_z_label_value.Location = new System.Drawing.Point(69, 319);
            this.median_z_label_value.Name = "median_z_label_value";
            this.median_z_label_value.Size = new System.Drawing.Size(13, 13);
            this.median_z_label_value.TabIndex = 41;
            this.median_z_label_value.Text = "0";
            // 
            // median_y_label_value
            // 
            this.median_y_label_value.AutoSize = true;
            this.median_y_label_value.Location = new System.Drawing.Point(69, 306);
            this.median_y_label_value.Name = "median_y_label_value";
            this.median_y_label_value.Size = new System.Drawing.Size(13, 13);
            this.median_y_label_value.TabIndex = 40;
            this.median_y_label_value.Text = "0";
            // 
            // median_x_label_value
            // 
            this.median_x_label_value.AutoSize = true;
            this.median_x_label_value.Location = new System.Drawing.Point(69, 293);
            this.median_x_label_value.Name = "median_x_label_value";
            this.median_x_label_value.Size = new System.Drawing.Size(13, 13);
            this.median_x_label_value.TabIndex = 39;
            this.median_x_label_value.Text = "0";
            // 
            // median_z_label
            // 
            this.median_z_label.AutoSize = true;
            this.median_z_label.Location = new System.Drawing.Point(3, 319);
            this.median_z_label.Name = "median_z_label";
            this.median_z_label.Size = new System.Drawing.Size(55, 13);
            this.median_z_label.TabIndex = 38;
            this.median_z_label.Text = "Median Z:";
            // 
            // median_y_label
            // 
            this.median_y_label.AutoSize = true;
            this.median_y_label.Location = new System.Drawing.Point(3, 306);
            this.median_y_label.Name = "median_y_label";
            this.median_y_label.Size = new System.Drawing.Size(55, 13);
            this.median_y_label.TabIndex = 37;
            this.median_y_label.Text = "Median Y:";
            // 
            // median_x_label
            // 
            this.median_x_label.AutoSize = true;
            this.median_x_label.Location = new System.Drawing.Point(3, 293);
            this.median_x_label.Name = "median_x_label";
            this.median_x_label.Size = new System.Drawing.Size(55, 13);
            this.median_x_label.TabIndex = 36;
            this.median_x_label.Text = "Median X:";
            // 
            // deltaAvg_z_label_value
            // 
            this.deltaAvg_z_label_value.AutoSize = true;
            this.deltaAvg_z_label_value.Location = new System.Drawing.Point(69, 271);
            this.deltaAvg_z_label_value.Name = "deltaAvg_z_label_value";
            this.deltaAvg_z_label_value.Size = new System.Drawing.Size(13, 13);
            this.deltaAvg_z_label_value.TabIndex = 35;
            this.deltaAvg_z_label_value.Text = "0";
            // 
            // deltaAvg_y_label_value
            // 
            this.deltaAvg_y_label_value.AutoSize = true;
            this.deltaAvg_y_label_value.Location = new System.Drawing.Point(69, 258);
            this.deltaAvg_y_label_value.Name = "deltaAvg_y_label_value";
            this.deltaAvg_y_label_value.Size = new System.Drawing.Size(13, 13);
            this.deltaAvg_y_label_value.TabIndex = 34;
            this.deltaAvg_y_label_value.Text = "0";
            // 
            // deltaAvg_x_label_value
            // 
            this.deltaAvg_x_label_value.AutoSize = true;
            this.deltaAvg_x_label_value.Location = new System.Drawing.Point(69, 245);
            this.deltaAvg_x_label_value.Name = "deltaAvg_x_label_value";
            this.deltaAvg_x_label_value.Size = new System.Drawing.Size(13, 13);
            this.deltaAvg_x_label_value.TabIndex = 33;
            this.deltaAvg_x_label_value.Text = "0";
            // 
            // deltaAvg_z_label
            // 
            this.deltaAvg_z_label.AutoSize = true;
            this.deltaAvg_z_label.Location = new System.Drawing.Point(3, 271);
            this.deltaAvg_z_label.Name = "deltaAvg_z_label";
            this.deltaAvg_z_label.Size = new System.Drawing.Size(64, 13);
            this.deltaAvg_z_label.TabIndex = 32;
            this.deltaAvg_z_label.Text = "DeltaAvg Z:";
            // 
            // deltaAvg_y_label
            // 
            this.deltaAvg_y_label.AutoSize = true;
            this.deltaAvg_y_label.Location = new System.Drawing.Point(3, 258);
            this.deltaAvg_y_label.Name = "deltaAvg_y_label";
            this.deltaAvg_y_label.Size = new System.Drawing.Size(64, 13);
            this.deltaAvg_y_label.TabIndex = 30;
            this.deltaAvg_y_label.Text = "DeltaAvg Y:";
            // 
            // deltaAvg_x_label
            // 
            this.deltaAvg_x_label.AutoSize = true;
            this.deltaAvg_x_label.Location = new System.Drawing.Point(3, 245);
            this.deltaAvg_x_label.Name = "deltaAvg_x_label";
            this.deltaAvg_x_label.Size = new System.Drawing.Size(64, 13);
            this.deltaAvg_x_label.TabIndex = 31;
            this.deltaAvg_x_label.Text = "DeltaAvg X:";
            // 
            // deltaMax_z_label_value
            // 
            this.deltaMax_z_label_value.AutoSize = true;
            this.deltaMax_z_label_value.Location = new System.Drawing.Point(69, 223);
            this.deltaMax_z_label_value.Name = "deltaMax_z_label_value";
            this.deltaMax_z_label_value.Size = new System.Drawing.Size(13, 13);
            this.deltaMax_z_label_value.TabIndex = 29;
            this.deltaMax_z_label_value.Text = "0";
            // 
            // deltaMax_y_label_value
            // 
            this.deltaMax_y_label_value.AutoSize = true;
            this.deltaMax_y_label_value.Location = new System.Drawing.Point(69, 210);
            this.deltaMax_y_label_value.Name = "deltaMax_y_label_value";
            this.deltaMax_y_label_value.Size = new System.Drawing.Size(13, 13);
            this.deltaMax_y_label_value.TabIndex = 28;
            this.deltaMax_y_label_value.Text = "0";
            this.deltaMax_y_label_value.Click += new System.EventHandler(this.label5_Click);
            // 
            // deltaMax_x_label_value
            // 
            this.deltaMax_x_label_value.AutoSize = true;
            this.deltaMax_x_label_value.Location = new System.Drawing.Point(69, 197);
            this.deltaMax_x_label_value.Name = "deltaMax_x_label_value";
            this.deltaMax_x_label_value.Size = new System.Drawing.Size(13, 13);
            this.deltaMax_x_label_value.TabIndex = 27;
            this.deltaMax_x_label_value.Text = "0";
            // 
            // deltaMax_z_label
            // 
            this.deltaMax_z_label.AutoSize = true;
            this.deltaMax_z_label.Location = new System.Drawing.Point(3, 223);
            this.deltaMax_z_label.Name = "deltaMax_z_label";
            this.deltaMax_z_label.Size = new System.Drawing.Size(65, 13);
            this.deltaMax_z_label.TabIndex = 26;
            this.deltaMax_z_label.Text = "DeltaMax Z:";
            // 
            // deltaMax_y_label
            // 
            this.deltaMax_y_label.AutoSize = true;
            this.deltaMax_y_label.Location = new System.Drawing.Point(3, 210);
            this.deltaMax_y_label.Name = "deltaMax_y_label";
            this.deltaMax_y_label.Size = new System.Drawing.Size(65, 13);
            this.deltaMax_y_label.TabIndex = 25;
            this.deltaMax_y_label.Text = "DeltaMax Y:";
            // 
            // deltaMax_x_label
            // 
            this.deltaMax_x_label.AutoSize = true;
            this.deltaMax_x_label.Location = new System.Drawing.Point(3, 197);
            this.deltaMax_x_label.Name = "deltaMax_x_label";
            this.deltaMax_x_label.Size = new System.Drawing.Size(65, 13);
            this.deltaMax_x_label.TabIndex = 24;
            this.deltaMax_x_label.Text = "DeltaMax X:";
            // 
            // variance_z_label_value
            // 
            this.variance_z_label_value.AutoSize = true;
            this.variance_z_label_value.Location = new System.Drawing.Point(69, 174);
            this.variance_z_label_value.Name = "variance_z_label_value";
            this.variance_z_label_value.Size = new System.Drawing.Size(13, 13);
            this.variance_z_label_value.TabIndex = 23;
            this.variance_z_label_value.Text = "0";
            // 
            // variance_y_label_value
            // 
            this.variance_y_label_value.AutoSize = true;
            this.variance_y_label_value.Location = new System.Drawing.Point(69, 161);
            this.variance_y_label_value.Name = "variance_y_label_value";
            this.variance_y_label_value.Size = new System.Drawing.Size(13, 13);
            this.variance_y_label_value.TabIndex = 22;
            this.variance_y_label_value.Text = "0";
            // 
            // variance_z_label
            // 
            this.variance_z_label.AutoSize = true;
            this.variance_z_label.Location = new System.Drawing.Point(3, 174);
            this.variance_z_label.Name = "variance_z_label";
            this.variance_z_label.Size = new System.Drawing.Size(62, 13);
            this.variance_z_label.TabIndex = 21;
            this.variance_z_label.Text = "Variance Z:";
            // 
            // variance_y_label
            // 
            this.variance_y_label.AutoSize = true;
            this.variance_y_label.Location = new System.Drawing.Point(3, 161);
            this.variance_y_label.Name = "variance_y_label";
            this.variance_y_label.Size = new System.Drawing.Size(62, 13);
            this.variance_y_label.TabIndex = 20;
            this.variance_y_label.Text = "Variance Y:";
            // 
            // variance_x_label_value
            // 
            this.variance_x_label_value.AutoSize = true;
            this.variance_x_label_value.Location = new System.Drawing.Point(69, 148);
            this.variance_x_label_value.Name = "variance_x_label_value";
            this.variance_x_label_value.Size = new System.Drawing.Size(13, 13);
            this.variance_x_label_value.TabIndex = 19;
            this.variance_x_label_value.Text = "0";
            // 
            // variance_x_label
            // 
            this.variance_x_label.AutoSize = true;
            this.variance_x_label.Location = new System.Drawing.Point(3, 148);
            this.variance_x_label.Name = "variance_x_label";
            this.variance_x_label.Size = new System.Drawing.Size(62, 13);
            this.variance_x_label.TabIndex = 18;
            this.variance_x_label.Text = "Variance X:";
            // 
            // min_z_label_value
            // 
            this.min_z_label_value.AutoSize = true;
            this.min_z_label_value.Location = new System.Drawing.Point(69, 123);
            this.min_z_label_value.Name = "min_z_label_value";
            this.min_z_label_value.Size = new System.Drawing.Size(13, 13);
            this.min_z_label_value.TabIndex = 17;
            this.min_z_label_value.Text = "0";
            // 
            // min_y_label_value
            // 
            this.min_y_label_value.AutoSize = true;
            this.min_y_label_value.Location = new System.Drawing.Point(69, 110);
            this.min_y_label_value.Name = "min_y_label_value";
            this.min_y_label_value.Size = new System.Drawing.Size(13, 13);
            this.min_y_label_value.TabIndex = 16;
            this.min_y_label_value.Text = "0";
            // 
            // min_x_label_value
            // 
            this.min_x_label_value.AutoSize = true;
            this.min_x_label_value.Location = new System.Drawing.Point(69, 97);
            this.min_x_label_value.Name = "min_x_label_value";
            this.min_x_label_value.Size = new System.Drawing.Size(13, 13);
            this.min_x_label_value.TabIndex = 15;
            this.min_x_label_value.Text = "0";
            // 
            // max_z_label_value
            // 
            this.max_z_label_value.AutoSize = true;
            this.max_z_label_value.Location = new System.Drawing.Point(69, 75);
            this.max_z_label_value.Name = "max_z_label_value";
            this.max_z_label_value.Size = new System.Drawing.Size(13, 13);
            this.max_z_label_value.TabIndex = 14;
            this.max_z_label_value.Text = "0";
            // 
            // max_y_label_value
            // 
            this.max_y_label_value.AutoSize = true;
            this.max_y_label_value.Location = new System.Drawing.Point(69, 62);
            this.max_y_label_value.Name = "max_y_label_value";
            this.max_y_label_value.Size = new System.Drawing.Size(13, 13);
            this.max_y_label_value.TabIndex = 13;
            this.max_y_label_value.Text = "0";
            // 
            // max_x_label_value
            // 
            this.max_x_label_value.AutoSize = true;
            this.max_x_label_value.Location = new System.Drawing.Point(69, 49);
            this.max_x_label_value.Name = "max_x_label_value";
            this.max_x_label_value.Size = new System.Drawing.Size(13, 13);
            this.max_x_label_value.TabIndex = 12;
            this.max_x_label_value.Text = "0";
            // 
            // mix_z_label
            // 
            this.mix_z_label.AutoSize = true;
            this.mix_z_label.Location = new System.Drawing.Point(3, 123);
            this.mix_z_label.Name = "mix_z_label";
            this.mix_z_label.Size = new System.Drawing.Size(37, 13);
            this.mix_z_label.TabIndex = 11;
            this.mix_z_label.Text = "Min Z:";
            // 
            // mix_y_label
            // 
            this.mix_y_label.AutoSize = true;
            this.mix_y_label.Location = new System.Drawing.Point(3, 110);
            this.mix_y_label.Name = "mix_y_label";
            this.mix_y_label.Size = new System.Drawing.Size(37, 13);
            this.mix_y_label.TabIndex = 10;
            this.mix_y_label.Text = "Min Y:";
            // 
            // mix_x_label
            // 
            this.mix_x_label.AutoSize = true;
            this.mix_x_label.Location = new System.Drawing.Point(3, 97);
            this.mix_x_label.Name = "mix_x_label";
            this.mix_x_label.Size = new System.Drawing.Size(37, 13);
            this.mix_x_label.TabIndex = 9;
            this.mix_x_label.Text = "Min X:";
            // 
            // max_z_label
            // 
            this.max_z_label.AutoSize = true;
            this.max_z_label.Location = new System.Drawing.Point(3, 75);
            this.max_z_label.Name = "max_z_label";
            this.max_z_label.Size = new System.Drawing.Size(40, 13);
            this.max_z_label.TabIndex = 8;
            this.max_z_label.Text = "Max Z:";
            // 
            // max_y_label
            // 
            this.max_y_label.AutoSize = true;
            this.max_y_label.Location = new System.Drawing.Point(3, 62);
            this.max_y_label.Name = "max_y_label";
            this.max_y_label.Size = new System.Drawing.Size(40, 13);
            this.max_y_label.TabIndex = 7;
            this.max_y_label.Text = "Max Y:";
            // 
            // max_x_label
            // 
            this.max_x_label.AutoSize = true;
            this.max_x_label.Location = new System.Drawing.Point(3, 49);
            this.max_x_label.Name = "max_x_label";
            this.max_x_label.Size = new System.Drawing.Size(40, 13);
            this.max_x_label.TabIndex = 6;
            this.max_x_label.Text = "Max X:";
            // 
            // average_z_label_value
            // 
            this.average_z_label_value.AutoSize = true;
            this.average_z_label_value.Location = new System.Drawing.Point(69, 26);
            this.average_z_label_value.Name = "average_z_label_value";
            this.average_z_label_value.Size = new System.Drawing.Size(13, 13);
            this.average_z_label_value.TabIndex = 5;
            this.average_z_label_value.Text = "0";
            // 
            // average_y_label_value
            // 
            this.average_y_label_value.AutoSize = true;
            this.average_y_label_value.Location = new System.Drawing.Point(69, 13);
            this.average_y_label_value.Name = "average_y_label_value";
            this.average_y_label_value.Size = new System.Drawing.Size(13, 13);
            this.average_y_label_value.TabIndex = 4;
            this.average_y_label_value.Text = "0";
            // 
            // average_x_label_value
            // 
            this.average_x_label_value.AutoSize = true;
            this.average_x_label_value.Location = new System.Drawing.Point(69, 0);
            this.average_x_label_value.Name = "average_x_label_value";
            this.average_x_label_value.Size = new System.Drawing.Size(13, 13);
            this.average_x_label_value.TabIndex = 3;
            this.average_x_label_value.Text = "0";
            // 
            // average_z_label
            // 
            this.average_z_label.AutoSize = true;
            this.average_z_label.Location = new System.Drawing.Point(3, 26);
            this.average_z_label.Name = "average_z_label";
            this.average_z_label.Size = new System.Drawing.Size(60, 13);
            this.average_z_label.TabIndex = 2;
            this.average_z_label.Text = "Average Z:";
            // 
            // average_y_label
            // 
            this.average_y_label.AutoSize = true;
            this.average_y_label.Location = new System.Drawing.Point(3, 13);
            this.average_y_label.Name = "average_y_label";
            this.average_y_label.Size = new System.Drawing.Size(60, 13);
            this.average_y_label.TabIndex = 1;
            this.average_y_label.Text = "Average Y:";
            // 
            // average_x_label
            // 
            this.average_x_label.AutoSize = true;
            this.average_x_label.Location = new System.Drawing.Point(3, 0);
            this.average_x_label.Name = "average_x_label";
            this.average_x_label.Size = new System.Drawing.Size(60, 13);
            this.average_x_label.TabIndex = 0;
            this.average_x_label.Text = "Average X:";
            // 
            // Measurement
            // 
            this.Measurement.HeaderText = "Measurement";
            this.Measurement.Name = "Measurement";
            // 
            // Axis
            // 
            this.Axis.HeaderText = "Axis";
            this.Axis.Items.AddRange(new object[] {
            "X",
            "Y",
            "Z"});
            this.Axis.Name = "Axis";
            this.Axis.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Axis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Nominal
            // 
            this.Nominal.HeaderText = "Nominal";
            this.Nominal.Name = "Nominal";
            // 
            // ToleranceLower
            // 
            this.ToleranceLower.HeaderText = "Tolerance Lower";
            this.ToleranceLower.Name = "ToleranceLower";
            // 
            // ToleranceUpper
            // 
            this.ToleranceUpper.HeaderText = "Tolerance Upper";
            this.ToleranceUpper.Name = "ToleranceUpper";
            // 
            // ResultStudioForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 602);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.dataGridView);
            this.Name = "ResultStudioForm";
            this.Text = "Result Studio";
            this.Load += new System.EventHandler(this.ResultStudioForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultStudioFormBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.BindingSource resultStudioFormBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label average_z_label;
        private System.Windows.Forms.Label average_y_label;
        private System.Windows.Forms.Label average_x_label;
        private System.Windows.Forms.Label average_z_label_value;
        private System.Windows.Forms.Label average_y_label_value;
        private System.Windows.Forms.Label average_x_label_value;
        private System.Windows.Forms.Label max_z_label;
        private System.Windows.Forms.Label max_y_label;
        private System.Windows.Forms.Label max_x_label;
        private System.Windows.Forms.Label variance_z_label_value;
        private System.Windows.Forms.Label variance_y_label_value;
        private System.Windows.Forms.Label variance_z_label;
        private System.Windows.Forms.Label variance_y_label;
        private System.Windows.Forms.Label variance_x_label_value;
        private System.Windows.Forms.Label variance_x_label;
        private System.Windows.Forms.Label min_z_label_value;
        private System.Windows.Forms.Label min_y_label_value;
        private System.Windows.Forms.Label min_x_label_value;
        private System.Windows.Forms.Label max_z_label_value;
        private System.Windows.Forms.Label max_y_label_value;
        private System.Windows.Forms.Label max_x_label_value;
        private System.Windows.Forms.Label mix_z_label;
        private System.Windows.Forms.Label mix_y_label;
        private System.Windows.Forms.Label mix_x_label;
        private System.Windows.Forms.Label deltaMax_y_label_value;
        private System.Windows.Forms.Label deltaMax_x_label_value;
        private System.Windows.Forms.Label deltaMax_z_label;
        private System.Windows.Forms.Label deltaMax_y_label;
        private System.Windows.Forms.Label deltaMax_x_label;
        private System.Windows.Forms.Label deltaMax_z_label_value;
        private System.Windows.Forms.Label deltaAvg_z_label_value;
        private System.Windows.Forms.Label deltaAvg_y_label_value;
        private System.Windows.Forms.Label deltaAvg_x_label_value;
        private System.Windows.Forms.Label deltaAvg_z_label;
        private System.Windows.Forms.Label deltaAvg_y_label;
        private System.Windows.Forms.Label deltaAvg_x_label;
        private System.Windows.Forms.Label median_x_label;
        private System.Windows.Forms.Label median_z_label_value;
        private System.Windows.Forms.Label median_y_label_value;
        private System.Windows.Forms.Label median_x_label_value;
        private System.Windows.Forms.Label median_z_label;
        private System.Windows.Forms.Label median_y_label;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lower_tolerance_label;
        private System.Windows.Forms.Label upper_tolerance_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn Measurement;
        private System.Windows.Forms.DataGridViewComboBoxColumn Axis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nominal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToleranceLower;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToleranceUpper;
    }
}

