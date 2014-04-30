using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace triforce {
    internal static class Program {
        [STAThread]
        private static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }

    internal class FrmMain : Form {
        private readonly IContainer components = null;
        private Button _button1;
        private Label _label1;
        private NumericUpDown _numericUpDown1;
        private TextBox _textBox1;

        public FrmMain() { this.InitializeComponent(); }

        protected override void Dispose(bool disposing) {
            if (disposing && (this.components != null))
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void button1_Click(object sender, EventArgs e) {
            const char nbsp = ' ';
            const char piramid = '▲';
            var cnt = Convert.ToInt32(this._numericUpDown1.Value)+1;
            var b = new StringBuilder(cnt * cnt * 4);
            for ( var i = 1; i < cnt; i++ ) {
                for ( var j = 1; j < cnt - i; j++ ) b.Append( nbsp );
                for ( var j = 0; j < i; j++ ) {
                    b.Append( piramid );
                    b.Append( nbsp );
                }
                b.Append( "\r\n" );
            }
            this._textBox1.Text = b.ToString().TrimEnd( '\r','\n', nbsp );
        }

        private void InitializeComponent() {
            this.SuspendLayout();
            this._numericUpDown1 = new NumericUpDown {
                Location = new Point(12, 41),
                Minimum = 1,
                Name = "numericUpDown1",
                Size = new Size(247, 20),
                TabIndex = 0,
                Value = 2
            };
            this._button1 = new Button {
                Location = new Point(293, 38),
                Name = "button1",
                Size = new Size(95, 23),
                TabIndex = 1,
                Text = "Triforce!",
                UseVisualStyleBackColor = true
            };
            this._button1.Click += this.button1_Click;
            this._textBox1 = new TextBox {
                Location = new Point(13, 82),
                Multiline = true,
                Name = "textBox1",
                Size = new Size(375, 247),
                TabIndex = 2
            };
            this._label1 = new Label {
                AutoSize = true,
                Location = new Point(13, 13),
                Name = "label1",
                Size = new Size(80, 13),
                TabIndex = 3,
                Text = "Number of lines"
            };
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(400, 332);
            this.Controls.AddRange(
                new Control[] {
                    this._label1,
                    this._textBox1,
                    this._button1,
                    this._numericUpDown1
                }
            );
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.FormClosed += this.Form1_FormClosed;
            this.Text = "Triforce-Gen by EpicM.org";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            try { Process.Start("http://ww.epicm.org/"); }
            catch { }
        }
    }
}