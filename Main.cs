namespace DesafioOakTecnologia
{
    public partial class Main : Form
    {
        private List<Register> _listaDeCadastro = new();

        public Main()
        {
            // chamada padrão que inicializa os componentes
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
            // seleciona itens e subitens quando a seleção é feita
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
            // para cada registro na lista de registro é registrado um nome como subitem
            //
            foreach (var register in _listaDeCadastro)
            {
                ListViewItem item = new ListViewItem(register.Name);
                item.SubItems.Add(register.Price.ToString());
                ListView_Register.Items.Add(item);
            }
        }

        // função para mostrar os detalhes
        private void ShowItemDetails(Register register)
        {
            Label_NameValue.Text = register.Name;
            Label_DescriptionValue.Text = register.Description;
            // converte para string pois price é uma double
            Label_PriceValue.Text = register.Price.ToString();
            // se o checkbox estiver disponível escreve sim, se não, não
            if(register.Available)
            {
                Label_AvaliableValue.Text = "Sim";
            } else
            {
                Label_AvaliableValue.Text = "Não";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // name é o valor escrito pelo usuário
            string name = TextBox_Name.Text;

            // condição de erro caso o usuário tente escrever nomes iguais
            if (_listaDeCadastro.Exists(o => o.Name == TextBox_Name.Text)) {
                MessageBox.Show("A lista não pode conter nomes iguais", "Erro", MessageBoxButtons.OK);
                return;
            }
            // condição de erro caso o usuário não escreva o nome
            if(name == string.Empty)
            {
                MessageBox.Show("O nome não pode ser nulo", "Erro", MessageBoxButtons.OK);
                return;
            }
            // description é o valor escrito pelo usuário
            string description = TextBox_Description.Text;

            double price;
            try
            {
                price = double.Parse(TextBox_Price.Text);
            }
            catch
            {
                MessageBox.Show("Valor Inválido", "Erro", MessageBoxButtons.OK);
                return;
            }
            // available é dado pelo usuário
            bool available = Check_AddAvailable.Checked;

            // depois de receber todas as informações necessárias, faz um cadastro
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
