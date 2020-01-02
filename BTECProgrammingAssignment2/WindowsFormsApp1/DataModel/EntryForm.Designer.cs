namespace WindowsFormsApp1
{
    partial class EntryForm
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
            this.DgdDisplay = new System.Windows.Forms.DataGridView();
            this.IdeaDgdViewTxtCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumVoteDgdViewTxtCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoteDgdViewBtnCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BindingSrc = new System.Windows.Forms.BindingSource(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtIdea = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.DgdDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSrc)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgdDisplay
            // 
            this.DgdDisplay.AllowUserToAddRows = false;
            this.DgdDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgdDisplay.AutoGenerateColumns = false;
            this.DgdDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgdDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdeaDgdViewTxtCol,
            this.NumVoteDgdViewTxtCol,
            this.VoteDgdViewBtnCol});
            this.DgdDisplay.DataSource = this.BindingSrc;
            this.DgdDisplay.Location = new System.Drawing.Point(5, 74);
            this.DgdDisplay.Name = "DgdDisplay";
            this.DgdDisplay.ReadOnly = true;
            this.DgdDisplay.Size = new System.Drawing.Size(783, 364);
            this.DgdDisplay.TabIndex = 0;
            // 
            // IdeaDgdViewTxtCol
            // 
            this.IdeaDgdViewTxtCol.DataPropertyName = "Idea";
            this.IdeaDgdViewTxtCol.HeaderText = "Idea";
            this.IdeaDgdViewTxtCol.Name = "IdeaDgdViewTxtCol";
            this.IdeaDgdViewTxtCol.ReadOnly = true;
            this.IdeaDgdViewTxtCol.Width = 500;
            // 
            // NumVoteDgdViewTxtCol
            // 
            this.NumVoteDgdViewTxtCol.DataPropertyName = "NumberOfVote";
            this.NumVoteDgdViewTxtCol.HeaderText = "Number of Vote";
            this.NumVoteDgdViewTxtCol.Name = "NumVoteDgdViewTxtCol";
            this.NumVoteDgdViewTxtCol.ReadOnly = true;
            // 
            // VoteDgdViewBtnCol
            // 
            this.VoteDgdViewBtnCol.DataPropertyName = "VoteBtnCol";
            this.VoteDgdViewBtnCol.HeaderText = "Vote";
            this.VoteDgdViewBtnCol.Name = "VoteDgdViewBtnCol";
            this.VoteDgdViewBtnCol.ReadOnly = true;
            this.VoteDgdViewBtnCol.Text = "Vote This";
            // 
            // BindingSrc
            // 
            this.BindingSrc.DataSource = typeof(WindowsFormsApp1.BrainStormPost);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(4, 32);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(782, 34);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Show Ranking";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(711, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(74, 22);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(633, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 22);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtIdea
            // 
            this.txtIdea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdea.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdea.Location = new System.Drawing.Point(3, 3);
            this.txtIdea.Name = "txtIdea";
            this.txtIdea.Size = new System.Drawing.Size(624, 23);
            this.txtIdea.TabIndex = 1;
            this.txtIdea.Text = "Type your idea here...";
            this.txtIdea.Click += new System.EventHandler(this.txtIdea_Click);
            this.txtIdea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIdea_KeyDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.txtIdea, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(788, 28);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.DgdDisplay);
            this.Name = "EntryForm";
            this.Text = "Brain Storm Board";
            this.Load += new System.EventHandler(this.EntryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgdDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSrc)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgdDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn voteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource BindingSrc;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdeaDgdViewTxtCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumVoteDgdViewTxtCol;
        private System.Windows.Forms.DataGridViewButtonColumn VoteDgdViewBtnCol;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtIdea;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}