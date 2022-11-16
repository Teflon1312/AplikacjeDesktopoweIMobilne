
namespace FirstWinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonSecond = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonName = new System.Windows.Forms.Button();
            this.labelAge = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.buttonAge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFirst
            // 
            this.buttonFirst.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.buttonFirst.Location = new System.Drawing.Point(12, 200);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(216, 114);
            this.buttonFirst.TabIndex = 0;
            this.buttonFirst.Text = "Przycisk";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonFirst_MouseClick);
            // 
            // buttonSecond
            // 
            this.buttonSecond.Font = new System.Drawing.Font("MV Boli", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.buttonSecond.ForeColor = System.Drawing.Color.MintCream;
            this.buttonSecond.Location = new System.Drawing.Point(178, 423);
            this.buttonSecond.Name = "buttonSecond";
            this.buttonSecond.Size = new System.Drawing.Size(346, 114);
            this.buttonSecond.TabIndex = 1;
            this.buttonSecond.Text = "baton";
            this.buttonSecond.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSecond.UseVisualStyleBackColor = true;
            this.buttonSecond.Click += new System.EventHandler(this.buttonSecond_Click);
            this.buttonSecond.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonSecond_MouseClick);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelName.ForeColor = System.Drawing.Color.LightCoral;
            this.labelName.Location = new System.Drawing.Point(12, 60);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(115, 30);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Podaj imie";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 112);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(252, 23);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonName
            // 
            this.buttonName.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonName.ForeColor = System.Drawing.Color.Crimson;
            this.buttonName.Location = new System.Drawing.Point(292, 77);
            this.buttonName.Name = "buttonName";
            this.buttonName.Size = new System.Drawing.Size(84, 58);
            this.buttonName.TabIndex = 4;
            this.buttonName.Text = "kliknij";
            this.buttonName.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.buttonName.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonName.UseVisualStyleBackColor = false;
            this.buttonName.Click += new System.EventHandler(this.buttonName_Click);
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.BackColor = System.Drawing.Color.DarkKhaki;
            this.labelAge.Location = new System.Drawing.Point(40, 160);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(64, 15);
            this.labelAge.TabIndex = 6;
            this.labelAge.Text = "Podaj wiek";
            this.labelAge.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxAge
            // 
            this.textBoxAge.BackColor = System.Drawing.Color.YellowGreen;
            this.textBoxAge.Location = new System.Drawing.Point(139, 152);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(104, 23);
            this.textBoxAge.TabIndex = 8;
            this.textBoxAge.TextChanged += new System.EventHandler(this.textBoxAge_TextChanged);
            // 
            // buttonAge
            // 
            this.buttonAge.Location = new System.Drawing.Point(292, 176);
            this.buttonAge.Name = "buttonAge";
            this.buttonAge.Size = new System.Drawing.Size(114, 23);
            this.buttonAge.TabIndex = 9;
            this.buttonAge.Text = "sprawdź wiek";
            this.buttonAge.UseVisualStyleBackColor = true;
            this.buttonAge.Click += new System.EventHandler(this.buttonAge_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(793, 711);
            this.Controls.Add(this.buttonAge);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.buttonName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonSecond);
            this.Controls.Add(this.buttonFirst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "MainForm";
            this.Text = "Pierwszy program okienkowy";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonSecond;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Button buttonAge;
    }
}

