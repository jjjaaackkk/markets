using markets.Addons;

namespace markets
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
            pTouchable = new Panel();
            btnClose = new RoundedButton();
            txtAppName = new Label();
            panel2 = new Panel();
            cbPairs = new ComboBox();
            label1 = new Label();
            tbBinancePrice = new TextBox();
            panel1 = new Panel();
            label3 = new Label();
            tbBybitPrice = new TextBox();
            panel3 = new Panel();
            label2 = new Label();
            panel4 = new Panel();
            tbKucoinPrice = new TextBox();
            label4 = new Label();
            panel5 = new Panel();
            tbBitgetPrice = new TextBox();
            label5 = new Label();
            pTouchable.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // pTouchable
            // 
            pTouchable.BackColor = Color.FromArgb(192, 64, 0);
            pTouchable.Controls.Add(btnClose);
            pTouchable.Controls.Add(txtAppName);
            pTouchable.Dock = DockStyle.Top;
            pTouchable.Location = new Point(1, 1);
            pTouchable.Name = "pTouchable";
            pTouchable.Size = new Size(257, 42);
            pTouchable.TabIndex = 0;
            pTouchable.MouseDown += pTouchable_MouseDown;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.ButtonFace;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnClose.ForeColor = Color.FromArgb(192, 64, 0);
            btnClose.Location = new Point(224, 6);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 30);
            btnClose.TabIndex = 1;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // txtAppName
            // 
            txtAppName.AutoSize = true;
            txtAppName.Font = new Font("OpenSymbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAppName.ForeColor = SystemColors.ButtonFace;
            txtAppName.Location = new Point(8, 14);
            txtAppName.Name = "txtAppName";
            txtAppName.Size = new Size(50, 16);
            txtAppName.TabIndex = 0;
            txtAppName.Text = "label1";
            txtAppName.MouseDown += txtAppName_MouseDown;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(cbPairs);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(1, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(257, 73);
            panel2.TabIndex = 1;
            // 
            // cbPairs
            // 
            cbPairs.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbPairs.FormattingEnabled = true;
            cbPairs.Location = new Point(53, 23);
            cbPairs.Name = "cbPairs";
            cbPairs.Size = new Size(131, 25);
            cbPairs.TabIndex = 1;
            cbPairs.SelectedIndexChanged += cbPairs_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("OpenSymbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 25);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 3;
            label1.Text = "Pair";
            // 
            // tbBinancePrice
            // 
            tbBinancePrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbBinancePrice.Location = new Point(84, 8);
            tbBinancePrice.Name = "tbBinancePrice";
            tbBinancePrice.Size = new Size(100, 25);
            tbBinancePrice.TabIndex = 2;
            tbBinancePrice.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(tbBinancePrice);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(1, 116);
            panel1.Name = "panel1";
            panel1.Size = new Size(257, 44);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("OpenSymbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(11, 10);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 3;
            label3.Text = "Binance";
            // 
            // tbBybitPrice
            // 
            tbBybitPrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbBybitPrice.Location = new Point(85, 10);
            tbBybitPrice.Name = "tbBybitPrice";
            tbBybitPrice.Size = new Size(100, 25);
            tbBybitPrice.TabIndex = 2;
            tbBybitPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(tbBybitPrice);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(1, 160);
            panel3.Name = "panel3";
            panel3.Size = new Size(257, 44);
            panel3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("OpenSymbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 3;
            label2.Text = "ByBit";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(tbKucoinPrice);
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(1, 204);
            panel4.Name = "panel4";
            panel4.Size = new Size(257, 44);
            panel4.TabIndex = 4;
            // 
            // tbKucoinPrice
            // 
            tbKucoinPrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbKucoinPrice.Location = new Point(85, 9);
            tbKucoinPrice.Name = "tbKucoinPrice";
            tbKucoinPrice.Size = new Size(100, 25);
            tbKucoinPrice.TabIndex = 2;
            tbKucoinPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("OpenSymbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 11);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 3;
            label4.Text = "Kucoin";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(tbBitgetPrice);
            panel5.Controls.Add(label5);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(1, 248);
            panel5.Name = "panel5";
            panel5.Size = new Size(257, 44);
            panel5.TabIndex = 5;
            // 
            // tbBitgetPrice
            // 
            tbBitgetPrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbBitgetPrice.Location = new Point(85, 9);
            tbBitgetPrice.Name = "tbBitgetPrice";
            tbBitgetPrice.Size = new Size(100, 25);
            tbBitgetPrice.TabIndex = 2;
            tbBitgetPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("OpenSymbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 11);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 3;
            label5.Text = "Bitget";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 64, 0);
            ClientSize = new Size(259, 326);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(pTouchable);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Padding = new Padding(1);
            Text = "Form1";
            Load += Form1_Load;
            pTouchable.ResumeLayout(false);
            pTouchable.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pTouchable;
        private Label txtAppName;
        private Panel panel2;
        private RoundedButton btnClose;
        private Panel panel1;
        private ComboBox cbPairs;
        private TextBox tbBinancePrice;
        private TextBox tbBybitPrice;
        private Label label3;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private Panel panel4;
        private TextBox tbKucoinPrice;
        private Label label4;
        private Panel panel5;
        private TextBox tbBitgetPrice;
        private Label label5;
    }
}
