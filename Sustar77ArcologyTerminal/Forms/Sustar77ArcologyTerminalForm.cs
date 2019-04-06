using Sustar77ArcologyTerminal.Communication;
using Sustar77ArcologyTerminal.Forms;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Sustar77ArcologyTerminal
{
    public partial class sustar77ArcologyTerminalForm : Form
    {
        IExperimentClient client = new ExperimentClient();
        User userData = new User();
        DoSomeActionForm executeCommandForm;
        List<DoSomeActionForm> executeCommandFormList = new List<DoSomeActionForm>();

        public sustar77ArcologyTerminalForm()
        {
            InitializeComponent();
        }

        private void describeButton_Click(object sender, EventArgs e)
        {
            callMethodDescribe();
        }

        private void executeCommadsButton_Click(object sender, EventArgs e)
        {
            if (executeCommandFormList.Count == 0)
            {
                executeCommandForm = new DoSomeActionForm(this);
                executeCommandFormList.Add(executeCommandForm);
                executeCommandForm.Show();
            }
            executeCommandForm.Focus();
        }

        public void removeElementFromExecuteCommandFormList()
        {
            executeCommandFormList.Clear();
        }

        public void callMethodDescribe()
        {
            var response = client.Describe(userData.getUserLogin(), userData.getUserToken());

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            listBox1.Items.Add($"Current turn: {response.Turn}");
            listBox1.Items.Add($"Should I restart experiment and cry: {response.ShouldIRestartExperimentAndCry}");
            listBox1.Items.Add($"Is terminated: {response.IsTerminated}");
            listBox1.Items.Add($"Event score: {response.EventScore}");
            listBox1.Items.Add($"Experiment score: {response.ExperimentScore}");
            listBox1.Items.Add($"Total score: {response.TotalScore}");
            listBox1.Items.Add($"Food quantity: {response.FoodQuantity}");
            listBox1.Items.Add($"Waste: {response.Waste}");
            listBox1.Items.Add($"Social capital: {response.SocialCapital}");
            listBox1.Items.Add($"Production: {response.Production}");
            listBox1.Items.Add($"Food capacity: {response.FoodCapacity}");
            listBox1.Items.Add($"Arcology integrity: {response.ArcologyIntegrity}");
            listBox1.Items.Add($"Population: {response.Population}");
            listBox1.Items.Add($"Population capacity: {response.PopulationCapacity}");

            try
            {
                for (int i = 0; i < response.NehoRunes.Count; i++)
                {
                    listBox2.Items.Add($"{response.NehoRunes[i]}");
                }
            }
            catch (System.NullReferenceException)
            {
                listBox2.Items.Add("You don't have any Neho Runes");
            };

            try
            {
                for (int i = 0; i < response.Events.Count; i++)
                {
                    listBox3.Items.Add(response.Events[i]);
                }
            }
            catch (System.NullReferenceException)
            {
                listBox3.Items.Add("Any event didn't occur");
            };

        }

        public ListBox getListBox1()
        {
            return listBox1;
        }

        public ListBox getListBox2()
        {
            return listBox2;
        }

        public ListBox getListBox3()
        {
            return listBox3;
        }
        public void setEventsInListBox4(string events)
        {
            listBox4.Items.Add(events);
        }
        public void clearListBox4()
        {
            listBox4.Items.Clear();
        }
    }
}
