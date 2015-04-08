namespace Project3
{
    partial class frmConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConverter));
            this.btnConvertFromDecimal = new System.Windows.Forms.Button();
            this.btnConvertToDecimal = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblConvertedText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudResultPlaces = new System.Windows.Forms.NumericUpDown();
            this.nudBase = new System.Windows.Forms.NumericUpDown();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.txtConverted = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudResultPlaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBase)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConvertFromDecimal
            // 
            this.btnConvertFromDecimal.Location = new System.Drawing.Point(41, 166);
            this.btnConvertFromDecimal.Name = "btnConvertFromDecimal";
            this.btnConvertFromDecimal.Size = new System.Drawing.Size(137, 34);
            this.btnConvertFromDecimal.TabIndex = 0;
            this.btnConvertFromDecimal.Text = "Convert From Decimal";
            this.btnConvertFromDecimal.UseVisualStyleBackColor = true;
            this.btnConvertFromDecimal.Click += new System.EventHandler(this.btnConvertFromDecimal_Click);
            // 
            // btnConvertToDecimal
            // 
            this.btnConvertToDecimal.Location = new System.Drawing.Point(196, 166);
            this.btnConvertToDecimal.Name = "btnConvertToDecimal";
            this.btnConvertToDecimal.Size = new System.Drawing.Size(137, 34);
            this.btnConvertToDecimal.TabIndex = 1;
            this.btnConvertToDecimal.Text = "Convert To Decimal";
            this.btnConvertToDecimal.UseVisualStyleBackColor = true;
            this.btnConvertToDecimal.Click += new System.EventHandler(this.btnConvertToDecimal_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(485, 157);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 43);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblConvertedText
            // 
            this.lblConvertedText.AutoSize = true;
            this.lblConvertedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblConvertedText.Location = new System.Drawing.Point(287, 42);
            this.lblConvertedText.Name = "lblConvertedText";
            this.lblConvertedText.Size = new System.Drawing.Size(189, 17);
            this.lblConvertedText.TabIndex = 3;
            this.lblConvertedText.Text = "Converted Integer Value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label2.Location = new System.Drawing.Point(38, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Decimal Integer Value:";
            // 
            // nudResultPlaces
            // 
            this.nudResultPlaces.Location = new System.Drawing.Point(474, 94);
            this.nudResultPlaces.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudResultPlaces.Name = "nudResultPlaces";
            this.nudResultPlaces.Size = new System.Drawing.Size(74, 20);
            this.nudResultPlaces.TabIndex = 5;
            this.nudResultPlaces.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // nudBase
            // 
            this.nudBase.Location = new System.Drawing.Point(301, 94);
            this.nudBase.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudBase.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudBase.Name = "nudBase";
            this.nudBase.Size = new System.Drawing.Size(74, 20);
            this.nudBase.TabIndex = 6;
            this.nudBase.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudBase.ValueChanged += new System.EventHandler(this.nudBase_ValueChanged);
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(41, 62);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(151, 20);
            this.txtDecimal.TabIndex = 7;
            this.txtDecimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDecimal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDecimal_KeyPress);
            // 
            // txtConverted
            // 
            this.txtConverted.Location = new System.Drawing.Point(290, 62);
            this.txtConverted.Name = "txtConverted";
            this.txtConverted.Size = new System.Drawing.Size(258, 20);
            this.txtConverted.TabIndex = 8;
            this.txtConverted.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtConverted.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConverted_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Places in Result:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Base:";
            // 
            // frmConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 212);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConverted);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.nudBase);
            this.Controls.Add(this.nudResultPlaces);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblConvertedText);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConvertToDecimal);
            this.Controls.Add(this.btnConvertFromDecimal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 250);
            this.MinimumSize = new System.Drawing.Size(600, 250);
            this.Name = "frmConverter";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudResultPlaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvertFromDecimal;
        private System.Windows.Forms.Button btnConvertToDecimal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblConvertedText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudResultPlaces;
        private System.Windows.Forms.NumericUpDown nudBase;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.TextBox txtConverted;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

