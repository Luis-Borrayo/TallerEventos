using TallerEventos.Clases;

namespace TallerEventos
{
    public partial class Form1 : Form
    {
        List<Tarea> Tareas = new List<Tarea>();
        public Form1()
        {
            InitializeComponent();
            txtNombreTarea.KeyDown += new KeyEventHandler(TeclaEnter);
        }       
        private void RenderizarTareas()
        {
            flypTareasEnProgreso.Controls.Clear();
            flypTareasCompletas.Controls.Clear();
            flypListaTareas.Controls.Clear();
            foreach (Tarea tarea in Tareas)
            {
                Label tarjeta = new Label();
                tarjeta.Text = tarea.Nombre;
                tarjeta.AutoSize = true;
                tarjeta.Padding = new Padding(10);
                tarjeta.Margin = new Padding(5);
                tarjeta.BackColor = Color.White;
                tarjeta.ForeColor = Color.Black;
                tarjeta.BorderStyle = BorderStyle.FixedSingle;

                tarjeta.MouseHover += (sender, e) =>
                {
                    tarjeta.BackColor = Color.LightGray;
                    tarjeta.Font = new Font(tarjeta.Font, FontStyle.Bold);
                    tarjeta.Cursor = Cursors.Hand;
                };
                tarjeta.MouseLeave += (sender, e) =>
                {
                    tarjeta.BackColor = Color.White;
                    tarjeta.Font = new Font(tarjeta.Font, FontStyle.Regular);
                };
                tarjeta.DoubleClick += (sender, e) =>
                    {
                        Label borrarconclics = sender as Label;
                        if (borrarconclics != null)
                        {
                            Tarea SelecTareaEstados = Tareas.FirstOrDefault(lbltareadlista => lbltareadlista.Nombre == borrarconclics.Text);
                            if (SelecTareaEstados != null)
                            {
                                if (SelecTareaEstados.Estado == "Tarea en Proceso")
                                {
                                    SelecTareaEstados.Estado = "Tarea Completada";                                  
                                    
                                }
                                else if (SelecTareaEstados.Estado == "Tarea sin Empezar")
                                {
                                    SelecTareaEstados.Estado = "Tarea en Proceso";
                                }
                                else if (SelecTareaEstados.Estado == "Tarea Completada")
                                {
                                    Tareas.Remove(SelecTareaEstados);
                                }
                                this.RenderizarTareas();


                            }

                        }
                    };
                switch (tarea.Estado)
                {
                    case "Tarea sin Empezar":
                        flypListaTareas.Controls.Add(tarjeta);
                        break;
                    case "Tarea en Proceso":
                        flypTareasEnProgreso.Controls.Add(tarjeta);
                        break;
                    case "Tarea Completada":
                        flypTareasCompletas.Controls.Add(tarjeta);
                        break;
                }

            }

        }

        private void TxtNombreTarea_TextChanged(object sender, EventArgs e)
        {
        }

        private void TeclaEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtNombreTarea.Text.Trim() == "")
                {
                    MessageBox.Show("Se debe agregar un nombre para la tareea");
                    return;
                }
                string? EstadoTareas = CBoxEstadosTareas.SelectedItem != null ? CBoxEstadosTareas.SelectedItem.ToString() : "Tarea sin Empezar";
                Tarea nuevatarea = new Tarea(txtNombreTarea.Text, EstadoTareas);
                Tareas.Add(nuevatarea);
                this.RenderizarTareas();
                txtNombreTarea.Clear();
                e.SuppressKeyPress = true;
            }           
        }

        private void CBoxEstadosTareas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}