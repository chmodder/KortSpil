using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Spil S = new Spil();
        visStilling(S);
    }

    protected void ButtonTagKort_Click(object sender, EventArgs e)
    {
        Spil S = new Spil();
        //if (S.jegHarVundet())
        //{
        //    LabelMsg.Text = "Tillykke du har vundet";
        //}
        //else
        //{
        //    LabelMsg.Text = "Øv. Du har tabt!";
        //}
        //S.
        S.givComputerPoint();
        visStilling(S);
    }

    public void visStilling(Spil S)
    {
        LiteralSpillerPoint.Text = S.SpillerPoint.ToString();
        LiteralComputerPoint.Text = S.ComputerPoint.ToString();
    }

    // TODO

    // givSpillerPoint
    // KORT class
    // FIELDS: nummer, farve
    // METODER: Constructor
}