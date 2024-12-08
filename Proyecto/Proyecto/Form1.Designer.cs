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
            this.nuevoArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.numericUpDownThickness = new System.Windows.Forms.NumericUpDown();
            this.pic_color = new System.Windows.Forms.Button();
            this.BtnLineWidth3 = new System.Windows.Forms.Button();
            this.BtnLineWidth2 = new System.Windows.Forms.Button();
            this.btnRehacer = new System.Windows.Forms.Button();
            this.btnDeshacer = new System.Windows.Forms.Button();
            this.picker = new System.Windows.Forms.PictureBox();
            this.BtnLine = new System.Windows.Forms.Button();
            this.BtnSquare = new System.Windows.Forms.Button();
            this.BtnColorSet = new System.Windows.Forms.Button();
            this.BtnLineWidth1 = new System.Windows.Forms.Button();
            this.BtnPentagono = new System.Windows.Forms.Button();
            this.BtnParalelogramo = new System.Windows.Forms.Button();
            this.BtnStair = new System.Windows.Forms.Button();
            this.BtnCircle = new System.Windows.Forms.Button();
            this.rellenar = new System.Windows.Forms.Button();
            this.BtnEraser = new System.Windows.Forms.Button();
            this.BtnPencil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PinTitle.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1898, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoArchivoToolStripMenuItem,
            this.cargarArchivoToolStripMenuItem,
            this.guardarArchivoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(88, 30);
            this.archivoToolStripMenuItem.Text = "Archivo";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // nuevoArchivoToolStripMenuItem
            // 
            this.nuevoArchivoToolStripMenuItem.Name = "nuevoArchivoToolStripMenuItem";
            this.nuevoArchivoToolStripMenuItem.Size = new System.Drawing.Size(242, 34);
            this.nuevoArchivoToolStripMenuItem.Text = "Nuevo Archivo";
            this.nuevoArchivoToolStripMenuItem.Click += new System.EventHandler(this.nuevoArchivoToolStripMenuItem_Click);
            // 
            // cargarArchivoToolStripMenuItem
            // 
            this.cargarArchivoToolStripMenuItem.Name = "cargarArchivoToolStripMenuItem";
            this.cargarArchivoToolStripMenuItem.Size = new System.Drawing.Size(242, 34);
            this.cargarArchivoToolStripMenuItem.Text = "Cargar Archivo";
            this.cargarArchivoToolStripMenuItem.Click += new System.EventHandler(this.cargarArchivoToolStripMenuItem_Click);
            // 
            // guardarArchivoToolStripMenuItem
            // 
            this.guardarArchivoToolStripMenuItem.Name = "guardarArchivoToolStripMenuItem";
            this.guardarArchivoToolStripMenuItem.Size = new System.Drawing.Size(242, 34);
            this.guardarArchivoToolStripMenuItem.Text = "Guardar Archivo";
            this.guardarArchivoToolStripMenuItem.Click += new System.EventHandler(this.guardarArchivoToolStripMenuItem_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefresh.Location = new System.Drawing.Point(315, 38);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(73, 55);
            this.BtnRefresh.TabIndex = 33;
            this.BtnRefresh.Text = "Limpiar";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // numericUpDownThickness
            // 
            this.numericUpDownThickness.Location = new System.Drawing.Point(1152, 56);
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
            // pic_color
            // 
            this.pic_color.BackColor = System.Drawing.Color.Black;
            this.pic_color.Location = new System.Drawing.Point(1382, 38);
            this.pic_color.Name = "pic_color";
            this.pic_color.Size = new System.Drawing.Size(60, 50);
            this.pic_color.TabIndex = 1;
            this.pic_color.UseVisualStyleBackColor = false;
            this.pic_color.Click += new System.EventHandler(this.pic_color_Click);
            // 
            // BtnLineWidth3
            // 
            this.BtnLineWidth3.BackgroundImage = global::Proyecto.Properties.Resources.Line3;
            this.BtnLineWidth3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLineWidth3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLineWidth3.Location = new System.Drawing.Point(1270, 85);
            this.BtnLineWidth3.Name = "BtnLineWidth3";
            this.BtnLineWidth3.Size = new System.Drawing.Size(73, 22);
            this.BtnLineWidth3.TabIndex = 56;
            this.BtnLineWidth3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLineWidth3.UseVisualStyleBackColor = true;
            this.BtnLineWidth3.Click += new System.EventHandler(this.BtnLineWidth3_Click);
            // 
            // BtnLineWidth2
            // 
            this.BtnLineWidth2.BackgroundImage = global::Proyecto.Properties.Resources.Line2;
            this.BtnLineWidth2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLineWidth2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLineWidth2.Location = new System.Drawing.Point(1270, 57);
            this.BtnLineWidth2.Name = "BtnLineWidth2";
            this.BtnLineWidth2.Size = new System.Drawing.Size(73, 22);
            this.BtnLineWidth2.TabIndex = 55;
            this.BtnLineWidth2.UseVisualStyleBackColor = true;
            this.BtnLineWidth2.Click += new System.EventHandler(this.BtnLineWidth2_Click);
            // 
            // btnRehacer
            // 
            this.btnRehacer.BackgroundImage = global::Proyecto.Properties.Resources.rehacer;
            this.btnRehacer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRehacer.Location = new System.Drawing.Point(473, 38);
            this.btnRehacer.Name = "btnRehacer";
            this.btnRehacer.Size = new System.Drawing.Size(73, 55);
            this.btnRehacer.TabIndex = 53;
            this.btnRehacer.UseVisualStyleBackColor = true;
            this.btnRehacer.Click += new System.EventHandler(this.btnRehacer_Click);
            // 
            // btnDeshacer
            // 
            this.btnDeshacer.BackgroundImage = global::Proyecto.Properties.Resources.deshacer;
            this.btnDeshacer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeshacer.Location = new System.Drawing.Point(394, 38);
            this.btnDeshacer.Name = "btnDeshacer";
            this.btnDeshacer.Size = new System.Drawing.Size(73, 55);
            this.btnDeshacer.TabIndex = 52;
            this.btnDeshacer.UseVisualStyleBackColor = true;
            this.btnDeshacer.Click += new System.EventHandler(this.btnDeshacer_Click);
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
            this.picker.Click += new System.EventHandler(this.picker_Click);
            this.picker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picker_MouseClick);
            // 
            // BtnLine
            // 
            this.BtnLine.BackgroundImage = global::Proyecto.Properties.Resources.linea1;
            this.BtnLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLine.Location = new System.Drawing.Point(622, 38);
            this.BtnLine.Name = "BtnLine";
            this.BtnLine.Size = new System.Drawing.Size(73, 55);
            this.BtnLine.TabIndex = 31;
            this.BtnLine.UseVisualStyleBackColor = true;
            this.BtnLine.Click += new System.EventHandler(this.BtnLine_Click);
            // 
            // BtnSquare
            // 
            this.BtnSquare.BackgroundImage = global::Proyecto.Properties.Resources.rectangulo;
            this.BtnSquare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSquare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSquare.Location = new System.Drawing.Point(701, 38);
            this.BtnSquare.Name = "BtnSquare";
            this.BtnSquare.Size = new System.Drawing.Size(73, 55);
            this.BtnSquare.TabIndex = 30;
            this.BtnSquare.UseVisualStyleBackColor = true;
            this.BtnSquare.Click += new System.EventHandler(this.button29_Click);
            // 
            // BtnColorSet
            // 
            this.BtnColorSet.BackgroundImage = global::Proyecto.Properties.Resources.ColorSet;
            this.BtnColorSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnColorSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnColorSet.Location = new System.Drawing.Point(1782, 27);
            this.BtnColorSet.Name = "BtnColorSet";
            this.BtnColorSet.Size = new System.Drawing.Size(73, 66);
            this.BtnColorSet.TabIndex = 29;
            this.BtnColorSet.UseVisualStyleBackColor = true;
            this.BtnColorSet.Click += new System.EventHandler(this.BtnColorSet_Click);
            // 
            // BtnLineWidth1
            // 
            this.BtnLineWidth1.BackgroundImage = global::Proyecto.Properties.Resources.Line11;
            this.BtnLineWidth1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLineWidth1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLineWidth1.Location = new System.Drawing.Point(1270, 30);
            this.BtnLineWidth1.Name = "BtnLineWidth1";
            this.BtnLineWidth1.Size = new System.Drawing.Size(73, 22);
            this.BtnLineWidth1.TabIndex = 9;
            this.BtnLineWidth1.UseVisualStyleBackColor = true;
            this.BtnLineWidth1.Click += new System.EventHandler(this.BtnPencilWidth_Click);
            // 
            // BtnPentagono
            // 
            this.BtnPentagono.BackgroundImage = global::Proyecto.Properties.Resources.pentagono;
            this.BtnPentagono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPentagono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPentagono.Location = new System.Drawing.Point(1017, 38);
            this.BtnPentagono.Name = "BtnPentagono";
            this.BtnPentagono.Size = new System.Drawing.Size(73, 55);
            this.BtnPentagono.TabIndex = 8;
            this.BtnPentagono.UseVisualStyleBackColor = true;
            this.BtnPentagono.Click += new System.EventHandler(this.BtnPentagono_Click);
            // 
            // BtnParalelogramo
            // 
            this.BtnParalelogramo.BackgroundImage = global::Proyecto.Properties.Resources.triangulo;
            this.BtnParalelogramo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnParalelogramo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnParalelogramo.Location = new System.Drawing.Point(938, 38);
            this.BtnParalelogramo.Name = "BtnParalelogramo";
            this.BtnParalelogramo.Size = new System.Drawing.Size(73, 55);
            this.BtnParalelogramo.TabIndex = 7;
            this.BtnParalelogramo.UseVisualStyleBackColor = true;
            this.BtnParalelogramo.Click += new System.EventHandler(this.BtnParalelogramo_Click);
            // 
            // BtnStair
            // 
            this.BtnStair.BackgroundImage = global::Proyecto.Properties.Resources.estrella;
            this.BtnStair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnStair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStair.Location = new System.Drawing.Point(859, 38);
            this.BtnStair.Name = "BtnStair";
            this.BtnStair.Size = new System.Drawing.Size(73, 55);
            this.BtnStair.TabIndex = 6;
            this.BtnStair.UseVisualStyleBackColor = true;
            this.BtnStair.Click += new System.EventHandler(this.BtnStair_Click);
            // 
            // BtnCircle
            // 
            this.BtnCircle.BackgroundImage = global::Proyecto.Properties.Resources.circulo1;
            this.BtnCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnCircle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCircle.Location = new System.Drawing.Point(780, 38);
            this.BtnCircle.Name = "BtnCircle";
            this.BtnCircle.Size = new System.Drawing.Size(73, 55);
            this.BtnCircle.TabIndex = 5;
            this.BtnCircle.UseVisualStyleBackColor = true;
            this.BtnCircle.Click += new System.EventHandler(this.BtnCircle_Click);
            // 
            // rellenar
            // 
            this.rellenar.BackgroundImage = global::Proyecto.Properties.Resources.Fill;
            this.rellenar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rellenar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rellenar.Location = new System.Drawing.Point(171, 38);
            this.rellenar.Name = "rellenar";
            this.rellenar.Size = new System.Drawing.Size(73, 55);
            this.rellenar.TabIndex = 4;
            this.rellenar.UseVisualStyleBackColor = true;
            this.rellenar.Click += new System.EventHandler(this.rellenar_Click);
            // 
            // BtnEraser
            // 
            this.BtnEraser.BackgroundImage = global::Proyecto.Properties.Resources.borrador;
            this.BtnEraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEraser.Location = new System.Drawing.Point(92, 38);
            this.BtnEraser.Name = "BtnEraser";
            this.BtnEraser.Size = new System.Drawing.Size(73, 55);
            this.BtnEraser.TabIndex = 3;
            this.BtnEraser.UseVisualStyleBackColor = true;
            this.BtnEraser.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnPencil
            // 
            this.BtnPencil.BackgroundImage = global::Proyecto.Properties.Resources.pencil;
            this.BtnPencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPencil.Location = new System.Drawing.Point(13, 38);
            this.BtnPencil.Name = "BtnPencil";
            this.BtnPencil.Size = new System.Drawing.Size(73, 55);
            this.BtnPencil.TabIndex = 2;
            this.BtnPencil.UseVisualStyleBackColor = true;
            this.BtnPencil.Click += new System.EventHandler(this.BtnPencil_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1049);
            this.Controls.Add(this.BtnLineWidth3);
            this.Controls.Add(this.BtnLineWidth2);
            this.Controls.Add(this.pic_color);
            this.Controls.Add(this.numericUpDownThickness);
            this.Controls.Add(this.btnRehacer);
            this.Controls.Add(this.btnDeshacer);
            this.Controls.Add(this.picker);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnLine);
            this.Controls.Add(this.BtnSquare);
            this.Controls.Add(this.BtnColorSet);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button BtnColorSet;
        private System.Windows.Forms.Button BtnSquare;
        private System.Windows.Forms.Button BtnLine;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.PictureBox picker;
        private System.Windows.Forms.ToolStripMenuItem nuevoArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarArchivoToolStripMenuItem;
        private System.Windows.Forms.Button btnDeshacer;
        private System.Windows.Forms.Button btnRehacer;
        private System.Windows.Forms.NumericUpDown numericUpDownThickness;
        private System.Windows.Forms.ToolStripMenuItem guardarArchivoToolStripMenuItem;
        private System.Windows.Forms.Button pic_color;
        private System.Windows.Forms.Button BtnLineWidth2;
        private System.Windows.Forms.Button BtnLineWidth3;
    }
}

