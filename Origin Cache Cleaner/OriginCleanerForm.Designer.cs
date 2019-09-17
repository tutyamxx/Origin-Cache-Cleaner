namespace Origin_Cache_Cleaner
{
    partial class frm_OriginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_OriginForm));
            this.picOrigin = new System.Windows.Forms.PictureBox();
            this.btn_ClearOriginCache = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picOrigin)).BeginInit();
            this.grpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // picOrigin
            // 
            this.picOrigin.Image = ((System.Drawing.Image)(resources.GetObject("picOrigin.Image")));
            this.picOrigin.Location = new System.Drawing.Point(13, 13);
            this.picOrigin.Name = "picOrigin";
            this.picOrigin.Size = new System.Drawing.Size(145, 131);
            this.picOrigin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOrigin.TabIndex = 0;
            this.picOrigin.TabStop = false;
            // 
            // btn_ClearOriginCache
            // 
            this.btn_ClearOriginCache.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_ClearOriginCache.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_ClearOriginCache.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClearOriginCache.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClearOriginCache.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ClearOriginCache.Location = new System.Drawing.Point(17, 65);
            this.btn_ClearOriginCache.Name = "btn_ClearOriginCache";
            this.btn_ClearOriginCache.Size = new System.Drawing.Size(160, 60);
            this.btn_ClearOriginCache.TabIndex = 1;
            this.btn_ClearOriginCache.Text = "Clean Origin Cache";
            this.btn_ClearOriginCache.UseVisualStyleBackColor = false;
            this.btn_ClearOriginCache.Click += new System.EventHandler(this.btn_ClearOriginCache_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(3, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hit this button to do the magic!";
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.label1);
            this.grpBox.Controls.Add(this.btn_ClearOriginCache);
            this.grpBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.grpBox.Location = new System.Drawing.Point(164, 13);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(200, 131);
            this.grpBox.TabIndex = 3;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Clean Origin Cache";
            // 
            // frm_OriginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(369, 159);
            this.Controls.Add(this.grpBox);
            this.Controls.Add(this.picOrigin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(385, 198);
            this.Name = "frm_OriginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Origin Cache Cleaner";
            ((System.ComponentModel.ISupportInitialize)(this.picOrigin)).EndInit();
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picOrigin;
        private System.Windows.Forms.Button btn_ClearOriginCache;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBox;
    }
}

