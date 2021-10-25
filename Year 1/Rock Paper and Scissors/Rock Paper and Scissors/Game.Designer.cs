
namespace Rock_Paper_and_Scissors
{
    partial class Game
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.WinsLabel = new System.Windows.Forms.Label();
            this.NoOneLabel = new System.Windows.Forms.Label();
            this.FallsLabel = new System.Windows.Forms.Label();
            this.scissors = new System.Windows.Forms.PictureBox();
            this.paper = new System.Windows.Forms.PictureBox();
            this.rock = new System.Windows.Forms.PictureBox();
            this.bot_choice = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bot_choice)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(572, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Робот думає ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(159)))), ((int)(((byte)(176)))));
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(361, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Знову";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.scissors);
            this.flowLayoutPanel1.Controls.Add(this.paper);
            this.flowLayoutPanel1.Controls.Add(this.rock);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(80, 59);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(215, 407);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NameLabel.Location = new System.Drawing.Point(338, 46);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(100, 28);
            this.NameLabel.TabIndex = 10;
            this.NameLabel.Text = "Гравець: ";
            // 
            // WinsLabel
            // 
            this.WinsLabel.AutoSize = true;
            this.WinsLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WinsLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.WinsLabel.Location = new System.Drawing.Point(338, 74);
            this.WinsLabel.Name = "WinsLabel";
            this.WinsLabel.Size = new System.Drawing.Size(136, 28);
            this.WinsLabel.TabIndex = 11;
            this.WinsLabel.Text = "Перемоги: 0";
            // 
            // NoOneLabel
            // 
            this.NoOneLabel.AutoSize = true;
            this.NoOneLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoOneLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NoOneLabel.Location = new System.Drawing.Point(338, 102);
            this.NoOneLabel.Name = "NoOneLabel";
            this.NoOneLabel.Size = new System.Drawing.Size(80, 28);
            this.NoOneLabel.TabIndex = 12;
            this.NoOneLabel.Text = "Нічії: 0";
            // 
            // FallsLabel
            // 
            this.FallsLabel.AutoSize = true;
            this.FallsLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FallsLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FallsLabel.Location = new System.Drawing.Point(338, 130);
            this.FallsLabel.Name = "FallsLabel";
            this.FallsLabel.Size = new System.Drawing.Size(128, 28);
            this.FallsLabel.TabIndex = 13;
            this.FallsLabel.Text = "Програші: 0";
            // 
            // scissors
            // 
            this.scissors.Image = global::Rock_Paper_and_Scissors.Properties.Resources.icons8_hand_scissors_100;
            this.scissors.Location = new System.Drawing.Point(3, 3);
            this.scissors.Name = "scissors";
            this.scissors.Size = new System.Drawing.Size(204, 127);
            this.scissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.scissors.TabIndex = 0;
            this.scissors.TabStop = false;
            this.scissors.Click += new System.EventHandler(this.scissors_Click);
            // 
            // paper
            // 
            this.paper.Image = global::Rock_Paper_and_Scissors.Properties.Resources.icons8_hand_100;
            this.paper.Location = new System.Drawing.Point(3, 136);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(204, 137);
            this.paper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.paper.TabIndex = 2;
            this.paper.TabStop = false;
            this.paper.Click += new System.EventHandler(this.paper_Click);
            // 
            // rock
            // 
            this.rock.Image = global::Rock_Paper_and_Scissors.Properties.Resources.icons8_hand_rock_100;
            this.rock.Location = new System.Drawing.Point(3, 279);
            this.rock.Name = "rock";
            this.rock.Size = new System.Drawing.Size(204, 127);
            this.rock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.rock.TabIndex = 1;
            this.rock.TabStop = false;
            this.rock.Click += new System.EventHandler(this.rock_Click);
            // 
            // bot_choice
            // 
            this.bot_choice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bot_choice.Image = global::Rock_Paper_and_Scissors.Properties.Resources.icons8_concerned_face_100;
            this.bot_choice.Location = new System.Drawing.Point(540, 195);
            this.bot_choice.Name = "bot_choice";
            this.bot_choice.Size = new System.Drawing.Size(204, 137);
            this.bot_choice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bot_choice.TabIndex = 5;
            this.bot_choice.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(106)))), ((int)(((byte)(149)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(361, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Грати";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(31)))), ((int)(((byte)(57)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(791, 549);
            this.ControlBox = false;
            this.Controls.Add(this.FallsLabel);
            this.Controls.Add(this.NoOneLabel);
            this.Controls.Add(this.WinsLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bot_choice);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bot_choice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox scissors;
        private System.Windows.Forms.PictureBox rock;
        private System.Windows.Forms.PictureBox paper;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox bot_choice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label WinsLabel;
        private System.Windows.Forms.Label NoOneLabel;
        private System.Windows.Forms.Label FallsLabel;
    }
}