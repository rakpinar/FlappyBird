
namespace FlappyBird1
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
            this.label1 = new System.Windows.Forms.Label();
            this.timerGameControl = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxGround = new System.Windows.Forms.PictureBox();
            this.pictureBoxBottom = new System.Windows.Forms.PictureBox();
            this.pictureBoxBird = new System.Windows.Forms.PictureBox();
            this.pictureBoxTop = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTop)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "SCORE:";
            // 
            // timerGameControl
            // 
            this.timerGameControl.Enabled = true;
            this.timerGameControl.Interval = 20;
            this.timerGameControl.Tick += new System.EventHandler(this.gameTimer);
            // 
            // pictureBoxGround
            // 
            this.pictureBoxGround.Image = global::FlappyBird1.Properties.Resources._base;
            this.pictureBoxGround.Location = new System.Drawing.Point(-1, 697);
            this.pictureBoxGround.Name = "pictureBoxGround";
            this.pictureBoxGround.Size = new System.Drawing.Size(632, 102);
            this.pictureBoxGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGround.TabIndex = 3;
            this.pictureBoxGround.TabStop = false;
            // 
            // pictureBoxBottom
            // 
            this.pictureBoxBottom.Image = global::FlappyBird1.Properties.Resources.pipeup;
            this.pictureBoxBottom.Location = new System.Drawing.Point(411, 461);
            this.pictureBoxBottom.Name = "pictureBoxBottom";
            this.pictureBoxBottom.Size = new System.Drawing.Size(118, 240);
            this.pictureBoxBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBottom.TabIndex = 2;
            this.pictureBoxBottom.TabStop = false;
            // 
            // pictureBoxBird
            // 
            this.pictureBoxBird.Image = global::FlappyBird1.Properties.Resources.yellowbird_upflap;
            this.pictureBoxBird.Location = new System.Drawing.Point(32, 265);
            this.pictureBoxBird.Name = "pictureBoxBird";
            this.pictureBoxBird.Size = new System.Drawing.Size(73, 54);
            this.pictureBoxBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBird.TabIndex = 1;
            this.pictureBoxBird.TabStop = false;
            // 
            // pictureBoxTop
            // 
            this.pictureBoxTop.Image = global::FlappyBird1.Properties.Resources.pipedown;
            this.pictureBoxTop.Location = new System.Drawing.Point(413, -3);
            this.pictureBoxTop.Name = "pictureBoxTop";
            this.pictureBoxTop.Size = new System.Drawing.Size(116, 253);
            this.pictureBoxTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTop.TabIndex = 0;
            this.pictureBoxTop.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(631, 799);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxGround);
            this.Controls.Add(this.pictureBoxBottom);
            this.Controls.Add(this.pictureBoxBird);
            this.Controls.Add(this.pictureBoxTop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTop;
        private System.Windows.Forms.PictureBox pictureBoxBird;
        private System.Windows.Forms.PictureBox pictureBoxBottom;
        private System.Windows.Forms.PictureBox pictureBoxGround;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerGameControl;
    }
}

