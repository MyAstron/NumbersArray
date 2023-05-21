namespace NumbersArray
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        int Longitud = 0, Num_Busqueda = 0;
        int[] Arreglo = new int[] { };

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Longitud = Convert.ToInt32(udLongArreglo.Text);
            Arreglo = new int[Longitud];
            lvRessultado.Items.Clear();
            Random obj_rnd = new Random();
            for (int i = 0; i < Arreglo.Length; i++)
            {
                Arreglo[i] = obj_rnd.Next(10)+1;
                lvRessultado.Items.Add((Arreglo[i])+"");
            }
            msApp.Enabled = true;
            gbDatos.Enabled = false;
        }

        private void msAppOrdenarMayor_Click(object sender, EventArgs e)
        {
            if (msAppOrdenarMayor.Checked)
            {
                msAppOrdenarMayor.Checked = false;
                if (msAppOrdenarMenor.Checked)
                    msAppOrdenarMenor.Checked = false;
                lvRessultado.Items.Clear();
                for (int i = 0; i < Arreglo.Length; i++)
                    lvRessultado.Items.Add(Arreglo[i] + "");
            }
            else
            {
                msAppOrdenarMayor.Checked = true;
                int Num_Mayor = Arreglo[0];
                for (int i = 0; i < Arreglo.Length; i++)
                {
                    if (Arreglo[i] > Num_Mayor)
                        Num_Mayor = Arreglo[i];
                }
                if (!msAppOrdenarMenor.Checked)
                    lvRessultado.Items.Clear();
                lvRessultado.Items.Add("Mayor: " + Num_Mayor);
            }
        }

        private void msAppOrdenarMenor_Click(object sender, EventArgs e)
        {
            if (msAppOrdenarMenor.Checked)
            {
                msAppOrdenarMenor.Checked = false;
                if (msAppOrdenarMayor.Checked)
                    msAppOrdenarMayor.Checked = false;
                lvRessultado.Items.Clear();
                for (int i = 0; i < Arreglo.Length; i++)
                    lvRessultado.Items.Add(Arreglo[i] + "");
            }
            else
            {
                msAppOrdenarMenor.Checked = true;
                int Num_Menor = Arreglo[0];
                for (int i = 0; i < Arreglo.Length; i++)
                {
                    if (Arreglo[i] < Num_Menor)
                        Num_Menor = Arreglo[i];
                }
                if (!msAppOrdenarMayor.Checked)
                    lvRessultado.Items.Clear();
                lvRessultado.Items.Add("Menor: " + Num_Menor);
            }
        }

        private void msAppSumar_Click(object sender, EventArgs e)
        {
            if (msAppSumar.Checked)
            {
                msAppSumar.Checked = false;
                lvRessultado.Items.Clear();
                for (int i = 0; i < Arreglo.Length; i++)
                    lvRessultado.Items.Add(Arreglo[i] + "");
            }
            else
            {
                msAppSumar.Checked = true;
                lvRessultado.Items.Clear();
                lvRessultado.Items.Add("Suma (Tot):");
                int suma = 0;
                for (int i = 0; i < Arreglo.Length; i++)
                    suma += Arreglo[i];
                lvRessultado.Items.Add(suma + "");
            }
        }

        private void msAppNuevo_Click(object sender, EventArgs e)
        {
            lvRessultado.Items.Clear();
            gbDatos.Enabled = true;
            udLongArreglo.Text = string.Empty;
            gbResultados.Visible = false;
            msAppBuscarEspecifico.Checked = false;
            msApp.Enabled = false;
            msAppOrdenar.Enabled = true;
            msAppOrdenar.Checked = false;
        }

        private void msAppOrdenar_Click(object sender, EventArgs e)
        {
            int cambio;
            msAppOrdenar.Checked = true;
            msAppOrdenar.Enabled = false;
            for (int i = 0; i < Arreglo.Length; i++)
                for (int j = 0; j < Arreglo.Length-1; j++)
                    if (Arreglo[j] > Arreglo[j+1])
                    {
                        cambio = Arreglo[j];
                        Arreglo[j] = Arreglo[j + 1];
                        Arreglo[j+1] = cambio;
                    }
            lvRessultado.Items.Clear();
            for (int i = 0; i < Arreglo.Length; i++)
            lvRessultado.Items.Add(Arreglo[i]+"");
        }

        private void msAppBuscarEspecifico_Click(object sender, EventArgs e)
        {
            
            if (msAppBuscarEspecifico.Checked)
            {
                msAppBuscarEspecifico.Checked = false;
                gbResultados.Visible = false;
                gbDatos.Enabled = false;
            }
            else 
            { 
                gbDatos.Enabled = true;
                msAppBuscarEspecifico.Checked = true;
                gbResultados.Visible = true;
            }
            lvRessultado.Items.Clear();
            for (int i = 0; i < Arreglo.Length; i++)
                lvRessultado.Items.Add(Arreglo[i] + "");
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Num_Busqueda = Convert.ToInt32(udBusqueda.Text)-1;
            if (Num_Busqueda > 0)
                for (int i = 0; i < Arreglo.Length; i++)
                    if (i == Num_Busqueda)
                    {
                        lvRessultado.Items.Clear();
                        lvRessultado.Items.Add("Numero:");
                        lvRessultado.Items.Add(Arreglo[i] + "");
                    }
        }

        private void msSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}