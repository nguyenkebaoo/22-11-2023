
namespace WindowsFormsApp1
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.radioBtnOption1 = new System.Windows.Forms.RadioButton();
            this.radioBtnOption2 = new System.Windows.Forms.RadioButton();
            this.radioBtnOption3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(148, 77);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(46, 17);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "label1";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQuestion.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(492, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioBtnOption1
            // 
            this.radioBtnOption1.AutoSize = true;
            this.radioBtnOption1.Location = new System.Drawing.Point(84, 157);
            this.radioBtnOption1.Name = "radioBtnOption1";
            this.radioBtnOption1.Size = new System.Drawing.Size(110, 21);
            this.radioBtnOption1.TabIndex = 6;
            this.radioBtnOption1.TabStop = true;
            this.radioBtnOption1.Text = "radioButton1";
            this.radioBtnOption1.UseVisualStyleBackColor = true;
            // 
            // radioBtnOption2
            // 
            this.radioBtnOption2.AutoSize = true;
            this.radioBtnOption2.Location = new System.Drawing.Point(270, 157);
            this.radioBtnOption2.Name = "radioBtnOption2";
            this.radioBtnOption2.Size = new System.Drawing.Size(110, 21);
            this.radioBtnOption2.TabIndex = 7;
            this.radioBtnOption2.TabStop = true;
            this.radioBtnOption2.Text = "radioButton2";
            this.radioBtnOption2.UseVisualStyleBackColor = true;
            // 
            // radioBtnOption3
            // 
            this.radioBtnOption3.AutoSize = true;
            this.radioBtnOption3.Location = new System.Drawing.Point(447, 157);
            this.radioBtnOption3.Name = "radioBtnOption3";
            this.radioBtnOption3.Size = new System.Drawing.Size(110, 21);
            this.radioBtnOption3.TabIndex = 8;
            this.radioBtnOption3.TabStop = true;
            this.radioBtnOption3.Text = "radioButton3";
            this.radioBtnOption3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 378);
            this.Controls.Add(this.radioBtnOption3);
            this.Controls.Add(this.radioBtnOption2);
            this.Controls.Add(this.radioBtnOption1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblQuestion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioBtnOption1;
        private System.Windows.Forms.RadioButton radioBtnOption2;
        private System.Windows.Forms.RadioButton radioBtnOption3;
    }
}

