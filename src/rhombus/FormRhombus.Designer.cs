namespace FigurasTarea.src.rhombus
{
    partial class FormRhombus
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
            this.txtMajorDiag = new System.Windows.Forms.TextBox();
            this.txtMinorDiag = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMajorDiag
            // 
            this.txtMajorDiag.Location = new System.Drawing.Point(152, 73);
            this.txtMajorDiag.Name = "txtMajorDiag";
            this.txtMajorDiag.Size = new System.Drawing.Size(148, 22);
            this.txtMajorDiag.TabIndex = 7;
            // 
            // txtMinorDiag
            // 
            this.txtMinorDiag.Location = new System.Drawing.Point(152, 115);
            this.txtMinorDiag.Name = "txtMinorDiag";
            this.txtMinorDiag.Size = new System.Drawing.Size(148, 22);
            this.txtMinorDiag.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Diagonal Mayor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Diagonal Menor";
            // 
            // FormRhombus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMinorDiag);
            this.Controls.Add(this.txtMajorDiag);
            this.Name = "FormRhombus";
            this.Text = "FormRhombus";
            this.Controls.SetChildIndex(this.txtPerimeter, 0);
            this.Controls.SetChildIndex(this.txtArea, 0);
            this.Controls.SetChildIndex(this.txtMajorDiag, 0);
            this.Controls.SetChildIndex(this.txtMinorDiag, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMajorDiag;
        private System.Windows.Forms.TextBox txtMinorDiag;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}