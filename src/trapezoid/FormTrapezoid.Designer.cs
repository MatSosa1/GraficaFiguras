namespace FigurasTarea.src.trapezoid
{
    partial class FormTrapezoid
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
            this.txtDiag1 = new System.Windows.Forms.TextBox();
            this.txtDiag2 = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDiag1
            // 
            this.txtDiag1.Location = new System.Drawing.Point(154, 73);
            this.txtDiag1.Name = "txtDiag1";
            this.txtDiag1.Size = new System.Drawing.Size(148, 22);
            this.txtDiag1.TabIndex = 7;
            // 
            // txtDiag2
            // 
            this.txtDiag2.Location = new System.Drawing.Point(154, 115);
            this.txtDiag2.Name = "txtDiag2";
            this.txtDiag2.Size = new System.Drawing.Size(148, 22);
            this.txtDiag2.TabIndex = 8;
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(154, 22);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(148, 22);
            this.txtBase.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Base";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Diagonal 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Diagonal 2";
            // 
            // FormTrapezoid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.txtDiag2);
            this.Controls.Add(this.txtDiag1);
            this.Name = "FormTrapezoid";
            this.Text = "FormTrapezoid";
            this.Controls.SetChildIndex(this.txtPerimeter, 0);
            this.Controls.SetChildIndex(this.txtArea, 0);
            this.Controls.SetChildIndex(this.txtDiag1, 0);
            this.Controls.SetChildIndex(this.txtDiag2, 0);
            this.Controls.SetChildIndex(this.txtBase, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDiag1;
        private System.Windows.Forms.TextBox txtDiag2;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}