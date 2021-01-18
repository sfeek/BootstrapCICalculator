using System;
using System.Linq;
using System.Windows.Forms;

namespace Bootstrap_CI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            double[] AValues;
            int NAValues;
            double[] BValues;
            int NBValues;
            double cl;
            double[] CValues;

            int iterations;
            int l, u;
            double total;
            Random r = new Random();

            try
            {

                if (txtDataA.Text != String.Empty)
                {
                    AValues = CSVSplit(txtDataA.Text);
                    NAValues = AValues.Length;
                }
                else
                {
                    return;
                }

                if (txtDataB.Text != String.Empty)
                {
                    BValues = CSVSplit(txtDataB.Text);
                    NBValues = BValues.Length;
                }
                else
                {
                    return;
                }

                if (txtCL.Text != String.Empty)
                {
                    cl = Convert.ToDouble(txtCL.Text);

                    if (cl < 0.0 || cl > 100.0) return;
                }
                else
                {
                    return;
                }

                if (txtIterations.Text != String.Empty)
                {
                    iterations = Convert.ToInt32(txtIterations.Text);

                    if (iterations < 1 || iterations > 10000) return;

                    iterations *= 1000;
                }
                else
                {
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Invalid Field Error", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnCalculate.Text = "Calculating...";
            Application.DoEvents();
            
            double[] dmeans = new double[iterations];

            if (chkPaired.Checked == false)
            {
                double[] ameans = new double[iterations];
                double[] bmeans = new double[iterations];


                for (int i = 0; i < iterations; i++)
                {
                    total = 0.0;
                    for (int j = 0; j < NAValues; j++)
                    {
                        total += AValues[r.Next(0, NAValues)];
                    }
                    ameans[i] = total / NAValues;
                }

                for (int i = 0; i < iterations; i++)
                {
                    total = 0.0;
                    for (int j = 0; j < NBValues; j++)
                    {
                        total += BValues[r.Next(0, NBValues)];
                    }
                    bmeans[i] = total / NBValues;
                }

                for (int i = 0; i < iterations; i++)
                {
                    dmeans[i] = bmeans[i] - ameans[i];
                }
            }
            else
            {
                if (NAValues != NBValues)
                {
                    MessageBox.Show("Data Fields Must Have Same Count for Paired Data", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                CValues = new double[NAValues];

                for (int i=0; i < NAValues; i++) CValues[i] = BValues[i] - AValues[i];

                for (int i = 0; i < iterations; i++)
                {
                    total = 0.0;
                    for (int j = 0; j < NAValues; j++)
                    {
                        total += CValues[r.Next(0, NAValues)];
                    }
                    dmeans[i] = total / NAValues;
                }
            }

            Array.Sort(dmeans);

            double meanA = AValues.Average();
            double meanB = BValues.Average();

            if (rbTwo.Checked == true)
            {
                cl = (100.0 - cl) / 200.0;

                l = Convert.ToInt32(Math.Round(cl * iterations, 0));
                u = Convert.ToInt32(Math.Round((1.0 - cl) * iterations, 0));

                txtCILow.Text = String.Format("{0:G2}", dmeans[l]);
                txtMeanA.Text = String.Format("{0:G6}", meanA);
                txtMeanB.Text = String.Format("{0:G6}", meanB);
                txtMeanDiff.Text = String.Format("{0:G6}", (meanB - meanA));
                txtCIHigh.Text = String.Format("{0:G2}", dmeans[u]);

                if (dmeans[l] <= 0.0 && dmeans[u] >= 0.0)
                    lblNullH.Text = "H0 = True   A = B";
                else
                    lblNullH.Text = "H0 = False   A \u2260 B";
            }
            else
            {
                cl = (100.0 - cl) / 100.0; 

                if (meanA > meanB)
                {
                    u = Convert.ToInt32(Math.Round((1.0 - cl) * iterations, 0));

                    txtCILow.Text = String.Format("{0:G2}", double.NegativeInfinity);
                    txtMeanA.Text = String.Format("{0:G6}", meanA);
                    txtMeanB.Text = String.Format("{0:G6}", meanB);
                    txtMeanDiff.Text = String.Format("{0:G6}", (meanB - meanA));
                    txtCIHigh.Text = String.Format("{0:G2}", dmeans[u]);

                    if (dmeans[u] > 0.0)
                        lblNullH.Text = "H0 = True   A \u226F B";
                    else
                        lblNullH.Text = "H0 = False   A > B";

                    if (dmeans[u] == 0.0) lblNullH.Text = "H0 = True   A = B";

                }
                else
                {
                    l = Convert.ToInt32(Math.Round(cl * iterations, 0));

                    txtCILow.Text = String.Format("{0:G2}", dmeans[l]);
                    txtMeanA.Text = String.Format("{0:G6}", meanA);
                    txtMeanB.Text = String.Format("{0:G6}", meanB);
                    txtMeanDiff.Text = String.Format("{0:G6}", (meanB - meanA));
                    txtCIHigh.Text = String.Format("{0:G2}", double.PositiveInfinity);

                    if (dmeans[l] < 0.0)
                        lblNullH.Text = "H0 = True   A \u226E B";
                    else
                        lblNullH.Text = "H0 = False   A < B";

                    if (dmeans[l] == 0.0) lblNullH.Text = "H0 = True   A = B";
                }
            }
            btnCalculate.Text = "Calculate";
        }

        // Get CSV as string and split into array of numbers, return NULL if anything goes wrong
        double[] CSVSplit(string inp)
        {
            string[] fields;
            double[] values;
            int c = 0;

            try
            {
                fields = inp.Split(new[] { "\r\n", "\r", "\n", "," }, StringSplitOptions.RemoveEmptyEntries);
                values = new double[fields.Length];

                foreach (string s in fields)
                {
                    values[c++] = Convert.ToDouble(s);
                }
            }
            catch
            {
                return null;
            }

            return values;
        }
    }
}
