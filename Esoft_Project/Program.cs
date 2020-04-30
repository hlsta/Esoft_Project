
using Esoft_Project;
using System;
using System.Windows.Forms;

static class Program
    {
    /// <summary>
    public static Esoft_ProjectEntities2 esoft = new Esoft_ProjectEntities2();
    /// Главная точка входа для приложения.
    /// </summary>
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Esoft_Project.Menu());
    }
    }

