namespace WindowsFormsApp11
{
    partial class Explorer
    {

        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows


        private void InitializeComponent()
        {
            this.explorerTreeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
          
            this.explorerTreeView.Location = new System.Drawing.Point(16, 15);
            this.explorerTreeView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.explorerTreeView.Name = "explorerTreeView";
            this.explorerTreeView.Size = new System.Drawing.Size(521, 517);
            this.explorerTreeView.TabIndex = 0;
            this.explorerTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.explorerTreeView_AfterSelect);
           
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 548);
            this.Controls.Add(this.explorerTreeView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Explorer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView explorerTreeView;
    }
}
