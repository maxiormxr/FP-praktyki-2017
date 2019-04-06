using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Sustar77ArcologyTerminal.Communication;
using System.IO;

namespace Sustar77ArcologyTerminal.Forms
{
    public partial class DoSomeActionForm : Form
    {
        IExperimentClient client = new ExperimentClient();
        User userData = new User();
        private sustar77ArcologyTerminalForm mainForm = null;
        private List<RadioButton> radioButtonList = new List<RadioButton>();

        List<string> previousList = new List<string>();
        List<string> actualList = new List<string>();
        List<string> onlyThisTurnList = new List<string>();

        public DoSomeActionForm(Form callingForm)
        {
            mainForm = callingForm as sustar77ArcologyTerminalForm;
            InitializeComponent();

            if (radioButtonList.Capacity == 0)
            {
                radioButtonList.Add(importFood);
                radioButtonList.Add(produce);
                radioButtonList.Add(buildArcology);
                radioButtonList.Add(clean);
                radioButtonList.Add(propaganda);
                radioButtonList.Add(expandPopulationCapacity);
                radioButtonList.Add(expandFoodCapacity);
                radioButtonList.Add(weAreReady);
                radioButtonList.Add(restart);
            }
        }

        private string whichCommandIsSelected(List<string> actionList)
        {
            for (int i = 0; i < radioButtonList.Capacity; i++)
            {
                if (radioButtonList[i].Checked) return actionList[i];
            }
            return null;
        }

        private void saveArcologyStateToLog(string selectedAction)
        {
            const string savePath = @"log.txt";
            if (!File.Exists(savePath))
            {
                File.Create(savePath);
            }
            StreamWriter logSaver = new StreamWriter(savePath, true);
            logSaver.WriteLine("=============================================================");
            logSaver.WriteLine("Action used: " + selectedAction);
            foreach (var item in mainForm.getListBox1().Items)
            {
                logSaver.WriteLine(item.ToString());
            }
            logSaver.WriteLine("Neho runes: ");
            foreach (var item in mainForm.getListBox2().Items)
            {
                logSaver.WriteLine(item.ToString());
            }

            createListOfEventsFromCurrentTurn();

            logSaver.WriteLine("Events: ");
            foreach (var item in onlyThisTurnList)
            {
                logSaver.WriteLine(item.ToString());
            }
            logSaver.WriteLine("=============================================================");
            logSaver.Close();
        }

        private void createListOfEventsFromCurrentTurn()
        {
            previousList.Clear();
            foreach (var item in actualList)
            {
                previousList.Add(item.ToString());
            }
            actualList.Clear();
            foreach (var item in mainForm.getListBox3().Items)
            {
                actualList.Add(item.ToString());
            }
            onlyThisTurnList.Clear();
            mainForm.clearListBox4();
            for (int i = previousList.Count; i < actualList.Count; i++)
            {
                onlyThisTurnList.Add(actualList[i]);
                mainForm.setEventsInListBox4(actualList[i]);
            }
        }

        private void clearLogIfRestart()
        {
            const string savePath = @"log.txt";
            if (!File.Exists(savePath))
            {
                File.Create(savePath);
            }
            StreamWriter logSaver = new StreamWriter(savePath, false);
            logSaver.Close();
        }

