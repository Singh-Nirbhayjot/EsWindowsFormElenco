namespace EsWindowsFormElenco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_aggiungi_Click(object sender, EventArgs e)
        {
            string agg;
            agg = txt_input.Text;      
            lst_elenco.Items.Add(agg);
        }
        private void btn_canc_Click(object sender, EventArgs e)
        {
            if (lst_elenco.Items.Count > 0)
            {
                lst_elenco.Items.RemoveAt(lst_elenco.Items.Count - 1);
                //ho fatto che elimina la stringa inserita precedentemente
                //non serviva ma l'ho aggiunto perchè mi piaceva e volevo sperimentare
            }
        }

        private void btn_elimina_Click(object sender, EventArgs e)
        {
            lst_elenco.Items.Clear();       //elimina tutto
        }
        private void txt_input_TextChanged(object sender, EventArgs e)
        {

        }
        private void lst_elenco_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
