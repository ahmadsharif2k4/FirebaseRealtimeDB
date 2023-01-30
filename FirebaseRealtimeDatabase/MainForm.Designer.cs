namespace FirebaseRealtimeDatabase
{
    partial class MainForm
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
            this.grpbox = new System.Windows.Forms.GroupBox();
            this.txtRegisteration = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDegreeProgram = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblRegisteration = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDegree = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.gridStudents = new System.Windows.Forms.DataGridView();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.grpbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbox
            // 
            this.grpbox.Controls.Add(this.btnRegister);
            this.grpbox.Controls.Add(this.lblAddress);
            this.grpbox.Controls.Add(this.lblPhone);
            this.grpbox.Controls.Add(this.lblDegree);
            this.grpbox.Controls.Add(this.lblName);
            this.grpbox.Controls.Add(this.lblRegisteration);
            this.grpbox.Controls.Add(this.txtAddress);
            this.grpbox.Controls.Add(this.txtPhone);
            this.grpbox.Controls.Add(this.txtDegreeProgram);
            this.grpbox.Controls.Add(this.txtName);
            this.grpbox.Controls.Add(this.txtRegisteration);
            this.grpbox.Location = new System.Drawing.Point(12, 12);
            this.grpbox.Name = "grpbox";
            this.grpbox.Size = new System.Drawing.Size(776, 190);
            this.grpbox.TabIndex = 0;
            this.grpbox.TabStop = false;
            this.grpbox.Text = "CRUD Operation With Firebase";
            // 
            // txtRegisteration
            // 
            this.txtRegisteration.Enabled = false;
            this.txtRegisteration.Location = new System.Drawing.Point(135, 30);
            this.txtRegisteration.Name = "txtRegisteration";
            this.txtRegisteration.Size = new System.Drawing.Size(220, 22);
            this.txtRegisteration.TabIndex = 0;
            this.txtRegisteration.Text = "1";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(477, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(220, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtDegreeProgram
            // 
            this.txtDegreeProgram.Location = new System.Drawing.Point(135, 58);
            this.txtDegreeProgram.Name = "txtDegreeProgram";
            this.txtDegreeProgram.Size = new System.Drawing.Size(220, 22);
            this.txtDegreeProgram.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(477, 58);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(220, 22);
            this.txtPhone.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(135, 86);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(562, 53);
            this.txtAddress.TabIndex = 4;
            // 
            // lblRegisteration
            // 
            this.lblRegisteration.AutoSize = true;
            this.lblRegisteration.Location = new System.Drawing.Point(20, 33);
            this.lblRegisteration.Name = "lblRegisteration";
            this.lblRegisteration.Size = new System.Drawing.Size(100, 16);
            this.lblRegisteration.TabIndex = 5;
            this.lblRegisteration.Text = "Registration No";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(361, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(92, 16);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Student Name";
            // 
            // lblDegree
            // 
            this.lblDegree.AutoSize = true;
            this.lblDegree.Location = new System.Drawing.Point(20, 61);
            this.lblDegree.Name = "lblDegree";
            this.lblDegree.Size = new System.Drawing.Size(109, 16);
            this.lblDegree.TabIndex = 7;
            this.lblDegree.Text = "Degree/Program";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(361, 61);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(73, 16);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "Contact No";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(20, 89);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 16);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "Address";
            // 
            // gridStudents
            // 
            this.gridStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStudents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridStudents.Location = new System.Drawing.Point(0, 245);
            this.gridStudents.Name = "gridStudents";
            this.gridStudents.RowHeadersWidth = 51;
            this.gridStudents.RowTemplate.Height = 24;
            this.gridStudents.Size = new System.Drawing.Size(800, 205);
            this.gridStudents.TabIndex = 1;
            this.gridStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridStudents_CellContentClick);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(622, 145);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 39);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(12, 208);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(100, 31);
            this.btnDeleteAll.TabIndex = 11;
            this.btnDeleteAll.Text = "Delete All";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.gridStudents);
            this.Controls.Add(this.grpbox);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firebase-Realtime Database";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.grpbox.ResumeLayout(false);
            this.grpbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbox;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRegisteration;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtDegreeProgram;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtRegisteration;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblDegree;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.DataGridView gridStudents;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnDeleteAll;
    }
}

