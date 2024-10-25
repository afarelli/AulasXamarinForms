public MainPage()
{
  InitializeComponent();
  btn_calcular.Clicked += calcular;
}

private void calcular(object sender, EventArgs args)
{
  double nota1, nota2, nota3, media;
  try
  {
    nota1 = Convert.ToDouble(txt_nota1.Text);
    nota2 = Convert.ToDouble(txt_nota2.Text);
    nota3 = Convert.ToDouble(txt_nota3.Text);
    media = (nota1 + nota2 + nota3) / 3;
    lbl_media.Text = "Sua media é:" + media.ToString();
    DisplayAlert("Mensagem", "Sua nota é:" + media.ToString(), "OK");
  }
  catch (FormatException ex)
  {
    // Handle the exception, e.g., display an error message to the user
    DisplayAlert("Erro", "Por favor, insira notas válidas.", "OK");
  }
}