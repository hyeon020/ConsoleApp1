using System;
using System.Windows.Forms;


class WinFormApp : Form
{
    WinFormApp()
    {
        Text = "Hello World!";
    }
    public static void main()
    {
        Application.Run(new WinFormApp());
    }
}
