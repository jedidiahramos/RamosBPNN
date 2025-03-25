using Backprop;

namespace RamosBPNN
{
    public partial class Form1 : Form
    {
        NeuralNet nn;
        public Form1()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            nn = new NeuralNet(4, 1, 1);
        }

        private void trainBtn_Click(object sender, EventArgs e)
        {
            createBtn.Enabled = false;
            trainBtn.Enabled = false;
            testBtn.Enabled = false;
            for (int i = 0; i < 1500; i++)
            {
                operationAND();
            }
            createBtn.Enabled = true;
            trainBtn.Enabled = true;
            testBtn.Enabled = true;
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            nn.setInputs(0, Convert.ToDouble(inputA.Text));
            nn.setInputs(1, Convert.ToDouble(inputB.Text));
            nn.setInputs(2, Convert.ToDouble(inputC.Text));
            nn.setInputs(3, Convert.ToDouble(inputD.Text));
            nn.run();
            outputX.Text = "" + nn.getOuputData(0);
        }

        private void operationAND()
        {
            // 0
            nn.setInputs(0, 0.0);
            nn.setInputs(1, 0.0);
            nn.setInputs(2, 0.0);
            nn.setInputs(3, 0.0);
            nn.setDesiredOutput(0, 0.0);
            nn.learn();
            // 1
            nn.setInputs(0, 1.0);
            nn.setInputs(1, 0.0);
            nn.setInputs(2, 0.0);
            nn.setInputs(3, 0.0);
            nn.setDesiredOutput(0, 0.0);
            nn.learn();
            // 2
            nn.setInputs(0, 0.0);
            nn.setInputs(1, 1.0);
            nn.setInputs(2, 0.0);
            nn.setInputs(3, 0.0);
            nn.setDesiredOutput(0, 0.0);
            nn.learn();
            // 3
            nn.setInputs(0, 1.0);
            nn.setInputs(1, 1.0);
            nn.setInputs(2, 0.0);
            nn.setInputs(3, 0.0);
            nn.setDesiredOutput(0, 0.0);
            nn.learn();
            // 4
            nn.setInputs(0, 0.0);
            nn.setInputs(1, 0.0);
            nn.setInputs(2, 1.0);
            nn.setInputs(3, 0.0);
            nn.setDesiredOutput(0, 0.0);
            nn.learn();
            // 5
            nn.setInputs(0, 1.0);
            nn.setInputs(1, 0.0);
            nn.setInputs(2, 1.0);
            nn.setInputs(3, 0.0);
            nn.setDesiredOutput(0, 0.0);
            nn.learn();
            // 6
            nn.setInputs(0, 0.0);
            nn.setInputs(1, 1.0);
            nn.setInputs(2, 1.0);
            nn.setInputs(3, 0.0);
            nn.setDesiredOutput(0, 0.0);
            nn.learn();
            // 7
            nn.setInputs(0, 1.0);
            nn.setInputs(1, 1.0);
            nn.setInputs(2, 1.0);
            nn.setInputs(3, 0.0);
            nn.setDesiredOutput(0, 0.0);
            nn.learn();
            // 8
            nn.setInputs(0, 0.0);
            nn.setInputs(1, 0.0);
            nn.setInputs(2, 0.0);
            nn.setInputs(3, 1.0);
            nn.setDesiredOutput(0, 0.0);
            nn.learn();
            // 9
            nn.setInputs(0, 1.0);
            nn.setInputs(1, 0.0);
            nn.setInputs(2, 0.0);
            nn.setInputs(3, 1.0);
            nn.setDesiredOutput(0, 0.0);
            nn.learn();
            // 10
            nn.setInputs(0, 0.0);
            nn.setInputs(1, 1.0);
            nn.setInputs(2, 0.0);
            nn.setInputs(3, 1.0);
            nn.setDesiredOutput(0, 0.0);
            nn.learn();
            // 11
            nn.setInputs(0, 1.0);
            nn.setInputs(1, 1.0);
            nn.setInputs(2, 0.0);
            nn.setInputs(3, 1.0);
            nn.setDesiredOutput(0, 0.0);
            nn.learn();
            // 12
            nn.setInputs(0, 0.0);
            nn.setInputs(1, 0.0);
            nn.setInputs(2, 1.0);
            nn.setInputs(3, 1.0);
            nn.setDesiredOutput(0, 0.0);
            nn.learn();
            // 13
            nn.setInputs(0, 1.0);
            nn.setInputs(1, 0.0);
            nn.setInputs(2, 1.0);
            nn.setInputs(3, 1.0);
            nn.setDesiredOutput(0, 0.0);
            nn.learn();
            // 14
            nn.setInputs(0, 0.0);
            nn.setInputs(1, 1.0);
            nn.setInputs(2, 1.0);
            nn.setInputs(3, 1.0);
            nn.setDesiredOutput(0, 0.0);
            nn.learn();
            // 15
            nn.setInputs(0, 1.0);
            nn.setInputs(1, 1.0);
            nn.setInputs(2, 1.0);
            nn.setInputs(3, 1.0);
            nn.setDesiredOutput(0, 1.0);
            nn.learn();
        }

        private void operationOR()
        {
            nn.setInputs(0, 0.0);
            nn.setInputs(1, 0.0);
            nn.setDesiredOutput(0, 0.0);
            nn.learn();

            nn.setInputs(0, 0.0);
            nn.setInputs(1, 1.0);
            nn.setDesiredOutput(0, 1.0);
            nn.learn();

            nn.setInputs(0, 1.0);
            nn.setInputs(1, 0.0);
            nn.setDesiredOutput(0, 1.0);
            nn.learn();

            nn.setInputs(0, 1.0);
            nn.setInputs(1, 1.0);
            nn.setDesiredOutput(0, 1.0);
            nn.learn();
        }
    }
}
