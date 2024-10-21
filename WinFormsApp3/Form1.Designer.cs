namespace WinFormsApp3
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
            materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            label1 = new Label();
            materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            richTextBox1 = new RichTextBox();
            materialButton6 = new MaterialSkin.Controls.MaterialButton();
            materialButton5 = new MaterialSkin.Controls.MaterialButton();
            materialButton4 = new MaterialSkin.Controls.MaterialButton();
            materialButton3 = new MaterialSkin.Controls.MaterialButton();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            tabPage2 = new TabPage();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            tabPage3 = new TabPage();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabSelector1
            // 
            materialTabSelector1.BaseTabControl = materialTabControl1;
            materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            materialTabSelector1.Depth = 0;
            materialTabSelector1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTabSelector1.Location = new Point(0, 60);
            materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabSelector1.Name = "materialTabSelector1";
            materialTabSelector1.Size = new Size(705, 30);
            materialTabSelector1.TabIndex = 0;
            materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPage1);
            materialTabControl1.Controls.Add(tabPage2);
            materialTabControl1.Controls.Add(tabPage3);
            materialTabControl1.Depth = 0;
            materialTabControl1.Location = new Point(6, 96);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(693, 463);
            materialTabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(materialCheckbox1);
            tabPage1.Controls.Add(materialLabel1);
            tabPage1.Controls.Add(richTextBox1);
            tabPage1.Controls.Add(materialButton6);
            tabPage1.Controls.Add(materialButton5);
            tabPage1.Controls.Add(materialButton4);
            tabPage1.Controls.Add(materialButton3);
            tabPage1.Controls.Add(materialButton2);
            tabPage1.Controls.Add(materialButton1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(685, 435);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "EXECUTION";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(520, 334);
            label1.Name = "label1";
            label1.Size = new Size(65, 17);
            label1.TabIndex = 12;
            label1.Text = "OFFLINE";
            // 
            // materialCheckbox1
            // 
            materialCheckbox1.AutoSize = true;
            materialCheckbox1.Depth = 0;
            materialCheckbox1.Location = new Point(576, 6);
            materialCheckbox1.Margin = new Padding(0);
            materialCheckbox1.MouseLocation = new Point(-1, -1);
            materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCheckbox1.Name = "materialCheckbox1";
            materialCheckbox1.ReadOnly = false;
            materialCheckbox1.Ripple = true;
            materialCheckbox1.Size = new Size(103, 37);
            materialCheckbox1.TabIndex = 11;
            materialCheckbox1.Text = "Top Most";
            materialCheckbox1.UseVisualStyleBackColor = true;
            materialCheckbox1.CheckedChanged += materialCheckbox1_CheckedChanged;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.ForeColor = Color.CornflowerBlue;
            materialLabel1.Location = new Point(463, 332);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(51, 19);
            materialLabel1.TabIndex = 9;
            materialLabel1.Text = "Status:";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.White;
            richTextBox1.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBox1.Location = new Point(7, 45);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(672, 275);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "print(\"swimhub\")";
            richTextBox1.WordWrap = false;
            // 
            // materialButton6
            // 
            materialButton6.AutoSize = false;
            materialButton6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton6.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton6.Depth = 0;
            materialButton6.HighEmphasis = true;
            materialButton6.Icon = null;
            materialButton6.Location = new Point(213, 329);
            materialButton6.Margin = new Padding(4, 6, 4, 6);
            materialButton6.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton6.Name = "materialButton6";
            materialButton6.NoAccentTextColor = Color.Empty;
            materialButton6.Size = new Size(95, 30);
            materialButton6.TabIndex = 7;
            materialButton6.Text = "SAVE FILE";
            materialButton6.TextAlign = ContentAlignment.TopCenter;
            materialButton6.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton6.UseAccentColor = false;
            materialButton6.UseVisualStyleBackColor = true;
            materialButton6.Click += materialButton6_Click;
            // 
            // materialButton5
            // 
            materialButton5.AutoSize = false;
            materialButton5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton5.Depth = 0;
            materialButton5.HighEmphasis = true;
            materialButton5.Icon = null;
            materialButton5.Location = new Point(316, 329);
            materialButton5.Margin = new Padding(4, 6, 4, 6);
            materialButton5.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton5.Name = "materialButton5";
            materialButton5.NoAccentTextColor = Color.Empty;
            materialButton5.Size = new Size(95, 30);
            materialButton5.TabIndex = 6;
            materialButton5.Text = "LOAD FILE";
            materialButton5.TextAlign = ContentAlignment.TopCenter;
            materialButton5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton5.UseAccentColor = false;
            materialButton5.UseVisualStyleBackColor = true;
            materialButton5.Click += materialButton5_Click;
            // 
            // materialButton4
            // 
            materialButton4.AutoSize = false;
            materialButton4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton4.Depth = 0;
            materialButton4.HighEmphasis = true;
            materialButton4.Icon = null;
            materialButton4.Location = new Point(110, 329);
            materialButton4.Margin = new Padding(4, 6, 4, 6);
            materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton4.Name = "materialButton4";
            materialButton4.NoAccentTextColor = Color.Empty;
            materialButton4.Size = new Size(95, 30);
            materialButton4.TabIndex = 5;
            materialButton4.Text = "CLEAR";
            materialButton4.TextAlign = ContentAlignment.TopCenter;
            materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton4.UseAccentColor = false;
            materialButton4.UseVisualStyleBackColor = true;
            materialButton4.Click += materialButton4_Click;
            // 
            // materialButton3
            // 
            materialButton3.AutoSize = false;
            materialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton3.Depth = 0;
            materialButton3.HighEmphasis = true;
            materialButton3.Icon = null;
            materialButton3.Location = new Point(7, 329);
            materialButton3.Margin = new Padding(4, 6, 4, 6);
            materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton3.Name = "materialButton3";
            materialButton3.NoAccentTextColor = Color.Empty;
            materialButton3.Size = new Size(95, 30);
            materialButton3.TabIndex = 3;
            materialButton3.Text = "EXECUTE";
            materialButton3.TextAlign = ContentAlignment.TopCenter;
            materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton3.UseAccentColor = false;
            materialButton3.UseVisualStyleBackColor = true;
            materialButton3.Click += materialButton3_Click;
            // 
            // materialButton2
            // 
            materialButton2.AutoSize = false;
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(144, 6);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(271, 30);
            materialButton2.TabIndex = 1;
            materialButton2.Text = "SW1MH7B FR33 (trident survival)";
            materialButton2.TextAlign = ContentAlignment.TopCenter;
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            materialButton2.Click += materialButton2_Click;
            // 
            // materialButton1
            // 
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(7, 6);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(129, 30);
            materialButton1.TabIndex = 0;
            materialButton1.Text = "ATTACH";
            materialButton1.TextAlign = ContentAlignment.TopCenter;
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(materialLabel3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(685, 435);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "THEMES";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(236, 107);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(82, 19);
            materialLabel3.TabIndex = 0;
            materialLabel3.Text = "KYS NIGGA";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(materialLabel6);
            tabPage3.Controls.Add(materialLabel5);
            tabPage3.Controls.Add(materialLabel4);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(685, 435);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "CREDITS";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(3, 38);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(252, 19);
            materialLabel6.TabIndex = 2;
            materialLabel6.Text = "original stella owner -> (lost in time)";
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(3, 19);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(109, 19);
            materialLabel5.TabIndex = 1;
            materialLabel5.Text = "UI -> swimdroid";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(3, 0);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(233, 19);
            materialLabel4.TabIndex = 0;
            materialLabel4.Text = "Synapse Z API -> GRH and Draco";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 565);
            Controls.Add(materialTabControl1);
            Controls.Add(materialTabSelector1);
            MaximizeBox = false;
            Name = "Form1";
            Sizable = false;
            Text = "Stella BETA";
            Load += Form1_Load;
            materialTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton6;
        private MaterialSkin.Controls.MaterialButton materialButton5;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private RichTextBox richTextBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private TabPage tabPage3;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private Label label1;
    }
}
