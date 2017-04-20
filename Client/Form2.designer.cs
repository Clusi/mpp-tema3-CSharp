namespace lab1
{
    partial class Form2
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.dataGridViewZbor = new System.Windows.Forms.DataGridView();
            this.zborBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtDestinatie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataPlecare = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumeClient = new System.Windows.Forms.TextBox();
            this.txtNumarLocuri = new System.Windows.Forms.TextBox();
            this.txtTuristi = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.btnAddBilet = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZbor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zborBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(513, 296);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // dataGridViewZbor
            // 
            this.dataGridViewZbor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZbor.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewZbor.Name = "dataGridViewZbor";
            this.dataGridViewZbor.Size = new System.Drawing.Size(544, 150);
            this.dataGridViewZbor.TabIndex = 1;
            // 
            // zborBindingSource
            // 
            // 
            // txtDestinatie
            // 
            this.txtDestinatie.Location = new System.Drawing.Point(93, 191);
            this.txtDestinatie.Name = "txtDestinatie";
            this.txtDestinatie.Size = new System.Drawing.Size(100, 20);
            this.txtDestinatie.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Destinatie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data plecare";
            // 
            // txtDataPlecare
            // 
            this.txtDataPlecare.CustomFormat = "yyyy-MM-dd";
            this.txtDataPlecare.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDataPlecare.Location = new System.Drawing.Point(93, 234);
            this.txtDataPlecare.Name = "txtDataPlecare";
            this.txtDataPlecare.Size = new System.Drawing.Size(100, 20);
            this.txtDataPlecare.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(47, 282);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nume client";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Numar locuri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Turisti";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Adresa";
            // 
            // txtNumeClient
            // 
            this.txtNumeClient.Location = new System.Drawing.Point(355, 169);
            this.txtNumeClient.Name = "txtNumeClient";
            this.txtNumeClient.Size = new System.Drawing.Size(100, 20);
            this.txtNumeClient.TabIndex = 11;
            // 
            // txtNumarLocuri
            // 
            this.txtNumarLocuri.Location = new System.Drawing.Point(355, 195);
            this.txtNumarLocuri.Name = "txtNumarLocuri";
            this.txtNumarLocuri.Size = new System.Drawing.Size(100, 20);
            this.txtNumarLocuri.TabIndex = 12;
            // 
            // txtTuristi
            // 
            this.txtTuristi.Location = new System.Drawing.Point(355, 225);
            this.txtTuristi.Name = "txtTuristi";
            this.txtTuristi.Size = new System.Drawing.Size(100, 20);
            this.txtTuristi.TabIndex = 13;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(355, 256);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(100, 20);
            this.txtAdresa.TabIndex = 14;
            // 
            // btnAddBilet
            // 
            this.btnAddBilet.Location = new System.Drawing.Point(311, 282);
            this.btnAddBilet.Name = "btnAddBilet";
            this.btnAddBilet.Size = new System.Drawing.Size(75, 23);
            this.btnAddBilet.TabIndex = 15;
            this.btnAddBilet.Text = "Buy Ticket";
            this.btnAddBilet.UseVisualStyleBackColor = true;
            this.btnAddBilet.Click += new System.EventHandler(this.btnAddBilet_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(513, 172);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 331);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddBilet);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtTuristi);
            this.Controls.Add(this.txtNumarLocuri);
            this.Controls.Add(this.txtNumeClient);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtDataPlecare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDestinatie);
            this.Controls.Add(this.dataGridViewZbor);
            this.Controls.Add(this.btnLogOut);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZbor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zborBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.DataGridView dataGridViewZbor;
        private System.Windows.Forms.BindingSource zborBindingSource;
        private System.Windows.Forms.TextBox txtDestinatie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtDataPlecare;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumeClient;
        private System.Windows.Forms.TextBox txtNumarLocuri;
        private System.Windows.Forms.TextBox txtTuristi;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Button btnAddBilet;
        private System.Windows.Forms.Button btnRefresh;
    }
}