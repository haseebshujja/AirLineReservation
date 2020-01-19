namespace AirLine
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.btnEditData = new System.Windows.Forms.Button();
            this.btnPassengerDetails = new System.Windows.Forms.Button();
            this.btnBookSeat = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.btnBookFlight = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.chbTheme = new System.Windows.Forms.CheckBox();
            this.leftPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.leftPanel.Controls.Add(this.btnBookFlight);
            this.leftPanel.Controls.Add(this.btnEditData);
            this.leftPanel.Controls.Add(this.btnPassengerDetails);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(153, 497);
            this.leftPanel.TabIndex = 0;
            // 
            // btnEditData
            // 
            this.btnEditData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnEditData.FlatAppearance.BorderSize = 0;
            this.btnEditData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditData.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditData.ForeColor = System.Drawing.Color.White;
            this.btnEditData.Image = ((System.Drawing.Image)(resources.GetObject("btnEditData.Image")));
            this.btnEditData.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditData.Location = new System.Drawing.Point(3, 282);
            this.btnEditData.Name = "btnEditData";
            this.btnEditData.Size = new System.Drawing.Size(139, 98);
            this.btnEditData.TabIndex = 3;
            this.btnEditData.Text = "Edit Data";
            this.btnEditData.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditData.UseVisualStyleBackColor = false;
            // 
            // btnPassengerDetails
            // 
            this.btnPassengerDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnPassengerDetails.FlatAppearance.BorderSize = 0;
            this.btnPassengerDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassengerDetails.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassengerDetails.ForeColor = System.Drawing.Color.White;
            this.btnPassengerDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnPassengerDetails.Image")));
            this.btnPassengerDetails.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPassengerDetails.Location = new System.Drawing.Point(2, 186);
            this.btnPassengerDetails.Name = "btnPassengerDetails";
            this.btnPassengerDetails.Size = new System.Drawing.Size(148, 79);
            this.btnPassengerDetails.TabIndex = 3;
            this.btnPassengerDetails.Text = "Passenger Details";
            this.btnPassengerDetails.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPassengerDetails.UseVisualStyleBackColor = false;
            // 
            // btnBookSeat
            // 
            this.btnBookSeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnBookSeat.FlatAppearance.BorderSize = 0;
            this.btnBookSeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookSeat.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookSeat.ForeColor = System.Drawing.Color.White;
            this.btnBookSeat.Image = ((System.Drawing.Image)(resources.GetObject("btnBookSeat.Image")));
            this.btnBookSeat.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBookSeat.Location = new System.Drawing.Point(139, 2);
            this.btnBookSeat.Name = "btnBookSeat";
            this.btnBookSeat.Size = new System.Drawing.Size(148, 89);
            this.btnBookSeat.TabIndex = 2;
            this.btnBookSeat.Text = "Book Seats";
            this.btnBookSeat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBookSeat.UseVisualStyleBackColor = false;
            this.btnBookSeat.Visible = false;
            this.btnBookSeat.Click += new System.EventHandler(this.btnBookSeat_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.topPanel.Controls.Add(this.pictureBox1);
            this.topPanel.Controls.Add(this.btnBookSeat);
            this.topPanel.Controls.Add(this.btnClose);
            this.topPanel.Controls.Add(this.chbTheme);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(153, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(734, 102);
            this.topPanel.TabIndex = 1;
            // 
            // btnBookFlight
            // 
            this.btnBookFlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnBookFlight.FlatAppearance.BorderSize = 0;
            this.btnBookFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookFlight.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookFlight.ForeColor = System.Drawing.Color.White;
            this.btnBookFlight.Image = ((System.Drawing.Image)(resources.GetObject("btnBookFlight.Image")));
            this.btnBookFlight.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBookFlight.Location = new System.Drawing.Point(5, 73);
            this.btnBookFlight.Name = "btnBookFlight";
            this.btnBookFlight.Size = new System.Drawing.Size(148, 89);
            this.btnBookFlight.TabIndex = 4;
            this.btnBookFlight.Text = "Book Flight";
            this.btnBookFlight.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBookFlight.UseVisualStyleBackColor = false;
            this.btnBookFlight.Click += new System.EventHandler(this.btnBookFlight_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-18, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 102);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.Location = new System.Drawing.Point(658, 21);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(57, 58);
            this.btnClose.TabIndex = 3;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chbTheme
            // 
            this.chbTheme.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbTheme.AutoSize = true;
            this.chbTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.chbTheme.FlatAppearance.BorderSize = 0;
            this.chbTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbTheme.Image = ((System.Drawing.Image)(resources.GetObject("chbTheme.Image")));
            this.chbTheme.Location = new System.Drawing.Point(483, 21);
            this.chbTheme.Name = "chbTheme";
            this.chbTheme.Size = new System.Drawing.Size(70, 70);
            this.chbTheme.TabIndex = 2;
            this.chbTheme.UseVisualStyleBackColor = false;
            this.chbTheme.CheckedChanged += new System.EventHandler(this.chbTheme_CheckedChanged);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(887, 497);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.leftPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBookSeat;
        private System.Windows.Forms.Button btnPassengerDetails;
        private System.Windows.Forms.Button btnEditData;
        private System.Windows.Forms.CheckBox chbTheme;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBookFlight;
    }
}