namespace Questiion1
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
            this.rdoadd = new System.Windows.Forms.RadioButton();
            this.rdoMult = new System.Windows.Forms.RadioButton();
            this.rdoSub = new System.Windows.Forms.RadioButton();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdoadd
            // 
            this.rdoadd.AutoSize = true;
            this.rdoadd.Location = new System.Drawing.Point(41, 55);
            this.rdoadd.Name = "rdoadd";
            this.rdoadd.Size = new System.Drawing.Size(88, 17);
            this.rdoadd.TabIndex = 0;
            this.rdoadd.TabStop = true;
            this.rdoadd.Text = "I want to Add";
            this.rdoadd.UseVisualStyleBackColor = true;
            this.rdoadd.CheckedChanged += new System.EventHandler(this.rdoadd_CheckedChanged);
            // 
            // rdoMult
            // 
            this.rdoMult.AutoSize = true;
            this.rdoMult.Location = new System.Drawing.Point(41, 129);
            this.rdoMult.Name = "rdoMult";
            this.rdoMult.Size = new System.Drawing.Size(104, 17);
            this.rdoMult.TabIndex = 1;
            this.rdoMult.TabStop = true;
            this.rdoMult.Text = "I want to Multiply";
            this.rdoMult.UseVisualStyleBackColor = true;
            this.rdoMult.CheckedChanged += new System.EventHandler(this.rdoMult_CheckedChanged);
            // 
            // rdoSub
            // 
            this.rdoSub.AutoSize = true;
            this.rdoSub.Location = new System.Drawing.Point(41, 96);
            this.rdoSub.Name = "rdoSub";
            this.rdoSub.Size = new System.Drawing.Size(109, 17);
            this.rdoSub.TabIndex = 2;
            this.rdoSub.TabStop = true;
            this.rdoSub.Text = "I want to Subtract";
            this.rdoSub.UseVisualStyleBackColor = true;
            this.rdoSub.CheckedChanged += new System.EventHandler(this.rdoSub_CheckedChanged);
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(142, 174);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(100, 20);
            this.txtFirst.TabIndex = 3;
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(142, 212);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(100, 20);
            this.txtSecond.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Number ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Second Number ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Subtract";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(232, 277);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Multiply";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 355);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.rdoSub);
            this.Controls.Add(this.rdoMult);
            this.Controls.Add(this.rdoadd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoadd;
        private System.Windows.Forms.RadioButton rdoMult;
        private System.Windows.Forms.RadioButton rdoSub;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

