namespace Projet_Ruyaga
{
    partial class FormRapportSortie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRapportSortie));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.DataTableSortieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetSortie = new Projet_Ruyaga.DataSetSortie();
            this.reportViewerSortieStock = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bunifuButtonNettoyage = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButtonInventaireUser = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButtonInventaireProduit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButtonInventaire = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuDropdownUser = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuDropdownProduit = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuDateEntreeAu = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.bunifuDateEntreeDe = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableSortieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetSortie)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataTableSortieBindingSource
            // 
            this.DataTableSortieBindingSource.DataMember = "DataTableSortie";
            this.DataTableSortieBindingSource.DataSource = this.DataSetSortie;
            // 
            // DataSetSortie
            // 
            this.DataSetSortie.DataSetName = "DataSetSortie";
            this.DataSetSortie.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewerSortieStock
            // 
            reportDataSource1.Name = "DataSetSortie";
            reportDataSource1.Value = this.DataTableSortieBindingSource;
            this.reportViewerSortieStock.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerSortieStock.LocalReport.ReportEmbeddedResource = "Projet_Ruyaga.ReportSortie.rdlc";
            this.reportViewerSortieStock.Location = new System.Drawing.Point(59, 12);
            this.reportViewerSortieStock.Name = "reportViewerSortieStock";
            this.reportViewerSortieStock.ServerReport.BearerToken = null;
            this.reportViewerSortieStock.Size = new System.Drawing.Size(802, 561);
            this.reportViewerSortieStock.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.bunifuButtonNettoyage);
            this.groupBox2.Controls.Add(this.bunifuButtonInventaireUser);
            this.groupBox2.Controls.Add(this.bunifuButtonInventaireProduit);
            this.groupBox2.Controls.Add(this.bunifuButtonInventaire);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.bunifuDropdownUser);
            this.groupBox2.Controls.Add(this.bunifuDropdownProduit);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.bunifuDateEntreeAu);
            this.groupBox2.Controls.Add(this.bunifuDateEntreeDe);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(928, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 563);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
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
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButtonNettoyage.CustomizableEdges = borderEdges1;
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
            this.bunifuButtonNettoyage.Location = new System.Drawing.Point(104, 487);
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
            // bunifuButtonInventaireUser
            // 
            this.bunifuButtonInventaireUser.AllowAnimations = true;
            this.bunifuButtonInventaireUser.AllowMouseEffects = true;
            this.bunifuButtonInventaireUser.AllowToggling = false;
            this.bunifuButtonInventaireUser.AnimationSpeed = 200;
            this.bunifuButtonInventaireUser.AutoGenerateColors = false;
            this.bunifuButtonInventaireUser.AutoRoundBorders = false;
            this.bunifuButtonInventaireUser.AutoSizeLeftIcon = true;
            this.bunifuButtonInventaireUser.AutoSizeRightIcon = true;
            this.bunifuButtonInventaireUser.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButtonInventaireUser.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonInventaireUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButtonInventaireUser.BackgroundImage")));
            this.bunifuButtonInventaireUser.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonInventaireUser.ButtonText = "Rapport";
            this.bunifuButtonInventaireUser.ButtonTextMarginLeft = 0;
            this.bunifuButtonInventaireUser.ColorContrastOnClick = 45;
            this.bunifuButtonInventaireUser.ColorContrastOnHover = 45;
            this.bunifuButtonInventaireUser.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.bunifuButtonInventaireUser.CustomizableEdges = borderEdges2;
            this.bunifuButtonInventaireUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButtonInventaireUser.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButtonInventaireUser.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButtonInventaireUser.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButtonInventaireUser.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButtonInventaireUser.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButtonInventaireUser.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonInventaireUser.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButtonInventaireUser.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButtonInventaireUser.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButtonInventaireUser.IconMarginLeft = 11;
            this.bunifuButtonInventaireUser.IconPadding = 5;
            this.bunifuButtonInventaireUser.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButtonInventaireUser.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButtonInventaireUser.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButtonInventaireUser.IconSize = 25;
            this.bunifuButtonInventaireUser.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonInventaireUser.IdleBorderRadius = 20;
            this.bunifuButtonInventaireUser.IdleBorderThickness = 1;
            this.bunifuButtonInventaireUser.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonInventaireUser.IdleIconLeftImage = global::Projet_Ruyaga.Properties.Resources.inventory;
            this.bunifuButtonInventaireUser.IdleIconRightImage = null;
            this.bunifuButtonInventaireUser.IndicateFocus = false;
            this.bunifuButtonInventaireUser.Location = new System.Drawing.Point(93, 425);
            this.bunifuButtonInventaireUser.Name = "bunifuButtonInventaireUser";
            this.bunifuButtonInventaireUser.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButtonInventaireUser.OnDisabledState.BorderRadius = 20;
            this.bunifuButtonInventaireUser.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonInventaireUser.OnDisabledState.BorderThickness = 1;
            this.bunifuButtonInventaireUser.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButtonInventaireUser.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButtonInventaireUser.OnDisabledState.IconLeftImage = null;
            this.bunifuButtonInventaireUser.OnDisabledState.IconRightImage = null;
            this.bunifuButtonInventaireUser.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButtonInventaireUser.onHoverState.BorderRadius = 20;
            this.bunifuButtonInventaireUser.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonInventaireUser.onHoverState.BorderThickness = 1;
            this.bunifuButtonInventaireUser.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButtonInventaireUser.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonInventaireUser.onHoverState.IconLeftImage = null;
            this.bunifuButtonInventaireUser.onHoverState.IconRightImage = null;
            this.bunifuButtonInventaireUser.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonInventaireUser.OnIdleState.BorderRadius = 20;
            this.bunifuButtonInventaireUser.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonInventaireUser.OnIdleState.BorderThickness = 1;
            this.bunifuButtonInventaireUser.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonInventaireUser.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonInventaireUser.OnIdleState.IconLeftImage = global::Projet_Ruyaga.Properties.Resources.inventory;
            this.bunifuButtonInventaireUser.OnIdleState.IconRightImage = null;
            this.bunifuButtonInventaireUser.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButtonInventaireUser.OnPressedState.BorderRadius = 20;
            this.bunifuButtonInventaireUser.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonInventaireUser.OnPressedState.BorderThickness = 1;
            this.bunifuButtonInventaireUser.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButtonInventaireUser.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonInventaireUser.OnPressedState.IconLeftImage = null;
            this.bunifuButtonInventaireUser.OnPressedState.IconRightImage = null;
            this.bunifuButtonInventaireUser.Size = new System.Drawing.Size(150, 39);
            this.bunifuButtonInventaireUser.TabIndex = 42;
            this.bunifuButtonInventaireUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButtonInventaireUser.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButtonInventaireUser.TextMarginLeft = 0;
            this.bunifuButtonInventaireUser.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButtonInventaireUser.UseDefaultRadiusAndThickness = true;
            this.bunifuButtonInventaireUser.Click += new System.EventHandler(this.bunifuButtonInventaireUser_Click);
            // 
            // bunifuButtonInventaireProduit
            // 
            this.bunifuButtonInventaireProduit.AllowAnimations = true;
            this.bunifuButtonInventaireProduit.AllowMouseEffects = true;
            this.bunifuButtonInventaireProduit.AllowToggling = false;
            this.bunifuButtonInventaireProduit.AnimationSpeed = 200;
            this.bunifuButtonInventaireProduit.AutoGenerateColors = false;
            this.bunifuButtonInventaireProduit.AutoRoundBorders = false;
            this.bunifuButtonInventaireProduit.AutoSizeLeftIcon = true;
            this.bunifuButtonInventaireProduit.AutoSizeRightIcon = true;
            this.bunifuButtonInventaireProduit.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButtonInventaireProduit.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonInventaireProduit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButtonInventaireProduit.BackgroundImage")));
            this.bunifuButtonInventaireProduit.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonInventaireProduit.ButtonText = "Rapport";
            this.bunifuButtonInventaireProduit.ButtonTextMarginLeft = 0;
            this.bunifuButtonInventaireProduit.ColorContrastOnClick = 45;
            this.bunifuButtonInventaireProduit.ColorContrastOnHover = 45;
            this.bunifuButtonInventaireProduit.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.bunifuButtonInventaireProduit.CustomizableEdges = borderEdges3;
            this.bunifuButtonInventaireProduit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButtonInventaireProduit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButtonInventaireProduit.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButtonInventaireProduit.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButtonInventaireProduit.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButtonInventaireProduit.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButtonInventaireProduit.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonInventaireProduit.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButtonInventaireProduit.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButtonInventaireProduit.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButtonInventaireProduit.IconMarginLeft = 11;
            this.bunifuButtonInventaireProduit.IconPadding = 5;
            this.bunifuButtonInventaireProduit.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButtonInventaireProduit.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButtonInventaireProduit.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButtonInventaireProduit.IconSize = 25;
            this.bunifuButtonInventaireProduit.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonInventaireProduit.IdleBorderRadius = 20;
            this.bunifuButtonInventaireProduit.IdleBorderThickness = 1;
            this.bunifuButtonInventaireProduit.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonInventaireProduit.IdleIconLeftImage = global::Projet_Ruyaga.Properties.Resources.inventory;
            this.bunifuButtonInventaireProduit.IdleIconRightImage = null;
            this.bunifuButtonInventaireProduit.IndicateFocus = false;
            this.bunifuButtonInventaireProduit.Location = new System.Drawing.Point(93, 285);
            this.bunifuButtonInventaireProduit.Name = "bunifuButtonInventaireProduit";
            this.bunifuButtonInventaireProduit.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButtonInventaireProduit.OnDisabledState.BorderRadius = 20;
            this.bunifuButtonInventaireProduit.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonInventaireProduit.OnDisabledState.BorderThickness = 1;
            this.bunifuButtonInventaireProduit.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButtonInventaireProduit.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButtonInventaireProduit.OnDisabledState.IconLeftImage = null;
            this.bunifuButtonInventaireProduit.OnDisabledState.IconRightImage = null;
            this.bunifuButtonInventaireProduit.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButtonInventaireProduit.onHoverState.BorderRadius = 20;
            this.bunifuButtonInventaireProduit.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonInventaireProduit.onHoverState.BorderThickness = 1;
            this.bunifuButtonInventaireProduit.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButtonInventaireProduit.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonInventaireProduit.onHoverState.IconLeftImage = null;
            this.bunifuButtonInventaireProduit.onHoverState.IconRightImage = null;
            this.bunifuButtonInventaireProduit.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonInventaireProduit.OnIdleState.BorderRadius = 20;
            this.bunifuButtonInventaireProduit.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonInventaireProduit.OnIdleState.BorderThickness = 1;
            this.bunifuButtonInventaireProduit.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonInventaireProduit.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonInventaireProduit.OnIdleState.IconLeftImage = global::Projet_Ruyaga.Properties.Resources.inventory;
            this.bunifuButtonInventaireProduit.OnIdleState.IconRightImage = null;
            this.bunifuButtonInventaireProduit.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButtonInventaireProduit.OnPressedState.BorderRadius = 20;
            this.bunifuButtonInventaireProduit.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonInventaireProduit.OnPressedState.BorderThickness = 1;
            this.bunifuButtonInventaireProduit.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButtonInventaireProduit.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonInventaireProduit.OnPressedState.IconLeftImage = null;
            this.bunifuButtonInventaireProduit.OnPressedState.IconRightImage = null;
            this.bunifuButtonInventaireProduit.Size = new System.Drawing.Size(150, 39);
            this.bunifuButtonInventaireProduit.TabIndex = 41;
            this.bunifuButtonInventaireProduit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButtonInventaireProduit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButtonInventaireProduit.TextMarginLeft = 0;
            this.bunifuButtonInventaireProduit.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButtonInventaireProduit.UseDefaultRadiusAndThickness = true;
            this.bunifuButtonInventaireProduit.Click += new System.EventHandler(this.bunifuButtonInventaireProduit_Click);
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
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.bunifuButtonInventaire.CustomizableEdges = borderEdges4;
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
            this.bunifuButtonInventaire.Location = new System.Drawing.Point(94, 151);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(122, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 39;
            this.label4.Text = "Utilisateur";
            // 
            // bunifuDropdownUser
            // 
            this.bunifuDropdownUser.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdownUser.BackgroundColor = System.Drawing.Color.White;
            this.bunifuDropdownUser.BorderColor = System.Drawing.Color.Silver;
            this.bunifuDropdownUser.BorderRadius = 10;
            this.bunifuDropdownUser.Color = System.Drawing.Color.Silver;
            this.bunifuDropdownUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuDropdownUser.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.bunifuDropdownUser.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bunifuDropdownUser.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuDropdownUser.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bunifuDropdownUser.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.bunifuDropdownUser.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.bunifuDropdownUser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bunifuDropdownUser.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.bunifuDropdownUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bunifuDropdownUser.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Center;
            this.bunifuDropdownUser.FillDropDown = true;
            this.bunifuDropdownUser.FillIndicator = false;
            this.bunifuDropdownUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuDropdownUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.bunifuDropdownUser.ForeColor = System.Drawing.Color.Black;
            this.bunifuDropdownUser.FormattingEnabled = true;
            this.bunifuDropdownUser.Icon = null;
            this.bunifuDropdownUser.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bunifuDropdownUser.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuDropdownUser.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bunifuDropdownUser.ItemBackColor = System.Drawing.Color.White;
            this.bunifuDropdownUser.ItemBorderColor = System.Drawing.Color.White;
            this.bunifuDropdownUser.ItemForeColor = System.Drawing.Color.Black;
            this.bunifuDropdownUser.ItemHeight = 26;
            this.bunifuDropdownUser.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDropdownUser.ItemHighLightForeColor = System.Drawing.Color.White;
            this.bunifuDropdownUser.ItemTopMargin = 3;
            this.bunifuDropdownUser.Location = new System.Drawing.Point(56, 373);
            this.bunifuDropdownUser.Name = "bunifuDropdownUser";
            this.bunifuDropdownUser.Size = new System.Drawing.Size(224, 32);
            this.bunifuDropdownUser.TabIndex = 38;
            this.bunifuDropdownUser.Text = null;
            this.bunifuDropdownUser.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Center;
            this.bunifuDropdownUser.TextLeftMargin = 5;
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
            // bunifuDateEntreeAu
            // 
            this.bunifuDateEntreeAu.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDateEntreeAu.BorderRadius = 10;
            this.bunifuDateEntreeAu.Color = System.Drawing.Color.Silver;
            this.bunifuDateEntreeAu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuDateEntreeAu.CustomFormat = "yyyy-MM-dd";
            this.bunifuDateEntreeAu.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.bunifuDateEntreeAu.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.bunifuDateEntreeAu.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDateEntreeAu.DisplayWeekNumbers = false;
            this.bunifuDateEntreeAu.DPHeight = 0;
            this.bunifuDateEntreeAu.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.bunifuDateEntreeAu.FillDatePicker = false;
            this.bunifuDateEntreeAu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.bunifuDateEntreeAu.ForeColor = System.Drawing.Color.Black;
            this.bunifuDateEntreeAu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bunifuDateEntreeAu.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuDateEntreeAu.Icon")));
            this.bunifuDateEntreeAu.IconColor = System.Drawing.Color.Gray;
            this.bunifuDateEntreeAu.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.bunifuDateEntreeAu.LeftTextMargin = 5;
            this.bunifuDateEntreeAu.Location = new System.Drawing.Point(188, 96);
            this.bunifuDateEntreeAu.MinimumSize = new System.Drawing.Size(4, 32);
            this.bunifuDateEntreeAu.Name = "bunifuDateEntreeAu";
            this.bunifuDateEntreeAu.Size = new System.Drawing.Size(129, 32);
            this.bunifuDateEntreeAu.TabIndex = 35;
            // 
            // bunifuDateEntreeDe
            // 
            this.bunifuDateEntreeDe.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDateEntreeDe.BorderRadius = 10;
            this.bunifuDateEntreeDe.Color = System.Drawing.Color.Silver;
            this.bunifuDateEntreeDe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuDateEntreeDe.CustomFormat = "yyyy-MM-dd";
            this.bunifuDateEntreeDe.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.bunifuDateEntreeDe.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.bunifuDateEntreeDe.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDateEntreeDe.DisplayWeekNumbers = false;
            this.bunifuDateEntreeDe.DPHeight = 0;
            this.bunifuDateEntreeDe.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.bunifuDateEntreeDe.FillDatePicker = false;
            this.bunifuDateEntreeDe.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.bunifuDateEntreeDe.ForeColor = System.Drawing.Color.Black;
            this.bunifuDateEntreeDe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bunifuDateEntreeDe.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuDateEntreeDe.Icon")));
            this.bunifuDateEntreeDe.IconColor = System.Drawing.Color.Gray;
            this.bunifuDateEntreeDe.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.bunifuDateEntreeDe.LeftTextMargin = 5;
            this.bunifuDateEntreeDe.Location = new System.Drawing.Point(20, 96);
            this.bunifuDateEntreeDe.MinimumSize = new System.Drawing.Size(4, 32);
            this.bunifuDateEntreeDe.Name = "bunifuDateEntreeDe";
            this.bunifuDateEntreeDe.Size = new System.Drawing.Size(129, 32);
            this.bunifuDateEntreeDe.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(157, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Voir tous les détails des Sorties";
            // 
            // FormRapportSortie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 592);
            this.Controls.Add(this.reportViewerSortieStock);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRapportSortie";
            this.Text = "FormRapportSortie";
            this.Load += new System.EventHandler(this.FormRapportSortie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTableSortieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetSortie)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerSortieStock;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButtonNettoyage;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButtonInventaireUser;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButtonInventaireProduit;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButtonInventaire;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuDropdown bunifuDropdownUser;
        private Bunifu.UI.WinForms.BunifuDropdown bunifuDropdownProduit;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuDatePicker bunifuDateEntreeAu;
        private Bunifu.UI.WinForms.BunifuDatePicker bunifuDateEntreeDe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource DataTableSortieBindingSource;
        private DataSetSortie DataSetSortie;
    }
}