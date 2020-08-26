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

        public List<string> FilePattern
        {
            get => textBox2.Lines.ToList();
            set => textBox2.Lines = value.ToArray();
        }
        public List<string> SearchPath
        {
            get => textBox1.Lines.ToList();
            set => textBox1.Lines = value.ToArray();
        }

        private void ConfigPanel_Load(object sender, EventArgs e)
        {
            label1.Text = LocalizationManager.ConfigPanelSearchPath;
            label2.Text = LocalizationManager.ConfigPanelFilePattern;
            label3.Text = LocalizationManager.ConfigPanelFilePatternDescription;
        }
    }
}
