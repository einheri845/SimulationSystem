using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Simulation_System.Presenter;
using Simulation_System.View;

namespace Simulation_System
{
    public partial class Form1 : Form, IMainMenu
    {
        public Form1()
        {
            InitializeComponent();
            new MMPresenter(this);
        }

        #region < Private fields >

        private string filePath;
        private string distribution;

        #endregion

        #region < Realization view interfaces >

        public void FirstState()
        {
            FourthState(false);
            ThirdState(false);
            SecondState(false);
            filePath = null;
        }

        public void SecondState(bool enabled)
        {
            customParser.Enabled = enabled;
        }

        public void ThirdState(bool enabled)
        {
            customClasses.Enabled = enabled;
        }

        public void FourthState(bool enabled)
        {
            customGenerator.Enabled = enabled;
            byFile.Enabled = enabled;
            byFile.Checked = enabled;
        }

        public void FifthState(bool enabled)
        {

        }

        public string FilePath
        {
            get
            {
                return filePath;
            }

            set
            {
                filePath = value;
            }
        }

        public string GetFile(string filterFiles)
        {
            if(filePath == null)
            {
                openFileDialog1.Filter = filterFiles;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog1.FileName;
                }
                return filePath;
            }
            else
            {
                return filePath;
            }
        }

        public void SetVariables(string[] varArray)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(varArray);
        }

        public int ValuePosition()
        {
            return comboBox1.SelectedIndex;
        }

        public int GetCountClasses()
        {
            if (radioButton1.Checked == true)
            {
                return Convert.ToInt32(numClasses.Value);
            }
            else
            {
                return 0;
            }
        }

        public bool GetDelAbnormalValues()
        {
            if (checkAbnormalV.Checked == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ShowVarRange(List<double[]> vaRData)
        {
            gridVarRange.Columns.Clear();
            gridVarRange.Rows.Clear();
            gridVarRange.Columns.Add("Iter", "№");
            gridVarRange.Columns["Iter"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            gridVarRange.Columns.Add("Value", "Value");
            gridVarRange.Columns.Add("Count", "Count");
            for(int i = 0; i < vaRData.Count; i++)
            {
                gridVarRange.Rows.Add(i + 1, vaRData[i][0], vaRData[i][1]);
            }
        }

        public void ShowClasses(List<double[]> classesData)
        {
            gridClass.Columns.Clear();
            gridClass.Rows.Clear();
            gridClass.Columns.Add("Iter", "№");
            gridClass.Columns["Iter"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            gridClass.Columns.Add("Boundaries", "Boundaries");
            gridClass.Columns["Boundaries"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            gridClass.Columns.Add("Quantity", "Quantity");
            gridClass.Columns.Add("Frequency", "Frequency");
            for(int i = 0; i < classesData.Count; i++)
            {
                if (i < classesData.Count - 1)
                {
                    gridClass.Rows.Add(i + 1, String.Format("[ {0:f0}; {1:f0} )", classesData[i][0], classesData[i][1]), classesData[i][2], String.Format("{0:f4}", classesData[i][3]));
                }
                else
                {
                    gridClass.Rows.Add(i + 1, String.Format("[ {0:f0}; {1:f0} ]", classesData[i][0], classesData[i][1]), classesData[i][2], String.Format("{0:f4}", classesData[i][3]));
                }
            }
        }

        public void ViewHistogram(List<double[]> xy, bool generator = false)
        {
            Chart chart;
            if (generator == false)
            {
                chart = (Chart)fileChart;
            }
            else
            {
                chart = (Chart)genChart;
            }
            chart.Series.Clear();
            chart.Series.Add("Histogram");
            chart.ChartAreas[0].AxisX.Title = "Classes";
            chart.ChartAreas[0].AxisY.Title = "Frequency";
            for (int i = 0; i < xy.Count; i++)
            {
                chart.Series[0].Points.AddXY(i + 1, xy[i][3]);
            }
        }

        public string GetDistribution()
        {
            return distribution;
        }

        public int GetQuantityRandValue()
        {
            return (int)numOfRequests.Value;
        }

        public void CreateRandTable(double[] randomData)
        {
            gridRandom.Columns.Clear();
            gridRandom.Columns.Add("ResponseTime", "Response time");
            foreach(double i in randomData)
            {
                gridRandom.Rows.Add(String.Format("{0:f4}", i));
            }
        }

        public void ShowResult(List<string[]> resultWorkSystem)
        {
            gridResult.Columns.Clear();
            //gridResult.Columns.Add("Iter", "№");
            //gridResult.Columns["Iter"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            gridResult.Columns.Add("arrTime", "Arrival time");
            gridResult.Columns.Add("resTime", "Response time");
            gridResult.Columns.Add("start", "Server1.Start");
            gridResult.Columns.Add("end", "Server1.End");
            gridResult.Columns.Add("waitTime", "Waiting time");
            gridResult.Columns.Add("exeS", "Execution status");
            for(int i = 0; i < resultWorkSystem.Count; i++)
            {
                gridResult.Rows.Add(resultWorkSystem[i]);
                if((string)gridResult.Rows[i].Cells["exes"].Value == "+")
                {
                    gridResult.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
                else
                {
                    gridResult.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
            tabProgram.SelectedIndex = 2;
        }

        #endregion

        #region < Event >

        public event EventHandler GetVariables;
        public event EventHandler GetDataParse;
        public event EventHandler StartDraw;
        public event EventHandler Generate;
        public event EventHandler SimulationSystem;

        #endregion

        #region < Interection >

        private void button1_Click(object sender, EventArgs e)
        {
            GetDataParse.Invoke(sender, e);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FirstState();
            GetVariables.Invoke(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartDraw.Invoke(sender, e);
        }

        private void CustomClassRB_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if(rb == radioButton1)
            {
                numClasses.Enabled = true;
            }
            else
            {
                numClasses.Enabled = false;
            }
        }

        private void byHand_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb == byHand)
            {
                rangeGeneraton.Enabled = true;
            }
            else
            {
                rangeGeneraton.Enabled = false;
            }
        }

        private void CustomGeneratorRB_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if(rb != null)
            {
                distribution = rb.Name;
            }
        }

        private void numMinResponse_ValueChanged(object sender, EventArgs e)
        {
            numMaxResponse.Minimum = numMinResponse.Value + (decimal)0.1;
        }

        private void numMinQueue_ValueChanged(object sender, EventArgs e)
        {
            numMaxQueue.Minimum = numMinQueue.Value + (decimal)0.1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Generate.Invoke(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SimulationSystem.Invoke(sender, e);
        }

        #endregion

        #region <Public method>

        public void ErrorMessage(string text)
        {
            MessageBox.Show(text);
        }

        #endregion

        
    }
}
