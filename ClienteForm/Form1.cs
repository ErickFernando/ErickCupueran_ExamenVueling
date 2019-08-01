using EricCupueran_ExamenVueling.Factory;
using EricCupueran_ExamenVueling.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteForm
{
    public partial class Form1 : Form
    {
        ServiceReference1.WebServiceSoapClient WebServiceSoapClient;
        Factory factory = new Factory();
        LogWriter log = new LogWriter();
        public Form1()
        {
            InitializeComponent();
            WebServiceSoapClient= new ServiceReference1.WebServiceSoapClient();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DateTime localDate = DateTime.Now;

            IUniverse Planeta = factory.getUniverse("Planeta");

            Object selectedItem = comboBox1.SelectedItem;
            try {
                if (selectedItem.ToString().Length > 0) {

                    switch (selectedItem.ToString()) {
                        case "Rebelde":
                            IUniverse Rebelde = factory.getUniverse(selectedItem.ToString());
                            if (!Checktext(textBox1.Text, textBox2.Text))
                            {
                                if (CheckTextVoid(textBox1.Text, textBox2.Text)){
                                    Planeta.SetName(textBox2.Text);
                                    Rebelde.SetName(textBox1.Text);

                                 WebServiceSoapClient.AddListServiceRebelde(Rebelde.GetName(), Planeta.GetName());
                                    //log.LogWrite("-. "+Rebelde.GetName() + ", " + Planeta.GetName()+"; "+localDate.ToString()) ;
                                    log.Add("Tipo "+ selectedItem.ToString() +  " Nombre: "+Rebelde.GetName() + ", Planeta: " + Planeta.GetName());
                                }
                                 else
                                {
                                    MessageBox.Show("Campos vacios");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Alguna cadena contiene caracteres no válidos");
                            }
                            break;
                        case "Soldado":
                            IUniverse Soldado = factory.getUniverse(selectedItem.ToString());
                            if (!Checktext(textBox1.Text, textBox2.Text))
                                {
                                if (CheckTextVoid(textBox1.Text, textBox2.Text))
                                {
                                     Planeta.SetName(textBox2.Text);
                                     Soldado.SetName(textBox1.Text);

                                     WebServiceSoapClient.AddListServiceSoldado(Soldado.GetName(), Planeta.GetName());
                                    // log.LogWrite(Soldado.GetName() + ", " + Planeta.GetName() + "; " + localDate.ToString());
                                    log.Add("Tipo " + selectedItem.ToString() + "Clase : " + Soldado.GetName() + ", Planeta: " + Planeta.GetName());
                                }
                                else
                                {
                                    MessageBox.Show("Campos vacios");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Alguna cadena contiene caracteres no válidos");
                            }
                            break;

                    }
                }
                textBox1.Clear();
                textBox2.Clear();
            }
            catch (NullReferenceException ex) {
                MessageBox.Show("Debes seleccionar el tipo de Persona");
            }
           
        }

        public bool Checktext(string text1, string text2) {

            Regex r = new Regex("[0-9]");

            string  value1 = text1.Replace(" ", "");
            string value2=text2.Replace(" ", "");

            if (r.IsMatch(value1) && r.IsMatch(value2))
            {
            
                return true;
            }
            return false;
        }
        public bool CheckTextVoid(string text1, string text2) {
            if (text1.Length > 0 && text2.Length > 0) {
                return true;
                    }
            return false;
        }


        private void ComboBox2_selectItem(object sender, EventArgs e)
        {
            Object selectedItem = comboBox2.SelectedItem;
            if (selectedItem.ToString().Length > 0) {
                // this.listBox4.Items.Add(cl.Pedido);

                switch (selectedItem.ToString())
                {
                    case "Rebelde":
                 
                       var rebeldes = WebServiceSoapClient.GetRebeldesService();

                        try
                        {
                            this.listBox1.DataSource = rebeldes.ToList();
                        }
                        catch (Exception ex) {
                            MessageBox.Show(ex.Message);
                        }
                         
                        
                  
                        break;
                    case "Soldado":
                       
                       var soldados = WebServiceSoapClient.GetSoldadosService();
                        try
                        {
                            this.listBox1.DataSource = soldados.ToList();
                        }
                        catch (Exception ex) {
                            MessageBox.Show(ex.Message);
                        }
                        break; 

                }

            }
        }
    }
}
