using ChatAppUI.MVVM.Model;
using System;
using System.Collections.ObjectModel;

namespace ChatAppUI.MVVM.ViewModel
{
    public class MainViewModel
    {
        public ObservableCollection<MessageModel> Messages { get; set; }
        public ObservableCollection<ContactModel> Contacts { get; set; }

        public MainViewModel()
        {
            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();

            Messages.Add(new MessageModel
            {
                userName = "Allison",
                userNameColor = "#409aff",
                imageSource = "https://i.imgur.com./yMWvLXd.png",
                message = "Test",
                time = DateTime.Now,
                isNativeOrigin = false,
                firstMessage = true
            });

            for (int i = 0; i < 3; i++)
            {
                Messages.Add(new MessageModel
                {
                    userName = "Allison",
                    userNameColor = "#409aff",
                    imageSource = "./Allison.png",
                    message = "Test",
                    time = DateTime.Now,
                    isNativeOrigin = false,
                    firstMessage = false
                });
            }
            for (int i = 0; i < 4; i++)
            {
                Messages.Add(new MessageModel
                {
                    userName = "Bunny",
                    userNameColor = "#409aff",
                    imageSource = "./Allison.png",
                    message = "Test",
                    time = DateTime.Now,
                    isNativeOrigin = true,
                    firstMessage = false
                });
            }

                Messages.Add(new MessageModel
                {
                    userName = "Bunny",
                    userNameColor = "#409aff",
                    imageSource = "./Allison.png",
                    message = "Last",
                    time = DateTime.Now,
                    isNativeOrigin = true
                });

            for (int i = 0; i < 5; i++)
            {
                Contacts.Add(new ContactModel
                {
                    userName = $"Allison {i}",
                    imageSource = "./Allison.png",
                    Messages = Messages
                });
            }
        }
    }
}
