﻿
namespace formsEx03lista11
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
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.txtPeca = new System.Windows.Forms.TextBox();
            this.txtPrecoUnitario = new System.Windows.Forms.TextBox();
            this.btnComissao = new System.Windows.Forms.Button();
            this.txtComissao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQtdVendida = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vendedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cód. Peça";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Preço unitário";
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(196, 42);
            this.txtVendedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(91, 31);
            this.txtVendedor.TabIndex = 3;
            this.txtVendedor.TextChanged += new System.EventHandler(this.txtVendedor_TextChanged);
            // 
            // txtPeca
            // 
            this.txtPeca.Location = new System.Drawing.Point(196, 92);
            this.txtPeca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPeca.Name = "txtPeca";
            this.txtPeca.Size = new System.Drawing.Size(91, 31);
            this.txtPeca.TabIndex = 4;
            this.txtPeca.TextChanged += new System.EventHandler(this.txtPeca_TextChanged);
            // 
            // txtPrecoUnitario
            // 
            this.txtPrecoUnitario.Location = new System.Drawing.Point(196, 144);
            this.txtPrecoUnitario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecoUnitario.Name = "txtPrecoUnitario";
            this.txtPrecoUnitario.Size = new System.Drawing.Size(91, 31);
            this.txtPrecoUnitario.TabIndex = 5;
            this.txtPrecoUnitario.TextChanged += new System.EventHandler(this.txtPrecoUnitario_TextChanged);
            // 
            // btnComissao
            // 
            this.btnComissao.Location = new System.Drawing.Point(17, 253);
            this.btnComissao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnComissao.Name = "btnComissao";
            this.btnComissao.Size = new System.Drawing.Size(249, 38);
            this.btnComissao.TabIndex = 7;
            this.btnComissao.Text = "Registrar Comissão";
            this.btnComissao.UseVisualStyleBackColor = true;
            this.btnComissao.Click += new System.EventHandler(this.btnComissao_Click);
            // 
            // txtComissao
            // 
            this.txtComissao.Enabled = false;
            this.txtComissao.Location = new System.Drawing.Point(196, 301);
            this.txtComissao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtComissao.Name = "txtComissao";
            this.txtComissao.ReadOnly = true;
            this.txtComissao.Size = new System.Drawing.Size(91, 31);
            this.txtComissao.TabIndex = 7;
            this.txtComissao.TextChanged += new System.EventHandler(this.txtComissao_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 307);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor Comissão R$";
            // 
            // txtQtdVendida
            // 
            this.txtQtdVendida.Location = new System.Drawing.Point(196, 204);
            this.txtQtdVendida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQtdVendida.Name = "txtQtdVendida";
            this.txtQtdVendida.Size = new System.Drawing.Size(91, 31);
            this.txtQtdVendida.TabIndex = 6;
            this.txtQtdVendida.TextChanged += new System.EventHandler(this.txtQtdVendida_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Qtd vendida";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 388);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQtdVendida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtComissao);
            this.Controls.Add(this.btnComissao);
            this.Controls.Add(this.txtPrecoUnitario);
            this.Controls.Add(this.txtPeca);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Valor Comissão";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.TextBox txtPeca;
        private System.Windows.Forms.TextBox txtPrecoUnitario;
        private System.Windows.Forms.Button btnComissao;
        private System.Windows.Forms.TextBox txtComissao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQtdVendida;
        private System.Windows.Forms.Label label5;
    }
}

