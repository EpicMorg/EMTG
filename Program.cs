using System;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
namespace triforce
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    class Form1 :Form
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Char nbsp = Convert.ToChar(160), piramid = '▲';
            int cnt = Convert.ToInt32(numericUpDown1.Value);
            StringBuilder b = new StringBuilder(cnt * cnt / 2);
            for (int i = 0; i < cnt; i++)
            {
                for (int j = (cnt - i) * 2; j > 0; j--) b.Append(nbsp);
                for (int j = -1; j < i; j++) { b.Append(piramid); if(j<i-1) b.Append(' '); }
                if (i<cnt-1) b.Append("\r\n");
            }

            textBox1.Text = b.ToString();
        }
        private void InitializeComponent()
        {
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            this.numericUpDown1.Location = new System.Drawing.Point(12, 41);
            this.numericUpDown1.Minimum = 1;
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(247, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = 2;
            this.button1.Location = new System.Drawing.Point(293, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Triforce!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.textBox1.Location = new System.Drawing.Point(13, 82);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(375, 247);
            this.textBox1.TabIndex = 2;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of lines";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 332);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
            this.Text = "Triforce-Gen by EpicM.org";
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try { System.Diagnostics.Process.Start("http://ww.epicm.org/"); }
            catch { }
        }
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}
