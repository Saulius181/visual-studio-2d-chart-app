
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Windows.Forms.DataVisualization.Charting;

namespace ResultStudio
{
  public partial class ResultStudioForm : Form
  {
        public ResultStudioForm()
    {
            InitializeComponent();
    }
        private void ResultStudioForm_Load(object sender, System.EventArgs e)
        {

        }


        private void chart_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                // Clear chart
                this.chart.Series["X"].Points.Clear();
                this.chart.Series["Y"].Points.Clear();
                this.chart.Series["Z"].Points.Clear();

                //Clear tolerance lines
                this.chart.ChartAreas["ChartArea1"].AxisY.StripLines.Clear();

                //Variable setup
                Dictionary<string, Dictionary<string, double>> panel_data = new Dictionary<string, Dictionary<string, double>>();
                Dictionary<string, Dictionary<int, double>> cell_data = new Dictionary<string, Dictionary<int, double>>();

                double upper_tolerance = 0;
                double lower_tolerance = 0;

                panel_data.Add("X", new Dictionary<string, double>());
                panel_data.Add("Y", new Dictionary<string, double>());
                panel_data.Add("Z", new Dictionary<string, double>());
                
                cell_data.Add("X", new Dictionary<int, double>());
                cell_data.Add("Y", new Dictionary<int, double>());
                cell_data.Add("Z", new Dictionary<int, double>());

                panel_data["X"].Add("Average", 0);
                panel_data["Y"].Add("Average", 0);
                panel_data["Z"].Add("Average", 0);

                panel_data["X"].Add("Row Count", 0);
                panel_data["Y"].Add("Row Count", 0);
                panel_data["Z"].Add("Row Count", 0);

                panel_data["X"].Add("Max", 0);
                panel_data["Y"].Add("Max", 0);
                panel_data["Z"].Add("Max", 0);

                panel_data["X"].Add("Min", 0);
                panel_data["Y"].Add("Min", 0);
                panel_data["Z"].Add("Min", 0);

                panel_data["X"].Add("Variance", 0);
                panel_data["Y"].Add("Variance", 0);
                panel_data["Z"].Add("Variance", 0);

                panel_data["X"].Add("DeltaMax", 0);
                panel_data["Y"].Add("DeltaMax", 0);
                panel_data["Z"].Add("DeltaMax", 0);

                panel_data["X"].Add("DeltaAvg", 0);
                panel_data["Y"].Add("DeltaAvg", 0);
                panel_data["Z"].Add("DeltaAvg", 0);

                panel_data["X"].Add("Median", 0);
                panel_data["Y"].Add("Median", 0);
                panel_data["Z"].Add("Median", 0);

                //Pass valid data from the grid to the dictionary
                foreach (DataGridViewRow row in this.dataGridView.Rows ) {

                    if (row.Cells[0].Value != null && Information.IsNumeric(row.Cells[0].Value) &&
                        row.Cells[1].Value != null &&
                        row.Cells[2].Value != null && Information.IsNumeric(row.Cells[2].Value) )
                    {

                        cell_data[row.Cells[1].Value.ToString()].Add(
                            int.Parse(row.Cells[0].Value.ToString()), 
                            Double.Parse(row.Cells[2].Value.ToString()
                            ));

                    }
                            
                }

                //Set tolerance values
                if (this.textBox1.Text != null && Information.IsNumeric(this.textBox1.Text))
                {
                    upper_tolerance = Double.Parse(this.textBox1.Text);
                    
                }

                if (this.textBox2.Text != null && Information.IsNumeric(this.textBox2.Text))
                {
                    lower_tolerance = Double.Parse(this.textBox2.Text);
                }
 
