using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Тестовое_приложение_по_поиску_файлов__в_репозитории
{
    public partial class Form1 : Form
    {
        private string SearchResult { get; set; }
        private string ActualDirectory{ get; set; }
        private int CounterOfMatches { get; set; }
        private bool FileFounded { get; set; }
        private int SearchFormat { get; set; }

        public Form1()
        {
            InitializeComponent();

            try
            {
                textBoxPathString.Text = File.ReadAllText("lastSearch.txt");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            TextBoxTime.Text = "0h:0m:0s:0ms";
            
        }
       
        public void RecursionSearch(string fileName,string fileExtension, string path, List<string> accesibleDirectorys, bool IsWithRecursion)
        {
           
            if (IsWithRecursion == true)//If folder from path contains more folders, programm will chek that folders too
            {
                foreach (var folder in accesibleDirectorys)
                {
                    ActualDirectory = folder;
                    switch (SearchFormat)
                    {
                        case 1://name and extension
                            if (Directory.GetFiles(folder).ToList().Exists(file => file.Split('\\').Last().Split('.')[0] == fileName
                             && Directory.GetFiles(folder).ToList().Exists(extension => extension.Split('\\').Last().Split('.')[extension.Split('\\').Last().Split('.').Length - 1] == fileExtension)))
                            {
                                SearchResult = folder;
                                FileFounded = true;

                                break;
                            }
                            else
                            {
                                АccessibleDirectory(folder, fileName, fileExtension);
                            }

                            break;

                        case 2:// only name
                            if (Directory.GetFiles(folder).ToList().Exists(file => file.Split('\\').Last().Split('.')[0] == fileName))
                            {
                                SearchResult = folder;
                                FileFounded = true;

                                break;
                            }
                            else
                            {
                                АccessibleDirectory(folder, fileName, fileExtension);
                            }

                            break;
                        case 3://only extension
                            if (Directory.GetFiles(folder).ToList().Exists(extension => extension.Split('\\').Last().Split('.')[extension.Split('\\').Last().Split('.').Length - 1] == fileExtension))
                            {
                                SearchResult = folder;
                                FileFounded = true;

                                break;
                            }
                            else
                            {
                                АccessibleDirectory(folder, fileName, fileExtension);
                            }

                            break;

                    }

                }
                    
            }
            else//Folder from path haven't contains any folders inside.Programm will chek only folder from path
            {
                ActualDirectory = path;

                switch (SearchFormat)
                {
                    case 1://name and extension

                        if (Directory.GetFiles(path).ToList().Exists(extension => extension.Split('\\').Last().Split('.')[extension.Split('\\').Last().Split('.').Length - 1] == fileExtension)
                        && Directory.GetFiles(path).ToList().Exists(file => file.Split('\\').Last().Split('.')[0] == fileName))
                        {
                            SearchResult = path;
                            FileFounded = true;
                        }

                        break;

                    case 2://only name

                        if (Directory.GetFiles(path).ToList().Exists(file => file.Split('\\').Last().Split('.')[0] == fileName))
                        {
                            SearchResult = path;
                            FileFounded = true;
                        }

                        break;

                    case 3://only extension

                        if (Directory.GetFiles(path).ToList().Exists(extension => extension.Split('\\').Last().Split('.')[extension.Split('\\').Last().Split('.').Length - 1] == fileExtension))
                        {
                            SearchResult = path;
                            FileFounded = true;
                        }

                        break;
                }
  
            }
           
        }
        public void АccessibleDirectory(string path, string fileName, string fileExtension)//Creat list of accessible directorys and searching files only in folders from that list
        {

            List<string> directoris = Directory.GetDirectories(path).ToList();

            string[] massOfAccesibleDirectorys = new string[directoris.Count];
            directoris.CopyTo(massOfAccesibleDirectorys);

            List<string> accesibleDirectorys = directoris.ToList();

            for (int i = 0; i < directoris.Count; i++)
            {
                try
                {
                    Directory.GetFiles(directoris[i]);

                }
                catch
                {
                    accesibleDirectorys.Remove(directoris[i]);
                }
                finally
                {
                    accesibleDirectorys.Remove("$Recycle.Bin");
                }
            }

            if (accesibleDirectorys.Count == 0)//we have only one folder for searching files
                RecursionSearch(fileName, fileExtension, path, accesibleDirectorys, IsWithRecursion: false);     

            else if(accesibleDirectorys.Count!=0 && FileFounded == false)//we have many folders for searching files and will cheking them one by one
                RecursionSearch(fileName, fileExtension, path, accesibleDirectorys, IsWithRecursion: true);
            
        }  

        private async void Search_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer FormTimer = new System.Windows.Forms.Timer
            {
                Interval = 1
            };
            FileFounded = false;
            SearchFormat = 0;

            if (textBoxFileName.Text.Equals("") & textBoxFileExtension.Text.Equals(""))
                MessageBox.Show("Укажите параметры для поиска");
            else if (textBoxPathString.Text.Length == 0)
                MessageBox.Show("Выберите начальную директорию поиска");
            else
            {
                //Choosing format of searching by the input information  
                if (textBoxFileName.Text.Equals("") == false && textBoxFileExtension.Text.Equals("") == false)
                    SearchFormat = 1;//Format, if u entered file name and file extension
                else if (textBoxFileName.Text.Equals("") == false && textBoxFileExtension.Text.Equals("") == true)
                    SearchFormat = 2;//Format, if u entered only file name
                else if (textBoxFileName.Text.Equals("") == true && textBoxFileExtension.Text.Equals("") == false)
                    SearchFormat = 3; //Format, if u entered only file extension

                treeView1.Nodes.Clear();
                SearchResult = null;
                ActualDirectory = null;

                TextBoxTime.Text = "0h:0m:0s:0ms";
                int milSec, sec, min, hour;
                milSec = sec = min = hour = 0;

                FormTimer.Start();
                FormTimer.Tick += new EventHandler(FormTimer_Tick);

                void FormTimer_Tick(object sender2, EventArgs e2)
                {
                    if (milSec == 60) { milSec = 00; sec++; }

                    if (sec == 60) { sec = 00; min++; }

                    if (min == 60) { min = 00; hour++; }

                    TextBoxTime.Text = $"{hour}h:{min}m:{sec}s:{milSec++}ms ";
                    if (FileFounded == false)
                        textBoxActualDirectory.Text = ActualDirectory;
                    else
                        textBoxActualDirectory.Text = SearchResult;
                }

                try
                {
                    File.WriteAllText("lastSearch.txt", textBoxPathString.Text);

                    if (textBoxFileName.Text != null || textBoxFileExtension != null)
                    {
                        pictureBox1.Visible = true;
                        pictureBox2.Visible = false;

                        await Task.Run(() => АccessibleDirectory(textBoxPathString.Text, textBoxFileName.Text, textBoxFileExtension.Text));// start background searching

                        if (SearchResult != null)
                        {
                            GC.Collect();
                            CounterForTree = 0; 
                            treeView1.Nodes.Add(CreateNodes(SearchResult, SearchResult.Split('\\')[0],textBoxFileName.Text, textBoxFileExtension.Text));                          
                        }
                        else
                        {
                            FormTimer.Stop();
                            GC.Collect();
                        }

                    }
                   
                    else
                    {
                        FormTimer.Stop();
                        MessageBox.Show("Пустой поисковый запрос");
                    }

                    FormTimer.Stop();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (FileFounded == false)
                        textBoxActualDirectory.Text = "Подходящих файлов не обнаружено";
                    else
                        textBoxActualDirectory.Text = SearchResult;
                    GC.Collect();
                    pictureBox1.Visible = false;
                    pictureBox2.Visible =true;
                }
            }
        }

        public int CounterForTree { get; set; }
        private TreeNode CreateNodes(string directoryPath, string folderName, string fileName,string fileExtension)
        {
            TreeNode Node = new TreeNode(folderName);
            string[] mass = directoryPath.Split('\\');

            while (CounterForTree< mass.Length - 1)
            { 
                CounterForTree++;
                Node.Nodes.Add(CreateNodes(directoryPath,mass[CounterForTree], fileName, fileExtension));
                return Node;

            }

            foreach (var file in Directory.GetFiles(SearchResult))
            {
                switch (SearchFormat)
                {
                    case 1://search by name and extension
                        if ((file.Split('\\').Last().Split('.')[0] == fileName) &&
                            (file.Split('\\').Last().Split('.')[file.Split('\\').Last().Split('.').Length - 1] == fileExtension))
                        {
                            Node.Nodes.Add(file.Split('\\')[file.Split('\\').Length - 1]).ForeColor = Color.DarkGreen;
                        }
                        else
                            Node.Nodes.Add(file.Split('\\')[file.Split('\\').Length - 1]).ForeColor = Color.Black;
                        break;

                    case 2://search by name
                        if (file.Split('\\').Last().Split('.')[0] == fileName)
                            Node.Nodes.Add(file.Split('\\')[file.Split('\\').Length - 1]).ForeColor = Color.DarkGreen;
                        else
                            Node.Nodes.Add(file.Split('\\')[file.Split('\\').Length - 1]).ForeColor = Color.Black;
                        break;

                    case 3://search by extension
                        if (file.Split('\\').Last().Split('.')[file.Split('\\').Last().Split('.').Length - 1] == fileExtension)
                            Node.Nodes.Add(file.Split('\\')[file.Split('\\').Length - 1]).ForeColor = Color.DarkGreen;
                        else
                            Node.Nodes.Add(file.Split('\\')[file.Split('\\').Length - 1]).ForeColor = Color.Black;
                        break;
                }
              
            }

            return Node;

        }

        private void PathBackSpace_Click(object sender, EventArgs e)
        {
            textBoxPathString.Clear();
        }

        private void FormatBackSpace_Click(object sender, EventArgs e)
        {
            textBoxFileName.Clear();
        }

        private void FileExtensionBackSpace_Click(object sender, EventArgs e)
        {
            textBoxFileExtension.Clear();
        }

    }
}
