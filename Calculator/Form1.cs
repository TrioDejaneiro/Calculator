namespace Calculator
{
    public partial class Form1 : Form
    {
        private double firstNumber = 0;
        private double secondNumber = 0;
        private string operation = "";
        public Form1()
        {
            InitializeComponent();
        }

        


        private void button_9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox_Text.Text += button.Text;
        }

        private void button_add_Click_1(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            firstNumber = double.Parse(textBox_Text.Text);
            operation = button.Text;
            textBox_Text.Text += button.Text;
            //textBox_Text.Clear();
        }

        private void button_equals_Click(object sender, EventArgs e)
        {
            string expression = textBox_Text.Text;

            //expression = expression.Replace(',', '.');


            char[] operators = { '+', '-', '*', '/' };
            int operatorIndex = expression.IndexOfAny(operators);


            // �������� ������ � ������ �����
            if (!double.TryParse(expression.Substring(0, operatorIndex).Trim(), out firstNumber))
            {
                MessageBox.Show("����������� ������ ������� �����.", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Text.Text = string.Empty;
            }

            if (!double.TryParse(expression.Substring(operatorIndex + 1).Trim(), out secondNumber))
            {
                MessageBox.Show("����������� ������ ������� �����.", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Text.Text = string.Empty;
            }

            double result = 0;

            // ��������� ��������������� ��������
            switch (operation)
            {
                case "+":
                    Addition addition = new Addition(firstNumber, secondNumber);
                    result = addition.Add();  // ��������� ��������
                    break;
                case "-":
                    Subtraction subtraction = new Subtraction(firstNumber, secondNumber);
                    result = subtraction.Subtract();  // ��������� ���������
                    break;
                case "*":
                    Multiplication multiplication = new Multiplication(firstNumber, secondNumber);
                    result = multiplication.Multiply();  // ��������� ���������
                    break;
                case "/":
                    Division division = new Division(firstNumber, secondNumber);
                    if (division.Divide() != -1 && secondNumber != 0)
                        result = division.Divide();  // ��������� �������
                    else
                    {
                        MessageBox.Show("ĳ����� �� 0 ���������", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
            textBox_Text.Text = result.ToString().Replace('.', ',');
          
        }

        private void button_c_Click(object sender, EventArgs e)
        {
            textBox_Text.Clear();  // ������� �������
            firstNumber = 0;
            secondNumber = 0;
            operation = "";
        }

        private void button_coma_Click(object sender, EventArgs e)
        {

            if (!textBox_Text.Text.Contains(","))
            {
                textBox_Text.Text += ",";
            }
        }
    }
}
