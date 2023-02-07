using Ispan_XAMLUI_MauiApp.Models;

namespace Ispan_XAMLUI_MauiApp.Views;

public partial class CustomerSystem : ContentPage
{
	List<CCustomer> Mycustomers = new List<CCustomer>();
    private int currentId { get; set; }
    public CustomerSystem()
	{
		InitializeComponent();
        this.currentId = 0;
        this.Loaded += CustomerSystem_Loaded;
    }

    private void CustomerSystem_Loaded(object sender, EventArgs e)
    {
        // ¸ü¤J½d¨Ò¸ê®Æ
        Mycustomers.Add(new CCustomer()
        {
            id = 1,
            name = "John",
            phone = "12345678",
            address = "Taipei",
            email = "ass@bss.com"
        });
        Mycustomers.Add(new CCustomer()
        {
            id = 2,
            name = "Mike",
            phone = "246810",
            address = "Park",
            email = "fff@bss.com"
        });
        Mycustomers.Add(new CCustomer()
        {
            id = 3,
            name = "Japan",
            phone = "1357911",
            address = "Ispan",
            email = "ddd@bss.com"
        });
    }

    private void btnFirst_Clicked(object sender, EventArgs e)
	{
        txtId.Text = Mycustomers[0].id.ToString();
        txtName.Text = Mycustomers[0].name;
        txtAddress.Text = Mycustomers[0].address;
        txtEmail.Text = Mycustomers[0].email;
        txtPhone.Text = Mycustomers[0].phone;
    }

	private void btnPrevious_Clicked(object sender, EventArgs e)
	{
        if (currentId - 1 >= 0) currentId -= 1;
        txtId.Text = Mycustomers[currentId].id.ToString();
        txtName.Text = Mycustomers[currentId].name;
        txtAddress.Text = Mycustomers[currentId].address;
        txtEmail.Text = Mycustomers[currentId].email;
        txtPhone.Text = Mycustomers[currentId].phone;
    }

	private void btnNext_Clicked(object sender, EventArgs e)
	{
        if (currentId < Mycustomers.Count - 1) currentId += 1; 
        txtId.Text = Mycustomers[currentId].id.ToString();
        txtName.Text = Mycustomers[currentId].name;
        txtAddress.Text = Mycustomers[currentId].address;
        txtEmail.Text = Mycustomers[currentId].email;
        txtPhone.Text = Mycustomers[currentId].phone;
    }

	private void btnLast_Clicked(object sender, EventArgs e)
	{
        currentId = Mycustomers.Count - 1;
        txtId.Text = Mycustomers[currentId].id.ToString();
        txtName.Text = Mycustomers[currentId].name;
        txtAddress.Text = Mycustomers[currentId].address;
        txtEmail.Text = Mycustomers[currentId].email;
        txtPhone.Text = Mycustomers[currentId].phone;
    }

	private void btnQuery_Clicked(object sender, EventArgs e)
	{

	}

	private void btnList_Clicked(object sender, EventArgs e)
	{

	}
}