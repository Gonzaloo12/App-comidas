using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.IO.Image;

namespace CapaUI
{
    public partial class FormTicket : Form
    {
        private Categoria categoria;
        private Bitmap memoryImage;

        public FormTicket(Categoria datos)
        {
            InitializeComponent();
            categoria = datos;

            var usuarioActual = new Usuario();
            traerDatos();

            labelNroTotal.Text = datos.ImporteTotal;
            labelDatoCliente.Text = usuarioActual.getUsuario();
            labelFecha.Text = DateTime.Now.Date.ToString("dd-MM-yyyy");
            medioPago.Text = datos.getMedioPago();
        }

        public void traerDatos()
        {
            DataGridViewRowCollection datosOrigen = categoria.DatosDataGridView;

            dataGridView2.Rows.Clear();

            foreach (DataGridViewRow filaOrigen in datosOrigen)
            {
                DataGridViewRow nuevaFila = (DataGridViewRow)filaOrigen.Clone();
                for (int i = 0; i < filaOrigen.Cells.Count; i++)
                {
                    nuevaFila.Cells[i].Value = filaOrigen.Cells[i].Value;
                }
                dataGridView2.Rows.Add(nuevaFila);
            }
        }

        private void descargarPdf_Click(object sender, EventArgs e)
        {
            GuardarComoPDF();
        }

        private void GuardarComoPDF()
        {
            // Capturar la imagen del formulario

            descargarPdf.Hide();

            CaptureFormImage();

            if (memoryImage != null)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
                    saveFileDialog.Title = "Guardar como PDF";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string rutaPDF = saveFileDialog.FileName;

                        
                        using (PdfWriter writer = new PdfWriter(rutaPDF))
                        {
                            using (PdfDocument pdf = new PdfDocument(writer))
                            {
                                
                                Document document = new Document(pdf);

                                
                                using (MemoryStream imageStream = new MemoryStream())
                                {
                                    
                                    memoryImage.Save(imageStream, System.Drawing.Imaging.ImageFormat.Png);
                                    byte[] imageBytes = imageStream.ToArray();

                                    
                                    iText.Layout.Element.Image image = new iText.Layout.Element.Image(ImageDataFactory.Create(imageBytes));
                                    document.Add(image);
                                }
                            }
                        }

                        MessageBox.Show("PDF generado exitosamente.");
                    }
                }
            }
            else
            {
                MessageBox.Show("La imagen no se ha capturado correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CaptureFormImage()
        {
            // Capturar la imagen del formulario
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

    }
}