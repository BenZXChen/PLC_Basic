namespace PLC_Basic
{
    partial class fMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.labPLCInfo = new System.Windows.Forms.Label();
            this.labInfo = new System.Windows.Forms.Label();
            this.labPLCArea = new System.Windows.Forms.Label();
            this.txtPLCArea = new System.Windows.Forms.TextBox();
            this.labWriteData = new System.Windows.Forms.Label();
            this.txtWriteData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConnect.Location = new System.Drawing.Point(39, 184);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(88, 36);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRead.Location = new System.Drawing.Point(153, 184);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(88, 36);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            // 
            // btnWrite
            // 
            this.btnWrite.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWrite.Location = new System.Drawing.Point(266, 184);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(88, 36);
            this.btnWrite.TabIndex = 2;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClose.Location = new System.Drawing.Point(375, 184);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 36);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;

            // 
            // labPLCInfo
            // 
            this.labPLCInfo.AutoSize = true;
            this.labPLCInfo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPLCInfo.Location = new System.Drawing.Point(44, 39);
            this.labPLCInfo.Name = "labPLCInfo";
            this.labPLCInfo.Size = new System.Drawing.Size(134, 21);
            this.labPLCInfo.TabIndex = 4;
            this.labPLCInfo.Text = "PLC Information";
            // 
            // labInfo
            // 
            this.labInfo.AutoSize = true;
            this.labInfo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labInfo.Location = new System.Drawing.Point(193, 39);
            this.labInfo.Name = "labInfo";
            this.labInfo.Size = new System.Drawing.Size(17, 21);
            this.labInfo.TabIndex = 5;
            this.labInfo.Text = "-";
            // 
            // labPLCArea
            // 
            this.labPLCArea.AutoSize = true;
            this.labPLCArea.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPLCArea.Location = new System.Drawing.Point(86, 84);
            this.labPLCArea.Name = "labPLCArea";
            this.labPLCArea.Size = new System.Drawing.Size(75, 21);
            this.labPLCArea.TabIndex = 6;
            this.labPLCArea.Text = "PLCArea";
            // 
            // txtPLCArea
            // 
            this.txtPLCArea.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPLCArea.Location = new System.Drawing.Point(197, 81);
            this.txtPLCArea.Name = "txtPLCArea";
            this.txtPLCArea.Size = new System.Drawing.Size(129, 29);
            this.txtPLCArea.TabIndex = 7;
            // 
            // labWriteData
            // 
            this.labWriteData.AutoSize = true;
            this.labWriteData.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labWriteData.Location = new System.Drawing.Point(86, 131);
            this.labWriteData.Name = "labWriteData";
            this.labWriteData.Size = new System.Drawing.Size(92, 21);
            this.labWriteData.TabIndex = 8;
            this.labWriteData.Text = "Write Data";
            // 
            // txtWriteData
            // 
            this.txtWriteData.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtWriteData.Location = new System.Drawing.Point(197, 126);
            this.txtWriteData.Name = "txtWriteData";
            this.txtWriteData.Size = new System.Drawing.Size(246, 29);
            this.txtWriteData.TabIndex = 9;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 264);
            this.Controls.Add(this.txtWriteData);
            this.Controls.Add(this.labWriteData);
            this.Controls.Add(this.txtPLCArea);
            this.Controls.Add(this.labPLCArea);
            this.Controls.Add(this.labInfo);
            this.Controls.Add(this.labPLCInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnConnect);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labPLCInfo;
        private System.Windows.Forms.Label labInfo;
        private System.Windows.Forms.Label labPLCArea;
        private System.Windows.Forms.TextBox txtPLCArea;
        private System.Windows.Forms.Label labWriteData;
        private System.Windows.Forms.TextBox txtWriteData;
    }
}

