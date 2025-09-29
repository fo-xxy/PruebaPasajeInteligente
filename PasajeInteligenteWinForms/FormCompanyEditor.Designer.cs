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
            label8 = new Label();
            lblMessage = new Label();
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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(label8);
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
            panel1.Size = new Size(909, 450);
            panel1.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Left;
            label8.Font = new Font("Segoe UI", 18F);
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(201, 32);
            label8.TabIndex = 17;
            label8.Text = "Pasaje Inteligente";
            // 
            // lblMessage
            // 
            lblMessage.Anchor = AnchorStyles.Top;
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 15F);
            lblMessage.Location = new Point(299, 22);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 28);
            lblMessage.TabIndex = 16;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F);
            btnCancel.Location = new Point(629, 183);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 30);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI", 12F);
            btnCreate.Location = new Point(629, 116);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(90, 30);
            btnCreate.TabIndex = 14;
            btnCreate.Text = "Agregar";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtCountry
            // 
            txtCountry.Font = new Font("Segoe UI", 12F);
            txtCountry.Location = new Point(353, 265);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(173, 29);
            txtCountry.TabIndex = 13;
            // 
            // txtDepartment
            // 
            txtDepartment.Font = new Font("Segoe UI", 12F);
            txtDepartment.Location = new Point(353, 185);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(173, 29);
            txtDepartment.TabIndex = 12;
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Segoe UI", 12F);
            txtCity.Location = new Point(353, 116);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(173, 29);
            txtCity.TabIndex = 11;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 12F);
            txtPhone.Location = new Point(42, 335);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(173, 29);
            txtPhone.TabIndex = 10;
            txtPhone.KeyPress += SoloNumeros_KeyPress;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 12F);
            txtAddress.Location = new Point(42, 265);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(231, 29);
            txtAddress.TabIndex = 9;
            // 
            // txtCode
            // 
            txtCode.Font = new Font("Segoe UI", 12F);
            txtCode.Location = new Point(42, 185);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(173, 29);
            txtCode.TabIndex = 8;
            txtCode.KeyPress += SoloNumeros_KeyPress;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(42, 116);
            txtName.Name = "txtName";
            txtName.Size = new Size(231, 29);
            txtName.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(353, 241);
            label7.Name = "label7";
            label7.Size = new Size(40, 21);
            label7.TabIndex = 6;
            label7.Text = "País:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(353, 161);
            label6.Name = "label6";
            label6.Size = new Size(113, 21);
            label6.TabIndex = 5;
            label6.Text = "Departamento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(353, 92);
            label5.Name = "label5";
            label5.Size = new Size(62, 21);
            label5.TabIndex = 4;
            label5.Text = "Ciudad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(42, 311);
            label4.Name = "label4";
            label4.Size = new Size(71, 21);
            label4.TabIndex = 3;
            label4.Text = "Teléfono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(42, 241);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 2;
            label3.Text = "Dirección:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(42, 161);
            label2.Name = "label2";
            label2.Size = new Size(63, 21);
            label2.TabIndex = 1;
            label2.Text = "Código:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(42, 92);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // FormCompanyEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(909, 450);
            Controls.Add(panel1);
            MaximizeBox = false;
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
        private Label label8;
    }
}