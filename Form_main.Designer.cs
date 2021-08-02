using System.Windows.Forms;

namespace VolandoBoy_printer
{
    partial class Form_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.label_error = new System.Windows.Forms.Label();
            this.panel_login = new System.Windows.Forms.Panel();
            this.button_login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.input_password = new System.Windows.Forms.TextBox();
            this.input_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_pooling = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.select_printer = new System.Windows.Forms.ComboBox();
            this.check_duplicate = new System.Windows.Forms.CheckBox();
            this.panel_log = new System.Windows.Forms.Panel();
            this.label_log = new System.Windows.Forms.Label();
            this.button_test_printer = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_rest_name = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.panel_login.SuspendLayout();
            this.panel_pooling.SuspendLayout();
            this.panel_log.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_error
            // 
            this.label_error.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_error.BackColor = System.Drawing.Color.Red;
            this.label_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_error.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_error.Location = new System.Drawing.Point(0, 0);
            this.label_error.Margin = new System.Windows.Forms.Padding(0);
            this.label_error.Name = "label_error";
            this.label_error.Padding = new System.Windows.Forms.Padding(10);
            this.label_error.Size = new System.Drawing.Size(826, 51);
            this.label_error.TabIndex = 0;
            this.label_error.Text = "Error";
            this.label_error.Visible = false;
            // 
            // panel_login
            // 
            this.panel_login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_login.Controls.Add(this.button_login);
            this.panel_login.Controls.Add(this.label3);
            this.panel_login.Controls.Add(this.label2);
            this.panel_login.Controls.Add(this.input_password);
            this.panel_login.Controls.Add(this.input_email);
            this.panel_login.Controls.Add(this.label1);
            this.panel_login.Location = new System.Drawing.Point(-5, 0);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(831, 436);
            this.panel_login.TabIndex = 2;
            this.panel_login.Visible = false;
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.Location = new System.Drawing.Point(551, 343);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(98, 42);
            this.button_login.TabIndex = 5;
            this.button_login.Text = "OK";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(173, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(169, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Correo electrónico";
            // 
            // input_password
            // 
            this.input_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.input_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_password.Location = new System.Drawing.Point(173, 273);
            this.input_password.MaxLength = 32;
            this.input_password.Name = "input_password";
            this.input_password.PasswordChar = '*';
            this.input_password.Size = new System.Drawing.Size(476, 35);
            this.input_password.TabIndex = 2;
            // 
            // input_email
            // 
            this.input_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.input_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_email.Location = new System.Drawing.Point(173, 180);
            this.input_email.MaxLength = 32;
            this.input_email.Name = "input_email";
            this.input_email.Size = new System.Drawing.Size(476, 35);
            this.input_email.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(166, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inciar sesión";
            // 
            // panel_pooling
            // 
            this.panel_pooling.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_pooling.BackColor = System.Drawing.Color.Transparent;
            this.panel_pooling.Controls.Add(this.label4);
            this.panel_pooling.Controls.Add(this.select_printer);
            this.panel_pooling.Controls.Add(this.check_duplicate);
            this.panel_pooling.Controls.Add(this.panel_log);
            this.panel_pooling.Controls.Add(this.button_test_printer);
            this.panel_pooling.Controls.Add(this.button_logout);
            this.panel_pooling.Controls.Add(this.panel1);
            this.panel_pooling.Location = new System.Drawing.Point(-5, 0);
            this.panel_pooling.Name = "panel_pooling";
            this.panel_pooling.Padding = new System.Windows.Forms.Padding(5);
            this.panel_pooling.Size = new System.Drawing.Size(836, 436);
            this.panel_pooling.TabIndex = 3;
            this.panel_pooling.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(379, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Impresora";
            // 
            // select_printer
            // 
            this.select_printer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.select_printer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_printer.Items.AddRange(new object[] {
            ""});
            this.select_printer.Location = new System.Drawing.Point(384, 391);
            this.select_printer.Name = "select_printer";
            this.select_printer.Size = new System.Drawing.Size(289, 28);
            this.select_printer.Sorted = true;
            this.select_printer.TabIndex = 0;
            this.select_printer.SelectedIndexChanged += new System.EventHandler(this.select_printer_SelectedIndexChanged);
            // 
            // check_duplicate
            // 
            this.check_duplicate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.check_duplicate.AutoSize = true;
            this.check_duplicate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_duplicate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.check_duplicate.Location = new System.Drawing.Point(152, 370);
            this.check_duplicate.Name = "check_duplicate";
            this.check_duplicate.Size = new System.Drawing.Size(202, 33);
            this.check_duplicate.TabIndex = 6;
            this.check_duplicate.Text = "Duplicar tickets";
            this.check_duplicate.UseVisualStyleBackColor = true;
            this.check_duplicate.CheckedChanged += new System.EventHandler(this.check_duplicate_CheckedChanged);
            // 
            // panel_log
            // 
            this.panel_log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_log.AutoScroll = true;
            this.panel_log.BackColor = System.Drawing.Color.Transparent;
            this.panel_log.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_log.Controls.Add(this.label_log);
            this.panel_log.Location = new System.Drawing.Point(18, 111);
            this.panel_log.Name = "panel_log";
            this.panel_log.Padding = new System.Windows.Forms.Padding(10);
            this.panel_log.Size = new System.Drawing.Size(799, 220);
            this.panel_log.TabIndex = 4;
            // 
            // label_log
            // 
            this.label_log.AutoSize = true;
            this.label_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_log.ForeColor = System.Drawing.Color.White;
            this.label_log.Location = new System.Drawing.Point(14, 14);
            this.label_log.Name = "label_log";
            this.label_log.Size = new System.Drawing.Size(73, 25);
            this.label_log.TabIndex = 0;
            this.label_log.Text = "log line";
            // 
            // button_test_printer
            // 
            this.button_test_printer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_test_printer.BackColor = System.Drawing.Color.MistyRose;
            this.button_test_printer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_test_printer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_test_printer.Location = new System.Drawing.Point(18, 356);
            this.button_test_printer.Name = "button_test_printer";
            this.button_test_printer.Size = new System.Drawing.Size(119, 63);
            this.button_test_printer.TabIndex = 1;
            this.button_test_printer.Text = "Test impresora";
            this.button_test_printer.UseVisualStyleBackColor = false;
            this.button_test_printer.Click += new System.EventHandler(this.button_test_printer_Click);
            // 
            // button_logout
            // 
            this.button_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_logout.BackColor = System.Drawing.Color.Red;
            this.button_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_logout.Location = new System.Drawing.Point(718, 356);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(99, 65);
            this.button_logout.TabIndex = 0;
            this.button_logout.Text = "Cerrar sessión";
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label_rest_name);
            this.panel1.Controls.Add(this.label_status);
            this.panel1.Location = new System.Drawing.Point(-11, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 98);
            this.panel1.TabIndex = 5;
            // 
            // label_rest_name
            // 
            this.label_rest_name.AutoSize = true;
            this.label_rest_name.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rest_name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_rest_name.Location = new System.Drawing.Point(17, 10);
            this.label_rest_name.Name = "label_rest_name";
            this.label_rest_name.Size = new System.Drawing.Size(258, 36);
            this.label_rest_name.TabIndex = 3;
            this.label_rest_name.Text = "Restaurant name";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_status.Location = new System.Drawing.Point(19, 63);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(99, 29);
            this.label_status.TabIndex = 2;
            this.label_status.Text = "Status: ";
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(825, 435);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.panel_login);
            this.Controls.Add(this.panel_pooling);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_main";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "VolandoBoy";
            this.Load += new System.EventHandler(this.Form_main_Load);
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            this.panel_pooling.ResumeLayout(false);
            this.panel_pooling.PerformLayout();
            this.panel_log.ResumeLayout(false);
            this.panel_log.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input_password;
        private System.Windows.Forms.TextBox input_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Panel panel_pooling;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_test_printer;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label_rest_name;
        private System.Windows.Forms.Panel panel_log;
        private System.Windows.Forms.Label label_log;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox check_duplicate;
        private System.Windows.Forms.ComboBox select_printer;
        private Label label4;
    }
}

