
namespace GraphicalProgram
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_StartPosY = new System.Windows.Forms.Label();
            this.lebel3 = new System.Windows.Forms.Label();
            this.lbl_StartPosX = new System.Windows.Forms.Label();
            this.lebel1 = new System.Windows.Forms.Label();
            this.btn_run = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txt_cmd = new System.Windows.Forms.TextBox();
            this.btn_exec = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.Pnl_Draw = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1050, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.newToolStripMenuItem.Text = "New";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_StartPosY);
            this.groupBox1.Controls.Add(this.lebel3);
            this.groupBox1.Controls.Add(this.lbl_StartPosX);
            this.groupBox1.Controls.Add(this.lebel1);
            this.groupBox1.Location = new System.Drawing.Point(0, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 114);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Co-ordinates";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbl_StartPosY
            // 
            this.lbl_StartPosY.AutoSize = true;
            this.lbl_StartPosY.Location = new System.Drawing.Point(159, 44);
            this.lbl_StartPosY.Name = "lbl_StartPosY";
            this.lbl_StartPosY.Size = new System.Drawing.Size(35, 17);
            this.lbl_StartPosY.TabIndex = 3;
            this.lbl_StartPosY.Text = "000";
            // 
            // lebel3
            // 
            this.lebel3.AutoSize = true;
            this.lebel3.Location = new System.Drawing.Point(121, 44);
            this.lebel3.Name = "lebel3";
            this.lebel3.Size = new System.Drawing.Size(18, 17);
            this.lebel3.TabIndex = 2;
            this.lebel3.Text = "Y";
            // 
            // lbl_StartPosX
            // 
            this.lbl_StartPosX.AutoSize = true;
            this.lbl_StartPosX.Location = new System.Drawing.Point(46, 44);
            this.lbl_StartPosX.Name = "lbl_StartPosX";
            this.lbl_StartPosX.Size = new System.Drawing.Size(35, 17);
            this.lbl_StartPosX.TabIndex = 1;
            this.lbl_StartPosX.Text = "000";
            // 
            // lebel1
            // 
            this.lebel1.AutoSize = true;
            this.lebel1.Location = new System.Drawing.Point(13, 44);
            this.lebel1.Name = "lebel1";
            this.lebel1.Size = new System.Drawing.Size(18, 17);
            this.lebel1.TabIndex = 0;
            this.lebel1.Text = "X";
            // 
            // btn_run
            // 
            this.btn_run.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_run.Location = new System.Drawing.Point(13, 202);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(76, 33);
            this.btn_run.TabIndex = 2;
            this.btn_run.Text = "Run";
            this.btn_run.UseVisualStyleBackColor = false;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClear.Location = new System.Drawing.Point(149, 202);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 33);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txt_cmd
            // 
            this.txt_cmd.Location = new System.Drawing.Point(0, 163);
            this.txt_cmd.Name = "txt_cmd";
            this.txt_cmd.Size = new System.Drawing.Size(239, 22);
            this.txt_cmd.TabIndex = 4;
            // 
            // btn_exec
            // 
            this.btn_exec.BackColor = System.Drawing.Color.Chocolate;
            this.btn_exec.Location = new System.Drawing.Point(16, 537);
            this.btn_exec.Name = "btn_exec";
            this.btn_exec.Size = new System.Drawing.Size(75, 33);
            this.btn_exec.TabIndex = 5;
            this.btn_exec.Text = "Execute";
            this.btn_exec.UseVisualStyleBackColor = false;
            this.btn_exec.Click += new System.EventHandler(this.btn_exec_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.OliveDrab;
            this.btnReset.Location = new System.Drawing.Point(149, 537);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 33);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(0, 255);
            this.txtCommand.Multiline = true;
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(239, 276);
            this.txtCommand.TabIndex = 7;
            // 
            // Pnl_Draw
            // 
            this.Pnl_Draw.BackColor = System.Drawing.Color.ForestGreen;
            this.Pnl_Draw.Location = new System.Drawing.Point(264, 26);
            this.Pnl_Draw.Name = "Pnl_Draw";
            this.Pnl_Draw.Size = new System.Drawing.Size(786, 555);
            this.Pnl_Draw.TabIndex = 8;
            this.Pnl_Draw.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_Draw_Paint);
            this.Pnl_Draw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pnl_Draw_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(1050, 583);
            this.Controls.Add(this.Pnl_Draw);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btn_exec);
            this.Controls.Add(this.txt_cmd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Graphical Programming Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_StartPosY;
        private System.Windows.Forms.Label lebel3;
        private System.Windows.Forms.Label lbl_StartPosX;
        private System.Windows.Forms.Label lebel1;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txt_cmd;
        private System.Windows.Forms.Button btn_exec;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Panel Pnl_Draw;
    }
}

