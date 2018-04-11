using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication9
{
    public  class Event
    {     public string name ;
          public string place ;
          public  DateTime startDateTime;
          public DateTime endDateTime;

          private TimeSpan Remind;
          public bool Done;
           public  Event() {
              
           }


           public bool CheckDone()//Compare Current Date and Time With EndDateTime and Set Done with value
           {
               
               
               int result = DateTime.Compare(endDateTime, DateTime.Now);
               if (result <= 0)
                   return Done = true;
               else
                   return Done = false;
           }
   
        public TimeSpan getRemind(){
                 return Remind = startDateTime - DateTime.Now;
                 
        }
            
      
 
    
}
    
}

  
