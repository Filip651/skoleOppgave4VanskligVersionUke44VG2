namespace oppgave4VanskligVersion
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
            this.btnClick = new System.Windows.Forms.Button();
            this.lblNumOfClicks = new System.Windows.Forms.Label();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.tCountDown = new System.Windows.Forms.Timer(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.BackColor = System.Drawing.Color.Lime;
            this.btnClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClick.Location = new System.Drawing.Point(12, 112);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(254, 123);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "Klikker";
            this.btnClick.UseVisualStyleBackColor = false;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // lblNumOfClicks
            // 
            this.lblNumOfClicks.AutoSize = true;
            this.lblNumOfClicks.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfClicks.Location = new System.Drawing.Point(43, 347);
            this.lblNumOfClicks.Name = "lblNumOfClicks";
            this.lblNumOfClicks.Size = new System.Drawing.Size(51, 55);
            this.lblNumOfClicks.TabIndex = 1;
            this.lblNumOfClicks.Text = "0";
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLeft.Location = new System.Drawing.Point(348, 347);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(51, 55);
            this.lblTimeLeft.TabIndex = 2;
            this.lblTimeLeft.Text = "0";
            // 
            // tCountDown
            // 
            this.tCountDown.Tick += new System.EventHandler(this.tCountDown_Tick);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(134, 347);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(183, 55);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Start på nytt";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::oppgave4VanskligVersion.Properties.Resources.mouse;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(462, 468);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.lblNumOfClicks);
            this.Controls.Add(this.btnClick);
            this.Name = "Form1";
            this.Text = "GameChanger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Label lblNumOfClicks;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Timer tCountDown;
        private System.Windows.Forms.Button btnReset;
    }
}

