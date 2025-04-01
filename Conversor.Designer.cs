namespace Conversor_de_divises___Ian_Martínez_Picazo
{
    partial class Conversor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conversor));
            ContenidorDivisioVistes = new SplitContainer();
            TaulaConversor = new TableLayoutPanel();
            ConvertirDivisaBoto = new Button();
            ContenidorDivisaConvertir = new SplitContainer();
            DivisaConvertirText = new Label();
            DivisaConvertirCaixa = new ComboBox();
            BotoBuidar = new Button();
            CaixaEscriptura = new RichTextBox();
            ConversorTitol = new Label();
            ContenidorDivisaActual = new SplitContainer();
            DivisaActualText = new Label();
            DivisaActualCaixa = new ComboBox();
            TaulaHistorial = new TableLayoutPanel();
            BotoEsborrar = new Button();
            HistorialTitol = new Label();
            TaulaDades = new DataGridView();
            ContenidorTipusTransaccio = new Panel();
            VendaTransaccio = new RadioButton();
            CompraTransaccio = new RadioButton();
            ContenidorClients = new SplitContainer();
            ClientsText = new Label();
            ClientsCaixa = new ComboBox();
            DescomptesContenidor = new SplitContainer();
            Descompte1CaixaMarca = new CheckBox();
            Descompte2CaixaMarca = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)ContenidorDivisioVistes).BeginInit();
            ContenidorDivisioVistes.Panel1.SuspendLayout();
            ContenidorDivisioVistes.Panel2.SuspendLayout();
            ContenidorDivisioVistes.SuspendLayout();
            TaulaConversor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ContenidorDivisaConvertir).BeginInit();
            ContenidorDivisaConvertir.Panel1.SuspendLayout();
            ContenidorDivisaConvertir.Panel2.SuspendLayout();
            ContenidorDivisaConvertir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ContenidorDivisaActual).BeginInit();
            ContenidorDivisaActual.Panel1.SuspendLayout();
            ContenidorDivisaActual.Panel2.SuspendLayout();
            ContenidorDivisaActual.SuspendLayout();
            TaulaHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TaulaDades).BeginInit();
            ContenidorTipusTransaccio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ContenidorClients).BeginInit();
            ContenidorClients.Panel1.SuspendLayout();
            ContenidorClients.Panel2.SuspendLayout();
            ContenidorClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DescomptesContenidor).BeginInit();
            DescomptesContenidor.Panel1.SuspendLayout();
            DescomptesContenidor.Panel2.SuspendLayout();
            DescomptesContenidor.SuspendLayout();
            SuspendLayout();
            // 
            // ContenidorDivisioVistes
            // 
            resources.ApplyResources(ContenidorDivisioVistes, "ContenidorDivisioVistes");
            ContenidorDivisioVistes.Name = "ContenidorDivisioVistes";
            // 
            // ContenidorDivisioVistes.Panel1
            // 
            ContenidorDivisioVistes.Panel1.Controls.Add(TaulaConversor);
            // 
            // ContenidorDivisioVistes.Panel2
            // 
            ContenidorDivisioVistes.Panel2.Controls.Add(TaulaHistorial);
            // 
            // TaulaConversor
            // 
            resources.ApplyResources(TaulaConversor, "TaulaConversor");
            TaulaConversor.Controls.Add(ConvertirDivisaBoto, 3, 5);
            TaulaConversor.Controls.Add(ContenidorDivisaConvertir, 3, 4);
            TaulaConversor.Controls.Add(BotoBuidar, 3, 1);
            TaulaConversor.Controls.Add(CaixaEscriptura, 0, 1);
            TaulaConversor.Controls.Add(ConversorTitol, 0, 0);
            TaulaConversor.Controls.Add(ContenidorDivisaActual, 3, 3);
            TaulaConversor.Name = "TaulaConversor";
            // 
            // ConvertirDivisaBoto
            // 
            ConvertirDivisaBoto.BackColor = Color.FromArgb(0, 192, 192);
            resources.ApplyResources(ConvertirDivisaBoto, "ConvertirDivisaBoto");
            ConvertirDivisaBoto.Name = "ConvertirDivisaBoto";
            ConvertirDivisaBoto.UseVisualStyleBackColor = false;
            ConvertirDivisaBoto.Click += convertirDivisa;
            // 
            // ContenidorDivisaConvertir
            // 
            resources.ApplyResources(ContenidorDivisaConvertir, "ContenidorDivisaConvertir");
            ContenidorDivisaConvertir.Name = "ContenidorDivisaConvertir";
            // 
            // ContenidorDivisaConvertir.Panel1
            // 
            ContenidorDivisaConvertir.Panel1.Controls.Add(DivisaConvertirText);
            // 
            // ContenidorDivisaConvertir.Panel2
            // 
            ContenidorDivisaConvertir.Panel2.Controls.Add(DivisaConvertirCaixa);
            // 
            // DivisaConvertirText
            // 
            resources.ApplyResources(DivisaConvertirText, "DivisaConvertirText");
            DivisaConvertirText.Name = "DivisaConvertirText";
            // 
            // DivisaConvertirCaixa
            // 
            resources.ApplyResources(DivisaConvertirCaixa, "DivisaConvertirCaixa");
            DivisaConvertirCaixa.DropDownStyle = ComboBoxStyle.DropDownList;
            DivisaConvertirCaixa.FormattingEnabled = true;
            DivisaConvertirCaixa.Name = "DivisaConvertirCaixa";
            // 
            // BotoBuidar
            // 
            BotoBuidar.BackColor = Color.Red;
            resources.ApplyResources(BotoBuidar, "BotoBuidar");
            BotoBuidar.Name = "BotoBuidar";
            BotoBuidar.UseVisualStyleBackColor = false;
            BotoBuidar.Click += buidarCaixa;
            // 
            // CaixaEscriptura
            // 
            TaulaConversor.SetColumnSpan(CaixaEscriptura, 3);
            resources.ApplyResources(CaixaEscriptura, "CaixaEscriptura");
            CaixaEscriptura.Name = "CaixaEscriptura";
            CaixaEscriptura.TextChanged += validacioQuantitat;
            // 
            // ConversorTitol
            // 
            resources.ApplyResources(ConversorTitol, "ConversorTitol");
            TaulaConversor.SetColumnSpan(ConversorTitol, 4);
            ConversorTitol.Name = "ConversorTitol";
            // 
            // ContenidorDivisaActual
            // 
            resources.ApplyResources(ContenidorDivisaActual, "ContenidorDivisaActual");
            ContenidorDivisaActual.Name = "ContenidorDivisaActual";
            // 
            // ContenidorDivisaActual.Panel1
            // 
            ContenidorDivisaActual.Panel1.Controls.Add(DivisaActualText);
            // 
            // ContenidorDivisaActual.Panel2
            // 
            ContenidorDivisaActual.Panel2.Controls.Add(DivisaActualCaixa);
            // 
            // DivisaActualText
            // 
            resources.ApplyResources(DivisaActualText, "DivisaActualText");
            DivisaActualText.Name = "DivisaActualText";
            // 
            // DivisaActualCaixa
            // 
            resources.ApplyResources(DivisaActualCaixa, "DivisaActualCaixa");
            DivisaActualCaixa.DropDownStyle = ComboBoxStyle.DropDownList;
            DivisaActualCaixa.FormattingEnabled = true;
            DivisaActualCaixa.Name = "DivisaActualCaixa";
            DivisaActualCaixa.SelectedIndexChanged += divisaActualSeleccionada;
            // 
            // TaulaHistorial
            // 
            resources.ApplyResources(TaulaHistorial, "TaulaHistorial");
            TaulaHistorial.Controls.Add(BotoEsborrar, 0, 3);
            TaulaHistorial.Controls.Add(HistorialTitol, 0, 0);
            TaulaHistorial.Controls.Add(TaulaDades, 0, 1);
            TaulaHistorial.Controls.Add(ContenidorTipusTransaccio, 3, 5);
            TaulaHistorial.Controls.Add(ContenidorClients, 0, 4);
            TaulaHistorial.Controls.Add(DescomptesContenidor, 0, 5);
            TaulaHistorial.Name = "TaulaHistorial";
            // 
            // BotoEsborrar
            // 
            BotoEsborrar.BackColor = Color.Red;
            TaulaHistorial.SetColumnSpan(BotoEsborrar, 4);
            resources.ApplyResources(BotoEsborrar, "BotoEsborrar");
            BotoEsborrar.Name = "BotoEsborrar";
            BotoEsborrar.UseVisualStyleBackColor = false;
            BotoEsborrar.Click += esborrarRegistre;
            // 
            // HistorialTitol
            // 
            resources.ApplyResources(HistorialTitol, "HistorialTitol");
            TaulaHistorial.SetColumnSpan(HistorialTitol, 4);
            HistorialTitol.Name = "HistorialTitol";
            // 
            // TaulaDades
            // 
            TaulaDades.AllowUserToAddRows = false;
            TaulaDades.AllowUserToDeleteRows = false;
            TaulaDades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TaulaDades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TaulaHistorial.SetColumnSpan(TaulaDades, 4);
            resources.ApplyResources(TaulaDades, "TaulaDades");
            TaulaDades.Name = "TaulaDades";
            TaulaHistorial.SetRowSpan(TaulaDades, 2);
            TaulaDades.CellValueChanged += comprovarDadesCoherents;
            // 
            // ContenidorTipusTransaccio
            // 
            ContenidorTipusTransaccio.Controls.Add(VendaTransaccio);
            ContenidorTipusTransaccio.Controls.Add(CompraTransaccio);
            resources.ApplyResources(ContenidorTipusTransaccio, "ContenidorTipusTransaccio");
            ContenidorTipusTransaccio.Name = "ContenidorTipusTransaccio";
            // 
            // VendaTransaccio
            // 
            resources.ApplyResources(VendaTransaccio, "VendaTransaccio");
            VendaTransaccio.Name = "VendaTransaccio";
            VendaTransaccio.UseVisualStyleBackColor = true;
            VendaTransaccio.KeyDown += keyShortcuts;
            // 
            // CompraTransaccio
            // 
            resources.ApplyResources(CompraTransaccio, "CompraTransaccio");
            CompraTransaccio.Checked = true;
            CompraTransaccio.Name = "CompraTransaccio";
            CompraTransaccio.TabStop = true;
            CompraTransaccio.UseVisualStyleBackColor = true;
            // 
            // ContenidorClients
            // 
            TaulaHistorial.SetColumnSpan(ContenidorClients, 4);
            resources.ApplyResources(ContenidorClients, "ContenidorClients");
            ContenidorClients.Name = "ContenidorClients";
            // 
            // ContenidorClients.Panel1
            // 
            ContenidorClients.Panel1.Controls.Add(ClientsText);
            // 
            // ContenidorClients.Panel2
            // 
            ContenidorClients.Panel2.Controls.Add(ClientsCaixa);
            // 
            // ClientsText
            // 
            resources.ApplyResources(ClientsText, "ClientsText");
            ClientsText.Name = "ClientsText";
            // 
            // ClientsCaixa
            // 
            resources.ApplyResources(ClientsCaixa, "ClientsCaixa");
            ClientsCaixa.DropDownStyle = ComboBoxStyle.DropDownList;
            ClientsCaixa.FormattingEnabled = true;
            ClientsCaixa.Name = "ClientsCaixa";
            // 
            // DescomptesContenidor
            // 
            TaulaHistorial.SetColumnSpan(DescomptesContenidor, 3);
            resources.ApplyResources(DescomptesContenidor, "DescomptesContenidor");
            DescomptesContenidor.Name = "DescomptesContenidor";
            // 
            // DescomptesContenidor.Panel1
            // 
            DescomptesContenidor.Panel1.Controls.Add(Descompte1CaixaMarca);
            // 
            // DescomptesContenidor.Panel2
            // 
            DescomptesContenidor.Panel2.Controls.Add(Descompte2CaixaMarca);
            // 
            // Descompte1CaixaMarca
            // 
            resources.ApplyResources(Descompte1CaixaMarca, "Descompte1CaixaMarca");
            Descompte1CaixaMarca.CausesValidation = false;
            Descompte1CaixaMarca.Name = "Descompte1CaixaMarca";
            Descompte1CaixaMarca.UseVisualStyleBackColor = true;
            // 
            // Descompte2CaixaMarca
            // 
            resources.ApplyResources(Descompte2CaixaMarca, "Descompte2CaixaMarca");
            Descompte2CaixaMarca.CausesValidation = false;
            Descompte2CaixaMarca.Name = "Descompte2CaixaMarca";
            Descompte2CaixaMarca.UseVisualStyleBackColor = true;
            // 
            // Conversor
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ContenidorDivisioVistes);
            KeyPreview = true;
            Name = "Conversor";
            KeyDown += keyShortcuts;
            ContenidorDivisioVistes.Panel1.ResumeLayout(false);
            ContenidorDivisioVistes.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ContenidorDivisioVistes).EndInit();
            ContenidorDivisioVistes.ResumeLayout(false);
            TaulaConversor.ResumeLayout(false);
            TaulaConversor.PerformLayout();
            ContenidorDivisaConvertir.Panel1.ResumeLayout(false);
            ContenidorDivisaConvertir.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ContenidorDivisaConvertir).EndInit();
            ContenidorDivisaConvertir.ResumeLayout(false);
            ContenidorDivisaActual.Panel1.ResumeLayout(false);
            ContenidorDivisaActual.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ContenidorDivisaActual).EndInit();
            ContenidorDivisaActual.ResumeLayout(false);
            TaulaHistorial.ResumeLayout(false);
            TaulaHistorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TaulaDades).EndInit();
            ContenidorTipusTransaccio.ResumeLayout(false);
            ContenidorTipusTransaccio.PerformLayout();
            ContenidorClients.Panel1.ResumeLayout(false);
            ContenidorClients.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ContenidorClients).EndInit();
            ContenidorClients.ResumeLayout(false);
            DescomptesContenidor.Panel1.ResumeLayout(false);
            DescomptesContenidor.Panel1.PerformLayout();
            DescomptesContenidor.Panel2.ResumeLayout(false);
            DescomptesContenidor.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DescomptesContenidor).EndInit();
            DescomptesContenidor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer ContenidorDivisioVistes;
        private TableLayoutPanel TaulaConversor;
        private Button ConvertirDivisaBoto;
        private SplitContainer ContenidorDivisaConvertir;
        private Label DivisaConvertirText;
        private ComboBox DivisaConvertirCaixa;
        private Button BotoBuidar;
        private RichTextBox CaixaEscriptura;
        private Label ConversorTitol;
        private SplitContainer ContenidorDivisaActual;
        private Label DivisaActualText;
        private ComboBox DivisaActualCaixa;
        private TableLayoutPanel TaulaHistorial;
        private Label HistorialTitol;
        private DataGridView TaulaDades;
        private ComboBox ClientsCaixa;
        private Label ClientsText;
        private CheckBox Descompte2CaixaMarca;
        private CheckBox Descompte1CaixaMarca;
        private Panel ContenidorTipusTransaccio;
        private RadioButton VendaTransaccio;
        private RadioButton CompraTransaccio;
        private SplitContainer ContenidorClients;
        private Button BotoEsborrar;
        private SplitContainer DescomptesContenidor;
    }
}
