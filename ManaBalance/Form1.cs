using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManaBalance
{
    public partial class Form1 : Form
    {
        private double BlackMana = 0;
        private double WhiteMana = 0;
        private double BlueMana = 0;
        private double GreenMana = 0;
        private double RedMana = 0;
        private double ColorlessMana = 0;
        private double BlackCard = 0;
        private double WhiteCard = 0;
        private double BlueCard = 0;
        private double GreenCard = 0;
        private double RedCard = 0;
        private double ColorlessCard = 0;

        private void UpdateMana(double manaIncrease, double cardIncrease, string color)
        {
            switch (color)
            {
                case "Black":
                    if (BlackMana + manaIncrease < 0 || BlackCard + cardIncrease < 0)
                    {
                        return;
                    }
                    BlackMana = BlackMana + manaIncrease;
                    BlackCard = BlackCard + cardIncrease;
                    UpdateManaLabel(BlackMana.ToString(), BlackCard.ToString(), (BlackMana * 100 / BlackCard).ToString("N1"), lblSwampCount);
                    break;
                case "Blue":
                    if (BlueMana + manaIncrease < 0 || BlueCard + cardIncrease < 0)
                    {
                        return;
                    }
                    BlueMana = BlueMana + manaIncrease;
                    BlueCard = BlueCard + cardIncrease;
                    UpdateManaLabel(BlueMana.ToString(), BlueCard.ToString(), (BlueMana * 100 / BlueCard).ToString(), lblIslandCount);
                    break;
                case "Green":
                    if (GreenMana + manaIncrease < 0 || GreenCard + cardIncrease < 0)
                    {
                        return;
                    }
                    GreenMana = GreenMana + manaIncrease;
                    GreenCard = GreenCard + cardIncrease;
                    UpdateManaLabel(GreenMana.ToString(), GreenCard.ToString(), (GreenMana * 100 / GreenCard).ToString(), lblForestCount);
                    break;
                case "White":
                    if (WhiteMana + manaIncrease < 0 || WhiteCard + cardIncrease < 0)
                    {
                        return;
                    }
                    WhiteMana = WhiteMana + manaIncrease;
                    WhiteCard = WhiteCard + cardIncrease;
                    UpdateManaLabel(WhiteMana.ToString(), WhiteCard.ToString(), (WhiteMana * 100 / WhiteCard).ToString(), lblPlainsCount);
                    break;
                case "Red":
                    if (RedMana + manaIncrease < 0 || RedCard + cardIncrease < 0)
                    {
                        return;
                    }
                    RedMana = RedMana + manaIncrease;
                    RedCard = RedCard + cardIncrease;
                    UpdateManaLabel(RedMana.ToString(), RedCard.ToString(), (RedMana * 100 / RedCard).ToString(), lblMountainCount);
                    break;
                case "Colorless":
                    if (ColorlessMana + manaIncrease < 0 || ColorlessCard + cardIncrease < 0)
                    {
                        return;
                    }
                    ColorlessMana = ColorlessMana + manaIncrease;
                    ColorlessCard = ColorlessCard + cardIncrease;
                    UpdateManaLabel(ColorlessMana.ToString(), ColorlessCard.ToString(), (ColorlessMana * 100 / ColorlessCard).ToString(), lblColorlessCount);
                    break;
            }
        }

        private void UpdateManaLabel(string newValue, string oldValue, string percent, Label lbl)
        {
            if (percent.Equals("NaN", StringComparison.OrdinalIgnoreCase))
            {
                percent = "0%";
            }
            else if (percent.Equals("Infinity", StringComparison.OrdinalIgnoreCase))
            {
                percent = "100%";
            }
            else
            {
                percent = percent + "%";
            }
            lbl.Text = newValue + "/" + oldValue + " = " + percent;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button) sender;

            if (btn.Tag.ToString().Substring(0,1) == "-")
            {
                UpdateMana(0, -1, btn.Tag.ToString().Substring(1));
            }
            else
            {
                UpdateMana(0, 1, btn.Tag.ToString().Substring(1));                
            }
        }

        private void pbColorless_MouseUp(object sender, MouseEventArgs e)
        {
            UpdateMana(e.Button == MouseButtons.Right ? -1 : 1, 0, ((PictureBox) sender).Tag.ToString());
        }
    }
}
