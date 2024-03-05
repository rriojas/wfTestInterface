namespace wfTestInterface
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnSpeak_Click(object sender, EventArgs e)
    {
      Cat myCat = new Cat();
      myCat.Name = txtName.Text;
      myCat.Species = txtSpecie.Text;
      lblSpeak.Text = myCat.Name + "[" + myCat.Species +"] " + myCat.Speak(txtSound.Text);
    }
  }
}
