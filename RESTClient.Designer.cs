namespace RESTClient
{
    partial class RESTClient
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
            this.DomainTextBox = new System.Windows.Forms.TextBox();
            this.PutRadioButton = new System.Windows.Forms.RadioButton();
            this.PostRadioButton = new System.Windows.Forms.RadioButton();
            this.GetRadioButton = new System.Windows.Forms.RadioButton();
            this.DomainLabel = new System.Windows.Forms.Label();
            this.OutPutLabel = new System.Windows.Forms.Label();
            this.OutPutTextBox = new System.Windows.Forms.TextBox();
            this.RequestGroupBox = new System.Windows.Forms.GroupBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.InputLabel = new System.Windows.Forms.Label();
            this.StatusCodeLabel = new System.Windows.Forms.Label();
            this.StatusCodeLabelActual = new System.Windows.Forms.Label();
            this.RequestGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DomainTextBox
            // 
            this.DomainTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DomainTextBox.Location = new System.Drawing.Point(48, 168);
            this.DomainTextBox.Multiline = true;
            this.DomainTextBox.Name = "DomainTextBox";
            this.DomainTextBox.Size = new System.Drawing.Size(813, 48);
            this.DomainTextBox.TabIndex = 0;
            this.DomainTextBox.Text = "http://localhost:60000/BoggleService.svc/users";
            this.DomainTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEnterEvent);
            // 
            // PutRadioButton
            // 
            this.PutRadioButton.AutoSize = true;
            this.PutRadioButton.Location = new System.Drawing.Point(16, 37);
            this.PutRadioButton.Name = "PutRadioButton";
            this.PutRadioButton.Size = new System.Drawing.Size(96, 33);
            this.PutRadioButton.TabIndex = 1;
            this.PutRadioButton.TabStop = true;
            this.PutRadioButton.Text = "PUT";
            this.PutRadioButton.UseVisualStyleBackColor = true;
            // 
            // PostRadioButton
            // 
            this.PostRadioButton.AutoSize = true;
            this.PostRadioButton.Location = new System.Drawing.Point(127, 37);
            this.PostRadioButton.Name = "PostRadioButton";
            this.PostRadioButton.Size = new System.Drawing.Size(115, 33);
            this.PostRadioButton.TabIndex = 2;
            this.PostRadioButton.TabStop = true;
            this.PostRadioButton.Text = "POST";
            this.PostRadioButton.UseVisualStyleBackColor = true;
            // 
            // GetRadioButton
            // 
            this.GetRadioButton.AutoSize = true;
            this.GetRadioButton.Location = new System.Drawing.Point(248, 37);
            this.GetRadioButton.Name = "GetRadioButton";
            this.GetRadioButton.Size = new System.Drawing.Size(97, 33);
            this.GetRadioButton.TabIndex = 3;
            this.GetRadioButton.TabStop = true;
            this.GetRadioButton.Text = "GET";
            this.GetRadioButton.UseVisualStyleBackColor = true;
            // 
            // DomainLabel
            // 
            this.DomainLabel.AutoSize = true;
            this.DomainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DomainLabel.Location = new System.Drawing.Point(43, 131);
            this.DomainLabel.Name = "DomainLabel";
            this.DomainLabel.Size = new System.Drawing.Size(109, 29);
            this.DomainLabel.TabIndex = 4;
            this.DomainLabel.Text = "Domain:";
            // 
            // OutPutLabel
            // 
            this.OutPutLabel.AutoSize = true;
            this.OutPutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutPutLabel.Location = new System.Drawing.Point(43, 541);
            this.OutPutLabel.Name = "OutPutLabel";
            this.OutPutLabel.Size = new System.Drawing.Size(138, 29);
            this.OutPutLabel.TabIndex = 5;
            this.OutPutLabel.Text = "Response:";
            // 
            // OutPutTextBox
            // 
            this.OutPutTextBox.Location = new System.Drawing.Point(48, 583);
            this.OutPutTextBox.Multiline = true;
            this.OutPutTextBox.Name = "OutPutTextBox";
            this.OutPutTextBox.Size = new System.Drawing.Size(813, 353);
            this.OutPutTextBox.TabIndex = 6;
            // 
            // RequestGroupBox
            // 
            this.RequestGroupBox.Controls.Add(this.GetRadioButton);
            this.RequestGroupBox.Controls.Add(this.PutRadioButton);
            this.RequestGroupBox.Controls.Add(this.PostRadioButton);
            this.RequestGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestGroupBox.Location = new System.Drawing.Point(48, 43);
            this.RequestGroupBox.Name = "RequestGroupBox";
            this.RequestGroupBox.Size = new System.Drawing.Size(813, 85);
            this.RequestGroupBox.TabIndex = 7;
            this.RequestGroupBox.TabStop = false;
            this.RequestGroupBox.Text = "Request Type:";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(48, 479);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(125, 50);
            this.ClearButton.TabIndex = 8;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(198, 479);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(125, 50);
            this.SendButton.TabIndex = 9;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(48, 264);
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(813, 202);
            this.InputTextBox.TabIndex = 10;
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLabel.Location = new System.Drawing.Point(43, 228);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(77, 29);
            this.InputLabel.TabIndex = 11;
            this.InputLabel.Text = "Input:";
            // 
            // StatusCodeLabel
            // 
            this.StatusCodeLabel.AutoSize = true;
            this.StatusCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusCodeLabel.Location = new System.Drawing.Point(279, 545);
            this.StatusCodeLabel.Name = "StatusCodeLabel";
            this.StatusCodeLabel.Size = new System.Drawing.Size(162, 29);
            this.StatusCodeLabel.TabIndex = 12;
            this.StatusCodeLabel.Text = "Status Code:";
            // 
            // StatusCodeLabelActual
            // 
            this.StatusCodeLabelActual.AutoSize = true;
            this.StatusCodeLabelActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusCodeLabelActual.Location = new System.Drawing.Point(447, 545);
            this.StatusCodeLabelActual.Name = "StatusCodeLabelActual";
            this.StatusCodeLabelActual.Size = new System.Drawing.Size(0, 29);
            this.StatusCodeLabelActual.TabIndex = 13;
            // 
            // RESTClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 973);
            this.Controls.Add(this.StatusCodeLabelActual);
            this.Controls.Add(this.StatusCodeLabel);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.RequestGroupBox);
            this.Controls.Add(this.OutPutTextBox);
            this.Controls.Add(this.OutPutLabel);
            this.Controls.Add(this.DomainLabel);
            this.Controls.Add(this.DomainTextBox);
            this.Name = "RESTClient";
            this.Text = "Ryans REST Client";
            this.RequestGroupBox.ResumeLayout(false);
            this.RequestGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DomainTextBox;
        private System.Windows.Forms.RadioButton PutRadioButton;
        private System.Windows.Forms.RadioButton PostRadioButton;
        private System.Windows.Forms.RadioButton GetRadioButton;
        private System.Windows.Forms.Label DomainLabel;
        private System.Windows.Forms.Label OutPutLabel;
        private System.Windows.Forms.TextBox OutPutTextBox;
        private System.Windows.Forms.GroupBox RequestGroupBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Label StatusCodeLabel;
        private System.Windows.Forms.Label StatusCodeLabelActual;
    }
}

