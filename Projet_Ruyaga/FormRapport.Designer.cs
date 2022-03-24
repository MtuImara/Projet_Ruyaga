namespace Projet_Ruyaga
{
    partial class FormRapport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRapport));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuPanelRapportBody = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.reportViewerGraphStock1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bunifuPanelRapportMenu = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuButtonRapportSortie = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButtonRapportEntree = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButtonReportStock = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuPanelRapportBody.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.bunifuPanelRapportMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuPanelRapportBody
            // 
            this.bunifuPanelRapportBody.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanelRapportBody.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanelRapportBody.BackgroundImage")));
            this.bunifuPanelRapportBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanelRapportBody.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanelRapportBody.BorderRadius = 3;
            this.bunifuPanelRapportBody.BorderThickness = 1;
            this.bunifuPanelRapportBody.Controls.Add(this.bunifuPanel2);
            this.bunifuPanelRapportBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanelRapportBody.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanelRapportBody.Name = "bunifuPanelRapportBody";
            this.bunifuPanelRapportBody.ShowBorders = true;
            this.bunifuPanelRapportBody.Size = new System.Drawing.Size(1284, 548);
            this.bunifuPanelRapportBody.TabIndex = 1;
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
            this.bunifuPanel2.Controls.Add(this.reportViewerGraphStock1);
            this.bunifuPanel2.Location = new System.Drawing.Point(39, 6);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(1207, 536);
            this.bunifuPanel2.TabIndex = 3;
            // 
            // reportViewerGraphStock1
            // 
            this.reportViewerGraphStock1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewerGraphStock1.LocalReport.ReportEmbeddedResource = "Projet_Ruyaga.ReportGraphStock.rdlc";
            this.reportViewerGraphStock1.Location = new System.Drawing.Point(15, 16);
            this.reportViewerGraphStock1.Name = "reportViewerGraphStock1";
            this.reportViewerGraphStock1.ServerReport.BearerToken = null;
            this.reportViewerGraphStock1.ShowBackButton = false;
            this.reportViewerGraphStock1.ShowFindControls = false;
            this.reportViewerGraphStock1.ShowPageNavigationControls = false;
            this.reportViewerGraphStock1.ShowStopButton = false;
            this.reportViewerGraphStock1.Size = new System.Drawing.Size(1164, 495);
            this.reportViewerGraphStock1.TabIndex = 24;
            // 
            // bunifuPanelRapportMenu
            // 
            this.bunifuPanelRapportMenu.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.bunifuPanelRapportMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanelRapportMenu.BackgroundImage")));
            this.bunifuPanelRapportMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanelRapportMenu.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanelRapportMenu.BorderRadius = 20;
            this.bunifuPanelRapportMenu.BorderThickness = 1;
            this.bunifuPanelRapportMenu.Controls.Add(this.bunifuButtonRapportSortie);
            this.bunifuPanelRapportMenu.Controls.Add(this.bunifuButtonRapportEntree);
            this.bunifuPanelRapportMenu.Controls.Add(this.bunifuButtonReportStock);
            this.bunifuPanelRapportMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuPanelRapportMenu.Location = new System.Drawing.Point(0, 548);
            this.bunifuPanelRapportMenu.Name = "bunifuPanelRapportMenu";
            this.bunifuPanelRapportMenu.ShowBorders = true;
            this.bunifuPanelRapportMenu.Size = new System.Drawing.Size(1284, 44);
            this.bunifuPanelRapportMenu.TabIndex = 0;
            // 
            // bunifuButtonRapportSortie
            // 
            this.bunifuButtonRapportSortie.AllowAnimations = true;
            this.bunifuButtonRapportSortie.AllowMouseEffects = true;
            this.bunifuButtonRapportSortie.AllowToggling = false;
            this.bunifuButtonRapportSortie.AnimationSpeed = 200;
            this.bunifuButtonRapportSortie.AutoGenerateColors = false;
            this.bunifuButtonRapportSortie.AutoRoundBorders = false;
            this.bunifuButtonRapportSortie.AutoSizeLeftIcon = true;
            this.bunifuButtonRapportSortie.AutoSizeRightIcon = true;
            this.bunifuButtonRapportSortie.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButtonRapportSortie.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonRapportSortie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButtonRapportSortie.BackgroundImage")));
            this.bunifuButtonRapportSortie.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonRapportSortie.ButtonText = "Sorties";
            this.bunifuButtonRapportSortie.ButtonTextMarginLeft = 0;
            this.bunifuButtonRapportSortie.ColorContrastOnClick = 45;
            this.bunifuButtonRapportSortie.ColorContrastOnHover = 45;
            this.bunifuButtonRapportSortie.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButtonRapportSortie.CustomizableEdges = borderEdges1;
            this.bunifuButtonRapportSortie.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButtonRapportSortie.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButtonRapportSortie.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButtonRapportSortie.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButtonRapportSortie.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButtonRapportSortie.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButtonRapportSortie.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonRapportSortie.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButtonRapportSortie.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButtonRapportSortie.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButtonRapportSortie.IconMarginLeft = 11;
            this.bunifuButtonRapportSortie.IconPadding = 10;
            this.bunifuButtonRapportSortie.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButtonRapportSortie.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButtonRapportSortie.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButtonRapportSortie.IconSize = 25;
            this.bunifuButtonRapportSortie.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonRapportSortie.IdleBorderRadius = 20;
            this.bunifuButtonRapportSortie.IdleBorderThickness = 1;
            this.bunifuButtonRapportSortie.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonRapportSortie.IdleIconLeftImage = null;
            this.bunifuButtonRapportSortie.IdleIconRightImage = null;
            this.bunifuButtonRapportSortie.IndicateFocus = false;
            this.bunifuButtonRapportSortie.Location = new System.Drawing.Point(389, 3);
            this.bunifuButtonRapportSortie.Name = "bunifuButtonRapportSortie";
            this.bunifuButtonRapportSortie.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButtonRapportSortie.OnDisabledState.BorderRadius = 20;
            this.bunifuButtonRapportSortie.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonRapportSortie.OnDisabledState.BorderThickness = 1;
            this.bunifuButtonRapportSortie.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButtonRapportSortie.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButtonRapportSortie.OnDisabledState.IconLeftImage = null;
            this.bunifuButtonRapportSortie.OnDisabledState.IconRightImage = null;
            this.bunifuButtonRapportSortie.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButtonRapportSortie.onHoverState.BorderRadius = 20;
            this.bunifuButtonRapportSortie.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonRapportSortie.onHoverState.BorderThickness = 1;
            this.bunifuButtonRapportSortie.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButtonRapportSortie.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonRapportSortie.onHoverState.IconLeftImage = null;
            this.bunifuButtonRapportSortie.onHoverState.IconRightImage = null;
            this.bunifuButtonRapportSortie.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonRapportSortie.OnIdleState.BorderRadius = 20;
            this.bunifuButtonRapportSortie.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonRapportSortie.OnIdleState.BorderThickness = 1;
            this.bunifuButtonRapportSortie.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonRapportSortie.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonRapportSortie.OnIdleState.IconLeftImage = null;
            this.bunifuButtonRapportSortie.OnIdleState.IconRightImage = null;
            this.bunifuButtonRapportSortie.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButtonRapportSortie.OnPressedState.BorderRadius = 20;
            this.bunifuButtonRapportSortie.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonRapportSortie.OnPressedState.BorderThickness = 1;
            this.bunifuButtonRapportSortie.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButtonRapportSortie.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonRapportSortie.OnPressedState.IconLeftImage = null;
            this.bunifuButtonRapportSortie.OnPressedState.IconRightImage = null;
            this.bunifuButtonRapportSortie.Size = new System.Drawing.Size(150, 39);
            this.bunifuButtonRapportSortie.TabIndex = 14;
            this.bunifuButtonRapportSortie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButtonRapportSortie.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButtonRapportSortie.TextMarginLeft = 0;
            this.bunifuButtonRapportSortie.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButtonRapportSortie.UseDefaultRadiusAndThickness = true;
            this.bunifuButtonRapportSortie.Click += new System.EventHandler(this.bunifuButtonRapportSortie_Click);
            // 
            // bunifuButtonRapportEntree
            // 
            this.bunifuButtonRapportEntree.AllowAnimations = true;
            this.bunifuButtonRapportEntree.AllowMouseEffects = true;
            this.bunifuButtonRapportEntree.AllowToggling = false;
            this.bunifuButtonRapportEntree.AnimationSpeed = 200;
            this.bunifuButtonRapportEntree.AutoGenerateColors = false;
            this.bunifuButtonRapportEntree.AutoRoundBorders = false;
            this.bunifuButtonRapportEntree.AutoSizeLeftIcon = true;
            this.bunifuButtonRapportEntree.AutoSizeRightIcon = true;
            this.bunifuButtonRapportEntree.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButtonRapportEntree.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonRapportEntree.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButtonRapportEntree.BackgroundImage")));
            this.bunifuButtonRapportEntree.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonRapportEntree.ButtonText = "Entrées";
            this.bunifuButtonRapportEntree.ButtonTextMarginLeft = 0;
            this.bunifuButtonRapportEntree.ColorContrastOnClick = 45;
            this.bunifuButtonRapportEntree.ColorContrastOnHover = 45;
            this.bunifuButtonRapportEntree.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.bunifuButtonRapportEntree.CustomizableEdges = borderEdges2;
            this.bunifuButtonRapportEntree.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButtonRapportEntree.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButtonRapportEntree.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButtonRapportEntree.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButtonRapportEntree.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButtonRapportEntree.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButtonRapportEntree.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonRapportEntree.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButtonRapportEntree.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButtonRapportEntree.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButtonRapportEntree.IconMarginLeft = 11;
            this.bunifuButtonRapportEntree.IconPadding = 10;
            this.bunifuButtonRapportEntree.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButtonRapportEntree.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButtonRapportEntree.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButtonRapportEntree.IconSize = 25;
            this.bunifuButtonRapportEntree.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonRapportEntree.IdleBorderRadius = 20;
            this.bunifuButtonRapportEntree.IdleBorderThickness = 1;
            this.bunifuButtonRapportEntree.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonRapportEntree.IdleIconLeftImage = null;
            this.bunifuButtonRapportEntree.IdleIconRightImage = null;
            this.bunifuButtonRapportEntree.IndicateFocus = false;
            this.bunifuButtonRapportEntree.Location = new System.Drawing.Point(216, 3);
            this.bunifuButtonRapportEntree.Name = "bunifuButtonRapportEntree";
            this.bunifuButtonRapportEntree.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButtonRapportEntree.OnDisabledState.BorderRadius = 20;
            this.bunifuButtonRapportEntree.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonRapportEntree.OnDisabledState.BorderThickness = 1;
            this.bunifuButtonRapportEntree.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButtonRapportEntree.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButtonRapportEntree.OnDisabledState.IconLeftImage = null;
            this.bunifuButtonRapportEntree.OnDisabledState.IconRightImage = null;
            this.bunifuButtonRapportEntree.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButtonRapportEntree.onHoverState.BorderRadius = 20;
            this.bunifuButtonRapportEntree.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonRapportEntree.onHoverState.BorderThickness = 1;
            this.bunifuButtonRapportEntree.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButtonRapportEntree.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonRapportEntree.onHoverState.IconLeftImage = null;
            this.bunifuButtonRapportEntree.onHoverState.IconRightImage = null;
            this.bunifuButtonRapportEntree.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonRapportEntree.OnIdleState.BorderRadius = 20;
            this.bunifuButtonRapportEntree.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonRapportEntree.OnIdleState.BorderThickness = 1;
            this.bunifuButtonRapportEntree.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonRapportEntree.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonRapportEntree.OnIdleState.IconLeftImage = null;
            this.bunifuButtonRapportEntree.OnIdleState.IconRightImage = null;
            this.bunifuButtonRapportEntree.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButtonRapportEntree.OnPressedState.BorderRadius = 20;
            this.bunifuButtonRapportEntree.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonRapportEntree.OnPressedState.BorderThickness = 1;
            this.bunifuButtonRapportEntree.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButtonRapportEntree.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonRapportEntree.OnPressedState.IconLeftImage = null;
            this.bunifuButtonRapportEntree.OnPressedState.IconRightImage = null;
            this.bunifuButtonRapportEntree.Size = new System.Drawing.Size(150, 39);
            this.bunifuButtonRapportEntree.TabIndex = 13;
            this.bunifuButtonRapportEntree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButtonRapportEntree.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButtonRapportEntree.TextMarginLeft = 0;
            this.bunifuButtonRapportEntree.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButtonRapportEntree.UseDefaultRadiusAndThickness = true;
            this.bunifuButtonRapportEntree.Click += new System.EventHandler(this.bunifuButtonRapportEntree_Click);
            // 
            // bunifuButtonReportStock
            // 
            this.bunifuButtonReportStock.AllowAnimations = true;
            this.bunifuButtonReportStock.AllowMouseEffects = true;
            this.bunifuButtonReportStock.AllowToggling = false;
            this.bunifuButtonReportStock.AnimationSpeed = 200;
            this.bunifuButtonReportStock.AutoGenerateColors = false;
            this.bunifuButtonReportStock.AutoRoundBorders = false;
            this.bunifuButtonReportStock.AutoSizeLeftIcon = true;
            this.bunifuButtonReportStock.AutoSizeRightIcon = true;
            this.bunifuButtonReportStock.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButtonReportStock.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonReportStock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButtonReportStock.BackgroundImage")));
            this.bunifuButtonReportStock.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonReportStock.ButtonText = "Stock";
            this.bunifuButtonReportStock.ButtonTextMarginLeft = 0;
            this.bunifuButtonReportStock.ColorContrastOnClick = 45;
            this.bunifuButtonReportStock.ColorContrastOnHover = 45;
            this.bunifuButtonReportStock.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.bunifuButtonReportStock.CustomizableEdges = borderEdges3;
            this.bunifuButtonReportStock.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButtonReportStock.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButtonReportStock.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButtonReportStock.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButtonReportStock.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButtonReportStock.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButtonReportStock.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonReportStock.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButtonReportStock.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButtonReportStock.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButtonReportStock.IconMarginLeft = 11;
            this.bunifuButtonReportStock.IconPadding = 10;
            this.bunifuButtonReportStock.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButtonReportStock.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButtonReportStock.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButtonReportStock.IconSize = 25;
            this.bunifuButtonReportStock.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonReportStock.IdleBorderRadius = 20;
            this.bunifuButtonReportStock.IdleBorderThickness = 1;
            this.bunifuButtonReportStock.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonReportStock.IdleIconLeftImage = null;
            this.bunifuButtonReportStock.IdleIconRightImage = null;
            this.bunifuButtonReportStock.IndicateFocus = false;
            this.bunifuButtonReportStock.Location = new System.Drawing.Point(47, 3);
            this.bunifuButtonReportStock.Name = "bunifuButtonReportStock";
            this.bunifuButtonReportStock.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButtonReportStock.OnDisabledState.BorderRadius = 20;
            this.bunifuButtonReportStock.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonReportStock.OnDisabledState.BorderThickness = 1;
            this.bunifuButtonReportStock.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButtonReportStock.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButtonReportStock.OnDisabledState.IconLeftImage = null;
            this.bunifuButtonReportStock.OnDisabledState.IconRightImage = null;
            this.bunifuButtonReportStock.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButtonReportStock.onHoverState.BorderRadius = 20;
            this.bunifuButtonReportStock.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonReportStock.onHoverState.BorderThickness = 1;
            this.bunifuButtonReportStock.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButtonReportStock.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonReportStock.onHoverState.IconLeftImage = null;
            this.bunifuButtonReportStock.onHoverState.IconRightImage = null;
            this.bunifuButtonReportStock.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonReportStock.OnIdleState.BorderRadius = 20;
            this.bunifuButtonReportStock.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonReportStock.OnIdleState.BorderThickness = 1;
            this.bunifuButtonReportStock.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonReportStock.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonReportStock.OnIdleState.IconLeftImage = null;
            this.bunifuButtonReportStock.OnIdleState.IconRightImage = null;
            this.bunifuButtonReportStock.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButtonReportStock.OnPressedState.BorderRadius = 20;
            this.bunifuButtonReportStock.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonReportStock.OnPressedState.BorderThickness = 1;
            this.bunifuButtonReportStock.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButtonReportStock.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonReportStock.OnPressedState.IconLeftImage = null;
            this.bunifuButtonReportStock.OnPressedState.IconRightImage = null;
            this.bunifuButtonReportStock.Size = new System.Drawing.Size(150, 39);
            this.bunifuButtonReportStock.TabIndex = 12;
            this.bunifuButtonReportStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButtonReportStock.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButtonReportStock.TextMarginLeft = 0;
            this.bunifuButtonReportStock.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButtonReportStock.UseDefaultRadiusAndThickness = true;
            this.bunifuButtonReportStock.Click += new System.EventHandler(this.bunifuButtonReportStock_Click);
            // 
            // FormRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 592);
            this.Controls.Add(this.bunifuPanelRapportBody);
            this.Controls.Add(this.bunifuPanelRapportMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRapport";
            this.Text = "FormRapport";
            this.bunifuPanelRapportBody.ResumeLayout(false);
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanelRapportMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanelRapportMenu;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanelRapportBody;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButtonRapportSortie;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButtonRapportEntree;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButtonReportStock;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerGraphStock1;
    }
}