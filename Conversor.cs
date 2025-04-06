using System.Windows.Forms;

// Permet fer que el dispisitiu de l'usuari pugui utilitzar qualsevol tipus de decimal.
using System.Globalization;
using System.Diagnostics;
using System.ComponentModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using Microsoft.VisualBasic;

namespace Conversor_de_divises___Ian_Martínez_Picazo
{
    public partial class Conversor : Form
    {
        // Constructor per conversions.
        public class Transaccio
        {
            public string Client { get; set; }
            public string Email { get; set; }
            public DateTime DataTransaccio { get; set; }
            public double Import1 { get; set; }
            public string Divisa1 { get; set; }
            public double Import2 { get; set; }
            public string Divisa2 { get; set; }
            public bool Compra { get; set; }
            public bool Venda { get; set; }
            public bool Descompte1 { get; set; }
            public bool Descompte2 { get; set; }

            public Transaccio
            (
                string client,
                string email,
                DateTime dataTransaccio,
                double import1,
                string divisa1,
                double import2,
                string divisa2,
                bool compra,
                bool venda,
                bool descompte1,
                bool descompte2
            )
            {
                Client = client;
                Email = email;
                DataTransaccio = dataTransaccio;
                Import1 = import1;
                Divisa1 = divisa1;
                Import2 = import2;
                Divisa2 = divisa2;
                Compra = compra;
                Venda = venda;
                Descompte1 = descompte1;
                Descompte2 = descompte2;
            }
        }

        // Emmagatzema conversions realitzades.
        private static BindingList<Transaccio> historial = new BindingList<Transaccio>();

        // Emmagatzema clients.
        private static BindingList<string> clients = new BindingList<string>();

        // Divises seleccionables.
        private static string[] divises =
        {
            "Euro | €",
            "Dòlar Estats Units | $",
            "Lliura Esterlina | £",
            "Ien Japonès | ¥",
            "Franc Suís | CHF"
        };

        // Totes les conversions possibles.
        private static Dictionary<string, double> conversions = new Dictionary<string, double>
        {
            // Conversions d'Euro (€).
            { "€_A_$", 1.10 },
            { "€_A_£", 0.85 },
            { "€_A_¥", 130.00 },
            { "€_A_CHF", 1.05 },

            // Conversions de Dòlar ($).
            { "$_A_€", 1 / 1.10 },
            { "$_A_£", 0.77 },
            { "$_A_¥", 118.18 },
            { "$_A_CHF", 0.95 },

            // Conversions de Lliura Esterlina (£).
            { "£_A_€", 1 / 0.85 },
            { "£_A_$", 1.30 },
            { "£_A_¥", 153.00 },
            { "£_A_CHF", 1.36 },

            // Conversions de Ien Japonès (¥).
            { "¥_A_€", 1 / 130.00 },
            { "¥_A_$", 1 / 118.18 },
            { "¥_A_£", 1 / 153.00 },
            { "¥_A_CHF", 0.0079 },

            // Conversions de Franc Suís (CHF).
            { "CHF_A_€", 1 / 1.05 },
            { "CHF_A_$", 1 / 0.95 },
            { "CHF_A_£", 1 / 1.36 },
            { "CHF_A_¥", 1 / 0.0079 }
        };

        // Emmagatzema els idiomes de l'aplicació.
        private static BindingList<string> idiomes = new BindingList<string>
        {
            "English | en",
            "Català | ca-ES",
            "Castellano | es",
            "Français | fr-FR",
            "Italiano | it"
        };

        // Utilitza l'idioma angles en carregar el formulari.
        public Conversor()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(aillarSimbol(idiomes[0]));
            InitializeComponent();
        }

        // Assigna els botons númerics per codi a la vista i també assigna un event compartit per a cadascú.
        private void CrearBotons(string nom, string text, int columna, int fila, int fusionar_columnes = 1)
        {
            Button btn = new Button
            {
                Name = nom,
                Text = text,
                MinimumSize = new Size(40, 40),
                Dock = DockStyle.Fill
            };

            TaulaConversor.Controls.Add(btn, columna, fila);

            TaulaConversor.SetColumnSpan(btn, fusionar_columnes);

            btn.Click += botoPremut;
        }

