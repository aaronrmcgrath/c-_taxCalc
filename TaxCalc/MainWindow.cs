using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnCalcTotalReleased (object sender, EventArgs e)
	{
		const double TAXRATE = 0.2;
		double subtotal = Double.Parse (subtotalTB.Text);
		double tax = subtotal * TAXRATE;
		double total = subtotal + tax;
		taxTB.Text = tax.ToString ();
		totalTB.Text = total.ToString ();
	}
}
