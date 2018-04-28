namespace ExercKran
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
            this.PnlMain = new System.Windows.Forms.Panel();
            this.PnlBase = new System.Windows.Forms.Panel();
            this.PnlArm = new System.Windows.Forms.Panel();
            this.PnlHook = new System.Windows.Forms.Panel();
            this.CmdHookHoch = new System.Windows.Forms.Button();
            this.CmdHookRunter = new System.Windows.Forms.Button();
            this.CmdArmRaus = new System.Windows.Forms.Button();
            this.CmdArmEinfahren = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBoxEingabeGeschw = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PnlMain
            // 
            this.PnlMain.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlMain.Location = new System.Drawing.Point(342, 99);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(36, 288);
            this.PnlMain.TabIndex = 0;
            // 
            // PnlBase
            // 
            this.PnlBase.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PnlBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlBase.Location = new System.Drawing.Point(263, 382);
            this.PnlBase.Name = "PnlBase";
            this.PnlBase.Size = new System.Drawing.Size(179, 28);
            this.PnlBase.TabIndex = 1;
            // 
            // PnlArm
            // 
            this.PnlArm.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PnlArm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlArm.Location = new System.Drawing.Point(166, 99);
            this.PnlArm.Name = "PnlArm";
            this.PnlArm.Size = new System.Drawing.Size(179, 15);
            this.PnlArm.TabIndex = 2;
            // 
            // PnlHook
            // 
            this.PnlHook.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PnlHook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlHook.Location = new System.Drawing.Point(166, 103);
            this.PnlHook.Name = "PnlHook";
            this.PnlHook.Size = new System.Drawing.Size(11, 69);
            this.PnlHook.TabIndex = 3;
            // 
            // CmdHookHoch
            // 
            this.CmdHookHoch.Location = new System.Drawing.Point(637, 145);
            this.CmdHookHoch.Name = "CmdHookHoch";
            this.CmdHookHoch.Size = new System.Drawing.Size(75, 23);
            this.CmdHookHoch.TabIndex = 4;
            this.CmdHookHoch.Text = "hoch";
            this.CmdHookHoch.UseVisualStyleBackColor = true;
            this.CmdHookHoch.Click += new System.EventHandler(this.CmdHookHoch_Click);
            // 
            // CmdHookRunter
            // 
            this.CmdHookRunter.Location = new System.Drawing.Point(637, 174);
            this.CmdHookRunter.Name = "CmdHookRunter";
            this.CmdHookRunter.Size = new System.Drawing.Size(75, 23);
            this.CmdHookRunter.TabIndex = 5;
            this.CmdHookRunter.Text = "runter";
            this.CmdHookRunter.UseVisualStyleBackColor = true;
            this.CmdHookRunter.Click += new System.EventHandler(this.CmdHookRunter_Click);
            // 
            // CmdArmRaus
            // 
            this.CmdArmRaus.Location = new System.Drawing.Point(637, 203);
            this.CmdArmRaus.Name = "CmdArmRaus";
            this.CmdArmRaus.Size = new System.Drawing.Size(75, 23);
            this.CmdArmRaus.TabIndex = 6;
            this.CmdArmRaus.Text = "ausfahren";
            this.CmdArmRaus.UseVisualStyleBackColor = true;
            this.CmdArmRaus.Click += new System.EventHandler(this.CmdArmRaus_Click);
            // 
            // CmdArmEinfahren
            // 
            this.CmdArmEinfahren.Location = new System.Drawing.Point(637, 232);
            this.CmdArmEinfahren.Name = "CmdArmEinfahren";
            this.CmdArmEinfahren.Size = new System.Drawing.Size(75, 23);
            this.CmdArmEinfahren.TabIndex = 7;
            this.CmdArmEinfahren.Text = "einfahren";
            this.CmdArmEinfahren.UseVisualStyleBackColor = true;
            this.CmdArmEinfahren.Click += new System.EventHandler(this.CmdArmEinfahren_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(610, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Krangeschwindigkeit (ganze Zahl):";
            // 
            // TxtBoxEingabeGeschw
            // 
            this.TxtBoxEingabeGeschw.Location = new System.Drawing.Point(613, 317);
            this.TxtBoxEingabeGeschw.Name = "TxtBoxEingabeGeschw";
            this.TxtBoxEingabeGeschw.Size = new System.Drawing.Size(167, 20);
            this.TxtBoxEingabeGeschw.TabIndex = 10;
            this.TxtBoxEingabeGeschw.TextChanged += new System.EventHandler(this.TxtBoxEingabeGeschw_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtBoxEingabeGeschw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmdArmEinfahren);
            this.Controls.Add(this.CmdArmRaus);
            this.Controls.Add(this.CmdHookRunter);
            this.Controls.Add(this.CmdHookHoch);
            this.Controls.Add(this.PnlHook);
            this.Controls.Add(this.PnlMain);
            this.Controls.Add(this.PnlArm);
            this.Controls.Add(this.PnlBase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.Panel PnlBase;
        private System.Windows.Forms.Panel PnlArm;
        private System.Windows.Forms.Panel PnlHook;
        private System.Windows.Forms.Button CmdHookHoch;
        private System.Windows.Forms.Button CmdHookRunter;
        private System.Windows.Forms.Button CmdArmRaus;
        private System.Windows.Forms.Button CmdArmEinfahren;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBoxEingabeGeschw;
    }
}