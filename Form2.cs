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

namespace WindowsFormsApplication9
{

    public partial class Form2 : Form
    {
        int Exist(List<Event> tmp, String name)//Check If Event Name Exist or no  , If Yes return Index To be used in Search Else return -1 
        {
            for (int i = 0; i < tmp.Count; i++)
            {
                if (name == tmp[i].name)

                    return i;
            }
            return -1;
        }
        void SortName(List<Event> tmp)//Sort The Given List in Parameter With Name
        {
            second_list.Items.Clear();

            for (int i = 0; i < tmp.Count; i++)//eventList.Count -> size of the list ;
            {
                for (int j = i; j < tmp.Count; j++)
                {
                    if (string.CompareOrdinal(tmp[j].name.ToLower(), tmp[i].name.ToLower()) < 0)//string.CompareOrdinal it's a fun that combare in ASCII
                    {
                        Event tmpEvent = tmp[j];
                        tmp[j] = tmp[i];
                        tmp[i] = tmpEvent;

                    }
                }
            }
            Display(tmp);
        }
        void SortStartDate(List<Event> tmp)//sort The given List in parameter with StartDate
        {
            second_list.Items.Clear();
            for (int i = 0; i < tmp.Count(); i++)
            {
                for (int j = i; j < tmp.Count(); j++)
                {
                    if (tmp[j].startDateTime < tmp[i].startDateTime)
                    {
                        Event tmpEvent = tmp[j];
                        tmp[j] = tmp[i];
                        tmp[i] = tmpEvent;

                    }

                }

            }
            Display(tmp);
        }
      
        List<Event> eventList = new List<Event>();// Not Finished Events
        List<Event> Finished_Event = new List<Event>();//Finished Events

        public void Display(List<Event> tmp)//Show List to ListView
        {
            //Add List to List

            second_list.Items.Clear();
            foreach (var Event in tmp)
            {
                var row = new string[]
                {
                   null,
                    Event.name , 
                    Event.place ,
                    Event.startDateTime.ToShortDateString(),
                    Event.startDateTime.ToShortTimeString(),
                    Event.endDateTime.ToShortDateString(),
                    Event.endDateTime.ToShortTimeString()
                     
                };
                var lis = new ListViewItem(row);
                second_list.Items.Add(lis);
            }
        }

        //moving form.....
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form2(List<Event> Done, List<Event> NotDone)// Constructor Receive the List from form 1
        {
            InitializeComponent();
            eventList = Done;
            Finished_Event = NotDone;

        }

        public static void Drag_Form(IntPtr Handle, MouseEventArgs e) //Move form..
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }﻿
        
        private void moving_form(object sender, MouseEventArgs e)// Move FOrm ..
        {
            Drag_Form(Handle, e);
        }

        private void second_list_SelectedIndexChanged(object sender, EventArgs e)// when user Select or reSelect Item from ListView it Check if all items finished or not yet to move to another List if finished
        {
            if (radFinished.Checked) { } else { 
            for (int i = 0; i < eventList.Count; i++)
            {
                eventList[i].CheckDone();
                if (eventList[i].Done)
                {
                    Finished_Event.Add(eventList[i]);
                    eventList.RemoveAt(i);
                    second_list.Items[i].Remove();
                }
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)//Close 'x'
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)//minimize '-'
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)//BackArrow 
        {
            this.Close();
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

        private void rad_StartTime_CheckedChanged(object sender, EventArgs e)//Radio StartDate to sort item with Start Date
        {

           
            if (rad_StartTime.Checked)
            {
                 if (radFinished.Checked)
                       SortStartDate(Finished_Event);
                    else
                        SortStartDate(eventList);
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            rad_Name_CheckedChanged(sender, e);//Default Value
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)//Radio Upcoming to Show Upcoming Events 
        {
            if (radUpcoming.Checked)
            {
                if (rad_StartTime.Checked)
                    rad_StartTime_CheckedChanged(sender, e);
                else
                    rad_Name_CheckedChanged(sender, e);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)//Radio Finished to Display Finished Events
        {
            if (radFinished.Checked)
            {
                if (rad_StartTime.Checked)
                    rad_StartTime_CheckedChanged(sender, e);
                else
                    rad_Name_CheckedChanged(sender, e);
            }
        }

        private void rad_Name_CheckedChanged(object sender, EventArgs e)//Radio Name to Display the List Sorted By Name
        {
            
            if (rad_Name.Checked) {
                if (radFinished.Checked){
                    SortName(Finished_Event);    
                }

                else
                {
                    SortName(eventList);
                }
                
        }
 }

        private void bu_Search_Click(object sender, EventArgs e)//button Search 
        {
            if (radUpcoming.Checked)
            {
                int SearchIndex = Exist(eventList, txt_Search.Text);
                if (SearchIndex == -1)
                {
                    MessageBox.Show("Event Name Doesn't Exist");
                }
                else
                {
                    second_list.Items[SearchIndex].Selected = true;
                    second_list.Select();
                }
            }
            else
            {
                int SearchIndex = Exist(Finished_Event, txt_Search.Text);
                if (SearchIndex == -1)
                {
                    MessageBox.Show("Event Name Doesn't Exist");
                }
                else
                {
                    second_list.Items[SearchIndex].Selected = true;
                    second_list.Select();
                }
            }
            
        }

        private void movelabel(object sender, MouseEventArgs e)//Move Form
        {
            Drag_Form(Handle, e);
        }


    }
}
