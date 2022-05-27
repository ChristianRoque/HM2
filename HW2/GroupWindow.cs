namespace HW2
{
    public partial class GroupWindow : Form
    {
        public GroupWindow()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(Properties.Settings.Default.WindowWidth, Properties.Settings.Default.WindowHeight);
        }

        private int isValid()
        {
            string myText = this.textBox1.Text;
            if (myText.Length == 0)
            {
                return 2;
            }
            if (myText.Length > 15)
            {
                return 3;
            }
            for (int i = 0; i < myText.Length; i++) 
            {
                if (myText[i] == ' ')
                {
                    return 4;
                }
            }
            return 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (this.isValid())
            {
                case 1:
                    this.listView1.Items.Add(this.textBox1.Text);
                    break;
                case 2:
                    MessageBox.Show("Empty field.");
                    break;
                case 3:
                    MessageBox.Show("Longer than 15 characters.");
                    break;
                case 4:
                    MessageBox.Show("Name contains a space.");
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(Properties.Settings.Default.WindowWidth, Properties.Settings.Default.WindowHeight);
        }
    }
}