using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdrianTouriñoExamenFebrero
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        Asignatura entornos = new Asignatura();
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult validacion1 = MessageBox.Show("¿Quiere guardar los datos?","Guardar",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
            String val1 = validacion1.ToString();
            if(val1 == "Yes")
            {
                if (nameBox.Text == "" || dniBox.Text == "" || interesBox.SelectedIndex == -1 || fechaBox.Text == "" || asistenciaBox.SelectedIndex == -1 || comentBox.Text == "" || (r1B.Checked == false && r2B.Checked == false && r3B.Checked == false && r4B.Checked == false))
                {
                    MessageBox.Show("Debe completar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    entornos.nombre = nameBox.Text;
                    entornos.DNI = dniBox.Text;
                    entornos.interes = interesBox.SelectedItem.ToString();
                    entornos.fecha = fechaBox.Text;
                    if (r1B.Checked)
                    {
                        entornos.aprendizaje = "He aprendido mucho";
                    } 
                    else if(r2B.Checked)
                    {
                        entornos.aprendizaje = "He aprendido poco";
                    }
                    else if (r3B.Checked)
                    {
                        entornos.aprendizaje = "No quiero aprender";
                    }
                    else
                    {
                        entornos.aprendizaje = "No quiero contestar";
                    }
                    entornos.comentario = comentBox.Text;
                    entornos.asistencia = asistenciaBox.SelectedItem.ToString();
                    if (consentimientoCheck.Checked)
                    {
                        entornos.consentimiento = true;
                    } else
                    {
                        entornos.consentimiento = false;
                    }
                    nameBox.Text = "";
                    dniBox.Text = "";
                    r1B.Checked = false;
                    r2B.Checked = false;
                    r3B.Checked = false;
                    r4B.Checked = false;
                    interesBox.SelectedIndex = -1;
                    fechaBox.Text = "";
                    consentimientoCheck.Checked = false;
                    asistenciaBox.SelectedIndex = -1;
                    comentBox.Text = "";
                }
            } else if(val1 == "No")
            {
                MessageBox.Show(entornos.muestraInfo(), "Información");

            } else
            {

            }
        }
        
        class Asignatura
        {
            public String nombre;
            public String DNI;
            public String aprendizaje;
            public String interes;
            public String fecha;
            public bool consentimiento;
            public String asistencia;
            public String comentario;

            public String muestraInfo()
            {
                return "Nombre: "+this.nombre+"\nDNI: "+this.DNI+"\n Aprendizaje: "+ this.aprendizaje+"\nInteres: "+this.interes+
                    "\nFecha: "+this.fecha+"\n¿Da su consentimiento? "+this.consentimiento+"\nAsistencia: "+this.asistencia+"\nComentario: "+this.comentario;
            }
        }

        Asignatura bbdd = new Asignatura();
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult validacion2 = MessageBox.Show("¿Quiere guardar los datos?", "Guardar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            String val2 = validacion2.ToString();
            if (val2 == "Yes")
            {
                if (nameBox.Text == "" || dniBox.Text == "" || interesBox.SelectedIndex == -1 || fechaBox.Text == "" || asistenciaBox.SelectedIndex == -1 || comentBox.Text == "" || (r1B.Checked == false && r2B.Checked == false && r3B.Checked == false && r4B.Checked == false))
                {
                    MessageBox.Show("Debe completar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bbdd.nombre = nameBox.Text;
                    bbdd.DNI = dniBox.Text;
                    bbdd.interes = interesBox.SelectedItem.ToString();
                    bbdd.fecha = fechaBox.Text;
                    if (r1B.Checked)
                    {
                        bbdd.aprendizaje = "He aprendido mucho";
                    }
                    else if (r2B.Checked)
                    {
                        bbdd.aprendizaje = "He aprendido poco";
                    }
                    else if (r3B.Checked)
                    {
                        bbdd.aprendizaje = "No quiero aprender";
                    }
                    else
                    {
                        bbdd.aprendizaje = "No quiero contestar";
                    }
                    bbdd.comentario = comentBox.Text;
                    bbdd.asistencia = asistenciaBox.SelectedItem.ToString();
                    if (consentimientoCheck.Checked)
                    {
                        bbdd.consentimiento = true;
                    }
                    else
                    {
                        bbdd.consentimiento = false;
                    }
                    nameBox.Text = "";
                    dniBox.Text = "";
                    r1B.Checked = false;
                    r2B.Checked = false;
                    r3B.Checked = false;
                    r4B.Checked = false;
                    interesBox.SelectedIndex = -1;
                    fechaBox.Text = "";
                    consentimientoCheck.Checked = false;
                    asistenciaBox.SelectedIndex = -1;
                    comentBox.Text = "";
                }
            }
            else if (val2 == "No")
            {
                MessageBox.Show(bbdd.muestraInfo(), "Información");

            }
            else
            {

            }
        }

        Asignatura marcas = new Asignatura();
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult validacion3 = MessageBox.Show("¿Quiere guardar los datos?", "Guardar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            String val3 = validacion3.ToString();
            if (val3 == "Yes")
            {
                if (nameBox.Text == "" || dniBox.Text == "" || interesBox.SelectedIndex == -1 || fechaBox.Text == "" || asistenciaBox.SelectedIndex == -1 || comentBox.Text == "" || (r1B.Checked == false && r2B.Checked == false && r3B.Checked == false && r4B.Checked == false))
                {
                    MessageBox.Show("Debe completar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    marcas.nombre = nameBox.Text;
                    marcas.DNI = dniBox.Text;
                    marcas.interes = interesBox.SelectedItem.ToString();
                    marcas.fecha = fechaBox.Text;
                    if (r1B.Checked)
                    {
                        marcas.aprendizaje = "He aprendido mucho";
                    }
                    else if (r2B.Checked)
                    {
                        marcas.aprendizaje = "He aprendido poco";
                    }
                    else if (r3B.Checked)
                    {
                        marcas.aprendizaje = "No quiero aprender";
                    }
                    else
                    {
                        marcas.aprendizaje = "No quiero contestar";
                    }
                    marcas.comentario = comentBox.Text;
                    marcas.asistencia = asistenciaBox.SelectedItem.ToString();
                    if (consentimientoCheck.Checked)
                    {
                        marcas.consentimiento = true;
                    }
                    else
                    {
                        marcas.consentimiento = false;
                    }
                    nameBox.Text = "";
                    dniBox.Text = "";
                    r1B.Checked = false;
                    r2B.Checked = false;
                    r3B.Checked = false;
                    r4B.Checked = false;
                    interesBox.SelectedIndex = -1;
                    fechaBox.Text = "";
                    consentimientoCheck.Checked = false;
                    asistenciaBox.SelectedIndex = -1;
                    comentBox.Text = "";
                }
            }
            else if (val3 == "No")
            {
                MessageBox.Show(marcas.muestraInfo(), "Información");

            }
            else
            {

            }
        }

        Asignatura prog = new Asignatura();
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult validacion4 = MessageBox.Show("¿Quiere guardar los datos?", "Guardar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            String val4 = validacion4.ToString();
            if (val4 == "Yes")
            {
                if (nameBox.Text == "" || dniBox.Text == "" || interesBox.SelectedIndex == -1 || fechaBox.Text == "" || asistenciaBox.SelectedIndex == -1 || comentBox.Text == "" || (r1B.Checked == false && r2B.Checked == false && r3B.Checked == false && r4B.Checked == false))
                {
                    MessageBox.Show("Debe completar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    prog.nombre = nameBox.Text;
                    prog.DNI = dniBox.Text;
                    prog.interes = interesBox.SelectedItem.ToString();
                    prog.fecha = fechaBox.Text;
                    if (r1B.Checked)
                    {
                        prog.aprendizaje = "He aprendido mucho";
                    }
                    else if (r2B.Checked)
                    {
                        prog.aprendizaje = "He aprendido poco";
                    }
                    else if (r3B.Checked)
                    {
                        prog.aprendizaje = "No quiero aprender";
                    }
                    else
                    {
                        prog.aprendizaje = "No quiero contestar";
                    }
                    prog.comentario = comentBox.Text;
                    prog.asistencia = asistenciaBox.SelectedItem.ToString();
                    if (consentimientoCheck.Checked)
                    {
                        prog.consentimiento = true;
                    }
                    else
                    {
                        prog.consentimiento = false;
                    }
                    nameBox.Text = "";
                    dniBox.Text = "";
                    r1B.Checked = false;
                    r2B.Checked = false;
                    r3B.Checked = false;
                    r4B.Checked = false;
                    interesBox.SelectedIndex = -1;
                    fechaBox.Text = "";
                    consentimientoCheck.Checked = false;
                    asistenciaBox.SelectedIndex = -1;
                    comentBox.Text = "";
                }
            }
            else if (val4 == "No")
            {
                MessageBox.Show(marcas.muestraInfo(), "Información");

            }
            else
            {

            }
        }
    }
}
