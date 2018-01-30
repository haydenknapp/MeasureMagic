namespace stuff
{
    partial class Dimensions
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
            this.Dimensions_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.waibox = new System.Windows.Forms.NumericUpDown();
            this.shrbox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.bicbox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.chestbox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.seambox = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.neckbox = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.shobox = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.slebox = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.waibox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shrbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bicbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chestbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seambox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neckbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shobox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slebox)).BeginInit();
            this.SuspendLayout();
            // 
            // Dimensions_button
            // 
            this.Dimensions_button.Location = new System.Drawing.Point(183, 241);
            this.Dimensions_button.Name = "Dimensions_button";
            this.Dimensions_button.Size = new System.Drawing.Size(75, 23);
            this.Dimensions_button.TabIndex = 0;
            this.Dimensions_button.Text = "Next";
            this.Dimensions_button.UseVisualStyleBackColor = true;
            this.Dimensions_button.Click += new System.EventHandler(this.Dimensions_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Waist Around";
            // 
            // waibox
            // 
            this.waibox.Location = new System.Drawing.Point(152, 96);
            this.waibox.Name = "waibox";
            this.waibox.Size = new System.Drawing.Size(120, 20);
            this.waibox.TabIndex = 3;
            this.waibox.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // shrbox
            // 
            this.shrbox.Location = new System.Drawing.Point(152, 122);
            this.shrbox.Name = "shrbox";
            this.shrbox.Size = new System.Drawing.Size(120, 20);
            this.shrbox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chest Circumference";
            // 
            // bicbox
            // 
            this.bicbox.Location = new System.Drawing.Point(152, 148);
            this.bicbox.Name = "bicbox";
            this.bicbox.Size = new System.Drawing.Size(120, 20);
            this.bicbox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bicep Circumference";
            // 
            // chestbox
            // 
            this.chestbox.Location = new System.Drawing.Point(152, 174);
            this.chestbox.Name = "chestbox";
            this.chestbox.Size = new System.Drawing.Size(120, 20);
            this.chestbox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Shirt Length";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // seambox
            // 
            this.seambox.Location = new System.Drawing.Point(152, 200);
            this.seambox.Name = "seambox";
            this.seambox.Size = new System.Drawing.Size(120, 20);
            this.seambox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Seam Allowance";
            // 
            // neckbox
            // 
            this.neckbox.Location = new System.Drawing.Point(152, 19);
            this.neckbox.Name = "neckbox";
            this.neckbox.Size = new System.Drawing.Size(120, 20);
            this.neckbox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Neck Circumference";
            // 
            // shobox
            // 
            this.shobox.Location = new System.Drawing.Point(152, 44);
            this.shobox.Name = "shobox";
            this.shobox.Size = new System.Drawing.Size(120, 20);
            this.shobox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Shoulder Width";
            // 
            // slebox
            // 
            this.slebox.Location = new System.Drawing.Point(152, 70);
            this.slebox.Name = "slebox";
            this.slebox.Size = new System.Drawing.Size(120, 20);
            this.slebox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Sleeve Length";
            // 
            // Dimensions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 274);
            this.Controls.Add(this.slebox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.shobox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.neckbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.seambox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chestbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bicbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.shrbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.waibox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dimensions_button);
            this.Name = "Dimensions";
            this.Text = "Enter your measurements!";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.waibox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shrbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bicbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chestbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seambox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neckbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shobox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Dimensions_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown waibox;
        private System.Windows.Forms.NumericUpDown shrbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown bicbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown chestbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown seambox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown neckbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown shobox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown slebox;
        private System.Windows.Forms.Label label8;
    }
}

