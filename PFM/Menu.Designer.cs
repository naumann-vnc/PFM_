namespace PFM
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.toolTip_operacao = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(838, 441);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(86, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 435);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btn4, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.btn1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btn3, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btn5, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.btn6, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.btn7, 0, 6);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(77, 435);
            this.tableLayoutPanel3.TabIndex = 2;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel3_Paint);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.ForestGreen;
            this.btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Location = new System.Drawing.Point(3, 189);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(71, 56);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "½ x";
            this.toolTip_operacao.SetToolTip(this.btn4, "Multiplicação de duas frações");
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Red;
            this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(3, 3);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(71, 56);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.DarkOrange;
            this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Location = new System.Drawing.Point(3, 65);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(71, 56);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "½ +";
            this.toolTip_operacao.SetToolTip(this.btn2, "Soma de duas frações");
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(11)))));
            this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Location = new System.Drawing.Point(3, 127);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(71, 56);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "½ -";
            this.toolTip_operacao.SetToolTip(this.btn3, "Subtração de duas frações");
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Location = new System.Drawing.Point(3, 251);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(71, 56);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "½ ÷";
            this.toolTip_operacao.SetToolTip(this.btn5, "Divisão de duas frações");
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Location = new System.Drawing.Point(3, 313);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(71, 56);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "[ ] +";
            this.toolTip_operacao.SetToolTip(this.btn6, "Soma de duas matrizes 3x3");
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Indigo;
            this.btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Location = new System.Drawing.Point(3, 375);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(71, 57);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "[ ] X";
            this.toolTip_operacao.SetToolTip(this.btn7, "Multiplicação de duas matrizes 3x3");
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PFM";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.ToolTip toolTip_operacao;
    }
}

