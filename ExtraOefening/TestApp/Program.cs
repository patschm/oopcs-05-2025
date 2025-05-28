
namespace TestApp;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        //ApplicationConfiguration.Initialize();
        //Application.Run(new Form1());

        Form1 form = new Form1();
        form.Text = "TestApp";

        TextBox tb = new TextBox();
        tb.Location = new Point(100, 200);
        form.Controls.Add(tb);

        Button button = new Button();
        button.Text = "Click Me";
        button.Location = new Point(100, 250);
        button.Click += DoeIets;
        form.Controls.Add(button);

        form.MouseMove += Mooove;
        form.ShowDialog();
    }

    private static void Mooove(object? sender, MouseEventArgs e)
    {
        if (sender is Form form)
        {
            form.Controls[0].Text = $"X: {e.X}, Y: {e.Y}";
        }
    }

    static void DoeIets(object? sender, EventArgs e)
    {
        if (sender is Button button)
        {
            button.Parent.BackColor = Color.Red;
        }
        
    }
}