namespace Wallpaper
{
    partial class frmWallpaperProperties
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
            this.components = new System.ComponentModel.Container();
            this.btnOpen1 = new System.Windows.Forms.Button();
            this.txtPath1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete1 = new System.Windows.Forms.Button();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpMonitor1 = new System.Windows.Forms.GroupBox();
            this.grpMonitor2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.btnOpen2 = new System.Windows.Forms.Button();
            this.btnDelete2 = new System.Windows.Forms.Button();
            this.txtPath2 = new System.Windows.Forms.TextBox();
            this.grpMonitor3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.btnOpen3 = new System.Windows.Forms.Button();
            this.btnDelete3 = new System.Windows.Forms.Button();
            this.txtPath3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.grpMonitor1.SuspendLayout();
            this.grpMonitor2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            this.grpMonitor3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpen1
            // 
            this.btnOpen1.Location = new System.Drawing.Point(27, 222);
            this.btnOpen1.Name = "btnOpen1";
            this.btnOpen1.Size = new System.Drawing.Size(102, 43);
            this.btnOpen1.TabIndex = 1;
            this.btnOpen1.Text = "Open In Explorer";
            this.btnOpen1.UseVisualStyleBackColor = true;
            this.btnOpen1.Click += new System.EventHandler(this.btnOpen1_Click);
            // 
            // txtPath1
            // 
            this.txtPath1.Location = new System.Drawing.Point(6, 39);
            this.txtPath1.Name = "txtPath1";
            this.txtPath1.Size = new System.Drawing.Size(295, 20);
            this.txtPath1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current Wallpaper:";
            // 
            // btnDelete1
            // 
            this.btnDelete1.Location = new System.Drawing.Point(173, 222);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.Size = new System.Drawing.Size(102, 43);
            this.btnDelete1.TabIndex = 4;
            this.btnDelete1.Text = "Delete Wallpaper";
            this.btnDelete1.UseVisualStyleBackColor = true;
            this.btnDelete1.Click += new System.EventHandler(this.btnDelete1_Click);
            // 
            // pic1
            // 
            this.pic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic1.Location = new System.Drawing.Point(6, 65);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(295, 151);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 5;
            this.pic1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // grpMonitor1
            // 
            this.grpMonitor1.Controls.Add(this.label1);
            this.grpMonitor1.Controls.Add(this.pic1);
            this.grpMonitor1.Controls.Add(this.btnOpen1);
            this.grpMonitor1.Controls.Add(this.btnDelete1);
            this.grpMonitor1.Controls.Add(this.txtPath1);
            this.grpMonitor1.Location = new System.Drawing.Point(12, 12);
            this.grpMonitor1.Name = "grpMonitor1";
            this.grpMonitor1.Size = new System.Drawing.Size(309, 276);
            this.grpMonitor1.TabIndex = 6;
            this.grpMonitor1.TabStop = false;
            this.grpMonitor1.Text = "Monitor 1";
            // 
            // grpMonitor2
            // 
            this.grpMonitor2.Controls.Add(this.label2);
            this.grpMonitor2.Controls.Add(this.pic2);
            this.grpMonitor2.Controls.Add(this.btnOpen2);
            this.grpMonitor2.Controls.Add(this.btnDelete2);
            this.grpMonitor2.Controls.Add(this.txtPath2);
            this.grpMonitor2.Location = new System.Drawing.Point(327, 12);
            this.grpMonitor2.Name = "grpMonitor2";
            this.grpMonitor2.Size = new System.Drawing.Size(309, 276);
            this.grpMonitor2.TabIndex = 7;
            this.grpMonitor2.TabStop = false;
            this.grpMonitor2.Text = "Monitor 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Current Wallpaper:";
            // 
            // pic2
            // 
            this.pic2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic2.Location = new System.Drawing.Point(6, 65);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(295, 151);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 5;
            this.pic2.TabStop = false;
            // 
            // btnOpen2
            // 
            this.btnOpen2.Location = new System.Drawing.Point(27, 222);
            this.btnOpen2.Name = "btnOpen2";
            this.btnOpen2.Size = new System.Drawing.Size(102, 43);
            this.btnOpen2.TabIndex = 1;
            this.btnOpen2.Text = "Open In Explorer";
            this.btnOpen2.UseVisualStyleBackColor = true;
            this.btnOpen2.Click += new System.EventHandler(this.btnOpen2_Click);
            // 
            // btnDelete2
            // 
            this.btnDelete2.Location = new System.Drawing.Point(173, 222);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(102, 43);
            this.btnDelete2.TabIndex = 4;
            this.btnDelete2.Text = "Delete Wallpaper";
            this.btnDelete2.UseVisualStyleBackColor = true;
            this.btnDelete2.Click += new System.EventHandler(this.btnDelete2_Click);
            // 
            // txtPath2
            // 
            this.txtPath2.Location = new System.Drawing.Point(6, 39);
            this.txtPath2.Name = "txtPath2";
            this.txtPath2.Size = new System.Drawing.Size(295, 20);
            this.txtPath2.TabIndex = 2;
            // 
            // grpMonitor3
            // 
            this.grpMonitor3.Controls.Add(this.label3);
            this.grpMonitor3.Controls.Add(this.pic3);
            this.grpMonitor3.Controls.Add(this.btnOpen3);
            this.grpMonitor3.Controls.Add(this.btnDelete3);
            this.grpMonitor3.Controls.Add(this.txtPath3);
            this.grpMonitor3.Location = new System.Drawing.Point(642, 12);
            this.grpMonitor3.Name = "grpMonitor3";
            this.grpMonitor3.Size = new System.Drawing.Size(309, 276);
            this.grpMonitor3.TabIndex = 7;
            this.grpMonitor3.TabStop = false;
            this.grpMonitor3.Text = "Monitor 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Current Wallpaper:";
            // 
            // pic3
            // 
            this.pic3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic3.Location = new System.Drawing.Point(6, 65);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(295, 151);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic3.TabIndex = 5;
            this.pic3.TabStop = false;
            // 
            // btnOpen3
            // 
            this.btnOpen3.Location = new System.Drawing.Point(27, 222);
            this.btnOpen3.Name = "btnOpen3";
            this.btnOpen3.Size = new System.Drawing.Size(102, 43);
            this.btnOpen3.TabIndex = 1;
            this.btnOpen3.Text = "Open In Explorer";
            this.btnOpen3.UseVisualStyleBackColor = true;
            this.btnOpen3.Click += new System.EventHandler(this.btnOpen3_Click);
            // 
            // btnDelete3
            // 
            this.btnDelete3.Location = new System.Drawing.Point(165, 222);
            this.btnDelete3.Name = "btnDelete3";
            this.btnDelete3.Size = new System.Drawing.Size(102, 43);
            this.btnDelete3.TabIndex = 4;
            this.btnDelete3.Text = "Delete Wallpaper";
            this.btnDelete3.UseVisualStyleBackColor = true;
            this.btnDelete3.Click += new System.EventHandler(this.btnDelete3_Click);
            // 
            // txtPath3
            // 
            this.txtPath3.Location = new System.Drawing.Point(6, 39);
            this.txtPath3.Name = "txtPath3";
            this.txtPath3.Size = new System.Drawing.Size(295, 20);
            this.txtPath3.TabIndex = 2;
            // 
            // frmWallpaperProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 301);
            this.Controls.Add(this.grpMonitor3);
            this.Controls.Add(this.grpMonitor2);
            this.Controls.Add(this.grpMonitor1);
            this.MaximizeBox = false;
            this.Name = "frmWallpaperProperties";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wallpaper Properties";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.grpMonitor1.ResumeLayout(false);
            this.grpMonitor1.PerformLayout();
            this.grpMonitor2.ResumeLayout(false);
            this.grpMonitor2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            this.grpMonitor3.ResumeLayout(false);
            this.grpMonitor3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen1;
        private System.Windows.Forms.TextBox txtPath1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete1;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox grpMonitor1;
        private System.Windows.Forms.GroupBox grpMonitor2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.Button btnOpen2;
        private System.Windows.Forms.Button btnDelete2;
        private System.Windows.Forms.TextBox txtPath2;
        private System.Windows.Forms.GroupBox grpMonitor3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.Button btnOpen3;
        private System.Windows.Forms.Button btnDelete3;
        private System.Windows.Forms.TextBox txtPath3;
    }
}

