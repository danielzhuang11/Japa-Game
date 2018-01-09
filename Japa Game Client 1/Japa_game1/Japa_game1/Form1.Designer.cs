namespace Japa_game1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnshuffle = new System.Windows.Forms.Button();
            this.lbP1 = new System.Windows.Forms.Label();
            this.lbP2 = new System.Windows.Forms.Label();
            this.btncompare1 = new System.Windows.Forms.Button();
            this.rbtncp = new System.Windows.Forms.RadioButton();
            this.rbtnI = new System.Windows.Forms.RadioButton();
            this.rbtnfp = new System.Windows.Forms.RadioButton();
            this.rbtns = new System.Windows.Forms.RadioButton();
            this.rbtnd = new System.Windows.Forms.RadioButton();
            this.lboxTie = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnshuffle
            // 
            this.btnshuffle.Location = new System.Drawing.Point(371, 454);
            this.btnshuffle.Name = "btnshuffle";
            this.btnshuffle.Size = new System.Drawing.Size(75, 23);
            this.btnshuffle.TabIndex = 0;
            this.btnshuffle.Text = "Shuffle";
            this.btnshuffle.UseVisualStyleBackColor = true;
            this.btnshuffle.Click += new System.EventHandler(this.btnshuffle_Click);
            // 
            // lbP1
            // 
            this.lbP1.AutoSize = true;
            this.lbP1.Location = new System.Drawing.Point(133, 9);
            this.lbP1.Name = "lbP1";
            this.lbP1.Size = new System.Drawing.Size(45, 13);
            this.lbP1.TabIndex = 3;
            this.lbP1.Text = "Player 1";
            // 
            // lbP2
            // 
            this.lbP2.AutoSize = true;
            this.lbP2.Location = new System.Drawing.Point(616, 9);
            this.lbP2.Name = "lbP2";
            this.lbP2.Size = new System.Drawing.Size(45, 13);
            this.lbP2.TabIndex = 4;
            this.lbP2.Text = "Player 2";
            this.lbP2.Click += new System.EventHandler(this.lbP2_Click);
            // 
            // btncompare1
            // 
            this.btncompare1.Enabled = false;
            this.btncompare1.Location = new System.Drawing.Point(341, 153);
            this.btncompare1.Name = "btncompare1";
            this.btncompare1.Size = new System.Drawing.Size(75, 23);
            this.btncompare1.TabIndex = 5;
            this.btncompare1.Text = "Compare";
            this.btncompare1.UseVisualStyleBackColor = true;
            this.btncompare1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbtncp
            // 
            this.rbtncp.AutoSize = true;
            this.rbtncp.Location = new System.Drawing.Point(341, 182);
            this.rbtncp.Name = "rbtncp";
            this.rbtncp.Size = new System.Drawing.Size(94, 17);
            this.rbtncp.TabIndex = 6;
            this.rbtncp.TabStop = true;
            this.rbtncp.Text = "Combat Power";
            this.rbtncp.UseVisualStyleBackColor = true;
            // 
            // rbtnI
            // 
            this.rbtnI.AutoSize = true;
            this.rbtnI.Location = new System.Drawing.Point(341, 205);
            this.rbtnI.Name = "rbtnI";
            this.rbtnI.Size = new System.Drawing.Size(79, 17);
            this.rbtnI.TabIndex = 7;
            this.rbtnI.TabStop = true;
            this.rbtnI.Text = "Intelligence";
            this.rbtnI.UseVisualStyleBackColor = true;
            this.rbtnI.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbtnfp
            // 
            this.rbtnfp.AutoSize = true;
            this.rbtnfp.Location = new System.Drawing.Point(341, 228);
            this.rbtnfp.Name = "rbtnfp";
            this.rbtnfp.Size = new System.Drawing.Size(85, 17);
            this.rbtnfp.TabIndex = 8;
            this.rbtnfp.TabStop = true;
            this.rbtnfp.Text = "Force Power";
            this.rbtnfp.UseVisualStyleBackColor = true;
            // 
            // rbtns
            // 
            this.rbtns.AutoSize = true;
            this.rbtns.Location = new System.Drawing.Point(339, 251);
            this.rbtns.Name = "rbtns";
            this.rbtns.Size = new System.Drawing.Size(81, 17);
            this.rbtns.TabIndex = 9;
            this.rbtns.TabStop = true;
            this.rbtns.Text = "Survivability";
            this.rbtns.UseVisualStyleBackColor = true;
            // 
            // rbtnd
            // 
            this.rbtnd.AutoSize = true;
            this.rbtnd.Location = new System.Drawing.Point(341, 274);
            this.rbtnd.Name = "rbtnd";
            this.rbtnd.Size = new System.Drawing.Size(66, 17);
            this.rbtnd.TabIndex = 10;
            this.rbtnd.TabStop = true;
            this.rbtnd.Text = "Dexterity";
            this.rbtnd.UseVisualStyleBackColor = true;
            this.rbtnd.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lboxTie
            // 
            this.lboxTie.FormattingEnabled = true;
            this.lboxTie.Location = new System.Drawing.Point(339, 308);
            this.lboxTie.Name = "lboxTie";
            this.lboxTie.Size = new System.Drawing.Size(161, 108);
            this.lboxTie.TabIndex = 12;
            this.lboxTie.SelectedIndexChanged += new System.EventHandler(this.lboxTie_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tie Box";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(308, 380);
            this.dataGridView1.TabIndex = 15;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(285, 454);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Visible = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 578);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lboxTie);
            this.Controls.Add(this.rbtnd);
            this.Controls.Add(this.rbtns);
            this.Controls.Add(this.rbtnfp);
            this.Controls.Add(this.rbtnI);
            this.Controls.Add(this.rbtncp);
            this.Controls.Add(this.btncompare1);
            this.Controls.Add(this.lbP2);
            this.Controls.Add(this.lbP1);
            this.Controls.Add(this.btnshuffle);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnshuffle;
        private System.Windows.Forms.Label lbP1;
        private System.Windows.Forms.Label lbP2;
        private System.Windows.Forms.Button btncompare1;
        private System.Windows.Forms.RadioButton rbtncp;
        private System.Windows.Forms.RadioButton rbtnI;
        private System.Windows.Forms.RadioButton rbtnfp;
        private System.Windows.Forms.RadioButton rbtns;
        private System.Windows.Forms.RadioButton rbtnd;
        private System.Windows.Forms.ListBox lboxTie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnRefresh;
    }
}

