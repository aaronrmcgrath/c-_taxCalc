
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;

	private global::Gtk.Entry taxTB;

	private global::Gtk.Entry totalTB;

	private global::Gtk.Button calcTotal;

	private global::Gtk.Entry subtotalTB;

	private global::Gtk.Label subtotalLabel;

	private global::Gtk.Label taxLabel;

	private global::Gtk.Label totalLabel;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.taxTB = new global::Gtk.Entry();
		this.taxTB.CanFocus = true;
		this.taxTB.Name = "taxTB";
		this.taxTB.IsEditable = true;
		this.taxTB.InvisibleChar = '●';
		this.fixed1.Add(this.taxTB);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.taxTB]));
		w1.X = 150;
		w1.Y = 100;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.totalTB = new global::Gtk.Entry();
		this.totalTB.CanFocus = true;
		this.totalTB.Name = "totalTB";
		this.totalTB.IsEditable = true;
		this.totalTB.InvisibleChar = '●';
		this.fixed1.Add(this.totalTB);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.totalTB]));
		w2.X = 150;
		w2.Y = 150;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.calcTotal = new global::Gtk.Button();
		this.calcTotal.CanFocus = true;
		this.calcTotal.Name = "calcTotal";
		this.calcTotal.UseUnderline = true;
		this.calcTotal.Label = global::Mono.Unix.Catalog.GetString("Calculate Total");
		this.fixed1.Add(this.calcTotal);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.calcTotal]));
		w3.X = 150;
		w3.Y = 200;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.subtotalTB = new global::Gtk.Entry();
		this.subtotalTB.CanFocus = true;
		this.subtotalTB.Name = "subtotalTB";
		this.subtotalTB.IsEditable = true;
		this.subtotalTB.InvisibleChar = '●';
		this.fixed1.Add(this.subtotalTB);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.subtotalTB]));
		w4.X = 150;
		w4.Y = 50;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.subtotalLabel = new global::Gtk.Label();
		this.subtotalLabel.Name = "subtotalLabel";
		this.subtotalLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Enter Amount");
		this.fixed1.Add(this.subtotalLabel);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.subtotalLabel]));
		w5.X = 60;
		w5.Y = 50;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.taxLabel = new global::Gtk.Label();
		this.taxLabel.Name = "taxLabel";
		this.taxLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Tax");
		this.fixed1.Add(this.taxLabel);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.taxLabel]));
		w6.X = 110;
		w6.Y = 100;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.totalLabel = new global::Gtk.Label();
		this.totalLabel.Name = "totalLabel";
		this.totalLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Total");
		this.fixed1.Add(this.totalLabel);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.totalLabel]));
		w7.X = 105;
		w7.Y = 150;
		this.Add(this.fixed1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 300;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.calcTotal.Released += new global::System.EventHandler(this.OnCalcTotalReleased);
	}
}