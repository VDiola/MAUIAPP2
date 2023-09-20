namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }


        private void ImgBtn1_Clicked(object sender, EventArgs e)
        {
            
            imgBtn1.Source = "img3.png";
            lbl1.Text = "Reality";
        }

        private void ImgBtn2_Clicked(object sender, EventArgs e)
        {
            
            imgBtn2.Source = "img4.png";
            lbl2.Text = "Reality";
        }

    }
}