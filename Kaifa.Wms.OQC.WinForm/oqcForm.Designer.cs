﻿namespace Kaifa.Wms.OQC.WinForm
{
    partial class oqcForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.orderkeytxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dropidtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statustxt = new System.Windows.Forms.TextBox();
            this.subtotalpickedqtytxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.subtotalcheckqtytxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.subtotaldiffqtytxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.stxqrcode = new System.Windows.Forms.TextBox();
            this.openqtytxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pickedqty = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkedqtytxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pickdetailgrid = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.checkrecordgrid = new System.Windows.Forms.DataGridView();
            this.diffqtytxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.diffck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pickdetailgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkrecordgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "出货单号";
            // 
            // orderkeytxt
            // 
            this.orderkeytxt.Location = new System.Drawing.Point(74, 10);
            this.orderkeytxt.MaxLength = 10;
            this.orderkeytxt.Name = "orderkeytxt";
            this.orderkeytxt.Size = new System.Drawing.Size(248, 20);
            this.orderkeytxt.TabIndex = 1;
            this.orderkeytxt.TextChanged += new System.EventHandler(this.orderkeytxt_TextChanged);
            this.orderkeytxt.Leave += new System.EventHandler(this.orderkeytxt_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "落放ID";
            // 
            // dropidtxt
            // 
            this.dropidtxt.Location = new System.Drawing.Point(376, 10);
            this.dropidtxt.MaxLength = 14;
            this.dropidtxt.Name = "dropidtxt";
            this.dropidtxt.Size = new System.Drawing.Size(248, 20);
            this.dropidtxt.TabIndex = 3;
            this.dropidtxt.Leave += new System.EventHandler(this.dropidtxt_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(640, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "订单状态";
            // 
            // statustxt
            // 
            this.statustxt.Location = new System.Drawing.Point(701, 10);
            this.statustxt.Name = "statustxt";
            this.statustxt.Size = new System.Drawing.Size(92, 20);
            this.statustxt.TabIndex = 5;
            // 
            // subtotalpickedqtytxt
            // 
            this.subtotalpickedqtytxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.subtotalpickedqtytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalpickedqtytxt.Location = new System.Drawing.Point(450, 399);
            this.subtotalpickedqtytxt.Name = "subtotalpickedqtytxt";
            this.subtotalpickedqtytxt.Size = new System.Drawing.Size(190, 38);
            this.subtotalpickedqtytxt.TabIndex = 9;
            this.subtotalpickedqtytxt.Text = "0";
            this.subtotalpickedqtytxt.TextChanged += new System.EventHandler(this.subpickedqtytxt_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(451, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "捡货数量";
            // 
            // subtotalcheckqtytxt
            // 
            this.subtotalcheckqtytxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.subtotalcheckqtytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalcheckqtytxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.subtotalcheckqtytxt.Location = new System.Drawing.Point(17, 399);
            this.subtotalcheckqtytxt.Name = "subtotalcheckqtytxt";
            this.subtotalcheckqtytxt.Size = new System.Drawing.Size(190, 38);
            this.subtotalcheckqtytxt.TabIndex = 11;
            this.subtotalcheckqtytxt.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "已检查数量";
            // 
            // subtotaldiffqtytxt
            // 
            this.subtotaldiffqtytxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.subtotaldiffqtytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotaldiffqtytxt.ForeColor = System.Drawing.Color.Red;
            this.subtotaldiffqtytxt.Location = new System.Drawing.Point(685, 399);
            this.subtotaldiffqtytxt.Name = "subtotaldiffqtytxt";
            this.subtotaldiffqtytxt.Size = new System.Drawing.Size(190, 38);
            this.subtotaldiffqtytxt.TabIndex = 13;
            this.subtotaldiffqtytxt.Text = "0";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(686, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "差异数量";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "希捷标签";
            // 
            // stxqrcode
            // 
            this.stxqrcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stxqrcode.Location = new System.Drawing.Point(92, 106);
            this.stxqrcode.Name = "stxqrcode";
            this.stxqrcode.Size = new System.Drawing.Size(701, 26);
            this.stxqrcode.TabIndex = 15;
            this.stxqrcode.Leave += new System.EventHandler(this.stxqrcode_Leave);
            // 
            // openqtytxt
            // 
            this.openqtytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openqtytxt.Location = new System.Drawing.Point(15, 59);
            this.openqtytxt.Name = "openqtytxt";
            this.openqtytxt.Size = new System.Drawing.Size(190, 38);
            this.openqtytxt.TabIndex = 17;
            this.openqtytxt.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "分配数量";
            // 
            // pickedqty
            // 
            this.pickedqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickedqty.Location = new System.Drawing.Point(211, 59);
            this.pickedqty.Name = "pickedqty";
            this.pickedqty.Size = new System.Drawing.Size(190, 38);
            this.pickedqty.TabIndex = 19;
            this.pickedqty.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(212, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "捡货数量";
            // 
            // checkedqtytxt
            // 
            this.checkedqtytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedqtytxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.checkedqtytxt.Location = new System.Drawing.Point(407, 59);
            this.checkedqtytxt.Name = "checkedqtytxt";
            this.checkedqtytxt.Size = new System.Drawing.Size(190, 38);
            this.checkedqtytxt.TabIndex = 21;
            this.checkedqtytxt.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(408, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "复捡数量";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(447, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "复检结果";
            // 
            // pickdetailgrid
            // 
            this.pickdetailgrid.AllowUserToAddRows = false;
            this.pickdetailgrid.AllowUserToDeleteRows = false;
            this.pickdetailgrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pickdetailgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.pickdetailgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pickdetailgrid.DefaultCellStyle = dataGridViewCellStyle14;
            this.pickdetailgrid.Location = new System.Drawing.Point(442, 155);
            this.pickdetailgrid.Name = "pickdetailgrid";
            this.pickdetailgrid.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pickdetailgrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.pickdetailgrid.Size = new System.Drawing.Size(604, 224);
            this.pickdetailgrid.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "复检记录";
            // 
            // checkrecordgrid
            // 
            this.checkrecordgrid.AllowUserToAddRows = false;
            this.checkrecordgrid.AllowUserToDeleteRows = false;
            this.checkrecordgrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.checkrecordgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.checkrecordgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.checkrecordgrid.DefaultCellStyle = dataGridViewCellStyle17;
            this.checkrecordgrid.Location = new System.Drawing.Point(12, 155);
            this.checkrecordgrid.Name = "checkrecordgrid";
            this.checkrecordgrid.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.checkrecordgrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.checkrecordgrid.Size = new System.Drawing.Size(409, 224);
            this.checkrecordgrid.TabIndex = 25;
            // 
            // diffqtytxt
            // 
            this.diffqtytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diffqtytxt.ForeColor = System.Drawing.Color.Red;
            this.diffqtytxt.Location = new System.Drawing.Point(603, 59);
            this.diffqtytxt.Name = "diffqtytxt";
            this.diffqtytxt.Size = new System.Drawing.Size(190, 38);
            this.diffqtytxt.TabIndex = 27;
            this.diffqtytxt.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(604, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "差异数量";
            // 
            // diffck
            // 
            this.diffck.AutoSize = true;
            this.diffck.Checked = true;
            this.diffck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.diffck.Location = new System.Drawing.Point(659, 138);
            this.diffck.Name = "diffck";
            this.diffck.Size = new System.Drawing.Size(134, 17);
            this.diffck.TabIndex = 28;
            this.diffck.Text = "只显示有差异的记录";
            this.diffck.UseVisualStyleBackColor = true;
            this.diffck.CheckedChanged += new System.EventHandler(this.diffck_CheckedChanged);
            // 
            // oqcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 440);
            this.Controls.Add(this.diffqtytxt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.checkrecordgrid);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pickdetailgrid);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.checkedqtytxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pickedqty);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.openqtytxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.stxqrcode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.subtotaldiffqtytxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.subtotalcheckqtytxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.subtotalpickedqtytxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statustxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dropidtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.orderkeytxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.diffck);
            this.Name = "oqcForm";
            this.Text = "出货复检程序";
            ((System.ComponentModel.ISupportInitialize)(this.pickdetailgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkrecordgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox orderkeytxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dropidtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox statustxt;
        private System.Windows.Forms.TextBox subtotalpickedqtytxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox subtotalcheckqtytxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox subtotaldiffqtytxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox stxqrcode;
        private System.Windows.Forms.TextBox openqtytxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox pickedqty;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox checkedqtytxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView checkrecordgrid;
        private System.Windows.Forms.TextBox diffqtytxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox diffck;
        private System.Windows.Forms.DataGridView pickdetailgrid;
    }
}
