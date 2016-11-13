namespace MovieCollectionMH
{
    partial class MainWindow
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.tbLoadExcel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btStartServer = new System.Windows.Forms.Button();
            this.tbfiletoServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tbSaveExcel = new System.Windows.Forms.TextBox();
            this.tbJsonSave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIpAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBrowseLoadExcel = new System.Windows.Forms.Button();
            this.btnBrowseSaveToExcel = new System.Windows.Forms.Button();
            this.btnBrowseSaveToJson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.AllowDrop = true;
            this.listView1.AutoArrange = false;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.listView1.LabelEdit = true;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(234, 461);
            this.listView1.TabIndex = 0;
            this.listView1.TabStop = false;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
          
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Movie";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Length";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Format";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load Excel file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbLoadExcel
            // 
            this.tbLoadExcel.Location = new System.Drawing.Point(375, 29);
            this.tbLoadExcel.Name = "tbLoadExcel";
            this.tbLoadExcel.Size = new System.Drawing.Size(289, 20);
            this.tbLoadExcel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "File to Load ";
            // 
            // btStartServer
            // 
            this.btStartServer.Location = new System.Drawing.Point(764, 450);
            this.btStartServer.Name = "btStartServer";
            this.btStartServer.Size = new System.Drawing.Size(100, 23);
            this.btStartServer.TabIndex = 4;
            this.btStartServer.Text = "Start Server";
            this.btStartServer.UseVisualStyleBackColor = true;
            this.btStartServer.Click += new System.EventHandler(this.btStartServer_Click);
            // 
            // tbfiletoServer
            // 
            this.tbfiletoServer.Location = new System.Drawing.Point(550, 419);
            this.tbfiletoServer.Name = "tbfiletoServer";
            this.tbfiletoServer.Size = new System.Drawing.Size(314, 20);
            this.tbfiletoServer.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(550, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Json File Location  To send to Android";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(265, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Save File to Excel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(265, 152);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Save File To  Json";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbSaveExcel
            // 
            this.tbSaveExcel.Location = new System.Drawing.Point(378, 86);
            this.tbSaveExcel.Name = "tbSaveExcel";
            this.tbSaveExcel.Size = new System.Drawing.Size(286, 20);
            this.tbSaveExcel.TabIndex = 9;
            // 
            // tbJsonSave
            // 
            this.tbJsonSave.Location = new System.Drawing.Point(378, 152);
            this.tbJsonSave.Name = "tbJsonSave";
            this.tbJsonSave.Size = new System.Drawing.Size(286, 20);
            this.tbJsonSave.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "File to Save to Excel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "File to Save To Json";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(438, 416);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "Browse";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(553, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "label5";
            // 
            // tbIpAddress
            // 
            this.tbIpAddress.Location = new System.Drawing.Point(553, 372);
            this.tbIpAddress.Name = "tbIpAddress";
            this.tbIpAddress.Size = new System.Drawing.Size(311, 20);
            this.tbIpAddress.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(553, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "IP Adress and Port :192.168.1.2:8080";
            // 
            // btnBrowseLoadExcel
            // 
            this.btnBrowseLoadExcel.Location = new System.Drawing.Point(671, 25);
            this.btnBrowseLoadExcel.Name = "btnBrowseLoadExcel";
            this.btnBrowseLoadExcel.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseLoadExcel.TabIndex = 17;
            this.btnBrowseLoadExcel.Text = "Browse";
            this.btnBrowseLoadExcel.UseVisualStyleBackColor = true;
            this.btnBrowseLoadExcel.Click += new System.EventHandler(this.btnBrowseLoadExcel_Click);
            // 
            // btnBrowseSaveToExcel
            // 
            this.btnBrowseSaveToExcel.Location = new System.Drawing.Point(671, 86);
            this.btnBrowseSaveToExcel.Name = "btnBrowseSaveToExcel";
            this.btnBrowseSaveToExcel.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseSaveToExcel.TabIndex = 18;
            this.btnBrowseSaveToExcel.Text = "Browse";
            this.btnBrowseSaveToExcel.UseVisualStyleBackColor = true;
            this.btnBrowseSaveToExcel.Click += new System.EventHandler(this.btnBrowseSaveToExcel_Click);
            // 
            // btnBrowseSaveToJson
            // 
            this.btnBrowseSaveToJson.Location = new System.Drawing.Point(671, 151);
            this.btnBrowseSaveToJson.Name = "btnBrowseSaveToJson";
            this.btnBrowseSaveToJson.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseSaveToJson.TabIndex = 19;
            this.btnBrowseSaveToJson.Text = "Browse";
            this.btnBrowseSaveToJson.UseVisualStyleBackColor = true;
            this.btnBrowseSaveToJson.Click += new System.EventHandler(this.btnBrowseSaveToJson_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 485);
            this.Controls.Add(this.btnBrowseSaveToJson);
            this.Controls.Add(this.btnBrowseSaveToExcel);
            this.Controls.Add(this.btnBrowseLoadExcel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbIpAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbJsonSave);
            this.Controls.Add(this.tbSaveExcel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbfiletoServer);
            this.Controls.Add(this.btStartServer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLoadExcel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbLoadExcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btStartServer;
        private System.Windows.Forms.TextBox tbfiletoServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tbSaveExcel;
        private System.Windows.Forms.TextBox tbJsonSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbIpAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBrowseLoadExcel;
        private System.Windows.Forms.Button btnBrowseSaveToExcel;
        private System.Windows.Forms.Button btnBrowseSaveToJson;
    }
}

