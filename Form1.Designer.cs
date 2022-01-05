namespace Calculadora
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
            this.btnSomar = new System.Windows.Forms.Button();
            this.txtV1 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtV2 = new System.Windows.Forms.TextBox();
            this.btnDividir = new System.Windows.Forms.Button();
            this.bntSubtrair = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSomar
            // 
            this.btnSomar.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSomar.Location = new System.Drawing.Point(12, 127);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(70, 62);
            this.btnSomar.TabIndex = 0;
            this.btnSomar.Text = "+";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.operacao_click);
            // 
            // txtV1
            // 
            this.txtV1.Location = new System.Drawing.Point(12, 22);
            this.txtV1.Name = "txtV1";
            this.txtV1.Size = new System.Drawing.Size(150, 31);
            this.txtV1.TabIndex = 1;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(183, 22);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(138, 38);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Resultado";
            // 
            // txtV2
            // 
            this.txtV2.Location = new System.Drawing.Point(12, 72);
            this.txtV2.Name = "txtV2";
            this.txtV2.Size = new System.Drawing.Size(150, 31);
            this.txtV2.TabIndex = 3;
            // 
            // btnDividir
            // 
            this.btnDividir.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDividir.Location = new System.Drawing.Point(92, 195);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(70, 62);
            this.btnDividir.TabIndex = 4;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.operacao_click);
            // 
            // bntSubtrair
            // 
            this.bntSubtrair.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bntSubtrair.Location = new System.Drawing.Point(92, 127);
            this.bntSubtrair.Name = "bntSubtrair";
            this.bntSubtrair.Size = new System.Drawing.Size(70, 62);
            this.bntSubtrair.TabIndex = 5;
            this.bntSubtrair.Text = "-";
            this.bntSubtrair.UseVisualStyleBackColor = true;
            this.bntSubtrair.Click += new System.EventHandler(this.operacao_click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMultiplicar.Location = new System.Drawing.Point(12, 195);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(70, 62);
            this.btnMultiplicar.TabIndex = 6;
            this.btnMultiplicar.Text = "x";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.operacao_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 284);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.bntSubtrair);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.txtV2);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtV1);
            this.Controls.Add(this.btnSomar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSomar;
        private TextBox txtV1;
        private Label lblResultado;
        private TextBox txtV2;
        private Button btnDividir;
        private Button bntSubtrair;
        private Button btnMultiplicar;
    }
}