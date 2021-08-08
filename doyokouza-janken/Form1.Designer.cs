
namespace doyokouza_janken
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rock = new System.Windows.Forms.Button();
            this.scissors = new System.Windows.Forms.Button();
            this.paper = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // rock
            // 
            this.rock.Location = new System.Drawing.Point(12, 212);
            this.rock.Name = "rock";
            this.rock.Size = new System.Drawing.Size(114, 137);
            this.rock.TabIndex = 0;
            this.rock.Text = "グー";
            this.rock.UseVisualStyleBackColor = true;
            this.rock.Click += new System.EventHandler(this.rock_Click);
            // 
            // scissors
            // 
            this.scissors.Location = new System.Drawing.Point(132, 212);
            this.scissors.Name = "scissors";
            this.scissors.Size = new System.Drawing.Size(120, 137);
            this.scissors.TabIndex = 0;
            this.scissors.Text = "チョキ";
            this.scissors.UseVisualStyleBackColor = true;
            this.scissors.Click += new System.EventHandler(this.scissors_Click);
            // 
            // paper
            // 
            this.paper.Location = new System.Drawing.Point(258, 212);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(114, 137);
            this.paper.TabIndex = 0;
            this.paper.Text = "パー";
            this.paper.UseVisualStyleBackColor = true;
            this.paper.Click += new System.EventHandler(this.paper_Click);
            // 
            // picture
            // 
            this.picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.Location = new System.Drawing.Point(12, 12);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(360, 194);
            this.picture.TabIndex = 1;
            this.picture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.paper);
            this.Controls.Add(this.scissors);
            this.Controls.Add(this.rock);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rock;
        private System.Windows.Forms.Button scissors;
        private System.Windows.Forms.Button paper;
        private System.Windows.Forms.PictureBox picture;
    }
}

