namespace DenemelerZafer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Perfect Number
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime now1 = DateTime.Now;

            listBox1.Items.Clear();
            int j, sum;
            int number = Convert.ToInt32(textBox1.Text);
            j = 2;

            while (j <= number)
            {
                sum = 0;
                for (int i = 1; i <= j / 2; i++)
                {
                    if (j % i == 0)
                    {
                        sum += i;
                    }
                }

                if (sum == j)
                {
                    listBox1.Items.Add(j);
                }
                j += 2;
            }
            DateTime now2 = DateTime.Now;
            MessageBox.Show(Convert.ToString(now2 - now1));
        }
        //Perfect Number

        //Creating an array by taking values ​​from listBox and finding the min, max and sum. 
        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox2.Text);
            textBox2.Clear();
            textBox2.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[listBox2.Items.Count];
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = Convert.ToInt32(listBox2.Items[i]);
            Array.Sort(numbers);
            label5.Text = numbers[0].ToString();
            label6.Text = numbers[numbers.Length - 1].ToString();

            int sum = 0;
            foreach (int j in numbers)
                sum += j;
            label7.Text = sum.ToString();
        }
        //Creating an array by taking values ​​from listBox and finding the min, max and sum.
    }
}