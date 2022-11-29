using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.Domain
{
    public class Usuario
    {
		public Usuario(string userName, string password)
		{
			UserName = userName;
			Password = password;
		}

		public int Id { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
	}
}
