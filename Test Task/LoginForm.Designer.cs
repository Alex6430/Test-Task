namespace Test_Task
{
    partial class LoginForm
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
            this.button_enter = new System.Windows.Forms.Button();
            this.PassFild = new System.Windows.Forms.TextBox();
            this.LogFild = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.RegLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.RegLabel);
            this.panel1.Controls.Add(this.button_enter);
            this.panel1.Controls.Add(this.PassFild);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.LogFild);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 446);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // button_enter
            // 
            this.button_enter.BackColor = System.Drawing.Color.Black;
            this.button_enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_enter.ForeColor = System.Drawing.Color.Red;
            this.button_enter.Location = new System.Drawing.Point(166, 331);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(133, 58);
            this.button_enter.TabIndex = 5;
            this.button_enter.Text = "войти\r\n\r\n";
            this.button_enter.UseVisualStyleBackColor = false;
            this.button_enter.Click += new System.EventHandler(this.button_enter_Click);
            // 
            // PassFild
            // 
            this.PassFild.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassFild.Location = new System.Drawing.Point(101, 245);
            this.PassFild.Name = "PassFild";
            this.PassFild.PasswordChar = '*';
            this.PassFild.Size = new System.Drawing.Size(320, 53);
            this.PassFild.TabIndex = 4;
            this.PassFild.UseSystemPasswordChar = true;
            // 
            // LogFild
            // 
            this.LogFild.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogFild.Location = new System.Drawing.Point(101, 124);
            this.LogFild.Multiline = true;
            this.LogFild.Name = "LogFild";
            this.LogFild.Size = new System.Drawing.Size(320, 64);
            this.LogFild.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(462, 100);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegLabel
            // 
            this.RegLabel.AutoSize = true;
            this.RegLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegLabel.ForeColor = System.Drawing.Color.Blue;
            this.RegLabel.Location = new System.Drawing.Point(127, 412);
            this.RegLabel.Name = "RegLabel";
            this.RegLabel.Size = new System.Drawing.Size(215, 25);
            this.RegLabel.TabIndex = 6;
            this.RegLabel.Text = "У вас нет аккаунта?";
            this.RegLabel.Click += new System.EventHandler(this.RegLabel_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Test_Task.Properties.Resources.icon_lock;
            this.pictureBox2.InitialImage = global::Test_Task.Properties.Resources.icon_user;
            this.pictureBox2.Location = new System.Drawing.Point(31, 245);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Test_Task.Properties.Resources.icon_user;
            this.pictureBox1.InitialImage = global::Test_Task.Properties.Resources.icon_user;
            this.pictureBox1.Location = new System.Drawing.Point(31, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 446);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox PassFild;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox LogFild;
        private System.Windows.Forms.Button button_enter;
        private System.Windows.Forms.Label RegLabel;
    }
}