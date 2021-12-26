
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
            this.srtwbtn = new System.Windows.Forms.Button();
            this.Lwstaw = new System.Windows.Forms.Label();
            this.Lbabel = new System.Windows.Forms.Label();
            this.Lszybkie = new System.Windows.Forms.Label();
            this.srtbbtn = new System.Windows.Forms.Button();
            this.srtsbtn = new System.Windows.Forms.Button();
            this.srthbtn = new System.Windows.Forms.Button();
            this.Lkopcowanie = new System.Windows.Forms.Label();
            this.srtscbtn = new System.Windows.Forms.Button();
            this.Lscalanie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // srtwbtn
            // 
            this.srtwbtn.Location = new System.Drawing.Point(12, 39);
            this.srtwbtn.Name = "srtwbtn";
            this.srtwbtn.Size = new System.Drawing.Size(166, 40);
            this.srtwbtn.TabIndex = 0;
            this.srtwbtn.Text = "Sortowanie przez wstawianie";
            this.srtwbtn.UseVisualStyleBackColor = true;
            this.srtwbtn.Click += new System.EventHandler(this.srtwbtn_Click);
            // 
            // Lwstaw
            // 
            this.Lwstaw.AutoSize = true;
            this.Lwstaw.Location = new System.Drawing.Point(12, 121);
            this.Lwstaw.Name = "Lwstaw";
            this.Lwstaw.Size = new System.Drawing.Size(156, 15);
            this.Lwstaw.TabIndex = 3;
            this.Lwstaw.Text = "sortowanie przez wstawianie";
            // 
            // Lbabel
            // 
            this.Lbabel.AutoSize = true;
            this.Lbabel.Location = new System.Drawing.Point(184, 121);
            this.Lbabel.Name = "Lbabel";
            this.Lbabel.Size = new System.Drawing.Size(125, 15);
            this.Lbabel.TabIndex = 6;
            this.Lbabel.Text = "sortowanie bąbelkowe";
            this.Lbabel.Click += new System.EventHandler(this.Lbabel_Click);
            // 
            // Lszybkie
            // 
            this.Lszybkie.AutoSize = true;
            this.Lszybkie.Location = new System.Drawing.Point(329, 121);
            this.Lszybkie.Name = "Lszybkie";
            this.Lszybkie.Size = new System.Drawing.Size(106, 15);
            this.Lszybkie.TabIndex = 7;
            this.Lszybkie.Text = "sortowanie szybkie";
            // 
            // srtbbtn
            // 
            this.srtbbtn.Location = new System.Drawing.Point(184, 38);
            this.srtbbtn.Name = "srtbbtn";
            this.srtbbtn.Size = new System.Drawing.Size(139, 40);
            this.srtbbtn.TabIndex = 8;
            this.srtbbtn.Text = "Sortowanie bąbelkowe";
            this.srtbbtn.UseVisualStyleBackColor = true;
            this.srtbbtn.Click += new System.EventHandler(this.srtbbtn_Click);
            // 
            // srtsbtn
            // 
            this.srtsbtn.Location = new System.Drawing.Point(329, 40);
            this.srtsbtn.Name = "srtsbtn";
            this.srtsbtn.Size = new System.Drawing.Size(115, 39);
            this.srtsbtn.TabIndex = 9;
            this.srtsbtn.Text = "Sortowanie szybkie";
            this.srtsbtn.UseVisualStyleBackColor = true;
            this.srtsbtn.Click += new System.EventHandler(this.srtsbtn_Click);
            // 
            // srthbtn
            // 
            this.srthbtn.Location = new System.Drawing.Point(451, 40);
            this.srthbtn.Name = "srthbtn";
            this.srthbtn.Size = new System.Drawing.Size(173, 37);
            this.srthbtn.TabIndex = 10;
            this.srthbtn.Text = "Sortowanie przez kopcowanie";
            this.srthbtn.UseVisualStyleBackColor = true;
            this.srthbtn.Click += new System.EventHandler(this.srthbtn_Click);
            // 
            // Lkopcowanie
            // 
            this.Lkopcowanie.AutoSize = true;
            this.Lkopcowanie.Location = new System.Drawing.Point(451, 121);
            this.Lkopcowanie.Name = "Lkopcowanie";
            this.Lkopcowanie.Size = new System.Drawing.Size(162, 15);
            this.Lkopcowanie.TabIndex = 11;
            this.Lkopcowanie.Text = "sortowanie przez kopcowanie";
            // 
            // srtscbtn
            // 
            this.srtscbtn.Location = new System.Drawing.Point(631, 40);
            this.srtscbtn.Name = "srtscbtn";
            this.srtscbtn.Size = new System.Drawing.Size(157, 36);
            this.srtscbtn.TabIndex = 12;
            this.srtscbtn.Text = "Sortowanie przez scalanie";
            this.srtscbtn.UseVisualStyleBackColor = true;
            
            // 
            // Lscalanie
            // 
            this.Lscalanie.AutoSize = true;
            this.Lscalanie.Location = new System.Drawing.Point(631, 121);
            this.Lscalanie.Name = "Lscalanie";
            this.Lscalanie.Size = new System.Drawing.Size(141, 15);
            this.Lscalanie.TabIndex = 13;
            this.Lscalanie.Text = "Sortowanie przez scalanie";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lscalanie);
            this.Controls.Add(this.srtscbtn);
            this.Controls.Add(this.Lkopcowanie);
            this.Controls.Add(this.srthbtn);
            this.Controls.Add(this.srtsbtn);
            this.Controls.Add(this.srtbbtn);
            this.Controls.Add(this.Lszybkie);
            this.Controls.Add(this.Lbabel);
            this.Controls.Add(this.Lwstaw);
            this.Controls.Add(this.srtwbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button srtwbtn;
        private System.Windows.Forms.Label Lwstaw;
        private System.Windows.Forms.Label Lbabel;
        private System.Windows.Forms.Label Lszybkie;
        private System.Windows.Forms.Button srtbbtn;
        private System.Windows.Forms.Button srtsbtn;
        private System.Windows.Forms.Button srthbtn;
        private System.Windows.Forms.Label Lkopcowanie;
        private System.Windows.Forms.Button srtscbtn;
        private System.Windows.Forms.Label Lscalanie;
    }
}