                //Iterate over data dictionary
                foreach (var axis in cell_data)
                {
                    foreach (var value in axis.Value)
                    {   
                        
                        panel_data[axis.Key]["Average"] += value.Value;

                        //Biggest value
                        if (value.Value > panel_data[axis.Key]["Max"] || panel_data[axis.Key]["Max"] == 0)
                        {
                            panel_data[axis.Key]["Max"] = value.Value;
                        }
                        //Smallest value
                        if (value.Value < panel_data[axis.Key]["Min"] || panel_data[axis.Key]["Min"] == 0)
                        {
                            panel_data[axis.Key]["Min"] = value.Value;
                        }
                    }
                    
                    //Average value
                    panel_data[axis.Key]["Average"] /= axis.Value.Count;

                    foreach (var value in axis.Value)
                    {
                        panel_data[axis.Key]["Variance"] += Math.Pow(value.Value - panel_data[axis.Key]["Average"], 2);
                    }
                    //Variance value
                    panel_data[axis.Key]["Variance"] = Math.Sqrt(panel_data[axis.Key]["Variance"] / axis.Value.Count);

                    //Median value
                    if (axis.Value.Count > 0)
                    {
                        if (axis.Value.Count % 2 == 1)
                        {
                            panel_data[axis.Key]["Median"] = axis.Value.Values.OrderBy(x => x).ToList()[(int)axis.Value.Count / 2];
                        }
                        else
                        {
                            panel_data[axis.Key]["Median"] = (axis.Value.Values.OrderBy(x => x).ToList()[(int)axis.Value.Values.Count / 2] + axis.Value.Values.OrderBy(x => x).ToList()[(int)axis.Value.Count / 2 - 1]) / 2;
                        }
                    }

                    var skippedFirstLoop = false;
                    var first_var = 0.0;
                    var second_var = 0.0;

                    
                    foreach (KeyValuePair<int, double> value in axis.Value)
                    {
                        first_var = value.Value;
                        if (skippedFirstLoop)
                        {
                            if ( Information.IsNumeric(value.Value))
                            {
                                if (Math.Abs(first_var - second_var) > panel_data[axis.Key]["DeltaMax"])
                                {   
                                    //Greatest change
                                    panel_data[axis.Key]["DeltaMax"] = Math.Abs(first_var - second_var);
                                }
                                
                                panel_data[axis.Key]["DeltaAvg"] += Math.Abs(first_var - second_var);
                            }
                        } else
                        {
                            skippedFirstLoop = true;
                        }
                        second_var = value.Value;
                    }
                    //Average change
                    panel_data[axis.Key]["DeltaAvg"] /= axis.Value.Count;

                    //Draw tolerance stripline for the current axis
                    StripLine stripLine1 = new StripLine();
                    stripLine1.BackColor = Color.FromArgb(60, 152, 180, 65);
                    stripLine1.StripWidth = upper_tolerance;
                    stripLine1.IntervalOffset = panel_data[axis.Key]["Average"];
                    stripLine1.Text = axis.Key + "-axis upper bound";
                    stripLine1.Font = new Font("Microsoft Sans Serif", 10);
                    //stripLine1.TextOrientation = TextOrientation.Rotated270;
                    stripLine1.TextLineAlignment = StringAlignment.Center;
                    stripLine1.TextAlignment = StringAlignment.Near;
                    this.chart.ChartAreas["ChartArea1"].AxisY.StripLines.Add(stripLine1);

                    //Draw tolerance stripline for the current axis
                    StripLine stripLine2 = new StripLine();
                    stripLine2.BackColor = Color.FromArgb(160, 152, 180, 65);
                    stripLine2.StripWidth = lower_tolerance;
                    stripLine2.IntervalOffset = panel_data[axis.Key]["Average"] - lower_tolerance;
                    stripLine2.Text = axis.Key + "-axis lower bound";
                    stripLine2.Font = new Font("Microsoft Sans Serif", 10);
                    //stripLine2.TextOrientation = TextOrientation.Rotated270;
                    stripLine2.TextLineAlignment = StringAlignment.Center;
                    stripLine2.TextAlignment = StringAlignment.Near;
                    this.chart.ChartAreas["ChartArea1"].AxisY.StripLines.Add(stripLine2);

                    foreach (var value in axis.Value.OrderBy(x => x.Key))
                    {
                        // Draw chart item
                        this.chart.Series[axis.Key].Points.AddXY(value.Key, value.Value);
                        if (panel_data[axis.Key]["Average"] + upper_tolerance < value.Value || panel_data[axis.Key]["Average"] - lower_tolerance > value.Value)
                        {
                            this.chart.Series[axis.Key].Points.Last().LabelBackColor = Color.FromArgb(255, 255, 1, 0);
                        }
                    }
                    
                }

                //Setup labels

                this.average_x_label_value.Text = (panel_data["X"]["Average"]).ToString();
                this.average_y_label_value.Text = (panel_data["Y"]["Average"]).ToString();
                this.average_z_label_value.Text = (panel_data["Z"]["Average"]).ToString();

                this.max_x_label_value.Text = (panel_data["X"]["Max"]).ToString();
                this.max_y_label_value.Text = (panel_data["Y"]["Max"]).ToString();
                this.max_z_label_value.Text = (panel_data["Z"]["Max"]).ToString();

                this.min_x_label_value.Text = (panel_data["X"]["Min"]).ToString();
                this.min_y_label_value.Text = (panel_data["Y"]["Min"]).ToString();
                this.min_z_label_value.Text = (panel_data["Z"]["Min"]).ToString();

                this.variance_x_label_value.Text = (panel_data["X"]["Variance"]).ToString();
                this.variance_y_label_value.Text = (panel_data["Y"]["Variance"]).ToString();
                this.variance_z_label_value.Text = (panel_data["Z"]["Variance"]).ToString();

                this.deltaMax_x_label_value.Text = (panel_data["X"]["DeltaMax"]).ToString();
                this.deltaMax_y_label_value.Text = (panel_data["Y"]["DeltaMax"]).ToString();
                this.deltaMax_z_label_value.Text = (panel_data["Z"]["DeltaMax"]).ToString();

                this.deltaAvg_x_label_value.Text = (panel_data["X"]["DeltaAvg"]).ToString();
                this.deltaAvg_y_label_value.Text = (panel_data["Y"]["DeltaAvg"]).ToString();
                this.deltaAvg_z_label_value.Text = (panel_data["Z"]["DeltaAvg"]).ToString();

                this.median_x_label_value.Text = (panel_data["X"]["Median"]).ToString();
                this.median_y_label_value.Text = (panel_data["Y"]["Median"]).ToString();
                this.median_z_label_value.Text = (panel_data["Z"]["Median"]).ToString();
            }
        }

        //Default axis value
        private void dataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["Axis"].Value = "X";
        }


        //Cell validation
        private void dataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            
        }

        private void dataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
