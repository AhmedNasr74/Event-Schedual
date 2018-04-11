using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace WindowsFormsApplication9
{
    
    public partial class ev_app : Form
    {
        bool Errors(Event tmp,int num)//Error Cases
        {
            
            int Existed_Index = Exist(eventList,txt_Name.Text, num);//Call Function Exist
             if (txt_Name.Text==null || txt_Name.Text=="" || txt_Place.Text=="" || txt_Place.Text==null)//Check IF Name\Place Empty or no
            {
                MessageBox.Show(@"Name\Place Empty Please check again! ", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                 return true;
            }
            else if (StartDate.Value >  EndDate.Value)//Check If Start Date Earlier Than End Date 
            {
                MessageBox.Show("End Data Earlier than Start Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else if (tmp.startDateTime==tmp.endDateTime)//Check if DateTime Same in Start and End مفيش ايفينت بيخلص فساعتها 
            {

                MessageBox.Show("Error with Event Date and Time ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
              else if (Existed_Index != -1)//Value of Function Exist
             {
                 MessageBox.Show("Event Name already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return true;
             }
             else if (Intersect(tmp,num))//Call Function Intersect
             {
                 MessageBox.Show("Event Time Intersect With Another Event", "");
                 return true;
             }
            return false;//Default value لما يعدي من كل الاختبارات دي 
        }
        void ListToList()//Move From eventList to Finished_List  

        {
            for (int i = 0; i < eventList.Count; i++)
            {
                eventList[i].CheckDone();
                if (eventList[i].Done)
                {
                    Finished_Event.Add(eventList[i]);
                    eventList.RemoveAt(i);
                    
                    listView1.Items[i].Remove();
                }
            }
        }

        private void Buttons(bool Case)//Buttons State Enable/Disable
        {
            //Enable/Disable Buttons
            bu_Add.Enabled = Case;
            bu_Delete.Enabled = Case;
            bu_Edit.Enabled = Case;
            bu_Detail.Enabled = Case;
            bu_Save.Enabled = !Case;
            bu_Cancel.Enabled = !Case;
        
       }
        bool Intersect( Event New,int num)//Check IF any New Event Intersect with any Event (المعادين مش داخلين فبعض) ==>  num if = num>=0 then it can be repeated once (Edit Case Only)
      {
          for (int i = 0; i < eventList.Count(); i++)
          {

              if (i == num)//Not to compare With itself
                  continue;
              if (eventList[i].startDateTime == New.startDateTime || eventList[i].endDateTime == New.endDateTime)
                  return true;
              else if (eventList[i].startDateTime < New.startDateTime && eventList[i].endDateTime > New.endDateTime)
                  return true;
              else if (eventList[i].startDateTime > New.startDateTime && eventList[i].endDateTime < New.endDateTime)
                  return true;
          }
          return false;
      }

        int Exist(List<Event> tmp ,String name, int num)//Check If Event Name Exist or no  , If Yes return Index To be used in Search Else return -1 num if = num>=0 then it can be repeated once (Edit Case Only)
        {
            for(int i=0;i<tmp.Count;i++)
            {
                if (i == num)
                    continue;
                if( name.ToLower() ==tmp[i].name.ToLower())
                
                   return i;
            }
            return -1;
        }

        void ClearFields()//set Name\Place and all DateTimePicker to Default Value
        {
            txt_Name.Text = "Name";
            txt_Name.ForeColor = Color.Silver;

            txt_Place.Text = "Place";
            txt_Place.ForeColor = Color.Silver;

            StartDate.Value = DateTime.Now;
            StartTime.Value = DateTime.Now;
            EndDate.Value = DateTime.Now;
            EndTime.Value = DateTime.Now;


        }
      
        void  AddToListView(Event tmpEvent) //Adding Item To ListView
        {
           
                ListViewItem list = new ListViewItem();

                list.SubItems.Add(tmpEvent.name);
                list.SubItems.Add(tmpEvent.startDateTime.ToShortDateString());
                list.SubItems.Add(tmpEvent.startDateTime.ToShortTimeString());

                listView1.Items.Add(list);

            
                ListToList();
        }
        
        int index = 0;//Global Variable For Editing to Avoid Error if User Change Focused Item in Edit Mode
        List<Event> eventList = new List<Event>();// Not Finished Events
        List<Event> Finished_Event = new List<Event>();//Finished Events

     
    
           //Resize Off
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
      


        public ev_app()
        {
            InitializeComponent();

        }
        
       
        string path = "eventlist.txt";//Saving File Name
        public void SaveData(Event events)//Saving Data to File
        {
            
            FileStream fs = new FileStream(path, FileMode.Append);//Append = if Exist read else Create
            StreamWriter sw = new StreamWriter(fs);

                sw.Write(events.name +','+ events.place + ',' + events.startDateTime + ','+events.endDateTime + ',' + events.Done+Environment.NewLine);
                sw.Close();//Dont forget to Close File After read and write to avoid Error  
        }
        public void UpdateData()//Delete File and Create new one to UpdateData 
        {
            try
            {
            File.Delete(path);
            for (int i = 0; i < eventList.Count; i++)
            {
                SaveData(eventList[i]);
            }
            for (int i = 0; i < Finished_Event.Count; i++)
            {
                SaveData(Finished_Event[i]);
            }
            }
            catch { }
            
        }

        public void ReadData()//Read Data from File to List
        {
            try
            {
                StreamReader read = new StreamReader(path);
                string ReadLine;

                while ((ReadLine = read.ReadLine()) != null)
                {


                    String[] data = ReadLine.Split(','); //Split String into Array of String with any char i want 

                    Event tmp = new Event();
                    tmp.name = data[0];
                    tmp.place = data[1];
                    tmp.startDateTime = Convert.ToDateTime(data[2]);
                    tmp.endDateTime = Convert.ToDateTime(data[3]);
                    tmp.CheckDone();
                    if (tmp.Done==false)
                    {
                        eventList.Add(tmp);
                        AddToListView(tmp);
                    }
                    else
                    {
                                                
                        Finished_Event.Add(tmp);
                    }

                    
                }
                read.Close();//Add to Finally
            }
            catch { }
        }
        

        
        private void ev_app_Load(object sender, EventArgs e)//Load Form1
        {
            Buttons(true);

            ClearFields();
           

                ReadData();//read from File to List

                rad_Name_CheckedChanged(sender, e);//Sort Data by default
            
        

        }

        private void nametextBox_TextChanged(object sender, EventArgs e)//Empty
        {

        }
        
        private void start_time_Click(object sender, EventArgs e)//Empty
        {

        }


        private void button1_Click(object sender, EventArgs e)//Add Button
        {
            //Add Button
            //add information to list.... 


                Event tmp = new Event();
                tmp.name = txt_Name.Text;
                tmp.place = txt_Place.Text;
                
                tmp.startDateTime = new DateTime(StartDate.Value.Year, StartDate.Value.Month, StartDate.Value.Day
                                                 , StartTime.Value.Hour, StartTime.Value.Minute, 0);

                tmp.endDateTime = new DateTime(EndDate.Value.Year, EndDate.Value.Month, EndDate.Value.Day
                                                 , EndTime.Value.Hour, EndTime.Value.Minute, 0);
      
             if (Errors(tmp,-1) == false)
            {
                    tmp.CheckDone();
                    eventList.Add(tmp);
                    ClearFields();
                    SaveData(tmp);
                    AddToListView(tmp);
                    ListToList();

                    if (rad_Name.Checked)//to Sort 
                        rad_Name_CheckedChanged(sender, e);
                    else//to Sort
                        rad_StartTime_CheckedChanged(sender, e);
                
            }
        }
        private void Search_Enter(object sender, EventArgs e)//watermark
        {
            //water mark
            if (txt_Search.Text == "By Name")
            {
                txt_Search.Text = null;
                txt_Search.ForeColor = Color.Black;

            }
        }

        private void Search_leave(object sender, EventArgs e)//watermark
        {
            //water mark
            if (txt_Search.Text == "")
            {
                txt_Search.Text = "By Name";
                txt_Search.ForeColor = Color.Silver;

            }
        }

        private void txt_Name_Enter(object sender, EventArgs e)//watermark
        {
            //water mark Remove
            if (txt_Name.Text == "Name")
            {
                txt_Name.Text = null;
                txt_Name.ForeColor = Color.Black;

            }
        }

        private void txt_Name_Leave(object sender, EventArgs e)//watermark
        {
            //water mark
            if (txt_Name.Text == "")
            {
                txt_Name.Text = "Name";
                txt_Name.ForeColor = Color.Silver;

            }
        }

        private void place_enter(object sender, EventArgs e)//watermark
        {
            
            //water mark Remove
            if (txt_Place.Text == "Place")
            {
                txt_Place.Text = null;
                txt_Place.ForeColor = Color.Black;

            }
        }

        private void place_leave(object sender, EventArgs e)//watermark
        {
            
             //water mark
            if (txt_Place.Text == "")
            {
                txt_Place.Text = "Place";
                txt_Place.ForeColor = Color.Silver;

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)//Redminder Label
        {
            try
            {
                int remindDays = (int)eventList[listView1.FocusedItem.Index].getRemind().TotalDays;

                lblRemind.Text = remindDays.ToString() + " Days";
            }
            catch { }
            
        }

        private void Update_button_Click(object sender, EventArgs e)//Save Button
        {
            Event tmp=new Event();

            tmp.name = txt_Name.Text;
           tmp.place = txt_Place.Text;

            tmp.startDateTime = new DateTime(StartDate.Value.Year, StartDate.Value.Month, StartDate.Value.Day
                                                     , StartTime.Value.Hour, StartTime.Value.Minute, 0);

                    tmp.endDateTime = new DateTime(EndDate.Value.Year, EndDate.Value.Month, EndDate.Value.Day
                                                     , EndTime.Value.Hour, EndTime.Value.Minute, 0);
            
            
            
            if(Errors(tmp,index)==false){
            eventList[index].name = txt_Name.Text;
            eventList[index].place = txt_Place.Text;

            eventList[index].startDateTime = new DateTime(StartDate.Value.Year, StartDate.Value.Month, StartDate.Value.Day
                                                     , StartTime.Value.Hour, StartTime.Value.Minute, 0);

                    eventList[index].endDateTime = new DateTime(EndDate.Value.Year, EndDate.Value.Month, EndDate.Value.Day
                                                     , EndTime.Value.Hour, EndTime.Value.Minute, 0);

                    listView1.Items[index].Remove();
                    AddToListView(eventList[index]);
                    if (rad_Name.Checked)
                        rad_Name_CheckedChanged(sender, e);
                    else
                        rad_StartTime_CheckedChanged(sender, e);

            UpdateData();
            ClearFields();

            ListToList();
            Buttons(true);
            }
        }

        private void Timee(object sender, EventArgs e)//Empty
        {

        }

        private void delete_button_Click(object sender, EventArgs e)//Delete Button
        {
            //delete a element of list...
           

           try{
               index = listView1.FocusedItem.Index;
                eventList.RemoveAt(index);
                listView1.Items[index].Remove();
                UpdateData();
                lblRemind.Text = "No Event Selected!";
            }
            
            catch
            {
                MessageBox.Show("Please Select an Event", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void select_element(object sender, ListViewItemSelectionChangedEventArgs e)//Empty
        {

        }

        private void cancel_button_Click_1(object sender, EventArgs e)//Cancel Button
        {
            
            //Default Values
            ClearFields();

            Buttons(true);
        }

        private void bunifuCalendar1_onValueChanged(object sender, EventArgs e)//Empty
        {

        }

        private void view_list(object sender, EventArgs e)//Empty
        {
        }

        private void list_button_Click(object sender, EventArgs e)//Detail Button
        {
            //Show Form2
            //ShowDialog = Disable Form1 Til Form2 Closed
            
                    ListToList();
                    Form2 frm = new Form2(eventList,Finished_Event);
                    frm.ShowDialog();
            
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)//Empty
        {

        }

        public static void Drag_Form(IntPtr Handle, MouseEventArgs e)//move form
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        
        private void panel1_Paint(object sender, MouseEventArgs e)//Empty
        {

        }

        private void panel1_Paint_move(object sender, MouseEventArgs e)//Empty
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)//Empty
        {

        }

        private void move_fprm(object sender, MouseEventArgs e)//Move Form
        {
            Drag_Form(Handle, e);
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)//Empty
        {
          
        }

        private void name_of_event_Click(object sender, EventArgs e)//Empty
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)//Empty
        {

        }

        private void place_TextChanged(object sender, EventArgs e)//Empty
        {

        }

        private void place_of_event_Click(object sender, EventArgs e)//Empty
        {

        }

        private void bu_Edit_Click(object sender, EventArgs e) //Edit Button
        {

           
            //Edit Event

            try
            {
                index = listView1.FocusedItem.Index;//set Global variable with selected index to save in it incase User Change Seleceted ITem
               
                txt_Name.Text = eventList[index].name;
                txt_Name.ForeColor = Color.Black;

                txt_Place.Text = eventList[index].place;
                txt_Place.ForeColor = Color.Black;
                StartDate.Value = eventList[index].startDateTime.Date;
                StartTime.Value = eventList[index].startDateTime;
                EndDate.Value = eventList[index].endDateTime.Date;
                EndTime.Value = eventList[index].endDateTime;

                Buttons(false);
            }
            catch
            {
                MessageBox.Show("Please Select Index", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
             
          
        }

        private void rad_Name_CheckedChanged(object sender, EventArgs e)//Radio Name
        {
           //RadioButton Sort By Name
            //eventList.Count -> size of the list ;

            listView1.Items.Clear();//Clear Items Without Headers
            for (int i = 0; i < eventList.Count; i++)//eventList.Count -> size of the list ;
            {
                for (int j = i; j < eventList.Count; j++)
                {
                    if (string.CompareOrdinal(eventList[j].name.ToLower(), eventList[i].name.ToLower()) < 0)//string.CompareOrdinal it's a fun that combare in ASCII
                    {
                        //if the eventList[j].name == eventList[i].name will return 0
                        //if the eventList[j].name <  eventList[i].name will return a positive integer [+] so it is true;
                        //if the eventList[j].name <  eventList[i].name will return a negative integer [-] so it is true;
                        Event temp = eventList[j];
                        eventList[j] = eventList[i];
                        eventList[i] = temp;

                    }


                }
                AddToListView(eventList[i]);
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)//Empty
        {

        }

        private void rad_StartTime_CheckedChanged(object sender, EventArgs e)//Radio StartTime
        {


            listView1.Items.Clear();
            for (int i = 0; i <eventList.Count(); i++)
            {
                for (int j = i; j <eventList.Count(); j++)
                {
                    if (eventList[j].startDateTime <  eventList[i].startDateTime )
                    {
                       Event temp = eventList[j];
                        eventList[j] = eventList[i];
                        eventList[i] = temp;

                    }
                  
                }
                AddToListView(eventList[i]);
            }
                     
           
        }

        private void EndDate_ValueChanged(object sender, EventArgs e)//Empty
        {
           
        }
     
        private void StartTime_ValueChanged(object sender, EventArgs e)//Empty
        {
           
        }

        private void EndTime_ValueChanged(object sender, EventArgs e)//Empty
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)//'X' Picture Close
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)//'-' Picture Minimize
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bu_Search_Click(object sender, EventArgs e)//Search Button
        {
            int SearchIndex = Exist(eventList, txt_Search.Text,-1);
            if (SearchIndex == -1)
            {
                if (Exist(Finished_Event, txt_Search.Text,-1) == -1)
                    MessageBox.Show("Event Name Doesn't Exist", " ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    MessageBox.Show("Event Has Finished ", "");
                }
            }
            else
            {
                listView1.Items[SearchIndex].Selected = true;
                listView1.Select();
            }

        }

       

        private void label(object sender, MouseEventArgs e)// Move Form
        {
            Drag_Form(Handle, e);
        }

     
        
    }
}

   