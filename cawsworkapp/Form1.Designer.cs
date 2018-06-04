namespace cawsworkapp
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
            this.task1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.task2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // task1
            // 
            this.task1.Location = new System.Drawing.Point(174, 88);
            this.task1.Name = "task1";
            this.task1.Size = new System.Drawing.Size(91, 40);
            this.task1.TabIndex = 0;
            this.task1.Text = "Task1";
            this.task1.UseVisualStyleBackColor = true;
            this.task1.Click += new System.EventHandler(this.task1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 7;
            // 
            // task2
            // 
            this.task2.Location = new System.Drawing.Point(539, 88);
            this.task2.Name = "task2";
            this.task2.Size = new System.Drawing.Size(91, 40);
            this.task2.TabIndex = 8;
            this.task2.Text = "Task2";
            this.task2.UseVisualStyleBackColor = true;
            this.task2.Click += new System.EventHandler(this.task2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.task2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.task1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button task1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button task2;
    }
}

