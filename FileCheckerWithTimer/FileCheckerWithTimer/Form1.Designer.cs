namespace FileCheckerWithTimer
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
            components = new System.ComponentModel.Container();
            lblFilePath = new Label();
            btnBrowseFile = new Button();
            txtChanges = new TextBox();
            timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblFilePath
            // 
            lblFilePath.AutoSize = true;
            lblFilePath.Location = new Point(180, 94);
            lblFilePath.Name = "lblFilePath";
            lblFilePath.Size = new Size(81, 25);
            lblFilePath.TabIndex = 0;
            lblFilePath.Text = "File Path:";
            // 
            // btnBrowseFile
            // 
            btnBrowseFile.Location = new Point(516, 89);
            btnBrowseFile.Name = "btnBrowseFile";
            btnBrowseFile.Size = new Size(112, 34);
            btnBrowseFile.TabIndex = 1;
            btnBrowseFile.Text = "Browse";
            btnBrowseFile.UseVisualStyleBackColor = true;
            btnBrowseFile.Click += btnBrowseFile_Click;
            // 
            // txtChanges
            // 
            txtChanges.Location = new Point(180, 161);
            txtChanges.Multiline = true;
            txtChanges.Name = "txtChanges";
            txtChanges.ScrollBars = ScrollBars.Vertical;
            txtChanges.Size = new Size(448, 203);
            txtChanges.TabIndex = 2;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtChanges);
            Controls.Add(btnBrowseFile);
            Controls.Add(lblFilePath);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFilePath;
        private Button btnBrowseFile;
        private TextBox txtChanges;
        private System.Windows.Forms.Timer timer;
    }
}
