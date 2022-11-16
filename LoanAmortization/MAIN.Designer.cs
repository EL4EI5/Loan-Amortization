namespace LoanAmortization
{
    partial class MAIN
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
            this.DGV = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SEL = new System.Windows.Forms.TextBox();
            this.CAL_BTN = new System.Windows.Forms.Button();
            this.SEL_STR = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TTL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AMO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RAT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MON = new System.Windows.Forms.TextBox();
            this.DAT = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.INT_BOX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BAL = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.REQ = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.INS = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.COS = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AllowUserToOrderColumns = true;
            this.DGV.AllowUserToResizeRows = false;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.DGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGV.Location = new System.Drawing.Point(0, 191);
            this.DGV.Margin = new System.Windows.Forms.Padding(4);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersVisible = false;
            this.DGV.Size = new System.Drawing.Size(1200, 329);
            this.DGV.TabIndex = 0;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 35.533F;
            this.Column7.HeaderText = "No.";
            this.Column7.Name = "Column7";
            // 
            // Column1
            // 
            this.Column1.FillWeight = 110.7445F;
            this.Column1.HeaderText = "Payment Date";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 110.7445F;
            this.Column2.HeaderText = "Begining Balance";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.FillWeight = 110.7445F;
            this.Column3.HeaderText = "Installment";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.FillWeight = 110.7445F;
            this.Column4.HeaderText = "Principal";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.FillWeight = 110.7445F;
            this.Column5.HeaderText = "Interest";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.FillWeight = 110.7445F;
            this.Column6.HeaderText = "Ending Balance";
            this.Column6.Name = "Column6";
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(714, 11);
            this.textBox.Margin = new System.Windows.Forms.Padding(4);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(473, 169);
            this.textBox.TabIndex = 3;
            // 
            // SEL
            // 
            this.SEL.Location = new System.Drawing.Point(569, 71);
            this.SEL.Margin = new System.Windows.Forms.Padding(4);
            this.SEL.Name = "SEL";
            this.SEL.ReadOnly = true;
            this.SEL.Size = new System.Drawing.Size(135, 22);
            this.SEL.TabIndex = 9;
            // 
            // CAL_BTN
            // 
            this.CAL_BTN.Location = new System.Drawing.Point(16, 139);
            this.CAL_BTN.Name = "CAL_BTN";
            this.CAL_BTN.Size = new System.Drawing.Size(250, 30);
            this.CAL_BTN.TabIndex = 10;
            this.CAL_BTN.Text = "Calculate";
            this.CAL_BTN.UseVisualStyleBackColor = true;
            this.CAL_BTN.Click += new System.EventHandler(this.CAL_BTN_Click);
            // 
            // SEL_STR
            // 
            this.SEL_STR.Location = new System.Drawing.Point(339, 11);
            this.SEL_STR.Margin = new System.Windows.Forms.Padding(4);
            this.SEL_STR.Name = "SEL_STR";
            this.SEL_STR.Size = new System.Drawing.Size(135, 22);
            this.SEL_STR.TabIndex = 11;
            this.SEL_STR.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Index";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Comulative";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(491, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Total";
            // 
            // TTL
            // 
            this.TTL.Location = new System.Drawing.Point(569, 41);
            this.TTL.Margin = new System.Windows.Forms.Padding(4);
            this.TTL.Name = "TTL";
            this.TTL.ReadOnly = true;
            this.TTL.Size = new System.Drawing.Size(135, 22);
            this.TTL.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Amount";
            // 
            // AMO
            // 
            this.AMO.Location = new System.Drawing.Point(97, 11);
            this.AMO.Margin = new System.Windows.Forms.Padding(4);
            this.AMO.Name = "AMO";
            this.AMO.Size = new System.Drawing.Size(169, 22);
            this.AMO.TabIndex = 16;
            this.AMO.Text = "108030";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Rate";
            // 
            // RAT
            // 
            this.RAT.Location = new System.Drawing.Point(97, 41);
            this.RAT.Margin = new System.Windows.Forms.Padding(4);
            this.RAT.Name = "RAT";
            this.RAT.Size = new System.Drawing.Size(169, 22);
            this.RAT.TabIndex = 18;
            this.RAT.Text = "17.0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Months";
            // 
            // MON
            // 
            this.MON.Location = new System.Drawing.Point(97, 71);
            this.MON.Margin = new System.Windows.Forms.Padding(4);
            this.MON.Name = "MON";
            this.MON.Size = new System.Drawing.Size(169, 22);
            this.MON.TabIndex = 20;
            this.MON.Text = "82";
            // 
            // DAT
            // 
            this.DAT.Location = new System.Drawing.Point(16, 102);
            this.DAT.Name = "DAT";
            this.DAT.Size = new System.Drawing.Size(250, 22);
            this.DAT.TabIndex = 22;
            this.DAT.Value = new System.DateTime(2020, 9, 16, 19, 45, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 47);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Interest";
            // 
            // INT_BOX
            // 
            this.INT_BOX.Location = new System.Drawing.Point(339, 41);
            this.INT_BOX.Margin = new System.Windows.Forms.Padding(4);
            this.INT_BOX.Name = "INT_BOX";
            this.INT_BOX.Size = new System.Drawing.Size(135, 22);
            this.INT_BOX.TabIndex = 23;
            this.INT_BOX.Text = "5.0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(491, 104);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Balance";
            // 
            // BAL
            // 
            this.BAL.Location = new System.Drawing.Point(569, 101);
            this.BAL.Margin = new System.Windows.Forms.Padding(4);
            this.BAL.Name = "BAL";
            this.BAL.ReadOnly = true;
            this.BAL.Size = new System.Drawing.Size(135, 22);
            this.BAL.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(491, 134);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "Required";
            // 
            // REQ
            // 
            this.REQ.Location = new System.Drawing.Point(569, 131);
            this.REQ.Margin = new System.Windows.Forms.Padding(4);
            this.REQ.Name = "REQ";
            this.REQ.ReadOnly = true;
            this.REQ.Size = new System.Drawing.Size(135, 22);
            this.REQ.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(491, 164);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 16);
            this.label10.TabIndex = 30;
            this.label10.Text = "Installments";
            // 
            // INS
            // 
            this.INS.Location = new System.Drawing.Point(569, 161);
            this.INS.Margin = new System.Windows.Forms.Padding(4);
            this.INS.Name = "INS";
            this.INS.ReadOnly = true;
            this.INS.Size = new System.Drawing.Size(135, 22);
            this.INS.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(491, 17);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 16);
            this.label11.TabIndex = 32;
            this.label11.Text = "Cost";
            // 
            // COS
            // 
            this.COS.Location = new System.Drawing.Point(569, 11);
            this.COS.Margin = new System.Windows.Forms.Padding(4);
            this.COS.Name = "COS";
            this.COS.ReadOnly = true;
            this.COS.Size = new System.Drawing.Size(135, 22);
            this.COS.TabIndex = 31;
            // 
            // MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 520);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.COS);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.INS);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.REQ);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BAL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.INT_BOX);
            this.Controls.Add(this.DAT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MON);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RAT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AMO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TTL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SEL_STR);
            this.Controls.Add(this.CAL_BTN);
            this.Controls.Add(this.SEL);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.DGV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MAIN";
            this.Text = "Loan Amortization";
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox SEL;
        private System.Windows.Forms.Button CAL_BTN;
        private System.Windows.Forms.TextBox SEL_STR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TTL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AMO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RAT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MON;
        private System.Windows.Forms.DateTimePicker DAT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox INT_BOX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BAL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox REQ;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox INS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox COS;
    }
}

