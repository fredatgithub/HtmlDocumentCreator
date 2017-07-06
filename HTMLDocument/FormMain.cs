namespace HtmlDocumentCreator
{
  using System;
  using System.IO;
  using System.Windows.Forms;

  public partial class FormMain : Form
  {
    private HTMLDocument htmlDoc1 = new HTMLDocument("file1", "html");

    public FormMain()
    {
      this.InitializeComponent();
    }

    private static void SaveFile(string path, string data)
    {
      if (File.Exists(path))
      {
        File.AppendAllText(path, data);
      }
      else
      {
        File.WriteAllText(path, data);
      }
    }

    private void ButtonCreateClick(object sender, EventArgs e)
    {
      this.htmlDoc1.CreateHeader();
      this.htmlDoc1.OpenHead();
      this.htmlDoc1.OpenAndCloseTitle("Hello World");
      this.htmlDoc1.AddMetaTag();
      this.htmlDoc1.CloseHead();
      this.htmlDoc1.OpenBody();
      this.htmlDoc1.AddText("Hello World");
      this.htmlDoc1.AddReturnCarriage(2);
      this.htmlDoc1.AddText("This is my first HTML document created with HTML Document Creator.");
      this.htmlDoc1.CloseBody();
      this.htmlDoc1.CloseHTML();
      this.buttonSave.Enabled = true;
      MessageBox.Show("Your Html document has been created, you can save it if you want to view it.");
    }

    private void ButtonSaveClick(object sender, EventArgs e)
    {
      this.saveFileDialog1.Filter = "html files (*.html)|*.html|htm files (*.htm)|*.htm|All files (*.*)|*.*";
      this.saveFileDialog1.FilterIndex = 1;

      if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
      {
        if (!string.IsNullOrEmpty(this.htmlDoc1.HTMLFileName))
        {
          SaveFile(this.saveFileDialog1.FileName, this.htmlDoc1.HTMLDoc);
          this.webBrowser1.Navigate(this.saveFileDialog1.FileName);
        }
      }
    }

    private void FormMainLoad(object sender, EventArgs e)
    {
      this.buttonSave.Enabled = false;
    }
  }
}