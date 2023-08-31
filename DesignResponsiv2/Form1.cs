namespace DesignResponsiv2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      void  RenderizaInterface()
        {
            //WIDTH -> largura
            //HEIGH -> altura
           
            WindowState = FormWindowState.Maximized;
            //jogar o panel para o meio da tela
            panel.Location = new Point(ClientSize.Width/2 - panel.Size.Width/2 +150,ClientSize.Height/2 - panel.Size.Height/2 +100);

            //menu esquerdo
            menuEsquerdo.Location = new Point(0, 0);
            menuEsquerdo.Size = new Size(300,ClientSize.Height);

            menuEmCima.Location = new Point(300, 0);
            menuEmCima.Size = new Size(ClientSize.Width, 200);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RenderizaInterface();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void wilBitPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}