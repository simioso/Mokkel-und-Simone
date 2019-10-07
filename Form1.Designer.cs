namespace VidCam
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
            this.Kamerabillede = new System.Windows.Forms.PictureBox();
            this.Capturebillede = new System.Windows.Forms.PictureBox();
            this.buttonCapture = new System.Windows.Forms.Button();
            this.buttonGray = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Kamerabillede)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Capturebillede)).BeginInit();
            this.SuspendLayout();
            // 
            // Kamerabillede
            // 
            this.Kamerabillede.Location = new System.Drawing.Point(12, 12);
            this.Kamerabillede.Name = "Kamerabillede";
            this.Kamerabillede.Size = new System.Drawing.Size(397, 315);
            this.Kamerabillede.TabIndex = 0;
            this.Kamerabillede.TabStop = false;
            // 
            // Capturebillede
            // 
            this.Capturebillede.Location = new System.Drawing.Point(415, 12);
            this.Capturebillede.Name = "Capturebillede";
            this.Capturebillede.Size = new System.Drawing.Size(373, 315);
            this.Capturebillede.TabIndex = 1;
            this.Capturebillede.TabStop = false;
            // 
            // buttonCapture
            // 
            this.buttonCapture.BackColor = System.Drawing.Color.Red;
            this.buttonCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCapture.Location = new System.Drawing.Point(12, 333);
            this.buttonCapture.Name = "buttonCapture";
            this.buttonCapture.Size = new System.Drawing.Size(397, 105);
            this.buttonCapture.TabIndex = 2;
            this.buttonCapture.Text = "Capture";
            this.buttonCapture.UseVisualStyleBackColor = false;
            this.buttonCapture.Click += new System.EventHandler(this.ButtonCapture_Click);
            // 
            // buttonGray
            // 
            this.buttonGray.BackColor = System.Drawing.Color.Blue;
            this.buttonGray.Location = new System.Drawing.Point(415, 333);
            this.buttonGray.Name = "buttonGray";
            this.buttonGray.Size = new System.Drawing.Size(373, 105);
            this.buttonGray.TabIndex = 3;
            this.buttonGray.Text = "GrayScale";
            this.buttonGray.UseVisualStyleBackColor = false;
            this.buttonGray.Click += new System.EventHandler(this.ButtonGray_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGray);
            this.Controls.Add(this.buttonCapture);
            this.Controls.Add(this.Capturebillede);
            this.Controls.Add(this.Kamerabillede);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Kamerabillede)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Capturebillede)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Kamerabillede;
        private System.Windows.Forms.PictureBox Capturebillede;
        private System.Windows.Forms.Button buttonCapture;
        private System.Windows.Forms.Button buttonGray;
    }
}

