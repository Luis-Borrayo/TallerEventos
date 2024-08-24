namespace TallerEventos
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
            txtNombreTarea = new TextBox();
            flypListaTareas = new FlowLayoutPanel();
            flypTareasEnProgreso = new FlowLayoutPanel();
            flypTareasCompletas = new FlowLayoutPanel();
            lblTareasinempezar = new Label();
            lblTareaProgreso = new Label();
            lblTareasCompletas = new Label();
            CBoxEstadosTareas = new ComboBox();
            SuspendLayout();
            // 
            // txtNombreTarea
            // 
            txtNombreTarea.Location = new Point(449, 60);
            txtNombreTarea.Name = "txtNombreTarea";
            txtNombreTarea.PlaceholderText = "Ingrese su tarea";
            txtNombreTarea.Size = new Size(309, 27);
            txtNombreTarea.TabIndex = 0;
            txtNombreTarea.TextChanged += TxtNombreTarea_TextChanged;
            // 
            // flypListaTareas
            // 
            flypListaTareas.Location = new Point(22, 184);
            flypListaTareas.Name = "flypListaTareas";
            flypListaTareas.Size = new Size(328, 480);
            flypListaTareas.TabIndex = 2;
            // 
            // flypTareasEnProgreso
            // 
            flypTareasEnProgreso.Location = new Point(384, 184);
            flypTareasEnProgreso.Name = "flypTareasEnProgreso";
            flypTareasEnProgreso.Size = new Size(328, 480);
            flypTareasEnProgreso.TabIndex = 4;
            // 
            // flypTareasCompletas
            // 
            flypTareasCompletas.Location = new Point(751, 184);
            flypTareasCompletas.Name = "flypTareasCompletas";
            flypTareasCompletas.Size = new Size(328, 480);
            flypTareasCompletas.TabIndex = 5;
            // 
            // lblTareasinempezar
            // 
            lblTareasinempezar.AutoSize = true;
            lblTareasinempezar.Location = new Point(104, 138);
            lblTareasinempezar.Name = "lblTareasinempezar";
            lblTareasinempezar.Size = new Size(137, 20);
            lblTareasinempezar.TabIndex = 6;
            lblTareasinempezar.Text = "Tareas sin empezar:";
            // 
            // lblTareaProgreso
            // 
            lblTareaProgreso.AutoSize = true;
            lblTareaProgreso.Location = new Point(489, 138);
            lblTareaProgreso.Name = "lblTareaProgreso";
            lblTareaProgreso.Size = new Size(136, 20);
            lblTareaProgreso.TabIndex = 7;
            lblTareaProgreso.Text = "Tareas en Progreso:";
            // 
            // lblTareasCompletas
            // 
            lblTareasCompletas.AutoSize = true;
            lblTareasCompletas.Location = new Point(841, 138);
            lblTareasCompletas.Name = "lblTareasCompletas";
            lblTareasCompletas.Size = new Size(142, 20);
            lblTareasCompletas.TabIndex = 8;
            lblTareasCompletas.Text = "Tareas Completadas";
            // 
            // CBoxEstadosTareas
            // 
            CBoxEstadosTareas.FormattingEnabled = true;
            CBoxEstadosTareas.Items.AddRange(new object[] { "Tarea sin Empezar", "Tarea en Proceso", "Tarea Completada" });
            CBoxEstadosTareas.Location = new Point(277, 60);
            CBoxEstadosTareas.Name = "CBoxEstadosTareas";
            CBoxEstadosTareas.Size = new Size(151, 28);
            CBoxEstadosTareas.TabIndex = 9;
            CBoxEstadosTareas.SelectedIndexChanged += CBoxEstadosTareas_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 713);
            Controls.Add(CBoxEstadosTareas);
            Controls.Add(lblTareasCompletas);
            Controls.Add(lblTareaProgreso);
            Controls.Add(lblTareasinempezar);
            Controls.Add(flypTareasCompletas);
            Controls.Add(flypTareasEnProgreso);
            Controls.Add(flypListaTareas);
            Controls.Add(txtNombreTarea);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreTarea;
        private FlowLayoutPanel flypListaTareas;
        private FlowLayoutPanel flypTareasEnProgreso;
        private FlowLayoutPanel flypTareasCompletas;
        private Label lblTareasinempezar;
        private Label lblTareaProgreso;
        private Label lblTareasCompletas;
        private ComboBox CBoxEstadosTareas;
    }
}
