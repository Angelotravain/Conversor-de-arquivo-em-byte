namespace ConversorByte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelecionarArquivo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arquivos de Texto|*.txt|Todos os Arquivos|*.*";
                openFileDialog.Title = "Selecione um arquivo";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtém o caminho do arquivo selecionado
                    string caminhoArquivo = openFileDialog.FileName;

                    // Atualiza o texto do campo txtArquivo
                    txtArquivo.Text = caminhoArquivo;
                }
            }
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            string caminhoArquivo = txtArquivo.Text;

            if (File.Exists(caminhoArquivo))
            {
                try
                {
                    // Lê o conteúdo do arquivo como bytes
                    byte[] arrayDeBytes = File.ReadAllBytes(caminhoArquivo);

                    // Converte o array de bytes para uma representação de string
                    string conteudoComoString = BitConverter.ToString(arrayDeBytes).Replace("-", " ");

                    // Atualiza o texto do campo txtSaida
                    txtSaida.Text = conteudoComoString;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao converter o arquivo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Arquivo não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conteudoComoString = txtSaida.Text;

            // Remove espaços em branco e converte de volta para um array de bytes
            byte[] arrayDeBytes = conteudoComoString.Split(' ')
                .Where(s => !string.IsNullOrWhiteSpace(s))
                .Select(s => Convert.ToByte(s, 16))
                .ToArray();

            // Exemplo: salva o array de bytes em um novo arquivo
            string novoCaminhoArquivo = "Caminho\\Para\\O\\Novo\\Arquivo.bin";

            try
            {
                // Salva os bytes em um novo arquivo
                File.WriteAllBytes(novoCaminhoArquivo, arrayDeBytes);

                MessageBox.Show($"Arquivo convertido com sucesso e salvo em: {novoCaminhoArquivo}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao converter e salvar o arquivo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText(txtSaida.Text);
        }
    }
}
