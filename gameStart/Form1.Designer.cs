
namespace gameStart
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
            this.startButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.countDown = new System.Windows.Forms.Label();
            this.gameGo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.startButton.Location = new System.Drawing.Point(230, 126);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(114, 57);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(168, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // countDown
            // 
            this.countDown.AutoSize = true;
            this.countDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countDown.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.countDown.Location = new System.Drawing.Point(271, 141);
            this.countDown.Name = "countDown";
            this.countDown.Size = new System.Drawing.Size(20, 24);
            this.countDown.TabIndex = 2;
            this.countDown.Text = "3";
            this.countDown.Visible = false;
            // 
            // gameGo
            // 
            this.gameGo.AutoSize = true;
            this.gameGo.BackColor = System.Drawing.Color.Transparent;
            this.gameGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameGo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gameGo.Location = new System.Drawing.Point(248, 141);
            this.gameGo.Name = "gameGo";
            this.gameGo.Size = new System.Drawing.Size(78, 42);
            this.gameGo.TabIndex = 3;
            this.gameGo.Text = "Go!";
            this.gameGo.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(595, 361);
            this.Controls.Add(this.gameGo);
            this.Controls.Add(this.countDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label countDown;
        private System.Windows.Forms.Label gameGo;
    }
}

