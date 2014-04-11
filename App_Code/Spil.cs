using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

public class Spil
{
    // FIELDS
    private int _spillerPoint;
    private int _computerPoint;

    // Properties
    #region PROPERTIES

    public int SpillerPoint
    {
        get { return this._spillerPoint; }
        set { this._spillerPoint = value; }
    }
    public int ComputerPoint
    {
        get { return this._computerPoint; }
        set { this._computerPoint = value; }
    }
    #endregion

    // CONSTRUCTOR Metoden
    public Spil()
    {
        // Ligger der et spil i session?
        if (HttpContext.Current.Session["Spil"] == null)
        {
            // NEJ
            this._spillerPoint = 0;
            this._computerPoint = 0;
            HttpContext.Current.Session["Spil"] = this;
        }
        else
        {
            // JA
            Spil gammeltSpil = (Spil)HttpContext.Current.Session["Spil"];
            this._computerPoint = gammeltSpil.ComputerPoint;
            this._spillerPoint = gammeltSpil.SpillerPoint;
        }
    }

    /// <summary>
    /// Giver computeren 1 point og gemmer i session.
    /// </summary>
    public void givComputerPoint()
    {
        this._computerPoint++;
        HttpContext.Current.Session["Spil"] = this;
    }
}
