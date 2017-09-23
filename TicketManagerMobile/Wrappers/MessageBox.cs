﻿using System;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace TicketManagerMobile.Wrappers
{
    public static class MessageBox
    {
        public async static Task ShowAsync(string content)
        {
            await new MessageDialog(content).ShowAsync();
        }

        public async static Task ShowAsync(string content, string title)
        {
            await new MessageDialog(content, title).ShowAsync();
        }
    }
}
