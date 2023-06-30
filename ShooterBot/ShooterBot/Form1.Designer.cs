namespace ShooterBot
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
            this.GreenRectangularButton = new System.Windows.Forms.Button();
            this.BlueRectangularButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Port_ComboBox = new System.Windows.Forms.ComboBox();
            this.BaudRate_ComboBox = new System.Windows.Forms.ComboBox();
            this.OpenButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SerialPortConnection = new System.IO.Ports.SerialPort(this.components);
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.RedCircularButton = new ShooterBot.CircularButton();
            this.BlueTriangularButton = new ShooterBot.TriangleButton();
            this.GreenCircularButton = new ShooterBot.CircularButton();
            this.RedTriangularButton = new ShooterBot.TriangleButton();
            this.SuspendLayout();
            // 
            // GreenRectangularButton
            // 
            this.GreenRectangularButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(192)))), ((int)(((byte)(99)))));
            this.GreenRectangularButton.FlatAppearance.BorderSize = 0;
            this.GreenRectangularButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreenRectangularButton.Location = new System.Drawing.Point(53, 261);
            this.GreenRectangularButton.Name = "GreenRectangularButton";
            this.GreenRectangularButton.Size = new System.Drawing.Size(255, 218);
            this.GreenRectangularButton.TabIndex = 4;
            this.GreenRectangularButton.UseVisualStyleBackColor = false;
            this.GreenRectangularButton.Click += new System.EventHandler(this.GreenRectangularButton_Click);
            // 
            // BlueRectangularButton
            // 
            this.BlueRectangularButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.BlueRectangularButton.FlatAppearance.BorderSize = 0;
            this.BlueRectangularButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlueRectangularButton.Location = new System.Drawing.Point(430, 585);
            this.BlueRectangularButton.Name = "BlueRectangularButton";
            this.BlueRectangularButton.Size = new System.Drawing.Size(255, 218);
            this.BlueRectangularButton.TabIndex = 5;
            this.BlueRectangularButton.UseVisualStyleBackColor = false;
            this.BlueRectangularButton.Click += new System.EventHandler(this.BlueRectangularButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(-1, 891);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(786, 65);
            this.ResetButton.TabIndex = 6;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(766, 891);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(718, 65);
            this.SendButton.TabIndex = 7;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1049, 93);
            this.label1.TabIndex = 8;
            this.label1.Text = "CHOOSE YOUR TARGETS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(608, 46);
            this.label2.TabIndex = 9;
            this.label2.Text = "Choose three of these targets ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1236, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1236, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "label4";
            // 
            // Port_ComboBox
            // 
            this.Port_ComboBox.FormattingEnabled = true;
            this.Port_ComboBox.Location = new System.Drawing.Point(1318, 336);
            this.Port_ComboBox.Name = "Port_ComboBox";
            this.Port_ComboBox.Size = new System.Drawing.Size(121, 24);
            this.Port_ComboBox.TabIndex = 12;
            // 
            // BaudRate_ComboBox
            // 
            this.BaudRate_ComboBox.FormattingEnabled = true;
            this.BaudRate_ComboBox.Location = new System.Drawing.Point(1318, 409);
            this.BaudRate_ComboBox.Name = "BaudRate_ComboBox";
            this.BaudRate_ComboBox.Size = new System.Drawing.Size(121, 24);
            this.BaudRate_ComboBox.TabIndex = 13;
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(1239, 495);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(75, 23);
            this.OpenButton.TabIndex = 14;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(1239, 594);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 15;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(1395, 593);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 16;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(1209, 232);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(184, 23);
            this.ProgressBar.TabIndex = 17;
            // 
            // RedCircularButton
            // 
            this.RedCircularButton.BackColor = System.Drawing.Color.Red;
            this.RedCircularButton.FlatAppearance.BorderSize = 0;
            this.RedCircularButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RedCircularButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedCircularButton.Location = new System.Drawing.Point(461, 276);
            this.RedCircularButton.Name = "RedCircularButton";
            this.RedCircularButton.Size = new System.Drawing.Size(204, 203);
            this.RedCircularButton.TabIndex = 3;
            this.RedCircularButton.UseVisualStyleBackColor = false;
            this.RedCircularButton.Click += new System.EventHandler(this.RedCircularButton_Click);
            // 
            // BlueTriangularButton
            // 
            this.BlueTriangularButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.BlueTriangularButton.FlatAppearance.BorderSize = 0;
            this.BlueTriangularButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BlueTriangularButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlueTriangularButton.Location = new System.Drawing.Point(786, 232);
            this.BlueTriangularButton.Name = "BlueTriangularButton";
            this.BlueTriangularButton.Size = new System.Drawing.Size(304, 276);
            this.BlueTriangularButton.TabIndex = 2;
            this.BlueTriangularButton.UseVisualStyleBackColor = false;
            this.BlueTriangularButton.Click += new System.EventHandler(this.BlueTriangularButton_Click);
            // 
            // GreenCircularButton
            // 
            this.GreenCircularButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(192)))), ((int)(((byte)(99)))));
            this.GreenCircularButton.FlatAppearance.BorderSize = 0;
            this.GreenCircularButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GreenCircularButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreenCircularButton.Location = new System.Drawing.Point(837, 571);
            this.GreenCircularButton.Name = "GreenCircularButton";
            this.GreenCircularButton.Size = new System.Drawing.Size(204, 203);
            this.GreenCircularButton.TabIndex = 1;
            this.GreenCircularButton.UseVisualStyleBackColor = false;
            this.GreenCircularButton.Click += new System.EventHandler(this.GreenCircularButton_Click);
            // 
            // RedTriangularButton
            // 
            this.RedTriangularButton.BackColor = System.Drawing.Color.Red;
            this.RedTriangularButton.FlatAppearance.BorderSize = 0;
            this.RedTriangularButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RedTriangularButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedTriangularButton.Location = new System.Drawing.Point(29, 557);
            this.RedTriangularButton.Name = "RedTriangularButton";
            this.RedTriangularButton.Size = new System.Drawing.Size(304, 276);
            this.RedTriangularButton.TabIndex = 0;
            this.RedTriangularButton.UseVisualStyleBackColor = false;
            this.RedTriangularButton.Click += new System.EventHandler(this.RedTriangularButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1482, 953);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.BaudRate_ComboBox);
            this.Controls.Add(this.Port_ComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.BlueRectangularButton);
            this.Controls.Add(this.GreenRectangularButton);
            this.Controls.Add(this.RedCircularButton);
            this.Controls.Add(this.BlueTriangularButton);
            this.Controls.Add(this.GreenCircularButton);
            this.Controls.Add(this.RedTriangularButton);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TriangleButton RedTriangularButton;
        private CircularButton GreenCircularButton;
        private CircularButton RedCircularButton;
        private TriangleButton BlueTriangularButton;
        private System.Windows.Forms.Button GreenRectangularButton;
        private System.Windows.Forms.Button BlueRectangularButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Port_ComboBox;
        private System.Windows.Forms.ComboBox BaudRate_ComboBox;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button CloseButton;
        private System.IO.Ports.SerialPort SerialPortConnection;
        private System.Windows.Forms.ProgressBar ProgressBar;
    }
}