        // Troba el botó premut dinamicament i ho escriu a la caixa de text.
        public void botoPremut(Object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            CaixaEscriptura.Text += btn.Text;
        }


        // Variable per evitar bucles.
        private bool canviant_text = false;

        // Assegura que el contingut de la caixa de text sigui valid.
        public void validacioQuantitat(object sender, EventArgs e)
        {
            // Evita que l'esdeveniment s'activi mentre es modifica el text programàticament.
            if (canviant_text) return;

            // Desa la posició del cursor.
            int cursor = CaixaEscriptura.SelectionStart;

            // Substitueix les comes per punts.
            string text = CaixaEscriptura.Text.Replace(',', '.');

            // Preven l'entrada de caràcters no numèrics ni punts decimals excessius.
            string text_valid = string.Empty;
            bool decimal_trobat = false;

            // Itera a través de cada caràcter del text.
            foreach (char caracter in text)
            {
                // Permet només números i un sol punt decimal.
                if (char.IsDigit(caracter))
                {
                    text_valid += caracter; // Afegeix el número.
                }
                else if (caracter == '.' && !decimal_trobat)
                {
                    text_valid += caracter; // Afegeix el punt decimal.
                    decimal_trobat = true; // Marca que s'ha trobat un punt decimal.
                }
            }
            // Desactiva el canvi de text per evitar el llançament de l'esdeveniment.
            canviant_text = true;

            // Assigna el text validat de nou.
            CaixaEscriptura.Text = text_valid + aillarSimbol(DivisaActualCaixa.Text.Trim());

            // Restaura la posició del cursor després de la validació.
            CaixaEscriptura.SelectionStart = cursor;

            // Rehabilita l'esdeveniment de canvi de text després de la modificació.
            canviant_text = false;
        }

        // Determina la divisa actual.
        private void divisaActualSeleccionada(object sender, EventArgs e)
        {
            CaixaEscriptura.Text = CaixaEscriptura.Text + " ";
        }

