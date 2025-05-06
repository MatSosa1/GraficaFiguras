namespace FigurasTarea.src.elipse
{
    partial class FormEllipse
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
            this.txtMajorAxis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMinorAxis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMajorAxis
            // 
            this.txtMajorAxis.Location = new System.Drawing.Point(153, 73);
            this.txtMajorAxis.Name = "txtMajorAxis";
            this.txtMajorAxis.Size = new System.Drawing.Size(148, 22);
            this.txtMajorAxis.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Radio Eje Mayor";
            // 
            // txtMinorAxis
            // 
            this.txtMinorAxis.Location = new System.Drawing.Point(153, 115);
            this.txtMinorAxis.Name = "txtMinorAxis";
            this.txtMinorAxis.Size = new System.Drawing.Size(148, 22);
            this.txtMinorAxis.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Radio Eje Menor";
            // 
            // FormEllipse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMinorAxis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMajorAxis);
            this.Name = "FormEllipse";
            this.Text = "FormEllipse";
            this.Controls.SetChildIndex(this.txtPerimeter, 0);
            this.Controls.SetChildIndex(this.txtArea, 0);
            this.Controls.SetChildIndex(this.txtMajorAxis, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtMinorAxis, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMajorAxis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMinorAxis;
        private System.Windows.Forms.Label label4;
    }
}