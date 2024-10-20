namespace Linkedin_Searcher_UI
{
    partial class Main
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
            label1 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            label6 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            label5 = new Label();
            label7 = new Label();
            button2 = new Button();
            label8 = new Label();
            button3 = new Button();
            numericUpDown1 = new NumericUpDown();
            label9 = new Label();
            label10 = new Label();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(378, 35);
            label1.TabIndex = 0;
            label1.Text = "OLÁ, EU SOU O HUNTER ROBOT!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 95);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "E-mail";
            textBox1.Size = new Size(166, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 40);
            label3.Name = "label3";
            label3.Size = new Size(378, 42);
            label3.TabIndex = 3;
            label3.Text = "Para começar, digite os dados de login da conta do Linkedin que deseja usar na busca\r\n";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Enabled = false;
            label4.Location = new Point(12, 82);
            label4.Name = "label4";
            label4.Size = new Size(378, 1);
            label4.TabIndex = 4;
            label4.Click += label4_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(224, 95);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "Senha";
            textBox2.Size = new Size(166, 23);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(157, 124);
            button1.Name = "button1";
            button1.Size = new Size(80, 23);
            button1.TabIndex = 7;
            button1.Text = "CONFIRMAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Enabled = false;
            label6.Location = new Point(12, 154);
            label6.Name = "label6";
            label6.Size = new Size(378, 1);
            label6.TabIndex = 8;
            label6.Text = "label6";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 253);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(294, 23);
            textBox3.TabIndex = 9;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 164);
            label2.Name = "label2";
            label2.Size = new Size(378, 39);
            label2.TabIndex = 10;
            label2.Text = "Agora, digite os termos de pesquisa que você quer nos perfis e em quantas páginas você quer buscar";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Enabled = false;
            label5.Location = new Point(12, 311);
            label5.Name = "label5";
            label5.Size = new Size(378, 1);
            label5.TabIndex = 11;
            label5.Text = "label5";
            label5.Click += label5_Click;
            // 
            // label7
            // 
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 323);
            label7.Name = "label7";
            label7.Size = new Size(378, 23);
            label7.TabIndex = 12;
            label7.Text = "Confirme se o Linkedin carregou a página de feed";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(157, 349);
            button2.Name = "button2";
            button2.Size = new Size(80, 23);
            button2.TabIndex = 13;
            button2.Text = "CONFIRMAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.Enabled = false;
            label8.Location = new Point(12, 375);
            label8.Name = "label8";
            label8.Size = new Size(378, 1);
            label8.TabIndex = 14;
            label8.Text = "label8";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(157, 282);
            button3.Name = "button3";
            button3.Size = new Size(80, 23);
            button3.TabIndex = 15;
            button3.Text = "CONFIRMAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(312, 254);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(78, 23);
            numericUpDown1.TabIndex = 16;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label9
            // 
            label9.Location = new Point(81, 212);
            label9.Name = "label9";
            label9.Size = new Size(250, 31);
            label9.TabIndex = 17;
            label9.Text = "OBS: Quanto mais páginas selecionadas, mais tempo o programa levará para ser concluído";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.Location = new Point(12, 431);
            label10.Name = "label10";
            label10.Size = new Size(378, 50);
            label10.TabIndex = 18;
            label10.TextAlign = ContentAlignment.MiddleCenter;
            label10.Click += label10_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 393);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(378, 23);
            progressBar1.TabIndex = 19;
            progressBar1.Click += progressBar1_Click_1;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 507);
            Controls.Add(progressBar1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(numericUpDown1);
            Controls.Add(button3);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            MaximumSize = new Size(418, 546);
            MinimumSize = new Size(418, 546);
            Name = "Main";
            Text = "Hunter Robot";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private Button button1;
        private Label label6;
        private TextBox textBox3;
        private Label label2;
        private Label label5;
        private Label label7;
        private Button button2;
        private Label label8;
        private Button button3;
        private NumericUpDown numericUpDown1;
        private Label label9;
        private Label label10;
        private ProgressBar progressBar1;
    }
}
