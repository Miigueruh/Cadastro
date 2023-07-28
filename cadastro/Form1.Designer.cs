namespace cadastro
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label9 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            valorFinal = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(444, 9);
            label1.Name = "label1";
            label1.Size = new Size(177, 21);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de produto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(51, 70);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 1;
            label2.Text = "Codigo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(51, 114);
            label3.Name = "label3";
            label3.Size = new Size(91, 21);
            label3.TabIndex = 2;
            label3.Text = "Descrição:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(51, 160);
            label4.Name = "label4";
            label4.Size = new Size(162, 21);
            label4.TabIndex = 3;
            label4.Text = "Preço de aquisição:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(51, 203);
            label5.Name = "label5";
            label5.Size = new Size(203, 21);
            label5.TabIndex = 4;
            label5.Text = "Porcentagem de venda:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(51, 250);
            label6.Name = "label6";
            label6.Size = new Size(135, 21);
            label6.TabIndex = 5;
            label6.Text = "Valor de venda:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(302, 181);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(256, 199);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(215, 155);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(141, 23);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(144, 112);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(212, 23);
            textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(144, 68);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(212, 23);
            textBox4.TabIndex = 14;
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(444, 247);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 16;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(546, 247);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 17;
            button2.Text = "Excluir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // valorFinal
            // 
            valorFinal.AutoSize = true;
            valorFinal.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            valorFinal.Location = new Point(256, 250);
            valorFinal.Name = "valorFinal";
            valorFinal.Size = new Size(53, 21);
            valorFinal.TabIndex = 18;
            valorFinal.Text = "lorem";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 508);
            Controls.Add(valorFinal);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label9;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Label valorFinal;
    }
}