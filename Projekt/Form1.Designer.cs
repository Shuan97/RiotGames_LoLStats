using System.Windows.Forms;

namespace Projekt
{
    partial class Form
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.SearchText = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.FlexLabel = new System.Windows.Forms.Label();
            this.TTLabel = new System.Windows.Forms.Label();
            this.SoloLabel = new System.Windows.Forms.Label();
            this.PanelTimer = new System.Windows.Forms.Timer(this.components);
            this.Panel = new System.Windows.Forms.Panel();
            this.PanelTimer2 = new System.Windows.Forms.Timer(this.components);
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.PanelButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            this.SoloImage = new System.Windows.Forms.PictureBox();
            this.TTImage = new System.Windows.Forms.PictureBox();
            this.FlexImage = new System.Windows.Forms.PictureBox();
            this.IconBox = new System.Windows.Forms.PictureBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoloImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlexImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchText
            // 
            this.SearchText.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SearchText.Location = new System.Drawing.Point(12, 121);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(250, 37);
            this.SearchText.TabIndex = 0;
            // 
            // ResultLabel
            // 
            this.ResultLabel.BackColor = System.Drawing.Color.Transparent;
            this.ResultLabel.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ResultLabel.Location = new System.Drawing.Point(94, 205);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(410, 35);
            this.ResultLabel.TabIndex = 3;
            // 
            // LevelLabel
            // 
            this.LevelLabel.BackColor = System.Drawing.Color.Transparent;
            this.LevelLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LevelLabel.Location = new System.Drawing.Point(94, 245);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(225, 35);
            this.LevelLabel.TabIndex = 4;
            // 
            // FlexLabel
            // 
            this.FlexLabel.BackColor = System.Drawing.Color.Transparent;
            this.FlexLabel.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FlexLabel.Location = new System.Drawing.Point(4, 435);
            this.FlexLabel.Name = "FlexLabel";
            this.FlexLabel.Size = new System.Drawing.Size(96, 24);
            this.FlexLabel.TabIndex = 8;
            this.FlexLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TTLabel
            // 
            this.TTLabel.BackColor = System.Drawing.Color.Transparent;
            this.TTLabel.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TTLabel.Location = new System.Drawing.Point(212, 435);
            this.TTLabel.Name = "TTLabel";
            this.TTLabel.Size = new System.Drawing.Size(97, 24);
            this.TTLabel.TabIndex = 9;
            this.TTLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SoloLabel
            // 
            this.SoloLabel.BackColor = System.Drawing.Color.Transparent;
            this.SoloLabel.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SoloLabel.Location = new System.Drawing.Point(99, 430);
            this.SoloLabel.Name = "SoloLabel";
            this.SoloLabel.Size = new System.Drawing.Size(114, 29);
            this.SoloLabel.TabIndex = 10;
            this.SoloLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PanelTimer
            // 
            this.PanelTimer.Interval = 5;
            this.PanelTimer.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Panel
            // 
            this.Panel.AutoScroll = true;
            this.Panel.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.Panel.BackColor = System.Drawing.Color.White;
            this.Panel.Location = new System.Drawing.Point(1000, 90);
            this.Panel.Margin = new System.Windows.Forms.Padding(0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(500, 510);
            this.Panel.TabIndex = 11;
            // 
            // PanelTimer2
            // 
            this.PanelTimer2.Interval = 5;
            this.PanelTimer2.Tick += new System.EventHandler(this.PanelTimer2_Tick);
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.MenuPanel.Controls.Add(this.PanelButton);
            this.MenuPanel.Controls.Add(this.ExitButton);
            this.MenuPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MenuPanel.Location = new System.Drawing.Point(0, 60);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(1000, 30);
            this.MenuPanel.TabIndex = 12;
            // 
            // PanelButton
            // 
            this.PanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PanelButton.ForeColor = System.Drawing.Color.White;
            this.PanelButton.Location = new System.Drawing.Point(943, 3);
            this.PanelButton.Name = "PanelButton";
            this.PanelButton.Size = new System.Drawing.Size(24, 24);
            this.PanelButton.TabIndex = 0;
            this.PanelButton.Text = "<";
            this.PanelButton.UseVisualStyleBackColor = true;
            this.PanelButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(973, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(24, 24);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LogoPicture
            // 
            this.LogoPicture.BackColor = System.Drawing.Color.Transparent;
            this.LogoPicture.Image = global::Projekt.Properties.Resources.logo;
            this.LogoPicture.Location = new System.Drawing.Point(12, 12);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Size = new System.Drawing.Size(100, 100);
            this.LogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPicture.TabIndex = 13;
            this.LogoPicture.TabStop = false;
            // 
            // SoloImage
            // 
            this.SoloImage.BackColor = System.Drawing.Color.Transparent;
            this.SoloImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SoloImage.Location = new System.Drawing.Point(106, 327);
            this.SoloImage.Name = "SoloImage";
            this.SoloImage.Size = new System.Drawing.Size(100, 100);
            this.SoloImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SoloImage.TabIndex = 7;
            this.SoloImage.TabStop = false;
            // 
            // TTImage
            // 
            this.TTImage.BackColor = System.Drawing.Color.Transparent;
            this.TTImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TTImage.Location = new System.Drawing.Point(219, 352);
            this.TTImage.Name = "TTImage";
            this.TTImage.Size = new System.Drawing.Size(80, 80);
            this.TTImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TTImage.TabIndex = 6;
            this.TTImage.TabStop = false;
            // 
            // FlexImage
            // 
            this.FlexImage.BackColor = System.Drawing.Color.Transparent;
            this.FlexImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FlexImage.Location = new System.Drawing.Point(13, 352);
            this.FlexImage.Name = "FlexImage";
            this.FlexImage.Size = new System.Drawing.Size(80, 80);
            this.FlexImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FlexImage.TabIndex = 5;
            this.FlexImage.TabStop = false;
            // 
            // IconBox
            // 
            this.IconBox.BackColor = System.Drawing.Color.Transparent;
            this.IconBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IconBox.Location = new System.Drawing.Point(13, 205);
            this.IconBox.Name = "IconBox";
            this.IconBox.Size = new System.Drawing.Size(75, 75);
            this.IconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconBox.TabIndex = 2;
            this.IconBox.TabStop = false;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Transparent;
            this.SearchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchButton.BackgroundImage")));
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Location = new System.Drawing.Point(269, 121);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(50, 50);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // Form
            // 
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.LogoPicture);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.SoloLabel);
            this.Controls.Add(this.TTLabel);
            this.Controls.Add(this.FlexLabel);
            this.Controls.Add(this.SoloImage);
            this.Controls.Add(this.TTImage);
            this.Controls.Add(this.FlexImage);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.IconBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoloImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlexImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox SearchText;
        private Button SearchButton;
        private PictureBox IconBox;
        private Label ResultLabel;
        private Label LevelLabel;
        private PictureBox FlexImage;
        private PictureBox TTImage;
        private PictureBox SoloImage;
        private Label FlexLabel;
        private Label TTLabel;
        private Label SoloLabel;
        private Timer PanelTimer;
        private Panel Panel;
        private Timer PanelTimer2;
        private Panel MenuPanel;
        private Button PanelButton;
        private Button ExitButton;
        private PictureBox LogoPicture;
    }
}

