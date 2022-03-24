namespace Projet_Ruyaga
{
    partial class AccueilAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccueilAdmin));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonIconMax = new System.Windows.Forms.Button();
            this.buttonRestore = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCloseApp = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.bunifuTextBoxUserName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.buttonUtilisateur = new System.Windows.Forms.Button();
            this.bunifuButtonReportEntreeStock = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButtonSortieStock = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButtonEntreeStock = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButtonAccueil = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panelBody = new System.Windows.Forms.Panel();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.reportViewerGraphSortie = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.buttonIconMax);
            this.panel1.Controls.Add(this.buttonRestore);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonCloseApp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 29);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.eventDeDeplacementEnTeteFormAccueil);
            // 
            // buttonIconMax
            // 
            this.buttonIconMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIconMax.BackgroundImage = global::Projet_Ruyaga.Properties.Resources.square;
            this.buttonIconMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonIconMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIconMax.FlatAppearance.BorderSize = 0;
            this.buttonIconMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonIconMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonIconMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIconMax.Location = new System.Drawing.Point(1230, 3);
            this.buttonIconMax.Name = "buttonIconMax";
            this.buttonIconMax.Size = new System.Drawing.Size(20, 20);
            this.buttonIconMax.TabIndex = 3;
            this.buttonIconMax.UseVisualStyleBackColor = true;
            this.buttonIconMax.Click += new System.EventHandler(this.buttonIconMax_Click);
            // 
            // buttonRestore
            // 
            this.buttonRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRestore.BackgroundImage = global::Projet_Ruyaga.Properties.Resources.squares;
            this.buttonRestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRestore.FlatAppearance.BorderSize = 0;
            this.buttonRestore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonRestore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestore.Location = new System.Drawing.Point(1230, 3);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(20, 20);
            this.buttonRestore.TabIndex = 2;
            this.buttonRestore.UseVisualStyleBackColor = true;
            this.buttonRestore.Visible = false;
            this.buttonRestore.Click += new System.EventHandler(this.buttonRestore_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::Projet_Ruyaga.Properties.Resources.minimize;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1204, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCloseApp
            // 
            this.buttonCloseApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCloseApp.BackgroundImage = global::Projet_Ruyaga.Properties.Resources.cancel_1_2;
            this.buttonCloseApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCloseApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCloseApp.FlatAppearance.BorderSize = 0;
            this.buttonCloseApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonCloseApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseApp.Location = new System.Drawing.Point(1256, 3);
            this.buttonCloseApp.Name = "buttonCloseApp";
            this.buttonCloseApp.Size = new System.Drawing.Size(20, 20);
            this.buttonCloseApp.TabIndex = 0;
            this.buttonCloseApp.UseVisualStyleBackColor = true;
            this.buttonCloseApp.Click += new System.EventHandler(this.buttonCloseApp_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelMenu.Controls.Add(this.bunifuTextBoxUserName);
            this.panelMenu.Controls.Add(this.buttonUtilisateur);
            this.panelMenu.Controls.Add(this.bunifuButtonReportEntreeStock);
            this.panelMenu.Controls.Add(this.bunifuButtonSortieStock);
            this.panelMenu.Controls.Add(this.bunifuButtonEntreeStock);
            this.panelMenu.Controls.Add(this.bunifuButtonAccueil);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 29);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1284, 40);
            this.panelMenu.TabIndex = 1;
            // 
            // bunifuTextBoxUserName
            // 
            this.bunifuTextBoxUserName.AcceptsReturn = false;
            this.bunifuTextBoxUserName.AcceptsTab = false;
            this.bunifuTextBoxUserName.AnimationSpeed = 200;
            this.bunifuTextBoxUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBoxUserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBoxUserName.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTextBoxUserName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBoxUserName.BackgroundImage")));
            this.bunifuTextBoxUserName.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.bunifuTextBoxUserName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuTextBoxUserName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuTextBoxUserName.BorderColorIdle = System.Drawing.Color.Silver;
            this.bunifuTextBoxUserName.BorderRadius = 10;
            this.bunifuTextBoxUserName.BorderThickness = 1;
            this.bunifuTextBoxUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTextBoxUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBoxUserName.DefaultFont = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextBoxUserName.DefaultText = "";
            this.bunifuTextBoxUserName.FillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuTextBoxUserName.ForeColor = System.Drawing.Color.White;
            this.bunifuTextBoxUserName.HideSelection = true;
            this.bunifuTextBoxUserName.IconLeft = global::Projet_Ruyaga.Properties.Resources.apple_touch_icon;
            this.bunifuTextBoxUserName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBoxUserName.IconPadding = 5;
            this.bunifuTextBoxUserName.IconRight = null;
            this.bunifuTextBoxUserName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBoxUserName.Lines = new string[0];
            this.bunifuTextBoxUserName.Location = new System.Drawing.Point(1056, 0);
            this.bunifuTextBoxUserName.MaxLength = 32767;
            this.bunifuTextBoxUserName.MinimumSize = new System.Drawing.Size(1, 1);
            this.bunifuTextBoxUserName.Modified = false;
            this.bunifuTextBoxUserName.Multiline = false;
            this.bunifuTextBoxUserName.Name = "bunifuTextBoxUserName";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBoxUserName.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.bunifuTextBoxUserName.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBoxUserName.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.DodgerBlue;
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBoxUserName.OnIdleState = stateProperties4;
            this.bunifuTextBoxUserName.Padding = new System.Windows.Forms.Padding(3);
            this.bunifuTextBoxUserName.PasswordChar = '\0';
            this.bunifuTextBoxUserName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.bunifuTextBoxUserName.PlaceholderText = "";
            this.bunifuTextBoxUserName.ReadOnly = true;
            this.bunifuTextBoxUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bunifuTextBoxUserName.SelectedText = "";
            this.bunifuTextBoxUserName.SelectionLength = 0;
            this.bunifuTextBoxUserName.SelectionStart = 0;
            this.bunifuTextBoxUserName.ShortcutsEnabled = true;
            this.bunifuTextBoxUserName.Size = new System.Drawing.Size(208, 38);
            this.bunifuTextBoxUserName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.bunifuTextBoxUserName.TabIndex = 26;
            this.bunifuTextBoxUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBoxUserName.TextMarginBottom = 0;
            this.bunifuTextBoxUserName.TextMarginLeft = 3;
            this.bunifuTextBoxUserName.TextMarginTop = 0;
            this.bunifuTextBoxUserName.TextPlaceholder = "";
            this.bunifuTextBoxUserName.UseSystemPasswordChar = false;
            this.bunifuTextBoxUserName.WordWrap = true;
            // 
            // buttonUtilisateur
            // 
            this.buttonUtilisateur.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonUtilisateur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUtilisateur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUtilisateur.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonUtilisateur.FlatAppearance.BorderSize = 0;
            this.buttonUtilisateur.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonUtilisateur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonUtilisateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUtilisateur.Image = global::Projet_Ruyaga.Properties.Resources.perso;
            this.buttonUtilisateur.Location = new System.Drawing.Point(1009, 2);
            this.buttonUtilisateur.Name = "buttonUtilisateur";
            this.buttonUtilisateur.Size = new System.Drawing.Size(41, 36);
            this.buttonUtilisateur.TabIndex = 14;
            this.buttonUtilisateur.UseVisualStyleBackColor = false;
            this.buttonUtilisateur.Click += new System.EventHandler(this.buttonUtilisateur_Click);
            // 
            // bunifuButtonReportEntreeStock
            // 
            this.bunifuButtonReportEntreeStock.AllowAnimations = true;
            this.bunifuButtonReportEntreeStock.AllowMouseEffects = true;
            this.bunifuButtonReportEntreeStock.AllowToggling = false;
            this.bunifuButtonReportEntreeStock.AnimationSpeed = 200;
            this.bunifuButtonReportEntreeStock.AutoGenerateColors = false;
            this.bunifuButtonReportEntreeStock.AutoRoundBorders = false;
            this.bunifuButtonReportEntreeStock.AutoSizeLeftIcon = true;
            this.bunifuButtonReportEntreeStock.AutoSizeRightIcon = true;
            this.bunifuButtonReportEntreeStock.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButtonReportEntreeStock.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonReportEntreeStock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButtonReportEntreeStock.BackgroundImage")));
            this.bunifuButtonReportEntreeStock.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonReportEntreeStock.ButtonText = "Rapports";
            this.bunifuButtonReportEntreeStock.ButtonTextMarginLeft = 0;
            this.bunifuButtonReportEntreeStock.ColorContrastOnClick = 45;
            this.bunifuButtonReportEntreeStock.ColorContrastOnHover = 45;
            this.bunifuButtonReportEntreeStock.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButtonReportEntreeStock.CustomizableEdges = borderEdges1;
            this.bunifuButtonReportEntreeStock.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButtonReportEntreeStock.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButtonReportEntreeStock.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButtonReportEntreeStock.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButtonReportEntreeStock.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButtonReportEntreeStock.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButtonReportEntreeStock.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonReportEntreeStock.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButtonReportEntreeStock.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButtonReportEntreeStock.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButtonReportEntreeStock.IconMarginLeft = 11;
            this.bunifuButtonReportEntreeStock.IconPadding = 10;
            this.bunifuButtonReportEntreeStock.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButtonReportEntreeStock.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButtonReportEntreeStock.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButtonReportEntreeStock.IconSize = 25;
            this.bunifuButtonReportEntreeStock.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonReportEntreeStock.IdleBorderRadius = 20;
            this.bunifuButtonReportEntreeStock.IdleBorderThickness = 1;
            this.bunifuButtonReportEntreeStock.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonReportEntreeStock.IdleIconLeftImage = null;
            this.bunifuButtonReportEntreeStock.IdleIconRightImage = null;
            this.bunifuButtonReportEntreeStock.IndicateFocus = false;
            this.bunifuButtonReportEntreeStock.Location = new System.Drawing.Point(471, 0);
            this.bunifuButtonReportEntreeStock.Name = "bunifuButtonReportEntreeStock";
            this.bunifuButtonReportEntreeStock.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButtonReportEntreeStock.OnDisabledState.BorderRadius = 20;
            this.bunifuButtonReportEntreeStock.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonReportEntreeStock.OnDisabledState.BorderThickness = 1;
            this.bunifuButtonReportEntreeStock.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButtonReportEntreeStock.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButtonReportEntreeStock.OnDisabledState.IconLeftImage = null;
            this.bunifuButtonReportEntreeStock.OnDisabledState.IconRightImage = null;
            this.bunifuButtonReportEntreeStock.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButtonReportEntreeStock.onHoverState.BorderRadius = 20;
            this.bunifuButtonReportEntreeStock.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonReportEntreeStock.onHoverState.BorderThickness = 1;
            this.bunifuButtonReportEntreeStock.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButtonReportEntreeStock.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonReportEntreeStock.onHoverState.IconLeftImage = null;
            this.bunifuButtonReportEntreeStock.onHoverState.IconRightImage = null;
            this.bunifuButtonReportEntreeStock.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonReportEntreeStock.OnIdleState.BorderRadius = 20;
            this.bunifuButtonReportEntreeStock.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonReportEntreeStock.OnIdleState.BorderThickness = 1;
            this.bunifuButtonReportEntreeStock.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonReportEntreeStock.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonReportEntreeStock.OnIdleState.IconLeftImage = null;
            this.bunifuButtonReportEntreeStock.OnIdleState.IconRightImage = null;
            this.bunifuButtonReportEntreeStock.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButtonReportEntreeStock.OnPressedState.BorderRadius = 20;
            this.bunifuButtonReportEntreeStock.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonReportEntreeStock.OnPressedState.BorderThickness = 1;
            this.bunifuButtonReportEntreeStock.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButtonReportEntreeStock.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonReportEntreeStock.OnPressedState.IconLeftImage = null;
            this.bunifuButtonReportEntreeStock.OnPressedState.IconRightImage = null;
            this.bunifuButtonReportEntreeStock.Size = new System.Drawing.Size(150, 39);
            this.bunifuButtonReportEntreeStock.TabIndex = 11;
            this.bunifuButtonReportEntreeStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButtonReportEntreeStock.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButtonReportEntreeStock.TextMarginLeft = 0;
            this.bunifuButtonReportEntreeStock.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButtonReportEntreeStock.UseDefaultRadiusAndThickness = true;
            this.bunifuButtonReportEntreeStock.Click += new System.EventHandler(this.bunifuButtonReportEntreeStock_Click);
            // 
            // bunifuButtonSortieStock
            // 
            this.bunifuButtonSortieStock.AllowAnimations = true;
            this.bunifuButtonSortieStock.AllowMouseEffects = true;
            this.bunifuButtonSortieStock.AllowToggling = false;
            this.bunifuButtonSortieStock.AnimationSpeed = 200;
            this.bunifuButtonSortieStock.AutoGenerateColors = false;
            this.bunifuButtonSortieStock.AutoRoundBorders = false;
            this.bunifuButtonSortieStock.AutoSizeLeftIcon = true;
            this.bunifuButtonSortieStock.AutoSizeRightIcon = true;
            this.bunifuButtonSortieStock.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButtonSortieStock.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonSortieStock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButtonSortieStock.BackgroundImage")));
            this.bunifuButtonSortieStock.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonSortieStock.ButtonText = "Sorties Stock";
            this.bunifuButtonSortieStock.ButtonTextMarginLeft = 0;
            this.bunifuButtonSortieStock.ColorContrastOnClick = 45;
            this.bunifuButtonSortieStock.ColorContrastOnHover = 45;
            this.bunifuButtonSortieStock.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.bunifuButtonSortieStock.CustomizableEdges = borderEdges2;
            this.bunifuButtonSortieStock.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButtonSortieStock.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButtonSortieStock.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButtonSortieStock.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButtonSortieStock.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButtonSortieStock.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButtonSortieStock.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonSortieStock.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButtonSortieStock.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButtonSortieStock.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButtonSortieStock.IconMarginLeft = 11;
            this.bunifuButtonSortieStock.IconPadding = 10;
            this.bunifuButtonSortieStock.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButtonSortieStock.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButtonSortieStock.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButtonSortieStock.IconSize = 25;
            this.bunifuButtonSortieStock.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonSortieStock.IdleBorderRadius = 20;
            this.bunifuButtonSortieStock.IdleBorderThickness = 1;
            this.bunifuButtonSortieStock.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonSortieStock.IdleIconLeftImage = null;
            this.bunifuButtonSortieStock.IdleIconRightImage = null;
            this.bunifuButtonSortieStock.IndicateFocus = false;
            this.bunifuButtonSortieStock.Location = new System.Drawing.Point(316, 1);
            this.bunifuButtonSortieStock.Name = "bunifuButtonSortieStock";
            this.bunifuButtonSortieStock.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButtonSortieStock.OnDisabledState.BorderRadius = 20;
            this.bunifuButtonSortieStock.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonSortieStock.OnDisabledState.BorderThickness = 1;
            this.bunifuButtonSortieStock.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButtonSortieStock.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButtonSortieStock.OnDisabledState.IconLeftImage = null;
            this.bunifuButtonSortieStock.OnDisabledState.IconRightImage = null;
            this.bunifuButtonSortieStock.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButtonSortieStock.onHoverState.BorderRadius = 20;
            this.bunifuButtonSortieStock.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonSortieStock.onHoverState.BorderThickness = 1;
            this.bunifuButtonSortieStock.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButtonSortieStock.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonSortieStock.onHoverState.IconLeftImage = null;
            this.bunifuButtonSortieStock.onHoverState.IconRightImage = null;
            this.bunifuButtonSortieStock.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonSortieStock.OnIdleState.BorderRadius = 20;
            this.bunifuButtonSortieStock.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonSortieStock.OnIdleState.BorderThickness = 1;
            this.bunifuButtonSortieStock.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonSortieStock.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonSortieStock.OnIdleState.IconLeftImage = null;
            this.bunifuButtonSortieStock.OnIdleState.IconRightImage = null;
            this.bunifuButtonSortieStock.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButtonSortieStock.OnPressedState.BorderRadius = 20;
            this.bunifuButtonSortieStock.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonSortieStock.OnPressedState.BorderThickness = 1;
            this.bunifuButtonSortieStock.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButtonSortieStock.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonSortieStock.OnPressedState.IconLeftImage = null;
            this.bunifuButtonSortieStock.OnPressedState.IconRightImage = null;
            this.bunifuButtonSortieStock.Size = new System.Drawing.Size(150, 39);
            this.bunifuButtonSortieStock.TabIndex = 10;
            this.bunifuButtonSortieStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButtonSortieStock.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButtonSortieStock.TextMarginLeft = 0;
            this.bunifuButtonSortieStock.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButtonSortieStock.UseDefaultRadiusAndThickness = true;
            this.bunifuButtonSortieStock.Click += new System.EventHandler(this.bunifuButton2_Click);
            // 
            // bunifuButtonEntreeStock
            // 
            this.bunifuButtonEntreeStock.AllowAnimations = true;
            this.bunifuButtonEntreeStock.AllowMouseEffects = true;
            this.bunifuButtonEntreeStock.AllowToggling = false;
            this.bunifuButtonEntreeStock.AnimationSpeed = 200;
            this.bunifuButtonEntreeStock.AutoGenerateColors = false;
            this.bunifuButtonEntreeStock.AutoRoundBorders = false;
            this.bunifuButtonEntreeStock.AutoSizeLeftIcon = true;
            this.bunifuButtonEntreeStock.AutoSizeRightIcon = true;
            this.bunifuButtonEntreeStock.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButtonEntreeStock.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonEntreeStock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButtonEntreeStock.BackgroundImage")));
            this.bunifuButtonEntreeStock.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonEntreeStock.ButtonText = "Entrées Stock";
            this.bunifuButtonEntreeStock.ButtonTextMarginLeft = 0;
            this.bunifuButtonEntreeStock.ColorContrastOnClick = 45;
            this.bunifuButtonEntreeStock.ColorContrastOnHover = 45;
            this.bunifuButtonEntreeStock.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.bunifuButtonEntreeStock.CustomizableEdges = borderEdges3;
            this.bunifuButtonEntreeStock.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButtonEntreeStock.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButtonEntreeStock.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButtonEntreeStock.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButtonEntreeStock.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButtonEntreeStock.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButtonEntreeStock.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonEntreeStock.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButtonEntreeStock.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButtonEntreeStock.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButtonEntreeStock.IconMarginLeft = 11;
            this.bunifuButtonEntreeStock.IconPadding = 10;
            this.bunifuButtonEntreeStock.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButtonEntreeStock.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButtonEntreeStock.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButtonEntreeStock.IconSize = 25;
            this.bunifuButtonEntreeStock.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonEntreeStock.IdleBorderRadius = 20;
            this.bunifuButtonEntreeStock.IdleBorderThickness = 1;
            this.bunifuButtonEntreeStock.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonEntreeStock.IdleIconLeftImage = null;
            this.bunifuButtonEntreeStock.IdleIconRightImage = null;
            this.bunifuButtonEntreeStock.IndicateFocus = false;
            this.bunifuButtonEntreeStock.Location = new System.Drawing.Point(160, 0);
            this.bunifuButtonEntreeStock.Name = "bunifuButtonEntreeStock";
            this.bunifuButtonEntreeStock.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButtonEntreeStock.OnDisabledState.BorderRadius = 20;
            this.bunifuButtonEntreeStock.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonEntreeStock.OnDisabledState.BorderThickness = 1;
            this.bunifuButtonEntreeStock.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButtonEntreeStock.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButtonEntreeStock.OnDisabledState.IconLeftImage = null;
            this.bunifuButtonEntreeStock.OnDisabledState.IconRightImage = null;
            this.bunifuButtonEntreeStock.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButtonEntreeStock.onHoverState.BorderRadius = 20;
            this.bunifuButtonEntreeStock.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonEntreeStock.onHoverState.BorderThickness = 1;
            this.bunifuButtonEntreeStock.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButtonEntreeStock.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonEntreeStock.onHoverState.IconLeftImage = null;
            this.bunifuButtonEntreeStock.onHoverState.IconRightImage = null;
            this.bunifuButtonEntreeStock.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonEntreeStock.OnIdleState.BorderRadius = 20;
            this.bunifuButtonEntreeStock.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonEntreeStock.OnIdleState.BorderThickness = 1;
            this.bunifuButtonEntreeStock.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonEntreeStock.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonEntreeStock.OnIdleState.IconLeftImage = null;
            this.bunifuButtonEntreeStock.OnIdleState.IconRightImage = null;
            this.bunifuButtonEntreeStock.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButtonEntreeStock.OnPressedState.BorderRadius = 20;
            this.bunifuButtonEntreeStock.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonEntreeStock.OnPressedState.BorderThickness = 1;
            this.bunifuButtonEntreeStock.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButtonEntreeStock.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonEntreeStock.OnPressedState.IconLeftImage = null;
            this.bunifuButtonEntreeStock.OnPressedState.IconRightImage = null;
            this.bunifuButtonEntreeStock.Size = new System.Drawing.Size(150, 39);
            this.bunifuButtonEntreeStock.TabIndex = 9;
            this.bunifuButtonEntreeStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButtonEntreeStock.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButtonEntreeStock.TextMarginLeft = 0;
            this.bunifuButtonEntreeStock.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButtonEntreeStock.UseDefaultRadiusAndThickness = true;
            this.bunifuButtonEntreeStock.Click += new System.EventHandler(this.bunifuButtonStock_Click);
            // 
            // bunifuButtonAccueil
            // 
            this.bunifuButtonAccueil.AllowAnimations = true;
            this.bunifuButtonAccueil.AllowMouseEffects = true;
            this.bunifuButtonAccueil.AllowToggling = false;
            this.bunifuButtonAccueil.AnimationSpeed = 200;
            this.bunifuButtonAccueil.AutoGenerateColors = false;
            this.bunifuButtonAccueil.AutoRoundBorders = false;
            this.bunifuButtonAccueil.AutoSizeLeftIcon = true;
            this.bunifuButtonAccueil.AutoSizeRightIcon = true;
            this.bunifuButtonAccueil.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButtonAccueil.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonAccueil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButtonAccueil.BackgroundImage")));
            this.bunifuButtonAccueil.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonAccueil.ButtonText = "Accueil";
            this.bunifuButtonAccueil.ButtonTextMarginLeft = 0;
            this.bunifuButtonAccueil.ColorContrastOnClick = 45;
            this.bunifuButtonAccueil.ColorContrastOnHover = 45;
            this.bunifuButtonAccueil.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.bunifuButtonAccueil.CustomizableEdges = borderEdges4;
            this.bunifuButtonAccueil.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButtonAccueil.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButtonAccueil.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButtonAccueil.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButtonAccueil.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButtonAccueil.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButtonAccueil.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonAccueil.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButtonAccueil.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButtonAccueil.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButtonAccueil.IconMarginLeft = 11;
            this.bunifuButtonAccueil.IconPadding = 5;
            this.bunifuButtonAccueil.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButtonAccueil.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButtonAccueil.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButtonAccueil.IconSize = 25;
            this.bunifuButtonAccueil.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonAccueil.IdleBorderRadius = 20;
            this.bunifuButtonAccueil.IdleBorderThickness = 1;
            this.bunifuButtonAccueil.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonAccueil.IdleIconLeftImage = global::Projet_Ruyaga.Properties.Resources.home_icon_silhouette;
            this.bunifuButtonAccueil.IdleIconRightImage = null;
            this.bunifuButtonAccueil.IndicateFocus = false;
            this.bunifuButtonAccueil.Location = new System.Drawing.Point(3, 1);
            this.bunifuButtonAccueil.Name = "bunifuButtonAccueil";
            this.bunifuButtonAccueil.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButtonAccueil.OnDisabledState.BorderRadius = 20;
            this.bunifuButtonAccueil.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonAccueil.OnDisabledState.BorderThickness = 1;
            this.bunifuButtonAccueil.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButtonAccueil.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButtonAccueil.OnDisabledState.IconLeftImage = null;
            this.bunifuButtonAccueil.OnDisabledState.IconRightImage = null;
            this.bunifuButtonAccueil.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButtonAccueil.onHoverState.BorderRadius = 20;
            this.bunifuButtonAccueil.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonAccueil.onHoverState.BorderThickness = 1;
            this.bunifuButtonAccueil.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButtonAccueil.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonAccueil.onHoverState.IconLeftImage = null;
            this.bunifuButtonAccueil.onHoverState.IconRightImage = null;
            this.bunifuButtonAccueil.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonAccueil.OnIdleState.BorderRadius = 20;
            this.bunifuButtonAccueil.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonAccueil.OnIdleState.BorderThickness = 1;
            this.bunifuButtonAccueil.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonAccueil.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonAccueil.OnIdleState.IconLeftImage = global::Projet_Ruyaga.Properties.Resources.home_icon_silhouette;
            this.bunifuButtonAccueil.OnIdleState.IconRightImage = null;
            this.bunifuButtonAccueil.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButtonAccueil.OnPressedState.BorderRadius = 20;
            this.bunifuButtonAccueil.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonAccueil.OnPressedState.BorderThickness = 1;
            this.bunifuButtonAccueil.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButtonAccueil.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonAccueil.OnPressedState.IconLeftImage = null;
            this.bunifuButtonAccueil.OnPressedState.IconRightImage = null;
            this.bunifuButtonAccueil.Size = new System.Drawing.Size(150, 39);
            this.bunifuButtonAccueil.TabIndex = 8;
            this.bunifuButtonAccueil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButtonAccueil.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButtonAccueil.TextMarginLeft = 0;
            this.bunifuButtonAccueil.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButtonAccueil.UseDefaultRadiusAndThickness = true;
            this.bunifuButtonAccueil.Click += new System.EventHandler(this.bunifuButtonAccueil_Click);
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.bunifuPanel2);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 69);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1284, 592);
            this.panelBody.TabIndex = 2;
            this.panelBody.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBody_Paint);
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 20;
            this.bunifuPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.reportViewerGraphSortie);
            this.bunifuPanel2.Location = new System.Drawing.Point(43, 28);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(1207, 536);
            this.bunifuPanel2.TabIndex = 2;
            // 
            // reportViewerGraphSortie
            // 
            this.reportViewerGraphSortie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewerGraphSortie.LocalReport.ReportEmbeddedResource = "Projet_Ruyaga.ReportGraphStock.rdlc";
            this.reportViewerGraphSortie.Location = new System.Drawing.Point(15, 16);
            this.reportViewerGraphSortie.Name = "reportViewerGraphSortie";
            this.reportViewerGraphSortie.ServerReport.BearerToken = null;
            this.reportViewerGraphSortie.ShowBackButton = false;
            this.reportViewerGraphSortie.ShowFindControls = false;
            this.reportViewerGraphSortie.ShowPageNavigationControls = false;
            this.reportViewerGraphSortie.ShowRefreshButton = false;
            this.reportViewerGraphSortie.ShowStopButton = false;
            this.reportViewerGraphSortie.Size = new System.Drawing.Size(1164, 495);
            this.reportViewerGraphSortie.TabIndex = 24;
            // 
            // AccueilAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccueilAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccueilAdmin";
            this.Load += new System.EventHandler(this.AccueilAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelBody.ResumeLayout(false);
            this.bunifuPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMenu;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButtonAccueil;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButtonReportEntreeStock;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButtonSortieStock;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButtonEntreeStock;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Button buttonCloseApp;
        private System.Windows.Forms.Button buttonIconMax;
        private System.Windows.Forms.Button buttonRestore;
        private System.Windows.Forms.Button button1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerGraphSortie;
        private System.Windows.Forms.Button buttonUtilisateur;
        private Bunifu.UI.WinForms.BunifuTextBox bunifuTextBoxUserName;
    }
}