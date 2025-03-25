namespace RamosBPNN
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            inputA = new TextBox();
            inputB = new TextBox();
            outputX = new TextBox();
            createBtn = new Button();
            trainBtn = new Button();
            testBtn = new Button();
            inputC = new TextBox();
            inputD = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // inputA
            // 
            inputA.Font = new Font("Segoe UI", 15F);
            inputA.Location = new Point(152, 53);
            inputA.Name = "inputA";
            inputA.Size = new Size(125, 41);
            inputA.TabIndex = 0;
            // 
            // inputB
            // 
            inputB.Font = new Font("Segoe UI", 15F);
            inputB.Location = new Point(152, 122);
            inputB.Name = "inputB";
            inputB.Size = new Size(125, 41);
            inputB.TabIndex = 1;
            // 
            // outputX
            // 
            outputX.Font = new Font("Segoe UI", 15F);
            outputX.Location = new Point(361, 161);
            outputX.Name = "outputX";
            outputX.Size = new Size(288, 41);
            outputX.TabIndex = 2;
            // 
            // createBtn
            // 
            createBtn.Font = new Font("Segoe UI", 10F);
            createBtn.Location = new Point(152, 344);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(85, 65);
            createBtn.TabIndex = 3;
            createBtn.Text = "Create BPNN";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click;
            // 
            // trainBtn
            // 
            trainBtn.Font = new Font("Segoe UI", 10F);
            trainBtn.Location = new Point(361, 344);
            trainBtn.Name = "trainBtn";
            trainBtn.Size = new Size(85, 65);
            trainBtn.TabIndex = 4;
            trainBtn.Text = "Train BPNN";
            trainBtn.UseVisualStyleBackColor = true;
            trainBtn.Click += trainBtn_Click;
            // 
            // testBtn
            // 
            testBtn.Font = new Font("Segoe UI", 10F);
            testBtn.Location = new Point(564, 344);
            testBtn.Name = "testBtn";
            testBtn.Size = new Size(85, 65);
            testBtn.TabIndex = 5;
            testBtn.Text = "Test BPNN";
            testBtn.UseVisualStyleBackColor = true;
            testBtn.Click += testBtn_Click;
            // 
            // inputC
            // 
            inputC.Font = new Font("Segoe UI", 15F);
            inputC.Location = new Point(152, 196);
            inputC.Name = "inputC";
            inputC.Size = new Size(125, 41);
            inputC.TabIndex = 6;
            // 
            // inputD
            // 
            inputD.Font = new Font("Segoe UI", 15F);
            inputD.Location = new Point(152, 265);
            inputD.Name = "inputD";
            inputD.Size = new Size(125, 41);
            inputD.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(361, 91);
            label1.Name = "label1";
            label1.Size = new Size(208, 35);
            label1.TabIndex = 8;
            label1.Text = "AND OPERATION";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(inputD);
            Controls.Add(inputC);
            Controls.Add(testBtn);
            Controls.Add(trainBtn);
            Controls.Add(createBtn);
            Controls.Add(outputX);
            Controls.Add(inputB);
            Controls.Add(inputA);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputA;
        private TextBox inputB;
        private TextBox outputX;
        private Button createBtn;
        private Button trainBtn;
        private Button testBtn;
        private TextBox inputC;
        private TextBox inputD;
        private Label label1;
    }
}
