namespace Noio.Inex.WindowsFormsUI
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
            this.dgwGames = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.gbxGameAdd = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxCountriesAdd = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxPublishersAdd = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxGameSlug = new System.Windows.Forms.TextBox();
            this.cbxDevelopersAdd = new System.Windows.Forms.ComboBox();
            this.btnNewGameAdd = new System.Windows.Forms.Button();
            this.tbxGameReleaseDate = new System.Windows.Forms.TextBox();
            this.tbxGameThumbnailUrl = new System.Windows.Forms.TextBox();
            this.tbxGameName = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNewDeveloperAdd = new System.Windows.Forms.Button();
            this.tbxDeveloperName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNewPublisherAdd = new System.Windows.Forms.Button();
            this.tbxPublisherName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbxCountry = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnNewCountryAdd = new System.Windows.Forms.Button();
            this.tbxLocale = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgwPublishers = new System.Windows.Forms.DataGridView();
            this.dgwDevelopers = new System.Windows.Forms.DataGridView();
            this.dgwCountries = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGames)).BeginInit();
            this.gbxGameAdd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPublishers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDevelopers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCountries)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwGames
            // 
            this.dgwGames.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwGames.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgwGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGames.Location = new System.Drawing.Point(607, 12);
            this.dgwGames.Name = "dgwGames";
            this.dgwGames.Size = new System.Drawing.Size(841, 320);
            this.dgwGames.TabIndex = 19;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(310, 532);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(86, 33);
            this.btnRemove.TabIndex = 27;
            this.btnRemove.Text = "Sil";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // gbxGameAdd
            // 
            this.gbxGameAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbxGameAdd.Controls.Add(this.label9);
            this.gbxGameAdd.Controls.Add(this.cbxCountriesAdd);
            this.gbxGameAdd.Controls.Add(this.label8);
            this.gbxGameAdd.Controls.Add(this.cbxPublishersAdd);
            this.gbxGameAdd.Controls.Add(this.label7);
            this.gbxGameAdd.Controls.Add(this.tbxGameSlug);
            this.gbxGameAdd.Controls.Add(this.cbxDevelopersAdd);
            this.gbxGameAdd.Controls.Add(this.btnNewGameAdd);
            this.gbxGameAdd.Controls.Add(this.tbxGameReleaseDate);
            this.gbxGameAdd.Controls.Add(this.tbxGameThumbnailUrl);
            this.gbxGameAdd.Controls.Add(this.tbxGameName);
            this.gbxGameAdd.Controls.Add(this.lblStock);
            this.gbxGameAdd.Controls.Add(this.lblUnitPrice);
            this.gbxGameAdd.Controls.Add(this.lblCategoryId);
            this.gbxGameAdd.Controls.Add(this.lblProductName);
            this.gbxGameAdd.Location = new System.Drawing.Point(12, 12);
            this.gbxGameAdd.Name = "gbxGameAdd";
            this.gbxGameAdd.Size = new System.Drawing.Size(283, 367);
            this.gbxGameAdd.TabIndex = 32;
            this.gbxGameAdd.TabStop = false;
            this.gbxGameAdd.Text = "Add New Game";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Countries  :";
            // 
            // cbxCountriesAdd
            // 
            this.cbxCountriesAdd.FormattingEnabled = true;
            this.cbxCountriesAdd.Location = new System.Drawing.Point(110, 292);
            this.cbxCountriesAdd.Name = "cbxCountriesAdd";
            this.cbxCountriesAdd.Size = new System.Drawing.Size(157, 21);
            this.cbxCountriesAdd.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Publishers  :";
            // 
            // cbxPublishersAdd
            // 
            this.cbxPublishersAdd.FormattingEnabled = true;
            this.cbxPublishersAdd.Location = new System.Drawing.Point(110, 250);
            this.cbxPublishersAdd.Name = "cbxPublishersAdd";
            this.cbxPublishersAdd.Size = new System.Drawing.Size(157, 21);
            this.cbxPublishersAdd.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Developers :";
            // 
            // tbxGameSlug
            // 
            this.tbxGameSlug.Location = new System.Drawing.Point(110, 82);
            this.tbxGameSlug.Name = "tbxGameSlug";
            this.tbxGameSlug.Size = new System.Drawing.Size(157, 20);
            this.tbxGameSlug.TabIndex = 13;
            // 
            // cbxDevelopersAdd
            // 
            this.cbxDevelopersAdd.FormattingEnabled = true;
            this.cbxDevelopersAdd.Location = new System.Drawing.Point(110, 214);
            this.cbxDevelopersAdd.Name = "cbxDevelopersAdd";
            this.cbxDevelopersAdd.Size = new System.Drawing.Size(157, 21);
            this.cbxDevelopersAdd.TabIndex = 33;
            // 
            // btnNewGameAdd
            // 
            this.btnNewGameAdd.Location = new System.Drawing.Point(110, 328);
            this.btnNewGameAdd.Name = "btnNewGameAdd";
            this.btnNewGameAdd.Size = new System.Drawing.Size(86, 33);
            this.btnNewGameAdd.TabIndex = 11;
            this.btnNewGameAdd.Text = "Add";
            this.btnNewGameAdd.UseVisualStyleBackColor = true;
            this.btnNewGameAdd.Click += new System.EventHandler(this.btnNewGameAdd_Click);
            // 
            // tbxGameReleaseDate
            // 
            this.tbxGameReleaseDate.Location = new System.Drawing.Point(110, 170);
            this.tbxGameReleaseDate.Name = "tbxGameReleaseDate";
            this.tbxGameReleaseDate.Size = new System.Drawing.Size(157, 20);
            this.tbxGameReleaseDate.TabIndex = 9;
            // 
            // tbxGameThumbnailUrl
            // 
            this.tbxGameThumbnailUrl.Location = new System.Drawing.Point(110, 126);
            this.tbxGameThumbnailUrl.Name = "tbxGameThumbnailUrl";
            this.tbxGameThumbnailUrl.Size = new System.Drawing.Size(157, 20);
            this.tbxGameThumbnailUrl.TabIndex = 8;
            // 
            // tbxGameName
            // 
            this.tbxGameName.Location = new System.Drawing.Point(110, 41);
            this.tbxGameName.Name = "tbxGameName";
            this.tbxGameName.Size = new System.Drawing.Size(157, 20);
            this.tbxGameName.TabIndex = 7;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(21, 171);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(78, 13);
            this.lblStock.TabIndex = 5;
            this.lblStock.Text = "Release Date :";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(19, 133);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(78, 13);
            this.lblUnitPrice.TabIndex = 4;
            this.lblUnitPrice.Text = "Thumbnail Url :";
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Location = new System.Drawing.Point(19, 89);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(34, 13);
            this.lblCategoryId.TabIndex = 3;
            this.lblCategoryId.Text = "Slug :";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(19, 48);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(41, 13);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Name :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnNewDeveloperAdd);
            this.groupBox1.Controls.Add(this.tbxDeveloperName);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Location = new System.Drawing.Point(310, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 131);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Developer";
            // 
            // btnNewDeveloperAdd
            // 
            this.btnNewDeveloperAdd.Location = new System.Drawing.Point(117, 82);
            this.btnNewDeveloperAdd.Name = "btnNewDeveloperAdd";
            this.btnNewDeveloperAdd.Size = new System.Drawing.Size(86, 33);
            this.btnNewDeveloperAdd.TabIndex = 11;
            this.btnNewDeveloperAdd.Text = "Add";
            this.btnNewDeveloperAdd.UseVisualStyleBackColor = true;
            this.btnNewDeveloperAdd.Click += new System.EventHandler(this.btnNewDeveloperAdd_Click);
            // 
            // tbxDeveloperName
            // 
            this.tbxDeveloperName.Location = new System.Drawing.Point(110, 41);
            this.tbxDeveloperName.Name = "tbxDeveloperName";
            this.tbxDeveloperName.Size = new System.Drawing.Size(157, 20);
            this.tbxDeveloperName.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Name :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.btnNewPublisherAdd);
            this.groupBox2.Controls.Add(this.tbxPublisherName);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(310, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 131);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add New Publisher";
            // 
            // btnNewPublisherAdd
            // 
            this.btnNewPublisherAdd.Location = new System.Drawing.Point(117, 82);
            this.btnNewPublisherAdd.Name = "btnNewPublisherAdd";
            this.btnNewPublisherAdd.Size = new System.Drawing.Size(86, 33);
            this.btnNewPublisherAdd.TabIndex = 11;
            this.btnNewPublisherAdd.Text = "Add";
            this.btnNewPublisherAdd.UseVisualStyleBackColor = true;
            this.btnNewPublisherAdd.Click += new System.EventHandler(this.btnNewPublisherAdd_Click);
            // 
            // tbxPublisherName
            // 
            this.tbxPublisherName.Location = new System.Drawing.Point(110, 41);
            this.tbxPublisherName.Name = "tbxPublisherName";
            this.tbxPublisherName.Size = new System.Drawing.Size(157, 20);
            this.tbxPublisherName.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Name :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.tbxCountry);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.btnNewCountryAdd);
            this.groupBox3.Controls.Add(this.tbxLocale);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(310, 317);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 191);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add New Country";
            // 
            // tbxCountry
            // 
            this.tbxCountry.Location = new System.Drawing.Point(110, 90);
            this.tbxCountry.Name = "tbxCountry";
            this.tbxCountry.Size = new System.Drawing.Size(157, 20);
            this.tbxCountry.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Country  :";
            // 
            // btnNewCountryAdd
            // 
            this.btnNewCountryAdd.Location = new System.Drawing.Point(117, 137);
            this.btnNewCountryAdd.Name = "btnNewCountryAdd";
            this.btnNewCountryAdd.Size = new System.Drawing.Size(86, 33);
            this.btnNewCountryAdd.TabIndex = 11;
            this.btnNewCountryAdd.Text = "Add";
            this.btnNewCountryAdd.UseVisualStyleBackColor = true;
            this.btnNewCountryAdd.Click += new System.EventHandler(this.btnNewCountryAdd_Click);
            // 
            // tbxLocale
            // 
            this.tbxLocale.Location = new System.Drawing.Point(110, 41);
            this.tbxLocale.Name = "tbxLocale";
            this.tbxLocale.Size = new System.Drawing.Size(157, 20);
            this.tbxLocale.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Locale :";
            // 
            // dgwPublishers
            // 
            this.dgwPublishers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwPublishers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgwPublishers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPublishers.Location = new System.Drawing.Point(607, 338);
            this.dgwPublishers.Name = "dgwPublishers";
            this.dgwPublishers.Size = new System.Drawing.Size(270, 320);
            this.dgwPublishers.TabIndex = 42;
            // 
            // dgwDevelopers
            // 
            this.dgwDevelopers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwDevelopers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgwDevelopers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDevelopers.Location = new System.Drawing.Point(893, 338);
            this.dgwDevelopers.Name = "dgwDevelopers";
            this.dgwDevelopers.Size = new System.Drawing.Size(270, 320);
            this.dgwDevelopers.TabIndex = 43;
            // 
            // dgwCountries
            // 
            this.dgwCountries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwCountries.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgwCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCountries.Location = new System.Drawing.Point(1178, 338);
            this.dgwCountries.Name = "dgwCountries";
            this.dgwCountries.Size = new System.Drawing.Size(270, 320);
            this.dgwCountries.TabIndex = 44;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 858);
            this.Controls.Add(this.dgwCountries);
            this.Controls.Add(this.dgwDevelopers);
            this.Controls.Add(this.dgwPublishers);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxGameAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dgwGames);
            this.Name = "Form1";
            this.Text = "InexAdminPanel";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwGames)).EndInit();
            this.gbxGameAdd.ResumeLayout(false);
            this.gbxGameAdd.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPublishers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDevelopers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCountries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwGames;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox gbxGameAdd;
        private System.Windows.Forms.TextBox tbxGameSlug;
        private System.Windows.Forms.Button btnNewGameAdd;
        private System.Windows.Forms.TextBox tbxGameReleaseDate;
        private System.Windows.Forms.TextBox tbxGameThumbnailUrl;
        private System.Windows.Forms.TextBox tbxGameName;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxCountriesAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxPublishersAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxDevelopersAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNewDeveloperAdd;
        private System.Windows.Forms.TextBox tbxDeveloperName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNewPublisherAdd;
        private System.Windows.Forms.TextBox tbxPublisherName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnNewCountryAdd;
        private System.Windows.Forms.TextBox tbxLocale;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbxCountry;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgwPublishers;
        private System.Windows.Forms.DataGridView dgwDevelopers;
        private System.Windows.Forms.DataGridView dgwCountries;
    }
}

