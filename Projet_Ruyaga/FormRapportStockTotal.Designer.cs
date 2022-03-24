namespace Projet_Ruyaga
{
    partial class FormRapportStockTotal
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRapportStockTotal));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.DataTableStockTotalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetStockTotal = new Projet_Ruyaga.DataSetStockTotal();
            this.reportViewerStock = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bunifuButtonInventaireParProduit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuTextBoxA = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuTextBoxDe = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuButtonNettoyage = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButtonInventaire = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuDropdownProduit = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableStockTotalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetStockTotal)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataTableStockTotalBindingSource
            // 
            this.DataTableStockTotalBindingSource.DataMember = "DataTableStockTotal";
            this.DataTableStockTotalBindingSource.DataSource = this.DataSetStockTotal;
            // 
            // DataSetStockTotal
            // 
            this.DataSetStockTotal.DataSetName = "DataSetStockTotal";
            this.DataSetStockTotal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewerStock
            // 
            reportDataSource1.Name = "DataSetStoctTotal";
            reportDataSource1.Value = this.DataTableStockTotalBindingSource;
            this.reportViewerStock.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerStock.LocalReport.ReportEmbeddedResource = "Projet_Ruyaga.ReportStockTotal.rdlc";
            this.reportViewerStock.Location = new System.Drawing.Point(95, 12);
            this.reportViewerStock.Name = "reportViewerStock";
            this.reportViewerStock.ServerReport.BearerToken = null;
            this.reportViewerStock.Size = new System.Drawing.Size(660, 502);
            this.reportViewerStock.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.bunifuButtonInventaireParProduit);
            this.groupBox2.Controls.Add(this.bunifuTextBoxA);
            this.groupBox2.Controls.Add(this.bunifuTextBoxDe);
            this.groupBox2.Controls.Add(this.bunifuButtonNettoyage);
            this.groupBox2.Controls.Add(this.bunifuButtonInventaire);
            this.groupBox2.Controls.Add(this.bunifuDropdownProduit);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(885, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 478);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // bunifuButtonInventaireParProduit
            // 
            this.bunifuButtonInventaireParProduit.AllowAnimations = true;
            this.bunifuButtonInventaireParProduit.AllowMouseEffects = true;
            this.bunifuButtonInventaireParProduit.AllowToggling = false;
            this.bunifuButtonInventaireParProduit.AnimationSpeed = 200;
            this.bunifuButtonInventaireParProduit.AutoGenerateColors = false;
            this.bunifuButtonInventaireParProduit.AutoRoundBorders = false;
            this.bunifuButtonInventaireParProduit.AutoSizeLeftIcon = true;
            this.bunifuButtonInventaireParProduit.AutoSizeRightIcon = true;
            this.bunifuButtonInventaireParProduit.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButtonInventaireParProduit.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonInventaireParProduit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButtonInventaireParProduit.BackgroundImage")));
            this.bunifuButtonInventaireParProduit.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonInventaireParProduit.ButtonText = "Rapport";
            this.bunifuButtonInventaireParProduit.ButtonTextMarginLeft = 0;
            this.bunifuButtonInventaireParProduit.ColorContrastOnClick = 45;
            this.bunifuButtonInventaireParProduit.ColorContrastOnHover = 45;
            this.bunifuButtonInventaireParProduit.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButtonInventaireParProduit.CustomizableEdges = borderEdges1;
            this.bunifuButtonInventaireParProduit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButtonInventaireParProduit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButtonInventaireParProduit.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButtonInventaireParProduit.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButtonInventaireParProduit.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButtonInventaireParProduit.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButtonInventaireParProduit.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonInventaireParProduit.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButtonInventaireParProduit.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButtonInventaireParProduit.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButtonInventaireParProduit.IconMarginLeft = 11;
            this.bunifuButtonInventaireParProduit.IconPadding = 5;
            this.bunifuButtonInventaireParProduit.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButtonInventaireParProduit.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButtonInventaireParProduit.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButtonInventaireParProduit.IconSize = 25;
            this.bunifuButtonInventaireParProduit.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonInventaireParProduit.IdleBorderRadius = 20;
            this.bunifuButtonInventaireParProduit.IdleBorderThickness = 1;
            this.bunifuButtonInventaireParProduit.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonInventaireParProduit.IdleIconLeftImage = global::Projet_Ruyaga.Properties.Resources.inventory;
            this.bunifuButtonInventaireParProduit.IdleIconRightImage = null;
            this.bunifuButtonInventaireParProduit.IndicateFocus = false;
            this.bunifuButtonInventaireParProduit.Location = new System.Drawing.Point(94, 290);
            this.bunifuButtonInventaireParProduit.Name = "bunifuButtonInventaireParProduit";
            this.bunifuButtonInventaireParProduit.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButtonInventaireParProduit.OnDisabledState.BorderRadius = 20;
            this.bunifuButtonInventaireParProduit.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonInventaireParProduit.OnDisabledState.BorderThickness = 1;
            this.bunifuButtonInventaireParProduit.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButtonInventaireParProduit.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButtonInventaireParProduit.OnDisabledState.IconLeftImage = null;
            this.bunifuButtonInventaireParProduit.OnDisabledState.IconRightImage = null;
            this.bunifuButtonInventaireParProduit.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButtonInventaireParProduit.onHoverState.BorderRadius = 20;
            this.bunifuButtonInventaireParProduit.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonInventaireParProduit.onHoverState.BorderThickness = 1;
            this.bunifuButtonInventaireParProduit.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButtonInventaireParProduit.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonInventaireParProduit.onHoverState.IconLeftImage = null;
            this.bunifuButtonInventaireParProduit.onHoverState.IconRightImage = null;
            this.bunifuButtonInventaireParProduit.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonInventaireParProduit.OnIdleState.BorderRadius = 20;
            this.bunifuButtonInventaireParProduit.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonInventaireParProduit.OnIdleState.BorderThickness = 1;
            this.bunifuButtonInventaireParProduit.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonInventaireParProduit.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonInventaireParProduit.OnIdleState.IconLeftImage = global::Projet_Ruyaga.Properties.Resources.inventory;
            this.bunifuButtonInventaireParProduit.OnIdleState.IconRightImage = null;
            this.bunifuButtonInventaireParProduit.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButtonInventaireParProduit.OnPressedState.BorderRadius = 20;
            this.bunifuButtonInventaireParProduit.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonInventaireParProduit.OnPressedState.BorderThickness = 1;
            this.bunifuButtonInventaireParProduit.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButtonInventaireParProduit.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonInventaireParProduit.OnPressedState.IconLeftImage = null;
            this.bunifuButtonInventaireParProduit.OnPressedState.IconRightImage = null;
            this.bunifuButtonInventaireParProduit.Size = new System.Drawing.Size(150, 39);
            this.bunifuButtonInventaireParProduit.TabIndex = 46;
            this.bunifuButtonInventaireParProduit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButtonInventaireParProduit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButtonInventaireParProduit.TextMarginLeft = 0;
            this.bunifuButtonInventaireParProduit.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButtonInventaireParProduit.UseDefaultRadiusAndThickness = true;
            this.bunifuButtonInventaireParProduit.Click += new System.EventHandler(this.bunifuButtonInventaireParProduit_Click);
            // 
            // bunifuTextBoxA
            // 
            this.bunifuTextBoxA.AcceptsReturn = false;
            this.bunifuTextBoxA.AcceptsTab = false;
            this.bunifuTextBoxA.AnimationSpeed = 200;
            this.bunifuTextBoxA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBoxA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBoxA.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTextBoxA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBoxA.BackgroundImage")));
            this.bunifuTextBoxA.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.bunifuTextBoxA.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuTextBoxA.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuTextBoxA.BorderColorIdle = System.Drawing.Color.Silver;
            this.bunifuTextBoxA.BorderRadius = 15;
            this.bunifuTextBoxA.BorderThickness = 1;
            this.bunifuTextBoxA.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTextBoxA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBoxA.DefaultFont = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextBoxA.DefaultText = "";
            this.bunifuTextBoxA.FillColor = System.Drawing.Color.White;
            this.bunifuTextBoxA.HideSelection = true;
            this.bunifuTextBoxA.IconLeft = null;
            this.bunifuTextBoxA.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBoxA.IconPadding = 10;
            this.bunifuTextBoxA.IconRight = null;
            this.bunifuTextBoxA.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBoxA.Lines = new string[0];
            this.bunifuTextBoxA.Location = new System.Drawing.Point(190, 82);
            this.bunifuTextBoxA.MaxLength = 32767;
            this.bunifuTextBoxA.MinimumSize = new System.Drawing.Size(1, 1);
            this.bunifuTextBoxA.Modified = false;
            this.bunifuTextBoxA.Multiline = false;
            this.bunifuTextBoxA.Name = "bunifuTextBoxA";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBoxA.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.bunifuTextBoxA.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBoxA.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBoxA.OnIdleState = stateProperties4;
            this.bunifuTextBoxA.Padding = new System.Windows.Forms.Padding(3);
            this.bunifuTextBoxA.PasswordChar = '\0';
            this.bunifuTextBoxA.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.bunifuTextBoxA.PlaceholderText = "";
            this.bunifuTextBoxA.ReadOnly = false;
            this.bunifuTextBoxA.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bunifuTextBoxA.SelectedText = "";
            this.bunifuTextBoxA.SelectionLength = 0;
            this.bunifuTextBoxA.SelectionStart = 0;
            this.bunifuTextBoxA.ShortcutsEnabled = true;
            this.bunifuTextBoxA.Size = new System.Drawing.Size(112, 32);
            this.bunifuTextBoxA.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.bunifuTextBoxA.TabIndex = 45;
            this.bunifuTextBoxA.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBoxA.TextMarginBottom = 0;
            this.bunifuTextBoxA.TextMarginLeft = 3;
            this.bunifuTextBoxA.TextMarginTop = 0;
            this.bunifuTextBoxA.TextPlaceholder = "";
            this.bunifuTextBoxA.UseSystemPasswordChar = false;
            this.bunifuTextBoxA.WordWrap = true;
            // 
            // bunifuTextBoxDe
            // 
            this.bunifuTextBoxDe.AcceptsReturn = false;
            this.bunifuTextBoxDe.AcceptsTab = false;
            this.bunifuTextBoxDe.AnimationSpeed = 200;
            this.bunifuTextBoxDe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBoxDe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBoxDe.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTextBoxDe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBoxDe.BackgroundImage")));
            this.bunifuTextBoxDe.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.bunifuTextBoxDe.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuTextBoxDe.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuTextBoxDe.BorderColorIdle = System.Drawing.Color.Silver;
            this.bunifuTextBoxDe.BorderRadius = 15;
            this.bunifuTextBoxDe.BorderThickness = 1;
            this.bunifuTextBoxDe.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTextBoxDe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBoxDe.DefaultFont = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextBoxDe.DefaultText = "";
            this.bunifuTextBoxDe.FillColor = System.Drawing.Color.White;
            this.bunifuTextBoxDe.HideSelection = true;
            this.bunifuTextBoxDe.IconLeft = null;
            this.bunifuTextBoxDe.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBoxDe.IconPadding = 10;
            this.bunifuTextBoxDe.IconRight = null;
            this.bunifuTextBoxDe.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBoxDe.Lines = new string[0];
            this.bunifuTextBoxDe.Location = new System.Drawing.Point(39, 82);
            this.bunifuTextBoxDe.MaxLength = 32767;
            this.bunifuTextBoxDe.MinimumSize = new System.Drawing.Size(1, 1);
            this.bunifuTextBoxDe.Modified = false;
            this.bunifuTextBoxDe.Multiline = false;
            this.bunifuTextBoxDe.Name = "bunifuTextBoxDe";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBoxDe.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.bunifuTextBoxDe.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBoxDe.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBoxDe.OnIdleState = stateProperties8;
            this.bunifuTextBoxDe.Padding = new System.Windows.Forms.Padding(3);
            this.bunifuTextBoxDe.PasswordChar = '\0';
            this.bunifuTextBoxDe.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.bunifuTextBoxDe.PlaceholderText = "";
            this.bunifuTextBoxDe.ReadOnly = false;
            this.bunifuTextBoxDe.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bunifuTextBoxDe.SelectedText = "";
            this.bunifuTextBoxDe.SelectionLength = 0;
            this.bunifuTextBoxDe.SelectionStart = 0;
            this.bunifuTextBoxDe.ShortcutsEnabled = true;
            this.bunifuTextBoxDe.Size = new System.Drawing.Size(112, 32);
            this.bunifuTextBoxDe.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.bunifuTextBoxDe.TabIndex = 44;
            this.bunifuTextBoxDe.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBoxDe.TextMarginBottom = 0;
            this.bunifuTextBoxDe.TextMarginLeft = 3;
            this.bunifuTextBoxDe.TextMarginTop = 0;
            this.bunifuTextBoxDe.TextPlaceholder = "";
            this.bunifuTextBoxDe.UseSystemPasswordChar = false;
            this.bunifuTextBoxDe.WordWrap = true;
            // 
            // bunifuButtonNettoyage
            // 
            this.bunifuButtonNettoyage.AllowAnimations = true;
            this.bunifuButtonNettoyage.AllowMouseEffects = true;
            this.bunifuButtonNettoyage.AllowToggling = false;
            this.bunifuButtonNettoyage.AnimationSpeed = 200;
            this.bunifuButtonNettoyage.AutoGenerateColors = false;
            this.bunifuButtonNettoyage.AutoRoundBorders = false;
            this.bunifuButtonNettoyage.AutoSizeLeftIcon = true;
            this.bunifuButtonNettoyage.AutoSizeRightIcon = true;
            this.bunifuButtonNettoyage.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButtonNettoyage.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonNettoyage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButtonNettoyage.BackgroundImage")));
            this.bunifuButtonNettoyage.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonNettoyage.ButtonText = "Actualiser";
            this.bunifuButtonNettoyage.ButtonTextMarginLeft = 0;
            this.bunifuButtonNettoyage.ColorContrastOnClick = 45;
            this.bunifuButtonNettoyage.ColorContrastOnHover = 45;
            this.bunifuButtonNettoyage.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.bunifuButtonNettoyage.CustomizableEdges = borderEdges2;
            this.bunifuButtonNettoyage.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButtonNettoyage.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButtonNettoyage.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButtonNettoyage.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButtonNettoyage.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButtonNettoyage.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButtonNettoyage.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonNettoyage.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButtonNettoyage.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButtonNettoyage.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButtonNettoyage.IconMarginLeft = 11;
            this.bunifuButtonNettoyage.IconPadding = 10;
            this.bunifuButtonNettoyage.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButtonNettoyage.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButtonNettoyage.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButtonNettoyage.IconSize = 25;
            this.bunifuButtonNettoyage.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonNettoyage.IdleBorderRadius = 35;
            this.bunifuButtonNettoyage.IdleBorderThickness = 1;
            this.bunifuButtonNettoyage.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonNettoyage.IdleIconLeftImage = global::Projet_Ruyaga.Properties.Resources.refresh_buttons;
            this.bunifuButtonNettoyage.IdleIconRightImage = null;
            this.bunifuButtonNettoyage.IndicateFocus = false;
            this.bunifuButtonNettoyage.Location = new System.Drawing.Point(118, 376);
            this.bunifuButtonNettoyage.Name = "bunifuButtonNettoyage";
            this.bunifuButtonNettoyage.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButtonNettoyage.OnDisabledState.BorderRadius = 35;
            this.bunifuButtonNettoyage.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonNettoyage.OnDisabledState.BorderThickness = 1;
            this.bunifuButtonNettoyage.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButtonNettoyage.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButtonNettoyage.OnDisabledState.IconLeftImage = null;
            this.bunifuButtonNettoyage.OnDisabledState.IconRightImage = null;
            this.bunifuButtonNettoyage.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButtonNettoyage.onHoverState.BorderRadius = 35;
            this.bunifuButtonNettoyage.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonNettoyage.onHoverState.BorderThickness = 1;
            this.bunifuButtonNettoyage.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButtonNettoyage.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonNettoyage.onHoverState.IconLeftImage = null;
            this.bunifuButtonNettoyage.onHoverState.IconRightImage = null;
            this.bunifuButtonNettoyage.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonNettoyage.OnIdleState.BorderRadius = 35;
            this.bunifuButtonNettoyage.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonNettoyage.OnIdleState.BorderThickness = 1;
            this.bunifuButtonNettoyage.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonNettoyage.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonNettoyage.OnIdleState.IconLeftImage = global::Projet_Ruyaga.Properties.Resources.refresh_buttons;
            this.bunifuButtonNettoyage.OnIdleState.IconRightImage = null;
            this.bunifuButtonNettoyage.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButtonNettoyage.OnPressedState.BorderRadius = 35;
            this.bunifuButtonNettoyage.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonNettoyage.OnPressedState.BorderThickness = 1;
            this.bunifuButtonNettoyage.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButtonNettoyage.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonNettoyage.OnPressedState.IconLeftImage = null;
            this.bunifuButtonNettoyage.OnPressedState.IconRightImage = null;
            this.bunifuButtonNettoyage.Size = new System.Drawing.Size(117, 35);
            this.bunifuButtonNettoyage.TabIndex = 43;
            this.bunifuButtonNettoyage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButtonNettoyage.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButtonNettoyage.TextMarginLeft = 0;
            this.bunifuButtonNettoyage.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButtonNettoyage.UseDefaultRadiusAndThickness = true;
            this.bunifuButtonNettoyage.Click += new System.EventHandler(this.bunifuButtonNettoyage_Click);
            // 
            // bunifuButtonInventaire
            // 
            this.bunifuButtonInventaire.AllowAnimations = true;
            this.bunifuButtonInventaire.AllowMouseEffects = true;
            this.bunifuButtonInventaire.AllowToggling = false;
            this.bunifuButtonInventaire.AnimationSpeed = 200;
            this.bunifuButtonInventaire.AutoGenerateColors = false;
            this.bunifuButtonInventaire.AutoRoundBorders = false;
            this.bunifuButtonInventaire.AutoSizeLeftIcon = true;
            this.bunifuButtonInventaire.AutoSizeRightIcon = true;
            this.bunifuButtonInventaire.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButtonInventaire.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonInventaire.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButtonInventaire.BackgroundImage")));
            this.bunifuButtonInventaire.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonInventaire.ButtonText = "Rapport";
            this.bunifuButtonInventaire.ButtonTextMarginLeft = 0;
            this.bunifuButtonInventaire.ColorContrastOnClick = 45;
            this.bunifuButtonInventaire.ColorContrastOnHover = 45;
            this.bunifuButtonInventaire.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.bunifuButtonInventaire.CustomizableEdges = borderEdges3;
            this.bunifuButtonInventaire.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButtonInventaire.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButtonInventaire.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButtonInventaire.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButtonInventaire.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButtonInventaire.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButtonInventaire.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonInventaire.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButtonInventaire.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButtonInventaire.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButtonInventaire.IconMarginLeft = 11;
            this.bunifuButtonInventaire.IconPadding = 5;
            this.bunifuButtonInventaire.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButtonInventaire.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButtonInventaire.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButtonInventaire.IconSize = 25;
            this.bunifuButtonInventaire.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonInventaire.IdleBorderRadius = 20;
            this.bunifuButtonInventaire.IdleBorderThickness = 1;
            this.bunifuButtonInventaire.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonInventaire.IdleIconLeftImage = global::Projet_Ruyaga.Properties.Resources.inventory;
            this.bunifuButtonInventaire.IdleIconRightImage = null;
            this.bunifuButtonInventaire.IndicateFocus = false;
            this.bunifuButtonInventaire.Location = new System.Drawing.Point(94, 130);
            this.bunifuButtonInventaire.Name = "bunifuButtonInventaire";
            this.bunifuButtonInventaire.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButtonInventaire.OnDisabledState.BorderRadius = 20;
            this.bunifuButtonInventaire.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonInventaire.OnDisabledState.BorderThickness = 1;
            this.bunifuButtonInventaire.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButtonInventaire.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButtonInventaire.OnDisabledState.IconLeftImage = null;
            this.bunifuButtonInventaire.OnDisabledState.IconRightImage = null;
            this.bunifuButtonInventaire.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButtonInventaire.onHoverState.BorderRadius = 20;
            this.bunifuButtonInventaire.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonInventaire.onHoverState.BorderThickness = 1;
            this.bunifuButtonInventaire.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButtonInventaire.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonInventaire.onHoverState.IconLeftImage = null;
            this.bunifuButtonInventaire.onHoverState.IconRightImage = null;
            this.bunifuButtonInventaire.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonInventaire.OnIdleState.BorderRadius = 20;
            this.bunifuButtonInventaire.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonInventaire.OnIdleState.BorderThickness = 1;
            this.bunifuButtonInventaire.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonInventaire.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonInventaire.OnIdleState.IconLeftImage = global::Projet_Ruyaga.Properties.Resources.inventory;
            this.bunifuButtonInventaire.OnIdleState.IconRightImage = null;
            this.bunifuButtonInventaire.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButtonInventaire.OnPressedState.BorderRadius = 20;
            this.bunifuButtonInventaire.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonInventaire.OnPressedState.BorderThickness = 1;
            this.bunifuButtonInventaire.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButtonInventaire.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonInventaire.OnPressedState.IconLeftImage = null;
            this.bunifuButtonInventaire.OnPressedState.IconRightImage = null;
            this.bunifuButtonInventaire.Size = new System.Drawing.Size(150, 39);
            this.bunifuButtonInventaire.TabIndex = 40;
            this.bunifuButtonInventaire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButtonInventaire.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButtonInventaire.TextMarginLeft = 0;
            this.bunifuButtonInventaire.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButtonInventaire.UseDefaultRadiusAndThickness = true;
            this.bunifuButtonInventaire.Click += new System.EventHandler(this.bunifuButtonInventaire_Click);
            // 
            // bunifuDropdownProduit
            // 
            this.bunifuDropdownProduit.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdownProduit.BackgroundColor = System.Drawing.Color.White;
            this.bunifuDropdownProduit.BorderColor = System.Drawing.Color.Silver;
            this.bunifuDropdownProduit.BorderRadius = 10;
            this.bunifuDropdownProduit.Color = System.Drawing.Color.Silver;
            this.bunifuDropdownProduit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuDropdownProduit.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.bunifuDropdownProduit.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bunifuDropdownProduit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuDropdownProduit.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bunifuDropdownProduit.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.bunifuDropdownProduit.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.bunifuDropdownProduit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bunifuDropdownProduit.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.bunifuDropdownProduit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bunifuDropdownProduit.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Center;
            this.bunifuDropdownProduit.FillDropDown = true;
            this.bunifuDropdownProduit.FillIndicator = false;
            this.bunifuDropdownProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuDropdownProduit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.bunifuDropdownProduit.ForeColor = System.Drawing.Color.Black;
            this.bunifuDropdownProduit.FormattingEnabled = true;
            this.bunifuDropdownProduit.Icon = null;
            this.bunifuDropdownProduit.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bunifuDropdownProduit.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuDropdownProduit.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bunifuDropdownProduit.ItemBackColor = System.Drawing.Color.White;
            this.bunifuDropdownProduit.ItemBorderColor = System.Drawing.Color.White;
            this.bunifuDropdownProduit.ItemForeColor = System.Drawing.Color.Black;
            this.bunifuDropdownProduit.ItemHeight = 26;
            this.bunifuDropdownProduit.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDropdownProduit.ItemHighLightForeColor = System.Drawing.Color.White;
            this.bunifuDropdownProduit.ItemTopMargin = 3;
            this.bunifuDropdownProduit.Location = new System.Drawing.Point(56, 232);
            this.bunifuDropdownProduit.Name = "bunifuDropdownProduit";
            this.bunifuDropdownProduit.Size = new System.Drawing.Size(224, 32);
            this.bunifuDropdownProduit.TabIndex = 37;
            this.bunifuDropdownProduit.Text = null;
            this.bunifuDropdownProduit.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Center;
            this.bunifuDropdownProduit.TextLeftMargin = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(100, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 19);
            this.label2.TabIndex = 36;
            this.label2.Text = "Nom du Produit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(157, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(110, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Etat du Stock";
            // 
            // FormRapportStockTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1268, 553);
            this.Controls.Add(this.reportViewerStock);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRapportStockTotal";
            this.Text = "FormRapportStockTotal";
            this.Load += new System.EventHandler(this.FormRapportStockTotal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTableStockTotalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetStockTotal)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerStock;
        private System.Windows.Forms.BindingSource DataTableStockTotalBindingSource;
        private DataSetStockTotal DataSetStockTotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButtonNettoyage;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButtonInventaire;
        private Bunifu.UI.WinForms.BunifuDropdown bunifuDropdownProduit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuTextBox bunifuTextBoxA;
        private Bunifu.UI.WinForms.BunifuTextBox bunifuTextBoxDe;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButtonInventaireParProduit;
    }
}