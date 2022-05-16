using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlipCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cardBackButton_Click(object sender, EventArgs e)
        {
            // When button to show back of the card clicked we set visibility property of cardBack to true
            // to make it visible and cardFace to false to make it invisible
            cardBack.Visible = true;
            cardFace.Visible = false;
        }

        private void cardFaceButton_Click(object sender, EventArgs e)
        {
            // When button to show face of the card clicked we set visibility property of cardBack to false
            // to make it invisible and cardFace to true to make it visible
            cardBack.Visible = false;
            cardFace.Visible = true;
        }
    }
}
