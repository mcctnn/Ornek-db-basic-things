namespace WinFormsApp1
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
            this.dgwAuthors = new System.Windows.Forms.DataGridView();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxPhonenumber = new System.Windows.Forms.TextBox();
            this.tbxLastname = new System.Windows.Forms.TextBox();
            this.tbxFirstname = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.tbxPhonenumber2 = new System.Windows.Forms.TextBox();
            this.tbxLastname2 = new System.Windows.Forms.TextBox();
            this.tbxFirstname2 = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblPhoneNumber2 = new System.Windows.Forms.Label();
            this.lblLastname2 = new System.Windows.Forms.Label();
            this.lblFirstName2 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAuthors)).BeginInit();
            this.gbxAdd.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwAuthors
            // 
            this.dgwAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAuthors.Location = new System.Drawing.Point(28, 12);
            this.dgwAuthors.Name = "dgwAuthors";
            this.dgwAuthors.RowTemplate.Height = 25;
            this.dgwAuthors.Size = new System.Drawing.Size(700, 150);
            this.dgwAuthors.TabIndex = 0;
            this.dgwAuthors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAuthors_CellClick);
            this.dgwAuthors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAuthors_CellContentClick);
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.tbxPhonenumber);
            this.gbxAdd.Controls.Add(this.tbxLastname);
            this.gbxAdd.Controls.Add(this.tbxFirstname);
            this.gbxAdd.Controls.Add(this.lblPhoneNumber);
            this.gbxAdd.Controls.Add(this.lblLastName);
            this.gbxAdd.Controls.Add(this.lblFirstName);
            this.gbxAdd.Location = new System.Drawing.Point(28, 216);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(700, 100);
            this.gbxAdd.TabIndex = 1;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Yazar ekle";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(393, 55);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 39);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxPhonenumber
            // 
            this.tbxPhonenumber.Location = new System.Drawing.Point(379, 22);
            this.tbxPhonenumber.Name = "tbxPhonenumber";
            this.tbxPhonenumber.Size = new System.Drawing.Size(148, 23);
            this.tbxPhonenumber.TabIndex = 5;
            // 
            // tbxLastname
            // 
            this.tbxLastname.Location = new System.Drawing.Point(121, 58);
            this.tbxLastname.Name = "tbxLastname";
            this.tbxLastname.Size = new System.Drawing.Size(148, 23);
            this.tbxLastname.TabIndex = 4;
            // 
            // tbxFirstname
            // 
            this.tbxFirstname.Location = new System.Drawing.Point(121, 24);
            this.tbxFirstname.Name = "tbxFirstname";
            this.tbxFirstname.Size = new System.Drawing.Size(148, 23);
            this.tbxFirstname.TabIndex = 3;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(301, 27);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(62, 15);
            this.lblPhoneNumber.TabIndex = 2;
            this.lblPhoneNumber.Text = "İletişim no";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(25, 64);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(48, 15);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Soyisim";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(25, 27);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(29, 15);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "İsim";
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.tbxPhonenumber2);
            this.gbxUpdate.Controls.Add(this.tbxLastname2);
            this.gbxUpdate.Controls.Add(this.tbxFirstname2);
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.lblPhoneNumber2);
            this.gbxUpdate.Controls.Add(this.lblLastname2);
            this.gbxUpdate.Controls.Add(this.lblFirstName2);
            this.gbxUpdate.Location = new System.Drawing.Point(28, 322);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(700, 100);
            this.gbxUpdate.TabIndex = 2;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Yazar güncelle";
            // 
            // tbxPhonenumber2
            // 
            this.tbxPhonenumber2.Location = new System.Drawing.Point(379, 22);
            this.tbxPhonenumber2.Name = "tbxPhonenumber2";
            this.tbxPhonenumber2.Size = new System.Drawing.Size(148, 23);
            this.tbxPhonenumber2.TabIndex = 6;
            // 
            // tbxLastname2
            // 
            this.tbxLastname2.Location = new System.Drawing.Point(121, 60);
            this.tbxLastname2.Name = "tbxLastname2";
            this.tbxLastname2.Size = new System.Drawing.Size(148, 23);
            this.tbxLastname2.TabIndex = 5;
            // 
            // tbxFirstname2
            // 
            this.tbxFirstname2.Location = new System.Drawing.Point(121, 22);
            this.tbxFirstname2.Name = "tbxFirstname2";
            this.tbxFirstname2.Size = new System.Drawing.Size(148, 23);
            this.tbxFirstname2.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(393, 59);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 31);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblPhoneNumber2
            // 
            this.lblPhoneNumber2.AutoSize = true;
            this.lblPhoneNumber2.Location = new System.Drawing.Point(301, 28);
            this.lblPhoneNumber2.Name = "lblPhoneNumber2";
            this.lblPhoneNumber2.Size = new System.Drawing.Size(62, 15);
            this.lblPhoneNumber2.TabIndex = 2;
            this.lblPhoneNumber2.Text = "İletişim no";
            // 
            // lblLastname2
            // 
            this.lblLastname2.AutoSize = true;
            this.lblLastname2.Location = new System.Drawing.Point(50, 67);
            this.lblLastname2.Name = "lblLastname2";
            this.lblLastname2.Size = new System.Drawing.Size(48, 15);
            this.lblLastname2.TabIndex = 1;
            this.lblLastname2.Text = "Soyisim";
            // 
            // lblFirstName2
            // 
            this.lblFirstName2.AutoSize = true;
            this.lblFirstName2.Location = new System.Drawing.Point(50, 28);
            this.lblFirstName2.Name = "lblFirstName2";
            this.lblFirstName2.Size = new System.Drawing.Size(29, 15);
            this.lblFirstName2.TabIndex = 0;
            this.lblFirstName2.Text = "İsim";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(516, 168);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(153, 32);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Sil";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgwAuthors);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAuthors)).EndInit();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgwAuthors;
        private GroupBox gbxAdd;
        private Button btnAdd;
        private TextBox tbxPhonenumber;
        private TextBox tbxLastname;
        private TextBox tbxFirstname;
        private Label lblPhoneNumber;
        private Label lblLastName;
        private Label lblFirstName;
        private GroupBox gbxUpdate;
        private TextBox tbxPhonenumber2;
        private TextBox tbxLastname2;
        private TextBox tbxFirstname2;
        private Button btnUpdate;
        private Label lblPhoneNumber2;
        private Label lblLastname2;
        private Label lblFirstName2;
        private Button btnRemove;
    }
}