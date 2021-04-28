namespace Connect4
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
            this.btn_col1 = new System.Windows.Forms.Button();
            this.btn_col2 = new System.Windows.Forms.Button();
            this.btn_col3 = new System.Windows.Forms.Button();
            this.btn_col4 = new System.Windows.Forms.Button();
            this.btn_col5 = new System.Windows.Forms.Button();
            this.btn_col6 = new System.Windows.Forms.Button();
            this.btn_col7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.userText = new System.Windows.Forms.TextBox();
            this.FinalScreen = new System.Windows.Forms.Panel();
            this.NewGame = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.WinnerLabel = new System.Windows.Forms.Label();
            this.FinalScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_col1
            // 
            this.btn_col1.Location = new System.Drawing.Point(100, 18);
            this.btn_col1.Margin = new System.Windows.Forms.Padding(4);
            this.btn_col1.Name = "btn_col1";
            this.btn_col1.Size = new System.Drawing.Size(67, 31);
            this.btn_col1.TabIndex = 0;
            this.btn_col1.Text = "V";
            this.btn_col1.UseVisualStyleBackColor = true;
            this.btn_col1.Click += new System.EventHandler(this.btn_col1_Click);
            // 
            // btn_col2
            // 
            this.btn_col2.Location = new System.Drawing.Point(233, 18);
            this.btn_col2.Margin = new System.Windows.Forms.Padding(4);
            this.btn_col2.Name = "btn_col2";
            this.btn_col2.Size = new System.Drawing.Size(67, 31);
            this.btn_col2.TabIndex = 1;
            this.btn_col2.Text = "V";
            this.btn_col2.UseVisualStyleBackColor = true;
            this.btn_col2.Click += new System.EventHandler(this.btn_col2_Click);
            // 
            // btn_col3
            // 
            this.btn_col3.Location = new System.Drawing.Point(367, 18);
            this.btn_col3.Margin = new System.Windows.Forms.Padding(4);
            this.btn_col3.Name = "btn_col3";
            this.btn_col3.Size = new System.Drawing.Size(67, 31);
            this.btn_col3.TabIndex = 2;
            this.btn_col3.Text = "V";
            this.btn_col3.UseVisualStyleBackColor = true;
            this.btn_col3.Click += new System.EventHandler(this.btn_col3_Click);
            // 
            // btn_col4
            // 
            this.btn_col4.Location = new System.Drawing.Point(500, 18);
            this.btn_col4.Margin = new System.Windows.Forms.Padding(4);
            this.btn_col4.Name = "btn_col4";
            this.btn_col4.Size = new System.Drawing.Size(67, 31);
            this.btn_col4.TabIndex = 3;
            this.btn_col4.Text = "V";
            this.btn_col4.UseVisualStyleBackColor = true;
            this.btn_col4.Click += new System.EventHandler(this.btn_col4_Click);
            // 
            // btn_col5
            // 
            this.btn_col5.Location = new System.Drawing.Point(633, 18);
            this.btn_col5.Margin = new System.Windows.Forms.Padding(4);
            this.btn_col5.Name = "btn_col5";
            this.btn_col5.Size = new System.Drawing.Size(67, 31);
            this.btn_col5.TabIndex = 4;
            this.btn_col5.Text = "V";
            this.btn_col5.UseVisualStyleBackColor = true;
            this.btn_col5.Click += new System.EventHandler(this.btn_col5_Click);
            // 
            // btn_col6
            // 
            this.btn_col6.Location = new System.Drawing.Point(767, 18);
            this.btn_col6.Margin = new System.Windows.Forms.Padding(4);
            this.btn_col6.Name = "btn_col6";
            this.btn_col6.Size = new System.Drawing.Size(67, 31);
            this.btn_col6.TabIndex = 5;
            this.btn_col6.Text = "V";
            this.btn_col6.UseVisualStyleBackColor = true;
            this.btn_col6.Click += new System.EventHandler(this.btn_col6_Click);
            // 
            // btn_col7
            // 
            this.btn_col7.Location = new System.Drawing.Point(900, 18);
            this.btn_col7.Margin = new System.Windows.Forms.Padding(4);
            this.btn_col7.Name = "btn_col7";
            this.btn_col7.Size = new System.Drawing.Size(67, 31);
            this.btn_col7.TabIndex = 6;
            this.btn_col7.Text = "V";
            this.btn_col7.UseVisualStyleBackColor = true;
            this.btn_col7.Click += new System.EventHandler(this.btn_col7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // userText
            // 
            this.userText.Location = new System.Drawing.Point(485, 0);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(100, 22);
            this.userText.TabIndex = 9;
            // 
            // FinalScreen
            // 
            this.FinalScreen.Controls.Add(this.WinnerLabel);
            this.FinalScreen.Controls.Add(this.Exit);
            this.FinalScreen.Controls.Add(this.NewGame);
            this.FinalScreen.Location = new System.Drawing.Point(0, 0);
            this.FinalScreen.Name = "FinalScreen";
            this.FinalScreen.Size = new System.Drawing.Size(1080, 573);
            this.FinalScreen.TabIndex = 10;
            // 
            // NewGame
            // 
            this.NewGame.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGame.Location = new System.Drawing.Point(450, 200);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(154, 42);
            this.NewGame.TabIndex = 1;
            this.NewGame.Text = "Play Again";
            this.NewGame.UseVisualStyleBackColor = false;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(485, 248);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(95, 42);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Quit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // WinnerLabel
            // 
            this.WinnerLabel.AutoSize = true;
            this.WinnerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinnerLabel.Location = new System.Drawing.Point(386, 149);
            this.WinnerLabel.Name = "WinnerLabel";
            this.WinnerLabel.Size = new System.Drawing.Size(314, 48);
            this.WinnerLabel.TabIndex = 4;
            this.WinnerLabel.Text = "The Winner is...";
            this.WinnerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 897);
            this.Controls.Add(this.FinalScreen);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_col7);
            this.Controls.Add(this.btn_col6);
            this.Controls.Add(this.btn_col5);
            this.Controls.Add(this.btn_col4);
            this.Controls.Add(this.btn_col3);
            this.Controls.Add(this.btn_col2);
            this.Controls.Add(this.btn_col1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Connect 4 - My Name";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FinalScreen.ResumeLayout(false);
            this.FinalScreen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_col1;
        private System.Windows.Forms.Button btn_col2;
        private System.Windows.Forms.Button btn_col3;
        private System.Windows.Forms.Button btn_col4;
        private System.Windows.Forms.Button btn_col5;
        private System.Windows.Forms.Button btn_col6;
        private System.Windows.Forms.Button btn_col7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userText;
        private System.Windows.Forms.Panel FinalScreen;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Label WinnerLabel;
    }
}

