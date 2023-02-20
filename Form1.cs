using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Collections.Generic;

namespace GuiDemo;

public partial class Form1 : Form
{
    
    public Form1()
    {
        InitializeComponent();
        textBox1.Text = "0.0";
        textBox2.Text = "0.0";
        textBox3.Text = "0.0";
    }
    private void button1_Click_1(object sender, EventArgs e)
    {
        MessageBox.Show("Button Click");
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label6_Click(object sender, EventArgs e)
    {

    }

    private void label8_Click(object sender, EventArgs e) 
    {
        
    }

    // Trayectoria km
    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        string trayecto = textBox1.Text;
        if (!double.TryParse(trayecto, out double d))
        {
            textBox1.Text = "0.0";
        }
        else
        {
            // Actualizar Costo Operario y Costo Comida
        
            double costo_operario = 850.0 / 350.0 * Convert.ToDouble(trayecto);
            textBox12.Text = costo_operario.ToString();

            double costo_comida = 200.0 / 350.0 * Convert.ToDouble(trayecto);
            textBox13.Text = costo_comida.ToString();

            // Actualizar Parametros de Rendimiento
            double rend_descargado = 25.6;
            double rend25 = 0.9 * rend_descargado;
            double rend50 = 0.7 * rend_descargado;
            double rend100 = 9.0 * 1.6;
            textBox11.Text = rend_descargado.ToString();
            textBox10.Text = rend25.ToString();
            textBox9.Text = rend50.ToString();
            textBox8.Text = rend100.ToString();

            
            //double precio_dep = Convert.ToDouble(textBox3.Text);
            
            //if (textBox2.Text != null && textBox3.Text != null) {
                
            //    double cost25 = ((Convert.ToDouble(trayecto) / rend25) * (precio_diesel + precio_dep) + Convert.ToDouble(trayecto) / rend_descargado * (precio_diesel + precio_dep));
            //    double cost50 = ((Convert.ToDouble(trayecto) / rend50) * (precio_diesel + precio_dep) + Convert.ToDouble(trayecto) / rend_descargado * (precio_diesel + precio_dep));
            //    double cost100 = ((Convert.ToDouble(trayecto) / rend100) * (precio_diesel + precio_dep) + Convert.ToDouble(trayecto) / rend_descargado * (precio_diesel + precio_dep));
            //}
        }   
    }

    // Precio Diesel galon
    private void textBox2_TextChanged(object sender, EventArgs e)
    {
        
        if (double.TryParse(textBox2.Text, out double d) || int.TryParse(textBox2.Text, out int i))
        {
            textBox3_TextChanged(sender, e);
            double precio_dep = Convert.ToDouble(textBox2.Text) * 0.25;
            textBox3.Text = precio_dep.ToString();
        }
        else
        {
            textBox2.Text = "0.0";
            textBox3.Text = "0.0";
        }
    }

    // Precio depreciacion
    private void textBox3_TextChanged(object sender, EventArgs e)
    {
        
    }

    // Rendimiento descargado
    private void textBox11_TextChanged(object sender, EventArgs e)
    {
        if (!Double.TryParse(textBox11.Text, out double d))
        {
            textBox11.Text = "0.0";
        }
        else
        {
            // Actualizar rendimientos
            

            // Actualizar costos / retornos
           

            // Actualizar costos totales
           

            // Actualizar cobros
            

        }
    }

    // Rendimiento 25%
    private void textBox10_TextChanged(object sender, EventArgs e)
    {
        
    }

    // Rendimiento 50%
    private void textBox9_TextChanged(object sender, EventArgs e)
    {
        
    }

    // Rendimiento 100%
    private void textBox8_TextChanged(object sender, EventArgs e)
    {
        
    }

    // Costo 25% Retorno 0
    private void textBox7_TextChanged(object sender, EventArgs e)
    {
        
    }

    // Costo 50% Retorno 0
    private void textBox6_TextChanged(object sender, EventArgs e)
    {
        
    }

    // Cost a mas de 50% retorno 0
    private void textBox5_TextChanged(object sender, EventArgs e)
    {
        
    }

    // Costo operario por dia
    private void textBox4_TextChanged(object sender, EventArgs e)
    {
       
    }

    // Costo comida por dia
    private void textBox15_TextChanged(object sender, EventArgs e)
    {
       
    }

    // Costo total al 0 - 25%
    private void textBox14_TextChanged(object sender, EventArgs e)
    {
        
    }

    // Costo total al 25 - 50%
    private void textBox13_TextChanged(object sender, EventArgs e)
    {
        
    }

    // Costo total mas del 50%
    private void textBox12_TextChanged(object sender, EventArgs e)
    {
        
    }

    // Cobrar 0 - 25
    private void textBox16_TextChanged(object sender, EventArgs e)
    {
        
    }
}
