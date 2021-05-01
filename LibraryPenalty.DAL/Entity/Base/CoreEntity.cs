using LibraryPenalty.DAL.Entity.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using System.Security.Principal;
using System.Text;

namespace LibraryPenalty.DAL.Entity.Base
{
    public class CoreEntity : IEntity<Guid>
    {
        public CoreEntity()
        {
            this.Status = Status.Active;
            this.CreatedDate = DateTime.Now;
            this.CreatedAdUserName = WindowsIdentity.GetCurrent().Name;
            this.CreatedComputerName = Environment.MachineName;
            this.CreatedIP = CoreEntity.GetHostName();
            this.CreatedBy = "admin";
            this.ModifiedDate = DateTime.Now;
            this.ModifiedAdComputerName = WindowsIdentity.GetCurrent().Name;
            this.ModifiedComputerName = Environment.MachineName;
            this.ModifiedIP = CoreEntity.GetHostName();
            this.ModifiedBy = "admin";
        }



        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedComputerName { get; set; }
        public string CreatedIP { get; set; }
        public string CreatedAdUserName { get; set; }
        public string CreatedBy { get; set; }

        public DateTime ModifiedDate { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedIP { get; set; }
        public string ModifiedAdComputerName { get; set; }
        public string ModifiedBy { get; set; }
        internal static string GetHostName()
        {
            string ip = null;
            IPAddress[] localIps = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (var item in localIps)
            {
                if (item.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    ip = item.ToString();

                }
            }
            return ip;
        }
    }
}
