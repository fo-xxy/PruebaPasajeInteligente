namespace PasajeInteligenteWinForms
{
    partial class FormCompanyEditor
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
            panel1 = new Panel();
            btnCancel = new Button();
            btnCreate = new Button();
            txtCountry = new TextBox();
            txtDepartment = new TextBox();
            txtCity = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            txtCode = new TextBox();
            txtName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblMessage = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblMessage);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnCreate);
            panel1.Controls.Add(txtCountry);
            panel1.Controls.Add(txtDepartment);
            panel1.Controls.Add(txtCity);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(txtCode);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(591, 187);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(591, 132);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 14;
            btnCreate.Text = "Agregar";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(307, 245);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(100, 23);
            txtCountry.TabIndex = 13;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(307, 175);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(100, 23);
            txtDepartment.TabIndex = 12;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(307, 95);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(100, 23);
            txtCity.TabIndex = 11;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(43, 309);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 10;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(43, 239);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 23);
            txtAddress.TabIndex = 9;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(43, 159);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(100, 23);
            txtCode.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(43, 90);
            txtName.Name = "txtName";
            txtName.Size = new Size(176, 23);
            txtName.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(307, 219);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 6;
            label7.Text = "País:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(307, 141);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 5;
            label6.Text = "Departamento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(307, 72);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 4;
            label5.Text = "Ciudad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 283);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 3;
            label4.Text = "Teléfono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 205);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Dirección:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 136);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Código:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 72);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(353, 23);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 15);
            lblMessage.TabIndex = 16;
            // 
            // FormCompanyEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FormCompanyEditor";
            Text = "FormCompanyEditor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtAddress;
        private TextBox txtCode;
        private TextBox txtName;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtCountry;
        private TextBox txtDepartment;
        private TextBox txtCity;
        private TextBox txtPhone;
        private Button btnCancel;
        private Button btnCreate;
        private Label lblMessage;
    }
}