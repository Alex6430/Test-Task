namespace Test_Task
{
    partial class RegistrationForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PhoneFild = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.NameFild = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.PassFild1 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button_reg = new System.Windows.Forms.Button();
            this.PassFild = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LogFild = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.PhoneFild);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.NameFild);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.PassFild1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.button_reg);
            this.panel1.Controls.Add(this.PassFild);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.LogFild);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 687);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // PhoneFild
            // 
            this.PhoneFild.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneFild.Location = new System.Drawing.Point(102, 361);
            this.PhoneFild.Multiline = true;
            this.PhoneFild.Name = "PhoneFild";
            this.PhoneFild.Size = new System.Drawing.Size(438, 64);
            this.PhoneFild.TabIndex = 12;
            this.PhoneFild.Enter += new System.EventHandler(this.PhoneFild_Enter);
            this.PhoneFild.Leave += new System.EventHandler(this.PhoneFild_Leave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Test_Task.Properties.Resources.icon_phone;
            this.pictureBox5.InitialImage = global::Test_Task.Properties.Resources.icon_phone;
            this.pictureBox5.Location = new System.Drawing.Point(22, 361);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(64, 64);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // NameFild
            // 
            this.NameFild.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameFild.Location = new System.Drawing.Point(102, 143);
            this.NameFild.Multiline = true;
            this.NameFild.Name = "NameFild";
            this.NameFild.Size = new System.Drawing.Size(438, 64);
            this.NameFild.TabIndex = 10;
            this.NameFild.Enter += new System.EventHandler(this.NameFild_Enter);
            this.NameFild.Leave += new System.EventHandler(this.NameFild_Leave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Test_Task.Properties.Resources.icon_user;
            this.pictureBox4.InitialImage = global::Test_Task.Properties.Resources.icon_user;
            this.pictureBox4.Location = new System.Drawing.Point(22, 143);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 64);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // PassFild1
            // 
            this.PassFild1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassFild1.Location = new System.Drawing.Point(102, 534);
            this.PassFild1.Name = "PassFild1";
            this.PassFild1.Size = new System.Drawing.Size(438, 53);
            this.PassFild1.TabIndex = 8;
            this.PassFild1.UseSystemPasswordChar = true;
            this.PassFild1.Enter += new System.EventHandler(this.PassFild1_Enter);
            this.PassFild1.Leave += new System.EventHandler(this.PassFild1_Leave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Test_Task.Properties.Resources.icon_lock;
            this.pictureBox3.InitialImage = global::Test_Task.Properties.Resources.icon_user;
            this.pictureBox3.Location = new System.Drawing.Point(22, 534);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // button_reg
            // 
            this.button_reg.BackColor = System.Drawing.Color.Black;
            this.button_reg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_reg.ForeColor = System.Drawing.Color.Red;
            this.button_reg.Location = new System.Drawing.Point(172, 607);
            this.button_reg.Name = "button_reg";
            this.button_reg.Size = new System.Drawing.Size(244, 58);
            this.button_reg.TabIndex = 6;
            this.button_reg.Text = "регистрация";
            this.button_reg.UseVisualStyleBackColor = false;
            this.button_reg.Click += new System.EventHandler(this.button_reg_Click);
            // 
            // PassFild
            // 
            this.PassFild.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassFild.Location = new System.Drawing.Point(102, 460);
            this.PassFild.Name = "PassFild";
            this.PassFild.Size = new System.Drawing.Size(438, 53);
            this.PassFild.TabIndex = 4;
            this.PassFild.UseSystemPasswordChar = true;
            this.PassFild.Enter += new System.EventHandler(this.PassFild_Enter);
            this.PassFild.Leave += new System.EventHandler(this.PassFild_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Test_Task.Properties.Resources.icon_lock;
            this.pictureBox2.InitialImage = global::Test_Task.Properties.Resources.icon_user;
            this.pictureBox2.Location = new System.Drawing.Point(22, 460);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // LogFild
            // 
            this.LogFild.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogFild.Location = new System.Drawing.Point(102, 255);
            this.LogFild.Multiline = true;
            this.LogFild.Name = "LogFild";
            this.LogFild.Size = new System.Drawing.Size(438, 64);
            this.LogFild.TabIndex = 2;
            this.LogFild.Enter += new System.EventHandler(this.LogFild_Enter);
            this.LogFild.Leave += new System.EventHandler(this.LogFild_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Test_Task.Properties.Resources.icon_user;
            this.pictureBox1.InitialImage = global::Test_Task.Properties.Resources.icon_user;
            this.pictureBox1.Location = new System.Drawing.Point(22, 255);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(562, 100);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(562, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "назад";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 687);
            this.Controls.Add(this.panel1);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrationForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox PassFild;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox LogFild;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PassFild1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button_reg;
        private System.Windows.Forms.TextBox NameFild;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox PhoneFild;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label2;
    }
}