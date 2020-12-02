using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ComboBoxTest.Shared
{
    public class MainViewModel
    {
        public Dictionary<string, string> Items { get; }

        public string CurrentKey { get; set; }

        public MainViewModel()
        {
            Items = new Dictionary<string, string>();
            Items.Add("Test1Key", "Test1");
            Items.Add("Test2Key", "Test2");
            Items.Add("Test3Key", "Test3");

            CurrentKey = "Test2Key";
        }
    }
}
