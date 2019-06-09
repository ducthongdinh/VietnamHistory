using System;
using System.Collections.Generic;
using System.Text;

namespace VietnamHistory.Models
{
    public enum MenuItemType
    {
        LogIn,
        MainPage,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
