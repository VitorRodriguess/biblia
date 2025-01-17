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
            var textoInteiro = File.ReadAllLines("C:\\BIBLIAC#\\b�blia sagrada.txt", Encoding.GetEncoding("ISO-8859-1"));
            foreach (var linha in textoInteiro)
            {

                if (linha.Contains("G�nesis") == true && lstBoxLivros.Items.Contains("G�nesis") == false)
                {
                    lstBoxLivros.Items.Add("G�nesis");
                    contador++;
                  
                }
                else if (linha.Contains("�xodo") == true && lstBoxLivros.Items.Contains("�xodo") == false)
                {
                    lstBoxLivros.Items.Add("�xodo");
                    contador++;
                   
                }
                else if (linha.Contains("Lev�tico") == true && lstBoxLivros.Items.Contains("Lev�tico") == false)
                {
                    lstBoxLivros.Items.Add("Lev�tico");
                    contador++;
                   

                }
                else if (linha.Contains("N�meros") == true && lstBoxLivros.Items.Contains("N�meros") == false)
                {
                    lstBoxLivros.Items.Add("N�meros");
                    contador++;
                   
                }
                else if (linha.Contains("Deuteron�mio") == true && lstBoxLivros.Items.Contains("Deuteron�mio") == false)
                {
                    lstBoxLivros.Items.Add("Deuteron�mio");
                    contador++;
             
                }
                else if (linha.Contains("Josu�") == true && lstBoxLivros.Items.Contains("Josu�") == false)
                {
                    lstBoxLivros.Items.Add("Josu�");
                    contador++;

                }
                else if (linha.Contains("Ju�zes") == true && lstBoxLivros.Items.Contains("Ju�zes") == false)
                {
                    lstBoxLivros.Items.Add("Ju�zes");
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
                else if (linha.Contains("I Cr�nicas") == true && lstBoxLivros.Items.Contains("I Cr�nicas") == false)
                {
                    lstBoxLivros.Items.Add("I Cr�nicas");
                    contador++;
            
                }
                else if (linha.Contains("II Cr�nicas") == true && lstBoxLivros.Items.Contains("II Cr�nicas") == false)
                {
                    lstBoxLivros.Items.Add("II Cr�nicas");
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
                else if (linha.Contains("J�") == true && lstBoxLivros.Items.Contains("J�") == false)
                {
                    lstBoxLivros.Items.Add("J�");
                    contador++;
                    
                }
                else if (linha.Contains("Salmos") == true && lstBoxLivros.Items.Contains("Salmos") == false)
                {
                    lstBoxLivros.Items.Add("Salmos");
                    contador++;
                  
                }
                else if (linha.Contains("Prov�rbios") == true && lstBoxLivros.Items.Contains("Prov�rbios") == false)
                {
                    lstBoxLivros.Items.Add("Prov�rbios");
                    contador++;
                   
                }
                else if (linha.Contains("Eclesiastes") == true && lstBoxLivros.Items.Contains("Eclesiastes") == false)
                {
                    lstBoxLivros.Items.Add("Eclesiastes");
                    contador++;

                }
                else if (linha.Contains("C�ntico dos C�nticos") == true && lstBoxLivros.Items.Contains("C�ntico dos C�nticos") == false)
                {
                    lstBoxLivros.Items.Add("C�ntico dos C�nticos");
                    contador++;
                    
                }
                else if (linha.Contains("Isa�as") == true && lstBoxLivros.Items.Contains("Isa�as") == false)
                {
                    lstBoxLivros.Items.Add("Isa�as");
                    contador++;
                    
                }
                else if (linha.Contains("Jeremias") == true && lstBoxLivros.Items.Contains("Jeremias") == false)
                {
                    lstBoxLivros.Items.Add("Jeremias");
                    contador++;
                   
                }
                else if (linha.Contains("Lamenta��es de Jeremias") == true && lstBoxLivros.Items.Contains("Lamenta��es de Jeremias") == false)
                {
                    lstBoxLivros.Items.Add("Lamenta��es de Jeremias");
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
                else if (linha.Contains("Os�ias") == true && lstBoxLivros.Items.Contains("Os�ias") == false)
                {
                    lstBoxLivros.Items.Add("Os�ias");
                    contador++;
                   
                }
                else if (linha.Contains("Joel") == true && lstBoxLivros.Items.Contains("Joel") == false)
                {
                    lstBoxLivros.Items.Add("Joel");
                    contador++;
                  
                }
                else if (linha.Contains("Am�s") == true && lstBoxLivros.Items.Contains("Am�s") == false)
                {
                    lstBoxLivros.Items.Add("Am�s");
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
                else if (linha.Contains("Miqu�ias") == true && lstBoxLivros.Items.Contains("Miqu�ias") == false)
                {
                    lstBoxLivros.Items.Add("Miqu�ias");
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
                else if (linha.Contains("Jo�o") == true && lstBoxLivros.Items.Contains("Jo�o") == false)
                {
                    lstBoxLivros.Items.Add("Jo�o");
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
                else if (linha.Contains("I Cor�ntios") == true && lstBoxLivros.Items.Contains("I Cor�ntios") == false)
                {
                    lstBoxLivros.Items.Add("I Cor�ntios");
                    contador++;
                 
                }
                else if (linha.Contains("II Cor�ntios") == true && lstBoxLivros.Items.Contains("II Cor�ntios") == false)
                {
                    lstBoxLivros.Items.Add("II Cor�ntios");
                    contador++;
                  
                }
                else if (linha.Contains("G�latas") == true && lstBoxLivros.Items.Contains("G�latas") == false)
                {
                    lstBoxLivros.Items.Add("G�latas");
                    contador++;
                    
                }
                else if (linha.Contains("Ef�sios") == true && lstBoxLivros.Items.Contains("Ef�sios") == false)
                {
                    lstBoxLivros.Items.Add("Ef�sios");
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
                else if (linha.Contains("I Tim�teo") == true && lstBoxLivros.Items.Contains("I Tim�teo") == false)
                {
                    lstBoxLivros.Items.Add("I Tim�teo");
                    contador++;
                  
                }
                else if (linha.Contains("II Tim�teo") == true && lstBoxLivros.Items.Contains("II Tim�teo") == false)
                {
                    lstBoxLivros.Items.Add("II Tim�teo");
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
                else if (linha.Contains("I Jo�o") == true && lstBoxLivros.Items.Contains("I Jo�o") == false)
                {
                    lstBoxLivros.Items.Add("I Jo�o");
                    contador++;
                   
                }
                else if (linha.Contains("II Jo�o") == true && lstBoxLivros.Items.Contains("II Jo�o") == false)
                {
                    lstBoxLivros.Items.Add("II Jo�o");
                    contador++;
                   
                }
                else if (linha.Contains("III Jo�o") == true && lstBoxLivros.Items.Contains("III Jo�o") == false)
                {
                    lstBoxLivros.Items.Add("III Jo�o");
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
            var textoInteiro = File.ReadAllLines("C:\\BIBLIAC#\\b�blia sagrada.txt", Encoding.GetEncoding("ISO-8859-1"));
            int CapituloNum = 1;
            lstBoxCapitulos.Items.Clear();
            foreach (var linha in textoInteiro)
            {
                int Posi��oLivro = lstBoxLivros.SelectedIndex;
                string Capitulo = "�" + lstBoxLivros.Items[Posi��oLivro].ToString().ToUpper() + $" [{CapituloNum}]";
                string Livro = lstBoxLivros.Items[Posi��oLivro].ToString().ToUpper();
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

            var textoInteiro = File.ReadAllLines("C:\\BIBLIAC#\\b�blia sagrada.txt", Encoding.GetEncoding("ISO-8859-1"));
            txtVersiculos.Text = "";
            cmbBoxInicial.Items.Clear();
            cmbBoxFinal.Items.Clear();
            foreach (var linha in textoInteiro)
            {
                int Posi��oLivro = lstBoxLivros.SelectedIndex;
                string Livro = lstBoxLivros.Items[Posi��oLivro].ToString().ToUpper();
                int Posi��oCapitulo = lstBoxCapitulos.SelectedIndex;
                string CapituloSelecionado = lstBoxCapitulos.Items[Posi��oCapitulo].ToString();
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
                MessageBox.Show("ERRO: N�MERO INICIAL PRECISA SER PREENCHIDO!");
                cmbBoxInicial.Focus();
            }
            else if (cmbBoxFinal.SelectedIndex == -1)
            {
                MessageBox.Show("ERRO: N�MERO FINAL PRECISA SER PREENCHIDO!");
                cmbBoxFinal.Focus();
            }
            else if (cmbBoxInicial.SelectedIndex > -1 && cmbBoxFinal.SelectedIndex > -1)
            {
                int Posi��oInicial = Convert.ToInt32(cmbBoxInicial.SelectedIndex);
                string InicialString = cmbBoxInicial.Items[Posi��oInicial].ToString();
                int Posi��oFinal = Convert.ToInt32(cmbBoxFinal.SelectedIndex);
                string FinalString = cmbBoxFinal.Items[Posi��oFinal].ToString();
                int VersiculoInicial = Convert.ToInt32(InicialString);
                int VersiculoFinal = Convert.ToInt32(FinalString);
                txtVersiculos.Text = "";
                bool SinalizadorVers = false;
                var textoInteiro = File.ReadAllLines("C:\\BIBLIAC#\\b�blia sagrada.txt", Encoding.GetEncoding("ISO-8859-1"));
                if (VersiculoInicial > VersiculoFinal)
                {
                    MessageBox.Show("ERRO: N�MERO INICIAL N�O PODE SER MAIOR QUE N�MERO FINAL!");
                    cmbBoxInicial.Focus();
                }
                foreach (var linha in textoInteiro)
                {
                    int Posi��oLivro = lstBoxLivros.SelectedIndex;
                    string Livro = lstBoxLivros.Items[Posi��oLivro].ToString().ToUpper();
                    int Posi��oCapitulo = lstBoxCapitulos.SelectedIndex;
                    string CapituloSelecionado = lstBoxCapitulos.Items[Posi��oCapitulo].ToString();
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