namespace stuff
{
    partial class fabrics
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Silk = new System.Windows.Forms.RadioButton();
            this.Cotton = new System.Windows.Forms.RadioButton();
            this.Polyester = new System.Windows.Forms.RadioButton();
            this.Linen = new System.Windows.Forms.RadioButton();
            this.Fleece = new System.Windows.Forms.RadioButton();
            this.Denim = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Denim);
            this.groupBox1.Controls.Add(this.Fleece);
            this.groupBox1.Controls.Add(this.Linen);
            this.groupBox1.Controls.Add(this.Polyester);
            this.groupBox1.Controls.Add(this.Cotton);
            this.groupBox1.Controls.Add(this.Silk);
            this.groupBox1.Location = new System.Drawing.Point(3, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 98);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Silk
            // 
            this.Silk.AutoSize = true;
            this.Silk.Location = new System.Drawing.Point(10, 20);
            this.Silk.Name = "Silk";
            this.Silk.Size = new System.Drawing.Size(42, 17);
            this.Silk.TabIndex = 0;
            this.Silk.TabStop = true;
            this.Silk.Text = "Silk";
            this.Silk.UseVisualStyleBackColor = true;
            // 
            // Cotton
            // 
            this.Cotton.AutoSize = true;
            this.Cotton.Location = new System.Drawing.Point(10, 43);
            this.Cotton.Name = "Cotton";
            this.Cotton.Size = new System.Drawing.Size(56, 17);
            this.Cotton.TabIndex = 1;
            this.Cotton.TabStop = true;
            this.Cotton.Text = "Cotton";
            this.Cotton.UseVisualStyleBackColor = true;
            this.Cotton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Polyester
            // 
            this.Polyester.AutoSize = true;
            this.Polyester.Location = new System.Drawing.Point(145, 66);
            this.Polyester.Name = "Polyester";
            this.Polyester.Size = new System.Drawing.Size(68, 17);
            this.Polyester.TabIndex = 2;
            this.Polyester.TabStop = true;
            this.Polyester.Text = "Polyester";
            this.Polyester.UseVisualStyleBackColor = true;
            // 
            // Linen
            // 
            this.Linen.AutoSize = true;
            this.Linen.Location = new System.Drawing.Point(145, 43);
            this.Linen.Name = "Linen";
            this.Linen.Size = new System.Drawing.Size(51, 17);
            this.Linen.TabIndex = 3;
            this.Linen.TabStop = true;
            this.Linen.Text = "Linen";
            this.Linen.UseVisualStyleBackColor = true;
            // 
            // Fleece
            // 
            this.Fleece.AutoSize = true;
            this.Fleece.Location = new System.Drawing.Point(145, 20);
            this.Fleece.Name = "Fleece";
            this.Fleece.Size = new System.Drawing.Size(57, 17);
            this.Fleece.TabIndex = 4;
            this.Fleece.TabStop = true;
            this.Fleece.Text = "Fleece";
            this.Fleece.UseVisualStyleBackColor = true;
            // 
            // Denim
            // 
            this.Denim.AutoSize = true;
            this.Denim.Location = new System.Drawing.Point(9, 66);
            this.Denim.Name = "Denim";
            this.Denim.Size = new System.Drawing.Size(55, 17);
            this.Denim.TabIndex = 5;
            this.Denim.TabStop = true;
            this.Denim.Text = "Denim";
            this.Denim.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Black",
            "White",
            "Blue",
            "Green",
            "Red",
            "Smaragdine"});
            this.comboBox1.Location = new System.Drawing.Point(13, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // fabrics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "fabrics";
            this.Text = "Enter your measurements!";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Denim;
        private System.Windows.Forms.RadioButton Fleece;
        private System.Windows.Forms.RadioButton Linen;
        private System.Windows.Forms.RadioButton Polyester;
        private System.Windows.Forms.RadioButton Cotton;
        private System.Windows.Forms.RadioButton Silk;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}