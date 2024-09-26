using System.Diagnostics;
using System.Drawing.Text;
using System.Management;



namespace ProcessDispatcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void PrintAllProcessList()
        {
            int num = 1;
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Process");
                ManagementObjectCollection processes = searcher.Get();

                foreach (ManagementObject process in processes)
                {
                    string processName = process["Name"].ToString();
                    int processId = int.Parse(process["ProcessId"].ToString());
                    long pagedMemorySize = long.Parse(process["WorkingSetSize"].ToString());
                    DateTime startTime = ManagementDateTimeConverter.ToDateTime(process["CreationDate"].ToString());

                    dataGridView1.Rows.Add(num, processName, processId, pagedMemorySize, startTime);
                    num++;
                }
            }
            catch (Exception ex)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add("Ошибка", ex.Message);
            }
        }

        private void GetProcessButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            PrintAllProcessList();
        }

        private void RefreshProcessListButton_Click(Object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                PrintAllProcessList();
            }

            catch (Exception ex)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add($"Ошибка: {ex.Message}");
            }
        }

        private void KillProcessButton_Click(object sender, EventArgs e)
        {
            int processId = (int)dataGridView1.SelectedCells[0].Value;
            Process process = Process.GetProcessById(processId);
            try
            {
                process.Kill();
            }

            catch ( Exception ex ) 
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add($"Ошибка: {ex.Message}");
            }
            dataGridView1.Rows.Clear();
            PrintAllProcessList();
        }

        private void Load_Form1()
        {
            dataGridView1.Rows.Clear();
            PrintAllProcessList();
        }

        private void SortByProcessName()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Process");
            ManagementObjectCollection processes = searcher.Get();

            var sortedProcesses = processes.Cast<ManagementObject>().OrderBy(process => process["Name"].ToString());

            dataGridView1.Rows.Clear();

            int num = 1;

            try
            {
                foreach (ManagementObject process in processes)
                {
                    string processName = process["Name"].ToString();
                    int processId = int.Parse(process["ProcessId"].ToString());
                    long pagedMemorySize = long.Parse(process["WorkingSetSize"].ToString());
                    DateTime startTime = ManagementDateTimeConverter.ToDateTime(process["CreationDate"].ToString());

                    dataGridView1.Rows.Add(num, processName, processId, pagedMemorySize, startTime);
                    num++;
                }
            }

            catch (Exception ex)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add("Ошибка", ex.Message);
            }
        }


    }
}
