namespace memo.cs
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.addButton = new System.Windows.Forms.Button();
            this.aditButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titletext = new System.Windows.Forms.TextBox();
            this.dateText = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.memoDataSet = new memo.cs.memoDataSet();
            this.memoDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memoDataSet1 = new memo.cs.memoDataSet();
            this.memoDataTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.日付DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.タイトルDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDataTableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(242, 377);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(102, 45);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "追加";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButtonClicked);
            // 
            // aditButton
            // 
            this.aditButton.Location = new System.Drawing.Point(267, 12);
            this.aditButton.Name = "aditButton";
            this.aditButton.Size = new System.Drawing.Size(77, 37);
            this.aditButton.TabIndex = 1;
            this.aditButton.Text = "編集";
            this.aditButton.UseVisualStyleBackColor = true;
            this.aditButton.Click += new System.EventHandler(this.aditButtonClicked);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(267, 69);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(77, 35);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "削除";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButtonClicked);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(24, 318);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(29, 12);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "日付";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(24, 377);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(40, 12);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "タイトル";
            // 
            // titletext
            // 
            this.titletext.Location = new System.Drawing.Point(26, 403);
            this.titletext.Name = "titletext";
            this.titletext.Size = new System.Drawing.Size(175, 19);
            this.titletext.TabIndex = 5;
            // 
            // dateText
            // 
            this.dateText.Location = new System.Drawing.Point(26, 345);
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(145, 19);
            this.dateText.TabIndex = 6;
            this.dateText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.日付DataGridViewTextBoxColumn,
            this.タイトルDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.memoDataTableBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(246, 294);
            this.dataGridView1.TabIndex = 7;
            // 
            // memoDataSet
            // 
            this.memoDataSet.DataSetName = "memoDataSet";
            this.memoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memoDataTableBindingSource
            // 
            this.memoDataTableBindingSource.DataMember = "memoDataTable";
            this.memoDataTableBindingSource.DataSource = this.memoDataSet;
            // 
            // memoDataSet1
            // 
            this.memoDataSet1.DataSetName = "memoDataSet";
            this.memoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memoDataTableBindingSource1
            // 
            this.memoDataTableBindingSource1.DataMember = "memoDataTable";
            this.memoDataTableBindingSource1.DataSource = this.memoDataSet1;
            // 
            // 日付DataGridViewTextBoxColumn
            // 
            this.日付DataGridViewTextBoxColumn.DataPropertyName = "日付";
            this.日付DataGridViewTextBoxColumn.HeaderText = "日付";
            this.日付DataGridViewTextBoxColumn.Name = "日付DataGridViewTextBoxColumn";
            // 
            // タイトルDataGridViewTextBoxColumn
            // 
            this.タイトルDataGridViewTextBoxColumn.DataPropertyName = "タイトル";
            this.タイトルDataGridViewTextBoxColumn.HeaderText = "タイトル";
            this.タイトルDataGridViewTextBoxColumn.Name = "タイトルDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 442);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateText);
            this.Controls.Add(this.titletext);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.aditButton);
            this.Controls.Add(this.addButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDataTableBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button aditButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titletext;
        private System.Windows.Forms.TextBox dateText;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource memoDataTableBindingSource;
        private memoDataSet memoDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日付DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn タイトルDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource memoDataTableBindingSource1;
        private memoDataSet memoDataSet1;
    }
}

