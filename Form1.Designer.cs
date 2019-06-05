namespace Static_Image_Generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picturebox_result = new System.Windows.Forms.PictureBox();
            this.btn_gen = new System.Windows.Forms.Button();
            this.num_Width = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num_Height = new System.Windows.Forms.NumericUpDown();
            this.btn_save = new System.Windows.Forms.Button();
            this.rand_alpha_check = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Height)).BeginInit();
            this.SuspendLayout();
            // 
            // picturebox_result
            // 
            this.picturebox_result.Location = new System.Drawing.Point(12, 12);
            this.picturebox_result.Name = "picturebox_result";
            this.picturebox_result.Size = new System.Drawing.Size(663, 426);
            this.picturebox_result.TabIndex = 0;
            this.picturebox_result.TabStop = false;
            // 
            // btn_gen
            // 
            this.btn_gen.Font = new System.Drawing.Font("Nachlieli CLM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_gen.Location = new System.Drawing.Point(682, 13);
            this.btn_gen.Name = "btn_gen";
            this.btn_gen.Size = new System.Drawing.Size(106, 48);
            this.btn_gen.TabIndex = 1;
            this.btn_gen.Text = "Generate";
            this.btn_gen.UseVisualStyleBackColor = true;
            this.btn_gen.Click += new System.EventHandler(this.Button1_Click);
            // 
            // num_Width
            // 
            this.num_Width.Location = new System.Drawing.Point(681, 92);
            this.num_Width.Maximum = new decimal(new int[] {
            1385447424,
            931,
            0,
            0});
            this.num_Width.Minimum = new decimal(new int[] {
            320,
            0,
            0,
            0});
            this.num_Width.Name = "num_Width";
            this.num_Width.Size = new System.Drawing.Size(120, 20);
            this.num_Width.TabIndex = 2;
            this.num_Width.Value = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nachlieli CLM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(679, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Height:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nachlieli CLM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(678, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Width:";
            // 
            // num_Height
            // 
            this.num_Height.Location = new System.Drawing.Point(681, 136);
            this.num_Height.Maximum = new decimal(new int[] {
            1385447424,
            931,
            0,
            0});
            this.num_Height.Minimum = new decimal(new int[] {
            320,
            0,
            0,
            0});
            this.num_Height.Name = "num_Height";
            this.num_Height.Size = new System.Drawing.Size(120, 20);
            this.num_Height.TabIndex = 5;
            this.num_Height.Value = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Nachlieli CLM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_save.Location = new System.Drawing.Point(682, 390);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(106, 48);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // rand_alpha_check
            // 
            this.rand_alpha_check.AutoSize = true;
            this.rand_alpha_check.Font = new System.Drawing.Font("Nachlieli CLM", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rand_alpha_check.Location = new System.Drawing.Point(681, 162);
            this.rand_alpha_check.Name = "rand_alpha_check";
            this.rand_alpha_check.Size = new System.Drawing.Size(126, 18);
            this.rand_alpha_check.TabIndex = 7;
            this.rand_alpha_check.Text = "Randomize Alpha";
            this.rand_alpha_check.UseVisualStyleBackColor = true;
            this.rand_alpha_check.CheckedChanged += new System.EventHandler(this.Rand_alpha_check_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rand_alpha_check);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.num_Height);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num_Width);
            this.Controls.Add(this.btn_gen);
            this.Controls.Add(this.picturebox_result);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Static Image Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Height)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picturebox_result;
        private System.Windows.Forms.Button btn_gen;
        private System.Windows.Forms.NumericUpDown num_Width;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_Height;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.CheckBox rand_alpha_check;
    }
}

