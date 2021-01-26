using Case07.ViewModel;
using Microsoft.Xaml.Behaviors;
using System.Windows;

namespace Case07.View
{
    public abstract class ActionBase<T> : TargetedTriggerAction<DependencyObject>
    {
        protected override void Invoke(object parameter)
        {
            if (parameter.GetType() != typeof(T))
            {
                return;
            }

            InvokeEx((T)parameter);
        }

        protected abstract void InvokeEx(T parameter);
    }

    public class UserNotificationObjectAction : ActionBase<UserNotificationObject.NotifyErrorEventArgs>
    {
        protected override void InvokeEx(UserNotificationObject.NotifyErrorEventArgs parameter)
        {
            _ = MessageBox.Show(parameter.Message, Application.Current.MainWindow.Title, MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
