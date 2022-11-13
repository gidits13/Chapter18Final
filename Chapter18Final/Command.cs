using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter18Final
{
    abstract class Command
    {
        abstract public  Task Execute(string url);
    }
}
