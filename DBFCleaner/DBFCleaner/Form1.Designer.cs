namespace DBFCleaner
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOpenFile = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.Button();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvReq = new System.Windows.Forms.DataGridView();
            this.rtbOut = new System.Windows.Forms.RichTextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.cbFilter = new System.Windows.Forms.CheckBox();
            this.cbDate = new System.Windows.Forms.CheckBox();
            this.cbWhere = new System.Windows.Forms.CheckBox();
            this.rtbReqWh = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbReqSel = new System.Windows.Forms.RichTextBox();
            this.LOG = new System.Windows.Forms.Label();
            this.cbSel = new System.Windows.Forms.CheckBox();
            this.btnClearDGV = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReq)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpenFile});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1178, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFile.Image")));
            this.btnOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(59, 22);
            this.btnOpenFile.Text = "Open file";
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(33, 77);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "Удалить";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(88, 28);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFrom.TabIndex = 2;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(88, 52);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 20);
            this.dtpTo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "С";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "По";
            // 
            // tbFileName
            // 
            this.tbFileName.Enabled = false;
            this.tbFileName.Location = new System.Drawing.Point(131, 147);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(346, 20);
            this.tbFileName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Выбранный файл";
            // 
            // dgvReq
            // 
            this.dgvReq.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReq.Location = new System.Drawing.Point(33, 173);
            this.dgvReq.Name = "dgvReq";
            this.dgvReq.Size = new System.Drawing.Size(1116, 278);
            this.dgvReq.TabIndex = 8;
            // 
            // rtbOut
            // 
            this.rtbOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbOut.Location = new System.Drawing.Point(966, 28);
            this.rtbOut.Name = "rtbOut";
            this.rtbOut.Size = new System.Drawing.Size(183, 113);
            this.rtbOut.TabIndex = 9;
            this.rtbOut.Text = "";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(114, 77);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 10;
            this.btnShow.Text = "Показать";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // cbFilter
            // 
            this.cbFilter.AutoSize = true;
            this.cbFilter.Location = new System.Drawing.Point(33, 108);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(93, 17);
            this.cbFilter.TabIndex = 11;
            this.cbFilter.Text = "С фильтрами";
            this.cbFilter.UseVisualStyleBackColor = true;
            // 
            // cbDate
            // 
            this.cbDate.AutoSize = true;
            this.cbDate.Location = new System.Drawing.Point(33, 124);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(65, 17);
            this.cbDate.TabIndex = 12;
            this.cbDate.Text = "С датой";
            this.cbDate.UseVisualStyleBackColor = true;
            // 
            // cbWhere
            // 
            this.cbWhere.AutoSize = true;
            this.cbWhere.Location = new System.Drawing.Point(211, 108);
            this.cbWhere.Name = "cbWhere";
            this.cbWhere.Size = new System.Drawing.Size(81, 17);
            this.cbWhere.TabIndex = 13;
            this.cbWhere.Text = "С \'WHERE\'";
            this.cbWhere.UseVisualStyleBackColor = true;
            // 
            // rtbReqWh
            // 
            this.rtbReqWh.Location = new System.Drawing.Point(618, 28);
            this.rtbReqWh.Name = "rtbReqWh";
            this.rtbReqWh.Size = new System.Drawing.Size(336, 113);
            this.rtbReqWh.TabIndex = 14;
            this.rtbReqWh.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(615, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "WHERE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "SELECT";
            // 
            // rtbReqSel
            // 
            this.rtbReqSel.Location = new System.Drawing.Point(294, 28);
            this.rtbReqSel.Name = "rtbReqSel";
            this.rtbReqSel.Size = new System.Drawing.Size(318, 113);
            this.rtbReqSel.TabIndex = 16;
            this.rtbReqSel.Text = "";
            // 
            // LOG
            // 
            this.LOG.AutoSize = true;
            this.LOG.Location = new System.Drawing.Point(963, 12);
            this.LOG.Name = "LOG";
            this.LOG.Size = new System.Drawing.Size(29, 13);
            this.LOG.TabIndex = 18;
            this.LOG.Text = "LOG";
            // 
            // cbSel
            // 
            this.cbSel.AutoSize = true;
            this.cbSel.Location = new System.Drawing.Point(124, 108);
            this.cbSel.Name = "cbSel";
            this.cbSel.Size = new System.Drawing.Size(81, 17);
            this.cbSel.TabIndex = 19;
            this.cbSel.Text = "С \'SELECT\'";
            this.cbSel.UseVisualStyleBackColor = true;
            // 
            // btnClearDGV
            // 
            this.btnClearDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearDGV.Location = new System.Drawing.Point(1033, 147);
            this.btnClearDGV.Name = "btnClearDGV";
            this.btnClearDGV.Size = new System.Drawing.Size(116, 23);
            this.btnClearDGV.TabIndex = 20;
            this.btnClearDGV.Text = "Очистить таблицу";
            this.btnClearDGV.UseVisualStyleBackColor = true;
            this.btnClearDGV.Click += new System.EventHandler(this.btnClearDGV_Click);
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(483, 147);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(148, 23);
            this.btnFill.TabIndex = 21;
            this.btnFill.Text = "Заполнить для \'2VW\'";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 482);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.btnClearDGV);
            this.Controls.Add(this.cbSel);
            this.Controls.Add(this.LOG);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtbReqSel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtbReqWh);
            this.Controls.Add(this.cbWhere);
            this.Controls.Add(this.cbDate);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.rtbOut);
            this.Controls.Add(this.dgvReq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.Text = "DBFCleaner";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnOpenFile;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvReq;
        private System.Windows.Forms.RichTextBox rtbOut;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.CheckBox cbFilter;
        private System.Windows.Forms.CheckBox cbDate;
        private System.Windows.Forms.CheckBox cbWhere;
        private System.Windows.Forms.RichTextBox rtbReqWh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbReqSel;
        private System.Windows.Forms.Label LOG;
        private System.Windows.Forms.CheckBox cbSel;
        private System.Windows.Forms.Button btnClearDGV;
        private System.Windows.Forms.Button btnFill;
    }
}

