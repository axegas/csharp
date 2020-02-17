using System;
using Gtk;
using Calculadora;

public partial class MainWindow : Gtk.Window
{
    private double op1;
    private double op2;
    private double resultado;
    private char operacion;
    private bool operado = false;
    Cientifica cientifica;
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
    protected void insertaNumero(string n)
    {
        string pantalla;
        if (operado)
        {
            entry1.DeleteText(0, entry1.Text.Length);
            entry1.InsertText(n);
            operado = false;
        }
        else
        {           
            pantalla = entry1.Text;
            entry1.DeleteText(0, entry1.Text.Length);
            entry1.InsertText(pantalla + n);
        }
    }
    protected void InsertaOp(char n)
    {
        if (!entry1.Text.Equals(""))
        {
            operacion = n;
            op1 = double.Parse(entry1.Text);
            entry1.DeleteText(0, entry1.Text.Length);
        }

    }
    protected void OnClick9(object sender, EventArgs e)
    {
        insertaNumero("9");
    }
    protected void OnClick8(object sender, EventArgs e)
    {
        insertaNumero("8");
    }
    protected void OnClick7(object sender, EventArgs e)
    {
        insertaNumero("7");
    }

    protected void OnClick6(object sender, EventArgs e)
    {
        insertaNumero("6");
    }

    protected void OnClick5(object sender, EventArgs e)
    {
        insertaNumero("5");
    }

    protected void OnClick4(object sender, EventArgs e)
    {
        insertaNumero("4");
    }

    protected void OnClick3(object sender, EventArgs e)
    {
        insertaNumero("3");
    }

    protected void OnClick2(object sender, EventArgs e)
    {
        insertaNumero("2");
    }

    protected void OnClick1(object sender, EventArgs e)
    {
        insertaNumero("1");
    }

    protected void OnClick0(object sender, EventArgs e)
    {
        insertaNumero("0");
    }

    protected void OnClickComa(object sender, EventArgs e)
    {
        if (entry1.Text.IndexOf(',') < 0)
        {
            insertaNumero(",");
        }
    }
    protected void OnClickReset(object sender, EventArgs e)
    {
        entry1.DeleteText(0, entry1.Text.Length);
        op1 = 0;
        op2 = 0;
        resultado = 0;
        operado = false;
    }

    protected void OnClickBorrar(object sender, EventArgs e)
    {
        if (!operado)
        {
            entry1.DeleteText(entry1.Text.Length - 1, entry1.Text.Length);
        }
    }

    protected void OnClickDividir(object sender, EventArgs e)
    {
        InsertaOp('/');
    }

    protected void OnClickMult(object sender, EventArgs e)
    {
        InsertaOp('*');
    }

    protected void OnClickRest(object sender, EventArgs e)
    {
        InsertaOp('-');
    }

    protected void OnClickSuma(object sender, EventArgs e)
    {
        InsertaOp('+');
    }

    protected void OnClickIgual(object sender, EventArgs e)
    {
        op2= double.Parse(entry1.Text);
        switch (operacion)
        {
            case '/':
                resultado = op1 / op2;
                break;
            case '*':
                resultado = op1 * op2;
                break;
            case '+':
                resultado = op1 + op2;
                break;
            case '-':
                resultado = op1 - op2;
                break;
            default:
                break;

        }
        entry1.Text = resultado.ToString();
        op1 = resultado;
        operado = true;
    }

    protected void OnClickCient(object sender, EventArgs e)
    {
        cientifica = new Cientifica(vbox5);

    }


}
