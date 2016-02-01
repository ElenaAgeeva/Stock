using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurnitureInStock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SolveWithGeneticAlgorithm_Click(object sender, EventArgs e)
        {
            Population population = new Population(20, 7, 2);
            population.FormInitialPopulation();
        }
    }
}
