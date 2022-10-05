
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
            this.buttonSecond.Location = new System.Drawing.Point(12, 335);
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
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(252, 23);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonName
            // 
            this.buttonName.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonName.ForeColor = System.Drawing.Color.Crimson;
            this.buttonName.Location = new System.Drawing.Point(296, 112);
            this.buttonName.Name = "buttonName";
            this.buttonName.Size = new System.Drawing.Size(60, 22);
            this.buttonName.TabIndex = 4;
            this.buttonName.Text = "kliknij";
            this.buttonName.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.buttonName.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonName.UseVisualStyleBackColor = false;
            this.buttonName.Click += new System.EventHandler(this.buttonName_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(384, 461);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonSecond;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonName;
    }
}

