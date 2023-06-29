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
            this.SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.button7 = new System.Windows.Forms.Button();
            this.circularButton1 = new ShooterBot.CircularButton();
            this.triangleButton1 = new ShooterBot.TriangleButton();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(765, 614);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 12;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // circularButton1
            // 
            this.circularButton1.BackColor = System.Drawing.Color.Red;
            this.circularButton1.FlatAppearance.BorderSize = 0;
            this.circularButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButton1.Location = new System.Drawing.Point(176, 95);
            this.circularButton1.Name = "circularButton1";
            this.circularButton1.Size = new System.Drawing.Size(199, 190);
            this.circularButton1.TabIndex = 13;
            this.circularButton1.Text = "circularButton1";
            this.circularButton1.UseVisualStyleBackColor = false;
            // 
            // triangleButton1
            // 
            this.triangleButton1.BackColor = System.Drawing.Color.Red;
            this.triangleButton1.FlatAppearance.BorderSize = 0;
            this.triangleButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.triangleButton1.Location = new System.Drawing.Point(466, 85);
            this.triangleButton1.Name = "triangleButton1";
            this.triangleButton1.Size = new System.Drawing.Size(263, 243);
            this.triangleButton1.TabIndex = 14;
            this.triangleButton1.Text = "triangleButton1";
            this.triangleButton1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1024, 684);
            this.Controls.Add(this.triangleButton1);
            this.Controls.Add(this.circularButton1);
            this.Controls.Add(this.button7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort SerialPort;
        private System.Windows.Forms.Button button7;
        private CircularButton circularButton1;
        private TriangleButton triangleButton1;
    }
}

