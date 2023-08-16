namespace Temperaturas.windows
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
            celsiusText = new TextBox();
            label1 = new Label();
            calcularButton = new Button();
            label2 = new Label();
            ContadorLabel = new Label();
            SuspendLayout();
            // 
            // celsiusText
            // 
            celsiusText.Location = new Point(49, 43);
            celsiusText.Name = "celsiusText";
            celsiusText.Size = new Size(100, 23);
            celsiusText.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 25);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "Celsius";
            // 
            // calcularButton
            // 
            calcularButton.Location = new Point(64, 94);
            calcularButton.Name = "calcularButton";
            calcularButton.Size = new Size(75, 23);
            calcularButton.TabIndex = 2;
            calcularButton.Text = "calcular";
            calcularButton.UseVisualStyleBackColor = true;
            calcularButton.Click += calcularButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 177);
            label2.Name = "label2";
            label2.Size = new Size(145, 15);
            label2.TabIndex = 3;
            label2.Text = "cantidad de temperaturas:";
            // 
            // ContadorLabel
            // 
            ContadorLabel.AutoSize = true;
            ContadorLabel.Location = new Point(175, 177);
            ContadorLabel.Name = "ContadorLabel";
            ContadorLabel.Size = new Size(13, 15);
            ContadorLabel.TabIndex = 4;
            ContadorLabel.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 229);
            Controls.Add(ContadorLabel);
            Controls.Add(label2);
            Controls.Add(calcularButton);
            Controls.Add(label1);
            Controls.Add(celsiusText);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox celsiusText;
        private Label label1;
        private Button calcularButton;
        private Label label2;
        private Label ContadorLabel;
    }
}