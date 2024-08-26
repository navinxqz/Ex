using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AdminSystem.DataAccess
{
    public class Data
    {
        public DataGridView Grid<T>(DataGridView g, List<T> values)
        {
            if(values != null)
            {
                if (g.InvokeRequired)
                {
                    g.Invoke(new Action(() => { g.DataSource = values;
                    g.ClearSelection();
                    }));
                }
                else
                {
                    g.DataSource = values;
                    g.ClearSelection();
                }
            }return g;
        }
    }
}
