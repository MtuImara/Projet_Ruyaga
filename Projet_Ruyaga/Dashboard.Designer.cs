namespace Projet_Ruyaga
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.chartStockEntree = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.reportViewerGraphEntreeSortie = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bunifuButtonInventaire = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuDateEntreeAu = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.bunifuDateEntreeDe = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStockEntree)).BeginInit();
            this.bunifuPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 20;
            this.bunifuPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.chartStockEntree);
            this.bunifuPanel1.Location = new System.Drawing.Point(16, 44);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(396, 427);
            this.bunifuPanel1.TabIndex = 0;
            this.bunifuPanel1.Click += new System.EventHandler(this.bunifuPanel1_Click);
            // 
            // chartStockEntree
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStockEntree.ChartAreas.Add(chartArea1);
            legend1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            legend1.Name = "Stock Total";
            legend1.Title = "Stock Total";
            legend1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartStockEntree.Legends.Add(legend1);
            this.chartStockEntree.Location = new System.Drawing.Point(23, 32);
            this.chartStockEntree.Name = "chartStockEntree";
            this.chartStockEntree.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Stock Total";
            series1.Name = "Nom du Produit";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.YValuesPerPoint = 4;
            this.chartStockEntree.Series.Add(series1);
            this.chartStockEntree.Size = new System.Drawing.Size(358, 346);
            this.chartStockEntree.TabIndex = 0;
            this.chartStockEntree.Text = "chart1";
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
            this.bunifuPanel2.Controls.Add(this.reportViewerGraphEntreeSortie);
            this.bunifuPanel2.Location = new System.Drawing.Point(423, 44);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(834, 536);
            this.bunifuPanel2.TabIndex = 1;
            this.bunifuPanel2.Click += new System.EventHandler(this.bunifuPanel2_Click);
            // 
            // reportViewerGraphEntreeSortie
            // 
            this.reportViewerGraphEntreeSortie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewerGraphEntreeSortie.LocalReport.ReportEmbeddedResource = "Projet_Ruyaga.ReportGraphEntreeSortie.rdlc";
            this.reportViewerGraphEntreeSortie.Location = new System.Drawing.Point(15, 16);
            this.reportViewerGraphEntreeSortie.Name = "reportViewerGraphEntreeSortie";
            this.reportViewerGraphEntreeSortie.ServerReport.BearerToken = null;
            this.reportViewerGraphEntreeSortie.ShowBackButton = false;
            this.reportViewerGraphEntreeSortie.ShowFindControls = false;
            this.reportViewerGraphEntreeSortie.ShowPageNavigationControls = false;
            this.reportViewerGraphEntreeSortie.ShowStopButton = false;
            this.reportViewerGraphEntreeSortie.Size = new System.Drawing.Size(797, 495);
            this.reportViewerGraphEntreeSortie.TabIndex = 24;
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
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButtonInventaire.CustomizableEdges = borderEdges1;
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
            this.bunifuButtonInventaire.Location = new System.Drawing.Point(128, 541);
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
            this.bunifuButtonInventaire.TabIndex = 44;
            this.bunifuButtonInventaire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButtonInventaire.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButtonInventaire.TextMarginLeft = 0;
            this.bunifuButtonInventaire.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButtonInventaire.UseDefaultRadiusAndThickness = true;
            this.bunifuButtonInventaire.Click += new System.EventHandler(this.bunifuButtonInventaire_Click);
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
            this.bunifuDateEntreeAu.Location = new System.Drawing.Point(222, 486);
            this.bunifuDateEntreeAu.MinimumSize = new System.Drawing.Size(4, 32);
            this.bunifuDateEntreeAu.Name = "bunifuDateEntreeAu";
            this.bunifuDateEntreeAu.Size = new System.Drawing.Size(129, 32);
            this.bunifuDateEntreeAu.TabIndex = 43;
            this.bunifuDateEntreeAu.ValueChanged += new System.EventHandler(this.bunifuDateEntreeAu_ValueChanged);
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
            this.bunifuDateEntreeDe.Location = new System.Drawing.Point(54, 486);
            this.bunifuDateEntreeDe.MinimumSize = new System.Drawing.Size(4, 32);
            this.bunifuDateEntreeDe.Name = "bunifuDateEntreeDe";
            this.bunifuDateEntreeDe.Size = new System.Drawing.Size(129, 32);
            this.bunifuDateEntreeDe.TabIndex = 42;
            this.bunifuDateEntreeDe.ValueChanged += new System.EventHandler(this.bunifuDateEntreeDe_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(191, 490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 25);
            this.label3.TabIndex = 41;
            this.label3.Text = "A";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 592);
            this.Controls.Add(this.bunifuButtonInventaire);
            this.Controls.Add(this.bunifuDateEntreeAu);
            this.Controls.Add(this.bunifuDateEntreeDe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartStockEntree)).EndInit();
            this.bunifuPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStockEntree;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerGraphEntreeSortie;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButtonInventaire;
        private Bunifu.UI.WinForms.BunifuDatePicker bunifuDateEntreeAu;
        private Bunifu.UI.WinForms.BunifuDatePicker bunifuDateEntreeDe;
        private System.Windows.Forms.Label label3;
    }
}