        private string letsDoThis()
        {
            string actionAndPoints = "";
            foreach (RadioButton element in radioButtonList)
            {
                string message;
                string selectedAction = element.Name;
                if (element.Checked)
                {
                    if (selectedAction == "produce" || selectedAction == "restart")
                    {
                        message = "Are you sure to execute " + selectedAction + "?";
                        var messageBoxObject = MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo);
                        if (messageBoxObject == DialogResult.Yes)
                        {
                            var response = client.Execute(whichCommandIsSelected(client.getActionList()));
                            MessageBox.Show("Succesfull execution of action: " + selectedAction +"\n" +"Status: " + Convert.ToString(response));
                            actionAndPoints = selectedAction;
                            if (selectedAction == "restart")
                            {
                                clearLogIfRestart();
                            }
                            return actionAndPoints;
                        }

                        else
                        {
                            MessageBox.Show("You blocked execution of " + selectedAction + " action");
                            return "blocked";
                        }
                    }
                    else
                    {
                        message = "Are you sure to execute " + selectedAction + " with parameter value = " + setParameterTrackBar.Value + "?";
                        var messageBoxObject = MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo);
                        if (messageBoxObject == DialogResult.Yes)
                        {
                            var response = client.Execute(whichCommandIsSelected(client.getActionList()), Convert.ToString(setParameterTrackBar.Value));
                            MessageBox.Show("Action " + selectedAction + " was taken" + "\n" + "Status: " + Convert.ToString(response));
                            actionAndPoints = selectedAction + ": " + Convert.ToString(setParameterTrackBar.Value);
                            return actionAndPoints;
                        }
                        else
                        {
                            MessageBox.Show("You blocked execution of " + selectedAction + " action");
                            return "blocked";
                        }
                    }
                }
            }
            return "";
        }
        
        private void DoSomeActionForm_FormClosed(object sender, EventArgs e)
        {
            mainForm.removeElementFromExecuteCommandFormList();
        }

        private void setParameterTrackBar_Scroll(object sender, EventArgs e)
        {
            parameterValueTextBox.Text = Convert.ToString(setParameterTrackBar.Value);
        }

        private void DoSomeActionForm_Load(object sender, EventArgs e)
        {
            parameterValueTextBox.Text = Convert.ToString(setParameterTrackBar.Value);
        }

        private void parameterValueTextBox_TextChanged(object sender, EventArgs e)
        {
            int parameterValue;

            try
            {
                parameterValue = Convert.ToInt32(parameterValueTextBox.Text);
            }
            catch(System.FormatException)
            {
                parameterValue = 1;
            }
            try
            {
                setParameterTrackBar.Value = Convert.ToInt32(parameterValueTextBox.Text);
            }
            catch(System.ArgumentOutOfRangeException)
            {
                if (parameterValue < 1)
                {
                    setParameterTrackBar.Value = 1;
                    parameterValueTextBox.Text = "1";
                }
                else
                {
                    setParameterTrackBar.Value = 200;
                    parameterValueTextBox.Text = "200";
                }
            }
            catch(System.FormatException)
            {
                parameterValueTextBox.Clear();
            }

            if (parameterValueTextBox.Text == "01" || parameterValueTextBox.Text == "001")
                parameterValueTextBox.Text = "1";
        }

        private void importFoodRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            setParameterTrackBar.Enabled = true;
            parameterValueTextBox.Enabled = true;
        }

        private void produceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            setParameterTrackBar.Enabled = false;
            parameterValueTextBox.Enabled = false;
        }

        private void propagandaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            setParameterTrackBar.Enabled = true;
            parameterValueTextBox.Enabled = true;
        }

        private void cleanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            setParameterTrackBar.Enabled = true;
            parameterValueTextBox.Enabled = true;
        }

        private void buildArcologyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            setParameterTrackBar.Enabled = true;
            parameterValueTextBox.Enabled = true;
        }

        private void expandPopulationCapacityRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            setParameterTrackBar.Enabled = true;
            parameterValueTextBox.Enabled = true;
        }

        private void expandFoodCapacityRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            setParameterTrackBar.Enabled = true;
            parameterValueTextBox.Enabled = true;
        }

        private void weAreReadyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            setParameterTrackBar.Enabled = true;
            parameterValueTextBox.Enabled = true;
        }

        private void restartRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            setParameterTrackBar.Enabled = false;
            parameterValueTextBox.Enabled = false;
        }

        private void parameterValueTextBox_Click(object sender, EventArgs e)
        {
            parameterValueTextBox.Clear();
        }

        private void letsDoThisButton_Click(object sender, EventArgs e)
        {
            string action = letsDoThis();
            mainForm.callMethodDescribe();
            if (action != "blocked")
            {
                saveArcologyStateToLog(action);
            }
        }
    }
}
