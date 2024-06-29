namespace DesafioOakTecnologia
{
    public partial class Main : Form
    {
        private List<Register> _listaDeCadastro = new();

        public Main()
        {
            // chamada padr�o que inicializa os componentes
            InitializeComponent();
            // inicializa algumas propriedades da lista
            InitializeListView();
            // inicializa as propriedades dos labels vazias
            InitializeLabels();
        }

        private void InitializeListView()
        {
            // faz o dock preencher o painel
            ListView_Register.Dock = DockStyle.Fill;

            // faz o view mostrar os detalhes
            ListView_Register.View = View.Details;
            // seleciona itens e subitens quando a sele��o � feita
            ListView_Register.FullRowSelect = true;
            // mostra grid lines.
            ListView_Register.GridLines = true;

            // cria colunas para os itens e subitens
            ListView_Register.Columns.Add("Nome", 300, HorizontalAlignment.Left);
            ListView_Register.Columns.Add("Valor", 200, HorizontalAlignment.Left);

        }

        private void InitializeLabels()
        {
            Label_NameValue.Text = string.Empty;
            Label_DescriptionValue.Text = string.Empty;
            Label_PriceValue.Text = string.Empty;
            Label_AvaliableValue.Text = string.Empty;
        }

        //
        private void RefreshListView()
        {
            ListView_Register.Items.Clear();
            // para cada registro na lista de registro � registrado um nome como subitem
            //
            foreach (var register in _listaDeCadastro)
            {
                ListViewItem item = new ListViewItem(register.Name);
                item.SubItems.Add(register.Price.ToString());
                ListView_Register.Items.Add(item);
            }
        }

        // fun��o para mostrar os detalhes
        private void ShowItemDetails(Register register)
        {
            Label_NameValue.Text = register.Name;
            Label_DescriptionValue.Text = register.Description;
            // converte para string pois price � uma double
            Label_PriceValue.Text = register.Price.ToString();
            // se o checkbox estiver dispon�vel escreve sim, se n�o, n�o
            if(register.Available)
            {
                Label_AvaliableValue.Text = "Sim";
            } else
            {
                Label_AvaliableValue.Text = "N�o";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // name � o valor escrito pelo usu�rio
            string name = TextBox_Name.Text;

            // condi��o de erro caso o usu�rio tente escrever nomes iguais
            if (_listaDeCadastro.Exists(o => o.Name == TextBox_Name.Text)) {
                MessageBox.Show("A lista n�o pode conter nomes iguais", "Erro", MessageBoxButtons.OK);
                return;
            }
            // condi��o de erro caso o usu�rio n�o escreva o nome
            if(name == string.Empty)
            {
                MessageBox.Show("O nome n�o pode ser nulo", "Erro", MessageBoxButtons.OK);
                return;
            }
            // description � o valor escrito pelo usu�rio
            string description = TextBox_Description.Text;

            double price;
            try
            {
                price = double.Parse(TextBox_Price.Text);
            }
            catch
            {
                MessageBox.Show("Valor Inv�lido", "Erro", MessageBoxButtons.OK);
                return;
            }
            // available � dado pelo usu�rio
            bool available = Check_AddAvailable.Checked;

            // depois de receber todas as informa��es necess�rias, faz um cadastro
            Register cadastro = new Register(name, description, price, available);
            // adiciona o cadastro na lista
            _listaDeCadastro.Add(cadastro);
            // ordena o cadastro
            _listaDeCadastro = _listaDeCadastro.OrderBy(o => o.Price).ToList();
            RefreshListView();
        }

        private void listViewCadastro_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in ListView_Register.SelectedItems)
            {
                Register cadastro = _listaDeCadastro.Find(o => o.Name == item.Text);
                if (cadastro != null) {
                    ShowItemDetails(cadastro);
                }
            }
        }
    }
}
