using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Timers;

namespace Japa_game1
{
    public struct cardDetail
    {
        public string name;
        public int combatPower;
        public int intelligence;
        public int force;
        public int survival;
        public int dexterity;
    };

    
    public partial class Form1 : Form
    {
        

        int cardCnt = 0;

        bool startFlag = false;

        // allName is from sql
        cardDetail[] allName = new cardDetail[100];
   
        List<int> p1Card = new List<int>();
        List<int> p2Card = new List<int>();
        List<int> tie = new List<int>();
          
        int[] cards= new int[100];

        int prevCount1 = 1;
        int prevCount2 = 1;

        int tieNum = 0;

        SqlConnection conn = new SqlConnection("user id=daniel;" +
                                      "password=liufang8;server=epicgaming-pc;" +
                                      "database=JapaGame; " +
                                      "connection timeout=30");

        /*SqlConnection conn = new SqlConnection("user id=sa;" +
                                       "password=XMG3-Rel.1;server=M2371662\\JCISQLDATA;" +
                                       "database=JapaGame; " +
                                       "connection timeout=10");*/
        ImageList myImageList = new ImageList();

       /* SqlConnection conn = new SqlConnection("user id=ads-user;" +
                                      "password=XMG3-Rel.1;server=M2109523\\SQLEXPRESS;" +
                                      "database=JapaGame; " +
                                      "connection timeout=10");*/

        public Form1()
        {
            InitializeComponent();
            myImageList.Images.Clear();

            for (int i = 0; i < 100; i++)
            {
                //myImageList.Images.Add(Image.FromFile(@"C:\Users\Public\Pictures\Sample Pictures\Desert.JPG"));
                myImageList.Images.Add(Image.FromFile(@"Desert.JPG"));
            }
            myImageList.ImageSize = new Size(32, 32);
        }

        private void displayCard()
        {
            // To do
            //readPlayerDB();

            //display tiebox
            lboxTie.Items.Clear();
            int listNum = tie.Count;
            for (int i = 0; i < listNum; i++)
            {
                int index = tie[i] - 1;
              
                lboxTie.Items.Add("" + allName[index].name);
                lboxTie.Items.Add("Combat Power: " + allName[index].combatPower.ToString());
                lboxTie.Items.Add("Intelligence: " + allName[index].intelligence.ToString());
                lboxTie.Items.Add("Force Power: " + allName[index].force.ToString());
                lboxTie.Items.Add("Survivibility: " + allName[index].survival.ToString());
                
                lboxTie.Items.Add("Dexterity:" + allName[index].dexterity.ToString());
                lboxTie.Items.Add("");
            }


            // display datagridview
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
                   

            dataGridView2.ColumnCount = 1;
            dataGridView2.Columns[0].Name = "Detail";
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            int imgIndex = dataGridView2.Columns.Add(img);
            dataGridView2.Columns[imgIndex].Name = "Image";

            dataGridView2.AllowUserToAddRows = true;
            listNum = p2Card.Count;
            for (int i = 0; i < listNum; i++)
            {
               // dataGridView1[0, i].Value = img;

                int index = p2Card[i] - 1;
                string[] rowStr = new string[6];
                rowStr[0] = "Name: " + allName[index].name + "\n";
                rowStr[1] = "Combat Power: " + allName[index].combatPower.ToString() + "\n";
                rowStr[2] = "Intelligence: " + allName[index].intelligence.ToString() + "\n";
                rowStr[3] = "Force Power: " + allName[index].force.ToString() + "\n";
                rowStr[4] = "Survivability " + allName[index].survival.ToString() + "\n";
                rowStr[5] = "Dexterity:" + allName[index].dexterity.ToString();

                DataGridViewRow row = (DataGridViewRow)dataGridView2.Rows[i].Clone();
                row.Cells[0].Value = rowStr[0] + rowStr[1] + rowStr[2] + rowStr[3] + rowStr[4] + rowStr[5];
                row.Cells[1].Value = myImageList.Images[index];

                dataGridView2.Rows.Add(row);          

            }
            dataGridView2.AllowUserToAddRows = false;
        }


