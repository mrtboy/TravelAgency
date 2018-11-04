namespace TravelAgency.View
{
    partial class LoadView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadView));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTours = new System.Windows.Forms.Button();
            this.btnBookings = new System.Windows.Forms.Button();
            this.btnCreateService = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(173, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Everest Travel Agency";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(746, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(605, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = " Design by: Reza and Damoon";
            // 
            // btnTours
            // 
            this.btnTours.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnTours.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTours.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTours.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTours.Location = new System.Drawing.Point(467, 336);
            this.btnTours.Name = "btnTours";
            this.btnTours.Size = new System.Drawing.Size(151, 35);
            this.btnTours.TabIndex = 3;
            this.btnTours.Text = "Show Solled Tours";
            this.btnTours.UseVisualStyleBackColor = false;
            // 
            // btnBookings
            // 
            this.btnBookings.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBookings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBookings.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBookings.Location = new System.Drawing.Point(175, 336);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(140, 35);
            this.btnBookings.TabIndex = 5;
            this.btnBookings.Text = "Booking Tour";
            this.btnBookings.UseVisualStyleBackColor = false;
            this.btnBookings.Click += new System.EventHandler(this.btnBookings_Click);
            // 
            // btnCreateService
            // 
            this.btnCreateService.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCreateService.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateService.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateService.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreateService.Location = new System.Drawing.Point(321, 336);
            this.btnCreateService.Name = "btnCreateService";
            this.btnCreateService.Size = new System.Drawing.Size(140, 35);
            this.btnCreateService.TabIndex = 6;
            this.btnCreateService.Text = "Create Service";
            this.btnCreateService.UseVisualStyleBackColor = false;
            this.btnCreateService.Click += new System.EventHandler(this.btnCreateService_Click);
            // 
            // LoadView
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreateService);
            this.Controls.Add(this.btnBookings);
            this.Controls.Add(this.btnTours);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LoadView";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Load_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTours;
        private System.Windows.Forms.Button btnBookings;
        private System.Windows.Forms.Button btnCreateService;
    }
}