namespace crudexemplo
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
            textboBoxNome = new TextBox();
            textBoxSobrenome = new TextBox();
            textBoxCurso = new TextBox();
            textBoxAno = new TextBox();
            textBoxIdade = new TextBox();
            textBoxRM = new TextBox();
            buttonsalvar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 52);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 98);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 1;
            label2.Text = "Sobrenome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 148);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 2;
            label3.Text = "Curso:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 197);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 3;
            label4.Text = "Ano:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 244);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 4;
            label5.Text = "Idade:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 293);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 5;
            label6.Text = "RM:";
            label6.Click += label6_Click;
            // 
            // textboBoxNome
            // 
            textboBoxNome.BackColor = Color.Purple;
            textboBoxNome.Location = new Point(138, 52);
            textboBoxNome.Name = "textboBoxNome";
            textboBoxNome.Size = new Size(220, 23);
            textboBoxNome.TabIndex = 6;
            // 
            // textBoxSobrenome
            // 
            textBoxSobrenome.BackColor = Color.Purple;
            textBoxSobrenome.Location = new Point(138, 90);
            textBoxSobrenome.Name = "textBoxSobrenome";
            textBoxSobrenome.Size = new Size(220, 23);
            textBoxSobrenome.TabIndex = 7;
            // 
            // textBoxCurso
            // 
            textBoxCurso.BackColor = Color.Purple;
            textBoxCurso.Location = new Point(138, 140);
            textBoxCurso.Name = "textBoxCurso";
            textBoxCurso.Size = new Size(220, 23);
            textBoxCurso.TabIndex = 8;
            // 
            // textBoxAno
            // 
            textBoxAno.BackColor = Color.Purple;
            textBoxAno.Location = new Point(138, 189);
            textBoxAno.Name = "textBoxAno";
            textBoxAno.Size = new Size(220, 23);
            textBoxAno.TabIndex = 9;
            // 
            // textBoxIdade
            // 
            textBoxIdade.BackColor = Color.Purple;
            textBoxIdade.Location = new Point(138, 236);
            textBoxIdade.Name = "textBoxIdade";
            textBoxIdade.Size = new Size(220, 23);
            textBoxIdade.TabIndex = 10;
            // 
            // textBoxRM
            // 
            textBoxRM.BackColor = Color.Purple;
            textBoxRM.Location = new Point(138, 285);
            textBoxRM.Name = "textBoxRM";
            textBoxRM.Size = new Size(220, 23);
            textBoxRM.TabIndex = 11;
            // 
            // buttonsalvar
            // 
            buttonsalvar.BackColor = Color.Lavender;
            buttonsalvar.Location = new Point(175, 329);
            buttonsalvar.Name = "buttonsalvar";
            buttonsalvar.Size = new Size(139, 59);
            buttonsalvar.TabIndex = 12;
            buttonsalvar.Text = "Salvar";
            buttonsalvar.UseVisualStyleBackColor = false;
            buttonsalvar.Click += buttonsalvar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonsalvar);
            Controls.Add(textBoxRM);
            Controls.Add(textBoxIdade);
            Controls.Add(textBoxAno);
            Controls.Add(textBoxCurso);
            Controls.Add(textBoxSobrenome);
            Controls.Add(textboBoxNome);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.DarkSlateBlue;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            RightToLeftLayout = true;
            Text = "Form1";
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
        private TextBox textboBoxNome;
        private TextBox textBoxSobrenome;
        private TextBox textBoxCurso;
        private TextBox textBoxAno;
        private TextBox textBoxIdade;
        private TextBox textBoxRM;
        private Button buttonsalvar;
    }
}
