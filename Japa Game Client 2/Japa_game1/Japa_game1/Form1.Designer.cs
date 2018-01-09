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
            this.lbP2 = new System.Windows.Forms.Label();
            this.btncompare2 = new System.Windows.Forms.Button();
            this.rbtncp = new System.Windows.Forms.RadioButton();
            this.rbtnI = new System.Windows.Forms.RadioButton();
            this.rbtnfp = new System.Windows.Forms.RadioButton();
            this.rbtns = new System.Windows.Forms.RadioButton();
            this.rbtnd = new System.Windows.Forms.RadioButton();
            this.lboxTie = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbP2
            // 
            this.lbP2.AutoSize = true;
            this.lbP2.Location = new System.Drawing.Point(133, 9);
            this.lbP2.Name = "lbP2";
            this.lbP2.Size = new System.Drawing.Size(45, 13);
            this.lbP2.TabIndex = 3;
            this.lbP2.Text = "Player 2";
            // 
            // btncompare2
            // 
            this.btncompare2.Enabled = false;
            this.btncompare2.Location = new System.Drawing.Point(341, 153);
            this.btncompare2.Name = "btncompare2";
            this.btncompare2.Size = new System.Drawing.Size(75, 23);
            this.btncompare2.TabIndex = 5;
            this.btncompare2.Text = "Compare";
            this.btncompare2.UseVisualStyleBackColor = true;
            this.btncompare2.Click += new System.EventHandler(this.button1_Click);
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
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.Location = new System.Drawing.Point(12, 36);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(308, 380);
            this.dataGridView2.TabIndex = 15;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(374, 480);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(273, 480);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 17;
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
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lboxTie);
            this.Controls.Add(this.rbtnd);
            this.Controls.Add(this.rbtns);
            this.Controls.Add(this.rbtnfp);
            this.Controls.Add(this.rbtnI);
            this.Controls.Add(this.rbtncp);
            this.Controls.Add(this.btncompare2);
            this.Controls.Add(this.lbP2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbP2;
        
        private System.Windows.Forms.Button btncompare2;
        private System.Windows.Forms.RadioButton rbtncp;
        private System.Windows.Forms.RadioButton rbtnI;
        private System.Windows.Forms.RadioButton rbtnfp;
        private System.Windows.Forms.RadioButton rbtns;
        private System.Windows.Forms.RadioButton rbtnd;
        private System.Windows.Forms.ListBox lboxTie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRefresh;
    }
}