        private void compareBtn()
        {
            if (p1Card.Count == 0)
            {
                MessageBox.Show("Player 2 Win");
                return;
            }
            else if (p2Card.Count == 0)
            {
                MessageBox.Show("Player 1 Win");
                return;
            }

            //p1Card[0] vs. p2Card[0]
            if (rbtncp.Checked == true)
            {
                // compare combat
                compare("Combat Power");
                displayCard();
            }
            else if (rbtnI.Checked == true)
            {
                //compare intellignece
                compare("Intelligence");
                displayCard();
            }
            else if (rbtnfp.Checked == true)
            {
                //compare force power
                compare("Force Power");
                displayCard();
            }
            else if (rbtns.Checked == true)
            {
                //compare survival
                compare("Survival");
                displayCard();
            }
            else if (rbtnd.Checked == true)
            {
                //compare dex   
                compare("Dexterity");

                displayCard();
            }
            else
            {
                //pop up warning
                MessageBox.Show("Choose a catagory", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void compare(string category)
        {
            int index_p1;
            int index_p2;
            index_p1 = p1Card[0] - 1;
            index_p2 = p2Card[0] - 1;

            if (category == "Combat Power")
                compareCategory(allName[index_p1].combatPower, allName[index_p2].combatPower);
            else if  (category == "Intelligence")
                compareCategory(allName[index_p1].intelligence, allName[index_p2].intelligence);
            else if (category == "Force Power")
                compareCategory(allName[index_p1].force, allName[index_p2].force);
            else if (category == "Survival")
                compareCategory(allName[index_p1].survival, allName[index_p2].survival);
            else if (category == "Dexterity")
                compareCategory(allName[index_p1].dexterity, allName[index_p2].dexterity);
        }


        private void compareCategory(int p1Val, int p2Val)
        {
            int index_p1;
            int index_p2;
            index_p1 = p1Card[0] - 1;
            index_p2 = p2Card[0] - 1;

            
            if (p1Val > p2Val)
            {
                 p1Win();
            }
            else if (p1Val < p2Val)
            {
                 p2Win();
            }
            else
            {
                cardTie();
               /* int tranferNum = p2Card[0];
                tie.Add(tranferNum);
                p2Card.RemoveAt(0);

                tranferNum = p1Card[0];
                tie.Add(tranferNum);
                p1Card.RemoveAt(0);*/
                    
            }
            

        }

        private void updateWinnderDB(int winnerNum)
        {
            // open connection to update
            if (conn == null || conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand myCommand = new SqlCommand("", conn);
            string cmdStr = "UPDATE tblWinner " +
                                 "SET Winner = " + winnerNum.ToString();


            myCommand.CommandText = cmdStr;
            myCommand.ExecuteNonQuery();

            if (conn != null)
            {
                conn.Close();
            }
        }

        private void readCardsFromTieTbl()
        {
            SqlDataReader rdr = null;

            try
            {

                if (conn == null || conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlCommand cmd = new SqlCommand("select * from dbo.tblTie", conn);


                // get query results
                rdr = cmd.ExecuteReader();

                // fill in structure          

                int line;
                tie.Clear();
                while (rdr.Read())
                {
                    line = Convert.ToInt32(rdr[0]);
                    tie.Add(line);

                }
            }
            finally
            {
                // close the reader
                if (rdr != null)
                {
                    rdr.Close();
                }

                // 5. Close the connection
                /*   if (conn != null)
                    {
                        conn.Close();
                    }*/
            }
        }

        private void readCardsFromDB()
        {
            SqlDataReader rdr = null;

            try
            {
               
                if (conn == null || conn.State == ConnectionState.Closed)
                    conn.Open();

                
                SqlCommand cmd = new SqlCommand("select * from dbo.tblAllName", conn);
              

                // get query results
                rdr = cmd.ExecuteReader();

                // fill in structure          
                int i = 0;
                while (rdr.Read())
                {
                    //line = (string)rdr[0];
                    allName[i].name = (string)rdr[0];
                    allName[i].combatPower = Convert.ToInt32(rdr[1]);
                    allName[i].intelligence = Convert.ToInt32(rdr[2]);
                    allName[i].force = Convert.ToInt32(rdr[3]);
                    allName[i].survival = Convert.ToInt32(rdr[4]);
                    allName[i].dexterity = Convert.ToInt32(rdr[5]);



                    i++;
                }
                cardCnt = i;
            }
            finally
            {
                // close the reader
                if (rdr != null)
                {
                    rdr.Close();
                }

                // 5. Close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void updatePlayerDB()
        {
            SqlCommand myCommand = new SqlCommand("", conn);
            string myCmdStr = "Delete From tblP1";

            // open connection to update
            if (conn == null || conn.State == ConnectionState.Closed)
                conn.Open();

            myCommand.CommandText = myCmdStr;
            myCommand.ExecuteNonQuery();

            for (int i = 0; i < p1Card.Count; i++)
            {
                string cmdStr = "INSERT INTO tblP1 " +
                                "VALUES (";
                cmdStr += p1Card[i].ToString() + ",";
                cmdStr += i.ToString() + ")";


                myCommand.CommandText = cmdStr;
                myCommand.ExecuteNonQuery();
            }

            myCmdStr = "Delete From tblP2";
            myCommand.CommandText = myCmdStr;
            myCommand.ExecuteNonQuery();

            for (int i = 0; i < p2Card.Count; i++)
            {
                string cmdStr = "INSERT INTO tblP2 " +
                                "VALUES (";
                cmdStr += p2Card[i].ToString() + ",";
                cmdStr += i.ToString() + ")";

                myCommand.CommandText = cmdStr;
                myCommand.ExecuteNonQuery();
            }

            if (conn != null)
            {
                conn.Close();
            }
        }

        private void cardTie()
        {
            string tempStr, tempStr2;
            SqlCommand myCommand = new SqlCommand("", conn);

            startFlag = true;

            /*tempStr = "Player 1 gets " + allName[p2Card[0] - 1].name;
            if (tie.Count > 1)
            {
                for (int i = 0; i < tie.Count; i++)
                {
                    tempStr += " and " + allName[tie[i] - 1].name;
                }
            }

            tempStr2 = tempStr + " (Beaten by " + allName[p1Card[0] - 1].name + ")";

            */

            int tranferNum1 = p2Card[0];
            int tranferNum2 = p1Card[0];


            p2Card.RemoveAt(0);
            p1Card.RemoveAt(0);
            tie.Add(tranferNum1);
            tie.Add(tranferNum2);




            // open connection to update
            if (conn == null || conn.State == ConnectionState.Closed)
                conn.Open();


            string cmdStr = "INSERT INTO tblTie " +
                                "VALUES (";
            cmdStr += tranferNum1.ToString() + ")";


            myCommand.CommandText = cmdStr;
            myCommand.ExecuteNonQuery();

            cmdStr = "INSERT INTO tblTie " +
                                "VALUES (";
            cmdStr += tranferNum2.ToString() + ") ";


            myCommand.CommandText = cmdStr;
            myCommand.ExecuteNonQuery();

            cmdStr = "DELETE From tblP2 " +
                "Where Position=0";
            myCommand.CommandText = cmdStr;
            myCommand.ExecuteNonQuery();

            // because tblP2 #1 item is removed, all position need be -1
            cmdStr = "UPDATE tblP2 SET Position -= 1";
            myCommand.CommandText = cmdStr;
            myCommand.ExecuteNonQuery();

            cmdStr = "DELETE From tblP1 " +
                "Where Position=0 ";
            myCommand.CommandText = cmdStr;
            myCommand.ExecuteNonQuery();

            // because tblP2 #1 item is removed, all position need be -1
            cmdStr = "UPDATE tblP1 SET Position -= 1";
            myCommand.CommandText = cmdStr;
            myCommand.ExecuteNonQuery();






            // to do
            /* if (p2Card.Count == 0)
             {
                 MessageBox.Show("Player 1 wins", "Winner",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
             }*/

            // MessageBox.Show(tempStr2, "Winner",MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void p1Win()
        {
            string tempStr, tempStr2;
            SqlCommand myCommand = new SqlCommand("", conn);

            startFlag = true;

            tempStr = "Player 1 gets " + allName[p2Card[0] - 1].name;
            if (tie.Count > 1)
            {
                for (int i = 0; i < tie.Count; i++)
                {
                    tempStr += " and " + allName[tie[i] - 1].name;
                }
            }

            tempStr2 = tempStr + " (Beaten by " + allName[p1Card[0] - 1].name + ")";



            int tranferNum = p2Card[0];

            p1Card.Add(tranferNum);
            p2Card.RemoveAt(0);

            // open connection to update
            if (conn == null || conn.State == ConnectionState.Closed)
                conn.Open();


            string cmdStr = "INSERT INTO tblP1 " +
                                "VALUES (";
            cmdStr += tranferNum.ToString() + ",";
            cmdStr += (p1Card.Count-1).ToString() + ")";

            myCommand.CommandText = cmdStr;
            myCommand.ExecuteNonQuery();

            cmdStr = "DELETE From tblP2 " +
                "Where Cards=" + tranferNum.ToString();
            myCommand.CommandText = cmdStr;
            myCommand.ExecuteNonQuery();

            // because tblP2 #1 item is removed, all position need be -1
            cmdStr = "UPDATE tblP2 SET Position -= 1";
            myCommand.CommandText = cmdStr;
            myCommand.ExecuteNonQuery();

            tranferNum = p1Card[0];
            p1Card.Add(tranferNum);
            p1Card.RemoveAt(0);

            cmdStr = "UPDATE tblP1 SET Position=";
            cmdStr += (p1Card.Count).ToString();
            cmdStr += " Where Position=0";

            myCommand.CommandText = cmdStr;
            myCommand.ExecuteNonQuery();

            // because tblP1 #1 position value was set to the last, all position need be -1
            cmdStr = "UPDATE tblP1 SET Position -= 1";
            myCommand.CommandText = cmdStr;
            myCommand.ExecuteNonQuery();


            // read tie table from DB, 
            // if anything exist, append to tblP1
            // clean up tblTie

            readCardsFromTieTbl();

            if (tie.Count > 0)
            {
                // append each of them to tblP1
                p1Card.AddRange(tie);
                int i = 0;
                foreach (int element in tie)
                {
                    cmdStr = "INSERT INTO tblP1 " +
                                    "VALUES (";
                    cmdStr += element.ToString() + ",";
                    cmdStr += (p1Card.Count - i-1).ToString() + ")";

                    myCommand.CommandText = cmdStr;
                    myCommand.ExecuteNonQuery();
                    i++;
                }
            }

            cmdStr = "TRUNCATE TABLE tblTie ";

            myCommand.CommandText = cmdStr;
            myCommand.ExecuteNonQuery();







            tieNum = tie.Count;
            tie.Clear();
            lboxTie.Items.Clear();

            updateWinnderDB(1);

            if (p2Card.Count == 0)
            {
                MessageBox.Show("Player 1 wins", "Winner",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // MessageBox.Show(tempStr2, "Winner",MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void p2Win()
        {
            string tempStr, tempStr2;
            SqlCommand myCommand = new SqlCommand("", conn);

            startFlag = true;
            tempStr = "Player 2 gets " + allName[p1Card[0] - 1].name;
            {
                for (int i = 0; i < tie.Count; i++)
                {
                    tempStr += " and " + allName[tie[i] - 1].name;
                }
            }

            tempStr2 = tempStr + " (Beaten by " + allName[p2Card[0] - 1].name + ")";

            int tranferNum = p1Card[0];
            p2Card.Add(tranferNum);
            p1Card.RemoveAt(0);

            // open connection to update
            if (conn == null || conn.State == ConnectionState.Closed)
                conn.Open();

            string cmdStr = "INSERT INTO tblP2 " +
                                "VALUES (";

            cmdStr += tranferNum.ToString() + ",";
            cmdStr += (p2Card.Count-1).ToString() + ")";
            myCommand.CommandText = cmdStr;
            myCommand.ExecuteNonQuery();

            cmdStr = "DELETE From tblP1 " +
                "Where Cards=" + tranferNum.ToString();
            myCommand.CommandText = cmdStr;
            myCommand.ExecuteNonQuery();

            // because tblP2 #1 item is removed, all position need be -1
            cmdStr = "UPDATE tblP1 SET Position -= 1";
            myCommand.CommandText = cmdStr;
            myCommand.ExecuteNonQuery();


            tranferNum = p2Card[0];
            p2Card.Add(tranferNum);
            p2Card.RemoveAt(0);

            cmdStr = "UPDATE tblP2 SET Position=";
            cmdStr += (p2Card.Count).ToString();
            cmdStr += " Where Position=0";

            myCommand.CommandText = cmdStr;
            myCommand.ExecuteNonQuery();

            // because tblP1 #1 position value was set to the last, all position need be -1
            cmdStr = "UPDATE tblP2 SET Position -= 1";
            myCommand.CommandText = cmdStr;
            myCommand.ExecuteNonQuery();

            readCardsFromTieTbl();

            if (tie.Count > 0)
            {
                // append each of them to tblP2
                p2Card.AddRange(tie);
                int i = 0;
                foreach (int element in tie)
                {
                    cmdStr = "INSERT INTO tblP2 " +
                                    "VALUES (";
                    cmdStr += element.ToString() + ",";
                    cmdStr += (p2Card.Count - i-1).ToString() + ")";

                    myCommand.CommandText = cmdStr;
                    myCommand.ExecuteNonQuery();
                    i++;
                }
            }

            cmdStr = "TRUNCATE TABLE tblTie ";

            myCommand.CommandText = cmdStr;
            myCommand.ExecuteNonQuery();


            tieNum = tie.Count;
            tie.Clear();
            lboxTie.Items.Clear();

            updateWinnderDB(2);

            if (p1Card.Count == 0)
            {
                MessageBox.Show("Player 2 wins", "Winner",
         MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            //   MessageBox.Show(tempStr2, "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            compareBtn();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lboxP2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btncompare2_Click(object sender, EventArgs e)
        {
            compareBtn();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Boolean currentOpen = false;

            if (startFlag == false)
                return;
            
            if (conn == null || conn.State==ConnectionState.Closed)
                conn.Open();
            else
                currentOpen = true;

                
            SqlCommand cmd = new SqlCommand("select * from dbo.tblWinner", conn);
               

                // get query results
            SqlDataReader   rdr = cmd.ExecuteReader();

                // fill in structure   
            int playerNum=1;
            int i = 0;
            while (rdr.Read())
            {                  
                    playerNum = Convert.ToInt32(rdr[0]);                   
                    i++;                
                
            }
            rdr.Close();
           
            if (currentOpen == false)
                conn.Close();

            if (playerNum == 1)
            {              
                btncompare2.Visible = false;
                btncompare2.Enabled = false;
                rbtncp.Checked = false;
                rbtnd.Checked = false;
                rbtnfp.Checked = false;
                rbtnI.Checked = false;
                rbtns.Checked = false;
                rbtncp.Visible = false;
                rbtnd.Visible = false;
                rbtnfp.Visible = false;
                rbtnI.Visible = false;
                rbtns.Visible = false;
                if (prevCount2 != p2Card.Count && prevCount1 != p1Card.Count)
                {
                    tieNum = p1Card.Count - prevCount1 - 1;
                    prevCount2 = p2Card.Count;
                    prevCount1 = p1Card.Count;
                    int index = p1Card.Count - 1;
                    if (tieNum < 0)
                    {
                        MessageBox.Show("tie", "tie",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                         
                       
                        if (p1Card.Count != 0)
                        {
                            string tempStr = "Player 1 gets " + allName[p1Card[index - 1 - tieNum] - 1].name;
                            for (int k = 0; k < tieNum; k++)
                            {
                                tempStr += ", " + allName[p1Card[index - k] - 1].name;
                            }

                            MessageBox.Show(tempStr + " (Beaten by " + allName[p1Card[index - tieNum] - 1].name + ")", "Winner",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tieNum = 0;
                        }
                     }

                }

            }
            else
            {               
                btncompare2.Visible = true;
                btncompare2.Enabled = true;
           
                rbtncp.Visible = true;
                rbtnd.Visible = true;
                rbtnfp.Visible = true;
                rbtnI.Visible = true;
                rbtns.Visible = true;

                if (prevCount2 != p2Card.Count && prevCount1 != p1Card.Count)
                {
                    tieNum = p2Card.Count - prevCount2 - 1;
                    prevCount2 = p2Card.Count;
                    prevCount1 = p1Card.Count;
                    int index = p2Card.Count - 1;
                    if (tieNum < 0)
                    {
                        MessageBox.Show("tie", "tie",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                     
                    }
                    else
                    {  
                        
                        if (p2Card.Count != 0)
                        {
                            string tempStr = "Player 2 gets " + allName[p2Card[index - 1 - tieNum] - 1].name;
                            for (int k = 0; k < tieNum; k++)
                            {
                                tempStr += ", " + allName[p2Card[index - k] - 1].name;
                            }

                            MessageBox.Show(tempStr + " (Beaten by " + allName[p2Card[index - tieNum] - 1].name + ")", "Winner",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tieNum = 0;
                        
                        }
                        
                    }

                }
            }

            bool display1Flag = readPlayer1();
            bool display2Flag = readPlayer2();
            if (display2Flag && cardCnt != 0 && startFlag)
            {
                readCardsFromTieTbl();
                displayCard();
            } 
                         
        }

        private bool readPlayer1()
        {
            Boolean readFlag = false;
            SqlDataReader rdr = null;

            // read player 1
            if (conn == null || conn.State == ConnectionState.Closed)
                conn.Open();

            // 3. Pass the connection to a command object
            SqlCommand cmd = new SqlCommand("select * from dbo.tblP1 order by Position", conn);

            // get query results
            rdr = cmd.ExecuteReader();

            // fill in structure          
            int i = 0;
            int num = 0;
            int count = p1Card.Count;
            int firstNum =0;
            if (count !=0)
                firstNum= p1Card[0];

            p1Card.Clear();
            while (rdr.Read())
            {
                num = Convert.ToInt32(rdr[0]);
                p1Card.Add(num);
                // check first one, if not same, return yes - we do need read again
                if (i == 0)
                {
                    if (firstNum != num)
                        readFlag = true;
                }

                i++;
            }

            if (i != count)
                readFlag = true;
           

            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            if (rdr != null)
            {
                rdr.Close();
            }

            return readFlag;
        }

        private bool readPlayer2()
        {
            Boolean readFlag = false;
            SqlDataReader rdr2 = null;

            // read player 2
            if (conn == null || conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand cmd2 = new SqlCommand("select * from dbo.tblP2 order by Position", conn);

            // get query results
            rdr2 = cmd2.ExecuteReader();

            // fill in structure          
            int i = 0;
            int num = 0;
            int count = p2Card.Count;
            int firstNum = 0;
            if (count != 0)
                firstNum = p2Card[0];

            p2Card.Clear();
            while (rdr2.Read())
            {
                num = Convert.ToInt32(rdr2[0]);
                p2Card.Add(num);
                // check first one, if not same, return yes - we do need read again
                if (i == 0)
                {
                    if (firstNum != num)
                        readFlag = true;
                }

                i++;
            }

            if (i != count)
                readFlag = true;
           
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            if (rdr2 != null)
            {
                rdr2.Close();
            }
            return readFlag;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            startFlag = true;

            // try to read from SQL DB
            // SqlConnection conn = new SqlConnection("Data Source=M2371662\\JCISQLDATA;Database=JapaGame;Integrated Security=SSPI");
            readCardsFromDB();
            myImageList.Images.Clear();

            for (int i = 0; i < cardCnt; i++)
            {
               // myImageList.Images.Add(Image.FromFile(@"C:\Users\Public\Pictures\Sample Pictures\Desert.JPG"));
                
                string[] filePaths = Directory.GetFiles(@"Images\", allName[i].name + ".jpg");
                if (filePaths.Length == 1)
                {
                    string tmpFilePath = "Images\\" + allName[i].name + ".jpg";
                    myImageList.Images.Add(Image.FromFile(tmpFilePath));
                }
                else
                {
                    myImageList.Images.Add(Image.FromFile(@"Desert.JPG"));
                }
            }
            myImageList.ImageSize = new Size(96, 96);

            for (int i = 1; i <= 100; i++)
                cards[i - 1] = i;


            readPlayer1();
            readPlayer2();
          
            displayCard();

            btnStart.Visible = false;

            prevCount1 = p1Card.Count;
            prevCount2 = p2Card.Count;

                
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
        }
    }
}
