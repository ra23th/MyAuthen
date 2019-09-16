using Plugin.Settings.Abstractions;
using Plugin.Settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAuthen.Helpers
{
    class Seting
    {
        private static ISettings AppSettings => CrossSettings.Current;

        public static string UserName
        {
            get => AppSettings.GetValueOrDefault(nameof(UserName), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(UserName), value);
        }
        public static string Password
        {
            get => AppSettings.GetValueOrDefault(nameof(Password), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(Password), value);
        }
    }
}
