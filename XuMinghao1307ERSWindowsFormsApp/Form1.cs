using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XuMinghao1307ERSWindowsFormsApp
{
    public partial class EmployeeRecordsForm : Form
    {
        private TreeNode tvRootNode;

        public EmployeeRecordsForm()
        {
            InitializeComponent();
            PopulateTreeView();
        }

        private void EmployeeRecordsForm_Load(object sender, EventArgs e)
        {
            
        }
        private void PopulateTreeView()
        {
            statusBarPanel1.Tag = "Refreshing Employee Code. Please wait...";
            this.Cursor = Cursors.WaitCursor;
            treeView1.Nodes.Clear();
            tvRootNode = new TreeNode("Employee Records");
            this.Cursor = Cursors.Default;
            treeView1.Nodes.Add(tvRootNode);

            TreeNodeCollection nodeCollection = tvRootNode.Nodes;
            XmlTextReader reader = new XmlTextReader("F:\\visual studio\\Project2022" +
                "\\W1L2ConsoleApp1\\XuMinghao1307App\\XuMinghao1307ERSWindowsFormsApp\\EmpRec.xml");

            reader.MoveToElement();
            try
            {
                while(reader.Read())
                {
                    if(reader.HasAttributes && reader.NodeType == XmlNodeType.Element)
                    {
                        reader.MoveToElement();
                        reader.MoveToElement();

                        reader.MoveToAttribute("Id");
                        String strVal = reader.Value;

                        reader.Read();
                        reader.Read();
                        if(reader.Name== "dept")
                        {
                            reader.Read();
                        }
                        //create a child node
                        TreeNode EcodeNode = new TreeNode(strVal);
                        //add the node
                        nodeCollection.Add(EcodeNode);
                    }
                }
                statusBarPanel1.Text = "Click on an employee code to see their record.";
            }
            catch(XmlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//end

        protected void InitalizeListControl()
        {
            listView1.Clear();
            listView1.Columns.Add("Employee Name", 255, HorizontalAlignment.Left);
            listView1.Columns.Add("Date of Join", 70, HorizontalAlignment.Right);
            listView1.Columns.Add("Gread", 105, HorizontalAlignment.Left);
            listView1.Columns.Add("Salary", 105, HorizontalAlignment.Left);
        }

        protected void PopulateListView(TreeNode crrNode)
        {
            InitalizeListControl();
            XmlTextReader listRead = new XmlTextReader("F:\\visual studio\\Project2022" +
                "\\W1L2ConsoleApp1\\XuMinghao1307App\\XuMinghao1307ERSWindowsFormsApp\\EmpRec.xml");
            listRead.MoveToElement();

            while (listRead.Read())
            {
                String strNodeName;
                String strNodePath;
                String name;
                String gread;
                String doj;
                String sal;
                String[] strItemsArr = new string[4];
                listRead.MoveToFirstAttribute();//Id="E001"
                strNodeName = listRead.Value;
                strNodePath = crrNode.FullPath.Remove(0, 17);
                if (strNodeName == strNodePath)
                {
                    ListViewItem lvi;
                    listRead.MoveToNextAttribute();
                    name = listRead.Value;//name "XuMinghao"
                    lvi = listView1.Items.Add(name);

                    listRead.Read();
                    listRead.Read();

                    listRead.MoveToFirstAttribute();
                    doj = listRead.Value;//DateofJoin="02-02-1999
                    lvi.SubItems.Add(doj);

                    listRead.MoveToFirstAttribute();
                    gread = listRead.Value;//Gread="A"
                    lvi = listView1.Items.Add(gread);

                    listRead.MoveToFirstAttribute();
                    sal = listRead.Value;//Salary="17500"
                    lvi = listView1.Items.Add(sal);

                    listRead.MoveToNextAttribute();
                    listRead.MoveToElement();
                    listRead.ReadString();
                }

            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode currNode = e.Node;
            if(tvRootNode == currNode)
            {
                InitalizeListControl();
                statusBarPanel1.Text = "Double click the Employee Records";
                return;
            }
            else
            {
                statusBarPanel1.Text = "Click an employee code to view individual record";
            }
            PopulateListView(currNode);
        }
    }
}
