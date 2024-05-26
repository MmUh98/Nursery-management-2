namespace Nursery_management
{
    partial class DistrictsForm1
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
            this.Abbottabad_button = new System.Windows.Forms.Button();
            this.Bajaur_button = new System.Windows.Forms.Button();
            this.ChitralLower_button = new System.Windows.Forms.Button();
            this.Area_and_FNFs_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Abbottabad_button
            // 
            this.Abbottabad_button.Location = new System.Drawing.Point(52, 169);
            this.Abbottabad_button.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Abbottabad_button.Name = "Abbottabad_button";
            this.Abbottabad_button.Size = new System.Drawing.Size(221, 48);
            this.Abbottabad_button.TabIndex = 0;
            this.Abbottabad_button.Text = "Abbottabad";
            this.Abbottabad_button.UseVisualStyleBackColor = true;
            this.Abbottabad_button.Click += new System.EventHandler(this.Abbottabad_button_Click);
            // 
            // Bajaur_button
            // 
            this.Bajaur_button.ForeColor = System.Drawing.Color.Black;
            this.Bajaur_button.Location = new System.Drawing.Point(52, 261);
            this.Bajaur_button.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Bajaur_button.Name = "Bajaur_button";
            this.Bajaur_button.Size = new System.Drawing.Size(221, 48);
            this.Bajaur_button.TabIndex = 1;
            this.Bajaur_button.Text = "Bajaur";
            this.Bajaur_button.UseVisualStyleBackColor = true;
            this.Bajaur_button.Click += new System.EventHandler(this.Bajaur_button_Click);
            // 
            // ChitralLower_button
            // 
            this.ChitralLower_button.ForeColor = System.Drawing.Color.Black;
            this.ChitralLower_button.Location = new System.Drawing.Point(52, 341);
            this.ChitralLower_button.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ChitralLower_button.Name = "ChitralLower_button";
            this.ChitralLower_button.Size = new System.Drawing.Size(221, 48);
            this.ChitralLower_button.TabIndex = 2;
            this.ChitralLower_button.Text = "Chitral Lower\r\n\r\n";
            this.ChitralLower_button.UseVisualStyleBackColor = true;
            this.ChitralLower_button.Click += new System.EventHandler(this.ChitralLower_button_Click);
            // 
            // Area_and_FNFs_button
            // 
            this.Area_and_FNFs_button.Location = new System.Drawing.Point(52, 89);
            this.Area_and_FNFs_button.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Area_and_FNFs_button.Name = "Area_and_FNFs_button";
            this.Area_and_FNFs_button.Size = new System.Drawing.Size(221, 48);
            this.Area_and_FNFs_button.TabIndex = 19;
            this.Area_and_FNFs_button.Text = "Area / FNFs";
            this.Area_and_FNFs_button.UseVisualStyleBackColor = true;
            this.Area_and_FNFs_button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Back_button
            // 
            this.Back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_button.Location = new System.Drawing.Point(127, 440);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(75, 34);
            this.Back_button.TabIndex = 20;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // DistrictsForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nursery_management.Properties.Resources.Agriculture_Reform_Plan_1170x7251;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(356, 486);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Area_and_FNFs_button);
            this.Controls.Add(this.ChitralLower_button);
            this.Controls.Add(this.Bajaur_button);
            this.Controls.Add(this.Abbottabad_button);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "DistrictsForm1";
            this.Text = "Districts";
            this.Load += new System.EventHandler(this.DistrictsForm1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Abbottabad_button;
        private System.Windows.Forms.Button Bajaur_button;
        private System.Windows.Forms.Button ChitralLower_button;
        private System.Windows.Forms.Button Area_and_FNFs_button;
        private System.Windows.Forms.Button Back_button;
    }
}