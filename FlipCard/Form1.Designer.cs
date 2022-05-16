
namespace FlipCard
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
            this.cardFace = new System.Windows.Forms.PictureBox();
            this.cardBack = new System.Windows.Forms.PictureBox();
            this.cardBackButton = new System.Windows.Forms.Button();
            this.cardFaceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cardFace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBack)).BeginInit();
            this.SuspendLayout();
            // 
            // cardFace
            // 
            this.cardFace.Image = global::FlipCard.Properties.Resources.ace1;
            this.cardFace.Location = new System.Drawing.Point(594, 12);
            this.cardFace.Name = "cardFace";
            this.cardFace.Size = new System.Drawing.Size(495, 650);
            this.cardFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardFace.TabIndex = 1;
            this.cardFace.TabStop = false;
            this.cardFace.Visible = false;
            // 
            // cardBack
            // 
            this.cardBack.Image = global::FlipCard.Properties.Resources.card_back;
            this.cardBack.Location = new System.Drawing.Point(60, 12);
            this.cardBack.Name = "cardBack";
            this.cardBack.Size = new System.Drawing.Size(481, 650);
            this.cardBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardBack.TabIndex = 0;
            this.cardBack.TabStop = false;
            // 
            // cardBackButton
            // 
            this.cardBackButton.Location = new System.Drawing.Point(176, 716);
            this.cardBackButton.Name = "cardBackButton";
            this.cardBackButton.Size = new System.Drawing.Size(233, 99);
            this.cardBackButton.TabIndex = 2;
            this.cardBackButton.Text = "Show the Card Back";
            this.cardBackButton.UseVisualStyleBackColor = true;
            this.cardBackButton.Click += new System.EventHandler(this.cardBackButton_Click);
            // 
            // cardFaceButton
            // 
            this.cardFaceButton.Location = new System.Drawing.Point(720, 716);
            this.cardFaceButton.Name = "cardFaceButton";
            this.cardFaceButton.Size = new System.Drawing.Size(233, 99);
            this.cardFaceButton.TabIndex = 3;
            this.cardFaceButton.Text = "Show the Card Face";
            this.cardFaceButton.UseVisualStyleBackColor = true;
            this.cardFaceButton.Click += new System.EventHandler(this.cardFaceButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 854);
            this.Controls.Add(this.cardFaceButton);
            this.Controls.Add(this.cardBackButton);
            this.Controls.Add(this.cardFace);
            this.Controls.Add(this.cardBack);
            this.Name = "Form1";
            this.Text = "FlipCard";
            ((System.ComponentModel.ISupportInitialize)(this.cardFace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cardBack;
        private System.Windows.Forms.PictureBox cardFace;
        private System.Windows.Forms.Button cardBackButton;
        private System.Windows.Forms.Button cardFaceButton;
    }
}

