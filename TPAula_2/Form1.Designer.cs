namespace TPAula_2
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Celsiuu = new System.Windows.Forms.TextBox();
            this.Faremheit = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.opcoes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Graus para Converter";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Graus Convertido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Conversão de Graus";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Celsiuu
            // 
            this.Celsiuu.Location = new System.Drawing.Point(494, 110);
            this.Celsiuu.Name = "Celsiuu";
            this.Celsiuu.Size = new System.Drawing.Size(100, 20);
            this.Celsiuu.TabIndex = 3;
            // 
            // Faremheit
            // 
            this.Faremheit.Location = new System.Drawing.Point(494, 217);
            this.Faremheit.Name = "Faremheit";
            this.Faremheit.Size = new System.Drawing.Size(100, 20);
            this.Faremheit.TabIndex = 4;
            this.Faremheit.TextChanged += new System.EventHandler(this.Faremheit_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(494, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Converter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // opcoes
            // 
            this.opcoes.FormattingEnabled = true;
            this.opcoes.Items.AddRange(new object[] {
            "Celsius/Fahrenheit",
            "Fahrenheit/Celsius"});
            this.opcoes.Location = new System.Drawing.Point(105, 152);
            this.opcoes.Name = "opcoes";
            this.opcoes.Size = new System.Drawing.Size(121, 21);
            this.opcoes.TabIndex = 6;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(669, 353);
            this.Controls.Add(this.opcoes);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Faremheit);
            this.Controls.Add(this.Celsiuu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Celsius;
        private System.Windows.Forms.TextBox Fahrenheit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Celsiuu;
        private System.Windows.Forms.TextBox Faremheit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox opcoes;
    }
}

