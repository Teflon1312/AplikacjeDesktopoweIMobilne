
namespace prosty_kalkulator
{
    partial class Kalkulator
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.textBoxFirstNumber = new System.Windows.Forms.TextBox();
            this.textBoxSecondNumber = new System.Windows.Forms.TextBox();
            this.labelFirstNumber = new System.Windows.Forms.Label();
            this.labelSecondNumber = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.ButtonMul = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(38, 176);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Dodawanie";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            this.buttonAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonAdd_MouseUp);
            // 
            // buttonSub
            // 
            this.buttonSub.Location = new System.Drawing.Point(119, 176);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(91, 23);
            this.buttonSub.TabIndex = 1;
            this.buttonSub.Text = "Odejmowanie";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.buttonSub_Click);
            // 
            // textBoxFirstNumber
            // 
            this.textBoxFirstNumber.Location = new System.Drawing.Point(54, 87);
            this.textBoxFirstNumber.Name = "textBoxFirstNumber";
            this.textBoxFirstNumber.Size = new System.Drawing.Size(100, 23);
            this.textBoxFirstNumber.TabIndex = 4;
            // 
            // textBoxSecondNumber
            // 
            this.textBoxSecondNumber.Location = new System.Drawing.Point(216, 87);
            this.textBoxSecondNumber.Name = "textBoxSecondNumber";
            this.textBoxSecondNumber.Size = new System.Drawing.Size(100, 23);
            this.textBoxSecondNumber.TabIndex = 5;
            // 
            // labelFirstNumber
            // 
            this.labelFirstNumber.AutoSize = true;
            this.labelFirstNumber.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelFirstNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelFirstNumber.Location = new System.Drawing.Point(54, 69);
            this.labelFirstNumber.Name = "labelFirstNumber";
            this.labelFirstNumber.Size = new System.Drawing.Size(85, 15);
            this.labelFirstNumber.TabIndex = 6;
            this.labelFirstNumber.Text = "Pierwsza liczba";
            this.labelFirstNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelSecondNumber
            // 
            this.labelSecondNumber.AutoSize = true;
            this.labelSecondNumber.Location = new System.Drawing.Point(216, 69);
            this.labelSecondNumber.Name = "labelSecondNumber";
            this.labelSecondNumber.Size = new System.Drawing.Size(72, 15);
            this.labelSecondNumber.TabIndex = 7;
            this.labelSecondNumber.Text = "Druga liczba";
            this.labelSecondNumber.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(54, 229);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 15);
            this.labelResult.TabIndex = 8;
            this.labelResult.Click += new System.EventHandler(this.label3_Click);
            // 
            // ButtonMul
            // 
            this.ButtonMul.Location = new System.Drawing.Point(216, 176);
            this.ButtonMul.Name = "ButtonMul";
            this.ButtonMul.Size = new System.Drawing.Size(75, 23);
            this.ButtonMul.TabIndex = 9;
            this.ButtonMul.Text = "Mnożenie";
            this.ButtonMul.UseVisualStyleBackColor = true;
            this.ButtonMul.Click += new System.EventHandler(this.ButtonMul_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Location = new System.Drawing.Point(302, 176);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(75, 23);
            this.buttonDiv.TabIndex = 10;
            this.buttonDiv.Text = "Dzielenie";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.buttonDiv_Click);
            // 
            // Kalkulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(389, 265);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.ButtonMul);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelSecondNumber);
            this.Controls.Add(this.labelFirstNumber);
            this.Controls.Add(this.textBoxSecondNumber);
            this.Controls.Add(this.textBoxFirstNumber);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Kalkulator";
            this.Text = "Kalkulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.TextBox textBoxFirstNumber;
        private System.Windows.Forms.TextBox textBoxSecondNumber;
        private System.Windows.Forms.Label labelFirstNumber;
        private System.Windows.Forms.Label labelSecondNumber;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button ButtonMul;
        private System.Windows.Forms.Button buttonDiv;
    }
}

