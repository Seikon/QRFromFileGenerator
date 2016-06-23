using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
namespace GeneradorQR
{
    public partial class Form1 : Form
    {
        private String fichero;
        private  List<String> ListCodigos = new List<String>();

        public Form1()
        {

            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
          /*  StreamWriter writer = new StreamWriter("C:\\Users\\fernandezale\\Desktop\\codigos.txt");

            for (int i = 0; i < 100000; i++)
            {
                writer.WriteLine(i);
            }

            writer.Close(); 
          */

            GenerarVisible(false);
            SeleccionarVisible(true);
        }


        private void btnGenerar_Click(object sender, EventArgs e)
        {   
            try {

                folderBrowserDialog1.ShowDialog();
                if(!String.IsNullOrEmpty(folderBrowserDialog1.SelectedPath))
                    generarCodigosFichero();

            }catch(Exception ex) {
                MessageBox.Show("Se ha producido un error al generar los códigos: " + ex.Message,"Error",MessageBoxButtons.OK);
            }
        }

        private void GenerarMuestra(String muestra)
        {
            try
            {

                var qrEnconder = new QrEncoder(ErrorCorrectionLevel.H);
                var qrCode = qrEnconder.Encode(muestra);
                var render = new GraphicsRenderer(new FixedModuleSize(5, QuietZoneModules.Two), Brushes.Black, Brushes.White);
                var stream = new System.IO.MemoryStream();
                render.WriteToStream(qrCode.Matrix, ImageFormat.Png, stream);
                Image imagen = Image.FromStream(stream);
                pcQr1.Image = imagen;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error al generar la muestra: " + ex.Message,"Error",MessageBoxButtons.OK);
            }
            
        }

        private void generarCodigosFichero()
        {
            try
            {
                int count = 0;
                QrEncoder qrEnconder = new QrEncoder(ErrorCorrectionLevel.H);
                QrCode qrCode = null;
                GraphicsRenderer render = null;
                FileStream stream = null;

                render = new GraphicsRenderer(new FixedModuleSize(5, QuietZoneModules.Two), Brushes.Black, Brushes.White);

                foreach (string code in ListCodigos)
                {
                    qrCode = qrEnconder.Encode(code);
                    stream = new FileStream(folderBrowserDialog1.SelectedPath + "\\code_" + count + ".jpg", FileMode.Create);
                    render.WriteToStream(qrCode.Matrix, ImageFormat.Jpeg, stream);
                    stream.Close();
                    count++;
                }

                MessageBox.Show(ListCodigos.Count.ToString() + " codigos Generados correctamente!","Codigos",MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                throw ex;
            }
                
        }

        private void btnSeleccionarFichero_Click(object sender, EventArgs e)
        {
            try
            {

                fichero = null;

                ListCodigos = new List<string>();
                openFileDialog1.ShowDialog();
                fichero = openFileDialog1.FileName;
                //si hay fichero seleccionado
                if (!String.IsNullOrEmpty(fichero))
                {
                    using (var stream = new System.IO.StreamReader(fichero))
                    {
                        String line = null;

                        while ((line = stream.ReadLine()) != null)
                        {
                            ListCodigos.Add(line);
                        }

                        //excluye si la cabecera si procede
                        if (chbSaltarCabecera.Checked)
                            ListCodigos.RemoveAt(0);

                        //Atualiza los graficos
                        lblTConteo.Text = ListCodigos.Count.ToString();
                        lblTRutaFichero.Text = fichero;

                        //Genera la muestra en base a un valor atleatorio
                        Random random = new Random();

                        GenerarMuestra(ListCodigos[random.Next(0, ListCodigos.Count)]);

                        GenerarVisible(true);
                    }
                }//end hay fichero seleccionado

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void SeleccionarVisible(bool modo)
        {
            lblFichero.Visible = modo;
            lblRutaFichero.Visible = modo;
            lblTRutaFichero.Visible = modo;
            lblConteo.Visible = modo;
            lblTConteo.Visible = modo;
            chbSaltarCabecera.Visible = modo;
            btnSeleccionarFichero.Visible = modo;
        }

        private void GenerarVisible(bool modo)
        {
            lblGenerarQR.Visible = modo;
            pcQr1.Visible = modo;
            lblMuestra.Visible = modo;
            btnGenerar.Visible = modo;
        }

    }
    
}
