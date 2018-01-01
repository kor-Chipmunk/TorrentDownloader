namespace TorrentDownloader
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lvResult = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(13, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(1097, 32);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1116, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 32);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "검색하기";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lvResult
            // 
            this.lvResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvResult.FullRowSelect = true;
            this.lvResult.GridLines = true;
            this.lvResult.Location = new System.Drawing.Point(12, 51);
            this.lvResult.MultiSelect = false;
            this.lvResult.Name = "lvResult";
            this.lvResult.Size = new System.Drawing.Size(1212, 754);
            this.lvResult.TabIndex = 2;
            this.lvResult.UseCompatibleStateImageBehavior = false;
            this.lvResult.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "#";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "제목";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 360;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "날짜";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "용량";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "양호";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "불량";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "분류";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 817);
            this.Controls.Add(this.lvResult);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "토렌트 다운로더";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView lvResult;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

