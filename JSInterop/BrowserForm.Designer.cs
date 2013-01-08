namespace JSInterop
{
    partial class BrowserForm
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
            this._splitMain = new System.Windows.Forms.SplitContainer();
            this._browser = new System.Windows.Forms.WebBrowser();
            this._txtToSend = new System.Windows.Forms.TextBox();
            this._btnInvoke = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._splitMain)).BeginInit();
            this._splitMain.Panel1.SuspendLayout();
            this._splitMain.Panel2.SuspendLayout();
            this._splitMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // _splitMain
            // 
            this._splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splitMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this._splitMain.Location = new System.Drawing.Point(0, 0);
            this._splitMain.Name = "_splitMain";
            this._splitMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // _splitMain.Panel1
            // 
            this._splitMain.Panel1.Controls.Add(this._btnInvoke);
            this._splitMain.Panel1.Controls.Add(this._txtToSend);
            // 
            // _splitMain.Panel2
            // 
            this._splitMain.Panel2.Controls.Add(this._browser);
            this._splitMain.Size = new System.Drawing.Size(292, 266);
            this._splitMain.SplitterDistance = 25;
            this._splitMain.SplitterWidth = 1;
            this._splitMain.TabIndex = 0;
            // 
            // _browser
            // 
            this._browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this._browser.Location = new System.Drawing.Point(0, 0);
            this._browser.MinimumSize = new System.Drawing.Size(20, 20);
            this._browser.Name = "_browser";
            this._browser.Size = new System.Drawing.Size(292, 240);
            this._browser.TabIndex = 0;
            // 
            // _txtToSend
            // 
            this._txtToSend.Location = new System.Drawing.Point(3, 3);
            this._txtToSend.Name = "_txtToSend";
            this._txtToSend.Size = new System.Drawing.Size(100, 20);
            this._txtToSend.TabIndex = 0;
            // 
            // _btnInvoke
            // 
            this._btnInvoke.Location = new System.Drawing.Point(215, 1);
            this._btnInvoke.Name = "_btnInvoke";
            this._btnInvoke.Size = new System.Drawing.Size(75, 23);
            this._btnInvoke.TabIndex = 1;
            this._btnInvoke.Text = "&Send";
            this._btnInvoke.UseVisualStyleBackColor = true;
            // 
            // BrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this._splitMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BrowserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Browser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this._splitMain.Panel1.ResumeLayout(false);
            this._splitMain.Panel1.PerformLayout();
            this._splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitMain)).EndInit();
            this._splitMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer _splitMain;
        private System.Windows.Forms.WebBrowser _browser;
        private System.Windows.Forms.TextBox _txtToSend;
        private System.Windows.Forms.Button _btnInvoke;
    }
}

