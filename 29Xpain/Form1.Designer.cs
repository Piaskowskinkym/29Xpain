
namespace _29Xpain
{
    partial class Form1
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
            this.srtbtn = new System.Windows.Forms.Button();
            this.Lwstaw = new System.Windows.Forms.Label();
            this.Lbabel = new System.Windows.Forms.Label();
            this.szybsrt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // srtbtn
            // 
            this.srtbtn.Location = new System.Drawing.Point(216, 42);
            this.srtbtn.Name = "srtbtn";
            this.srtbtn.Size = new System.Drawing.Size(331, 23);
            this.srtbtn.TabIndex = 0;
            this.srtbtn.Text = "sortuj";
            this.srtbtn.UseVisualStyleBackColor = true;
            // 
            // Lwstaw
            // 
            this.Lwstaw.AutoSize = true;
            this.Lwstaw.Location = new System.Drawing.Point(12, 117);
            this.Lwstaw.Name = "Lwstaw";
            this.Lwstaw.Size = new System.Drawing.Size(190, 15);
            this.Lwstaw.TabIndex = 3;
            this.Lwstaw.Text = "wynik sortowania przez wstawianie";
            // 
            // Lbabel
            // 
            this.Lbabel.AutoSize = true;
            this.Lbabel.Location = new System.Drawing.Point(139, 158);
            this.Lbabel.Name = "Lbabel";
            this.Lbabel.Size = new System.Drawing.Size(173, 15);
            this.Lbabel.TabIndex = 6;
            this.Lbabel.Text = "wynik sortowania bąbelkowego";
            // 
            // szybsrt
            // 
            this.szybsrt.AutoSize = true;
            this.szybsrt.Location = new System.Drawing.Point(356, 195);
            this.szybsrt.Name = "szybsrt";
            this.szybsrt.Size = new System.Drawing.Size(154, 15);
            this.szybsrt.TabIndex = 7;
            this.szybsrt.Text = "wynik sortowania szybkiego";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.szybsrt);
            this.Controls.Add(this.Lbabel);
            this.Controls.Add(this.Lwstaw);
            this.Controls.Add(this.srtbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button srtbtn;
        private System.Windows.Forms.Label Lwstaw;
        private System.Windows.Forms.Label Lbabel;
        private System.Windows.Forms.Label szybsrt;
    }
}

