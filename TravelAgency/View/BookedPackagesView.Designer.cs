namespace TravelAgency.View
{
    partial class Booked_Packages
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
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgHotels = new System.Windows.Forms.DataGridView();
            this.dgEntertainment = new System.Windows.Forms.DataGridView();
            this.dgtransportation = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeleteHotel = new System.Windows.Forms.Button();
            this.txtHotelId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEntertainmentId = new System.Windows.Forms.TextBox();
            this.btnDeleteEntertainment = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTransportId = new System.Windows.Forms.TextBox();
            this.btnDeleteTransportation = new System.Windows.Forms.Button();
            this.dgCustomer = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.btnFindPackage = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dgBooking = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBookingId = new System.Windows.Forms.TextBox();
            this.btnDeleteBooking = new System.Windows.Forms.Button();
            this.btnEditBooking = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgHotels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntertainment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtransportation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12.Location = new System.Drawing.Point(261, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(419, 46);
            this.label12.TabIndex = 9;
            this.label12.Text = "Everest Travel Agency";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TravelAgency.Properties.Resources.kisspng_logo_blue_ridge_rock_festival_2018_logo_mountain_5b5cc9dab9a066_0694187215328076427603;
            this.pictureBox1.Location = new System.Drawing.Point(42, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // dgHotels
            // 
            this.dgHotels.AllowUserToAddRows = false;
            this.dgHotels.AllowUserToDeleteRows = false;
            this.dgHotels.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgHotels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHotels.Location = new System.Drawing.Point(42, 289);
            this.dgHotels.Name = "dgHotels";
            this.dgHotels.ReadOnly = true;
            this.dgHotels.Size = new System.Drawing.Size(566, 147);
            this.dgHotels.TabIndex = 10;
            // 
            // dgEntertainment
            // 
            this.dgEntertainment.AllowUserToAddRows = false;
            this.dgEntertainment.AllowUserToDeleteRows = false;
            this.dgEntertainment.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgEntertainment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEntertainment.Location = new System.Drawing.Point(42, 474);
            this.dgEntertainment.Name = "dgEntertainment";
            this.dgEntertainment.ReadOnly = true;
            this.dgEntertainment.Size = new System.Drawing.Size(566, 144);
            this.dgEntertainment.TabIndex = 11;
            // 
            // dgtransportation
            // 
            this.dgtransportation.AllowUserToAddRows = false;
            this.dgtransportation.AllowUserToDeleteRows = false;
            this.dgtransportation.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgtransportation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtransportation.Location = new System.Drawing.Point(42, 113);
            this.dgtransportation.Name = "dgtransportation";
            this.dgtransportation.ReadOnly = true;
            this.dgtransportation.Size = new System.Drawing.Size(566, 146);
            this.dgtransportation.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Hotel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Entertainment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Transportation";
            // 
            // btnDeleteHotel
            // 
            this.btnDeleteHotel.BackColor = System.Drawing.Color.Red;
            this.btnDeleteHotel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteHotel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteHotel.Location = new System.Drawing.Point(646, 379);
            this.btnDeleteHotel.Name = "btnDeleteHotel";
            this.btnDeleteHotel.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteHotel.TabIndex = 16;
            this.btnDeleteHotel.Text = "Delete";
            this.btnDeleteHotel.UseVisualStyleBackColor = false;
            this.btnDeleteHotel.Click += new System.EventHandler(this.btnDeleteHotel_Click);
            // 
            // txtHotelId
            // 
            this.txtHotelId.Location = new System.Drawing.Point(618, 340);
            this.txtHotelId.Name = "txtHotelId";
            this.txtHotelId.Size = new System.Drawing.Size(127, 20);
            this.txtHotelId.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(642, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Hotel ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(644, 497);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Event ID:";
            // 
            // txtEntertainmentId
            // 
            this.txtEntertainmentId.Location = new System.Drawing.Point(618, 520);
            this.txtEntertainmentId.Name = "txtEntertainmentId";
            this.txtEntertainmentId.Size = new System.Drawing.Size(127, 20);
            this.txtEntertainmentId.TabIndex = 20;
            // 
            // btnDeleteEntertainment
            // 
            this.btnDeleteEntertainment.BackColor = System.Drawing.Color.Red;
            this.btnDeleteEntertainment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteEntertainment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteEntertainment.Location = new System.Drawing.Point(644, 546);
            this.btnDeleteEntertainment.Name = "btnDeleteEntertainment";
            this.btnDeleteEntertainment.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteEntertainment.TabIndex = 19;
            this.btnDeleteEntertainment.Text = "Delete";
            this.btnDeleteEntertainment.UseVisualStyleBackColor = false;
            this.btnDeleteEntertainment.Click += new System.EventHandler(this.btnDeleteEntertainment_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(614, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Transportation ID:";
            // 
            // txtTransportId
            // 
            this.txtTransportId.Location = new System.Drawing.Point(618, 180);
            this.txtTransportId.Name = "txtTransportId";
            this.txtTransportId.Size = new System.Drawing.Size(127, 20);
            this.txtTransportId.TabIndex = 23;
            // 
            // btnDeleteTransportation
            // 
            this.btnDeleteTransportation.BackColor = System.Drawing.Color.Red;
            this.btnDeleteTransportation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteTransportation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteTransportation.Location = new System.Drawing.Point(641, 216);
            this.btnDeleteTransportation.Name = "btnDeleteTransportation";
            this.btnDeleteTransportation.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteTransportation.TabIndex = 22;
            this.btnDeleteTransportation.Text = "Delete";
            this.btnDeleteTransportation.UseVisualStyleBackColor = false;
            this.btnDeleteTransportation.Click += new System.EventHandler(this.btnDeleteTransportation_Click);
            // 
            // dgCustomer
            // 
            this.dgCustomer.AllowUserToAddRows = false;
            this.dgCustomer.AllowUserToDeleteRows = false;
            this.dgCustomer.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomer.Location = new System.Drawing.Point(757, 121);
            this.dgCustomer.Name = "dgCustomer";
            this.dgCustomer.ReadOnly = true;
            this.dgCustomer.Size = new System.Drawing.Size(589, 148);
            this.dgCustomer.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(823, 484);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Customer ID";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(810, 507);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(127, 20);
            this.txtCustomerId.TabIndex = 27;
            // 
            // btnFindPackage
            // 
            this.btnFindPackage.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFindPackage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFindPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindPackage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFindPackage.Location = new System.Drawing.Point(810, 533);
            this.btnFindPackage.Name = "btnFindPackage";
            this.btnFindPackage.Size = new System.Drawing.Size(130, 36);
            this.btnFindPackage.TabIndex = 26;
            this.btnFindPackage.Text = "Find Package";
            this.btnFindPackage.UseVisualStyleBackColor = false;
            this.btnFindPackage.Click += new System.EventHandler(this.btnFindPackage_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(753, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 24);
            this.label8.TabIndex = 29;
            this.label8.Text = "Customer Info";
            // 
            // dgBooking
            // 
            this.dgBooking.AllowUserToAddRows = false;
            this.dgBooking.AllowUserToDeleteRows = false;
            this.dgBooking.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBooking.Location = new System.Drawing.Point(757, 317);
            this.dgBooking.Name = "dgBooking";
            this.dgBooking.ReadOnly = true;
            this.dgBooking.Size = new System.Drawing.Size(589, 148);
            this.dgBooking.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(753, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 24);
            this.label9.TabIndex = 31;
            this.label9.Text = "Booking Info";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1130, 492);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 20);
            this.label10.TabIndex = 34;
            this.label10.Text = "Booking ID";
            // 
            // txtBookingId
            // 
            this.txtBookingId.Location = new System.Drawing.Point(1112, 515);
            this.txtBookingId.Name = "txtBookingId";
            this.txtBookingId.Size = new System.Drawing.Size(127, 20);
            this.txtBookingId.TabIndex = 33;
            // 
            // btnDeleteBooking
            // 
            this.btnDeleteBooking.BackColor = System.Drawing.Color.Red;
            this.btnDeleteBooking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteBooking.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteBooking.Location = new System.Drawing.Point(1189, 541);
            this.btnDeleteBooking.Name = "btnDeleteBooking";
            this.btnDeleteBooking.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteBooking.TabIndex = 32;
            this.btnDeleteBooking.Text = "Delete";
            this.btnDeleteBooking.UseVisualStyleBackColor = false;
            this.btnDeleteBooking.Click += new System.EventHandler(this.btnDeleteBooking_Click);
            // 
            // btnEditBooking
            // 
            this.btnEditBooking.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEditBooking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBooking.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditBooking.Location = new System.Drawing.Point(1095, 541);
            this.btnEditBooking.Name = "btnEditBooking";
            this.btnEditBooking.Size = new System.Drawing.Size(88, 23);
            this.btnEditBooking.TabIndex = 35;
            this.btnEditBooking.Text = "Edit";
            this.btnEditBooking.UseVisualStyleBackColor = false;
            this.btnEditBooking.Click += new System.EventHandler(this.btnEditBooking_Click);
            // 
            // Booked_Packages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1358, 630);
            this.Controls.Add(this.btnEditBooking);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBookingId);
            this.Controls.Add(this.btnDeleteBooking);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgBooking);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.btnFindPackage);
            this.Controls.Add(this.dgCustomer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTransportId);
            this.Controls.Add(this.btnDeleteTransportation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEntertainmentId);
            this.Controls.Add(this.btnDeleteEntertainment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHotelId);
            this.Controls.Add(this.btnDeleteHotel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgtransportation);
            this.Controls.Add(this.dgEntertainment);
            this.Controls.Add(this.dgHotels);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Booked_Packages";
            this.Text = "Booked_Packages";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Booked_Packages_FormClosed);
            this.Load += new System.EventHandler(this.Booked_Packages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgHotels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntertainment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtransportation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBooking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgHotels;
        private System.Windows.Forms.DataGridView dgEntertainment;
        private System.Windows.Forms.DataGridView dgtransportation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeleteHotel;
        private System.Windows.Forms.TextBox txtHotelId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEntertainmentId;
        private System.Windows.Forms.Button btnDeleteEntertainment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTransportId;
        private System.Windows.Forms.Button btnDeleteTransportation;
        private System.Windows.Forms.DataGridView dgCustomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Button btnFindPackage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgBooking;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBookingId;
        private System.Windows.Forms.Button btnDeleteBooking;
        private System.Windows.Forms.Button btnEditBooking;
    }
}