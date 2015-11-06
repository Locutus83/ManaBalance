using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManaBalance
{
    public partial class Form1 : Form
    {
        double BlackMana = 0, 
               WhiteMana = 0, 
               BlueMana = 0, 
               GreenMana = 0, 
               RedMana = 0, 
               ColorlessMana = 0, 
               BlackCard = 0, 
               WhiteCard = 0, 
               BlueCard = 0, 
               GreenCard = 0, 
               RedCard = 0, 
               ColorlessCard = 0;
        
        private enum ManaColor : int
        {
            Black = 0,
            White = 1,
            Blue = 2,
            Green = 3,
            Red = 4,
            Colorless = 5
        }

        private void UpdateManaLabel(double manaIncrease, double cardIncrease, ManaColor color)
        {
            switch (color)
            {
                case ManaColor.Black:
                    BlackMana = BlackMana + manaIncrease;
                    BlackCard = BlackCard + cardIncrease;
                    lblSwampCount.Text = BlackMana + "/" + BlackCard + " = " + (BlackMana / BlackCard);
                    break;
                case ManaColor.Blue:
                    BlueMana = BlueMana + manaIncrease;
                    BlueCard = BlueCard + cardIncrease;
                    lblIslandCount.Text = BlueMana + "/" + BlueCard + " = " + (BlueMana / BlueCard);
                    break;
                case ManaColor.Green:
                    GreenMana = GreenMana + manaIncrease;
                    GreenCard = GreenCard + cardIncrease;
                    lblForestCount.Text = GreenMana + "/" + GreenCard + " = " + (GreenMana / GreenCard);
                    break;
                case ManaColor.White:
                    WhiteMana = WhiteMana + manaIncrease;
                    WhiteCard = WhiteCard + cardIncrease;
                    lblPlainsCount.Text = WhiteMana + "/" + WhiteCard + " = " + (WhiteMana / WhiteCard);
                    break;
                case ManaColor.Red:
                    RedMana = RedMana + manaIncrease;
                    RedCard = RedCard + cardIncrease;
                    lblMountainCount.Text = RedMana + "/" + RedCard + " = " + (RedMana / RedCard);
                    break;
                case ManaColor.Colorless:
                    ColorlessMana = ColorlessMana + manaIncrease;
                    ColorlessCard = ColorlessCard + cardIncrease;
                    lblColorlessCount.Text = ColorlessMana + "/" + ColorlessCard + " = " + (ColorlessMana / ColorlessCard);
                    break;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void pbSwamp_Click(object sender, EventArgs e)
        {
            UpdateManaLabel(1, 0, ManaColor.Black);
        }

        private void pbPlains_Click(object sender, EventArgs e)
        {
            UpdateManaLabel(1, 0, ManaColor.White);
        }

        private void pbIsland_Click(object sender, EventArgs e)
        {
            UpdateManaLabel(1, 0, ManaColor.Blue);
        }

        private void pbForest_Click(object sender, EventArgs e)
        {
            UpdateManaLabel(1, 0, ManaColor.Green);
        }

        private void pbMountain_Click(object sender, EventArgs e)
        {
            UpdateManaLabel(1, 0, ManaColor.Red);
        }

        private void pbColorless_Click(object sender, EventArgs e)
        {
            UpdateManaLabel(1, 0, ManaColor.Colorless);
        }

        private void btnAddBlack_Click(object sender, EventArgs e)
        {
            UpdateManaLabel(0, 1, ManaColor.Black);
        }

        private void btnAddWhite_Click(object sender, EventArgs e)
        {
            UpdateManaLabel(0, 1, ManaColor.White);
        }

        private void btnAddBlue_Click(object sender, EventArgs e)
        {
            UpdateManaLabel(0, 1, ManaColor.Blue);
        }

        private void btnAddGreen_Click(object sender, EventArgs e)
        {
            UpdateManaLabel(0, 1, ManaColor.Green);
        }

        private void btnAddRed_Click(object sender, EventArgs e)
        {
            UpdateManaLabel(0, 1, ManaColor.Red);
        }

        private void btnAddColorless_Click(object sender, EventArgs e)
        {
            UpdateManaLabel(0, 1, ManaColor.Colorless);
        }
    }
}
