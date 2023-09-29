using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ReferenceForm.Classes
{
    class User
    {
        public int ReferenceId { get; set; }

        public string Identification { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Gender { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string CreatedDate { get; set; } = DateTime.Now.ToShortDateString();

        public string ModifiedDate { get; set; } = string.Empty;

        public string DeletedDate { get; set; } = string.Empty;


        public override string ToString()
        {
            return
                $"Reference Id: {ReferenceId} \n" +
                $"Identification: {Identification} \n" +
                $"Name: {Name} \n" +
                $"Last Name: {LastName} \n" +
                $"Gender: {Gender} \n" +
                $"Phone: {Phone} \n" +
                $"Email: {Email} \n" +
                $"Address: {Address} \n" +
                $"Created Date: {CreatedDate} \n" +
                $"Modified Date: {ModifiedDate} \n" +
                $"Deleted Date: {DeletedDate} \n";
        }

    }
}
