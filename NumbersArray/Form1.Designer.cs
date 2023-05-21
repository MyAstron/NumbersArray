namespace NumbersArray
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.udLongArreglo = new System.Windows.Forms.DomainUpDown();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lvRessultado = new System.Windows.Forms.ListView();
            this.ms = new System.Windows.Forms.MenuStrip();
            this.msApp = new System.Windows.Forms.ToolStripMenuItem();
            this.msAppOrdenar = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msAppOrdenarMayor = new System.Windows.Forms.ToolStripMenuItem();
            this.msAppOrdenarMenor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.msAppBuscarEspecifico = new System.Windows.Forms.ToolStripMenuItem();
            this.msAppSumar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.msAppNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.msSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.gbResultados = new System.Windows.Forms.GroupBox();
            this.udBusqueda = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown3 = new System.Windows.Forms.DomainUpDown();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.ms.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.gbResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // udLongArreglo
            // 
            this.udLongArreglo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.udLongArreglo.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.udLongArreglo.Location = new System.Drawing.Point(6, 28);
            this.udLongArreglo.Name = "udLongArreglo";
            this.udLongArreglo.Size = new System.Drawing.Size(180, 29);
            this.udLongArreglo.TabIndex = 0;
            this.udLongArreglo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udLongArreglo.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerar.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerar.Location = new System.Drawing.Point(192, 29);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(174, 28);
            this.btnGenerar.TabIndex = 1;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lvRessultado
            // 
            this.lvRessultado.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lvRessultado.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvRessultado.Location = new System.Drawing.Point(12, 105);
            this.lvRessultado.Name = "lvRessultado";
            this.lvRessultado.Size = new System.Drawing.Size(372, 169);
            this.lvRessultado.TabIndex = 2;
            this.lvRessultado.UseCompatibleStateImageBehavior = false;
            // 
            // ms
            // 
            this.ms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msApp,
            this.msSalir});
            this.ms.Location = new System.Drawing.Point(0, 0);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(396, 24);
            this.ms.TabIndex = 4;
            this.ms.Text = "menuStrip1";
            // 
            // msApp
            // 
            this.msApp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msAppOrdenar,
            this.ordenarToolStripMenuItem,
            this.msAppSumar,
            this.toolStripSeparator1,
            this.msAppNuevo});
            this.msApp.Enabled = false;
            this.msApp.Name = "msApp";
            this.msApp.Size = new System.Drawing.Size(75, 20);
            this.msApp.Text = "Aplicacion";
            // 
            // msAppOrdenar
            // 
            this.msAppOrdenar.Name = "msAppOrdenar";
            this.msAppOrdenar.Size = new System.Drawing.Size(188, 22);
            this.msAppOrdenar.Text = "Ordenar (ascendente)";
            this.msAppOrdenar.Click += new System.EventHandler(this.msAppOrdenar_Click);
            // 
            // ordenarToolStripMenuItem
            // 
            this.ordenarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msAppOrdenarMayor,
            this.msAppOrdenarMenor,
            this.toolStripSeparator2,
            this.msAppBuscarEspecifico});
            this.ordenarToolStripMenuItem.Name = "ordenarToolStripMenuItem";
            this.ordenarToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.ordenarToolStripMenuItem.Text = "Buscar";
            // 
            // msAppOrdenarMayor
            // 
            this.msAppOrdenarMayor.Name = "msAppOrdenarMayor";
            this.msAppOrdenarMayor.Size = new System.Drawing.Size(174, 22);
            this.msAppOrdenarMayor.Text = "Numero Mayor";
            this.msAppOrdenarMayor.Click += new System.EventHandler(this.msAppOrdenarMayor_Click);
            // 
            // msAppOrdenarMenor
            // 
            this.msAppOrdenarMenor.Name = "msAppOrdenarMenor";
            this.msAppOrdenarMenor.Size = new System.Drawing.Size(174, 22);
            this.msAppOrdenarMenor.Text = "Numero Menor";
            this.msAppOrdenarMenor.Click += new System.EventHandler(this.msAppOrdenarMenor_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(171, 6);
            // 
            // msAppBuscarEspecifico
            // 
            this.msAppBuscarEspecifico.Name = "msAppBuscarEspecifico";
            this.msAppBuscarEspecifico.Size = new System.Drawing.Size(174, 22);
            this.msAppBuscarEspecifico.Text = "Numero Especifico";
            this.msAppBuscarEspecifico.Click += new System.EventHandler(this.msAppBuscarEspecifico_Click);
            // 
            // msAppSumar
            // 
            this.msAppSumar.Name = "msAppSumar";
            this.msAppSumar.Size = new System.Drawing.Size(188, 22);
            this.msAppSumar.Text = "Sumar (Tot.)";
            this.msAppSumar.Click += new System.EventHandler(this.msAppSumar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // msAppNuevo
            // 
            this.msAppNuevo.Name = "msAppNuevo";
            this.msAppNuevo.Size = new System.Drawing.Size(188, 22);
            this.msAppNuevo.Text = "Nuevo Arreglo";
            this.msAppNuevo.Click += new System.EventHandler(this.msAppNuevo_Click);
            // 
            // msSalir
            // 
            this.msSalir.Name = "msSalir";
            this.msSalir.Size = new System.Drawing.Size(41, 20);
            this.msSalir.Text = "Salir";
            this.msSalir.Click += new System.EventHandler(this.msSalir_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.gbResultados);
            this.gbDatos.Controls.Add(this.udLongArreglo);
            this.gbDatos.Controls.Add(this.btnGenerar);
            this.gbDatos.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbDatos.Location = new System.Drawing.Point(12, 27);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(372, 72);
            this.gbDatos.TabIndex = 5;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Escribe la Longitud que tendra el Arreglo";
            // 
            // gbResultados
            // 
            this.gbResultados.Controls.Add(this.udBusqueda);
            this.gbResultados.Controls.Add(this.domainUpDown3);
            this.gbResultados.Controls.Add(this.btnAyuda);
            this.gbResultados.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbResultados.Location = new System.Drawing.Point(0, 0);
            this.gbResultados.Name = "gbResultados";
            this.gbResultados.Size = new System.Drawing.Size(372, 72);
            this.gbResultados.TabIndex = 6;
            this.gbResultados.TabStop = false;
            this.gbResultados.Text = "Escribe la Posicion del Numero";
            this.gbResultados.Visible = false;
            // 
            // udBusqueda
            // 
            this.udBusqueda.Location = new System.Drawing.Point(6, 28);
            this.udBusqueda.Name = "udBusqueda";
            this.udBusqueda.Size = new System.Drawing.Size(180, 29);
            this.udBusqueda.TabIndex = 3;
            this.udBusqueda.Text = "0";
            this.udBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udBusqueda.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // domainUpDown3
            // 
            this.domainUpDown3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.domainUpDown3.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.domainUpDown3.Location = new System.Drawing.Point(6, 28);
            this.domainUpDown3.Name = "domainUpDown3";
            this.domainUpDown3.Size = new System.Drawing.Size(180, 29);
            this.domainUpDown3.TabIndex = 0;
            this.domainUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.domainUpDown3.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAyuda.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAyuda.Location = new System.Drawing.Point(192, 29);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(174, 28);
            this.btnAyuda.TabIndex = 1;
            this.btnAyuda.Text = "Buscar";
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(396, 283);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.lvRessultado);
            this.Controls.Add(this.ms);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ms;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..:: Arreglos - Numeros ::..";
            this.ms.ResumeLayout(false);
            this.ms.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbResultados.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox gbDatos;
        private DomainUpDown domainUpDown1;
        private Button button1;
        private DomainUpDown udLongArreglo;
        private Button btnGenerar;
        private ListView lvRessultado;
        private MenuStrip ms;
        private ToolStripMenuItem msApp;
        private ToolStripMenuItem ordenarToolStripMenuItem;
        private ToolStripMenuItem msAppSumar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem msAppNuevo;
        private ToolStripMenuItem msSalir;
        private ToolStripMenuItem msAppOrdenarMayor;
        private ToolStripMenuItem msAppOrdenarMenor;
        private GroupBox gbResultados;
        private DomainUpDown domainUpDown3;
        private Button btnAyuda;
        private ToolStripMenuItem msAppOrdenar;
        private ToolStripMenuItem msAppBuscarEspecifico;
        private ToolStripSeparator toolStripSeparator2;
        private DomainUpDown udBusqueda;
    }
}