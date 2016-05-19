namespace Enter_DFA_Machine
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Gv1 = new System.Windows.Forms.DataGridView();
            this.ColQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFinal = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtString = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Gv1)).BeginInit();
            this.SuspendLayout();
            // 
            // Gv1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Gv1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Gv1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Gv1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Gv1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Gv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColQ,
            this.ColA,
            this.ColB,
            this.ColFinal});
            this.Gv1.GridColor = System.Drawing.Color.WhiteSmoke;
            this.Gv1.Location = new System.Drawing.Point(1, 1);
            this.Gv1.Name = "Gv1";
            this.Gv1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Gv1.Size = new System.Drawing.Size(436, 371);
            this.Gv1.TabIndex = 0;
            this.Gv1.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowLeave);
            // 
            // ColQ
            // 
            this.ColQ.Frozen = true;
            this.ColQ.HeaderText = "Q";
            this.ColQ.Name = "ColQ";
            // 
            // ColA
            // 
            this.ColA.HeaderText = "a";
            this.ColA.Name = "ColA";
            // 
            // ColB
            // 
            this.ColB.HeaderText = "b";
            this.ColB.Name = "ColB";
            // 
            // ColFinal
            // 
            this.ColFinal.HeaderText = "F";
            this.ColFinal.Name = "ColFinal";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(517, 149);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(156, 66);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Read String";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(517, 221);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(156, 67);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset ";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(517, 294);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(156, 67);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "String :";
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(478, 33);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(195, 20);
            this.txtString.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 373);
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.Gv1);
            this.Name = "Form1";
            this.Text = "Enter DFA";
            ((System.ComponentModel.ISupportInitialize)(this.Gv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Gv1;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColB;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColFinal;
    }
}