        // Calculs de conversió de divisa amb control d'errada.
        private void convertirDivisa(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CaixaEscriptura.Text))
            {
                // Obté les divises seleccionades
                string divisa_actual = aillarSimbol(DivisaActualCaixa.Text);
                string divisa_convertir = aillarSimbol(DivisaConvertirCaixa.Text);

                // Obté la part númmerica de la caixa de text
                if (double.TryParse(CaixaEscriptura.Text.Substring(0, CaixaEscriptura.Text.Length - divisa_actual.Length), NumberStyles.Any, CultureInfo.InvariantCulture, out double quantitat))
                {
                    // Consulta al dictionari per a fer el calcul de conversió.
                    string conversio = $"{divisa_actual}_A_{divisa_convertir}";
                    if (conversions.TryGetValue(conversio, out double taxa))
                    {
                        // Obté el nom i el e-mail del client.
                        string[] client = ClientsCaixa.Text.Split("|");

                        // Comprova que cap valor es buit.
                        if
                        (
                            client != null &&
                            client[0] != null &&
                            client[1] != null &&
                            divisa_actual != null &&
                            divisa_convertir != null
                        )
                        {
                            // Calcula la conversió.
                            double resultat = quantitat * taxa;
                            DivisaActualCaixa.SelectedItem = DivisaConvertirCaixa.SelectedItem;
                            CaixaEscriptura.Text = resultat.ToString("F4");

                            // Afegeix la conversió a l'historial.
                            historial.Add
                            (
                                new Transaccio
                                (
                                    client[0],
                                    client[1],
                                    DateTime.Now,
                                    quantitat,
                                    divisa_actual,
                                    resultat,
                                    divisa_convertir,
                                    CompraTransaccio.Checked,
                                    VendaTransaccio.Checked,
                                    Descompte1CaixaMarca.Checked,
                                    Descompte2CaixaMarca.Checked
                                )
                            );
                        }
                        else
                        {
                            MessageBox.Show("Omple tots els camps");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Skib");
                    }
                }
                else
                {
                    MessageBox.Show("No m'agradan les lletres a l'hora de calcular.");
                }
            }
        }

        // Retorna el simbol del text proporcionat. (Format: [Nom] | [Simbol)
        public string aillarSimbol(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                char buscador = text[i];
                if (buscador == '|')
                {
                    return text.Substring(i + 1).Trim();
                }
            }
            return "Skib";
        }

        // Buida la caixa.
        private void buidarCaixa(object sender, EventArgs e)
        {
            CaixaEscriptura.Text = null;
        }

        // S'executa quan l'usuari tracta d'esborrar un registre.
        private void esborrarRegistre(object sender, EventArgs e)
        {
            if (TaulaDades.SelectedRows.Count > 0)
            {
                DialogResult resultat = MessageBox.Show
                (
                    "Vols esborrar el registre?",
                    "Confirmació",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultat == DialogResult.Yes)
                {
                    int id_registre = TaulaDades.SelectedRows[0].Index;

                    historial.RemoveAt(id_registre);
                }
            }
        }

        // Comprova que els imports en els registres siguin numericament valids.
        private void TaulaDades_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string nom_columna = TaulaDades.Columns[e.ColumnIndex].Name;
            string valor_celda = Convert.ToString(e.FormattedValue) ?? "";

            if (nom_columna == "Import1" || nom_columna == "Import2")
            {
                if (!double.TryParse(valor_celda, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double valor))
                {
                    MessageBox.Show("No és un nombre.");
                    e.Cancel = true; // No permet fer clic a cap altre objecte.
                }
                else
                {
                    TaulaDades.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = valor;
                }
            }
        }


        // Variable per evitar bucles.
        bool canviant_valors = false;

        // S'executa en actualitzar dades. (Tan sols s'executa si els import son numericament valids.)
        private void comprovarDadesCoherents(object sender, DataGridViewCellEventArgs e)
        {
            if (canviant_valors) return;
            canviant_valors = true;

            // Troba la fila i columna modificada.
            var columna = TaulaDades.Columns[e.ColumnIndex];
            var fila = TaulaDades.Rows[e.RowIndex];

            // Aplica la lògica de que compra i venda no poden ser seleccionats a la vegada, i que sempre hi ha d'haver-hi un seleccionat.
            if (columna.Name.Equals("Compra"))
            {
                if (Convert.ToBoolean(fila.Cells["Compra"].Value))
                {
                    fila.Cells["Venda"].Value = false;
                }
                else
                {
                    fila.Cells["Venda"].Value = true;
                }
            }
            else if (columna.Name.Equals("Venda"))
            {
                if (Convert.ToBoolean(fila.Cells["Venda"].Value))
                {
                    fila.Cells["Compra"].Value = false;
                }
                else
                {
                    fila.Cells["Compra"].Value = true;
                }
            }

            // Aplica la lògica de canvi de divises i imports en temps real.
            if (columna.Name.Equals("Divisa1") || columna.Name.Equals("Divisa2"))
            {
                // Control d'errada.
                bool divisa1_valida = false, divisa2_valida = false;
                foreach (String divisa in divises)
                {
                    if (fila.Cells["Divisa1"].Value.Equals(aillarSimbol(divisa)))
                    {
                        divisa1_valida = true;
                    }
                    if (fila.Cells["Divisa2"].Value.Equals(aillarSimbol(divisa)))
                    {
                        divisa2_valida = true;
                    }
                }
                if (!divisa1_valida || !divisa2_valida || fila.Cells["Divisa1"].Value.Equals(fila.Cells["Divisa2"].Value))
                {
                    MessageBox.Show("Divises no valida.");
                    fila.Cells["Divisa1"].Value = divises[0].Substring(divises[0].Length - 1);
                    fila.Cells["Divisa2"].Value = divises[1].Substring(divises[1].Length - 1);
                }

                // Executa la conversió
                String conversio = $"{fila.Cells["Divisa1"].Value}_A_{fila.Cells["Divisa2"].Value}";
                if (conversions.TryGetValue(conversio, out double taxa))
                {
                    double resultat = (double)fila.Cells["Import1"].Value * taxa;
                    fila.Cells["Import2"].Value = resultat;
                }
            }
            if (columna.Name.Equals("Import1"))
            {
                // Executa la conversió
                String conversio = $"{fila.Cells["Divisa1"].Value}_A_{fila.Cells["Divisa2"].Value}";
                if (conversions.TryGetValue(conversio, out double taxa))
                {
                    double resultat = (double)fila.Cells["Import1"].Value * taxa;
                    fila.Cells["Import2"].Value = resultat;
                }
            }
            if (columna.Name.Equals("Import2"))
            {
                String conversio = $"{fila.Cells["Divisa2"].Value}_A_{fila.Cells["Divisa1"].Value}";
                if (conversions.TryGetValue(conversio, out double taxa))
                {
                    double resultat = (double)fila.Cells["Import2"].Value * taxa;
                    fila.Cells["Import1"].Value = resultat;
                }
            }
            canviant_valors = false;
        }

        // Executat en premer qualsevol tecla.
        private void keyShortcuts(object sender, KeyEventArgs e)
        {
            // Conversió de divisa.
            if (e.Control && e.KeyCode == Keys.N)
            {
                convertirDivisa(sender, e);
            }

            // Buidar caixa.
            if (e.Control && e.KeyCode == Keys.Q)
            {
                buidarCaixa(sender, e);
            }

            // Esborrar registre.
            if (e.Control && e.KeyCode == Keys.D)
            {
                esborrarRegistre(sender, e);
            }
        }

        // Per evitar errades.
        bool primera_vegada = true;

        // S'executa en seleccionar qualsevol llenguatge, reinicia l'aplicació.
        private void canviarLlenguatge(object sender, EventArgs e)
        {
            if (!primera_vegada)
            {
                string idioma_seleccionat = IdiomaCaixa.SelectedValue.ToString();
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(aillarSimbol(idioma_seleccionat));
                Controls.Clear();

                // Gestiona els canvis inesperats de la finestra.
                var posicio = this.Location;
                var tamany = this.Size;
                primera_vegada = true;
                InitializeComponent();
                inicialitzacio(this, e);
                this.Location = posicio;
                this.Size = tamany;
                this.PerformLayout();
                primera_vegada = true;
                IdiomaCaixa.SelectedItem = idioma_seleccionat;
            }
            else
            {
                primera_vegada = false;
            }
        }

        // Estableïx tot lo necessari en carregar el formulari
        public void inicialitzacio(object sender, EventArgs e)
        {
            ContenidorDivisioVistes.SplitterDistance = ContenidorDivisioVistes.Width / 3;

            // Creació de botons númerics.
            for (int i = 1; i <= 9; i++)
            {
                CrearBotons("Num" + i, i.ToString(), (i - 1) % 3, (i - 1) / 3 + 2);
            }
            CrearBotons("Num0", "0", 0, 5, 2);
            CrearBotons("Decimal", ".", 2, 5);

            // Afegeix les divises als desplegables.
            DivisaActualCaixa.Items.AddRange(divises);
            DivisaConvertirCaixa.Items.AddRange(divises);

            ContenidorDivisaActual.SplitterDistance = ContenidorDivisaActual.Width / 2;
            ContenidorDivisaConvertir.SplitterDistance = ContenidorDivisaConvertir.Width / 2;
            DescomptesContenidor.SplitterDistance = DescomptesContenidor.Width / 2;
            ContenidorClients.SplitterDistance = ContenidorClients.Width / 4;

            // Vincula la taula d'historial de conversions amb una font d'informació.
            TaulaDades.DataSource = historial;

            // Vincula el desplegable de clients amb una font d'informació.
            ClientsCaixa.DataSource = clients;

            // Vincula el desplegabe d'idiomes a una font d'informació.
            IdiomaCaixa.DataSource = idiomes;

            // Clients per demostrar.
            List<string> clients_demostratius = new List<string>
            {
                "John Smith | john.smith@email.com",
                "Jane Doe | jane.doe@email.com",
                "Michael Johnson | michael.j@email.com",
                "Emily Davis | emily.d@email.com",
                "David Wilson | david.w@email.com",
                "Sarah Brown | sarah.b@email.com",
                "Chris Martinez | chris.m@email.com",
                "Jessica Taylor | jessica.t@email.com",
                "Daniel Anderson | daniel.a@email.com",
                "Laura White | laura.w@email.com"
            };
            foreach (var client in clients_demostratius)
            {
                clients.Add(client);
            }
        }
    }
}