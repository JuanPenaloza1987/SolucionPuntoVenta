﻿namespace SRATAPV.Reportes.Vista
{
    partial class frmCryReciboPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCryReciboPago));
            this.crvRptEdo = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvRptEdo
            // 
            this.crvRptEdo.ActiveViewIndex = -1;
            this.crvRptEdo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvRptEdo.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvRptEdo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvRptEdo.Location = new System.Drawing.Point(0, 0);
            this.crvRptEdo.Name = "crvRptEdo";
            this.crvRptEdo.Size = new System.Drawing.Size(845, 523);
            this.crvRptEdo.TabIndex = 2;
            this.crvRptEdo.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmCryReciboPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 523);
            this.Controls.Add(this.crvRptEdo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCryReciboPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Recibo de Pago";
            this.Load += new System.EventHandler(this.frmCryReciboPago_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvRptEdo;
    }
}