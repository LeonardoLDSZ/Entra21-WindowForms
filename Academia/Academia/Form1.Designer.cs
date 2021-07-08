
namespace Academia
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAluno = new System.Windows.Forms.TextBox();
            this.txtTurma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.listBoxAlunos = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.maskedTextCpf = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextRg = new System.Windows.Forms.MaskedTextBox();
            this.checkBoxPago = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(49, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(49, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "RG";
            // 
            // txtAluno
            // 
            this.txtAluno.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAluno.Location = new System.Drawing.Point(138, 62);
            this.txtAluno.Name = "txtAluno";
            this.txtAluno.Size = new System.Drawing.Size(150, 31);
            this.txtAluno.TabIndex = 0;
            // 
            // txtTurma
            // 
            this.txtTurma.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTurma.Location = new System.Drawing.Point(138, 172);
            this.txtTurma.Name = "txtTurma";
            this.txtTurma.Size = new System.Drawing.Size(150, 31);
            this.txtTurma.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(39, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Turma";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.Location = new System.Drawing.Point(20, 256);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(112, 34);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeletar.Location = new System.Drawing.Point(20, 307);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(112, 34);
            this.btnDeletar.TabIndex = 7;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // listBoxAlunos
            // 
            this.listBoxAlunos.FormattingEnabled = true;
            this.listBoxAlunos.ItemHeight = 25;
            this.listBoxAlunos.Location = new System.Drawing.Point(306, 62);
            this.listBoxAlunos.Name = "listBoxAlunos";
            this.listBoxAlunos.Size = new System.Drawing.Size(482, 279);
            this.listBoxAlunos.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(306, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "CADASTRO ALUNOS";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlterar.Location = new System.Drawing.Point(176, 256);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(112, 34);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // maskedTextCpf
            // 
            this.maskedTextCpf.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maskedTextCpf.Location = new System.Drawing.Point(138, 98);
            this.maskedTextCpf.Mask = "000.000.000.00";
            this.maskedTextCpf.Name = "maskedTextCpf";
            this.maskedTextCpf.Size = new System.Drawing.Size(150, 31);
            this.maskedTextCpf.TabIndex = 1;
            // 
            // maskedTextRg
            // 
            this.maskedTextRg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maskedTextRg.Location = new System.Drawing.Point(138, 135);
            this.maskedTextRg.Mask = "0.000.000";
            this.maskedTextRg.Name = "maskedTextRg";
            this.maskedTextRg.Size = new System.Drawing.Size(150, 31);
            this.maskedTextRg.TabIndex = 2;
            // 
            // checkBoxPago
            // 
            this.checkBoxPago.AutoSize = true;
            this.checkBoxPago.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxPago.Location = new System.Drawing.Point(138, 209);
            this.checkBoxPago.Name = "checkBoxPago";
            this.checkBoxPago.Size = new System.Drawing.Size(81, 29);
            this.checkBoxPago.TabIndex = 4;
            this.checkBoxPago.Text = "Pago";
            this.checkBoxPago.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Mensalidade";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 356);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBoxPago);
            this.Controls.Add(this.maskedTextRg);
            this.Controls.Add(this.maskedTextCpf);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxAlunos);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtTurma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAluno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAluno;
        private System.Windows.Forms.TextBox txtTurma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.ListBox listBoxAlunos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.MaskedTextBox maskedTextCpf;
        private System.Windows.Forms.MaskedTextBox maskedTextRg;
        private System.Windows.Forms.CheckBox checkBoxPago;
        private System.Windows.Forms.Label label6;
    }
}

