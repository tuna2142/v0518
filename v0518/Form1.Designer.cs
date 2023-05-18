namespace v0518
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
            player = new Button();
            leftButton = new Button();
            downButton = new Button();
            rightButton = new Button();
            upButton = new Button();
            SuspendLayout();
            // 
            // player
            // 
            player.Location = new Point(333, 205);
            player.Name = "player";
            player.Size = new Size(75, 23);
            player.TabIndex = 0;
            player.Text = "自分";
            player.UseVisualStyleBackColor = true;
            player.Click += button1_Click;
            // 
            // leftButton
            // 
            leftButton.Location = new Point(12, 336);
            leftButton.Name = "leftButton";
            leftButton.Size = new Size(48, 48);
            leftButton.TabIndex = 1;
            leftButton.Text = "←";
            leftButton.UseVisualStyleBackColor = true;
            leftButton.Click += leftButton_Click;
            // 
            // downButton
            // 
            downButton.Location = new Point(61, 390);
            downButton.Name = "downButton";
            downButton.Size = new Size(48, 48);
            downButton.TabIndex = 2;
            downButton.Text = "↓";
            downButton.UseVisualStyleBackColor = true;
            downButton.Click += downButton_Click;
            // 
            // rightButton
            // 
            rightButton.Location = new Point(110, 336);
            rightButton.Name = "rightButton";
            rightButton.Size = new Size(48, 48);
            rightButton.TabIndex = 3;
            rightButton.Text = "→";
            rightButton.UseVisualStyleBackColor = true;
            rightButton.Click += rightButton_Click;
            // 
            // upButton
            // 
            upButton.Location = new Point(61, 282);
            upButton.Name = "upButton";
            upButton.Size = new Size(48, 48);
            upButton.TabIndex = 4;
            upButton.Text = "↑";
            upButton.UseVisualStyleBackColor = true;
            upButton.Click += upButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(upButton);
            Controls.Add(rightButton);
            Controls.Add(downButton);
            Controls.Add(leftButton);
            Controls.Add(player);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button player;
        private Button leftButton;
        private Button downButton;
        private Button rightButton;
        private Button upButton;
    }
}