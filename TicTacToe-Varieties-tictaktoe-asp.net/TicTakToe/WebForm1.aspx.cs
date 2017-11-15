using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TicTakToe
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public static int player = 2;
        public int s1=0;
        public int s2 = 0;
        public int sd = 0;

        protected void Page_Load(object OBJ, EventArgs e)
        {
            Message.Text = "Player X Turn";
        }

        private void disableButtons()
        {
            A1.Enabled = A2.Enabled = A3.Enabled = B1.Enabled = B2.Enabled = B3.Enabled = C1.Enabled = C2.Enabled = C3.Enabled = false;
        }
        protected void ButtonClick(object sender, EventArgs e)
        {
            Button button =(Button) sender;

            if (button.Text == " ")
            {
                if (player % 2 == 0)
                {
                    Message.Text = "Player O Turn !";
                    button.Text = "X";
                    if(Winner()== true)
                    {
                        Message.Text = "Player O Is The Winner !";
                        disableButtons();
                    }
                    player++;
                }
                else
                {
                    Message.Text = "Player X Turn !";
                    button.Text = "O";
                    if (Winner() == true)
                    {
                        Message.Text = "Player X Is The Winner !";
                        disableButtons();
                    }
                    player++;
                }
                if(Draw()==true)
                {
                    Message.Text = "Match is Draw.!!!!";
                }
            }
        }
        protected bool Winner()
        {
            if(A1.Text== A2.Text && A2.Text==A3.Text && A1.Text!=" ")
            {
                return true;
            }
            if (B1.Text == B2.Text && B2.Text == B3.Text && B1.Text != " ")
            {
                return true;
            }
            if (C1.Text == C2.Text && C2.Text == C3.Text && C1.Text != " ")
            {
                return true;
            }
            if (A1.Text == B1.Text && B1.Text == C1.Text && A1.Text != " ")
            {
                return true;
            }
            if (A2.Text == B2.Text && B2.Text == C2.Text && A2.Text != " ")
            {
                return true;
            }
            if (A3.Text == B3.Text && B3.Text == C3.Text && A3.Text != " ")
            {
                return true;
            }
            if (A1.Text == B2.Text && B2.Text == C3.Text && A1.Text != " ")
            {
                return true;
            }
            if (A3.Text == B2.Text && B2.Text == C1.Text && A3.Text != " ")
            {
                return true;
            }
          return false;
        }
        public bool Draw()
        {
            if(A1.Text!=" " && A2.Text != " " && A3.Text != " " && B1.Text != " " && B2.Text != " " && B3.Text != " " && C1.Text != " " && C2.Text != " " && C3.Text != " " )
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        protected void Restart_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }
    }
    }