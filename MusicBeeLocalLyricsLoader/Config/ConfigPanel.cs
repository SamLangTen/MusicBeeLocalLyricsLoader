using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MusicBeePlugin
{
    public partial class ConfigPanel : UserControl
    {
        public ConfigPanel()
        {
            InitializeComponent();
        }

        public string FilePattern { get => textBox2.Text; set => textBox2.Text = value; }
        public string SearchPath { get => textBox1.Text; set => textBox1.Text = value; }

        private void ConfigPanel_Load(object sender, EventArgs e)
        {
            label1.Text = LocalizationManager.ConfigPanelSearchPath;
            label2.Text = LocalizationManager.ConfigPanelFilePattern;
            label3.Text = LocalizationManager.ConfigPanelFilePatternDescription;
        }
    }
}
