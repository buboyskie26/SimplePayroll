using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePayroll
{
    public interface IRole
    {
        string[] GetRole(string role);
    }
}
