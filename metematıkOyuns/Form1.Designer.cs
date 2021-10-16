
namespace metematıkOyuns
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.lblIlkgrup = new System.Windows.Forms.Label();
            this.lblıkıncıGrup = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.lblıslem = new System.Windows.Forms.Label();
            this.txtıslem = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tmrsure = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hangisi Daha Büyük";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 251);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(434, 251);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // txtDurum
            // 
            this.txtDurum.Location = new System.Drawing.Point(300, 323);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(100, 20);
            this.txtDurum.TabIndex = 5;
            // 
            // lblIlkgrup
            // 
            this.lblIlkgrup.AutoSize = true;
            this.lblIlkgrup.Location = new System.Drawing.Point(181, 213);
            this.lblIlkgrup.Name = "lblIlkgrup";
            this.lblIlkgrup.Size = new System.Drawing.Size(40, 13);
            this.lblIlkgrup.TabIndex = 6;
            this.lblIlkgrup.Text = "ilkGrup";
            // 
            // lblıkıncıGrup
            // 
            this.lblıkıncıGrup.AutoSize = true;
            this.lblıkıncıGrup.Location = new System.Drawing.Point(479, 213);
            this.lblıkıncıGrup.Name = "lblıkıncıGrup";
            this.lblıkıncıGrup.Size = new System.Drawing.Size(54, 13);
            this.lblıkıncıGrup.TabIndex = 7;
            this.lblıkıncıGrup.Text = "ikinciGrup";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Location = new System.Drawing.Point(65, 149);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(32, 13);
            this.lblSure.TabIndex = 8;
            this.lblSure.Text = "Süre:";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Location = new System.Drawing.Point(499, 149);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(35, 13);
            this.lblPuan.TabIndex = 9;
            this.lblPuan.Text = "Puan:";
            // 
            // lblıslem
            // 
            this.lblıslem.AutoSize = true;
            this.lblıslem.Location = new System.Drawing.Point(323, 190);
            this.lblıslem.Name = "lblıslem";
            this.lblıslem.Size = new System.Drawing.Size(30, 13);
            this.lblıslem.TabIndex = 10;
            this.lblıslem.Text = "işlem";
            // 
            // txtıslem
            // 
            this.txtıslem.Location = new System.Drawing.Point(300, 251);
            this.txtıslem.Name = "txtıslem";
            this.txtıslem.Size = new System.Drawing.Size(100, 20);
            this.txtıslem.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(459, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tmrsure
            // 
            this.tmrsure.Interval = 1000;
            this.tmrsure.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtıslem);
            this.Controls.Add(this.lblıslem);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.lblıkıncıGrup);
            this.Controls.Add(this.lblIlkgrup);
            this.Controls.Add(this.txtDurum);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtDurum;
        private System.Windows.Forms.Label lblIlkgrup;
        private System.Windows.Forms.Label lblıkıncıGrup;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Label lblıslem;
        private System.Windows.Forms.TextBox txtıslem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer tmrsure;
    }
}

