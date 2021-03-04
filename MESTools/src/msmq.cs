using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace MESTools.src
{
    public class msmq
    {
        public string QueueName { get; set; }

        public int MessagesInQueue { get; set; }

        public int MessagesinJournalQueue { get; internal set; }

        public string BytesinQueue { get; internal set; }

        public string BytesinJournalQueue { get; internal set; }

        public DateTime OldestArrivedTime { get; internal set; }

        public DateTime NewestArrivedTime { get; internal set; }
       
        public int MessagesInQueueLongerThan1Minutes { get; internal set; }
    }
}
