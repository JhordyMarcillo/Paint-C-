namespace Proyecto
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
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.PinTitle = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnPencil = new System.Windows.Forms.Button();
            this.BtnEraser = new System.Windows.Forms.Button();
            this.rellenar = new System.Windows.Forms.Button();
            this.BtnCircle = new System.Windows.Forms.Button();
            this.BtnStair = new System.Windows.Forms.Button();
            this.BtnParalelogramo = new System.Windows.Forms.Button();
            this.BtnPentagono = new System.Windows.Forms.Button();
            this.BtnLineWidth1 = new System.Windows.Forms.Button();
            this.BtnLineWidth2 = new System.Windows.Forms.Button();
            this.BtnLineWidth3 = new System.Windows.Forms.Button();
            this.BtnColorSet = new System.Windows.Forms.Button();
            this.BtnSquare = new System.Windows.Forms.Button();
            this.BtnLine = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.picker = new System.Windows.Forms.PictureBox();
            this.PenColor = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nuevoArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeshacer = new System.Windows.Forms.Button();
            this.btnRehacer = new System.Windows.Forms.Button();
            this.numericUpDownThickness = new System.Windows.Forms.NumericUpDown();
            this.PinTitle.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PenColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThickness)).BeginInit();
            this.SuspendLayout();
            // 
            // fontDialog1
            // 
            this.fontDialog1.ShowColor = true;
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // PinTitle
            // 
            this.PinTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PinTitle.Controls.Add(this.menuStrip1);
            this.PinTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PinTitle.Location = new System.Drawing.Point(0, 0);
            this.PinTitle.Name = "PinTitle";
            this.PinTitle.Size = new System.Drawing.Size(1898, 31);
            this.PinTitle.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1898, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoArchivoToolStripMenuItem,
            this.cargarArchivoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.archivoToolStripMenuItem.Text = "Archivo";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // BtnPencil
            // 
            this.BtnPencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPencil.Location = new System.Drawing.Point(13, 38);
            this.BtnPencil.Name = "BtnPencil";
            this.BtnPencil.Size = new System.Drawing.Size(73, 55);
            this.BtnPencil.TabIndex = 2;
            this.BtnPencil.Text = "Lapiz";
            this.BtnPencil.UseVisualStyleBackColor = true;
            this.BtnPencil.Click += new System.EventHandler(this.BtnPencil_Click);
            // 
            // BtnEraser
            // 
            this.BtnEraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEraser.Location = new System.Drawing.Point(92, 38);
            this.BtnEraser.Name = "BtnEraser";
            this.BtnEraser.Size = new System.Drawing.Size(73, 55);
            this.BtnEraser.TabIndex = 3;
            this.BtnEraser.Text = "Borrador";
            this.BtnEraser.UseVisualStyleBackColor = true;
            this.BtnEraser.Click += new System.EventHandler(this.button2_Click);
            // 
            // rellenar
            // 
            this.rellenar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rellenar.Location = new System.Drawing.Point(171, 38);
            this.rellenar.Name = "rellenar";
            this.rellenar.Size = new System.Drawing.Size(73, 55);
            this.rellenar.TabIndex = 4;
            this.rellenar.Text = "BtnFill";
            this.rellenar.UseVisualStyleBackColor = true;
            this.rellenar.Click += new System.EventHandler(this.rellenar_Click);
            // 
            // BtnCircle
            // 
            this.BtnCircle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCircle.Location = new System.Drawing.Point(751, 39);
            this.BtnCircle.Name = "BtnCircle";
            this.BtnCircle.Size = new System.Drawing.Size(73, 55);
            this.BtnCircle.TabIndex = 5;
            this.BtnCircle.Text = "Circulo";
            this.BtnCircle.UseVisualStyleBackColor = true;
            this.BtnCircle.Click += new System.EventHandler(this.BtnCircle_Click);
            // 
            // BtnStair
            // 
            this.BtnStair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStair.Location = new System.Drawing.Point(830, 39);
            this.BtnStair.Name = "BtnStair";
            this.BtnStair.Size = new System.Drawing.Size(73, 55);
            this.BtnStair.TabIndex = 6;
            this.BtnStair.Text = "Estrella";
            this.BtnStair.UseVisualStyleBackColor = true;
            // 
            // BtnParalelogramo
            // 
            this.BtnParalelogramo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnParalelogramo.Location = new System.Drawing.Point(909, 39);
            this.BtnParalelogramo.Name = "BtnParalelogramo";
            this.BtnParalelogramo.Size = new System.Drawing.Size(73, 55);
            this.BtnParalelogramo.TabIndex = 7;
            this.BtnParalelogramo.Text = "Paralelogramo";
            this.BtnParalelogramo.UseVisualStyleBackColor = true;
            // 
            // BtnPentagono
            // 
            this.BtnPentagono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPentagono.Location = new System.Drawing.Point(988, 38);
            this.BtnPentagono.Name = "BtnPentagono";
            this.BtnPentagono.Size = new System.Drawing.Size(73, 55);
            this.BtnPentagono.TabIndex = 8;
            this.BtnPentagono.Text = "Pentagono";
            this.BtnPentagono.UseVisualStyleBackColor = true;
            // 
            // BtnLineWidth1
            // 
            this.BtnLineWidth1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLineWidth1.Location = new System.Drawing.Point(1206, 29);
            this.BtnLineWidth1.Name = "BtnLineWidth1";
            this.BtnLineWidth1.Size = new System.Drawing.Size(73, 22);
            this.BtnLineWidth1.TabIndex = 9;
            this.BtnLineWidth1.Text = "-------";
            this.BtnLineWidth1.UseVisualStyleBackColor = true;
            this.BtnLineWidth1.Click += new System.EventHandler(this.BtnPencilWidth_Click);
            // 
            // BtnLineWidth2
            // 
            this.BtnLineWidth2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLineWidth2.Location = new System.Drawing.Point(1206, 55);
            this.BtnLineWidth2.Name = "BtnLineWidth2";
            this.BtnLineWidth2.Size = new System.Drawing.Size(73, 22);
            this.BtnLineWidth2.TabIndex = 10;
            this.BtnLineWidth2.Text = "=====";
            this.BtnLineWidth2.UseVisualStyleBackColor = true;
            this.BtnLineWidth2.Click += new System.EventHandler(this.BtnPencilWidth_Click);
            // 
            // BtnLineWidth3
            // 
            this.BtnLineWidth3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLineWidth3.Location = new System.Drawing.Point(1206, 83);
            this.BtnLineWidth3.Name = "BtnLineWidth3";
            this.BtnLineWidth3.Size = new System.Drawing.Size(73, 22);
            this.BtnLineWidth3.TabIndex = 11;
            this.BtnLineWidth3.Text = "=-=-=-";
            this.BtnLineWidth3.UseVisualStyleBackColor = true;
            this.BtnLineWidth3.Click += new System.EventHandler(this.BtnPencilWidth_Click);
            // 
            // BtnColorSet
            // 
            this.BtnColorSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnColorSet.Location = new System.Drawing.Point(1782, 27);
            this.BtnColorSet.Name = "BtnColorSet";
            this.BtnColorSet.Size = new System.Drawing.Size(73, 66);
            this.BtnColorSet.TabIndex = 29;
            this.BtnColorSet.Text = "ColorSet";
            this.BtnColorSet.UseVisualStyleBackColor = true;
            this.BtnColorSet.Click += new System.EventHandler(this.BtnColorSet_Click);
            // 
            // BtnSquare
            // 
            this.BtnSquare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSquare.Location = new System.Drawing.Point(672, 40);
            this.BtnSquare.Name = "BtnSquare";
            this.BtnSquare.Size = new System.Drawing.Size(73, 55);
            this.BtnSquare.TabIndex = 30;
            this.BtnSquare.Text = "Cuadrado";
            this.BtnSquare.UseVisualStyleBackColor = true;
            this.BtnSquare.Click += new System.EventHandler(this.button29_Click);
            // 
            // BtnLine
            // 
            this.BtnLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLine.Location = new System.Drawing.Point(593, 40);
            this.BtnLine.Name = "BtnLine";
            this.BtnLine.Size = new System.Drawing.Size(73, 55);
            this.BtnLine.TabIndex = 31;
            this.BtnLine.Text = "Linea";
            this.BtnLine.UseVisualStyleBackColor = true;
            this.BtnLine.Click += new System.EventHandler(this.BtnLine_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.Location = new System.Drawing.Point(357, 40);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(73, 55);
            this.BtnSave.TabIndex = 32;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefresh.Location = new System.Drawing.Point(436, 40);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(73, 55);
            this.BtnRefresh.TabIndex = 33;
            this.BtnRefresh.Text = "Limpiar";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // picker
            // 
            this.picker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picker.Image = global::Proyecto.Properties.Resources.picker;
            this.picker.Location = new System.Drawing.Point(1468, 14);
            this.picker.Name = "picker";
            this.picker.Size = new System.Drawing.Size(308, 91);
            this.picker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picker.TabIndex = 51;
            this.picker.TabStop = false;
            this.picker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picker_MouseClick);
            // 
            // PenColor
            // 
            this.PenColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PenColor.Location = new System.Drawing.Point(1389, 29);
            this.PenColor.Name = "PenColor";
            this.PenColor.Size = new System.Drawing.Size(73, 64);
            this.PenColor.TabIndex = 34;
            this.PenColor.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(25, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1873, 936);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // nuevoArchivoToolStripMenuItem
            // 
            this.nuevoArchivoToolStripMenuItem.Name = "nuevoArchivoToolStripMenuItem";
            this.nuevoArchivoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.nuevoArchivoToolStripMenuItem.Text = "Nuevo Archivo";
            this.nuevoArchivoToolStripMenuItem.Click += new System.EventHandler(this.nuevoArchivoToolStripMenuItem_Click);
            // 
            // cargarArchivoToolStripMenuItem
            // 
            this.cargarArchivoToolStripMenuItem.Name = "cargarArchivoToolStripMenuItem";
            this.cargarArchivoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.cargarArchivoToolStripMenuItem.Text = "Cargar Archivo";
            this.cargarArchivoToolStripMenuItem.Click += new System.EventHandler(this.cargarArchivoToolStripMenuItem_Click);
            // 
            // btnDeshacer
            // 
            this.btnDeshacer.Location = new System.Drawing.Point(1080, 36);
            this.btnDeshacer.Name = "btnDeshacer";
            this.btnDeshacer.Size = new System.Drawing.Size(100, 29);
            this.btnDeshacer.TabIndex = 52;
            this.btnDeshacer.Text = "Deshacer";
            this.btnDeshacer.UseVisualStyleBackColor = true;
            this.btnDeshacer.Click += new System.EventHandler(this.btnDeshacer_Click);
            // 
            // btnRehacer
            // 
            this.btnRehacer.Location = new System.Drawing.Point(1080, 71);
            this.btnRehacer.Name = "btnRehacer";
            this.btnRehacer.Size = new System.Drawing.Size(100, 37);
            this.btnRehacer.TabIndex = 53;
            this.btnRehacer.Text = "Rehacer";
            this.btnRehacer.UseVisualStyleBackColor = true;
            this.btnRehacer.Click += new System.EventHandler(this.btnRehacer_Click);
            // 
            // numericUpDownThickness
            // 
            this.numericUpDownThickness.Location = new System.Drawing.Point(251, 55);
            this.numericUpDownThickness.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownThickness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownThickness.Name = "numericUpDownThickness";
            this.numericUpDownThickness.Size = new System.Drawing.Size(100, 26);
            this.numericUpDownThickness.TabIndex = 54;
            this.numericUpDownThickness.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownThickness.ValueChanged += new System.EventHandler(this.numericUpDownThickness_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1049);
            this.Controls.Add(this.numericUpDownThickness);
            this.Controls.Add(this.btnRehacer);
            this.Controls.Add(this.btnDeshacer);
            this.Controls.Add(this.picker);
            this.Controls.Add(this.PenColor);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnLine);
            this.Controls.Add(this.BtnSquare);
            this.Controls.Add(this.BtnColorSet);
            this.Controls.Add(this.BtnLineWidth3);
            this.Controls.Add(this.BtnLineWidth2);
            this.Controls.Add(this.BtnLineWidth1);
            this.Controls.Add(this.BtnPentagono);
            this.Controls.Add(this.BtnParalelogramo);
            this.Controls.Add(this.BtnStair);
            this.Controls.Add(this.BtnCircle);
            this.Controls.Add(this.rellenar);
            this.Controls.Add(this.BtnEraser);
            this.Controls.Add(this.BtnPencil);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PinTitle);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PinTitle.ResumeLayout(false);
            this.PinTitle.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PenColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThickness)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Panel PinTitle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnPencil;
        private System.Windows.Forms.Button BtnEraser;
        private System.Windows.Forms.Button rellenar;
        private System.Windows.Forms.Button BtnCircle;
        private System.Windows.Forms.Button BtnStair;
        private System.Windows.Forms.Button BtnParalelogramo;
        private System.Windows.Forms.Button BtnPentagono;
        private System.Windows.Forms.Button BtnLineWidth1;
        private System.Windows.Forms.Button BtnLineWidth2;
        private System.Windows.Forms.Button BtnLineWidth3;
        private System.Windows.Forms.Button BtnColorSet;
        private System.Windows.Forms.Button BtnSquare;
        private System.Windows.Forms.Button BtnLine;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.PictureBox PenColor;
        private System.Windows.Forms.PictureBox picker;
        private System.Windows.Forms.ToolStripMenuItem nuevoArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarArchivoToolStripMenuItem;
        private System.Windows.Forms.Button btnDeshacer;
        private System.Windows.Forms.Button btnRehacer;
        private System.Windows.Forms.NumericUpDown numericUpDownThickness;
    }
}

