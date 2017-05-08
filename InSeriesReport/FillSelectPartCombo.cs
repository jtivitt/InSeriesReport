namespace Jan19School
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            PopulatingCombo();
        }

        private void PopulatingCombo()
        {
            //creating new dataTable (you will populate table from sql query):
            DataTable table = new DataTable("Schools");
            table.Columns.Add(new DataColumn("school_number", typeof(int)));
            table.Columns.Add(new DataColumn("school_name", typeof(string)));

            //setting primary key:
            table.Columns["school_number"].Unique = true;
            table.PrimaryKey = new DataColumn[] { table.Columns["school_number"] };

            //filling table:      
            for (int i = 0; i < 5; i++)
            {
                //numbers from 10-14 and with coresponding names from names[] array
                table.Rows.Add(new object[] { i + 1, string.Format("School {0}", i + 1) });
            }

            //populating comboBox:
            comboBox1.DataSource = table;
            comboBox1.DisplayMember = "school_name";
            comboBox1.ValueMember = "school_number";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                try
                {
                    int value = (int)comboBox1.SelectedValue;
                    YourFunctionToDo(value);
                }
                catch
                {
                    //when populating comboBox with dataSource, the index changes, 
                    //so the code will come in here and there will be an error on the upper line
                    //thats why you have to use try, catch statement
                }
            }
        }

        private void YourFunctionToDo(int value)
        {
            //use the selected value, this is school number in here (use parameter "value"):
            label1.Text = "School number is " + value.ToString();
        }
    }
}