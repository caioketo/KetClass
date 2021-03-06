﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KetClass.Data
{
    public partial interface IController<T> where T : BaseEntity
    {
        List<T> Index();
        T Details(int id);
        T Create(T model);
        void Edit(T model);
        bool Delete(int id);
        List<T> Filter(string text);
        List<DataGridViewColumn> Columns();
    }
}
