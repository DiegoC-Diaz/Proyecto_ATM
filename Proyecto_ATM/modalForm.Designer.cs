namespace Proyecto_ATM
{
    partial class modalForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modalForm));
            label1 = new Label();
            ok_btn = new RoundButton();
            roundButton2 = new RoundButton();
            modalEffect_Timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.FromArgb(204, 24, 38);
            label1.Name = "label1";
            label1.Click += label1_Click;
            // 
            // ok_btn
            // 
            resources.ApplyResources(ok_btn, "ok_btn");
            ok_btn.BackColor = Color.FromArgb(204, 24, 38);
            ok_btn.BackgroundColor = Color.FromArgb(204, 24, 38);
            ok_btn.BorderColor = Color.FromArgb(204, 24, 38);
            ok_btn.BorderRadius = 10;
            ok_btn.BorderSize = 1;
            ok_btn.FlatAppearance.BorderSize = 0;
            ok_btn.ForeColor = Color.White;
            ok_btn.Name = "ok_btn";
            ok_btn.TextColor = Color.White;
            ok_btn.UseVisualStyleBackColor = false;
            ok_btn.Click += ok_btn_Click;
            // 
            // roundButton2
            // 
            resources.ApplyResources(roundButton2, "roundButton2");
            roundButton2.BackColor = Color.FromArgb(143, 14, 24);
            roundButton2.BackgroundColor = Color.FromArgb(143, 14, 24);
            roundButton2.BorderColor = Color.PaleVioletRed;
            roundButton2.BorderRadius = 10;
            roundButton2.BorderSize = 0;
            roundButton2.FlatAppearance.BorderSize = 0;
            roundButton2.ForeColor = Color.White;
            roundButton2.Name = "roundButton2";
            roundButton2.TextColor = Color.White;
            roundButton2.UseVisualStyleBackColor = false;
            // 
            // modalEffect_Timer
            // 
            modalEffect_Timer.Enabled = true;
            modalEffect_Timer.Interval = 1;
            modalEffect_Timer.Tick += modalEffect_Timer_Tick;
            // 
            // modalForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(ok_btn);
            Controls.Add(roundButton2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "modalForm";
            Load += modalForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RoundButton ok_btn;
        private RoundButton roundButton2;
        private System.Windows.Forms.Timer modalEffect_Timer;
    }
}