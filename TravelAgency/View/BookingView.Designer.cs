namespace TravelAgency.View
{
    partial class BookingView
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
            this.label12 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cbTransportation = new System.Windows.Forms.ComboBox();
            this.tATransportationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agencyDataSet2 = new TravelAgency.AgencyDataSet2();
            this.cbEvents = new System.Windows.Forms.ComboBox();
            this.tAEntertainmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agencyDataSet1 = new TravelAgency.AgencyDataSet1();
            this.cbHotels = new System.Windows.Forms.ComboBox();
            this.tAHotelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agencyDataSet = new TravelAgency.AgencyDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtNights = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tA_HotelTableAdapter = new TravelAgency.AgencyDataSetTableAdapters.TA_HotelTableAdapter();
            this.agencyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tA_EntertainmentTableAdapter = new TravelAgency.AgencyDataSet1TableAdapters.TA_EntertainmentTableAdapter();
            this.tA_TransportationTableAdapter = new TravelAgency.AgencyDataSet2TableAdapters.TA_TransportationTableAdapter();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tATransportationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencyDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAEntertainmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAHotelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencyDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12.Location = new System.Drawing.Point(284, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(419, 46);
            this.label12.TabIndex = 7;
            this.label12.Text = "Everest Travel Agency";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.lblMessage);
            this.panel4.Controls.Add(this.btnSubmit);
            this.panel4.Controls.Add(this.cbTransportation);
            this.panel4.Controls.Add(this.cbEvents);
            this.panel4.Controls.Add(this.cbHotels);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.lblName);
            this.panel4.Controls.Add(this.dtStartDate);
            this.panel4.Controls.Add(this.txtDestination);
            this.panel4.Controls.Add(this.txtNights);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(5, 68);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(851, 308);
            this.panel4.TabIndex = 6;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(424, 253);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 20);
            this.lblMessage.TabIndex = 25;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSubmit.Location = new System.Drawing.Point(305, 240);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(92, 36);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cbTransportation
            // 
            this.cbTransportation.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tATransportationBindingSource, "Id", true));
            this.cbTransportation.DataSource = this.tATransportationBindingSource;
            this.cbTransportation.DisplayMember = "Type";
            this.cbTransportation.FormattingEnabled = true;
            this.cbTransportation.Location = new System.Drawing.Point(667, 162);
            this.cbTransportation.Name = "cbTransportation";
            this.cbTransportation.Size = new System.Drawing.Size(121, 21);
            this.cbTransportation.TabIndex = 6;
            this.cbTransportation.ValueMember = "Id";
            // 
            // tATransportationBindingSource
            // 
            this.tATransportationBindingSource.DataMember = "TA_Transportation";
            this.tATransportationBindingSource.DataSource = this.agencyDataSet2;
            // 
            // agencyDataSet2
            // 
            this.agencyDataSet2.DataSetName = "AgencyDataSet2";
            this.agencyDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbEvents
            // 
            this.cbEvents.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tAEntertainmentBindingSource, "Id", true));
            this.cbEvents.DataSource = this.tAEntertainmentBindingSource;
            this.cbEvents.DisplayMember = "Title";
            this.cbEvents.FormattingEnabled = true;
            this.cbEvents.Location = new System.Drawing.Point(667, 103);
            this.cbEvents.Name = "cbEvents";
            this.cbEvents.Size = new System.Drawing.Size(121, 21);
            this.cbEvents.TabIndex = 5;
            this.cbEvents.ValueMember = "Id";
            // 
            // tAEntertainmentBindingSource
            // 
            this.tAEntertainmentBindingSource.DataMember = "TA_Entertainment";
            this.tAEntertainmentBindingSource.DataSource = this.agencyDataSet1;
            // 
            // agencyDataSet1
            // 
            this.agencyDataSet1.DataSetName = "AgencyDataSet1";
            this.agencyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbHotels
            // 
            this.cbHotels.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tAHotelBindingSource, "Id", true));
            this.cbHotels.DataSource = this.tAHotelBindingSource;
            this.cbHotels.DisplayMember = "Name";
            this.cbHotels.FormattingEnabled = true;
            this.cbHotels.Location = new System.Drawing.Point(667, 48);
            this.cbHotels.Name = "cbHotels";
            this.cbHotels.Size = new System.Drawing.Size(121, 21);
            this.cbHotels.TabIndex = 4;
            this.cbHotels.ValueMember = "Id";
            // 
            // tAHotelBindingSource
            // 
            this.tAHotelBindingSource.DataMember = "TA_Hotel";
            this.tAHotelBindingSource.DataSource = this.agencyDataSet;
            // 
            // agencyDataSet
            // 
            this.agencyDataSet.DataSetName = "AgencyDataSet";
            this.agencyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(472, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Transportation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(472, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Event";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(472, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Hotel";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblName.Location = new System.Drawing.Point(300, 14);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 25);
            this.lblName.TabIndex = 16;
            // 
            // dtStartDate
            // 
            this.dtStartDate.Location = new System.Drawing.Point(183, 52);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(178, 20);
            this.dtStartDate.TabIndex = 1;
            // 
            // txtDestination
            // 
            this.txtDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestination.Location = new System.Drawing.Point(183, 104);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(178, 24);
            this.txtDestination.TabIndex = 2;
            // 
            // txtNights
            // 
            this.txtNights.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNights.Location = new System.Drawing.Point(183, 162);
            this.txtNights.Name = "txtNights";
            this.txtNights.Size = new System.Drawing.Size(181, 24);
            this.txtNights.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(17, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 24);
            this.label10.TabIndex = 5;
            this.label10.Text = "Destination:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(17, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 24);
            this.label9.TabIndex = 4;
            this.label9.Text = "How many nights:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(17, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "Start Date: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.CadetBlue;
            this.label6.Location = new System.Drawing.Point(16, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(292, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Booking info for Customer ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TravelAgency.Properties.Resources.kisspng_logo_blue_ridge_rock_festival_2018_logo_mountain_5b5cc9dab9a066_0694187215328076427603;
            this.pictureBox1.Location = new System.Drawing.Point(29, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // tA_HotelTableAdapter
            // 
            this.tA_HotelTableAdapter.ClearBeforeFill = true;
            // 
            // agencyDataSetBindingSource
            // 
            this.agencyDataSetBindingSource.DataSource = this.agencyDataSet;
            this.agencyDataSetBindingSource.Position = 0;
            // 
            // tA_EntertainmentTableAdapter
            // 
            this.tA_EntertainmentTableAdapter.ClearBeforeFill = true;
            // 
            // tA_TransportationTableAdapter
            // 
            this.tA_TransportationTableAdapter.ClearBeforeFill = true;
            // 
            // BookingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(877, 392);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel4);
            this.Name = "BookingView";
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.BookingView_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tATransportationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencyDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAEntertainmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAHotelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencyDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtNights;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTransportation;
        private System.Windows.Forms.ComboBox cbEvents;
        private System.Windows.Forms.ComboBox cbHotels;
        private System.Windows.Forms.Button btnSubmit;
        private AgencyDataSet agencyDataSet;
        private System.Windows.Forms.BindingSource tAHotelBindingSource;
        private AgencyDataSetTableAdapters.TA_HotelTableAdapter tA_HotelTableAdapter;
        private System.Windows.Forms.BindingSource agencyDataSetBindingSource;
        private AgencyDataSet1 agencyDataSet1;
        private System.Windows.Forms.BindingSource tAEntertainmentBindingSource;
        private AgencyDataSet1TableAdapters.TA_EntertainmentTableAdapter tA_EntertainmentTableAdapter;
        private AgencyDataSet2 agencyDataSet2;
        private System.Windows.Forms.BindingSource tATransportationBindingSource;
        private AgencyDataSet2TableAdapters.TA_TransportationTableAdapter tA_TransportationTableAdapter;
        private System.Windows.Forms.Label lblMessage;
    }
}