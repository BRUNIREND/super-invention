using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab_5_AIS
{
    
    public partial class Histagramm : Form
    {
        List<string> specialities { get; set; }

        public Histagramm(List<string> specs)
        {
            InitializeComponent();
            
            specialities = specs;
            fillHistogram();
        }
        
        
        
        public event EventHandler EventGetSpecialietesView = delegate { };

        public void fillHistogram()
        {

            Dictionary<string, int> specs = new Dictionary<string, int>();
            foreach (string s in specialities)
            {
                if (specs.ContainsKey(s)) specs[s]++;
                else specs.Add(s, 1);

            }
            foreach (var spec in specs)
            {
                chart1.Series[chart1.Series.Count() - 1].Points.AddXY(spec.Key, spec.Value);
            }
        }

    }
}