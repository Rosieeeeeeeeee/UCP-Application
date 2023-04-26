namespace WindowsFormsApplication9
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTwoBtn = new System.Windows.Forms.Button();
            this.panelOneBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.twoOutput = new System.Windows.Forms.TextBox();
            this.oneOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelControl11 = new WindowsFormsApplication9.PanelControl1();
            this.panelControl21 = new WindowsFormsApplication9.PanelControl2();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelTwoBtn);
            this.panel1.Controls.Add(this.panelOneBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 354);
            this.panel1.TabIndex = 0;
            // 
            // panelTwoBtn
            // 
            this.panelTwoBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTwoBtn.Location = new System.Drawing.Point(21, 169);
            this.panelTwoBtn.Name = "panelTwoBtn";
            this.panelTwoBtn.Size = new System.Drawing.Size(119, 47);
            this.panelTwoBtn.TabIndex = 2;
            this.panelTwoBtn.Text = "Panel Two";
            this.panelTwoBtn.UseVisualStyleBackColor = true;
            this.panelTwoBtn.Click += new System.EventHandler(this.panelTwoBtn_Click);
            // 
            // panelOneBtn
            // 
            this.panelOneBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelOneBtn.Location = new System.Drawing.Point(21, 91);
            this.panelOneBtn.Name = "panelOneBtn";
            this.panelOneBtn.Size = new System.Drawing.Size(119, 47);
            this.panelOneBtn.TabIndex = 2;
            this.panelOneBtn.Text = "Panel One";
            this.panelOneBtn.UseVisualStyleBackColor = true;
            this.panelOneBtn.Click += new System.EventHandler(this.panelOneBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.twoOutput);
            this.panel2.Controls.Add(this.oneOutput);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(588, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 354);
            this.panel2.TabIndex = 1;
            // 
            // twoOutput
            // 
            this.twoOutput.Location = new System.Drawing.Point(19, 160);
            this.twoOutput.Name = "twoOutput";
            this.twoOutput.Size = new System.Drawing.Size(155, 20);
            this.twoOutput.TabIndex = 4;
            // 
            // oneOutput
            // 
            this.oneOutput.Location = new System.Drawing.Point(19, 91);
            this.oneOutput.Name = "oneOutput";
            this.oneOutput.Size = new System.Drawing.Size(155, 20);
            this.oneOutput.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Input Two:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Input One:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(165, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(338, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "User Control Panel Application";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelControl11
            // 
            this.panelControl11.BackColor = System.Drawing.Color.LightBlue;
            this.panelControl11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelControl11.Location = new System.Drawing.Point(181, 51);
            this.panelControl11.Name = "panelControl11";
            this.panelControl11.Size = new System.Drawing.Size(382, 291);
            this.panelControl11.TabIndex = 3;
            // 
            // panelControl21
            // 
            this.panelControl21.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelControl21.Location = new System.Drawing.Point(181, 51);
            this.panelControl21.Name = "panelControl21";
            this.panelControl21.Size = new System.Drawing.Size(382, 291);
            this.panelControl21.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 354);
            this.Controls.Add(this.panelControl21);
            this.Controls.Add(this.panelControl11);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button panelTwoBtn;
        private System.Windows.Forms.Button panelOneBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox twoOutput;
        private System.Windows.Forms.TextBox oneOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private PanelControl1 panelControl11;
        private PanelControl2 panelControl21;
    }
}

