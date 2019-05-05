namespace WindowsFormsApp27
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
            this.btn00 = new System.Windows.Forms.Button();
            this.btn01 = new System.Windows.Forms.Button();
            this.btn02 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn00
            // 
            this.btn00.Location = new System.Drawing.Point(231, 99);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(75, 43);
            this.btn00.TabIndex = 0;
            this.btn00.UseVisualStyleBackColor = true;
            this.btn00.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_click);
            // 
            // btn01
            // 
            this.btn01.Location = new System.Drawing.Point(332, 99);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(75, 43);
            this.btn01.TabIndex = 1;
            this.btn01.UseVisualStyleBackColor = true;
            this.btn01.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_click);
            // 
            // btn02
            // 
            this.btn02.Location = new System.Drawing.Point(431, 99);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(75, 43);
            this.btn02.TabIndex = 2;
            this.btn02.UseVisualStyleBackColor = true;
            this.btn02.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_click);
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(231, 158);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(75, 39);
            this.btn10.TabIndex = 3;
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_click);
            // 
            // btn11
            // 
            this.btn11.Location = new System.Drawing.Point(332, 158);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(75, 39);
            this.btn11.TabIndex = 4;
            this.btn11.UseVisualStyleBackColor = true;
            this.btn11.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_click);
            // 
            // btn12
            // 
            this.btn12.Location = new System.Drawing.Point(431, 158);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(75, 39);
            this.btn12.TabIndex = 5;
            this.btn12.UseVisualStyleBackColor = true;
            this.btn12.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_click);
            // 
            // btn20
            // 
            this.btn20.Location = new System.Drawing.Point(231, 221);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(75, 38);
            this.btn20.TabIndex = 6;
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_click);
            // 
            // btn21
            // 
            this.btn21.Location = new System.Drawing.Point(332, 221);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(75, 38);
            this.btn21.TabIndex = 7;
            this.btn21.UseVisualStyleBackColor = true;
            this.btn21.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_click);
            // 
            // btn22
            // 
            this.btn22.Location = new System.Drawing.Point(431, 221);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(75, 38);
            this.btn22.TabIndex = 8;
            this.btn22.UseVisualStyleBackColor = true;
            this.btn22.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn22);
            this.Controls.Add(this.btn21);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn11);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn02);
            this.Controls.Add(this.btn01);
            this.Controls.Add(this.btn00);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Button button1;
    }
}

