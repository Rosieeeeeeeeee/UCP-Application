namespace WindowsFormsApplication9
{
    partial class PanelControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.twoOutput = new System.Windows.Forms.TextBox();
            this.oneOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 30);
            this.label1.TabIndex = 20;
            this.label1.Text = "Panel Two!";
            // 
            // twoOutput
            // 
            this.twoOutput.Location = new System.Drawing.Point(38, 156);
            this.twoOutput.Name = "twoOutput";
            this.twoOutput.Size = new System.Drawing.Size(155, 20);
            this.twoOutput.TabIndex = 19;
            // 
            // oneOutput
            // 
            this.oneOutput.Location = new System.Drawing.Point(38, 102);
            this.oneOutput.Name = "oneOutput";
            this.oneOutput.Size = new System.Drawing.Size(155, 20);
            this.oneOutput.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Input Two:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Input One:";
            // 
            // PanelControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.twoOutput);
            this.Controls.Add(this.oneOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "PanelControl2";
            this.Size = new System.Drawing.Size(309, 282);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox twoOutput;
        private System.Windows.Forms.TextBox oneOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
