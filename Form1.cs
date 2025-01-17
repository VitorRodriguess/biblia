using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Windows.Forms.LinkLabel;

namespace biblia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int contador = 0;
            var textoInteiro = File.ReadAllLines("C:\\BIBLIAC#\\bíblia sagrada.txt", Encoding.GetEncoding("ISO-8859-1"));
            foreach (var linha in textoInteiro)
            {

                if (linha.Contains("Gênesis") == true && lstBoxLivros.Items.Contains("Gênesis") == false)
                {
                    lstBoxLivros.Items.Add("Gênesis");
                    contador++;
                  
                }
                else if (linha.Contains("Êxodo") == true && lstBoxLivros.Items.Contains("Êxodo") == false)
                {
                    lstBoxLivros.Items.Add("Êxodo");
                    contador++;
                   
                }
                else if (linha.Contains("Levítico") == true && lstBoxLivros.Items.Contains("Levítico") == false)
                {
                    lstBoxLivros.Items.Add("Levítico");
                    contador++;
                   

                }
                else if (linha.Contains("Números") == true && lstBoxLivros.Items.Contains("Números") == false)
                {
                    lstBoxLivros.Items.Add("Números");
                    contador++;
                   
                }
                else if (linha.Contains("Deuteronômio") == true && lstBoxLivros.Items.Contains("Deuteronômio") == false)
                {
                    lstBoxLivros.Items.Add("Deuteronômio");
                    contador++;
             
                }
                else if (linha.Contains("Josué") == true && lstBoxLivros.Items.Contains("Josué") == false)
                {
                    lstBoxLivros.Items.Add("Josué");
                    contador++;

                }
                else if (linha.Contains("Juízes") == true && lstBoxLivros.Items.Contains("Juízes") == false)
                {
                    lstBoxLivros.Items.Add("Juízes");
                    contador++;
                  
                }
                else if (linha.Contains("Rute") == true && lstBoxLivros.Items.Contains("Rute") == false)
                {
                    lstBoxLivros.Items.Add("Rute");
                    contador++;
                 
                }
                else if (linha.Contains("I Samuel") == true && lstBoxLivros.Items.Contains("I Samuel") == false)
                {
                    lstBoxLivros.Items.Add("I Samuel");
                    contador++;
                    
                }
                else if (linha.Contains("II Samuel") == true && lstBoxLivros.Items.Contains("II Samuel") == false)
                {
                    lstBoxLivros.Items.Add("II Samuel");
                    contador++;
                  
                }
                else if (linha.Contains("I Reis") == true && lstBoxLivros.Items.Contains("I Reis") == false)
                {
                    lstBoxLivros.Items.Add("I Reis");
                    contador++;
               
                }
                else if (linha.Contains("II Reis") == true && lstBoxLivros.Items.Contains("II Reis") == false)
                {
                    lstBoxLivros.Items.Add("II Reis");
                    contador++;
                  
                }
                else if (linha.Contains("I Crônicas") == true && lstBoxLivros.Items.Contains("I Crônicas") == false)
                {
                    lstBoxLivros.Items.Add("I Crônicas");
                    contador++;
            
                }
                else if (linha.Contains("II Crônicas") == true && lstBoxLivros.Items.Contains("II Crônicas") == false)
                {
                    lstBoxLivros.Items.Add("II Crônicas");
                    contador++;
            
                }
                else if (linha.Contains("Esdras") == true && lstBoxLivros.Items.Contains("Esdras") == false)
                {
                    lstBoxLivros.Items.Add("Esdras");
                    contador++;
                 
                }
                else if (linha.Contains("Neemias") == true && lstBoxLivros.Items.Contains("Neemias") == false)
                {
                    lstBoxLivros.Items.Add("Neemias");
                    contador++;
             
                }
                else if (linha.Contains("Ester") == true && lstBoxLivros.Items.Contains("Ester") == false)
                {
                    lstBoxLivros.Items.Add("Ester");
                    contador++;
            
                }
                else if (linha.Contains("Jó") == true && lstBoxLivros.Items.Contains("Jó") == false)
                {
                    lstBoxLivros.Items.Add("Jó");
                    contador++;
                    
                }
                else if (linha.Contains("Salmos") == true && lstBoxLivros.Items.Contains("Salmos") == false)
                {
                    lstBoxLivros.Items.Add("Salmos");
                    contador++;
                  
                }
                else if (linha.Contains("Provérbios") == true && lstBoxLivros.Items.Contains("Provérbios") == false)
                {
                    lstBoxLivros.Items.Add("Provérbios");
                    contador++;
                   
                }
                else if (linha.Contains("Eclesiastes") == true && lstBoxLivros.Items.Contains("Eclesiastes") == false)
                {
                    lstBoxLivros.Items.Add("Eclesiastes");
                    contador++;

                }
                else if (linha.Contains("Cântico dos Cânticos") == true && lstBoxLivros.Items.Contains("Cântico dos Cânticos") == false)
                {
                    lstBoxLivros.Items.Add("Cântico dos Cânticos");
                    contador++;
                    
                }
                else if (linha.Contains("Isaías") == true && lstBoxLivros.Items.Contains("Isaías") == false)
                {
                    lstBoxLivros.Items.Add("Isaías");
                    contador++;
                    
                }
                else if (linha.Contains("Jeremias") == true && lstBoxLivros.Items.Contains("Jeremias") == false)
                {
                    lstBoxLivros.Items.Add("Jeremias");
                    contador++;
                   
                }
                else if (linha.Contains("Lamentações de Jeremias") == true && lstBoxLivros.Items.Contains("Lamentações de Jeremias") == false)
                {
                    lstBoxLivros.Items.Add("Lamentações de Jeremias");
                    contador++;
                
                }
                else if (linha.Contains("Ezequiel") == true && lstBoxLivros.Items.Contains("Ezequiel") == false)
                {
                    lstBoxLivros.Items.Add("Ezequiel");
                    contador++;
                    
                }
                else if (linha.Contains("Daniel") == true && lstBoxLivros.Items.Contains("Daniel") == false)
                {
                    lstBoxLivros.Items.Add("Daniel");
                    contador++;
                 
                }
                else if (linha.Contains("Oséias") == true && lstBoxLivros.Items.Contains("Oséias") == false)
                {
                    lstBoxLivros.Items.Add("Oséias");
                    contador++;
                   
                }
                else if (linha.Contains("Joel") == true && lstBoxLivros.Items.Contains("Joel") == false)
                {
                    lstBoxLivros.Items.Add("Joel");
                    contador++;
                  
                }
                else if (linha.Contains("Amós") == true && lstBoxLivros.Items.Contains("Amós") == false)
                {
                    lstBoxLivros.Items.Add("Amós");
                    contador++;
                  
                }
                else if (linha.Contains("Obadias") == true && lstBoxLivros.Items.Contains("Obadias") == false)
                {
                    lstBoxLivros.Items.Add("Obadias");
                    contador++;
                  
                }
                else if (linha.Contains("Jonas") == true && lstBoxLivros.Items.Contains("Jonas") == false)
                {
                    lstBoxLivros.Items.Add("Jonas");
                    contador++;
                   
                }
                else if (linha.Contains("Miquéias") == true && lstBoxLivros.Items.Contains("Miquéias") == false)
                {
                    lstBoxLivros.Items.Add("Miquéias");
                    contador++;
                  
                }
                else if (linha.Contains("Naum") == true && lstBoxLivros.Items.Contains("Naum") == false)
                {
                    lstBoxLivros.Items.Add("Naum");
                    contador++;
                   
                }
                else if (linha.Contains("Habacuque") == true && lstBoxLivros.Items.Contains("Habacuque") == false)
                {
                    lstBoxLivros.Items.Add("Habacuque");
                    contador++;
                    
                }
                else if (linha.Contains("Sofonias") == true && lstBoxLivros.Items.Contains("Sofonias") == false)
                {
                    lstBoxLivros.Items.Add("Sofonias");
                    contador++;
                
                }
                else if (linha.Contains("Ageu") == true && lstBoxLivros.Items.Contains("Ageu") == false)
                {
                    lstBoxLivros.Items.Add("Ageu");
                    contador++;
                
                }
                else if (linha.Contains("Zacarias") == true && lstBoxLivros.Items.Contains("Zacarias") == false)
                {
                    lstBoxLivros.Items.Add("Zacarias");
                    contador++;
               
                }
                else if (linha.Contains("Malaquias") == true && lstBoxLivros.Items.Contains("Malaquias") == false)
                {
                    lstBoxLivros.Items.Add("Malaquias");
                    contador++;

                }
                else if (linha.Contains("Mateus") == true && lstBoxLivros.Items.Contains("Mateus") == false)
                {
                    // novo testamento
                    lstBoxLivros.Items.Add("Mateus");
                    contador++;
                 
                }
                else if (linha.Contains("Marcos") == true && lstBoxLivros.Items.Contains("Marcos") == false)
                {
                    lstBoxLivros.Items.Add("Marcos");
                    contador++;
                    
                }
                else if (linha.Contains("Lucas") == true && lstBoxLivros.Items.Contains("Lucas") == false)
                {
                    lstBoxLivros.Items.Add("Lucas");
                    contador++;
                  
                }
                else if (linha.Contains("João") == true && lstBoxLivros.Items.Contains("João") == false)
                {
                    lstBoxLivros.Items.Add("João");
                    contador++;
                  
                }
                else if (linha.Contains("Atos") == true && lstBoxLivros.Items.Contains("Atos") == false)
                {
                    lstBoxLivros.Items.Add("Atos");
                    contador++;
                  
                }
                else if (linha.Contains("Romanos") == true && lstBoxLivros.Items.Contains("Romanos") == false)
                {
                    lstBoxLivros.Items.Add("Romanos");
                    contador++;
                  
                }
                else if (linha.Contains("I Coríntios") == true && lstBoxLivros.Items.Contains("I Coríntios") == false)
                {
                    lstBoxLivros.Items.Add("I Coríntios");
                    contador++;
                 
                }
                else if (linha.Contains("II Coríntios") == true && lstBoxLivros.Items.Contains("II Coríntios") == false)
                {
                    lstBoxLivros.Items.Add("II Coríntios");
                    contador++;
                  
                }
                else if (linha.Contains("Gálatas") == true && lstBoxLivros.Items.Contains("Gálatas") == false)
                {
                    lstBoxLivros.Items.Add("Gálatas");
                    contador++;
                    
                }
                else if (linha.Contains("Efésios") == true && lstBoxLivros.Items.Contains("Efésios") == false)
                {
                    lstBoxLivros.Items.Add("Efésios");
                    contador++;
                    
                }
                else if (linha.Contains("Filipenses") == true && lstBoxLivros.Items.Contains("Filipenses") == false)
                {
                    lstBoxLivros.Items.Add("Filipenses");
                    contador++;
                
                }
                else if (linha.Contains("Colossenses") == true && lstBoxLivros.Items.Contains("Colossenses") == false)
                {
                    lstBoxLivros.Items.Add("Colossenses");
                    contador++;
                    
                }
                else if (linha.Contains("I Tessalonicenses") == true && lstBoxLivros.Items.Contains("I Tessalonicenses") == false)
                {
                    lstBoxLivros.Items.Add("I Tessalonicenses");
                    contador++;
                 
                }
                else if (linha.Contains("II Tessalonicenses") == true && lstBoxLivros.Items.Contains("II Tessalonicenses") == false)
                {
                    lstBoxLivros.Items.Add("II Tessalonicenses");
                    contador++;
               
                }
                else if (linha.Contains("I Timóteo") == true && lstBoxLivros.Items.Contains("I Timóteo") == false)
                {
                    lstBoxLivros.Items.Add("I Timóteo");
                    contador++;
                  
                }
                else if (linha.Contains("II Timóteo") == true && lstBoxLivros.Items.Contains("II Timóteo") == false)
                {
                    lstBoxLivros.Items.Add("II Timóteo");
                    contador++;
                   
                }
                else if (linha.Contains("Tito") == true && lstBoxLivros.Items.Contains("Tito") == false)
                {
                    lstBoxLivros.Items.Add("Tito");
                    contador++;
                    
                }
                else if (linha.Contains("Filemom") == true && lstBoxLivros.Items.Contains("Filemom") == false)
                {
                    lstBoxLivros.Items.Add("Filemom");
                    contador++;
                   
                }
                else if (linha.Contains("Hebreus") == true && lstBoxLivros.Items.Contains("Hebreus") == false)
                {
                    lstBoxLivros.Items.Add("Hebreus");
                    contador++;
                   
                }
                else if (linha.Contains("Tiago") == true && lstBoxLivros.Items.Contains("Tiago") == false)
                {
                    lstBoxLivros.Items.Add("Tiago");
                    contador++;
                   
                }
                else if (linha.Contains("I Pedro") == true && lstBoxLivros.Items.Contains("I Pedro") == false)
                {
                    lstBoxLivros.Items.Add("I Pedro");
                    contador++;
                   
                    
                }
                else if (linha.Contains("II Pedro") == true && lstBoxLivros.Items.Contains("II Pedro") == false)
                {
                    lstBoxLivros.Items.Add("II Pedro");
                    contador++;
                    
                }
                else if (linha.Contains("I João") == true && lstBoxLivros.Items.Contains("I João") == false)
                {
                    lstBoxLivros.Items.Add("I João");
                    contador++;
                   
                }
                else if (linha.Contains("II João") == true && lstBoxLivros.Items.Contains("II João") == false)
                {
                    lstBoxLivros.Items.Add("II João");
                    contador++;
                   
                }
                else if (linha.Contains("III João") == true && lstBoxLivros.Items.Contains("III João") == false)
                {
                    lstBoxLivros.Items.Add("III João");
                    contador++;
                   
                }
                else if (linha.Contains("Judas") == true && lstBoxLivros.Items.Contains("Judas") == false)
                {
                    lstBoxLivros.Items.Add("Judas");
                    contador++;
               
                }
         
                else if (linha.Contains("Apocalipse") == true && lstBoxLivros.Items.Contains("Apocalipse") == false)
                {
                    lstBoxLivros.Items.Add("Apocalipse");
                    contador++;
                }
                else if (contador == 66)
                {
                    return;
                }
            }
        }

        private void lstBoxLivros_SelectedIndexChanged(object sender, EventArgs e)
        {
            var textoInteiro = File.ReadAllLines("C:\\BIBLIAC#\\bíblia sagrada.txt", Encoding.GetEncoding("ISO-8859-1"));
            int CapituloNum = 1;
            lstBoxCapitulos.Items.Clear();
            foreach (var linha in textoInteiro)
            {
                int PosiçãoLivro = lstBoxLivros.SelectedIndex;
                string Capitulo = "»" + lstBoxLivros.Items[PosiçãoLivro].ToString().ToUpper() + $" [{CapituloNum}]";
                string Livro = lstBoxLivros.Items[PosiçãoLivro].ToString().ToUpper();
                if (linha.ToUpper().Trim().Contains(Capitulo) == true && lstBoxCapitulos.Items.Contains(Capitulo) == false)
                {

                    lstBoxCapitulos.Items.Add(linha.ToUpper());
                    CapituloNum++;

                }

            }
        }

        public void lstBoxCapitulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool SinalizadorVers = false;
            bool SinalizadorText = false;

            var textoInteiro = File.ReadAllLines("C:\\BIBLIAC#\\bíblia sagrada.txt", Encoding.GetEncoding("ISO-8859-1"));
            txtVersiculos.Text = "";
            cmbBoxInicial.Items.Clear();
            cmbBoxFinal.Items.Clear();
            foreach (var linha in textoInteiro)
            {
                int PosiçãoLivro = lstBoxLivros.SelectedIndex;
                string Livro = lstBoxLivros.Items[PosiçãoLivro].ToString().ToUpper();
                int PosiçãoCapitulo = lstBoxCapitulos.SelectedIndex;
                string CapituloSelecionado = lstBoxCapitulos.Items[PosiçãoCapitulo].ToString();
                if (linha.ToUpper().Trim().Contains(Livro) == true && linha.ToUpper().Trim().Contains(CapituloSelecionado) == true)
                {
                    SinalizadorVers = true;

                }
                else if (SinalizadorVers == true)
                {
                    if (linha == "")
                    {
                        break;
                    }
                    else
                    {
                        if (linha != "")
                        {
                            txtVersiculos.Text += $"{linha}" + Environment.NewLine;
                            SinalizadorText = true;
                            string[] inicial = linha.Split(" ");
                            string[] final = linha.Split(" ");
                            cmbBoxInicial.Items.Add($"{inicial[0]}");
                            cmbBoxFinal.Items.Add($"{final[0]}");
                        }
                    }
                }

            }
        }
        private void btnListarVersiculos_Click(object sender, EventArgs e)
        {
            if (cmbBoxInicial.SelectedIndex == -1)
            {
                MessageBox.Show("ERRO: NÚMERO INICIAL PRECISA SER PREENCHIDO!");
                cmbBoxInicial.Focus();
            }
            else if (cmbBoxFinal.SelectedIndex == -1)
            {
                MessageBox.Show("ERRO: NÚMERO FINAL PRECISA SER PREENCHIDO!");
                cmbBoxFinal.Focus();
            }
            else if (cmbBoxInicial.SelectedIndex > -1 && cmbBoxFinal.SelectedIndex > -1)
            {
                int PosiçãoInicial = Convert.ToInt32(cmbBoxInicial.SelectedIndex);
                string InicialString = cmbBoxInicial.Items[PosiçãoInicial].ToString();
                int PosiçãoFinal = Convert.ToInt32(cmbBoxFinal.SelectedIndex);
                string FinalString = cmbBoxFinal.Items[PosiçãoFinal].ToString();
                int VersiculoInicial = Convert.ToInt32(InicialString);
                int VersiculoFinal = Convert.ToInt32(FinalString);
                txtVersiculos.Text = "";
                bool SinalizadorVers = false;
                var textoInteiro = File.ReadAllLines("C:\\BIBLIAC#\\bíblia sagrada.txt", Encoding.GetEncoding("ISO-8859-1"));
                if (VersiculoInicial > VersiculoFinal)
                {
                    MessageBox.Show("ERRO: NÚMERO INICIAL NÃO PODE SER MAIOR QUE NÚMERO FINAL!");
                    cmbBoxInicial.Focus();
                }
                foreach (var linha in textoInteiro)
                {
                    int PosiçãoLivro = lstBoxLivros.SelectedIndex;
                    string Livro = lstBoxLivros.Items[PosiçãoLivro].ToString().ToUpper();
                    int PosiçãoCapitulo = lstBoxCapitulos.SelectedIndex;
                    string CapituloSelecionado = lstBoxCapitulos.Items[PosiçãoCapitulo].ToString();
                    if (linha.ToUpper().Trim().Contains(Livro) == true && linha.ToUpper().Trim().Contains(CapituloSelecionado) == true)
                    {
                        SinalizadorVers = true;

                    }
                    else if (SinalizadorVers == true)
                    {
                        if (linha == "")
                        {
                            break;
                        }
                        else
                        {
                            bool sinalizador2 = false;
                            if (VersiculoInicial <= VersiculoFinal && linha.Contains(VersiculoInicial.ToString()) == true)
                            {
                                txtVersiculos.Text += $"{linha}" + Environment.NewLine;
                                VersiculoInicial++;
                            }
                        }
                    }
                }
            }
        }
        private void txtVersiculos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}