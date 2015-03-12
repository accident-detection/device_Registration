namespace device_Registration.DeviceManager
{
    partial class AddDevice
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
            this.label1 = new System.Windows.Forms.Label();
            this.deviceName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deviceAPI = new System.Windows.Forms.TextBox();
            this.deviceActive = new System.Windows.Forms.CheckBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Device name:";
            // 
            // deviceName
            // 
            this.deviceName.Location = new System.Drawing.Point(92, 10);
            this.deviceName.Name = "deviceName";
            this.deviceName.Size = new System.Drawing.Size(300, 20);
            this.deviceName.TabIndex = 1;
            this.deviceName.TextChanged += new System.EventHandler(this.deviceName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "API key:";
            // 
            // deviceAPI
            // 
            this.deviceAPI.Enabled = false;
            this.deviceAPI.Location = new System.Drawing.Point(92, 36);
            this.deviceAPI.Name = "deviceAPI";
            this.deviceAPI.Size = new System.Drawing.Size(300, 20);
            this.deviceAPI.TabIndex = 3;
            // 
            // deviceActive
            // 
            this.deviceActive.AutoSize = true;
            this.deviceActive.Location = new System.Drawing.Point(92, 63);
            this.deviceActive.Name = "deviceActive";
            this.deviceActive.Size = new System.Drawing.Size(100, 17);
            this.deviceActive.TabIndex = 4;
            this.deviceActive.Text = "Activate device";
            this.deviceActive.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(317, 63);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(236, 63);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // AddDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 93);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.deviceActive);
            this.Controls.Add(this.deviceAPI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deviceName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDevice";
            this.Text = "Add device";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox deviceName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox deviceAPI;
        private System.Windows.Forms.CheckBox deviceActive;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
    }
}