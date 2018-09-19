namespace RestockingFee
{
    partial class MainWindow
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
            this.pasteButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.inputTextbox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pasteButton
            // 
            this.pasteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasteButton.Location = new System.Drawing.Point(255, 0);
            this.pasteButton.Name = "pasteButton";
            this.pasteButton.Size = new System.Drawing.Size(150, 80);
            this.pasteButton.TabIndex = 0;
            this.pasteButton.Text = "Paste";
            this.pasteButton.UseVisualStyleBackColor = true;
            this.pasteButton.Click += new System.EventHandler(this.PasteButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.copyButton.Location = new System.Drawing.Point(255, 86);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(150, 80);
            this.copyButton.TabIndex = 1;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // inputTextbox
            // 
            this.inputTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextbox.Location = new System.Drawing.Point(0, 0);
            this.inputTextbox.Name = "inputTextbox";
            this.inputTextbox.Size = new System.Drawing.Size(250, 80);
            this.inputTextbox.TabIndex = 2;
            this.inputTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputTextbox.TextChanged += new System.EventHandler(this.InputTextbox_TextChanged);
            this.inputTextbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InputTextbox_MouseClick);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTextBox.Location = new System.Drawing.Point(0, 86);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(250, 80);
            this.outputTextBox.TabIndex = 3;
            this.outputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.outputTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OutputTextbox_MouseClick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 169);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputTextbox);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.pasteButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainWindow";
            this.Text = "10%";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pasteButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.TextBox inputTextbox;
        private System.Windows.Forms.TextBox outputTextBox;
    }
}

